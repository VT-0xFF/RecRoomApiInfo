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
using Microsoft.CodeAnalysis;
using Mono.Math;
using RecNet;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3CBB260", Offset = "0x3CBA660", VA = "0x183CBB260")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x778380", Offset = "0x777780", VA = "0x180778380")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xFCBE90", Offset = "0xFCB290", VA = "0x180FCBE90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MPEKHGGFAHD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3253D30", Offset = "0x3253130", VA = "0x183253D30")]
	public MPEKHGGFAHD(string CIBBLLOHCGM, Exception IOEKPCFCNII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class JGIEKGEPBHB : KPNNBHHJKAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct KNNINCEIGKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MFCGKHHIAKN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TaskAwaiter<global::CFLCFDIDDPJ<MFCGKHHIAKN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3C51380", Offset = "0x3C50780", VA = "0x183C51380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3C51560", Offset = "0x3C50960", VA = "0x183C51560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GHNGMHGFKFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<IKGAMFFBJBK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<IKGAMFFBJBK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C490", Offset = "0x3C4B890", VA = "0x183C4C490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C650", Offset = "0x3C4BA50", VA = "0x183C4C650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	[UnityEngine.Scripting.Preserve]
	public JGIEKGEPBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x324BD30", Offset = "0x324B130", VA = "0x18324BD30", Slot = "4")]
	[AsyncStateMachine(typeof(KNNINCEIGKL))]
	public Task<IReadOnlyList<MFCGKHHIAKN>> GBKODFHOCHI(long COLNHBBPCAP, long JPKIIMPIPPD, [Optional] CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x324BE80", Offset = "0x324B280", VA = "0x18324BE80", Slot = "5")]
	[AsyncStateMachine(typeof(GHNGMHGFKFP))]
	public Task<IReadOnlyList<IKGAMFFBJBK>> JDFAMLOHGGI(IReadOnlyList<int> HFBAJMNEFOF, [Optional] CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PEOFKAOGBAF : IEquatable<PEOFKAOGBAF>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int LBLHGGBPIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	IKGAMFFBJBK LICKADBCHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime PJHGJBKOLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GNDMPBIHMPA? CDEDIPLDHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GEPPHDJNNJL? JAAEPPOJKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	PMLGOGNDJGL KBBMCIAMOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<EKKOLLPPNIM> IDPCKPKICKA();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum PMLGOGNDJGL
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KPNNBHHJKAK
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<MFCGKHHIAKN>> GBKODFHOCHI(long COLNHBBPCAP, long JPKIIMPIPPD, [Optional] CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<IKGAMFFBJBK>> JDFAMLOHGGI(IReadOnlyList<int> HFBAJMNEFOF, [Optional] CancellationToken MJMCKAGGCOI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KOKNHMBIKPL
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class BGPPBOLFPHA : PEOFKAOGBAF, IEquatable<PEOFKAOGBAF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct IFIJOANMBFI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<EKKOLLPPNIM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public BGPPBOLFPHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private GALFFEGNLPK <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<JIAGHJHJMHD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<EKKOLLPPNIM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x482B7E0", Offset = "0x482ABE0", VA = "0x18482B7E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x482BC70", Offset = "0x482B070", VA = "0x18482BC70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly MFCGKHHIAKN BJEEPAMLNMO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int LBLHGGBPIJL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x705BA0", Offset = "0x704FA0", VA = "0x180705BA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IKGAMFFBJBK LICKADBCHPH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime OLCHKBFKECE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1D5FF30", Offset = "0x1D5F330", VA = "0x181D5FF30", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GNDMPBIHMPA? CDEDIPLDHBH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xE94110", Offset = "0xE93510", VA = "0x180E94110", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public GEPPHDJNNJL? JAAEPPOJKLP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xE940D0", Offset = "0xE934D0", VA = "0x180E940D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public PMLGOGNDJGL KBBMCIAMOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6C6940", Offset = "0x6C5D40", VA = "0x1806C6940", Slot = "10")]
			get
			{
				return default(PMLGOGNDJGL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3C43FA0", Offset = "0x3C433A0", VA = "0x183C43FA0", Slot = "9")]
		[AsyncStateMachine(typeof(IFIJOANMBFI))]
		public Task<EKKOLLPPNIM> IDPCKPKICKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3C44110", Offset = "0x3C43510", VA = "0x183C44110")]
		public BGPPBOLFPHA(int LDGEGJEMBKM, IKGAMFFBJBK JJOGGPBOBFM, MFCGKHHIAKN BJEEPAMLNMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3C43E80", Offset = "0x3C43280", VA = "0x183C43E80", Slot = "11")]
		public bool Equals(PEOFKAOGBAF FJLHJLAMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3C43DE0", Offset = "0x3C431E0", VA = "0x183C43DE0", Slot = "0")]
		public override bool Equals(object JGHFLANLLNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3C440D0", Offset = "0x3C434D0", VA = "0x183C440D0")]
		private bool JMMDDKCOLJC(BGPPBOLFPHA FJLHJLAMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3C43F10", Offset = "0x3C43310", VA = "0x183C43F10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class PJJDKJBAIBB : PEOFKAOGBAF, IEquatable<PEOFKAOGBAF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct PEOOBHMHOIN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<EKKOLLPPNIM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public PJJDKJBAIBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<EKKOLLPPNIM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x48302D0", Offset = "0x482F6D0", VA = "0x1848302D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x4830510", Offset = "0x482F910", VA = "0x184830510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly AMJALDODKON LJAPEKJPGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GNDMPBIHMPA FKEKKHHLPPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly GEPPHDJNNJL IIAPOIICIAG;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int LBLHGGBPIJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3C58590", Offset = "0x3C57990", VA = "0x183C58590", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IKGAMFFBJBK LICKADBCHPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3C58410", Offset = "0x3C57810", VA = "0x183C58410", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime OLCHKBFKECE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3C58540", Offset = "0x3C57940", VA = "0x183C58540", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public GNDMPBIHMPA? CDEDIPLDHBH
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x3C587B0", Offset = "0x3C57BB0", VA = "0x183C587B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public GEPPHDJNNJL? JAAEPPOJKLP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x3C58700", Offset = "0x3C57B00", VA = "0x183C58700", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public PMLGOGNDJGL KBBMCIAMOMC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x85F6D0", Offset = "0x85EAD0", VA = "0x18085F6D0", Slot = "10")]
			get
			{
				return default(PMLGOGNDJGL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB17B40", Offset = "0xB16F40", VA = "0x180B17B40")]
		public PJJDKJBAIBB(AMJALDODKON KGEMKNACOAL, GNDMPBIHMPA CCMMKHKNFAC, GEPPHDJNNJL JJKMALDKMDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3C585E0", Offset = "0x3C579E0", VA = "0x183C585E0", Slot = "9")]
		[AsyncStateMachine(typeof(PEOOBHMHOIN))]
		public Task<EKKOLLPPNIM> IDPCKPKICKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C58370", Offset = "0x3C57770", VA = "0x183C58370", Slot = "11")]
		public bool Equals(PEOFKAOGBAF FJLHJLAMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3C582C0", Offset = "0x3C576C0", VA = "0x183C582C0", Slot = "0")]
		public override bool Equals(object JGHFLANLLNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C58750", Offset = "0x3C57B50", VA = "0x183C58750")]
		private bool JMMDDKCOLJC(PJJDKJBAIBB FJLHJLAMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3C584B0", Offset = "0x3C578B0", VA = "0x183C584B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class FFDBCPDBIIB : PEOFKAOGBAF, IEquatable<PEOFKAOGBAF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct GBIIPLMEADL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<EKKOLLPPNIM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<EKKOLLPPNIM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4829E60", Offset = "0x4829260", VA = "0x184829E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x482A040", Offset = "0x4829440", VA = "0x18482A040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly IKGAMFFBJBK NLNODBCGPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly GNDMPBIHMPA FKEKKHHLPPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly GEPPHDJNNJL IIAPOIICIAG;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int LBLHGGBPIJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x3C4AF50", Offset = "0x3C4A350", VA = "0x183C4AF50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public IKGAMFFBJBK LICKADBCHPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime OLCHKBFKECE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public GNDMPBIHMPA? CDEDIPLDHBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x3C4B210", Offset = "0x3C4A610", VA = "0x183C4B210", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public GEPPHDJNNJL? JAAEPPOJKLP
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x3C4B0C0", Offset = "0x3C4A4C0", VA = "0x183C4B0C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public PMLGOGNDJGL KBBMCIAMOMC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "10")]
			get
			{
				return default(PMLGOGNDJGL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB17B40", Offset = "0xB16F40", VA = "0x180B17B40")]
		public FFDBCPDBIIB(IKGAMFFBJBK JJOGGPBOBFM, GNDMPBIHMPA CCMMKHKNFAC, GEPPHDJNNJL JJKMALDKMDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3C4AFD0", Offset = "0x3C4A3D0", VA = "0x183C4AFD0", Slot = "9")]
		[AsyncStateMachine(typeof(GBIIPLMEADL))]
		public Task<EKKOLLPPNIM> IDPCKPKICKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C4AD60", Offset = "0x3C4A160", VA = "0x183C4AD60", Slot = "11")]
		public bool Equals(PEOFKAOGBAF FJLHJLAMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3C4AC10", Offset = "0x3C4A010", VA = "0x183C4AC10", Slot = "0")]
		public override bool Equals(object JGHFLANLLNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3C4AEA0", Offset = "0x3C4A2A0", VA = "0x183C4AEA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B110", Offset = "0x3C4A510", VA = "0x183C4B110")]
		private bool JMMDDKCOLJC(FFDBCPDBIIB FJLHJLAMLMA)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct PDHLDDPGCLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<PEOFKAOGBAF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public KOKNHMBIKPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<MFCGKHHIAKN> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<MFCGKHHIAKN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, IKGAMFFBJBK account, MFCGKHHIAKN roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C558F0", Offset = "0x3C54CF0", VA = "0x183C558F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3C56380", Offset = "0x3C55780", VA = "0x183C56380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct LLBMNFFPECK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, IKGAMFFBJBK account, MFCGKHHIAKN roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<MFCGKHHIAKN> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public KOKNHMBIKPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<IKGAMFFBJBK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3C522A0", Offset = "0x3C516A0", VA = "0x183C522A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3C52C20", Offset = "0x3C52020", VA = "0x183C52C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FGKFBCOODAE KBINADEIPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KPNNBHHJKAK ONIIMLGGOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CIIIIGJIDFC NKEKDILAEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly global::NGPBMLMCGED<(long, long), IReadOnlyList<MFCGKHHIAKN>> DHMFAPDLLDM;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x324C730", Offset = "0x324BB30", VA = "0x18324C730")]
	[UnityEngine.Scripting.Preserve]
	public KOKNHMBIKPL([ANGFGGDOPHE(null)] KPNNBHHJKAK KFDDKCFJLHJ, [ANGFGGDOPHE(null)] CIIIIGJIDFC LJCFBNOEIAB, [ANGFGGDOPHE(null)] FGKFBCOODAE OACIHEBGKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x324C2F0", Offset = "0x324B6F0", VA = "0x18324C2F0")]
	[AsyncStateMachine(typeof(PDHLDDPGCLL))]
	public Task<IList<PEOFKAOGBAF>> ACGKEHMODPM(long COLNHBBPCAP, long BPIAGBMFLPM, bool HPPLPEHCDBK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x324C580", Offset = "0x324B980", VA = "0x18324C580")]
	private bool KDAPKJIHGGE(DateTime? MCOEFJPNDEJ, long COLNHBBPCAP, long BPIAGBMFLPM, out AMJALDODKON LFOFFPBKHMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x324C440", Offset = "0x324B840", VA = "0x18324C440")]
	[AsyncStateMachine(typeof(LLBMNFFPECK))]
	private Task<IReadOnlyList<(int, IKGAMFFBJBK, MFCGKHHIAKN)>> JICNANPHOJC(IReadOnlyList<MFCGKHHIAKN> NLIOPACJONE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CIIIIGJIDFC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<AMJALDODKON> FIHIENDPGIK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCGJGGJBKHD(long COLNHBBPCAP, long BPIAGBMFLPM, OMDMCGFKGDM OCPBEPAJLMP, OCGBNMGMCOF PAABLILJLLA);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OBDAKNBAPNL(long COLNHBBPCAP, long BPIAGBMFLPM, out AMJALDODKON LFOFFPBKHMJ);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IKGHLIPCLFF(long COLNHBBPCAP, long BPIAGBMFLPM, OCGBNMGMCOF PAABLILJLLA, out AMJALDODKON LFOFFPBKHMJ);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KJGIMCDMHFI(long COLNHBBPCAP, long BPIAGBMFLPM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface MKIJKNGGGEN : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OFJIAJAACLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task ILACKGMBJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMBLAENHMJH(Task IGPMHCEBGGP, string DCONDLIMEPG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface KLOMKOPCGBL : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EKKOLLPPNIM> MGIEBEPIEGP(AMJALDODKON LFOFFPBKHMJ);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GLBJGAHJEHH(CancellationToken MJMCKAGGCOI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface JBNFGNMGBPF : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CPHIJNHNMFK IGKCECBAIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCIALHFNDMD();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MEPIHBPHANC();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface PGKAMNNFOKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface GKAHBEHBJIH
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan AIMGIIDHOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan DMAHLEAPIGO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan JNIFPHMGDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan FGNJGEMLBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool EKBNEICJNLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PBJFBHBDAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool CNKDIFMNADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum KPNHLKPHAGN
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum JGOHEHCNFEL
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct FKHOLCDLGLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long IHMFAKAKFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long JPKIIMPIPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly KPNHLKPHAGN BKGBGEHNCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception HEKNDBCOFEA;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3241BF0", Offset = "0x3240FF0", VA = "0x183241BF0")]
	public FKHOLCDLGLO(long IHMFAKAKFLN, long JPKIIMPIPPD, KPNHLKPHAGN BKGBGEHNCAE, [CanBeNull] Exception HEKNDBCOFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3241BA0", Offset = "0x3240FA0", VA = "0x183241BA0")]
	public static FKHOLCDLGLO JNKDJNOGMIC(OAILMIHJFAK IKCDGDCGBBI, KPNHLKPHAGN BKGBGEHNCAE, [Optional] Exception HEKNDBCOFEA)
	{
		return default(FKHOLCDLGLO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void HHOHNACIAAP(FKHOLCDLGLO MILONKEOIFA);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface MJNBCFMHIHE : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action EKHKEMKCLKH;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event HHOHNACIAAP HLFIAGPKFHL;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HHOHNACIAAP FDBPHBMMJPM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event HHOHNACIAAP LPOBDKLPEIB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<JGOHEHCNFEL, bool> BGLCHEDKLOK;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MPFAEBOKOGL();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JJKFDBLFJBN(FKHOLCDLGLO MILONKEOIFA);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CJFLKKIIOCD(FKHOLCDLGLO MILONKEOIFA);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GMLBLDJEOKL(FKHOLCDLGLO MILONKEOIFA);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ELPFLLDAEFL(JGOHEHCNFEL OOIKEALFDCH, bool CCMACNPGBGB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface OBFFLECOGHD : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NMJNJFODPMJ();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFEEEBJDOBD();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FIGPHFJKAAA();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate Task NDGBMEHBGKE(OCLGLHHAFAO FOGLEECNIFC, CancellationToken JCHAGIDHJIB);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface NLPLHFNOPIN : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool MECGMNAHNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EOMCMAHKGJG(NDGBMEHBGKE NCLELDJHNLK);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface HFAMPDNHCGH : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TaskStatus HKINNFLEDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HKLKLODMFIG(OAILMIHJFAK KEDDCKBKHLI, KFHPPEDHCNA HAFOKFMHBON, CancellationToken JFEIMHDODID);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class MIBKPGOGEGN
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x32535C0", Offset = "0x32529C0", VA = "0x1832535C0")]
	public static bool MKPAFNFAFAH(this HFAMPDNHCGH CNHKIBBKMLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface GOLPDNFBDPM : GALFFEGNLPK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CancellationToken EFKEJJIIEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	BHKHBEKDAPI CIFMMJJOMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	NKKMLDCLAFH FCOJJOEHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	DOAKALKGBLF KACKMELPFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	EELDLGKOJPM PBGLAENKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	KHAALFBNGAL MEJNIMKHLEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MEDPDNCDEGC IDONBIEAIAE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	JFCDMGDONIF JKDDPMLIHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	PAJJLIFLOGC JADAELMMIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	MKIJKNGGGEN AEONEOEFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	KLOMKOPCGBL PKKHKCCEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	MJNBCFMHIHE MLEOKMOCBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	OBFFLECOGHD HPCNBPAJOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	HFAMPDNHCGH EEPDOKLHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	NLPLHFNOPIN JDOAGKEEPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IIGBIBLGCBF LOOBFBELPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MEAIHPHJEFK AGJFEDAOKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	HPGDJAJILOJ HBKLHEOALKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	AADLLMCLBHB DAPENLCIAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HEGGCKEGGLN BHGFOAFKAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	BBCAJKHGDAF ONGPGKKABGH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MIDAHBJNNBL HLLPFFAKGIF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	MECBEAOLDHP GKGHJABFGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CDMJDHCPJDD NJLANJDLFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	DGDNBGPEIIB FJDENHDCFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	MAOOBHKBEAI KAKFEHMCGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	JBNFGNMGBPF POJEKKFAJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	GKAHBEHBJIH DDFFKOOJGAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	ECPIIGAIEKM PBPJMJBKHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	CIIIIGJIDFC AAMMLCNCBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void DJCOHNLLGCK(KFHPPEDHCNA CAHDIDENEGC);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface IIGBIBLGCBF : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AAFDOAPGFME BKCAAEBNAMB(Guid JLOMHEMDNBP);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAMANBAONBG(Guid JLOMHEMDNBP);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OIIKIEMDIED(Guid JLOMHEMDNBP, Task OMLFMKOMCDI);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AFMEPLOEJNA(Guid JLOMHEMDNBP, EKKOLLPPNIM AHHOEKADPMM);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FIGPHFJKAAA(Guid JLOMHEMDNBP);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(EKKOLLPPNIM, Task)> JCENADENMON(Guid JLOMHEMDNBP);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface MEAIHPHJEFK : PGKAMNNFOKD, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface HPGDJAJILOJ : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAFIIJLGCBO(KNOPHICLNED CIBBLLOHCGM);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKMEMDLPCBK(KNOPHICLNED CIBBLLOHCGM);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OBGEECKNGII> OFBADADBGOP(CancellationToken JBOBFFCKODA);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public delegate EKKOLLPPNIM PJEJOBEGFKB(JEHHKLECEGB DBNCGPLMAHF, OBGEECKNGII LLGLGGINHDF);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface AADLLMCLBHB : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AAFDOAPGFME HAPNGECLAIG(KNOPHICLNED OPLCKDLCBJH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJNKLLBLKPI(Guid JLOMHEMDNBP, Task OMLFMKOMCDI);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface HEGGCKEGGLN : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EKKOLLPPNIM> BHGFOAFKAMF(KNOPHICLNED MANBGEKEGNP);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface BBCAJKHGDAF : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CCLMJIMCJFD> LKOHBKNLNDA(MIPBMMJKKCH KNJJIICJOLE, OAILMIHJFAK KEDDCKBKHLI, CancellationToken MJMCKAGGCOI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface MECBEAOLDHP : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EKKOLLPPNIM HHJGOICGJGB(JEHHKLECEGB DBNCGPLMAHF);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FNMBLDBDJOM(string NMGICKMLDFI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface MIDAHBJNNBL : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KNOPHICLNED> BLLGIMBHLIK(KNOPHICLNED PJJLMKEBMEE, NCNPBEKEBJI PMFJNBHFHFC, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KNOPHICLNED> NNDPBNFPNIP(CancellationToken MJMCKAGGCOI, NCNPBEKEBJI PMFJNBHFHFC);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FIDGNAKNAGA PGBODHOEMED(FPOEHJGJEFB ENFOGPPAFKK, MIPBMMJKKCH KNJJIICJOLE);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FIDGNAKNAGA LOMEJCENEAC(FPOEHJGJEFB ENFOGPPAFKK, MIPBMMJKKCH KNJJIICJOLE);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface CDMJDHCPJDD : PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EKKOLLPPNIM NJBFPBCONNL(JEHHKLECEGB DBNCGPLMAHF, OBGEECKNGII LLGLGGINHDF);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EKKOLLPPNIM KIHMIBCPFBB(JEHHKLECEGB PBPJIKMNMJH);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EKKOLLPPNIM KCDMFNEKBCC(JEHHKLECEGB PBPJIKMNMJH);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface DGDNBGPEIIB
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKOAHODNAFP(KCEOPGFPCFN JAGLKDHCLEM);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLEFFGKBOIH(KCEOPGFPCFN JAGLKDHCLEM);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FENFLACHKEN(KCEOPGFPCFN JAGLKDHCLEM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NBFHHFOGIOM(KCEOPGFPCFN JAGLKDHCLEM);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class KCEOPGFPCFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly OAILMIHJFAK HNLAPDFLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> NGDNKKHDENG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public global::PADKJAANMNM<string> IGAHDLGOFON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x762090", VA = "0x180762C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
	public KCEOPGFPCFN(OAILMIHJFAK CNMCCMNNBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x324C1A0", Offset = "0x324B5A0", VA = "0x18324C1A0")]
	public KCEOPGFPCFN ELHMPBBFFFL(string NPBDKCONLNC, string FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x324C270", Offset = "0x324B670", VA = "0x18324C270")]
	public bool KPIHOHLAABA(out IEnumerable<KeyValuePair<string, string>> ACPMBEFCNOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x94A140", Offset = "0x949540", VA = "0x18094A140")]
	public KCEOPGFPCFN FGDKFPNADOD(global::PADKJAANMNM<string> HMHNEOCJGLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface ECPIIGAIEKM
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool CCFJCJBDCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string MMHLGLGBAAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PCOFDKMCHCG();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LOIMFBCEIGF EDAIAIAOOOP(long IPDMILNMCPD);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::JJDHKAEFBFK<LECBPDHMHPK, OCDIJFCGFPK> FFOACMHONFP(long IPDMILNMCPD);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::JJDHKAEFBFK<LECBPDHMHPK, LNPAGJDMHMD> NDHJPOFLFPP(long IPDMILNMCPD);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::JJDHKAEFBFK<long, DIGMNKOOPIB> NEIHCLMHJAO();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> HDMBNHBMPPI(byte[] GIENOADFBID, byte[] GPCAHMAJMLI, CancellationToken MJMCKAGGCOI);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface GALFFEGNLPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool MKPAFNFAFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool DBLJMFDDFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Task PLGNELGHBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	KFHPPEDHCNA FNHBFIFFNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action EKHKEMKCLKH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event HHOHNACIAAP HLFIAGPKFHL;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event HHOHNACIAAP FDBPHBMMJPM;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event HHOHNACIAAP LPOBDKLPEIB;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<JGOHEHCNFEL, bool> BGLCHEDKLOK;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OFEEEBJDOBD();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LHFPHAFPDJH DOHLFLDLDIN();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JGBBPIJGKMA LCCJMPOAJGC();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<EKKOLLPPNIM> MGIEBEPIEGP(AMJALDODKON KGEMKNACOAL);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task GLBJGAHJEHH(CancellationToken MJMCKAGGCOI);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KHAALFBNGAL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool PKDIEDEMNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string EDPOMLIBGEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEBHEHMJCNO(Scene FKEADLNIGEO);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task AOLJJGNOFEE(NGKGLMOPHKN KDBIEOAAICN, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PAFNMLGKDKL();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EELDLGKOJPM
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	KHKJJLCHIGJ EACHPFKLBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int LMGCOCBFJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool DNAFKGBKCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool BAEHEGOBCGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool AIHBJNDCEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool GGFMNBHHBMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool KKPEIJDGKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	JEHHKLECEGB JLDBICMPKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool IAJIEOMMDKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BHKHBEKDAPI DLBMACPBGKB(BHKHBEKDAPI DPFIAKKFGJG);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBACEKHKNCN(BHKHBEKDAPI CBOODPBIPLK);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task CLAPOINEOON(MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task OEGLNHEGELK(CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task GCGLABOCNGP(AODFFPEIGEF DFCEDJEBLNA, [Optional] CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JDMKPFBPDNH(float HJOFIKBMGND);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GNNNDPIKKGN(string ILEBAMKAJND);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<JLIBGKFOCHA> CBJIBPAKHFC();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable NPLDLBDPLLG(object OEGBAMNPENI, JLIBGKFOCHA OEEGLLLODJM);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OCDIJFCGFPK PKFGLHDMFAN();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EPJKONNJFHA(int POCEJBKICIH);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task JNGOACKIMIG();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AMMPKPNEDNB();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool FBGOFMBLGBG();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task JEBKKIAKGAB(CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task NLIANINOKOL(CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<LMLBDNGHFLE> MGJMKLGLOFM(DateTime IGFIDEDJNEN, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> CGEGGACEFEA(CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FCLECOMLCMM();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "25")]
	FPBBPFNELCM NCMECKNMMAC(HLBKDPDMAPP CCHGFKGHKDC, LNPAGJDMHMD INDBPANDAMO, IEnumerable<PersistenceView> JAMKHPGLIAO, ref JAMCKBOEJMM MGCIHOBCCIO);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void POGEOBHJPKH(LNPAGJDMHMD INDBPANDAMO);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BKNFNPFFLIG(GNAMCHKIIOD FCEBLLIOAFD, in FPBBPFNELCM IGALNDDKACB);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task LCJHGGDFHLJ(LNPAGJDMHMD IHGOPHBGHNK, bool FLHOOJKKNGM, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task ILEFILEDFBN(CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void ILJHNAIFGHA(long COLNHBBPCAP, long JPKIIMPIPPD, JIAGHJHJMHD MDHLICGIKHL, OMDMCGFKGDM OCPBEPAJLMP);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void NFADKFBMFHH(long COLNHBBPCAP, long JPKIIMPIPPD);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void NEAGIIAMHHC(PersistenceView KIHLBGFMEMD);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool PJKFEIKKFFO(PersistenceView FNDIGAAAAOD);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool JPGPGJHADKI(GNAMCHKIIOD FCEBLLIOAFD, KGPBGDOCNHG KPHKDFLEHCN, out LOHOGOJBAPD LMLAPGPDEEI);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task JCOPPJPAOGK(CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void EILIFNCECND();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable PNLMMLGNDLL();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void MNMMGABEIJC(LNPAGJDMHMD IHGOPHBGHNK, KGPBGDOCNHG KPHKDFLEHCN);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> PHHFEHIGAAD(NKKMLDCLAFH CMHEIEGMDHP, CancellationToken MJMCKAGGCOI, MIPBMMJKKCH KNJJIICJOLE);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void CLMOOCHEOHN(CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<HEDEMNPEDMH> DBAGMJPJBLE(OPPGOAGNLAJ PJJLMKEBMEE);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<FAMHFHLIEMJ> KKJLBDOGKHG(string KFNFEIADKID, long COLNHBBPCAP, long JPKIIMPIPPD, string BLDADOPGBGF, ALMHAOJMCOA.MOMFCPDMDNM FOGLEECNIFC, ALMHAOJMCOA.MOMFCPDMDNM GPCAHMAJMLI, int GKEHNDPJBOF);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<JIAGHJHJMHD> PEJLFKBFDLL(long COLNHBBPCAP, bool HHNGKKMNBBJ, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool NEHIEBJAGOI();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool KJAHPKGFJCP();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool HNGAOOBPOLC(IEnumerable<LOHOGOJBAPD> DOKCIELJBGF);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void CGAFNPDMCPM(List<GameObject> MCEJILCDHAH);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float EMEAIECEENG();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool KDKDGFLBLCD(string DFHBGAHLFPK, out Scene LKJCHBJAPLC);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> EIPBKMEKEFI(string DFHBGAHLFPK, LoadSceneMode DAFKGOFGGPI, bool BDMEDJAANHE, MIPBMMJKKCH HMHNEOCJGLO);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void DHPCELJCBEP();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool DENIGKLOGJD(ByteString LFBMPCLHCOB);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void KCDNBAPEHOJ();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void INODBIFMDHK();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void BCIIINEHLDC(OAILMIHJFAK NPJKDKEHGJC);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task PHDLAKGENOP(MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task ALHHFACEIHN(MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void HEAAINJEPGL();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "62")]
	IDisposable CLDEGGBOHLB();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "63")]
	DIIBBGOJBHM LANKLGCFEFI();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface DIIBBGOJBHM
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HGOOCNIFBEF(CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MPPPKKJKHON(CancellationToken MJMCKAGGCOI);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FPBBPFNELCM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> NHAOOPAHLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IDisposable ONFAGBILMOC;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3243860", Offset = "0x3242C60", VA = "0x183243860", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum LMLBDNGHFLE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KHKJJLCHIGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	OAILMIHJFAK GIOJNHONMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	JIAGHJHJMHD LFIKIBAJNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	CLNOPKLDMLF BOMIDKGEBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool CAAPILLDCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool NEGAHIAANAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int LMGCOCBFJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action OJELHBDJALF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<int> BGCDPJAALDO;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HDHFMDJCLCF();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.NPKOLENFHIH> IFDNEMCKLDJ();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task PHJMPJLNPFD();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "13")]
	(OAILMIHJFAK, KFHPPEDHCNA) BEEJGGGKFLJ();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NFAEEPLGGPJ OMBPIIDPMLK();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KAIMJMADIDB(long IPDMILNMCPD);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MAOOBHKBEAI
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CIGJCHPOMOH(out IEnumerable<int> JFGAHMPONMN);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FINCNMLNOMD(ANOHCNMGJIP JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGOAHFDFBJB(ANOHCNMGJIP JCHAGIDHJIB);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface MPBIOFJMFJP
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LJLEDNDMCJM(EKKOLLPPNIM EBCKEMJOFAC);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EKAFNCKDMBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODLFFMGAIGG(NAMHCFFGEIE.MBMCAJHJFHH LOJCMADPDCK);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBKEIGKACBB(NAMHCFFGEIE.MBMCAJHJFHH LOJCMADPDCK);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MEDPDNCDEGC : EKAFNCKDMBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EKKOLLPPNIM JGDGMKFPANH(JEHHKLECEGB PBPJIKMNMJH);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface JFCDMGDONIF : EKAFNCKDMBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EKKOLLPPNIM HHJGOICGJGB(JEHHKLECEGB NKBGOBOMGOG);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface LOIMFBCEIGF
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::DPAEKNFIIFN<NGKGLMOPHKN, GKAEBCMEFAL>> FICCDGKEAFA(string BLDADOPGBGF, long IPDMILNMCPD, HEEMOONFCAF.GCONECGKFJD FLINFOKJJJH, CancellationToken MJMCKAGGCOI);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface JJDHKAEFBFK<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::DPAEKNFIIFN<byte[], GKAEBCMEFAL>> NLOACFNIBJI(TGetDataArg DEMGJAEGHAE, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::DPAEKNFIIFN<global::BMEALCICMDB<TData>, GKAEBCMEFAL> NHNFGHKDEPE(byte[] MPEBBGJJODN);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class FPHMHGEHKLH : GOLPDNFBDPM, GALFFEGNLPK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct BIBODHDGAPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<EKKOLLPPNIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public FPHMHGEHKLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AMJALDODKON autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<EKKOLLPPNIM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE110", Offset = "0x3CAD510", VA = "0x183CAE110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE3B0", Offset = "0x3CAD7B0", VA = "0x183CAE3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct OFKEFCFAMHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public FPHMHGEHKLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3CBEC40", Offset = "0x3CBE040", VA = "0x183CBEC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JEJMPOLBFPA : IEnumerable<PGKAMNNFOKD>, IEnumerable, IEnumerator<PGKAMNNFOKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private PGKAMNNFOKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public FPHMHGEHKLH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private PGKAMNNFOKD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
		[DebuggerHidden]
		public JEJMPOLBFPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4A10", Offset = "0x3CB3E10", VA = "0x183CB4A10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4E50", Offset = "0x3CB4250", VA = "0x183CB4E50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4DB0", Offset = "0x3CB41B0", VA = "0x183CB4DB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PGKAMNNFOKD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4DB0", Offset = "0x3CB41B0", VA = "0x183CB4DB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource GGPGNCKFJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly BHKHBEKDAPI CBOODPBIPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private MMCMKNGMJAA BACBOIBOPLB;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public NKKMLDCLAFH FCOJJOEHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6E1530", Offset = "0x6E0930", VA = "0x1806E1530", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x77DEE0", Offset = "0x77D2E0", VA = "0x18077DEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public DOAKALKGBLF KACKMELPFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6E27A0", Offset = "0x6E1BA0", VA = "0x1806E27A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x77DF30", Offset = "0x77D330", VA = "0x18077DF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public EELDLGKOJPM PBGLAENKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6E0", Offset = "0x6C9AE0", VA = "0x1806CA6E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x875110", Offset = "0x874510", VA = "0x180875110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public KHAALFBNGAL MEJNIMKHLEB
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x845B30", Offset = "0x844F30", VA = "0x180845B30", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8C0", Offset = "0x7CDCC0", VA = "0x1807CE8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public MEDPDNCDEGC IDONBIEAIAE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x845B40", Offset = "0x844F40", VA = "0x180845B40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xBD0150", Offset = "0xBCF550", VA = "0x180BD0150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public JFCDMGDONIF JKDDPMLIHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x75A820", Offset = "0x759C20", VA = "0x18075A820", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x928C10", Offset = "0x928010", VA = "0x180928C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public PAJJLIFLOGC JADAELMMIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7EE290", Offset = "0x7ED690", VA = "0x1807EE290", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x938150", Offset = "0x937550", VA = "0x180938150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public MKIJKNGGGEN AEONEOEFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8AC630", Offset = "0x8ABA30", VA = "0x1808AC630", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8AC640", Offset = "0x8ABA40", VA = "0x1808AC640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public KLOMKOPCGBL PKKHKCCEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8201E0", Offset = "0x81F5E0", VA = "0x1808201E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8AC070", Offset = "0x8AB470", VA = "0x1808AC070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public MJNBCFMHIHE MLEOKMOCBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x884180", Offset = "0x883580", VA = "0x180884180", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xD29410", Offset = "0xD28810", VA = "0x180D29410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public OBFFLECOGHD HPCNBPAJOFK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x795BC0", Offset = "0x794FC0", VA = "0x180795BC0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x795C80", Offset = "0x795080", VA = "0x180795C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public HFAMPDNHCGH EEPDOKLHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x845B50", Offset = "0x844F50", VA = "0x180845B50", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x938140", Offset = "0x937540", VA = "0x180938140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public NLPLHFNOPIN JDOAGKEEPOE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x78ADA0", Offset = "0x78A1A0", VA = "0x18078ADA0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x78B000", Offset = "0x78A400", VA = "0x18078B000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public IIGBIBLGCBF LOOBFBELPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x78AE60", Offset = "0x78A260", VA = "0x18078AE60", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x78B010", Offset = "0x78A410", VA = "0x18078B010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public MEAIHPHJEFK AGJFEDAOKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x78AD20", Offset = "0x78A120", VA = "0x18078AD20", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x78AFF0", Offset = "0x78A3F0", VA = "0x18078AFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public HPGDJAJILOJ HBKLHEOALKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9E0", Offset = "0x7C9DE0", VA = "0x1807CA9E0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7CAA30", Offset = "0x7C9E30", VA = "0x1807CAA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public AADLLMCLBHB DAPENLCIAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA18820", Offset = "0xA17C20", VA = "0x180A18820", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA193B0", Offset = "0xA187B0", VA = "0x180A193B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public HEGGCKEGGLN BHGFOAFKAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7CCB10", Offset = "0x7CBF10", VA = "0x1807CCB10", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7CCFD0", Offset = "0x7CC3D0", VA = "0x1807CCFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public BBCAJKHGDAF ONGPGKKABGH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6E3330", Offset = "0x6E2730", VA = "0x1806E3330", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7CD130", Offset = "0x7CC530", VA = "0x1807CD130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public MIDAHBJNNBL HLLPFFAKGIF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC610", Offset = "0x7EBA10", VA = "0x1807EC610", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7EDFC0", Offset = "0x7ED3C0", VA = "0x1807EDFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public MECBEAOLDHP GKGHJABFGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE20", Offset = "0x7CB220", VA = "0x1807CBE20", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xC682B0", Offset = "0xC676B0", VA = "0x180C682B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public CDMJDHCPJDD NJLANJDLFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7CCAF0", Offset = "0x7CBEF0", VA = "0x1807CCAF0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7EFAE0", Offset = "0x7EEEE0", VA = "0x1807EFAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public DGDNBGPEIIB FJDENHDCFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7CCB00", Offset = "0x7CBF00", VA = "0x1807CCB00", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7CCFC0", Offset = "0x7CC3C0", VA = "0x1807CCFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public MAOOBHKBEAI KAKFEHMCGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7EFAD0", Offset = "0x7EEED0", VA = "0x1807EFAD0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7EFAF0", Offset = "0x7EEEF0", VA = "0x1807EFAF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public JBNFGNMGBPF POJEKKFAJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7EBC20", Offset = "0x7EB020", VA = "0x1807EBC20", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7CD110", Offset = "0x7CC510", VA = "0x1807CD110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public GKAHBEHBJIH DDFFKOOJGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7F3780", Offset = "0x7F2B80", VA = "0x1807F3780", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7F37A0", Offset = "0x7F2BA0", VA = "0x1807F37A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public ECPIIGAIEKM PBPJMJBKHAH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3790", Offset = "0x7F2B90", VA = "0x1807F3790", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7F37B0", Offset = "0x7F2BB0", VA = "0x1807F37B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public CIIIIGJIDFC AAMMLCNCBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7F8670", Offset = "0x7F7A70", VA = "0x1807F8670", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public KFHPPEDHCNA FNHBFIFFNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xB8CE40", Offset = "0xB8C240", VA = "0x180B8CE40", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xB8CED0", Offset = "0xB8C2D0", VA = "0x180B8CED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private bool NDBBJKEFFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3244150", Offset = "0x3243550", VA = "0x183244150", Slot = "45")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private bool CGNLBIFKOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3244010", Offset = "0x3243410", VA = "0x183244010", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private Task BEMOKMADKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3244380", Offset = "0x3243780", VA = "0x183244380", Slot = "47")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private CancellationToken GBDMHPKKENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x32442A0", Offset = "0x32436A0", VA = "0x1832442A0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private BHKHBEKDAPI PBANHJIPOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event Action FLBKPEFOPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3243DE0", Offset = "0x32431E0", VA = "0x183243DE0", Slot = "35")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x32442C0", Offset = "0x32436C0", VA = "0x1832442C0", Slot = "36")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event HHOHNACIAAP AMFCMGIJHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3243D80", Offset = "0x3243180", VA = "0x183243D80", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3244090", Offset = "0x3243490", VA = "0x183244090", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event HHOHNACIAAP NEAEAMKMDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3243E40", Offset = "0x3243240", VA = "0x183243E40", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3243FB0", Offset = "0x32433B0", VA = "0x183243FB0", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event HHOHNACIAAP BIIIJBLHHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3243F00", Offset = "0x3243300", VA = "0x183243F00", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x32440F0", Offset = "0x32434F0", VA = "0x1832440F0", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event Action<JGOHEHCNFEL, bool> DIELMNPGJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3243D20", Offset = "0x3243120", VA = "0x183243D20", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3244320", Offset = "0x3243720", VA = "0x183244320", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0xB8CED0", Offset = "0xB8C2D0", VA = "0x180B8CED0", Slot = "34")]
	public void DJCOHNLLGCK(KFHPPEDHCNA CAHDIDENEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3244670", Offset = "0x3243A70", VA = "0x183244670")]
	[UnityEngine.Scripting.Preserve]
	internal FPHMHGEHKLH([ANGFGGDOPHE(null)] BHKHBEKDAPI CBOODPBIPLK, [ANGFGGDOPHE(null)] NKKMLDCLAFH CMHEIEGMDHP, [ANGFGGDOPHE(null)] DOAKALKGBLF KNFGALJFAEL, [ANGFGGDOPHE(null)] EELDLGKOJPM CMMLIBKHPCN, [ANGFGGDOPHE(null)] KHAALFBNGAL KLKGHAKICED, [ANGFGGDOPHE(null)] MEDPDNCDEGC DEPNOOMKGNJ, [ANGFGGDOPHE(null)] JFCDMGDONIF AACJAEEEEFG, [ANGFGGDOPHE(null)] PAJJLIFLOGC EGEEHBIEOLL, [ANGFGGDOPHE(null)] MKIJKNGGGEN KNEDOJCPCEC, [ANGFGGDOPHE(null)] KLOMKOPCGBL BMCJIPNKIEK, [ANGFGGDOPHE(null)] MJNBCFMHIHE HIAJLBHGCPF, [ANGFGGDOPHE(null)] OBFFLECOGHD DKDKIJMNFMC, [ANGFGGDOPHE(null)] HFAMPDNHCGH CNHKIBBKMLH, [ANGFGGDOPHE(null)] NLPLHFNOPIN HGIDDHKAAPB, [ANGFGGDOPHE(null)] IIGBIBLGCBF MJMEGBGNFLD, [ANGFGGDOPHE(null)] MEAIHPHJEFK ONIHBGGKIJC, [ANGFGGDOPHE(null)] HPGDJAJILOJ OMLFDHIGBEN, [ANGFGGDOPHE(null)] AADLLMCLBHB NPIBEABIIHM, [ANGFGGDOPHE(null)] HEGGCKEGGLN GJEPHDOAGJG, [ANGFGGDOPHE(null)] BBCAJKHGDAF DOEFDIDAEIJ, [ANGFGGDOPHE(null)] MECBEAOLDHP NIJOHJIPDDM, [ANGFGGDOPHE(null)] MIDAHBJNNBL DGFONDEJJDO, [ANGFGGDOPHE(null)] CDMJDHCPJDD DHAGGAIBNIA, [ANGFGGDOPHE(null)] DGDNBGPEIIB HLILACDMBND, [ANGFGGDOPHE(null)] MAOOBHKBEAI JIACEKBJBHH, [ANGFGGDOPHE(null)] GKAHBEHBJIH PNMMLHPKIGP, [ANGFGGDOPHE(null)] ECPIIGAIEKM FFNAIPACHFH, [ANGFGGDOPHE(null)] CIIIIGJIDFC IFMPCHEAMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x32443D0", Offset = "0x32437D0", VA = "0x1832443D0")]
	private void NPFGFFCDMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3243B90", Offset = "0x3242F90", VA = "0x183243B90", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3243F60", Offset = "0x3243360", VA = "0x183243F60", Slot = "48")]
	private void FMKENCEIHAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x32438B0", Offset = "0x3242CB0", VA = "0x1832438B0", Slot = "49")]
	private LHFPHAFPDJH BBCJABEEEDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x32444C0", Offset = "0x32438C0", VA = "0x1832444C0", Slot = "50")]
	private JGBBPIJGKMA OPHDDJOLLIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3244160", Offset = "0x3243560", VA = "0x183244160", Slot = "51")]
	[AsyncStateMachine(typeof(BIBODHDGAPL))]
	private Task<EKKOLLPPNIM> KGNJGPBEJJC(AMJALDODKON LFOFFPBKHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3243A70", Offset = "0x3242E70", VA = "0x183243A70", Slot = "52")]
	[AsyncStateMachine(typeof(OFKEFCFAMHC))]
	private Task DKCHCOHIDPL(CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3243A00", Offset = "0x3242E00", VA = "0x183243A00")]
	[IteratorStateMachine(typeof(JEJMPOLBFPA))]
	private IEnumerable<PGKAMNNFOKD> DIPEKGHAHLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3243EA0", Offset = "0x32432A0", VA = "0x183243EA0")]
	[CompilerGenerated]
	private void FKIFBOPBJGG(PGKAMNNFOKD LFAAOBNJLDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal class FNNIPMFMJAB : NOHGOGKIIGD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct KJNJMDJBHIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public FNNIPMFMJAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CB55D0", Offset = "0x3CB49D0", VA = "0x183CB55D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5960", Offset = "0x3CB4D60", VA = "0x183CB5960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly EELDLGKOJPM CMMLIBKHPCN;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x77E010", Offset = "0x77D410", VA = "0x18077E010")]
	public FNNIPMFMJAB(GOLPDNFBDPM GAMGMMDKBIL, EELDLGKOJPM CMMLIBKHPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3242740", Offset = "0x3241B40", VA = "0x183242740", Slot = "4")]
	[AsyncStateMachine(typeof(KJNJMDJBHIK))]
	public Task<bool> PGCDHLEIODC(CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3242660", Offset = "0x3241A60", VA = "0x183242660")]
	[CompilerGenerated]
	private object HCCKBMDGJGI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class OBELKDMHPHF : NOHGOGKIIGD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct BJOJELFGCOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public OBELKDMHPHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4823CC0", Offset = "0x48230C0", VA = "0x184823CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x48243C0", Offset = "0x48237C0", VA = "0x1848243C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const float CPMFEAKBNCE = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly EELDLGKOJPM CMMLIBKHPCN;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private KHKJJLCHIGJ EACHPFKLBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3CBB2F0", Offset = "0x3CBA6F0", VA = "0x183CBB2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x77E010", Offset = "0x77D410", VA = "0x18077E010")]
	public OBELKDMHPHF(GOLPDNFBDPM GAMGMMDKBIL, EELDLGKOJPM CMMLIBKHPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB420", Offset = "0x3CBA820", VA = "0x183CBB420", Slot = "4")]
	[AsyncStateMachine(typeof(BJOJELFGCOL))]
	public Task<bool> PGCDHLEIODC(CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB340", Offset = "0x3CBA740", VA = "0x183CBB340")]
	[CompilerGenerated]
	private object NPNEPEMPPLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class CMNAFAHPAJD : NOHGOGKIIGD
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JLKANOJHAAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CMNAFAHPAJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Matchmaking.NPKOLENFHIH result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public OAILMIHJFAK newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JLKANOJHAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4E90", Offset = "0x3CB4290", VA = "0x183CB4E90")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4F70", Offset = "0x3CB4370", VA = "0x183CB4F70")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4FE0", Offset = "0x3CB43E0", VA = "0x183CB4FE0")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct NOIKHABLMID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CMNAFAHPAJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private JLKANOJHAAE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<Matchmaking.NPKOLENFHIH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA8C0", Offset = "0x3CB9CC0", VA = "0x183CBA8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3CBB210", Offset = "0x3CBA610", VA = "0x183CBB210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private const float CPMFEAKBNCE = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly EELDLGKOJPM CMMLIBKHPCN;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private KHKJJLCHIGJ EACHPFKLBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x323AF90", Offset = "0x323A390", VA = "0x18323AF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x77E010", Offset = "0x77D410", VA = "0x18077E010")]
	public CMNAFAHPAJD(GOLPDNFBDPM GAMGMMDKBIL, EELDLGKOJPM CMMLIBKHPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x323AFE0", Offset = "0x323A3E0", VA = "0x18323AFE0", Slot = "4")]
	[AsyncStateMachine(typeof(NOIKHABLMID))]
	public Task<bool> PGCDHLEIODC(CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal interface NOHGOGKIIGD
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> PGCDHLEIODC(CancellationToken MJMCKAGGCOI);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal struct LMGCDOBIPEN
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class BMHBNKAACDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public GOLPDNFBDPM manager;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BMHBNKAACDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3C446D0", Offset = "0x3C43AD0", VA = "0x183C446D0")]
		internal Task <CreateTask>b__0(OCLGLHHAFAO data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct ELFMDKNPBLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public LMGCDOBIPEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private AMJALDODKON <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<LMLBDNGHFLE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<EKKOLLPPNIM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3C49CA0", Offset = "0x3C490A0", VA = "0x183C49CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A220", Offset = "0x3C49620", VA = "0x183C4A220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct BOKMHHLKJDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public LMGCDOBIPEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3C44710", Offset = "0x3C43B10", VA = "0x183C44710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken MJMCKAGGCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly GOLPDNFBDPM NBEGMMIIDMD;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private NKKMLDCLAFH FCOJJOEHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3250CF0", Offset = "0x32500F0", VA = "0x183250CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private EELDLGKOJPM PBGLAENKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3250890", Offset = "0x324FC90", VA = "0x183250890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private KHKJJLCHIGJ EACHPFKLBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x32508E0", Offset = "0x324FCE0", VA = "0x1832508E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private KLOMKOPCGBL PKKHKCCEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3250610", Offset = "0x324FA10", VA = "0x183250610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3250D40", Offset = "0x3250140", VA = "0x183250D40")]
	public LMGCDOBIPEN(CancellationToken MJMCKAGGCOI, GOLPDNFBDPM NBEGMMIIDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3250960", Offset = "0x324FD60", VA = "0x183250960")]
	public static NDGBMEHBGKE JHJEOIAMODK(GOLPDNFBDPM NBEGMMIIDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3250660", Offset = "0x324FA60", VA = "0x183250660")]
	[AsyncStateMachine(typeof(ELFMDKNPBLH))]
	public Task<bool> BFJDGLKAEGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3250B50", Offset = "0x324FF50", VA = "0x183250B50")]
	private bool OBBMOGADHEP(out AMJALDODKON LFOFFPBKHMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3250790", Offset = "0x324FB90", VA = "0x183250790")]
	[AsyncStateMachine(typeof(BOKMHHLKJDG))]
	private Task DCCPMNODFCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3250A10", Offset = "0x324FE10", VA = "0x183250A10")]
	private Task<LMLBDNGHFLE> MOHBKJNLDCD(AMJALDODKON OLDGFECLFEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal struct AAFDOAPGFME : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly IIGBIBLGCBF MJMEGBGNFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid JLOMHEMDNBP;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private Task<(EKKOLLPPNIM, Task)> NGBLAGGDOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3234B10", Offset = "0x3233F10", VA = "0x183234B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2B44950", Offset = "0x2B43D50", VA = "0x182B44950")]
	public AAFDOAPGFME(IIGBIBLGCBF MJMEGBGNFLD, Guid JLOMHEMDNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x32349F0", Offset = "0x3233DF0", VA = "0x1832349F0")]
	public TaskAwaiter<(EKKOLLPPNIM, Task)> AMEJOHIBBNA()
	{
		return default(TaskAwaiter<(EKKOLLPPNIM, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3234A40", Offset = "0x3233E40", VA = "0x183234A40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct NBHCCCJNJIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(EKKOLLPPNIM, Task)> GNNPCCOIGIP;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Task<(EKKOLLPPNIM, Task)> NGBLAGGDOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9840", Offset = "0x3CB8C40", VA = "0x183CB9840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9910", Offset = "0x3CB8D10", VA = "0x183CB9910")]
	public NBHCCCJNJIM(TimeSpan OHFDFDCBAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x3CB96C0", Offset = "0x3CB8AC0", VA = "0x183CB96C0")]
	public void IDDPACCKFMB(Task OMLFMKOMCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9760", Offset = "0x3CB8B60", VA = "0x183CB9760")]
	public void LEAHNFBMDNG(EKKOLLPPNIM EBCKEMJOFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3CB97F0", Offset = "0x3CB8BF0", VA = "0x183CB97F0")]
	public void MBHAGAGOHEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9880", Offset = "0x3CB8C80", VA = "0x183CB9880")]
	internal void OCLPHHILKHG(string CIBBLLOHCGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class OOAEJCADFJP
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class GDJNJICCDAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public long subRoomId;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public GDJNJICCDAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x1C004F0", Offset = "0x1BFF8F0", VA = "0x181C004F0")]
		internal bool <Create>b__0(CLNOPKLDMLF subRoom)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFC20", Offset = "0x3CBF020", VA = "0x183CBFC20")]
	public static CCLMJIMCJFD PELCFOCODBC(long IHMFAKAKFLN, long JPKIIMPIPPD, LECBPDHMHPK GIENOADFBID, string BLDADOPGBGF, LECBPDHMHPK GPCAHMAJMLI, string KFNFEIADKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFAB0", Offset = "0x3CBEEB0", VA = "0x183CBFAB0")]
	public static CCLMJIMCJFD PELCFOCODBC(JIAGHJHJMHD FKOJNMGOCBE, MFCGKHHIAKN KMBBHGDOOIF, [Optional] string KFNFEIADKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF890", Offset = "0x3CBEC90", VA = "0x183CBF890")]
	public static CCLMJIMCJFD PELCFOCODBC(JIAGHJHJMHD FKOJNMGOCBE, long JPKIIMPIPPD, [Optional] string KFNFEIADKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF790", Offset = "0x3CBEB90", VA = "0x183CBF790")]
	public static CCLMJIMCJFD HNFMFHGICNL(this CCLMJIMCJFD OCMDFIDHJDH, JIAGHJHJMHD IBKBGGIENGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF5D0", Offset = "0x3CBE9D0", VA = "0x183CBF5D0")]
	public static CCLMJIMCJFD GLHIHOJCGGI(this CCLMJIMCJFD OCMDFIDHJDH, MFCGKHHIAKN FNGBNIELNLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF6B0", Offset = "0x3CBEAB0", VA = "0x183CBF6B0")]
	public static CCLMJIMCJFD GLHIHOJCGGI(this CCLMJIMCJFD OCMDFIDHJDH, CLNOPKLDMLF BBMOGKDKELE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[UnityEngine.Scripting.Preserve]
internal class MNAOJKMIHCM : MKIJKNGGGEN, PGKAMNNFOKD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct CMIIDPJKBKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public MNAOJKMIHCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3C450E0", Offset = "0x3C444E0", VA = "0x183C450E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly ANOHCNMGJIP KHBHPOLKONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string CGGEMHFILOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task GEIOFDNHADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool OFJIAJAACLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3253AA0", Offset = "0x3252EA0", VA = "0x183253AA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Task ILACKGMBJII
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3253AD0", Offset = "0x3252ED0", VA = "0x183253AD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x963B10", Offset = "0x962F10", VA = "0x180963B10", Slot = "7")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3253B30", Offset = "0x3252F30", VA = "0x183253B30", Slot = "6")]
	public void OMBLAENHMJH(Task IGPMHCEBGGP, string DCONDLIMEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3253970", Offset = "0x3252D70", VA = "0x183253970")]
	[AsyncStateMachine(typeof(CMIIDPJKBKB))]
	private Task ADHPDPKNPEE(Task AAFBDDEPGIB, string DCONDLIMEPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3253CB0", Offset = "0x32530B0", VA = "0x183253CB0")]
	public MNAOJKMIHCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class BEIKGOFCFMB : JBNFGNMGBPF, PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool PLPDDBIKCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private CPHIJNHNMFK AKAHOOOMMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private NKKMLDCLAFH CMHEIEGMDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private GKAHBEHBJIH PNMMLHPKIGP;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public CPHIJNHNMFK IGKCECBAIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3238AF0", Offset = "0x3237EF0", VA = "0x183238AF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x3238B60", Offset = "0x3237F60", VA = "0x183238B60", Slot = "7")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x32388B0", Offset = "0x3237CB0", VA = "0x1832388B0", Slot = "5")]
	public void FCIALHFNDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3238870", Offset = "0x3237C70", VA = "0x183238870", Slot = "6")]
	public void MEPIHBPHANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3238A70", Offset = "0x3237E70", VA = "0x183238A70")]
	private Task JGDMKIPFLDI(ALKGHOEMCCK FKBMHFEKLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3238870", Offset = "0x3237C70", VA = "0x183238870", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public BEIKGOFCFMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class ACLEDPLKAOF : GKAHBEHBJIH
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private class CEEHDFAKOIB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly OMJDHGKECKG HFOCOPJAHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string NPBDKCONLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly T IEMLIFLCGLH;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public T EJBPMDLBLGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x826290", Offset = "0x825690", VA = "0x180826290")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x8262B0", Offset = "0x8256B0", VA = "0x1808262B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3B645F0", Offset = "0x3B639F0", VA = "0x183B645F0")]
		public CEEHDFAKOIB(OMJDHGKECKG HFOCOPJAHGF, string NPBDKCONLNC, T IEMLIFLCGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3B63FE0", Offset = "0x3B633E0", VA = "0x183B63FE0")]
		private void GDKLJKBGPCM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly CEEHDFAKOIB<TimeSpan> NHOPAOLJBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly CEEHDFAKOIB<TimeSpan> MHJEBGFBAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly CEEHDFAKOIB<TimeSpan> HLCHGAMHCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly CEEHDFAKOIB<TimeSpan> JBPMMBLMICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly CEEHDFAKOIB<bool> FIKLPLNNPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly CEEHDFAKOIB<bool> IBPHFPBHIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly CEEHDFAKOIB<bool> GELIMBHEHAB;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public TimeSpan AIMGIIDHOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3236870", Offset = "0x3235C70", VA = "0x183236870", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan DMAHLEAPIGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x32367B0", Offset = "0x3235BB0", VA = "0x1832367B0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan JNIFPHMGDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3236730", Offset = "0x3235B30", VA = "0x183236730", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan FGNJGEMLBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3236770", Offset = "0x3235B70", VA = "0x183236770", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool EKBNEICJNLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x32367F0", Offset = "0x3235BF0", VA = "0x1832367F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool PBJFBHBDAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3236830", Offset = "0x3235C30", VA = "0x183236830", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool CNKDIFMNADE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x32368B0", Offset = "0x3235CB0", VA = "0x1832368B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x32368F0", Offset = "0x3235CF0", VA = "0x1832368F0")]
	[UnityEngine.Scripting.Preserve]
	public ACLEDPLKAOF([ANGFGGDOPHE(null)] OMJDHGKECKG HFOCOPJAHGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[UnityEngine.Scripting.Preserve]
internal class HMONMPGKPFO : MJNBCFMHIHE, PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class BPNFJNAJPFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public FKHOLCDLGLO roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BPNFJNAJPFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3C44940", Offset = "0x3C43D40", VA = "0x183C44940")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action EKHKEMKCLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3249B70", Offset = "0x3248F70", VA = "0x183249B70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3249930", Offset = "0x3248D30", VA = "0x183249930", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event HHOHNACIAAP HLFIAGPKFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3249AA0", Offset = "0x3248EA0", VA = "0x183249AA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3249740", Offset = "0x3248B40", VA = "0x183249740", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event HHOHNACIAAP FDBPHBMMJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3249C10", Offset = "0x3249010", VA = "0x183249C10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3249F30", Offset = "0x3249330", VA = "0x183249F30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event HHOHNACIAAP LPOBDKLPEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3249A00", Offset = "0x3248E00", VA = "0x183249A00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3249890", Offset = "0x3248C90", VA = "0x183249890", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<JGOHEHCNFEL, bool> BGLCHEDKLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x324A230", Offset = "0x3249630", VA = "0x18324A230", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3249670", Offset = "0x3248A70", VA = "0x183249670", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "19")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3249CB0", Offset = "0x32490B0", VA = "0x183249CB0", Slot = "14")]
	public void MPFAEBOKOGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x3249B40", Offset = "0x3248F40", VA = "0x183249B40", Slot = "15")]
	public void JJKFDBLFJBN(FKHOLCDLGLO MILONKEOIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3249710", Offset = "0x3248B10", VA = "0x183249710", Slot = "16")]
	public void CJFLKKIIOCD(FKHOLCDLGLO MILONKEOIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x32499D0", Offset = "0x3248DD0", VA = "0x1832499D0", Slot = "17")]
	public void GMLBLDJEOKL(FKHOLCDLGLO MILONKEOIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x32497E0", Offset = "0x3248BE0", VA = "0x1832497E0", Slot = "18")]
	public void ELPFLLDAEFL(JGOHEHCNFEL OOIKEALFDCH, bool CCMACNPGBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3249FD0", Offset = "0x32493D0", VA = "0x183249FD0")]
	private void PECAEBJKGCF(HHOHNACIAAP OEEGLLLODJM, FKHOLCDLGLO MILONKEOIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public HMONMPGKPFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class AMCPCHPLLFC : OBFFLECOGHD, PGKAMNNFOKD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct MCNEKINGAJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AMCPCHPLLFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3CB7560", Offset = "0x3CB6960", VA = "0x183CB7560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct FBGHLONCOKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AMCPCHPLLFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3CAF930", Offset = "0x3CAED30", VA = "0x183CAF930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class KMHKACEBABI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public KMHKACEBABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3CB59B0", Offset = "0x3CB4DB0", VA = "0x183CB59B0")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct LHFOPJNFIKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AMCPCHPLLFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private KMHKACEBABI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5C60", Offset = "0x3CB5060", VA = "0x183CB5C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3CB61F0", Offset = "0x3CB55F0", VA = "0x183CB61F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class LFIGIKGOHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LFIGIKGOHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5BF0", Offset = "0x3CB4FF0", VA = "0x183CB5BF0")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private EELDLGKOJPM CMMLIBKHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private NOHGOGKIIGD[] GOMEJHKMNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private CancellationTokenSource NFMAFINMMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private int MDPOCACFKIG;

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x3237BF0", Offset = "0x3236FF0", VA = "0x183237BF0", Slot = "7")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x32372B0", Offset = "0x32366B0", VA = "0x1832372B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x3237540", Offset = "0x3236940", VA = "0x183237540", Slot = "6")]
	public void FIGPHFJKAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3237FD0", Offset = "0x32373D0", VA = "0x183237FD0", Slot = "5")]
	public void OFEEEBJDOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3237AE0", Offset = "0x3236EE0", VA = "0x183237AE0", Slot = "4")]
	[AsyncStateMachine(typeof(MCNEKINGAJB))]
	public Task NMJNJFODPMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3237C70", Offset = "0x3237070", VA = "0x183237C70")]
	private void OBAINFMOBNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3237410", Offset = "0x3236810", VA = "0x183237410")]
	[AsyncStateMachine(typeof(FBGHLONCOKA))]
	private Task ENPGBNFEKGB(CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x32372C0", Offset = "0x32366C0", VA = "0x1832372C0")]
	[AsyncStateMachine(typeof(LHFOPJNFIKI))]
	private Task<bool> EBLPICBKNIO(int GABJOMFFJAI, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x3237150", Offset = "0x3236550", VA = "0x183237150")]
	private void DIECELMGEFM(int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x3237990", Offset = "0x3236D90", VA = "0x183237990")]
	private void NEJDAJPIMJG(int GABJOMFFJAI, bool CCMACNPGBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x32376C0", Offset = "0x3236AC0", VA = "0x1832376C0")]
	private void KFFFJCCLPHF(int GABJOMFFJAI, Exception ODLBKMKCIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x3237880", Offset = "0x3236C80", VA = "0x183237880")]
	private void LGGKHHHPNLK(CancellationToken MJMCKAGGCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public AMCPCHPLLFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[UnityEngine.Scripting.Preserve]
internal class LBDONPDDGAD : NLPLHFNOPIN, PGKAMNNFOKD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct FKJCFICKPGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public LBDONPDDGAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public OCLGLHHAFAO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B630", Offset = "0x3C4AA30", VA = "0x183C4B630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class AONBKMBKMGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public LBDONPDDGAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public OCLGLHHAFAO roomData;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public AONBKMBKMGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3C43690", Offset = "0x3C42A90", VA = "0x183C43690")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct FGHEEMOMGOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public NDGBMEHBGKE taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B260", Offset = "0x3C4A660", VA = "0x183C4B260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct CFHFFLBPNDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public LBDONPDDGAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3C44A40", Offset = "0x3C43E40", VA = "0x183C44A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly HashSet<NDGBMEHBGKE> ICGMDDOJNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private DOAKALKGBLF KNFGALJFAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private JLIBGKFOCHA CFDDLOCOJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private DKAAMFPFCDG GGGELEFFGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private IDisposable CNOOHHNFADL;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool MECGMNAHNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x324CE00", Offset = "0x324C200", VA = "0x18324CE00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal Task NGBLAGGDOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x324D850", Offset = "0x324CC50", VA = "0x18324D850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x324D860", Offset = "0x324CC60", VA = "0x18324D860", Slot = "6")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x324CE30", Offset = "0x324C230", VA = "0x18324CE30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x324CEB0", Offset = "0x324C2B0", VA = "0x18324CEB0", Slot = "5")]
	public bool EOMCMAHKGJG(NDGBMEHBGKE NCLELDJHNLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x324D410", Offset = "0x324C810", VA = "0x18324D410")]
	private void ILCLICNMNHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x324D170", Offset = "0x324C570", VA = "0x18324D170")]
	private void ILBMIHEJEPG(OCLGLHHAFAO FOGLEECNIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x324CCE0", Offset = "0x324C0E0", VA = "0x18324CCE0")]
	[AsyncStateMachine(typeof(FKJCFICKPGP))]
	private Task AMCOKAEONAK(OCLGLHHAFAO FOGLEECNIFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x324D670", Offset = "0x324CA70", VA = "0x18324D670")]
	private Func<CancellationToken, List<Task>> LABOJPLKJIL(OCLGLHHAFAO FOGLEECNIFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x324DB00", Offset = "0x324CF00", VA = "0x18324DB00")]
	private List<Task> PKGCCIBLJJK(OCLGLHHAFAO FOGLEECNIFC, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x324D040", Offset = "0x324C440", VA = "0x18324D040")]
	[AsyncStateMachine(typeof(FGHEEMOMGOP))]
	private Task GNBFJICIECH(NDGBMEHBGKE NHPEDPGHBNB, OCLGLHHAFAO MPEBBGJJODN, CancellationToken JCHAGIDHJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x324D750", Offset = "0x324CB50", VA = "0x18324D750")]
	[AsyncStateMachine(typeof(CFHFFLBPNDB))]
	private Task LOADNJEFCCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x324CF10", Offset = "0x324C310", VA = "0x18324CF10")]
	private void FIGPHFJKAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x324E040", Offset = "0x324D440", VA = "0x18324E040")]
	public LBDONPDDGAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[RecRoom.NoEngine.Common.Preserve]
internal class NBDEECLLNFO : HFAMPDNHCGH, PGKAMNNFOKD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct IMFFGJIJAEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public OAILMIHJFAK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public NBDEECLLNFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public KFHPPEDHCNA customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3C4D930", Offset = "0x3C4CD30", VA = "0x183C4D930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct FFDACCEIPHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public NBDEECLLNFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public OAILMIHJFAK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public KFHPPEDHCNA customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private global::PADKJAANMNM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private NCNPBEKEBJI <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private KCEOPGFPCFN <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A270", Offset = "0x3C49670", VA = "0x183C4A270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class GPOCGNDHKGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public Task<CCLMJIMCJFD> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public GPOCGNDHKGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		internal Task<CCLMJIMCJFD> <ConnectToRoomAndRunLoadLogic>b__0(MIPBMMJKKCH _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct EAPEAGONCHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public NBDEECLLNFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public OAILMIHJFAK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public KFHPPEDHCNA customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public NCNPBEKEBJI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private GPOCGNDHKGI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private NAIIIENIGCP <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private MIPBMMJKKCH <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private NPFGJMKHLLJ <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationTokenSource <photonJoinedTokenSource>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <photonJoinedToken>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Task <roomLoadTask>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<CCLMJIMCJFD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3C47560", Offset = "0x3C46960", VA = "0x183C47560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct MJCGBOBFPBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public NBDEECLLNFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private MIPBMMJKKCH <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private MIPBMMJKKCH <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3C53010", Offset = "0x3C52410", VA = "0x183C53010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct KNLNFFOEINK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public NBDEECLLNFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private BHKHBEKDAPI <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3C50F60", Offset = "0x3C50360", VA = "0x183C50F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct DPCFNMBBJAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public OAILMIHJFAK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public NBDEECLLNFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public NCNPBEKEBJI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private MIPBMMJKKCH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<OKJBFGJKMDO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3C46920", Offset = "0x3C45D20", VA = "0x183C46920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class AOHPALDPFLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public OAILMIHJFAK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public AOHPALDPFLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3C43590", Offset = "0x3C42990", VA = "0x183C43590")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3C43490", Offset = "0x3C42890", VA = "0x183C43490")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct PEDICOOCJAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public OAILMIHJFAK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public NBDEECLLNFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private AOHPALDPFLL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x3C563D0", Offset = "0x3C557D0", VA = "0x183C563D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct EFKAFAMMAKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public NBDEECLLNFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public NCNPBEKEBJI joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public CCLMJIMCJFD initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public OAILMIHJFAK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public NAIIIENIGCP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private MIPBMMJKKCH <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3C490A0", Offset = "0x3C484A0", VA = "0x183C490A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct HOOPDMMAMPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public NBDEECLLNFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private MIPBMMJKKCH <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3C4CBB0", Offset = "0x3C4BFB0", VA = "0x183C4CBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct BGEEABNDHDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public NBDEECLLNFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3C43740", Offset = "0x3C42B40", VA = "0x183C43740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct ILOCIECHLMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NBDEECLLNFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private MIPBMMJKKCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3C4D670", Offset = "0x3C4CA70", VA = "0x183C4D670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct JOBBBGEPHLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public NBDEECLLNFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<EKKOLLPPNIM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F630", Offset = "0x3C4EA30", VA = "0x183C4F630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct IJAINPLDKHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public NBDEECLLNFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private MIPBMMJKKCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3C4D2C0", Offset = "0x3C4C6C0", VA = "0x183C4D2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class GHAFJPOAHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public OAILMIHJFAK targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public GHAFJPOAHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C000", Offset = "0x3C4B400", VA = "0x183C4C000")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class MBFKLDCALKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public MBFKLDCALKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3C52C70", Offset = "0x3C52070", VA = "0x183C52C70")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class FOPAJAINIMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public OAILMIHJFAK targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public FOPAJAINIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BA80", Offset = "0x3C4AE80", VA = "0x183C4BA80")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class KGDGICFMGHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public OAILMIHJFAK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public KGDGICFMGHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3C503B0", Offset = "0x3C4F7B0", VA = "0x183C503B0")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly string CCCGCELEMMD;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly string CEMMFPFEKCO;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string HIHDIKBPJNJ;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly Guid GLHJMHFDNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private PAJJLIFLOGC EGEEHBIEOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private DOAKALKGBLF KNFGALJFAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NKKMLDCLAFH CMHEIEGMDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private EELDLGKOJPM CMMLIBKHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private OBFFLECOGHD DKDKIJMNFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private MKIJKNGGGEN KNEDOJCPCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private MJNBCFMHIHE HIAJLBHGCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private GKAHBEHBJIH PNMMLHPKIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private IDisposable CNOOHHNFADL;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TaskStatus HKINNFLEDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xAEBA20", Offset = "0xAEAE20", VA = "0x180AEBA20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x115AED0", Offset = "0x115A2D0", VA = "0x18115AED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private KHKJJLCHIGJ EACHPFKLBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3256B00", Offset = "0x3255F00", VA = "0x183256B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x32576E0", Offset = "0x3256AE0", VA = "0x1832576E0", Slot = "6")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x32557A0", Offset = "0x3254BA0", VA = "0x1832557A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3256810", Offset = "0x3255C10", VA = "0x183256810", Slot = "5")]
	[AsyncStateMachine(typeof(IMFFGJIJAEG))]
	public Task HKLKLODMFIG(OAILMIHJFAK KEDDCKBKHLI, KFHPPEDHCNA HAFOKFMHBON, CancellationToken JFEIMHDODID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3255A50", Offset = "0x3254E50", VA = "0x183255A50")]
	[AsyncStateMachine(typeof(FFDACCEIPHO))]
	private Task FAKLIPGIIGN(OAILMIHJFAK KEDDCKBKHLI, KFHPPEDHCNA HAFOKFMHBON, CancellationToken JFEIMHDODID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3257520", Offset = "0x3256920", VA = "0x183257520")]
	private static void MOKGHIBMDJE(OAILMIHJFAK KEDDCKBKHLI, Exception ODLBKMKCIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x32545F0", Offset = "0x32539F0", VA = "0x1832545F0")]
	private static void BHKMOOADCGM(KCEOPGFPCFN DGACNIFHPME, Exception ODLBKMKCIIL, [Optional] List<int> AADEJHBBMMH, int MDPOCACFKIG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3256C90", Offset = "0x3256090", VA = "0x183256C90")]
	[AsyncStateMachine(typeof(EAPEAGONCHK))]
	private Task IMPGEIMNGJJ(MIPBMMJKKCH HMHNEOCJGLO, OAILMIHJFAK KEDDCKBKHLI, KFHPPEDHCNA HAFOKFMHBON, NCNPBEKEBJI HILLANCEPBM, CancellationToken JFEIMHDODID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3256300", Offset = "0x3255700", VA = "0x183256300")]
	private void GHNJCMPMNCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x3256B50", Offset = "0x3255F50", VA = "0x183256B50")]
	[AsyncStateMachine(typeof(MJCGBOBFPBJ))]
	private Task IKAEDPNKJDJ(MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3257CB0", Offset = "0x32570B0", VA = "0x183257CB0")]
	private void PNNOODALFCP(OAILMIHJFAK KEDDCKBKHLI, CancellationToken JFEIMHDODID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3255BB0", Offset = "0x3254FB0", VA = "0x183255BB0")]
	private void FALIPHKFOME(OAILMIHJFAK KEDDCKBKHLI, NCNPBEKEBJI HILLANCEPBM, OperationCanceledException EEIBKDBLMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x3254F70", Offset = "0x3254370", VA = "0x183254F70")]
	private void CJFLGOIPNIF(OAILMIHJFAK KEDDCKBKHLI, NCNPBEKEBJI HILLANCEPBM, Exception ODLBKMKCIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x32553C0", Offset = "0x32547C0", VA = "0x1832553C0")]
	private void DICMPHDFKNB(OAILMIHJFAK KEDDCKBKHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x3256960", Offset = "0x3255D60", VA = "0x183256960")]
	private static FKHOLCDLGLO HMHBMAAAGOI(OAILMIHJFAK KEDDCKBKHLI)
	{
		return default(FKHOLCDLGLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x32572C0", Offset = "0x32566C0", VA = "0x1832572C0")]
	[AsyncStateMachine(typeof(KNLNFFOEINK))]
	private Task KEBEBMELLPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x3256A50", Offset = "0x3255E50", VA = "0x183256A50")]
	private static OKJBFGJKMDO IEFKMOBNFPA(OAILMIHJFAK KEDDCKBKHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3257B40", Offset = "0x3256F40", VA = "0x183257B40")]
	[AsyncStateMachine(typeof(DPCFNMBBJAO))]
	private Task PKDJLLHDPEN(OAILMIHJFAK KEDDCKBKHLI, NCNPBEKEBJI HILLANCEPBM, MIPBMMJKKCH HMHNEOCJGLO, CancellationToken GHDIBNBHECI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x32573C0", Offset = "0x32567C0", VA = "0x1832573C0")]
	[AsyncStateMachine(typeof(PEDICOOCJAD))]
	private Task LOCJLFJEOAC(OAILMIHJFAK KEDDCKBKHLI, CancellationTokenSource DJDCKDKKKFN, Task FFKJLMEPCOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3256170", Offset = "0x3255570", VA = "0x183256170")]
	[AsyncStateMachine(typeof(EFKAFAMMAKG))]
	private Task GCKGBLOGOLI(CCLMJIMCJFD HGCIHMIBCBK, NAIIIENIGCP OIAJHHLDCGM, OAILMIHJFAK OAAOOBICBIM, NCNPBEKEBJI NMFFOJMKIGP, MIPBMMJKKCH HMHNEOCJGLO, CancellationToken BEBDJLKCPBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3257070", Offset = "0x3256470", VA = "0x183257070")]
	private NCNPBEKEBJI JKFDBCDKDHI(NCNPBEKEBJI NMFFOJMKIGP, ref CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x32544B0", Offset = "0x32538B0", VA = "0x1832544B0")]
	[AsyncStateMachine(typeof(HOOPDMMAMPP))]
	private Task ALKLEGGEABA(MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x3255E70", Offset = "0x3255270", VA = "0x183255E70")]
	[AsyncStateMachine(typeof(BGEEABNDHDA))]
	private Task FEDCNNCNCOL(MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x3254E30", Offset = "0x3254230", VA = "0x183254E30")]
	[AsyncStateMachine(typeof(ILOCIECHLMP))]
	private Task BKOAMICGEPK(MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x3255660", Offset = "0x3254A60", VA = "0x183255660")]
	[AsyncStateMachine(typeof(JOBBBGEPHLD))]
	private Task DLCANCKJCJM(OCLGLHHAFAO MPEBBGJJODN, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x3256030", Offset = "0x3255430", VA = "0x183256030")]
	[AsyncStateMachine(typeof(IJAINPLDKHC))]
	private Task GCGLABOCNGP(MIPBMMJKKCH KNJJIICJOLE, CancellationToken GHDIBNBHECI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x32557F0", Offset = "0x3254BF0", VA = "0x1832557F0")]
	private static void ELIHCIFOJFK(OAILMIHJFAK KEDDCKBKHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x3256E10", Offset = "0x3256210", VA = "0x183256E10")]
	private void JHCBOODKHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x3255FA0", Offset = "0x32553A0", VA = "0x183255FA0")]
	private void FJPMOLEIINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x32569C0", Offset = "0x3255DC0", VA = "0x1832569C0")]
	private void IBCBBCEEFAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x3256FE0", Offset = "0x32563E0", VA = "0x183256FE0")]
	private void JKEONAFDHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x3256450", Offset = "0x3255850", VA = "0x183256450")]
	private static void GICPKHLBLGO(OAILMIHJFAK KEDDCKBKHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x3257A80", Offset = "0x3256E80", VA = "0x183257A80")]
	private static void PCPGBEKIPEA(OAILMIHJFAK KEDDCKBKHLI, CancellationToken GHDIBNBHECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x3255230", Offset = "0x3254630", VA = "0x183255230")]
	private static void CPCNPFLLKIK(OAILMIHJFAK KEDDCKBKHLI, Exception ODLBKMKCIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x32565D0", Offset = "0x32559D0", VA = "0x1832565D0")]
	private void HCAGFGECFDH(OAILMIHJFAK KEDDCKBKHLI, Task FFKJLMEPCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x3255960", Offset = "0x3254D60", VA = "0x183255960")]
	private static void EPMJEFBIMPO(Func<string> HPCOFNJFOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x32580F0", Offset = "0x32574F0", VA = "0x1832580F0")]
	public NBDEECLLNFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[UnityEngine.Scripting.Preserve]
internal sealed class PDELAPPGPNO : IIGBIBLGCBF, PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class JNENFKBELEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JNENFKBELEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x482C390", Offset = "0x482B790", VA = "0x18482C390")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class CBCOLGANHCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public CBCOLGANHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x4824940", Offset = "0x4823D40", VA = "0x184824940")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class NKDFPHCBELN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public NKDFPHCBELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x482EB80", Offset = "0x482DF80", VA = "0x18482EB80")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class MDBHODLOMCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public MDBHODLOMCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x482D6D0", Offset = "0x482CAD0", VA = "0x18482D6D0")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class CGPGCGILKEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public CGPGCGILKEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x4824DB0", Offset = "0x48241B0", VA = "0x184824DB0")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly Dictionary<Guid, NBHCCCJNJIM> MJMEGBGNFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly TimeSpan JKGOGIAFAFP;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "10")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x3CC20D0", Offset = "0x3CC14D0", VA = "0x183CC20D0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1B70", Offset = "0x3CC0F70", VA = "0x183CC1B70", Slot = "4")]
	public AAFDOAPGFME BKCAAEBNAMB(Guid JLOMHEMDNBP)
	{
		return default(AAFDOAPGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2360", Offset = "0x3CC1760", VA = "0x183CC2360", Slot = "5")]
	public bool GAMANBAONBG(Guid JLOMHEMDNBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x3CC20E0", Offset = "0x3CC14E0", VA = "0x183CC20E0", Slot = "8")]
	public bool FIGPHFJKAAA(Guid JLOMHEMDNBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC26B0", Offset = "0x3CC1AB0", VA = "0x183CC26B0", Slot = "6")]
	public bool OIIKIEMDIED(Guid JLOMHEMDNBP, Task OMLFMKOMCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x3CC18A0", Offset = "0x3CC0CA0", VA = "0x183CC18A0", Slot = "7")]
	public bool AFMEPLOEJNA(Guid JLOMHEMDNBP, EKKOLLPPNIM EBCKEMJOFAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2620", Offset = "0x3CC1A20", VA = "0x183CC2620", Slot = "9")]
	public Task<(EKKOLLPPNIM, Task)> JCENADENMON(Guid JLOMHEMDNBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1E10", Offset = "0x3CC1210", VA = "0x183CC1E10")]
	private void DNBINNDCJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2A80", Offset = "0x3CC1E80", VA = "0x183CC2A80")]
	public PDELAPPGPNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[UnityEngine.Scripting.Preserve]
internal class OBGGJFEKAPN : MEAIHPHJEFK, PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class ALPLIKKNGNG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private readonly OAILMIHJFAK NPJKDKEHGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private readonly CancellationTokenSource NFMAFINMMPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public readonly CancellationToken FIMCGBHKOJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private bool FFFJDMJFOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private bool MDPNAAPBFCF;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x4823480", Offset = "0x4822880", VA = "0x184823480")]
		public ALPLIKKNGNG(OAILMIHJFAK NPJKDKEHGJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x4823330", Offset = "0x4822730", VA = "0x184823330")]
		public void FIGPHFJKAAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x4823300", Offset = "0x4822700", VA = "0x184823300", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class BMEPHDEOIOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public ALKGHOEMCCK disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BMEPHDEOIOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x4824890", Offset = "0x4823C90", VA = "0x184824890")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct CDNNBMNPDFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public ALKGHOEMCCK disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public OBGGJFEKAPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x4824A10", Offset = "0x4823E10", VA = "0x184824A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class CCMKMNAHODE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public CCMKMNAHODE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x48249A0", Offset = "0x4823DA0", VA = "0x1848249A0")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct PCBHDGAMNOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public OBGGJFEKAPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x482F820", Offset = "0x482EC20", VA = "0x18482F820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x886DE0", Offset = "0x8861E0", VA = "0x180886DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class POKECDLKBGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public OAILMIHJFAK newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public POKECDLKBGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x4830560", Offset = "0x482F960", VA = "0x184830560")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x4830600", Offset = "0x482FA00", VA = "0x184830600")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x4830640", Offset = "0x482FA40", VA = "0x184830640")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class IBGMFFAOLHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public IBGMFFAOLHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x482B6E0", Offset = "0x482AAE0", VA = "0x18482B6E0")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct DNAOCOMEIOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public OAILMIHJFAK newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public OBGGJFEKAPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public KFHPPEDHCNA customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private POKECDLKBGG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x4827640", Offset = "0x4826A40", VA = "0x184827640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private DOAKALKGBLF KNFGALJFAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private OBFFLECOGHD DKDKIJMNFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private EELDLGKOJPM CMMLIBKHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private GKAHBEHBJIH PNMMLHPKIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private HFAMPDNHCGH CNHKIBBKMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private long MPOILEACDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private ALPLIKKNGNG COAMHCMGJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private bool EAPHOOLFEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private Task MMMGKHPEGOB;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private KHKJJLCHIGJ EACHPFKLBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3CBBC00", Offset = "0x3CBB000", VA = "0x183CBBC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool KFJLKHMPEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xAD41A0", Offset = "0xAD35A0", VA = "0x180AD41A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3CBBC50", Offset = "0x3CBB050", VA = "0x183CBBC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3CBBF00", Offset = "0x3CBB300", VA = "0x183CBBF00", Slot = "4")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB7E0", Offset = "0x3CBABE0", VA = "0x183CBB7E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3CBBAA0", Offset = "0x3CBAEA0", VA = "0x183CBBAA0")]
	[AsyncStateMachine(typeof(CDNNBMNPDFN))]
	private Task GCAEOPOGKPL(ALKGHOEMCCK JENGEJPIMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC1B0", Offset = "0x3CBB5B0", VA = "0x183CBC1B0")]
	private void OJELHBDJALF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3CBBC60", Offset = "0x3CBB060", VA = "0x183CBBC60")]
	private void KJJILHHBHCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC790", Offset = "0x3CBBB90", VA = "0x183CBC790")]
	private void OOHGGGKIBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3CBBE80", Offset = "0x3CBB280", VA = "0x183CBBE80")]
	private bool KNALCHDEDNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB560", Offset = "0x3CBA960", VA = "0x183CBB560")]
	[AsyncStateMachine(typeof(PCBHDGAMNOC))]
	private void BGCDPJAALDO(int CPILGALONLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC3D0", Offset = "0x3CBB7D0", VA = "0x183CBC3D0")]
	private void OLAKCFPNLMM(out IDisposable KEHHNNPJALF, out IDisposable NLOLDEPNCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB650", Offset = "0x3CBAA50", VA = "0x183CBB650")]
	private bool BHDPFOCGDEH(OAILMIHJFAK NPJKDKEHGJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3CBBBC0", Offset = "0x3CBAFC0", VA = "0x183CBBBC0")]
	private void IBPPIPIMFEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB960", Offset = "0x3CBAD60", VA = "0x183CBB960")]
	[AsyncStateMachine(typeof(DNAOCOMEIOK))]
	private Task FAKLIPGIIGN(OAILMIHJFAK NPJKDKEHGJC, KFHPPEDHCNA HAFOKFMHBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC9A0", Offset = "0x3CBBDA0", VA = "0x183CBC9A0")]
	public OBGGJFEKAPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[UnityEngine.Scripting.Preserve]
internal sealed class GJPDNPKLGLN : HPGDJAJILOJ, PGKAMNNFOKD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct JOIGKBMDFGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AsyncTaskMethodBuilder<OBGEECKNGII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public GJPDNPKLGLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TaskAwaiter<OBGEECKNGII> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x3C4FD50", Offset = "0x3C4F150", VA = "0x183C4FD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x3C4FFA0", Offset = "0x3C4F3A0", VA = "0x183C4FFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class MPNAAFLILFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public KNOPHICLNED message;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public MPNAAFLILFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C53E10", Offset = "0x3C53210", VA = "0x183C53E10")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class HONBOFPNNIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public KNOPHICLNED messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HONBOFPNNIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x3C4CB50", Offset = "0x3C4BF50", VA = "0x183C4CB50")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class ACKLAMMIEHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public KNOPHICLNED request;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ACKLAMMIEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x3C43430", Offset = "0x3C42830", VA = "0x183C43430")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct JKGFAFABBNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public KNOPHICLNED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public GJPDNPKLGLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private TaskAwaiter<FPOEHJGJEFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x3C4EA10", Offset = "0x3C4DE10", VA = "0x183C4EA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class FPJKPPEJPFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public KNOPHICLNED operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public FPJKPPEJPFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BB00", Offset = "0x3C4AF00", VA = "0x183C4BB00")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct PHKHAEIGCEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public KNOPHICLNED operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public GJPDNPKLGLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private NCNPBEKEBJI <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter<KNOPHICLNED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x3C579A0", Offset = "0x3C56DA0", VA = "0x183C579A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct DDKAAFPOKIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public AsyncTaskMethodBuilder<FPOEHJGJEFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public GJPDNPKLGLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public KNOPHICLNED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private NCNPBEKEBJI <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<KNOPHICLNED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x3C46420", Offset = "0x3C45820", VA = "0x183C46420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C46870", Offset = "0x3C45C70", VA = "0x183C46870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class BFPNDOBBFMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public FPOEHJGJEFB operation;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BFPNDOBBFMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C436C0", Offset = "0x3C42AC0", VA = "0x183C436C0")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct ELAKKGMIIFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public FPOEHJGJEFB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public GJPDNPKLGLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private global::PADKJAANMNM<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C49750", Offset = "0x3C48B50", VA = "0x183C49750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class DGMLDDJJKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public KNOPHICLNED request;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public DGMLDDJJKNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x3C468C0", Offset = "0x3C45CC0", VA = "0x183C468C0")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class CIDIFCJNDIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public KNOPHICLNED request;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public CIDIFCJNDIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x3C45080", Offset = "0x3C44480", VA = "0x183C45080")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private MKIJKNGGGEN KNEDOJCPCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private AADLLMCLBHB NPIBEABIIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private MIDAHBJNNBL DGFONDEJJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private NKKMLDCLAFH CMHEIEGMDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private TaskCompletionSource<OBGEECKNGII> MCODDIFAGHD;

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3247010", Offset = "0x3246410", VA = "0x183247010", Slot = "7")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x3247990", Offset = "0x3246D90", VA = "0x183247990", Slot = "6")]
	[AsyncStateMachine(typeof(JOIGKBMDFGG))]
	public Task<OBGEECKNGII> OFBADADBGOP(CancellationToken JBOBFFCKODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x32470F0", Offset = "0x32464F0", VA = "0x1832470F0", Slot = "4")]
	public void OAFIIJLGCBO(KNOPHICLNED CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x32465D0", Offset = "0x32459D0", VA = "0x1832465D0", Slot = "5")]
	public void DKMEMDLPCBK(KNOPHICLNED JOKBCMGCOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x3246EE0", Offset = "0x32462E0", VA = "0x183246EE0")]
	[AsyncStateMachine(typeof(JKGFAFABBNE))]
	private Task JIOIHGPDCEM(KNOPHICLNED PJJLMKEBMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x3247C40", Offset = "0x3247040", VA = "0x183247C40")]
	[AsyncStateMachine(typeof(PHKHAEIGCEH))]
	private Task PKLHNOIMIDD(KNOPHICLNED ALGDKILBFEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x3246C60", Offset = "0x3246060", VA = "0x183246C60")]
	[AsyncStateMachine(typeof(DDKAAFPOKIL))]
	private Task<FPOEHJGJEFB> GKJJLKMGOKJ(KNOPHICLNED PJJLMKEBMEE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x3247B20", Offset = "0x3246F20", VA = "0x183247B20")]
	private NCNPBEKEBJI PCIOPHFBIAI(KNOPHICLNED MANBGEKEGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x3246DB0", Offset = "0x32461B0", VA = "0x183246DB0")]
	[AsyncStateMachine(typeof(ELAKKGMIIFK))]
	private Task IMCLJNCPAIH(FPOEHJGJEFB KPPDIIPHNDH, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x32469E0", Offset = "0x3245DE0", VA = "0x1832469E0")]
	private FPOEHJGJEFB FCCMMCCJHOA(KNOPHICLNED PJJLMKEBMEE, NCNPBEKEBJI PMFJNBHFHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD260", Offset = "0x2DBC660", VA = "0x182DBD260")]
	private T CJPOKKINCKD<T>(T FPLJCBGEJAP) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3247530", Offset = "0x3246930", VA = "0x183247530")]
	private FPOEHJGJEFB OEJKNHFBNFG(KNOPHICLNED PJJLMKEBMEE, NCNPBEKEBJI PMFJNBHFHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GJPDNPKLGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x3247AD0", Offset = "0x3246ED0", VA = "0x183247AD0")]
	[CompilerGenerated]
	private void OIDHAAFDBGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[UnityEngine.Scripting.Preserve]
internal sealed class EMLALHKFGOB : AADLLMCLBHB, PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class DMCLOMAIKBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public DMCLOMAIKBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x3CAEEC0", Offset = "0x3CAE2C0", VA = "0x183CAEEC0")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class PAIIGCLJHKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public PAIIGCLJHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x3CC01C0", Offset = "0x3CBF5C0", VA = "0x183CC01C0")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private NKKMLDCLAFH CMHEIEGMDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private CDMJDHCPJDD DHAGGAIBNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private HPGDJAJILOJ OMLFDHIGBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private IIGBIBLGCBF MJMEGBGNFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private MAOOBHKBEAI JIACEKBJBHH;

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x323EA70", Offset = "0x323DE70", VA = "0x18323EA70", Slot = "6")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x323DA20", Offset = "0x323CE20", VA = "0x18323DA20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x323E2B0", Offset = "0x323D6B0", VA = "0x18323E2B0", Slot = "4")]
	public AAFDOAPGFME HAPNGECLAIG(KNOPHICLNED OPLCKDLCBJH)
	{
		return default(AAFDOAPGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x323CD50", Offset = "0x323C150", VA = "0x18323CD50", Slot = "5")]
	public void AJNKLLBLKPI(Guid JLOMHEMDNBP, Task OMLFMKOMCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x323EBE0", Offset = "0x323DFE0", VA = "0x18323EBE0")]
	private void NPNKNMLAJIG(byte KOIFIHCACIP, int ICEJCNKCKBG, object KGMOGBBCAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x323D2E0", Offset = "0x323C6E0", VA = "0x18323D2E0")]
	private void BNEKBCHBDDE(LMFGEIKAFKF NACBGCCHDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x323DAC0", Offset = "0x323CEC0", VA = "0x18323DAC0")]
	private void FCFMMDBBANH(LMFGEIKAFKF NACBGCCHDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x323E7B0", Offset = "0x323DBB0", VA = "0x18323E7B0")]
	private void MANCLOPHONO(LMFGEIKAFKF NACBGCCHDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x323DDA0", Offset = "0x323D1A0", VA = "0x18323DDA0")]
	private EKKOLLPPNIM FHMNEFEOABC(KNOPHICLNED MANBGEKEGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x323E050", Offset = "0x323D450", VA = "0x18323E050")]
	private void GNDDJJOGPBC(KNOPHICLNED ALGDKILBFEO, EKKOLLPPNIM EBCKEMJOFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x323EF90", Offset = "0x323E390", VA = "0x18323EF90")]
	private bool OJABELNMLNF(KNOPHICLNED ALGDKILBFEO, EKKOLLPPNIM EBCKEMJOFAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x323ECB0", Offset = "0x323E0B0", VA = "0x18323ECB0")]
	private bool OGIGHDACKOO(KNOPHICLNED JKPPICCJEEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x323CFD0", Offset = "0x323C3D0", VA = "0x18323CFD0")]
	private bool BHEBBBIOBBB(byte KOIFIHCACIP, ExitGames.Client.Photon.Hashtable NACBGCCHDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public EMLALHKFGOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[UnityEngine.Scripting.Preserve]
internal sealed class MGOAMCEAOIH : HEGGCKEGGLN, PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class NOCFFDNODAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public OBGEECKNGII operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public MGOAMCEAOIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public KNOPHICLNED roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public NOCFFDNODAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x3C54640", Offset = "0x3C53A40", VA = "0x183C54640")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x3C546B0", Offset = "0x3C53AB0", VA = "0x183C546B0")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct EAIKFIKPGNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public AsyncTaskMethodBuilder<EKKOLLPPNIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public MGOAMCEAOIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public KNOPHICLNED roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter<EKKOLLPPNIM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x3C46F80", Offset = "0x3C46380", VA = "0x183C46F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3C47510", Offset = "0x3C46910", VA = "0x183C47510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class JIGOIMPPNMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public OBGEECKNGII operationType;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JIGOIMPPNMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E6A0", Offset = "0x3C4DAA0", VA = "0x183C4E6A0")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class FPJNLHJHHCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public KNOPHICLNED request;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public FPJNLHJHHCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BB60", Offset = "0x3C4AF60", VA = "0x183C4BB60")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BBD0", Offset = "0x3C4AFD0", VA = "0x183C4BBD0")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BC40", Offset = "0x3C4B040", VA = "0x183C4BC40")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct DBEJIIBHAHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder<EKKOLLPPNIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public KNOPHICLNED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public MGOAMCEAOIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private FPJNLHJHHCK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private AAFDOAPGFME <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private EKKOLLPPNIM <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private TaskAwaiter<(EKKOLLPPNIM validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x3C45790", Offset = "0x3C44B90", VA = "0x183C45790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x3C45E90", Offset = "0x3C45290", VA = "0x183C45E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private NKKMLDCLAFH CMHEIEGMDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private CDMJDHCPJDD DHAGGAIBNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private AADLLMCLBHB NPIBEABIIHM;

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x32532A0", Offset = "0x32526A0", VA = "0x1832532A0", Slot = "5")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3252EE0", Offset = "0x32522E0", VA = "0x183252EE0", Slot = "4")]
	[AsyncStateMachine(typeof(EAIKFIKPGNK))]
	private Task<EKKOLLPPNIM> IFJJCCHGICF(KNOPHICLNED MANBGEKEGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3253020", Offset = "0x3252420", VA = "0x183253020")]
	private bool MGMLECNLDNL(OBGEECKNGII OOIKEALFDCH, out EKKOLLPPNIM CGKNIAMFPAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3252DA0", Offset = "0x32521A0", VA = "0x183252DA0")]
	[AsyncStateMachine(typeof(DBEJIIBHAHC))]
	private Task<EKKOLLPPNIM> IEAKJOCBNIA(KNOPHICLNED PJJLMKEBMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public MGOAMCEAOIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class LDBNMAFALGL : BBCAJKHGDAF, PGKAMNNFOKD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct PLBDKFIGMCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<CCLMJIMCJFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public OAILMIHJFAK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public LDBNMAFALGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<JIAGHJHJMHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3C58800", Offset = "0x3C57C00", VA = "0x183C58800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3C589E0", Offset = "0x3C57DE0", VA = "0x183C589E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class JKKLGJBBPJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JKKLGJBBPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F060", Offset = "0x3C4E460", VA = "0x183C4F060")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct NLGCLCILBMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<JIAGHJHJMHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public LDBNMAFALGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public OAILMIHJFAK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private JKKLGJBBPJJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter<MEAOKELPKFO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x3C541A0", Offset = "0x3C535A0", VA = "0x183C541A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x3C545F0", Offset = "0x3C539F0", VA = "0x183C545F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class DEIENGOLMAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public DEIENGOLMAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x1C004F0", Offset = "0x1BFF8F0", VA = "0x181C004F0")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(CLNOPKLDMLF sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private EELDLGKOJPM CMMLIBKHPCN;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly (LECBPDHMHPK superRoomData, string unityAssetId, LECBPDHMHPK subRoomData) EMNOOKPMKNE;

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x324E550", Offset = "0x324D950", VA = "0x18324E550", Slot = "5")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x324E3D0", Offset = "0x324D7D0", VA = "0x18324E3D0", Slot = "4")]
	[AsyncStateMachine(typeof(PLBDKFIGMCJ))]
	public Task<CCLMJIMCJFD> LKOHBKNLNDA(MIPBMMJKKCH KNJJIICJOLE, OAILMIHJFAK KEDDCKBKHLI, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x324E0C0", Offset = "0x324D4C0", VA = "0x18324E0C0")]
	[AsyncStateMachine(typeof(NLGCLCILBMA))]
	private Task<JIAGHJHJMHD> ACHNPLNMEAN(OAILMIHJFAK KEDDCKBKHLI, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x324E240", Offset = "0x324D640", VA = "0x18324E240")]
	private CCLMJIMCJFD CKNHHADKGEP(OAILMIHJFAK KEDDCKBKHLI, JIAGHJHJMHD GNBAMMLEGON, long BPIAGBMFLPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x324E5C0", Offset = "0x324D9C0", VA = "0x18324E5C0")]
	private (LECBPDHMHPK, string, LECBPDHMHPK) OFCKEHAELHH(OAILMIHJFAK KEDDCKBKHLI, JIAGHJHJMHD GNBAMMLEGON, long BPIAGBMFLPM)
	{
		return default((LECBPDHMHPK, string, LECBPDHMHPK));
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public LDBNMAFALGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal sealed class PBGOLNGHMMO : MIDAHBJNNBL, PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class IFENKDEDDLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public KNOPHICLNED request;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public IFENKDEDDLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x482B780", Offset = "0x482AB80", VA = "0x18482B780")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct EBLMPKIBLGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<KNOPHICLNED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public KNOPHICLNED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public PBGOLNGHMMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public NCNPBEKEBJI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private TaskAwaiter<KNOPHICLNED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x48288F0", Offset = "0x4827CF0", VA = "0x1848288F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x4828D70", Offset = "0x4828170", VA = "0x184828D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct GBFGDAJNDNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public AsyncTaskMethodBuilder<KNOPHICLNED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public PBGOLNGHMMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public NCNPBEKEBJI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<IGCPMELOMFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x4829830", Offset = "0x4828C30", VA = "0x184829830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x4829E10", Offset = "0x4829210", VA = "0x184829E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class LBCCLGFHPIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public KNOPHICLNED request;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LBCCLGFHPIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x482C7E0", Offset = "0x482BBE0", VA = "0x18482C7E0")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct DDGIFKJHJCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AsyncTaskMethodBuilder<KNOPHICLNED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public KNOPHICLNED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public PBGOLNGHMMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public NCNPBEKEBJI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private KINOPGFLEIO <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private DCEMEGMIAKN <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<IGCPMELOMFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x4825DD0", Offset = "0x48251D0", VA = "0x184825DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x4826860", Offset = "0x4825C60", VA = "0x184826860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private NKKMLDCLAFH CMHEIEGMDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private JBNFGNMGBPF IKACBHFMFBC;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private CPHIJNHNMFK IGKCECBAIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x3CC11E0", Offset = "0x3CC05E0", VA = "0x183CC11E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1540", Offset = "0x3CC0940", VA = "0x183CC1540", Slot = "8")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0DC0", Offset = "0x3CC01C0", VA = "0x183CC0DC0", Slot = "4")]
	[AsyncStateMachine(typeof(EBLMPKIBLGH))]
	public Task<KNOPHICLNED> BLLGIMBHLIK(KNOPHICLNED PJJLMKEBMEE, NCNPBEKEBJI PMFJNBHFHFC, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3CC13E0", Offset = "0x3CC07E0", VA = "0x183CC13E0", Slot = "5")]
	[AsyncStateMachine(typeof(GBFGDAJNDNL))]
	public Task<KNOPHICLNED> NNDPBNFPNIP(CancellationToken MJMCKAGGCOI, NCNPBEKEBJI PMFJNBHFHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3CC15D0", Offset = "0x3CC09D0", VA = "0x183CC15D0", Slot = "6")]
	public FIDGNAKNAGA PGBODHOEMED(FPOEHJGJEFB ENFOGPPAFKK, MIPBMMJKKCH KNJJIICJOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC10B0", Offset = "0x3CC04B0", VA = "0x183CC10B0", Slot = "7")]
	public FIDGNAKNAGA LOMEJCENEAC(FPOEHJGJEFB ENFOGPPAFKK, MIPBMMJKKCH KNJJIICJOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0F30", Offset = "0x3CC0330", VA = "0x183CC0F30")]
	[AsyncStateMachine(typeof(DDGIFKJHJCJ))]
	private Task<KNOPHICLNED> JCHBGNFCFNI(KNOPHICLNED PJJLMKEBMEE, NCNPBEKEBJI PMFJNBHFHFC, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x384F4E0", Offset = "0x384E8E0", VA = "0x18384F4E0")]
	private static byte[] HKFAELKAIMD(KNOPHICLNED CIBBLLOHCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1290", Offset = "0x3CC0690", VA = "0x183CC1290")]
	private static string NKMKOOJMDCC(byte[] DEMGJAEGHAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public PBGOLNGHMMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[UnityEngine.Scripting.Preserve]
internal sealed class OECDJNJPAOF : CDMJDHCPJDD, PGKAMNNFOKD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private MEDPDNCDEGC DEPNOOMKGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private NKKMLDCLAFH CMHEIEGMDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private MKIJKNGGGEN KNEDOJCPCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private MECBEAOLDHP NIJOHJIPDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private EELDLGKOJPM CMMLIBKHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private HFAMPDNHCGH CNHKIBBKMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private NLPLHFNOPIN HGIDDHKAAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private GKAHBEHBJIH PNMMLHPKIGP;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private KHKJJLCHIGJ EACHPFKLBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x3CBE4B0", Offset = "0x3CBD8B0", VA = "0x183CBE4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private static EKKOLLPPNIM POKAFKIADMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x3CBE490", Offset = "0x3CBD890", VA = "0x183CBE490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x3CBEAE0", Offset = "0x3CBDEE0", VA = "0x183CBEAE0", Slot = "7")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3CBE950", Offset = "0x3CBDD50", VA = "0x183CBE950", Slot = "4")]
	public EKKOLLPPNIM NJBFPBCONNL(JEHHKLECEGB DBNCGPLMAHF, OBGEECKNGII LLGLGGINHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3CBE700", Offset = "0x3CBDB00", VA = "0x183CBE700", Slot = "5")]
	public EKKOLLPPNIM KIHMIBCPFBB(JEHHKLECEGB PBPJIKMNMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x3CBE500", Offset = "0x3CBD900", VA = "0x183CBE500", Slot = "6")]
	public EKKOLLPPNIM KCDMFNEKBCC(JEHHKLECEGB PBPJIKMNMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x3CBE4A0", Offset = "0x3CBD8A0", VA = "0x183CBE4A0")]
	private static EKKOLLPPNIM EMIJJGFGNAL(MBNPGMPNOII DFCEDJEBLNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public OECDJNJPAOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class EIDLCLHOGMB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x323CD10", Offset = "0x323C110", VA = "0x18323CD10")]
	public EIDLCLHOGMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xF804F0", Offset = "0xF7F8F0", VA = "0x180F804F0")]
	public EIDLCLHOGMB(string CIBBLLOHCGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class FOOAEBKODJH : KLOMKOPCGBL, PGKAMNNFOKD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct AFHJAFDKBFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public AsyncTaskMethodBuilder<EKKOLLPPNIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public FOOAEBKODJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AMJALDODKON autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private global::PADKJAANMNM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private MIPBMMJKKCH <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private MHPFLMMJCPI <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private MIPBMMJKKCH <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<EKKOLLPPNIM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x3CAD680", Offset = "0x3CACA80", VA = "0x183CAD680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x3CADDE0", Offset = "0x3CAD1E0", VA = "0x183CADDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct GCDEPGHDMDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public FOOAEBKODJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1980", Offset = "0x3CB0D80", VA = "0x183CB1980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct KEABEHFCCEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public FOOAEBKODJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5080", Offset = "0x3CB4480", VA = "0x183CB5080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct DGFBHICODBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public FOOAEBKODJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE7F0", Offset = "0x3CADBF0", VA = "0x183CAE7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct MBMMHKNIKMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public FOOAEBKODJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E10", Offset = "0x3CB6210", VA = "0x183CB6E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct IPCBMMFPMLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public FOOAEBKODJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public OCGBNMGMCOF autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private global::PADKJAANMNM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x3CB44D0", Offset = "0x3CB38D0", VA = "0x183CB44D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private static readonly TimeSpan CBAFDEHMMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private NKKMLDCLAFH CMHEIEGMDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private EELDLGKOJPM CMMLIBKHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private MIDAHBJNNBL DGFONDEJJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private MKIJKNGGGEN KNEDOJCPCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private NLPLHFNOPIN HGIDDHKAAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private CancellationTokenSource GECKCKOGNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private Task CEOAKDEIOKN;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x32435B0", Offset = "0x32429B0", VA = "0x1832435B0", Slot = "6")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x1CD1610", Offset = "0x1CD0A10", VA = "0x181CD1610", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x3243470", Offset = "0x3242870", VA = "0x183243470", Slot = "4")]
	[AsyncStateMachine(typeof(AFHJAFDKBFN))]
	public Task<EKKOLLPPNIM> MGIEBEPIEGP(AMJALDODKON LFOFFPBKHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3242AC0", Offset = "0x3241EC0", VA = "0x183242AC0", Slot = "5")]
	[AsyncStateMachine(typeof(GCDEPGHDMDE))]
	public Task GLBJGAHJEHH([Optional] CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1CD1610", Offset = "0x1CD0A10", VA = "0x181CD1610")]
	public void AOJOFOALEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3243090", Offset = "0x3242490", VA = "0x183243090")]
	private MHPFLMMJCPI KOCKLPGEHFL(AMJALDODKON LFOFFPBKHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3242F60", Offset = "0x3242360", VA = "0x183242F60")]
	[AsyncStateMachine(typeof(KEABEHFCCEP))]
	private Task JNDBGDIJBLM(OCLGLHHAFAO FKBMHFEKLIC, CancellationToken JFEIMHDODID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x3243350", Offset = "0x3242750", VA = "0x183243350")]
	[AsyncStateMachine(typeof(DGFBHICODBF))]
	private Task LDCNOLFCCPP([Optional] CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3242860", Offset = "0x3241C60", VA = "0x183242860")]
	[AsyncStateMachine(typeof(MBMMHKNIKMP))]
	private Task BHEMCNPNIAP(TimeSpan LLDFAMOBDGB, CancellationToken JFEIMHDODID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3242CF0", Offset = "0x32420F0", VA = "0x183242CF0")]
	private Task HNJCMKAPNEC(OCGBNMGMCOF PAABLILJLLA, CancellationToken JFEIMHDODID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3242990", Offset = "0x3241D90", VA = "0x183242990")]
	[AsyncStateMachine(typeof(IPCBMMFPMLP))]
	private Task CGPNKLMJDCJ(OCGBNMGMCOF PAABLILJLLA, CancellationToken JFEIMHDODID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3242BE0", Offset = "0x3241FE0", VA = "0x183242BE0")]
	private bool HHJGOICGJGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public FOOAEBKODJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[UnityEngine.Scripting.Preserve]
internal class LFGLAKEKOIP : MECBEAOLDHP, PGKAMNNFOKD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct NLFIMLAMOEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public LFGLAKEKOIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private global::PADKJAANMNM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x3C53E70", Offset = "0x3C53270", VA = "0x183C53E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private JFCDMGDONIF AACJAEEEEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private CDMJDHCPJDD DHAGGAIBNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private MIDAHBJNNBL DGFONDEJJDO;

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x324FD80", Offset = "0x324F180", VA = "0x18324FD80", Slot = "6")]
	public void NPFGFFCDMGH(GOLPDNFBDPM GAMGMMDKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x324FBB0", Offset = "0x324EFB0", VA = "0x18324FBB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x324FC00", Offset = "0x324F000", VA = "0x18324FC00", Slot = "5")]
	[AsyncStateMachine(typeof(NLFIMLAMOEO))]
	public Task FNMBLDBDJOM(string NMGICKMLDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x324FD20", Offset = "0x324F120", VA = "0x18324FD20", Slot = "4")]
	public EKKOLLPPNIM HHJGOICGJGB(JEHHKLECEGB DBNCGPLMAHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x324FA60", Offset = "0x324EE60", VA = "0x18324FA60")]
	private JMPLNMJBEFD DOOOAHMNEGB(string NMGICKMLDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public LFGLAKEKOIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class GMGHKKGOMHF
{
	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x3248230", Offset = "0x3247630", VA = "0x183248230")]
	public static void ILOJHCDBLLG(BHKHBEKDAPI CBOODPBIPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3248150", Offset = "0x3247550", VA = "0x183248150")]
	internal static void BFCNOIIHMPK(BHKHBEKDAPI CBOODPBIPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x32483F0", Offset = "0x32477F0", VA = "0x1832483F0")]
	internal static void NJIAEGFMGEH(BHKHBEKDAPI CBOODPBIPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x32484D0", Offset = "0x32478D0", VA = "0x1832484D0")]
	internal static void NNMPEDIEPFA(BHKHBEKDAPI CBOODPBIPLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal class ACGLLJLCAMP : global::MJAAMBAMMHJ<KNOPHICLNED>
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class MGGKIMHJHJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public KNOPHICLNED message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public MGGKIMHJHJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x3CB79D0", Offset = "0x3CB6DD0", VA = "0x183CB79D0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly ACGLLJLCAMP KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private const string AAMEOOAPENF = "pl";

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3235FD0", Offset = "0x32353D0", VA = "0x183235FD0")]
	public ExitGames.Client.Photon.Hashtable DGECGJPLFOM(KNOPHICLNED CIBBLLOHCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x32361E0", Offset = "0x32355E0", VA = "0x1832361E0", Slot = "5")]
	protected override void FPNGEILNMNJ(KNOPHICLNED CIBBLLOHCGM, IDictionary<object, object> MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3235D80", Offset = "0x3235180", VA = "0x183235D80", Slot = "6")]
	public override KNOPHICLNED AHLFMBEKFNG(IDictionary<object, object> MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3236050", Offset = "0x3235450", VA = "0x183236050")]
	private static void EPMJEFBIMPO(string EENPNEENKOB, KNOPHICLNED CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x32366F0", Offset = "0x3235AF0", VA = "0x1832366F0")]
	public ACGLLJLCAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x3236320", Offset = "0x3235720", VA = "0x183236320")]
	[CompilerGenerated]
	internal static string NNGPOIFIOEO(CCLMJIMCJFD OCMDFIDHJDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class AJLEDCBCBJD
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public static EKKOLLPPNIM POKAFKIADMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x3236C10", Offset = "0x3236010", VA = "0x183236C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3236BF0", Offset = "0x3235FF0", VA = "0x183236BF0")]
	public static bool AIDBDOOGGPH(this EKKOLLPPNIM EBCKEMJOFAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3236C70", Offset = "0x3236070", VA = "0x183236C70")]
	public static EKKOLLPPNIM EMIJJGFGNAL(MBNPGMPNOII LJPMBPHCKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3237140", Offset = "0x3236540", VA = "0x183237140")]
	public static EKKOLLPPNIM OFCCKJOBANM(params EKKOLLPPNIM[] OMIMENDHDEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3236CD0", Offset = "0x32360D0", VA = "0x183236CD0")]
	public static EKKOLLPPNIM MCMGBBFAHAO(IEnumerable<EKKOLLPPNIM> OMIMENDHDEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x3236ED0", Offset = "0x32362D0", VA = "0x183236ED0")]
	public static string MGKKKCPGKPL(this EKKOLLPPNIM CGKNIAMFPAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class NAMHCFFGEIE : EKAFNCKDMBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public delegate EKKOLLPPNIM MBMCAJHJFHH([NotNull] JEHHKLECEGB HNDMBPEHNEC);

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class ILGEAEBLBCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public JEHHKLECEGB photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ILGEAEBLBCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x3C4D640", Offset = "0x3C4CA40", VA = "0x183C4D640")]
		internal EKKOLLPPNIM <Validate>b__0(MBMCAJHJFHH v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	protected readonly HashSet<MBMCAJHJFHH> BPOCBEEGIHG;

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3254450", Offset = "0x3253850", VA = "0x183254450", Slot = "4")]
	public void ODLFFMGAIGG(MBMCAJHJFHH LOJCMADPDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3254150", Offset = "0x3253550", VA = "0x183254150", Slot = "5")]
	public void GBKEIGKACBB(MBMCAJHJFHH LOJCMADPDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3254100", Offset = "0x3253500", VA = "0x183254100", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x32541B0", Offset = "0x32535B0", VA = "0x1832541B0")]
	protected EKKOLLPPNIM NGCAEDCBADA(JEHHKLECEGB PBPJIKMNMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x3246550", Offset = "0x3245950", VA = "0x183246550")]
	protected NAMHCFFGEIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public class PBHFEDJKDHG : NAMHCFFGEIE, MEDPDNCDEGC, EKAFNCKDMBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class MHLKMBABKLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public EKKOLLPPNIM result;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public MHLKMBABKLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x482D980", Offset = "0x482CD80", VA = "0x18482D980")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1890", Offset = "0x3CC0C90", VA = "0x183CC1890")]
	[UnityEngine.Scripting.Preserve]
	public PBHFEDJKDHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1700", Offset = "0x3CC0B00", VA = "0x183CC1700", Slot = "8")]
	public EKKOLLPPNIM JGDGMKFPANH(JEHHKLECEGB PBPJIKMNMJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class GJLNAGCCCDE : NAMHCFFGEIE, JFCDMGDONIF, EKAFNCKDMBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class FHOOKIIDNOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public EKKOLLPPNIM result;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public FHOOKIIDNOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B5D0", Offset = "0x3C4A9D0", VA = "0x183C4B5D0")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x3246550", Offset = "0x3245950", VA = "0x183246550")]
	[UnityEngine.Scripting.Preserve]
	public GJLNAGCCCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x32463C0", Offset = "0x32457C0", VA = "0x1832463C0", Slot = "8")]
	public EKKOLLPPNIM HHJGOICGJGB(JEHHKLECEGB NKBGOBOMGOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public enum AODFFPEIGEF
{
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class CBGDMLMOBCG
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class FBPLKPGHMCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public global::PADKJAANMNM<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public FBPLKPGHMCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x3CAFCF0", Offset = "0x3CAF0F0", VA = "0x183CAFCF0")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public const string CHDMLNOHMPJ = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public const string MECJNLOOFKP = "END: ";

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3239C90", Offset = "0x3239090", VA = "0x183239C90")]
	public static global::PADKJAANMNM<string> HIKBKDCPBJH([Optional] string LMAGPOPKGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3239B90", Offset = "0x3238F90", VA = "0x183239B90")]
	private static void DDMAHGILMLD(string NPBDKCONLNC, PNHDOMMPKKJ HMHNEOCJGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3239D60", Offset = "0x3239160", VA = "0x183239D60")]
	private static void KKNHCFOJDFI(string NPBDKCONLNC, PNHDOMMPKKJ HMHNEOCJGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3239960", Offset = "0x3238D60", VA = "0x183239960")]
	public static void AIMPOHBOFLD(global::PADKJAANMNM<string> HMHNEOCJGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3239AD0", Offset = "0x3238ED0", VA = "0x183239AD0")]
	public static string CBNBFPKHCHO(KNOPHICLNED MANBGEKEGNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class IDBKINDJKBC
{
	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x324A3E0", Offset = "0x32497E0", VA = "0x18324A3E0")]
	public static void JGMEJDFAKLK(this NKKMLDCLAFH CMHEIEGMDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x324A3F0", Offset = "0x32497F0", VA = "0x18324A3F0")]
	public static void ODJGDLANDMM(this NKKMLDCLAFH CMHEIEGMDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x324A2D0", Offset = "0x32496D0", VA = "0x18324A2D0")]
	private static void DGAABHKEBCJ(this NKKMLDCLAFH CMHEIEGMDHP, bool GNIPHJLDLLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class NHFAOMEEHML : EIPBLKPHMFE, HIPAPOMCLID, BLHFANMACHC, HPGHJMBMJBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private readonly HIPAPOMCLID IPHJMHACGND;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public JEHHKLECEGB JLDBICMPKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA460", Offset = "0x3CB9860", VA = "0x183CBA460", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int POOBOFHKNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA280", Offset = "0x3CB9680", VA = "0x183CBA280", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int GDOBDMMHNGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA370", Offset = "0x3CB9770", VA = "0x183CBA370", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool BNLPKLKPHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x798260", Offset = "0x797660", VA = "0x180798260", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public int ABDANABMPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x6C6940", Offset = "0x6C5D40", VA = "0x1806C6940", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event CCDJNMKLABL.AHIKDMDGGDL MMJOGHDCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event BHKENKGPLJP LAHBPHMJLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9EB0", Offset = "0x3CB92B0", VA = "0x183CB9EB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA2D0", Offset = "0x3CB96D0", VA = "0x183CBA2D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<bool> PHEDILJEPPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<JEHHKLECEGB> GHCPIMCKJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action JHMELDMDMHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA3C0", Offset = "0x3CB97C0", VA = "0x183CBA3C0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA050", Offset = "0x3CB9450", VA = "0x183CBA050", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x14CED70", Offset = "0x14CE170", VA = "0x1814CED70")]
	public NHFAOMEEHML(HIPAPOMCLID IPHJMHACGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x3CBA1D0", Offset = "0x3CB95D0", VA = "0x183CBA1D0", Slot = "8")]
	public bool JLOFKOOHDLC(byte KOIFIHCACIP, ExitGames.Client.Photon.Hashtable PNBBMKDMDKE, IMLIINHNGKM JBOJCCEAKCK, SendOptions CONDIEAKEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9FB0", Offset = "0x3CB93B0", VA = "0x183CB9FB0", Slot = "29")]
	public JEHHKLECEGB FPHAFIOHJFH(int EECFAEEFJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3CBA0F0", Offset = "0x3CB94F0", VA = "0x183CBA0F0", Slot = "16")]
	public JEHHKLECEGB IMFIDMGKPGC(int HOHMOBPJMJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "19")]
	public void DKNCMJACBHN(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "20")]
	public void JIGKACKGAJN(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "21")]
	public void NEOHDMLNANO(object JCHAGIDHJIB, bool HBPAJJFPAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9F50", Offset = "0x3CB9350", VA = "0x183CB9F50", Slot = "22")]
	public IDisposable CMDPKMAAKAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "23")]
	private bool EALKMAAOBOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "24")]
	public void FIIDLBKIEMO(StringBuilder FPLMDNKILDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x3CBA4B0", Offset = "0x3CB98B0", VA = "0x183CBA4B0", Slot = "25")]
	public bool OLJAAAGDKNN(bool GFHPOFGODBJ, out string MCGMECECHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	public void APHNFKFIECJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x1D08810", Offset = "0x1D07C10", VA = "0x181D08810", Slot = "28")]
	public void FAJALKBINMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal struct LMFGEIKAFKF
{
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public const string IMDHFOEMCPG = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public const string GEJCPDHNMIA = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private readonly IDictionary<object, object> NACBGCCHDIJ;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool NFDBEOJPGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9F9730", Offset = "0x9F8B30", VA = "0x1809F9730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x7809C0", Offset = "0x77FDC0", VA = "0x1807809C0")]
	public LMFGEIKAFKF(IDictionary<object, object> NACBGCCHDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x3250220", Offset = "0x324F620", VA = "0x183250220")]
	public bool AFDGPLLJIJF(out KNOPHICLNED CIBBLLOHCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x32502E0", Offset = "0x324F6E0", VA = "0x1832502E0")]
	public Guid ALMLLKKBMMH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x32503C0", Offset = "0x324F7C0", VA = "0x1832503C0")]
	public EKKOLLPPNIM MFCNHIFFIKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x3250520", Offset = "0x324F920", VA = "0x183250520")]
	public static ExitGames.Client.Photon.Hashtable PELCFOCODBC(KNOPHICLNED CIBBLLOHCGM, EKKOLLPPNIM EBCKEMJOFAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal static class CEAIMCIOIDN
{
	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x323A820", Offset = "0x3239C20", VA = "0x18323A820")]
	public static string BFOPMKLFFOB(this OAILMIHJFAK CNMCCMNNBPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x323AA70", Offset = "0x3239E70", VA = "0x18323AA70")]
	public static bool EFFFHKCOKHM(this OAILMIHJFAK CNMCCMNNBPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct DKAAMFPFCDG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct HAJGNINBDGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public DKAAMFPFCDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x3CB25E0", Offset = "0x3CB19E0", VA = "0x183CB25E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly CancellationTokenSource NFMAFINMMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private Task IGPMHCEBGGP;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool NFDBEOJPGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x323BBD0", Offset = "0x323AFD0", VA = "0x18323BBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	internal Task NGBLAGGDOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x323BC00", Offset = "0x323B000", VA = "0x18323BC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x323BDB0", Offset = "0x323B1B0", VA = "0x18323BDB0")]
	public DKAAMFPFCDG(CancellationToken MJMCKAGGCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x323BC80", Offset = "0x323B080", VA = "0x18323BC80")]
	[AsyncStateMachine(typeof(HAJGNINBDGL))]
	public Task OGDDONKAJIF(Func<CancellationToken, List<Task>> APLJEDKBCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x323BB80", Offset = "0x323AF80", VA = "0x18323BB80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public readonly struct JFANLJIHJDN<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct PGNEGKJKDCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder<global::DPAEKNFIIFN<global::BMEALCICMDB<TData>, GKAEBCMEFAL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public global::JFANLJIHJDN<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private MIPBMMJKKCH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter<global::DPAEKNFIIFN<byte[], GKAEBCMEFAL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x4346050", Offset = "0x4345450", VA = "0x184346050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x37090E0", Offset = "0x37084E0", VA = "0x1837090E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly global::JJDHKAEFBFK<TGetDataArg, TData> PPHNDGGADPC;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x7809C0", Offset = "0x77FDC0", VA = "0x1807809C0")]
	internal JFANLJIHJDN(global::JJDHKAEFBFK<TGetDataArg, TData> DNELEABCBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x327C120", Offset = "0x327B520", VA = "0x18327C120")]
	[AsyncStateMachine(typeof(global::JFANLJIHJDN<, >.PGNEGKJKDCK))]
	public Task<global::DPAEKNFIIFN<global::BMEALCICMDB<TData>, GKAEBCMEFAL>> AJGDDCNEKFB(TGetDataArg DEMGJAEGHAE, string PIGJPBPDHOL, MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public static class MCPGKFOAHGO
{
	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2D7CD30", Offset = "0x2D7C130", VA = "0x182D7CD30")]
	public static global::JFANLJIHJDN<TGetDataArg, TData> GEGCLDEHDAN<TGetDataArg, TData>(global::JJDHKAEFBFK<TGetDataArg, TData> DNELEABCBIJ)
	{
		return default(global::JFANLJIHJDN<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class PAJJLIFLOGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private readonly BEFJBNCFADF LPGNDACFCPO;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private const string HIMNEAEMELF = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private const string BBGPLFOJDOA = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private const string NCLPKHMLGCM = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private const string JJEHDOCPAFN = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private const string EEBMHIMKBLK = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private string LCHIGGKCBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private long? NKFLHMLCNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private long? BAJMJOBENLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private IFLKGDBGJPO DOMGNEMCFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private long? AHGNOHJIPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private bool NKMDMJDONOB;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string NNNPIJKHCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public long DKFIPGEJMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x3CC07C0", Offset = "0x3CBFBC0", VA = "0x183CC07C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public long IDHHJENLDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0D20", Offset = "0x3CC0120", VA = "0x183CC0D20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IFLKGDBGJPO PEINIMFFPBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E70", Offset = "0x6F8270", VA = "0x1806F8E70")]
		get
		{
			return default(IFLKGDBGJPO);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x3CC06D0", Offset = "0x3CBFAD0", VA = "0x183CC06D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public long EENGAIABJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0820", Offset = "0x3CBFC20", VA = "0x183CC0820")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0D80", Offset = "0x3CC0180", VA = "0x183CC0D80")]
	[UnityEngine.Scripting.Preserve]
	public PAJJLIFLOGC([ANGFGGDOPHE(null)] BEFJBNCFADF LPGNDACFCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0520", Offset = "0x3CBF920", VA = "0x183CC0520")]
	private void FPANNECJNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0880", Offset = "0x3CBFC80", VA = "0x183CC0880")]
	public void LIAGMDAGOAE(long COLNHBBPCAP, long BPIAGBMFLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0C30", Offset = "0x3CC0030", VA = "0x183CC0C30")]
	public void MNENKNIGBAE(string CEKIFHEBLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0230", Offset = "0x3CBF630", VA = "0x183CC0230")]
	public void EFNCEPCIGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal class FIDGNAKNAGA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct MPFPFECDMPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public AsyncTaskMethodBuilder<KNOPHICLNED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public KNOPHICLNED roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public FIDGNAKNAGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private MIPBMMJKKCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private TaskAwaiter<OJFBNEMFIIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8A40", Offset = "0x3CB7E40", VA = "0x183CB8A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8D50", Offset = "0x3CB8150", VA = "0x183CB8D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct NEIMEOCOFPC<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private sealed class BEKPCBGFAAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public KNOPHICLNED roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BEKPCBGFAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE000", Offset = "0x3CAD400", VA = "0x183CAE000")]
		internal KNOPHICLNED <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct MAGKABIAGJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public AsyncTaskMethodBuilder<OJFBNEMFIIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public KNOPHICLNED roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public FIDGNAKNAGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private KINOPGFLEIO <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private TaskAwaiter<OJFBNEMFIIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x3CB65E0", Offset = "0x3CB59E0", VA = "0x183CB65E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6DC0", Offset = "0x3CB61C0", VA = "0x183CB6DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct BLKIMLEFLHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public FIDGNAKNAGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE400", Offset = "0x3CAD800", VA = "0x183CAE400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class APIPCAHJCDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public APIPCAHJCDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x3CADE30", Offset = "0x3CAD230", VA = "0x183CADE30")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class BCAAOLKEAOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BCAAOLKEAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x3CADFA0", Offset = "0x3CAD3A0", VA = "0x183CADFA0")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private sealed class FBGHAFNKMBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public FBGHAFNKMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x3CAF8C0", Offset = "0x3CAECC0", VA = "0x183CAF8C0")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class MOBHOJKDEHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public MOBHOJKDEHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x3CB89D0", Offset = "0x3CB7DD0", VA = "0x183CB89D0")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class FHCAPBKMICO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public FIDGNAKNAGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public FHCAPBKMICO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0270", Offset = "0x3CAF670", VA = "0x183CB0270")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class NLLLEPOPCGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public FIDGNAKNAGA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public NLLLEPOPCGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA620", Offset = "0x3CB9A20", VA = "0x183CBA620")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private static readonly Guid KNCCHCENCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public readonly FPOEHJGJEFB EEMNHICDDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly CPHIJNHNMFK ALCDJKDIIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly BLHFANMACHC CMHEIEGMDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private readonly HPGHJMBMJBC FGIKELKHPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private bool AHKNIBLFOIF;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x3241980", Offset = "0x3240D80", VA = "0x183241980")]
	public FIDGNAKNAGA(FPOEHJGJEFB KPPDIIPHNDH, CPHIJNHNMFK ALCDJKDIIMG, BLHFANMACHC CMHEIEGMDHP, HPGHJMBMJBC FGIKELKHPND, MIPBMMJKKCH KNJJIICJOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x32402B0", Offset = "0x323F6B0", VA = "0x1832402B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x32402B0", Offset = "0x323F6B0", VA = "0x1832402B0")]
	public void BCNBCCFENCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x3240130", Offset = "0x323F530", VA = "0x183240130")]
	public void AMLIHLHMOJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x3240E30", Offset = "0x3240230", VA = "0x183240E30")]
	public void GGALNJAMAMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x3240740", Offset = "0x323FB40", VA = "0x183240740")]
	[AsyncStateMachine(typeof(MPFPFECDMPN))]
	internal Task<KNOPHICLNED> CJPGJDMAMNM(MIPBMMJKKCH KNJJIICJOLE, KNOPHICLNED MANBGEKEGNP, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x384F4E0", Offset = "0x384E8E0", VA = "0x18384F4E0")]
	private static byte[] LFIDKJBLNAM<T>(T CIBBLLOHCGM) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x384F330", Offset = "0x384E730", VA = "0x18384F330")]
	private static T KAAKBJBLHNP<T>(MessageParser<T> ILGBCAOOJCB, byte[] CIBBLLOHCGM, T NBFEHKAOJAA) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x32412B0", Offset = "0x32406B0", VA = "0x1832412B0")]
	[AsyncStateMachine(typeof(MAGKABIAGJL))]
	private Task<OJFBNEMFIIJ> KMHKOFOCECL(KNOPHICLNED MANBGEKEGNP, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x384F050", Offset = "0x384E450", VA = "0x18384F050")]
	[AsyncStateMachine(typeof(FCPBCENNKEL))]
	internal Task<T> CPCBAOBMMJN<T>(CancellationToken JFEIMHDODID, Func<CancellationToken, Task<T>> KKPPAOENEHN, int GJKFNHPEBKP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x3240950", Offset = "0x323FD50", VA = "0x183240950")]
	[AsyncStateMachine(typeof(BLKIMLEFLHF))]
	internal Task CPCBAOBMMJN(CancellationToken JFEIMHDODID, Func<CancellationToken, Task> KKPPAOENEHN, int GJKFNHPEBKP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x32408C0", Offset = "0x323FCC0", VA = "0x1832408C0")]
	public KNOPHICLNED CPAOHEGIAPI(KINOPGFLEIO HCDAAHMBHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x3240640", Offset = "0x323FA40", VA = "0x183240640")]
	public IFDIMGJBHNK BKFGDEMPHMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x3240DC0", Offset = "0x32401C0", VA = "0x183240DC0")]
	public OEAKLMLGIKJ FNOHMAMOABC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x3240F80", Offset = "0x3240380", VA = "0x183240F80")]
	public MAMPEHPGOLC IEOCFIPEGOP([Optional] BOPNJOMCJCD? EMLKPOBLHAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x3240280", Offset = "0x323F680", VA = "0x183240280")]
	public void AMMNEAOGAFE(Func<Guid, bool> NGINFEJBBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x32410D0", Offset = "0x32404D0", VA = "0x1832410D0")]
	public void JNJPPJLAAIH(Func<Guid, bool> ABPLODKKIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3241560", Offset = "0x3240960", VA = "0x183241560")]
	public void LJBJJNEAHBB(Func<Guid, bool> NGINFEJBBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x3241700", Offset = "0x3240B00", VA = "0x183241700")]
	public Guid OFEOLKPHNEA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x3240460", Offset = "0x323F860", VA = "0x183240460")]
	public void BGIOGCABMDO(Guid MCEDDCCLFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x3241410", Offset = "0x3240810", VA = "0x183241410")]
	public void KMIHJGDLDOA(KNOPHICLNED JFLHJLNMMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x3240AA0", Offset = "0x323FEA0", VA = "0x183240AA0")]
	public void EPMJEFBIMPO(string LFPODICNGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x3240C30", Offset = "0x3240030", VA = "0x183240C30")]
	public void EPMJEFBIMPO(Func<string> MMEJEIBJGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x384EC60", Offset = "0x384E060", VA = "0x18384EC60")]
	private T CJPOKKINCKD<T>(T FPLJCBGEJAP) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x32405F0", Offset = "0x323F9F0", VA = "0x1832405F0")]
	public void BGNAPPIEOIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x384ED40", Offset = "0x384E140", VA = "0x18384ED40")]
	[CompilerGenerated]
	internal static string CNAINGBCMMF<T>(byte[] GJDBLJLIDDI, int NMNIMBGHCBL, ref NEIMEOCOFPC<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal sealed class JFPOKFBMJIL : FPOEHJGJEFB
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class HAFGAOBBEDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HAFGAOBBEDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C6A0", Offset = "0x3C4BAA0", VA = "0x183C4C6A0")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct HLFHEABACOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public JFPOKFBMJIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public FIDGNAKNAGA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private OEAKLMLGIKJ <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C710", Offset = "0x3C4BB10", VA = "0x183C4C710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class IMLHCJNJFGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public NFAEEPLGGPJ presence;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public IMLHCJNJFGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x3C4DE90", Offset = "0x3C4D290", VA = "0x183C4DE90")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private readonly CCLMJIMCJFD HGCIHMIBCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private readonly OAILMIHJFAK MHAPMKMEKNI;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private const bool JLNCFJAGGOB = false;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x324B620", Offset = "0x324AA20", VA = "0x18324B620")]
	public JFPOKFBMJIL(CCLMJIMCJFD HGCIHMIBCBK, OAILMIHJFAK MHAPMKMEKNI, Guid JLOMHEMDNBP, GOLPDNFBDPM GAMGMMDKBIL, NCNPBEKEBJI OCLGLCIKIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x324B280", Offset = "0x324A680", VA = "0x18324B280", Slot = "8")]
	[AsyncStateMachine(typeof(HLFHEABACOM))]
	protected override Task OKIKPAJCKOH(FIDGNAKNAGA GHCBFJMJKDF, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x324B3D0", Offset = "0x324A7D0", VA = "0x18324B3D0")]
	private NFAEEPLGGPJ OMBPIIDPMLK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal class MHPFLMMJCPI : FPOEHJGJEFB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct KPDICFIGJHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public MHPFLMMJCPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public FIDGNAKNAGA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private MIPBMMJKKCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private TaskAwaiter<HEDEMNPEDMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x3C515B0", Offset = "0x3C509B0", VA = "0x183C515B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private readonly int LJDKKEFKNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private readonly AMJALDODKON KGEMKNACOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public readonly long PCBFOPHPCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public readonly long CHMCBNHIBEP;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public HEDEMNPEDMH EOMABGNBJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x8201E0", Offset = "0x81F5E0", VA = "0x1808201E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x8AC070", Offset = "0x8AB470", VA = "0x1808AC070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x3253490", Offset = "0x3252890", VA = "0x183253490")]
	public MHPFLMMJCPI(Guid JLOMHEMDNBP, GOLPDNFBDPM GAMGMMDKBIL, NCNPBEKEBJI OCLGLCIKIMF, int LJDKKEFKNDI, AMJALDODKON KGEMKNACOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x3253350", Offset = "0x3252750", VA = "0x183253350", Slot = "8")]
	[AsyncStateMachine(typeof(KPDICFIGJHC))]
	protected override Task OKIKPAJCKOH(FIDGNAKNAGA GHCBFJMJKDF, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal abstract class GBGCOPOBBMM : FPOEHJGJEFB
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class GHMHPKDLFMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public GBGCOPOBBMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public DIIBBGOJBHM playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public GHMHPKDLFMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2520", Offset = "0x3CB1920", VA = "0x183CB2520")]
		internal Task <RunAsync>b__0(MIPBMMJKKCH postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2560", Offset = "0x3CB1960", VA = "0x183CB2560")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct IEKAMOMJPBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public GBGCOPOBBMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public FIDGNAKNAGA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private GHMHPKDLFMF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2D60", Offset = "0x3CB2160", VA = "0x183CB2D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct EPJIBAPIJJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public DIIBBGOJBHM playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public GBGCOPOBBMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private MIPBMMJKKCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x3CAF400", Offset = "0x3CAE800", VA = "0x183CAF400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x3245850", Offset = "0x3244C50", VA = "0x183245850")]
	public GBGCOPOBBMM(Guid JLOMHEMDNBP, GOLPDNFBDPM GAMGMMDKBIL, NCNPBEKEBJI OCLGLCIKIMF, string MGDDCMAFDMI, JGOHEHCNFEL OOIKEALFDCH, bool JCHNFMBMNBD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x3245700", Offset = "0x3244B00", VA = "0x183245700", Slot = "8")]
	[AsyncStateMachine(typeof(IEKAMOMJPBO))]
	protected override Task OKIKPAJCKOH(FIDGNAKNAGA GHCBFJMJKDF, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task OOCJPJFPIDF(FIDGNAKNAGA GHCBFJMJKDF, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x32455A0", Offset = "0x32449A0", VA = "0x1832455A0")]
	[AsyncStateMachine(typeof(EPJIBAPIJJB))]
	private Task DNFEALFOELE(IDisposable HNAGMKODCFD, DIIBBGOJBHM NCLDMOFHJCL, MIPBMMJKKCH HMHNEOCJGLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal class MBELMLFNBGP : FPOEHJGJEFB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct DBJNKPPJAGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public MBELMLFNBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public FIDGNAKNAGA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private TaskAwaiter<OMDMCGFKGDM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x3C45EE0", Offset = "0x3C452E0", VA = "0x183C45EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly OCGBNMGMCOF PAABLILJLLA;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x3252A40", Offset = "0x3251E40", VA = "0x183252A40")]
	public MBELMLFNBGP(Guid JLOMHEMDNBP, GOLPDNFBDPM GAMGMMDKBIL, NCNPBEKEBJI OCLGLCIKIMF, OCGBNMGMCOF PAABLILJLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x3252820", Offset = "0x3251C20", VA = "0x183252820", Slot = "7")]
	protected override string HAOBHECDFDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x3252900", Offset = "0x3251D00", VA = "0x183252900", Slot = "8")]
	[AsyncStateMachine(typeof(DBJNKPPJAGN))]
	protected override Task OKIKPAJCKOH(FIDGNAKNAGA GHCBFJMJKDF, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal abstract class FPOEHJGJEFB : JPMEPLFEOKB
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public delegate Task PJFJLHNOAJK(MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class HHHEOAALNEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public MIPBMMJKKCH operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public FPOEHJGJEFB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HHHEOAALNEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2830", Offset = "0x3CB1C30", VA = "0x183CB2830")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class JEIPKBLJJPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public HHHEOAALNEL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JEIPKBLJJPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4890", Offset = "0x3CB3C90", VA = "0x183CB4890")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4950", Offset = "0x3CB3D50", VA = "0x183CB4950")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct FJNFLGANLMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public FPOEHJGJEFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public Func<FPOEHJGJEFB, MIPBMMJKKCH, FIDGNAKNAGA> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private HHHEOAALNEL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private FIDGNAKNAGA <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private TaskAwaiter<KNOPHICLNED> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x3CB04F0", Offset = "0x3CAF8F0", VA = "0x183CB04F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private struct DCIFEFJBHLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public FPOEHJGJEFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE560", Offset = "0x3CAD960", VA = "0x183CAE560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public readonly Guid BCCHIKAMDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public readonly ByteString IIDOGEADCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public readonly NCNPBEKEBJI HNCEKGDHBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	protected readonly string JNKDNIHODEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private readonly GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly bool JCHNFMBMNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private readonly Queue<PJFJLHNOAJK> HIOCJFJLDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private readonly NPFGJMKHLLJ HHGKLFPPCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private readonly JGOHEHCNFEL OOIKEALFDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private bool DLMGMKAJLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public IFLKGDBGJPO PEAMDMEEJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public IFLKGDBGJPO CCMBELFPEMK;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public GOLPDNFBDPM NLFJDMEGNNP
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x6C72D0", Offset = "0x6C66D0", VA = "0x1806C72D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public EELDLGKOJPM PBGLAENKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x3244FC0", Offset = "0x32443C0", VA = "0x183244FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public KHAALFBNGAL MEJNIMKHLEB
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x3244D50", Offset = "0x3244150", VA = "0x183244D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public KHKJJLCHIGJ EACHPFKLBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x3245010", Offset = "0x3244410", VA = "0x183245010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public float DOMCCMPOCJF
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x3245440", Offset = "0x3244840", VA = "0x183245440", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event BNKPPKJPPFB AMEPKCMHGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x3245420", Offset = "0x3244820", VA = "0x183245420", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x3244F60", Offset = "0x3244360", VA = "0x183244F60", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x3245460", Offset = "0x3244860", VA = "0x183245460")]
	protected FPOEHJGJEFB(Guid JLOMHEMDNBP, GOLPDNFBDPM GAMGMMDKBIL, NCNPBEKEBJI OCLGLCIKIMF, string MGDDCMAFDMI, JGOHEHCNFEL OOIKEALFDCH, bool JCHNFMBMNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x3244F80", Offset = "0x3244380", VA = "0x183244F80", Slot = "7")]
	protected virtual string HAOBHECDFDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x32453C0", Offset = "0x32447C0", VA = "0x1832453C0")]
	public void LPMIBEJJIGC(PJFJLHNOAJK NHPEDPGHBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x3244A50", Offset = "0x3243E50", VA = "0x183244A50")]
	protected void ABGIDNHNDHE(float KONDPAFENHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x3244C00", Offset = "0x3244000", VA = "0x183244C00")]
	[AsyncStateMachine(typeof(FJNFLGANLMN))]
	public Task BFJDGLKAEGF(CancellationToken MJMCKAGGCOI, MIPBMMJKKCH KNJJIICJOLE, [Optional] Func<FPOEHJGJEFB, MIPBMMJKKCH, FIDGNAKNAGA> NJNBKBFOKIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x3244A70", Offset = "0x3243E70", VA = "0x183244A70")]
	private void BCCHCBHIPMH(bool CCMACNPGBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x3245090", Offset = "0x3244490", VA = "0x183245090")]
	private void IHBIJFKBDDL(FIDGNAKNAGA GHCBFJMJKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task OKIKPAJCKOH(FIDGNAKNAGA GHCBFJMJKDF, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x3244E20", Offset = "0x3244220", VA = "0x183244E20")]
	[AsyncStateMachine(typeof(DCIFEFJBHLE))]
	private Task DDNCFJPOKEG(MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x3244DA0", Offset = "0x32441A0", VA = "0x183244DA0")]
	public KNOPHICLNED CPAOHEGIAPI(KINOPGFLEIO HCDAAHMBHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x32452E0", Offset = "0x32446E0", VA = "0x1832452E0")]
	[CompilerGenerated]
	private Task KNMJCELDAFK(CancellationToken MOGPOAHNFIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal sealed class EOPKCLNPLML : GBGCOPOBBMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct IJGHMKFIMLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public EOPKCLNPLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public FIDGNAKNAGA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private FKHOLCDLGLO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private OEAKLMLGIKJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3480", Offset = "0x3CB2880", VA = "0x183CB3480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly CCLMJIMCJFD JMFAPLOAJLD;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x323F7C0", Offset = "0x323EBC0", VA = "0x18323F7C0")]
	public EOPKCLNPLML(Guid JLOMHEMDNBP, GOLPDNFBDPM GAMGMMDKBIL, CCLMJIMCJFD JMFAPLOAJLD, NCNPBEKEBJI OCLGLCIKIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x323F670", Offset = "0x323EA70", VA = "0x18323F670", Slot = "9")]
	[AsyncStateMachine(typeof(IJGHMKFIMLO))]
	protected override Task OOCJPJFPIDF(FIDGNAKNAGA GHCBFJMJKDF, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal class JMPLNMJBEFD : FPOEHJGJEFB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct IEAGNHEANOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public JMPLNMJBEFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public FIDGNAKNAGA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private TaskAwaiter<OMDMCGFKGDM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x3C4CFA0", Offset = "0x3C4C3A0", VA = "0x183C4CFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private readonly string IFLELKJMIFB;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x324C0F0", Offset = "0x324B4F0", VA = "0x18324C0F0")]
	public JMPLNMJBEFD(Guid JLOMHEMDNBP, GOLPDNFBDPM GAMGMMDKBIL, NCNPBEKEBJI OCLGLCIKIMF, string IFLELKJMIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x324BFC0", Offset = "0x324B3C0", VA = "0x18324BFC0", Slot = "8")]
	[AsyncStateMachine(typeof(IEAGNHEANOL))]
	protected override Task OKIKPAJCKOH(FIDGNAKNAGA GHCBFJMJKDF, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class CCANBEDHFMF : GBGCOPOBBMM
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class MJPKLOJNFOP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public AsyncTaskMethodBuilder<KNOPHICLNED> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public MJPKLOJNFOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			private TaskAwaiter<OMDMCGFKGDM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			private TaskAwaiter<KNOPHICLNED> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x4832EF0", Offset = "0x48322F0", VA = "0x184832EF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x4833240", Offset = "0x4832640", VA = "0x184833240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public CCANBEDHFMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public MAMPEHPGOLC serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public IFDIMGJBHNK uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public MJPKLOJNFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x3CB7D80", Offset = "0x3CB7180", VA = "0x183CB7D80")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<KNOPHICLNED> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct IKELJPHFKCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public CCANBEDHFMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public FIDGNAKNAGA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private MJPKLOJNFOP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private FKHOLCDLGLO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private OEAKLMLGIKJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TaskAwaiter<KNOPHICLNED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3A50", Offset = "0x3CB2E50", VA = "0x183CB3A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly int GKEHNDPJBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	[CanBeNull]
	private readonly KHFJKINMMAE BMOJANKKHDC;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x323A250", Offset = "0x3239650", VA = "0x18323A250")]
	public CCANBEDHFMF(Guid JLOMHEMDNBP, GOLPDNFBDPM GAMGMMDKBIL, int GKEHNDPJBOF, KHFJKINMMAE BMOJANKKHDC, NCNPBEKEBJI OCLGLCIKIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x323A0F0", Offset = "0x32394F0", VA = "0x18323A0F0", Slot = "9")]
	[AsyncStateMachine(typeof(IKELJPHFKCL))]
	protected override Task OOCJPJFPIDF(FIDGNAKNAGA GHCBFJMJKDF, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x3239E60", Offset = "0x3239260", VA = "0x183239E60")]
	private void CGBCDPEELFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x3239F50", Offset = "0x3239350", VA = "0x183239F50")]
	private void HODPMGEJCKI(MIPBMMJKKCH KNJJIICJOLE, FKHOLCDLGLO MILONKEOIFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal abstract class HMFLHMEOFKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public readonly FPOEHJGJEFB EEMNHICDDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public readonly FIDGNAKNAGA PCKAGDFFFFK;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public EELDLGKOJPM PBGLAENKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x3249530", Offset = "0x3248930", VA = "0x183249530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public KHKJJLCHIGJ EACHPFKLBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x3249580", Offset = "0x3248980", VA = "0x183249580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x3249610", Offset = "0x3248A10", VA = "0x183249610")]
	protected HMFLHMEOFKK(FIDGNAKNAGA GHCBFJMJKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x3249370", Offset = "0x3248770", VA = "0x183249370")]
	protected void EPMJEFBIMPO(string LFPODICNGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x3249390", Offset = "0x3248790", VA = "0x183249390")]
	public void EPMJEFBIMPO(Func<string> MMEJEIBJGDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct ILPNBJBNLCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public Dictionary<Guid, List<NKPFEHNNMMA>> DOJLFIKOBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public Dictionary<Guid, List<NKPFEHNNMMA>> JBAHIJOGIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public Dictionary<Guid, List<NKPFEHNNMMA>> NKHAKPICIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public List<Guid> OBGLINKIEJA;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x324AB30", Offset = "0x3249F30", VA = "0x18324AB30")]
	public static ILPNBJBNLCA PEBNPJONHNJ(EELDLGKOJPM CMMLIBKHPCN, IFLKGDBGJPO NFJBOGPFGFJ, OCLGLHHAFAO HIDNHJFMIMB)
	{
		return default(ILPNBJBNLCA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal struct LNMMMABFJOP
{
	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0")]
	public static LNMMMABFJOP PELCFOCODBC()
	{
		return default(LNMMMABFJOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void NHKGAHAOOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void HAMNNPKAHBI(OCLGLHHAFAO MPEBBGJJODN, object FCEBLLIOAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void NMGHMINOEBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal struct MEAOKELPKFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public readonly JIAGHJHJMHD MDHLICGIKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public readonly CLNOPKLDMLF OMMJBOPNGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public readonly LKHDFEKNHMI IBPLPONFJOL;

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x3252AE0", Offset = "0x3251EE0", VA = "0x183252AE0")]
	public MEAOKELPKFO(JIAGHJHJMHD MDHLICGIKHL, CLNOPKLDMLF OMMJBOPNGPM, LKHDFEKNHMI IBPLPONFJOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal struct COKMEONCFGB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private readonly FIDGNAKNAGA GHCBFJMJKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private readonly Guid MCEDDCCLFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private bool CCMACNPGBGB;

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x323B470", Offset = "0x323A870", VA = "0x18323B470")]
	public static COKMEONCFGB OFEOLKPHNEA(FIDGNAKNAGA GHCBFJMJKDF)
	{
		return default(COKMEONCFGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0xCC9730", Offset = "0xCC8B30", VA = "0x180CC9730")]
	public void LBFMGIOEJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x323B460", Offset = "0x323A860", VA = "0x18323B460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x323B550", Offset = "0x323A950", VA = "0x18323B550")]
	private COKMEONCFGB(FIDGNAKNAGA GHCBFJMJKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x323B120", Offset = "0x323A520", VA = "0x18323B120")]
	private void BGIOGCABMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x323B4A0", Offset = "0x323A8A0", VA = "0x18323B4A0")]
	private Func<Guid, bool> ONKFOMBDGPE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal class OEAKLMLGIKJ : HMFLHMEOFKK, JPMEPLFEOKB
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public delegate Task<IFLKGDBGJPO> BIOHJKPBDAO(OCLGLHHAFAO MPEBBGJJODN, LFIANFENBMG EIEDFMEJOJK, NPFGJMKHLLJ OIAJHHLDCGM, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct FEMMDDLMFAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public CCLMJIMCJFD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private COKMEONCFGB <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private TaskAwaiter<KNOPHICLNED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x48294B0", Offset = "0x48288B0", VA = "0x1848294B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct DFGOIEMOBCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public AsyncTaskMethodBuilder<KNOPHICLNED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public CCLMJIMCJFD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private MIPBMMJKKCH <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private TaskAwaiter<KNOPHICLNED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x48268B0", Offset = "0x4825CB0", VA = "0x1848268B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x4826BD0", Offset = "0x4825FD0", VA = "0x184826BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct IGHPDAIFPBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CCLMJIMCJFD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private MIPBMMJKKCH <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x482BCC0", Offset = "0x482B0C0", VA = "0x18482BCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class LAHIIMCFGOI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010E")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public AsyncTaskMethodBuilder<MEAOKELPKFO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public LAHIIMCFGOI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			private MEAOKELPKFO <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private TaskAwaiter<IFLKGDBGJPO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private TaskAwaiter<MEAOKELPKFO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x48319E0", Offset = "0x4830DE0", VA = "0x1848319E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x4831FF0", Offset = "0x48313F0", VA = "0x184831FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public AsyncTaskMethodBuilder<OCLGLHHAFAO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public LAHIIMCFGOI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			private OCLGLHHAFAO <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private TaskAwaiter<IFLKGDBGJPO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private TaskAwaiter<OCLGLHHAFAO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x4832040", Offset = "0x4831440", VA = "0x184832040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x4832570", Offset = "0x4831970", VA = "0x184832570", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public LAHIIMCFGOI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private bool <isReloadingSceneForObjectModel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			private TaskAwaiter<IFLKGDBGJPO> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			private LFIANFENBMG <timedYielder>5__3;

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x48307C0", Offset = "0x482FBC0", VA = "0x1848307C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public CCLMJIMCJFD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public NPFGJMKHLLJ preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public NPFGJMKHLLJ downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public MEAOKELPKFO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public NPFGJMKHLLJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public OCLGLHHAFAO phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public HEEMOONFCAF.GCONECGKFJD <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LAHIIMCFGOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x482C520", Offset = "0x482B920", VA = "0x18482C520")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<MEAOKELPKFO> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x482C660", Offset = "0x482BA60", VA = "0x18482C660")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<OCLGLHHAFAO> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x482C7A0", Offset = "0x482BBA0", VA = "0x18482C7A0")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x482C3F0", Offset = "0x482B7F0", VA = "0x18482C3F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct NKABGIGPMJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public CCLMJIMCJFD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private LAHIIMCFGOI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private TaskAwaiter<MEAOKELPKFO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private TaskAwaiter<OCLGLHHAFAO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x482DF90", Offset = "0x482D390", VA = "0x18482DF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct PBIBIHKPBGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x482F300", Offset = "0x482E700", VA = "0x18482F300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct EBOGMFICKNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public NPFGJMKHLLJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private MIPBMMJKKCH <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private TaskAwaiter<IFLKGDBGJPO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x4828DC0", Offset = "0x48281C0", VA = "0x184828DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct DAFNBBOCKPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public AsyncTaskMethodBuilder<IFLKGDBGJPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public NPFGJMKHLLJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private MIPBMMJKKCH <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private TaskAwaiter<IFLKGDBGJPO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x4825270", Offset = "0x4824670", VA = "0x184825270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x4825D10", Offset = "0x4825110", VA = "0x184825D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct LNOJJEGIOIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public AsyncTaskMethodBuilder<IFLKGDBGJPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public NPFGJMKHLLJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public LFIANFENBMG timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private MIPBMMJKKCH <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<IFLKGDBGJPO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x482CAD0", Offset = "0x482BED0", VA = "0x18482CAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x482D680", Offset = "0x482CA80", VA = "0x18482D680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct MDPPJELGBNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public AsyncTaskMethodBuilder<IFLKGDBGJPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public IFLKGDBGJPO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public NPFGJMKHLLJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public OCLGLHHAFAO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private TaskAwaiter<IFLKGDBGJPO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x482D730", Offset = "0x482CB30", VA = "0x18482D730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x482D930", Offset = "0x482CD30", VA = "0x18482D930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class FDCCMDCKNIC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public AsyncTaskMethodBuilder<IFLKGDBGJPO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public FDCCMDCKNIC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private TaskAwaiter<IFLKGDBGJPO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x48325C0", Offset = "0x48319C0", VA = "0x1848325C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0x4832B10", Offset = "0x4831F10", VA = "0x184832B10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public NPFGJMKHLLJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public BIOHJKPBDAO masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public LFIANFENBMG timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public IFLKGDBGJPO originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public FDCCMDCKNIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x4829370", Offset = "0x4828770", VA = "0x184829370")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<IFLKGDBGJPO> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct HBLPFDPEHDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public AsyncTaskMethodBuilder<IFLKGDBGJPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public NPFGJMKHLLJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public BIOHJKPBDAO masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public LFIANFENBMG timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private TaskAwaiter<IFLKGDBGJPO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x482A840", Offset = "0x4829C40", VA = "0x18482A840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x482ACF0", Offset = "0x482A0F0", VA = "0x18482ACF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct ACFNIPGNLMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public NPFGJMKHLLJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private IFLKGDBGJPO <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private IEnumerator<IFLKGDBGJPO> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private TaskAwaiter<IFLKGDBGJPO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x4822A80", Offset = "0x4821E80", VA = "0x184822A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct BDNGMJONIJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x4823530", Offset = "0x4822930", VA = "0x184823530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct JELHLIOIPOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public OEAKLMLGIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x482C260", Offset = "0x482B660", VA = "0x18482C260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class LHFNLILGDCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public JIAGHJHJMHD roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LHFNLILGDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x482C840", Offset = "0x482BC40", VA = "0x18482C840")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private readonly ANOHCNMGJIP NBOCOKJBMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly ANOHCNMGJIP HBFFIGKOMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly PAJJLIFLOGC EGEEHBIEOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly PLJMPALPDGD OMALDENKKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private readonly CDLJLJJCJHP DAAHLDMDFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private readonly NAIIIENIGCP BAKPAFBEONN;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float DOMCCMPOCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x3CBDF80", Offset = "0x3CBD380", VA = "0x183CBDF80", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private GOLPDNFBDPM NLFJDMEGNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x324A8B0", Offset = "0x3249CB0", VA = "0x18324A8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event BNKPPKJPPFB AMEPKCMHGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x3CBDDC0", Offset = "0x3CBD1C0", VA = "0x183CBDDC0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x3CBD2B0", Offset = "0x3CBC6B0", VA = "0x183CBD2B0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x3CBE230", Offset = "0x3CBD630", VA = "0x183CBE230")]
	public OEAKLMLGIKJ(FIDGNAKNAGA GHCBFJMJKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD020", Offset = "0x3CBC420", VA = "0x183CBD020")]
	[AsyncStateMachine(typeof(FEMMDDLMFAB))]
	public Task CCECDAONEEC(CCLMJIMCJFD PJJLMKEBMEE, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCEA0", Offset = "0x3CBC2A0", VA = "0x183CBCEA0")]
	[AsyncStateMachine(typeof(DFGOIEMOBCB))]
	private Task<KNOPHICLNED> BMKHDIBOFAM(CCLMJIMCJFD PJJLMKEBMEE, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x3CBDE20", Offset = "0x3CBD220", VA = "0x183CBDE20")]
	[AsyncStateMachine(typeof(IGHPDAIFPBD))]
	private Task OAPBMOLMACM(CCLMJIMCJFD PJJLMKEBMEE, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCA70", Offset = "0x3CBBE70", VA = "0x183CBCA70")]
	[AsyncStateMachine(typeof(NKABGIGPMJO))]
	private Task BAEHAFCPCOF(CCLMJIMCJFD PJJLMKEBMEE, MIPBMMJKKCH KNJJIICJOLE, CancellationToken BIOIFFGBMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x3CBE100", Offset = "0x3CBD500", VA = "0x183CBE100")]
	[AsyncStateMachine(typeof(PBIBIHKPBGK))]
	private Task PHDLAKGENOP(MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD590", Offset = "0x3CBC990", VA = "0x183CBD590")]
	[AsyncStateMachine(typeof(EBOGMFICKNP))]
	private Task ENEFGHBEHEG(OCLGLHHAFAO MPEBBGJJODN, NPFGJMKHLLJ OIAJHHLDCGM, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCD20", Offset = "0x3CBC120", VA = "0x183CBCD20")]
	[AsyncStateMachine(typeof(DAFNBBOCKPP))]
	private Task<IFLKGDBGJPO> BKLGNGLENGP(OCLGLHHAFAO MPEBBGJJODN, LFIANFENBMG GIMGBIMHKMI, NPFGJMKHLLJ OIAJHHLDCGM, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x3CBDBF0", Offset = "0x3CBCFF0", VA = "0x183CBDBF0")]
	[AsyncStateMachine(typeof(LNOJJEGIOIC))]
	private Task<IFLKGDBGJPO> KJPGKNAFPJO(OCLGLHHAFAO MPEBBGJJODN, LFIANFENBMG GIMGBIMHKMI, NPFGJMKHLLJ OIAJHHLDCGM, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x3CBDA60", Offset = "0x3CBCE60", VA = "0x183CBDA60")]
	[AsyncStateMachine(typeof(MDPPJELGBNN))]
	private Task<IFLKGDBGJPO> JMFANNGIBHH(IFLKGDBGJPO NFJBOGPFGFJ, OCLGLHHAFAO HIDNHJFMIMB, NPFGJMKHLLJ OIAJHHLDCGM, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI, bool HJAAGIAJCBM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD350", Offset = "0x3CBC750", VA = "0x183CBD350")]
	private bool EJEAOHGBMAM(OCLGLHHAFAO CBGIMGEOGCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD3E0", Offset = "0x3CBC7E0", VA = "0x183CBD3E0")]
	[AsyncStateMachine(typeof(HBLPFDPEHDP))]
	protected Task<IFLKGDBGJPO> ELJEHKMDEDL(OCLGLHHAFAO MPEBBGJJODN, LFIANFENBMG GIMGBIMHKMI, NPFGJMKHLLJ OIAJHHLDCGM, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI, BIOHJKPBDAO BJKJOCBKIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD730", Offset = "0x3CBCB30", VA = "0x183CBD730")]
	[AsyncStateMachine(typeof(ACFNIPGNLMO))]
	private Task HDIICNAOMCA(OCLGLHHAFAO MPEBBGJJODN, NPFGJMKHLLJ OIAJHHLDCGM, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD300", Offset = "0x3CBC700", VA = "0x183CBD300")]
	private void EDOHAEJDAPK(IFLKGDBGJPO AMBLACGPHJB, NPFGJMKHLLJ OIAJHHLDCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x3CBDA20", Offset = "0x3CBCE20", VA = "0x183CBDA20")]
	private void JAFBIDPCEEL(IFLKGDBGJPO CLLHGOGGDHF, out IFLKGDBGJPO LKKMJAAODMC, out IFLKGDBGJPO KJMIBJNJLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x3CBDDE0", Offset = "0x3CBD1E0", VA = "0x183CBDDE0")]
	private Task<MEAOKELPKFO> NLPABJODBOP(CCLMJIMCJFD PJJLMKEBMEE, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCA20", Offset = "0x3CBBE20", VA = "0x183CBCA20")]
	private Task<OCLGLHHAFAO> AMKLJKKDALI(CCLMJIMCJFD PJJLMKEBMEE, MEAOKELPKFO MPEBBGJJODN, HEEMOONFCAF.GCONECGKFJD FLINFOKJJJH, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x3CBDFA0", Offset = "0x3CBD3A0", VA = "0x183CBDFA0")]
	[AsyncStateMachine(typeof(BDNGMJONIJI))]
	private Task OKJIFPMHCFD(OCLGLHHAFAO MPEBBGJJODN, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI, bool NKDCDADEIDN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD170", Offset = "0x3CBC570", VA = "0x183CBD170")]
	[AsyncStateMachine(typeof(JELHLIOIPOB))]
	private Task CKMOHIDAFLF(OCLGLHHAFAO MPEBBGJJODN, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD2D0", Offset = "0x3CBC6D0", VA = "0x183CBD2D0")]
	private Task DPNJJAMPCEI(OCLGLHHAFAO MPEBBGJJODN, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD290", Offset = "0x3CBC690", VA = "0x183CBD290")]
	private Task CNJJNOLJLAB(OCLGLHHAFAO MPEBBGJJODN, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCBC0", Offset = "0x3CBBFC0", VA = "0x183CBCBC0")]
	private Task BCFKBDBGJGN(OCLGLHHAFAO MPEBBGJJODN, LFIANFENBMG GIMGBIMHKMI, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD890", Offset = "0x3CBCC90", VA = "0x183CBD890")]
	private Task HNBPPEDLBNM(OCLGLHHAFAO MPEBBGJJODN, LFIANFENBMG GIMGBIMHKMI, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCD10", Offset = "0x3CBC110", VA = "0x183CBCD10")]
	private static Task BDCEFNPKEMA(CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD6F0", Offset = "0x3CBCAF0", VA = "0x183CBD6F0")]
	private Task EOLEEEBLIPH(OCLGLHHAFAO MPEBBGJJODN, LFIANFENBMG GIMGBIMHKMI, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD710", Offset = "0x3CBCB10", VA = "0x183CBD710")]
	private Task GJFEPLJGBKD(OCLGLHHAFAO MPEBBGJJODN, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x3CBDD90", Offset = "0x3CBD190", VA = "0x183CBDD90")]
	private void LAJNLLGPEPA(CCLMJIMCJFD PJJLMKEBMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD8B0", Offset = "0x3CBCCB0", VA = "0x183CBD8B0")]
	private static void IJPCJJLHBAK(JIAGHJHJMHD MDHLICGIKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct MPLMLOJCCIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private OCLGLHHAFAO MPEBBGJJODN;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private EELDLGKOJPM PBGLAENKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x32540B0", Offset = "0x32534B0", VA = "0x1832540B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x3253DB0", Offset = "0x32531B0", VA = "0x183253DB0")]
	public static Task BFJDGLKAEGF(GOLPDNFBDPM GAMGMMDKBIL, OCLGLHHAFAO MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x3253E50", Offset = "0x3253250", VA = "0x183253E50")]
	private void BFJDGLKAEGF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct MFIJLFHJEAM
{
	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x3252B30", Offset = "0x3251F30", VA = "0x183252B30")]
	public static Task BFJDGLKAEGF(CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct MGMLOPNLHKJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct EDOONIBMHFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public FIDGNAKNAGA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private MIPBMMJKKCH <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C48C20", Offset = "0x3C48020", VA = "0x183C48C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x3252C50", Offset = "0x3252050", VA = "0x183252C50")]
	[AsyncStateMachine(typeof(EDOONIBMHFA))]
	public static Task BFJDGLKAEGF(FIDGNAKNAGA GHCBFJMJKDF, OCLGLHHAFAO MPEBBGJJODN, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal struct GKLFJGCKKNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct OCOEAFMPKJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public FIDGNAKNAGA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public LFIANFENBMG timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private IFLKGDBGJPO <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private GOLPDNFBDPM <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private EELDLGKOJPM <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private List<(PersistenceView, GNAMCHKIIOD)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private GNAMCHKIIOD <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C550F0", Offset = "0x3C544F0", VA = "0x183C550F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x3247D70", Offset = "0x3247170", VA = "0x183247D70")]
	[AsyncStateMachine(typeof(OCOEAFMPKJL))]
	public static Task BFJDGLKAEGF(FIDGNAKNAGA GHCBFJMJKDF, OCLGLHHAFAO MPEBBGJJODN, LFIANFENBMG GIMGBIMHKMI, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x3247EE0", Offset = "0x32472E0", VA = "0x183247EE0")]
	private static void BKICLOEJIBA(PersistenceView FNDIGAAAAOD, GNAMCHKIIOD FCEBLLIOAFD, OCLGLHHAFAO MPEBBGJJODN, IFLKGDBGJPO NFJBOGPFGFJ, bool FLHOOJKKNGM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal struct MAHMJJPNNEP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct LHHCAJIBFKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public GOLPDNFBDPM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x3C51E50", Offset = "0x3C51250", VA = "0x183C51E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x3251430", Offset = "0x3250830", VA = "0x183251430")]
	[AsyncStateMachine(typeof(LHHCAJIBFKN))]
	public static Task BFJDGLKAEGF(GOLPDNFBDPM GAMGMMDKBIL, OCLGLHHAFAO MPEBBGJJODN, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct GIEEEFCIMCF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct KBOGBFJMJJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public GOLPDNFBDPM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public FIDGNAKNAGA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x3C50230", Offset = "0x3C4F630", VA = "0x183C50230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class EGLJMHDIBKO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			public MIPBMMJKKCH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public EGLJMHDIBKO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			private MIPBMMJKKCH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0x4832CA0", Offset = "0x48320A0", VA = "0x184832CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public EGLJMHDIBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x3C49610", Offset = "0x3C48A10", VA = "0x183C49610")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task <Run>b__0(MIPBMMJKKCH timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct ADOBEIINDLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public GIEEEFCIMCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private TaskAwaiter<KNOPHICLNED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x3CACD50", Offset = "0x3CAC150", VA = "0x183CACD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private sealed class JMFFOICLFGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public KGPBGDOCNHG version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JMFFOICLFGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F110", Offset = "0x3C4E510", VA = "0x183C4F110")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F1F0", Offset = "0x3C4E5F0", VA = "0x183C4F1F0")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private OCLGLHHAFAO MPEBBGJJODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private FIDGNAKNAGA GHCBFJMJKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private bool NKDCDADEIDN;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private static readonly ByteString PKKAJJPMKPB;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private EELDLGKOJPM PBGLAENKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x3246270", Offset = "0x3245670", VA = "0x183246270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private KHKJJLCHIGJ EACHPFKLBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x32462C0", Offset = "0x32456C0", VA = "0x1832462C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x32458A0", Offset = "0x3244CA0", VA = "0x1832458A0")]
	[AsyncStateMachine(typeof(KBOGBFJMJJM))]
	public static Task BFJDGLKAEGF(GOLPDNFBDPM GAMGMMDKBIL, OCLGLHHAFAO MPEBBGJJODN, FIDGNAKNAGA GHCBFJMJKDF, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI, bool NKDCDADEIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x3245A10", Offset = "0x3244E10", VA = "0x183245A10")]
	[AsyncStateMachine(typeof(ADOBEIINDLE))]
	private Task BFJDGLKAEGF(MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x3245B50", Offset = "0x3244F50", VA = "0x183245B50")]
	private void BIINDCOHNLB([NotNull] LNPAGJDMHMD IHGOPHBGHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x3246240", Offset = "0x3245640", VA = "0x183246240")]
	private bool EAMNNJBAAMC(KGPBGDOCNHG IIMAMIPIKFH, LNPAGJDMHMD IHGOPHBGHNK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal struct GNDILOFLHDC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct NPLCBLHFNCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public AsyncTaskMethodBuilder<OCLGLHHAFAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public GNDILOFLHDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public HEEMOONFCAF.GCONECGKFJD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private MIPBMMJKKCH <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private TaskAwaiter<(global::DPAEKNFIIFN<NGKGLMOPHKN, GKAEBCMEFAL>, global::DPAEKNFIIFN<global::BMEALCICMDB<LNPAGJDMHMD>, GKAEBCMEFAL>, global::DPAEKNFIIFN<global::BMEALCICMDB<OCDIJFCGFPK>, GKAEBCMEFAL>, global::DPAEKNFIIFN<global::BMEALCICMDB<DIGMNKOOPIB>, GKAEBCMEFAL>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x3C547E0", Offset = "0x3C53BE0", VA = "0x183C547E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x3C550A0", Offset = "0x3C544A0", VA = "0x183C550A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct KGPONKHKAKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public AsyncTaskMethodBuilder<global::DPAEKNFIIFN<NGKGLMOPHKN, GKAEBCMEFAL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public MIPBMMJKKCH downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public GNDILOFLHDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public HEEMOONFCAF.GCONECGKFJD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private MIPBMMJKKCH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private TaskAwaiter<global::DPAEKNFIIFN<NGKGLMOPHKN, GKAEBCMEFAL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x3C504B0", Offset = "0x3C4F8B0", VA = "0x183C504B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x3C509B0", Offset = "0x3C4FDB0", VA = "0x183C509B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private global::JFANLJIHJDN<LECBPDHMHPK, OCDIJFCGFPK> FKOJNMGOCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private global::JFANLJIHJDN<LECBPDHMHPK, LNPAGJDMHMD> OMMJBOPNGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private global::JFANLJIHJDN<long, DIGMNKOOPIB> KFCJBIGMINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private LOIMFBCEIGF FFAKIBDJHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private CCLMJIMCJFD PJJLMKEBMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private JIAGHJHJMHD MDHLICGIKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private CLNOPKLDMLF PDKEPHFALCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private long IPDMILNMCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private MIPBMMJKKCH HMHNEOCJGLO;

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x3248C80", Offset = "0x3248080", VA = "0x183248C80")]
	public static Task<OCLGLHHAFAO> LKLGKMCKMON(GOLPDNFBDPM GAMGMMDKBIL, CCLMJIMCJFD PJJLMKEBMEE, in MEAOKELPKFO MPEBBGJJODN, HEEMOONFCAF.GCONECGKFJD FLINFOKJJJH, MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x3248920", Offset = "0x3247D20", VA = "0x183248920")]
	[AsyncStateMachine(typeof(NPLCBLHFNCJ))]
	private Task<OCLGLHHAFAO> BFJDGLKAEGF(HEEMOONFCAF.GCONECGKFJD FLINFOKJJJH, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x3248C40", Offset = "0x3248040", VA = "0x183248C40")]
	private LECBPDHMHPK JNKDJNOGMIC(COPCGIKJKPF IPFFBCILDPE)
	{
		return default(LECBPDHMHPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x3248A90", Offset = "0x3247E90", VA = "0x183248A90")]
	[AsyncStateMachine(typeof(KGPONKHKAKB))]
	private Task<global::DPAEKNFIIFN<NGKGLMOPHKN, GKAEBCMEFAL>> FAKOFJACGAL(string BLDADOPGBGF, long IPDMILNMCPD, HEEMOONFCAF.GCONECGKFJD FLINFOKJJJH, MIPBMMJKKCH BBEOGCNHFDN, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct FNDGEMCMEPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct FDNIJAHDCNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public AsyncTaskMethodBuilder<MEAOKELPKFO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public FNDGEMCMEPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private MIPBMMJKKCH <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private TaskAwaiter<MEAOKELPKFO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x3CAFD70", Offset = "0x3CAF170", VA = "0x183CAFD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0220", Offset = "0x3CAF620", VA = "0x183CB0220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct GEANNDBKFII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public AsyncTaskMethodBuilder<MEAOKELPKFO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public FNDGEMCMEPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private TaskAwaiter<MEAOKELPKFO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2010", Offset = "0x3CB1410", VA = "0x183CB2010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2200", Offset = "0x3CB1600", VA = "0x183CB2200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private sealed class NBAJDABFHFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public NBAJDABFHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x1C004F0", Offset = "0x1BFF8F0", VA = "0x181C004F0")]
		internal bool <FetchRoomDetails>b__0(CLNOPKLDMLF sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct MMMOLGLOMED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public AsyncTaskMethodBuilder<MEAOKELPKFO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public EELDLGKOJPM callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private NBAJDABFHFJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private MIPBMMJKKCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private TaskAwaiter<JIAGHJHJMHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x3CB7ED0", Offset = "0x3CB72D0", VA = "0x183CB7ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8410", Offset = "0x3CB7810", VA = "0x183CB8410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private EELDLGKOJPM CMMLIBKHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private PAJJLIFLOGC EGEEHBIEOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private MIPBMMJKKCH HMHNEOCJGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	private long COLNHBBPCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	private long BPIAGBMFLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	private string CFOGADLFGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	private LECBPDHMHPK MIJLIGGNAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	private LECBPDHMHPK MLJIOMPJKJF;

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x3241F10", Offset = "0x3241310", VA = "0x183241F10")]
	public static Task<MEAOKELPKFO> LKLGKMCKMON(GOLPDNFBDPM GAMGMMDKBIL, CCLMJIMCJFD PJJLMKEBMEE, MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x3241C10", Offset = "0x3241010", VA = "0x183241C10")]
	[AsyncStateMachine(typeof(FDNIJAHDCNF))]
	private Task<MEAOKELPKFO> BFJDGLKAEGF(CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x3242350", Offset = "0x3241750", VA = "0x183242350")]
	[AsyncStateMachine(typeof(GEANNDBKFII))]
	private Task<MEAOKELPKFO> NLPABJODBOP(long COLNHBBPCAP, long BPIAGBMFLPM, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI, bool GJBDEGJLFGI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x32424E0", Offset = "0x32418E0", VA = "0x1832424E0")]
	[AsyncStateMachine(typeof(MMMOLGLOMED))]
	public static Task<MEAOKELPKFO> NLPABJODBOP(EELDLGKOJPM CMMLIBKHPCN, long COLNHBBPCAP, long BPIAGBMFLPM, CancellationToken MJMCKAGGCOI, MIPBMMJKKCH KNJJIICJOLE, bool GJBDEGJLFGI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x3241D70", Offset = "0x3241170", VA = "0x183241D70")]
	private void CGDKKMPKAIF(JIAGHJHJMHD MDHLICGIKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x3241DA0", Offset = "0x32411A0", VA = "0x183241DA0")]
	private bool EJALPJIBBBC(MEAOKELPKFO MPEBBGJJODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x32421A0", Offset = "0x32415A0", VA = "0x1832421A0")]
	private void NHBEHHJHMDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal struct AMDNPJDNBNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct FMEKPOFGHDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public AMDNPJDNBNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private MIPBMMJKKCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1320", Offset = "0x3CB0720", VA = "0x183CB1320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private const int DENMBJJHAHC = 20;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private const float NLMHAMLPNEL = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private EELDLGKOJPM CMMLIBKHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private OCLGLHHAFAO MPEBBGJJODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private MIPBMMJKKCH HMHNEOCJGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private float JGLLFICAKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private float FAIKJMAIGOG;

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x3238150", Offset = "0x3237550", VA = "0x183238150")]
	public static Task BCOHMIIHMBA(GOLPDNFBDPM GAMGMMDKBIL, OCLGLHHAFAO MPEBBGJJODN, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x32382F0", Offset = "0x32376F0", VA = "0x1832382F0")]
	[AsyncStateMachine(typeof(FMEKPOFGHDB))]
	public Task BFJDGLKAEGF(CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x32386C0", Offset = "0x3237AC0", VA = "0x1832386C0")]
	private static void OGJFHGCKOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x32384E0", Offset = "0x32378E0", VA = "0x1832384E0")]
	private void MJGLOFCMPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x3238420", Offset = "0x3237820", VA = "0x183238420")]
	private static float CMANOKIJLIA(EELDLGKOJPM CMMLIBKHPCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x3238130", Offset = "0x3237530", VA = "0x183238130")]
	private static float ANLKMFHNMCC()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct ENKHNENOGEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct DHHKILOHPEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public FIDGNAKNAGA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private FPOEHJGJEFB <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private GOLPDNFBDPM <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private AAJKAGKMIPK.LGFFJCEKAJA <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private TaskAwaiter<KNOPHICLNED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE930", Offset = "0x3CADD30", VA = "0x183CAE930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct FOLPHNHLAHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private OGFMIGENEOM.LAHJEEFBJJK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x3CB16D0", Offset = "0x3CB0AD0", VA = "0x183CB16D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x323F370", Offset = "0x323E770", VA = "0x18323F370")]
	[AsyncStateMachine(typeof(DHHKILOHPEL))]
	public static Task BFJDGLKAEGF(FIDGNAKNAGA GHCBFJMJKDF, OCLGLHHAFAO MPEBBGJJODN, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x323F4D0", Offset = "0x323E8D0", VA = "0x18323F4D0")]
	private static Task<KNOPHICLNED> HDICNCMHHIK(FIDGNAKNAGA GHCBFJMJKDF, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x323F2A0", Offset = "0x323E6A0", VA = "0x18323F2A0")]
	[AsyncStateMachine(typeof(FOLPHNHLAHH))]
	private static Task AENGOJOJLHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct DOFIEMIFFCE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct HJKDBAPELGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public DOFIEMIFFCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private MIPBMMJKKCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2860", Offset = "0x3CB1C60", VA = "0x183CB2860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class PHMMNCFAKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public PHMMNCFAKDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2D10", Offset = "0x3CC2110", VA = "0x183CC2D10")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct MNDEFINNCDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public DOFIEMIFFCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private PLNGHDKDMIG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8460", Offset = "0x3CB7860", VA = "0x183CB8460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private bool KOKIFLOICCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private MIPBMMJKKCH HMHNEOCJGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private CancellationToken MJMCKAGGCOI;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x323C110", Offset = "0x323B510", VA = "0x18323C110")]
	public static Task NFPFHOLFNAO(GOLPDNFBDPM GAMGMMDKBIL, bool KOKIFLOICCG, MIPBMMJKKCH HMHNEOCJGLO, CancellationToken GHDIBNBHECI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x323BED0", Offset = "0x323B2D0", VA = "0x18323BED0")]
	[AsyncStateMachine(typeof(HJKDBAPELGF))]
	private Task BFJDGLKAEGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x323BFE0", Offset = "0x323B3E0", VA = "0x18323BFE0")]
	[AsyncStateMachine(typeof(MNDEFINNCDP))]
	private Task HHAEJLHKOBI(bool BDMEDJAANHE, string DFHBGAHLFPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0")]
	private bool KKNEFIOFNGA(bool KOKIFLOICCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct PAIEOCFGGAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct AKPNGCIKNJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public PAIEOCFGGAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private MIPBMMJKKCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x4822E60", Offset = "0x4822260", VA = "0x184822E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x48232B0", Offset = "0x48226B0", VA = "0x1848232B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class GCACHBBIFOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public GCACHBBIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x482A090", Offset = "0x4829490", VA = "0x18482A090")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct NJGAGMMPPCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public PAIEOCFGGAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private PLNGHDKDMIG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x482D9E0", Offset = "0x482CDE0", VA = "0x18482D9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x482DF40", Offset = "0x482D340", VA = "0x18482DF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private LKHDFEKNHMI ODMLCLDMLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private MIPBMMJKKCH HMHNEOCJGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private bool LGBHELCEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private OCLGLHHAFAO MPEBBGJJODN;

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0140", Offset = "0x3CBF540", VA = "0x183CC0140")]
	public static Task<Scene> IOFKGPIOCOJ(GOLPDNFBDPM GAMGMMDKBIL, LKHDFEKNHMI FDKLGKDBLIA, MIPBMMJKKCH HMHNEOCJGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFF40", Offset = "0x3CBF340", VA = "0x183CBFF40")]
	public static Task<Scene> EJHIFDAOGDC(GOLPDNFBDPM GAMGMMDKBIL, OCLGLHHAFAO MPEBBGJJODN, MIPBMMJKKCH HMHNEOCJGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFD60", Offset = "0x3CBF160", VA = "0x183CBFD60")]
	[AsyncStateMachine(typeof(AKPNGCIKNJJ))]
	private Task<Scene> BFJDGLKAEGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFF00", Offset = "0x3CBF300", VA = "0x183CBFF00")]
	private bool EIDGLBADJKA(OCLGLHHAFAO MPEBBGJJODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFE90", Offset = "0x3CBF290", VA = "0x183CBFE90")]
	private void DHPCELJCBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFFE0", Offset = "0x3CBF3E0", VA = "0x183CBFFE0")]
	[AsyncStateMachine(typeof(NJGAGMMPPCE))]
	private Task<Scene> HHAEJLHKOBI(string DFHBGAHLFPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
internal struct CDLJLJJCJHP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct PNOCPLMIJAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public AsyncTaskMethodBuilder<IFLKGDBGJPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public CDLJLJJCJHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public IFLKGDBGJPO nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public OCLGLHHAFAO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private MIPBMMJKKCH <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private TaskAwaiter<IFLKGDBGJPO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4400", Offset = "0x3CC3800", VA = "0x183CC4400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4C10", Offset = "0x3CC4010", VA = "0x183CC4C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct GFEDMAOHGNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public AsyncTaskMethodBuilder<IFLKGDBGJPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CDLJLJJCJHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public IFLKGDBGJPO state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private TaskAwaiter<KNOPHICLNED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2250", Offset = "0x3CB1650", VA = "0x183CB2250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x3CB24D0", Offset = "0x3CB18D0", VA = "0x183CB24D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly FIDGNAKNAGA GHCBFJMJKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private readonly PAJJLIFLOGC EGEEHBIEOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private readonly PLJMPALPDGD OMALDENKKPG;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private FPOEHJGJEFB EEMNHICDDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xB909E0", Offset = "0xB8FDE0", VA = "0x180B909E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x323A7C0", Offset = "0x3239BC0", VA = "0x18323A7C0")]
	public CDLJLJJCJHP(FIDGNAKNAGA GHCBFJMJKDF, PAJJLIFLOGC EGEEHBIEOLL, PLJMPALPDGD OMALDENKKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x323A620", Offset = "0x3239A20", VA = "0x18323A620")]
	[AsyncStateMachine(typeof(PNOCPLMIJAE))]
	public Task<IFLKGDBGJPO> NEIKEIGGKCM(IFLKGDBGJPO MCGANIPLHFC, OCLGLHHAFAO HIDNHJFMIMB, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI, bool HJAAGIAJCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x323A480", Offset = "0x3239880", VA = "0x18323A480")]
	[AsyncStateMachine(typeof(GFEDMAOHGNI))]
	private Task<IFLKGDBGJPO> ILCNAEEACBP(MIPBMMJKKCH KNJJIICJOLE, IFLKGDBGJPO LGKAKPIGKKN, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x323A5F0", Offset = "0x32399F0", VA = "0x18323A5F0")]
	private bool KDHCJBHDFOC(IFLKGDBGJPO GCDBJNOJGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x323A460", Offset = "0x3239860", VA = "0x18323A460")]
	private void EPMJEFBIMPO(string HPCOFNJFOOG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct JDAABKOCMPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct KKGHFLNLCLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public FPOEHJGJEFB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public LFIANFENBMG timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private List<(PersistenceView, GNAMCHKIIOD)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private (PersistenceView, GNAMCHKIIOD) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x3C50A00", Offset = "0x3C4FE00", VA = "0x183C50A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x324B120", Offset = "0x324A520", VA = "0x18324B120")]
	[AsyncStateMachine(typeof(KKGHFLNLCLF))]
	public static Task BFJDGLKAEGF(FPOEHJGJEFB KPPDIIPHNDH, OCLGLHHAFAO MPEBBGJJODN, LFIANFENBMG GIMGBIMHKMI, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct NLEMNBPOHNH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct HBAFDNEJIMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public FPOEHJGJEFB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public LFIANFENBMG timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private KGPBGDOCNHG <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private List<(PersistenceView, GNAMCHKIIOD)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private GNAMCHKIIOD <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x482A150", Offset = "0x4829550", VA = "0x18482A150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x3CBA4D0", Offset = "0x3CB98D0", VA = "0x183CBA4D0")]
	[AsyncStateMachine(typeof(HBAFDNEJIMI))]
	public static Task BFJDGLKAEGF(FPOEHJGJEFB KPPDIIPHNDH, OCLGLHHAFAO MPEBBGJJODN, LFIANFENBMG GIMGBIMHKMI, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal struct AAJKAGKMIPK
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct LGFFJCEKAJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public List<LOHOGOJBAPD> OCLEFAFHDLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public List<GNAMCHKIIOD> PHDPJEKHPJO;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xAABA10", Offset = "0xAAAE10", VA = "0x180AABA10")]
		public LGFFJCEKAJA(List<LOHOGOJBAPD> OCLEFAFHDLI, List<GNAMCHKIIOD> PHDPJEKHPJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class HENPMGIJDCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public IEnumerable<LOHOGOJBAPD> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HENPMGIJDCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x3CB27B0", Offset = "0x3CB1BB0", VA = "0x183CB27B0")]
		internal object <TryBulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private OCLGLHHAFAO MPEBBGJJODN;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private EELDLGKOJPM PBGLAENKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x32354B0", Offset = "0x32348B0", VA = "0x1832354B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x3234F00", Offset = "0x3234300", VA = "0x183234F00")]
	public static LGFFJCEKAJA BFJDGLKAEGF(GOLPDNFBDPM GAMGMMDKBIL, OCLGLHHAFAO MPEBBGJJODN)
	{
		return default(LGFFJCEKAJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x3234BE0", Offset = "0x3233FE0", VA = "0x183234BE0")]
	private LGFFJCEKAJA BFJDGLKAEGF()
	{
		return default(LGFFJCEKAJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x3234F60", Offset = "0x3234360", VA = "0x183234F60")]
	private LGFFJCEKAJA EFGJLKBJJCF(LNPAGJDMHMD IHGOPHBGHNK, KGPBGDOCNHG KPHKDFLEHCN)
	{
		return default(LGFFJCEKAJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x3235500", Offset = "0x3234900", VA = "0x183235500")]
	private bool JMPFEMGAKDC(IEnumerable<LOHOGOJBAPD> OCLEFAFHDLI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct LOMIBOCKGIN
{
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class MGDJKPMEFFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public AAJKAGKMIPK.LGFFJCEKAJA instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public MGDJKPMEFFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x3C52F60", Offset = "0x3C52360", VA = "0x183C52F60")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class ILFDFKGECHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ILFDFKGECHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x3C4D5B0", Offset = "0x3C4C9B0", VA = "0x183C4D5B0")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x3250D80", Offset = "0x3250180", VA = "0x183250D80")]
	public static void BFJDGLKAEGF(FPOEHJGJEFB KPPDIIPHNDH, OCLGLHHAFAO MPEBBGJJODN, AAJKAGKMIPK.LGFFJCEKAJA NNLPKPHBILF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal struct COKOFMIOKEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct LEEENDNAAMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public GOLPDNFBDPM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public FIDGNAKNAGA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5A20", Offset = "0x3CB4E20", VA = "0x183CB5A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct EHCMEGKHAIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public COKOFMIOKEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x3CAEFA0", Offset = "0x3CAE3A0", VA = "0x183CAEFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000577")]
	private OCLGLHHAFAO MPEBBGJJODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000578")]
	private ByteString AGKIAKBKNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000579")]
	private FIDGNAKNAGA GHCBFJMJKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400057A")]
	private bool DAMNHBBAJKJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private EELDLGKOJPM PBGLAENKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x323BA20", Offset = "0x323AE20", VA = "0x18323BA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private bool IAJIEOMMDKN
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x323BB00", Offset = "0x323AF00", VA = "0x18323BB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private bool OAAJIONFGDO
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x323BA70", Offset = "0x323AE70", VA = "0x18323BA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x323B8B0", Offset = "0x323ACB0", VA = "0x18323B8B0")]
	[AsyncStateMachine(typeof(LEEENDNAAMD))]
	public static Task BFJDGLKAEGF(GOLPDNFBDPM GAMGMMDKBIL, OCLGLHHAFAO MPEBBGJJODN, FIDGNAKNAGA GHCBFJMJKDF, bool DAMNHBBAJKJ, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x323B780", Offset = "0x323AB80", VA = "0x18323B780")]
	[AsyncStateMachine(typeof(EHCMEGKHAIA))]
	private Task BFJDGLKAEGF(MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal class PLJMPALPDGD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct JCLNFDOKFIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public PLJMPALPDGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public IFLKGDBGJPO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public OCLGLHHAFAO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x482BF20", Offset = "0x482B320", VA = "0x18482BF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class HKKGAMPDPOF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			public HKKGAMPDPOF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x4832B60", Offset = "0x4831F60", VA = "0x184832B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public PLJMPALPDGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public MIPBMMJKKCH handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HKKGAMPDPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x482AD40", Offset = "0x482A140", VA = "0x18482AD40")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct OEOLCNJNCEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public PLJMPALPDGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private HKKGAMPDPOF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x482EBE0", Offset = "0x482DFE0", VA = "0x18482EBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct BLABEBFLBLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public PLJMPALPDGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private MIPBMMJKKCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private Dictionary<Guid, List<NKPFEHNNMMA>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x4824410", Offset = "0x4823810", VA = "0x184824410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct DPNBNOKIOOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public PLJMPALPDGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private MIPBMMJKKCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private Dictionary<Guid, List<NKPFEHNNMMA>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x48283F0", Offset = "0x48277F0", VA = "0x1848283F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class OMIONEAFDJN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200015D")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005BD")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005BE")]
			public NKPFEHNNMMA handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			public OMIONEAFDJN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x4830680", Offset = "0x482FA80", VA = "0x184830680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public BHBMFDNOIIH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public List<NKPFEHNNMMA> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public OMIONEAFDJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x482F000", Offset = "0x482E400", VA = "0x18482F000")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x482F1E0", Offset = "0x482E5E0", VA = "0x18482F1E0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(NKPFEHNNMMA handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x482F0F0", Offset = "0x482E4F0", VA = "0x18482F0F0")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct IAGEFIBKKCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public BHBMFDNOIIH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public List<NKPFEHNNMMA> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private OMIONEAFDJN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x482B150", Offset = "0x482A550", VA = "0x18482B150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct HKKKADDIAAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public PLJMPALPDGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public MIPBMMJKKCH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x482AE60", Offset = "0x482A260", VA = "0x18482AE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class HMJDDAJBAGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HMJDDAJBAGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x482B0E0", Offset = "0x482A4E0", VA = "0x18482B0E0")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct CMMIOJPMIAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public PLJMPALPDGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x4824E10", Offset = "0x4824210", VA = "0x184824E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class DBPJKCLGIJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public DBPJKCLGIJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x4825D60", Offset = "0x4825160", VA = "0x184825D60")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct DLGIKJBDGMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public PLJMPALPDGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private TaskAwaiter<KNOPHICLNED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x4826C20", Offset = "0x4826020", VA = "0x184826C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class GLMPAABHDFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public GLMPAABHDFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x482A0E0", Offset = "0x48294E0", VA = "0x18482A0E0")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	private readonly FIDGNAKNAGA GHCBFJMJKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400058B")]
	private ILPNBJBNLCA OMALDENKKPG;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private FPOEHJGJEFB EEMNHICDDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xCA7990", Offset = "0xCA6D90", VA = "0x180CA7990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
	public PLJMPALPDGD(FIDGNAKNAGA GHCBFJMJKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3490", Offset = "0x3CC2890", VA = "0x183CC3490")]
	[AsyncStateMachine(typeof(JCLNFDOKFIH))]
	public Task BFJDGLKAEGF(IFLKGDBGJPO NFJBOGPFGFJ, OCLGLHHAFAO HIDNHJFMIMB, MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x3CC35F0", Offset = "0x3CC29F0", VA = "0x183CC35F0")]
	[AsyncStateMachine(typeof(OEOLCNJNCEM))]
	private Task FGDOPNCIHAP(OCLGLHHAFAO MPEBBGJJODN, MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3CF0", Offset = "0x3CC30F0", VA = "0x183CC3CF0")]
	[AsyncStateMachine(typeof(BLABEBFLBLB))]
	private Task NHBFPKBPPOA(OCLGLHHAFAO MPEBBGJJODN, MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3E50", Offset = "0x3CC3250", VA = "0x183CC3E50")]
	[AsyncStateMachine(typeof(DPNBNOKIOOC))]
	private Task ONDDIPNGEIA(OCLGLHHAFAO MPEBBGJJODN, MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x3CC40F0", Offset = "0x3CC34F0", VA = "0x183CC40F0")]
	[AsyncStateMachine(typeof(IAGEFIBKKCJ))]
	private Task PJDDJPIGALL(Guid GNBOPJEFMMC, List<NKPFEHNNMMA> BNDCLHLFNMF, BHBMFDNOIIH PNEBIDBOHNP, OCLGLHHAFAO MPEBBGJJODN, CancellationToken JCHAGIDHJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3A70", Offset = "0x3CC2E70", VA = "0x183CC3A70")]
	[AsyncStateMachine(typeof(HKKKADDIAAD))]
	private Task IFCCFEAACJI(OCLGLHHAFAO MPEBBGJJODN, MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3FB0", Offset = "0x3CC33B0", VA = "0x183CC3FB0")]
	[AsyncStateMachine(typeof(CMMIOJPMIAB))]
	private Task OPEOEPBNOLA(Guid EKLDNIGEAJE, OCLGLHHAFAO MPEBBGJJODN, MIPBMMJKKCH HMHNEOCJGLO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3920", Offset = "0x3CC2D20", VA = "0x183CC3920")]
	[AsyncStateMachine(typeof(DLGIKJBDGMD))]
	private Task GNFNNPCOECE(Guid EKLDNIGEAJE, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x3CC32F0", Offset = "0x3CC26F0", VA = "0x183CC32F0")]
	private void AIACALLEKOF(Guid EKLDNIGEAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3BC0", Offset = "0x3CC2FC0", VA = "0x183CC3BC0")]
	private void LOJMFJHFICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4230", Offset = "0x3CC3630", VA = "0x183CC4230")]
	public Guid PONEBHDAKLK(IFLKGDBGJPO AMBLACGPHJB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3750", Offset = "0x3CC2B50", VA = "0x183CC3750")]
	[CompilerGenerated]
	private object GBNEPFAKFIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal struct KOLKHLLDOCC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct MCOFIFNIEHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public GOLPDNFBDPM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public OCLGLHHAFAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public FIDGNAKNAGA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x3C52D10", Offset = "0x3C52110", VA = "0x183C52D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C52F10", Offset = "0x3C52310", VA = "0x183C52F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct JAPNEFNIOJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public KOLKHLLDOCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private bool <reloadSceneForObjectModel>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C4DFD0", Offset = "0x3C4D3D0", VA = "0x183C4DFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E510", Offset = "0x3C4D910", VA = "0x183C4E510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private GOLPDNFBDPM GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	private OCLGLHHAFAO MPEBBGJJODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	private ByteString AGKIAKBKNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private FIDGNAKNAGA GHCBFJMJKDF;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private EELDLGKOJPM PBGLAENKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x324CB40", Offset = "0x324BF40", VA = "0x18324CB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private bool IAJIEOMMDKN
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x324CC20", Offset = "0x324C020", VA = "0x18324CC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private bool OAAJIONFGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x324CB90", Offset = "0x324BF90", VA = "0x18324CB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private bool BMADIAMHIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x324CCA0", Offset = "0x324C0A0", VA = "0x18324CCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x324C850", Offset = "0x324BC50", VA = "0x18324C850")]
	[AsyncStateMachine(typeof(MCOFIFNIEHL))]
	public static Task<bool> BFJDGLKAEGF(GOLPDNFBDPM GAMGMMDKBIL, OCLGLHHAFAO MPEBBGJJODN, FIDGNAKNAGA GHCBFJMJKDF, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x324C9E0", Offset = "0x324BDE0", VA = "0x18324C9E0")]
	[AsyncStateMachine(typeof(JAPNEFNIOJF))]
	private Task<bool> BFJDGLKAEGF(MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public readonly struct OMDMCGFKGDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005FC")]
	[CanBeNull]
	public readonly LNPAGJDMHMD ACCGBDIFPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005FD")]
	[NotNull]
	public readonly AFELMKLPMOP IMDGMPEOIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005FE")]
	[CanBeNull]
	public readonly string CAGKGCAJNCG;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public IReadOnlyCollection<string> JLCNFBENJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF4B0", Offset = "0x3CBE8B0", VA = "0x183CBF4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public IReadOnlyDictionary<long, int> DNGALLOMADI
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF490", Offset = "0x3CBE890", VA = "0x183CBF490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF4D0", Offset = "0x3CBE8D0", VA = "0x183CBF4D0")]
	public OMDMCGFKGDM([CanBeNull] LNPAGJDMHMD FOGLEECNIFC, [NotNull] AFELMKLPMOP MENDBILAMPI, [CanBeNull] string BLDADOPGBGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal class MAMPEHPGOLC : HMFLHMEOFKK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct BKIMDKFPMIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public AsyncTaskMethodBuilder<OMDMCGFKGDM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public MAMPEHPGOLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public HLBKDPDMAPP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x3C44170", Offset = "0x3C43570", VA = "0x183C44170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C44610", Offset = "0x3C43A10", VA = "0x183C44610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class KBNNNNNGCLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public HLBKDPDMAPP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public KBNNNNNGCLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C4FFF0", Offset = "0x3C4F3F0", VA = "0x183C4FFF0")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class BKOANPDHBCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public KBNNNNNGCLI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BKOANPDHBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x3C44660", Offset = "0x3C43A60", VA = "0x183C44660")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class KPHCICBNONA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public KBNNNNNGCLI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public KPHCICBNONA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C51E10", Offset = "0x3C51210", VA = "0x183C51E10")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct AAAJJBEIAME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public HLBKDPDMAPP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public MAMPEHPGOLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private BKOANPDHBCL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private OGFMIGENEOM.PDHOIAILJGO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x3C42E30", Offset = "0x3C42230", VA = "0x183C42E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private readonly BOPNJOMCJCD EMLKPOBLHAA;

	[Cpp2IlInjected.Token(Token = "0x4000600")]
	private static readonly TimeSpan BMHONGHCHLD;

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x3252710", Offset = "0x3251B10", VA = "0x183252710")]
	public MAMPEHPGOLC(FIDGNAKNAGA GHCBFJMJKDF, [Optional] BOPNJOMCJCD? EMLKPOBLHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x3251560", Offset = "0x3250960", VA = "0x183251560")]
	[AsyncStateMachine(typeof(BKIMDKFPMIM))]
	public Task<OMDMCGFKGDM> DGECGJPLFOM(long BPIAGBMFLPM, string BLDADOPGBGF, HLBKDPDMAPP CCHGFKGHKDC, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x3252540", Offset = "0x3251940", VA = "0x183252540")]
	[AsyncStateMachine(typeof(AAAJJBEIAME))]
	private Task OIDNHFIMAFL(HLBKDPDMAPP CCHGFKGHKDC, IEnumerable<PersistenceView> JAMKHPGLIAO, StringBuilder HBPNNHNLOGN, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x3252050", Offset = "0x3251450", VA = "0x183252050")]
	private OMDMCGFKGDM NHIHJEEBOFC(long BPIAGBMFLPM, string BLDADOPGBGF, HLBKDPDMAPP CCHGFKGHKDC, IEnumerable<PersistenceView> JAMKHPGLIAO, StringBuilder HBPNNHNLOGN)
	{
		return default(OMDMCGFKGDM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x3251E70", Offset = "0x3251270", VA = "0x183251E70")]
	private LNPAGJDMHMD FCNBKJEAFBI(long BPIAGBMFLPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x32516E0", Offset = "0x3250AE0", VA = "0x1832516E0")]
	private void DMBHCNCDNCB(LNPAGJDMHMD INDBPANDAMO, StringBuilder HBPNNHNLOGN, IEnumerable<PersistenceView> JAMKHPGLIAO, in FPBBPFNELCM IGALNDDKACB, ref JAMCKBOEJMM MGCIHOBCCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x3251900", Offset = "0x3250D00", VA = "0x183251900")]
	private void EPDNEFHGPAJ(LNPAGJDMHMD INDBPANDAMO, StringBuilder HBPNNHNLOGN, PersistenceView FNDIGAAAAOD, ref JAMCKBOEJMM MGCIHOBCCIO, in FPBBPFNELCM IGALNDDKACB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal class IFDIMGJBHNK : HMFLHMEOFKK
{
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class JNBJHFKHEFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public ALMHAOJMCOA.MOMFCPDMDNM roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public ALMHAOJMCOA.MOMFCPDMDNM subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JNBJHFKHEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F2A0", Offset = "0x3C4E6A0", VA = "0x183C4F2A0")]
		internal object <UploadRoomDataToStorage>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F330", Offset = "0x3C4E730", VA = "0x183C4F330")]
		internal object <UploadRoomDataToStorage>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F380", Offset = "0x3C4E780", VA = "0x183C4F380")]
		internal object <UploadRoomDataToStorage>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F3F0", Offset = "0x3C4E7F0", VA = "0x183C4F3F0")]
		internal object <UploadRoomDataToStorage>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct PFBIKPAEMJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public AsyncTaskMethodBuilder<(ALMHAOJMCOA.MOMFCPDMDNM roomDataUpload, ALMHAOJMCOA.MOMFCPDMDNM subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public OMDMCGFKGDM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public IFDIMGJBHNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private JNBJHFKHEFD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private TaskAwaiter<ALMHAOJMCOA.MOMFCPDMDNM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x3C56EB0", Offset = "0x3C562B0", VA = "0x183C56EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C57950", Offset = "0x3C56D50", VA = "0x183C57950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct MMJILABKOAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public AsyncTaskMethodBuilder<HEDEMNPEDMH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public IFDIMGJBHNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public OMDMCGFKGDM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public KHFJKINMMAE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private TaskAwaiter<(ALMHAOJMCOA.MOMFCPDMDNM roomDataUpload, ALMHAOJMCOA.MOMFCPDMDNM subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private TaskAwaiter<HEDEMNPEDMH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x3C53900", Offset = "0x3C52D00", VA = "0x183C53900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x3C53DC0", Offset = "0x3C531C0", VA = "0x183C53DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct CFMDCJPAAEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public AsyncTaskMethodBuilder<FAMHFHLIEMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public IFDIMGJBHNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public OMDMCGFKGDM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private TaskAwaiter<(ALMHAOJMCOA.MOMFCPDMDNM roomDataUpload, ALMHAOJMCOA.MOMFCPDMDNM subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private TaskAwaiter<FAMHFHLIEMJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C44CA0", Offset = "0x3C440A0", VA = "0x183C44CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x3C45030", Offset = "0x3C44430", VA = "0x183C45030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class JFJBBCDKJOH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000177")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400064D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400064E")]
			public AsyncTaskMethodBuilder<KNOPHICLNED> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			public JFJBBCDKJOH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			private KNOPHICLNED <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			private TaskAwaiter<FAMHFHLIEMJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			private TaskAwaiter<HEDEMNPEDMH> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			private TaskAwaiter<KNOPHICLNED> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x4833290", Offset = "0x4832690", VA = "0x184833290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0x4833E70", Offset = "0x4833270", VA = "0x184833E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public IFDIMGJBHNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public OMDMCGFKGDM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public KHFJKINMMAE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JFJBBCDKJOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E560", Offset = "0x3C4D960", VA = "0x183C4E560")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<KNOPHICLNED> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct JJCHGMPFCFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public AsyncTaskMethodBuilder<KNOPHICLNED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public IFDIMGJBHNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public OMDMCGFKGDM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public KHFJKINMMAE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private TaskAwaiter<KNOPHICLNED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E710", Offset = "0x3C4DB10", VA = "0x183C4E710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E9C0", Offset = "0x3C4DDC0", VA = "0x183C4E9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000621")]
	private const float MJHJDMLPBAB = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000622")]
	private readonly BBCAJKHGDAF DOEFDIDAEIJ;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private GOLPDNFBDPM NLFJDMEGNNP
	{
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x324A8B0", Offset = "0x3249CB0", VA = "0x18324A8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x324AA70", Offset = "0x3249E70", VA = "0x18324AA70")]
	public IFDIMGJBHNK(FIDGNAKNAGA GHCBFJMJKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x324A590", Offset = "0x3249990", VA = "0x18324A590")]
	[AsyncStateMachine(typeof(PFBIKPAEMJP))]
	private Task<(ALMHAOJMCOA.MOMFCPDMDNM, ALMHAOJMCOA.MOMFCPDMDNM)> EAIALOKFDFF(OMDMCGFKGDM OCPBEPAJLMP, long COLNHBBPCAP, long JPKIIMPIPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x324A8E0", Offset = "0x3249CE0", VA = "0x18324A8E0")]
	[AsyncStateMachine(typeof(MMJILABKOAC))]
	public Task<HEDEMNPEDMH> PEECINOFBDM(int GKEHNDPJBOF, [CanBeNull] KHFJKINMMAE BMOJANKKHDC, OMDMCGFKGDM OCPBEPAJLMP, long COLNHBBPCAP, long JPKIIMPIPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x324A400", Offset = "0x3249800", VA = "0x18324A400")]
	[AsyncStateMachine(typeof(CFMDCJPAAEK))]
	private Task<FAMHFHLIEMJ> BEODAEMCJJK(string KFNFEIADKID, int GKEHNDPJBOF, OMDMCGFKGDM OCPBEPAJLMP, long COLNHBBPCAP, long JPKIIMPIPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x324A700", Offset = "0x3249B00", VA = "0x18324A700")]
	[AsyncStateMachine(typeof(JJCHGMPFCFG))]
	public Task<KNOPHICLNED> FMIBPECEBPK(int GKEHNDPJBOF, [CanBeNull] KHFJKINMMAE BMOJANKKHDC, OMDMCGFKGDM OCPBEPAJLMP, long COLNHBBPCAP, long JPKIIMPIPPD, MIPBMMJKKCH KNJJIICJOLE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public abstract class MANCHBBCOOE<T> where T : global::MANCHBBCOOE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000661")]
	internal readonly GOLPDNFBDPM LKFDMBOPMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	private int? FEILHBFMHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000663")]
	protected readonly Guid BCCHIKAMDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	protected readonly OBGEECKNGII OFNIEHFHHNL;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	protected T JNMCICGALCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A7F0", Offset = "0x3E59BF0", VA = "0x183E5A7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A850", Offset = "0x3E59C50", VA = "0x183E5A850")]
	internal MANCHBBCOOE(GOLPDNFBDPM DMBFGIOCCHP, OBGEECKNGII LLGLGGINHDF, [Optional] Guid? JLOMHEMDNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A500", Offset = "0x3E59900", VA = "0x183E5A500")]
	private KNOPHICLNED CNAGOEPBBOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "4")]
	protected virtual void BPIDOBDCMLN(KNOPHICLNED CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A6E0", Offset = "0x3E59AE0", VA = "0x183E5A6E0")]
	public T EHGJMHMHIIL(JEHHKLECEGB NKBGOBOMGOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A770", Offset = "0x3E59B70", VA = "0x183E5A770")]
	public T HECBIAHLKFI(int NGFBLJNEGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A5E0", Offset = "0x3E599E0", VA = "0x183E5A5E0", Slot = "5")]
	public virtual Task<EKKOLLPPNIM> EDBOHHNIDFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public class LHFPHAFPDJH : global::MANCHBBCOOE<LHFPHAFPDJH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private CCLMJIMCJFD OCMDFIDHJDH;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x32500F0", Offset = "0x324F4F0", VA = "0x1832500F0")]
	internal LHFPHAFPDJH(GOLPDNFBDPM DMBFGIOCCHP, OBGEECKNGII LLGLGGINHDF, [Optional] Guid? JLOMHEMDNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x94A180", Offset = "0x949580", VA = "0x18094A180")]
	public LHFPHAFPDJH OJAMHINKHPG(CCLMJIMCJFD OCMDFIDHJDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x3250030", Offset = "0x324F430", VA = "0x183250030", Slot = "4")]
	protected override void BPIDOBDCMLN(KNOPHICLNED CIBBLLOHCGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
public class JGBBPIJGKMA : global::MANCHBBCOOE<JGBBPIJGKMA>
{
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	internal enum PEFOEOJFFMF
	{
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct GAJMDCCADBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public AsyncTaskMethodBuilder<EKKOLLPPNIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public JGBBPIJGKMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private TaskAwaiter<EKKOLLPPNIM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BCB0", Offset = "0x3C4B0B0", VA = "0x183C4BCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BFB0", Offset = "0x3C4B3B0", VA = "0x183C4BFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private PEFOEOJFFMF CFBEIGPGBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private string EFLFGAFNKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000668")]
	private KHFJKINMMAE OCMDFIDHJDH;

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x324BBB0", Offset = "0x324AFB0", VA = "0x18324BBB0")]
	internal JGBBPIJGKMA(GOLPDNFBDPM DMBFGIOCCHP, OBGEECKNGII LLGLGGINHDF, [Optional] Guid? JLOMHEMDNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x324BB00", Offset = "0x324AF00", VA = "0x18324BB00")]
	public JGBBPIJGKMA FDPKGMABFKM(string GBLODIDCLHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x324BB30", Offset = "0x324AF30", VA = "0x18324BB30")]
	public JGBBPIJGKMA GHEEGJLNIIF(bool DLDMLCMNEEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x324BB80", Offset = "0x324AF80", VA = "0x18324BB80")]
	public JGBBPIJGKMA NOFBFPLOBPP(string NMGICKMLDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x324BB50", Offset = "0x324AF50", VA = "0x18324BB50")]
	public JGBBPIJGKMA HNBMPGBDDLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x324B870", Offset = "0x324AC70", VA = "0x18324B870", Slot = "4")]
	protected override void BPIDOBDCMLN(KNOPHICLNED CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x324B9E0", Offset = "0x324ADE0", VA = "0x18324B9E0", Slot = "5")]
	[AsyncStateMachine(typeof(GAJMDCCADBB))]
	public override Task<EKKOLLPPNIM> EDBOHHNIDFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x324B830", Offset = "0x324AC30", VA = "0x18324B830")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<EKKOLLPPNIM> AIBDAHCPOPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal static class PGIFFLAFKAE
{
	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2BC0", Offset = "0x3CC1FC0", VA = "0x183CC2BC0")]
	public static void OBPGMABPJLK(this NFAEEPLGGPJ HLGBNMHNFEF, OAILMIHJFAK MHAPMKMEKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2B40", Offset = "0x3CC1F40", VA = "0x183CC2B40")]
	public static void ELIHCIFOJFK(this OAILMIHJFAK CNMCCMNNBPB, [Optional] string CIBBLLOHCGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public static class CDJPKCFPJGB
{
	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x323A300", Offset = "0x3239700", VA = "0x18323A300")]
	public static LECBPDHMHPK AMAFPIOOHMJ(this COPCGIKJKPF IPFFBCILDPE)
	{
		return default(LECBPDHMHPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x323A3A0", Offset = "0x32397A0", VA = "0x18323A3A0")]
	public static COPCGIKJKPF NBDJPBNCIJE(this LECBPDHMHPK KBGJPKOFNPO)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000181")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000675")]
			public MBNPGMPNOII ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000676")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000677")]
			public MBNPGMPNOII HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000678")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private static MBNPGMPNOII[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private Dictionary<MBNPGMPNOII, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5590", Offset = "0x3CC4990", VA = "0x183CC5590")]
		public bool OELIFBJCMOI(MBNPGMPNOII LJPMBPHCKJL, out ResultConfig PNMMLHPKIGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5470", Offset = "0x3CC4870", VA = "0x183CC5470")]
		public ResultConfig HBAMICMJCLH(MBNPGMPNOII DFCEDJEBLNA, [Optional] HashSet<MBNPGMPNOII> AMCLFJGFMBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5B80", Offset = "0x3CC4F80", VA = "0x183CC5B80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5600", Offset = "0x3CC4A00", VA = "0x183CC5600", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x830720", Offset = "0x82FB20", VA = "0x180830720")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
public static class CHOLENKOGGK
{
	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x323AAF0", Offset = "0x3239EF0", VA = "0x18323AAF0")]
	[KPHLIICFIPJ(OEKFJILJDLM.GameOnly)]
	private static void IBABMEFBFLK(BHKHBEKDAPI EDJAHGEIPIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public interface AMJALDODKON : IEquatable<AMJALDODKON>
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	MIAHBCCJCFO KKCIGGIGLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	DateTime CADJBGJGIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGLNPLBNLKM();

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KPIODMKNIDC(long COLNHBBPCAP, long BPIAGBMFLPM, out OMDMCGFKGDM OCPBEPAJLMP);
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
internal class BPONNALMNCA : CIIIIGJIDFC
{
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class EBCBFLDBIDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public OCGBNMGMCOF autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public EBCBFLDBIDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x3CAEF30", Offset = "0x3CAE330", VA = "0x183CAEF30")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private readonly ADLJAPBCDBM OEEAADFKJHC;

	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private const int CIGFHIJAJDC = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event Action<AMJALDODKON> FIHIENDPGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x32390E0", Offset = "0x32384E0", VA = "0x1832390E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x3239740", Offset = "0x3238B40", VA = "0x183239740", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
	[UnityEngine.Scripting.Preserve]
	public BPONNALMNCA([ANGFGGDOPHE(null)] ADLJAPBCDBM OEEAADFKJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x3238CE0", Offset = "0x32380E0", VA = "0x183238CE0", Slot = "6")]
	public bool CCGJGGJBKHD(long COLNHBBPCAP, long BPIAGBMFLPM, OMDMCGFKGDM OCPBEPAJLMP, OCGBNMGMCOF PAABLILJLLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x3239040", Offset = "0x3238440", VA = "0x183239040")]
	private void EGOEMLKBKKD(AMJALDODKON KGEMKNACOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x32397E0", Offset = "0x3238BE0", VA = "0x1832397E0", Slot = "7")]
	public bool OBDAKNBAPNL(long COLNHBBPCAP, long BPIAGBMFLPM, out AMJALDODKON LFOFFPBKHMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x3239180", Offset = "0x3238580", VA = "0x183239180", Slot = "8")]
	public bool IKGHLIPCLFF(long COLNHBBPCAP, long BPIAGBMFLPM, OCGBNMGMCOF PAABLILJLLA, out AMJALDODKON LFOFFPBKHMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x3239350", Offset = "0x3238750", VA = "0x183239350")]
	private void NECNAOHLAOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x3239230", Offset = "0x3238630", VA = "0x183239230", Slot = "9")]
	public void KJGIMCDMHFI(long COLNHBBPCAP, long BPIAGBMFLPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal abstract class FEHDDMDODDA : ADLJAPBCDBM
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	protected enum NCEMIHLJNGN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class LPEDFDKPNMA : IEnumerable<AMJALDODKON>, IEnumerable, IEnumerator<AMJALDODKON>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private AMJALDODKON <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public FEHDDMDODDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private OCGBNMGMCOF autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public OCGBNMGMCOF <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		private AMJALDODKON System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
		[DebuggerHidden]
		public LPEDFDKPNMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x3CB62D0", Offset = "0x3CB56D0", VA = "0x183CB62D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x3CB65A0", Offset = "0x3CB59A0", VA = "0x183CB65A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x3CB64F0", Offset = "0x3CB58F0", VA = "0x183CB64F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AMJALDODKON> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x3CB64F0", Offset = "0x3CB58F0", VA = "0x183CB64F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class LMFMALAJGMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public OCGBNMGMCOF autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LMFMALAJGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6240", Offset = "0x3CB5640", VA = "0x183CB6240")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class HEHDPHPKBNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public FEHDDMDODDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HEHDPHPKBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2780", Offset = "0x3CB1B80", VA = "0x183CB2780")]
		internal void <TryReadAutosaveFile>b__0(KOFEKCMPOEK.MMEIIFKNGDM ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	protected readonly string KINPEMDOHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private readonly object NIJJDMCLJBO;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract MIAHBCCJCFO KKCIGGIGLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x32400A0", Offset = "0x323F4A0", VA = "0x1832400A0")]
	protected FEHDDMDODDA([CanBeNull] string LFHDLAMMELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x323FEF0", Offset = "0x323F2F0", VA = "0x18323FEF0", Slot = "5")]
	public bool LNPIHIEABHN(long COLNHBBPCAP, long BPIAGBMFLPM, OCGBNMGMCOF PAABLILJLLA, out AMJALDODKON KGEMKNACOAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x323FE70", Offset = "0x323F270", VA = "0x18323FE70", Slot = "6")]
	[IteratorStateMachine(typeof(LPEDFDKPNMA))]
	public IEnumerable<AMJALDODKON> KGGGGAINJCN(OCGBNMGMCOF PAABLILJLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void IBOKNIHFKEI(Stream LEEKJNEOALM, long COLNHBBPCAP, long BPIAGBMFLPM, OMDMCGFKGDM OCPBEPAJLMP);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool PFDMOAENEDD(Stream MJEPFACLOME, long COLNHBBPCAP, long BPIAGBMFLPM, LHCCDDKPOCP LNKNEJNHOOC, out OMDMCGFKGDM OCPBEPAJLMP);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x323F8E0", Offset = "0x323ECE0", VA = "0x18323F8E0", Slot = "7")]
	public AMJALDODKON CONPKJDIEPC(long COLNHBBPCAP, long BPIAGBMFLPM, OMDMCGFKGDM OCPBEPAJLMP, OCGBNMGMCOF PAABLILJLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo NBCELPOONGI(long COLNHBBPCAP, long BPIAGBMFLPM, OCGBNMGMCOF PAABLILJLLA, NCEMIHLJNGN MPEJGKJGGEE);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo HLGLAGIIAGI(OCGBNMGMCOF PAABLILJLLA, NCEMIHLJNGN MPEJGKJGGEE);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x323F870", Offset = "0x323EC70", VA = "0x18323F870")]
	protected void AOKBEEFNCOC(KOFEKCMPOEK.MMEIIFKNGDM NHBPNDDMJGB, string HPCOFNJFOOG, FileInfo BNDMOPGGFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x323FBC0", Offset = "0x323EFC0", VA = "0x18323FBC0")]
	internal bool IADLAANNLIE(FileInfo GOIMCAGGFKL, long COLNHBBPCAP, long BPIAGBMFLPM, out OMDMCGFKGDM OCPBEPAJLMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	private void PGJMKILHBEB(Exception ADPFAOFBEEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
internal class EEOLEMPKEAL : FEHDDMDODDA
{
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private const string HDIHIDEBNAE = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private const string DPPHBJGJIHG = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private const string KBEAHOOEIKM = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public override MIAHBCCJCFO KKCIGGIGLLD
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x9C2220", Offset = "0x9C1620", VA = "0x1809C2220", Slot = "8")]
		get
		{
			return default(MIAHBCCJCFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x323CC60", Offset = "0x323C060", VA = "0x18323CC60")]
	public EEOLEMPKEAL([Optional] string LFHDLAMMELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x323C180", Offset = "0x323B580", VA = "0x18323C180")]
	private void GACOGALIILF(OCGBNMGMCOF PAABLILJLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x323C310", Offset = "0x323B710", VA = "0x18323C310", Slot = "9")]
	internal override void IBOKNIHFKEI(Stream LEEKJNEOALM, long COLNHBBPCAP, long BPIAGBMFLPM, OMDMCGFKGDM OCPBEPAJLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x323C670", Offset = "0x323BA70", VA = "0x18323C670", Slot = "10")]
	internal override bool PFDMOAENEDD(Stream MJEPFACLOME, long COLNHBBPCAP, long BPIAGBMFLPM, LHCCDDKPOCP LNKNEJNHOOC, out OMDMCGFKGDM OCPBEPAJLMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x323C580", Offset = "0x323B980", VA = "0x18323C580", Slot = "11")]
	protected override FileInfo NBCELPOONGI(long COLNHBBPCAP, long BPIAGBMFLPM, OCGBNMGMCOF PAABLILJLLA, NCEMIHLJNGN MPEJGKJGGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x323C200", Offset = "0x323B600", VA = "0x18323C200", Slot = "12")]
	protected override DirectoryInfo HLGLAGIIAGI(OCGBNMGMCOF PAABLILJLLA, NCEMIHLJNGN MPEJGKJGGEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
internal sealed class LEIOHBDFFJH : FEHDDMDODDA
{
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private static readonly byte[] NPBDKCONLNC;

	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private const string DPPHBJGJIHG = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private const string KBEAHOOEIKM = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private const string MLBLGCEHNFM = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private readonly byte[] MBFENLNCHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private readonly byte[] ODJHJOPPEKM;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public override MIAHBCCJCFO KKCIGGIGLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x9C39C0", Offset = "0x9C2DC0", VA = "0x1809C39C0", Slot = "8")]
		get
		{
			return default(MIAHBCCJCFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x324F910", Offset = "0x324ED10", VA = "0x18324F910")]
	public LEIOHBDFFJH([Optional] string LFHDLAMMELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x324EB80", Offset = "0x324DF80", VA = "0x18324EB80", Slot = "9")]
	internal override void IBOKNIHFKEI(Stream LEEKJNEOALM, long COLNHBBPCAP, long BPIAGBMFLPM, OMDMCGFKGDM OCPBEPAJLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x324F070", Offset = "0x324E470", VA = "0x18324F070", Slot = "10")]
	internal override bool PFDMOAENEDD(Stream MJEPFACLOME, long COLNHBBPCAP, long BPIAGBMFLPM, LHCCDDKPOCP LNKNEJNHOOC, out OMDMCGFKGDM OCPBEPAJLMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x324EE30", Offset = "0x324E230", VA = "0x18324EE30")]
	private void LCKHLEPJDIP(byte[] GJDBLJLIDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x324EF40", Offset = "0x324E340", VA = "0x18324EF40", Slot = "11")]
	protected override FileInfo NBCELPOONGI(long COLNHBBPCAP, long BPIAGBMFLPM, OCGBNMGMCOF PAABLILJLLA, NCEMIHLJNGN MPEJGKJGGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x324EA60", Offset = "0x324DE60", VA = "0x18324EA60", Slot = "12")]
	protected override DirectoryInfo HLGLAGIIAGI(OCGBNMGMCOF PAABLILJLLA, NCEMIHLJNGN MPEJGKJGGEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public enum MIAHBCCJCFO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
internal class NBEEENKNAFG : ADLJAPBCDBM
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class DLKKGDBNGHE : IEnumerable<AMJALDODKON>, IEnumerable, IEnumerator<AMJALDODKON>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private AMJALDODKON <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public NBEEENKNAFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private OCGBNMGMCOF autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public OCGBNMGMCOF <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private MIAHBCCJCFO[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private IEnumerator<AMJALDODKON> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		private AMJALDODKON System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
		[DebuggerHidden]
		public DLKKGDBNGHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x4827560", Offset = "0x4826960", VA = "0x184827560", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x4827190", Offset = "0x4826590", VA = "0x184827190", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x48275F0", Offset = "0x48269F0", VA = "0x1848275F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x4827520", Offset = "0x4826920", VA = "0x184827520", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x4827470", Offset = "0x4826870", VA = "0x184827470", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AMJALDODKON> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x4827470", Offset = "0x4826870", VA = "0x184827470", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	private readonly MIAHBCCJCFO[] PHPBJOKNBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private readonly Dictionary<MIAHBCCJCFO, ADLJAPBCDBM> CIJNNMGDBHF;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public MIAHBCCJCFO KKCIGGIGLLD
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8F00", Offset = "0x3CB8300", VA = "0x183CB8F00", Slot = "4")]
		get
		{
			return default(MIAHBCCJCFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9350", Offset = "0x3CB8750", VA = "0x183CB9350")]
	[UnityEngine.Scripting.Preserve]
	public NBEEENKNAFG(params ADLJAPBCDBM[] MILGOHFMFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x3CB91F0", Offset = "0x3CB85F0", VA = "0x183CB91F0", Slot = "5")]
	public bool LNPIHIEABHN(long COLNHBBPCAP, long BPIAGBMFLPM, OCGBNMGMCOF PAABLILJLLA, out AMJALDODKON KGEMKNACOAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8F40", Offset = "0x3CB8340", VA = "0x183CB8F40")]
	private void GIAHIDHOHBK(int BHFEHMGHMDN, long COLNHBBPCAP, long BPIAGBMFLPM, OCGBNMGMCOF PAABLILJLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9170", Offset = "0x3CB8570", VA = "0x183CB9170", Slot = "6")]
	[IteratorStateMachine(typeof(DLKKGDBNGHE))]
	public IEnumerable<AMJALDODKON> KGGGGAINJCN(OCGBNMGMCOF PAABLILJLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8DA0", Offset = "0x3CB81A0", VA = "0x183CB8DA0", Slot = "7")]
	public AMJALDODKON CONPKJDIEPC(long COLNHBBPCAP, long BPIAGBMFLPM, OMDMCGFKGDM OCPBEPAJLMP, OCGBNMGMCOF PAABLILJLLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal static class MKJMKGOAFOE
{
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	internal const int POIFMDDCGHA = 32;

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x32536F0", Offset = "0x3252AF0", VA = "0x1832536F0")]
	internal static byte[] GHHHLIJMKBC(byte[] GJDBLJLIDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x3253670", Offset = "0x3252A70", VA = "0x183253670")]
	public static void CMMKGDGAIHG(Stream LBMMCNGMDLI, byte[] HLNDGDBNHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x3253790", Offset = "0x3252B90", VA = "0x183253790")]
	public static bool ODOHFIMGKBD(Stream LBMMCNGMDLI, long GBDJHKJJIAF, LHCCDDKPOCP LBKOLHDJPCF, out byte[] JKEKPFHIOLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal sealed class OJJKAEEIGHL : AMJALDODKON, IEquatable<AMJALDODKON>, IEquatable<OJJKAEEIGHL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	private readonly FEHDDMDODDA LMHKBNLCCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	public readonly FileInfo MIHHKMEDNFH;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public MIAHBCCJCFO KKCIGGIGLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x12622D0", Offset = "0x12616D0", VA = "0x1812622D0", Slot = "4")]
		get
		{
			return default(MIAHBCCJCFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public DateTime CADJBGJGIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x3CBEE10", Offset = "0x3CBE210", VA = "0x183CBEE10", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF390", Offset = "0x3CBE790", VA = "0x183CBF390")]
	public OJJKAEEIGHL(FEHDDMDODDA NMJPOJNAOOA, FileInfo GOIMCAGGFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF2E0", Offset = "0x3CBE6E0", VA = "0x183CBF2E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF1E0", Offset = "0x3CBE5E0", VA = "0x183CBF1E0", Slot = "6")]
	public void IGLNPLBNLKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF2A0", Offset = "0x3CBE6A0", VA = "0x183CBF2A0", Slot = "7")]
	public bool KPIODMKNIDC(long COLNHBBPCAP, long BPIAGBMFLPM, out OMDMCGFKGDM OCPBEPAJLMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x3CBEF60", Offset = "0x3CBE360", VA = "0x183CBEF60", Slot = "8")]
	public bool Equals(AMJALDODKON FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x3CBEEB0", Offset = "0x3CBE2B0", VA = "0x183CBEEB0", Slot = "9")]
	public bool Equals(OJJKAEEIGHL FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF040", Offset = "0x3CBE440", VA = "0x183CBF040", Slot = "0")]
	public override bool Equals(object JGHFLANLLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF140", Offset = "0x3CBE540", VA = "0x183CBF140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x2725730", Offset = "0x2724B30", VA = "0x182725730")]
	public static bool OACFLELFBPC(OJJKAEEIGHL COMOCJDHDGL, OJJKAEEIGHL APKFNCAIFAF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x2725740", Offset = "0x2724B40", VA = "0x182725740")]
	public static bool OFLJMIEJHAG(OJJKAEEIGHL COMOCJDHDGL, OJJKAEEIGHL APKFNCAIFAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public delegate void LHCCDDKPOCP(KOFEKCMPOEK.MMEIIFKNGDM BIDFBKDJOAC, string CIBBLLOHCGM);
[Cpp2IlInjected.Token(Token = "0x2000196")]
internal interface ADLJAPBCDBM
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	MIAHBCCJCFO KKCIGGIGLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LNPIHIEABHN(long COLNHBBPCAP, long BPIAGBMFLPM, OCGBNMGMCOF PAABLILJLLA, out AMJALDODKON KGEMKNACOAL);

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<AMJALDODKON> KGGGGAINJCN(OCGBNMGMCOF PAABLILJLLA);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AMJALDODKON CONPKJDIEPC(long COLNHBBPCAP, long BPIAGBMFLPM, OMDMCGFKGDM OCPBEPAJLMP, OCGBNMGMCOF PAABLILJLLA);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x3235AA0", Offset = "0x3234EA0", VA = "0x183235AA0")]
	private static string OGMGDCCGOFL(byte[] CFEKEMJOJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x3235750", Offset = "0x3234B50", VA = "0x183235750")]
	public static string DFBBLGFDDMJ(byte[] GJDBLJLIDDI, bool JLJMGNGGBON)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200019B")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200019C")]
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
