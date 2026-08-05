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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x62259F0", Offset = "0x62241F0", VA = "0x1862259F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78AB20", VA = "0x18078C320")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78C360", Offset = "0x78AB60", VA = "0x18078C360")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CDLKNIKKCNK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62142C0", Offset = "0x6212AC0", VA = "0x1862142C0")]
	public CDLKNIKKCNK(string LACIBLEADOC, Exception DCMGDCMCLDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class NOCMLBBAPCJ : HHNGCHNPCHM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct FAGOFGINMMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<GKOKDKMFDDE>> <>t__builder;

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
		private TaskAwaiter<IDBEHODKHKG<GKOKDKMFDDE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6216060", Offset = "0x6214860", VA = "0x186216060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62162A0", Offset = "0x6214AA0", VA = "0x1862162A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JFKIEGLMGIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BCHFMFCPAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<BCHFMFCPAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x621DF60", Offset = "0x621C760", VA = "0x18621DF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x621E170", Offset = "0x621C970", VA = "0x18621E170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	[UnityEngine.Scripting.Preserve]
	public NOCMLBBAPCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x62255D0", Offset = "0x6223DD0", VA = "0x1862255D0", Slot = "4")]
	[AsyncStateMachine(typeof(FAGOFGINMMK))]
	public Task<IReadOnlyList<GKOKDKMFDDE>> KHHPBBPFHIK(long EJLCNJNHKAA, long KEECHBIDKCE, [Optional] CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x62256F0", Offset = "0x6223EF0", VA = "0x1862256F0", Slot = "5")]
	[AsyncStateMachine(typeof(JFKIEGLMGIC))]
	public Task<IReadOnlyList<BCHFMFCPAPL>> OMFJIAHEALB(IReadOnlyList<int> KFHNGINBEOB, [Optional] CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PFHIGANABHH : IEquatable<PFHIGANABHH>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int HDFNGNFCCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	BCHFMFCPAPL DFEKMECPAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime JFMAOEEDOHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	CJGCPDFJPEI? IIFJGHAIBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NMPCGPGJIOM? CJHBIAHPIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	ACAIGPNDJEO IPHBMBFACOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<JJAMOFDJDHP> PCIBBGLNIJC();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum ACAIGPNDJEO
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HHNGCHNPCHM
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<GKOKDKMFDDE>> KHHPBBPFHIK(long EJLCNJNHKAA, long KEECHBIDKCE, [Optional] CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<BCHFMFCPAPL>> OMFJIAHEALB(IReadOnlyList<int> KFHNGINBEOB, [Optional] CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BKMCDAALBHO
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class ALGPBMBBMBH : PFHIGANABHH, IEquatable<PFHIGANABHH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct IBOIGADFHIA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<JJAMOFDJDHP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public ALGPBMBBMBH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private OOJFMECIBMD <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<EECIHAPGBPO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<JJAMOFDJDHP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x621A970", Offset = "0x6219170", VA = "0x18621A970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x621AE10", Offset = "0x6219610", VA = "0x18621AE10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly GKOKDKMFDDE HINNJDBNIND;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int HDFNGNFCCGE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x76CBA0", Offset = "0x76B3A0", VA = "0x18076CBA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public BCHFMFCPAPL DFEKMECPAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime NFCPKDFKHON
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8D1680", Offset = "0x8CFE80", VA = "0x1808D1680", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CJGCPDFJPEI? IIFJGHAIBCL
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x17B8860", Offset = "0x17B7060", VA = "0x1817B8860", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NMPCGPGJIOM? CJHBIAHPIIB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1F54FC0", Offset = "0x1F537C0", VA = "0x181F54FC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ACAIGPNDJEO IPHBMBFACOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7DDB70", Offset = "0x7DC370", VA = "0x1807DDB70", Slot = "10")]
			get
			{
				return default(ACAIGPNDJEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x620F240", Offset = "0x620DA40", VA = "0x18620F240", Slot = "9")]
		[AsyncStateMachine(typeof(IBOIGADFHIA))]
		public Task<JJAMOFDJDHP> PCIBBGLNIJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x620F340", Offset = "0x620DB40", VA = "0x18620F340")]
		public ALGPBMBBMBH(int JCNGOCGPODL, BCHFMFCPAPL NOLLELBBHHN, GKOKDKMFDDE HINNJDBNIND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x620F0F0", Offset = "0x620D8F0", VA = "0x18620F0F0", Slot = "11")]
		public bool Equals(PFHIGANABHH GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x620F050", Offset = "0x620D850", VA = "0x18620F050", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x620F200", Offset = "0x620DA00", VA = "0x18620F200")]
		private bool HKPIENODCEE(ALGPBMBBMBH GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x620F180", Offset = "0x620D980", VA = "0x18620F180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class KBDNOJPIDCO : PFHIGANABHH, IEquatable<PFHIGANABHH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct FDGCJAFNACG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<JJAMOFDJDHP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public KBDNOJPIDCO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<JJAMOFDJDHP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6216D40", Offset = "0x6215540", VA = "0x186216D40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6216F70", Offset = "0x6215770", VA = "0x186216F70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly FLHCBAOPFOP OHICIKBNNEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly CJGCPDFJPEI IGGCGNOPBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly NMPCGPGJIOM PJAECMNOOHB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int HDFNGNFCCGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x621EFA0", Offset = "0x621D7A0", VA = "0x18621EFA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BCHFMFCPAPL DFEKMECPAAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x621EF10", Offset = "0x621D710", VA = "0x18621EF10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime NFCPKDFKHON
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x621EC40", Offset = "0x621D440", VA = "0x18621EC40", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public CJGCPDFJPEI? IIFJGHAIBCL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x621EDE0", Offset = "0x621D5E0", VA = "0x18621EDE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NMPCGPGJIOM? CJHBIAHPIIB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x621EBF0", Offset = "0x621D3F0", VA = "0x18621EBF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ACAIGPNDJEO IPHBMBFACOM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7E11F0", Offset = "0x7DF9F0", VA = "0x1807E11F0", Slot = "10")]
			get
			{
				return default(ACAIGPNDJEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD4FD50", Offset = "0xD4E550", VA = "0x180D4FD50")]
		public KBDNOJPIDCO(FLHCBAOPFOP HHLLBPMFFJA, CJGCPDFJPEI PAMJLKDMCCI, NMPCGPGJIOM LHNBDPNBLAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x621EFE0", Offset = "0x621D7E0", VA = "0x18621EFE0", Slot = "9")]
		[AsyncStateMachine(typeof(FDGCJAFNACG))]
		public Task<JJAMOFDJDHP> PCIBBGLNIJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x621EC90", Offset = "0x621D490", VA = "0x18621EC90", Slot = "11")]
		public bool Equals(PFHIGANABHH GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x621ED30", Offset = "0x621D530", VA = "0x18621ED30", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x621EEB0", Offset = "0x621D6B0", VA = "0x18621EEB0")]
		private bool HKPIENODCEE(KBDNOJPIDCO GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x621EE30", Offset = "0x621D630", VA = "0x18621EE30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class CHFNHPLHEBK : PFHIGANABHH, IEquatable<PFHIGANABHH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct IJIAJDAEIBL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<JJAMOFDJDHP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<JJAMOFDJDHP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x621B9F0", Offset = "0x621A1F0", VA = "0x18621B9F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x621BC30", Offset = "0x621A430", VA = "0x18621BC30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly BCHFMFCPAPL AFDDCNCICJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly CJGCPDFJPEI IGGCGNOPBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly NMPCGPGJIOM PJAECMNOOHB;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int HDFNGNFCCGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6214BE0", Offset = "0x62133E0", VA = "0x186214BE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public BCHFMFCPAPL DFEKMECPAAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime NFCPKDFKHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x761FD0", Offset = "0x7607D0", VA = "0x180761FD0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public CJGCPDFJPEI? IIFJGHAIBCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x62149B0", Offset = "0x62131B0", VA = "0x1862149B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NMPCGPGJIOM? CJHBIAHPIIB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6214870", Offset = "0x6213070", VA = "0x186214870", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ACAIGPNDJEO IPHBMBFACOM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x761FD0", Offset = "0x7607D0", VA = "0x180761FD0", Slot = "10")]
			get
			{
				return default(ACAIGPNDJEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD4FD50", Offset = "0xD4E550", VA = "0x180D4FD50")]
		public CHFNHPLHEBK(BCHFMFCPAPL NOLLELBBHHN, CJGCPDFJPEI PAMJLKDMCCI, NMPCGPGJIOM LHNBDPNBLAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6214C60", Offset = "0x6213460", VA = "0x186214C60", Slot = "9")]
		[AsyncStateMachine(typeof(IJIAJDAEIBL))]
		public Task<JJAMOFDJDHP> PCIBBGLNIJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x62148C0", Offset = "0x62130C0", VA = "0x1862148C0", Slot = "11")]
		public bool Equals(PFHIGANABHH GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6214930", Offset = "0x6213130", VA = "0x186214930", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6214A00", Offset = "0x6213200", VA = "0x186214A00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6214AB0", Offset = "0x62132B0", VA = "0x186214AB0")]
		private bool HKPIENODCEE(CHFNHPLHEBK GHNNCJBDHKF)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct AOHKNAPKKLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<PFHIGANABHH>> <>t__builder;

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
		public BKMCDAALBHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<GKOKDKMFDDE> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<GKOKDKMFDDE>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, BCHFMFCPAPL account, GKOKDKMFDDE roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x62100F0", Offset = "0x620E8F0", VA = "0x1862100F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6210ED0", Offset = "0x620F6D0", VA = "0x186210ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct OHLHFFJBMOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, BCHFMFCPAPL account, GKOKDKMFDDE roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<GKOKDKMFDDE> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public BKMCDAALBHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<BCHFMFCPAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6226690", Offset = "0x6224E90", VA = "0x186226690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x62270D0", Offset = "0x62258D0", VA = "0x1862270D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MEDNDKGIJOJ LMIINFJPCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HHNGCHNPCHM MOCKCPKBJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly AGDJJDJHMHB GLAGEJIAAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly BGGFJEOIJEE<(long, long), IReadOnlyList<GKOKDKMFDDE>> NMIDEFIGPBM;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6212B50", Offset = "0x6211350", VA = "0x186212B50")]
	[UnityEngine.Scripting.Preserve]
	public BKMCDAALBHO([AKMGDNDIMPI(null)] HHNGCHNPCHM HACBHPKOOJC, [AKMGDNDIMPI(null)] AGDJJDJHMHB FBKGOJCDKHM, [AKMGDNDIMPI(null)] MEDNDKGIJOJ AAONAMAFOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6212A00", Offset = "0x6211200", VA = "0x186212A00")]
	[AsyncStateMachine(typeof(AOHKNAPKKLF))]
	public Task<IList<PFHIGANABHH>> MPGHKBFCCDN(long EJLCNJNHKAA, long FDNNACNGHGO, bool IGJLCPJELKG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6212860", Offset = "0x6211060", VA = "0x186212860")]
	private bool FKDBEHMIMGF(DateTime? DFGFJMLGOOL, long EJLCNJNHKAA, long FDNNACNGHGO, [Out] FLHCBAOPFOP CDBCCOOGIEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6212750", Offset = "0x6210F50", VA = "0x186212750")]
	[AsyncStateMachine(typeof(OHLHFFJBMOA))]
	private Task<IReadOnlyList<(int, BCHFMFCPAPL, GKOKDKMFDDE)>> BOIADAPHKLI(IReadOnlyList<GKOKDKMFDDE> OOCLAOAHBFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AGDJJDJHMHB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<FLHCBAOPFOP> FHICCOHHCND;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OKDGDBCDILC(long EJLCNJNHKAA, long FDNNACNGHGO, GDEGEKAIEIO GGGAPNAEJML, IBBKBOPDBAK KEHONEKOMDA);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LNFNCDEEDDA(long EJLCNJNHKAA, long FDNNACNGHGO, [Out] FLHCBAOPFOP CDBCCOOGIEL);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FDLDKDDHNPF(long EJLCNJNHKAA, long FDNNACNGHGO, IBBKBOPDBAK KEHONEKOMDA, [Out] FLHCBAOPFOP CDBCCOOGIEL);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BHCIMKHFJEB(long EJLCNJNHKAA, long FDNNACNGHGO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface HDNNGOECGBI : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ABHEOBAIAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task FAIAEBFDPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FALJMOAMAFG(Task DGINPAIAOMP, string DHLOGNBKFEC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface EDPPJJGAKJA : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JJAMOFDJDHP> IPICDDPNPKC(FLHCBAOPFOP CDBCCOOGIEL);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MFMCIOFDEFB(CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface CFLKBIBCDJP : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CMLGONECJCN BBCAHJICDOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHKBAKDBMOP();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EPMJOCIBJBM();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface CEMJENDAKDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface OIODMMKFNHN
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan GKDFJJHPIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan JOKNOPFGGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan NPAPPEOBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan DLADGACAFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool DLJJLLJPODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool APHILAPAGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OCHAFNDHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int EIHBGIGPGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JKOIIJLKPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum CGENDBCKMBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum FBBDFPONJFN
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
public struct KHIICHLPDND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long AMAENOBJCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long KEECHBIDKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly CGENDBCKMBJ BJKOKHNAAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception FFHENBGHPEP;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x621F200", Offset = "0x621DA00", VA = "0x18621F200")]
	public KHIICHLPDND(long AMAENOBJCEO, long KEECHBIDKCE, CGENDBCKMBJ BJKOKHNAAID, [CanBeNull] Exception FFHENBGHPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x621F1B0", Offset = "0x621D9B0", VA = "0x18621F1B0")]
	public static KHIICHLPDND KPKHGEOEKHP(MFNEBLAPOMP BMIBLOMHPBB, CGENDBCKMBJ BJKOKHNAAID, [Optional] Exception FFHENBGHPEP)
	{
		return default(KHIICHLPDND);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void HCDOAGIBNBJ(KHIICHLPDND MAHPOCEAIGO);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface JEAMLGPKGGG : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ELMDMCGCOJA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event HCDOAGIBNBJ ONMLBHNPFEC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HCDOAGIBNBJ EAKMKONKCCF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event HCDOAGIBNBJ BHMMEDJJEPI;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<FBBDFPONJFN, bool> DCKPKCCOFEL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KOILHDEEGAN();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MADHAEDOANB(KHIICHLPDND MAHPOCEAIGO);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ENHOFLOCPMM(KHIICHLPDND MAHPOCEAIGO);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JPCBPPMGPNF(KHIICHLPDND MAHPOCEAIGO);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OAJGKFCFHEE(FBBDFPONJFN PHIFKJALFPB, bool LNBAAAMMLGI);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface CADPBBGPEGA : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HBKPKICEGPC();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJOFLBLEECE();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface OFFAOEFCPMH : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	TaskStatus DIHMEDCEKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MJADPFFANNN(MFNEBLAPOMP GLFNGDOHNJH, FNDAMPCNFND GBFJAJLHCCO, CancellationToken MHKFOCFJDAA);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal static class LGKNBEKNJJG
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6224CD0", Offset = "0x62234D0", VA = "0x186224CD0")]
	public static bool DFEMIGALBKJ(this OFFAOEFCPMH JCDNHPPBMDP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public delegate Task OEJJLMDLCGB(JIHLGMHMNNN EKBIDHDINDL, CancellationToken PIPCHJCEPPJ);
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface CCAKIPMFFCB : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BDLLGGBPEIA(OEJJLMDLCGB PGILBIDMOCN);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface MAJPJMCJJLM : OOJFMECIBMD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	CancellationToken AIOPEENLFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	MPCHBJGCNBP PKDHIHLHEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	FEHJFMFNJLD IOCIKAPEOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	EKCOKNMBGKP AJACLCPIBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	NGMOAIDHLMP DDNOPAPNNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FIOHPHCNBAK NEHEAHGOMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	LMMKFLEMMPC GMBPPHHMGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	GLJEHEJFJGI MEBBHAIDGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	AHLBCEHGINI NMGFFNHJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HDNNGOECGBI IDLGAFBIPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	EDPPJJGAKJA AIHONOACLAN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	JEAMLGPKGGG PLLBKHOJKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	CADPBBGPEGA PEPFHMDOEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	OFFAOEFCPMH BPOGJDPHDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	CCAKIPMFFCB NFOGJELEMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	PFNAKLPOBFB FGFDBPFIHKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	IKLIOEGIHAP FEDJAOHKPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	EENCPGGOAOF DJCEEJPPILG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	PGNPNLILCHA OGKNBOLIOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	EFPHCAFJJKI NFIKPIFHPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	KENGCGJDOLN EADPAAABJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	CIBNAOBGHGP KMIOCEDCCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	NOAKFPBBDBH BMIAKPNDAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	OOGKBHBCPMI HBGJEFPALDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	MPMMPPEJPGA AGINIKMPLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	CFLKBIBCDJP NJAJJBDONIP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	OIODMMKFNHN CFDHEPDPNHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	GNALCFGGCEC ABBHFBMOLME
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	AGDJJDJHMHB CHELNACDIOK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	MOHLDHBNJEI AGIKLIHICIM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	PBLOGGEMBJD BMDPMPGHHGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void AJGFCEDOJGM(FNDAMPCNFND NFOPFOMHJOD);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface PFNAKLPOBFB : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NOKGCPFMFJM EIGFNHEIDIC(Guid CGNOLEKHOBB);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OICBJJIPNIH(Guid CGNOLEKHOBB);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHNCPNHOMCA(Guid CGNOLEKHOBB, Task HMJMMIJLJAP);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IJMFEJLHNIO(Guid CGNOLEKHOBB, JJAMOFDJDHP HAPPNCBCGNO);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(JJAMOFDJDHP, Task)> HEHMBILBILG(Guid CGNOLEKHOBB);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface PCIHHEPKGLB : CEMJENDAKDI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface IKLIOEGIHAP : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFKCFMJAGDL(DGGJMFLMPCO LACIBLEADOC);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBOKNMOIGBJ(DGGJMFLMPCO LACIBLEADOC);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<FGCIHKDOMIA> ENOECJLAMMB(CancellationToken FFDGCDLGEIM);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface EENCPGGOAOF : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NOKGCPFMFJM HNEFAJILENF(DGGJMFLMPCO HNOGGDKAEDI);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EDKLNDEHMCH(Guid CGNOLEKHOBB, Task HMJMMIJLJAP);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface PGNPNLILCHA : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JJAMOFDJDHP> OGKNBOLIOKO(DGGJMFLMPCO CAGLDJCODFH);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface EFPHCAFJJKI : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IDDPDCCBLKC> AEELCAEKHEE(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, MFNEBLAPOMP GLFNGDOHNJH, CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface CIBNAOBGHGP : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJAMOFDJDHP BNBIMNJFDJP(OGIKDEMJHKP CNAAIHEGHKN);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HJAFMJDLBKO(string OMHPAGCEPHJ);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface KENGCGJDOLN : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DGGJMFLMPCO> AEEHMHCMBKO(DGGJMFLMPCO FDOGBBKMGKO, NENHMEPEJHH NHGCEFHBKEP, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DGGJMFLMPCO> DDMKGEHFEOA(CancellationToken NCEIDHNHODH, NENHMEPEJHH NHGCEFHBKEP);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GGBNNOAMFHH IEHIOLNFNMH(ELMHAJPGKEB JHGGCNMDALA, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GGBNNOAMFHH NJJEANANECJ(ELMHAJPGKEB JHGGCNMDALA, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface NOAKFPBBDBH : CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJAMOFDJDHP FBFOPBICBPG(OGIKDEMJHKP CNAAIHEGHKN, FGCIHKDOMIA NHPBHKFKFOB);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JJAMOFDJDHP OLJFELCNEDK(OGIKDEMJHKP NMMMAHNJECD);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface OOGKBHBCPMI
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FICIEKAIPFM(GPACDPBJIOP PEANKIBNAGE);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBFADHGCFEB(GPACDPBJIOP PEANKIBNAGE);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JEENOJOLJLH(GPACDPBJIOP PEANKIBNAGE);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBKAFNHEFPN(GPACDPBJIOP PEANKIBNAGE);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class GPACDPBJIOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly MFNEBLAPOMP NJNNOBLPKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> EFEKONCCLPD;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public GJGBNJADGMM<string> IODLOJDMIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x7634B0", VA = "0x180764CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	public GPACDPBJIOP(MFNEBLAPOMP LBLFNDEJNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6219730", Offset = "0x6217F30", VA = "0x186219730")]
	public GPACDPBJIOP DBBDCJJIKHI(string EBICOEDOGKC, string IFKKLLBODIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6219800", Offset = "0x6218000", VA = "0x186219800")]
	public bool GACIDOJAHHJ([Out] IEnumerable<KeyValuePair<string, string>> JBLGAEKJNFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x567AA80", Offset = "0x5679280", VA = "0x18567AA80")]
	public GPACDPBJIOP AGMJKHIBLEO(GJGBNJADGMM<string> HCIPJNOFOCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface GNALCFGGCEC
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool DDAMNNMAFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	string NDFBFOPLJOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MAFBJEFFLPD();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BGCAIAOCLNF DPMCCGKGCAI(long LKELLPJGDFO);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IPLHKPNIDMG<IKADIHEDPNP, GGDFBENKHAA> HOPNHGDNFIG(long LKELLPJGDFO);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IPLHKPNIDMG<IKADIHEDPNP, NHKJOGGKLGM> IBCHPAOJPEO(long LKELLPJGDFO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IPLHKPNIDMG<long, ADKICODIKGA> DGNKIGPNLAN();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> AKGHOMFLKCP(byte[] ODMOBPIKOMJ, byte[] LFJGLGNJDAA, CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface OOJFMECIBMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool DFEMIGALBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool JJINKIHGJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	FNDAMPCNFND IKIFCJOHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action ELMDMCGCOJA;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event HCDOAGIBNBJ ONMLBHNPFEC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event HCDOAGIBNBJ EAKMKONKCCF;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event HCDOAGIBNBJ BHMMEDJJEPI;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<FBBDFPONJFN, bool> DCKPKCCOFEL;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DJOFLBLEECE();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FFBPABPNMLI JFEHIKMAJDO();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OHMAKDLGDFA IJENOOJFIPO();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<JJAMOFDJDHP> IPICDDPNPKC(FLHCBAOPFOP HHLLBPMFFJA);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task MFMCIOFDEFB(CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface FIOHPHCNBAK
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool EJCJILDBCCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string DOPKHOFJOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDDIAKKBENA(Scene GJCLIEAGPHI);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BCHIKEAKJOJ(BKAFNPCOIPD BNKMFPGGFLB, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LFMPBMOCOHI();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface NGMOAIDHLMP
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	OPPEAOPALJL EACCPEEKEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool DFFPCGOGBND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool KADEENBOOMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool EJBJOAIDFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool LNDKJAHGPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool EEOEFNCMFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool OGJFKDFIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float POKGGKDJHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> NADFMONKCHC;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MPCHBJGCNBP KJIKPGHGEPK(MPCHBJGCNBP GNIFGHPMHGL);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDBDFIOKHAP(MPCHBJGCNBP DJDFFLPPHHA);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EOCDHJFEPJC();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task CHDJDCIGKIN(GJGBNJADGMM<string>.NJLLNAPFMFK EEJEKOAEDJL, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMLFGFEIJGK(float OHGIGMABAEG);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DBOFBMOOBFN(string PMFEOHBFPBF);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<KFMAKOMGIMC> DJLHGNBADPE();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable CCNGIGFJJKA(object LIODJEBJPCP, KFMAKOMGIMC GPCEEAOLIHJ);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GGDFBENKHAA LIGNNMBIHKN(IEnumerable<EIOKPMDGBOG> KGMDPLHMIAM);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IHNKFILONAH(int NODGLOENINC);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task BEOOEHJNGDH();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HMIEBMKOJNG();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool IGJPJEEFKLG();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task EMHKEPLEKMN(CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task ODKNOLKCOGI(CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<GIMOEMINLBO> DKDPCCJNINE(DateTime PHDBLBODELN, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<bool> FKGNAMLAEOK(CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void POKAAFJBFPN(string POCOGFKKBGD = "", float AIKHKAOPEOH = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	PIAFPDBPJKH GAFIFODCCJH(GPILLMEHCKI OKBKLFFMACC, LCMMCDFAPFH ECAPLELHMOA, NHKJOGGKLGM JIKNAIPIKIL, IEnumerable<PersistenceView> PLLMOHIABIO, KDLDCCCKPJN BKLJBFPCFAH);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void AEKKDILFHND(NHKJOGGKLGM JIKNAIPIKIL);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BNHJHFFNLOB(EIOKPMDGBOG ABFGFJDAMKM, [In] PIAFPDBPJKH BDODKHNBHFM);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task JHGAECDBCEB(NHKJOGGKLGM MCDMEHJKDHP, bool KKPADBHBCMO, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task DEKKBMAOMFM(CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JMOLNLGEJLA(long EJLCNJNHKAA, long KEECHBIDKCE, EECIHAPGBPO MIJEACHDKHJ, GKOKDKMFDDE IKMFLIBAGDD, GDEGEKAIEIO GGGAPNAEJML, MNCILMPOIGF? EFBEAHBHKGB, DPBKFADKGDF? AAGDLJMIGID);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NFHHFHDAHGI(long EJLCNJNHKAA, long KEECHBIDKCE, DPBKFADKGDF? AAGDLJMIGID);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void IBGHLPGLJMJ(PersistenceView AFLDGMMMBFD);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool EKJPIBKAEFO(PersistenceView ICAGFLPKAGF);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool AGFKEJINDPP(EIOKPMDGBOG ABFGFJDAMKM, GLIPOGAFJFJ MGMDHGEHFPB, [Out] KDDEBPPJICK KNCOJBINNFB);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task JJKLLGECAEI(CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void NPDBLMGLCJM();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IDisposable MILNMEIBBGE();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void KNCNABPLOPP(NHKJOGGKLGM MCDMEHJKDHP, GLIPOGAFJFJ MGMDHGEHFPB);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<bool> LEGLMEBCJCF(FEHJFMFNJLD EFJCCGHENLP, CancellationToken NCEIDHNHODH, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void AAKMFDDJOLP(CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<ILCOBDLGLGL> LMLJAJFHDHE(LKGBMOEKCDI FDOGBBKMGKO);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<EECIHAPGBPO> EOEBCIGFIDB(long EJLCNJNHKAA, bool GMLFJAKKCJA, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<GKOKDKMFDDE> JNHGLPFJCLJ(long EJLCNJNHKAA, long KEECHBIDKCE, long DKLLEJDNMKH, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<EGANNAAHLJC> EIMJMPMEIHI(string AGLMNMBOMLF, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<EGANNAAHLJC> CKFFLCJJMPN(string AGLMNMBOMLF, long EJLCNJNHKAA, long KEECHBIDKCE, string KOAJJCKLDML, DEKGBIFNIKA.CLKFDKPAHHB EKBIDHDINDL, DEKGBIFNIKA.CLKFDKPAHHB LFJGLGNJDAA, int CAKLMGDELIK);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool AJJKNPLGMAH();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool FMMIOCEGFEK();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool NCGFMINPHGM(IEnumerable<KDDEBPPJICK> CLPGNDHNIGJ);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void INJACLGDGNF(List<GameObject> MPAOEGFFDOE);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float OBACIINGCFB();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<Scene> NOFCLMMJNOM(string LINGGNBNLPP, LoadSceneMode MGNGBPDGLNM, bool AGFDKGFIPBJ, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void NOGJKEKGBOB();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void DBLFJEFFIEC(bool ICGNKEDIKDH);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void CABHHCHKPGG(MFNEBLAPOMP OOLBMDAJJLO);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "58")]
	Task PADPHPIPLMA(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task FIDIDGAMFCP(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task HMKLKGALANM(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "61")]
	IDisposable PDCGKIBIFIN();

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "62")]
	CKACELKMDCF DFJGGDKGFPF();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task OGMFHPBJOEL(CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface CKACELKMDCF
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ADHBNKOGMEK(CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MNEHNDOOKIC(CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct PIAFPDBPJKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> NCCMEKPAGNB;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum GIMOEMINLBO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct GPILLMEHCKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string FEOJGNEGJPI;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface OPPEAOPALJL
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	MFNEBLAPOMP NBKCGLNGNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	EECIHAPGBPO GAGLAHGJBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	MDHHLNLKLJD JICEAGKDGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool GNEFMPNADOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool CEOIKMCELAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int PJNBJGHPJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action MPNGNDHLFHD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> IMJCPHBNJJM;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GOADLLNGALE();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.OIABHCOJCFB> JNKDGMFILOB(long LKELLPJGDFO, [Optional] CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.DFAOLODLOLP> MICFMMPNJPI();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task OIJEANAJADN();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(MFNEBLAPOMP, FNDAMPCNFND) JBCLGEDJAHJ();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FALBIGDBNFH BIFCAMCEBEN();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DKAHLMGCGHE(long LKELLPJGDFO);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MPMMPPEJPGA
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOCDAJJIMJC([Out] IEnumerable<int> IALAPKAPGFN);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOJGHOCFFKP(MICACFBJMJM PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNMOLPBJLNE(MICACFBJMJM PIPCHJCEPPJ);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface NPOCFBJDEPF
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PIHCCIPAAPM(JJAMOFDJDHP EINOPIPKKIO);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EHAADLPADGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNAEJHAMCEE(CFOLALGJNGK.CCACBAFJIHD JEOGDBBAHNP);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIHGBCPDECL(CFOLALGJNGK.CCACBAFJIHD JEOGDBBAHNP);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface LMMKFLEMMPC : EHAADLPADGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJAMOFDJDHP GMIPJKCNAPE(OGIKDEMJHKP NMMMAHNJECD);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GLJEHEJFJGI : EHAADLPADGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJAMOFDJDHP BNBIMNJFDJP(OGIKDEMJHKP INJFADHECIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface BGCAIAOCLNF
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ENHODGJKDIF<BKAFNPCOIPD, OFFEGPLAFGN>> MNEANPHIDGG(string KOAJJCKLDML, long LKELLPJGDFO, IBOLNHACDLA.AKIMNHBIOAL FDLLKJLKJJK, CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface IPLHKPNIDMG<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ENHODGJKDIF<byte[], OFFEGPLAFGN>> AEONBALBFLD(TGetDataArg EIMPEEDPEPM, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ENHODGJKDIF<LMHJDCGEFHK<TData>, OFFEGPLAFGN> EOEMMFGDOJA(byte[] KOIMDAJNDOD);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class LEDJGINBNGD : MAJPJMCJJLM, OOJFMECIBMD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct FCGIBLPLNGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<JJAMOFDJDHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public LEDJGINBNGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public FLHCBAOPFOP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<JJAMOFDJDHP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6216A50", Offset = "0x6215250", VA = "0x186216A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6216CD0", Offset = "0x62154D0", VA = "0x186216CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct GDBBPLJCHID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public LEDJGINBNGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6217FB0", Offset = "0x62167B0", VA = "0x186217FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x62181E0", Offset = "0x62169E0", VA = "0x1862181E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class NNIJGIAGIGN : IEnumerable<CEMJENDAKDI>, IEnumerable, IEnumerator<CEMJENDAKDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private CEMJENDAKDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public LEDJGINBNGD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private CEMJENDAKDI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x866770", Offset = "0x864F70", VA = "0x180866770")]
		[DebuggerHidden]
		public NNIJGIAGIGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6225120", Offset = "0x6223920", VA = "0x186225120", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6225580", Offset = "0x6223D80", VA = "0x186225580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x62254D0", Offset = "0x6223CD0", VA = "0x1862254D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CEMJENDAKDI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x62254D0", Offset = "0x6223CD0", VA = "0x1862254D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource EHGENNNHGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly MPCHBJGCNBP DJDFFLPPHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private POPGAKNIMBC AMBIGOFHBDL;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public FEHJFMFNJLD IOCIKAPEOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x762B10", Offset = "0x761310", VA = "0x180762B10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x762D80", Offset = "0x761580", VA = "0x180762D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EKCOKNMBGKP AJACLCPIBJC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x762B50", Offset = "0x761350", VA = "0x180762B50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x762A30", Offset = "0x761230", VA = "0x180762A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public NGMOAIDHLMP DDNOPAPNNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x762BA0", Offset = "0x7613A0", VA = "0x180762BA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x762AA0", Offset = "0x7612A0", VA = "0x180762AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public FIOHPHCNBAK NEHEAHGOMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x763DB0", Offset = "0x7625B0", VA = "0x180763DB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x763DC0", Offset = "0x7625C0", VA = "0x180763DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public LMMKFLEMMPC GMBPPHHMGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x762B30", Offset = "0x761330", VA = "0x180762B30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x762B80", Offset = "0x761380", VA = "0x180762B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public GLJEHEJFJGI MEBBHAIDGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x762AB0", Offset = "0x7612B0", VA = "0x180762AB0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x762A70", Offset = "0x761270", VA = "0x180762A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public AHLBCEHGINI NMGFFNHJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x76F3A0", Offset = "0x76DBA0", VA = "0x18076F3A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x76F2B0", Offset = "0x76DAB0", VA = "0x18076F2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public HDNNGOECGBI IDLGAFBIPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x76F3E0", Offset = "0x76DBE0", VA = "0x18076F3E0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x76F3D0", Offset = "0x76DBD0", VA = "0x18076F3D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public EDPPJJGAKJA AIHONOACLAN
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x76F310", Offset = "0x76DB10", VA = "0x18076F310", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x76F2E0", Offset = "0x76DAE0", VA = "0x18076F2E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public JEAMLGPKGGG PLLBKHOJKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x810850", Offset = "0x80F050", VA = "0x180810850", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x810930", Offset = "0x80F130", VA = "0x180810930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public CADPBBGPEGA PEPFHMDOEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x76F350", Offset = "0x76DB50", VA = "0x18076F350", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x76F2C0", Offset = "0x76DAC0", VA = "0x18076F2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public OFFAOEFCPMH BPOGJDPHDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x89E0A0", Offset = "0x89C8A0", VA = "0x18089E0A0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x89E5D0", Offset = "0x89CDD0", VA = "0x18089E5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public CCAKIPMFFCB NFOGJELEMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x76EA20", Offset = "0x76D220", VA = "0x18076EA20", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x76E9B0", Offset = "0x76D1B0", VA = "0x18076E9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public PFNAKLPOBFB FGFDBPFIHKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8B6640", Offset = "0x8B4E40", VA = "0x1808B6640", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8B6890", Offset = "0x8B5090", VA = "0x1808B6890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public PCIHHEPKGLB FPJMNCIHBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x83D750", Offset = "0x83BF50", VA = "0x18083D750", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6950", Offset = "0x8B5150", VA = "0x1808B6950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public IKLIOEGIHAP FEDJAOHKPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B4E90", VA = "0x1808B6690", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8B68F0", Offset = "0x8B50F0", VA = "0x1808B68F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public EENCPGGOAOF DJCEEJPPILG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x816EB0", Offset = "0x8156B0", VA = "0x180816EB0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6970", Offset = "0x8B5170", VA = "0x1808B6970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public PGNPNLILCHA OGKNBOLIOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8B66A0", Offset = "0x8B4EA0", VA = "0x1808B66A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8B6910", Offset = "0x8B5110", VA = "0x1808B6910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public EFPHCAFJJKI NFIKPIFHPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x76EA10", Offset = "0x76D210", VA = "0x18076EA10", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x76E990", Offset = "0x76D190", VA = "0x18076E990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public KENGCGJDOLN EADPAAABJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8B0", Offset = "0x7D90B0", VA = "0x1807DA8B0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8C0", Offset = "0x7D90C0", VA = "0x1807DA8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public CIBNAOBGHGP KMIOCEDCCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8B66C0", Offset = "0x8B4EC0", VA = "0x1808B66C0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8B6990", Offset = "0x8B5190", VA = "0x1808B6990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public NOAKFPBBDBH BMIAKPNDAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8B66B0", Offset = "0x8B4EB0", VA = "0x1808B66B0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8B6930", Offset = "0x8B5130", VA = "0x1808B6930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public OOGKBHBCPMI HBGJEFPALDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8B6680", Offset = "0x8B4E80", VA = "0x1808B6680", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8B68D0", Offset = "0x8B50D0", VA = "0x1808B68D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public MPMMPPEJPGA AGINIKMPLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8B67D0", Offset = "0x8B4FD0", VA = "0x1808B67D0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6BB0", Offset = "0x8B53B0", VA = "0x1808B6BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public CFLKBIBCDJP NJAJJBDONIP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8B67B0", Offset = "0x8B4FB0", VA = "0x1808B67B0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6B70", Offset = "0x8B5370", VA = "0x1808B6B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public OIODMMKFNHN CFDHEPDPNHN
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6760", Offset = "0x8B4F60", VA = "0x1808B6760", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AD0", Offset = "0x8B52D0", VA = "0x1808B6AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public GNALCFGGCEC ABBHFBMOLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8B6720", Offset = "0x8B4F20", VA = "0x1808B6720", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A50", Offset = "0x8B5250", VA = "0x1808B6A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public AGDJJDJHMHB CHELNACDIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8B67C0", Offset = "0x8B4FC0", VA = "0x1808B67C0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public MOHLDHBNJEI AGIKLIHICIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8B6650", Offset = "0x8B4E50", VA = "0x1808B6650", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public PBLOGGEMBJD BMDPMPGHHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8B6790", Offset = "0x8B4F90", VA = "0x1808B6790", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public FNDAMPCNFND IKIFCJOHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8B6730", Offset = "0x8B4F30", VA = "0x1808B6730", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A70", Offset = "0x8B5270", VA = "0x1808B6A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private bool LJFHDNBKNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6224300", Offset = "0x6222B00", VA = "0x186224300", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private bool FDOLPAOIKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6224420", Offset = "0x6222C20", VA = "0x186224420", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private CancellationToken DCAFHHABBLL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6224610", Offset = "0x6222E10", VA = "0x186224610", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private MPCHBJGCNBP EBJACJOGJHE
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action HJLFLOGJLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x62240A0", Offset = "0x62228A0", VA = "0x1862240A0", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6224250", Offset = "0x6222A50", VA = "0x186224250", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event HCDOAGIBNBJ MIHINJFFNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x62243C0", Offset = "0x6222BC0", VA = "0x1862243C0", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x62241F0", Offset = "0x62229F0", VA = "0x1862241F0", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event HCDOAGIBNBJ FALGJLMGPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6223D30", Offset = "0x6222530", VA = "0x186223D30", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x62244A0", Offset = "0x6222CA0", VA = "0x1862244A0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event HCDOAGIBNBJ NNOMNAJABHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6224360", Offset = "0x6222B60", VA = "0x186224360", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6224830", Offset = "0x6223030", VA = "0x186224830", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<FBBDFPONJFN, bool> MBADCCOCEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6224190", Offset = "0x6222990", VA = "0x186224190", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6223D90", Offset = "0x6222590", VA = "0x186223D90", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A70", Offset = "0x8B5270", VA = "0x1808B6A70", Slot = "35")]
	public void AJGFCEDOJGM(FNDAMPCNFND NFOPFOMHJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6224890", Offset = "0x6223090", VA = "0x186224890")]
	[UnityEngine.Scripting.Preserve]
	internal LEDJGINBNGD([AKMGDNDIMPI(null)] MPCHBJGCNBP DJDFFLPPHHA, [AKMGDNDIMPI(null)] FEHJFMFNJLD EFJCCGHENLP, [AKMGDNDIMPI(null)] EKCOKNMBGKP LLBLOLECDGF, [AKMGDNDIMPI(null)] NGMOAIDHLMP PEPBPPBDPDE, [AKMGDNDIMPI(null)] FIOHPHCNBAK FGPHFAOCCHB, [AKMGDNDIMPI(null)] LMMKFLEMMPC DJOLGIMLPIM, [AKMGDNDIMPI(null)] GLJEHEJFJGI FHLNBEOKANG, [AKMGDNDIMPI(null)] AHLBCEHGINI CDNPIEBPINI, [AKMGDNDIMPI(null)] HDNNGOECGBI KCJKCNNEHHL, [AKMGDNDIMPI(null)] EDPPJJGAKJA MHGDCEEKOGD, [AKMGDNDIMPI(null)] JEAMLGPKGGG CDJEKMIHKGB, [AKMGDNDIMPI(null)] CADPBBGPEGA MLAEHMKMMLF, [AKMGDNDIMPI(null)] OFFAOEFCPMH JCDNHPPBMDP, [AKMGDNDIMPI(null)] CCAKIPMFFCB KOJOFNIMLCM, [AKMGDNDIMPI(null)] PFNAKLPOBFB AIJLCEBPLLB, [AKMGDNDIMPI(null)] PCIHHEPKGLB CODFHHDPCCH, [AKMGDNDIMPI(null)] IKLIOEGIHAP BIJFFDEAHDI, [AKMGDNDIMPI(null)] EENCPGGOAOF MAGIPIBNNIL, [AKMGDNDIMPI(null)] PGNPNLILCHA EKIKHNEMOMC, [AKMGDNDIMPI(null)] EFPHCAFJJKI EFGNLJOHFAA, [AKMGDNDIMPI(null)] CIBNAOBGHGP EDJHDAFOKNF, [AKMGDNDIMPI(null)] KENGCGJDOLN BLGGKJEFGGN, [AKMGDNDIMPI(null)] NOAKFPBBDBH DLAJDDBMLLH, [AKMGDNDIMPI(null)] OOGKBHBCPMI PFLBMPEAIDP, [AKMGDNDIMPI(null)] MPMMPPEJPGA HHPJHGCIDDD, [AKMGDNDIMPI(null)] OIODMMKFNHN NPLDMOPOFGN, [AKMGDNDIMPI(null)] GNALCFGGCEC KKCICEGDHEN, [AKMGDNDIMPI(null)] AGDJJDJHMHB IOMDENJHDFM, [AKMGDNDIMPI(null)] MOHLDHBNJEI CKGPKLAMPMJ, [AKMGDNDIMPI(null)] PBLOGGEMBJD ICLCAFBEEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6224560", Offset = "0x6222D60", VA = "0x186224560")]
	private void MJKJMKCCJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6223F00", Offset = "0x6222700", VA = "0x186223F00", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x62242B0", Offset = "0x6222AB0", VA = "0x1862242B0", Slot = "48")]
	private void IENIAPLEAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x62247A0", Offset = "0x6222FA0", VA = "0x1862247A0", Slot = "49")]
	private FFBPABPNMLI OKBOGKJNIBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6224100", Offset = "0x6222900", VA = "0x186224100", Slot = "50")]
	private OHMAKDLGDFA GDDOGKFJMEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6223DF0", Offset = "0x62225F0", VA = "0x186223DF0", Slot = "51")]
	[AsyncStateMachine(typeof(FCGIBLPLNGA))]
	private Task<JJAMOFDJDHP> BDDIADJODDK(FLHCBAOPFOP CDBCCOOGIEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6224630", Offset = "0x6222E30", VA = "0x186224630", Slot = "52")]
	[AsyncStateMachine(typeof(GDBBPLJCHID))]
	private Task NNMADFMFNBH(CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6224720", Offset = "0x6222F20", VA = "0x186224720")]
	[IteratorStateMachine(typeof(NNIJGIAGIGN))]
	private IEnumerable<CEMJENDAKDI> OENFNLPNNJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6224500", Offset = "0x6222D00", VA = "0x186224500")]
	[CompilerGenerated]
	private void MDKLMMGKKFJ(CEMJENDAKDI ENFAJMDKEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NOILCJDEFPJ : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0xC18F30", Offset = "0xC17730", VA = "0x180C18F30")]
	public NOILCJDEFPJ(string LACIBLEADOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class DOLDEELLHOF : DGPEGFBFNEO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct HGBLKPGADFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DOLDEELLHOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x621A5C0", Offset = "0x6218DC0", VA = "0x18621A5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x621A900", Offset = "0x6219100", VA = "0x18621A900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly NGMOAIDHLMP PEPBPPBDPDE;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x760A40", Offset = "0x75F240", VA = "0x180760A40")]
	public DOLDEELLHOF(MAJPJMCJJLM BBFJMMLGFPP, NGMOAIDHLMP PEPBPPBDPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6215C30", Offset = "0x6214430", VA = "0x186215C30", Slot = "4")]
	[AsyncStateMachine(typeof(HGBLKPGADFA))]
	public Task<bool> GAPHLIAKNDH(CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6215D20", Offset = "0x6214520", VA = "0x186215D20")]
	[CompilerGenerated]
	private object JAANJBFMGGK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class EHCBAENMDAJ : DGPEGFBFNEO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct CPDNODBKMCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public EHCBAENMDAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x62152E0", Offset = "0x6213AE0", VA = "0x1862152E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x62159F0", Offset = "0x62141F0", VA = "0x1862159F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NGMOAIDHLMP PEPBPPBDPDE;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private OPPEAOPALJL EACCPEEKEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6216010", Offset = "0x6214810", VA = "0x186216010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x760A40", Offset = "0x75F240", VA = "0x180760A40")]
	public EHCBAENMDAJ(MAJPJMCJJLM BBFJMMLGFPP, NGMOAIDHLMP PEPBPPBDPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6215E00", Offset = "0x6214600", VA = "0x186215E00", Slot = "4")]
	[AsyncStateMachine(typeof(CPDNODBKMCJ))]
	public Task<bool> GAPHLIAKNDH(CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6215F30", Offset = "0x6214730", VA = "0x186215F30")]
	[CompilerGenerated]
	private object IIGHNKANNOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class BDFGGOCMNPP : DGPEGFBFNEO
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class OLLFECNDJJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public BDFGGOCMNPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Matchmaking.DFAOLODLOLP result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public MFNEBLAPOMP newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public OLLFECNDJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6227250", Offset = "0x6225A50", VA = "0x186227250")]
		internal object MJHPOBLDJND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6227140", Offset = "0x6225940", VA = "0x186227140")]
		internal object FLPAJFOIBCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x62271B0", Offset = "0x62259B0", VA = "0x1862271B0")]
		internal object KDHPJHILBGE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct BGJEBOKBMDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public BDFGGOCMNPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private OLLFECNDJJP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<Matchmaking.DFAOLODLOLP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6211DB0", Offset = "0x62105B0", VA = "0x186211DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x62126E0", Offset = "0x6210EE0", VA = "0x1862126E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NGMOAIDHLMP PEPBPPBDPDE;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private OPPEAOPALJL EACCPEEKEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6211D60", Offset = "0x6210560", VA = "0x186211D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x760A40", Offset = "0x75F240", VA = "0x180760A40")]
	public BDFGGOCMNPP(MAJPJMCJJLM BBFJMMLGFPP, NGMOAIDHLMP PEPBPPBDPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6211C40", Offset = "0x6210440", VA = "0x186211C40", Slot = "4")]
	[AsyncStateMachine(typeof(BGJEBOKBMDB))]
	public Task<bool> GAPHLIAKNDH(CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal interface DGPEGFBFNEO
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> GAPHLIAKNDH(CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct FCFDNOMCBPP
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class LBLAHHNEOGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public MAJPJMCJJLM manager;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public LBLAHHNEOGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x62201B0", Offset = "0x621E9B0", VA = "0x1862201B0")]
		internal Task IAHDNIMLAMB(JIHLGMHMNNN data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct FPENBKFAOJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public FCFDNOMCBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private FLHCBAOPFOP <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<GIMOEMINLBO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<JJAMOFDJDHP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x62179B0", Offset = "0x62161B0", VA = "0x1862179B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6217F40", Offset = "0x6216740", VA = "0x186217F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct FIHHACMAPEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public FCFDNOMCBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6216FE0", Offset = "0x62157E0", VA = "0x186216FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6217300", Offset = "0x6215B00", VA = "0x186217300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken NCEIDHNHODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly MAJPJMCJJLM FMEPDACEHFM;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private FEHJFMFNJLD IOCIKAPEOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6216440", Offset = "0x6214C40", VA = "0x186216440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private NGMOAIDHLMP DDNOPAPNNMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x62165F0", Offset = "0x6214DF0", VA = "0x1862165F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private OPPEAOPALJL EACCPEEKEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6216640", Offset = "0x6214E40", VA = "0x186216640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private EDPPJJGAKJA AIHONOACLAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x62165A0", Offset = "0x6214DA0", VA = "0x1862165A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1C363A0", Offset = "0x1C34BA0", VA = "0x181C363A0")]
	public FCFDNOMCBPP(CancellationToken NCEIDHNHODH, MAJPJMCJJLM FMEPDACEHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6216790", Offset = "0x6214F90", VA = "0x186216790")]
	public static OEJJLMDLCGB LHHDJDAGLOO(MAJPJMCJJLM FMEPDACEHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6216490", Offset = "0x6214C90", VA = "0x186216490")]
	[AsyncStateMachine(typeof(FPENBKFAOJF))]
	public Task<bool> GFKLAMKNNLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6216840", Offset = "0x6215040", VA = "0x186216840")]
	private bool LNBDOKACNAA([Out] FLHCBAOPFOP CDBCCOOGIEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x62166C0", Offset = "0x6214EC0", VA = "0x1862166C0")]
	[AsyncStateMachine(typeof(FIHHACMAPEI))]
	private Task KGHJMLAMBGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6216310", Offset = "0x6214B10", VA = "0x186216310")]
	private Task<GIMOEMINLBO> CKBDLENNKFG(FLHCBAOPFOP HGFMPGKINMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct NOKGCPFMFJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly PFNAKLPOBFB AIJLCEBPLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid CGNOLEKHOBB;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private Task<(JJAMOFDJDHP, Task)> PNJPPPKPPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6225800", Offset = "0x6224000", VA = "0x186225800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3975050", Offset = "0x3973850", VA = "0x183975050")]
	public NOKGCPFMFJM(PFNAKLPOBFB AIJLCEBPLLB, Guid CGNOLEKHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x62258D0", Offset = "0x62240D0", VA = "0x1862258D0")]
	public TaskAwaiter<(JJAMOFDJDHP, Task)> CKDLNEOCDIK()
	{
		return default(TaskAwaiter<(JJAMOFDJDHP, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6225920", Offset = "0x6224120", VA = "0x186225920", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct OENNPEAHAGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(JJAMOFDJDHP, Task)> ENODOOGLLPF;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Task<(JJAMOFDJDHP, Task)> PNJPPPKPPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6226200", Offset = "0x6224A00", VA = "0x186226200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6226450", Offset = "0x6224C50", VA = "0x186226450")]
	public OENNPEAHAGC(TimeSpan EMAKFGFOEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6226360", Offset = "0x6224B60", VA = "0x186226360")]
	public void OHDCECLDEJC(Task HMJMMIJLJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6226240", Offset = "0x6224A40", VA = "0x186226240")]
	public void KAOCGMLFOJM(JJAMOFDJDHP EINOPIPKKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6226400", Offset = "0x6224C00", VA = "0x186226400")]
	public void PLBEFKPGNDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x62262D0", Offset = "0x6224AD0", VA = "0x1862262D0")]
	internal void MCLMGBCJEFP(string LACIBLEADOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class GNFPKNFAOOE
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class MCPNNBFJBDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public GKOKDKMFDDE subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MCPNNBFJBDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6224D20", Offset = "0x6223520", VA = "0x186224D20")]
		internal bool IIMGFFCINGL(MDHHLNLKLJD s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6219420", Offset = "0x6217C20", VA = "0x186219420")]
	public static IDDPDCCBLKC GFPEABNIECK(long AMAENOBJCEO, long KEECHBIDKCE, string AGLMNMBOMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6218FA0", Offset = "0x62177A0", VA = "0x186218FA0")]
	public static IDDPDCCBLKC GFPEABNIECK(long AMAENOBJCEO, long KEECHBIDKCE, IKADIHEDPNP ODMOBPIKOMJ, long DKLLEJDNMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6219060", Offset = "0x6217860", VA = "0x186219060")]
	public static IDDPDCCBLKC GFPEABNIECK(ILCOBDLGLGL BFGEBICIPLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x62191F0", Offset = "0x62179F0", VA = "0x1862191F0")]
	public static IDDPDCCBLKC GFPEABNIECK(EECIHAPGBPO MCGDKPNCGNC, GKOKDKMFDDE JDPMKOIIHEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6219640", Offset = "0x6217E40", VA = "0x186219640")]
	public static IDDPDCCBLKC NBNEAGJBMEI(this IDDPDCCBLKC AJPCNFDACDH, EECIHAPGBPO DCPHKMGJGLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x62194B0", Offset = "0x6217CB0", VA = "0x1862194B0")]
	public static IDDPDCCBLKC LDMEGBMOEOD(this IDDPDCCBLKC AJPCNFDACDH, GKOKDKMFDDE DFKELKPCKGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class NBOAFHJHJAN : HDNNGOECGBI, CEMJENDAKDI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct CBPPEDIEOMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public NBOAFHJHJAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6213B80", Offset = "0x6212380", VA = "0x186213B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6214260", Offset = "0x6212A60", VA = "0x186214260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly MICACFBJMJM DMBFLKDMCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string FCODPFJOMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task NKJIALAECKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool ABHEOBAIAFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6225060", Offset = "0x6223860", VA = "0x186225060", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Task FAIAEBFDPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6224FD0", Offset = "0x62237D0", VA = "0x186224FD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7640E0", VA = "0x1807658E0", Slot = "7")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6224D50", Offset = "0x6223550", VA = "0x186224D50", Slot = "6")]
	public void FALJMOAMAFG(Task DGINPAIAOMP, string DHLOGNBKFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6224EB0", Offset = "0x62236B0", VA = "0x186224EB0")]
	[AsyncStateMachine(typeof(CBPPEDIEOMG))]
	private Task JMOIKPDMHKN(Task PLNAIJFJBMD, string DHLOGNBKFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6225090", Offset = "0x6223890", VA = "0x186225090")]
	public NBOAFHJHJAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class AJDAHELPHIE : CFLKBIBCDJP, CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool KBDBKIGLEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private CMLGONECJCN GFLPMFJKIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private FEHJFMFNJLD EFJCCGHENLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private OIODMMKFNHN NPLDMOPOFGN;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public CMLGONECJCN BBCAHJICDOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x620ECB0", Offset = "0x620D4B0", VA = "0x18620ECB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x620ED20", Offset = "0x620D520", VA = "0x18620ED20", Slot = "7")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x620EEA0", Offset = "0x620D6A0", VA = "0x18620EEA0", Slot = "5")]
	public void PHKBAKDBMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x620EC70", Offset = "0x620D470", VA = "0x18620EC70", Slot = "6")]
	public void EPMJOCIBJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x620EBB0", Offset = "0x620D3B0", VA = "0x18620EBB0")]
	private Task AIKIIDGMEFP(NDLKKEDOPDE JJPCCHMLAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x620EC70", Offset = "0x620D470", VA = "0x18620EC70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public AJDAHELPHIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class FPAPKCLKBFC : OIODMMKFNHN
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class BFBIKECNCKE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly OCKBJCLIMLK BGKHIPPBKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly string EBICOEDOGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly T FEAAGHJCDLM;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public T GNAEIIEFOAF
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x7B28A0", Offset = "0x7B10A0", VA = "0x1807B28A0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x8B8620", Offset = "0x8B6E20", VA = "0x1808B8620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x46A52F0", Offset = "0x46A3AF0", VA = "0x1846A52F0")]
		public BFBIKECNCKE(OCKBJCLIMLK BGKHIPPBKAM, string EBICOEDOGKC, T FEAAGHJCDLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x46A4E30", Offset = "0x46A3630", VA = "0x1846A4E30")]
		private void FFIOGHHIIMN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly OCKBJCLIMLK BGKHIPPBKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly BFBIKECNCKE<TimeSpan> GPKGAIKIHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly BFBIKECNCKE<TimeSpan> CLABEAHCBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly BFBIKECNCKE<TimeSpan> HBJPCKKOGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly BFBIKECNCKE<TimeSpan> IEAOOBNLFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly BFBIKECNCKE<bool> CJNFHECONCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly BFBIKECNCKE<bool> MKIBAONFHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly BFBIKECNCKE<bool> PGFBGHBMDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly BFBIKECNCKE<int> OJMCDJOGCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly BFBIKECNCKE<bool> CJHJPNLHIGK;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan GKDFJJHPIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6217560", Offset = "0x6215D60", VA = "0x186217560", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan JOKNOPFGGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6217360", Offset = "0x6215B60", VA = "0x186217360", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan NPAPPEOBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6217420", Offset = "0x6215C20", VA = "0x186217420", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TimeSpan DLADGACAFGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x62173A0", Offset = "0x6215BA0", VA = "0x1862173A0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool DLJJLLJPODA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6217460", Offset = "0x6215C60", VA = "0x186217460", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool APHILAPAGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x62174E0", Offset = "0x6215CE0", VA = "0x1862174E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool OCHAFNDHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6217520", Offset = "0x6215D20", VA = "0x186217520", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int EIHBGIGPGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x62173E0", Offset = "0x6215BE0", VA = "0x1862173E0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool JKOIIJLKPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x62174A0", Offset = "0x6215CA0", VA = "0x1862174A0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x62175A0", Offset = "0x6215DA0", VA = "0x1862175A0")]
	[UnityEngine.Scripting.Preserve]
	public FPAPKCLKBFC([AKMGDNDIMPI(null)] OCKBJCLIMLK BGKHIPPBKAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[UnityEngine.Scripting.Preserve]
internal class IJJMFJGNGFD : JEAMLGPKGGG, CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class KGIMOIBJPFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public KHIICHLPDND roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public KGIMOIBJPFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x621F0D0", Offset = "0x621D8D0", VA = "0x18621F0D0")]
		internal object OENGDAODHOM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action ELMDMCGCOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x621C290", Offset = "0x621AA90", VA = "0x18621C290", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x621C140", Offset = "0x621A940", VA = "0x18621C140", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event HCDOAGIBNBJ ONMLBHNPFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x621BCA0", Offset = "0x621A4A0", VA = "0x18621BCA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x621C580", Offset = "0x621AD80", VA = "0x18621C580", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event HCDOAGIBNBJ EAKMKONKCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x621C650", Offset = "0x621AE50", VA = "0x18621C650", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x621BF30", Offset = "0x621A730", VA = "0x18621BF30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event HCDOAGIBNBJ BHMMEDJJEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x621BFD0", Offset = "0x621A7D0", VA = "0x18621BFD0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x621C0A0", Offset = "0x621A8A0", VA = "0x18621C0A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<FBBDFPONJFN, bool> DCKPKCCOFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x621C740", Offset = "0x621AF40", VA = "0x18621C740", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x621C1E0", Offset = "0x621A9E0", VA = "0x18621C1E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "19")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x621C360", Offset = "0x621AB60", VA = "0x18621C360", Slot = "14")]
	public void KOILHDEEGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x621C620", Offset = "0x621AE20", VA = "0x18621C620", Slot = "15")]
	public void MADHAEDOANB(KHIICHLPDND MAHPOCEAIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x621C070", Offset = "0x621A870", VA = "0x18621C070", Slot = "16")]
	public void ENHOFLOCPMM(KHIICHLPDND MAHPOCEAIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x621C330", Offset = "0x621AB30", VA = "0x18621C330", Slot = "17")]
	public void JPCBPPMGPNF(KHIICHLPDND MAHPOCEAIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x621C6F0", Offset = "0x621AEF0", VA = "0x18621C6F0", Slot = "18")]
	public void OAJGKFCFHEE(FBBDFPONJFN PHIFKJALFPB, bool LNBAAAMMLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x621BD40", Offset = "0x621A540", VA = "0x18621BD40")]
	private void AOLJJLOPFJO(HCDOAGIBNBJ GPCEEAOLIHJ, KHIICHLPDND MAHPOCEAIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public IJJMFJGNGFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal class HELJFJHADMO : CADPBBGPEGA, CEMJENDAKDI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct CKFGDJKIHCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public HELJFJHADMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6214D30", Offset = "0x6213530", VA = "0x186214D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6215280", Offset = "0x6213A80", VA = "0x186215280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct KOFLJAFDHOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public HELJFJHADMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x621FAB0", Offset = "0x621E2B0", VA = "0x18621FAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6220150", Offset = "0x621E950", VA = "0x186220150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class APJDHBOBDMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public APJDHBOBDMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6210F40", Offset = "0x620F740", VA = "0x186210F40")]
		internal object HIEEMGJMNPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct AOAPJEDKMFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public HELJFJHADMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private APJDHBOBDMD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x620F8F0", Offset = "0x620E0F0", VA = "0x18620F8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6210080", Offset = "0x620E880", VA = "0x186210080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class INLIGMNFMJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public INLIGMNFMJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x621C7F0", Offset = "0x621AFF0", VA = "0x18621C7F0")]
		internal object AHEFOIHPBAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NGMOAIDHLMP PEPBPPBDPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private DGPEGFBFNEO[] LFPKKEINCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private CancellationTokenSource OOKDIBNEDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private int PNOCLHEKBEH;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x621A3D0", Offset = "0x6218BD0", VA = "0x18621A3D0", Slot = "6")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6219E90", Offset = "0x6218690", VA = "0x186219E90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6219EA0", Offset = "0x62186A0", VA = "0x186219EA0", Slot = "8")]
	public void FELDDOHAJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6219CD0", Offset = "0x62184D0", VA = "0x186219CD0", Slot = "5")]
	public void DJOFLBLEECE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x621A0E0", Offset = "0x62188E0", VA = "0x18621A0E0", Slot = "4")]
	[AsyncStateMachine(typeof(CKFGDJKIHCE))]
	public Task HBKPKICEGPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6219890", Offset = "0x6218090", VA = "0x186219890")]
	private void AIMEEPKDBOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x621A1B0", Offset = "0x62189B0", VA = "0x18621A1B0")]
	[AsyncStateMachine(typeof(KOFLJAFDHOM))]
	private Task HNCCADGEAKK(CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x621A2A0", Offset = "0x6218AA0", VA = "0x18621A2A0")]
	[AsyncStateMachine(typeof(AOAPJEDKMFM))]
	private Task<bool> LGCEBGGPPFO(int ADMJKDLHPCI, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6219DB0", Offset = "0x62185B0", VA = "0x186219DB0")]
	private void DNIEDOOEGKB(int ADMJKDLHPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x621A450", Offset = "0x6218C50", VA = "0x18621A450")]
	private void OGKIILOJLPP(int ADMJKDLHPCI, bool LNBAAAMMLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6219BA0", Offset = "0x62183A0", VA = "0x186219BA0")]
	private void DBGGKKOAMNO(int ADMJKDLHPCI, Exception DCJGKNPOAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6219FB0", Offset = "0x62187B0", VA = "0x186219FB0")]
	private void FLMDJNNIKHN(CancellationToken NCEIDHNHODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public HELJFJHADMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class LCNEEILCHGE : OFFAOEFCPMH, CEMJENDAKDI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct BPHENMIOMPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public MFNEBLAPOMP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public LCNEEILCHGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public FNDAMPCNFND customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6213160", Offset = "0x6211960", VA = "0x186213160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6213B20", Offset = "0x6212320", VA = "0x186213B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct GKAEJPNPEGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public LCNEEILCHGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public MFNEBLAPOMP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public FNDAMPCNFND customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private GJGBNJADGMM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private NENHMEPEJHH <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private GPACDPBJIOP <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6218340", Offset = "0x6216B40", VA = "0x186218340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x6218F40", Offset = "0x6217740", VA = "0x186218F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class OFOKOOODNPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public Matchmaking.DJMCPJNPALD result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public KOCOMPJBIBG errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public OFOKOOODNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x62265E0", Offset = "0x6224DE0", VA = "0x1862265E0")]
		internal object HMELKJICPPP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class KHFHINJEHIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Task<IDDPDCCBLKC> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public KHFHINJEHIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		internal Task<IDDPDCCBLKC> AHFCAAFHKJJ(GJGBNJADGMM<string>.NJLLNAPFMFK _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct AIHIHIJCODP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public LCNEEILCHGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public MFNEBLAPOMP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public FNDAMPCNFND customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public NENHMEPEJHH joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private KHFHINJEHIE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private CIFBALEPACJ <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private NLICGJDEPPG <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private Task<Matchmaking.OIABHCOJCFB> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private HAMBCBOKEBL <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private TaskAwaiter<Matchmaking.OIABHCOJCFB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationToken <photonJoinedToken>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private Task <roomLoadTask>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter<IDDPDCCBLKC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6209D60", Offset = "0x6208560", VA = "0x186209D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x620EB50", Offset = "0x620D350", VA = "0x18620EB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct IFAHFNDHFMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public LCNEEILCHGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x621AE80", Offset = "0x6219680", VA = "0x18621AE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x621B910", Offset = "0x621A110", VA = "0x18621B910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct BNHKJOIPDEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public LCNEEILCHGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private MPCHBJGCNBP <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6212C80", Offset = "0x6211480", VA = "0x186212C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6213100", Offset = "0x6211900", VA = "0x186213100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct ANHLDOMNMHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder<Matchmaking.OIABHCOJCFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public MFNEBLAPOMP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public LCNEEILCHGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private TaskAwaiter<Matchmaking.OIABHCOJCFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x620F3A0", Offset = "0x620DBA0", VA = "0x18620F3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x620F880", Offset = "0x620E080", VA = "0x18620F880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct OAIHFBKGLAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public Matchmaking.OIABHCOJCFB serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public LCNEEILCHGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public NENHMEPEJHH joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<IEOFFFPHCAE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6225A70", Offset = "0x6224270", VA = "0x186225A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x62261A0", Offset = "0x62249A0", VA = "0x1862261A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class PGHBMOMAIAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public MFNEBLAPOMP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public PGHBMOMAIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6227440", Offset = "0x6225C40", VA = "0x186227440")]
		internal object DHADCNGGDHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6227340", Offset = "0x6225B40", VA = "0x186227340")]
		internal string DENJOMLOFJG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct BDABKAJIOLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public MFNEBLAPOMP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public LCNEEILCHGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private PGHBMOMAIAF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6210FB0", Offset = "0x620F7B0", VA = "0x186210FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6211BE0", Offset = "0x62103E0", VA = "0x186211BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct KANONLKGDHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public LCNEEILCHGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public NENHMEPEJHH joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public IDDPDCCBLKC initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MFNEBLAPOMP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public CIFBALEPACJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x621E280", Offset = "0x621CA80", VA = "0x18621E280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x621EB90", Offset = "0x621D390", VA = "0x18621EB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct JBOHGNMMDOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public LCNEEILCHGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x621C860", Offset = "0x621B060", VA = "0x18621C860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x621DF00", Offset = "0x621C700", VA = "0x18621DF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct KKFEBADKNBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public LCNEEILCHGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private TaskAwaiter<JJAMOFDJDHP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x621F220", Offset = "0x621DA20", VA = "0x18621F220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x621FA50", Offset = "0x621E250", VA = "0x18621FA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class DCPNIHJLNGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public MFNEBLAPOMP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public DCPNIHJLNGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6215A60", Offset = "0x6214260", VA = "0x186215A60")]
		internal object JAMLKNCKDOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class JIKGBCCGOME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public JIKGBCCGOME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x621E1E0", Offset = "0x621C9E0", VA = "0x18621E1E0")]
		internal void LIPBHBIOCEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class IHHCPAJBNAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public MFNEBLAPOMP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public IHHCPAJBNAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x621B970", Offset = "0x621A170", VA = "0x18621B970")]
		internal object CHLPFIEBJFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class GJINJOCOGCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public MFNEBLAPOMP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public GJINJOCOGCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6218240", Offset = "0x6216A40", VA = "0x186218240")]
		internal string JJHFPHAHDFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly PFECAMNMOCE HENDLNMDDMM;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly PFECAMNMOCE DKOLOKMPHKK;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly PFECAMNMOCE CLDNNEEDECB;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly string LBJDFMAPKFM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly string GEDLADNIAAO;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string HPOIIGFMLBI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static readonly Guid MLDOCANDGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private AHLBCEHGINI CDNPIEBPINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private EKCOKNMBGKP LLBLOLECDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private FEHJFMFNJLD EFJCCGHENLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NGMOAIDHLMP PEPBPPBDPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private CADPBBGPEGA MLAEHMKMMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private HDNNGOECGBI KCJKCNNEHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private JEAMLGPKGGG CDJEKMIHKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private PBLOGGEMBJD ICLCAFBEEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private MOHLDHBNJEI CKGPKLAMPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private IDisposable KNAEJDGMGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly MICACFBJMJM ECNHKJFMHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly MICACFBJMJM HECMKPIMGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private HAMBCBOKEBL BGEAFLLMLBD;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public TaskStatus DIHMEDCEKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x954C50", Offset = "0x953450", VA = "0x180954C50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x99D5F0", Offset = "0x99BDF0", VA = "0x18099D5F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private OPPEAOPALJL EACCPEEKEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6222520", Offset = "0x6220D20", VA = "0x186222520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6223000", Offset = "0x6221800", VA = "0x186223000", Slot = "6")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6220DD0", Offset = "0x621F5D0", VA = "0x186220DD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6222B80", Offset = "0x6221380", VA = "0x186222B80", Slot = "5")]
	[AsyncStateMachine(typeof(BPHENMIOMPN))]
	public Task MJADPFFANNN(MFNEBLAPOMP GLFNGDOHNJH, FNDAMPCNFND GBFJAJLHCCO, CancellationToken MHKFOCFJDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6221610", Offset = "0x621FE10", VA = "0x186221610")]
	[AsyncStateMachine(typeof(GKAEJPNPEGP))]
	private Task IDNKHFEALKE(MFNEBLAPOMP GLFNGDOHNJH, FNDAMPCNFND GBFJAJLHCCO, CancellationToken MHKFOCFJDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x62203F0", Offset = "0x621EBF0", VA = "0x1862203F0")]
	private static void BFIKLCOOPNC(PBLOGGEMBJD ICLCAFBEEAK, MFNEBLAPOMP GLFNGDOHNJH, Exception DCJGKNPOAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6221A00", Offset = "0x6220200", VA = "0x186221A00")]
	private static void JABHBGGJGDO(GPACDPBJIOP JGNOACCBPMJ, Exception DCJGKNPOAGA, [Optional] List<int> NGEJFHBPKNF, int PNOCLHEKBEH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6222570", Offset = "0x6220D70", VA = "0x186222570")]
	[AsyncStateMachine(typeof(AIHIHIJCODP))]
	private Task KIHIOHBHNEP(GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, MFNEBLAPOMP GLFNGDOHNJH, FNDAMPCNFND GBFJAJLHCCO, NENHMEPEJHH CFMDFEHJEFI, CancellationToken MHKFOCFJDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x62236F0", Offset = "0x6221EF0", VA = "0x1862236F0")]
	private void ONELPPIMKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x62218D0", Offset = "0x62200D0", VA = "0x1862218D0")]
	[AsyncStateMachine(typeof(IFAHFNDHFMF))]
	private Task INGNNAKAKJF(GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6222CC0", Offset = "0x62214C0", VA = "0x186222CC0")]
	private void MJEOFMIDIDC(MFNEBLAPOMP GLFNGDOHNJH, CancellationToken MHKFOCFJDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6220B40", Offset = "0x621F340", VA = "0x186220B40")]
	private void CNHGEGECEDL(MFNEBLAPOMP GLFNGDOHNJH, NENHMEPEJHH CFMDFEHJEFI, OperationCanceledException DNMIPEDONCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x62234C0", Offset = "0x6221CC0", VA = "0x1862234C0")]
	private void NIGOPAAOGGE(MFNEBLAPOMP GLFNGDOHNJH, NENHMEPEJHH CFMDFEHJEFI, Exception DCJGKNPOAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6222950", Offset = "0x6221150", VA = "0x186222950")]
	private void MBDKJJKHBBF(MFNEBLAPOMP GLFNGDOHNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6220D70", Offset = "0x621F570", VA = "0x186220D70")]
	private static KHIICHLPDND DMJAOFMLDGH(MFNEBLAPOMP GLFNGDOHNJH)
	{
		return default(KHIICHLPDND);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6220200", Offset = "0x621EA00", VA = "0x186220200")]
	[AsyncStateMachine(typeof(BNHKJOIPDEM))]
	private Task ADNEJJBDJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x62223E0", Offset = "0x6220BE0", VA = "0x1862223E0")]
	[AsyncStateMachine(typeof(ANHLDOMNMHD))]
	private Task<Matchmaking.OIABHCOJCFB> JNKDGMFILOB(MFNEBLAPOMP GLFNGDOHNJH, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x62238A0", Offset = "0x62220A0", VA = "0x1862238A0")]
	private static IEOFFFPHCAE PCHGMFCEALI(Matchmaking.OIABHCOJCFB HGCIMHJJJIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6222290", Offset = "0x6220A90", VA = "0x186222290")]
	[AsyncStateMachine(typeof(OAIHFBKGLAC))]
	private Task JLAJDAJLCIH(Matchmaking.OIABHCOJCFB HGCIMHJJJIO, NENHMEPEJHH CFMDFEHJEFI, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken CAEGBIBBNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6222800", Offset = "0x6221000", VA = "0x186222800")]
	[AsyncStateMachine(typeof(BDABKAJIOLO))]
	private Task LNCLADPDBKB(MFNEBLAPOMP GLFNGDOHNJH, CancellationTokenSource AOFLPMNMOPO, Task GILIHGLFPIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6221760", Offset = "0x621FF60", VA = "0x186221760")]
	[AsyncStateMachine(typeof(KANONLKGDHM))]
	private Task IHJKJIMAGKJ(IDDPDCCBLKC GOAJCBNPNNF, CIFBALEPACJ HEMKJANDKME, MFNEBLAPOMP NIHDKDNMLPE, NENHMEPEJHH FIHCONNIOHL, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken GLECMLGNMKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x62212F0", Offset = "0x621FAF0", VA = "0x1862212F0")]
	private NENHMEPEJHH GIJNPGHCPFO(NENHMEPEJHH FIHCONNIOHL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x62226D0", Offset = "0x6220ED0", VA = "0x1862226D0")]
	[AsyncStateMachine(typeof(JBOHGNMMDOG))]
	private Task LCDILLKGGDH(GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x62214F0", Offset = "0x621FCF0", VA = "0x1862214F0")]
	[AsyncStateMachine(typeof(KKFEBADKNBK))]
	private Task GNHJIHMCNEH(JIHLGMHMNNN KOIMDAJNDOD, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x62208C0", Offset = "0x621F0C0", VA = "0x1862208C0")]
	private static void CEECBAEKEMG(MFNEBLAPOMP GLFNGDOHNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6220F10", Offset = "0x621F710", VA = "0x186220F10")]
	private void EJANOEGKLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x62239B0", Offset = "0x62221B0", VA = "0x1862239B0")]
	private void PMFPPCKHFJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x62202D0", Offset = "0x621EAD0", VA = "0x1862202D0")]
	private void ANJPBPHOKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6220360", Offset = "0x621EB60", VA = "0x186220360")]
	private void BBJIIKNEHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6220E20", Offset = "0x621F620", VA = "0x186220E20")]
	private static void EFFNJOPHKDG(MFNEBLAPOMP GLFNGDOHNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x62207B0", Offset = "0x621EFB0", VA = "0x1862207B0")]
	private static CancellationTokenRegistration BIOHPEGOFEN(MFNEBLAPOMP GLFNGDOHNJH, CancellationToken CAEGBIBBNOL)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6220A40", Offset = "0x621F240", VA = "0x186220A40")]
	private static void CEJCOJLLILI(MFNEBLAPOMP GLFNGDOHNJH, Exception DCJGKNPOAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x62210E0", Offset = "0x621F8E0", VA = "0x1862210E0")]
	private void EJHPIFMGEBI(MFNEBLAPOMP GLFNGDOHNJH, Task GILIHGLFPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6223840", Offset = "0x6222040", VA = "0x186223840")]
	private static void OPCGADAFALC(Func<string> KBMLJNGIOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6223C60", Offset = "0x6222460", VA = "0x186223C60")]
	public LCNEEILCHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6221290", Offset = "0x621FA90", VA = "0x186221290")]
	[CompilerGenerated]
	internal static (int, int?) FIJILBBEGGA(KOCOMPJBIBG GDLCNBAFCBJ)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[UnityEngine.Scripting.Preserve]
internal class ACNODPGLHAA : CCAKIPMFFCB, CEMJENDAKDI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct CGMJFDMKMGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public ACNODPGLHAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public JIHLGMHMNNN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6214330", Offset = "0x6212B30", VA = "0x186214330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6214810", Offset = "0x6213010", VA = "0x186214810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class LECDHJOKLKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public ACNODPGLHAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public JIHLGMHMNNN roomData;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public LECDHJOKLKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6241390", Offset = "0x623FB90", VA = "0x186241390")]
		internal List<Task> CBEODFOJPCH(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct MKPFGIPOMAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public OEJJLMDLCGB taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x62420A0", Offset = "0x62408A0", VA = "0x1862420A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6242470", Offset = "0x6240C70", VA = "0x186242470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct BBKOKOBOPNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public ACNODPGLHAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x622AD40", Offset = "0x6229540", VA = "0x18622AD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x622B000", Offset = "0x6229800", VA = "0x18622B000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly HashSet<OEJJLMDLCGB> LFBMKOABDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private EKCOKNMBGKP LLBLOLECDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private KFMAKOMGIMC PIBBEEICMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private LPNGGIJLKAK GIMJAJMJBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private IDisposable KNAEJDGMGJG;

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6209980", Offset = "0x6208180", VA = "0x186209980", Slot = "5")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x6209470", Offset = "0x6207C70", VA = "0x186209470", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x6208DB0", Offset = "0x62075B0", VA = "0x186208DB0", Slot = "4")]
	public bool BDLLGGBPEIA(OEJJLMDLCGB PGILBIDMOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x6209840", Offset = "0x6208040", VA = "0x186209840")]
	private void KKIPDFOGDGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x6209640", Offset = "0x6207E40", VA = "0x186209640")]
	private void GFHPBKFMPNL(JIHLGMHMNNN EKBIDHDINDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x62094D0", Offset = "0x6207CD0", VA = "0x1862094D0")]
	[AsyncStateMachine(typeof(CGMJFDMKMGP))]
	private Task EGIBMBNNCNL(JIHLGMHMNNN EKBIDHDINDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6209C00", Offset = "0x6208400", VA = "0x186209C00")]
	private Func<CancellationToken, List<Task>> OEGBDNHFIHP(JIHLGMHMNNN EKBIDHDINDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6208E10", Offset = "0x6207610", VA = "0x186208E10")]
	private List<Task> CBINAFPPAJP(JIHLGMHMNNN EKBIDHDINDL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6209350", Offset = "0x6207B50", VA = "0x186209350")]
	[AsyncStateMachine(typeof(MKPFGIPOMAG))]
	private Task DJFGLLECLNM(OEJJLMDLCGB FIFOOGHPLJD, JIHLGMHMNNN KOIMDAJNDOD, CancellationToken PIPCHJCEPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6209280", Offset = "0x6207A80", VA = "0x186209280")]
	[AsyncStateMachine(typeof(BBKOKOBOPNC))]
	private Task DHAMFIBHIIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x62095C0", Offset = "0x6207DC0", VA = "0x1862095C0")]
	private void FELDDOHAJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6209CD0", Offset = "0x62084D0", VA = "0x186209CD0")]
	public ACNODPGLHAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[UnityEngine.Scripting.Preserve]
internal sealed class CKGHCHHNGGE : PFNAKLPOBFB, CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class GMBIJGAJFLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public GMBIJGAJFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x6236BA0", Offset = "0x62353A0", VA = "0x186236BA0")]
		internal object HCAFLFGKGDC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class AKGEENAPIIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public AKGEENAPIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x622A3E0", Offset = "0x6228BE0", VA = "0x18622A3E0")]
		internal object AHFANENMPNG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class JEHAAGPGPKN
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public JEHAAGPGPKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class DPNFNPBNALP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public DPNFNPBNALP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6230ED0", Offset = "0x622F6D0", VA = "0x186230ED0")]
		internal object HOMNKJJJJBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class MCCKDKFEELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MCCKDKFEELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6241F60", Offset = "0x6240760", VA = "0x186241F60")]
		internal object MFPGPLGEJHJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private readonly Dictionary<Guid, OENNPEAHAGC> AIJLCEBPLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly TimeSpan CEBLIEPFIPA;

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "9")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x622C440", Offset = "0x622AC40", VA = "0x18622C440", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x622C450", Offset = "0x622AC50", VA = "0x18622C450", Slot = "4")]
	public NOKGCPFMFJM EIGFNHEIDIC(Guid CGNOLEKHOBB)
	{
		return default(NOKGCPFMFJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x622CC40", Offset = "0x622B440", VA = "0x18622CC40", Slot = "5")]
	public bool OICBJJIPNIH(Guid CGNOLEKHOBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x622C8F0", Offset = "0x622B0F0", VA = "0x18622C8F0", Slot = "6")]
	public bool KHNCPNHOMCA(Guid CGNOLEKHOBB, Task HMJMMIJLJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x622C6F0", Offset = "0x622AEF0", VA = "0x18622C6F0", Slot = "7")]
	public bool IJMFEJLHNIO(Guid CGNOLEKHOBB, JJAMOFDJDHP EINOPIPKKIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x622C680", Offset = "0x622AE80", VA = "0x18622C680", Slot = "8")]
	public Task<(JJAMOFDJDHP, Task)> HEHMBILBILG(Guid CGNOLEKHOBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x622CE70", Offset = "0x622B670", VA = "0x18622CE70")]
	private void OOGNCFGFIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x622D0B0", Offset = "0x622B8B0", VA = "0x18622D0B0")]
	public CKGHCHHNGGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[UnityEngine.Scripting.Preserve]
internal class FPAMLIMKHFP : PCIHHEPKGLB, CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class LJLAGJEJDFG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private readonly MFNEBLAPOMP OOLBMDAJJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private readonly CancellationTokenSource OOKDIBNEDBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public readonly CancellationToken FGEHNDAGFOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private bool HPHEMBCHHPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private bool PMNGKOBCMDF;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6241680", Offset = "0x623FE80", VA = "0x186241680")]
		public LJLAGJEJDFG(MFNEBLAPOMP OOLBMDAJJLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6241530", Offset = "0x623FD30", VA = "0x186241530")]
		public void FELDDOHAJBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6241500", Offset = "0x623FD00", VA = "0x186241500", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class NNAPMHFOPAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public NDLKKEDOPDE disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public NNAPMHFOPAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6243490", Offset = "0x6241C90", VA = "0x186243490")]
		internal object NEHJNGKAMAD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct JMCEDIKJMAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public NDLKKEDOPDE disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public FPAMLIMKHFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x623BE20", Offset = "0x623A620", VA = "0x18623BE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x623C250", Offset = "0x623AA50", VA = "0x18623C250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class PKHNNCMAANP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public PKHNNCMAANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6246830", Offset = "0x6245030", VA = "0x186246830")]
		internal object OPONKANKJMM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct PJGPEICKPIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public FPAMLIMKHFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x6245640", Offset = "0x6243E40", VA = "0x186245640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x843D40", Offset = "0x842540", VA = "0x180843D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class LANNHFPGDJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public MFNEBLAPOMP newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public LANNHFPGDJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6240290", Offset = "0x623EA90", VA = "0x186240290")]
		internal object OHOCKMFPPAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6240210", Offset = "0x623EA10", VA = "0x186240210")]
		internal object FGGLNBJCCAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6240250", Offset = "0x623EA50", VA = "0x186240250")]
		internal object LLHIAJKEDDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class JEFPEDNCDDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public JEFPEDNCDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x623A640", Offset = "0x6238E40", VA = "0x18623A640")]
		internal void LOAEBNCNDCN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct KJHGLLPFCHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public MFNEBLAPOMP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public FPAMLIMKHFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public FNDAMPCNFND customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private LANNHFPGDJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private CancellationTokenRegistration <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x623F0C0", Offset = "0x623D8C0", VA = "0x18623F0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x62400D0", Offset = "0x623E8D0", VA = "0x1862400D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly HHDPCCODDDF.BJIKOLFGPBE CBBCNMGGLGK;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly MNJJCMIAPGO DOMGFIFOHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private EKCOKNMBGKP LLBLOLECDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private CADPBBGPEGA MLAEHMKMMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private NGMOAIDHLMP PEPBPPBDPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private OIODMMKFNHN NPLDMOPOFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private OFFAOEFCPMH JCDNHPPBMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private long HBOFMKJPMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private LJLAGJEJDFG NFDCILCICIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private bool BCKJPGNJCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private Task BFCEOOJJFKG;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private OPPEAOPALJL EACCPEEKEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6234060", Offset = "0x6232860", VA = "0x186234060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CBPGAHAMIBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA39CD0", Offset = "0xA384D0", VA = "0x180A39CD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6234580", Offset = "0x6232D80", VA = "0x186234580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x62340B0", Offset = "0x62328B0", VA = "0x1862340B0", Slot = "4")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x62336C0", Offset = "0x6231EC0", VA = "0x1862336C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6233BD0", Offset = "0x62323D0", VA = "0x186233BD0")]
	[AsyncStateMachine(typeof(JMCEDIKJMAM))]
	private Task HOFLHDNALEL(NDLKKEDOPDE JLKDCPMPPFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6234350", Offset = "0x6232B50", VA = "0x186234350")]
	private void MPNGNDHLFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6233EC0", Offset = "0x62326C0", VA = "0x186233EC0")]
	private void JLCOFKIPPOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x62334E0", Offset = "0x6231CE0", VA = "0x1862334E0")]
	private void BLAMCHFNKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6234510", Offset = "0x6232D10", VA = "0x186234510")]
	private bool NKDGKOPLEII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6233DF0", Offset = "0x62325F0", VA = "0x186233DF0")]
	[AsyncStateMachine(typeof(PJGPEICKPIH))]
	private void IMJCPHBNJJM(int AJEJCPPFLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6233940", Offset = "0x6232140", VA = "0x186233940")]
	private void FEAJNOOJAOM([Out] IDisposable ODKBEJEKIOH, [Out] IDisposable CKCADBHLIEH, [Out] IDisposable LOBGDBEDMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6233830", Offset = "0x6232030", VA = "0x186233830")]
	private bool FDPLODMILAP(MFNEBLAPOMP OOLBMDAJJLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6233670", Offset = "0x6231E70", VA = "0x186233670")]
	private void CGNCNMDNLBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6233CC0", Offset = "0x62324C0", VA = "0x186233CC0")]
	[AsyncStateMachine(typeof(KJHGLLPFCHO))]
	private Task IDNKHFEALKE(MFNEBLAPOMP OOLBMDAJJLO, FNDAMPCNFND GBFJAJLHCCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6234960", Offset = "0x6233160", VA = "0x186234960")]
	public FPAMLIMKHFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[UnityEngine.Scripting.Preserve]
internal sealed class IKDDHGKMCKH : IKLIOEGIHAP, CEMJENDAKDI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct FLPOOHLBKBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public AsyncTaskMethodBuilder<FGCIHKDOMIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public IKDDHGKMCKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<FGCIHKDOMIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6232890", Offset = "0x6231090", VA = "0x186232890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6232AE0", Offset = "0x62312E0", VA = "0x186232AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class EDLMILIAIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public DGGJMFLMPCO message;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public EDLMILIAIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6230F30", Offset = "0x622F730", VA = "0x186230F30")]
		internal object FBIOFJDLNIJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class MNCPNELOMLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public DGGJMFLMPCO messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MNCPNELOMLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6242530", Offset = "0x6240D30", VA = "0x186242530")]
		internal object AEALOOLNIEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class ELOMFAEHAEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public DGGJMFLMPCO request;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public ELOMFAEHAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6231090", Offset = "0x622F890", VA = "0x186231090")]
		internal object EGKBJPJALBO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct AAPINDDDBLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public DGGJMFLMPCO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public IKDDHGKMCKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<ELMHAJPGKEB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6228690", Offset = "0x6226E90", VA = "0x186228690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6228FA0", Offset = "0x62277A0", VA = "0x186228FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class CEKIMEOCFFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public DGGJMFLMPCO operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public CEKIMEOCFFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x622BFA0", Offset = "0x622A7A0", VA = "0x18622BFA0")]
		internal object GFOACDKMLLP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct OLCIDCIIIFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public DGGJMFLMPCO operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public IKDDHGKMCKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private NENHMEPEJHH <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<DGGJMFLMPCO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x6243B80", Offset = "0x6242380", VA = "0x186243B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6244730", Offset = "0x6242F30", VA = "0x186244730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct EMGHCCAMDDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AsyncTaskMethodBuilder<ELMHAJPGKEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public IKDDHGKMCKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public DGGJMFLMPCO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private PMDIBNEJKMK.BMCOFLJKLKK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private NENHMEPEJHH <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<DGGJMFLMPCO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x62310F0", Offset = "0x622F8F0", VA = "0x1862310F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x6231610", Offset = "0x622FE10", VA = "0x186231610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class EJCCEPLFNBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public ELMHAJPGKEB operation;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public EJCCEPLFNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6231010", Offset = "0x622F810", VA = "0x186231010")]
		internal object BMGCBKPJKPF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct CLBIJAOCMJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public ELMHAJPGKEB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public IKDDHGKMCKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private GJGBNJADGMM<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x622D3B0", Offset = "0x622BBB0", VA = "0x18622D3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x622DA30", Offset = "0x622C230", VA = "0x18622DA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class NPBNFJFLHHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public DGGJMFLMPCO request;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public NPBNFJFLHHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6243AC0", Offset = "0x62422C0", VA = "0x186243AC0")]
		internal object GJJLLNMHELJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class GFAIGKHCOGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public DGGJMFLMPCO request;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public GFAIGKHCOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x62349D0", Offset = "0x62331D0", VA = "0x1862349D0")]
		internal object KIEKELJCPDL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private HDNNGOECGBI KCJKCNNEHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private EENCPGGOAOF MAGIPIBNNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private KENGCGJDOLN BLGGKJEFGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private FEHJFMFNJLD EFJCCGHENLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private TaskCompletionSource<FGCIHKDOMIA> CHAJFOAKHGA;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6239B40", Offset = "0x6238340", VA = "0x186239B40", Slot = "7")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x62392B0", Offset = "0x6237AB0", VA = "0x1862392B0", Slot = "6")]
	[AsyncStateMachine(typeof(FLPOOHLBKBL))]
	public Task<FGCIHKDOMIA> ENOECJLAMMB(CancellationToken FFDGCDLGEIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6238E00", Offset = "0x6237600", VA = "0x186238E00", Slot = "4")]
	public void DFKCFMJAGDL(DGGJMFLMPCO LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6239C30", Offset = "0x6238430", VA = "0x186239C30", Slot = "5")]
	public void PBOKNMOIGBJ(DGGJMFLMPCO LCLAJKJAPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6238D00", Offset = "0x6237500", VA = "0x186238D00")]
	[AsyncStateMachine(typeof(AAPINDDDBLJ))]
	private Task COEPFMEOOKH(DGGJMFLMPCO FDOGBBKMGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x62391A0", Offset = "0x62379A0", VA = "0x1862391A0")]
	[AsyncStateMachine(typeof(OLCIDCIIIFL))]
	private Task DGNBJEBBNII(DGGJMFLMPCO CHGDKIHMDFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x6238BB0", Offset = "0x62373B0", VA = "0x186238BB0")]
	[AsyncStateMachine(typeof(EMGHCCAMDDI))]
	private Task<ELMHAJPGKEB> BJOKEAAJDLN(DGGJMFLMPCO FDOGBBKMGKO, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x62393C0", Offset = "0x6237BC0", VA = "0x1862393C0")]
	private NENHMEPEJHH GDFNGJBPPON(DGGJMFLMPCO CAGLDJCODFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x62397F0", Offset = "0x6237FF0", VA = "0x1862397F0")]
	[AsyncStateMachine(typeof(CLBIJAOCMJH))]
	private Task HPBNLDLEGIO(ELMHAJPGKEB GOOGNEMPJCK, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6239910", Offset = "0x6238110", VA = "0x186239910")]
	private ELMHAJPGKEB KIIOMJJFOIC(DGGJMFLMPCO FDOGBBKMGKO, NENHMEPEJHH NHGCEFHBKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x240E3A0", Offset = "0x240CBA0", VA = "0x18240E3A0")]
	private T JACMIBLDFLP<T>(T IFKKLLBODIE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6239450", Offset = "0x6237C50", VA = "0x186239450")]
	private ELMHAJPGKEB HHEAOOIBOKD(DGGJMFLMPCO FDOGBBKMGKO, NENHMEPEJHH NHGCEFHBKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public IKDDHGKMCKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[UnityEngine.Scripting.Preserve]
internal sealed class KEMHMDLDBKE : EENCPGGOAOF, CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class MGCLLJJICDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MGCLLJJICDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6241FC0", Offset = "0x62407C0", VA = "0x186241FC0")]
		internal object DOPPLPDPELJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class PPPPKKJDHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public PPPPKKJDHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6246D10", Offset = "0x6245510", VA = "0x186246D10")]
		internal object OEAOMFOMMEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private FEHJFMFNJLD EFJCCGHENLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private NOAKFPBBDBH DLAJDDBMLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private IKLIOEGIHAP BIJFFDEAHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private PFNAKLPOBFB AIJLCEBPLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private MPMMPPEJPGA HHPJHGCIDDD;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x623E430", Offset = "0x623CC30", VA = "0x18623E430", Slot = "6")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x623D1E0", Offset = "0x623B9E0", VA = "0x18623D1E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x623DF10", Offset = "0x623C710", VA = "0x18623DF10", Slot = "4")]
	public NOKGCPFMFJM HNEFAJILENF(DGGJMFLMPCO HNOGGDKAEDI)
	{
		return default(NOKGCPFMFJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x623D290", Offset = "0x623BA90", VA = "0x18623D290", Slot = "5")]
	public void EDKLNDEHMCH(Guid CGNOLEKHOBB, Task HMJMMIJLJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x623E360", Offset = "0x623CB60", VA = "0x18623E360")]
	private void LALNECGEPHB(byte KNOONNJMOFL, int ANKECHDDAPB, object IEGEHNMFBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x623D940", Offset = "0x623C140", VA = "0x18623D940")]
	private void ELMEJALLIEN(PNFCJFONALL NFMBDICKDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x623E5A0", Offset = "0x623CDA0", VA = "0x18623E5A0")]
	private void MKGCJJDCDFD(PNFCJFONALL NFMBDICKDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x623E8C0", Offset = "0x623D0C0", VA = "0x18623E8C0")]
	private void OAHLLJIHMMH(PNFCJFONALL NFMBDICKDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x623D4B0", Offset = "0x623BCB0", VA = "0x18623D4B0")]
	private JJAMOFDJDHP EEJGDPMILJH(DGGJMFLMPCO CAGLDJCODFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x623D710", Offset = "0x623BF10", VA = "0x18623D710")]
	private void EICKEODDOOD(DGGJMFLMPCO CHGDKIHMDFG, JJAMOFDJDHP EINOPIPKKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x623EB10", Offset = "0x623D310", VA = "0x18623EB10")]
	private bool OHALMDFJPCP(DGGJMFLMPCO CHGDKIHMDFG, JJAMOFDJDHP EINOPIPKKIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x623EDD0", Offset = "0x623D5D0", VA = "0x18623EDD0")]
	private bool OJBBKODLCKL(DGGJMFLMPCO EHDBJEEFCMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x623CF40", Offset = "0x623B740", VA = "0x18623CF40")]
	private bool ACKJOJECAFF(byte KNOONNJMOFL, ExitGames.Client.Photon.Hashtable NFMBDICKDOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public KEMHMDLDBKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[UnityEngine.Scripting.Preserve]
internal sealed class GGGGHCGECDB : PGNPNLILCHA, CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class GJKAMHBCCPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public FGCIHKDOMIA operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public GGGGHCGECDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public DGGJMFLMPCO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public GJKAMHBCCPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6236B30", Offset = "0x6235330", VA = "0x186236B30")]
		internal object LEBODCNOCEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x6236A00", Offset = "0x6235200", VA = "0x186236A00")]
		internal object DKKMPHMAJMG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct FNPFGPOLCKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AsyncTaskMethodBuilder<JJAMOFDJDHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public GGGGHCGECDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public DGGJMFLMPCO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private TaskAwaiter<JJAMOFDJDHP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6232D90", Offset = "0x6231590", VA = "0x186232D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6233470", Offset = "0x6231C70", VA = "0x186233470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class AAGGPNACPHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public FGCIHKDOMIA operationType;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public AAGGPNACPHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x6227FC0", Offset = "0x62267C0", VA = "0x186227FC0")]
		internal object LBEPLEFPOJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class FKCFIJPPOFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public DGGJMFLMPCO request;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public FKCFIJPPOFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x6232820", Offset = "0x6231020", VA = "0x186232820")]
		internal object LPKBIAFLCDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x62327B0", Offset = "0x6230FB0", VA = "0x1862327B0")]
		internal object DHJBCADJCBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6232740", Offset = "0x6230F40", VA = "0x186232740")]
		internal object BNBCODCOKIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct IKCJBHBNACC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public AsyncTaskMethodBuilder<JJAMOFDJDHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public DGGJMFLMPCO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public GGGGHCGECDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private FKCFIJPPOFB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private NOKGCPFMFJM <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private JJAMOFDJDHP <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private TaskAwaiter<(JJAMOFDJDHP validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6238240", Offset = "0x6236A40", VA = "0x186238240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6238B40", Offset = "0x6237340", VA = "0x186238B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private FEHJFMFNJLD EFJCCGHENLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private NOAKFPBBDBH DLAJDDBMLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private EENCPGGOAOF MAGIPIBNNIL;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6236830", Offset = "0x6235030", VA = "0x186236830", Slot = "5")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x62368E0", Offset = "0x62350E0", VA = "0x1862368E0", Slot = "4")]
	[AsyncStateMachine(typeof(FNPFGPOLCKI))]
	private Task<JJAMOFDJDHP> NABGPLCACIK(DGGJMFLMPCO CAGLDJCODFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x62364E0", Offset = "0x6234CE0", VA = "0x1862364E0")]
	private bool AIKGIEGFLHK(FGCIHKDOMIA PHIFKJALFPB, [Out] JJAMOFDJDHP PGNGICAKGGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x62366F0", Offset = "0x6234EF0", VA = "0x1862366F0")]
	[AsyncStateMachine(typeof(IKCJBHBNACC))]
	private Task<JJAMOFDJDHP> GAPOLBHMAOA(DGGJMFLMPCO FDOGBBKMGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public GGGGHCGECDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class AOJKFHEKCPH : EFPHCAFJJKI, CEMJENDAKDI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct PHICLOFKKGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<IDDPDCCBLKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public MFNEBLAPOMP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public AOJKFHEKCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter<EECIHAPGBPO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6245120", Offset = "0x6243920", VA = "0x186245120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x62455D0", Offset = "0x6243DD0", VA = "0x1862455D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class CBFFELGDAEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public CBFFELGDAEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x622BD10", Offset = "0x622A510", VA = "0x18622BD10")]
		internal object MEIBBKCGBAF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct AAGJPLEABKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public AsyncTaskMethodBuilder<EECIHAPGBPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AOJKFHEKCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public MFNEBLAPOMP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private CBFFELGDAEO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter<EECIHAPGBPO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6228030", Offset = "0x6226830", VA = "0x186228030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6228620", Offset = "0x6226E20", VA = "0x186228620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class CNGJDADOLHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public CNGJDADOLHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1302680", Offset = "0x1300E80", VA = "0x181302680")]
		internal bool IJENDJNMFIA(MDHHLNLKLJD sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private NGMOAIDHLMP PEPBPPBDPDE;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static readonly (IKADIHEDPNP superRoomData, long subRoomDataSaveId) LKPFFINPHBA;

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x622A620", Offset = "0x6228E20", VA = "0x18622A620", Slot = "5")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x622A4C0", Offset = "0x6228CC0", VA = "0x18622A4C0", Slot = "4")]
	[AsyncStateMachine(typeof(PHICLOFKKGE))]
	public Task<IDDPDCCBLKC> AEELCAEKHEE(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, MFNEBLAPOMP GLFNGDOHNJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x622AB10", Offset = "0x6229310", VA = "0x18622AB10")]
	[AsyncStateMachine(typeof(AAGJPLEABKM))]
	private Task<EECIHAPGBPO> OGCNLMCKOEH(MFNEBLAPOMP GLFNGDOHNJH, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x622A690", Offset = "0x6228E90", VA = "0x18622A690")]
	private IDDPDCCBLKC NGECAHGDGPP(MFNEBLAPOMP GLFNGDOHNJH, EECIHAPGBPO KENKBOBCPCN, long FDNNACNGHGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x622A7D0", Offset = "0x6228FD0", VA = "0x18622A7D0")]
	private (IKADIHEDPNP, long) NGMPDMJPNOM(MFNEBLAPOMP GLFNGDOHNJH, EECIHAPGBPO KENKBOBCPCN, long FDNNACNGHGO)
	{
		return default((IKADIHEDPNP, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public AOJKFHEKCPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal sealed class DEMCOIAJDBC : KENGCGJDOLN, CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class OIGCBEMMOKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public DGGJMFLMPCO request;

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public OIGCBEMMOKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6243B20", Offset = "0x6242320", VA = "0x186243B20")]
		internal object JMEGCCLDMDM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct FIHMMNNOBGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public AsyncTaskMethodBuilder<DGGJMFLMPCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public DGGJMFLMPCO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public DEMCOIAJDBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public NENHMEPEJHH pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<DGGJMFLMPCO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6232090", Offset = "0x6230890", VA = "0x186232090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x62326D0", Offset = "0x6230ED0", VA = "0x1862326D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct JCBABDDLDEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<DGGJMFLMPCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public DEMCOIAJDBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public NENHMEPEJHH pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<KEMHOAACCEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6239FA0", Offset = "0x62387A0", VA = "0x186239FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x623A5D0", Offset = "0x6238DD0", VA = "0x18623A5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class MLNKDEJIJIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public DGGJMFLMPCO request;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MLNKDEJIJIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x62424D0", Offset = "0x6240CD0", VA = "0x1862424D0")]
		internal object LAPHCKLKJKB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct JPMHGNLCANP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<DGGJMFLMPCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public DGGJMFLMPCO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public DEMCOIAJDBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public NENHMEPEJHH pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private BJOHHEECOCH <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private CPDPBPNOEBK <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<KEMHOAACCEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x623C2B0", Offset = "0x623AAB0", VA = "0x18623C2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x623CED0", Offset = "0x623B6D0", VA = "0x18623CED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private FEHJFMFNJLD EFJCCGHENLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private CFLKBIBCDJP JAPDDGIPDDN;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private CMLGONECJCN BBCAHJICDOC
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x622FCD0", Offset = "0x622E4D0", VA = "0x18622FCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x622FD90", Offset = "0x622E590", VA = "0x18622FD90", Slot = "8")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x622F6C0", Offset = "0x622DEC0", VA = "0x18622F6C0", Slot = "4")]
	[AsyncStateMachine(typeof(FIHMMNNOBGG))]
	public Task<DGGJMFLMPCO> AEEHMHCMBKO(DGGJMFLMPCO FDOGBBKMGKO, NENHMEPEJHH NHGCEFHBKEP, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x622F980", Offset = "0x622E180", VA = "0x18622F980", Slot = "5")]
	[AsyncStateMachine(typeof(JCBABDDLDEA))]
	public Task<DGGJMFLMPCO> DDMKGEHFEOA(CancellationToken NCEIDHNHODH, NENHMEPEJHH NHGCEFHBKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x622FAC0", Offset = "0x622E2C0", VA = "0x18622FAC0", Slot = "6")]
	public GGBNNOAMFHH IEHIOLNFNMH(ELMHAJPGKEB JHGGCNMDALA, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x622FE20", Offset = "0x622E620", VA = "0x18622FE20", Slot = "7")]
	public GGBNNOAMFHH NJJEANANECJ(ELMHAJPGKEB JHGGCNMDALA, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x622F820", Offset = "0x622E020", VA = "0x18622F820")]
	[AsyncStateMachine(typeof(JPMHGNLCANP))]
	private Task<DGGJMFLMPCO> CBCIAOCOEKL(DGGJMFLMPCO FDOGBBKMGKO, NENHMEPEJHH NHGCEFHBKEP, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x237B2F0", Offset = "0x2379AF0", VA = "0x18237B2F0")]
	private static byte[] PPOKDCMBOLJ(DGGJMFLMPCO LACIBLEADOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public DEMCOIAJDBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[UnityEngine.Scripting.Preserve]
internal sealed class BLMOJAALDJK : NOAKFPBBDBH, CEMJENDAKDI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private LMMKFLEMMPC DJOLGIMLPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private FEHJFMFNJLD EFJCCGHENLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private HDNNGOECGBI KCJKCNNEHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private CIBNAOBGHGP EDJHDAFOKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private NGMOAIDHLMP PEPBPPBDPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private OFFAOEFCPMH JCDNHPPBMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private CCAKIPMFFCB KOJOFNIMLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private OIODMMKFNHN NPLDMOPOFGN;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private OPPEAOPALJL EACCPEEKEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x622B350", Offset = "0x6229B50", VA = "0x18622B350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private static JJAMOFDJDHP EMKIMIPGPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x622B7E0", Offset = "0x6229FE0", VA = "0x18622B7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x622B3A0", Offset = "0x6229BA0", VA = "0x18622B3A0", Slot = "6")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x622B180", Offset = "0x6229980", VA = "0x18622B180", Slot = "4")]
	public JJAMOFDJDHP FBFOPBICBPG(OGIKDEMJHKP CNAAIHEGHKN, FGCIHKDOMIA NHPBHKFKFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x622B510", Offset = "0x6229D10", VA = "0x18622B510", Slot = "5")]
	public JJAMOFDJDHP OLJFELCNEDK(OGIKDEMJHKP NMMMAHNJECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x622B2F0", Offset = "0x6229AF0", VA = "0x18622B2F0")]
	private static JJAMOFDJDHP HJDGMDDNDCJ(NDNGADCBMED PHFMGFNHLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public BLMOJAALDJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class IGBENEFPLJN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6238200", Offset = "0x6236A00", VA = "0x186238200")]
	public IGBENEFPLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x58B78E0", Offset = "0x58B60E0", VA = "0x1858B78E0")]
	public IGBENEFPLJN(string LACIBLEADOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class LBOLFANGCLI : EDPPJJGAKJA, CEMJENDAKDI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct CPKPGLLAAKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<JJAMOFDJDHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public LBOLFANGCLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public FLHCBAOPFOP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private GJGBNJADGMM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private PDPENLJKLMC <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private TaskAwaiter<JJAMOFDJDHP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x622E210", Offset = "0x622CA10", VA = "0x18622E210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x622EDD0", Offset = "0x622D5D0", VA = "0x18622EDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct GGCGDHJNHNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public LBOLFANGCLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x6235D30", Offset = "0x6234530", VA = "0x186235D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6236480", Offset = "0x6234C80", VA = "0x186236480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct AEBPPHLINIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public LBOLFANGCLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6229000", Offset = "0x6227800", VA = "0x186229000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6229510", Offset = "0x6227D10", VA = "0x186229510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct FGNPFCCDEJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public LBOLFANGCLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x62318E0", Offset = "0x62300E0", VA = "0x1862318E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6232030", Offset = "0x6230830", VA = "0x186232030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct HPKBAOMFPDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public LBOLFANGCLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x62375C0", Offset = "0x6235DC0", VA = "0x1862375C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6237760", Offset = "0x6235F60", VA = "0x186237760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct CLMCGGLNBCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public LBOLFANGCLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x622DA90", Offset = "0x622C290", VA = "0x18622DA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x622E1B0", Offset = "0x622C9B0", VA = "0x18622E1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct BNCENMLBILG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public LBOLFANGCLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x622B840", Offset = "0x622A040", VA = "0x18622B840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x622BCB0", Offset = "0x622A4B0", VA = "0x18622BCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct NJBMJBHNBJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public LBOLFANGCLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public IBBKBOPDBAK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private GJGBNJADGMM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6242EF0", Offset = "0x62416F0", VA = "0x186242EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6243430", Offset = "0x6241C30", VA = "0x186243430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private FEHJFMFNJLD EFJCCGHENLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private NGMOAIDHLMP PEPBPPBDPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private KENGCGJDOLN BLGGKJEFGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private HDNNGOECGBI KCJKCNNEHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private CCAKIPMFFCB KOJOFNIMLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private CancellationTokenSource KFAANIJLPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private Task BJKLJPKJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private TaskCompletionSource<int> HFMMNHCOINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private int HFPEENPMPGL;

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6241010", Offset = "0x623F810", VA = "0x186241010", Slot = "6")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x1B17E00", Offset = "0x1B16600", VA = "0x181B17E00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6240A10", Offset = "0x623F210", VA = "0x186240A10")]
	private void FFLLDDDEFJN(float CKBFLJBIGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x6240D00", Offset = "0x623F500", VA = "0x186240D00", Slot = "4")]
	[AsyncStateMachine(typeof(CPKPGLLAAKO))]
	public Task<JJAMOFDJDHP> IPICDDPNPKC(FLHCBAOPFOP CDBCCOOGIEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6240F20", Offset = "0x623F720", VA = "0x186240F20", Slot = "5")]
	[AsyncStateMachine(typeof(GGCGDHJNHNF))]
	public Task MFMCIOFDEFB([Optional] CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x1B17E00", Offset = "0x1B16600", VA = "0x181B17E00")]
	public void NKCHEHCEKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x62411C0", Offset = "0x623F9C0", VA = "0x1862411C0")]
	private PDPENLJKLMC PPMBOAGOCPD(FLHCBAOPFOP CDBCCOOGIEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x6240E30", Offset = "0x623F630", VA = "0x186240E30")]
	[AsyncStateMachine(typeof(AEBPPHLINIA))]
	private Task LGCNACNFKEE(JIHLGMHMNNN JJPCCHMLAMH, CancellationToken MHKFOCFJDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6240AF0", Offset = "0x623F2F0", VA = "0x186240AF0")]
	[AsyncStateMachine(typeof(FGNPFCCDEJL))]
	private Task GANHDOCFHBM(CancellationToken MHKFOCFJDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6240390", Offset = "0x623EB90", VA = "0x186240390")]
	[AsyncStateMachine(typeof(HPKBAOMFPDA))]
	private Task BHCEANOOFJI([Optional] CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6240590", Offset = "0x623ED90", VA = "0x186240590")]
	[AsyncStateMachine(typeof(CLMCGGLNBCN))]
	private Task BOFLGPBJFDE(CancellationToken MHKFOCFJDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6240680", Offset = "0x623EE80", VA = "0x186240680")]
	[AsyncStateMachine(typeof(BNCENMLBILG))]
	private Task DAKOIOBNEEK(CancellationToken KHDJDKKJAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6240780", Offset = "0x623EF80", VA = "0x186240780")]
	private Task DOKMKODKCJI(IBBKBOPDBAK KEHONEKOMDA, CancellationToken MHKFOCFJDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x6240BF0", Offset = "0x623F3F0", VA = "0x186240BF0")]
	[AsyncStateMachine(typeof(NJBMJBHNBJK))]
	private Task GMABDHJKKIO(IBBKBOPDBAK KEHONEKOMDA, CancellationToken MHKFOCFJDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x6240480", Offset = "0x623EC80", VA = "0x186240480")]
	private bool BNBIMNJFDJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public LBOLFANGCLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[UnityEngine.Scripting.Preserve]
internal class PDFNOEGCKAJ : CIBNAOBGHGP, CEMJENDAKDI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct IFFKNBOKKAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public PDFNOEGCKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private GJGBNJADGMM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x62377C0", Offset = "0x6235FC0", VA = "0x1862377C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6237D20", Offset = "0x6236520", VA = "0x186237D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private GLJEHEJFJGI FHLNBEOKANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private NOAKFPBBDBH DLAJDDBMLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private KENGCGJDOLN BLGGKJEFGGN;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6244AF0", Offset = "0x62432F0", VA = "0x186244AF0", Slot = "6")]
	public void MJKJMKCCJMD(MAJPJMCJJLM BBFJMMLGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x62448B0", Offset = "0x62430B0", VA = "0x1862448B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x62449F0", Offset = "0x62431F0", VA = "0x1862449F0", Slot = "5")]
	[AsyncStateMachine(typeof(IFFKNBOKKAJ))]
	public Task HJAFMJDLBKO(string OMHPAGCEPHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x6244850", Offset = "0x6243050", VA = "0x186244850", Slot = "4")]
	public JJAMOFDJDHP BNBIMNJFDJP(OGIKDEMJHKP CNAAIHEGHKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6244900", Offset = "0x6243100", VA = "0x186244900")]
	private PKLEFENKMAC FMBOFPGBMJH(string OMHPAGCEPHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public PDFNOEGCKAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class NIHHBFCBJNK
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x62426A0", Offset = "0x6240EA0", VA = "0x1862426A0")]
	public static void JFHMLDALGLH(MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6242DD0", Offset = "0x62415D0", VA = "0x186242DD0")]
	internal static void PHLDJLLEHAN(MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6242CF0", Offset = "0x62414F0", VA = "0x186242CF0")]
	internal static void KIIHPIOJONJ(MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x62428A0", Offset = "0x62410A0", VA = "0x1862428A0")]
	internal static void KIEBKDBKELG(MPCHBJGCNBP DJDFFLPPHHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal class DDPHDGPJJOE : HDOHFFJKLGB<DGGJMFLMPCO>
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class PHCAMBHCEIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public DGGJMFLMPCO message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public PHCAMBHCEIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6244DD0", Offset = "0x62435D0", VA = "0x186244DD0")]
		internal object MINDONJMOJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly DDPHDGPJJOE LNAOMADBHGP;

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x622F440", Offset = "0x622DC40", VA = "0x18622F440")]
	public ExitGames.Client.Photon.Hashtable NDMEHJLGNHG(DGGJMFLMPCO LACIBLEADOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x622EE40", Offset = "0x622D640", VA = "0x18622EE40", Slot = "5")]
	protected override void AGMACMFEBHM(DGGJMFLMPCO LACIBLEADOC, IDictionary<object, object> KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x622EF70", Offset = "0x622D770", VA = "0x18622EF70", Slot = "6")]
	public override DGGJMFLMPCO GHFHHMFPNJI(IDictionary<object, object> KOIMDAJNDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x622F4D0", Offset = "0x622DCD0", VA = "0x18622F4D0")]
	private static void OPCGADAFALC(string LBDPDIKKCAH, DGGJMFLMPCO LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x622F680", Offset = "0x622DE80", VA = "0x18622F680")]
	public DDPHDGPJJOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x622F1A0", Offset = "0x622D9A0", VA = "0x18622F1A0")]
	[CompilerGenerated]
	internal static string HJAAAJMLCDD(IDDPDCCBLKC AJPCNFDACDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class IFKNODBGHEL
{
	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public static JJAMOFDJDHP EMKIMIPGPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x622B7E0", Offset = "0x6229FE0", VA = "0x18622B7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x62381E0", Offset = "0x62369E0", VA = "0x1862381E0")]
	public static bool JKLFPFKOGPN(this JJAMOFDJDHP EINOPIPKKIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x622B2F0", Offset = "0x6229AF0", VA = "0x18622B2F0")]
	public static JJAMOFDJDHP HJDGMDDNDCJ(NDNGADCBMED POHIDANHEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6237FE0", Offset = "0x62367E0", VA = "0x186237FE0")]
	public static JJAMOFDJDHP FDIPHFLDEDL(IEnumerable<JJAMOFDJDHP> BJODLOLFBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6237D80", Offset = "0x6236580", VA = "0x186237D80")]
	public static string ABDEHAHDNGC(this JJAMOFDJDHP PGNGICAKGGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class CFOLALGJNGK : EHAADLPADGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public delegate JJAMOFDJDHP CCACBAFJIHD([NotNull] OGIKDEMJHKP DDOJLNBLHAH);

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class COGCOBPGJJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public OGIKDEMJHKP photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public COGCOBPGJJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5AB96B0", Offset = "0x5AB7EB0", VA = "0x185AB96B0")]
		internal JJAMOFDJDHP MKGNJCPMFIA(CCACBAFJIHD v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	protected readonly HashSet<CCACBAFJIHD> DMOJFGLOOJA;

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x622C350", Offset = "0x622AB50", VA = "0x18622C350", Slot = "4")]
	public void GNAEJHAMCEE(CCACBAFJIHD JEOGDBBAHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x622C2F0", Offset = "0x622AAF0", VA = "0x18622C2F0", Slot = "5")]
	public void FIHGBCPDECL(CCACBAFJIHD JEOGDBBAHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x622C000", Offset = "0x622A800", VA = "0x18622C000", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x622C050", Offset = "0x622A850", VA = "0x18622C050")]
	protected JJAMOFDJDHP EAKFDIIIAPN(OGIKDEMJHKP NMMMAHNJECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x622C3B0", Offset = "0x622ABB0", VA = "0x18622C3B0")]
	protected CFOLALGJNGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class BHLLBFDFPFG : CFOLALGJNGK, LMMKFLEMMPC, EHAADLPADGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class OPGOHAPNAJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public JJAMOFDJDHP result;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public OPGOHAPNAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x6244790", Offset = "0x6242F90", VA = "0x186244790")]
		internal object PAODJBDHKEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x622B170", Offset = "0x6229970", VA = "0x18622B170")]
	[UnityEngine.Scripting.Preserve]
	public BHLLBFDFPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x622B060", Offset = "0x6229860", VA = "0x18622B060", Slot = "8")]
	public JJAMOFDJDHP GMIPJKCNAPE(OGIKDEMJHKP NMMMAHNJECD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class NCFOKEHBMMB : CFOLALGJNGK, GLJEHEJFJGI, EHAADLPADGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class PAOCLOGNDHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public JJAMOFDJDHP result;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public PAOCLOGNDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x62447F0", Offset = "0x6242FF0", VA = "0x1862447F0")]
		internal object CDKGNENBLAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x622B170", Offset = "0x6229970", VA = "0x18622B170")]
	[UnityEngine.Scripting.Preserve]
	public NCFOKEHBMMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6242590", Offset = "0x6240D90", VA = "0x186242590", Slot = "8")]
	public JJAMOFDJDHP BNBIMNJFDJP(OGIKDEMJHKP INJFADHECIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal static class FBNKOEPIDHA
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class ALLAONOECPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public GJGBNJADGMM<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public ALLAONOECPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x622A440", Offset = "0x6228C40", VA = "0x18622A440")]
		internal object ODCMFHODGMP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6231740", Offset = "0x622FF40", VA = "0x186231740")]
	public static GJGBNJADGMM<string> DEHOKAFOIPC(PFECAMNMOCE ANEILBIOBIP, [Optional] string BEFGAIODLPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6231680", Offset = "0x622FE80", VA = "0x186231680")]
	public static void CIEDDIPFPHC(GJGBNJADGMM<string> HCIPJNOFOCL, PFECAMNMOCE ANEILBIOBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6231820", Offset = "0x6230020", VA = "0x186231820")]
	public static string KBIJFAFEPDE(DGGJMFLMPCO CAGLDJCODFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal static class LFPKHKCHGGP
{
	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x62414E0", Offset = "0x623FCE0", VA = "0x1862414E0")]
	public static void JAMIOGMJOPN(this FEHJFMFNJLD EFJCCGHENLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x62414F0", Offset = "0x623FCF0", VA = "0x1862414F0")]
	public static void LKKGLOIBODD(this FEHJFMFNJLD EFJCCGHENLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x62413C0", Offset = "0x623FBC0", VA = "0x1862413C0")]
	private static void GNGIPMKNFNB(this FEHJFMFNJLD EFJCCGHENLP, bool CDEFHPFFPNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class LJMKNMCLAPE : AADGEKIMFMI, DLBFKHCIPPN, OFIPPLFNAEJ, DBMKFFLALCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private readonly DLBFKHCIPPN PBPMJIJGIIC;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public OGIKDEMJHKP DICECHIKLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6241C50", Offset = "0x6240450", VA = "0x186241C50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int JFIBOPJMCKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6241C00", Offset = "0x6240400", VA = "0x186241C00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int JNALEFNCJEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x6241890", Offset = "0x6240090", VA = "0x186241890", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool JAIPJDBIFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int MOJCNKNOKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB70", Offset = "0x7DC370", VA = "0x1807DDB70", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event OKMNAIBCJOF.FJFBNBINGHJ NBDACNFKHHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event ABNEEAKGGAG NKPNFLBDEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x62419E0", Offset = "0x62401E0", VA = "0x1862419E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x6241A80", Offset = "0x6240280", VA = "0x186241A80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> EMCIGAOMIID
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<OGIKDEMJHKP> GMDLHNBCIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action ALDFOHHNCJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x62417F0", Offset = "0x623FFF0", VA = "0x1862417F0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x6241750", Offset = "0x623FF50", VA = "0x186241750", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xBF5420", Offset = "0xBF3C20", VA = "0x180BF5420")]
	public LJMKNMCLAPE(DLBFKHCIPPN PBPMJIJGIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x62418E0", Offset = "0x62400E0", VA = "0x1862418E0", Slot = "8")]
	public bool HECGMEJODPK(byte KNOONNJMOFL, ExitGames.Client.Photon.Hashtable HJBFBCEMIAG, IEGKPBKKIBG LBHNCOBHHAA, SendOptions CIPBKAEKPGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6241B20", Offset = "0x6240320", VA = "0x186241B20", Slot = "16")]
	public OGIKDEMJHKP OCLPEGJCHAF(int BNIMHBPGHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "19")]
	public void CEIAKMHPGAB(object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "20")]
	public void OANNLIPJJMJ(object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "21")]
	public void HDGDKPBLEDN(object PIPCHJCEPPJ, bool BDKPNCADKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6241990", Offset = "0x6240190", VA = "0x186241990", Slot = "22")]
	public IDisposable IHJAHNOBICD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "23")]
	private bool BMPPOIJEFGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "24")]
	public void FFBCHKOEOMH(StringBuilder NNPFGGEOJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6241730", Offset = "0x623FF30", VA = "0x186241730", Slot = "25")]
	public bool BOIIMHLMOEN(bool IBHGEFDLAIL, [Out] string OBDAEGBLILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC70", Offset = "0xAAE470", VA = "0x180AAFC70", Slot = "28")]
	public void CIPCNJBMAFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal struct PNFCJFONALL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private readonly IDictionary<object, object> NFMBDICKDOG;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8C0", Offset = "0x7EC0C0", VA = "0x1807ED8C0")]
	public PNFCJFONALL(IDictionary<object, object> NFMBDICKDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6246A40", Offset = "0x6245240", VA = "0x186246A40")]
	public bool KENIAHCAOPF([Out] DGGJMFLMPCO LACIBLEADOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x62468A0", Offset = "0x62450A0", VA = "0x1862468A0")]
	public Guid DKODANCIHIB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6246AF0", Offset = "0x62452F0", VA = "0x186246AF0")]
	public JJAMOFDJDHP NJGIJFJDAIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6246950", Offset = "0x6245150", VA = "0x186246950")]
	public static ExitGames.Client.Photon.Hashtable GFPEABNIECK(DGGJMFLMPCO LACIBLEADOC, JJAMOFDJDHP EINOPIPKKIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class EENOFDMCCPC
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6230F90", Offset = "0x622F790", VA = "0x186230F90")]
	public static bool OFANCBMANNP(this MFNEBLAPOMP LBLFNDEJNGM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal struct LPNGGIJLKAK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct FNDDBEGCGCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public LPNGGIJLKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x6232B50", Offset = "0x6231350", VA = "0x186232B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x6232D30", Offset = "0x6231530", VA = "0x186232D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private readonly CancellationTokenSource OOKDIBNEDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private Task DGINPAIAOMP;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool NLJMBAJEDED
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x6241CF0", Offset = "0x62404F0", VA = "0x186241CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6241E30", Offset = "0x6240630", VA = "0x186241E30")]
	public LPNGGIJLKAK(CancellationToken NCEIDHNHODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6241D20", Offset = "0x6240520", VA = "0x186241D20")]
	[AsyncStateMachine(typeof(FNDDBEGCGCJ))]
	public Task LKJGCIDEADN(Func<CancellationToken, List<Task>> PKCHKALCBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6241CA0", Offset = "0x62404A0", VA = "0x186241CA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public readonly struct HMOCGKEEMJM<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct AEPBAHKLHPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AsyncTaskMethodBuilder<ENHODGJKDIF<LMHJDCGEFHK<TData>, OFFEGPLAFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public HMOCGKEEMJM<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private TaskAwaiter<ENHODGJKDIF<byte[], OFFEGPLAFGN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x359E5E0", Offset = "0x359CDE0", VA = "0x18359E5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x359FFE0", Offset = "0x359E7E0", VA = "0x18359FFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private readonly IPLHKPNIDMG<TGetDataArg, TData> CIFIMLEEDNI;

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8C0", Offset = "0x7EC0C0", VA = "0x1807ED8C0")]
	internal HMOCGKEEMJM(IPLHKPNIDMG<TGetDataArg, TData> AGOMFIAFNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x3542280", Offset = "0x3540A80", VA = "0x183542280")]
	[AsyncStateMachine(typeof(HMOCGKEEMJM<, >.AEPBAHKLHPG))]
	public Task<ENHODGJKDIF<LMHJDCGEFHK<TData>, OFFEGPLAFGN>> EBKGMNCHHPB(TGetDataArg EIMPEEDPEPM, string PICDDOAAMJC, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class JBAHLOEJBEF
{
	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x2380890", Offset = "0x237F090", VA = "0x182380890")]
	public static HMOCGKEEMJM<TGetDataArg, TData> MJLGMKKAMEE<TGetDataArg, TData>(IPLHKPNIDMG<TGetDataArg, TData> AGOMFIAFNMP)
	{
		return default(HMOCGKEEMJM<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct KOCOMPJBIBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public readonly int KPOIBBJEBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public readonly int? MMHHPMHBEGC;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x396E950", Offset = "0x396D150", VA = "0x18396E950")]
	public KOCOMPJBIBG(int NODGLOENINC, [Optional] int? HACLOADJLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6240130", Offset = "0x623E930", VA = "0x186240130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface EMOJKBCDODL<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJJEOPNODDA();

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EMOJKBCDODL<T> FGHKJDEBILE(string BDJPOBPOGJA);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EMOJKBCDODL<T> ELBAGDANJJH(JPAPIJHJDGP<T> FCKIOCBOHKG);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EMOJKBCDODL<T> CEINHMEBHMM(int GDLCNBAFCBJ);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EMOJKBCDODL<T> KFILEPLLCJI(int GDLCNBAFCBJ, OACCFOKEKAJ<T> NCOIFDANFBD);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface PBLOGGEMBJD
{
	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EMOJKBCDODL<T> EIBOJHFKFNK<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CDOGDJNPIFI MOPFOJKAPAE(Exception DCJGKNPOAGA);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KOCOMPJBIBG BODNDGNEOFL(Exception DCJGKNPOAGA);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public delegate string JPAPIJHJDGP<in T>(T DCJGKNPOAGA) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate int OACCFOKEKAJ<in T>(T DCJGKNPOAGA) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class JGEOCMFLOID : PBLOGGEMBJD
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private delegate string BIEJIJLICCJ(Exception DCJGKNPOAGA);

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate int PBPPLPAMBCH(Exception DCJGKNPOAGA);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private class LMEEGJHNLKG<T> : EMOJKBCDODL<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class MPEMAPBFDDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public MPEMAPBFDDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
			internal string LCFDCDMEJNI(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class INMLPNOABIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public JPAPIJHJDGP<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public INMLPNOABIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x3672000", Offset = "0x3670800", VA = "0x183672000")]
			internal string MJLGLGLFCMK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class MBBEPJGLJAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public OACCFOKEKAJ<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public MBBEPJGLJAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x3672000", Offset = "0x3670800", VA = "0x183672000")]
			internal int GOLHOPHNBPE(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private readonly JGEOCMFLOID ICLCAFBEEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private readonly Type JJOLHOGJHND;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x39A6110", Offset = "0x39A4910", VA = "0x1839A6110")]
		internal LMEEGJHNLKG(JGEOCMFLOID ICLCAFBEEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x39A60E0", Offset = "0x39A48E0", VA = "0x1839A60E0", Slot = "4")]
		public void MJJEOPNODDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x39A5EB0", Offset = "0x39A46B0", VA = "0x1839A5EB0", Slot = "5")]
		public EMOJKBCDODL<T> FGHKJDEBILE(string BDJPOBPOGJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x39A5DA0", Offset = "0x39A45A0", VA = "0x1839A5DA0", Slot = "6")]
		public EMOJKBCDODL<T> ELBAGDANJJH(JPAPIJHJDGP<T> FCKIOCBOHKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x39A5D60", Offset = "0x39A4560", VA = "0x1839A5D60", Slot = "7")]
		public EMOJKBCDODL<T> CEINHMEBHMM(int GDLCNBAFCBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x39A5FC0", Offset = "0x39A47C0", VA = "0x1839A5FC0", Slot = "8")]
		public EMOJKBCDODL<T> KFILEPLLCJI(int GDLCNBAFCBJ, OACCFOKEKAJ<T> NCOIFDANFBD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class KCBFDIGICFC<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private bool BJJIMJFLMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private readonly List<Type> BBIAJJNMIPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private readonly Dictionary<Type, TVal> IHKDIBHLJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private readonly Dictionary<Type, int> ILBCDPLBFBF;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public IReadOnlyList<Type> PMIHBPBKEAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x388C5C0", Offset = "0x388ADC0", VA = "0x18388C5C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x388C680", Offset = "0x388AE80", VA = "0x18388C680")]
		public KCBFDIGICFC(Dictionary<Type, int> ILBCDPLBFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x388C2E0", Offset = "0x388AAE0", VA = "0x18388C2E0")]
		public void EIGFNHEIDIC(Type EBICOEDOGKC, TVal HBAHLIBAHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x388C1C0", Offset = "0x388A9C0", VA = "0x18388C1C0")]
		public bool AEOBOIKIJEH(Type JJOLHOGJHND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x388C4C0", Offset = "0x388ACC0", VA = "0x18388C4C0")]
		public bool HFNOFAJLEEM(TVal IFKKLLBODIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x388C200", Offset = "0x388AA00", VA = "0x18388C200")]
		public TVal BCFBOGKIONB(Type BJKOKHNAAID)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x388C380", Offset = "0x388AB80", VA = "0x18388C380")]
		[CompilerGenerated]
		private int GEOLCDNAMAG(Type ECKIADKIBKI, Type CCCKHEAEKAD)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class DLLBENCIECN : IEnumerable<KOCOMPJBIBG>, IEnumerable, IEnumerator<KOCOMPJBIBG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private KOCOMPJBIBG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public JGEOCMFLOID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private IEnumerator<KOCOMPJBIBG> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private KOCOMPJBIBG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x30916E0", Offset = "0x308FEE0", VA = "0x1830916E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KOCOMPJBIBG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x6230D30", Offset = "0x622F530", VA = "0x186230D30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x866770", Offset = "0x864F70", VA = "0x180866770")]
		[DebuggerHidden]
		public DLLBENCIECN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x6230D80", Offset = "0x622F580", VA = "0x186230D80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6230770", Offset = "0x622EF70", VA = "0x186230770", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x6230720", Offset = "0x622EF20", VA = "0x186230720")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x62306D0", Offset = "0x622EED0", VA = "0x1862306D0")]
		private void ADBDFKNJMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x6230CE0", Offset = "0x622F4E0", VA = "0x186230CE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6230C20", Offset = "0x622F420", VA = "0x186230C20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KOCOMPJBIBG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6230C20", Offset = "0x622F420", VA = "0x186230C20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private static readonly KOCOMPJBIBG AJBGLILFDAN;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private static readonly Dictionary<Type, int> AAFAJHPAOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private readonly HashSet<Type> EBKGCNFOBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	private readonly KCBFDIGICFC<int> IGKONGGKGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private readonly KCBFDIGICFC<PBPPLPAMBCH> PLKKFLHADNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private readonly KCBFDIGICFC<BIEJIJLICCJ> IIDDKIPOPFG;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x623A830", Offset = "0x6239030", VA = "0x18623A830")]
	[OPPPCFMOGOO(OIAOEFLOJIJ.GameOnly)]
	private static void AJCEEBENPCL(MPCHBJGCNBP EHMBKIJNGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x623BAE0", Offset = "0x623A2E0", VA = "0x18623BAE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public JGEOCMFLOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2424270", Offset = "0x2422A70", VA = "0x182424270", Slot = "4")]
	public EMOJKBCDODL<T> EIBOJHFKFNK<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x623B980", Offset = "0x623A180", VA = "0x18623B980", Slot = "5")]
	public CDOGDJNPIFI MOPFOJKAPAE(Exception DCJGKNPOAGA)
	{
		return default(CDOGDJNPIFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x623A8A0", Offset = "0x62390A0", VA = "0x18623A8A0", Slot = "6")]
	public KOCOMPJBIBG BODNDGNEOFL(Exception? DCJGKNPOAGA)
	{
		return default(KOCOMPJBIBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x623B8E0", Offset = "0x623A0E0", VA = "0x18623B8E0", Slot = "7")]
	[IteratorStateMachine(typeof(DLLBENCIECN))]
	public IEnumerable<KOCOMPJBIBG> KLNBPADLPAA(Exception DCJGKNPOAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x623A6E0", Offset = "0x6238EE0", VA = "0x18623A6E0", Slot = "8")]
	public string AGLFNBPCHDJ(Exception? DCJGKNPOAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x623B5D0", Offset = "0x6239DD0", VA = "0x18623B5D0")]
	private string JNAHKFGHIJN(AggregateException GNDAEOJMPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x623AAA0", Offset = "0x62392A0", VA = "0x18623AAA0")]
	private void FFMOKGAMCDL(Type JJOLHOGJHND, int GDLCNBAFCBJ, PBPPLPAMBCH? OLHHJABOMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x623AFD0", Offset = "0x62397D0", VA = "0x18623AFD0")]
	private void FLGDJMLKJGK(Type JJOLHOGJHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x623B220", Offset = "0x6239A20", VA = "0x18623B220")]
	private void INDFOBILFLO(Type JJOLHOGJHND, BIEJIJLICCJ DNGPHLEKBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x623AE50", Offset = "0x6239650", VA = "0x18623AE50")]
	private static int FIIGFJGEKHB(Type JJOLHOGJHND, Dictionary<Type, int> ILBCDPLBFBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2423EA0", Offset = "0x24226A0", VA = "0x182423EA0")]
	private static bool BPHAJILOBBG<TVal>(KCBFDIGICFC<TVal> EMKFAOJKFLD, Type JJOLHOGJHND, [Out] TVal IFKKLLBODIE) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x623B4F0", Offset = "0x6239CF0", VA = "0x18623B4F0")]
	[CompilerGenerated]
	internal static int JGGKODDFPAE(Type HMBDNEMMCLM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct CDOGDJNPIFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public readonly KOCOMPJBIBG FMBLEEBJFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public readonly string GIMKMKMHCPL;

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x622BF80", Offset = "0x622A780", VA = "0x18622BF80")]
	public CDOGDJNPIFI(string INLFEKKMHPL, KOCOMPJBIBG GDLCNBAFCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x622BEE0", Offset = "0x622A6E0", VA = "0x18622BEE0")]
	public string ACCAMJNGADB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class AHLBCEHGINI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private readonly NIHIPDEEGMN JOJKFMBOPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private string PBJLEJGOBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private long? BEOBIBOGDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private long? LEJDIELBKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private long? NBHJMPEJMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private string AFDFLLFONEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private OKPMJGIMPPJ LGKDHLHEHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private long? IBPDKFJOJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private bool HOOANKNPBOE;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public string PKPOJAMGMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public long PHEKECKPPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x622A050", Offset = "0x6228850", VA = "0x18622A050")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public long IOBHJPKKNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x6229570", Offset = "0x6227D70", VA = "0x186229570")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public long GODMNDEKBGH
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x622A300", Offset = "0x6228B00", VA = "0x18622A300")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public string NIBEJCMICDH
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x622A360", Offset = "0x6228B60", VA = "0x18622A360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public OKPMJGIMPPJ NGGKFCMDKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xED65B0", Offset = "0xED4DB0", VA = "0x180ED65B0")]
		get
		{
			return default(OKPMJGIMPPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x62295D0", Offset = "0x6227DD0", VA = "0x1862295D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public long BILBEHNLDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x6229ED0", Offset = "0x62286D0", VA = "0x186229ED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x622A3A0", Offset = "0x6228BA0", VA = "0x18622A3A0")]
	[UnityEngine.Scripting.Preserve]
	public AHLBCEHGINI([AKMGDNDIMPI(null)] NIHIPDEEGMN JOJKFMBOPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x622A0B0", Offset = "0x62288B0", VA = "0x18622A0B0")]
	private void MHPIMBCDJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x62296C0", Offset = "0x6227EC0", VA = "0x1862296C0")]
	public void HLOHDJOILPG(long EJLCNJNHKAA, long FDNNACNGHGO, [Optional] long? LKELLPJGDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x6229F30", Offset = "0x6228730", VA = "0x186229F30")]
	public void LAOBFCMLLKO(long LKELLPJGDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6229FD0", Offset = "0x62287D0", VA = "0x186229FD0")]
	public void LHPNPODGNHN(string MPHFJKEFEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6229B50", Offset = "0x6228350", VA = "0x186229B50")]
	public void IDJHHKDKJAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class GGBNNOAMFHH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct NNOEADDIKJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public AsyncTaskMethodBuilder<DGGJMFLMPCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public DGGJMFLMPCO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public GGBNNOAMFHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<CMLGONECJCN.NALPBIKMEFA<DGGJMFLMPCO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6243520", Offset = "0x6241D20", VA = "0x186243520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x6243A50", Offset = "0x6242250", VA = "0x186243A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct KBMFGDBKKMO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class PPNGNBDLCBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public DGGJMFLMPCO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public PPNGNBDLCBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x6246C30", Offset = "0x6245430", VA = "0x186246C30")]
		internal DGGJMFLMPCO IGHPMPFHPLD(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct DJJDEMDJCDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public AsyncTaskMethodBuilder<CMLGONECJCN.NALPBIKMEFA<DGGJMFLMPCO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public DGGJMFLMPCO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public GGBNNOAMFHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private BJOHHEECOCH <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private TaskAwaiter<CMLGONECJCN.NALPBIKMEFA<DGGJMFLMPCO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x6230050", Offset = "0x622E850", VA = "0x186230050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x6230660", Offset = "0x622EE60", VA = "0x186230660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct CFKMCJGJAMC<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public GGBNNOAMFHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x4A522C0", Offset = "0x4A50AC0", VA = "0x184A522C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE6A0", Offset = "0x2FDCEA0", VA = "0x182FDE6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct HKGDCEIGIGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public GGBNNOAMFHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x62373A0", Offset = "0x6235BA0", VA = "0x1862373A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x6237560", Offset = "0x6235D60", VA = "0x186237560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class CCKDCPIAOEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public CCKDCPIAOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x622BDC0", Offset = "0x622A5C0", VA = "0x18622BDC0")]
		internal object CAKEFBGGOOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x622BE20", Offset = "0x622A620", VA = "0x18622BE20")]
		internal bool HIHLEGDJHLB(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class LBNMELPICAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public LBNMELPICAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6240330", Offset = "0x623EB30", VA = "0x186240330")]
		internal object DHLBHKBJJEE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class KGLDMCHMKKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public KGLDMCHMKKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x623F050", Offset = "0x623D850", VA = "0x18623F050")]
		internal object DKOKGDOPHHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class MKINJLJIJDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MKINJLJIJDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x6242030", Offset = "0x6240830", VA = "0x186242030")]
		internal object CLOIOPPLKJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class CKNNCCEELNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public GGBNNOAMFHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public CKNNCCEELNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x622D170", Offset = "0x622B970", VA = "0x18622D170")]
		internal object MINDONJMOJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private static readonly Guid LCLJHOPNHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public readonly ELMHAJPGKEB DBGHKGKMCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private readonly CMLGONECJCN NJHJDJHPFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private readonly OFIPPLFNAEJ EFJCCGHENLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private readonly DBMKFFLALCA CNLGOAGIMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private bool FNFMLLFDGIK;

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6235B00", Offset = "0x6234300", VA = "0x186235B00")]
	public GGBNNOAMFHH(ELMHAJPGKEB GOOGNEMPJCK, CMLGONECJCN NJHJDJHPFIA, OFIPPLFNAEJ EFJCCGHENLP, DBMKFFLALCA CNLGOAGIMBM, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x6234C30", Offset = "0x6233430", VA = "0x186234C30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6234C30", Offset = "0x6233430", VA = "0x186234C30")]
	public void NKAIDLMKHEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6234FE0", Offset = "0x62337E0", VA = "0x186234FE0")]
	public void FBCMNINILNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6235600", Offset = "0x6233E00", VA = "0x186235600")]
	public void OBFLLGLCEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6234D50", Offset = "0x6233550", VA = "0x186234D50")]
	[AsyncStateMachine(typeof(NNOEADDIKJK))]
	internal Task<DGGJMFLMPCO> ENBCIDGKBHC(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, DGGJMFLMPCO CAGLDJCODFH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x237B2F0", Offset = "0x2379AF0", VA = "0x18237B2F0")]
	private static byte[] CGFCHDDFMNI<T>(T LACIBLEADOC) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x237B830", Offset = "0x237A030", VA = "0x18237B830")]
	private static T IAEDFNHINMH<T>(MessageParser<T> FMKOEHMHIOG, byte[] LACIBLEADOC, T MJLEEPFNLFO) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6235120", Offset = "0x6233920", VA = "0x186235120")]
	[AsyncStateMachine(typeof(DJJDEMDJCDB))]
	private Task<CMLGONECJCN.NALPBIKMEFA<DGGJMFLMPCO>> MCNDEKEIPJD(DGGJMFLMPCO CAGLDJCODFH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x237B300", Offset = "0x2379B00", VA = "0x18237B300")]
	[AsyncStateMachine(typeof(CFKMCJGJAMC<>))]
	internal Task<T> ENKPDJMCMGJ<T>(CancellationToken MHKFOCFJDAA, Func<CancellationToken, Task<T>> ELPLDDIDLPD, int GNFBMMLBKDK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6234EB0", Offset = "0x62336B0", VA = "0x186234EB0")]
	[AsyncStateMachine(typeof(HKGDCEIGIGL))]
	internal Task ENKPDJMCMGJ(CancellationToken MHKFOCFJDAA, Func<CancellationToken, Task> ELPLDDIDLPD, int GNFBMMLBKDK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x6234BB0", Offset = "0x62333B0", VA = "0x186234BB0")]
	public HDEHAPKJCEN CGPHGGJKHJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x62350A0", Offset = "0x62338A0", VA = "0x1862350A0")]
	public EDAGFHPKKGD LAHLMOHJIGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x62354B0", Offset = "0x6233CB0", VA = "0x1862354B0")]
	public PGCDNJDDLBN NAJHIPIAPBP([Optional] PFECAMNMOCE? ANEILBIOBIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x62356C0", Offset = "0x6233EC0", VA = "0x1862356C0")]
	public void OKDAMBKBKPN(Func<Guid, bool> PCOJNHMLEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6235930", Offset = "0x6234130", VA = "0x186235930")]
	public void PAODEBKEJKN(Func<Guid, bool> OKBCKMLDOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6234A30", Offset = "0x6233230", VA = "0x186234A30")]
	public Guid AEIHJCOOFKC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x62353A0", Offset = "0x6233BA0", VA = "0x1862353A0")]
	public void MGDACGENMIH(Guid MDNBJMALCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6235260", Offset = "0x6233A60", VA = "0x186235260")]
	public void MEIJLJHDNKK(DGGJMFLMPCO EEKDDENNPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6235820", Offset = "0x6234020", VA = "0x186235820")]
	public void OPCGADAFALC(string BKMOEDBCMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x237B980", Offset = "0x237A180", VA = "0x18237B980")]
	private T JACMIBLDFLP<T>(T IFKKLLBODIE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6235A40", Offset = "0x6234240", VA = "0x186235A40")]
	public void PJOFFANBDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x237B580", Offset = "0x2379D80", VA = "0x18237B580")]
	[CompilerGenerated]
	internal static string HIDDGHEEFGJ<T>(byte[] CMDCHMPDLBJ, int EJEHEMILDGL, KBMFGDBKKMO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal sealed class HENONKDKFBG : ELMHAJPGKEB
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class IIGFGBNHOGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public IIGFGBNHOGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x62538B0", Offset = "0x62520B0", VA = "0x1862538B0")]
		internal object GCCBPAJHLKB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct BBBJPDMPOIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public HENONKDKFBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public GGBNNOAMFHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private FALBIGDBNFH <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private EDAGFHPKKGD <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x6248010", Offset = "0x6246810", VA = "0x186248010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x6248790", Offset = "0x6246F90", VA = "0x186248790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct HEFHGHHDDJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public HENONKDKFBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private bool <omIsEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private TaskAwaiter<EECIHAPGBPO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x6252D20", Offset = "0x6251520", VA = "0x186252D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x62532A0", Offset = "0x6251AA0", VA = "0x1862532A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct MLFCHOJPPJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public HENONKDKFBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<GKOKDKMFDDE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x6256F10", Offset = "0x6255710", VA = "0x186256F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x6257230", Offset = "0x6255A30", VA = "0x186257230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class MHLMJAJFKJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public FALBIGDBNFH presence;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MHLMJAJFKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x6256C40", Offset = "0x6255440", VA = "0x186256C40")]
		internal object GDGAAPDKGGH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private static readonly PFECAMNMOCE FJNHIHOCDOB;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static readonly PFECAMNMOCE HKBPABOKHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly IDDPDCCBLKC GOAJCBNPNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private readonly MFNEBLAPOMP GLNGGECJCLK;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6237210", Offset = "0x6235A10", VA = "0x186237210")]
	public HENONKDKFBG(IDDPDCCBLKC GOAJCBNPNNF, MFNEBLAPOMP GLNGGECJCLK, Guid CGNOLEKHOBB, MAJPJMCJJLM BBFJMMLGFPP, NENHMEPEJHH IJHBAIDMHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6236EE0", Offset = "0x62356E0", VA = "0x186236EE0", Slot = "7")]
	[AsyncStateMachine(typeof(BBBJPDMPOIC))]
	protected override Task KFFMDMIPGPO(GGBNNOAMFHH LBFDBPOFACL, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6236DE0", Offset = "0x62355E0", VA = "0x186236DE0")]
	[AsyncStateMachine(typeof(HEFHGHHDDJH))]
	private Task DBLFJEFFIEC(CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6237020", Offset = "0x6235820", VA = "0x186237020")]
	[AsyncStateMachine(typeof(MLFCHOJPPJD))]
	private Task<byte> MNCLFJNCNEP(CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6236C00", Offset = "0x6235400", VA = "0x186236C00")]
	private FALBIGDBNFH BIFCAMCEBEN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class PDPENLJKLMC : ELMHAJPGKEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct OMEBBFCINPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public PDPENLJKLMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public GGBNNOAMFHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private TaskAwaiter<ILCOBDLGLGL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x6259C80", Offset = "0x6258480", VA = "0x186259C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x625A650", Offset = "0x6258E50", VA = "0x18625A650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private readonly int MHNMOHNLBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private readonly FLHCBAOPFOP HHLLBPMFFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public readonly long OOMMMCPBIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public readonly long JCKNDDNEGHF;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public ILCOBDLGLGL INFPBIPHFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x76F310", Offset = "0x76DB10", VA = "0x18076F310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x76F2E0", Offset = "0x76DAE0", VA = "0x18076F2E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x625A7D0", Offset = "0x6258FD0", VA = "0x18625A7D0")]
	public PDPENLJKLMC(Guid CGNOLEKHOBB, MAJPJMCJJLM BBFJMMLGFPP, NENHMEPEJHH IJHBAIDMHHF, int MHNMOHNLBBL, FLHCBAOPFOP HHLLBPMFFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x625A6B0", Offset = "0x6258EB0", VA = "0x18625A6B0", Slot = "7")]
	[AsyncStateMachine(typeof(OMEBBFCINPA))]
	protected override Task KFFMDMIPGPO(GGBNNOAMFHH LBFDBPOFACL, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal abstract class KALGEHFCCKF : ELMHAJPGKEB
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class JBAHJCKBABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public KALGEHFCCKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public CKACELKMDCF playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public JBAHJCKBABC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x6253EA0", Offset = "0x62526A0", VA = "0x186253EA0")]
		internal Task NGOPHBDJHKG(GJGBNJADGMM<string>.NJLLNAPFMFK postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x6253E10", Offset = "0x6252610", VA = "0x186253E10")]
		internal object CJOEBKLKELD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct BBDICACNJCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public KALGEHFCCKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public GGBNNOAMFHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private JBAHJCKBABC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x62487F0", Offset = "0x6246FF0", VA = "0x1862487F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x6248FB0", Offset = "0x62477B0", VA = "0x186248FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct EIFHIBKKCNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public CKACELKMDCF playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public KALGEHFCCKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x624F7E0", Offset = "0x624DFE0", VA = "0x18624F7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x624FD70", Offset = "0x624E570", VA = "0x18624FD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6255340", Offset = "0x6253B40", VA = "0x186255340")]
	public KALGEHFCCKF(Guid CGNOLEKHOBB, MAJPJMCJJLM BBFJMMLGFPP, NENHMEPEJHH IJHBAIDMHHF, string KKLNCNDPMHO, FBBDFPONJFN PHIFKJALFPB, bool FMOPHIACLNG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6255200", Offset = "0x6253A00", VA = "0x186255200", Slot = "7")]
	[AsyncStateMachine(typeof(BBDICACNJCA))]
	protected override Task KFFMDMIPGPO(GGBNNOAMFHH LBFDBPOFACL, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task AIGFKLOBMHG(GGBNNOAMFHH LBFDBPOFACL, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x62550C0", Offset = "0x62538C0", VA = "0x1862550C0")]
	[AsyncStateMachine(typeof(EIFHIBKKCNP))]
	private Task GMBPEAGBOMF(IDisposable KHLADEDGDNE, CKACELKMDCF LKFJCHCGEKA, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class DIDGEFCBEOH : ELMHAJPGKEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct DHENLLPLOBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public DIDGEFCBEOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public GGBNNOAMFHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private TaskAwaiter<GDEGEKAIEIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x624C7F0", Offset = "0x624AFF0", VA = "0x18624C7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x624CD60", Offset = "0x624B560", VA = "0x18624CD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly IBBKBOPDBAK KEHONEKOMDA;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x624CFC0", Offset = "0x624B7C0", VA = "0x18624CFC0")]
	public DIDGEFCBEOH(Guid CGNOLEKHOBB, MAJPJMCJJLM BBFJMMLGFPP, NENHMEPEJHH IJHBAIDMHHF, IBBKBOPDBAK KEHONEKOMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x624CDC0", Offset = "0x624B5C0", VA = "0x18624CDC0", Slot = "6")]
	protected override string DECIHBIHKJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x624CEA0", Offset = "0x624B6A0", VA = "0x18624CEA0", Slot = "7")]
	[AsyncStateMachine(typeof(DHENLLPLOBK))]
	protected override Task KFFMDMIPGPO(GGBNNOAMFHH LBFDBPOFACL, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class ELMHAJPGKEB : IDDPBALIJFA
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public delegate Task KIHGFJHLGEK(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class CCBJHMCDHEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public ELMHAJPGKEB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public CCBJHMCDHEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x624A560", Offset = "0x6248D60", VA = "0x18624A560")]
		internal Task DJFBBHIPNBB(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class MGHFHMBCNEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public CCBJHMCDHEH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MGHFHMBCNEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6256910", Offset = "0x6255110", VA = "0x186256910")]
		internal object BJFPADOKLPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x62569D0", Offset = "0x62551D0", VA = "0x1862569D0")]
		internal object GBBNOANBLAN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct CGEMPJBJBLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public ELMHAJPGKEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public Func<ELMHAJPGKEB, GJGBNJADGMM<string>.NJLLNAPFMFK, GGBNNOAMFHH> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private CCBJHMCDHEH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private GGBNNOAMFHH <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private TaskAwaiter<DGGJMFLMPCO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x624A690", Offset = "0x6248E90", VA = "0x18624A690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x624B790", Offset = "0x6249F90", VA = "0x18624B790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct DAFMIMDJPCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public ELMHAJPGKEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x624C430", Offset = "0x624AC30", VA = "0x18624C430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x624C790", Offset = "0x624AF90", VA = "0x18624C790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public readonly Guid BNMFAJPLHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public readonly ByteString HGKIAHHJILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public readonly NENHMEPEJHH KEMPCNGACMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	protected readonly string NLEIFJIEOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	private readonly MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	private readonly bool FMOPHIACLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	private readonly Queue<KIHGFJHLGEK> MFEAMNNJBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly NLICGJDEPPG PIAOEBAAMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly FBBDFPONJFN PHIFKJALFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private bool CKKDOKNAAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public OKPMJGIMPPJ LFAPKAPDBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public OKPMJGIMPPJ GGGANJLGDCP;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public MAJPJMCJJLM LOBAJGKJGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x762D40", Offset = "0x761540", VA = "0x180762D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public NGMOAIDHLMP DDNOPAPNNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x62502F0", Offset = "0x624EAF0", VA = "0x1862502F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public FIOHPHCNBAK NEHEAHGOMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x62503C0", Offset = "0x624EBC0", VA = "0x1862503C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public OPPEAOPALJL EACCPEEKEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6250340", Offset = "0x624EB40", VA = "0x186250340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event GFCOEMPEOME NADBLLBKOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x62505F0", Offset = "0x624EDF0", VA = "0x1862505F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6250180", Offset = "0x624E980", VA = "0x186250180", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x6250610", Offset = "0x624EE10", VA = "0x186250610")]
	protected ELMHAJPGKEB(Guid CGNOLEKHOBB, MAJPJMCJJLM BBFJMMLGFPP, NENHMEPEJHH IJHBAIDMHHF, string KKLNCNDPMHO, FBBDFPONJFN PHIFKJALFPB, bool FMOPHIACLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6250000", Offset = "0x624E800", VA = "0x186250000", Slot = "6")]
	protected virtual string DECIHBIHKJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x624FDD0", Offset = "0x624E5D0", VA = "0x18624FDD0")]
	public void BJCHIDJOAHB(KIHGFJHLGEK FIFOOGHPLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6250040", Offset = "0x624E840", VA = "0x186250040")]
	protected void DIINCAMPMCN(float BGAAPDHNPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x62501A0", Offset = "0x624E9A0", VA = "0x1862501A0")]
	[AsyncStateMachine(typeof(CGEMPJBJBLK))]
	public Task GFKLAMKNNLG(CancellationToken NCEIDHNHODH, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, [Optional] Func<ELMHAJPGKEB, GJGBNJADGMM<string>.NJLLNAPFMFK, GGBNNOAMFHH> HDKCKLMFIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x624FE30", Offset = "0x624E630", VA = "0x18624FE30")]
	private void CAHNCHKKJKF(bool LNBAAAMMLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6250500", Offset = "0x624ED00", VA = "0x186250500")]
	private void NKGOGNKMLIN(GGBNNOAMFHH LBFDBPOFACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task KFFMDMIPGPO(GGBNNOAMFHH LBFDBPOFACL, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6250060", Offset = "0x624E860", VA = "0x186250060")]
	[AsyncStateMachine(typeof(DAFMIMDJPCD))]
	private Task DOMDPHLDILJ(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x624FF80", Offset = "0x624E780", VA = "0x18624FF80")]
	public DGGJMFLMPCO CJEMMODKKFD(BJOHHEECOCH FMPFGPIEADF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6250410", Offset = "0x624EC10", VA = "0x186250410")]
	[CompilerGenerated]
	private Task NDIMPCFEDNN(CancellationToken KIDCMEILBJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal sealed class ACOEJPPIPAD : KALGEHFCCKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct JFIKHBPHICN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public ACOEJPPIPAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public GGBNNOAMFHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private KHIICHLPDND <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private EDAGFHPKKGD <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6253EE0", Offset = "0x62526E0", VA = "0x186253EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6254650", Offset = "0x6252E50", VA = "0x186254650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly IDDPDCCBLKC LLECONBLMME;

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x6247CB0", Offset = "0x62464B0", VA = "0x186247CB0")]
	public ACOEJPPIPAD(Guid CGNOLEKHOBB, MAJPJMCJJLM BBFJMMLGFPP, IDDPDCCBLKC LLECONBLMME, NENHMEPEJHH IJHBAIDMHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6247B60", Offset = "0x6246360", VA = "0x186247B60", Slot = "8")]
	[AsyncStateMachine(typeof(JFIKHBPHICN))]
	protected override Task AIGFKLOBMHG(GGBNNOAMFHH LBFDBPOFACL, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal class PKLEFENKMAC : ELMHAJPGKEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct LKFLPBMHLKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public PKLEFENKMAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public GGBNNOAMFHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private TaskAwaiter<GDEGEKAIEIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6256500", Offset = "0x6254D00", VA = "0x186256500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x62568B0", Offset = "0x62550B0", VA = "0x1862568B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private readonly string NMLIEDFGFAP;

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x625CA80", Offset = "0x625B280", VA = "0x18625CA80")]
	public PKLEFENKMAC(Guid CGNOLEKHOBB, MAJPJMCJJLM BBFJMMLGFPP, NENHMEPEJHH IJHBAIDMHHF, string NMLIEDFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x625C970", Offset = "0x625B170", VA = "0x18625C970", Slot = "7")]
	[AsyncStateMachine(typeof(LKFLPBMHLKJ))]
	protected override Task KFFMDMIPGPO(GGBNNOAMFHH LBFDBPOFACL, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class HEFAGOMEHGB : KALGEHFCCKF
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class CAPEODEFONP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public AsyncTaskMethodBuilder<DGGJMFLMPCO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public CAPEODEFONP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private TaskAwaiter<GDEGEKAIEIO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private TaskAwaiter<DGGJMFLMPCO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x6260D60", Offset = "0x625F560", VA = "0x186260D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x6261220", Offset = "0x625FA20", VA = "0x186261220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public HEFAGOMEHGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public PGCDNJDDLBN serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public GPILLMEHCKI roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public HDEHAPKJCEN uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public DPBKFADKGDF roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public CAPEODEFONP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x624A330", Offset = "0x6248B30", VA = "0x18624A330")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<DGGJMFLMPCO> MJEFNFDEDNI(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct OHNCCEKAOLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public HEFAGOMEHGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public GGBNNOAMFHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private CAPEODEFONP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private KHIICHLPDND <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private EDAGFHPKKGD <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter<DGGJMFLMPCO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x6258D80", Offset = "0x6257580", VA = "0x186258D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6259C20", Offset = "0x6258420", VA = "0x186259C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private static readonly PFECAMNMOCE FJNHIHOCDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private readonly int CAKLMGDELIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	[CanBeNull]
	private readonly MNCILMPOIGF EFBEAHBHKGB;

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6252C70", Offset = "0x6251470", VA = "0x186252C70")]
	public HEFAGOMEHGB(Guid CGNOLEKHOBB, MAJPJMCJJLM BBFJMMLGFPP, int CAKLMGDELIK, MNCILMPOIGF EFBEAHBHKGB, NENHMEPEJHH IJHBAIDMHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x62527B0", Offset = "0x6250FB0", VA = "0x1862527B0", Slot = "8")]
	[AsyncStateMachine(typeof(OHNCCEKAOLB))]
	protected override Task AIGFKLOBMHG(GGBNNOAMFHH LBFDBPOFACL, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x62528F0", Offset = "0x62510F0", VA = "0x1862528F0")]
	private void CDFIHKBKKBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x62529F0", Offset = "0x62511F0", VA = "0x1862529F0")]
	private void PHBDMGHBNEF(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, KHIICHLPDND MAHPOCEAIGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal abstract class ENELEIKFJDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public readonly ELMHAJPGKEB DBGHKGKMCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public readonly GGBNNOAMFHH PLFDOEBHOKJ;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public NGMOAIDHLMP DDNOPAPNNMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x6250770", Offset = "0x624EF70", VA = "0x186250770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public OPPEAOPALJL EACCPEEKEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x62507C0", Offset = "0x624EFC0", VA = "0x1862507C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6250870", Offset = "0x624F070", VA = "0x186250870")]
	protected ENELEIKFJDO(GGBNNOAMFHH LBFDBPOFACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x6250850", Offset = "0x624F050", VA = "0x186250850")]
	protected void OPCGADAFALC(string BKMOEDBCMNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct DIHCMLOEDDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public Dictionary<Guid, List<GMCMKCHOBAP>> ODFKMLCBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public Dictionary<Guid, List<GMCMKCHOBAP>> ONPFBEDDGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public Dictionary<Guid, List<GMCMKCHOBAP>> GAPAEBIMNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public List<Guid> HMGLMJIJNBK;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x624D060", Offset = "0x624B860", VA = "0x18624D060")]
	public static DIHCMLOEDDF BCFBOGKIONB(NGMOAIDHLMP PEPBPPBDPDE, OKPMJGIMPPJ AGGNLEOBHDE, JIHLGMHMNNN FLJGKCCEDKC)
	{
		return default(DIHCMLOEDDF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct NGMDHGDAKIJ
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0")]
	public static NGMDHGDAKIJ GFPEABNIECK()
	{
		return default(NGMDHGDAKIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal struct FOIOCCMPOML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public readonly EECIHAPGBPO MIJEACHDKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public readonly MDHHLNLKLJD DKIOOMJDCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public readonly string KOAJJCKLDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public readonly IKADIHEDPNP ODMOBPIKOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly IKADIHEDPNP LFJGLGNJDAA;

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x6251070", Offset = "0x624F870", VA = "0x186251070")]
	public FOIOCCMPOML(EECIHAPGBPO MIJEACHDKHJ, MDHHLNLKLJD DKIOOMJDCMJ, string KOAJJCKLDML, IKADIHEDPNP ODMOBPIKOMJ, IKADIHEDPNP LFJGLGNJDAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct MHINOJMKGHL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private readonly GGBNNOAMFHH LBFDBPOFACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private readonly Guid MDNBJMALCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private bool LNBAAAMMLGI;

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x6256B30", Offset = "0x6255330", VA = "0x186256B30")]
	public static MHINOJMKGHL AEIHJCOOFKC(GGBNNOAMFHH LBFDBPOFACL)
	{
		return default(MHINOJMKGHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x7DE620", Offset = "0x7DCE20", VA = "0x1807DE620")]
	public void LDKFGDLOIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6256B90", Offset = "0x6255390", VA = "0x186256B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6256BF0", Offset = "0x62553F0", VA = "0x186256BF0")]
	private MHINOJMKGHL(GGBNNOAMFHH LBFDBPOFACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6256B90", Offset = "0x6255390", VA = "0x186256B90")]
	private void MGDACGENMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x6256A90", Offset = "0x6255290", VA = "0x186256A90")]
	private Func<Guid, bool> ACFFKDNKPLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class EDAGFHPKKGD : ENELEIKFJDO, IDDPBALIJFA
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	public delegate Task<OKPMJGIMPPJ> FFJGAMHHDDC(JIHLGMHMNNN KOIMDAJNDOD, PPFIELLBHKM FHJANPOADBL, NLICGJDEPPG HEMKJANDKME, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct GMBJOLMLMDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public IDDPDCCBLKC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private MHINOJMKGHL <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter<DGGJMFLMPCO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x6251350", Offset = "0x624FB50", VA = "0x186251350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x6251A50", Offset = "0x6250250", VA = "0x186251A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct JJFINBIBPHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public AsyncTaskMethodBuilder<DGGJMFLMPCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public IDDPDCCBLKC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private TaskAwaiter<DGGJMFLMPCO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x6254C40", Offset = "0x6253440", VA = "0x186254C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x6255050", Offset = "0x6253850", VA = "0x186255050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct INIGKNJAGMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public IDDPDCCBLKC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x6253920", Offset = "0x6252120", VA = "0x186253920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x6253DB0", Offset = "0x62525B0", VA = "0x186253DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class AAGFOFCKPOC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000120")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public AsyncTaskMethodBuilder<FOIOCCMPOML> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public AAGFOFCKPOC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private FOIOCCMPOML <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			private TaskAwaiter<OKPMJGIMPPJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			private TaskAwaiter<FOIOCCMPOML> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x625F3D0", Offset = "0x625DBD0", VA = "0x18625F3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x625FB60", Offset = "0x625E360", VA = "0x18625FB60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public AsyncTaskMethodBuilder<JIHLGMHMNNN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public AAGFOFCKPOC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			private JIHLGMHMNNN <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<OKPMJGIMPPJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			private TaskAwaiter<JIHLGMHMNNN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x625FBD0", Offset = "0x625E3D0", VA = "0x18625FBD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x6260220", Offset = "0x625EA20", VA = "0x186260220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public AAGFOFCKPOC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			private TaskAwaiter<OKPMJGIMPPJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private PPFIELLBHKM <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x625E030", Offset = "0x625C830", VA = "0x18625E030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x625F370", Offset = "0x625DB70", VA = "0x18625F370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public IDDPDCCBLKC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public NLICGJDEPPG preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public NLICGJDEPPG downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public FOIOCCMPOML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public NLICGJDEPPG postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public JIHLGMHMNNN phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public IBOLNHACDLA.AKIMNHBIOAL <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public AAGFOFCKPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x62479E0", Offset = "0x62461E0", VA = "0x1862479E0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<FOIOCCMPOML> EDHBDFJKDHG(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x62477C0", Offset = "0x6245FC0", VA = "0x1862477C0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<JIHLGMHMNNN> BHKIDIGOBKJ(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x6247B20", Offset = "0x6246320", VA = "0x186247B20")]
		internal void GBMCBIJHANL(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x62478E0", Offset = "0x62460E0", VA = "0x1862478E0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task CICAPOPJDCO(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct PJDHCOIEEBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public IDDPDCCBLKC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private AAGFOFCKPOC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private TaskAwaiter<FOIOCCMPOML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private TaskAwaiter<JIHLGMHMNNN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x625BC10", Offset = "0x625A410", VA = "0x18625BC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x625C910", Offset = "0x625B110", VA = "0x18625C910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct CHMEFCCOEMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x624B7F0", Offset = "0x6249FF0", VA = "0x18624B7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x624BF30", Offset = "0x624A730", VA = "0x18624BF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct BELPEGEDGDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public NLICGJDEPPG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter<OKPMJGIMPPJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x6249010", Offset = "0x6247810", VA = "0x186249010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x6249970", Offset = "0x6248170", VA = "0x186249970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct PHNKJHDFKON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public AsyncTaskMethodBuilder<OKPMJGIMPPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public NLICGJDEPPG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private TaskAwaiter<OKPMJGIMPPJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x625AA20", Offset = "0x6259220", VA = "0x18625AA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x625BBA0", Offset = "0x625A3A0", VA = "0x18625BBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct NGBCIBNCPBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder<OKPMJGIMPPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public NLICGJDEPPG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public PPFIELLBHKM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private TaskAwaiter<OKPMJGIMPPJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x62572A0", Offset = "0x6255AA0", VA = "0x1862572A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x6258670", Offset = "0x6256E70", VA = "0x186258670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct BNCKGKMODJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public AsyncTaskMethodBuilder<OKPMJGIMPPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public OKPMJGIMPPJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public NLICGJDEPPG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public JIHLGMHMNNN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter<OKPMJGIMPPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x624A030", Offset = "0x6248830", VA = "0x18624A030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x624A2C0", Offset = "0x6248AC0", VA = "0x18624A2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class PEJLPAPHHJH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			public AsyncTaskMethodBuilder<OKPMJGIMPPJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public PEJLPAPHHJH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private TaskAwaiter<OKPMJGIMPPJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x6260290", Offset = "0x625EA90", VA = "0x186260290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0x6260900", Offset = "0x625F100", VA = "0x186260900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public NLICGJDEPPG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public FFJGAMHHDDC masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public PPFIELLBHKM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public OKPMJGIMPPJ originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public PEJLPAPHHJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x625A900", Offset = "0x6259100", VA = "0x18625A900")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<OKPMJGIMPPJ> NENCIHKILAD(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct IDAKNHNLGNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public AsyncTaskMethodBuilder<OKPMJGIMPPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public NLICGJDEPPG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public FFJGAMHHDDC masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public PPFIELLBHKM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private TaskAwaiter<OKPMJGIMPPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6253300", Offset = "0x6251B00", VA = "0x186253300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x6253840", Offset = "0x6252040", VA = "0x186253840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct JHJGHBGMBFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public NLICGJDEPPG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private OKPMJGIMPPJ <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private IEnumerator<OKPMJGIMPPJ> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private TaskAwaiter<OKPMJGIMPPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x62546B0", Offset = "0x6252EB0", VA = "0x1862546B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x6254BE0", Offset = "0x62533E0", VA = "0x186254BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct NPJLJBFFGFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x6258A10", Offset = "0x6257210", VA = "0x186258A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6258D20", Offset = "0x6257520", VA = "0x186258D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct BAOGPMHINPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public EDAGFHPKKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x6247D60", Offset = "0x6246560", VA = "0x186247D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x6247FB0", Offset = "0x62467B0", VA = "0x186247FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private readonly MICACFBJMJM FGJIFNBHKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly MICACFBJMJM AHMHKJNABBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly AHLBCEHGINI CDNPIEBPINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly HKNHFJHPCGN OJOBEEHHCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly ICOHOABDJKG FMEFDNBDPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private readonly CIFBALEPACJ LEOBEHHMHID;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private MAJPJMCJJLM LOBAJGKJGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x624DEC0", Offset = "0x624C6C0", VA = "0x18624DEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event GFCOEMPEOME NADBLLBKOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x624F3C0", Offset = "0x624DBC0", VA = "0x18624F3C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x624E3B0", Offset = "0x624CBB0", VA = "0x18624E3B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x624F530", Offset = "0x624DD30", VA = "0x18624F530")]
	public EDAGFHPKKGD(GGBNNOAMFHH LBFDBPOFACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x624E3D0", Offset = "0x624CBD0", VA = "0x18624E3D0")]
	[AsyncStateMachine(typeof(GMBJOLMLMDL))]
	public Task ELAMGEABAEA(IDDPDCCBLKC FDOGBBKMGKO, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x624F0C0", Offset = "0x624D8C0", VA = "0x18624F0C0")]
	[AsyncStateMachine(typeof(JJFINBIBPHB))]
	private Task<DGGJMFLMPCO> ODAOKLMBMOC(IDDPDCCBLKC FDOGBBKMGKO, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x624E540", Offset = "0x624CD40", VA = "0x18624E540")]
	[AsyncStateMachine(typeof(INIGKNJAGMJ))]
	private Task FCAAAOHGIMG(IDDPDCCBLKC FDOGBBKMGKO, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x624DC30", Offset = "0x624C430", VA = "0x18624DC30")]
	[AsyncStateMachine(typeof(PJDHCOIEEBH))]
	private Task AENHPAFGCEE(IDDPDCCBLKC FDOGBBKMGKO, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken LAPFCBIKOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x624F420", Offset = "0x624DC20", VA = "0x18624F420")]
	[AsyncStateMachine(typeof(CHMEFCCOEMG))]
	private Task PADPHPIPLMA(GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x624DD70", Offset = "0x624C570", VA = "0x18624DD70")]
	[AsyncStateMachine(typeof(BELPEGEDGDM))]
	private Task BBDGJCOEACC(JIHLGMHMNNN KOIMDAJNDOD, NLICGJDEPPG HEMKJANDKME, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x624DF40", Offset = "0x624C740", VA = "0x18624DF40")]
	[AsyncStateMachine(typeof(PHNKJHDFKON))]
	private Task<OKPMJGIMPPJ> BKIKHCAGOHK(JIHLGMHMNNN KOIMDAJNDOD, PPFIELLBHKM JEFAMGJLOKP, NLICGJDEPPG HEMKJANDKME, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x624F240", Offset = "0x624DA40", VA = "0x18624F240")]
	[AsyncStateMachine(typeof(NGBCIBNCPBG))]
	private Task<OKPMJGIMPPJ> OLKPCMPNFHM(JIHLGMHMNNN KOIMDAJNDOD, PPFIELLBHKM JEFAMGJLOKP, NLICGJDEPPG HEMKJANDKME, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x624E810", Offset = "0x624D010", VA = "0x18624E810")]
	[AsyncStateMachine(typeof(BNCKGKMODJM))]
	private Task<OKPMJGIMPPJ> GNPJLFHMCCE(OKPMJGIMPPJ AGGNLEOBHDE, JIHLGMHMNNN FLJGKCCEDKC, NLICGJDEPPG HEMKJANDKME, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH, bool LMLCGHOLMBC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x624ED70", Offset = "0x624D570", VA = "0x18624ED70")]
	private bool MBIKJNHIODB(JIHLGMHMNNN IOCLDMGNBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x624E1A0", Offset = "0x624C9A0", VA = "0x18624E1A0")]
	[AsyncStateMachine(typeof(IDAKNHNLGNH))]
	protected Task<OKPMJGIMPPJ> DDCLKGELMHA(JIHLGMHMNNN KOIMDAJNDOD, PPFIELLBHKM JEFAMGJLOKP, NLICGJDEPPG HEMKJANDKME, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH, FFJGAMHHDDC ACMOPJOGNEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x624E990", Offset = "0x624D190", VA = "0x18624E990")]
	[AsyncStateMachine(typeof(JHJGHBGMBFF))]
	private Task GPKIGBAOOIH(JIHLGMHMNNN KOIMDAJNDOD, NLICGJDEPPG HEMKJANDKME, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x624DEF0", Offset = "0x624C6F0", VA = "0x18624DEF0")]
	private void BJJPBEAIMHL(OKPMJGIMPPJ PBMJHMIJNIE, NLICGJDEPPG HEMKJANDKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x624F3E0", Offset = "0x624DBE0", VA = "0x18624F3E0")]
	private void ONEJKJDCPAP(OKPMJGIMPPJ ICLNHGBLFAI, [Out] OKPMJGIMPPJ LPIEEHPFPJE, [Out] OKPMJGIMPPJ HMNMFJNDEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x624E330", Offset = "0x624CB30", VA = "0x18624E330")]
	private Task<FOIOCCMPOML> DNHCADFDCBP(IDDPDCCBLKC FDOGBBKMGKO, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x624E370", Offset = "0x624CB70", VA = "0x18624E370")]
	private Task<JIHLGMHMNNN> ECCPODNBNON(FOIOCCMPOML KOIMDAJNDOD, IBOLNHACDLA.AKIMNHBIOAL FDLLKJLKJJK, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x624EE60", Offset = "0x624D660", VA = "0x18624EE60")]
	[AsyncStateMachine(typeof(NPJLJBFFGFF))]
	private Task MKFEEGDNCFO(JIHLGMHMNNN KOIMDAJNDOD, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH, bool JKFIPNOAHFA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x624EFD0", Offset = "0x624D7D0", VA = "0x18624EFD0")]
	[AsyncStateMachine(typeof(BAOGPMHINPD))]
	private Task NOFKLPDNCKK(JIHLGMHMNNN KOIMDAJNDOD, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x624EC30", Offset = "0x624D430", VA = "0x18624EC30")]
	private Task JDFLAADMMDM(JIHLGMHMNNN KOIMDAJNDOD, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x624EFB0", Offset = "0x624D7B0", VA = "0x18624EFB0")]
	private Task NKPNNCIBAJF(JIHLGMHMNNN KOIMDAJNDOD, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x624E0A0", Offset = "0x624C8A0", VA = "0x18624E0A0")]
	private Task BOEKLCDCLOB(JIHLGMHMNNN KOIMDAJNDOD, PPFIELLBHKM JEFAMGJLOKP, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x624EAE0", Offset = "0x624D2E0", VA = "0x18624EAE0")]
	private Task HMFIIPPNNGO(JIHLGMHMNNN KOIMDAJNDOD, PPFIELLBHKM JEFAMGJLOKP, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x624E0C0", Offset = "0x624C8C0", VA = "0x18624E0C0")]
	private static Task CAADCLHNBOK(CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x624E520", Offset = "0x624CD20", VA = "0x18624E520")]
	private Task EPBJMCMFCMF(JIHLGMHMNNN KOIMDAJNDOD, PPFIELLBHKM JEFAMGJLOKP, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x624E6D0", Offset = "0x624CED0", VA = "0x18624E6D0")]
	private Task GCLOFDCGBKJ(JIHLGMHMNNN KOIMDAJNDOD, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x624E680", Offset = "0x624CE80", VA = "0x18624E680")]
	private void FMJGABJFKLD(IDDPDCCBLKC FDOGBBKMGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x624F220", Offset = "0x624DA20", VA = "0x18624F220")]
	public void OJHICLICGJJ(long LKELLPJGDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void LAFBANMJBIK(EECIHAPGBPO MIJEACHDKHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal struct NOPMNDENIOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private JIHLGMHMNNN KOIMDAJNDOD;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private NGMOAIDHLMP DDNOPAPNNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x62589C0", Offset = "0x62571C0", VA = "0x1862589C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x62586E0", Offset = "0x6256EE0", VA = "0x1862586E0")]
	public static Task GFKLAMKNNLG(MAJPJMCJJLM BBFJMMLGFPP, JIHLGMHMNNN KOIMDAJNDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x62587C0", Offset = "0x6256FC0", VA = "0x1862587C0")]
	private void GFKLAMKNNLG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct PPNMLPJPOCN
{
	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x624E0C0", Offset = "0x624C8C0", VA = "0x18624E0C0")]
	public static Task GFKLAMKNNLG(CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct GBPBLHGJFID
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct KGFCFMPKFNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public GGBNNOAMFHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x6255390", Offset = "0x6253B90", VA = "0x186255390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x62558F0", Offset = "0x62540F0", VA = "0x1862558F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x62510F0", Offset = "0x624F8F0", VA = "0x1862510F0")]
	[AsyncStateMachine(typeof(KGFCFMPKFNN))]
	public static Task GFKLAMKNNLG(GGBNNOAMFHH LBFDBPOFACL, JIHLGMHMNNN KOIMDAJNDOD, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct EBNJLHOBIHN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct HCIFPJCAPEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public GGBNNOAMFHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public PPFIELLBHKM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private OKPMJGIMPPJ <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private MAJPJMCJJLM <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private NGMOAIDHLMP <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private IDisposable <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private List<(PersistenceView, EIOKPMDGBOG)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private EIOKPMDGBOG <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x6251AB0", Offset = "0x62502B0", VA = "0x186251AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x6252750", Offset = "0x6250F50", VA = "0x186252750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x624D8E0", Offset = "0x624C0E0", VA = "0x18624D8E0")]
	[AsyncStateMachine(typeof(HCIFPJCAPEG))]
	public static Task GFKLAMKNNLG(GGBNNOAMFHH LBFDBPOFACL, JIHLGMHMNNN KOIMDAJNDOD, PPFIELLBHKM JEFAMGJLOKP, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x624DA30", Offset = "0x624C230", VA = "0x18624DA30")]
	private static void NNKCGNPNPGP(PersistenceView ICAGFLPKAGF, EIOKPMDGBOG ABFGFJDAMKM, JIHLGMHMNNN KOIMDAJNDOD, OKPMJGIMPPJ AGGNLEOBHDE, bool KKPADBHBCMO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal struct CBKPDNNCBEP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct CNCBAINJHGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public MAJPJMCJJLM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x624BF90", Offset = "0x624A790", VA = "0x18624BF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x624C3D0", Offset = "0x624ABD0", VA = "0x18624C3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x624A450", Offset = "0x6248C50", VA = "0x18624A450")]
	[AsyncStateMachine(typeof(CNCBAINJHGO))]
	public static Task GFKLAMKNNLG(MAJPJMCJJLM BBFJMMLGFPP, JIHLGMHMNNN KOIMDAJNDOD, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct PMNCKELBMMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct DJPAAFJABND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public MAJPJMCJJLM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public GGBNNOAMFHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x624D670", Offset = "0x624BE70", VA = "0x18624D670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x624D880", Offset = "0x624C080", VA = "0x18624D880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class GHKOKJOFKJC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013C")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			public GHKOKJOFKJC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004E6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x6260970", Offset = "0x625F170", VA = "0x186260970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0x6260D00", Offset = "0x625F500", VA = "0x186260D00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public GHKOKJOFKJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x6251230", Offset = "0x624FA30", VA = "0x186251230")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task AHBGMLKAFDE(GJGBNJADGMM<string>.NJLLNAPFMFK timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct PPJCJMCKNAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public PMNCKELBMMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter<DGGJMFLMPCO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x625D620", Offset = "0x625BE20", VA = "0x18625D620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x625DFD0", Offset = "0x625C7D0", VA = "0x18625DFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class MJBMMAEPPFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public GLIPOGAFJFJ version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MJBMMAEPPFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x6256E30", Offset = "0x6255630", VA = "0x186256E30")]
		internal object LBEDJDJCNHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x6256D80", Offset = "0x6255580", VA = "0x186256D80")]
		internal object JKHMJPIKBDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private JIHLGMHMNNN KOIMDAJNDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private GGBNNOAMFHH LBFDBPOFACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private bool JKFIPNOAHFA;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private static readonly ByteString LKAHBPJAANM;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private NGMOAIDHLMP DDNOPAPNNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x625CE00", Offset = "0x625B600", VA = "0x18625CE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private OPPEAOPALJL EACCPEEKEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x625CE50", Offset = "0x625B650", VA = "0x18625CE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x625CB70", Offset = "0x625B370", VA = "0x18625CB70")]
	[AsyncStateMachine(typeof(DJPAAFJABND))]
	public static Task GFKLAMKNNLG(MAJPJMCJJLM BBFJMMLGFPP, JIHLGMHMNNN KOIMDAJNDOD, GGBNNOAMFHH LBFDBPOFACL, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH, bool JKFIPNOAHFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x625CCC0", Offset = "0x625B4C0", VA = "0x18625CCC0")]
	[AsyncStateMachine(typeof(PPJCJMCKNAN))]
	private Task GFKLAMKNNLG(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x625CEF0", Offset = "0x625B6F0", VA = "0x18625CEF0")]
	private void OIIEAOMIBED([NotNull] NHKJOGGKLGM MCDMEHJKDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x625CB30", Offset = "0x625B330", VA = "0x18625CB30")]
	private bool AELDBGMECHF(GLIPOGAFJFJ OJAHFIICKFC, NHKJOGGKLGM MCDMEHJKDHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct FBJIEFHAGKO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct LEOCBOFEFPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public AsyncTaskMethodBuilder<JIHLGMHMNNN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public FBJIEFHAGKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public IBOLNHACDLA.AKIMNHBIOAL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private TaskAwaiter<(ENHODGJKDIF<BKAFNPCOIPD, OFFEGPLAFGN>, ENHODGJKDIF<LMHJDCGEFHK<NHKJOGGKLGM>, OFFEGPLAFGN>, ENHODGJKDIF<LMHJDCGEFHK<GGDFBENKHAA>, OFFEGPLAFGN>, ENHODGJKDIF<LMHJDCGEFHK<ADKICODIKGA>, OFFEGPLAFGN>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6255AA0", Offset = "0x62542A0", VA = "0x186255AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6256490", Offset = "0x6254C90", VA = "0x186256490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct BNCFGLDIMFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public AsyncTaskMethodBuilder<ENHODGJKDIF<BKAFNPCOIPD, OFFEGPLAFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public FBJIEFHAGKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public IBOLNHACDLA.AKIMNHBIOAL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private TaskAwaiter<ENHODGJKDIF<BKAFNPCOIPD, OFFEGPLAFGN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x62499D0", Offset = "0x62481D0", VA = "0x1862499D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6249FC0", Offset = "0x62487C0", VA = "0x186249FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private HMOCGKEEMJM<IKADIHEDPNP, GGDFBENKHAA> HEDODNLDNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private HMOCGKEEMJM<IKADIHEDPNP, NHKJOGGKLGM> LMOLEIODANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private HMOCGKEEMJM<long, ADKICODIKGA> NFJLPPDACPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private BGCAIAOCLNF JCPJPFNFLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private EECIHAPGBPO MIJEACHDKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private MDHHLNLKLJD DKIOOMJDCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private string KOAJJCKLDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private IKADIHEDPNP ODMOBPIKOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private IKADIHEDPNP LFJGLGNJDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private long LKELLPJGDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x62508D0", Offset = "0x624F0D0", VA = "0x1862508D0")]
	public static Task<JIHLGMHMNNN> GEGDGMJPMHD(MAJPJMCJJLM BBFJMMLGFPP, [In] FOIOCCMPOML KOIMDAJNDOD, IBOLNHACDLA.AKIMNHBIOAL FDLLKJLKJJK, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x6250DF0", Offset = "0x624F5F0", VA = "0x186250DF0")]
	[AsyncStateMachine(typeof(LEOCBOFEFPN))]
	private Task<JIHLGMHMNNN> GFKLAMKNNLG(IBOLNHACDLA.AKIMNHBIOAL FDLLKJLKJJK, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x6250C40", Offset = "0x624F440", VA = "0x186250C40")]
	[AsyncStateMachine(typeof(BNCFGLDIMFD))]
	private Task<ENHODGJKDIF<BKAFNPCOIPD, OFFEGPLAFGN>> GFBPMBKMDDE(string KOAJJCKLDML, long LKELLPJGDFO, IBOLNHACDLA.AKIMNHBIOAL FDLLKJLKJJK, GJGBNJADGMM<string>.NJLLNAPFMFK CIHGIMMCKFD, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct JKDJJFMOEFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct DLALEPLBIBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder<FOIOCCMPOML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public JKDJJFMOEFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter<FOIOCCMPOML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x6269F30", Offset = "0x6268730", VA = "0x186269F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x626A330", Offset = "0x6268B30", VA = "0x18626A330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct PIGGEOFINAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public AsyncTaskMethodBuilder<FOIOCCMPOML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public JKDJJFMOEFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter<FOIOCCMPOML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x6278C20", Offset = "0x6277420", VA = "0x186278C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6279020", Offset = "0x6277820", VA = "0x186279020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class CKGHHHNDDNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public CKGHHHNDDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x1302680", Offset = "0x1300E80", VA = "0x181302680")]
		internal bool FOMBJKPHMIC(MDHHLNLKLJD sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct DILEAOHDFCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AsyncTaskMethodBuilder<FOIOCCMPOML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public IKADIHEDPNP superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public NGMOAIDHLMP callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private CKGHHHNDDNE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private EECIHAPGBPO <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private MDHHLNLKLJD <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private IKADIHEDPNP <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private IKADIHEDPNP <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private TaskAwaiter<EECIHAPGBPO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private TaskAwaiter<EGANNAAHLJC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private TaskAwaiter<GKOKDKMFDDE> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x62687E0", Offset = "0x6266FE0", VA = "0x1862687E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x6269880", Offset = "0x6268080", VA = "0x186269880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private NGMOAIDHLMP PEPBPPBDPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private AHLBCEHGINI CDNPIEBPINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private long EJLCNJNHKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private long FDNNACNGHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private long DKLLEJDNMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private string AGLMNMBOMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private IKADIHEDPNP KHBAHJADDBL;

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x6272630", Offset = "0x6270E30", VA = "0x186272630")]
	public static Task<FOIOCCMPOML> GEGDGMJPMHD(MAJPJMCJJLM BBFJMMLGFPP, IDDPDCCBLKC FDOGBBKMGKO, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x62728B0", Offset = "0x62710B0", VA = "0x1862728B0")]
	[AsyncStateMachine(typeof(DLALEPLBIBD))]
	private Task<FOIOCCMPOML> GFKLAMKNNLG(CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x62724D0", Offset = "0x6270CD0", VA = "0x1862724D0")]
	[AsyncStateMachine(typeof(PIGGEOFINAL))]
	private Task<FOIOCCMPOML> DNHCADFDCBP(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x6272340", Offset = "0x6270B40", VA = "0x186272340")]
	[AsyncStateMachine(typeof(DILEAOHDFCO))]
	private static Task<FOIOCCMPOML> DNHCADFDCBP(NGMOAIDHLMP PEPBPPBDPDE, long EJLCNJNHKAA, long FDNNACNGHGO, long DKLLEJDNMKH, string AGLMNMBOMLF, IKADIHEDPNP KHBAHJADDBL, CancellationToken NCEIDHNHODH, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x6272310", Offset = "0x6270B10", VA = "0x186272310")]
	private void CDNBNGPGAAH(EECIHAPGBPO MIJEACHDKHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct DIMKHKHJLCN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct MBBMELOKKMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public DIMKHKHJLCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x6274110", Offset = "0x6272910", VA = "0x186274110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x62746A0", Offset = "0x6272EA0", VA = "0x1862746A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private NGMOAIDHLMP PEPBPPBDPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private JIHLGMHMNNN KOIMDAJNDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private float NBLJFIPNHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private float OKHAOOIBDKG;

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x62698F0", Offset = "0x62680F0", VA = "0x1862698F0")]
	public static Task BMEPNFGAANE(MAJPJMCJJLM BBFJMMLGFPP, JIHLGMHMNNN KOIMDAJNDOD, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x6269CB0", Offset = "0x62684B0", VA = "0x186269CB0")]
	[AsyncStateMachine(typeof(MBBMELOKKMN))]
	public Task GFKLAMKNNLG(CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x6269B70", Offset = "0x6268370", VA = "0x186269B70")]
	private static void DGOKBGODKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x6269DD0", Offset = "0x62685D0", VA = "0x186269DD0")]
	private void IBECDMKOEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x6269AB0", Offset = "0x62682B0", VA = "0x186269AB0")]
	private static float DANPICJJAAF(NGMOAIDHLMP PEPBPPBDPDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6269A90", Offset = "0x6268290", VA = "0x186269A90")]
	private static float CPKHJAIIEDJ()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct BKNLOFGMHKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct CEJHCGNJIJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public GGBNNOAMFHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private ELMHAJPGKEB <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private MAJPJMCJJLM <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private DCECEOCNFPJ.FDLNFCHEIBN <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private TaskAwaiter<DGGJMFLMPCO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x6264C90", Offset = "0x6263490", VA = "0x186264C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x6265680", Offset = "0x6263E80", VA = "0x186265680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct MMPBDOJGEEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x6274820", Offset = "0x6273020", VA = "0x186274820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x6274B50", Offset = "0x6273350", VA = "0x186274B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x62643C0", Offset = "0x6262BC0", VA = "0x1862643C0")]
	[AsyncStateMachine(typeof(CEJHCGNJIJE))]
	public static Task GFKLAMKNNLG(GGBNNOAMFHH LBFDBPOFACL, JIHLGMHMNNN KOIMDAJNDOD, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x6264350", Offset = "0x6262B50", VA = "0x186264350")]
	private static Task<DGGJMFLMPCO> FBKGJAHKNDO(GGBNNOAMFHH LBFDBPOFACL, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x6264500", Offset = "0x6262D00", VA = "0x186264500")]
	[AsyncStateMachine(typeof(MMPBDOJGEEI))]
	private static Task LBBAAFLEJKA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal struct NCGIDEBHHDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct IFFDIGPEFAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public NCGIDEBHHDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x626FF30", Offset = "0x626E730", VA = "0x18626FF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x62705E0", Offset = "0x626EDE0", VA = "0x1862705E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class IOJEPJHMIKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public IOJEPJHMIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6271460", Offset = "0x626FC60", VA = "0x186271460")]
		internal object KIGMKADODLL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct ELFGFBJBLIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public NCGIDEBHHDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private AIKJJIACJBJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x626A410", Offset = "0x6268C10", VA = "0x18626A410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x626AA20", Offset = "0x6269220", VA = "0x18626AA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private bool MFPICLBANBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	private GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	private MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	private CancellationToken NCEIDHNHODH;

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x62758C0", Offset = "0x62740C0", VA = "0x1862758C0")]
	public static Task MGJPFOIPFEO(MAJPJMCJJLM BBFJMMLGFPP, bool MFPICLBANBL, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken CAEGBIBBNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x62757D0", Offset = "0x6273FD0", VA = "0x1862757D0")]
	[AsyncStateMachine(typeof(IFFDIGPEFAO))]
	private Task GFKLAMKNNLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x62756A0", Offset = "0x6273EA0", VA = "0x1862756A0")]
	[AsyncStateMachine(typeof(ELFGFBJBLIK))]
	private Task CMCMGJHNEJH(bool AGFDKGFIPBJ, string LINGGNBNLPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0")]
	private bool DGHLLAONJHD(bool MFPICLBANBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct FILKPBMEKOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct OPLMDMHDMLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public FILKPBMEKOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x6277550", Offset = "0x6275D50", VA = "0x186277550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x6277AC0", Offset = "0x62762C0", VA = "0x186277AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class ONLCBLBANIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public ONLCBLBANIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x6277470", Offset = "0x6275C70", VA = "0x186277470")]
		internal object KIGMKADODLL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct JENAOPPGIPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public FILKPBMEKOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private AIKJJIACJBJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x6271CC0", Offset = "0x62704C0", VA = "0x186271CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x62722A0", Offset = "0x6270AA0", VA = "0x1862722A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private JJOCADIPPHB MJJGOOPEBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private bool DBPAAPEOFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private JIHLGMHMNNN KOIMDAJNDOD;

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x626BEC0", Offset = "0x626A6C0", VA = "0x18626BEC0")]
	public static Task<Scene> GOGDMBMLNPC(MAJPJMCJJLM BBFJMMLGFPP, JJOCADIPPHB IFPDDGMPPDO, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x626BDA0", Offset = "0x626A5A0", VA = "0x18626BDA0")]
	[AsyncStateMachine(typeof(OPLMDMHDMLO))]
	private Task<Scene> GFKLAMKNNLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x626BC20", Offset = "0x626A420", VA = "0x18626BC20")]
	private bool CKCGKJILNGM(JIHLGMHMNNN KOIMDAJNDOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x626BF40", Offset = "0x626A740", VA = "0x18626BF40")]
	private void NOGJKEKGBOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x626BC50", Offset = "0x626A450", VA = "0x18626BC50")]
	[AsyncStateMachine(typeof(JENAOPPGIPB))]
	private Task<Scene> CMCMGJHNEJH(string LINGGNBNLPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct ICOHOABDJKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct BJECHCCOAFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public AsyncTaskMethodBuilder<OKPMJGIMPPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public ICOHOABDJKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public OKPMJGIMPPJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public JIHLGMHMNNN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<OKPMJGIMPPJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6263800", Offset = "0x6262000", VA = "0x186263800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x62642E0", Offset = "0x6262AE0", VA = "0x1862642E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct PJBCPMPBFGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder<OKPMJGIMPPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public ICOHOABDJKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public OKPMJGIMPPJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter<DGGJMFLMPCO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x6279090", Offset = "0x6277890", VA = "0x186279090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x6279370", Offset = "0x6277B70", VA = "0x186279370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private readonly GGBNNOAMFHH LBFDBPOFACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private readonly AHLBCEHGINI CDNPIEBPINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private readonly HKNHFJHPCGN OJOBEEHHCBJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private ELMHAJPGKEB DBGHKGKMCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x4C33E60", Offset = "0x4C32660", VA = "0x184C33E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x626FED0", Offset = "0x626E6D0", VA = "0x18626FED0")]
	public ICOHOABDJKG(GGBNNOAMFHH LBFDBPOFACL, AHLBCEHGINI CDNPIEBPINI, HKNHFJHPCGN OJOBEEHHCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x626FD30", Offset = "0x626E530", VA = "0x18626FD30")]
	[AsyncStateMachine(typeof(BJECHCCOAFG))]
	public Task<OKPMJGIMPPJ> NKBGNGHCAJM(OKPMJGIMPPJ BHOHNOPGFGF, JIHLGMHMNNN FLJGKCCEDKC, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH, bool LMLCGHOLMBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x626FBD0", Offset = "0x626E3D0", VA = "0x18626FBD0")]
	[AsyncStateMachine(typeof(PJBCPMPBFGF))]
	private Task<OKPMJGIMPPJ> MDCOICNMIAM(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, OKPMJGIMPPJ KAFJGNMGLLD, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x626FBA0", Offset = "0x626E3A0", VA = "0x18626FBA0")]
	private bool IOFFPLKKBLG(OKPMJGIMPPJ HCIAGDEHPLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x626FEB0", Offset = "0x626E6B0", VA = "0x18626FEB0")]
	private void OPCGADAFALC(string KBMLJNGIOLJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct IJMAFICPCCL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct GLLPGNPAOAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public ELMHAJPGKEB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public PPFIELLBHKM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private List<(PersistenceView, EIOKPMDGBOG)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private (PersistenceView, EIOKPMDGBOG) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x626C7B0", Offset = "0x626AFB0", VA = "0x18626C7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x626CDF0", Offset = "0x626B5F0", VA = "0x18626CDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x6271260", Offset = "0x626FA60", VA = "0x186271260")]
	[AsyncStateMachine(typeof(GLLPGNPAOAL))]
	public static Task GFKLAMKNNLG(ELMHAJPGKEB GOOGNEMPJCK, JIHLGMHMNNN KOIMDAJNDOD, PPFIELLBHKM JEFAMGJLOKP, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct EPGMDJGBHBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct CKMPKANFPMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public ELMHAJPGKEB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public PPFIELLBHKM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private GLIPOGAFJFJ <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private List<(PersistenceView, EIOKPMDGBOG)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private EIOKPMDGBOG <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x6266C30", Offset = "0x6265430", VA = "0x186266C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x6267490", Offset = "0x6265C90", VA = "0x186267490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x626AA80", Offset = "0x6269280", VA = "0x18626AA80")]
	[AsyncStateMachine(typeof(CKMPKANFPMD))]
	public static Task GFKLAMKNNLG(ELMHAJPGKEB GOOGNEMPJCK, JIHLGMHMNNN KOIMDAJNDOD, PPFIELLBHKM JEFAMGJLOKP, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct DCECEOCNFPJ
{
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	public struct FDLNFCHEIBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public List<KDDEBPPJICK> BJKDDLMKHGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public List<EIOKPMDGBOG> EHFOCMHFAGO;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x7F41F0", Offset = "0x7F29F0", VA = "0x1807F41F0")]
		public FDLNFCHEIBN(List<KDDEBPPJICK> BJKDDLMKHGD, List<EIOKPMDGBOG> EHFOCMHFAGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class IMAILNEMAKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public IEnumerable<KDDEBPPJICK> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public IMAILNEMAKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x62713A0", Offset = "0x626FBA0", VA = "0x1862713A0")]
		internal object AOANNOENOPN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	private MAJPJMCJJLM BBFJMMLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private JIHLGMHMNNN KOIMDAJNDOD;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private NGMOAIDHLMP DDNOPAPNNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x6267980", Offset = "0x6266180", VA = "0x186267980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x6267750", Offset = "0x6265F50", VA = "0x186267750")]
	public static FDLNFCHEIBN GFKLAMKNNLG(MAJPJMCJJLM BBFJMMLGFPP, JIHLGMHMNNN KOIMDAJNDOD)
	{
		return default(FDLNFCHEIBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x62674F0", Offset = "0x6265CF0", VA = "0x1862674F0")]
	private FDLNFCHEIBN GFKLAMKNNLG()
	{
		return default(FDLNFCHEIBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x62679D0", Offset = "0x62661D0", VA = "0x1862679D0")]
	private FDLNFCHEIBN OBIKEMBLMAL(NHKJOGGKLGM MCDMEHJKDHP, GLIPOGAFJFJ MGMDHGEHFPB)
	{
		return default(FDLNFCHEIBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x62677B0", Offset = "0x6265FB0", VA = "0x1862677B0")]
	private bool HJNNDBGEOFN(IEnumerable<KDDEBPPJICK> BJKDDLMKHGD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct HMENCCMEKCO
{
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class CIFKJEMPCPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public DCECEOCNFPJ.FDLNFCHEIBN instantiations;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public CIFKJEMPCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x6266B80", Offset = "0x6265380", VA = "0x186266B80")]
		internal object AHBGMLKAFDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class OPIAINFOPHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public OPIAINFOPHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x62774C0", Offset = "0x6275CC0", VA = "0x1862774C0")]
		internal object DJFBBHIPNBB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x626F5F0", Offset = "0x626DDF0", VA = "0x18626F5F0")]
	public static void GFKLAMKNNLG(ELMHAJPGKEB GOOGNEMPJCK, JIHLGMHMNNN KOIMDAJNDOD, DCECEOCNFPJ.FDLNFCHEIBN ILLAGPPDPIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal class HKNHFJHPCGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct LCCLHAKOMAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public HKNHFJHPCGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public OKPMJGIMPPJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public JIHLGMHMNNN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x62735A0", Offset = "0x6271DA0", VA = "0x1862735A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x6273D10", Offset = "0x6272510", VA = "0x186273D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class KNLIABPAAIH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000165")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			public KNLIABPAAIH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x62798E0", Offset = "0x62780E0", VA = "0x1862798E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x6279BA0", Offset = "0x62783A0", VA = "0x186279BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public HKNHFJHPCGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public KNLIABPAAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x62734B0", Offset = "0x6271CB0", VA = "0x1862734B0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task CHDKMPBJPAP(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct GJECJCCEOJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public HKNHFJHPCGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private KNLIABPAAIH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x626C220", Offset = "0x626AA20", VA = "0x18626C220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x626C750", Offset = "0x626AF50", VA = "0x18626C750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct OBFNNKGNMGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public HKNHFJHPCGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private Dictionary<Guid, List<GMCMKCHOBAP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x6276120", Offset = "0x6274920", VA = "0x186276120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x62766D0", Offset = "0x6274ED0", VA = "0x1862766D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct BOEPEJJBPEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public HKNHFJHPCGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private Dictionary<Guid, List<GMCMKCHOBAP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x62645B0", Offset = "0x6262DB0", VA = "0x1862645B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x6264C30", Offset = "0x6263430", VA = "0x186264C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class BAGNJFEPMJK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016A")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005EA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005EB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005EC")]
			public GMCMKCHOBAP handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005ED")]
			public BAGNJFEPMJK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005EE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x62796E0", Offset = "0x6277EE0", VA = "0x1862796E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x6279880", Offset = "0x6278080", VA = "0x186279880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public FABGNAOCIBB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public List<GMCMKCHOBAP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public BAGNJFEPMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x6263710", Offset = "0x6261F10", VA = "0x186263710")]
		internal object JIFGIFCFLPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x6263530", Offset = "0x6261D30", VA = "0x186263530")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task AOHNOJPODDG(GMCMKCHOBAP handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x6263620", Offset = "0x6261E20", VA = "0x186263620")]
		internal object IHKLELDGCHH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct AOLGOONOHIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public FABGNAOCIBB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public List<GMCMKCHOBAP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private BAGNJFEPMJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x6263000", Offset = "0x6261800", VA = "0x186263000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x62634D0", Offset = "0x6261CD0", VA = "0x1862634D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct FHAPPGKDMKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public HKNHFJHPCGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x626B610", Offset = "0x6269E10", VA = "0x18626B610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x626BBC0", Offset = "0x626A3C0", VA = "0x18626BBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class NEPMNFBHJCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public NEPMNFBHJCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x6275930", Offset = "0x6274130", VA = "0x186275930")]
		internal object GFPLPKIBNOI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct HHKCOGKHMFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public HKNHFJHPCGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public JIHLGMHMNNN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x626DA10", Offset = "0x626C210", VA = "0x18626DA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x626DF20", Offset = "0x626C720", VA = "0x18626DF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class LGKLCNEBJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public LGKLCNEBJEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x6273D70", Offset = "0x6272570", VA = "0x186273D70")]
		internal object NAMBNMOOJKH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct FCJFDFGPAJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public HKNHFJHPCGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private TaskAwaiter<DGGJMFLMPCO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x626AD90", Offset = "0x6269590", VA = "0x18626AD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x626B410", Offset = "0x6269C10", VA = "0x18626B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class NLHNKIOALHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public NLHNKIOALHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x62759A0", Offset = "0x62741A0", VA = "0x1862759A0")]
		internal object FNFDFJMAAFC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	private readonly GGBNNOAMFHH LBFDBPOFACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private DIHCMLOEDDF OJOBEEHHCBJ;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private ELMHAJPGKEB DBGHKGKMCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x19FE0E0", Offset = "0x19FC8E0", VA = "0x1819FE0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	public HKNHFJHPCGN(GGBNNOAMFHH LBFDBPOFACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x626EB80", Offset = "0x626D380", VA = "0x18626EB80")]
	[AsyncStateMachine(typeof(LCCLHAKOMAM))]
	public Task GFKLAMKNNLG(OKPMJGIMPPJ AGGNLEOBHDE, JIHLGMHMNNN FLJGKCCEDKC, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x626EE10", Offset = "0x626D610", VA = "0x18626EE10")]
	[AsyncStateMachine(typeof(GJECJCCEOJC))]
	private Task HKEDFINMCIF(JIHLGMHMNNN KOIMDAJNDOD, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x626EA40", Offset = "0x626D240", VA = "0x18626EA40")]
	[AsyncStateMachine(typeof(OBFNNKGNMGC))]
	private Task DONBMLKPKNJ(JIHLGMHMNNN KOIMDAJNDOD, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x626E690", Offset = "0x626CE90", VA = "0x18626E690")]
	[AsyncStateMachine(typeof(BOEPEJJBPEA))]
	private Task AFNPPEOBKBJ(JIHLGMHMNNN KOIMDAJNDOD, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x626E7D0", Offset = "0x626CFD0", VA = "0x18626E7D0")]
	[AsyncStateMachine(typeof(AOLGOONOHIM))]
	private Task AGEDIIDEBBF(Guid KAPKHKNCCLM, List<GMCMKCHOBAP> DFMOFKIGMIF, FABGNAOCIBB NHHMPLCGKKL, JIHLGMHMNNN KOIMDAJNDOD, CancellationToken PIPCHJCEPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x626F190", Offset = "0x626D990", VA = "0x18626F190")]
	[AsyncStateMachine(typeof(FHAPPGKDMKP))]
	private Task JPDBNIHBKPO(JIHLGMHMNNN KOIMDAJNDOD, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x626ECD0", Offset = "0x626D4D0", VA = "0x18626ECD0")]
	[AsyncStateMachine(typeof(HHKCOGKHMFC))]
	private Task GJFONADOIKL(Guid OLDAGOECMHF, JIHLGMHMNNN KOIMDAJNDOD, GJGBNJADGMM<string>.NJLLNAPFMFK HCIPJNOFOCL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x626F4B0", Offset = "0x626DCB0", VA = "0x18626F4B0")]
	[AsyncStateMachine(typeof(FCJFDFGPAJF))]
	private Task PAHFCCGKMIJ(Guid OLDAGOECMHF, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x626E920", Offset = "0x626D120", VA = "0x18626E920")]
	private void DGHBCPAIHLG(Guid OLDAGOECMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x626F0E0", Offset = "0x626D8E0", VA = "0x18626F0E0")]
	private void IMIABKABHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x626EF50", Offset = "0x626D750", VA = "0x18626EF50")]
	public Guid IEBCBHBNLNC(OKPMJGIMPPJ PBMJHMIJNIE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x626F2D0", Offset = "0x626DAD0", VA = "0x18626F2D0")]
	[CompilerGenerated]
	private object NFKFBHBHFEO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
public readonly struct DPBKFADKGDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	public readonly bool BBHJMJDMCAJ;

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0xB30410", Offset = "0xB2EC10", VA = "0x180B30410")]
	public DPBKFADKGDF(bool IAALMBGAIGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public readonly struct GDEGEKAIEIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	public readonly NHKJOGGKLGM? EKNGBJLPMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	public readonly HOAPOLNGCIK IPKJPOFPAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	public readonly string? FEOJGNEGJPI;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IReadOnlyCollection<string> CAEAALPDHFF
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x626C0E0", Offset = "0x626A8E0", VA = "0x18626C0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public IReadOnlyDictionary<long, int> MCNCFFDPBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x626C100", Offset = "0x626A900", VA = "0x18626C100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x626C120", Offset = "0x626A920", VA = "0x18626C120")]
	public GDEGEKAIEIO(NHKJOGGKLGM? EKBIDHDINDL, HOAPOLNGCIK POOLLALNAHH, string? KOAJJCKLDML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
internal class PGCDNJDDLBN : ENELEIKFJDO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct HIKCDLGOGKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public AsyncTaskMethodBuilder<GDEGEKAIEIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public PGCDNJDDLBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public LCMMCDFAPFH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public GPILLMEHCKI roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x626DF80", Offset = "0x626C780", VA = "0x18626DF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x626E620", Offset = "0x626CE20", VA = "0x18626E620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class PKFOBENJOLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public LCMMCDFAPFH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public PGCDNJDDLBN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public PKFOBENJOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x62794C0", Offset = "0x6277CC0", VA = "0x1862794C0")]
		internal Task JGOMMGBHMLN(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x62793E0", Offset = "0x6277BE0", VA = "0x1862793E0")]
		internal Task HHJJELIDILO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class EGHCGONMMJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public PKFOBENJOLA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public EGHCGONMMJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x626A3A0", Offset = "0x6268BA0", VA = "0x18626A3A0")]
		internal object LCEGDNBEDLB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class IOEBOHAGHED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public PKFOBENJOLA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public IOEBOHAGHED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x6271420", Offset = "0x626FC20", VA = "0x186271420")]
		internal Task CIHDKHKJKKO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct ALJKEHIAFLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public LCMMCDFAPFH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public PGCDNJDDLBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private EGHCGONMMJN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x62626E0", Offset = "0x6260EE0", VA = "0x1862626E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6262FA0", Offset = "0x62617A0", VA = "0x186262FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private static readonly TimeSpan JFKDANMCDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private readonly JCLKKOPDAPH ALLNFFKIAAN;

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x6278BD0", Offset = "0x62773D0", VA = "0x186278BD0")]
	public PGCDNJDDLBN(GGBNNOAMFHH LBFDBPOFACL, JCLKKOPDAPH ALLNFFKIAAN, PFECAMNMOCE ANEILBIOBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x6278A00", Offset = "0x6277200", VA = "0x186278A00")]
	[AsyncStateMachine(typeof(HIKCDLGOGKP))]
	public Task<GDEGEKAIEIO> NDMEHJLGNHG(long FDNNACNGHGO, GPILLMEHCKI OKBKLFFMACC, LCMMCDFAPFH ECAPLELHMOA, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x6277B30", Offset = "0x6276330", VA = "0x186277B30")]
	[AsyncStateMachine(typeof(ALJKEHIAFLK))]
	private Task CPFHLBIHEGC(LCMMCDFAPFH ECAPLELHMOA, IEnumerable<PersistenceView> PLLMOHIABIO, StringBuilder HCIENICKJON, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x62783A0", Offset = "0x6276BA0", VA = "0x1862783A0")]
	private GDEGEKAIEIO LGBCPPEMBAL(long FDNNACNGHGO, GPILLMEHCKI OKBKLFFMACC, LCMMCDFAPFH ECAPLELHMOA, IEnumerable<PersistenceView> PLLMOHIABIO, StringBuilder HCIENICKJON)
	{
		return default(GDEGEKAIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x6278840", Offset = "0x6277040", VA = "0x186278840")]
	private NHKJOGGKLGM LJDPJEFBDAE(long FDNNACNGHGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x6278150", Offset = "0x6276950", VA = "0x186278150")]
	private void LBEOFKBMCDB(NHKJOGGKLGM JIKNAIPIKIL, StringBuilder HCIENICKJON, IEnumerable<PersistenceView> PLLMOHIABIO, [In] PIAFPDBPJKH BDODKHNBHFM, KDLDCCCKPJN BKLJBFPCFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x6277C80", Offset = "0x6276480", VA = "0x186277C80")]
	private void DEADCFGKPGC(NHKJOGGKLGM JIKNAIPIKIL, StringBuilder HCIENICKJON, PersistenceView ICAGFLPKAGF, KDLDCCCKPJN BKLJBFPCFAH, [In] PIAFPDBPJKH BDODKHNBHFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal class HDEHAPKJCEN : ENELEIKFJDO
{
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class MNGCPFHMFGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public DEKGBIFNIKA.CLKFDKPAHHB roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MNGCPFHMFGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x6274BB0", Offset = "0x62733B0", VA = "0x186274BB0")]
		internal object PDBGIFCGKJJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct OKJGKNLBNDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public AsyncTaskMethodBuilder<(DEKGBIFNIKA.CLKFDKPAHHB roomDataUpload, DEKGBIFNIKA.CLKFDKPAHHB subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public GDEGEKAIEIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public HDEHAPKJCEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private MNGCPFHMFGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private TaskAwaiter<DEKGBIFNIKA.CLKFDKPAHHB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x6276BC0", Offset = "0x62753C0", VA = "0x186276BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x6277400", Offset = "0x6275C00", VA = "0x186277400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct KMFCEPBPKEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public AsyncTaskMethodBuilder<ILCOBDLGLGL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public HDEHAPKJCEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public GDEGEKAIEIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public MNCILMPOIGF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private TaskAwaiter<(DEKGBIFNIKA.CLKFDKPAHHB roomDataUpload, DEKGBIFNIKA.CLKFDKPAHHB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private TaskAwaiter<ILCOBDLGLGL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x6272E20", Offset = "0x6271620", VA = "0x186272E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x6273440", Offset = "0x6271C40", VA = "0x186273440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct AJELHFEFDPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public AsyncTaskMethodBuilder<EGANNAAHLJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public HDEHAPKJCEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public GDEGEKAIEIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private TaskAwaiter<(DEKGBIFNIKA.CLKFDKPAHHB roomDataUpload, DEKGBIFNIKA.CLKFDKPAHHB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private TaskAwaiter<EGANNAAHLJC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x6262250", Offset = "0x6260A50", VA = "0x186262250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x6262670", Offset = "0x6260E70", VA = "0x186262670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class GBNGLBLJFPE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000182")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000668")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000669")]
			public AsyncTaskMethodBuilder<DGGJMFLMPCO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			public GBNGLBLJFPE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400066B")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400066C")]
			private DGGJMFLMPCO <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400066D")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400066E")]
			private TaskAwaiter<EGANNAAHLJC> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400066F")]
			private TaskAwaiter<ILCOBDLGLGL> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000670")]
			private TaskAwaiter<DGGJMFLMPCO> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x6279C00", Offset = "0x6278400", VA = "0x186279C00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x627AC00", Offset = "0x6279400", VA = "0x18627AC00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public HDEHAPKJCEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public GDEGEKAIEIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public MNCILMPOIGF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public DPBKFADKGDF roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public GBNGLBLJFPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x626BFB0", Offset = "0x626A7B0", VA = "0x18626BFB0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<DGGJMFLMPCO> CGACOCPLDOK(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct HHJOJLPNMPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public AsyncTaskMethodBuilder<DGGJMFLMPCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public HDEHAPKJCEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public GDEGEKAIEIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public MNCILMPOIGF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public DPBKFADKGDF roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private TaskAwaiter<DGGJMFLMPCO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x626D690", Offset = "0x626BE90", VA = "0x18626D690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x626D9A0", Offset = "0x626C1A0", VA = "0x18626D9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x4000640")]
	private static readonly PFECAMNMOCE FJNHIHOCDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private readonly EFPHCAFJJKI EFGNLJOHFAA;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private MAJPJMCJJLM LOBAJGKJGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x624DEC0", Offset = "0x624C6C0", VA = "0x18624DEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x626D4B0", Offset = "0x626BCB0", VA = "0x18626D4B0")]
	public HDEHAPKJCEN(GGBNNOAMFHH LBFDBPOFACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x626D2D0", Offset = "0x626BAD0", VA = "0x18626D2D0")]
	[AsyncStateMachine(typeof(OKJGKNLBNDI))]
	private Task<(DEKGBIFNIKA.CLKFDKPAHHB, DEKGBIFNIKA.CLKFDKPAHHB)> PNONHBBHEAN(GDEGEKAIEIO GGGAPNAEJML, long EJLCNJNHKAA, long KEECHBIDKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x626D160", Offset = "0x626B960", VA = "0x18626D160")]
	[AsyncStateMachine(typeof(KMFCEPBPKEF))]
	public Task<ILCOBDLGLGL> OLDJJGPNKDO(int CAKLMGDELIK, [CanBeNull] MNCILMPOIGF EFBEAHBHKGB, GDEGEKAIEIO GGGAPNAEJML, long EJLCNJNHKAA, long KEECHBIDKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x626CFF0", Offset = "0x626B7F0", VA = "0x18626CFF0")]
	[AsyncStateMachine(typeof(AJELHFEFDPL))]
	private Task<EGANNAAHLJC> JLNGPPGNCAC(string AGLMNMBOMLF, int CAKLMGDELIK, GDEGEKAIEIO GGGAPNAEJML, long EJLCNJNHKAA, long KEECHBIDKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x626CE50", Offset = "0x626B650", VA = "0x18626CE50")]
	[AsyncStateMachine(typeof(HHJOJLPNMPA))]
	public Task<DGGJMFLMPCO> BJBBFBLNMFN(int CAKLMGDELIK, MNCILMPOIGF? EFBEAHBHKGB, GDEGEKAIEIO GGGAPNAEJML, long EJLCNJNHKAA, long KEECHBIDKCE, DPBKFADKGDF AAGDLJMIGID, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public abstract class HAFBFMFGEIC<T> where T : HAFBFMFGEIC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067D")]
	internal readonly MAJPJMCJJLM BIGJIPAKNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private int? CNLJPOLKJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	protected readonly Guid BNMFAJPLHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	protected readonly FGCIHKDOMIA HNDMHIKEMBP;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	protected T AENODFFNKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x35057D0", Offset = "0x3503FD0", VA = "0x1835057D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x3505830", Offset = "0x3504030", VA = "0x183505830")]
	internal HAFBFMFGEIC(MAJPJMCJJLM NMHCICOCCJE, FGCIHKDOMIA NHPBHKFKFOB, [Optional] Guid? CGNOLEKHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x3505660", Offset = "0x3503E60", VA = "0x183505660")]
	private DGGJMFLMPCO HLFOEGMHDLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "4")]
	protected virtual void JGNJBNKLKPA(DGGJMFLMPCO LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x35055D0", Offset = "0x3503DD0", VA = "0x1835055D0")]
	public T HGPCFAHMINB(OGIKDEMJHKP INJFADHECIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x3505740", Offset = "0x3503F40", VA = "0x183505740")]
	public T ILGOOCJGJKL(int CBCFGHLCEAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x35054B0", Offset = "0x3503CB0", VA = "0x1835054B0", Slot = "5")]
	public virtual Task<JJAMOFDJDHP> GHCCCLIFFIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class FFBPABPNMLI : HAFBFMFGEIC<FFBPABPNMLI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private IDDPDCCBLKC AJPCNFDACDH;

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x626B540", Offset = "0x6269D40", VA = "0x18626B540")]
	internal FFBPABPNMLI(MAJPJMCJJLM NMHCICOCCJE, FGCIHKDOMIA NHPBHKFKFOB, [Optional] Guid? CGNOLEKHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x59745F0", Offset = "0x5972DF0", VA = "0x1859745F0")]
	public FFBPABPNMLI FPHODJPAIGL(IDDPDCCBLKC AJPCNFDACDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x626B470", Offset = "0x6269C70", VA = "0x18626B470", Slot = "4")]
	protected override void JGNJBNKLKPA(DGGJMFLMPCO LACIBLEADOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public class OHMAKDLGDFA : HAFBFMFGEIC<OHMAKDLGDFA>
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	internal enum BLCAKOLNILC
	{
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private struct KHDLPOKGPKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public AsyncTaskMethodBuilder<JJAMOFDJDHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public OHMAKDLGDFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private TaskAwaiter<JJAMOFDJDHP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x6272A00", Offset = "0x6271200", VA = "0x186272A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x6272DB0", Offset = "0x62715B0", VA = "0x186272DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private BLCAKOLNILC FAILAIJBJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private string OBCMMKDDKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private MNCILMPOIGF AJPCNFDACDH;

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x6276A50", Offset = "0x6275250", VA = "0x186276A50")]
	internal OHMAKDLGDFA(MAJPJMCJJLM NMHCICOCCJE, FGCIHKDOMIA NHPBHKFKFOB, [Optional] Guid? CGNOLEKHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x6276730", Offset = "0x6274F30", VA = "0x186276730")]
	public OHMAKDLGDFA EFGANCBLBEE(string CLCHEEBIFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x6276850", Offset = "0x6275050", VA = "0x186276850")]
	public OHMAKDLGDFA HJKBPGBHHLH(bool PNCJNDPLIKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x6276A20", Offset = "0x6275220", VA = "0x186276A20")]
	public OHMAKDLGDFA OKMANIPLJHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x6276870", Offset = "0x6275070", VA = "0x186276870", Slot = "4")]
	protected override void JGNJBNKLKPA(DGGJMFLMPCO LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x6276760", Offset = "0x6274F60", VA = "0x186276760", Slot = "5")]
	[AsyncStateMachine(typeof(KHDLPOKGPKN))]
	public override Task<JJAMOFDJDHP> GHCCCLIFFIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x62769E0", Offset = "0x62751E0", VA = "0x1862769E0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<JJAMOFDJDHP> NNEDNOENNLE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal static class EPMCEIBHNDF
{
	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x626AC40", Offset = "0x6269440", VA = "0x18626AC40")]
	public static void IGBFKLCKIDC(this FALBIGDBNFH OPOBENPAPFJ, MFNEBLAPOMP GLNGGECJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x626ABC0", Offset = "0x62693C0", VA = "0x18626ABC0")]
	public static void CEECBAEKEMG(this MFNEBLAPOMP LBLFNDEJNGM, [Optional] string LACIBLEADOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
public static class HEDKNFENMAF
{
	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x626D5F0", Offset = "0x626BDF0", VA = "0x18626D5F0")]
	public static IKADIHEDPNP LECKGLPNLDI(this MLLLBAMLBGE ICGNAKFINAB)
	{
		return default(IKADIHEDPNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x626D540", Offset = "0x626BD40", VA = "0x18626D540")]
	public static MLLLBAMLBGE JIDGOCGKOLN(this IKADIHEDPNP ICDEBNCGPBF)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000691")]
			public NDNGADCBMED ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000692")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000693")]
			public NDNGADCBMED HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000694")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000696")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private static NDNGADCBMED[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private Dictionary<NDNGADCBMED, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x627B440", Offset = "0x6279C40", VA = "0x18627B440")]
		public bool EDNLJILBNPD(NDNGADCBMED POHIDANHEDA, [Out] ResultConfig NPLDMOPOFGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x627B300", Offset = "0x6279B00", VA = "0x18627B300")]
		public ResultConfig DCCCCEPMILK(NDNGADCBMED PHFMGFNHLEP, [Optional] HashSet<NDNGADCBMED> LPMBEHACPIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x627BA10", Offset = "0x627A210", VA = "0x18627BA10", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x627B4B0", Offset = "0x6279CB0", VA = "0x18627B4B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x825B10", Offset = "0x824310", VA = "0x180825B10")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class JDCPHLJINAH
{
	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x6271800", Offset = "0x6270000", VA = "0x186271800")]
	[OPPPCFMOGOO(OIAOEFLOJIJ.GameOnly)]
	private static void APGOIBPKMBC(MPCHBJGCNBP EHMBKIJNGEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public interface FLHCBAOPFOP : IEquatable<FLHCBAOPFOP>
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	DateTime AJBKGEMAEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLOMGCLBONK();

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ABGMDDFAAHH(long EJLCNJNHKAA, long FDNNACNGHGO, [Out] GDEGEKAIEIO GGGAPNAEJML);
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
internal class ADCBMEMDCOA : AGDJJDJHMHB
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class NPPMBIIAMEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public IBBKBOPDBAK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public NPPMBIIAMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x62760B0", Offset = "0x62748B0", VA = "0x1862760B0")]
		internal object ACPCKLFPMFO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private readonly BKJGGDPLONE NKIPMCMPEFM;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<FLHCBAOPFOP> FHICCOHHCND
	{
		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x6261D50", Offset = "0x6260550", VA = "0x186261D50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x6261BF0", Offset = "0x62603F0", VA = "0x186261BF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	[UnityEngine.Scripting.Preserve]
	public ADCBMEMDCOA([AKMGDNDIMPI(null)] BKJGGDPLONE NKIPMCMPEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x6261F70", Offset = "0x6260770", VA = "0x186261F70", Slot = "6")]
	public bool OKDGDBCDILC(long EJLCNJNHKAA, long FDNNACNGHGO, GDEGEKAIEIO GGGAPNAEJML, IBBKBOPDBAK KEHONEKOMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x17E9760", Offset = "0x17E7F60", VA = "0x1817E9760")]
	private void BPEEHIPCFDM(FLHCBAOPFOP HHLLBPMFFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x6261E00", Offset = "0x6260600", VA = "0x186261E00", Slot = "7")]
	public bool LNFNCDEEDDA(long EJLCNJNHKAA, long FDNNACNGHGO, [Out] FLHCBAOPFOP CDBCCOOGIEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x6261CA0", Offset = "0x62604A0", VA = "0x186261CA0", Slot = "8")]
	public bool FDLDKDDHNPF(long EJLCNJNHKAA, long FDNNACNGHGO, IBBKBOPDBAK KEHONEKOMDA, [Out] FLHCBAOPFOP CDBCCOOGIEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x62617C0", Offset = "0x625FFC0", VA = "0x1862617C0")]
	private void CFDKFGBPJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x6261690", Offset = "0x625FE90", VA = "0x186261690", Slot = "9")]
	public void BHCIMKHFJEB(long EJLCNJNHKAA, long FDNNACNGHGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal abstract class NAJHGGOEEOF : BKJGGDPLONE
{
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	protected enum EBIOPNPDEJJ : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class LMKPOKBMIEN : IEnumerable<FLHCBAOPFOP>, IEnumerable, IEnumerator<FLHCBAOPFOP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private FLHCBAOPFOP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public NAJHGGOEEOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private IBBKBOPDBAK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public IBBKBOPDBAK <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private FLHCBAOPFOP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x866770", Offset = "0x864F70", VA = "0x180866770")]
		[DebuggerHidden]
		public LMKPOKBMIEN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x6273DE0", Offset = "0x62725E0", VA = "0x186273DE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x62740C0", Offset = "0x62728C0", VA = "0x1862740C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x6274010", Offset = "0x6272810", VA = "0x186274010", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FLHCBAOPFOP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x6274010", Offset = "0x6272810", VA = "0x186274010", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class MJHONIOJFHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public IBBKBOPDBAK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MJHONIOJFHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x6274780", Offset = "0x6272F80", VA = "0x186274780")]
		internal object DADAKIODAND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class MHOOEFJLEOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public NAJHGGOEEOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MHOOEFJLEOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6274700", Offset = "0x6272F00", VA = "0x186274700")]
		internal void JCBIGBNJHFM(LDCKGCNBNAL.OGPGLOGEJOP ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	protected readonly string CBNANNOEHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private readonly object OENAINEFIOP;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract BHCEFNLIKOP CNOFCMGEGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x6275600", Offset = "0x6273E00", VA = "0x186275600")]
	protected NAJHGGOEEOF([CanBeNull] string DNNGFLKGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x6275380", Offset = "0x6273B80", VA = "0x186275380", Slot = "5")]
	public bool MEBIFEAAHEI(long EJLCNJNHKAA, long FDNNACNGHGO, IBBKBOPDBAK KEHONEKOMDA, [Out] FLHCBAOPFOP HHLLBPMFFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x6275570", Offset = "0x6273D70", VA = "0x186275570", Slot = "6")]
	[IteratorStateMachine(typeof(LMKPOKBMIEN))]
	public IEnumerable<FLHCBAOPFOP> NPAFMMADHLO(IBBKBOPDBAK KEHONEKOMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void MFJDEHMGJNI(Stream EOAIGOKFNPH, long EJLCNJNHKAA, long FDNNACNGHGO, GDEGEKAIEIO GGGAPNAEJML);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool FAFFIHBMFNB(Stream MEGNABICDLO, long EJLCNJNHKAA, long FDNNACNGHGO, LLGHLKEPJKC GNFJLEJLLDK, [Out] GDEGEKAIEIO GGGAPNAEJML);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x6274C00", Offset = "0x6273400", VA = "0x186274C00", Slot = "7")]
	public FLHCBAOPFOP CHGABPMFLON(long EJLCNJNHKAA, long FDNNACNGHGO, GDEGEKAIEIO GGGAPNAEJML, IBBKBOPDBAK KEHONEKOMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo POLFMLBNEKH(long EJLCNJNHKAA, long FDNNACNGHGO, IBBKBOPDBAK KEHONEKOMDA, EBIOPNPDEJJ APAJLEHCJAE);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo CNDFBKNCBPC(IBBKBOPDBAK KEHONEKOMDA, EBIOPNPDEJJ APAJLEHCJAE);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x6275310", Offset = "0x6273B10", VA = "0x186275310")]
	protected void JEJFFELJEDO(LDCKGCNBNAL.OGPGLOGEJOP CHDDENJJFLP, string KBMLJNGIOLJ, FileInfo NLICHCOAEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x6274F80", Offset = "0x6273780", VA = "0x186274F80")]
	internal bool FBLNKIOGFKE(FileInfo OJEHMGAJILP, long EJLCNJNHKAA, long FDNNACNGHGO, [Out] GDEGEKAIEIO GGGAPNAEJML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private void AFFGKDNIMCG(Exception PADODIHKGMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
internal class IIFPMEEFKJE : NAJHGGOEEOF
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public override BHCEFNLIKOP CNOFCMGEGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xA4B580", Offset = "0xA49D80", VA = "0x180A4B580", Slot = "8")]
		get
		{
			return default(BHCEFNLIKOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x62711A0", Offset = "0x626F9A0", VA = "0x1862711A0")]
	public IIFPMEEFKJE([Optional] string DNNGFLKGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x6270DA0", Offset = "0x626F5A0", VA = "0x186270DA0")]
	private void KNPKPGDCGNG(IBBKBOPDBAK KEHONEKOMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x6270E20", Offset = "0x626F620", VA = "0x186270E20", Slot = "9")]
	internal override void MFJDEHMGJNI(Stream EOAIGOKFNPH, long EJLCNJNHKAA, long FDNNACNGHGO, GDEGEKAIEIO GGGAPNAEJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x6270750", Offset = "0x626EF50", VA = "0x186270750", Slot = "10")]
	internal override bool FAFFIHBMFNB(Stream MEGNABICDLO, long EJLCNJNHKAA, long FDNNACNGHGO, LLGHLKEPJKC GNFJLEJLLDK, [Out] GDEGEKAIEIO GGGAPNAEJML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x62710B0", Offset = "0x626F8B0", VA = "0x1862710B0", Slot = "11")]
	protected override FileInfo POLFMLBNEKH(long EJLCNJNHKAA, long FDNNACNGHGO, IBBKBOPDBAK KEHONEKOMDA, EBIOPNPDEJJ APAJLEHCJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x6270640", Offset = "0x626EE40", VA = "0x186270640", Slot = "12")]
	protected override DirectoryInfo CNDFBKNCBPC(IBBKBOPDBAK KEHONEKOMDA, EBIOPNPDEJJ APAJLEHCJAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal sealed class CFMNDHAIMIE : NAJHGGOEEOF
{
	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	private static readonly byte[] EBICOEDOGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	private readonly byte[] OLNJLBGMMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	private readonly byte[] OCMLPAHCEPA;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public override BHCEFNLIKOP CNOFCMGEGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x529CE20", Offset = "0x529B620", VA = "0x18529CE20", Slot = "8")]
		get
		{
			return default(BHCEFNLIKOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x6266560", Offset = "0x6264D60", VA = "0x186266560")]
	public CFMNDHAIMIE([Optional] string DNNGFLKGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x62660E0", Offset = "0x62648E0", VA = "0x1862660E0", Slot = "9")]
	internal override void MFJDEHMGJNI(Stream EOAIGOKFNPH, long EJLCNJNHKAA, long FDNNACNGHGO, GDEGEKAIEIO GGGAPNAEJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x62658B0", Offset = "0x62640B0", VA = "0x1862658B0", Slot = "10")]
	internal override bool FAFFIHBMFNB(Stream MEGNABICDLO, long EJLCNJNHKAA, long FDNNACNGHGO, LLGHLKEPJKC GNFJLEJLLDK, [Out] GDEGEKAIEIO GGGAPNAEJML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x62656E0", Offset = "0x6263EE0", VA = "0x1862656E0")]
	private void CHFAALHJDMN(byte[] CMDCHMPDLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x62663A0", Offset = "0x6264BA0", VA = "0x1862663A0", Slot = "11")]
	protected override FileInfo POLFMLBNEKH(long EJLCNJNHKAA, long FDNNACNGHGO, IBBKBOPDBAK KEHONEKOMDA, EBIOPNPDEJJ APAJLEHCJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x62657A0", Offset = "0x6263FA0", VA = "0x1862657A0", Slot = "12")]
	protected override DirectoryInfo CNDFBKNCBPC(IBBKBOPDBAK KEHONEKOMDA, EBIOPNPDEJJ APAJLEHCJAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
public enum BHCEFNLIKOP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal class DEGMLDHCOEI : BKJGGDPLONE
{
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private sealed class CGDFMONOHPM : IEnumerable<FLHCBAOPFOP>, IEnumerable, IEnumerator<FLHCBAOPFOP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private FLHCBAOPFOP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public DEGMLDHCOEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private IBBKBOPDBAK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public IBBKBOPDBAK <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private BHCEFNLIKOP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private IEnumerator<FLHCBAOPFOP> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		private FLHCBAOPFOP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x866770", Offset = "0x864F70", VA = "0x180866770")]
		[DebuggerHidden]
		public CGDFMONOHPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x6266AF0", Offset = "0x62652F0", VA = "0x186266AF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x6266710", Offset = "0x6264F10", VA = "0x186266710", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x62666C0", Offset = "0x6264EC0", VA = "0x1862666C0")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x6266AA0", Offset = "0x62652A0", VA = "0x186266AA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x62669F0", Offset = "0x62651F0", VA = "0x1862669F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FLHCBAOPFOP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x62669F0", Offset = "0x62651F0", VA = "0x1862669F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private readonly BHCEFNLIKOP[] HANEIPBMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private readonly Dictionary<BHCEFNLIKOP, BKJGGDPLONE> BBCHICCGBIH;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public BHCEFNLIKOP CNOFCMGEGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x6268060", Offset = "0x6266860", VA = "0x186268060", Slot = "4")]
		get
		{
			return default(BHCEFNLIKOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x6268490", Offset = "0x6266C90", VA = "0x186268490")]
	[UnityEngine.Scripting.Preserve]
	public DEGMLDHCOEI(params BKJGGDPLONE[] JLJADDDKENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x62682B0", Offset = "0x6266AB0", VA = "0x1862682B0", Slot = "5")]
	public bool MEBIFEAAHEI(long EJLCNJNHKAA, long FDNNACNGHGO, IBBKBOPDBAK KEHONEKOMDA, [Out] FLHCBAOPFOP HHLLBPMFFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x6268090", Offset = "0x6266890", VA = "0x186268090")]
	private void KEBBFDBENMF(int EOEPENNCFMP, long EJLCNJNHKAA, long FDNNACNGHGO, IBBKBOPDBAK KEHONEKOMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x6268400", Offset = "0x6266C00", VA = "0x186268400", Slot = "6")]
	[IteratorStateMachine(typeof(CGDFMONOHPM))]
	public IEnumerable<FLHCBAOPFOP> NPAFMMADHLO(IBBKBOPDBAK KEHONEKOMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x6267F80", Offset = "0x6266780", VA = "0x186267F80", Slot = "7")]
	public FLHCBAOPFOP CHGABPMFLON(long EJLCNJNHKAA, long FDNNACNGHGO, GDEGEKAIEIO GGGAPNAEJML, IBBKBOPDBAK KEHONEKOMDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal static class JBIELIBMGCK
{
	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x6271740", Offset = "0x626FF40", VA = "0x186271740")]
	internal static byte[] PHOPJPJLOFE(byte[] CMDCHMPDLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x62716C0", Offset = "0x626FEC0", VA = "0x1862716C0")]
	public static void LNPCHCLNHJO(Stream NLHFJNBMIBJ, byte[] CLPJNLPLAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x62714E0", Offset = "0x626FCE0", VA = "0x1862714E0")]
	public static bool HOMNBCKOHNF(Stream NLHFJNBMIBJ, long EOFAIKCPMFN, LLGHLKEPJKC DKFEGJJFNKK, [Out] byte[] EKKBDGJCKHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal sealed class NNGOCNHNBLF : FLHCBAOPFOP, IEquatable<FLHCBAOPFOP>, IEquatable<NNGOCNHNBLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private readonly NAJHGGOEEOF OAMDFLBGMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	public readonly FileInfo AAKHCBLFCMI;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public BHCEFNLIKOP CNOFCMGEGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x6275AE0", Offset = "0x62742E0", VA = "0x186275AE0", Slot = "9")]
		get
		{
			return default(BHCEFNLIKOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DateTime AJBKGEMAEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x6275A50", Offset = "0x6274250", VA = "0x186275A50", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x6275FA0", Offset = "0x62747A0", VA = "0x186275FA0")]
	public NNGOCNHNBLF(NAJHGGOEEOF MPNCDPGOIAH, FileInfo OJEHMGAJILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x6275EF0", Offset = "0x62746F0", VA = "0x186275EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x6275E30", Offset = "0x6274630", VA = "0x186275E30", Slot = "5")]
	public void JLOMGCLBONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x6275A10", Offset = "0x6274210", VA = "0x186275A10", Slot = "6")]
	public bool ABGMDDFAAHH(long EJLCNJNHKAA, long FDNNACNGHGO, [Out] GDEGEKAIEIO GGGAPNAEJML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x6275CC0", Offset = "0x62744C0", VA = "0x186275CC0", Slot = "7")]
	public bool Equals(FLHCBAOPFOP GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x6275B10", Offset = "0x6274310", VA = "0x186275B10", Slot = "8")]
	public bool Equals(NNGOCNHNBLF GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x6275BD0", Offset = "0x62743D0", VA = "0x186275BD0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x6275DA0", Offset = "0x62745A0", VA = "0x186275DA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public delegate void LLGHLKEPJKC(LDCKGCNBNAL.OGPGLOGEJOP JNCMLPEOBKF, string LACIBLEADOC);
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal interface BKJGGDPLONE
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	BHCEFNLIKOP CNOFCMGEGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MEBIFEAAHEI(long EJLCNJNHKAA, long FDNNACNGHGO, IBBKBOPDBAK KEHONEKOMDA, [Out] FLHCBAOPFOP HHLLBPMFFJA);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<FLHCBAOPFOP> NPAFMMADHLO(IBBKBOPDBAK KEHONEKOMDA);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FLHCBAOPFOP CHGABPMFLON(long EJLCNJNHKAA, long FDNNACNGHGO, GDEGEKAIEIO GGGAPNAEJML, IBBKBOPDBAK KEHONEKOMDA);
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
