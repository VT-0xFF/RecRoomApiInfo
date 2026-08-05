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
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x31D3190", Offset = "0x31D1F90", VA = "0x1831D3190")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7DB60", Offset = "0xA7C960", VA = "0x180A7DB60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HCNDLBPDDLM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2883E90", Offset = "0x2882C90", VA = "0x182883E90")]
	public HCNDLBPDDLM(string GPAOLHFLBHD, Exception HJNEAIFJHLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class IIIMFKFPDMJ : ONFHLEALAPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct NGIBNFBBINN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<CIAEOCHKJND>> <>t__builder;

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
		private TaskAwaiter<global::KJLFFBOMIHP<CIAEOCHKJND>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3A7C810", Offset = "0x3A7B610", VA = "0x183A7C810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3A7C9F0", Offset = "0x3A7B7F0", VA = "0x183A7C9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct HLGLNPGDKFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MNNGBBACNPN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<MNNGBBACNPN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3A75960", Offset = "0x3A74760", VA = "0x183A75960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3A75B20", Offset = "0x3A74920", VA = "0x183A75B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	[UnityEngine.Scripting.Preserve]
	public IIIMFKFPDMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2886520", Offset = "0x2885320", VA = "0x182886520", Slot = "4")]
	[AsyncStateMachine(typeof(NGIBNFBBINN))]
	public Task<IReadOnlyList<CIAEOCHKJND>> HILBBAAAMIJ(long GJDNMGJBIPD, long EOEOMNAMOHH, [Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28863E0", Offset = "0x28851E0", VA = "0x1828863E0", Slot = "5")]
	[AsyncStateMachine(typeof(HLGLNPGDKFC))]
	public Task<IReadOnlyList<MNNGBBACNPN>> GMCFLLCMPGO(IReadOnlyList<int> FHMNHCBAMFD, [Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LCJEOAJLLJN : IEquatable<LCJEOAJLLJN>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int POMHLFFNDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	MNNGBBACNPN BFJFAGEGOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime JCFKFLIFBCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MOFMPAFGGMG? FNDJGHLNLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LCJKPHOOCJO? LDGJNPKEGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	LBIJHMCOJGC ICKHIMAOPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CMMKJOOIFOH> NAIDDCGKHOG();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum LBIJHMCOJGC
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ONFHLEALAPC
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<CIAEOCHKJND>> HILBBAAAMIJ(long GJDNMGJBIPD, long EOEOMNAMOHH, [Optional] CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<MNNGBBACNPN>> GMCFLLCMPGO(IReadOnlyList<int> FHMNHCBAMFD, [Optional] CancellationToken NBLKBHANAPP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MIFFKOHMKEI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class FOELNHGIMGL : LCJEOAJLLJN, IEquatable<LCJEOAJLLJN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct OAIBMBHBHAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<CMMKJOOIFOH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public FOELNHGIMGL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private DCKNHNPPIEN <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<PGKHPCCBDIC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<CMMKJOOIFOH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4830", Offset = "0x6AD3630", VA = "0x186AD4830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4C70", Offset = "0x6AD3A70", VA = "0x186AD4C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly CIAEOCHKJND DNFJJCPILIM;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int POMHLFFNDDO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x741BD0", Offset = "0x7409D0", VA = "0x180741BD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MNNGBBACNPN BFJFAGEGOCC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime KHJLEPNIHJC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x39B8BA0", Offset = "0x39B79A0", VA = "0x1839B8BA0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MOFMPAFGGMG? FNDJGHLNLEB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x85DED0", Offset = "0x85CCD0", VA = "0x18085DED0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public LCJKPHOOCJO? LDGJNPKEGDB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x13CCD20", Offset = "0x13CBB20", VA = "0x1813CCD20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LBIJHMCOJGC ICKHIMAOPEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x767C30", Offset = "0x766A30", VA = "0x180767C30", Slot = "10")]
			get
			{
				return default(LBIJHMCOJGC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x39B8BC0", Offset = "0x39B79C0", VA = "0x1839B8BC0", Slot = "9")]
		[AsyncStateMachine(typeof(OAIBMBHBHAE))]
		public Task<CMMKJOOIFOH> NAIDDCGKHOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x39B8D30", Offset = "0x39B7B30", VA = "0x1839B8D30")]
		public FOELNHGIMGL(int POBNBDKEJBO, MNNGBBACNPN GLMOKKAJEKJ, CIAEOCHKJND DNFJJCPILIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x39B89E0", Offset = "0x39B77E0", VA = "0x1839B89E0", Slot = "11")]
		public bool Equals(LCJEOAJLLJN IDBPJJAKCBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x39B8A70", Offset = "0x39B7870", VA = "0x1839B8A70", Slot = "0")]
		public override bool Equals(object OJGAEOFIMPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x39B8CF0", Offset = "0x39B7AF0", VA = "0x1839B8CF0")]
		private bool PPFGNHJPJAB(FOELNHGIMGL IDBPJJAKCBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x39B8B10", Offset = "0x39B7910", VA = "0x1839B8B10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class APOOKPJOMCI : LCJEOAJLLJN, IEquatable<LCJEOAJLLJN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct PABEOJCFGFG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<CMMKJOOIFOH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public APOOKPJOMCI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<CMMKJOOIFOH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4CC0", Offset = "0x6AD3AC0", VA = "0x186AD4CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4F00", Offset = "0x6AD3D00", VA = "0x186AD4F00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly MBCPJOOJPCB HBPHHMKPNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly MOFMPAFGGMG JHFPILDPBBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly LCJKPHOOCJO JLMBGFINDPF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int POMHLFFNDDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x39B2FD0", Offset = "0x39B1DD0", VA = "0x1839B2FD0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MNNGBBACNPN BFJFAGEGOCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x39B32A0", Offset = "0x39B20A0", VA = "0x1839B32A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime KHJLEPNIHJC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x39B3250", Offset = "0x39B2050", VA = "0x1839B3250", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MOFMPAFGGMG? FNDJGHLNLEB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x39B2F80", Offset = "0x39B1D80", VA = "0x1839B2F80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public LCJKPHOOCJO? LDGJNPKEGDB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x39B3170", Offset = "0x39B1F70", VA = "0x1839B3170", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public LBIJHMCOJGC ICKHIMAOPEK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x75C430", Offset = "0x75B230", VA = "0x18075C430", Slot = "10")]
			get
			{
				return default(LBIJHMCOJGC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE410", Offset = "0x7FD210", VA = "0x1807FE410")]
		public APOOKPJOMCI(MBCPJOOJPCB JCPDIHAGMHH, MOFMPAFGGMG CJPPMCHELCH, LCJKPHOOCJO KFFNHOFINLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x39B3340", Offset = "0x39B2140", VA = "0x1839B3340", Slot = "9")]
		[AsyncStateMachine(typeof(PABEOJCFGFG))]
		public Task<CMMKJOOIFOH> NAIDDCGKHOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x39B30D0", Offset = "0x39B1ED0", VA = "0x1839B30D0", Slot = "11")]
		public bool Equals(LCJEOAJLLJN IDBPJJAKCBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x39B3020", Offset = "0x39B1E20", VA = "0x1839B3020", Slot = "0")]
		public override bool Equals(object OJGAEOFIMPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x39B3460", Offset = "0x39B2260", VA = "0x1839B3460")]
		private bool PPFGNHJPJAB(APOOKPJOMCI IDBPJJAKCBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x39B31C0", Offset = "0x39B1FC0", VA = "0x1839B31C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class LILDFMPHHND : LCJEOAJLLJN, IEquatable<LCJEOAJLLJN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct DAKALBFCBIO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<CMMKJOOIFOH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<CMMKJOOIFOH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4600", Offset = "0x6AD3400", VA = "0x186AD4600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6AD47E0", Offset = "0x6AD35E0", VA = "0x186AD47E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly MNNGBBACNPN MPFFAEDLDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly MOFMPAFGGMG JHFPILDPBBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly LCJKPHOOCJO JLMBGFINDPF;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int POMHLFFNDDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x39BDF30", Offset = "0x39BCD30", VA = "0x1839BDF30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public MNNGBBACNPN BFJFAGEGOCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime KHJLEPNIHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7487A0", Offset = "0x7475A0", VA = "0x1807487A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public MOFMPAFGGMG? FNDJGHLNLEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x39BDEE0", Offset = "0x39BCCE0", VA = "0x1839BDEE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public LCJKPHOOCJO? LDGJNPKEGDB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x39BE240", Offset = "0x39BD040", VA = "0x1839BE240", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public LBIJHMCOJGC ICKHIMAOPEK
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7487A0", Offset = "0x7475A0", VA = "0x1807487A0", Slot = "10")]
			get
			{
				return default(LBIJHMCOJGC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE410", Offset = "0x7FD210", VA = "0x1807FE410")]
		public LILDFMPHHND(MNNGBBACNPN GLMOKKAJEKJ, MOFMPAFGGMG CJPPMCHELCH, LCJKPHOOCJO KFFNHOFINLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x39BE340", Offset = "0x39BD140", VA = "0x1839BE340", Slot = "9")]
		[AsyncStateMachine(typeof(DAKALBFCBIO))]
		public Task<CMMKJOOIFOH> NAIDDCGKHOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x39BDFB0", Offset = "0x39BCDB0", VA = "0x1839BDFB0", Slot = "11")]
		public bool Equals(LCJEOAJLLJN IDBPJJAKCBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x39BE0F0", Offset = "0x39BCEF0", VA = "0x1839BE0F0", Slot = "0")]
		public override bool Equals(object OJGAEOFIMPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x39BE290", Offset = "0x39BD090", VA = "0x1839BE290", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x39BE430", Offset = "0x39BD230", VA = "0x1839BE430")]
		private bool PPFGNHJPJAB(LILDFMPHHND IDBPJJAKCBN)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct CJOIEAEBBAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<LCJEOAJLLJN>> <>t__builder;

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
		public MIFFKOHMKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<CIAEOCHKJND> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<CIAEOCHKJND>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, MNNGBBACNPN account, CIAEOCHKJND roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x39B5220", Offset = "0x39B4020", VA = "0x1839B5220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x39B5CB0", Offset = "0x39B4AB0", VA = "0x1839B5CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct KNLENCLANBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, MNNGBBACNPN account, CIAEOCHKJND roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<CIAEOCHKJND> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MIFFKOHMKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<MNNGBBACNPN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x39BC790", Offset = "0x39BB590", VA = "0x1839BC790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x39BD110", Offset = "0x39BBF10", VA = "0x1839BD110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BKADMHEJFKB DPKMBACFHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly ONFHLEALAPC LJHLFCNBADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NHGJBGGAMDL IOCGKNGLKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly global::HENINDMIAPN<(long, long), IReadOnlyList<CIAEOCHKJND>> ONDDNPANLLE;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x31D03E0", Offset = "0x31CF1E0", VA = "0x1831D03E0")]
	[UnityEngine.Scripting.Preserve]
	public MIFFKOHMKEI([HDMGOABMPFL(null)] ONFHLEALAPC KEAPOOCOOHM, [HDMGOABMPFL(null)] NHGJBGGAMDL CAPOFFBGLFG, [HDMGOABMPFL(null)] BKADMHEJFKB JDPFHLBGEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x31D0290", Offset = "0x31CF090", VA = "0x1831D0290")]
	[AsyncStateMachine(typeof(CJOIEAEBBAH))]
	public Task<IList<LCJEOAJLLJN>> OOMGJDOJIBP(long GJDNMGJBIPD, long HIIJPNGKPPH, bool NGONLMKCFLK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x31D00E0", Offset = "0x31CEEE0", VA = "0x1831D00E0")]
	private bool MFBAJPJELJN(DateTime? FACEPCAFGBM, long GJDNMGJBIPD, long HIIJPNGKPPH, out MBCPJOOJPCB MBHFGKKMFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x31CFFA0", Offset = "0x31CEDA0", VA = "0x1831CFFA0")]
	[AsyncStateMachine(typeof(KNLENCLANBK))]
	private Task<IReadOnlyList<(int, MNNGBBACNPN, CIAEOCHKJND)>> IOCIFDMBDAJ(IReadOnlyList<CIAEOCHKJND> CBNHCPJLDIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NHGJBGGAMDL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MBCPJOOJPCB> DIELBKKIPPF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FLPFGACIJFP(long GJDNMGJBIPD, long HIIJPNGKPPH, IENJOFGBOJJ KLECAGPMPEJ, BNJGMAOFPGO HIFGKEGLOMI);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OPAEOOGMEFM(long GJDNMGJBIPD, long HIIJPNGKPPH, out MBCPJOOJPCB MBHFGKKMFBO);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PCIMNHAFJDE(long GJDNMGJBIPD, long HIIJPNGKPPH, BNJGMAOFPGO HIFGKEGLOMI, out MBCPJOOJPCB MBHFGKKMFBO);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ALMEAJNMGBH(long GJDNMGJBIPD, long HIIJPNGKPPH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface JGIGJCGIKAB : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool POACFAKEKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task FDIOKKMCBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EFIOAIIHKHA(Task LEGNJFDJJMM, string JCAJMNDLCGE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface BBOBOACPNFE : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CMMKJOOIFOH> HABPGOHNLLM(MBCPJOOJPCB MBHFGKKMFBO);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BLFOKAMEDNG(CancellationToken NBLKBHANAPP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface IIHPFCOCLEK : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	NKGAPBOHOGB HAIBIHFPHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIMLDGOMKBN();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIPPHNBCJNM();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface BBGDLNNBMPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface IHCNJMAEGBK
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan IEMGIEIIHOH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan LHKPAIEOOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan AGJICOIGDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan MOFLPEIHJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool EGHNKAPJOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool KNNGBLJMAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool FNLCHKIOCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool MKPIJHIDFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TimeSpan MIFFLFJAGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum OFHJEIDCOLD
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum GMLFIIMGPAI
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
public struct MCEKIAOMMJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long MONCOENCOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long EOEOMNAMOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly OFHJEIDCOLD LEDIIMFEFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception KBLFPBEMLIA;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x31CBCF0", Offset = "0x31CAAF0", VA = "0x1831CBCF0")]
	public MCEKIAOMMJF(long MONCOENCOLJ, long EOEOMNAMOHH, OFHJEIDCOLD LEDIIMFEFLP, [CanBeNull] Exception KBLFPBEMLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x31CBCA0", Offset = "0x31CAAA0", VA = "0x1831CBCA0")]
	public static MCEKIAOMMJF EJPGKLALKON(OPEMBDFJMKA ONNODGAIHFK, OFHJEIDCOLD LEDIIMFEFLP, [Optional] Exception KBLFPBEMLIA)
	{
		return default(MCEKIAOMMJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void OBBOFFGLJNH(MCEKIAOMMJF LIBNHJGGHLH);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface PKCFOCPJANB : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action DACGIMMGMBM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OBBOFFGLJNH IEJDCCBAGBK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OBBOFFGLJNH DCKIKINLFPJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event OBBOFFGLJNH KGCHMGONNOG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<GMLFIIMGPAI, bool> BBKFBPFMCKA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HOIMNAJDGNH();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JGONIAMFOCK(MCEKIAOMMJF LIBNHJGGHLH);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GDKFAFPJOMF(MCEKIAOMMJF LIBNHJGGHLH);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JDEEOMKCJKI(MCEKIAOMMJF LIBNHJGGHLH);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DNAFCIAOIDH(GMLFIIMGPAI GGEJDEFAICK, bool BLMJMLDJNFF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface PIBCCLAAKAJ : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HMBGEEKAIAN();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDADMPOMLPH();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GEKMIDEDNJD();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate Task HKCDMMMKIGC(PBFKGFFPEEN FHDHPJOAAEH, CancellationToken AMBDKIOJFBL);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface BELKPCBNDJB : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool PPGBKGEGHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CAIKNBOJPHP(HKCDMMMKIGC CACOFLEAFDK);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface LKKHABLMCAB : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus BGKOJICHBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PJHBECONBKD(OPEMBDFJMKA MEKHMAAKHAB, IHPHEABPHJC BKCLECAFNAE, CancellationToken GHKIFNBJIOP);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class BJGEIMBLFJN
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x28743D0", Offset = "0x28731D0", VA = "0x1828743D0")]
	public static bool APJCLHOMMND(this LKKHABLMCAB ALILBHNKJBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface PPDJPHHFIJM : DCKNHNPPIEN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken FHELHDLJOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	GMLHNNIDAIC GKFOBOEAKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	ADEJCHDMBNK DKGIFMJCJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	DCDAEJDLCNO CMBFBINNOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ANDGFCHCEHL DFBAGBDEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	FIBHEMFOEOC DHOEJBIMPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KPGHAKJHDEB JCOCHLADEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HMCJICJEDFG PFDJFJJJNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ODKLBOIFAHG KCDKPAKMHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	JGIGJCGIKAB FFHCBJKDKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BBOBOACPNFE FGGKPJPGGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	PKCFOCPJANB KKDAPIDEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	PIBCCLAAKAJ JPJKAEDNGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	LKKHABLMCAB MPKCNMCAFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	BELKPCBNDJB GICBFHFKOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	DMEKEBPMIEN GKKBDLFMHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PANINHFEEGA CBDDEDDCEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CAPNMFLJGID ANJEEBKGPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	NCGLDKLNFGO NAHMNFLMBHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CDGLHGPDNPI PBICEIOPPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	NNANKNBNIOG GDCIHMEHEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	NCHBIKKLAIG GCOCHNIKGFL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	AKFILMIEMOH DNAEAPLEDJI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	OHFKFMDHGAO NCHNBOCACIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	OJBJMMLAPIP BMCAFMCOEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	DCGGKIJCELB IHKOPGHPLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	IIHPFCOCLEK EFPJBEOECCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	IHCNJMAEGBK NGIPAFAFHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	GBLALHMHKCE BFOJAMKJHML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	NHGJBGGAMDL NIBNMCFKKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	IGGAKCNFNLL PHADLLCCDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	EEDLOOFOHCJ FINJGHHNGJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CGHHMJAIFMA(IHPHEABPHJC FBGLMNLJMEG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface DMEKEBPMIEN : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIINDCJDOHE OEECIDDHIAM(Guid HBBMBELBIND);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJGLMEKHGBL(Guid HBBMBELBIND);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HILLHCONDMO(Guid HBBMBELBIND, Task HBKINEMCBOK);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DGPJCMMAIDH(Guid HBBMBELBIND, CMMKJOOIFOH KEJKEAHCDEG);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GEKMIDEDNJD(Guid HBBMBELBIND);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(CMMKJOOIFOH, Task)> CMNPBJJDNHA(Guid HBBMBELBIND);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface PANINHFEEGA : BBGDLNNBMPO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface CAPNMFLJGID : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLLBCAFCPAM(BNAMHEGAPHG GPAOLHFLBHD);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OAAONCBPLAB(BNAMHEGAPHG GPAOLHFLBHD);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OEIBDBJPPKE> NPFHAMOIDLH(CancellationToken CBJKCBJOPEH);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public delegate CMMKJOOIFOH DNBHBELAAGB(ECDFOCMBGHG PAGIFHGDGPD, OEIBDBJPPKE BLIFIBIKDIM);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface NCGLDKLNFGO : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIINDCJDOHE KIAJKINAPGP(BNAMHEGAPHG PFBJKINAJLH);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHBJEJOJKII(Guid HBBMBELBIND, Task HBKINEMCBOK);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface CDGLHGPDNPI : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CMMKJOOIFOH> PBICEIOPPMI(BNAMHEGAPHG MEMGMBLNKEC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface NNANKNBNIOG : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HAMOGNLMBNC> HNEAHCEKGLK(EHEFPJIJJBB LKDPBPGJFDJ, OPEMBDFJMKA MEKHMAAKHAB, CancellationToken NBLKBHANAPP);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface AKFILMIEMOH : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMMKJOOIFOH IIEMJOOICOI(ECDFOCMBGHG PAGIFHGDGPD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IBJEHMJHGGD(string DIHIPMILEPF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface NCHBIKKLAIG : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BNAMHEGAPHG> HAKBJDNAEJB(BNAMHEGAPHG CCNKPMLIOPA, PKHONFCPCPD MLHNCMAKIOC, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<BNAMHEGAPHG> HKJBGJINLBA(CancellationToken NBLKBHANAPP, PKHONFCPCPD MLHNCMAKIOC);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MHCLGBNNENN MAIFMIFIEHN(FGOMEABCFHE ADAFNHMEEML, EHEFPJIJJBB LKDPBPGJFDJ);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MHCLGBNNENN KHAGAMEJNEE(FGOMEABCFHE ADAFNHMEEML, EHEFPJIJJBB LKDPBPGJFDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface OHFKFMDHGAO : BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMMKJOOIFOH GDAADOMNHIC(ECDFOCMBGHG PAGIFHGDGPD, OEIBDBJPPKE BLIFIBIKDIM);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CMMKJOOIFOH NPCLEDJAJII(ECDFOCMBGHG AHBBAFEEDKB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CMMKJOOIFOH NIFLGPAGIOD(ECDFOCMBGHG AHBBAFEEDKB);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface OJBJMMLAPIP
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GACBNFKDPKM(MNCIBHIPBEK PIAHNIBPHHB);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMCFKLENDOB(MNCIBHIPBEK PIAHNIBPHHB);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCCOFCDODJJ(MNCIBHIPBEK PIAHNIBPHHB);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GIAPMOHHOHB(MNCIBHIPBEK PIAHNIBPHHB);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class MNCIBHIPBEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly OPEMBDFJMKA IFICPPJEBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> NPHFIEBGKNO;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public global::GKMALKFADNA<string> LDHBJGFGABN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x741130", Offset = "0x73FF30", VA = "0x180741130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
	public MNCIBHIPBEK(OPEMBDFJMKA DFCLCBILPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x31D0ED0", Offset = "0x31CFCD0", VA = "0x1831D0ED0")]
	public MNCIBHIPBEK GNGCHLHMGGK(string JHANOPJHOLP, string MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x31D0FA0", Offset = "0x31CFDA0", VA = "0x1831D0FA0")]
	public bool LIFBGGEFMHK(out IEnumerable<KeyValuePair<string, string>> NFBNFLKINGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A85DA0", Offset = "0x2A84BA0", VA = "0x182A85DA0")]
	public MNCIBHIPBEK GKGMCPGDNLA(global::GKMALKFADNA<string> NBINANLIAKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface GBLALHMHKCE
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool PMJMODAOLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string LKDKHELGACP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FPEOGHMHGBP();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JNOIIEOBJFD GIALGGFKOND(long EMGKBPGHGPI);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::NDAPEJCMNIC<JBPGEGNDOLF, BJGLJEFJOPL> EOHPABGDNAD(long EMGKBPGHGPI);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::NDAPEJCMNIC<JBPGEGNDOLF, CKGKBFGOMIH> PJNFJBLNMLL(long EMGKBPGHGPI);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::NDAPEJCMNIC<long, OCJOABFFAGH> KDNGJAKMBKB();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> OGCOBPCPFKJ(byte[] ACGOFPFCLOD, byte[] NLBPGLPMHJA, CancellationToken NBLKBHANAPP);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface DCKNHNPPIEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool APJCLHOMMND
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool DKCBFOABPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Task OBOHEBFHLAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	IHPHEABPHJC OENIIJJIEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action DACGIMMGMBM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event OBBOFFGLJNH IEJDCCBAGBK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event OBBOFFGLJNH DCKIKINLFPJ;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event OBBOFFGLJNH KGCHMGONNOG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<GMLFIIMGPAI, bool> BBKFBPFMCKA;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PDADMPOMLPH();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ICHHHHDLGAH BIGFNPCJMDF();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LJNECJMOFCO FCDPODOAKBO();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<CMMKJOOIFOH> HABPGOHNLLM(MBCPJOOJPCB JCPDIHAGMHH);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task BLFOKAMEDNG(CancellationToken NBLKBHANAPP);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface FIBHEMFOEOC
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool MFONHBFDAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string CHIODENMNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEPLILKFAGJ(Scene CGIAIBGLOLH);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ACGNAAEPGCB(GPCFNPDMJCA CCPCPHHPEBA, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task NEABBJCDNMC();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ANDGFCHCEHL
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	PHGCHEAKDPI KDMNNHJCNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	int AGOPGHPMGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool AAANBHGLKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool FOINEPHHKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool OBAHMPFFOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool EOHKOGNKOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	ECDFOCMBGHG PAACCJIGOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool PDBKJDNHKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GMLHNNIDAIC ANCFCNOFIML(GMLHNNIDAIC DMCCIOFLMBE);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KBBHPAGDCCM(GMLHNNIDAIC IPJNDIBMKEC);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KGAMPHBMLGI();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task DGGCEHHPCCE(EHEFPJIJJBB LJGLCJNMGBB, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GGIDLGGNOLC(float DPHHOFKPKFO);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FBBBGNPOCFJ(string FPIGGFIFINB);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IReadOnlyList<IONJGNDKGMO> JBJLJIKEEMA();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IDisposable DFIEBKEMCED(object IJBJKIBEJLN, IONJGNDKGMO MLEDLEIOLCD);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BJGLJEFJOPL DDCFEKBNAMI(IEnumerable<MEKMDLBCOOO> IAGOKLAIEJK);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NCINCBAMADC(int DGBBJEKCCEK);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task NICBEKJGABC();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AMBBNGKBCFK();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool ACEBLECIFMD();

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task IMCBGBODBNK(CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task LGCKIDCBJDP(CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<IIADJOIAGJF> CLPINHCDAJG(DateTime APCMDHMEJKP, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> HGNNAGLHBDI(CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LDLDEKIACPP();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "23")]
	JGPGGHFLMCK NHEEPGNPDBO(ONONGACBCBK KMKCJEELFKC, CKGKBFGOMIH COAPKJAONPJ, IEnumerable<PersistenceView> OAKHLLCMLDG, ref CMOKOFJLOKE FDAJJHMIIIA);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FBCECAIIKGG(CKGKBFGOMIH COAPKJAONPJ);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void KBCPGBDKNIO(MEKMDLBCOOO EKODLDGKCFA, in JGPGGHFLMCK PHFANALOCKM);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task MHBHICADNOL(CKGKBFGOMIH JJCJKABJJAC, bool NAMAHBGBOEG, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task FEPOCHLHPEF(CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LENMGJDLDCN(long GJDNMGJBIPD, long EOEOMNAMOHH, PGKHPCCBDIC ENCIGLKNHFJ, CIAEOCHKJND NKKHHBLBLIP, IENJOFGBOJJ KLECAGPMPEJ, CGKIAAJADJO? NIIJACDKHBG, MDPJPGJEHCC? MIKDHLNLDME);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void ANLHKNPAJDG(long GJDNMGJBIPD, long EOEOMNAMOHH, MDPJPGJEHCC? MIKDHLNLDME);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void LOLKHJAFKHO(PersistenceView NANMOILCOAB);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool KNAFFEIGDPK(PersistenceView LNBPHBEKGAD);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool AFNOLPHKMBB(MEKMDLBCOOO EKODLDGKCFA, AIFDHHOCJIF KKKJGICBLPB, out HGKMGLGDNAG DHLOMAHHDOF);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task JMPJCJALFPD(CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void GOKPLHKONGE();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable BOPMKPJBANL();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void EGLHBHKAIGI(CKGKBFGOMIH JJCJKABJJAC, AIFDHHOCJIF KKKJGICBLPB);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> JKGILMEKPHA(ADEJCHDMBNK PAOJHNGKONI, CancellationToken NBLKBHANAPP, EHEFPJIJJBB LKDPBPGJFDJ);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void AJONHPPGFHA(CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<LAHOMKBPNPM> JGBDGMBLGFC(LDLMFFEFCNG CCNKPMLIOPA);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<PGKHPCCBDIC> HNHADAKJJGM(long GJDNMGJBIPD, bool FKKLGDDDPHP, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<CIAEOCHKJND> LFEPOGBJIAK(long GJDNMGJBIPD, long EOEOMNAMOHH, long EOEGJCLNPMO, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<ANALHMKOLNC> NAFIKFHFBLG(string LNGNOBMKHBG, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<ANALHMKOLNC> MDCODIKGFHH(string LNGNOBMKHBG, long GJDNMGJBIPD, long EOEOMNAMOHH, string APGKPINBDMG, DOFOBNGPBFN.AHEDDOMINFH FHDHPJOAAEH, DOFOBNGPBFN.AHEDDOMINFH NLBPGLPMHJA, int AJMHEOJBMOO);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool HHPADCLADMB();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool IONBGJADPAN();

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool BGMMHNGFLPJ(IEnumerable<HGKMGLGDNAG> APPMKGFJEBH);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void CICEJEFCGNB(List<GameObject> IJAIAPKEGNA);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float CLHBFMGFENL();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool JIINMEPIAGM(string GBOIDOKOFKM, out Scene OAALIIEEAME);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> COENNFFEABP(string GBOIDOKOFKM, LoadSceneMode COBMNAJFBCJ, bool GLPNGKLIAJC, EHEFPJIJJBB NBINANLIAKB);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void DDMCMLHEOJN();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool DFJMBFIPONJ(ByteString AAOFEOFDGLE);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void JCLPELFGOND();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void OIDOBPJDCHK();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void EFGOOIOLGMP(OPEMBDFJMKA NBKOFBGEAIG);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task LKIHAENPNJM(EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task CKLJIMBDIBN(EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task DKOBANBHNGP(EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void PGDOGAFANHF();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "63")]
	IDisposable EJLIBPKNMOL();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "64")]
	PIHHNFJBCGL IHIKBKOAHIL();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "65")]
	Task MAEPEFGECBN(CancellationToken NBLKBHANAPP);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface PIHHNFJBCGL
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HKENBLOALLI(CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HIIFMLJCEEF(CancellationToken NBLKBHANAPP);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct JGPGGHFLMCK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> ODDPPJGHMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IDisposable PNKCMPCHGJP;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2886E20", Offset = "0x2885C20", VA = "0x182886E20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum IIADJOIAGJF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface PHGCHEAKDPI
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	OPEMBDFJMKA LJEEDFGMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	PGKHPCCBDIC IIDHBHELLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	DDJMGGCCABD DHMGMNDMDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool ALCCLJHOHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool NCEKBPMMFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	int AGOPGHPMGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action GEGDOENFHEM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<int> IMFFAOOBPKA;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GPGIMPJLOPN();

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.GHCNBLCIAFG> HPDFNMILHGG(long EMGKBPGHGPI, [Optional] CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.PLBMBHKLCHD> FNAHOMHBJGP();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task IAAPMKPLBDI();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(OPEMBDFJMKA, IHPHEABPHJC) JLAEGMBENKG();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MGJOBLLJJHL EIIIDCEMBFC();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CPKOKHDCGGP(long EMGKBPGHGPI);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface DCGGKIJCELB
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBLMPJHMNEJ(out IEnumerable<int> OJJGJFAJDPM);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLHIGKPJPFA(OLFJFONDFJE AMBDKIOJFBL);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBIFCGAKGAE(OLFJFONDFJE AMBDKIOJFBL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HFBELGKHBEG
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MFMMAOJEAMA(CMMKJOOIFOH OBCHIKIIOEL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KJOFHLEFNFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHJAPHPMHKI(HPOPKPLMCDF.LLKMCKKOIPO FMIECABLCJK);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBHHLACGOLO(HPOPKPLMCDF.LLKMCKKOIPO FMIECABLCJK);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface KPGHAKJHDEB : KJOFHLEFNFJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMMKJOOIFOH JFGABFCLHOK(ECDFOCMBGHG AHBBAFEEDKB);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HMCJICJEDFG : KJOFHLEFNFJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMMKJOOIFOH IIEMJOOICOI(ECDFOCMBGHG FDHCKLIPOGF);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface JNOIIEOBJFD
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::AEGPCPFJGKN<GPCFNPDMJCA, MDPLBPNGKPK>> NGGMOEIOFFF(string APGKPINBDMG, long EMGKBPGHGPI, FMCHGLJJNMK.GMIEONIJOCN IAEDJFGDAGH, CancellationToken NBLKBHANAPP);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface NDAPEJCMNIC<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::AEGPCPFJGKN<byte[], MDPLBPNGKPK>> HLPALAABIAC(TGetDataArg OHMLFHCAJEC, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::AEGPCPFJGKN<global::JJEOKINGBLJ<TData>, MDPLBPNGKPK> DEFADLGGOKA(byte[] MMJOHADFCHO);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class GNIGGDJMCPN : PPDJPHHFIJM, DCKNHNPPIEN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct CKGOOLLEHNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<CMMKJOOIFOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public GNIGGDJMCPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MBCPJOOJPCB autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<CMMKJOOIFOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3A6D850", Offset = "0x3A6C650", VA = "0x183A6D850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A6DAF0", Offset = "0x3A6C8F0", VA = "0x183A6DAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct KKJEMODOAHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GNIGGDJMCPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3A78DF0", Offset = "0x3A77BF0", VA = "0x183A78DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JBOPNFFDBBL : IEnumerable<BBGDLNNBMPO>, IEnumerable, IEnumerator<BBGDLNNBMPO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private BBGDLNNBMPO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GNIGGDJMCPN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		private BBGDLNNBMPO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
		[DebuggerHidden]
		public JBOPNFFDBBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A76770", Offset = "0x3A75570", VA = "0x183A76770", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A76BB0", Offset = "0x3A759B0", VA = "0x183A76BB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A76B10", Offset = "0x3A75910", VA = "0x183A76B10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BBGDLNNBMPO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3A76B10", Offset = "0x3A75910", VA = "0x183A76B10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource MNCDDMKODBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly GMLHNNIDAIC IPJNDIBMKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private IDMPKOELGMG PEHOKDLEFGK;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public ADEJCHDMBNK DKGIFMJCJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7578F0", Offset = "0x7566F0", VA = "0x1807578F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7E2700", Offset = "0x7E1500", VA = "0x1807E2700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public DCDAEJDLCNO CMBFBINNOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7400B0", Offset = "0x73EEB0", VA = "0x1807400B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8509F0", Offset = "0x84F7F0", VA = "0x1808509F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public ANDGFCHCEHL DFBAGBDEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x757900", Offset = "0x756700", VA = "0x180757900", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1B0", Offset = "0x7F8FB0", VA = "0x1807FA1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public FIBHEMFOEOC DHOEJBIMPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x757910", Offset = "0x756710", VA = "0x180757910", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8509E0", Offset = "0x84F7E0", VA = "0x1808509E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public KPGHAKJHDEB JCOCHLADEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x757890", Offset = "0x756690", VA = "0x180757890", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7699F0", Offset = "0x7687F0", VA = "0x1807699F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public HMCJICJEDFG PFDJFJJJNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7578A0", Offset = "0x7566A0", VA = "0x1807578A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x778F40", Offset = "0x777D40", VA = "0x180778F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public ODKLBOIFAHG KCDKPAKMHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x77D860", Offset = "0x77C660", VA = "0x18077D860", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x778F20", Offset = "0x777D20", VA = "0x180778F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public JGIGJCGIKAB FFHCBJKDKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7483B0", Offset = "0x7471B0", VA = "0x1807483B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x94CF40", Offset = "0x94BD40", VA = "0x18094CF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public BBOBOACPNFE FGGKPJPGGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x748450", Offset = "0x747250", VA = "0x180748450", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8C16C0", Offset = "0x8C04C0", VA = "0x1808C16C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public PKCFOCPJANB KKDAPIDEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x77D830", Offset = "0x77C630", VA = "0x18077D830", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x94C560", Offset = "0x94B360", VA = "0x18094C560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public PIBCCLAAKAJ JPJKAEDNGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7578B0", Offset = "0x7566B0", VA = "0x1807578B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x778F30", Offset = "0x777D30", VA = "0x180778F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public LKKHABLMCAB MPKCNMCAFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7578C0", Offset = "0x7566C0", VA = "0x1807578C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB60", Offset = "0x7DB960", VA = "0x1807DCB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public BELKPCBNDJB GICBFHFKOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7578E0", Offset = "0x7566E0", VA = "0x1807578E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8751C0", Offset = "0x873FC0", VA = "0x1808751C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public DMEKEBPMIEN GKKBDLFMHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7578D0", Offset = "0x7566D0", VA = "0x1807578D0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x778F50", Offset = "0x777D50", VA = "0x180778F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public PANINHFEEGA CBDDEDDCEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x872940", Offset = "0x871740", VA = "0x180872940", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x873030", Offset = "0x871E30", VA = "0x180873030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public CAPNMFLJGID ANJEEBKGPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x810E90", Offset = "0x80FC90", VA = "0x180810E90", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x872950", Offset = "0x871750", VA = "0x180872950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public NCGLDKLNFGO NAHMNFLMBHN
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x874F00", Offset = "0x873D00", VA = "0x180874F00", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x874FF0", Offset = "0x873DF0", VA = "0x180874FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public CDGLHGPDNPI PBICEIOPPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA90", Offset = "0x8BD890", VA = "0x1808BEA90", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8BEB70", Offset = "0x8BD970", VA = "0x1808BEB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public NNANKNBNIOG GDCIHMEHEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8735E0", Offset = "0x8723E0", VA = "0x1808735E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7E0", Offset = "0x8BE5E0", VA = "0x1808BF7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public NCHBIKKLAIG GCOCHNIKGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8732E0", Offset = "0x8720E0", VA = "0x1808732E0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x873610", Offset = "0x872410", VA = "0x180873610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public AKFILMIEMOH DNAEAPLEDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8732C0", Offset = "0x8720C0", VA = "0x1808732C0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8735F0", Offset = "0x8723F0", VA = "0x1808735F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public OHFKFMDHGAO NCHNBOCACIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8732D0", Offset = "0x8720D0", VA = "0x1808732D0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x873600", Offset = "0x872400", VA = "0x180873600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public OJBJMMLAPIP BMCAFMCOEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7D0", Offset = "0x8BE5D0", VA = "0x1808BF7D0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x121F140", Offset = "0x121DF40", VA = "0x18121F140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public DCGGKIJCELB IHKOPGHPLEP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8735C0", Offset = "0x8723C0", VA = "0x1808735C0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x873760", Offset = "0x872560", VA = "0x180873760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public IIHPFCOCLEK EFPJBEOECCL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8735D0", Offset = "0x8723D0", VA = "0x1808735D0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x873770", Offset = "0x872570", VA = "0x180873770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public IHCNJMAEGBK NGIPAFAFHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1CF0", VA = "0x180AD2EF0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xAD2580", Offset = "0xAD1380", VA = "0x180AD2580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public GBLALHMHKCE BFOJAMKJHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xAD1050", Offset = "0xACFE50", VA = "0x180AD1050", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x100F9E0", Offset = "0x100E7E0", VA = "0x18100F9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public NHGJBGGAMDL NIBNMCFKKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x12A1B20", Offset = "0x12A0920", VA = "0x1812A1B20", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public IGGAKCNFNLL PHADLLCCDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x108B0A0", Offset = "0x1089EA0", VA = "0x18108B0A0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public EEDLOOFOHCJ FINJGHHNGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xD3A620", Offset = "0xD39420", VA = "0x180D3A620", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IHPHEABPHJC OENIIJJIEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xB4FD20", Offset = "0xB4EB20", VA = "0x180B4FD20", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x1571F10", Offset = "0x1570D10", VA = "0x181571F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private bool CMICFFFBFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x28829E0", Offset = "0x28817E0", VA = "0x1828829E0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private bool NJNJEJLEDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2882960", Offset = "0x2881760", VA = "0x182882960", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private Task HKOPHLPOKOM
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2882540", Offset = "0x2881340", VA = "0x182882540", Slot = "49")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private CancellationToken FBIFONGJFIM
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2881D20", Offset = "0x2880B20", VA = "0x182881D20", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private GMLHNNIDAIC COKCMKPNDKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event Action EFKBFJAFMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x28827D0", Offset = "0x28815D0", VA = "0x1828827D0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2882900", Offset = "0x2881700", VA = "0x182882900", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event OBBOFFGLJNH BABMNLBOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2882390", Offset = "0x2881190", VA = "0x182882390", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2882710", Offset = "0x2881510", VA = "0x182882710", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event OBBOFFGLJNH GPICOJGJNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2882770", Offset = "0x2881570", VA = "0x182882770", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2881E00", Offset = "0x2880C00", VA = "0x182881E00", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event OBBOFFGLJNH CGIOOFJIICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2882590", Offset = "0x2881390", VA = "0x182882590", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2881D40", Offset = "0x2880B40", VA = "0x182881D40", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event Action<GMLFIIMGPAI, bool> IKKAGBGOIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2882180", Offset = "0x2880F80", VA = "0x182882180", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2881DA0", Offset = "0x2880BA0", VA = "0x182881DA0", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x1571F10", Offset = "0x1570D10", VA = "0x181571F10", Slot = "36")]
	public void CGHHMJAIFMA(IHPHEABPHJC FBGLMNLJMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2882B30", Offset = "0x2881930", VA = "0x182882B30")]
	[UnityEngine.Scripting.Preserve]
	internal GNIGGDJMCPN([HDMGOABMPFL(null)] GMLHNNIDAIC IPJNDIBMKEC, [HDMGOABMPFL(null)] ADEJCHDMBNK PAOJHNGKONI, [HDMGOABMPFL(null)] DCDAEJDLCNO CDHAGCGCKNO, [HDMGOABMPFL(null)] ANDGFCHCEHL BGEMPOFCNMN, [HDMGOABMPFL(null)] FIBHEMFOEOC PJCBKGBDLPB, [HDMGOABMPFL(null)] KPGHAKJHDEB BMINMBBBAAB, [HDMGOABMPFL(null)] HMCJICJEDFG BKBLGOGKJCJ, [HDMGOABMPFL(null)] ODKLBOIFAHG FEAFELBKNGM, [HDMGOABMPFL(null)] JGIGJCGIKAB OOBAEENGOCC, [HDMGOABMPFL(null)] BBOBOACPNFE ECNHBNKKHKM, [HDMGOABMPFL(null)] PKCFOCPJANB NKBLKEDOMIK, [HDMGOABMPFL(null)] PIBCCLAAKAJ JABNJDPKPMO, [HDMGOABMPFL(null)] LKKHABLMCAB ALILBHNKJBO, [HDMGOABMPFL(null)] BELKPCBNDJB JIIFDKMGCMN, [HDMGOABMPFL(null)] DMEKEBPMIEN DNPEAIFMHCM, [HDMGOABMPFL(null)] PANINHFEEGA LJCMNOMMHEP, [HDMGOABMPFL(null)] CAPNMFLJGID OKNLPKGAEBP, [HDMGOABMPFL(null)] NCGLDKLNFGO JHLIAJGMMNG, [HDMGOABMPFL(null)] CDGLHGPDNPI KKMBPBJFECL, [HDMGOABMPFL(null)] NNANKNBNIOG ELFMLANLFAG, [HDMGOABMPFL(null)] AKFILMIEMOH GAGCPDIPDLE, [HDMGOABMPFL(null)] NCHBIKKLAIG AOJLHJGFNKL, [HDMGOABMPFL(null)] OHFKFMDHGAO GCJODOFFKKC, [HDMGOABMPFL(null)] OJBJMMLAPIP HOICIFAOMKE, [HDMGOABMPFL(null)] DCGGKIJCELB BJINBGOFHAG, [HDMGOABMPFL(null)] IHCNJMAEGBK GHGEODFGMEJ, [HDMGOABMPFL(null)] GBLALHMHKCE OMIDOAONCJA, [HDMGOABMPFL(null)] NHGJBGGAMDL OGBPEGPPFKJ, [HDMGOABMPFL(null)] IGGAKCNFNLL GDHMHFDKONJ, [HDMGOABMPFL(null)] EEDLOOFOHCJ PEAAMKLINHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2882A40", Offset = "0x2881840", VA = "0x182882A40")]
	private void PGIHAENGDGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2881FA0", Offset = "0x2880DA0", VA = "0x182881FA0", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2882130", Offset = "0x2880F30", VA = "0x182882130", Slot = "50")]
	private void EODHCDCCFLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x28823F0", Offset = "0x28811F0", VA = "0x1828823F0", Slot = "51")]
	private ICHHHHDLGAH GNDNMDMGJLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x28821E0", Offset = "0x2880FE0", VA = "0x1828821E0", Slot = "52")]
	private LJNECJMOFCO EONCMGDGPJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2881E60", Offset = "0x2880C60", VA = "0x182881E60", Slot = "53")]
	[AsyncStateMachine(typeof(CKGOOLLEHNP))]
	private Task<CMMKJOOIFOH> DNHFHEIHIOC(MBCPJOOJPCB MBHFGKKMFBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x28825F0", Offset = "0x28813F0", VA = "0x1828825F0", Slot = "54")]
	[AsyncStateMachine(typeof(KKJEMODOAHG))]
	private Task IPOJOLMFIBA(CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2882890", Offset = "0x2881690", VA = "0x182882890")]
	[IteratorStateMachine(typeof(JBOPNFFDBBL))]
	private IEnumerable<BBGDLNNBMPO> OMMAJFHLMPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2882830", Offset = "0x2881630", VA = "0x182882830")]
	[CompilerGenerated]
	private void NGHGHDPPOIA(BBGDLNNBMPO KHJAOGDHEIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class KCPMBMEKDKN : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x146C840", Offset = "0x146B640", VA = "0x18146C840")]
	public KCPMBMEKDKN(string GPAOLHFLBHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class DNCCPKOBABA : OBLPJGNIOCG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct LPICFIFIMGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DNCCPKOBABA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x31CB8C0", Offset = "0x31CA6C0", VA = "0x1831CB8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x31CBC50", Offset = "0x31CAA50", VA = "0x1831CBC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ANDGFCHCEHL BGEMPOFCNMN;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x7406E0", Offset = "0x73F4E0", VA = "0x1807406E0")]
	public DNCCPKOBABA(PPDJPHHFIJM PMENMHOEOKK, ANDGFCHCEHL BGEMPOFCNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x2875A50", Offset = "0x2874850", VA = "0x182875A50", Slot = "4")]
	[AsyncStateMachine(typeof(LPICFIFIMGO))]
	public Task<bool> BIDPNHLOBEJ(CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2875B70", Offset = "0x2874970", VA = "0x182875B70")]
	[CompilerGenerated]
	private object PIHFOMJBOBO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class EKGHPGJFBKG : OBLPJGNIOCG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct IIHOEPCBIGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public EKGHPGJFBKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x31C7230", Offset = "0x31C6030", VA = "0x1831C7230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x31C78E0", Offset = "0x31C66E0", VA = "0x1831C78E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private const float LBGJIGPIOJK = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly ANDGFCHCEHL BGEMPOFCNMN;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private PHGCHEAKDPI KDMNNHJCNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x287CBB0", Offset = "0x287B9B0", VA = "0x18287CBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7406E0", Offset = "0x73F4E0", VA = "0x1807406E0")]
	public EKGHPGJFBKG(PPDJPHHFIJM PMENMHOEOKK, ANDGFCHCEHL BGEMPOFCNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x287C990", Offset = "0x287B790", VA = "0x18287C990", Slot = "4")]
	[AsyncStateMachine(typeof(IIHOEPCBIGN))]
	public Task<bool> BIDPNHLOBEJ(CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x287CAD0", Offset = "0x287B8D0", VA = "0x18287CAD0")]
	[CompilerGenerated]
	private object GHDBDLMIMDP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class JOLODPACGBB : OBLPJGNIOCG
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class MPCGOBHJIKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public JOLODPACGBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Matchmaking.PLBMBHKLCHD result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public OPEMBDFJMKA newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public MPCGOBHJIKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A7BA20", Offset = "0x3A7A820", VA = "0x183A7BA20")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A7BB70", Offset = "0x3A7A970", VA = "0x183A7BB70")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A7BBE0", Offset = "0x3A7A9E0", VA = "0x183A7BBE0")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct PALDGMNBLEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public JOLODPACGBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MPCGOBHJIKM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<Matchmaking.PLBMBHKLCHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3A7CEF0", Offset = "0x3A7BCF0", VA = "0x183A7CEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3A7D840", Offset = "0x3A7C640", VA = "0x183A7D840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private const float LBGJIGPIOJK = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ANDGFCHCEHL BGEMPOFCNMN;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private PHGCHEAKDPI KDMNNHJCNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2889EB0", Offset = "0x2888CB0", VA = "0x182889EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7406E0", Offset = "0x73F4E0", VA = "0x1807406E0")]
	public JOLODPACGBB(PPDJPHHFIJM PMENMHOEOKK, ANDGFCHCEHL BGEMPOFCNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2889D70", Offset = "0x2888B70", VA = "0x182889D70", Slot = "4")]
	[AsyncStateMachine(typeof(PALDGMNBLEG))]
	public Task<bool> BIDPNHLOBEJ(CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal interface OBLPJGNIOCG
{
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> BIDPNHLOBEJ(CancellationToken NBLKBHANAPP);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct FAGFGCAOHKI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class HFPKOLJGLIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public PPDJPHHFIJM manager;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public HFPKOLJGLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x31C5B00", Offset = "0x31C4900", VA = "0x1831C5B00")]
		internal Task <CreateTask>b__0(PBFKGFFPEEN data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct JAMDIJAGFAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public FAGFGCAOHKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private MBCPJOOJPCB <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<IIADJOIAGJF> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<CMMKJOOIFOH> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x31C7B00", Offset = "0x31C6900", VA = "0x1831C7B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x31C8080", Offset = "0x31C6E80", VA = "0x1831C8080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct BDEFGADDOPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public FAGFGCAOHKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x31C1B40", Offset = "0x31C0940", VA = "0x1831C1B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CancellationToken NBLKBHANAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly PPDJPHHFIJM GPCKGMCLNIA;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private ADEJCHDMBNK DKGIFMJCJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x287E420", Offset = "0x287D220", VA = "0x18287E420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private ANDGFCHCEHL DFBAGBDEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x287E250", Offset = "0x287D050", VA = "0x18287E250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private PHGCHEAKDPI KDMNNHJCNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x287E470", Offset = "0x287D270", VA = "0x18287E470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private BBOBOACPNFE FGGKPJPGGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x287E2A0", Offset = "0x287D0A0", VA = "0x18287E2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x287E990", Offset = "0x287D790", VA = "0x18287E990")]
	public FAGFGCAOHKI(CancellationToken NBLKBHANAPP, PPDJPHHFIJM GPCKGMCLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x287E8D0", Offset = "0x287D6D0", VA = "0x18287E8D0")]
	public static HKCDMMMKIGC ONCELMIPKKO(PPDJPHHFIJM GPCKGMCLNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x287E2F0", Offset = "0x287D0F0", VA = "0x18287E2F0")]
	[AsyncStateMachine(typeof(JAMDIJAGFAD))]
	public Task<bool> ECBHNDAKKOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x287E730", Offset = "0x287D530", VA = "0x18287E730")]
	private bool MHIFEKAMEPO(out MBCPJOOJPCB MBHFGKKMFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x287E4F0", Offset = "0x287D2F0", VA = "0x18287E4F0")]
	[AsyncStateMachine(typeof(BDEFGADDOPM))]
	private Task LHNOKMLPIAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x287E5F0", Offset = "0x287D3F0", VA = "0x18287E5F0")]
	private Task<IIADJOIAGJF> MGDIBLMDDGO(MBCPJOOJPCB BPOFCHGCFIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct EIINDCJDOHE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly DMEKEBPMIEN DNPEAIFMHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Guid HBBMBELBIND;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private Task<(CMMKJOOIFOH, Task)> HDBMMNLKBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x287C870", Offset = "0x287B670", VA = "0x18287C870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2568930", Offset = "0x2567730", VA = "0x182568930")]
	public EIINDCJDOHE(DMEKEBPMIEN DNPEAIFMHCM, Guid HBBMBELBIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x287C940", Offset = "0x287B740", VA = "0x18287C940")]
	public TaskAwaiter<(CMMKJOOIFOH, Task)> JEHOAINMNNO()
	{
		return default(TaskAwaiter<(CMMKJOOIFOH, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x287C7A0", Offset = "0x287B5A0", VA = "0x18287C7A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct JGBAMMOOLCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly TaskCompletionSource<(CMMKJOOIFOH, Task)> MKGOPJBOECL;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public Task<(CMMKJOOIFOH, Task)> HDBMMNLKBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2886850", Offset = "0x2885650", VA = "0x182886850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2886A10", Offset = "0x2885810", VA = "0x182886A10")]
	public JGBAMMOOLCO(TimeSpan OIPLOFODGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2886890", Offset = "0x2885690", VA = "0x182886890")]
	public void HCLOMDEOOKO(Task HBKINEMCBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x28867C0", Offset = "0x28855C0", VA = "0x1828867C0")]
	public void FJDDCJGFMLG(CMMKJOOIFOH OBCHIKIIOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x28869C0", Offset = "0x28857C0", VA = "0x1828869C0")]
	public void MFHNGACHKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2886930", Offset = "0x2885730", VA = "0x182886930")]
	internal void MCJLPOGAAAD(string GPAOLHFLBHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class FFGJELHAMGD
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class GBKALPFJGHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public CIAEOCHKJND subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public GBKALPFJGHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x31C53D0", Offset = "0x31C41D0", VA = "0x1831C53D0")]
		internal bool <Create>b__0(DDJMGGCCABD s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x287FEF0", Offset = "0x287ECF0", VA = "0x18287FEF0")]
	public static HAMOGNLMBNC CJALKNOJAHB(long MONCOENCOLJ, long EOEOMNAMOHH, string LNGNOBMKHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x287FA40", Offset = "0x287E840", VA = "0x18287FA40")]
	public static HAMOGNLMBNC CJALKNOJAHB(long MONCOENCOLJ, long EOEOMNAMOHH, JBPGEGNDOLF ACGOFPFCLOD, long EOEGJCLNPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x287FD40", Offset = "0x287EB40", VA = "0x18287FD40")]
	public static HAMOGNLMBNC CJALKNOJAHB(LAHOMKBPNPM DNKEDMEIFAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x287FB00", Offset = "0x287E900", VA = "0x18287FB00")]
	public static HAMOGNLMBNC CJALKNOJAHB(PGKHPCCBDIC OEMFFNAFLID, CIAEOCHKJND PIDHBFBJKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x287FF80", Offset = "0x287ED80", VA = "0x18287FF80")]
	public static HAMOGNLMBNC LFCFADJIDPH(this HAMOGNLMBNC HIHKKNOLPAP, PGKHPCCBDIC JLLBAPHPFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2880080", Offset = "0x287EE80", VA = "0x182880080")]
	public static HAMOGNLMBNC PNLFNEHPGBA(this HAMOGNLMBNC HIHKKNOLPAP, CIAEOCHKJND PLBOGPHEFOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class PIOGPMEMMEI : JGIGJCGIKAB, BBGDLNNBMPO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct DKNANLBBFND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public PIOGPMEMMEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x39B5F00", Offset = "0x39B4D00", VA = "0x1839B5F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly OLFJFONDFJE IAAHOBNBCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private string LKKIOKDKGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Task BCLDIANBOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool POACFAKEKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x31DA0B0", Offset = "0x31D8EB0", VA = "0x1831DA0B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Task FDIOKKMCBDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x31D9ED0", Offset = "0x31D8CD0", VA = "0x1831D9ED0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7833A0", Offset = "0x7821A0", VA = "0x1807833A0", Slot = "7")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x31D9F30", Offset = "0x31D8D30", VA = "0x1831D9F30", Slot = "6")]
	public void EFIOAIIHKHA(Task LEGNJFDJJMM, string JCAJMNDLCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x31DA0E0", Offset = "0x31D8EE0", VA = "0x1831DA0E0")]
	[AsyncStateMachine(typeof(DKNANLBBFND))]
	private Task PIGJAPKACMK(Task LEAGIPGCPJP, string JCAJMNDLCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x31DA210", Offset = "0x31D9010", VA = "0x1831DA210")]
	public PIOGPMEMMEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class BLCIGEBHBNK : IIHPFCOCLEK, BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool PMNBBAAEGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NKGAPBOHOGB MHPNLKJILDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private ADEJCHDMBNK PAOJHNGKONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private IHCNJMAEGBK GHGEODFGMEJ;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public NKGAPBOHOGB HAIBIHFPHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2874CF0", Offset = "0x2873AF0", VA = "0x182874CF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2874F20", Offset = "0x2873D20", VA = "0x182874F20", Slot = "7")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2874D60", Offset = "0x2873B60", VA = "0x182874D60", Slot = "5")]
	public void MIMLDGOMKBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2874CB0", Offset = "0x2873AB0", VA = "0x182874CB0", Slot = "6")]
	public void OIPPHNBCJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2874C30", Offset = "0x2873A30", VA = "0x182874C30")]
	private Task AEJAANPEHMK(OAAKIMBOCHL IDKOCJBGGJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2874CB0", Offset = "0x2873AB0", VA = "0x182874CB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public BLCIGEBHBNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class MLHFNLOKLFA : IHCNJMAEGBK
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class CHHHJFHFGNK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly DAPKKAODDPK ECEJLOGBDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly string JHANOPJHOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly T HPJBCMEILDI;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public T KCKILJPPPGI
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x745880", Offset = "0x744680", VA = "0x180745880")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x7458A0", Offset = "0x7446A0", VA = "0x1807458A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6350", Offset = "0x2DB5150", VA = "0x182DB6350")]
		public CHHHJFHFGNK(DAPKKAODDPK ECEJLOGBDPG, string JHANOPJHOLP, T HPJBCMEILDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x2DB5FA0", Offset = "0x2DB4DA0", VA = "0x182DB5FA0")]
		private void KKELIHALBPE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly DAPKKAODDPK ECEJLOGBDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly CHHHJFHFGNK<TimeSpan> INALMJPKANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly CHHHJFHFGNK<TimeSpan> KDOAOGMOJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly CHHHJFHFGNK<TimeSpan> JJGAGGOKJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly CHHHJFHFGNK<TimeSpan> OPFFMNKNPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly CHHHJFHFGNK<bool> NHIJJDJIBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly CHHHJFHFGNK<bool> JADODHFEDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly CHHHJFHFGNK<bool> NAGINEIBNJL;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private const string KBIIACNNBFN = "RoomLoadCameraFadeTimeout";

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public TimeSpan IEMGIEIIHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x31D0A00", Offset = "0x31CF800", VA = "0x1831D0A00", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public TimeSpan LHKPAIEOOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x31D0A40", Offset = "0x31CF840", VA = "0x1831D0A40", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public TimeSpan AGJICOIGDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x31D0A80", Offset = "0x31CF880", VA = "0x1831D0A80", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public TimeSpan MOFLPEIHJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x31D0940", Offset = "0x31CF740", VA = "0x1831D0940", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool EGHNKAPJOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x31D07B0", Offset = "0x31CF5B0", VA = "0x1831D07B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool KNNGBLJMAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x31D09C0", Offset = "0x31CF7C0", VA = "0x1831D09C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool FNLCHKIOCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x31D0980", Offset = "0x31CF780", VA = "0x1831D0980", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool MKPIJHIDFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x31D0AC0", Offset = "0x31CF8C0", VA = "0x1831D0AC0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TimeSpan MIFFLFJAGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x31D07F0", Offset = "0x31CF5F0", VA = "0x1831D07F0", Slot = "12")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x31D0BC0", Offset = "0x31CF9C0", VA = "0x1831D0BC0")]
	[UnityEngine.Scripting.Preserve]
	public MLHFNLOKLFA([HDMGOABMPFL(null)] DAPKKAODDPK ECEJLOGBDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[UnityEngine.Scripting.Preserve]
internal class LMGKGCDKDLG : PKCFOCPJANB, BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class AFEHGAEMBGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public MCEKIAOMMJF roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public AFEHGAEMBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x39B2E80", Offset = "0x39B1C80", VA = "0x1839B2E80")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action DACGIMMGMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x31C99C0", Offset = "0x31C87C0", VA = "0x1831C99C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x31C97D0", Offset = "0x31C85D0", VA = "0x1831C97D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event OBBOFFGLJNH IEJDCCBAGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x31C9730", Offset = "0x31C8530", VA = "0x1831C9730", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x31C9870", Offset = "0x31C8670", VA = "0x1831C9870", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event OBBOFFGLJNH DCKIKINLFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x31C9F70", Offset = "0x31C8D70", VA = "0x1831C9F70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x31CA110", Offset = "0x31C8F10", VA = "0x1831CA110", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event OBBOFFGLJNH KGCHMGONNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x31CA010", Offset = "0x31C8E10", VA = "0x1831CA010", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x31CA250", Offset = "0x31C9050", VA = "0x1831CA250", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<GMLFIIMGPAI, bool> BBKFBPFMCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x31C9690", Offset = "0x31C8490", VA = "0x1831C9690", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x31CA1B0", Offset = "0x31C8FB0", VA = "0x1831CA1B0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "19")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x31C9A90", Offset = "0x31C8890", VA = "0x1831C9A90", Slot = "14")]
	public void HOIMNAJDGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x31CA0E0", Offset = "0x31C8EE0", VA = "0x1831CA0E0", Slot = "15")]
	public void JGONIAMFOCK(MCEKIAOMMJF LIBNHJGGHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x31C9A60", Offset = "0x31C8860", VA = "0x1831C9A60", Slot = "16")]
	public void GDKFAFPJOMF(MCEKIAOMMJF LIBNHJGGHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x31CA0B0", Offset = "0x31C8EB0", VA = "0x1831CA0B0", Slot = "17")]
	public void JDEEOMKCJKI(MCEKIAOMMJF LIBNHJGGHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x31C9910", Offset = "0x31C8710", VA = "0x1831C9910", Slot = "18")]
	public void DNAFCIAOIDH(GMLFIIMGPAI GGEJDEFAICK, bool BLMJMLDJNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x31C9D10", Offset = "0x31C8B10", VA = "0x1831C9D10")]
	private void IABBPDFDKNC(OBBOFFGLJNH MLEDLEIOLCD, MCEKIAOMMJF LIBNHJGGHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public LMGKGCDKDLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal class JIGPGLEELIP : PIBCCLAAKAJ, BBGDLNNBMPO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct HLPHCLBJCKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public JIGPGLEELIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3A76270", Offset = "0x3A75070", VA = "0x183A76270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct ACHKBFMKOOJ : IAsyncStateMachine
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
		public JIGPGLEELIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3A69BA0", Offset = "0x3A689A0", VA = "0x183A69BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class HICCDPKFHPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public HICCDPKFHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3A758F0", Offset = "0x3A746F0", VA = "0x183A758F0")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct KFGKLNKKIGA : IAsyncStateMachine
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
		public JIGPGLEELIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private HICCDPKFHPG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3A78730", Offset = "0x3A77530", VA = "0x183A78730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3A78C70", Offset = "0x3A77A70", VA = "0x183A78C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class EKHLIEBDIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public EKHLIEBDIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3A70710", Offset = "0x3A6F510", VA = "0x183A70710")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private ANDGFCHCEHL BGEMPOFCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private OBLPJGNIOCG[] HJJBNDBBMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private CancellationTokenSource BCHDMIKMMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private int JHKCEMKEJGI;

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2888A30", Offset = "0x2887830", VA = "0x182888A30", Slot = "7")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x2887D90", Offset = "0x2886B90", VA = "0x182887D90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2887F00", Offset = "0x2886D00", VA = "0x182887F00", Slot = "6")]
	public void GEKMIDEDNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x28888D0", Offset = "0x28876D0", VA = "0x1828888D0", Slot = "5")]
	public void PDADMPOMLPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2888090", Offset = "0x2886E90", VA = "0x182888090", Slot = "4")]
	[AsyncStateMachine(typeof(HLPHCLBJCKP))]
	public Task HMBGEEKAIAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2888550", Offset = "0x2887350", VA = "0x182888550")]
	private void OOGNDJDACOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2887AA0", Offset = "0x28868A0", VA = "0x182887AA0")]
	[AsyncStateMachine(typeof(ACHKBFMKOOJ))]
	private Task ALLLCLBHPPK(CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x28881A0", Offset = "0x2886FA0", VA = "0x1828881A0")]
	[AsyncStateMachine(typeof(KFGKLNKKIGA))]
	private Task<bool> LDIBLLKBKGM(int NNHNOIMLALG, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2887DA0", Offset = "0x2886BA0", VA = "0x182887DA0")]
	private void FGKFOOGAGIP(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2888400", Offset = "0x2887200", VA = "0x182888400")]
	private void NEEOOPOOFBH(int NNHNOIMLALG, bool BLMJMLDJNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2887BD0", Offset = "0x28869D0", VA = "0x182887BD0")]
	private void DCNFBJHGKHA(int NNHNOIMLALG, Exception ADJEGMMBDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x28882F0", Offset = "0x28870F0", VA = "0x1828882F0")]
	private void LHPGAGBMDMN(CancellationToken NBLKBHANAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public JIGPGLEELIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[UnityEngine.Scripting.Preserve]
internal class OCDPCEKMPPC : BELKPCBNDJB, BBGDLNNBMPO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct MCHMHEKIHIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public OCDPCEKMPPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public PBFKGFFPEEN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x39C0050", Offset = "0x39BEE50", VA = "0x1839C0050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class JBCBJDMIMFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public OCDPCEKMPPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public PBFKGFFPEEN roomData;

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JBCBJDMIMFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x39BC370", Offset = "0x39BB170", VA = "0x1839BC370")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct HIJBJFAOIFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public HKCDMMMKIGC taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x39BA6E0", Offset = "0x39B94E0", VA = "0x1839BA6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct LHMFDCGOOKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public OCDPCEKMPPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x39BDC80", Offset = "0x39BCA80", VA = "0x1839BDC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly HashSet<HKCDMMMKIGC> CALEFNGGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private DCDAEJDLCNO CDHAGCGCKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private IONJGNDKGMO IBALNAJELEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private GBJNBIIMLLD OGOIALCEMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private IDisposable PHMODDMHIME;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool PPGBKGEGHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x31D4140", Offset = "0x31D2F40", VA = "0x1831D4140", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	internal Task HDBMMNLKBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x31D4130", Offset = "0x31D2F30", VA = "0x1831D4130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x31D49B0", Offset = "0x31D37B0", VA = "0x1831D49B0", Slot = "6")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x31D3DC0", Offset = "0x31D2BC0", VA = "0x1831D3DC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x31D3D60", Offset = "0x31D2B60", VA = "0x1831D3D60", Slot = "5")]
	public bool CAIKNBOJPHP(HKCDMMMKIGC CACOFLEAFDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x31D4670", Offset = "0x31D3470", VA = "0x1831D4670")]
	private void MNJPIMLIEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x31D3AC0", Offset = "0x31D28C0", VA = "0x1831D3AC0")]
	private void BODEEJFAELL(PBFKGFFPEEN FHDHPJOAAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x31D39A0", Offset = "0x31D27A0", VA = "0x1831D39A0")]
	[AsyncStateMachine(typeof(MCHMHEKIHIM))]
	private Task BMILGNPGGNG(PBFKGFFPEEN FHDHPJOAAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x31D4050", Offset = "0x31D2E50", VA = "0x1831D4050")]
	private Func<CancellationToken, List<Task>> GIFONNJANHE(PBFKGFFPEEN FHDHPJOAAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x31D4150", Offset = "0x31D2F50", VA = "0x1831D4150")]
	private List<Task> LOIGDBOMHDK(PBFKGFFPEEN FHDHPJOAAEH, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x31D3E20", Offset = "0x31D2C20", VA = "0x1831D3E20")]
	[AsyncStateMachine(typeof(HIJBJFAOIFG))]
	private Task ELODKGHDANF(HKCDMMMKIGC CFPAOIHJDPL, PBFKGFFPEEN MMJOHADFCHO, CancellationToken AMBDKIOJFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x31D48B0", Offset = "0x31D36B0", VA = "0x1831D48B0")]
	[AsyncStateMachine(typeof(LHMFDCGOOKB))]
	private Task ODNCMEIDOGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x31D3F50", Offset = "0x31D2D50", VA = "0x1831D3F50")]
	private void GEKMIDEDNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x31D4C80", Offset = "0x31D3A80", VA = "0x1831D4C80")]
	public OCDPCEKMPPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[RecRoom.NoEngine.Common.Preserve]
internal class KIODAGAIDKB : LKKHABLMCAB, BBGDLNNBMPO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct MCAJMKHCCCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public OPEMBDFJMKA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public KIODAGAIDKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public IHPHEABPHJC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x39BFAE0", Offset = "0x39BE8E0", VA = "0x1839BFAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct GFNNLGEDGCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public KIODAGAIDKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public OPEMBDFJMKA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public IHPHEABPHJC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private global::GKMALKFADNA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private PKHONFCPCPD <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private MNCIBHIPBEK <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3A74400", Offset = "0x3A73200", VA = "0x183A74400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class NCEHANACKPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Matchmaking.FJAJGBDEAAL result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public PMELGNANPFG errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public NCEHANACKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x39C1AB0", Offset = "0x39C08B0", VA = "0x1839C1AB0")]
		internal object <ReportGameJoinResultFailureToRecNetMatchmaking>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class JFDLHHINJOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public Task<HAMOGNLMBNC> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JFDLHHINJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		internal Task<HAMOGNLMBNC> <ConnectToRoomAndRunLoadLogic>b__0(EHEFPJIJJBB _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct ENEOKMLEDOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public KIODAGAIDKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public OPEMBDFJMKA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public IHPHEABPHJC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public PKHONFCPCPD joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private JFDLHHINJOP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private ANINPBDMPIO <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private EHEFPJIJJBB <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private PGCPDGBOHJA <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private Task<Matchmaking.GHCNBLCIAFG> <serverConnectionInfoTask>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private FANPMFPOMPD <>7__wrap9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private CancellationTokenSource <cameraFadeCts>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private EHEFPJIJJBB <>7__wrap11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter<Matchmaking.GHCNBLCIAFG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private CancellationToken <photonJoinedToken>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private Task <roomLoadTask>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter<HAMOGNLMBNC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3A70D10", Offset = "0x3A6FB10", VA = "0x183A70D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct MEIBFFDKIEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public KIODAGAIDKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private EHEFPJIJJBB <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private EHEFPJIJJBB <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x39C0510", Offset = "0x39BF310", VA = "0x1839C0510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct DANFFEMMFJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public KIODAGAIDKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private GMLHNNIDAIC <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E2B0", Offset = "0x3A6D0B0", VA = "0x183A6E2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct CGAFLHEPBAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public AsyncTaskMethodBuilder<Matchmaking.GHCNBLCIAFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public OPEMBDFJMKA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public KIODAGAIDKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private EHEFPJIJJBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TaskAwaiter<Matchmaking.GHCNBLCIAFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3A6D200", Offset = "0x3A6C000", VA = "0x183A6D200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3A6D5A0", Offset = "0x3A6C3A0", VA = "0x183A6D5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct LJHPJBDENKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public OPEMBDFJMKA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public Matchmaking.GHCNBLCIAFG serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public KIODAGAIDKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public PKHONFCPCPD joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private EHEFPJIJJBB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private TaskAwaiter<GONJJJGFLNJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x39BE530", Offset = "0x39BD330", VA = "0x1839BE530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class DAHPHOBOJGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public OPEMBDFJMKA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public DAHPHOBOJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E1B0", Offset = "0x3A6CFB0", VA = "0x183A6E1B0")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E0B0", Offset = "0x3A6CEB0", VA = "0x183A6E0B0")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct EBBIFOHNGHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public OPEMBDFJMKA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public KIODAGAIDKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private DAHPHOBOJGK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x3A6F330", Offset = "0x3A6E130", VA = "0x183A6F330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct JAEGICCCGMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public KIODAGAIDKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public PKHONFCPCPD joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public HAMOGNLMBNC initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public OPEMBDFJMKA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public ANINPBDMPIO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private EHEFPJIJJBB <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x39BB8B0", Offset = "0x39BA6B0", VA = "0x1839BB8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct MBPPPAEIIDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public KIODAGAIDKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private EHEFPJIJJBB <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private EHEFPJIJJBB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private CancellationTokenSource <timeoutTcs>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private CancellationToken <timeoutToken>5__6;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x39BEE40", Offset = "0x39BDC40", VA = "0x1839BEE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct BAACNIFONLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public KIODAGAIDKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private TaskAwaiter<CMMKJOOIFOH> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A960", Offset = "0x3A69760", VA = "0x183A6A960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class AKPJKIBPOKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public OPEMBDFJMKA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public AKPJKIBPOKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A3A0", Offset = "0x3A691A0", VA = "0x183A6A3A0")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class HCAKFLEMAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public HCAKFLEMAKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3A75850", Offset = "0x3A74650", VA = "0x183A75850")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class PIPOGCFIKEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public OPEMBDFJMKA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PIPOGCFIKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x39C3C00", Offset = "0x39C2A00", VA = "0x1839C3C00")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class POMGGHLPANP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public OPEMBDFJMKA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public POMGGHLPANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x39C4780", Offset = "0x39C3580", VA = "0x1839C4780")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly string NLDAEONLBBC;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly string NGLKIHHNAJP;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly string PJFBIFOIHGP;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static readonly Guid DNJLPBAMCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private ODKLBOIFAHG FEAFELBKNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private DCDAEJDLCNO CDHAGCGCKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private ADEJCHDMBNK PAOJHNGKONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private ANDGFCHCEHL BGEMPOFCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private PIBCCLAAKAJ JABNJDPKPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private JGIGJCGIKAB OOBAEENGOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private PKCFOCPJANB NKBLKEDOMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private EEDLOOFOHCJ PEAAMKLINHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private IGGAKCNFNLL GDHMHFDKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private IDisposable PHMODDMHIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly OLFJFONDFJE GMIKMBLBMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly OLFJFONDFJE HNLDKGMFOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private FANPMFPOMPD GCPMGHCGNGM;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TaskStatus BGKOJICHBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x897710", Offset = "0x896510", VA = "0x180897710", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8978F0", Offset = "0x8966F0", VA = "0x1808978F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private PHGCHEAKDPI KDMNNHJCNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x288F6D0", Offset = "0x288E4D0", VA = "0x18288F6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x28903F0", Offset = "0x288F1F0", VA = "0x1828903F0", Slot = "6")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x288E440", Offset = "0x288D240", VA = "0x18288E440", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2890680", Offset = "0x288F480", VA = "0x182890680", Slot = "5")]
	[AsyncStateMachine(typeof(MCAJMKHCCCF))]
	public Task PJHBECONBKD(OPEMBDFJMKA MEKHMAAKHAB, IHPHEABPHJC BKCLECAFNAE, CancellationToken GHKIFNBJIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x288F470", Offset = "0x288E270", VA = "0x18288F470")]
	[AsyncStateMachine(typeof(GFNNLGEDGCE))]
	private Task IFDKNECPDPC(OPEMBDFJMKA MEKHMAAKHAB, IHPHEABPHJC BKCLECAFNAE, CancellationToken GHKIFNBJIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x288E030", Offset = "0x288CE30", VA = "0x18288E030")]
	private static void DPCMGLCLMBE(EEDLOOFOHCJ PEAAMKLINHM, OPEMBDFJMKA MEKHMAAKHAB, Exception ADJEGMMBDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x288CF20", Offset = "0x288BD20", VA = "0x18288CF20")]
	private static void BBFMGNAJBED(MNCIBHIPBEK HJMEDLLOEAM, Exception ADJEGMMBDPA, [Optional] List<int> JBDBCCECDAM, int JHKCEMKEJGI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x288FC10", Offset = "0x288EA10", VA = "0x18288FC10")]
	[AsyncStateMachine(typeof(ENEOKMLEDOP))]
	private Task KEEAMPMLNBG(EHEFPJIJJBB NBINANLIAKB, OPEMBDFJMKA MEKHMAAKHAB, IHPHEABPHJC BKCLECAFNAE, PKHONFCPCPD LJDNKDJJLOI, CancellationToken GHKIFNBJIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x288F1C0", Offset = "0x288DFC0", VA = "0x18288F1C0")]
	private void HNPPIBFNEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2890270", Offset = "0x288F070", VA = "0x182890270")]
	[AsyncStateMachine(typeof(MEIBFFDKIEB))]
	private Task PAJDEDCDCNF(EHEFPJIJJBB NBINANLIAKB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x288E490", Offset = "0x288D290", VA = "0x18288E490")]
	private void EFDLOOMLNJA(OPEMBDFJMKA MEKHMAAKHAB, CancellationToken GHKIFNBJIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x288D8F0", Offset = "0x288C6F0", VA = "0x18288D8F0")]
	private void CBCIDHJGKFO(OPEMBDFJMKA MEKHMAAKHAB, PKHONFCPCPD LJDNKDJJLOI, OperationCanceledException CGLEKGHMKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x288EDB0", Offset = "0x288DBB0", VA = "0x18288EDB0")]
	private void HDNFEICAFMA(OPEMBDFJMKA MEKHMAAKHAB, PKHONFCPCPD LJDNKDJJLOI, Exception ADJEGMMBDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x288EB10", Offset = "0x288D910", VA = "0x18288EB10")]
	private void GGJPEKOODMJ(OPEMBDFJMKA MEKHMAAKHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x28903B0", Offset = "0x288F1B0", VA = "0x1828903B0")]
	private static MCEKIAOMMJF PFJFOODMDID(OPEMBDFJMKA MEKHMAAKHAB)
	{
		return default(MCEKIAOMMJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x288F5D0", Offset = "0x288E3D0", VA = "0x18288F5D0")]
	[AsyncStateMachine(typeof(DANFFEMMFJM))]
	private Task ILCENGHOIDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x288F310", Offset = "0x288E110", VA = "0x18288F310")]
	[AsyncStateMachine(typeof(CGAFLHEPBAP))]
	private Task<Matchmaking.GHCNBLCIAFG> HPDFNMILHGG(OPEMBDFJMKA MEKHMAAKHAB, EHEFPJIJJBB NBINANLIAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x288F070", Offset = "0x288DE70", VA = "0x18288F070")]
	private static GONJJJGFLNJ HJJHJHPPPBA(OPEMBDFJMKA MEKHMAAKHAB, Matchmaking.GHCNBLCIAFG KOFIDMBLHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x288E990", Offset = "0x288D790", VA = "0x18288E990")]
	[AsyncStateMachine(typeof(LJHPJBDENKL))]
	private Task GEGLBFAACEA(OPEMBDFJMKA MEKHMAAKHAB, Matchmaking.GHCNBLCIAFG KOFIDMBLHKL, PKHONFCPCPD LJDNKDJJLOI, EHEFPJIJJBB NBINANLIAKB, CancellationToken OPABCBKJNHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x288FD90", Offset = "0x288EB90", VA = "0x18288FD90")]
	[AsyncStateMachine(typeof(EBBIFOHNGHP))]
	private Task LBKIPHPPKJE(OPEMBDFJMKA MEKHMAAKHAB, CancellationTokenSource DONLGLKMPPJ, Task FKIAAFNFJDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x288D760", Offset = "0x288C560", VA = "0x18288D760")]
	[AsyncStateMachine(typeof(JAEGICCCGMD))]
	private Task BPJCNCHHDDA(HAMOGNLMBNC HCBDEGKCKLC, ANINPBDMPIO HDJGHOJJGDB, OPEMBDFJMKA IBHKJDDBFAL, PKHONFCPCPD NEOMOPFEIFE, EHEFPJIJJBB NBINANLIAKB, CancellationToken IHHCPOBFLFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x288CC10", Offset = "0x288BA10", VA = "0x18288CC10")]
	private PKHONFCPCPD AHFIGOILNEM(PKHONFCPCPD NEOMOPFEIFE, ref CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2890130", Offset = "0x288EF30", VA = "0x182890130")]
	[AsyncStateMachine(typeof(MBPPPAEIIDI))]
	private Task NLNJHAHNNBA(EHEFPJIJJBB NBINANLIAKB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x288FF80", Offset = "0x288ED80", VA = "0x18288FF80")]
	[AsyncStateMachine(typeof(BAACNIFONLH))]
	private Task LDDBEELLFMH(PBFKGFFPEEN MMJOHADFCHO, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x288DEC0", Offset = "0x288CCC0", VA = "0x18288DEC0")]
	private static void DMLKNKLOHGG(OPEMBDFJMKA MEKHMAAKHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x288F720", Offset = "0x288E520", VA = "0x18288F720")]
	private void IPANGIPBHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x288FEF0", Offset = "0x288ECF0", VA = "0x18288FEF0")]
	private void LCHMLBJPJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x288F940", Offset = "0x288E740", VA = "0x18288F940")]
	private void JALHKPMGGJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x288DBB0", Offset = "0x288C9B0", VA = "0x18288DBB0")]
	private void CEFCIMFBAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x288DC40", Offset = "0x288CA40", VA = "0x18288DC40")]
	private static void CPIPCKAMALD(OPEMBDFJMKA MEKHMAAKHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x288CE60", Offset = "0x288BC60", VA = "0x18288CE60")]
	private static void BAFAMHGLDDK(OPEMBDFJMKA MEKHMAAKHAB, CancellationToken OPABCBKJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x288E7F0", Offset = "0x288D5F0", VA = "0x18288E7F0")]
	private static void GBJIPCHHFIC(OPEMBDFJMKA MEKHMAAKHAB, Exception ADJEGMMBDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x288F9D0", Offset = "0x288E7D0", VA = "0x18288F9D0")]
	private void JIFHAPDGPOM(OPEMBDFJMKA MEKHMAAKHAB, Task FKIAAFNFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x288DDD0", Offset = "0x288CBD0", VA = "0x18288DDD0")]
	private static void DBKHFPMEGAJ(Func<string> IMOOIIGBLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x28908C0", Offset = "0x288F6C0", VA = "0x1828908C0")]
	public KIODAGAIDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x28900C0", Offset = "0x288EEC0", VA = "0x1828900C0")]
	[CompilerGenerated]
	internal static (int, int?) LIJPJNOANNL(PMELGNANPFG IBCAALMMGCM)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[UnityEngine.Scripting.Preserve]
internal sealed class JJKPMHJAGDI : DMEKEBPMIEN, BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class BHJCMBFCAOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BHJCMBFCAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A6C5A0", Offset = "0x3A6B3A0", VA = "0x183A6C5A0")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class NHKIHCHADGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public NHKIHCHADGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A7CA40", Offset = "0x3A7B840", VA = "0x183A7CA40")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class LIDODIJFAPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public LIDODIJFAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3A79990", Offset = "0x3A78790", VA = "0x183A79990")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class JBHAKCBGFBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JBHAKCBGFBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A76710", Offset = "0x3A75510", VA = "0x183A76710")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class DLJNFCDGLHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public DLJNFCDGLHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E6D0", Offset = "0x3A6D4D0", VA = "0x183A6E6D0")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly Dictionary<Guid, JGBAMMOOLCO> DNPEAIFMHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private readonly TimeSpan EJFHFBLPNGF;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "10")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x28890D0", Offset = "0x2887ED0", VA = "0x1828890D0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2889A10", Offset = "0x2888810", VA = "0x182889A10", Slot = "4")]
	public EIINDCJDOHE OEECIDDHIAM(Guid HBBMBELBIND)
	{
		return default(EIINDCJDOHE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2888AB0", Offset = "0x28878B0", VA = "0x182888AB0", Slot = "5")]
	public bool CJGLMEKHGBL(Guid HBBMBELBIND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x28890E0", Offset = "0x2887EE0", VA = "0x1828890E0", Slot = "8")]
	public bool GEKMIDEDNJD(Guid HBBMBELBIND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2889370", Offset = "0x2888170", VA = "0x182889370", Slot = "6")]
	public bool HILLHCONDMO(Guid HBBMBELBIND, Task HBKINEMCBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2888E00", Offset = "0x2887C00", VA = "0x182888E00", Slot = "7")]
	public bool DGPJCMMAIDH(Guid HBBMBELBIND, CMMKJOOIFOH OBCHIKIIOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2888D70", Offset = "0x2887B70", VA = "0x182888D70", Slot = "9")]
	public Task<(CMMKJOOIFOH, Task)> CMNPBJJDNHA(Guid HBBMBELBIND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2889740", Offset = "0x2888540", VA = "0x182889740")]
	private void OALPHBGPFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2889CB0", Offset = "0x2888AB0", VA = "0x182889CB0")]
	public JJKPMHJAGDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[UnityEngine.Scripting.Preserve]
internal class MEAALAFCDIE : PANINHFEEGA, BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class OIFPKFNDCGJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private readonly OPEMBDFJMKA NBKOFBGEAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private readonly CancellationTokenSource BCHDMIKMMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public readonly CancellationToken BPEOEBDKKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private bool ENFPHPNKPIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private bool OCJGGEPKHAO;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x39C31D0", Offset = "0x39C1FD0", VA = "0x1839C31D0")]
		public OIFPKFNDCGJ(OPEMBDFJMKA NBKOFBGEAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x39C3080", Offset = "0x39C1E80", VA = "0x1839C3080")]
		public void GEKMIDEDNJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x39C3050", Offset = "0x39C1E50", VA = "0x1839C3050", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class CMKGNCAOGHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public OAAKIMBOCHL disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public CMKGNCAOGHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x39B5D00", Offset = "0x39B4B00", VA = "0x1839B5D00")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct OMBEAFLBAAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public OAAKIMBOCHL disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public MEAALAFCDIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x39C3280", Offset = "0x39C2080", VA = "0x1839C3280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class GJHOKCKPKMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public GJHOKCKPKMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x39B8D90", Offset = "0x39B7B90", VA = "0x1839B8D90")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct LGLKJIBMDND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public MEAALAFCDIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x39BD160", Offset = "0x39BBF60", VA = "0x1839BD160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x74B100", Offset = "0x749F00", VA = "0x18074B100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class ICEHMHOFDNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public OPEMBDFJMKA newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ICEHMHOFDNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x39BAA50", Offset = "0x39B9850", VA = "0x1839BAA50")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x39BAAF0", Offset = "0x39B98F0", VA = "0x1839BAAF0")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x39BAB30", Offset = "0x39B9930", VA = "0x1839BAB30")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class EBBHIBKJNIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public EBBHIBKJNIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x39B6A00", Offset = "0x39B5800", VA = "0x1839B6A00")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct HDNPACECIPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public OPEMBDFJMKA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public MEAALAFCDIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public IHPHEABPHJC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private ICEHMHOFDNO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x39B97F0", Offset = "0x39B85F0", VA = "0x1839B97F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private DCDAEJDLCNO CDHAGCGCKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private PIBCCLAAKAJ JABNJDPKPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private ANDGFCHCEHL BGEMPOFCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private IHCNJMAEGBK GHGEODFGMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private LKKHABLMCAB ALILBHNKJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private long GAALDPAPCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private OIFPKFNDCGJ MGLOHLKFELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private bool LEFDPDAKILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private Task IIICLOMJGGE;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private PHGCHEAKDPI KDMNNHJCNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x31CC550", Offset = "0x31CB350", VA = "0x1831CC550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool IADHBCGMFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x12C06C0", Offset = "0x12BF4C0", VA = "0x1812C06C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x31CBD50", Offset = "0x31CAB50", VA = "0x1831CBD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x31CCE80", Offset = "0x31CBC80", VA = "0x1831CCE80", Slot = "4")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x31CBD60", Offset = "0x31CAB60", VA = "0x1831CBD60", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x31CC7C0", Offset = "0x31CB5C0", VA = "0x1831CC7C0")]
	[AsyncStateMachine(typeof(OMBEAFLBAAM))]
	private Task KIBDHMHMIAF(OAAKIMBOCHL LOHBMAHKHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x31CBEE0", Offset = "0x31CACE0", VA = "0x1831CBEE0")]
	private void GEGDOENFHEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x31CC5A0", Offset = "0x31CB3A0", VA = "0x1831CC5A0")]
	private void IPJHPIOIJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x31CC240", Offset = "0x31CB040", VA = "0x1831CC240")]
	private void IILHDDOFMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x31CCE00", Offset = "0x31CBC00", VA = "0x1831CCE00")]
	private bool MBADFHFFDBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x31CC460", Offset = "0x31CB260", VA = "0x1831CC460")]
	[AsyncStateMachine(typeof(LGLKJIBMDND))]
	private void IMFFAOOBPKA(int COGEDNMFBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x31CC8E0", Offset = "0x31CB6E0", VA = "0x1831CC8E0")]
	private void KNMKKDJOHIO(out IDisposable IGAHKPBEOKI, out IDisposable FDJIHEFJDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x31CCC70", Offset = "0x31CBA70", VA = "0x1831CCC70")]
	private bool LCPLHCCALOJ(OPEMBDFJMKA NBKOFBGEAIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x31CBD10", Offset = "0x31CAB10", VA = "0x1831CBD10")]
	private void BNPFBMKAEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x31CC100", Offset = "0x31CAF00", VA = "0x1831CC100")]
	[AsyncStateMachine(typeof(HDNPACECIPM))]
	private Task IFDKNECPDPC(OPEMBDFJMKA NBKOFBGEAIG, IHPHEABPHJC BKCLECAFNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x31CD130", Offset = "0x31CBF30", VA = "0x1831CD130")]
	public MEAALAFCDIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[UnityEngine.Scripting.Preserve]
internal sealed class AENKAADHEOG : CAPNMFLJGID, BBGDLNNBMPO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct PJMOCBAEHOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public AsyncTaskMethodBuilder<OEIBDBJPPKE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AENKAADHEOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter<OEIBDBJPPKE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x31DA290", Offset = "0x31D9090", VA = "0x1831DA290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x31DA4E0", Offset = "0x31D92E0", VA = "0x1831DA4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class IGAMNFGAONH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public BNAMHEGAPHG message;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public IGAMNFGAONH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x31C6D30", Offset = "0x31C5B30", VA = "0x1831C6D30")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class JFOGNJONAOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public BNAMHEGAPHG messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JFOGNJONAOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x31C8210", Offset = "0x31C7010", VA = "0x1831C8210")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class LHIOLOBKGBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public BNAMHEGAPHG request;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public LHIOLOBKGBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x31C9630", Offset = "0x31C8430", VA = "0x1831C9630")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct BPONPDICJHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public BNAMHEGAPHG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public AENKAADHEOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<FGOMEABCFHE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x31C2120", Offset = "0x31C0F20", VA = "0x1831C2120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class BKHDCJDKMGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public BNAMHEGAPHG operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BKHDCJDKMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x31C1DA0", Offset = "0x31C0BA0", VA = "0x1831C1DA0")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct LMPCFPOJGCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public BNAMHEGAPHG operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AENKAADHEOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private PKHONFCPCPD <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<BNAMHEGAPHG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x31CAE60", Offset = "0x31C9C60", VA = "0x1831CAE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct IGKGFGLCOPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public AsyncTaskMethodBuilder<FGOMEABCFHE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AENKAADHEOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public BNAMHEGAPHG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private PKHONFCPCPD <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<BNAMHEGAPHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x31C6D90", Offset = "0x31C5B90", VA = "0x1831C6D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x31C71E0", Offset = "0x31C5FE0", VA = "0x1831C71E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class EBCHJFBPGBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public FGOMEABCFHE operation;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public EBCHJFBPGBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x31C3980", Offset = "0x31C2780", VA = "0x1831C3980")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct GOOFLJONELJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public FGOMEABCFHE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public AENKAADHEOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private global::GKMALKFADNA<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x31C5460", Offset = "0x31C4260", VA = "0x1831C5460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class GLKHIIMOBJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public BNAMHEGAPHG request;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public GLKHIIMOBJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x31C5400", Offset = "0x31C4200", VA = "0x1831C5400")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class FKNEMNLBFFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public BNAMHEGAPHG request;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public FKNEMNLBFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x31C3F00", Offset = "0x31C2D00", VA = "0x1831C3F00")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private JGIGJCGIKAB OOBAEENGOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private NCGLDKLNFGO JHLIAJGMMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private NCHBIKKLAIG AOJLHJGFNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private ADEJCHDMBNK PAOJHNGKONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private TaskCompletionSource<OEIBDBJPPKE> ODAMKJKNKEA;

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2872FF0", Offset = "0x2871DF0", VA = "0x182872FF0", Slot = "7")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2872AA0", Offset = "0x28718A0", VA = "0x182872AA0", Slot = "6")]
	[AsyncStateMachine(typeof(PJMOCBAEHOA))]
	public Task<OEIBDBJPPKE> NPFHAMOIDLH(CancellationToken CBJKCBJOPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x28722F0", Offset = "0x28710F0", VA = "0x1828722F0", Slot = "4")]
	public void GLLBCAFCPAM(BNAMHEGAPHG GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2872BE0", Offset = "0x28719E0", VA = "0x182872BE0", Slot = "5")]
	public void OAAONCBPLAB(BNAMHEGAPHG PFDPMGKLIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2872730", Offset = "0x2871530", VA = "0x182872730")]
	[AsyncStateMachine(typeof(BPONPDICJHH))]
	private Task JNJGJOCILAM(BNAMHEGAPHG CCNKPMLIOPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2872980", Offset = "0x2871780", VA = "0x182872980")]
	[AsyncStateMachine(typeof(LMPCFPOJGCB))]
	private Task NLOKPBCBAAG(BNAMHEGAPHG OOIBFOFOHNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2872190", Offset = "0x2870F90", VA = "0x182872190")]
	[AsyncStateMachine(typeof(IGKGFGLCOPJ))]
	private Task<FGOMEABCFHE> FJPKKKHNDLH(BNAMHEGAPHG CCNKPMLIOPA, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2872860", Offset = "0x2871660", VA = "0x182872860")]
	private PKHONFCPCPD JNPFLEOHDEK(BNAMHEGAPHG MEMGMBLNKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2871D70", Offset = "0x2870B70", VA = "0x182871D70")]
	[AsyncStateMachine(typeof(GOOFLJONELJ))]
	private Task BJFBKMLPLII(FGOMEABCFHE DMPEOFAJLOH, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2871EB0", Offset = "0x2870CB0", VA = "0x182871EB0")]
	private FGOMEABCFHE DPHCFFECMCC(BNAMHEGAPHG CCNKPMLIOPA, PKHONFCPCPD MLHNCMAKIOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x22EA390", Offset = "0x22E9190", VA = "0x1822EA390")]
	private T HBPFDOAGBIK<T>(T MGFMONLLLPD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2871910", Offset = "0x2870710", VA = "0x182871910")]
	private FGOMEABCFHE ABKLDHJAOFB(BNAMHEGAPHG CCNKPMLIOPA, PKHONFCPCPD MLHNCMAKIOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public AENKAADHEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2872140", Offset = "0x2870F40", VA = "0x182872140")]
	[CompilerGenerated]
	private void ENCOGCNMGID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[UnityEngine.Scripting.Preserve]
internal sealed class EIIDIDNKGPL : NCGLDKLNFGO, BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class AMBFMEKNGID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public AMBFMEKNGID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x31C1360", Offset = "0x31C0160", VA = "0x1831C1360")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class HDALEPKFGGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public HDALEPKFGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x31C59B0", Offset = "0x31C47B0", VA = "0x1831C59B0")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private ADEJCHDMBNK PAOJHNGKONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private OHFKFMDHGAO GCJODOFFKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private CAPNMFLJGID OKNLPKGAEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private DMEKEBPMIEN DNPEAIFMHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private DCGGKIJCELB BJINBGOFHAG;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x287C630", Offset = "0x287B430", VA = "0x18287C630", Slot = "6")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x287B700", Offset = "0x287A500", VA = "0x18287B700", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x287C130", Offset = "0x287AF30", VA = "0x18287C130", Slot = "4")]
	public EIINDCJDOHE KIAJKINAPGP(BNAMHEGAPHG PFBJKINAJLH)
	{
		return default(EIINDCJDOHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x287B470", Offset = "0x287A270", VA = "0x18287B470", Slot = "5")]
	public void CHBJEJOJKII(Guid HBBMBELBIND, Task HBKINEMCBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x287BD50", Offset = "0x287AB50", VA = "0x18287BD50")]
	private void FKJOBDJPIFE(byte PLFGLKLLFNF, int PIDNKAJJCDN, object CIEELPIEIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x287ACD0", Offset = "0x2879AD0", VA = "0x18287ACD0")]
	private void BHIMNPPDMOA(GHBGBFBHOGL CANNGAMIHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x287B7A0", Offset = "0x287A5A0", VA = "0x18287B7A0")]
	private void FDHNFJPFMAG(GHBGBFBHOGL CANNGAMIHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x287BA90", Offset = "0x287A890", VA = "0x18287BA90")]
	private void FJOKFAFGNAP(GHBGBFBHOGL CANNGAMIHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x287AA20", Offset = "0x2879820", VA = "0x18287AA20")]
	private CMMKJOOIFOH BFEMEDNEFOE(BNAMHEGAPHG MEMGMBLNKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x287A210", Offset = "0x2879010", VA = "0x18287A210")]
	private void ADLHNJMBDOK(BNAMHEGAPHG OOIBFOFOHNM, CMMKJOOIFOH OBCHIKIIOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x287BE20", Offset = "0x287AC20", VA = "0x18287BE20")]
	private bool GDBEJOGFDID(BNAMHEGAPHG OOIBFOFOHNM, CMMKJOOIFOH OBCHIKIIOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x287A780", Offset = "0x2879580", VA = "0x18287A780")]
	private bool AOAABIDDGKG(BNAMHEGAPHG GBNHCPDECAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x287A470", Offset = "0x2879270", VA = "0x18287A470")]
	private bool AFAONFPACNI(byte PLFGLKLLFNF, ExitGames.Client.Photon.Hashtable CANNGAMIHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public EIIDIDNKGPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[UnityEngine.Scripting.Preserve]
internal sealed class DNLCIDNKPCC : CDGLHGPDNPI, BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class GBGPHBNOFDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public OEIBDBJPPKE operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public DNLCIDNKPCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public BNAMHEGAPHG roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public GBGPHBNOFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x31C51B0", Offset = "0x31C3FB0", VA = "0x1831C51B0")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x31C5220", Offset = "0x31C4020", VA = "0x1831C5220")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct AMKJMADKMNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public AsyncTaskMethodBuilder<CMMKJOOIFOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public DNLCIDNKPCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public BNAMHEGAPHG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private TaskAwaiter<CMMKJOOIFOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x31C13D0", Offset = "0x31C01D0", VA = "0x1831C13D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x31C1970", Offset = "0x31C0770", VA = "0x1831C1970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class HEJGMGNIHCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public OEIBDBJPPKE operationType;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public HEJGMGNIHCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x31C5A90", Offset = "0x31C4890", VA = "0x1831C5A90")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class JKNCGDHMHLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public BNAMHEGAPHG request;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JKNCGDHMHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x31C82E0", Offset = "0x31C70E0", VA = "0x1831C82E0")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x31C8350", Offset = "0x31C7150", VA = "0x1831C8350")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x31C83C0", Offset = "0x31C71C0", VA = "0x1831C83C0")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct DAJKEDBDFKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<CMMKJOOIFOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public BNAMHEGAPHG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public DNLCIDNKPCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private JKNCGDHMHLO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private EIINDCJDOHE <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private CMMKJOOIFOH <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private TaskAwaiter<(CMMKJOOIFOH validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x31C2770", Offset = "0x31C1570", VA = "0x1831C2770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x31C2E90", Offset = "0x31C1C90", VA = "0x1831C2E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private ADEJCHDMBNK PAOJHNGKONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private OHFKFMDHGAO GCJODOFFKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private NCGLDKLNFGO JHLIAJGMMNG;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x28768A0", Offset = "0x28756A0", VA = "0x1828768A0", Slot = "5")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2876760", Offset = "0x2875560", VA = "0x182876760", Slot = "4")]
	[AsyncStateMachine(typeof(AMKJMADKMNG))]
	private Task<CMMKJOOIFOH> MFEGMBFPIOG(BNAMHEGAPHG MEMGMBLNKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x28764E0", Offset = "0x28752E0", VA = "0x1828764E0")]
	private bool BLHEIGNLMKC(OEIBDBJPPKE GGEJDEFAICK, out CMMKJOOIFOH AJCHMFJLMGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2876390", Offset = "0x2875190", VA = "0x182876390")]
	[AsyncStateMachine(typeof(DAJKEDBDFKO))]
	private Task<CMMKJOOIFOH> APKJEGDHDAB(BNAMHEGAPHG CCNKPMLIOPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public DNLCIDNKPCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class BCNIOILBDJD : NNANKNBNIOG, BBGDLNNBMPO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct KOKAPDOCLNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AsyncTaskMethodBuilder<HAMOGNLMBNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public OPEMBDFJMKA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public BCNIOILBDJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<PGKHPCCBDIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x31C92E0", Offset = "0x31C80E0", VA = "0x1831C92E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x31C94C0", Offset = "0x31C82C0", VA = "0x1831C94C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class OHKJAMIDBLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public OHKJAMIDBLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x31D6C50", Offset = "0x31D5A50", VA = "0x1831D6C50")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct DJPKELDANGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AsyncTaskMethodBuilder<PGKHPCCBDIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public BCNIOILBDJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public OPEMBDFJMKA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private OHKJAMIDBLK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private EHEFPJIJJBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter<PGKHPCCBDIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x31C2EE0", Offset = "0x31C1CE0", VA = "0x1831C2EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x31C3490", Offset = "0x31C2290", VA = "0x1831C3490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class BODOFLHJPCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BODOFLHJPCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1208A40", Offset = "0x1207840", VA = "0x181208A40")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(DDJMGGCCABD sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private ANDGFCHCEHL BGEMPOFCNMN;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly (JBPGEGNDOLF superRoomData, long subRoomDataSaveId) CABOBJDLLGM;

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2873910", Offset = "0x2872710", VA = "0x182873910", Slot = "5")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x28732B0", Offset = "0x28720B0", VA = "0x1828732B0", Slot = "4")]
	[AsyncStateMachine(typeof(KOKAPDOCLNA))]
	public Task<HAMOGNLMBNC> HNEAHCEKGLK(EHEFPJIJJBB LKDPBPGJFDJ, OPEMBDFJMKA MEKHMAAKHAB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2873430", Offset = "0x2872230", VA = "0x182873430")]
	[AsyncStateMachine(typeof(DJPKELDANGM))]
	private Task<PGKHPCCBDIC> NDJELFGDING(OPEMBDFJMKA MEKHMAAKHAB, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2873110", Offset = "0x2871F10", VA = "0x182873110")]
	private HAMOGNLMBNC FAJFGKBJJPG(OPEMBDFJMKA MEKHMAAKHAB, PGKHPCCBDIC DIPFHONDAKO, long HIIJPNGKPPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x28735A0", Offset = "0x28723A0", VA = "0x1828735A0")]
	private (JBPGEGNDOLF, long) OAGBPPLDHEE(OPEMBDFJMKA MEKHMAAKHAB, PGKHPCCBDIC DIPFHONDAKO, long HIIJPNGKPPH)
	{
		return default((JBPGEGNDOLF, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public BCNIOILBDJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal sealed class NDCLFELFHHA : NCHBIKKLAIG, BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class EAOOONPFOID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public BNAMHEGAPHG request;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public EAOOONPFOID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x39B69A0", Offset = "0x39B57A0", VA = "0x1839B69A0")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct EOCKIFPPJDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public AsyncTaskMethodBuilder<BNAMHEGAPHG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public BNAMHEGAPHG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public NDCLFELFHHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public PKHONFCPCPD pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<BNAMHEGAPHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x39B7090", Offset = "0x39B5E90", VA = "0x1839B7090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x39B7510", Offset = "0x39B6310", VA = "0x1839B7510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct CHIJICOKGAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public AsyncTaskMethodBuilder<BNAMHEGAPHG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public NDCLFELFHHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public PKHONFCPCPD pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private TaskAwaiter<DDKIIINLLEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x39B41A0", Offset = "0x39B2FA0", VA = "0x1839B41A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x39B4790", Offset = "0x39B3590", VA = "0x1839B4790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class FGFBPMFPNLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public BNAMHEGAPHG request;

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public FGFBPMFPNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x39B84F0", Offset = "0x39B72F0", VA = "0x1839B84F0")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct PKJNCICNOBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<BNAMHEGAPHG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public BNAMHEGAPHG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public NDCLFELFHHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public PKHONFCPCPD pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private CECNJAKHHDF <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private HJOIKHPBCCN <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<DDKIIINLLEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x39C3C80", Offset = "0x39C2A80", VA = "0x1839C3C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x39C4730", Offset = "0x39C3530", VA = "0x1839C4730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private ADEJCHDMBNK PAOJHNGKONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private IIHPFCOCLEK GFFIGGFIPLB;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private NKGAPBOHOGB HAIBIHFPHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x31D17C0", Offset = "0x31D05C0", VA = "0x1831D17C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x31D2320", Offset = "0x31D1120", VA = "0x1831D2320", Slot = "8")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x31D19C0", Offset = "0x31D07C0", VA = "0x1831D19C0", Slot = "4")]
	[AsyncStateMachine(typeof(EOCKIFPPJDJ))]
	public Task<BNAMHEGAPHG> HAKBJDNAEJB(BNAMHEGAPHG CCNKPMLIOPA, PKHONFCPCPD MLHNCMAKIOC, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x31D1B40", Offset = "0x31D0940", VA = "0x1831D1B40", Slot = "5")]
	[AsyncStateMachine(typeof(CHIJICOKGAO))]
	public Task<BNAMHEGAPHG> HKJBGJINLBA(CancellationToken NBLKBHANAPP, PKHONFCPCPD MLHNCMAKIOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x31D2090", Offset = "0x31D0E90", VA = "0x1831D2090", Slot = "6")]
	public MHCLGBNNENN MAIFMIFIEHN(FGOMEABCFHE ADAFNHMEEML, EHEFPJIJJBB LKDPBPGJFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x31D1E10", Offset = "0x31D0C10", VA = "0x1831D1E10", Slot = "7")]
	public MHCLGBNNENN KHAGAMEJNEE(FGOMEABCFHE ADAFNHMEEML, EHEFPJIJJBB LKDPBPGJFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x31D1C90", Offset = "0x31D0A90", VA = "0x1831D1C90")]
	[AsyncStateMachine(typeof(PKJNCICNOBJ))]
	private Task<BNAMHEGAPHG> JOBINOEKGCF(BNAMHEGAPHG CCNKPMLIOPA, PKHONFCPCPD MLHNCMAKIOC, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2508700", Offset = "0x2507500", VA = "0x182508700")]
	private static byte[] GAKBFMAKDOC(BNAMHEGAPHG GPAOLHFLBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x31D1870", Offset = "0x31D0670", VA = "0x1831D1870")]
	private static string FGFANJMEJJL(byte[] OHMLFHCAJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public NDCLFELFHHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[UnityEngine.Scripting.Preserve]
internal sealed class HBNPPCAHMPN : OHFKFMDHGAO, BBGDLNNBMPO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private KPGHAKJHDEB BMINMBBBAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private ADEJCHDMBNK PAOJHNGKONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private JGIGJCGIKAB OOBAEENGOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private AKFILMIEMOH GAGCPDIPDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private ANDGFCHCEHL BGEMPOFCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private LKKHABLMCAB ALILBHNKJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private BELKPCBNDJB JIIFDKMGCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private IHCNJMAEGBK GHGEODFGMEJ;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private PHGCHEAKDPI KDMNNHJCNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x28830E0", Offset = "0x2881EE0", VA = "0x1828830E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private static CMMKJOOIFOH CCDBMPIAAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x2883130", Offset = "0x2881F30", VA = "0x182883130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x2883620", Offset = "0x2882420", VA = "0x182883620", Slot = "7")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x2882F40", Offset = "0x2881D40", VA = "0x182882F40", Slot = "4")]
	public CMMKJOOIFOH GDAADOMNHIC(ECDFOCMBGHG PAGIFHGDGPD, OEIBDBJPPKE BLIFIBIKDIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2883380", Offset = "0x2882180", VA = "0x182883380", Slot = "5")]
	public CMMKJOOIFOH NPCLEDJAJII(ECDFOCMBGHG AHBBAFEEDKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x2883140", Offset = "0x2881F40", VA = "0x182883140", Slot = "6")]
	public CMMKJOOIFOH NIFLGPAGIOD(ECDFOCMBGHG AHBBAFEEDKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x28830D0", Offset = "0x2881ED0", VA = "0x1828830D0")]
	private static CMMKJOOIFOH IMPPDPMKFPH(NHHCNMIONKA PDFOLHHIIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public HBNPPCAHMPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class AHNDBPHBNDO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x28730D0", Offset = "0x2871ED0", VA = "0x1828730D0")]
	public AHNDBPHBNDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0xAD6EF0", Offset = "0xAD5CF0", VA = "0x180AD6EF0")]
	public AHNDBPHBNDO(string GPAOLHFLBHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class MGCJKPKOJEE : BBOBOACPNFE, BBGDLNNBMPO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct NIOLOKAEPFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public AsyncTaskMethodBuilder<CMMKJOOIFOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public MGCJKPKOJEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public MBCPJOOJPCB autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private global::GKMALKFADNA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private EHEFPJIJJBB <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private FGCOKIPJJEI <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private EHEFPJIJJBB <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private TaskAwaiter<CMMKJOOIFOH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x39C1CA0", Offset = "0x39C0AA0", VA = "0x1839C1CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x39C23A0", Offset = "0x39C11A0", VA = "0x1839C23A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct PPBEHIFMPML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public MGCJKPKOJEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x39C4880", Offset = "0x39C3680", VA = "0x1839C4880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct JAGPEOHHPFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public MGCJKPKOJEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x39BBE20", Offset = "0x39BAC20", VA = "0x1839BBE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct LLCNFLACLEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public MGCJKPKOJEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x39BED00", Offset = "0x39BDB00", VA = "0x1839BED00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct ODLOHGHPDNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public MGCJKPKOJEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x39C23F0", Offset = "0x39C11F0", VA = "0x1839C23F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct FLNCBCOLOOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public MGCJKPKOJEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public BNJGMAOFPGO autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private global::GKMALKFADNA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x39B8550", Offset = "0x39B7350", VA = "0x1839B8550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private static readonly TimeSpan OPNLGBMLOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private ADEJCHDMBNK PAOJHNGKONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private ANDGFCHCEHL BGEMPOFCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private NCHBIKKLAIG AOJLHJGFNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private JGIGJCGIKAB OOBAEENGOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private BELKPCBNDJB JIIFDKMGCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private CancellationTokenSource GOBCHHINCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private Task MFJLJPGENDB;

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x31CE3C0", Offset = "0x31CD1C0", VA = "0x1831CE3C0", Slot = "6")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x12656C0", Offset = "0x12644C0", VA = "0x1812656C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x31CDC50", Offset = "0x31CCA50", VA = "0x1831CDC50", Slot = "4")]
	[AsyncStateMachine(typeof(NIOLOKAEPFE))]
	public Task<CMMKJOOIFOH> HABPGOHNLLM(MBCPJOOJPCB MBHFGKKMFBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x31CD630", Offset = "0x31CC430", VA = "0x1831CD630", Slot = "5")]
	[AsyncStateMachine(typeof(PPBEHIFMPML))]
	public Task BLFOKAMEDNG([Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x12656C0", Offset = "0x12644C0", VA = "0x1812656C0")]
	public void DKNMAEPKKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x31CDA40", Offset = "0x31CC840", VA = "0x1831CDA40")]
	private FGCOKIPJJEI DMMJEOEKKAK(MBCPJOOJPCB MBHFGKKMFBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x31CE040", Offset = "0x31CCE40", VA = "0x1831CE040")]
	[AsyncStateMachine(typeof(JAGPEOHHPFP))]
	private Task LNLBGOHCGAC(PBFKGFFPEEN IDKOCJBGGJO, CancellationToken GHKIFNBJIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x31CE2A0", Offset = "0x31CD0A0", VA = "0x1831CE2A0")]
	[AsyncStateMachine(typeof(LLCNFLACLEI))]
	private Task MNHOJKPHJAE([Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x31CDF10", Offset = "0x31CCD10", VA = "0x1831CDF10")]
	[AsyncStateMachine(typeof(ODLOHGHPDNL))]
	private Task KFFHELDDJGF(TimeSpan COLELLDDDBO, CancellationToken GHKIFNBJIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x31CD750", Offset = "0x31CC550", VA = "0x1831CD750")]
	private Task CDEDAJGAIEI(BNJGMAOFPGO HIFGKEGLOMI, CancellationToken GHKIFNBJIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x31CE170", Offset = "0x31CCF70", VA = "0x1831CE170")]
	[AsyncStateMachine(typeof(FLNCBCOLOOH))]
	private Task MLDIGLDLBPG(BNJGMAOFPGO HIFGKEGLOMI, CancellationToken GHKIFNBJIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x31CDD90", Offset = "0x31CCB90", VA = "0x1831CDD90")]
	private bool IIEMJOOICOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public MGCJKPKOJEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[UnityEngine.Scripting.Preserve]
internal class EEOHFPIAJML : AKFILMIEMOH, BBGDLNNBMPO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct ODHHCKLLDOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public EEOHFPIAJML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private global::GKMALKFADNA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x31D4D00", Offset = "0x31D3B00", VA = "0x1831D4D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private HMCJICJEDFG BKBLGOGKJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private OHFKFMDHGAO GCJODOFFKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private NCHBIKKLAIG AOJLHJGFNKL;

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2879FF0", Offset = "0x2878DF0", VA = "0x182879FF0", Slot = "6")]
	public void PGIHAENGDGO(PPDJPHHFIJM PMENMHOEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2879E20", Offset = "0x2878C20", VA = "0x182879E20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2879E70", Offset = "0x2878C70", VA = "0x182879E70", Slot = "5")]
	[AsyncStateMachine(typeof(ODHHCKLLDOA))]
	public Task IBJEHMJHGGD(string DIHIPMILEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2879F90", Offset = "0x2878D90", VA = "0x182879F90", Slot = "4")]
	public CMMKJOOIFOH IIEMJOOICOI(ECDFOCMBGHG PAGIFHGDGPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2879CD0", Offset = "0x2878AD0", VA = "0x182879CD0")]
	private KLPEHKICGHL AJLGJLBBPBI(string DIHIPMILEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public EEOHFPIAJML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class EOKLMEDOCOC
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x287DB20", Offset = "0x287C920", VA = "0x18287DB20")]
	public static void BFPCKBNIBIC(GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x287DA00", Offset = "0x287C800", VA = "0x18287DA00")]
	internal static void APGGANKKCHP(GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x287E170", Offset = "0x287CF70", VA = "0x18287E170")]
	internal static void EFEOMIBDNGE(GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x287DD20", Offset = "0x287CB20", VA = "0x18287DD20")]
	internal static void BJEDLBOAHNC(GMLHNNIDAIC IPJNDIBMKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal class PPPAJIDPJCD : global::BOHKGGMKFDP<BNAMHEGAPHG>
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class CGGNNMDKNCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public BNAMHEGAPHG message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public CGGNNMDKNCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x39B3DF0", Offset = "0x39B2BF0", VA = "0x1839B3DF0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly PPPAJIDPJCD NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private const string JHAFOOFMPGE = "pl";

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x31DB2E0", Offset = "0x31DA0E0", VA = "0x1831DB2E0")]
	public ExitGames.Client.Photon.Hashtable EPOBOPBJBKM(BNAMHEGAPHG GPAOLHFLBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x31DB360", Offset = "0x31DA160", VA = "0x1831DB360", Slot = "5")]
	protected override void HGGBOBHFBCI(BNAMHEGAPHG GPAOLHFLBHD, IDictionary<object, object> MMJOHADFCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x31DAF50", Offset = "0x31D9D50", VA = "0x1831DAF50", Slot = "6")]
	public override BNAMHEGAPHG BPPOCFBLMGN(IDictionary<object, object> MMJOHADFCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x31DB150", Offset = "0x31D9F50", VA = "0x1831DB150")]
	private static void DBKHFPMEGAJ(string OJBHOMKBJHH, BNAMHEGAPHG GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x31DB520", Offset = "0x31DA320", VA = "0x1831DB520")]
	public PPPAJIDPJCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x31DAC70", Offset = "0x31D9A70", VA = "0x1831DAC70")]
	[CompilerGenerated]
	internal static string BEMLELPOBEO(HAMOGNLMBNC HIHKKNOLPAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class NMPJHCACOIO
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public static CMMKJOOIFOH CCDBMPIAAKD
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x31D2F20", Offset = "0x31D1D20", VA = "0x1831D2F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x31D2C30", Offset = "0x31D1A30", VA = "0x1831D2C30")]
	public static bool EGOBOOEICEE(this CMMKJOOIFOH OBCHIKIIOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x31D2C50", Offset = "0x31D1A50", VA = "0x1831D2C50")]
	public static CMMKJOOIFOH IMPPDPMKFPH(NHHCNMIONKA IIJAOKEIPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x31D2F80", Offset = "0x31D1D80", VA = "0x1831D2F80")]
	public static CMMKJOOIFOH MMLFDKDNCOG(params CMMKJOOIFOH[] OPPADPLKMIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x31D2F90", Offset = "0x31D1D90", VA = "0x1831D2F90")]
	public static CMMKJOOIFOH OLCKPGGAKNM(IEnumerable<CMMKJOOIFOH> OPPADPLKMIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x31D2CB0", Offset = "0x31D1AB0", VA = "0x1831D2CB0")]
	public static string JAHBNLGGKMA(this CMMKJOOIFOH AJCHMFJLMGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class HPOPKPLMCDF : KJOFHLEFNFJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public delegate CMMKJOOIFOH LLKMCKKOIPO([NotNull] ECDFOCMBGHG AMHALGEOEAP);

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class PDDPPPCCMNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public ECDFOCMBGHG photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PDDPPPCCMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A7DB20", Offset = "0x3A7C920", VA = "0x183A7DB20")]
		internal CMMKJOOIFOH <Validate>b__0(LLKMCKKOIPO v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	protected readonly HashSet<LLKMCKKOIPO> OIEBLIHDPFO;

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2884860", Offset = "0x2883660", VA = "0x182884860", Slot = "4")]
	public void OHJAPHPMHKI(LLKMCKKOIPO FMIECABLCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2884800", Offset = "0x2883600", VA = "0x182884800", Slot = "5")]
	public void MBHHLACGOLO(LLKMCKKOIPO FMIECABLCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2884590", Offset = "0x2883390", VA = "0x182884590", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x28845E0", Offset = "0x28833E0", VA = "0x1828845E0")]
	protected CMMKJOOIFOH FJAEIKLFADK(ECDFOCMBGHG AHBBAFEEDKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x28840A0", Offset = "0x2882EA0", VA = "0x1828840A0")]
	protected HPOPKPLMCDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public class HCOLFKIHGCJ : HPOPKPLMCDF, KPGHAKJHDEB, KJOFHLEFNFJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class JGNGJODLIAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public CMMKJOOIFOH result;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JGNGJODLIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A77D80", Offset = "0x3A76B80", VA = "0x183A77D80")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x28840A0", Offset = "0x2882EA0", VA = "0x1828840A0")]
	[UnityEngine.Scripting.Preserve]
	public HCOLFKIHGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2883F10", Offset = "0x2882D10", VA = "0x182883F10", Slot = "8")]
	public CMMKJOOIFOH JFGABFCLHOK(ECDFOCMBGHG AHBBAFEEDKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class PDNBFGIHDON : HPOPKPLMCDF, HMCJICJEDFG, KJOFHLEFNFJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class FFFEPAGFFMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public CMMKJOOIFOH result;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public FFFEPAGFFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x39B8490", Offset = "0x39B7290", VA = "0x1839B8490")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x31D96C0", Offset = "0x31D84C0", VA = "0x1831D96C0")]
	[UnityEngine.Scripting.Preserve]
	public PDNBFGIHDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x31D9530", Offset = "0x31D8330", VA = "0x1831D9530", Slot = "8")]
	public CMMKJOOIFOH IIEMJOOICOI(ECDFOCMBGHG FDHCKLIPOGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public enum OEDJGOCMIOE
{
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class KCCKCAEMDEO
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class GCNMLPNEFAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public GONOMPDEHOL finalTimerLogFlags;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public GCNMLPNEFAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x3A73F80", Offset = "0x3A72D80", VA = "0x183A73F80")]
		internal void <TimerScope>b__0(BMIMNEOCMDO t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class IHEBCIPAKPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public global::GKMALKFADNA<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public IHEBCIPAKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x3A76690", Offset = "0x3A75490", VA = "0x183A76690")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public const string BLPBCJIDKOG = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public const string GNPFNOHJAHC = "END: ";

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x288A530", Offset = "0x2889330", VA = "0x18288A530")]
	public static global::GKMALKFADNA<string> BGAJDKOFOJF([Optional] string NGJPKKLJDGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x288A6A0", Offset = "0x28894A0", VA = "0x18288A6A0")]
	public static global::GKMALKFADNA<string> BGAJDKOFOJF(GONOMPDEHOL EHAKLEGJPGC, [Optional] string NGJPKKLJDGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x288A980", Offset = "0x2889780", VA = "0x18288A980")]
	private static void IFPOKBBFCFI(string JHANOPJHOLP, HALPHLGMPIC NBINANLIAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x288A870", Offset = "0x2889670", VA = "0x18288A870")]
	private static void ICGAOLKNAHA(string JHANOPJHOLP, HALPHLGMPIC NBINANLIAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x288AA90", Offset = "0x2889890", VA = "0x18288AA90")]
	public static void LFLCMHKJPGF(global::GKMALKFADNA<string> NBINANLIAKB, GONOMPDEHOL CMDMNMJCLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x288A7B0", Offset = "0x28895B0", VA = "0x18288A7B0")]
	public static string CMLCPEFMPDP(BNAMHEGAPHG MEMGMBLNKEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal static class FFFFEBNEDCG
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x287FA30", Offset = "0x287E830", VA = "0x18287FA30")]
	public static void LDMKJPADKFE(this ADEJCHDMBNK PAOJHNGKONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x287FA20", Offset = "0x287E820", VA = "0x18287FA20")]
	public static void HJEOEMPDKCJ(this ADEJCHDMBNK PAOJHNGKONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x287F910", Offset = "0x287E710", VA = "0x18287F910")]
	private static void CMPPDCOAMKN(this ADEJCHDMBNK PAOJHNGKONI, bool ENAFCFHFILC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class EEFGOIEHHFP : GFGCLDPMDED, CBDHJILDHIP, MBMPIPGPDDJ, OPKPKCJDBNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private readonly CBDHJILDHIP EEOFJCMLNOK;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public ECDFOCMBGHG PAACCJIGOEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2879830", Offset = "0x2878630", VA = "0x182879830", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int KFJEOLEEDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2879AB0", Offset = "0x28788B0", VA = "0x182879AB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public int AMJAJFPDLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2879880", Offset = "0x2878680", VA = "0x182879880", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool MNDOHLGPHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int MDCDLEALGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x767C30", Offset = "0x766A30", VA = "0x180767C30", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event DLJDIJKODNL.GMEMDPKOEKA LLCBPPIPMON
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GAIOIIDEJOE HIIHJJPFKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2879970", Offset = "0x2878770", VA = "0x182879970", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2879BD0", Offset = "0x28789D0", VA = "0x182879BD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<bool> OLDOGDLHEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<ECDFOCMBGHG> PNLMCCJKCBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action JBFGPNEHDAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2879790", Offset = "0x2878590", VA = "0x182879790", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2879A10", Offset = "0x2878810", VA = "0x182879A10", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0xC9D230", Offset = "0xC9C030", VA = "0x180C9D230")]
	public EEFGOIEHHFP(CBDHJILDHIP EEOFJCMLNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2879B20", Offset = "0x2878920", VA = "0x182879B20", Slot = "8")]
	public bool KBJPMBEOGNN(byte PLFGLKLLFNF, ExitGames.Client.Photon.Hashtable JFNKHGDIIEM, OHJCMMIIADA IHGPCCMNLBJ, SendOptions FNBAAGLGPAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x28798D0", Offset = "0x28786D0", VA = "0x1828798D0", Slot = "29")]
	public ECDFOCMBGHG IFKNOGKAGPJ(int KCCMIIMCEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x28796B0", Offset = "0x28784B0", VA = "0x1828796B0", Slot = "16")]
	public ECDFOCMBGHG CLLNDGLEOPP(int BKNOAMJJOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "19")]
	public void COOODJECDEI(object AMBDKIOJFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "20")]
	public void KBIJMKJKOPO(object AMBDKIOJFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "21")]
	public void HIFIBMLACMD(object AMBDKIOJFBL, bool OHPEFNFODEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2879C70", Offset = "0x2878A70", VA = "0x182879C70", Slot = "22")]
	public IDisposable OMFGHEOBCFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "23")]
	private bool LNIEINALDIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "24")]
	public void KLGNEAAAOPM(StringBuilder EOCPHJGLPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2879B00", Offset = "0x2878900", VA = "0x182879B00", Slot = "25")]
	public bool JMHABEEFHPP(bool DLDBGNDCLIN, out string DOIPIGHENCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	public void HMNJAALBIOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x12C16E0", Offset = "0x12C04E0", VA = "0x1812C16E0", Slot = "28")]
	public void OJNAMOIOKAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal struct GHBGBFBHOGL
{
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public const string LOHLOOBLAAO = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public const string JPPBHNFJCFA = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private readonly IDictionary<object, object> CANNGAMIHEC;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool EMDPCLDELLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x967680", Offset = "0x966480", VA = "0x180967680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x918E40", Offset = "0x917C40", VA = "0x180918E40")]
	public GHBGBFBHOGL(IDictionary<object, object> CANNGAMIHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2881A20", Offset = "0x2880820", VA = "0x182881A20")]
	public bool DOEGCFIKPKO(out BNAMHEGAPHG GPAOLHFLBHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2881C40", Offset = "0x2880A40", VA = "0x182881C40")]
	public Guid LOBIJLCMPNE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2881AE0", Offset = "0x28808E0", VA = "0x182881AE0")]
	public CMMKJOOIFOH IDMNOHCJEHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2881930", Offset = "0x2880730", VA = "0x182881930")]
	public static ExitGames.Client.Photon.Hashtable CJALKNOJAHB(BNAMHEGAPHG GPAOLHFLBHD, CMMKJOOIFOH OBCHIKIIOEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class NAIIPLIKPCJ
{
	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x31D12D0", Offset = "0x31D00D0", VA = "0x1831D12D0")]
	public static string GLDNEDCGAAI(this OPEMBDFJMKA DFCLCBILPLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x31D1250", Offset = "0x31D0050", VA = "0x1831D1250")]
	public static bool DLNJBLNFJDD(this OPEMBDFJMKA DFCLCBILPLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal struct GBJNBIIMLLD : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct FALHNBEOEJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public GBJNBIIMLLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x3A73390", Offset = "0x3A72190", VA = "0x183A73390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly CancellationTokenSource BCHDMIKMMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private Task LEGNJFDJJMM;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool EMDPCLDELLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x2881710", Offset = "0x2880510", VA = "0x182881710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	internal Task HDBMMNLKBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x2881790", Offset = "0x2880590", VA = "0x182881790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2881810", Offset = "0x2880610", VA = "0x182881810")]
	public GBJNBIIMLLD(CancellationToken NBLKBHANAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x28815E0", Offset = "0x28803E0", VA = "0x1828815E0")]
	[AsyncStateMachine(typeof(FALHNBEOEJM))]
	public Task AEPNDCONBAM(Func<CancellationToken, List<Task>> APNIEPIMPLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2881740", Offset = "0x2880540", VA = "0x182881740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public readonly struct ICILLBMELBG<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct PLGFDCKEKPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public AsyncTaskMethodBuilder<global::AEGPCPFJGKN<global::JJEOKINGBLJ<TData>, MDPLBPNGKPK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public global::ICILLBMELBG<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private EHEFPJIJJBB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private TaskAwaiter<global::AEGPCPFJGKN<byte[], MDPLBPNGKPK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x2016760", Offset = "0x2015560", VA = "0x182016760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x1054F50", Offset = "0x1053D50", VA = "0x181054F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private readonly global::NDAPEJCMNIC<TGetDataArg, TData> DDAEJNDNJLK;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x918E40", Offset = "0x917C40", VA = "0x180918E40")]
	internal ICILLBMELBG(global::NDAPEJCMNIC<TGetDataArg, TData> HJHJNAMIAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1DFF9E0", Offset = "0x1DFE7E0", VA = "0x181DFF9E0")]
	[AsyncStateMachine(typeof(global::ICILLBMELBG<, >.PLGFDCKEKPD))]
	public Task<global::AEGPCPFJGKN<global::JJEOKINGBLJ<TData>, MDPLBPNGKPK>> ALMBPAAEHCM(TGetDataArg OHMLFHCAJEC, string FNODCILDBIC, EHEFPJIJJBB NBINANLIAKB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class JBABKHGCCPJ
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x23004A0", Offset = "0x22FF2A0", VA = "0x1823004A0")]
	public static global::ICILLBMELBG<TGetDataArg, TData> AIJMFKKLHCC<TGetDataArg, TData>(global::NDAPEJCMNIC<TGetDataArg, TData> HJHJNAMIAKE)
	{
		return default(global::ICILLBMELBG<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct PMELGNANPFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public readonly int PJJFNCNMLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public readonly int? IJBFPPJCIDJ;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2568730", Offset = "0x2567530", VA = "0x182568730")]
	public PMELGNANPFG(int DGBBJEKCCEK, [Optional] int? EBGFJNIINOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x31DA910", Offset = "0x31D9710", VA = "0x1831DA910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface FNHJJEIIAMD<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIBBLFFJPAP();

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::FNHJJEIIAMD<T> BIHKGOACHIN(string HCANNJFNPIO);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::FNHJJEIIAMD<T> GAABONMEBFN(global::JCNIHMNOEEI<T> AGEBGNGPIBC);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::FNHJJEIIAMD<T> AICCNDALOMP(int IBCAALMMGCM);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::FNHJJEIIAMD<T> HKDOKHAGGFF(int IBCAALMMGCM, int EBGFJNIINOJ);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::FNHJJEIIAMD<T> BIDPAPHCJOG(int IBCAALMMGCM, global::CCGICGDCOCM<T> PDMJNAHPBGH);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface EEDLOOFOHCJ
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::FNHJJEIIAMD<T> KONNLJPFOPF<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OKKELOKOMOB PNEIEGNKFFD(Exception ADJEGMMBDPA);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PMELGNANPFG LJGNGIKDCAA(Exception ADJEGMMBDPA);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<PMELGNANPFG> GEANPKDCNGI(Exception ADJEGMMBDPA);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string LNKODLMCBIL(Exception ADJEGMMBDPA);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public delegate string JCNIHMNOEEI<in T>(T ADJEGMMBDPA) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate int CCGICGDCOCM<in T>(T ADJEGMMBDPA) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class PCJCGLIHKHL : EEDLOOFOHCJ
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private delegate string ODJDFMGENCE(Exception ADJEGMMBDPA);

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate int FALBELJNHPB(Exception ADJEGMMBDPA);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private class NBIIIJCKAGC<T> : global::FNHJJEIIAMD<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class LLLGMMOCLDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
			public LLLGMMOCLDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
			internal string <WithErrorMessage>b__0(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class KFNOFMJGCOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AB040", Offset = "0x6AA440")]
			public global::JCNIHMNOEEI<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
			public KFNOFMJGCOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x23547C0", Offset = "0x23535C0", VA = "0x1823547C0")]
			internal string <WithErrorMessageBuilder>b__0(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class KBKKDOGFKJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public int subCode;

			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
			public KBKKDOGFKJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x740040", Offset = "0x73EE40", VA = "0x180740040")]
			internal int <WithErrorCodeAndSubCode>b__0(Exception _)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class BBHMJCDAEGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AB0A0", Offset = "0x6AA4A0")]
			public global::CCGICGDCOCM<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
			public BBHMJCDAEGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x23547C0", Offset = "0x23535C0", VA = "0x1823547C0")]
			internal int <WithErrorCodeBuilder>b__0(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private readonly PCJCGLIHKHL PEAAMKLINHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly Type BIOIDCHGFEM;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x31AB0E0", Offset = "0x31A9EE0", VA = "0x1831AB0E0")]
		internal NBIIIJCKAGC(PCJCGLIHKHL PEAAMKLINHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x31AAEA0", Offset = "0x31A9CA0", VA = "0x1831AAEA0", Slot = "4")]
		public void CIBBLFFJPAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x31AADA0", Offset = "0x31A9BA0", VA = "0x1831AADA0", Slot = "5")]
		public global::FNHJJEIIAMD<T> BIHKGOACHIN(string HCANNJFNPIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x31AAED0", Offset = "0x31A9CD0", VA = "0x1831AAED0", Slot = "6")]
		public global::FNHJJEIIAMD<T> GAABONMEBFN(global::JCNIHMNOEEI<T> AGEBGNGPIBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x31AAC40", Offset = "0x31A9A40", VA = "0x1831AAC40", Slot = "7")]
		public global::FNHJJEIIAMD<T> AICCNDALOMP(int IBCAALMMGCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x31AAFD0", Offset = "0x31A9DD0", VA = "0x1831AAFD0", Slot = "8")]
		public global::FNHJJEIIAMD<T> HKDOKHAGGFF(int IBCAALMMGCM, int EBGFJNIINOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x31AAC80", Offset = "0x31A9A80", VA = "0x1831AAC80", Slot = "9")]
		public global::FNHJJEIIAMD<T> BIDPAPHCJOG(int IBCAALMMGCM, global::CCGICGDCOCM<T> PDMJNAHPBGH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class PNHDLNECNBB<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private bool LNEJBMHELBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private readonly List<Type> PDPJAOFCNAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private readonly Dictionary<Type, TVal> MIPMPMPNMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private readonly Dictionary<Type, int> KMJFFIEBCJA;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public IReadOnlyList<Type> JNGCHEAIAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x39A2A70", Offset = "0x39A1870", VA = "0x1839A2A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x39A2E50", Offset = "0x39A1C50", VA = "0x1839A2E50")]
		public PNHDLNECNBB(Dictionary<Type, int> KMJFFIEBCJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x39A2BF0", Offset = "0x39A19F0", VA = "0x1839A2BF0")]
		public void OEECIDDHIAM(Type JHANOPJHOLP, TVal MMAFFACGBGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x39A2A40", Offset = "0x39A1840", VA = "0x1839A2A40")]
		public bool EJNKOOJFENG(Type BIOIDCHGFEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x39A2D30", Offset = "0x39A1B30", VA = "0x1839A2D30")]
		public bool PDKOIMMPCFM(TVal MGFMONLLLPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x31B0AC0", Offset = "0x31AF8C0", VA = "0x1831B0AC0")]
		public TVal BANNGLOAJDI(Type LEDIIMFEFLP)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x39A29A0", Offset = "0x39A17A0", VA = "0x1839A29A0")]
		[CompilerGenerated]
		private int BOKAHFPMOAH(Type AOKFKNLGNOK, Type MIHHENBGNOK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class ILCAPHPIAFM : IEnumerable<PMELGNANPFG>, IEnumerable, IEnumerator<PMELGNANPFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private PMELGNANPFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public PCJCGLIHKHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private IEnumerator<PMELGNANPFG> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		private PMELGNANPFG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x2755630", Offset = "0x2754430", VA = "0x182755630", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PMELGNANPFG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x39BB470", Offset = "0x39BA270", VA = "0x1839BB470", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
		[DebuggerHidden]
		public ILCAPHPIAFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x39BB4C0", Offset = "0x39BA2C0", VA = "0x1839BB4C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x39BAFB0", Offset = "0x39B9DB0", VA = "0x1839BAFB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x39BB590", Offset = "0x39BA390", VA = "0x1839BB590")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x39BB5E0", Offset = "0x39BA3E0", VA = "0x1839BB5E0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x39BB430", Offset = "0x39BA230", VA = "0x1839BB430", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x39BB380", Offset = "0x39BA180", VA = "0x1839BB380", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PMELGNANPFG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x39BB380", Offset = "0x39BA180", VA = "0x1839BB380", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	internal const int BOENGJIPOCE = 8700;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private static readonly PMELGNANPFG NLLIDOKEFBM;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	internal const string LIABPAGDAJA = "Unknown error loading room";

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	internal const int PBALOGCNCLP = 8708;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private static readonly Dictionary<Type, int> GHPICPHIICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly HashSet<Type> NEJLCOCIFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private readonly PNHDLNECNBB<int> FEEOMEDCMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private readonly PNHDLNECNBB<FALBELJNHPB> MKGEDMIBJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private readonly PNHDLNECNBB<ODJDFMGENCE> GOOOJBKNAAI;

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x31D8860", Offset = "0x31D7660", VA = "0x1831D8860")]
	[CFDOMFEMHNO(ANAFFCEINAM.GameOnly)]
	private static void HGNLLPENNMP(GMLHNNIDAIC LNJPAOGJIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x31D91B0", Offset = "0x31D7FB0", VA = "0x1831D91B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PCJCGLIHKHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x22B4780", Offset = "0x22B3580", VA = "0x1822B4780", Slot = "4")]
	public global::FNHJJEIIAMD<T> KONNLJPFOPF<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x31D9070", Offset = "0x31D7E70", VA = "0x1831D9070", Slot = "5")]
	public OKKELOKOMOB PNEIEGNKFFD(Exception ADJEGMMBDPA)
	{
		return default(OKKELOKOMOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x31D8D00", Offset = "0x31D7B00", VA = "0x1831D8D00", Slot = "6")]
	public PMELGNANPFG LJGNGIKDCAA(Exception? ADJEGMMBDPA)
	{
		return default(PMELGNANPFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x31D8630", Offset = "0x31D7430", VA = "0x1831D8630", Slot = "7")]
	[IteratorStateMachine(typeof(ILCAPHPIAFM))]
	public IEnumerable<PMELGNANPFG> GEANPKDCNGI(Exception ADJEGMMBDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x31D8F20", Offset = "0x31D7D20", VA = "0x1831D8F20", Slot = "8")]
	public string LNKODLMCBIL(Exception? ADJEGMMBDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x31D82D0", Offset = "0x31D70D0", VA = "0x1831D82D0")]
	private string DPBFDBNMCDB(AggregateException JGJLFDAPLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x31D7F30", Offset = "0x31D6D30", VA = "0x1831D7F30")]
	private void CBHEDHAJHFB(Type BIOIDCHGFEM, int IBCAALMMGCM, FALBELJNHPB? NFDFKMHIJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x31D7CF0", Offset = "0x31D6AF0", VA = "0x1831D7CF0")]
	private void ANMJEHJFMCP(Type BIOIDCHGFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x31D8A40", Offset = "0x31D7840", VA = "0x1831D8A40")]
	private void LGIMLABOLJL(Type BIOIDCHGFEM, ODJDFMGENCE INGCPCOPCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x31D86C0", Offset = "0x31D74C0", VA = "0x1831D86C0")]
	private static int GLDBMDELPFF(Type BIOIDCHGFEM, Dictionary<Type, int> KMJFFIEBCJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x27E2450", Offset = "0x27E1250", VA = "0x1827E2450")]
	private static bool PIOCCFFKPCD<TVal>(PNHDLNECNBB<TVal> HEJNPPKNAND, Type BIOIDCHGFEM, out TVal MGFMONLLLPD) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x31D8950", Offset = "0x31D7750", VA = "0x1831D8950")]
	[CompilerGenerated]
	internal static int IOMPFCCDDBK(Type HLDMEMMANHM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct OKKELOKOMOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public readonly PMELGNANPFG ENIEAJDHNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public readonly string FNFOMMBCLHH;

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x31D7640", Offset = "0x31D6440", VA = "0x1831D7640")]
	public OKKELOKOMOB(string NAFFLKLHFIG, PMELGNANPFG IBCAALMMGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x31D75C0", Offset = "0x31D63C0", VA = "0x1831D75C0")]
	public string PHDIDCPKNLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x31D7520", Offset = "0x31D6320", VA = "0x1831D7520")]
	public string FPDLFDCEAGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class ODKLBOIFAHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly BBALOPFJECE DCIHABDMDLK;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private const string ENEEPOBJKEI = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private const string GLJPLMDBPJL = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private const string DNOFAHAANKB = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private const string ONHCFLOLBFD = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private const string BDMAELIJBDD = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private string NFNOKBCANGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private long? BPCCCEGFNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private long? IELCECHMJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private MNNIDFIIFAP NAJLNGOHMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private long? DMHIEAJHNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private bool NLJJFKIEGOI;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string BDBFBDICOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long FIHFOGPBCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x31D5830", Offset = "0x31D4630", VA = "0x1831D5830")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public long DCKKCDFPLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x31D57D0", Offset = "0x31D45D0", VA = "0x1831D57D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public MNNIDFIIFAP KENOBLJJBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x78E900", Offset = "0x78D700", VA = "0x18078E900")]
		get
		{
			return default(MNNIDFIIFAP);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x31D55F0", Offset = "0x31D43F0", VA = "0x1831D55F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public long DMGFPHIKGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x31D5030", Offset = "0x31D3E30", VA = "0x1831D5030")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x31D5B80", Offset = "0x31D4980", VA = "0x1831D5B80")]
	[UnityEngine.Scripting.Preserve]
	public ODKLBOIFAHG([HDMGOABMPFL(null)] BBALOPFJECE DCIHABDMDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x31D5090", Offset = "0x31D3E90", VA = "0x1831D5090")]
	private void BLLNJJMFPDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x31D5240", Offset = "0x31D4040", VA = "0x1831D5240")]
	public void CKCAIOMAKAD(long GJDNMGJBIPD, long HIIJPNGKPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x31D56E0", Offset = "0x31D44E0", VA = "0x1831D56E0")]
	public void IAABKCKLHPB(string NLMBJOCJJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x31D5890", Offset = "0x31D4690", VA = "0x1831D5890")]
	public void NHEKEEKKLGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class MHCLGBNNENN : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct EODOALGNFPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public AsyncTaskMethodBuilder<BNAMHEGAPHG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public BNAMHEGAPHG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public MHCLGBNNENN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private EHEFPJIJJBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private TaskAwaiter<ABONJODNNPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x39B7560", Offset = "0x39B6360", VA = "0x1839B7560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x39B7870", Offset = "0x39B6670", VA = "0x1839B7870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct EJFOEDAPFNF<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class HEGFLIDIKOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public BNAMHEGAPHG roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public HEGFLIDIKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x39BA5D0", Offset = "0x39B93D0", VA = "0x1839BA5D0")]
		internal BNAMHEGAPHG <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct BBNJOFPGLCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public AsyncTaskMethodBuilder<ABONJODNNPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public BNAMHEGAPHG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public MHCLGBNNENN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private CECNJAKHHDF <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private TaskAwaiter<ABONJODNNPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x39B34C0", Offset = "0x39B22C0", VA = "0x1839B34C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x39B3CB0", Offset = "0x39B2AB0", VA = "0x1839B3CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct LJOIAHBHKBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public MHCLGBNNENN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x39BEBA0", Offset = "0x39BD9A0", VA = "0x1839BEBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class JKAKAAAHDPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JKAKAAAHDPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x39BC620", Offset = "0x39BB420", VA = "0x1839BC620")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class FMLGOIHAFJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public FMLGOIHAFJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x39B8980", Offset = "0x39B7780", VA = "0x1839B8980")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class ENOIMFBHPJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ENOIMFBHPJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x39B7020", Offset = "0x39B5E20", VA = "0x1839B7020")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class CCDFDENIOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public CCDFDENIOLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x39B3D80", Offset = "0x39B2B80", VA = "0x1839B3D80")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class ILMIAIHCDGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public MHCLGBNNENN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ILMIAIHCDGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x39BB630", Offset = "0x39BA430", VA = "0x1839BB630")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class PCIKOENOANE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public MHCLGBNNENN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PCIKOENOANE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x39C3610", Offset = "0x39C2410", VA = "0x1839C3610")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private static readonly Guid LJGPJCIEGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public readonly FGOMEABCFHE KFFFMMOJAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private readonly NKGAPBOHOGB IAPECBCLCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private readonly MBMPIPGPDDJ PAOJHNGKONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private readonly OPKPKCJDBNM EGNGADKKHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private bool IDHAPJGGLMI;

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x31CFD80", Offset = "0x31CEB80", VA = "0x1831CFD80")]
	public MHCLGBNNENN(FGOMEABCFHE DMPEOFAJLOH, NKGAPBOHOGB IAPECBCLCOE, MBMPIPGPDDJ PAOJHNGKONI, OPKPKCJDBNM EGNGADKKHEK, EHEFPJIJJBB LKDPBPGJFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x31CEAC0", Offset = "0x31CD8C0", VA = "0x1831CEAC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x31CEAC0", Offset = "0x31CD8C0", VA = "0x1831CEAC0")]
	public void FCJMEFMCHIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x31CF000", Offset = "0x31CDE00", VA = "0x1831CF000")]
	public void HNDHPAGMMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x31CF160", Offset = "0x31CDF60", VA = "0x1831CF160")]
	public void IOAFEJBMLBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x31CEDF0", Offset = "0x31CDBF0", VA = "0x1831CEDF0")]
	[AsyncStateMachine(typeof(EODOALGNFPD))]
	internal Task<BNAMHEGAPHG> GEHEHJEHFME(EHEFPJIJJBB LKDPBPGJFDJ, BNAMHEGAPHG MEMGMBLNKEC, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2508700", Offset = "0x2507500", VA = "0x182508700")]
	private static byte[] MLNMDIJCNLL<T>(T GPAOLHFLBHD) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2508240", Offset = "0x2507040", VA = "0x182508240")]
	private static T HLLOMOBIJNB<T>(MessageParser<T> BOALGNIKNHC, byte[] GPAOLHFLBHD, T IIEJCKFDDHI) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x31CF2C0", Offset = "0x31CE0C0", VA = "0x1831CF2C0")]
	[AsyncStateMachine(typeof(BBNJOFPGLCK))]
	private Task<ABONJODNNPD> KBPFCNAKELP(BNAMHEGAPHG MEMGMBLNKEC, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2507FF0", Offset = "0x2506DF0", VA = "0x182507FF0")]
	[AsyncStateMachine(typeof(BMKMJNEMGMF))]
	internal Task<T> EPNGENDBLPG<T>(CancellationToken GHKIFNBJIOP, Func<CancellationToken, Task<T>> ANMGJKBPNPM, int JEBIEDLHFND = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x31CEC70", Offset = "0x31CDA70", VA = "0x1831CEC70")]
	[AsyncStateMachine(typeof(LJOIAHBHKBE))]
	internal Task EPNGENDBLPG(CancellationToken GHKIFNBJIOP, Func<CancellationToken, Task> ANMGJKBPNPM, int JEBIEDLHFND = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x31CEF70", Offset = "0x31CDD70", VA = "0x1831CEF70")]
	public BNAMHEGAPHG GHAECIJFLGE(CECNJAKHHDF BPKFMEPDEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x31CE5E0", Offset = "0x31CD3E0", VA = "0x1831CE5E0")]
	public HCHFGCGNNOO ALJNBNLBLFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x31CF8F0", Offset = "0x31CE6F0", VA = "0x1831CF8F0")]
	public KHICHIDOBBB OEBLBEHDNIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x31CE6A0", Offset = "0x31CD4A0", VA = "0x1831CE6A0")]
	public DPMNHEEECCA CKLIEECNPBO([Optional] GONOMPDEHOL? CMDMNMJCLCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x31CEDC0", Offset = "0x31CDBC0", VA = "0x1831CEDC0")]
	public void FNLPPIKJBND(Func<Guid, bool> GCFKLPPHEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x31CF710", Offset = "0x31CE510", VA = "0x1831CF710")]
	public void MELBFJFIIEL(Func<Guid, bool> POANIJJJHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x31CF960", Offset = "0x31CE760", VA = "0x1831CF960")]
	public void PDLJDBOPOEI(Func<Guid, bool> GCFKLPPHEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x31CFB00", Offset = "0x31CE900", VA = "0x1831CFB00")]
	public Guid PEFIJCKCIPC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x31CF570", Offset = "0x31CE370", VA = "0x1831CF570")]
	public void LIMLLJKFAKN(Guid GHAMPAIMANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x31CF420", Offset = "0x31CE220", VA = "0x1831CF420")]
	public void LFEJBCNOFGE(BNAMHEGAPHG MEIOHDHFJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x31CE930", Offset = "0x31CD730", VA = "0x1831CE930")]
	public void DBKHFPMEGAJ(string HIINDHMNMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x31CE7A0", Offset = "0x31CD5A0", VA = "0x1831CE7A0")]
	public void DBKHFPMEGAJ(Func<string> LAJMGPABMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2508160", Offset = "0x2506F60", VA = "0x182508160")]
	private T HBPFDOAGBIK<T>(T MGFMONLLLPD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x31CE650", Offset = "0x31CD450", VA = "0x1831CE650")]
	public void AMHJFOENHMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x25083F0", Offset = "0x25071F0", VA = "0x1825083F0")]
	[CompilerGenerated]
	internal static string IKOOIJPEOPI<T>(byte[] EMGPHLLIACG, int FNPFDGJMNLD, ref EJFOEDAPFNF<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal sealed class OGEEMHOLCCJ : FGOMEABCFHE
{
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class FLOEKKEHDJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public FLOEKKEHDJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x39B8910", Offset = "0x39B7710", VA = "0x1839B8910")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct IIBKPLGMDCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public OGEEMHOLCCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public MHCLGBNNENN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private KHICHIDOBBB <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x39BAB70", Offset = "0x39B9970", VA = "0x1839BAB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class NFMFDGGNMOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public MGJOBLLJJHL presence;

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public NFMFDGGNMOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x39C1B60", Offset = "0x39C0960", VA = "0x1839C1B60")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly HAMOGNLMBNC HCBDEGKCKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private readonly OPEMBDFJMKA CCBKDGCANFI;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private const bool LMBAGEGOBBE = false;

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x31D6730", Offset = "0x31D5530", VA = "0x1831D6730")]
	public OGEEMHOLCCJ(HAMOGNLMBNC HCBDEGKCKLC, OPEMBDFJMKA CCBKDGCANFI, Guid HBBMBELBIND, PPDJPHHFIJM PMENMHOEOKK, PKHONFCPCPD PLFFAJKMIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x31D65E0", Offset = "0x31D53E0", VA = "0x1831D65E0", Slot = "8")]
	[AsyncStateMachine(typeof(IIBKPLGMDCN))]
	protected override Task MNHADCLDPDL(MHCLGBNNENN OMGKKPHIJBG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x31D61F0", Offset = "0x31D4FF0", VA = "0x1831D61F0")]
	private MGJOBLLJJHL EIIIDCEMBFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class FGCOKIPJJEI : FGOMEABCFHE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct FMBCMONHFEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public FGCOKIPJJEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public MHCLGBNNENN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private EHEFPJIJJBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private TaskAwaiter<LAHOMKBPNPM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x31C48F0", Offset = "0x31C36F0", VA = "0x1831C48F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private readonly int PBFIDJFEFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private readonly MBCPJOOJPCB JCPDIHAGMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public readonly long DODLBPPBFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public readonly long LLDDFFOECAG;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public LAHOMKBPNPM CEPIGIIDKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x7483B0", Offset = "0x7471B0", VA = "0x1807483B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x94CF40", Offset = "0x94BD40", VA = "0x18094CF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x2880340", Offset = "0x287F140", VA = "0x182880340")]
	public FGCOKIPJJEI(Guid HBBMBELBIND, PPDJPHHFIJM PMENMHOEOKK, PKHONFCPCPD PLFFAJKMIKE, int PBFIDJFEFHF, MBCPJOOJPCB JCPDIHAGMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x2880200", Offset = "0x287F000", VA = "0x182880200", Slot = "8")]
	[AsyncStateMachine(typeof(FMBCMONHFEJ))]
	protected override Task MNHADCLDPDL(MHCLGBNNENN OMGKKPHIJBG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal abstract class KMFHKIPODMN : FGOMEABCFHE
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class EEAAFFCHCDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public KMFHKIPODMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public PIHHNFJBCGL playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public EEAAFFCHCDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x39B6AA0", Offset = "0x39B58A0", VA = "0x1839B6AA0")]
		internal Task <RunAsync>b__0(EHEFPJIJJBB postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x39B6AE0", Offset = "0x39B58E0", VA = "0x1839B6AE0")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct CJMIIIHCMFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public KMFHKIPODMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public MHCLGBNNENN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private EEAAFFCHCDB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x39B4B00", Offset = "0x39B3900", VA = "0x1839B4B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct ENGMLHKMKKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public PIHHNFJBCGL playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public KMFHKIPODMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EHEFPJIJJBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x39B6B60", Offset = "0x39B5960", VA = "0x1839B6B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2891E60", Offset = "0x2890C60", VA = "0x182891E60")]
	public KMFHKIPODMN(Guid HBBMBELBIND, PPDJPHHFIJM PMENMHOEOKK, PKHONFCPCPD PLFFAJKMIKE, string KLHPGAJLAAC, GMLFIIMGPAI GGEJDEFAICK, bool MHIOGFNACCP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2891D10", Offset = "0x2890B10", VA = "0x182891D10", Slot = "8")]
	[AsyncStateMachine(typeof(CJMIIIHCMFC))]
	protected override Task MNHADCLDPDL(MHCLGBNNENN OMGKKPHIJBG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task MABOEDEKANL(MHCLGBNNENN OMGKKPHIJBG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x2891BB0", Offset = "0x28909B0", VA = "0x182891BB0")]
	[AsyncStateMachine(typeof(ENGMLHKMKKB))]
	private Task CJDKILJCBAE(IDisposable ALNELMEEAEL, PIHHNFJBCGL IAPFAHEEBME, EHEFPJIJJBB NBINANLIAKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class FJMFAMFOBIA : FGOMEABCFHE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct EKKGPIJDFAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public FJMFAMFOBIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public MHCLGBNNENN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private TaskAwaiter<IENJOFGBOJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x3A70780", Offset = "0x3A6F580", VA = "0x183A70780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private readonly BNJGMAOFPGO HIFGKEGLOMI;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x2881540", Offset = "0x2880340", VA = "0x182881540")]
	public FJMFAMFOBIA(Guid HBBMBELBIND, PPDJPHHFIJM PMENMHOEOKK, PKHONFCPCPD PLFFAJKMIKE, BNJGMAOFPGO HIFGKEGLOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x2881320", Offset = "0x2880120", VA = "0x182881320", Slot = "7")]
	protected override string DDHEPKCOGJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2881400", Offset = "0x2880200", VA = "0x182881400", Slot = "8")]
	[AsyncStateMachine(typeof(EKKGPIJDFAL))]
	protected override Task MNHADCLDPDL(MHCLGBNNENN OMGKKPHIJBG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class FGOMEABCFHE : LMOCEHOAJIL
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public delegate Task GOJDNKFFFBI(EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class JDKEOGPADHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public EHEFPJIJJBB operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public FGOMEABCFHE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JDKEOGPADHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x3A77540", Offset = "0x3A76340", VA = "0x183A77540")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class EFPPJGKBPOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public JDKEOGPADHJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public EFPPJGKBPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A70080", Offset = "0x3A6EE80", VA = "0x183A70080")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A70140", Offset = "0x3A6EF40", VA = "0x183A70140")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct BEGLFIEGHDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public FGOMEABCFHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public Func<FGOMEABCFHE, EHEFPJIJJBB, MHCLGBNNENN> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private JDKEOGPADHJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private MHCLGBNNENN <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private TaskAwaiter<BNAMHEGAPHG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x3A6B650", Offset = "0x3A6A450", VA = "0x183A6B650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct PBIPMNCBIOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public FGOMEABCFHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A7D890", Offset = "0x3A7C690", VA = "0x183A7D890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public readonly Guid FPNGEBBIFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public readonly ByteString OCBNAMDGFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public readonly PKHONFCPCPD KHDKBBLBPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	protected readonly string KDBJJFJBHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private readonly PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000395")]
	private readonly bool MHIOGFNACCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private readonly Queue<GOJDNKFFFBI> KDGKNPGAMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	private readonly PGCPDGBOHJA BGFOIBJLPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	private readonly GMLFIIMGPAI GGEJDEFAICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private bool MJCFCJNEBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public MNNIDFIIFAP CHOCDFDBKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public MNNIDFIIFAP ENFFNMMOLCN;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public PPDJPHHFIJM CHNGMAGIGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x748BA0", Offset = "0x7479A0", VA = "0x180748BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public ANDGFCHCEHL DFBAGBDEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x2880990", Offset = "0x287F790", VA = "0x182880990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public FIBHEMFOEOC DHOEJBIMPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x2880B60", Offset = "0x287F960", VA = "0x182880B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public PHGCHEAKDPI KDMNNHJCNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x2880EA0", Offset = "0x287FCA0", VA = "0x182880EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public float NNMDGEJCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x28811C0", Offset = "0x287FFC0", VA = "0x1828811C0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event NEKACKKACMG ODMDLNBIEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x2880D00", Offset = "0x287FB00", VA = "0x182880D00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x2880970", Offset = "0x287F770", VA = "0x182880970", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x28811E0", Offset = "0x287FFE0", VA = "0x1828811E0")]
	protected FGOMEABCFHE(Guid HBBMBELBIND, PPDJPHHFIJM PMENMHOEOKK, PKHONFCPCPD PLFFAJKMIKE, string KLHPGAJLAAC, GMLFIIMGPAI GGEJDEFAICK, bool MHIOGFNACCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x28809E0", Offset = "0x287F7E0", VA = "0x1828809E0", Slot = "7")]
	protected virtual string DDHEPKCOGJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x2880910", Offset = "0x287F710", VA = "0x182880910")]
	public void AJDIDJHBLLM(GOJDNKFFFBI CFPAOIHJDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x2880D20", Offset = "0x287FB20", VA = "0x182880D20")]
	protected void EMMPMCIFKBN(float NDFOGNBCBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x2880BB0", Offset = "0x287F9B0", VA = "0x182880BB0")]
	[AsyncStateMachine(typeof(BEGLFIEGHDF))]
	public Task ECBHNDAKKOH(CancellationToken NBLKBHANAPP, EHEFPJIJJBB LKDPBPGJFDJ, [Optional] Func<FGOMEABCFHE, EHEFPJIJJBB, MHCLGBNNENN> IKOIBJHDEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2880F20", Offset = "0x287FD20", VA = "0x182880F20")]
	private void NLBGCJIMIEG(bool BLMJMLDJNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x28810B0", Offset = "0x287FEB0", VA = "0x1828810B0")]
	private void OGFBAFKLAHP(MHCLGBNNENN OMGKKPHIJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task MNHADCLDPDL(MHCLGBNNENN OMGKKPHIJBG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x2880A20", Offset = "0x287F820", VA = "0x182880A20")]
	[AsyncStateMachine(typeof(PBIPMNCBIOD))]
	private Task DJDHEEBGBEJ(EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2880E20", Offset = "0x287FC20", VA = "0x182880E20")]
	public BNAMHEGAPHG GHAECIJFLGE(CECNJAKHHDF BPKFMEPDEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x2880D40", Offset = "0x287FB40", VA = "0x182880D40")]
	[CompilerGenerated]
	private Task FLCICLKJDMM(CancellationToken DJCNOMGFLPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal sealed class EODGBDIMKHI : KMFHKIPODMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct HOAOMIBIPPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public EODGBDIMKHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public MHCLGBNNENN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private MCEKIAOMMJF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private KHICHIDOBBB <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x31C6660", Offset = "0x31C5460", VA = "0x1831C6660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly HAMOGNLMBNC JAEOOBJGIMP;

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x287CD50", Offset = "0x287BB50", VA = "0x18287CD50")]
	public EODGBDIMKHI(Guid HBBMBELBIND, PPDJPHHFIJM PMENMHOEOKK, HAMOGNLMBNC JAEOOBJGIMP, PKHONFCPCPD PLFFAJKMIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x287CC00", Offset = "0x287BA00", VA = "0x18287CC00", Slot = "9")]
	[AsyncStateMachine(typeof(HOAOMIBIPPB))]
	protected override Task MABOEDEKANL(MHCLGBNNENN OMGKKPHIJBG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal class KLPEHKICGHL : FGOMEABCFHE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct CHMPJLGHHBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public KLPEHKICGHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public MHCLGBNNENN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter<IENJOFGBOJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x39B47E0", Offset = "0x39B35E0", VA = "0x1839B47E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	private readonly string DGNEBPIKCDO;

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x2891B00", Offset = "0x2890900", VA = "0x182891B00")]
	public KLPEHKICGHL(Guid HBBMBELBIND, PPDJPHHFIJM PMENMHOEOKK, PKHONFCPCPD PLFFAJKMIKE, string DGNEBPIKCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x28919D0", Offset = "0x28907D0", VA = "0x1828919D0", Slot = "8")]
	[AsyncStateMachine(typeof(CHMPJLGHHBO))]
	protected override Task MNHADCLDPDL(MHCLGBNNENN OMGKKPHIJBG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class LDGCKPGLGJG : KMFHKIPODMN
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class CMKJHBCHNPK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public AsyncTaskMethodBuilder<BNAMHEGAPHG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public CMKJHBCHNPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			private TaskAwaiter<IENJOFGBOJJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AB5B0", Offset = "0x6AA9B0")]
			private TaskAwaiter<BNAMHEGAPHG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4F50", Offset = "0x6AD3D50", VA = "0x186AD4F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x6AD52A0", Offset = "0x6AD40A0", VA = "0x186AD52A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public LDGCKPGLGJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public DPMNHEEECCA serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public HCHFGCGNNOO uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public MDPJPGJEHCC roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public CMKJHBCHNPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x39B5DB0", Offset = "0x39B4BB0", VA = "0x1839B5DB0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<BNAMHEGAPHG> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct EOLKFACINGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public LDGCKPGLGJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public MHCLGBNNENN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private CMKJHBCHNPK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private MCEKIAOMMJF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private KHICHIDOBBB <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private TaskAwaiter<BNAMHEGAPHG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x39B78C0", Offset = "0x39B66C0", VA = "0x1839B78C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly int AJMHEOJBMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	[CanBeNull]
	private readonly CGKIAAJADJO NIIJACDKHBG;

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2892490", Offset = "0x2891290", VA = "0x182892490")]
	public LDGCKPGLGJG(Guid HBBMBELBIND, PPDJPHHFIJM PMENMHOEOKK, int AJMHEOJBMOO, CGKIAAJADJO NIIJACDKHBG, PKHONFCPCPD PLFFAJKMIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x2892330", Offset = "0x2891130", VA = "0x182892330", Slot = "9")]
	[AsyncStateMachine(typeof(EOLKFACINGG))]
	protected override Task MABOEDEKANL(MHCLGBNNENN OMGKKPHIJBG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2892210", Offset = "0x2891010", VA = "0x182892210")]
	private void JOBOFKMCLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x2892070", Offset = "0x2890E70", VA = "0x182892070")]
	private void HFPHGGELMNG(EHEFPJIJJBB LKDPBPGJFDJ, MCEKIAOMMJF LIBNHJGGHLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal abstract class NBFGBADGPEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public readonly FGOMEABCFHE KFFFMMOJAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public readonly MHCLGBNNENN NGJHOGAHGOO;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public ANDGFCHCEHL DFBAGBDEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x31D1520", Offset = "0x31D0320", VA = "0x1831D1520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public PHGCHEAKDPI KDMNNHJCNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x31D1700", Offset = "0x31D0500", VA = "0x1831D1700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x31D1760", Offset = "0x31D0560", VA = "0x1831D1760")]
	protected NBFGBADGPEF(MHCLGBNNENN OMGKKPHIJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x31D1540", Offset = "0x31D0340", VA = "0x1831D1540")]
	protected void DBKHFPMEGAJ(string HIINDHMNMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x31D1560", Offset = "0x31D0360", VA = "0x1831D1560")]
	public void DBKHFPMEGAJ(Func<string> LAJMGPABMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct PIBFJEHBDEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public Dictionary<Guid, List<OLAAHHNGKFM>> LPPKJGHHJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public Dictionary<Guid, List<OLAAHHNGKFM>> LDEKJNDHIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public Dictionary<Guid, List<OLAAHHNGKFM>> NLHHHEDGHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public List<Guid> DDKKNBALLBK;

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x31D9780", Offset = "0x31D8580", VA = "0x1831D9780")]
	public static PIBFJEHBDEG BANNGLOAJDI(ANDGFCHCEHL BGEMPOFCNMN, MNNIDFIIFAP IDCCOFECHBB, PBFKGFFPEEN LKPCOGIAENK)
	{
		return default(PIBFJEHBDEG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct AOEADLGBKHP
{
	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330")]
	public static AOEADLGBKHP CJALKNOJAHB()
	{
		return default(AOEADLGBKHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void IGJNLHKKIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void HJFLCILFGEJ(PBFKGFFPEEN MMJOHADFCHO, object EKODLDGKCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void HLDLNEDOKLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal struct KGDGMJJPKIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public readonly PGKHPCCBDIC ENCIGLKNHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public readonly DDJMGGCCABD KGKNCCKOLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public readonly string APGKPINBDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public readonly JBPGEGNDOLF ACGOFPFCLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public readonly JBPGEGNDOLF NLBPGLPMHJA;

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x288ABD0", Offset = "0x28899D0", VA = "0x18288ABD0")]
	public KGDGMJJPKIG(PGKHPCCBDIC ENCIGLKNHFJ, DDJMGGCCABD KGKNCCKOLNO, string APGKPINBDMG, JBPGEGNDOLF ACGOFPFCLOD, JBPGEGNDOLF NLBPGLPMHJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct LALNADNGBBG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private readonly MHCLGBNNENN OMGKKPHIJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	private readonly Guid GHAMPAIMANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	private bool BLMJMLDJNFF;

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2891FC0", Offset = "0x2890DC0", VA = "0x182891FC0")]
	public static LALNADNGBBG PEFIJCKCIPC(MHCLGBNNENN OMGKKPHIJBG)
	{
		return default(LALNADNGBBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x19FB470", Offset = "0x19FA270", VA = "0x1819FB470")]
	public void OAFIFHBKKOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2891F60", Offset = "0x2890D60", VA = "0x182891F60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2892020", Offset = "0x2890E20", VA = "0x182892020")]
	private LALNADNGBBG(MHCLGBNNENN OMGKKPHIJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2891F60", Offset = "0x2890D60", VA = "0x182891F60")]
	private void LIMLLJKFAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2891EB0", Offset = "0x2890CB0", VA = "0x182891EB0")]
	private Func<Guid, bool> DBCFFCDOCEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class KHICHIDOBBB : NBFGBADGPEF, LMOCEHOAJIL
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	public delegate Task<MNNIDFIIFAP> JMEMIEFAOML(PBFKGFFPEEN MMJOHADFCHO, BMBKGOBPDMA EAHPMCPNCCG, PGCPDGBOHJA HDJGHOJJGDB, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct KDEGBICOIPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public HAMOGNLMBNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private LALNADNGBBG <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private TaskAwaiter<BNAMHEGAPHG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x3A783B0", Offset = "0x3A771B0", VA = "0x183A783B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct LDEBCINGELN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public AsyncTaskMethodBuilder<BNAMHEGAPHG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public HAMOGNLMBNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private EHEFPJIJJBB <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private TaskAwaiter<BNAMHEGAPHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x3A79290", Offset = "0x3A78090", VA = "0x183A79290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x3A795B0", Offset = "0x3A783B0", VA = "0x183A795B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct CGELBJOMBEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public HAMOGNLMBNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private EHEFPJIJJBB <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x3A6D5F0", Offset = "0x3A6C3F0", VA = "0x183A6D5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class ALAHCFGNNHO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000120")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public AsyncTaskMethodBuilder<KGDGMJJPKIG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public ALAHCFGNNHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			private KGDGMJJPKIG <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			private TaskAwaiter<MNNIDFIIFAP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			private TaskAwaiter<KGDGMJJPKIG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x39C6260", Offset = "0x39C5060", VA = "0x1839C6260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x39C68B0", Offset = "0x39C56B0", VA = "0x1839C68B0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public AsyncTaskMethodBuilder<PBFKGFFPEEN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public ALAHCFGNNHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			private PBFKGFFPEEN <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			private TaskAwaiter<MNNIDFIIFAP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			private TaskAwaiter<PBFKGFFPEEN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x39C6900", Offset = "0x39C5700", VA = "0x1839C6900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x39C6E70", Offset = "0x39C5C70", VA = "0x1839C6E70", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public ALAHCFGNNHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			private bool <isReloadingSceneForObjectModel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			private TaskAwaiter<MNNIDFIIFAP> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			private BMBKGOBPDMA <timedYielder>5__3;

			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0x39C5060", Offset = "0x39C3E60", VA = "0x1839C5060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public HAMOGNLMBNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public PGCPDGBOHJA preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public PGCPDGBOHJA downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public KGDGMJJPKIG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public PGCPDGBOHJA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public PBFKGFFPEEN phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public FMCHGLJJNMK.GMIEONIJOCN <>9__6;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ALAHCFGNNHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A6A0", Offset = "0x3A694A0", VA = "0x183A6A6A0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<KGDGMJJPKIG> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A7E0", Offset = "0x3A695E0", VA = "0x183A6A7E0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<PBFKGFFPEEN> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A920", Offset = "0x3A69720", VA = "0x183A6A920")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A570", Offset = "0x3A69370", VA = "0x183A6A570")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct MMNGBDGJDOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public HAMOGNLMBNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private ALAHCFGNNHO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private TaskAwaiter<KGDGMJJPKIG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private TaskAwaiter<PBFKGFFPEEN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x3A7A310", Offset = "0x3A79110", VA = "0x183A7A310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct MHBJGLPIIBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x3A79CB0", Offset = "0x3A78AB0", VA = "0x183A79CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct GMJHMJLMFBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public PGCPDGBOHJA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private EHEFPJIJJBB <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private TaskAwaiter<MNNIDFIIFAP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x3A74E50", Offset = "0x3A73C50", VA = "0x183A74E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct MOFLHLNBEEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public AsyncTaskMethodBuilder<MNNIDFIIFAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public PGCPDGBOHJA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private EHEFPJIJJBB <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private TaskAwaiter<MNNIDFIIFAP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x3A7AF30", Offset = "0x3A79D30", VA = "0x183A7AF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x3A7B9D0", Offset = "0x3A7A7D0", VA = "0x183A7B9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct DMCEOGOPCDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public AsyncTaskMethodBuilder<MNNIDFIIFAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public PGCPDGBOHJA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public BMBKGOBPDMA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private EHEFPJIJJBB <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private TaskAwaiter<MNNIDFIIFAP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E730", Offset = "0x3A6D530", VA = "0x183A6E730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x3A6F2E0", Offset = "0x3A6E0E0", VA = "0x183A6F2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct FAFFDJDENJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public AsyncTaskMethodBuilder<MNNIDFIIFAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public MNNIDFIIFAP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public PGCPDGBOHJA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public PBFKGFFPEEN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private TaskAwaiter<MNNIDFIIFAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x3A73140", Offset = "0x3A71F40", VA = "0x183A73140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x3A73340", Offset = "0x3A72140", VA = "0x183A73340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class BEMMAGJHMIB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public AsyncTaskMethodBuilder<MNNIDFIIFAP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public BEMMAGJHMIB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			private TaskAwaiter<MNNIDFIIFAP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0x39C6EC0", Offset = "0x39C5CC0", VA = "0x1839C6EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0x39C7420", Offset = "0x39C6220", VA = "0x1839C7420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public PGCPDGBOHJA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public JMEMIEFAOML masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public BMBKGOBPDMA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public MNNIDFIIFAP originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BEMMAGJHMIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x3A6C460", Offset = "0x3A6B260", VA = "0x183A6C460")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<MNNIDFIIFAP> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct EIDBNIDNHKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public AsyncTaskMethodBuilder<MNNIDFIIFAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public PGCPDGBOHJA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public JMEMIEFAOML masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public BMBKGOBPDMA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private TaskAwaiter<MNNIDFIIFAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x3A70200", Offset = "0x3A6F000", VA = "0x183A70200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x3A706C0", Offset = "0x3A6F4C0", VA = "0x183A706C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct AGPHFHBLLLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public PGCPDGBOHJA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private MNNIDFIIFAP <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private IEnumerator<MNNIDFIIFAP> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private TaskAwaiter<MNNIDFIIFAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x3A69F60", Offset = "0x3A68D60", VA = "0x183A69F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct OJPNGEPMNIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x3A7CD30", Offset = "0x3A7BB30", VA = "0x183A7CD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct KJFONJCJNOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public KHICHIDOBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x3A78CC0", Offset = "0x3A77AC0", VA = "0x183A78CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class OABLDEMGNKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public PGKHPCCBDIC roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public OABLDEMGNKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x3A7CAA0", Offset = "0x3A7B8A0", VA = "0x183A7CAA0")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	private readonly OLFJFONDFJE MKADDMEMKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	private readonly OLFJFONDFJE PEPAJKIBFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	private readonly ODKLBOIFAHG FEAFELBKNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	private readonly EDFAKHENNAC JFJLJKKEMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	private readonly IEBOIAAPNJL HLAELNDIGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	private readonly ANINPBDMPIO GKJMADIGOPB;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public float NNMDGEJCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x288C700", Offset = "0x288B500", VA = "0x18288C700", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private PPDJPHHFIJM CHNGMAGIGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x28838F0", Offset = "0x28826F0", VA = "0x1828838F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event NEKACKKACMG ODMDLNBIEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x288B130", Offset = "0x2889F30", VA = "0x18288B130", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x288AC50", Offset = "0x2889A50", VA = "0x18288AC50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x288C9F0", Offset = "0x288B7F0", VA = "0x18288C9F0")]
	public KHICHIDOBBB(MHCLGBNNENN OMGKKPHIJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x288C5B0", Offset = "0x288B3B0", VA = "0x18288C5B0")]
	[AsyncStateMachine(typeof(KDEGBICOIPC))]
	public Task OPDOEANFGMH(HAMOGNLMBNC CCNKPMLIOPA, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x288B7F0", Offset = "0x288A5F0", VA = "0x18288B7F0")]
	[AsyncStateMachine(typeof(LDEBCINGELN))]
	private Task<BNAMHEGAPHG> JLOFCKEGIMD(HAMOGNLMBNC CCNKPMLIOPA, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x288ADC0", Offset = "0x2889BC0", VA = "0x18288ADC0")]
	[AsyncStateMachine(typeof(CGELBJOMBEE))]
	private Task CLEEOLLBFDA(HAMOGNLMBNC CCNKPMLIOPA, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x288AC70", Offset = "0x2889A70", VA = "0x18288AC70")]
	[AsyncStateMachine(typeof(MMNGBDGJDOL))]
	private Task ALBPOFMIIDH(HAMOGNLMBNC CCNKPMLIOPA, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken HPBNLFEENGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x288BF70", Offset = "0x288AD70", VA = "0x18288BF70")]
	[AsyncStateMachine(typeof(MHBJGLPIIBI))]
	private Task LKIHAENPNJM(EHEFPJIJJBB NBINANLIAKB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x288BCB0", Offset = "0x288AAB0", VA = "0x18288BCB0")]
	[AsyncStateMachine(typeof(GMJHMJLMFBK))]
	private Task KOCLAAACOKB(PBFKGFFPEEN MMJOHADFCHO, PGCPDGBOHJA HDJGHOJJGDB, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x288BB30", Offset = "0x288A930", VA = "0x18288BB30")]
	[AsyncStateMachine(typeof(MOFLHLNBEEC))]
	private Task<MNNIDFIIFAP> KDIAJELLDFN(PBFKGFFPEEN MMJOHADFCHO, BMBKGOBPDMA KMNPHCMBJHG, PGCPDGBOHJA HDJGHOJJGDB, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x288C0A0", Offset = "0x288AEA0", VA = "0x18288C0A0")]
	[AsyncStateMachine(typeof(DMCEOGOPCDI))]
	private Task<MNNIDFIIFAP> NIPILJMOGMK(PBFKGFFPEEN MMJOHADFCHO, BMBKGOBPDMA KMNPHCMBJHG, PGCPDGBOHJA HDJGHOJJGDB, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x288B9A0", Offset = "0x288A7A0", VA = "0x18288B9A0")]
	[AsyncStateMachine(typeof(FAFFDJDENJM))]
	private Task<MNNIDFIIFAP> JPODGJMEMMM(MNNIDFIIFAP IDCCOFECHBB, PBFKGFFPEEN LKPCOGIAENK, PGCPDGBOHJA HDJGHOJJGDB, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP, bool HHHOLOMHMLJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x288B040", Offset = "0x2889E40", VA = "0x18288B040")]
	private bool DDKNLPHGABK(PBFKGFFPEEN CGJGNPEBNIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x288C240", Offset = "0x288B040", VA = "0x18288C240")]
	[AsyncStateMachine(typeof(EIDBNIDNHKN))]
	protected Task<MNNIDFIIFAP> NNMAKNPHEPP(PBFKGFFPEEN MMJOHADFCHO, BMBKGOBPDMA KMNPHCMBJHG, PGCPDGBOHJA HDJGHOJJGDB, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP, JMEMIEFAOML FCIPLPABCCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x288BE10", Offset = "0x288AC10", VA = "0x18288BE10")]
	[AsyncStateMachine(typeof(AGPHFHBLLLK))]
	private Task LHDPHLCBAMJ(PBFKGFFPEEN MMJOHADFCHO, PGCPDGBOHJA HDJGHOJJGDB, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x288B610", Offset = "0x288A410", VA = "0x18288B610")]
	private void HNCJGGLCHEN(MNNIDFIIFAP PDPLBIJAOOO, PGCPDGBOHJA HDJGHOJJGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x288B470", Offset = "0x288A270", VA = "0x18288B470")]
	private void FLNFNIMPJJC(MNNIDFIIFAP LBNMLDCEPOH, out MNNIDFIIFAP NIFMFHJKDOK, out MNNIDFIIFAP KIDJELPGHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x288C3F0", Offset = "0x288B1F0", VA = "0x18288C3F0")]
	private Task<KGDGMJJPKIG> OIENBELDLKC(HAMOGNLMBNC CCNKPMLIOPA, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x288B430", Offset = "0x288A230", VA = "0x18288B430")]
	private Task<PBFKGFFPEEN> FJMGAFEADPJ(KGDGMJJPKIG MMJOHADFCHO, FMCHGLJJNMK.GMIEONIJOCN IAEDJFGDAGH, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x288C890", Offset = "0x288B690", VA = "0x18288C890")]
	[AsyncStateMachine(typeof(OJPNGEPMNIL))]
	private Task PJLDFLADMJI(PBFKGFFPEEN MMJOHADFCHO, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP, bool KEOALEBIEGM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x288AF20", Offset = "0x2889D20", VA = "0x18288AF20")]
	[AsyncStateMachine(typeof(KJFONJCJNOK))]
	private Task CPAIODEDCIJ(PBFKGFFPEEN MMJOHADFCHO, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x288B970", Offset = "0x288A770", VA = "0x18288B970")]
	private Task JPCCEOPHFLH(PBFKGFFPEEN MMJOHADFCHO, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x288B690", Offset = "0x288A490", VA = "0x18288B690")]
	private Task JIIBMPGEGJN(PBFKGFFPEEN MMJOHADFCHO, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x288B2E0", Offset = "0x288A0E0", VA = "0x18288B2E0")]
	private Task EPAEDBNCKPC(PBFKGFFPEEN MMJOHADFCHO, BMBKGOBPDMA KMNPHCMBJHG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x288B150", Offset = "0x2889F50", VA = "0x18288B150")]
	private Task EDHBJPFKBHD(PBFKGFFPEEN MMJOHADFCHO, BMBKGOBPDMA KMNPHCMBJHG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x288B4B0", Offset = "0x288A2B0", VA = "0x18288B4B0")]
	private static Task HBDFJEHCCCH(CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x288B4C0", Offset = "0x288A2C0", VA = "0x18288B4C0")]
	private Task HHKKIMNEDNN(PBFKGFFPEEN MMJOHADFCHO, BMBKGOBPDMA KMNPHCMBJHG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x288B2C0", Offset = "0x288A0C0", VA = "0x18288B2C0")]
	private Task EMHOOOKAEND(PBFKGFFPEEN MMJOHADFCHO, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x288B660", Offset = "0x288A460", VA = "0x18288B660")]
	private void IGGNCILBCPE(HAMOGNLMBNC CCNKPMLIOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x288C720", Offset = "0x288B520", VA = "0x18288C720")]
	private static void PFOGECNGNNI(PGKHPCCBDIC ENCIGLKNHFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct OHKOJOCJOFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private PBFKGFFPEEN MMJOHADFCHO;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private ANDGFCHCEHL DFBAGBDEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x31D6D00", Offset = "0x31D5B00", VA = "0x1831D6D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x31D6FC0", Offset = "0x31D5DC0", VA = "0x1831D6FC0")]
	public static Task ECBHNDAKKOH(PPDJPHHFIJM PMENMHOEOKK, PBFKGFFPEEN MMJOHADFCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x31D6D50", Offset = "0x31D5B50", VA = "0x1831D6D50")]
	private void ECBHNDAKKOH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct OMNFIPMPHMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x31D7660", Offset = "0x31D6460", VA = "0x1831D7660")]
	public static Task ECBHNDAKKOH(CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct OKHNJPPFFMD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct GPIGOBCJAEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public MHCLGBNNENN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private EHEFPJIJJBB <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x39B8E00", Offset = "0x39B7C00", VA = "0x1839B8E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x31D73D0", Offset = "0x31D61D0", VA = "0x1831D73D0")]
	[AsyncStateMachine(typeof(GPIGOBCJAEG))]
	public static Task ECBHNDAKKOH(MHCLGBNNENN OMGKKPHIJBG, PBFKGFFPEEN MMJOHADFCHO, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct HELKKEJGGJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct JEIKGIJLDKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public MHCLGBNNENN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public BMBKGOBPDMA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private MNNIDFIIFAP <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private PPDJPHHFIJM <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private ANDGFCHCEHL <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private List<(PersistenceView, MEKMDLBCOOO)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private MEKMDLBCOOO <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x3A77570", Offset = "0x3A76370", VA = "0x183A77570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2884120", Offset = "0x2882F20", VA = "0x182884120")]
	[AsyncStateMachine(typeof(JEIKGIJLDKD))]
	public static Task ECBHNDAKKOH(MHCLGBNNENN OMGKKPHIJBG, PBFKGFFPEEN MMJOHADFCHO, BMBKGOBPDMA KMNPHCMBJHG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2884290", Offset = "0x2883090", VA = "0x182884290")]
	private static void OAAOCNHJBNK(PersistenceView LNBPHBEKGAD, MEKMDLBCOOO EKODLDGKCFA, PBFKGFFPEEN MMJOHADFCHO, MNNIDFIIFAP IDCCOFECHBB, bool NAMAHBGBOEG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct LOIMAMHCHHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct AABLDKGGMPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public PPDJPHHFIJM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x39B2A30", Offset = "0x39B1830", VA = "0x1839B2A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x31CB790", Offset = "0x31CA590", VA = "0x1831CB790")]
	[AsyncStateMachine(typeof(AABLDKGGMPF))]
	public static Task ECBHNDAKKOH(PPDJPHHFIJM PMENMHOEOKK, PBFKGFFPEEN MMJOHADFCHO, CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct FBHKMPPLKHL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct BBGPEGCDDMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public PPDJPHHFIJM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public MHCLGBNNENN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x31C19C0", Offset = "0x31C07C0", VA = "0x1831C19C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class JCADDLOGHAI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013D")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			public EHEFPJIJJBB timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004D2")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D3")]
			public JCADDLOGHAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004D4")]
			private EHEFPJIJJBB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004D5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x39C75B0", Offset = "0x39C63B0", VA = "0x1839C75B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JCADDLOGHAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x31C80D0", Offset = "0x31C6ED0", VA = "0x1831C80D0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task <Run>b__0(EHEFPJIJJBB timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct FLLGFDNKDHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public FBHKMPPLKHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private TaskAwaiter<BNAMHEGAPHG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x31C3F60", Offset = "0x31C2D60", VA = "0x1831C3F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class KFADFBBOBJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public AIFDHHOCJIF version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public KFADFBBOBJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x31C9150", Offset = "0x31C7F50", VA = "0x1831C9150")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x31C9230", Offset = "0x31C8030", VA = "0x1831C9230")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private PBFKGFFPEEN MMJOHADFCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	private MHCLGBNNENN OMGKKPHIJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private bool KEOALEBIEGM;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	private static readonly ByteString IHMBMFGHECN;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private ANDGFCHCEHL DFBAGBDEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x287E9D0", Offset = "0x287D7D0", VA = "0x18287E9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private PHGCHEAKDPI KDMNNHJCNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x287F3E0", Offset = "0x287E1E0", VA = "0x18287F3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x287EA20", Offset = "0x287D820", VA = "0x18287EA20")]
	[AsyncStateMachine(typeof(BBGPEGCDDMI))]
	public static Task ECBHNDAKKOH(PPDJPHHFIJM PMENMHOEOKK, PBFKGFFPEEN MMJOHADFCHO, MHCLGBNNENN OMGKKPHIJBG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP, bool KEOALEBIEGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x287EB90", Offset = "0x287D990", VA = "0x18287EB90")]
	[AsyncStateMachine(typeof(FLLGFDNKDHF))]
	private Task ECBHNDAKKOH(EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x287ECD0", Offset = "0x287DAD0", VA = "0x18287ECD0")]
	private void GNKGLLIKNEC([NotNull] CKGKBFGOMIH JJCJKABJJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x287F460", Offset = "0x287E260", VA = "0x18287F460")]
	private bool LEGLJMNOJIC(AIFDHHOCJIF HHCMOLFBCEB, CKGKBFGOMIH JJCJKABJJAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct IGEJHIJHEKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct JCODIEDMBKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public AsyncTaskMethodBuilder<PBFKGFFPEEN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public IGEJHIJHEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public FMCHGLJJNMK.GMIEONIJOCN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private EHEFPJIJJBB <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private TaskAwaiter<(global::AEGPCPFJGKN<GPCFNPDMJCA, MDPLBPNGKPK>, global::AEGPCPFJGKN<global::JJEOKINGBLJ<CKGKBFGOMIH>, MDPLBPNGKPK>, global::AEGPCPFJGKN<global::JJEOKINGBLJ<BJGLJEFJOPL>, MDPLBPNGKPK>, global::AEGPCPFJGKN<global::JJEOKINGBLJ<OCJOABFFAGH>, MDPLBPNGKPK>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x3A76BF0", Offset = "0x3A759F0", VA = "0x183A76BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x3A774F0", Offset = "0x3A762F0", VA = "0x183A774F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct CMLGLAEBNMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public AsyncTaskMethodBuilder<global::AEGPCPFJGKN<GPCFNPDMJCA, MDPLBPNGKPK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public EHEFPJIJJBB downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public IGEJHIJHEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public FMCHGLJJNMK.GMIEONIJOCN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private EHEFPJIJJBB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private TaskAwaiter<global::AEGPCPFJGKN<GPCFNPDMJCA, MDPLBPNGKPK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x3A6DB40", Offset = "0x3A6C940", VA = "0x183A6DB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E060", Offset = "0x3A6CE60", VA = "0x183A6E060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private global::ICILLBMELBG<JBPGEGNDOLF, BJGLJEFJOPL> HJDMJJDLJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private global::ICILLBMELBG<JBPGEGNDOLF, CKGKBFGOMIH> CKOENAEOKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private global::ICILLBMELBG<long, OCJOABFFAGH> BHHOGKKOGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private JNOIIEOBJFD DGAEFBKNHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private PGKHPCCBDIC ENCIGLKNHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private DDJMGGCCABD KGKNCCKOLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private string APGKPINBDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private JBPGEGNDOLF ACGOFPFCLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private JBPGEGNDOLF NLBPGLPMHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private long EMGKBPGHGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	private EHEFPJIJJBB NBINANLIAKB;

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2886080", Offset = "0x2884E80", VA = "0x182886080")]
	public static Task<PBFKGFFPEEN> POMCMNKEOAC(PPDJPHHFIJM PMENMHOEOKK, in KGDGMJJPKIG MMJOHADFCHO, FMCHGLJJNMK.GMIEONIJOCN IAEDJFGDAGH, EHEFPJIJJBB NBINANLIAKB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x2885EF0", Offset = "0x2884CF0", VA = "0x182885EF0")]
	[AsyncStateMachine(typeof(JCODIEDMBKA))]
	private Task<PBFKGFFPEEN> ECBHNDAKKOH(FMCHGLJJNMK.GMIEONIJOCN IAEDJFGDAGH, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x2885D20", Offset = "0x2884B20", VA = "0x182885D20")]
	[AsyncStateMachine(typeof(CMLGLAEBNMI))]
	private Task<global::AEGPCPFJGKN<GPCFNPDMJCA, MDPLBPNGKPK>> DFNJEKMCLJB(string APGKPINBDMG, long EMGKBPGHGPI, FMCHGLJJNMK.GMIEONIJOCN IAEDJFGDAGH, EHEFPJIJJBB DNAGOECMGIO, CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct LENFEPHDIJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct DMMMABOKALD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public AsyncTaskMethodBuilder<KGDGMJJPKIG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public LENFEPHDIJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private EHEFPJIJJBB <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private TaskAwaiter<KGDGMJJPKIG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x39B65B0", Offset = "0x39B53B0", VA = "0x1839B65B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x39B6950", Offset = "0x39B5750", VA = "0x1839B6950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct JGEAOLBEDBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public AsyncTaskMethodBuilder<KGDGMJJPKIG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public LENFEPHDIJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private TaskAwaiter<KGDGMJJPKIG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x39BC3A0", Offset = "0x39BB1A0", VA = "0x1839BC3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x39BC5D0", Offset = "0x39BB3D0", VA = "0x1839BC5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class MKPIHNMMMMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public MKPIHNMMMMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x1208A40", Offset = "0x1207840", VA = "0x181208A40")]
		internal bool <FetchRoomLoadDetails>b__0(DDJMGGCCABD sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct NBHCGCKIOOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public AsyncTaskMethodBuilder<KGDGMJJPKIG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public JBPGEGNDOLF superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public ANDGFCHCEHL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private MKPIHNMMMMJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private PGKHPCCBDIC <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private DDJMGGCCABD <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private JBPGEGNDOLF <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private JBPGEGNDOLF <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private EHEFPJIJJBB <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private TaskAwaiter<PGKHPCCBDIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private TaskAwaiter<ANALHMKOLNC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter<CIAEOCHKJND> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x39C0E00", Offset = "0x39BFC00", VA = "0x1839C0E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x39C1A60", Offset = "0x39C0860", VA = "0x1839C1A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private ANDGFCHCEHL BGEMPOFCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	private ODKLBOIFAHG FEAFELBKNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private EHEFPJIJJBB NBINANLIAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private long GJDNMGJBIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private long HIIJPNGKPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private long EOEGJCLNPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private string LNGNOBMKHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private JBPGEGNDOLF FBHFMDDGEPP;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x28929F0", Offset = "0x28917F0", VA = "0x1828929F0")]
	public static Task<KGDGMJJPKIG> POMCMNKEOAC(PPDJPHHFIJM PMENMHOEOKK, HAMOGNLMBNC CCNKPMLIOPA, EHEFPJIJJBB NBINANLIAKB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2892540", Offset = "0x2891340", VA = "0x182892540")]
	[AsyncStateMachine(typeof(DMMMABOKALD))]
	private Task<KGDGMJJPKIG> ECBHNDAKKOH(CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x2892870", Offset = "0x2891670", VA = "0x182892870")]
	[AsyncStateMachine(typeof(JGEAOLBEDBE))]
	private Task<KGDGMJJPKIG> OIENBELDLKC(EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x28926D0", Offset = "0x28914D0", VA = "0x1828926D0")]
	[AsyncStateMachine(typeof(NBHCGCKIOOC))]
	private static Task<KGDGMJJPKIG> OIENBELDLKC(ANDGFCHCEHL BGEMPOFCNMN, long GJDNMGJBIPD, long HIIJPNGKPPH, long EOEGJCLNPMO, string LNGNOBMKHBG, JBPGEGNDOLF FBHFMDDGEPP, CancellationToken NBLKBHANAPP, EHEFPJIJJBB LKDPBPGJFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x28926A0", Offset = "0x28914A0", VA = "0x1828926A0")]
	private void HAELHKGMDPI(PGKHPCCBDIC ENCIGLKNHFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct DNIJLJEIGEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct OBFAOBAMHPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public DNIJLJEIGEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private EHEFPJIJJBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x31D35F0", Offset = "0x31D23F0", VA = "0x1831D35F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private const int PCABEPICHLE = 20;

	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private const float LNJPMNHNOMI = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private ANDGFCHCEHL BGEMPOFCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private PBFKGFFPEEN MMJOHADFCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private EHEFPJIJJBB NBINANLIAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private float GNMLANPMDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private float AIEHGCKNEFJ;

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x2875FF0", Offset = "0x2874DF0", VA = "0x182875FF0")]
	public static Task JMFODMHBGJB(PPDJPHHFIJM PMENMHOEOKK, PBFKGFFPEEN MMJOHADFCHO, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x2875D10", Offset = "0x2874B10", VA = "0x182875D10")]
	[AsyncStateMachine(typeof(OBFAOBAMHPE))]
	public Task ECBHNDAKKOH(CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x2875E40", Offset = "0x2874C40", VA = "0x182875E40")]
	private static void JLNBJMOEPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x28761B0", Offset = "0x2874FB0", VA = "0x1828761B0")]
	private void NBCOLOBOCDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x2875C50", Offset = "0x2874A50", VA = "0x182875C50")]
	private static float COPCEFLMMBJ(ANDGFCHCEHL BGEMPOFCNMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x2876190", Offset = "0x2874F90", VA = "0x182876190")]
	private static float MFMBNLBBPDB()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct JGFENOIIGGH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct CDAEGLIMFLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public MHCLGBNNENN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private FGOMEABCFHE <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private PPDJPHHFIJM <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private LMLKLCJOEJJ.FPFPHCPJMLB <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter<BNAMHEGAPHG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x3A6CC50", Offset = "0x3A6BA50", VA = "0x183A6CC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct LOBGHBFHNMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private JIJGDFGGHKA.CFEHIMMEOBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x3A799F0", Offset = "0x3A787F0", VA = "0x183A799F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2886C50", Offset = "0x2885A50", VA = "0x182886C50")]
	[AsyncStateMachine(typeof(CDAEGLIMFLK))]
	public static Task ECBHNDAKKOH(MHCLGBNNENN OMGKKPHIJBG, PBFKGFFPEEN MMJOHADFCHO, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2886DB0", Offset = "0x2885BB0", VA = "0x182886DB0")]
	private static Task<BNAMHEGAPHG> HBDJBLFLCCO(MHCLGBNNENN OMGKKPHIJBG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2886B80", Offset = "0x2885980", VA = "0x182886B80")]
	[AsyncStateMachine(typeof(LOBGHBFHNMG))]
	private static Task AKFBKEHLDIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct MKFDKHDPBII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct OFKCOMOPMEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public MKFDKHDPBII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private EHEFPJIJJBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x39C2B50", Offset = "0x39C1950", VA = "0x1839C2B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class BKAEIMMIMAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BKAEIMMIMAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x39B3D00", Offset = "0x39B2B00", VA = "0x1839B3D00")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct HAPOGLJAMCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public MKFDKHDPBII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private GFIONJIFIBL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x39B9280", Offset = "0x39B8080", VA = "0x1839B9280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private bool PBNIDFEFFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private EHEFPJIJJBB NBINANLIAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private CancellationToken NBLKBHANAPP;

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x31D0610", Offset = "0x31CF410", VA = "0x1831D0610")]
	public static Task EJLMOCECJEA(PPDJPHHFIJM PMENMHOEOKK, bool PBNIDFEFFOD, EHEFPJIJJBB NBINANLIAKB, CancellationToken OPABCBKJNHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x31D0500", Offset = "0x31CF300", VA = "0x1831D0500")]
	[AsyncStateMachine(typeof(OFKCOMOPMEB))]
	private Task ECBHNDAKKOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x31D0680", Offset = "0x31CF480", VA = "0x1831D0680")]
	[AsyncStateMachine(typeof(HAPOGLJAMCO))]
	private Task PHEBNLFLBIL(bool GLPNGKLIAJC, string GBOIDOKOFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330")]
	private bool BBCGIDDPLEM(bool PBNIDFEFFOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal struct CILHOOGOFDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct DMLGKEOOPPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public CILHOOGOFDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private EHEFPJIJJBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x31C34E0", Offset = "0x31C22E0", VA = "0x1831C34E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x31C3930", Offset = "0x31C2730", VA = "0x1831C3930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class NMNFOCIKGNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public NMNFOCIKGNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x31D2BE0", Offset = "0x31D19E0", VA = "0x1831D2BE0")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct HKIMNGDNLKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public CILHOOGOFDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private GFIONJIFIBL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x31C60B0", Offset = "0x31C4EB0", VA = "0x1831C60B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x31C6610", Offset = "0x31C5410", VA = "0x1831C6610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	private KPFMPDBFDJB AENBHDLKLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	private EHEFPJIJJBB NBINANLIAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private bool DAGHJHGDGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private PBFKGFFPEEN MMJOHADFCHO;

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2875500", Offset = "0x2874300", VA = "0x182875500")]
	public static Task<Scene> PJIENIBCFNA(PPDJPHHFIJM PMENMHOEOKK, KPFMPDBFDJB JLBAPJMLFLC, EHEFPJIJJBB NBINANLIAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2875130", Offset = "0x2873F30", VA = "0x182875130")]
	public static Task<Scene> CHHAJLBOHOP(PPDJPHHFIJM PMENMHOEOKK, PBFKGFFPEEN MMJOHADFCHO, EHEFPJIJJBB NBINANLIAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2875240", Offset = "0x2874040", VA = "0x182875240")]
	[AsyncStateMachine(typeof(DMLGKEOOPPC))]
	private Task<Scene> ECBHNDAKKOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2875370", Offset = "0x2874170", VA = "0x182875370")]
	private bool LOIKJCHBOPM(PBFKGFFPEEN MMJOHADFCHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x28751D0", Offset = "0x2873FD0", VA = "0x1828751D0")]
	private void DDMCMLHEOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x28753A0", Offset = "0x28741A0", VA = "0x1828753A0")]
	[AsyncStateMachine(typeof(HKIMNGDNLKK))]
	private Task<Scene> PHEBNLFLBIL(string GBOIDOKOFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct IEBOIAAPNJL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct BDJJBGLJMKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder<MNNIDFIIFAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public IEBOIAAPNJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public MNNIDFIIFAP nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public PBFKGFFPEEN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private EHEFPJIJJBB <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private TaskAwaiter<MNNIDFIIFAP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x3A6B010", Offset = "0x3A69E10", VA = "0x183A6B010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A6B600", Offset = "0x3A6A400", VA = "0x183A6B600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct LAPCAPEIODD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public AsyncTaskMethodBuilder<MNNIDFIIFAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public IEBOIAAPNJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public MNNIDFIIFAP state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter<BNAMHEGAPHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A78FC0", Offset = "0x3A77DC0", VA = "0x183A78FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A79240", Offset = "0x3A78040", VA = "0x183A79240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private readonly MHCLGBNNENN OMGKKPHIJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private readonly ODKLBOIFAHG FEAFELBKNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private readonly EDFAKHENNAC JFJLJKKEMME;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private FGOMEABCFHE KFFFMMOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x999440", Offset = "0x998240", VA = "0x180999440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x28852C0", Offset = "0x28840C0", VA = "0x1828852C0")]
	public IEBOIAAPNJL(MHCLGBNNENN OMGKKPHIJBG, ODKLBOIFAHG FEAFELBKNGM, EDFAKHENNAC JFJLJKKEMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x2884FB0", Offset = "0x2883DB0", VA = "0x182884FB0")]
	[AsyncStateMachine(typeof(BDJJBGLJMKM))]
	public Task<MNNIDFIIFAP> EGDAFMDDMGM(MNNIDFIIFAP NIAMFNHLOAP, PBFKGFFPEEN LKPCOGIAENK, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP, bool HHHOLOMHMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x2885150", Offset = "0x2883F50", VA = "0x182885150")]
	[AsyncStateMachine(typeof(LAPCAPEIODD))]
	private Task<MNNIDFIIFAP> GMGIHJDIBCN(EHEFPJIJJBB LKDPBPGJFDJ, MNNIDFIIFAP GMDALJMBJKE, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x2884F60", Offset = "0x2883D60", VA = "0x182884F60")]
	private bool CFFBIONMJAN(MNNIDFIIFAP FLFCPDLHCMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x2884F90", Offset = "0x2883D90", VA = "0x182884F90")]
	private void DBKHFPMEGAJ(string IMOOIIGBLCN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct BLBAJPJHILA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct PANAOOCLAKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public FGOMEABCFHE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public BMBKGOBPDMA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private List<(PersistenceView, MEKMDLBCOOO)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private (PersistenceView, MEKMDLBCOOO) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x31D7780", Offset = "0x31D6580", VA = "0x1831D7780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2874AE0", Offset = "0x28738E0", VA = "0x182874AE0")]
	[AsyncStateMachine(typeof(PANAOOCLAKH))]
	public static Task ECBHNDAKKOH(FGOMEABCFHE DMPEOFAJLOH, PBFKGFFPEEN MMJOHADFCHO, BMBKGOBPDMA KMNPHCMBJHG, CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct JDHDONIGFLK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct HLOLLFPCGDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public FGOMEABCFHE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public BMBKGOBPDMA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private AIFDHHOCJIF <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private List<(PersistenceView, MEKMDLBCOOO)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private MEKMDLBCOOO <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A75B70", Offset = "0x3A74970", VA = "0x183A75B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x2886670", Offset = "0x2885470", VA = "0x182886670")]
	[AsyncStateMachine(typeof(HLOLLFPCGDJ))]
	public static Task ECBHNDAKKOH(FGOMEABCFHE DMPEOFAJLOH, PBFKGFFPEEN MMJOHADFCHO, BMBKGOBPDMA KMNPHCMBJHG, CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct LMLKLCJOEJJ
{
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	public struct FPFPHCPJMLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public List<HGKMGLGDNAG> DIPIOHJANNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public List<MEKMDLBCOOO> BPIPCJKBGAG;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x809110", Offset = "0x807F10", VA = "0x180809110")]
		public FPFPHCPJMLB(List<HGKMGLGDNAG> DIPIOHJANNC, List<MEKMDLBCOOO> BPIPCJKBGAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class FFAGHKAKHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public IEnumerable<HGKMGLGDNAG> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public FFAGHKAKHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x39B8410", Offset = "0x39B7210", VA = "0x1839B8410")]
		internal object <TryBulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	private PBFKGFFPEEN MMJOHADFCHO;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private ANDGFCHCEHL DFBAGBDEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x31CA2F0", Offset = "0x31C90F0", VA = "0x1831CA2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x31CA660", Offset = "0x31C9460", VA = "0x1831CA660")]
	public static FPFPHCPJMLB ECBHNDAKKOH(PPDJPHHFIJM PMENMHOEOKK, PBFKGFFPEEN MMJOHADFCHO)
	{
		return default(FPFPHCPJMLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x31CA340", Offset = "0x31C9140", VA = "0x1831CA340")]
	private FPFPHCPJMLB ECBHNDAKKOH()
	{
		return default(FPFPHCPJMLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x31CA6C0", Offset = "0x31C94C0", VA = "0x1831CA6C0")]
	private FPFPHCPJMLB FACCMFICFGE(CKGKBFGOMIH JJCJKABJJAC, AIFDHHOCJIF KKKJGICBLPB)
	{
		return default(FPFPHCPJMLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x31CAC10", Offset = "0x31C9A10", VA = "0x1831CAC10")]
	private bool HHGKICFEKFM(IEnumerable<HGKMGLGDNAG> DIPIOHJANNC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct BKKPBGMKLNA
{
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class PEJOCPAGNJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public LMLKLCJOEJJ.FPFPHCPJMLB instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PEJOCPAGNJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x31D96D0", Offset = "0x31D84D0", VA = "0x1831D96D0")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class OEHAHMMFLEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public OEHAHMMFLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x31D5BC0", Offset = "0x31D49C0", VA = "0x1831D5BC0")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x2874420", Offset = "0x2873220", VA = "0x182874420")]
	public static void ECBHNDAKKOH(FGOMEABCFHE DMPEOFAJLOH, PBFKGFFPEEN MMJOHADFCHO, LMLKLCJOEJJ.FPFPHCPJMLB IDPLAOMBKBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct FCKGFMMKCMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct IJALLENPIEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public PPDJPHHFIJM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public MHCLGBNNENN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x31C7930", Offset = "0x31C6730", VA = "0x1831C7930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct PKBFLONMMCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public FCKGFMMKCMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x31DA530", Offset = "0x31D9330", VA = "0x1831DA530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A9")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005AA")]
	private PBFKGFFPEEN MMJOHADFCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AB")]
	private ByteString HFCLKAFBFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	private MHCLGBNNENN OMGKKPHIJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private bool HODBLDEBGPP;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private ANDGFCHCEHL DFBAGBDEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x287F510", Offset = "0x287E310", VA = "0x18287F510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool PDBKJDNHKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x287F800", Offset = "0x287E600", VA = "0x18287F800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool GNJIIABNJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x287F880", Offset = "0x287E680", VA = "0x18287F880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x287F690", Offset = "0x287E490", VA = "0x18287F690")]
	[AsyncStateMachine(typeof(IJALLENPIEJ))]
	public static Task ECBHNDAKKOH(PPDJPHHFIJM PMENMHOEOKK, PBFKGFFPEEN MMJOHADFCHO, MHCLGBNNENN OMGKKPHIJBG, bool HODBLDEBGPP, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x287F560", Offset = "0x287E360", VA = "0x18287F560")]
	[AsyncStateMachine(typeof(PKBFLONMMCF))]
	private Task ECBHNDAKKOH(EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal class EDFAKHENNAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct JOPGHMIHODJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public EDFAKHENNAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public MNNIDFIIFAP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public PBFKGFFPEEN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x31C88E0", Offset = "0x31C76E0", VA = "0x1831C88E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class LBNBEECJGBI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000169")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public LBNBEECJGBI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005CE")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005CF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x39C7470", Offset = "0x39C6270", VA = "0x1839C7470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public EDFAKHENNAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public EHEFPJIJJBB handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public LBNBEECJGBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x31C9510", Offset = "0x31C8310", VA = "0x1831C9510")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct JNDLGDGDAOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public EDFAKHENNAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private LBNBEECJGBI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x31C8430", Offset = "0x31C7230", VA = "0x1831C8430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct MEFPKGPFELA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public EDFAKHENNAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private EHEFPJIJJBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private Dictionary<Guid, List<OLAAHHNGKFM>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x31CD1B0", Offset = "0x31CBFB0", VA = "0x1831CD1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct EPINLFNLDPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public EDFAKHENNAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private EHEFPJIJJBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private Dictionary<Guid, List<OLAAHHNGKFM>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x31C3A00", Offset = "0x31C2800", VA = "0x1831C3A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class OJCOHJPBFBE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005F0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			public OLAAHHNGKFM handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			public OJCOHJPBFBE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x39C4F20", Offset = "0x39C3D20", VA = "0x1839C4F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public AOOGJGGKCGF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public List<OLAAHHNGKFM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public OJCOHJPBFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x31D7060", Offset = "0x31D5E60", VA = "0x1831D7060")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x31D7240", Offset = "0x31D6040", VA = "0x1831D7240")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(OLAAHHNGKFM handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x31D7150", Offset = "0x31D5F50", VA = "0x1831D7150")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct OGDLNNGHJPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public AOOGJGGKCGF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public List<OLAAHHNGKFM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private OJCOHJPBFBE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x31D5C50", Offset = "0x31D4A50", VA = "0x1831D5C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct PMLLPLANCAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public EDFAKHENNAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public EHEFPJIJJBB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x31DA9F0", Offset = "0x31D97F0", VA = "0x1831DA9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class JHANPLGEPGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JHANPLGEPGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x31C8270", Offset = "0x31C7070", VA = "0x1831C8270")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct AAGLDGGKPJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public EDFAKHENNAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x31C0EF0", Offset = "0x31BFCF0", VA = "0x1831C0EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class HPLMLGOGDCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public HPLMLGOGDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x31C6C80", Offset = "0x31C5A80", VA = "0x1831C6C80")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct HIGBCEJFEPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public EDFAKHENNAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private TaskAwaiter<BNAMHEGAPHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x31C5B40", Offset = "0x31C4940", VA = "0x1831C5B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class OJDFECPDBDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public OJDFECPDBDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x31D7360", Offset = "0x31D6160", VA = "0x1831D7360")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	private readonly MHCLGBNNENN OMGKKPHIJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private PIBFJEHBDEG JFJLJKKEMME;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private FGOMEABCFHE KFFFMMOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x897730", Offset = "0x896530", VA = "0x180897730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
	public EDFAKHENNAC(MHCLGBNNENN OMGKKPHIJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x2878770", Offset = "0x2877570", VA = "0x182878770")]
	[AsyncStateMachine(typeof(JOPGHMIHODJ))]
	public Task ECBHNDAKKOH(MNNIDFIIFAP IDCCOFECHBB, PBFKGFFPEEN LKPCOGIAENK, EHEFPJIJJBB NBINANLIAKB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x2879170", Offset = "0x2877F70", VA = "0x182879170")]
	[AsyncStateMachine(typeof(JNDLGDGDAOJ))]
	private Task MPPCBMGELKC(PBFKGFFPEEN MMJOHADFCHO, EHEFPJIJJBB NBINANLIAKB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x2878D10", Offset = "0x2877B10", VA = "0x182878D10")]
	[AsyncStateMachine(typeof(MEFPKGPFELA))]
	private Task IBOBJCBMPCN(PBFKGFFPEEN MMJOHADFCHO, EHEFPJIJJBB NBINANLIAKB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x2879010", Offset = "0x2877E10", VA = "0x182879010")]
	[AsyncStateMachine(typeof(EPINLFNLDPE))]
	private Task MEMDECNKPHB(PBFKGFFPEEN MMJOHADFCHO, EHEFPJIJJBB NBINANLIAKB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x28792D0", Offset = "0x28780D0", VA = "0x1828792D0")]
	[AsyncStateMachine(typeof(OGDLNNGHJPO))]
	private Task PBDMBIPOKIH(Guid JJCLOEHBMNF, List<OLAAHHNGKFM> CKPFOPOOAAO, AOOGJGGKCGF FEGNGINNNGL, PBFKGFFPEEN MMJOHADFCHO, CancellationToken AMBDKIOJFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x2879560", Offset = "0x2878360", VA = "0x182879560")]
	[AsyncStateMachine(typeof(PMLLPLANCAI))]
	private Task PNDEDNDDDJE(PBFKGFFPEEN MMJOHADFCHO, EHEFPJIJJBB NBINANLIAKB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x28788D0", Offset = "0x28776D0", VA = "0x1828788D0")]
	[AsyncStateMachine(typeof(AAGLDGGKPJD))]
	private Task HBAJADMEMCN(Guid GKBHPCCCDJI, PBFKGFFPEEN MMJOHADFCHO, EHEFPJIJJBB NBINANLIAKB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x2879410", Offset = "0x2878210", VA = "0x182879410")]
	[AsyncStateMachine(typeof(HIGBCEJFEPM))]
	private Task PIPKHKKPOFF(Guid GKBHPCCCDJI, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x2878E70", Offset = "0x2877C70", VA = "0x182878E70")]
	private void KIMONLKANOH(Guid GKBHPCCCDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x2878BE0", Offset = "0x28779E0", VA = "0x182878BE0")]
	private void IAMIIEBBFJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x2878A10", Offset = "0x2877810", VA = "0x182878A10")]
	public Guid HBJBLPIDEOO(MNNIDFIIFAP PDPLBIJAOOO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x28785A0", Offset = "0x28773A0", VA = "0x1828785A0")]
	[CompilerGenerated]
	private object AKJPDGMPJFE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal struct IDPHMAAIBBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct EBLKOKLHFDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public PPDJPHHFIJM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public PBFKGFFPEEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public MHCLGBNNENN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x3A6FE30", Offset = "0x3A6EC30", VA = "0x183A6FE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x3A70030", Offset = "0x3A6EE30", VA = "0x183A70030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct GBOHNIKKKHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public IDPHMAAIBBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private bool <reloadSceneForObjectModel>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x3A739E0", Offset = "0x3A727E0", VA = "0x183A739E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x3A73F30", Offset = "0x3A72D30", VA = "0x183A73F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private PPDJPHHFIJM PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private PBFKGFFPEEN MMJOHADFCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	private ByteString HFCLKAFBFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061E")]
	private MHCLGBNNENN OMGKKPHIJBG;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private ANDGFCHCEHL DFBAGBDEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2884AD0", Offset = "0x28838D0", VA = "0x182884AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private bool PDBKJDNHKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x2884E50", Offset = "0x2883C50", VA = "0x182884E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private bool GNJIIABNJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x2884ED0", Offset = "0x2883CD0", VA = "0x182884ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private bool JNICBNJDDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x2884B20", Offset = "0x2883920", VA = "0x182884B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x2884CC0", Offset = "0x2883AC0", VA = "0x182884CC0")]
	[AsyncStateMachine(typeof(EBLKOKLHFDJ))]
	public static Task<bool> ECBHNDAKKOH(PPDJPHHFIJM PMENMHOEOKK, PBFKGFFPEEN MMJOHADFCHO, MHCLGBNNENN OMGKKPHIJBG, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x2884B60", Offset = "0x2883960", VA = "0x182884B60")]
	[AsyncStateMachine(typeof(GBOHNIKKKHA))]
	private Task<bool> ECBHNDAKKOH(EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public readonly struct MDPJPGJEHCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	public readonly bool LLKCMIOJKLI;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0xEEFE50", Offset = "0xEEEC50", VA = "0x180EEFE50")]
	public MDPJPGJEHCC(bool ODHHOLBPJEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
public readonly struct IENJOFGBOJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	public readonly CKGKBFGOMIH? PJJPOOGAMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	public readonly LEGJNFMIAHE FIDNPFMFAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	public readonly string? FGCCPEAEAKD;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public IReadOnlyCollection<string> MGJHNAJPFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x2885340", Offset = "0x2884140", VA = "0x182885340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public IReadOnlyDictionary<long, int> GLLKKCMMBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x2885320", Offset = "0x2884120", VA = "0x182885320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x2885360", Offset = "0x2884160", VA = "0x182885360")]
	public IENJOFGBOJJ(CKGKBFGOMIH? FHDHPJOAAEH, LEGJNFMIAHE AGKNJOLFPEN, string? APGKPINBDMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal class DPMNHEEECCA : NBFGBADGPEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct JPEIJIFNDLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public AsyncTaskMethodBuilder<IENJOFGBOJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public DPMNHEEECCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public ONONGACBCBK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x31C8C20", Offset = "0x31C7A20", VA = "0x1831C8C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x31C9100", Offset = "0x31C7F00", VA = "0x1831C9100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class BNLCOOFLKFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public ONONGACBCBK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public DPMNHEEECCA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BNLCOOFLKFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x31C1E00", Offset = "0x31C0C00", VA = "0x1831C1E00")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x31C2040", Offset = "0x31C0E40", VA = "0x1831C2040")]
		internal Task <PreserializeViews>b__2(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class HDLLEGPDJBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public BNLCOOFLKFJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public HDLLEGPDJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x31C5A20", Offset = "0x31C4820", VA = "0x1831C5A20")]
		internal object <PreserializeViews>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private sealed class IBIGHEBIKGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public BNLCOOFLKFJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public IBIGHEBIKGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x31C6CF0", Offset = "0x31C5AF0", VA = "0x1831C6CF0")]
		internal Task <PreserializeViews>b__5(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct NEBLOKDGMMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public ONONGACBCBK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public DPMNHEEECCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private HDLLEGPDJBL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private JIJGDFGGHKA.LKCGLHAHOEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x31D23B0", Offset = "0x31D11B0", VA = "0x1831D23B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private readonly GONOMPDEHOL CMDMNMJCLCL;

	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private static readonly TimeSpan INPKCEKGNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private readonly AFCDEBGDGNM ADLFMCIAPPN;

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x2877B70", Offset = "0x2876970", VA = "0x182877B70")]
	public DPMNHEEECCA(MHCLGBNNENN OMGKKPHIJBG, AFCDEBGDGNM ADLFMCIAPPN, [Optional] GONOMPDEHOL? CMDMNMJCLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x2876CE0", Offset = "0x2875AE0", VA = "0x182876CE0")]
	[AsyncStateMachine(typeof(JPEIJIFNDLD))]
	public Task<IENJOFGBOJJ> EPOBOPBJBKM(long HIIJPNGKPPH, string APGKPINBDMG, ONONGACBCBK KMKCJEELFKC, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x2876E60", Offset = "0x2875C60", VA = "0x182876E60")]
	[AsyncStateMachine(typeof(NEBLOKDGMMP))]
	private Task FFEIKIOOCHH(ONONGACBCBK KMKCJEELFKC, IEnumerable<PersistenceView> OAKHLLCMLDG, StringBuilder JNODMFDILOC, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x28774F0", Offset = "0x28762F0", VA = "0x1828774F0")]
	private IENJOFGBOJJ MELHDHECJPD(long HIIJPNGKPPH, string APGKPINBDMG, ONONGACBCBK KMKCJEELFKC, IEnumerable<PersistenceView> OAKHLLCMLDG, StringBuilder JNODMFDILOC)
	{
		return default(IENJOFGBOJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x2876950", Offset = "0x2875750", VA = "0x182876950")]
	private CKGKBFGOMIH DKBCCHAHKOJ(long HIIJPNGKPPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x2876AC0", Offset = "0x28758C0", VA = "0x182876AC0")]
	private void ELPIJMHGCAD(CKGKBFGOMIH COAPKJAONPJ, StringBuilder JNODMFDILOC, IEnumerable<PersistenceView> OAKHLLCMLDG, in JGPGGHFLMCK PHFANALOCKM, ref CMOKOFJLOKE FDAJJHMIIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x2876FC0", Offset = "0x2875DC0", VA = "0x182876FC0")]
	private void IHKHNPHBLLJ(CKGKBFGOMIH COAPKJAONPJ, StringBuilder JNODMFDILOC, PersistenceView LNBPHBEKGAD, ref CMOKOFJLOKE FDAJJHMIIIA, in JGPGGHFLMCK PHFANALOCKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class HCHFGCGNNOO : NBFGBADGPEF
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class LFHMHDOOJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public DOFOBNGPBFN.AHEDDOMINFH roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public DOFOBNGPBFN.AHEDDOMINFH subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public LFHMHDOOJIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x3A79600", Offset = "0x3A78400", VA = "0x183A79600")]
		internal object <UploadRoomDataToStorage>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x3A79690", Offset = "0x3A78490", VA = "0x183A79690")]
		internal object <UploadRoomDataToStorage>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x3A796E0", Offset = "0x3A784E0", VA = "0x183A796E0")]
		internal object <UploadRoomDataToStorage>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x3A79750", Offset = "0x3A78550", VA = "0x183A79750")]
		internal object <UploadRoomDataToStorage>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct MPGPLBHPJKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public AsyncTaskMethodBuilder<(DOFOBNGPBFN.AHEDDOMINFH roomDataUpload, DOFOBNGPBFN.AHEDDOMINFH subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public IENJOFGBOJJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public HCHFGCGNNOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private LFHMHDOOJIF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<DOFOBNGPBFN.AHEDDOMINFH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x3A7BC80", Offset = "0x3A7AA80", VA = "0x183A7BC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x3A7C7C0", Offset = "0x3A7B5C0", VA = "0x183A7C7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct CBAFKDLAEBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public AsyncTaskMethodBuilder<LAHOMKBPNPM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public HCHFGCGNNOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public IENJOFGBOJJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public CGKIAAJADJO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private TaskAwaiter<(DOFOBNGPBFN.AHEDDOMINFH roomDataUpload, DOFOBNGPBFN.AHEDDOMINFH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private TaskAwaiter<LAHOMKBPNPM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x3A6C740", Offset = "0x3A6B540", VA = "0x183A6C740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x3A6CC00", Offset = "0x3A6BA00", VA = "0x183A6CC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private struct GEKOHNOCKFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public AsyncTaskMethodBuilder<ANALHMKOLNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public HCHFGCGNNOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public IENJOFGBOJJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private TaskAwaiter<(DOFOBNGPBFN.AHEDDOMINFH roomDataUpload, DOFOBNGPBFN.AHEDDOMINFH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private TaskAwaiter<ANALHMKOLNC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x3A74020", Offset = "0x3A72E20", VA = "0x183A74020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x3A743B0", Offset = "0x3A731B0", VA = "0x183A743B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class BHPOFNNFHHL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000685")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000686")]
			public AsyncTaskMethodBuilder<BNAMHEGAPHG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000687")]
			public BHPOFNNFHHL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000688")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000689")]
			private BNAMHEGAPHG <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400068A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400068B")]
			private TaskAwaiter<ANALHMKOLNC> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400068C")]
			private TaskAwaiter<LAHOMKBPNPM> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400068D")]
			private TaskAwaiter<BNAMHEGAPHG> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x39C7800", Offset = "0x39C6600", VA = "0x1839C7800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x39C83E0", Offset = "0x39C71E0", VA = "0x1839C83E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public HCHFGCGNNOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public IENJOFGBOJJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public CGKIAAJADJO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public MDPJPGJEHCC roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ACAB0", Offset = "0x6ABEB0")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BHPOFNNFHHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x3A6C600", Offset = "0x3A6B400", VA = "0x183A6C600")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<BNAMHEGAPHG> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct PLHHFJHKEFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public AsyncTaskMethodBuilder<BNAMHEGAPHG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public HCHFGCGNNOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public IENJOFGBOJJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public CGKIAAJADJO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public MDPJPGJEHCC roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ACB60", Offset = "0x6ABF60")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private TaskAwaiter<BNAMHEGAPHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x3A7DB50", Offset = "0x3A7C950", VA = "0x183A7DB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x3A7DE10", Offset = "0x3A7CC10", VA = "0x183A7DE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000658")]
	private const float IHCKEAOLELI = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000659")]
	private readonly NNANKNBNIOG ELFMLANLFAG;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private PPDJPHHFIJM CHNGMAGIGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x28838F0", Offset = "0x28826F0", VA = "0x1828838F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x2883E00", Offset = "0x2882C00", VA = "0x182883E00")]
	public HCHFGCGNNOO(MHCLGBNNENN OMGKKPHIJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x2883780", Offset = "0x2882580", VA = "0x182883780")]
	[AsyncStateMachine(typeof(MPGPLBHPJKE))]
	private Task<(DOFOBNGPBFN.AHEDDOMINFH, DOFOBNGPBFN.AHEDDOMINFH)> AHPIHLJKMNE(IENJOFGBOJJ KLECAGPMPEJ, long GJDNMGJBIPD, long EOEOMNAMOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x2883920", Offset = "0x2882720", VA = "0x182883920")]
	[AsyncStateMachine(typeof(CBAFKDLAEBN))]
	public Task<LAHOMKBPNPM> KCMHPMNNLGM(int AJMHEOJBMOO, [CanBeNull] CGKIAAJADJO NIIJACDKHBG, IENJOFGBOJJ KLECAGPMPEJ, long GJDNMGJBIPD, long EOEOMNAMOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x2883AB0", Offset = "0x28828B0", VA = "0x182883AB0")]
	[AsyncStateMachine(typeof(GEKOHNOCKFK))]
	private Task<ANALHMKOLNC> KNHOHIFHIOJ(string LNGNOBMKHBG, int AJMHEOJBMOO, IENJOFGBOJJ KLECAGPMPEJ, long GJDNMGJBIPD, long EOEOMNAMOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x2883C40", Offset = "0x2882A40", VA = "0x182883C40")]
	[AsyncStateMachine(typeof(PLHHFJHKEFG))]
	public Task<BNAMHEGAPHG> MNJIBIMJJEN(int AJMHEOJBMOO, CGKIAAJADJO? NIIJACDKHBG, IENJOFGBOJJ KLECAGPMPEJ, long GJDNMGJBIPD, long EOEOMNAMOHH, MDPJPGJEHCC MIKDHLNLDME, EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
public abstract class HDNNEAPMMKF<T> where T : global::HDNNEAPMMKF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	internal readonly PPDJPHHFIJM GBMJKOALPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private int? PDGHKLAPOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	protected readonly Guid FPNGEBBIFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	protected readonly OEIBDBJPPKE KGMCNAIIKFD;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	protected T CMHHAKJHNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x3236D70", Offset = "0x3235B70", VA = "0x183236D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x3237010", Offset = "0x3235E10", VA = "0x183237010")]
	internal HDNNEAPMMKF(PPDJPHHFIJM HHHNJDHCCIP, OEIBDBJPPKE BLIFIBIKDIM, [Optional] Guid? HBBMBELBIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x3236DD0", Offset = "0x3235BD0", VA = "0x183236DD0")]
	private BNAMHEGAPHG ILGPLLKAKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "4")]
	protected virtual void JIBDPHLGDBK(BNAMHEGAPHG GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x3236F30", Offset = "0x3235D30", VA = "0x183236F30")]
	public T PCCFDKCNLOC(ECDFOCMBGHG FDHCKLIPOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x3236EB0", Offset = "0x3235CB0", VA = "0x183236EB0")]
	public T LGIACILKOEE(int EAFOBKINPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x3236C70", Offset = "0x3235A70", VA = "0x183236C70", Slot = "5")]
	public virtual Task<CMMKJOOIFOH> CJGFGMPEKJL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public class ICHHHHDLGAH : global::HDNNEAPMMKF<ICHHHHDLGAH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private HAMOGNLMBNC HIHKKNOLPAP;

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x28849A0", Offset = "0x28837A0", VA = "0x1828849A0")]
	internal ICHHHHDLGAH(PPDJPHHFIJM HHHNJDHCCIP, OEIBDBJPPKE BLIFIBIKDIM, [Optional] Guid? HBBMBELBIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x28848C0", Offset = "0x28836C0", VA = "0x1828848C0")]
	public ICHHHHDLGAH BDLEANGFMOJ(HAMOGNLMBNC HIHKKNOLPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x28848E0", Offset = "0x28836E0", VA = "0x1828848E0", Slot = "4")]
	protected override void JIBDPHLGDBK(BNAMHEGAPHG GPAOLHFLBHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
public class LJNECJMOFCO : global::HDNNEAPMMKF<LJNECJMOFCO>
{
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	internal enum CIFIPMLOGFB
	{
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct PILMALCAHJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public AsyncTaskMethodBuilder<CMMKJOOIFOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public LJNECJMOFCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private TaskAwaiter<CMMKJOOIFOH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x39C38B0", Offset = "0x39C26B0", VA = "0x1839C38B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x39C3BB0", Offset = "0x39C29B0", VA = "0x1839C3BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private CIFIPMLOGFB HOAFBHLBFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private string OGJKODOOFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private CGKIAAJADJO HIHKKNOLPAP;

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x2892F10", Offset = "0x2891D10", VA = "0x182892F10")]
	internal LJNECJMOFCO(PPDJPHHFIJM HHHNJDHCCIP, OEIBDBJPPKE BLIFIBIKDIM, [Optional] Guid? HBBMBELBIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x2892CB0", Offset = "0x2891AB0", VA = "0x182892CB0")]
	public LJNECJMOFCO FKADCAPEBNJ(string GMCKDEIFKJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x2892CE0", Offset = "0x2891AE0", VA = "0x182892CE0")]
	public LJNECJMOFCO GIBMIBLFDFO(bool HPOGECILHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x2892D00", Offset = "0x2891B00", VA = "0x182892D00")]
	public LJNECJMOFCO JGFCMJFOOFM(string DIHIPMILEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x2892EA0", Offset = "0x2891CA0", VA = "0x182892EA0")]
	public LJNECJMOFCO LCJFMOEEJJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x2892D30", Offset = "0x2891B30", VA = "0x182892D30", Slot = "4")]
	protected override void JIBDPHLGDBK(BNAMHEGAPHG GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x2892B90", Offset = "0x2891990", VA = "0x182892B90", Slot = "5")]
	[AsyncStateMachine(typeof(PILMALCAHJC))]
	public override Task<CMMKJOOIFOH> CJGFGMPEKJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x2892ED0", Offset = "0x2891CD0", VA = "0x182892ED0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<CMMKJOOIFOH> PDICOCFLFIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
internal static class MOMINGOAAMI
{
	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x31D1100", Offset = "0x31CFF00", VA = "0x1831D1100")]
	public static void JIDHMOGPDFM(this MGJOBLLJJHL DAGFDJKHKPA, OPEMBDFJMKA CCBKDGCANFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x31D1020", Offset = "0x31CFE20", VA = "0x1831D1020")]
	public static void DMLKNKLOHGG(this OPEMBDFJMKA DFCLCBILPLD, [Optional] string GPAOLHFLBHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public static class PINHHKNBNCB
{
	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x31D9D70", Offset = "0x31D8B70", VA = "0x1831D9D70")]
	public static JBPGEGNDOLF KIEBMMCCFKO(this DJNBLLILKNJ EJCCAPEIJHK)
	{
		return default(JBPGEGNDOLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x31D9E10", Offset = "0x31D8C10", VA = "0x1831D9E10")]
	public static DJNBLLILKNJ NAIBCOEDHOJ(this JBPGEGNDOLF GNOJCKHHECD)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006AE")]
			public NHHCNMIONKA ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006AF")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006B0")]
			public NHHCNMIONKA HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006B1")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006B2")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006B3")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private static NHHCNMIONKA[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private Dictionary<NHHCNMIONKA, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x31DBC70", Offset = "0x31DAA70", VA = "0x1831DBC70")]
		public bool DNINIEDMPBG(NHHCNMIONKA IIJAOKEIPOK, out ResultConfig GHGEODFGMEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x31DBB50", Offset = "0x31DA950", VA = "0x1831DBB50")]
		public ResultConfig BDFONIKDIIA(NHHCNMIONKA PDFOLHHIIFI, [Optional] HashSet<NHHCNMIONKA> FNFLKIIGBLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x31DC260", Offset = "0x31DB060", VA = "0x1831DC260", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x31DBCE0", Offset = "0x31DAAE0", VA = "0x1831DBCE0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xE8B1B0", Offset = "0xE89FB0", VA = "0x180E8B1B0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public static class FGEHCGBNGIE
{
	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x2880470", Offset = "0x287F270", VA = "0x182880470")]
	[CFDOMFEMHNO(ANAFFCEINAM.GameOnly)]
	private static void PEBFIEIHMDK(GMLHNNIDAIC LNJPAOGJIFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public interface MBCPJOOJPCB : IEquatable<MBCPJOOJPCB>
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	AABLLNOFLNI HMNICLDLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	DateTime ILADHBGPKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCDABDFMDPM();

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DBDNHDOGEHI(long GJDNMGJBIPD, long HIIJPNGKPPH, out IENJOFGBOJJ KLECAGPMPEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
internal class JHOHJJOJKKP : NHGJBGGAMDL
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class GDDNEMGNBFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public BNJGMAOFPGO autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public GDDNEMGNBFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x3A73FB0", Offset = "0x3A72DB0", VA = "0x183A73FB0")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private readonly HDMLINOBOFH JILNOKPBDHI;

	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private const int GIAMPDLFBDA = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event Action<MBCPJOOJPCB> DIELBKKIPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x28877D0", Offset = "0x28865D0", VA = "0x1828877D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x2887730", Offset = "0x2886530", VA = "0x182887730", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
	[UnityEngine.Scripting.Preserve]
	public JHOHJJOJKKP([HDMGOABMPFL(null)] HDMLINOBOFH JILNOKPBDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x2886F90", Offset = "0x2885D90", VA = "0x182886F90", Slot = "6")]
	public bool FLPFGACIJFP(long GJDNMGJBIPD, long HIIJPNGKPPH, IENJOFGBOJJ KLECAGPMPEJ, BNJGMAOFPGO HIFGKEGLOMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x28872A0", Offset = "0x28860A0", VA = "0x1828872A0")]
	private void GFECOGDFEAB(MBCPJOOJPCB JCPDIHAGMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x2887870", Offset = "0x2886670", VA = "0x182887870", Slot = "7")]
	public bool OPAEOOGMEFM(long GJDNMGJBIPD, long HIIJPNGKPPH, out MBCPJOOJPCB MBHFGKKMFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x28879F0", Offset = "0x28867F0", VA = "0x1828879F0", Slot = "8")]
	public bool PCIMNHAFJDE(long GJDNMGJBIPD, long HIIJPNGKPPH, BNJGMAOFPGO HIFGKEGLOMI, out MBCPJOOJPCB MBHFGKKMFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x2887340", Offset = "0x2886140", VA = "0x182887340")]
	private void HABKHFOMEMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x2886E70", Offset = "0x2885C70", VA = "0x182886E70", Slot = "9")]
	public void ALMEAJNMGBH(long GJDNMGJBIPD, long HIIJPNGKPPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal abstract class EAPIJIMLLJJ : HDMLINOBOFH
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	protected enum LKOMMMLJGCN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class OGMFIJICHJP : IEnumerable<MBCPJOOJPCB>, IEnumerable, IEnumerator<MBCPJOOJPCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private MBCPJOOJPCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public EAPIJIMLLJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private BNJGMAOFPGO autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public BNJGMAOFPGO <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private MBCPJOOJPCB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
		[DebuggerHidden]
		public OGMFIJICHJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x31D6A00", Offset = "0x31D5800", VA = "0x1831D6A00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x31D6C10", Offset = "0x31D5A10", VA = "0x1831D6C10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x31D6B60", Offset = "0x31D5960", VA = "0x1831D6B60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MBCPJOOJPCB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x31D6B60", Offset = "0x31D5960", VA = "0x1831D6B60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private sealed class JNKLDLINOLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public BNJGMAOFPGO autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JNKLDLINOLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x31C8850", Offset = "0x31C7650", VA = "0x1831C8850")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private sealed class BKALMNJMIKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public EAPIJIMLLJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BKALMNJMIKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x31C1D70", Offset = "0x31C0B70", VA = "0x1831C1D70")]
		internal void <TryReadAutosaveFile>b__0(JAHENLJOODF.PGGOOHJPFPC ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	protected readonly string LKEMIOOJOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private readonly object FAADEMHCBEB;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public abstract AABLLNOFLNI HMNICLDLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x2878510", Offset = "0x2877310", VA = "0x182878510")]
	protected EAPIJIMLLJJ([CanBeNull] string HEKDPOEMEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x2878330", Offset = "0x2877130", VA = "0x182878330", Slot = "5")]
	public bool MKEOLNFGCOB(long GJDNMGJBIPD, long HIIJPNGKPPH, BNJGMAOFPGO HIFGKEGLOMI, out MBCPJOOJPCB JCPDIHAGMHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x2878000", Offset = "0x2876E00", VA = "0x182878000", Slot = "6")]
	[IteratorStateMachine(typeof(OGMFIJICHJP))]
	public IEnumerable<MBCPJOOJPCB> FNIJBAJIDLL(BNJGMAOFPGO HIFGKEGLOMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void ELBMGOLKGJI(Stream AGHPCGOKMIH, long GJDNMGJBIPD, long HIIJPNGKPPH, IENJOFGBOJJ KLECAGPMPEJ);

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool NKMKAKOGJAJ(Stream PCLBGPCNFOJ, long GJDNMGJBIPD, long HIIJPNGKPPH, CBMEKFEFLIC HIPKJOOJFPK, out IENJOFGBOJJ KLECAGPMPEJ);

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x2877CB0", Offset = "0x2876AB0", VA = "0x182877CB0", Slot = "7")]
	public MBCPJOOJPCB ENOCBAPIOEB(long GJDNMGJBIPD, long HIIJPNGKPPH, IENJOFGBOJJ KLECAGPMPEJ, BNJGMAOFPGO HIFGKEGLOMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo CMFJOCLEEKC(long GJDNMGJBIPD, long HIIJPNGKPPH, BNJGMAOFPGO HIFGKEGLOMI, LKOMMMLJGCN JHMHMHHKABO);

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo IBKFMPFFCGC(BNJGMAOFPGO HIFGKEGLOMI, LKOMMMLJGCN JHMHMHHKABO);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x2877C40", Offset = "0x2876A40", VA = "0x182877C40")]
	protected void CLKMFCEDJFK(JAHENLJOODF.PGGOOHJPFPC KEEAHECKHLN, string IMOOIIGBLCN, FileInfo DPEGDJOIEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x2878080", Offset = "0x2876E80", VA = "0x182878080")]
	internal bool KOAIJBGEJJB(FileInfo LACALPJAEIC, long GJDNMGJBIPD, long HIIJPNGKPPH, out IENJOFGBOJJ KLECAGPMPEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private void HINPFAPBLPH(Exception NBMLFONNLJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal class EODJDPMPPFK : EAPIJIMLLJJ
{
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private const string LNMKMLEPMEL = "V2";

	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private const string DPKEDICCPFO = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private const string LBNHAPABPCA = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public override AABLLNOFLNI HMNICLDLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x13380D0", Offset = "0x1336ED0", VA = "0x1813380D0", Slot = "8")]
		get
		{
			return default(AABLLNOFLNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x287D950", Offset = "0x287C750", VA = "0x18287D950")]
	public EODJDPMPPFK([Optional] string HEKDPOEMEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x287CEF0", Offset = "0x287BCF0", VA = "0x18287CEF0")]
	private void DGLJDEINNBM(BNJGMAOFPGO HIFGKEGLOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x287CF70", Offset = "0x287BD70", VA = "0x18287CF70", Slot = "9")]
	internal override void ELBMGOLKGJI(Stream AGHPCGOKMIH, long GJDNMGJBIPD, long HIIJPNGKPPH, IENJOFGBOJJ KLECAGPMPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x287D2E0", Offset = "0x287C0E0", VA = "0x18287D2E0", Slot = "10")]
	internal override bool NKMKAKOGJAJ(Stream PCLBGPCNFOJ, long GJDNMGJBIPD, long HIIJPNGKPPH, CBMEKFEFLIC HIPKJOOJFPK, out IENJOFGBOJJ KLECAGPMPEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x287CE00", Offset = "0x287BC00", VA = "0x18287CE00", Slot = "11")]
	protected override FileInfo CMFJOCLEEKC(long GJDNMGJBIPD, long HIIJPNGKPPH, BNJGMAOFPGO HIFGKEGLOMI, LKOMMMLJGCN JHMHMHHKABO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x287D1D0", Offset = "0x287BFD0", VA = "0x18287D1D0", Slot = "12")]
	protected override DirectoryInfo IBKFMPFFCGC(BNJGMAOFPGO HIFGKEGLOMI, LKOMMMLJGCN JHMHMHHKABO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal sealed class KJJEDNMGPHH : EAPIJIMLLJJ
{
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private static readonly byte[] JHANOPJHOLP;

	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private const string DPKEDICCPFO = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private const string LBNHAPABPCA = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private const string KFOKGBHFEKE = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private readonly byte[] FGNGGMMBOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private readonly byte[] GGDLGLADFEH;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public override AABLLNOFLNI HMNICLDLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x812710", Offset = "0x811510", VA = "0x180812710", Slot = "8")]
		get
		{
			return default(AABLLNOFLNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x2891880", Offset = "0x2890680", VA = "0x182891880")]
	public KJJEDNMGPHH([Optional] string HEKDPOEMEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x2890AB0", Offset = "0x288F8B0", VA = "0x182890AB0", Slot = "9")]
	internal override void ELBMGOLKGJI(Stream AGHPCGOKMIH, long GJDNMGJBIPD, long HIIJPNGKPPH, IENJOFGBOJJ KLECAGPMPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x2890F80", Offset = "0x288FD80", VA = "0x182890F80", Slot = "10")]
	internal override bool NKMKAKOGJAJ(Stream PCLBGPCNFOJ, long GJDNMGJBIPD, long HIIJPNGKPPH, CBMEKFEFLIC HIPKJOOJFPK, out IENJOFGBOJJ KLECAGPMPEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x2890E70", Offset = "0x288FC70", VA = "0x182890E70")]
	private void ICLLIPJLPPB(byte[] EMGPHLLIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x2890980", Offset = "0x288F780", VA = "0x182890980", Slot = "11")]
	protected override FileInfo CMFJOCLEEKC(long GJDNMGJBIPD, long HIIJPNGKPPH, BNJGMAOFPGO HIFGKEGLOMI, LKOMMMLJGCN JHMHMHHKABO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x2890D50", Offset = "0x288FB50", VA = "0x182890D50", Slot = "12")]
	protected override DirectoryInfo IBKFMPFFCGC(BNJGMAOFPGO HIFGKEGLOMI, LKOMMMLJGCN JHMHMHHKABO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public enum AABLLNOFLNI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class IGDHFNGKDDC : HDMLINOBOFH
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private sealed class GBDNLOAMNDI : IEnumerable<MBCPJOOJPCB>, IEnumerable, IEnumerator<MBCPJOOJPCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private MBCPJOOJPCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public IGDHFNGKDDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private BNJGMAOFPGO autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public BNJGMAOFPGO <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private AABLLNOFLNI[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private IEnumerator<MBCPJOOJPCB> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private MBCPJOOJPCB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
		[DebuggerHidden]
		public GBDNLOAMNDI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A73900", Offset = "0x3A72700", VA = "0x183A73900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x3A73530", Offset = "0x3A72330", VA = "0x183A73530", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A73990", Offset = "0x3A72790", VA = "0x183A73990")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x3A738C0", Offset = "0x3A726C0", VA = "0x183A738C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x3A73810", Offset = "0x3A72610", VA = "0x183A73810", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MBCPJOOJPCB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A73810", Offset = "0x3A72610", VA = "0x183A73810", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private readonly AABLLNOFLNI[] PPHIAPEHAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private readonly Dictionary<AABLLNOFLNI, HDMLINOBOFH> OFPNIOJHEJL;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public AABLLNOFLNI HMNICLDLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2885810", Offset = "0x2884610", VA = "0x182885810", Slot = "4")]
		get
		{
			return default(AABLLNOFLNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x28859B0", Offset = "0x28847B0", VA = "0x1828859B0")]
	[UnityEngine.Scripting.Preserve]
	public IGDHFNGKDDC(params HDMLINOBOFH[] BEHKIJNPDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x2885850", Offset = "0x2884650", VA = "0x182885850", Slot = "5")]
	public bool MKEOLNFGCOB(long GJDNMGJBIPD, long HIIJPNGKPPH, BNJGMAOFPGO HIFGKEGLOMI, out MBCPJOOJPCB JCPDIHAGMHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x2885550", Offset = "0x2884350", VA = "0x182885550")]
	private void FHAIDFNNMMK(int CFNDAEDCJKE, long GJDNMGJBIPD, long HIIJPNGKPPH, BNJGMAOFPGO HIFGKEGLOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x2885790", Offset = "0x2884590", VA = "0x182885790", Slot = "6")]
	[IteratorStateMachine(typeof(GBDNLOAMNDI))]
	public IEnumerable<MBCPJOOJPCB> FNIJBAJIDLL(BNJGMAOFPGO HIFGKEGLOMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x2885460", Offset = "0x2884260", VA = "0x182885460", Slot = "7")]
	public MBCPJOOJPCB ENOCBAPIOEB(long GJDNMGJBIPD, long HIIJPNGKPPH, IENJOFGBOJJ KLECAGPMPEJ, BNJGMAOFPGO HIFGKEGLOMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
internal static class BHEJOLDHPMO
{
	[Cpp2IlInjected.Token(Token = "0x40006ED")]
	internal const int COMIKAAFFNN = 32;

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x2873AD0", Offset = "0x28728D0", VA = "0x182873AD0")]
	internal static byte[] LLDEHLLBFDP(byte[] EMGPHLLIACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x2873A50", Offset = "0x2872850", VA = "0x182873A50")]
	public static void KLDODMLKHGP(Stream KHIILPEBNKK, byte[] ENNLFCNHNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x2873B70", Offset = "0x2872970", VA = "0x182873B70")]
	public static bool PDFKJCHIEFJ(Stream KHIILPEBNKK, long DHBMAFIJGLP, CBMEKFEFLIC EGMIAKIMPGK, out byte[] LFFMNINCDMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
internal sealed class BIACCADAJDH : MBCPJOOJPCB, IEquatable<MBCPJOOJPCB>, IEquatable<BIACCADAJDH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EE")]
	private readonly EAPIJIMLLJJ JCFAFIBONNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	public readonly FileInfo PJLOILNHBML;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public AABLLNOFLNI HMNICLDLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xB2E8C0", Offset = "0xB2D6C0", VA = "0x180B2E8C0", Slot = "4")]
		get
		{
			return default(AABLLNOFLNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DateTime ILADHBGPKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x28740C0", Offset = "0x2872EC0", VA = "0x1828740C0", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x28742D0", Offset = "0x28730D0", VA = "0x1828742D0")]
	public BIACCADAJDH(EAPIJIMLLJJ BKENPKHHIHH, FileInfo LACALPJAEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x2874220", Offset = "0x2873020", VA = "0x182874220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x2874160", Offset = "0x2872F60", VA = "0x182874160", Slot = "6")]
	public void JCDABDFMDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x2873D50", Offset = "0x2872B50", VA = "0x182873D50", Slot = "7")]
	public bool DBDNHDOGEHI(long GJDNMGJBIPD, long HIIJPNGKPPH, out IENJOFGBOJJ KLECAGPMPEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x2873F40", Offset = "0x2872D40", VA = "0x182873F40", Slot = "8")]
	public bool Equals(MBCPJOOJPCB IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x2873E90", Offset = "0x2872C90", VA = "0x182873E90", Slot = "9")]
	public bool Equals(BIACCADAJDH IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x2873D90", Offset = "0x2872B90", VA = "0x182873D90", Slot = "0")]
	public override bool Equals(object OJGAEOFIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x2874020", Offset = "0x2872E20", VA = "0x182874020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x1935FB0", Offset = "0x1934DB0", VA = "0x181935FB0")]
	public static bool EJGLOGBEPOL(BIACCADAJDH CJCAMOJJGED, BIACCADAJDH DDMHJAPFCFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x1936470", Offset = "0x1935270", VA = "0x181936470")]
	public static bool IKFCAHNLBFO(BIACCADAJDH CJCAMOJJGED, BIACCADAJDH DDMHJAPFCFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
public delegate void CBMEKFEFLIC(JAHENLJOODF.PGGOOHJPFPC NKADJFACGMI, string GPAOLHFLBHD);
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal interface HDMLINOBOFH
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	AABLLNOFLNI HMNICLDLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MKEOLNFGCOB(long GJDNMGJBIPD, long HIIJPNGKPPH, BNJGMAOFPGO HIFGKEGLOMI, out MBCPJOOJPCB JCPDIHAGMHH);

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<MBCPJOOJPCB> FNIJBAJIDLL(BNJGMAOFPGO HIFGKEGLOMI);

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MBCPJOOJPCB ENOCBAPIOEB(long GJDNMGJBIPD, long HIIJPNGKPPH, IENJOFGBOJJ KLECAGPMPEJ, BNJGMAOFPGO HIFGKEGLOMI);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x288A250", Offset = "0x2889050", VA = "0x18288A250")]
	private static string PKFOMDHOGCM(byte[] EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x2889F00", Offset = "0x2888D00", VA = "0x182889F00")]
	public static string GMEGIIKFFNC(byte[] EMGPHLLIACG, bool PHHFDNEANIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20001AD")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
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
