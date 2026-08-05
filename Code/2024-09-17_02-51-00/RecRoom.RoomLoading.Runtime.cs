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
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using Unity.Profiling;
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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x73110E0", Offset = "0x730FAE0", VA = "0x1873110E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x730E680", Offset = "0x730D080", VA = "0x18730E680", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7315700", Offset = "0x7314100", VA = "0x187315700", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AGIEODFEOEN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72F7E10", Offset = "0x72F6810", VA = "0x1872F7E10")]
	public AGIEODFEOEN(string KFAOBDLOMDC, Exception OCHGOHJLMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class FGBEBIFAJCB : EAJJKDIHBJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MAAOLOAJLHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BOFGPKPACMJ>> <>t__builder;

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
		private TaskAwaiter<CJPLDPAMPDM<BOFGPKPACMJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x730E8A0", Offset = "0x730D2A0", VA = "0x18730E8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x730EAE0", Offset = "0x730D4E0", VA = "0x18730EAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LLLCIIMGMOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<FNBDLJKINKJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<FNBDLJKINKJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7309710", Offset = "0x7308110", VA = "0x187309710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7309920", Offset = "0x7308320", VA = "0x187309920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	[UnityEngine.Scripting.Preserve]
	public FGBEBIFAJCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72FF050", Offset = "0x72FDA50", VA = "0x1872FF050", Slot = "4")]
	[AsyncStateMachine(typeof(MAAOLOAJLHK))]
	public Task<IReadOnlyList<BOFGPKPACMJ>> FKIAKKHDFIH(long FNKMOIJJLLC, long KAEOEGGGCFM, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72FF170", Offset = "0x72FDB70", VA = "0x1872FF170", Slot = "5")]
	[AsyncStateMachine(typeof(LLLCIIMGMOM))]
	public Task<IReadOnlyList<FNBDLJKINKJ>> HFGMMOKGIKK(IReadOnlyList<int> PHPGOIIFJIB, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HPOHFLBBJML : IEquatable<HPOHFLBBJML>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int GHCOECGOHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	FNBDLJKINKJ FKPNHBEFGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime KKLDIHCEKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	PDKGFNPLBAB? KHODNPKLAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HDKDBPIPIMF? GNFJFDGKFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	IMBNLMOHHKK EFEHBFBKFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BFFBEBDHILG> KCEEEEGBEBH();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum IMBNLMOHHKK
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EAJJKDIHBJP
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<BOFGPKPACMJ>> FKIAKKHDFIH(long FNKMOIJJLLC, long KAEOEGGGCFM, [Optional] CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<FNBDLJKINKJ>> HFGMMOKGIKK(IReadOnlyList<int> PHPGOIIFJIB, [Optional] CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class COHJBNAMCAE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class NCONJPKDOFA : HPOHFLBBJML, IEquatable<HPOHFLBBJML>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct NDALCICBPON : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<BFFBEBDHILG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public NCONJPKDOFA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private BLBEHMJAFNE <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<LGKHNIEIJHC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<BFFBEBDHILG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x730F710", Offset = "0x730E110", VA = "0x18730F710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x730FBD0", Offset = "0x730E5D0", VA = "0x18730FBD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly BOFGPKPACMJ BPBJOHMIOFC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int GHCOECGOHJF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x89F660", Offset = "0x89E060", VA = "0x18089F660", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FNBDLJKINKJ FKPNHBEFGEI
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime JOKBPDJKOLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5E83E30", Offset = "0x5E82830", VA = "0x185E83E30", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PDKGFNPLBAB? KHODNPKLAMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1FA9300", Offset = "0x1FA7D00", VA = "0x181FA9300", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HDKDBPIPIMF? GNFJFDGKFJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E83F10", Offset = "0x5E82910", VA = "0x185E83F10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IMBNLMOHHKK EFEHBFBKFHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x923D80", Offset = "0x922780", VA = "0x180923D80", Slot = "10")]
			get
			{
				return default(IMBNLMOHHKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x730F570", Offset = "0x730DF70", VA = "0x18730F570", Slot = "9")]
		[AsyncStateMachine(typeof(NDALCICBPON))]
		public Task<BFFBEBDHILG> KCEEEEGBEBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x730F6B0", Offset = "0x730E0B0", VA = "0x18730F6B0")]
		public NCONJPKDOFA(int CLIBILDFGJD, FNBDLJKINKJ KPBMKMABBAG, BOFGPKPACMJ BPBJOHMIOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x730F460", Offset = "0x730DE60", VA = "0x18730F460", Slot = "11")]
		public bool Equals(HPOHFLBBJML PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x730F3C0", Offset = "0x730DDC0", VA = "0x18730F3C0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x730F670", Offset = "0x730E070", VA = "0x18730F670")]
		private bool KIDDJHOLIGJ(NCONJPKDOFA PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x730F4F0", Offset = "0x730DEF0", VA = "0x18730F4F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class CHMODGDAFID : HPOHFLBBJML, IEquatable<HPOHFLBBJML>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct BHOIKGNAPFC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<BFFBEBDHILG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public CHMODGDAFID <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<BFFBEBDHILG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x72F89B0", Offset = "0x72F73B0", VA = "0x1872F89B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x72F8C00", Offset = "0x72F7600", VA = "0x1872F8C00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly LOPIKBFKNII MNGMJKCJFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly PDKGFNPLBAB MJJNCHHEJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly HDKDBPIPIMF PLPGHLCPDCF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int GHCOECGOHJF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x72F93B0", Offset = "0x72F7DB0", VA = "0x1872F93B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FNBDLJKINKJ FKPNHBEFGEI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x72F9800", Offset = "0x72F8200", VA = "0x1872F9800", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime JOKBPDJKOLM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x72F93F0", Offset = "0x72F7DF0", VA = "0x1872F93F0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PDKGFNPLBAB? KHODNPKLAMC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x72F97B0", Offset = "0x72F81B0", VA = "0x1872F97B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public HDKDBPIPIMF? GNFJFDGKFJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x72F9610", Offset = "0x72F8010", VA = "0x1872F9610", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IMBNLMOHHKK EFEHBFBKFHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x98E810", Offset = "0x98D210", VA = "0x18098E810", Slot = "10")]
			get
			{
				return default(IMBNLMOHHKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x164E420", Offset = "0x164CE20", VA = "0x18164E420")]
		public CHMODGDAFID(LOPIKBFKNII HENLKHJGNOF, PDKGFNPLBAB OBAGLMBCNOC, HDKDBPIPIMF HDDCDLHOGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72F9660", Offset = "0x72F8060", VA = "0x1872F9660", Slot = "9")]
		[AsyncStateMachine(typeof(BHOIKGNAPFC))]
		public Task<BFFBEBDHILG> KCEEEEGBEBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72F94F0", Offset = "0x72F7EF0", VA = "0x1872F94F0", Slot = "11")]
		public bool Equals(HPOHFLBBJML PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x72F9440", Offset = "0x72F7E40", VA = "0x1872F9440", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72F9750", Offset = "0x72F8150", VA = "0x1872F9750")]
		private bool KIDDJHOLIGJ(CHMODGDAFID PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72F9590", Offset = "0x72F7F90", VA = "0x1872F9590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class BAADPMNIKML : HPOHFLBBJML, IEquatable<HPOHFLBBJML>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct LMHGACIFAMI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<BFFBEBDHILG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<BFFBEBDHILG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x730A950", Offset = "0x7309350", VA = "0x18730A950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x730ABB0", Offset = "0x73095B0", VA = "0x18730ABB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly FNBDLJKINKJ AHKDHPKIIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly PDKGFNPLBAB MJJNCHHEJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly HDKDBPIPIMF PLPGHLCPDCF;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int GHCOECGOHJF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x72F7E80", Offset = "0x72F6880", VA = "0x1872F7E80", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public FNBDLJKINKJ FKPNHBEFGEI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime JOKBPDJKOLM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PDKGFNPLBAB? KHODNPKLAMC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x72F8360", Offset = "0x72F6D60", VA = "0x1872F8360", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HDKDBPIPIMF? GNFJFDGKFJD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x72F8160", Offset = "0x72F6B60", VA = "0x1872F8160", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IMBNLMOHHKK EFEHBFBKFHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "10")]
			get
			{
				return default(IMBNLMOHHKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x164E420", Offset = "0x164CE20", VA = "0x18164E420")]
		public BAADPMNIKML(FNBDLJKINKJ KPBMKMABBAG, PDKGFNPLBAB OBAGLMBCNOC, HDKDBPIPIMF HDDCDLHOGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x72F81B0", Offset = "0x72F6BB0", VA = "0x1872F81B0", Slot = "9")]
		[AsyncStateMachine(typeof(LMHGACIFAMI))]
		public Task<BFFBEBDHILG> KCEEEEGBEBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72F7FC0", Offset = "0x72F69C0", VA = "0x1872F7FC0", Slot = "11")]
		public bool Equals(HPOHFLBBJML PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x72F7EA0", Offset = "0x72F68A0", VA = "0x1872F7EA0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x72F80D0", Offset = "0x72F6AD0", VA = "0x1872F80D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x72F8280", Offset = "0x72F6C80", VA = "0x1872F8280")]
		private bool KIDDJHOLIGJ(BAADPMNIKML PLNBHPCFEOK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct NOKCGNLNMHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<HPOHFLBBJML>> <>t__builder;

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
		public COHJBNAMCAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<BOFGPKPACMJ> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<BOFGPKPACMJ>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, FNBDLJKINKJ account, BOFGPKPACMJ roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7310230", Offset = "0x730EC30", VA = "0x187310230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7311070", Offset = "0x730FA70", VA = "0x187311070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct DKGHCINEBMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, FNBDLJKINKJ account, BOFGPKPACMJ roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<BOFGPKPACMJ> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public COHJBNAMCAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<FNBDLJKINKJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x72FCB40", Offset = "0x72FB540", VA = "0x1872FCB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x72FD500", Offset = "0x72FBF00", VA = "0x1872FD500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BGDGALOGHIM FLJKCAFHBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly EAJJKDIHBJP JJHPINMHOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JAKPAJHKCIF JFNJJOKPLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly OPOIEJEJAIC<(long, long), IReadOnlyList<BOFGPKPACMJ>> AGGDNBOENJB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72F9C90", Offset = "0x72F8690", VA = "0x1872F9C90")]
	[UnityEngine.Scripting.Preserve]
	public COHJBNAMCAE([OLJNBPOCBCJ(null)] EAJJKDIHBJP FFANIGDKIED, [OLJNBPOCBCJ(null)] JAKPAJHKCIF DBGICPHMPJC, [OLJNBPOCBCJ(null)] BGDGALOGHIM LBHFEELELCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x72F9A30", Offset = "0x72F8430", VA = "0x1872F9A30")]
	[AsyncStateMachine(typeof(NOKCGNLNMHB))]
	public Task<IList<HPOHFLBBJML>> LADGCLDECCC(long FNKMOIJJLLC, long PIGKPDHCACB, bool HFEIJINBJMA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x72F9890", Offset = "0x72F8290", VA = "0x1872F9890")]
	private bool DEHFEIBKEKH(DateTime? LCGNHPOCJOF, long FNKMOIJJLLC, long PIGKPDHCACB, [Out] LOPIKBFKNII IJOJEOLCKLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x72F9B80", Offset = "0x72F8580", VA = "0x1872F9B80")]
	[AsyncStateMachine(typeof(DKGHCINEBMK))]
	private Task<IReadOnlyList<(int, FNBDLJKINKJ, BOFGPKPACMJ)>> MEJPCJFLLAE(IReadOnlyList<BOFGPKPACMJ> GGCGHAPDHLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JAKPAJHKCIF
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<LOPIKBFKNII> FBCIMONKFKJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GDNNDPGIFAM(long FNKMOIJJLLC, long PIGKPDHCACB, MEHJOEPPCEK NOGJGLJBMOE, CLGBBEAHBHE NFFFIACDANN);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KHALIBNEFPC(long FNKMOIJJLLC, long PIGKPDHCACB, [Out] LOPIKBFKNII IJOJEOLCKLF);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ENPHBHKLMBE(long FNKMOIJJLLC, long PIGKPDHCACB, CLGBBEAHBHE NFFFIACDANN, [Out] LOPIKBFKNII IJOJEOLCKLF);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFMJOGEMJHD(long FNKMOIJJLLC, long PIGKPDHCACB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface KJIJNLHKCML : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JDBKMHAKAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task CGPMFAGANPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMPOEAODNAL(Task KECDGIGMBNG, string DLIKJLMFKCM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface FAFBLHDAJOP : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BFFBEBDHILG> DLJOKENJPCA(LOPIKBFKNII IJOJEOLCKLF);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CNGAAKAAHBP(CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface DFOEFOELAAD : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PDHFKAAJHLH ANHGEHHEBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCEDPDPHCIP();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNFDBMFICIC();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface BMNPGLCOMID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface LPOICFJDFMI
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan OIPGEAMHLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan KFGMGHLNHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan KBDBGDHHPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan NAIHANFKAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool ICHBDKLICIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool DDPLFPIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool HEPFINMBBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int LHDBPJMFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NPEKNNJNAFF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool DIAKHADNPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum GGGKLAANCNC
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum MCHJNCNCMFE
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
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct NNNIMOHICLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long BJOMGIJGFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long KAEOEGGGCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly GGGKLAANCNC JLAAKHANEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception CNOBFBAEOCB;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7310210", Offset = "0x730EC10", VA = "0x187310210")]
	public NNNIMOHICLC(long BJOMGIJGFCE, long KAEOEGGGCFM, GGGKLAANCNC JLAAKHANEHC, [CanBeNull] Exception CNOBFBAEOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x73101C0", Offset = "0x730EBC0", VA = "0x1873101C0")]
	public static NNNIMOHICLC IPHAGGDKEPB(KHOOKALDLHN HEIMGNIKCLH, GGGKLAANCNC JLAAKHANEHC, [Optional] Exception CNOBFBAEOCB)
	{
		return default(NNNIMOHICLC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void NMKPALILNGG(NNNIMOHICLC CFEFAAHHDGD);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface EIBLLKALBEA : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action OFAMBOHCLKO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NMKPALILNGG LFBABMJMFPD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NMKPALILNGG IPMDFEFLPFP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event NMKPALILNGG AOHAKGOKEDJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<MCHJNCNCMFE, bool> OJCJABIILFL;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KICNMDKIGNP();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ECNMNDIJCIK(NNNIMOHICLC CFEFAAHHDGD);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MBAHOJHCGBF(NNNIMOHICLC CFEFAAHHDGD);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OPJODIMAFFD(NNNIMOHICLC CFEFAAHHDGD);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HPHMCNFACHP(MCHJNCNCMFE PGJKOCEAFDN, bool PPGNMKCJKAG);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface LJJCGHGHPFO : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PMNMJKKDNPG();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEEMLBFEEPK();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface MCNHIJKHPJB : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus BAFPIIJOKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EFHOBAHCHCB(KHOOKALDLHN HFHIOLPIJPD, FNJJGBHANJJ KOMFLAAAPDL, CancellationToken LBFDJGLPAMK);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class HOMIHOGIIDG
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x73060A0", Offset = "0x7304AA0", VA = "0x1873060A0")]
	public static bool JILFNHJLCJF(this MCNHIJKHPJB OKLBMJCKNHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate Task AGCLHPCNANP(CancellationToken FLLNLBHFENG, int NCDFAOGECAA, HFNNEAJJBFG LDHBPHKKKGO);
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface BDJAJBONKII : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEALCEDEBIM(AGCLHPCNANP GDAOOCOCFIO);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface BEEALJNDIKM : BLBEHMJAFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken LEHLIJDOKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	JEFLJDHAGDI FNPCHNFJDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	EGBHJBCMIAK BLAOPLDDHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	OMBNPJCAOGA KFPNGNFDPLM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	HIANIBLJMCN DBCHGEHMEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	HNDNOODJKON PJKBCDMJCPB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	CBDLFDNFBLG KOCKKGJEEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HFHGINOGHOO DFDACJOGHNF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	AGACIEIJNOB CBNGDJHNGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	KJIJNLHKCML EEKILKIPEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FAFBLHDAJOP GBHHCDFKAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	EIBLLKALBEA NOMPCFGMHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	LJJCGHGHPFO NLJLPJEGGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	MCNHIJKHPJB JJEBEFBGIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	BDJAJBONKII OBFGJLGNCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	JKAFDPGPODN BILPIEHHFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FICCAOGJBPO CBBNLIHDJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	MCGJBBCJMLP OMENJDCCOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	BHNOOEGGBCE FMKPPEKOGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IABENDKKNAO IDLGDMBEKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	NLFOBJDIJJK KCNNIJDBGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	BBJBMLDCFDB MNMFCHOEGGB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	HJLOFENDNMA DNEGGDNHNDA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	AHOCGFBEOIA JELMOAGPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	EFLEFCBBADG GAPJKBBJOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	DFOEFOELAAD AEFKKDBDHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	LPOICFJDFMI HNBIEIKEEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	APBLLCPLLGK LPKBINPADHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	JAKPAJHKCIF OPMGGFMCCIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EEGEOAIGKHO NLGMLFLBGMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	KKFFKMIIAGB POGFPECMKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	GDFLEMFPAMO LMFGDLONHIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	OAKJPCECMGP LBEOGPDCDJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void OECFFCJACNM(FNJJGBHANJJ CJPKIJGKBBD);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface JKAFDPGPODN : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KFHLAEHFELF FABNFHGMHGJ(Guid FAOKHBLGHEO);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MBEEDABKNGP(Guid FAOKHBLGHEO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AAEGDNBPCOK(Guid FAOKHBLGHEO, Task BMPJEOPADED);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FOADIMFCLFG(Guid FAOKHBLGHEO, BFFBEBDHILG MFKMAFGGAPB);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(BFFBEBDHILG, Task)> GHBLKOBAADB(Guid FAOKHBLGHEO);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface EFBPDKCJLBC : BMNPGLCOMID, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface FICCAOGJBPO : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMKMIINCLAN(DDFNKKNNNOO KFAOBDLOMDC);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFIEOGJLDBC(DDFNKKNNNOO KFAOBDLOMDC);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<JHBLFOFBKFH> HJABMDOJOEF(CancellationToken EMNFCPHPLIP);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface MCGJBBCJMLP : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KFHLAEHFELF JDIHALCHCPA(DDFNKKNNNOO LHFDPAHJLIF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFDGHOOJPPK(Guid FAOKHBLGHEO, Task BMPJEOPADED);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface BHNOOEGGBCE : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BFFBEBDHILG> FMKPPEKOGMH(DDFNKKNNNOO PAKJCFMGCOO);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface IABENDKKNAO : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HHMBNBENNDA> GFGPOFEKHOL(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, KHOOKALDLHN HFHIOLPIJPD, CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface BBJBMLDCFDB : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFFBEBDHILG OBMNEDEFDCL(PDPPFLAPOCL OIGHEJMKIKC);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HHLKOLCPEHJ(string BICLBBDNKCN);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface NLFOBJDIJJK : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DDFNKKNNNOO> MFMFKLFAHAI(DDFNKKNNNOO NEKCFCOLDAN, KPCABNKAIHO INICLHMEMEN, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DDFNKKNNNOO> NNJLIDKBGIN(CancellationToken IONNNJNKLMJ, KPCABNKAIHO INICLHMEMEN);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HPJHGCAGHML GNADJKDOCMN(EDIIHMJKPCA FKALECGNFPE, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HPJHGCAGHML KEBEKCOFKLC(EDIIHMJKPCA FKALECGNFPE, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface HJLOFENDNMA : BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFFBEBDHILG FKGDGLOPBMN(PDPPFLAPOCL OIGHEJMKIKC, JHBLFOFBKFH ACDFMINNBKN);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BFFBEBDHILG CPFFFCBLCEJ(PDPPFLAPOCL CCFJKNIPNFA);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface AHOCGFBEOIA
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHBIDIFJPJO(EFKHNGPIHKB GOPNLHDBBLE);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKPCHOKELED(EFKHNGPIHKB GOPNLHDBBLE);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MJLDLPPCOEE(EFKHNGPIHKB GOPNLHDBBLE);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JKNGJOAIFBO(EFKHNGPIHKB GOPNLHDBBLE);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class EFKHNGPIHKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly KHOOKALDLHN MIBPCHBICPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> OCMGHLEJHCH;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public APPPBJLIGLH<string> OKKNMAFMNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x899040", Offset = "0x897A40", VA = "0x180899040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public EFKHNGPIHKB(KHOOKALDLHN EKJBHGGEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x72FE0F0", Offset = "0x72FCAF0", VA = "0x1872FE0F0")]
	public EFKHNGPIHKB JMPNEFGMOBK(string LFOBGDLOPID, string KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x72FE060", Offset = "0x72FCA60", VA = "0x1872FE060")]
	public bool ABKIMDHJANA([Out] IEnumerable<KeyValuePair<string, string>> CDFLBEOLHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6552C40", Offset = "0x6551640", VA = "0x186552C40")]
	public EFKHNGPIHKB HECIPOFLIEI(APPPBJLIGLH<string> LOIGOPGNFFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface APBLLCPLLGK
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool NJEFPHGOJPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string JBPDMBLKECB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool DKMMLMLDBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JAPDMKFMCKD();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DCMKEGOFLLC JKFECFADAGF(long CBAGNPPEFDD);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BLDDNNGHBEO<GDGMMMLOHOM, PIKJJPNAMNM> FDFDMEEBBPH(long CBAGNPPEFDD);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BLDDNNGHBEO<GDGMMMLOHOM, ANPHFBDJECI> MIPCEFPOOPE(long CBAGNPPEFDD);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BLDDNNGHBEO<long, ODLNIBGADPI> MPODFBOPHFK();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HEBIJNCMHPO(long CBAGNPPEFDD, [Out] bool CBHIPDDMLPF);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> PBPFNMKBHGJ(byte[] FFHNFKPFGJK, byte[] IBGIHNMJLNF, CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface BLBEHMJAFNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool JILFNHJLCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool GJIDLCGDEII
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	FNJJGBHANJJ ADGNEHJLDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action OFAMBOHCLKO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NMKPALILNGG LFBABMJMFPD;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event NMKPALILNGG IPMDFEFLPFP;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NMKPALILNGG AOHAKGOKEDJ;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MCHJNCNCMFE, bool> OJCJABIILFL;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GEEMLBFEEPK();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AJEHHEDFAGG BPBCKFDGMOK();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ILAHAMKAGHN PMDNLPFOBDL();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<BFFBEBDHILG> DLJOKENJPCA(LOPIKBFKNII HENLKHJGNOF);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task CNGAAKAAHBP(CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HNDNOODJKON
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool IJGAPEDDAOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string LIKOOJFLJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLAHDKFKOKL(Scene IGAKIDBPOLA);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task GCNEEBAODGE(HJGNFGCDHNI FPMMMLBHDJJ, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task FAEAOHOIFMD();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task HPEICBHINKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface HIANIBLJMCN
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	JHCJKADOLFD EOEFNJKPLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool LDDACCJMPNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool AGKCDJCBBMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool BJFFGOFPILH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool IAEJLPLLELB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int NIJIPIJGMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool GPFPHJNGMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool ECHGEDDJOJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	byte ABEDPDDCGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	byte DINFEGINBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool BEGENGEHBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool HJFCPBBDEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool JIFPMIABDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float CPGPNLLMAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> CCMOMDEEHLM;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JEFLJDHAGDI HOCBHJDMJMK(JEFLJDHAGDI BFDGPCILEGN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNEJHOBIOHH(JEFLJDHAGDI EOPOOELIKIH);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PDNNBJDNCIC();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task CMBLDGCLHGE(APPPBJLIGLH<string>.LANPOEPHMID KGJMPGOMKOP, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JFBJIENCPBH(float HFLGBGLDNCG);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BAKKBPHIJLB(string MANKBKONOGI);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<MEHHEBAJBML> AONMBHMCFDP();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable DGIJCIODAAA(object EIGKPCONJCB, MEHHEBAJBML DIBMBMDNNMF);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<DFAEJJCMMDK> AMJINEDOHIJ();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PIKJJPNAMNM INLHGANDEIF(IEnumerable<GIFFLNOJBNJ> PCMPKHGEFMC);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JDLEAKFJFHD(int LPOJEHINHEE);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task DJPHDGAHNFB();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MDJOGCIKAIJ();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool FNKNPNKODAA();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task EFHMDFOJGFD(CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task IDBGDOHHGHO(CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<COHODKEGLJJ> PEPCOMJLKNL(DateTime PEJJBHBHKBK, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> KJMNNGKFNAK(CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PMDMACCIPDI(string KFAOBDLOMDC = "", float MCPPIEMELEJ = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CAEKKOPCOEB KBHCDDADHFA(JBKIJJFEMIN FOJIONBHMJM, GJPEDFMPFGK HFOMLLLDCBF, ANPHFBDJECI DILEOHOOPEN, IEnumerable<PersistenceView> KENCFBGEJNC, MDPIPDLAMAN KDDHGGHCICN);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GMDPPMFPPGK(ANPHFBDJECI DILEOHOOPEN);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PIAJFJCIFPP(GIFFLNOJBNJ LBLEGAGFFHC, [In] CAEKKOPCOEB PPBAPDHDPLG);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task CAGKCCHFDDB(ANPHFBDJECI HMKLJBLDGHJ, bool DBNOMKFMHII, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task KDHCFDEHNCK(CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BFGEFBHBMKM(long FNKMOIJJLLC, long KAEOEGGGCFM, LGKHNIEIJHC LFMOELFFHGE, BOFGPKPACMJ PDGPGKOGCJC, MEHJOEPPCEK NOGJGLJBMOE, BPLKLHJMAAG? OAIOGDMPBHC, IGDHBHLHBPD? JGMDEBOCKEO);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void GIFNAPAMPKK(long FNKMOIJJLLC, long KAEOEGGGCFM, IGDHBHLHBPD? JGMDEBOCKEO);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void OGIJFEFIIPE(PersistenceView EDDDHIPANCK);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool CAGEDLHGNLI(PersistenceView NKLHHJOEDHF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool EKOHEKIFLOJ(GIFFLNOJBNJ LBLEGAGFFHC, CHNAKMPIEHA LEMDJDELLGF, [Out] ADINIACMIJA IKIDIKAFKCM);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task DALEEDJBFEN(CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void LEHKPNGECKL();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable PBKFAHPOJHN();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void LAPPBBJFPGF(ANPHFBDJECI HMKLJBLDGHJ, CHNAKMPIEHA LEMDJDELLGF);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> LFHNCBNHHBL(EGBHJBCMIAK BPCHJLBHPKH, CancellationToken IONNNJNKLMJ, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void PHOGCGIMPEG(CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<IPHFHDPNPHJ> MGNDMCOLEBO(HDKDKOBLKLN NEKCFCOLDAN);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<LGKHNIEIJHC> PKLFLPGFILK(long FNKMOIJJLLC, bool GPJJCHFJPEG, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<BOFGPKPACMJ> KHADPLLKJFG(long FNKMOIJJLLC, long KAEOEGGGCFM, long AGBIDMLFJLK, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<BOFGPKPACMJ> DBLDHJCJFCJ(long FNKMOIJJLLC, long KAEOEGGGCFM, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<HDFDHEKBLHP> PNKGFNLLIHA(string HJDICKDHJJJ, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<HDFDHEKBLHP> JFFELNMEIDB(string HJDICKDHJJJ, long FNKMOIJJLLC, long KAEOEGGGCFM, string MLOHFKEBHCJ, LENINMJDNMO.OFPMGLEFMFF LLAPGPIJJLB, LENINMJDNMO.OFPMGLEFMFF IBGIHNMJLNF, int BIENMLJGBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool ALOHKOFJPBM();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool KPGEJKOGEMG();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool IAHPNMIPBBO(IEnumerable<ADINIACMIJA> ONLACHIGAKG);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void HOHJMOBBGCG(List<GameObject> EHOPKDCHAGH);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float GBFJLGJPKJK();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> EFFLHAHGBON(string BFMPCJDOKPD, LoadSceneMode MGPNIHAOLIP, bool NGJHJADFEEB, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void LLGGEPLEEHF();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void IMCNJHILLBI(bool GCKGFMHINMG);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void IDLDHENGLAO();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void KAKGGHGIFNP();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void BCFLEBGBDFN(KHOOKALDLHN LDIIHKFHGOB);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task OKKNJBLOLOH(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task HNOLFIPMNAA(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task BBNEONKIEIF(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task GFHDPFMGDEN(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable BFPBGMDCCCL();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "73")]
	LOELFNDLHDD HKACLGIFKGN();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task BAAEHGCOKNC(CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface LOELFNDLHDD
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KJABDAEGIEI(CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IEMPCMEBGDC(CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct CAEKKOPCOEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> NBGPLLNGHFN;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum COHODKEGLJJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct JBKIJJFEMIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string GIIPHAELJJP;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JHCJKADOLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	KHOOKALDLHN PCBILONHKIP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	LGKHNIEIJHC BEMILBPFDBH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GPIOLPLJMNL FPFFGOFDJAA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool OFLKEEGOFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool PHKCAGMOFGP
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int NADLEGOLICB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action HJLFKPOKNHN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> DMNHMHKHOEG;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ONGGKFIIDOK();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.FIHIOPIMEAP> JKGDIPILCCC(long CBAGNPPEFDD, [Optional] CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<DOONLKNHPMM> KHOGMKPKMLE();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task IEBCHNDGALP();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(KHOOKALDLHN, FNJJGBHANJJ) PCMPDOCILBC();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EJJAIGEJFIJ KIMFMKOOOBB();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EIIJBLCDLJJ(long CBAGNPPEFDD);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KKAKLPGPIFC(KHOOKALDLHN EKJBHGGEALF, Matchmaking.HACHMPFPOME POBDLJBBBCI, (int Major, int? Minor)? JPKBMOOHKJG);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EFLEFCBBADG
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NFHFPDDIPHD([Out] IEnumerable<int> AHGGCFCBLHP);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEALLLPFBHC(EAFCCNKEDEM FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICNDMHBEEOF(EAFCCNKEDEM FLLNLBHFENG);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MKEFIMJBHHI
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BNLOKDAOAPP(BFFBEBDHILG PEPNKKDPKHK);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface LCALCLGHBHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCLFHPHJFGO(GIDEKABFKGJ.MOACLFEEKNC HKDJNHDFLMA);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGGKAJEDPDF(GIDEKABFKGJ.MOACLFEEKNC HKDJNHDFLMA);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface CBDLFDNFBLG : LCALCLGHBHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFFBEBDHILG PAANLDJLCMM(PDPPFLAPOCL CCFJKNIPNFA);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface HFHGINOGHOO : LCALCLGHBHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFFBEBDHILG OBMNEDEFDCL(PDPPFLAPOCL MBAGFJGPJPM);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface DCMKEGOFLLC
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BCLNLKLFCPB<HJGNFGCDHNI, LBGFPGMHGDG>> PGNMKJOHOEG(string MLOHFKEBHCJ, long CBAGNPPEFDD, long? FNKMOIJJLLC, long? KAEOEGGGCFM, HNDCNJIJLFL.DNNCMLIGBAE CGFMLHAFPII, CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BLDDNNGHBEO<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BCLNLKLFCPB<CKKLNOOKGGD<TData>, LBGFPGMHGDG>> KMCKIBKMOKE(TGetDataArg IOBLLEKOCNN, CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class LMFONLLGHPP : BEEALJNDIKM, BLBEHMJAFNE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct PPNLMKJCPIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<BFFBEBDHILG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public LMFONLLGHPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LOPIKBFKNII autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<BFFBEBDHILG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7314D50", Offset = "0x7313750", VA = "0x187314D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7314FD0", Offset = "0x73139D0", VA = "0x187314FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct CFAIFENDBAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public LMFONLLGHPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x72F9120", Offset = "0x72F7B20", VA = "0x1872F9120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x72F9350", Offset = "0x72F7D50", VA = "0x1872F9350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class CCAOMBIJHIM : IEnumerable<BMNPGLCOMID>, IEnumerable, IEnumerator<BMNPGLCOMID>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private BMNPGLCOMID <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LMFONLLGHPP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		private BMNPGLCOMID System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x993D30", Offset = "0x992730", VA = "0x180993D30")]
		[DebuggerHidden]
		public CCAOMBIJHIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x72F8C70", Offset = "0x72F7670", VA = "0x1872F8C70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x72F90D0", Offset = "0x72F7AD0", VA = "0x1872F90D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x72F9020", Offset = "0x72F7A20", VA = "0x1872F9020", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BMNPGLCOMID> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x72F9020", Offset = "0x72F7A20", VA = "0x1872F9020", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource NCEBEHMFMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly JEFLJDHAGDI EOPOOELIKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool HFIMBOHAJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private ONMMMNEKELP NPJIJBBJFOG;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public EGBHJBCMIAK BLAOPLDDHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898250", VA = "0x180899850", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8999D0", Offset = "0x8983D0", VA = "0x1808999D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public OMBNPJCAOGA KFPNGNFDPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8988B0", Offset = "0x8972B0", VA = "0x1808988B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x898880", Offset = "0x897280", VA = "0x180898880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public HIANIBLJMCN DBCHGEHMEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x898850", Offset = "0x897250", VA = "0x180898850", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8988A0", Offset = "0x8972A0", VA = "0x1808988A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public HNDNOODJKON PJKBCDMJCPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x898870", Offset = "0x897270", VA = "0x180898870", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x898860", Offset = "0x897260", VA = "0x180898860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public CBDLFDNFBLG KOCKKGJEEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x898840", Offset = "0x897240", VA = "0x180898840", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x898890", Offset = "0x897290", VA = "0x180898890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public HFHGINOGHOO DFDACJOGHNF
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x899950", Offset = "0x898350", VA = "0x180899950", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x899980", Offset = "0x898380", VA = "0x180899980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public AGACIEIJNOB CBNGDJHNGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x89F780", Offset = "0x89E180", VA = "0x18089F780", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x89F7B0", Offset = "0x89E1B0", VA = "0x18089F7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public KJIJNLHKCML EEKILKIPEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x89F740", Offset = "0x89E140", VA = "0x18089F740", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x89F720", Offset = "0x89E120", VA = "0x18089F720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public FAFBLHDAJOP GBHHCDFKAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x89F6E0", Offset = "0x89E0E0", VA = "0x18089F6E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x89F700", Offset = "0x89E100", VA = "0x18089F700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public EIBLLKALBEA NOMPCFGMHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9D4320", Offset = "0x9D2D20", VA = "0x1809D4320", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xD3F8B0", Offset = "0xD3E2B0", VA = "0x180D3F8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public LJJCGHGHPFO NLJLPJEGGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x89F620", Offset = "0x89E020", VA = "0x18089F620", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x89F6C0", Offset = "0x89E0C0", VA = "0x18089F6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public MCNHIJKHPJB JJEBEFBGIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x949AA0", Offset = "0x9484A0", VA = "0x180949AA0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x923D60", Offset = "0x922760", VA = "0x180923D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public BDJAJBONKII OBFGJLGNCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x897DE0", Offset = "0x8967E0", VA = "0x180897DE0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x897DC0", Offset = "0x8967C0", VA = "0x180897DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public JKAFDPGPODN BILPIEHHFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x924730", Offset = "0x923130", VA = "0x180924730", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x924210", Offset = "0x922C10", VA = "0x180924210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public EFBPDKCJLBC NJHGMDHPDBD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA93220", Offset = "0xA91C20", VA = "0x180A93220", Slot = "57")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xD26410", Offset = "0xD24E10", VA = "0x180D26410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public FICCAOGJBPO CBBNLIHDJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x96AD90", Offset = "0x969790", VA = "0x18096AD90", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xB9C4C0", Offset = "0xB9AEC0", VA = "0x180B9C4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public MCGJBBCJMLP OMENJDCCOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9E1440", Offset = "0x9DFE40", VA = "0x1809E1440", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xBA4230", Offset = "0xBA2C30", VA = "0x180BA4230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public BHNOOEGGBCE FMKPPEKOGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x976500", Offset = "0x974F00", VA = "0x180976500", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9A9640", Offset = "0x9A8040", VA = "0x1809A9640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public IABENDKKNAO IDLGDMBEKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x897E50", Offset = "0x896850", VA = "0x180897E50", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x897E60", Offset = "0x896860", VA = "0x180897E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public NLFOBJDIJJK KCNNIJDBGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xB0F290", Offset = "0xB0DC90", VA = "0x180B0F290", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xC491E0", Offset = "0xC47BE0", VA = "0x180C491E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public BBJBMLDCFDB MNMFCHOEGGB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xAE22C0", Offset = "0xAE0CC0", VA = "0x180AE22C0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xDEECB0", Offset = "0xDED6B0", VA = "0x180DEECB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public HJLOFENDNMA DNEGGDNHNDA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8E2C20", Offset = "0x8E1620", VA = "0x1808E2C20", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xDEEC90", Offset = "0xDED690", VA = "0x180DEEC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public AHOCGFBEOIA JELMOAGPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x96BF40", Offset = "0x96A940", VA = "0x18096BF40", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xC4A9B0", Offset = "0xC493B0", VA = "0x180C4A9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public EFLEFCBBADG GAPJKBBJOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x921420", Offset = "0x91FE20", VA = "0x180921420", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9218C0", Offset = "0x9202C0", VA = "0x1809218C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public DFOEFOELAAD AEFKKDBDHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9212A0", Offset = "0x91FCA0", VA = "0x1809212A0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xDEEE10", Offset = "0xDED810", VA = "0x180DEEE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public LPOICFJDFMI HNBIEIKEEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xB0F330", Offset = "0xB0DD30", VA = "0x180B0F330", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xDEEDF0", Offset = "0xDED7F0", VA = "0x180DEEDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public APBLLCPLLGK LPKBINPADHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9F5680", Offset = "0x9F4080", VA = "0x1809F5680", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xDEED30", Offset = "0xDED730", VA = "0x180DEED30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public JAKPAJHKCIF OPMGGFMCCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9F5670", Offset = "0x9F4070", VA = "0x1809F5670", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public EEGEOAIGKHO NLGMLFLBGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9763A0", Offset = "0x974DA0", VA = "0x1809763A0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public KKFFKMIIAGB POGFPECMKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x972500", Offset = "0x970F00", VA = "0x180972500", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public GDFLEMFPAMO LMFGDLONHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xD577A0", Offset = "0xD561A0", VA = "0x180D577A0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public OAKJPCECMGP LBEOGPDCDJB
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA0A960", Offset = "0xA09360", VA = "0x180A0A960", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public FNJJGBHANJJ ADGNEHJLDBC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x997EC0", Offset = "0x9968C0", VA = "0x180997EC0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xDEECF0", Offset = "0xDED6F0", VA = "0x180DEECF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private bool NLNLHDAFLCI
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7309A40", Offset = "0x7308440", VA = "0x187309A40", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private bool JELGJKJMDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7309E90", Offset = "0x7308890", VA = "0x187309E90", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private CancellationToken EPGKDCMPHGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x730A460", Offset = "0x7308E60", VA = "0x18730A460", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private JEFLJDHAGDI MDAFNEMMHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action IAKIHPAIPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x730A1D0", Offset = "0x7308BD0", VA = "0x18730A1D0", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x730A290", Offset = "0x7308C90", VA = "0x18730A290", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event NMKPALILNGG AHNEPBFMODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x730A0E0", Offset = "0x7308AE0", VA = "0x18730A0E0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7309AA0", Offset = "0x73084A0", VA = "0x187309AA0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event NMKPALILNGG LPMJADJGMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x730A480", Offset = "0x7308E80", VA = "0x18730A480", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x730A020", Offset = "0x7308A20", VA = "0x18730A020", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event NMKPALILNGG OKEHHEAILCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x730A230", Offset = "0x7308C30", VA = "0x18730A230", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x730A2F0", Offset = "0x7308CF0", VA = "0x18730A2F0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<MCHJNCNCMFE, bool> FMKAGCJKNLD
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x730A080", Offset = "0x7308A80", VA = "0x18730A080", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x730A400", Offset = "0x7308E00", VA = "0x18730A400", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0xDEECF0", Offset = "0xDED6F0", VA = "0x180DEECF0", Slot = "37")]
	public void OECFFCJACNM(FNJJGBHANJJ CJPKIJGKBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x730A4E0", Offset = "0x7308EE0", VA = "0x18730A4E0")]
	[UnityEngine.Scripting.Preserve]
	internal LMFONLLGHPP([OLJNBPOCBCJ(null)] JEFLJDHAGDI EOPOOELIKIH, [OLJNBPOCBCJ(null)] EGBHJBCMIAK BPCHJLBHPKH, [OLJNBPOCBCJ(null)] OMBNPJCAOGA KGLLIKFJBHM, [OLJNBPOCBCJ(null)] HIANIBLJMCN GDGJPCNEJIO, [OLJNBPOCBCJ(null)] HNDNOODJKON JGHPNDDNNFK, [OLJNBPOCBCJ(null)] CBDLFDNFBLG JELMMHODMIB, [OLJNBPOCBCJ(null)] HFHGINOGHOO BEDGHDEFIEF, [OLJNBPOCBCJ(null)] AGACIEIJNOB NIKMEECOFFH, [OLJNBPOCBCJ(null)] KJIJNLHKCML JEKJAIKFHDJ, [OLJNBPOCBCJ(null)] FAFBLHDAJOP IMKNICAHAJK, [OLJNBPOCBCJ(null)] EIBLLKALBEA NMPHPKABOGC, [OLJNBPOCBCJ(null)] LJJCGHGHPFO GHCGPKFFHGJ, [OLJNBPOCBCJ(null)] MCNHIJKHPJB OKLBMJCKNHF, [OLJNBPOCBCJ(null)] BDJAJBONKII OBJINCGBDGF, [OLJNBPOCBCJ(null)] JKAFDPGPODN KMKDLONGONK, [OLJNBPOCBCJ(null)] EFBPDKCJLBC POOGABOHHII, [OLJNBPOCBCJ(null)] FICCAOGJBPO GKEJPBNHBNM, [OLJNBPOCBCJ(null)] MCGJBBCJMLP LGFNFNJMPCA, [OLJNBPOCBCJ(null)] BHNOOEGGBCE HGPCMHPOGAF, [OLJNBPOCBCJ(null)] IABENDKKNAO IKBLHDDIIDD, [OLJNBPOCBCJ(null)] BBJBMLDCFDB ACFKCHINHAC, [OLJNBPOCBCJ(null)] NLFOBJDIJJK FPPDDFOBDKA, [OLJNBPOCBCJ(null)] HJLOFENDNMA LANALEKHAFN, [OLJNBPOCBCJ(null)] AHOCGFBEOIA OBNLJBNIOOG, [OLJNBPOCBCJ(null)] EFLEFCBBADG JGAMKLNBBPE, [OLJNBPOCBCJ(null)] LPOICFJDFMI JNHFGLCOILM, [OLJNBPOCBCJ(null)] APBLLCPLLGK GIJAMFOOCEA, [OLJNBPOCBCJ(null)] JAKPAJHKCIF LCKFKNFPEBC, [OLJNBPOCBCJ(null)] EEGEOAIGKHO NDGOGLFJEPL, [OLJNBPOCBCJ(null)] KKFFKMIIAGB KFGOMDKIDIC, [OLJNBPOCBCJ(null)] GDFLEMFPAMO ECMDAHDBBFL, [OLJNBPOCBCJ(null)] OAKJPCECMGP CKBOBBJECCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7309990", Offset = "0x7308390", VA = "0x187309990")]
	private void AIFHKOLJDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7309D00", Offset = "0x7308700", VA = "0x187309D00", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x730A3B0", Offset = "0x7308DB0", VA = "0x18730A3B0", Slot = "50")]
	private void ODHGDPBGANI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7309F10", Offset = "0x7308910", VA = "0x187309F10", Slot = "51")]
	private AJEHHEDFAGG EFCOKHMKJMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x730A140", Offset = "0x7308B40", VA = "0x18730A140", Slot = "52")]
	private ILAHAMKAGHN IKBDMLFLAPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7309BF0", Offset = "0x73085F0", VA = "0x187309BF0", Slot = "53")]
	[AsyncStateMachine(typeof(PPNLMKJCPIG))]
	private Task<BFFBEBDHILG> CBEHJPGIJFL(LOPIKBFKNII IJOJEOLCKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7309B00", Offset = "0x7308500", VA = "0x187309B00", Slot = "54")]
	[AsyncStateMachine(typeof(CFAIFENDBAE))]
	private Task BPBNLNDAOAA(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7309FA0", Offset = "0x73089A0", VA = "0x187309FA0")]
	[IteratorStateMachine(typeof(CCAOMBIJHIM))]
	private IEnumerable<BMNPGLCOMID> FKDBFMMNHKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x730A350", Offset = "0x7308D50", VA = "0x18730A350")]
	[CompilerGenerated]
	private void MHFHPBMMEMA(BMNPGLCOMID INEJDODHNGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class NOFDGLCDNEM : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x116A7A0", Offset = "0x11691A0", VA = "0x18116A7A0")]
	public NOFDGLCDNEM(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class KCINDOGLGFP : AHNHKLJIMLC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct KBAGHJFEMFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public KCINDOGLGFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7307B50", Offset = "0x7306550", VA = "0x187307B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7307E90", Offset = "0x7306890", VA = "0x187307E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly HIANIBLJMCN GDGJPCNEJIO;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x89CB80", Offset = "0x89B580", VA = "0x18089CB80")]
	public KCINDOGLGFP(BEEALJNDIKM BPLHAJDMKHP, HIANIBLJMCN GDGJPCNEJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7307FE0", Offset = "0x73069E0", VA = "0x187307FE0", Slot = "4")]
	[AsyncStateMachine(typeof(KBAGHJFEMFG))]
	public Task<bool> NMGNIPCENHJ(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7307F00", Offset = "0x7306900", VA = "0x187307F00")]
	[CompilerGenerated]
	private object GANJGIFNDHH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class HNGFOCLAJBJ : AHNHKLJIMLC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct GHJDHDFEDMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public HNGFOCLAJBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x73054C0", Offset = "0x7303EC0", VA = "0x1873054C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7305BD0", Offset = "0x73045D0", VA = "0x187305BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly HIANIBLJMCN GDGJPCNEJIO;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private JHCJKADOLFD EOEFNJKPLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7305F20", Offset = "0x7304920", VA = "0x187305F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x89CB80", Offset = "0x89B580", VA = "0x18089CB80")]
	public HNGFOCLAJBJ(BEEALJNDIKM BPLHAJDMKHP, HIANIBLJMCN GDGJPCNEJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7305F70", Offset = "0x7304970", VA = "0x187305F70", Slot = "4")]
	[AsyncStateMachine(typeof(GHJDHDFEDMF))]
	public Task<bool> NMGNIPCENHJ(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7305E40", Offset = "0x7304840", VA = "0x187305E40")]
	[CompilerGenerated]
	private object HEDHMJJHDFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class FBCEAKMGEED : AHNHKLJIMLC
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class ADHLJCOLEID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public FBCEAKMGEED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public DOONLKNHPMM result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KHOOKALDLHN newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ADHLJCOLEID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x72F7B20", Offset = "0x72F6520", VA = "0x1872F7B20")]
		internal object EHFFLADGFEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x72F7CB0", Offset = "0x72F66B0", VA = "0x1872F7CB0")]
		internal object MFNNHIKJNOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x72F7C10", Offset = "0x72F6610", VA = "0x1872F7C10")]
		internal object JHEEPOKDMFB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct OADDOMMCPAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public FBCEAKMGEED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private ADHLJCOLEID <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<DOONLKNHPMM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7311160", Offset = "0x730FB60", VA = "0x187311160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7311A80", Offset = "0x7310480", VA = "0x187311A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly HIANIBLJMCN GDGJPCNEJIO;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private JHCJKADOLFD EOEFNJKPLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x72FE1C0", Offset = "0x72FCBC0", VA = "0x1872FE1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x89CB80", Offset = "0x89B580", VA = "0x18089CB80")]
	public FBCEAKMGEED(BEEALJNDIKM BPLHAJDMKHP, HIANIBLJMCN GDGJPCNEJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x72FE210", Offset = "0x72FCC10", VA = "0x1872FE210", Slot = "4")]
	[AsyncStateMachine(typeof(OADDOMMCPAL))]
	public Task<bool> NMGNIPCENHJ(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal interface AHNHKLJIMLC
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> NMGNIPCENHJ(CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct AALIJBPMCDF
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class LIEEGOELEJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public BEEALJNDIKM manager;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LIEEGOELEJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x73096C0", Offset = "0x73080C0", VA = "0x1873096C0")]
		internal Task OMMPEDIHJMI(CancellationToken cancellationToken, int roomTotalVersion, HFNNEAJJBFG localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct BHNGHLEPJNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AALIJBPMCDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private LOPIKBFKNII <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<COHODKEGLJJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<BFFBEBDHILG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x72F83B0", Offset = "0x72F6DB0", VA = "0x1872F83B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x72F8940", Offset = "0x72F7340", VA = "0x1872F8940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct MLKKLHNEKAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AALIJBPMCDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x730F040", Offset = "0x730DA40", VA = "0x18730F040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x730F360", Offset = "0x730DD60", VA = "0x18730F360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CancellationToken IONNNJNKLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly BEEALJNDIKM EHABNPPLNPG;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private EGBHJBCMIAK BLAOPLDDHNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x72F7720", Offset = "0x72F6120", VA = "0x1872F7720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private HIANIBLJMCN DBCHGEHMEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x72F7510", Offset = "0x72F5F10", VA = "0x1872F7510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private JHCJKADOLFD EOEFNJKPLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x72F77C0", Offset = "0x72F61C0", VA = "0x1872F77C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private FAFBLHDAJOP GBHHCDFKAGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x72F7770", Offset = "0x72F6170", VA = "0x1872F7770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x215F710", Offset = "0x215E110", VA = "0x18215F710")]
	public AALIJBPMCDF(CancellationToken IONNNJNKLMJ, BEEALJNDIKM EHABNPPLNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x72F7670", Offset = "0x72F6070", VA = "0x1872F7670")]
	public static AGCLHPCNANP ENMBPEMLMNJ(BEEALJNDIKM EHABNPPLNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x72F7560", Offset = "0x72F5F60", VA = "0x1872F7560")]
	[AsyncStateMachine(typeof(BHNGHLEPJNF))]
	public Task<bool> CKOMBPKHALD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x72F7910", Offset = "0x72F6310", VA = "0x1872F7910")]
	private bool JIMNOIKIBNO([Out] LOPIKBFKNII IJOJEOLCKLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x72F7840", Offset = "0x72F6240", VA = "0x1872F7840")]
	[AsyncStateMachine(typeof(MLKKLHNEKAD))]
	private Task ILBHHPCJMNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x72F73E0", Offset = "0x72F5DE0", VA = "0x1872F73E0")]
	private Task<COHODKEGLJJ> ABENPGADLPA(LOPIKBFKNII MJIDNHBNCKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct KFHLAEHFELF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly JKAFDPGPODN KMKDLONGONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Guid FAOKHBLGHEO;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Task<(BFFBEBDHILG, Task)> KMEDLCHNELM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x73086E0", Offset = "0x73070E0", VA = "0x1873086E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x44B3C20", Offset = "0x44B2620", VA = "0x1844B3C20")]
	public KFHLAEHFELF(JKAFDPGPODN KMKDLONGONK, Guid FAOKHBLGHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x73087B0", Offset = "0x73071B0", VA = "0x1873087B0")]
	public TaskAwaiter<(BFFBEBDHILG, Task)> GPOPJKKIDGI()
	{
		return default(TaskAwaiter<(BFFBEBDHILG, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7308610", Offset = "0x7307010", VA = "0x187308610", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct DHKDIANGADC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly TaskCompletionSource<(BFFBEBDHILG, Task)> MMGDAHAFOME;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Task<(BFFBEBDHILG, Task)> KMEDLCHNELM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x72FA8A0", Offset = "0x72F92A0", VA = "0x1872FA8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x72FA9C0", Offset = "0x72F93C0", VA = "0x1872FA9C0")]
	public DHKDIANGADC(TimeSpan PFFHGEAHJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x72FA800", Offset = "0x72F9200", VA = "0x1872FA800")]
	public void BMBOBFBGLLG(Task BMPJEOPADED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x72FA930", Offset = "0x72F9330", VA = "0x1872FA930")]
	public void MOACJMLPKBE(BFFBEBDHILG PEPNKKDPKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x72FA8E0", Offset = "0x72F92E0", VA = "0x1872FA8E0")]
	public void LNAPLNGBALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x72FA770", Offset = "0x72F9170", VA = "0x1872FA770")]
	internal void AANOHGOMHJC(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class OMLBFOACJGP
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class GAFGFAAMKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public BOFGPKPACMJ subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GAFGFAAMKDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x72FF280", Offset = "0x72FDC80", VA = "0x1872FF280")]
		internal bool GHAGCCPOMNO(GPIOLPLJMNL s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x73128A0", Offset = "0x73112A0", VA = "0x1873128A0")]
	public static HHMBNBENNDA GMDNOGMNFLF(long BJOMGIJGFCE, long KAEOEGGGCFM, string HJDICKDHJJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x73127E0", Offset = "0x73111E0", VA = "0x1873127E0")]
	public static HHMBNBENNDA GMDNOGMNFLF(long BJOMGIJGFCE, long KAEOEGGGCFM, GDGMMMLOHOM FFHNFKPFGJK, long AGBIDMLFJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7312420", Offset = "0x7310E20", VA = "0x187312420")]
	public static HHMBNBENNDA GMDNOGMNFLF(IPHFHDPNPHJ JGNPIPGOOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x73125B0", Offset = "0x7310FB0", VA = "0x1873125B0")]
	public static HHMBNBENNDA GMDNOGMNFLF(LGKHNIEIJHC OGKCNNIFDKM, BOFGPKPACMJ JAKOGDCPEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7312930", Offset = "0x7311330", VA = "0x187312930")]
	public static HHMBNBENNDA OBPBMDBIGIO(this HHMBNBENNDA AJFODGMHKJN, LGKHNIEIJHC MMNANGPBKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7312290", Offset = "0x7310C90", VA = "0x187312290")]
	public static HHMBNBENNDA EOLAAHIIODN(this HHMBNBENNDA AJFODGMHKJN, BOFGPKPACMJ IAMDDLEIGBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RecRoom.NoEngine.Common.Preserve]
internal class PDOCNMLDGGI : KJIJNLHKCML, BMNPGLCOMID, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct PCIAHLFNMMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public PDOCNMLDGGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7312A20", Offset = "0x7311420", VA = "0x187312A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x73130A0", Offset = "0x7311AA0", VA = "0x1873130A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly EAFCCNKEDEM IDINOLCNHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private string KLIHFDPLFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Task EFOLPLMNAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool JDBKMHAKAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7313410", Offset = "0x7311E10", VA = "0x187313410", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Task CGPMFAGANPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7313100", Offset = "0x7311B00", VA = "0x187313100", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x89D6B0", Offset = "0x89C0B0", VA = "0x18089D6B0", Slot = "7")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7313190", Offset = "0x7311B90", VA = "0x187313190", Slot = "6")]
	public void HMPOEAODNAL(Task KECDGIGMBNG, string DLIKJLMFKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x73132F0", Offset = "0x7311CF0", VA = "0x1873132F0")]
	[AsyncStateMachine(typeof(PCIAHLFNMMH))]
	private Task KDEMHJHNOAC(Task DDFCFEFDKMO, string DLIKJLMFKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7313440", Offset = "0x7311E40", VA = "0x187313440")]
	public PDOCNMLDGGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class NGAKJEKKADN : DFOEFOELAAD, BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool GOHEMOFIONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private PDHFKAAJHLH CPCILLFOMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private EGBHJBCMIAK BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private LPOICFJDFMI JNHFGLCOILM;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public PDHFKAAJHLH ANHGEHHEBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x730FD20", Offset = "0x730E720", VA = "0x18730FD20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x730FD90", Offset = "0x730E790", VA = "0x18730FD90", Slot = "7")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x730FFD0", Offset = "0x730E9D0", VA = "0x18730FFD0", Slot = "5")]
	public void DCEDPDPHCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7310180", Offset = "0x730EB80", VA = "0x187310180", Slot = "6")]
	public void LNFDBMFICIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x730FF10", Offset = "0x730E910", VA = "0x18730FF10")]
	private Task CPJHHOOGKFN(LGFDOGGLNLF MNKBAIOBLHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7310180", Offset = "0x730EB80", VA = "0x187310180", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public NGAKJEKKADN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class PPAGCONBDOG : LPOICFJDFMI
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class DEGKPELAJPL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly LEBBOCDPOJL JGGOGAFIBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly string LFOBGDLOPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly T MCAGMGIJFIA;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public T PGPGCBGPPOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x923890", Offset = "0x922290", VA = "0x180923890")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x923B70", Offset = "0x922570", VA = "0x180923B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x5B33260", Offset = "0x5B31C60", VA = "0x185B33260")]
		public DEGKPELAJPL(LEBBOCDPOJL JGGOGAFIBCM, string LFOBGDLOPID, T MCAGMGIJFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x5B32D60", Offset = "0x5B31760", VA = "0x185B32D60")]
		private void JMODJPHPING()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly LEBBOCDPOJL JGGOGAFIBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly DEGKPELAJPL<TimeSpan> GLHCADKHIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly DEGKPELAJPL<TimeSpan> ONBHFIIALCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly DEGKPELAJPL<TimeSpan> PKBPDLHGECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly DEGKPELAJPL<TimeSpan> GOFKPJGMOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly DEGKPELAJPL<bool> BKILDLJMANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly DEGKPELAJPL<bool> LHHOBBIGCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly DEGKPELAJPL<bool> NBPJHEANHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly DEGKPELAJPL<int> DAOPLJDLGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly DEGKPELAJPL<bool> MGAMODBLDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly DEGKPELAJPL<bool> KFCIDPGNKIB;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TimeSpan OIPGEAMHLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7314820", Offset = "0x7313220", VA = "0x187314820", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TimeSpan KFGMGHLNHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7314860", Offset = "0x7313260", VA = "0x187314860", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TimeSpan KBDBGDHHPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7314660", Offset = "0x7313060", VA = "0x187314660", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public TimeSpan NAIHANFKAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7314760", Offset = "0x7313160", VA = "0x187314760", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool ICHBDKLICIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x73147E0", Offset = "0x73131E0", VA = "0x1873147E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool DDPLFPIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x73146E0", Offset = "0x73130E0", VA = "0x1873146E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool HEPFINMBBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7314720", Offset = "0x7313120", VA = "0x187314720", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int LHDBPJMFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x73148A0", Offset = "0x73132A0", VA = "0x1873148A0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool NPEKNNJNAFF
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x73147A0", Offset = "0x73131A0", VA = "0x1873147A0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool DIAKHADNPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x73146A0", Offset = "0x73130A0", VA = "0x1873146A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x73148E0", Offset = "0x73132E0", VA = "0x1873148E0")]
	[UnityEngine.Scripting.Preserve]
	public PPAGCONBDOG([OLJNBPOCBCJ(null)] LEBBOCDPOJL JGGOGAFIBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class DNCOOIEPAIA : EIBLLKALBEA, BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class NEFGKGAPCOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public NNNIMOHICLC roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NEFGKGAPCOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x730FC40", Offset = "0x730E640", VA = "0x18730FC40")]
		internal object HPPPKHKIOPP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action OFAMBOHCLKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x72FD8D0", Offset = "0x72FC2D0", VA = "0x1872FD8D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x72FD750", Offset = "0x72FC150", VA = "0x1872FD750", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event NMKPALILNGG LFBABMJMFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x72FD6B0", Offset = "0x72FC0B0", VA = "0x1872FD6B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x72FDD70", Offset = "0x72FC770", VA = "0x1872FDD70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event NMKPALILNGG IPMDFEFLPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x72FD610", Offset = "0x72FC010", VA = "0x1872FD610", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x72FDEF0", Offset = "0x72FC8F0", VA = "0x1872FDEF0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event NMKPALILNGG AOHAKGOKEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x72FDF90", Offset = "0x72FC990", VA = "0x1872FDF90", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x72FD570", Offset = "0x72FBF70", VA = "0x1872FD570", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<MCHJNCNCMFE, bool> OJCJABIILFL
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x72FD820", Offset = "0x72FC220", VA = "0x1872FD820", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x72FDE40", Offset = "0x72FC840", VA = "0x1872FDE40", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "19")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x72FDB80", Offset = "0x72FC580", VA = "0x1872FDB80", Slot = "14")]
	public void KICNMDKIGNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x72FD7F0", Offset = "0x72FC1F0", VA = "0x1872FD7F0", Slot = "15")]
	public void ECNMNDIJCIK(NNNIMOHICLC CFEFAAHHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x72FDE10", Offset = "0x72FC810", VA = "0x1872FDE10", Slot = "16")]
	public void MBAHOJHCGBF(NNNIMOHICLC CFEFAAHHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x72FE030", Offset = "0x72FCA30", VA = "0x1872FE030", Slot = "17")]
	public void OPJODIMAFFD(NNNIMOHICLC CFEFAAHHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x72FDB30", Offset = "0x72FC530", VA = "0x1872FDB30", Slot = "18")]
	public void HPHMCNFACHP(MCHJNCNCMFE PGJKOCEAFDN, bool PPGNMKCJKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x72FD970", Offset = "0x72FC370", VA = "0x1872FD970")]
	private void FJEDBGMGJGG(NMKPALILNGG DIBMBMDNNMF, NNNIMOHICLC CFEFAAHHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public DNCOOIEPAIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal class FBEHHEFAOGB : LJJCGHGHPFO, BMNPGLCOMID, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct KFCJPJLHAEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public FBEHHEFAOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x73080D0", Offset = "0x7306AD0", VA = "0x1873080D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x73085B0", Offset = "0x7306FB0", VA = "0x1873085B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct OKGIDBLGCBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public FBEHHEFAOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7311B60", Offset = "0x7310560", VA = "0x187311B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x73121C0", Offset = "0x7310BC0", VA = "0x1873121C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class OBCAKODGKMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public OBCAKODGKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7311AF0", Offset = "0x73104F0", VA = "0x187311AF0")]
		internal object IKBEJJKPAJA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct GBCPEBGGEIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public FBEHHEFAOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private OBCAKODGKMH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x72FF2B0", Offset = "0x72FDCB0", VA = "0x1872FF2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x72FF9F0", Offset = "0x72FE3F0", VA = "0x1872FF9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class OMIFFFCIGCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public OMIFFFCIGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x7312220", Offset = "0x7310C20", VA = "0x187312220")]
		internal object OGFEHAPJNDG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private HIANIBLJMCN GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private AHNHKLJIMLC[] CEKBKKJPLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private CancellationTokenSource ADHBHFEGLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private int GALBAEEHDDF;

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x72FE330", Offset = "0x72FCD30", VA = "0x1872FE330", Slot = "6")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x72FE490", Offset = "0x72FCE90", VA = "0x1872FE490", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x72FE4A0", Offset = "0x72FCEA0", VA = "0x1872FE4A0", Slot = "8")]
	public void FFPCHLDHDDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x72FE6D0", Offset = "0x72FD0D0", VA = "0x1872FE6D0", Slot = "5")]
	public void GEEMLBFEEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x72FEF00", Offset = "0x72FD900", VA = "0x1872FEF00", Slot = "4")]
	[AsyncStateMachine(typeof(KFCJPJLHAEC))]
	public Task PMNMJKKDNPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x72FEAF0", Offset = "0x72FD4F0", VA = "0x1872FEAF0")]
	private void NDIIKBMLNDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x72FEE00", Offset = "0x72FD800", VA = "0x1872FEE00")]
	[AsyncStateMachine(typeof(OKGIDBLGCBP))]
	private Task NOFFJODEKMM(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x72FE9B0", Offset = "0x72FD3B0", VA = "0x1872FE9B0")]
	[AsyncStateMachine(typeof(GBCPEBGGEIP))]
	private Task<bool> LELBEBBIKAC(int HGFDMIDEFHN, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x72FE8D0", Offset = "0x72FD2D0", VA = "0x1872FE8D0")]
	private void JPJEJLPCEPL(int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x72FE3B0", Offset = "0x72FCDB0", VA = "0x1872FE3B0")]
	private void BNMHBFOOKBN(int HGFDMIDEFHN, bool PPGNMKCJKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x72FE7A0", Offset = "0x72FD1A0", VA = "0x1872FE7A0")]
	private void GINGAOAKDJC(int HGFDMIDEFHN, Exception NJACFNFHNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x72FE5A0", Offset = "0x72FCFA0", VA = "0x1872FE5A0")]
	private void GCALAFDGNCE(CancellationToken IONNNJNKLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public FBEHHEFAOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.NoEngine.Common.Preserve]
internal class LPOIBHCDGHI : MCNHIJKHPJB, BMNPGLCOMID, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct CPIMCLKODNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public KHOOKALDLHN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public LPOIBHCDGHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public FNJJGBHANJJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x72F9DC0", Offset = "0x72F87C0", VA = "0x1872F9DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x72FA710", Offset = "0x72F9110", VA = "0x1872FA710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct KNDDINNBGCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public LPOIBHCDGHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public KHOOKALDLHN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public FNJJGBHANJJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private APPPBJLIGLH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private GFHOFHONACH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private KPCABNKAIHO <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private EFKHNGPIHKB <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7308800", Offset = "0x7307200", VA = "0x187308800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7309490", Offset = "0x7307E90", VA = "0x187309490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class IOLNFPFMMBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Matchmaking.HACHMPFPOME result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public LAMMFHOBGJG errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public IOLNFPFMMBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x73072E0", Offset = "0x7305CE0", VA = "0x1873072E0")]
		internal object NNMIDEKKCIO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class PHGEEJAKNGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Task<HHMBNBENNDA> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public PHGEEJAKNGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		internal Task<HHMBNBENNDA> NKHJIAJDLBI(APPPBJLIGLH<string>.LANPOEPHMID _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct GEEFLKGFBNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public LPOIBHCDGHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public KHOOKALDLHN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public FNJJGBHANJJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public KPCABNKAIHO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private PHGEEJAKNGG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private DEDDEELPDLO <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private GFHOFHONACH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private APPPBJLIGLH<string>.LANPOEPHMID <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private NHPDOFIEOLC <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Task<Matchmaking.FIHIOPIMEAP> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private PDAOGCILCGI <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private TaskAwaiter<Matchmaking.FIHIOPIMEAP> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter<HHMBNBENNDA> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x72FFA60", Offset = "0x72FE460", VA = "0x1872FFA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7305460", Offset = "0x7303E60", VA = "0x187305460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct IGJLBFPGJIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public LPOIBHCDGHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private APPPBJLIGLH<string>.LANPOEPHMID <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x73060F0", Offset = "0x7304AF0", VA = "0x1873060F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7306B30", Offset = "0x7305530", VA = "0x187306B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct MKOJIFHMKPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public LPOIBHCDGHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private JEFLJDHAGDI <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x730EB50", Offset = "0x730D550", VA = "0x18730EB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x730EFE0", Offset = "0x730D9E0", VA = "0x18730EFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct PDPDDBGLPPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<Matchmaking.FIHIOPIMEAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public KHOOKALDLHN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public LPOIBHCDGHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter<Matchmaking.FIHIOPIMEAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x73134D0", Offset = "0x7311ED0", VA = "0x1873134D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x73139D0", Offset = "0x73123D0", VA = "0x1873139D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct IIFIAFOHGGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Matchmaking.FIHIOPIMEAP serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public LPOIBHCDGHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public KPCABNKAIHO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter<CCNMINLGMMG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7306B90", Offset = "0x7305590", VA = "0x187306B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7307280", Offset = "0x7305C80", VA = "0x187307280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class GLNHMIJAFGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public KHOOKALDLHN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GLNHMIJAFGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7305C40", Offset = "0x7304640", VA = "0x187305C40")]
		internal object BHOPBBGBCGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7305D40", Offset = "0x7304740", VA = "0x187305D40")]
		internal string IDALCFDEIFN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct PEKMEDDBJAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public KHOOKALDLHN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public LPOIBHCDGHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private GLNHMIJAFGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7313A40", Offset = "0x7312440", VA = "0x187313A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7314600", Offset = "0x7313000", VA = "0x187314600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct DIIHEHOACKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public LPOIBHCDGHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public KPCABNKAIHO joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public HHMBNBENNDA initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public KHOOKALDLHN targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public DEDDEELPDLO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private APPPBJLIGLH<string>.LANPOEPHMID <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x72FC1D0", Offset = "0x72FABD0", VA = "0x1872FC1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x72FCAE0", Offset = "0x72FB4E0", VA = "0x1872FCAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct DHLHOGBKMPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public LPOIBHCDGHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private APPPBJLIGLH<string>.LANPOEPHMID <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private GFHOFHONACH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x72FAB40", Offset = "0x72F9540", VA = "0x1872FAB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x72FC170", Offset = "0x72FAB70", VA = "0x1872FC170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct JPHBOBHFLPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public HFNNEAJJBFG localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public LPOIBHCDGHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<BFFBEBDHILG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7307390", Offset = "0x7305D90", VA = "0x187307390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7307AF0", Offset = "0x73064F0", VA = "0x187307AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class LGBNJNFAFCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public KHOOKALDLHN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LGBNJNFAFCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x73094F0", Offset = "0x7307EF0", VA = "0x1873094F0")]
		internal object AKMDAEOOIGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class DOLADLGPCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public DOLADLGPCHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x731EB30", Offset = "0x731D530", VA = "0x18731EB30")]
		internal void OCNCGFGIAIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class KGCMPFGNPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public KHOOKALDLHN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public KGCMPFGNPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x732DE80", Offset = "0x732C880", VA = "0x18732DE80")]
		internal object CKIKJIMDEJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class LNEFNIGCCAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public KHOOKALDLHN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LNEFNIGCCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x732FF90", Offset = "0x732E990", VA = "0x18732FF90")]
		internal string CPHMGHJOIDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly CMICIECANPG LKKMJBJLDKB;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly CMICIECANPG OKFAFIFCBGP;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly CMICIECANPG IDFDNFNHPJJ;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string GGHJJGNKNOD;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string FPLEOBOJLBI;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string AJPAJOBNJHC;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly Guid OAKJAOKIADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private AGACIEIJNOB NIKMEECOFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private OMBNPJCAOGA KGLLIKFJBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private EGBHJBCMIAK BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private HIANIBLJMCN GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private LJJCGHGHPFO GHCGPKFFHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private KJIJNLHKCML JEKJAIKFHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private EIBLLKALBEA NMPHPKABOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private KKFFKMIIAGB KFGOMDKIDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private EEGEOAIGKHO NDGOGLFJEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private IDisposable DFJOAFKKCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private OAKJPCECMGP CKBOBBJECCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly EAFCCNKEDEM LKOIEDDMLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private PDAOGCILCGI AKMEPNMDLLJ;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public TaskStatus BAFPIIJOKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8BF000", Offset = "0x8BDA00", VA = "0x1808BF000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xD1D7C0", Offset = "0xD1C1C0", VA = "0x180D1D7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private JHCJKADOLFD EOEFNJKPLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x730C3C0", Offset = "0x730ADC0", VA = "0x18730C3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x730AD50", Offset = "0x7309750", VA = "0x18730AD50", Slot = "6")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x730B540", Offset = "0x7309F40", VA = "0x18730B540", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x730B590", Offset = "0x7309F90", VA = "0x18730B590", Slot = "5")]
	[AsyncStateMachine(typeof(CPIMCLKODNG))]
	public Task EFHOBAHCHCB(KHOOKALDLHN HFHIOLPIJPD, FNJJGBHANJJ KOMFLAAAPDL, CancellationToken LBFDJGLPAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x730BB30", Offset = "0x730A530", VA = "0x18730BB30")]
	[AsyncStateMachine(typeof(KNDDINNBGCB))]
	private Task GBDNEFNOONL(KHOOKALDLHN HFHIOLPIJPD, FNJJGBHANJJ KOMFLAAAPDL, CancellationToken LBFDJGLPAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x730CBB0", Offset = "0x730B5B0", VA = "0x18730CBB0")]
	private void MLDJCAMBJAL(KKFFKMIIAGB KFGOMDKIDIC, KHOOKALDLHN HFHIOLPIJPD, Exception NJACFNFHNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x730D270", Offset = "0x730BC70", VA = "0x18730D270")]
	private static void OEIPJLBJJKH(EFKHNGPIHKB HNIBAPCCNNF, Exception NJACFNFHNDN, [Optional] List<int> HEIGPDOKHLI, int GALBAEEHDDF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x730B080", Offset = "0x7309A80", VA = "0x18730B080")]
	[AsyncStateMachine(typeof(GEEFLKGFBNI))]
	private Task ALKMKNHDONA(APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, KHOOKALDLHN HFHIOLPIJPD, FNJJGBHANJJ KOMFLAAAPDL, KPCABNKAIHO OKFIGIJHEFH, CancellationToken LBFDJGLPAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x730C270", Offset = "0x730AC70", VA = "0x18730C270")]
	private void IFDBCHFJNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x730C500", Offset = "0x730AF00", VA = "0x18730C500")]
	[AsyncStateMachine(typeof(IGJLBFPGJIF))]
	private Task JFAABECJOAN(APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x730DF20", Offset = "0x730C920", VA = "0x18730DF20")]
	private void ONEHKCOPFBJ(KHOOKALDLHN HFHIOLPIJPD, CancellationToken LBFDJGLPAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x730B1E0", Offset = "0x7309BE0", VA = "0x18730B1E0")]
	private void ANMHGEKDPFC(KHOOKALDLHN HFHIOLPIJPD, KPCABNKAIHO OKFIGIJHEFH, OperationCanceledException GHPHNHCPDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x730C030", Offset = "0x730AA30", VA = "0x18730C030")]
	private void HECCNIJFDGE(KHOOKALDLHN HFHIOLPIJPD, KPCABNKAIHO OKFIGIJHEFH, Exception NJACFNFHNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x730B6D0", Offset = "0x730A0D0", VA = "0x18730B6D0")]
	private void FAPFBKECAOC(KHOOKALDLHN HFHIOLPIJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x730C630", Offset = "0x730B030", VA = "0x18730C630")]
	private static NNNIMOHICLC JIGPHIDIODH(KHOOKALDLHN HFHIOLPIJPD)
	{
		return default(NNNIMOHICLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x730CAE0", Offset = "0x730B4E0", VA = "0x18730CAE0")]
	[AsyncStateMachine(typeof(MKOJIFHMKPD))]
	private Task MEAIPNICJPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x730C690", Offset = "0x730B090", VA = "0x18730C690")]
	[AsyncStateMachine(typeof(PDPDDBGLPPC))]
	private Task<Matchmaking.FIHIOPIMEAP> JKGDIPILCCC(KHOOKALDLHN HFHIOLPIJPD, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x730DB10", Offset = "0x730C510", VA = "0x18730DB10")]
	private static CCNMINLGMMG OGKCHFIPAFG(Matchmaking.FIHIOPIMEAP MPPLCAJANEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x730B9E0", Offset = "0x730A3E0", VA = "0x18730B9E0")]
	[AsyncStateMachine(typeof(IIFIAFOHGGL))]
	private Task FOIDMOCMGEB(Matchmaking.FIHIOPIMEAP MPPLCAJANEA, KPCABNKAIHO OKFIGIJHEFH, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken LIPEIAELIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x730C9A0", Offset = "0x730B3A0", VA = "0x18730C9A0")]
	[AsyncStateMachine(typeof(PEKMEDDBJAO))]
	private Task LKMKFMLJJHH(KHOOKALDLHN HFHIOLPIJPD, CancellationTokenSource LABDKMAFGOA, Task AOLJLMLEFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x730DDB0", Offset = "0x730C7B0", VA = "0x18730DDB0")]
	[AsyncStateMachine(typeof(DIIHEHOACKE))]
	private Task OMHLMLGOPBJ(HHMBNBENNDA FIHPFCNBMJB, DEDDEELPDLO OGFHPDOEGDH, KHOOKALDLHN JLHJPBOHLHG, KPCABNKAIHO NNIAJLPMKLA, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken AFLMMJEDAHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x730D020", Offset = "0x730BA20", VA = "0x18730D020")]
	private KPCABNKAIHO MNJNGDLMNPO(KPCABNKAIHO NNIAJLPMKLA, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x730AC20", Offset = "0x7309620", VA = "0x18730AC20")]
	[AsyncStateMachine(typeof(DHLHOGBKMPA))]
	private Task AHBDFNLAAFK(APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x730DC80", Offset = "0x730C680", VA = "0x18730DC80")]
	[AsyncStateMachine(typeof(JPHBOBHFLPC))]
	private Task OJNEGHHOGBK(CancellationToken IONNNJNKLMJ, int NCDFAOGECAA, HFNNEAJJBFG LDHBPHKKKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x730BC80", Offset = "0x730A680", VA = "0x18730BC80")]
	private static void GIJFFINMLPH(KHOOKALDLHN HFHIOLPIJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x730BE00", Offset = "0x730A800", VA = "0x18730BE00")]
	private void GPPFNOIDJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x730B420", Offset = "0x7309E20", VA = "0x18730B420")]
	private void BCCOFEFILDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x730B4B0", Offset = "0x7309EB0", VA = "0x18730B4B0")]
	private void BOIJPHFFEKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x730E250", Offset = "0x730CC50", VA = "0x18730E250")]
	private void PEEFPOOAMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x730C410", Offset = "0x730AE10", VA = "0x18730C410")]
	private static void IJPNEJNECGC(KHOOKALDLHN HFHIOLPIJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x730E2E0", Offset = "0x730CCE0", VA = "0x18730E2E0")]
	private static CancellationTokenRegistration PILDEGBPHDL(KHOOKALDLHN HFHIOLPIJPD, CancellationToken LIPEIAELIIM)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x730B8E0", Offset = "0x730A2E0", VA = "0x18730B8E0")]
	private static void FKMGPADIMJK(KHOOKALDLHN HFHIOLPIJPD, Exception NJACFNFHNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x730C7F0", Offset = "0x730B1F0", VA = "0x18730C7F0")]
	private void KKKOFNJCNEH(KHOOKALDLHN HFHIOLPIJPD, Task AOLJLMLEFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x730DC20", Offset = "0x730C620", VA = "0x18730DC20")]
	private static void OJMFFMAGFPH(Func<string> GGCMALNCNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x730E5F0", Offset = "0x730CFF0", VA = "0x18730E5F0")]
	public LPOIBHCDGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x730D210", Offset = "0x730BC10", VA = "0x18730D210")]
	[CompilerGenerated]
	internal static (int, int?) NHLILPMFBIK(LAMMFHOBGJG JPKBMOOHKJG)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class GPPJIKDKPBM : BDJAJBONKII, BMNPGLCOMID, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct LIHEIGBILCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public GPPJIKDKPBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public HFNNEAJJBFG localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x732F7A0", Offset = "0x732E1A0", VA = "0x18732F7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x732FC00", Offset = "0x732E600", VA = "0x18732FC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class EHOIECMJINO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public GPPJIKDKPBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public HFNNEAJJBFG localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EHOIECMJINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7320F80", Offset = "0x731F980", VA = "0x187320F80")]
		internal List<Task> FHCOAPDJGGE(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct DMFFKDBMEAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public AGCLHPCNANP taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public HFNNEAJJBFG localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x731E6E0", Offset = "0x731D0E0", VA = "0x18731E6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x731EA70", Offset = "0x731D470", VA = "0x18731EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct MJMDFIHOACK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public GPPJIKDKPBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7331620", Offset = "0x7330020", VA = "0x187331620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x73318E0", Offset = "0x73302E0", VA = "0x1873318E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly HashSet<AGCLHPCNANP> JOPIKEFJKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private OMBNPJCAOGA KGLLIKFJBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private MEHHEBAJBML GKEOBEPILKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private LJHCGCJMJGC BGGKKLJPDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private IDisposable DFJOAFKKCLH;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7326480", Offset = "0x7324E80", VA = "0x187326480", Slot = "5")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7326970", Offset = "0x7325370", VA = "0x187326970", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7327360", Offset = "0x7325D60", VA = "0x187327360", Slot = "4")]
	public bool GEALCEDEBIM(AGCLHPCNANP GDAOOCOCFIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x73268A0", Offset = "0x73252A0", VA = "0x1873268A0")]
	private void DIPDICELLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7326AC0", Offset = "0x73254C0", VA = "0x187326AC0")]
	private void FAAADJOAIDG(ANLFOIKADDC LLAPGPIJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7327270", Offset = "0x7325C70", VA = "0x187327270")]
	[AsyncStateMachine(typeof(LIHEIGBILCP))]
	private Task FGHILPGOBBJ(int NCDFAOGECAA, HFNNEAJJBFG LDHBPHKKKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x73273C0", Offset = "0x7325DC0", VA = "0x1873273C0")]
	private Func<CancellationToken, List<Task>> LEHDBEFLKKM(int NCDFAOGECAA, HFNNEAJJBFG LDHBPHKKKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7326CE0", Offset = "0x73256E0", VA = "0x187326CE0")]
	private List<Task> FFOMCJLJOBK(int NCDFAOGECAA, HFNNEAJJBFG LDHBPHKKKGO, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7326780", Offset = "0x7325180", VA = "0x187326780")]
	[AsyncStateMachine(typeof(DMFFKDBMEAG))]
	private Task CDGFFNNAOAP(AGCLHPCNANP POBEKJIJHNB, CancellationToken FLLNLBHFENG, int NCDFAOGECAA, HFNNEAJJBFG LDHBPHKKKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x73269F0", Offset = "0x73253F0", VA = "0x1873269F0")]
	[AsyncStateMachine(typeof(MJMDFIHOACK))]
	private Task EFEIECHPJMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x73271C0", Offset = "0x7325BC0", VA = "0x1873271C0")]
	private void FFPCHLDHDDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7327490", Offset = "0x7325E90", VA = "0x187327490")]
	public GPPJIKDKPBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[UnityEngine.Scripting.Preserve]
internal sealed class HIOCNANOPLH : JKAFDPGPODN, BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class MKBMEJEKIPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public MKBMEJEKIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7331940", Offset = "0x7330340", VA = "0x187331940")]
		internal object FCCMKHPBCOM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class FCGEDOOFMHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public FCGEDOOFMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7321DF0", Offset = "0x73207F0", VA = "0x187321DF0")]
		internal object KJBJOJFFKPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class EJAAMJJHODG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EJAAMJJHODG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class MMOIFBIEGMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public MMOIFBIEGMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7331C00", Offset = "0x7330600", VA = "0x187331C00")]
		internal object NDFMIOMAGNN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class PLJJCAHJEPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public PLJJCAHJEPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7335680", Offset = "0x7334080", VA = "0x187335680")]
		internal object GPNIBNLPJFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly Dictionary<Guid, DHKDIANGADC> KMKDLONGONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly TimeSpan KDGMLKNPLJG;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "9")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7327E90", Offset = "0x7326890", VA = "0x187327E90", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7327EA0", Offset = "0x73268A0", VA = "0x187327EA0", Slot = "4")]
	public KFHLAEHFELF FABNFHGMHGJ(Guid FAOKHBLGHEO)
	{
		return default(KFHLAEHFELF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7328540", Offset = "0x7326F40", VA = "0x187328540", Slot = "5")]
	public bool MBEEDABKNGP(Guid FAOKHBLGHEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7327B60", Offset = "0x7326560", VA = "0x187327B60", Slot = "6")]
	public bool AAEGDNBPCOK(Guid FAOKHBLGHEO, Task BMPJEOPADED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x73280C0", Offset = "0x7326AC0", VA = "0x1873280C0", Slot = "7")]
	public bool FOADIMFCLFG(Guid FAOKHBLGHEO, BFFBEBDHILG PEPNKKDPKHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x73282A0", Offset = "0x7326CA0", VA = "0x1873282A0", Slot = "8")]
	public Task<(BFFBEBDHILG, Task)> GHBLKOBAADB(Guid FAOKHBLGHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7328310", Offset = "0x7326D10", VA = "0x187328310")]
	private void LGKHJMBCPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7328750", Offset = "0x7327150", VA = "0x187328750")]
	public HIOCNANOPLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.NoEngine.Common.Preserve]
internal class CGDODEMEBFN : EFBPDKCJLBC, BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private class FABNKMBOAIA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private readonly KHOOKALDLHN LDIIHKFHGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private readonly CancellationTokenSource ADHBHFEGLBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public readonly CancellationToken EMEGGONDJAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool OJAMJLHAHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private bool HHCLANPDDNK;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7321D40", Offset = "0x7320740", VA = "0x187321D40")]
		public FABNKMBOAIA(KHOOKALDLHN LDIIHKFHGOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7321BF0", Offset = "0x73205F0", VA = "0x187321BF0")]
		public void FFPCHLDHDDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7321BC0", Offset = "0x73205C0", VA = "0x187321BC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class NOBDMOPBCMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public LGFDOGGLNLF disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NOBDMOPBCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7332730", Offset = "0x7331130", VA = "0x187332730")]
		internal object JEMLCJOMEFF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct AELAOOHHMEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public LGFDOGGLNLF disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public CGDODEMEBFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x73168E0", Offset = "0x73152E0", VA = "0x1873168E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7316C90", Offset = "0x7315690", VA = "0x187316C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class LLCMFBKAAOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LLCMFBKAAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x732FF20", Offset = "0x732E920", VA = "0x18732FF20")]
		internal object IOCFIPJHDLI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct CKMGNKHIJNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CGDODEMEBFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private GFHOFHONACH <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x731C4A0", Offset = "0x731AEA0", VA = "0x18731C4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class LCOPOMDKEDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public KHOOKALDLHN newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LCOPOMDKEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x732ED50", Offset = "0x732D750", VA = "0x18732ED50")]
		internal object FENEJBBGOII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x732EDF0", Offset = "0x732D7F0", VA = "0x18732EDF0")]
		internal object LMFLFNPNBFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x732EE30", Offset = "0x732D830", VA = "0x18732EE30")]
		internal object PIMEPCLABHE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class KGPCNEECMGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public KGPCNEECMGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x732DF00", Offset = "0x732C900", VA = "0x18732DF00")]
		internal void NAFJCHHBLIN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct KCNMOIMIPPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public KHOOKALDLHN newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public CGDODEMEBFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public FNJJGBHANJJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private LCOPOMDKEDO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x732CEA0", Offset = "0x732B8A0", VA = "0x18732CEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x732DE20", Offset = "0x732C820", VA = "0x18732DE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly KHPMDAPEGOE.FKBNIKCEDOD PMINCAKCMCD;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly FGIKIPNBDNO CLMMMKOAFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private OMBNPJCAOGA KGLLIKFJBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private LJJCGHGHPFO GHCGPKFFHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private HIANIBLJMCN GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private LPOICFJDFMI JNHFGLCOILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private MCNHIJKHPJB OKLBMJCKNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private KHOOKALDLHN CDJDIIKFKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private FABNKMBOAIA FCBMJIDGHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private bool DBDANMPPDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private Task PPPNFKAAPPN;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private JHCJKADOLFD EOEFNJKPLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x731B6A0", Offset = "0x731A0A0", VA = "0x18731B6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool AIDBLMPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x9A44C0", Offset = "0x9A2EC0", VA = "0x1809A44C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x731A890", Offset = "0x7319290", VA = "0x18731A890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x731A8A0", Offset = "0x73192A0", VA = "0x18731A8A0", Slot = "4")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x731B000", Offset = "0x7319A00", VA = "0x18731B000", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x731B2F0", Offset = "0x7319CF0", VA = "0x18731B2F0")]
	[AsyncStateMachine(typeof(AELAOOHHMEM))]
	private Task FMGIFNBAKHA(LGFDOGGLNLF NEPIBNNBDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x731B510", Offset = "0x7319F10", VA = "0x18731B510")]
	private void HJLFKPOKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x731B6F0", Offset = "0x731A0F0", VA = "0x18731B6F0")]
	private void LDALGOLFKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x731B170", Offset = "0x7319B70", VA = "0x18731B170")]
	private void FKOPEBBOOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x731B880", Offset = "0x731A280", VA = "0x18731B880")]
	private bool NIBAIDFHGLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x731AF30", Offset = "0x7319930", VA = "0x18731AF30")]
	[AsyncStateMachine(typeof(CKMGNKHIJNG))]
	private void DMNHMHKHOEG(int JNHDKONHEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x731AB90", Offset = "0x7319590", VA = "0x18731AB90")]
	private void CDKNPFFNAON([Out] IDisposable ADDDNBKLOKL, [Out] IDisposable GBCIHNKNCLL, [Out] IDisposable BDIFMEKOCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x731AE10", Offset = "0x7319810", VA = "0x18731AE10")]
	private bool DGOENGIKBDL(KHOOKALDLHN LDIIHKFHGOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x731AB40", Offset = "0x7319540", VA = "0x18731AB40")]
	private void CCMHHADPCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x731B3E0", Offset = "0x7319DE0", VA = "0x18731B3E0")]
	[AsyncStateMachine(typeof(KCNMOIMIPPI))]
	private Task GBDNEFNOONL(KHOOKALDLHN LDIIHKFHGOB, FNJJGBHANJJ KOMFLAAAPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x731BC90", Offset = "0x731A690", VA = "0x18731BC90")]
	public CGDODEMEBFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class LPANHOAIKIL : FICCAOGJBPO, BMNPGLCOMID, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct LDGHOKHICOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public AsyncTaskMethodBuilder<JHBLFOFBKFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public LPANHOAIKIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<JHBLFOFBKFH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x732EE70", Offset = "0x732D870", VA = "0x18732EE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x732F100", Offset = "0x732DB00", VA = "0x18732F100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class JKPIKHADPOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public DDFNKKNNNOO message;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public JKPIKHADPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x732B730", Offset = "0x732A130", VA = "0x18732B730")]
		internal object IBNHELDJDMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class CCBDBCJHHJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public DDFNKKNNNOO messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public CCBDBCJHHJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7319FC0", Offset = "0x73189C0", VA = "0x187319FC0")]
		internal object EIEANIACCGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class NELDLFJELEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public DDFNKKNNNOO request;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NELDLFJELEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7331C60", Offset = "0x7330660", VA = "0x187331C60")]
		internal object NBAENJONMOJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct OBEOODLACMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public DDFNKKNNNOO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public LPANHOAIKIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<EDIIHMJKPCA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x73327C0", Offset = "0x73311C0", VA = "0x1873327C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7333080", Offset = "0x7331A80", VA = "0x187333080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class NLCHMOPBJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public DDFNKKNNNOO operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NLCHMOPBJIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x73326D0", Offset = "0x73310D0", VA = "0x1873326D0")]
		internal object PPJFNHEIOOI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct GKNICGNCEEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public DDFNKKNNNOO operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public LPANHOAIKIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private KPCABNKAIHO <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<DDFNKKNNNOO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x73258C0", Offset = "0x73242C0", VA = "0x1873258C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7326420", Offset = "0x7324E20", VA = "0x187326420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct CLECKNENCDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<EDIIHMJKPCA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public LPANHOAIKIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public DDFNKKNNNOO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private AJHJEJAAJCC.ANLLPJNAFMB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private KPCABNKAIHO <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<DDFNKKNNNOO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x731D680", Offset = "0x731C080", VA = "0x18731D680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x731DBA0", Offset = "0x731C5A0", VA = "0x18731DBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class LAGAEHKDNLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public EDIIHMJKPCA operation;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LAGAEHKDNLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x732E000", Offset = "0x732CA00", VA = "0x18732E000")]
		internal object LPOJHLJHCKO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct ECJIODOEAHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public EDIIHMJKPCA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public LPANHOAIKIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private APPPBJLIGLH<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x731ED20", Offset = "0x731D720", VA = "0x18731ED20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x731F360", Offset = "0x731DD60", VA = "0x18731F360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class ICNHKDNNHOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public DDFNKKNNNOO request;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ICNHKDNNHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x732A610", Offset = "0x7329010", VA = "0x18732A610")]
		internal object FOBMHDJEAGK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class DNOOBJLGEOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public DDFNKKNNNOO request;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public DNOOBJLGEOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x731EAD0", Offset = "0x731D4D0", VA = "0x18731EAD0")]
		internal object IDPCOHPNKOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private KJIJNLHKCML JEKJAIKFHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private MCGJBBCJMLP LGFNFNJMPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private NLFOBJDIJJK FPPDDFOBDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private EGBHJBCMIAK BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private TaskCompletionSource<JHBLFOFBKFH> DGGIBIBPEAK;

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7330250", Offset = "0x732EC50", VA = "0x187330250", Slot = "7")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7330990", Offset = "0x732F390", VA = "0x187330990", Slot = "6")]
	[AsyncStateMachine(typeof(LDGHOKHICOC))]
	public Task<JHBLFOFBKFH> HJABMDOJOEF(CancellationToken EMNFCPHPLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7330F10", Offset = "0x732F910", VA = "0x187330F10", Slot = "4")]
	public void LMKMIINCLAN(DDFNKKNNNOO KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7330BB0", Offset = "0x732F5B0", VA = "0x187330BB0", Slot = "5")]
	public void JFIEOGJLDBC(DDFNKKNNNOO LKOPNFCHAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7330AA0", Offset = "0x732F4A0", VA = "0x187330AA0")]
	[AsyncStateMachine(typeof(OBEOODLACMC))]
	private Task ILMCHFOCJAF(DDFNKKNNNOO NEKCFCOLDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7330760", Offset = "0x732F160", VA = "0x187330760")]
	[AsyncStateMachine(typeof(GKNICGNCEEH))]
	private Task DDDIKLBGPJM(DDFNKKNNNOO EPBAILIIGEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7330100", Offset = "0x732EB00", VA = "0x187330100")]
	[AsyncStateMachine(typeof(CLECKNENCDD))]
	private Task<EDIIHMJKPCA> AHLNGENDNJG(DDFNKKNNNOO NEKCFCOLDAN, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7330340", Offset = "0x732ED40", VA = "0x187330340")]
	private KPCABNKAIHO AIGFKPGFKLN(DDFNKKNNNOO PAKJCFMGCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7330870", Offset = "0x732F270", VA = "0x187330870")]
	[AsyncStateMachine(typeof(ECJIODOEAHO))]
	private Task HHBDJMLFGHD(EDIIHMJKPCA OPLFDLOEKLI, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x73312A0", Offset = "0x732FCA0", VA = "0x1873312A0")]
	private EDIIHMJKPCA MBDBOFKFKAN(DDFNKKNNNOO NEKCFCOLDAN, KPCABNKAIHO INICLHMEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2E5E0B0", Offset = "0x2E5CAB0", VA = "0x182E5E0B0")]
	private T AGPGOEOEEPL<T>(T KLABJGGMBGH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x73303D0", Offset = "0x732EDD0", VA = "0x1873303D0")]
	private EDIIHMJKPCA BEKELKIBMMP(DDFNKKNNNOO NEKCFCOLDAN, KPCABNKAIHO INICLHMEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public LPANHOAIKIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[UnityEngine.Scripting.Preserve]
internal sealed class FPGMPMBCJIE : MCGJBBCJMLP, BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class PCPHHEJHNOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public PCPHHEJHNOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7334700", Offset = "0x7333100", VA = "0x187334700")]
		internal object EIIICIBDBIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class LNLEJKOAOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LNLEJKOAOKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7330090", Offset = "0x732EA90", VA = "0x187330090")]
		internal object OOLAKBKDLHK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private EGBHJBCMIAK BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private HJLOFENDNMA LANALEKHAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private FICCAOGJBPO GKEJPBNHBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private JKAFDPGPODN KMKDLONGONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private EFLEFCBBADG JGAMKLNBBPE;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7323230", Offset = "0x7321C30", VA = "0x187323230", Slot = "6")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7323870", Offset = "0x7322270", VA = "0x187323870", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7323BA0", Offset = "0x73225A0", VA = "0x187323BA0", Slot = "4")]
	public KFHLAEHFELF JDIHALCHCPA(DDFNKKNNNOO LHFDPAHJLIF)
	{
		return default(KFHLAEHFELF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x73241C0", Offset = "0x7322BC0", VA = "0x1873241C0", Slot = "5")]
	public void LFDGHOOJPPK(Guid FAOKHBLGHEO, Task BMPJEOPADED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7324BB0", Offset = "0x73235B0", VA = "0x187324BB0")]
	private void ONOEOEPJIGH(byte MPCHJCCFIKH, int MPNIFGFJIPM, object BCBKEOPAPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x73243D0", Offset = "0x7322DD0", VA = "0x1873243D0")]
	private void LHIHIJGCNCM(LCKFCEAPKCD GIEOAGIJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7322F30", Offset = "0x7321930", VA = "0x187322F30")]
	private void AFOINGDKHHN(LCKFCEAPKCD GIEOAGIJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7324C80", Offset = "0x7323680", VA = "0x187324C80")]
	private void PDPDBKJDKDL(LCKFCEAPKCD GIEOAGIJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7323640", Offset = "0x7322040", VA = "0x187323640")]
	private BFFBEBDHILG DDMHJHFKCIG(DDFNKKNNNOO PAKJCFMGCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7323FC0", Offset = "0x73229C0", VA = "0x187323FC0")]
	private void KCJEALICAFA(DDFNKKNNNOO EPBAILIIGEF, BFFBEBDHILG PEPNKKDPKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x73233A0", Offset = "0x7321DA0", VA = "0x1873233A0")]
	private bool BHGONAGLMID(DDFNKKNNNOO EPBAILIIGEF, BFFBEBDHILG PEPNKKDPKHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7324940", Offset = "0x7323340", VA = "0x187324940")]
	private bool NDEADJGFKHI(DDFNKKNNNOO AEHEIBAIJFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7323920", Offset = "0x7322320", VA = "0x187323920")]
	private bool IHPCEMHCIPE(byte MPCHJCCFIKH, ExitGames.Client.Photon.Hashtable GIEOAGIJFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public FPGMPMBCJIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[UnityEngine.Scripting.Preserve]
internal sealed class FGLICGIMHBB : BHNOOEGGBCE, BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class PKJBEJDOMLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public JHBLFOFBKFH operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public FGLICGIMHBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public DDFNKKNNNOO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public PKJBEJDOMLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x7335610", Offset = "0x7334010", VA = "0x187335610")]
		internal object MIHJOFJIEJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x73354E0", Offset = "0x7333EE0", VA = "0x1873354E0")]
		internal object DEGNFBLGOOO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct PDGHMEOLHBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AsyncTaskMethodBuilder<BFFBEBDHILG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public FGLICGIMHBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public DDFNKKNNNOO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private TaskAwaiter<BFFBEBDHILG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x7334770", Offset = "0x7333170", VA = "0x187334770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7334DF0", Offset = "0x73337F0", VA = "0x187334DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class JDAPHHLHDNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public JHBLFOFBKFH operationType;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public JDAPHHLHDNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x732B170", Offset = "0x7329B70", VA = "0x18732B170")]
		internal object FLKGDGDONBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class EBOCAHGLOKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public DDFNKKNNNOO request;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EBOCAHGLOKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x731ECB0", Offset = "0x731D6B0", VA = "0x18731ECB0")]
		internal object NHOKAOLDECG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x731EBD0", Offset = "0x731D5D0", VA = "0x18731EBD0")]
		internal object JDELGMNOMNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x731EC40", Offset = "0x731D640", VA = "0x18731EC40")]
		internal object KHNGAPHCAIM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct IHPGDFEOCEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<BFFBEBDHILG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public DDFNKKNNNOO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public FGLICGIMHBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private EBOCAHGLOKI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private KFHLAEHFELF <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private BFFBEBDHILG <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<(BFFBEBDHILG validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x732A6F0", Offset = "0x73290F0", VA = "0x18732A6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x732AFA0", Offset = "0x73299A0", VA = "0x18732AFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private EGBHJBCMIAK BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private HJLOFENDNMA LANALEKHAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private MCGJBBCJMLP LGFNFNJMPCA;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7321E50", Offset = "0x7320850", VA = "0x187321E50", Slot = "5")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x73220F0", Offset = "0x7320AF0", VA = "0x1873220F0", Slot = "4")]
	[AsyncStateMachine(typeof(PDGHMEOLHBF))]
	private Task<BFFBEBDHILG> MAIMDJKPPFA(DDFNKKNNNOO PAKJCFMGCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7321F00", Offset = "0x7320900", VA = "0x187321F00")]
	private bool LIPJPHLOOCM(JHBLFOFBKFH PGJKOCEAFDN, [Out] BFFBEBDHILG POBDLJBBBCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7322210", Offset = "0x7320C10", VA = "0x187322210")]
	[AsyncStateMachine(typeof(IHPGDFEOCEP))]
	private Task<BFFBEBDHILG> OIHJEEJLGFF(DDFNKKNNNOO NEKCFCOLDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public FGLICGIMHBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class LBCLCBOIIOA : IABENDKKNAO, BMNPGLCOMID, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct HECBPGLBJCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<HHMBNBENNDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public KHOOKALDLHN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public LBCLCBOIIOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<LGKHNIEIJHC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<HHMBNBENNDA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x7327520", Offset = "0x7325F20", VA = "0x187327520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x7327AF0", Offset = "0x73264F0", VA = "0x187327AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class CPAMIDLLOGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public CPAMIDLLOGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x731E630", Offset = "0x731D030", VA = "0x18731E630")]
		internal object NDHNLKEABCP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct AKPMDDKNPEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<LGKHNIEIJHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public LBCLCBOIIOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public KHOOKALDLHN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private CPAMIDLLOGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<LGKHNIEIJHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x73191E0", Offset = "0x7317BE0", VA = "0x1873191E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x73197D0", Offset = "0x73181D0", VA = "0x1873197D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct JJFGGENDBCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<HHMBNBENNDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public LBCLCBOIIOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public KHOOKALDLHN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public LGKHNIEIJHC roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<(GDGMMMLOHOM superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x732B260", Offset = "0x7329C60", VA = "0x18732B260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x732B6C0", Offset = "0x732A0C0", VA = "0x18732B6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class INPDBMPDGGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public INPDBMPDGGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x955340", Offset = "0x953D40", VA = "0x180955340")]
		internal bool NPHOMBEKDHN(GPIOLPLJMNL sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct OBNCEEABHAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<(GDGMMMLOHOM superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public LGKHNIEIJHC roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public LBCLCBOIIOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public KHOOKALDLHN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter<(GDGMMMLOHOM superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x73330E0", Offset = "0x7331AE0", VA = "0x1873330E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7333780", Offset = "0x7332180", VA = "0x187333780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class AGGLICAFKKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public AGGLICAFKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7317B60", Offset = "0x7316560", VA = "0x187317B60")]
		internal object NODKPBGIJIG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct CJKPALLNKAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<(GDGMMMLOHOM superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public GPIOLPLJMNL subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public LBCLCBOIIOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public KHOOKALDLHN dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private AGGLICAFKKN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<BOFGPKPACMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x731BD00", Offset = "0x731A700", VA = "0x18731BD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x731C430", Offset = "0x731AE30", VA = "0x18731C430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly (GDGMMMLOHOM superRoomData, long subRoomDataSaveId) IDEGEMBHKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private HIANIBLJMCN GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private GDFLEMFPAMO ECMDAHDBBFL;

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x732E160", Offset = "0x732CB60", VA = "0x18732E160", Slot = "5")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x732E1F0", Offset = "0x732CBF0", VA = "0x18732E1F0", Slot = "4")]
	[AsyncStateMachine(typeof(HECBPGLBJCK))]
	public Task<HHMBNBENNDA> GFGPOFEKHOL(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, KHOOKALDLHN HFHIOLPIJPD, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x732E630", Offset = "0x732D030", VA = "0x18732E630")]
	[AsyncStateMachine(typeof(AKPMDDKNPEL))]
	private Task<LGKHNIEIJHC> JGCIHKHCGMB(KHOOKALDLHN HFHIOLPIJPD, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x732E4C0", Offset = "0x732CEC0", VA = "0x18732E4C0")]
	[AsyncStateMachine(typeof(JJFGGENDBCH))]
	private Task<HHMBNBENNDA> IGDIGBPPIOG(KHOOKALDLHN HFHIOLPIJPD, LGKHNIEIJHC HLNFJPOGDHL, long PIGKPDHCACB, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x732E790", Offset = "0x732D190", VA = "0x18732E790")]
	[AsyncStateMachine(typeof(OBNCEEABHAF))]
	private Task<(GDGMMMLOHOM, long)> MFLAEHJBBDD(KHOOKALDLHN HFHIOLPIJPD, LGKHNIEIJHC HLNFJPOGDHL, long PIGKPDHCACB, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x732E350", Offset = "0x732CD50", VA = "0x18732E350")]
	[AsyncStateMachine(typeof(CJKPALLNKAK))]
	private Task<(GDGMMMLOHOM, long)> HPHEBHOGNJK(KHOOKALDLHN JDBPJJMJCPB, GPIOLPLJMNL BKFCONONDMC, long PIGKPDHCACB, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public LBCLCBOIIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[UnityEngine.Scripting.Preserve]
internal sealed class ECOKAKOCBDH : NLFOBJDIJJK, BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class GBNJAHHOFEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public DDFNKKNNNOO request;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GBNJAHHOFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7324EC0", Offset = "0x73238C0", VA = "0x187324EC0")]
		internal object MIEDJBLPEKA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct PELOHBPOOEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public AsyncTaskMethodBuilder<DDFNKKNNNOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public DDFNKKNNNOO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public ECOKAKOCBDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public KPCABNKAIHO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<DDFNKKNNNOO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7334E60", Offset = "0x7333860", VA = "0x187334E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x7335470", Offset = "0x7333E70", VA = "0x187335470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct FMDKKJIAGJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public AsyncTaskMethodBuilder<DDFNKKNNNOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public ECOKAKOCBDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public KPCABNKAIHO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter<LPMFOEBBGEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x73228D0", Offset = "0x73212D0", VA = "0x1873228D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7322EC0", Offset = "0x73218C0", VA = "0x187322EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class BMOOOHKOMPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public DDFNKKNNNOO request;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public BMOOOHKOMPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x7319F60", Offset = "0x7318960", VA = "0x187319F60")]
		internal object NIPHKOCLBLK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct EEHBCBNGPLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<DDFNKKNNNOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public DDFNKKNNNOO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public ECOKAKOCBDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public KPCABNKAIHO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private DDHMMEPGMLJ <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private GJFOFPMDGOA <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter<LPMFOEBBGEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x731FD60", Offset = "0x731E760", VA = "0x18731FD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x7320950", Offset = "0x731F350", VA = "0x187320950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private EGBHJBCMIAK BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private DFOEFOELAAD NLEICECKEEF;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private PDHFKAAJHLH ANHGEHHEBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x731F3C0", Offset = "0x731DDC0", VA = "0x18731F3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x731F480", Offset = "0x731DE80", VA = "0x18731F480", Slot = "8")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x731F950", Offset = "0x731E350", VA = "0x18731F950", Slot = "4")]
	[AsyncStateMachine(typeof(PELOHBPOOEP))]
	public Task<DDFNKKNNNOO> MFMFKLFAHAI(DDFNKKNNNOO NEKCFCOLDAN, KPCABNKAIHO INICLHMEMEN, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x731FAB0", Offset = "0x731E4B0", VA = "0x18731FAB0", Slot = "5")]
	[AsyncStateMachine(typeof(FMDKKJIAGJK))]
	public Task<DDFNKKNNNOO> NNJLIDKBGIN(CancellationToken IONNNJNKLMJ, KPCABNKAIHO INICLHMEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x731F510", Offset = "0x731DF10", VA = "0x18731F510", Slot = "6")]
	public HPJHGCAGHML GNADJKDOCMN(EDIIHMJKPCA FKALECGNFPE, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x731F720", Offset = "0x731E120", VA = "0x18731F720", Slot = "7")]
	public HPJHGCAGHML KEBEKCOFKLC(EDIIHMJKPCA FKALECGNFPE, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x731FC00", Offset = "0x731E600", VA = "0x18731FC00")]
	[AsyncStateMachine(typeof(EEHBCBNGPLM))]
	private Task<DDFNKKNNNOO> PEJFAHKFKCF(DDFNKKNNNOO NEKCFCOLDAN, KPCABNKAIHO INICLHMEMEN, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2DE39F0", Offset = "0x2DE23F0", VA = "0x182DE39F0")]
	private static byte[] IBGKHKJEKOO(DDFNKKNNNOO KFAOBDLOMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public ECOKAKOCBDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class LEDGHPPJMPJ : HJLOFENDNMA, BMNPGLCOMID, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private CBDLFDNFBLG JELMMHODMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private EGBHJBCMIAK BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private KJIJNLHKCML JEKJAIKFHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private BBJBMLDCFDB ACFKCHINHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private HIANIBLJMCN GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private MCNHIJKHPJB OKLBMJCKNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private BDJAJBONKII OBJINCGBDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private LPOICFJDFMI JNHFGLCOILM;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private JHCJKADOLFD EOEFNJKPLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x732F750", Offset = "0x732E150", VA = "0x18732F750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private static BFFBEBDHILG FELKKEINIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7319B10", Offset = "0x7318510", VA = "0x187319B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x732F170", Offset = "0x732DB70", VA = "0x18732F170", Slot = "6")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x732F5E0", Offset = "0x732DFE0", VA = "0x18732F5E0", Slot = "4")]
	public BFFBEBDHILG FKGDGLOPBMN(PDPPFLAPOCL OIGHEJMKIKC, JHBLFOFBKFH ACDFMINNBKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x732F2E0", Offset = "0x732DCE0", VA = "0x18732F2E0", Slot = "5")]
	public BFFBEBDHILG CPFFFCBLCEJ(PDPPFLAPOCL CCFJKNIPNFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7319A90", Offset = "0x7318490", VA = "0x187319A90")]
	private static BFFBEBDHILG GIHNKBKCELI(CJGBFBHKACP ONIANAELCBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public LEDGHPPJMPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class JAJDBDEFKEA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x732B010", Offset = "0x7329A10", VA = "0x18732B010")]
	public JAJDBDEFKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x67992F0", Offset = "0x6797CF0", VA = "0x1867992F0")]
	public JAJDBDEFKEA(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[UnityEngine.Scripting.Preserve]
internal sealed class AHOLEGJMBGC : FAFBLHDAJOP, BMNPGLCOMID, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct EICPIJDOJBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder<BFFBEBDHILG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public AHOLEGJMBGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public LOPIKBFKNII autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private APPPBJLIGLH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private APPPBJLIGLH<string>.LANPOEPHMID <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private FBKPMFCMPJP <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<BFFBEBDHILG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7320FC0", Offset = "0x731F9C0", VA = "0x187320FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7321B50", Offset = "0x7320550", VA = "0x187321B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct ADNNADCHJEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public AHOLEGJMBGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7316150", Offset = "0x7314B50", VA = "0x187316150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7316880", Offset = "0x7315280", VA = "0x187316880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct GDBAACINDIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AHOLEGJMBGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7324F20", Offset = "0x7323920", VA = "0x187324F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7325430", Offset = "0x7323E30", VA = "0x187325430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct OFEFBEGJNAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public AHOLEGJMBGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x73337F0", Offset = "0x73321F0", VA = "0x1873337F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7333F30", Offset = "0x7332930", VA = "0x187333F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct BGNADKCCDEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public AHOLEGJMBGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7319D60", Offset = "0x7318760", VA = "0x187319D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7319F00", Offset = "0x7318900", VA = "0x187319F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct OJGIGLGJKHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public AHOLEGJMBGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7333F90", Offset = "0x7332990", VA = "0x187333F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x73346A0", Offset = "0x73330A0", VA = "0x1873346A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct CMKBEGDOJLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public AHOLEGJMBGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x731DC10", Offset = "0x731C610", VA = "0x18731DC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x731E080", Offset = "0x731CA80", VA = "0x18731E080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct EGOEEEOIKEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AHOLEGJMBGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public CLGBBEAHBHE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private APPPBJLIGLH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x73209C0", Offset = "0x731F3C0", VA = "0x1873209C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7320F20", Offset = "0x731F920", VA = "0x187320F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private EGBHJBCMIAK BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private HIANIBLJMCN GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private NLFOBJDIJJK FPPDDFOBDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private KJIJNLHKCML JEKJAIKFHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private BDJAJBONKII OBJINCGBDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private CancellationTokenSource FAHNDAAMGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private Task JHKPCIGMEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private TaskCompletionSource<int> AOKFMIMGEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private int DCOPENIBFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private int OHAJBPJHHPL;

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x73182C0", Offset = "0x7316CC0", VA = "0x1873182C0", Slot = "6")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0xCD3F00", Offset = "0xCD2900", VA = "0x180CD3F00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7318F90", Offset = "0x7317990", VA = "0x187318F90")]
	private void OGHLEKKHEPC(float AEOONNDEKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7318750", Offset = "0x7317150", VA = "0x187318750", Slot = "4")]
	[AsyncStateMachine(typeof(EICPIJDOJBC))]
	public Task<BFFBEBDHILG> DLJOKENJPCA(LOPIKBFKNII IJOJEOLCKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7318570", Offset = "0x7316F70", VA = "0x187318570", Slot = "5")]
	[AsyncStateMachine(typeof(ADNNADCHJEO))]
	public Task CNGAAKAAHBP([Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xCD3F00", Offset = "0xCD2900", VA = "0x180CD3F00")]
	public void OMBEBJNJKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7319070", Offset = "0x7317A70", VA = "0x187319070")]
	private FBKPMFCMPJP OMDKMGDFGLJ(LOPIKBFKNII IJOJEOLCKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x73181D0", Offset = "0x7316BD0", VA = "0x1873181D0")]
	[AsyncStateMachine(typeof(GDBAACINDIB))]
	private Task ACNLBBKCPBG(CancellationToken LBFDJGLPAMK, int NCDFAOGECAA, HFNNEAJJBFG LDHBPHKKKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7318470", Offset = "0x7316E70", VA = "0x187318470")]
	[AsyncStateMachine(typeof(OFEFBEGJNAN))]
	private Task CDDCEENKCCO(CancellationToken LBFDJGLPAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7318880", Offset = "0x7317280", VA = "0x187318880")]
	[AsyncStateMachine(typeof(BGNADKCCDEL))]
	private Task EFEAKCIJKMM([Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7318660", Offset = "0x7317060", VA = "0x187318660")]
	[AsyncStateMachine(typeof(OJGIGLGJKHD))]
	private Task CPBODPOILGH(CancellationToken LBFDJGLPAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7318A80", Offset = "0x7317480", VA = "0x187318A80")]
	[AsyncStateMachine(typeof(CMKBEGDOJLH))]
	private Task GKNPOADMMOA(CancellationToken LHBHCPKDDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7318B80", Offset = "0x7317580", VA = "0x187318B80")]
	private Task LCNKABLJCGG(CLGBBEAHBHE NFFFIACDANN, CancellationToken LBFDJGLPAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7318970", Offset = "0x7317370", VA = "0x187318970")]
	[AsyncStateMachine(typeof(EGOEEEOIKEC))]
	private Task EGNLLPKCFNJ(CLGBBEAHBHE NFFFIACDANN, CancellationToken LBFDJGLPAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7318D10", Offset = "0x7317710", VA = "0x187318D10")]
	private bool OBMNEDEFDCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public AHOLEGJMBGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[UnityEngine.Scripting.Preserve]
internal class FJIPIGAKMON : BBJBMLDCFDB, BMNPGLCOMID, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct AGHOBADLCLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public FJIPIGAKMON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private APPPBJLIGLH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7317C10", Offset = "0x7316610", VA = "0x187317C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7318170", Offset = "0x7316B70", VA = "0x187318170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private HFHGINOGHOO BEDGHDEFIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private HJLOFENDNMA LANALEKHAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private NLFOBJDIJJK FPPDDFOBDKA;

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x7322350", Offset = "0x7320D50", VA = "0x187322350", Slot = "6")]
	public void AIFHKOLJDOL(BEEALJNDIKM BPLHAJDMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7322630", Offset = "0x7321030", VA = "0x187322630", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x7322680", Offset = "0x7321080", VA = "0x187322680", Slot = "5")]
	[AsyncStateMachine(typeof(AGHOBADLCLK))]
	public Task HHLKOLCPEHJ(string BICLBBDNKCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x7322780", Offset = "0x7321180", VA = "0x187322780", Slot = "4")]
	public BFFBEBDHILG OBMNEDEFDCL(PDPPFLAPOCL OIGHEJMKIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x73227E0", Offset = "0x73211E0", VA = "0x1873227E0")]
	private PIJEFGPPEPE PCMJMEJHIBL(string BICLBBDNKCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public FJIPIGAKMON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class NIBEMCBNEJO
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7332490", Offset = "0x7330E90", VA = "0x187332490")]
	public static void PFNCGHEGHEC(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7331EE0", Offset = "0x73308E0", VA = "0x187331EE0")]
	internal static void KAJHLKLCMPN(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7331E00", Offset = "0x7330800", VA = "0x187331E00")]
	internal static void CEHIOBBFECI(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x7332040", Offset = "0x7330A40", VA = "0x187332040")]
	internal static void MEONPOCCMLP(JEFLJDHAGDI EOPOOELIKIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class CDCOMBBDGDL : PLPBAIPAOFD<DDFNKKNNNOO>
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class ABGODKEKDEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public DDFNKKNNNOO message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ABGODKEKDEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7315E00", Offset = "0x7314800", VA = "0x187315E00")]
		internal object PKOPJMFPGBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly CDCOMBBDGDL DFEEMNKDOMA;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x731A020", Offset = "0x7318A20", VA = "0x18731A020")]
	public ExitGames.Client.Photon.Hashtable AMCHBAGBIFH(DDFNKKNNNOO KFAOBDLOMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x731A2E0", Offset = "0x7318CE0", VA = "0x18731A2E0", Slot = "5")]
	protected override void NFOLMAHJLGI(DDFNKKNNNOO KFAOBDLOMDC, IDictionary<object, object> JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x731A0B0", Offset = "0x7318AB0", VA = "0x18731A0B0", Slot = "6")]
	public override DDFNKKNNNOO CENBFOHJAFB(IDictionary<object, object> JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x731A410", Offset = "0x7318E10", VA = "0x18731A410")]
	private static void OJMFFMAGFPH(string DLMFPIAEPPD, DDFNKKNNNOO KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x731A850", Offset = "0x7319250", VA = "0x18731A850")]
	public CDCOMBBDGDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x731A520", Offset = "0x7318F20", VA = "0x18731A520")]
	[CompilerGenerated]
	internal static string PNFNAAOIOAM(HHMBNBENNDA AJFODGMHKJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class BFIJGPNENBD
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public static BFFBEBDHILG FELKKEINIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7319B10", Offset = "0x7318510", VA = "0x187319B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7319AF0", Offset = "0x73184F0", VA = "0x187319AF0")]
	public static bool MKOIFHLBMKC(this BFFBEBDHILG PEPNKKDPKHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7319A90", Offset = "0x7318490", VA = "0x187319A90")]
	public static BFFBEBDHILG GIHNKBKCELI(CJGBFBHKACP BOPGOELGDIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7319B70", Offset = "0x7318570", VA = "0x187319B70")]
	public static BFFBEBDHILG OJPPALBPEOA(IEnumerable<BFFBEBDHILG> EKBFKDNHIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x7319840", Offset = "0x7318240", VA = "0x187319840")]
	public static string DFNDMBGMFCP(this BFFBEBDHILG POBDLJBBBCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public abstract class GIDEKABFKGJ : LCALCLGHBHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public delegate BFFBEBDHILG MOACLFEEKNC([NotNull] PDPPFLAPOCL KEGACPFHMIA);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class NNHIAIEMCNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public PDPPFLAPOCL photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NNHIAIEMCNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x69838C0", Offset = "0x69822C0", VA = "0x1869838C0")]
		internal BFFBEBDHILG OJIEKGBAIPA(MOACLFEEKNC v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private bool HFIMBOHAJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	protected readonly HashSet<MOACLFEEKNC> OEBLDIGOEDF;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x73257D0", Offset = "0x73241D0", VA = "0x1873257D0", Slot = "4")]
	public void PCLFHPHJFGO(MOACLFEEKNC HKDJNHDFLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x73254E0", Offset = "0x7323EE0", VA = "0x1873254E0", Slot = "5")]
	public void HGGKAJEDPDF(MOACLFEEKNC HKDJNHDFLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7325490", Offset = "0x7323E90", VA = "0x187325490", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x7325540", Offset = "0x7323F40", VA = "0x187325540")]
	protected BFFBEBDHILG JHLFOMPHHEC(PDPPFLAPOCL CCFJKNIPNFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x7325830", Offset = "0x7324230", VA = "0x187325830")]
	protected GIDEKABFKGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class JCLJMHBOIHF : GIDEKABFKGJ, CBDLFDNFBLG, LCALCLGHBHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private sealed class KPEKMODMJNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public BFFBEBDHILG result;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public KPEKMODMJNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x732DFA0", Offset = "0x732C9A0", VA = "0x18732DFA0")]
		internal object JIGAFJHLLMM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x732B160", Offset = "0x7329B60", VA = "0x18732B160")]
	[UnityEngine.Scripting.Preserve]
	public JCLJMHBOIHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x732B050", Offset = "0x7329A50", VA = "0x18732B050", Slot = "8")]
	public BFFBEBDHILG PAANLDJLCMM(PDPPFLAPOCL CCFJKNIPNFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class MCDMMIPMBJI : GIDEKABFKGJ, HFHGINOGHOO, LCALCLGHBHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private sealed class MCABOFEDALG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public BFFBEBDHILG result;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public MCABOFEDALG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x73314B0", Offset = "0x732FEB0", VA = "0x1873314B0")]
		internal object OONGIIJKFBL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x732B160", Offset = "0x7329B60", VA = "0x18732B160")]
	[UnityEngine.Scripting.Preserve]
	public MCDMMIPMBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7331510", Offset = "0x732FF10", VA = "0x187331510", Slot = "8")]
	public BFFBEBDHILG OBMNEDEFDCL(PDPPFLAPOCL MBAGFJGPJPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class MLEIJJAGMJJ
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class JGNNLOPNGKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public APPPBJLIGLH<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public JGNNLOPNGKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x732B1E0", Offset = "0x7329BE0", VA = "0x18732B1E0")]
		internal object GDJJBAJJDEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x73319A0", Offset = "0x73303A0", VA = "0x1873319A0")]
	public static APPPBJLIGLH<string> AOPKIHOIMNF(CMICIECANPG FPPDOFKLJHI, [Optional] string FOKBPMBLGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7331B40", Offset = "0x7330540", VA = "0x187331B40")]
	public static void EHBLPPCNLII(APPPBJLIGLH<string> LOIGOPGNFFM, CMICIECANPG FPPDOFKLJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7331A80", Offset = "0x7330480", VA = "0x187331A80")]
	public static string EDAIDCDAEAN(DDFNKKNNNOO PAKJCFMGCOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal static class NFHCHBMDBPI
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7331DE0", Offset = "0x73307E0", VA = "0x187331DE0")]
	public static void LIOMFFIEOIK(this EGBHJBCMIAK BPCHJLBHPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7331DF0", Offset = "0x73307F0", VA = "0x187331DF0")]
	public static void PEDABPIHPIC(this EGBHJBCMIAK BPCHJLBHPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x7331CC0", Offset = "0x73306C0", VA = "0x187331CC0")]
	private static void EFCNPIOACEG(this EGBHJBCMIAK BPCHJLBHPKH, bool ACBKDBOIIKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class CMKONJAACLO : NDFDKFMNCOI, MEEPNJMHOOA, LFPBGMALGLA, KPBGJCJHBMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private readonly MEEPNJMHOOA NDBAJAEDOJO;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public PDPPFLAPOCL BBCDFEPIACG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x731E270", Offset = "0x731CC70", VA = "0x18731E270", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int PACBCMBLHEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x731E450", Offset = "0x731CE50", VA = "0x18731E450", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int PLPJJKNKAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x731E180", Offset = "0x731CB80", VA = "0x18731E180", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DMIFGEPFKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int GEAAJGJGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x923D80", Offset = "0x922780", VA = "0x180923D80", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GIJMDANJJLD.DONLMOLJOLL IDJBLIEMLMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event DJIPEOGFHJA NPFBOIGGLFH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x731E1D0", Offset = "0x731CBD0", VA = "0x18731E1D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x731E0E0", Offset = "0x731CAE0", VA = "0x18731E0E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> LLMBGDGDGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<PDPPFLAPOCL> KJEDPAEBLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action CAKIOOCNOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x731E360", Offset = "0x731CD60", VA = "0x18731E360", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x731E2C0", Offset = "0x731CCC0", VA = "0x18731E2C0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0xCBD0D0", Offset = "0xCBBAD0", VA = "0x180CBD0D0")]
	public CMKONJAACLO(MEEPNJMHOOA NDBAJAEDOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x731E580", Offset = "0x731CF80", VA = "0x18731E580", Slot = "8")]
	public bool PHELLDCEDPK(byte MPCHJCCFIKH, ExitGames.Client.Photon.Hashtable EIHMKDMMCON, JDPGDEJLHAK JHPFNNLCLMJ, SendOptions MLLJNHKPFAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x731E4A0", Offset = "0x731CEA0", VA = "0x18731E4A0", Slot = "16")]
	public PDPPFLAPOCL PBJFHGDMOMO(int DKOHPFNHOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "19")]
	public void BBKPCPLMDPD(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "20")]
	public void LGBIFJGPIHI(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "21")]
	public void DMNMHJDPMHN(object FLLNLBHFENG, bool PGBODBNFMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x731E400", Offset = "0x731CE00", VA = "0x18731E400", Slot = "22")]
	public IDisposable HKJIFGJHNKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "23")]
	private bool MJLKHLHDAAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "24")]
	public void LGMFFNOJNBJ(StringBuilder POJKCMOJLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xA109C0", Offset = "0xA0F3C0", VA = "0x180A109C0", Slot = "25")]
	public bool DPFHLHPEHLO(bool HEIPIBIBDKL, [Out] string ENDMINEHNJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x9555D0", Offset = "0x953FD0", VA = "0x1809555D0", Slot = "28")]
	public void AOLDEPFJNPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct LCKFCEAPKCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly IDictionary<object, object> GIEOAGIJFBB;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
	public LCKFCEAPKCD(IDictionary<object, object> GIEOAGIJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x732E9D0", Offset = "0x732D3D0", VA = "0x18732E9D0")]
	public bool DMNPDCHHGAC([Out] DDFNKKNNNOO KFAOBDLOMDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x732ECA0", Offset = "0x732D6A0", VA = "0x18732ECA0")]
	public Guid JMKIHENJNMK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x732EB70", Offset = "0x732D570", VA = "0x18732EB70")]
	public BFFBEBDHILG IHMJGMPCHAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x732EA80", Offset = "0x732D480", VA = "0x18732EA80")]
	public static ExitGames.Client.Photon.Hashtable GMDNOGMNFLF(DDFNKKNNNOO KFAOBDLOMDC, BFFBEBDHILG PEPNKKDPKHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal static class IGBOCHLOIKJ
{
	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x732A670", Offset = "0x7329070", VA = "0x18732A670")]
	public static bool EFMHGAEGFED(this KHOOKALDLHN EKJBHGGEALF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct LJHCGCJMJGC : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct IAKLJINEHOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public LJHCGCJMJGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x732A3D0", Offset = "0x7328DD0", VA = "0x18732A3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x732A5B0", Offset = "0x7328FB0", VA = "0x18732A5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private readonly CancellationTokenSource ADHBHFEGLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private bool HFIMBOHAJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private Task KECDGIGMBNG;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool OGCLLAHCFGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x732FC60", Offset = "0x732E660", VA = "0x18732FC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x732FDF0", Offset = "0x732E7F0", VA = "0x18732FDF0")]
	public LJHCGCJMJGC(CancellationToken IONNNJNKLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x732FCE0", Offset = "0x732E6E0", VA = "0x18732FCE0")]
	[AsyncStateMachine(typeof(IAKLJINEHOC))]
	public Task FMFKDMFODMO(Func<CancellationToken, List<Task>> JPGALEDIIAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x732FC90", Offset = "0x732E690", VA = "0x18732FC90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public readonly struct JOMNDKMPEGJ<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct DFEGNMECFEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<CKKLNOOKGGD<TData>, LBGFPGMHGDG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public JOMNDKMPEGJ<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private TaskAwaiter<BCLNLKLFCPB<CKKLNOOKGGD<TData>, LBGFPGMHGDG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x5B33770", Offset = "0x5B32170", VA = "0x185B33770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x40B0860", Offset = "0x40AF260", VA = "0x1840B0860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private readonly BLDDNNGHBEO<TGetDataArg, TData> FJKKNCLMNHM;

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
	internal JOMNDKMPEGJ(BLDDNNGHBEO<TGetDataArg, TData> LAKCFHGOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x432AF20", Offset = "0x4329920", VA = "0x18432AF20")]
	[AsyncStateMachine(typeof(JOMNDKMPEGJ<, >.DFEGNMECFEN))]
	public Task<BCLNLKLFCPB<CKKLNOOKGGD<TData>, LBGFPGMHGDG>> MJLBBOIHEKE(TGetDataArg IOBLLEKOCNN, string DGOIGMKDPGK, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class HEKEKBDINED
{
	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D70730", Offset = "0x2D6F130", VA = "0x182D70730")]
	public static JOMNDKMPEGJ<TGetDataArg, TData> GGBAHLJJLHO<TGetDataArg, TData>(BLDDNNGHBEO<TGetDataArg, TData> LAKCFHGOLJA)
	{
		return default(JOMNDKMPEGJ<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct LAMMFHOBGJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public readonly int IHEMAPGJOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public readonly int? AALLBCBLAGB;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x44B3E30", Offset = "0x44B2830", VA = "0x1844B3E30")]
	public LAMMFHOBGJG(int LPOJEHINHEE, [Optional] int? FGNIKAJDALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x732E080", Offset = "0x732CA80", VA = "0x18732E080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface NIMBFBGLBIO<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHFAFNFJFHM();

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NIMBFBGLBIO<T> LCOLFAFADNH(string CCOJMELONMF);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NIMBFBGLBIO<T> BKCFINDNICA(AFOJDGJGJME<T> AKKHONCHEBN);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NIMBFBGLBIO<T> MFDJMBGFCMO(int JPKBMOOHKJG);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NIMBFBGLBIO<T> AOPFPBLILNK(int JPKBMOOHKJG, GJJCMNDPIIC<T> MIJHNAGEBAB);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface KKFFKMIIAGB
{
	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NIMBFBGLBIO<T> LNOLEBMLINH<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOOCCCOIOCJ BAIOFPLJEPK(Exception NJACFNFHNDN);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LAMMFHOBGJG AKGDJMOJALH(Exception NJACFNFHNDN);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate string AFOJDGJGJME<in T>(T NJACFNFHNDN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public delegate int GJJCMNDPIIC<in T>(T NJACFNFHNDN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class KCGOKMMKOMA : KKFFKMIIAGB
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate string LKGONCKAAMA(Exception NJACFNFHNDN);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private delegate int IHJJIMEJHKP(Exception NJACFNFHNDN);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class DBJIKDLBOIC<T> : NIMBFBGLBIO<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class HGAOMFLFABK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public HGAOMFLFABK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
			internal string DCHMMNDJJCA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class OJFMPOHGFJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public AFOJDGJGJME<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public OJFMPOHGFJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x425C6A0", Offset = "0x425B0A0", VA = "0x18425C6A0")]
			internal string ALILONBKMEJ(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class JADAAMBMOGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public GJJCMNDPIIC<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public JADAAMBMOGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x425C6A0", Offset = "0x425B0A0", VA = "0x18425C6A0")]
			internal int KLNIKFFIFAJ(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly KCGOKMMKOMA KFGOMDKIDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private readonly Type MJBMAGFLLLJ;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5B28260", Offset = "0x5B26C60", VA = "0x185B28260")]
		internal DBJIKDLBOIC(KCGOKMMKOMA KFGOMDKIDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5B27E70", Offset = "0x5B26870", VA = "0x185B27E70", Slot = "4")]
		public void AHFAFNFJFHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5B28100", Offset = "0x5B26B00", VA = "0x185B28100", Slot = "5")]
		public NIMBFBGLBIO<T> LCOLFAFADNH(string CCOJMELONMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x5B27FE0", Offset = "0x5B269E0", VA = "0x185B27FE0", Slot = "6")]
		public NIMBFBGLBIO<T> BKCFINDNICA(AFOJDGJGJME<T> AKKHONCHEBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x5B28220", Offset = "0x5B26C20", VA = "0x185B28220", Slot = "7")]
		public NIMBFBGLBIO<T> MFDJMBGFCMO(int JPKBMOOHKJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x5B27EA0", Offset = "0x5B268A0", VA = "0x185B27EA0", Slot = "8")]
		public NIMBFBGLBIO<T> AOPFPBLILNK(int JPKBMOOHKJG, GJJCMNDPIIC<T> MIJHNAGEBAB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class OOLPEPNKCNF<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private bool LMOLCJBEMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private readonly List<Type> AEJHGADCEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private readonly Dictionary<Type, TVal> GEFMDANGIEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly Dictionary<Type, int> PFJMFDAKMEA;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public IReadOnlyList<Type> CALPDEDPKPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x490BCE0", Offset = "0x490A6E0", VA = "0x18490BCE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x490BF80", Offset = "0x490A980", VA = "0x18490BF80")]
		public OOLPEPNKCNF(Dictionary<Type, int> PFJMFDAKMEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x490B960", Offset = "0x490A360", VA = "0x18490B960")]
		public void FABNFHGMHGJ(Type LFOBGDLOPID, TVal AAJFAHDADNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x490BC80", Offset = "0x490A680", VA = "0x18490BC80")]
		public bool OFPALHODEEG(Type MJBMAGFLLLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x490BAE0", Offset = "0x490A4E0", VA = "0x18490BAE0")]
		public bool GJKKBKFNGDO(TVal KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x4416440", Offset = "0x4414E40", VA = "0x184416440")]
		public TVal PBGHNKGJFJB(Type JLAAKHANEHC)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x490BB40", Offset = "0x490A540", VA = "0x18490BB40")]
		[CompilerGenerated]
		private int HGCBPNDHAMJ(Type NMGBOLEJFOH, Type KIBJEPNLMCN)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class HJPFGFPOIGM : IEnumerable<LAMMFHOBGJG>, IEnumerable, IEnumerator<LAMMFHOBGJG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private LAMMFHOBGJG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public KCGOKMMKOMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private IEnumerator<LAMMFHOBGJG> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		private LAMMFHOBGJG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x3ABC120", Offset = "0x3ABAB20", VA = "0x183ABC120", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LAMMFHOBGJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x7328E60", Offset = "0x7327860", VA = "0x187328E60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x993D30", Offset = "0x992730", VA = "0x180993D30")]
		[DebuggerHidden]
		public HJPFGFPOIGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x7328EB0", Offset = "0x73278B0", VA = "0x187328EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x73288B0", Offset = "0x73272B0", VA = "0x1873288B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7328860", Offset = "0x7327260", VA = "0x187328860")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x7328810", Offset = "0x7327210", VA = "0x187328810")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7328E10", Offset = "0x7327810", VA = "0x187328E10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x7328D50", Offset = "0x7327750", VA = "0x187328D50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LAMMFHOBGJG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x7328D50", Offset = "0x7327750", VA = "0x187328D50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly LAMMFHOBGJG MOLGGOLBNMM;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Dictionary<Type, int> ELFKGGCGFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly HashSet<Type> IDEENHAPFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly OOLPEPNKCNF<int> KKEEGEPIDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly OOLPEPNKCNF<IHJJIMEJHKP> JCKAHGACGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly OOLPEPNKCNF<LKGONCKAAMA> LAJBOOPIKFL;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x732C6A0", Offset = "0x732B0A0", VA = "0x18732C6A0")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	internal static void LJBMCKAFLEE(JEFLJDHAGDI FMBOKBBFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x732CB70", Offset = "0x732B570", VA = "0x18732CB70")]
	[RecRoom.NoEngine.Common.Preserve]
	public KCGOKMMKOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2ACDA20", Offset = "0x2ACC420", VA = "0x182ACDA20", Slot = "4")]
	public NIMBFBGLBIO<T> LNOLEBMLINH<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x732B990", Offset = "0x732A390", VA = "0x18732B990", Slot = "5")]
	public HOOCCCOIOCJ BAIOFPLJEPK(Exception NJACFNFHNDN)
	{
		return default(HOOCCCOIOCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x732B790", Offset = "0x732A190", VA = "0x18732B790", Slot = "6")]
	public LAMMFHOBGJG AKGDJMOJALH(Exception? NJACFNFHNDN)
	{
		return default(LAMMFHOBGJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x732CA10", Offset = "0x732B410", VA = "0x18732CA10", Slot = "7")]
	[IteratorStateMachine(typeof(HJPFGFPOIGM))]
	public IEnumerable<LAMMFHOBGJG> PDAINHNHMJB(Exception NJACFNFHNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x732BB00", Offset = "0x732A500", VA = "0x18732BB00", Slot = "8")]
	public string GEBNGBEJPPO(Exception? NJACFNFHNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x732C710", Offset = "0x732B110", VA = "0x18732C710")]
	private string NIMAMCJOENL(AggregateException NHHNFLAOHBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x732C2F0", Offset = "0x732ACF0", VA = "0x18732C2F0")]
	private void JEDIKEPBLCF(Type MJBMAGFLLLJ, int JPKBMOOHKJG, IHJJIMEJHKP? MKGFIKABHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x732C0A0", Offset = "0x732AAA0", VA = "0x18732C0A0")]
	private void INDGBDFKMLA(Type MJBMAGFLLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x732BC50", Offset = "0x732A650", VA = "0x18732BC50")]
	private void HAFIIBHCEBK(Type MJBMAGFLLLJ, LKGONCKAAMA BIAHNHJOFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x732BF20", Offset = "0x732A920", VA = "0x18732BF20")]
	private static int ICLGHDOBJPE(Type MJBMAGFLLLJ, Dictionary<Type, int> PFJMFDAKMEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2E447A0", Offset = "0x2E431A0", VA = "0x182E447A0")]
	private static bool MPMMNHGIIBG<TVal>(OOLPEPNKCNF<TVal> ICLOFOKMOJF, Type MJBMAGFLLLJ, [Out] TVal KLABJGGMBGH) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x732BA20", Offset = "0x732A420", VA = "0x18732BA20")]
	[CompilerGenerated]
	internal static int EMCLLDHOIOE(Type DMGLAENLDCG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct HOOCCCOIOCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public readonly LAMMFHOBGJG JNCFHGENFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public readonly string FCAOMPBDGMG;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x73290A0", Offset = "0x7327AA0", VA = "0x1873290A0")]
	public HOOCCCOIOCJ(string LNGNJEGILDB, LAMMFHOBGJG JPKBMOOHKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7329000", Offset = "0x7327A00", VA = "0x187329000")]
	public string KNDHDFPPAPF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class AGACIEIJNOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly OLBLMMDLAHJ DEDLEDMKLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private string KFGEPNIDOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private long? MAJLNFHABBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private long? NPLAEPHNDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? IILDEGLNNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private string AHFOJOEHIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private INJHLDLALFB EHJJOKDIHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private long? OBMBIJNPIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private bool IDAIEDMDHMD;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string OJADDCKEIAD
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long FHKFFAOBAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x73171D0", Offset = "0x7315BD0", VA = "0x1873171D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public long KJCENLBBNKI
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x7317AC0", Offset = "0x73164C0", VA = "0x187317AC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public long HJODHHIDLDN
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x7316CF0", Offset = "0x73156F0", VA = "0x187316CF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string FLCPIJNCDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x7317190", Offset = "0x7315B90", VA = "0x187317190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public INJHLDLALFB JLKPLCEBBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x948F30", Offset = "0x947930", VA = "0x180948F30")]
		get
		{
			return default(INJHLDLALFB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x7316E50", Offset = "0x7315850", VA = "0x187316E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long MHKGAKHMFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x7316D50", Offset = "0x7315750", VA = "0x187316D50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7317B20", Offset = "0x7316520", VA = "0x187317B20")]
	[UnityEngine.Scripting.Preserve]
	public AGACIEIJNOB([OLJNBPOCBCJ(null)] OLBLMMDLAHJ DEDLEDMKLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7316F40", Offset = "0x7315940", VA = "0x187316F40")]
	private void FGGJBBOEFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7317230", Offset = "0x7315C30", VA = "0x187317230")]
	public void JGMLCHFABDD(long FNKMOIJJLLC, long PIGKPDHCACB, [Optional] long? CBAGNPPEFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7316DB0", Offset = "0x73157B0", VA = "0x187316DB0")]
	public void DFFNLFHMDFB(long CBAGNPPEFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7317A40", Offset = "0x7316440", VA = "0x187317A40")]
	public void NEHDLIGEDEB(string BDPJHMFKLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x73176C0", Offset = "0x73160C0", VA = "0x1873176C0")]
	public void MGMMFFMMLCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class HPJHGCAGHML : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct NJEPIEFKMNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public AsyncTaskMethodBuilder<DDFNKKNNNOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public DDFNKKNNNOO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public HPJHGCAGHML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private TaskAwaiter<PDHFKAAJHLH.CLMLJDJNAKE<DDFNKKNNNOO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x73486B0", Offset = "0x73470B0", VA = "0x1873486B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x7348AB0", Offset = "0x73474B0", VA = "0x187348AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct GBIHELALONO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class HINIFDGJLDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public DDFNKKNNNOO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public HINIFDGJLDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x733F8B0", Offset = "0x733E2B0", VA = "0x18733F8B0")]
		internal DDFNKKNNNOO CLCPDBEHPFI(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct POPIBOGJIIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder<PDHFKAAJHLH.CLMLJDJNAKE<DDFNKKNNNOO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public DDFNKKNNNOO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public HPJHGCAGHML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private DDHMMEPGMLJ <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<PDHFKAAJHLH.CLMLJDJNAKE<DDFNKKNNNOO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x734C260", Offset = "0x734AC60", VA = "0x18734C260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x734C870", Offset = "0x734B270", VA = "0x18734C870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct MIIHPJLHGPA<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public HPJHGCAGHML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x4778760", Offset = "0x4777160", VA = "0x184778760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x37663F0", Offset = "0x3764DF0", VA = "0x1837663F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct LIFJCMLAFPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public HPJHGCAGHML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x7345E30", Offset = "0x7344830", VA = "0x187345E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7345FF0", Offset = "0x73449F0", VA = "0x187345FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class GJBKEODANIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GJBKEODANIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x733E780", Offset = "0x733D180", VA = "0x18733E780")]
		internal object JHGFEEBIBJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x733E6C0", Offset = "0x733D0C0", VA = "0x18733E6C0")]
		internal bool HAPMCPINKPI(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class AGNMPNHFIGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public AGNMPNHFIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x7336590", Offset = "0x7334F90", VA = "0x187336590")]
		internal object FDJBEILOAIJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class DEOKOOGOGNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public DEOKOOGOGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x733A500", Offset = "0x7338F00", VA = "0x18733A500")]
		internal object MFLKIGGEBBC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class DHNLCODMAMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public DHNLCODMAMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x733A570", Offset = "0x7338F70", VA = "0x18733A570")]
		internal object KBGJIBHJLNL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class ALIIMEGBDFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public HPJHGCAGHML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ALIIMEGBDFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x7336FD0", Offset = "0x73359D0", VA = "0x187336FD0")]
		internal object PKOPJMFPGBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private static readonly Guid CCAJGDNCEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly EDIIHMJKPCA HIGMOHCHDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly PDHFKAAJHLH FCCCNGAOFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly LFPBGMALGLA BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly KPBGJCJHBMM KEACINHHINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private bool BCJPGBEDOBC;

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x732A1A0", Offset = "0x7328BA0", VA = "0x18732A1A0")]
	public HPJHGCAGHML(EDIIHMJKPCA OPLFDLOEKLI, PDHFKAAJHLH FCCCNGAOFIN, LFPBGMALGLA BPCHJLBHPKH, KPBGJCJHBMM KEACINHHINM, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x73290C0", Offset = "0x7327AC0", VA = "0x1873290C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x73290C0", Offset = "0x7327AC0", VA = "0x1873290C0")]
	public void ACBDOMPLIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x73291E0", Offset = "0x7327BE0", VA = "0x1873291E0")]
	public void AJFAOPJOODK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7329AB0", Offset = "0x73284B0", VA = "0x187329AB0")]
	public void HFALEHBEFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7329CA0", Offset = "0x73286A0", VA = "0x187329CA0")]
	[AsyncStateMachine(typeof(NJEPIEFKMNM))]
	internal Task<DDFNKKNNNOO> KOAKMNDHIGA(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, DDFNKKNNNOO PAKJCFMGCOO, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2DE39F0", Offset = "0x2DE23F0", VA = "0x182DE39F0")]
	private static byte[] EANBOGFBLCC<T>(T KFAOBDLOMDC) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3CA0", Offset = "0x2DE26A0", VA = "0x182DE3CA0")]
	private static T LBGEOHCEKCL<T>(MessageParser<T> AEBGGHPGJMN, byte[] KFAOBDLOMDC, T AKPJMLDDHEN) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7329970", Offset = "0x7328370", VA = "0x187329970")]
	[AsyncStateMachine(typeof(POPIBOGJIIK))]
	private Task<PDHFKAAJHLH.CLMLJDJNAKE<DDFNKKNNNOO>> GELJDFJOOCE(DDFNKKNNNOO PAKJCFMGCOO, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3A00", Offset = "0x2DE2400", VA = "0x182DE3A00")]
	[AsyncStateMachine(typeof(MIIHPJLHGPA<>))]
	internal Task<T> KNNKPJCAHCD<T>(CancellationToken LBFDJGLPAMK, Func<CancellationToken, Task<T>> DBFIDHCMGKK, int HHFOCOAHDDD = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7329B70", Offset = "0x7328570", VA = "0x187329B70")]
	[AsyncStateMachine(typeof(LIFJCMLAFPK))]
	internal Task KNNKPJCAHCD(CancellationToken LBFDJGLPAMK, Func<CancellationToken, Task> DBFIDHCMGKK, int HHFOCOAHDDD = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x732A0C0", Offset = "0x7328AC0", VA = "0x18732A0C0")]
	public GGKCJPOLELJ PFHGCNKAOOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x73292A0", Offset = "0x7327CA0", VA = "0x1873292A0")]
	public IADPDJEAOKO ALONOPLGEBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x73296E0", Offset = "0x73280E0", VA = "0x1873296E0")]
	public MCNIBFGHKEK ELHOKDKCEAO([Optional] CMICIECANPG? FPPDOFKLJHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7329F60", Offset = "0x7328960", VA = "0x187329F60")]
	public void OMLHLFIJACF(Func<Guid, bool> AAMCLEMCIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7329860", Offset = "0x7328260", VA = "0x187329860")]
	public void FEIIKFDDJHF(Func<Guid, bool> CMLFCFJPLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7329320", Offset = "0x7327D20", VA = "0x187329320")]
	public Guid BMJMGCBHIFP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x73295D0", Offset = "0x7327FD0", VA = "0x1873295D0")]
	public void DMCNALIBOAJ(Guid OKIGLNDGEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x73294A0", Offset = "0x7327EA0", VA = "0x1873294A0")]
	public void DDOFFKOJAHI(DDFNKKNNNOO BJBDPGJLLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7329E50", Offset = "0x7328850", VA = "0x187329E50")]
	public void OJMFFMAGFPH(string KEJGDNGNGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3900", Offset = "0x2DE2300", VA = "0x182DE3900")]
	private T AGPGOEOEEPL<T>(T KLABJGGMBGH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7329E00", Offset = "0x7328800", VA = "0x187329E00")]
	public void LFHGCHEBCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3DF0", Offset = "0x2DE27F0", VA = "0x182DE3DF0")]
	[CompilerGenerated]
	internal static string OAGPDMEINLC<T>(byte[] CNGBPDKMHBB, int DOBHOIOIHAC, GBIHELALONO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal sealed class CGCGCLJGPAP : EDIIHMJKPCA
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class FAOMMNDCEJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public FAOMMNDCEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x733B6E0", Offset = "0x733A0E0", VA = "0x18733B6E0")]
		internal object KADFCEPNOJB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct CMCOBJIOPEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public CGCGCLJGPAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public HPJHGCAGHML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private EJJAIGEJFIJ <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private IADPDJEAOKO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x73392C0", Offset = "0x7337CC0", VA = "0x1873392C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x7339B90", Offset = "0x7338590", VA = "0x187339B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct MMCFODFAEKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public CGCGCLJGPAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private TaskAwaiter<LGKHNIEIJHC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x7347D80", Offset = "0x7346780", VA = "0x187347D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x7348530", Offset = "0x7346F30", VA = "0x187348530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct CMLPPJICLJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public CGCGCLJGPAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter<BOFGPKPACMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x7339BF0", Offset = "0x73385F0", VA = "0x187339BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x7339F10", Offset = "0x7338910", VA = "0x187339F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class LJBJHMMGPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public EJJAIGEJFIJ presence;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LJBJHMMGPCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x7346050", Offset = "0x7344A50", VA = "0x187346050")]
		internal object BCOJIOGAPGE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private static readonly CMICIECANPG DIOOPEKBCGD;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly CMICIECANPG CBLKKOCDMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private readonly HHMBNBENNDA FIHPFCNBMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly KHOOKALDLHN JMNNOFADHCG;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x7338F30", Offset = "0x7337930", VA = "0x187338F30")]
	public CGCGCLJGPAP(HHMBNBENNDA FIHPFCNBMJB, KHOOKALDLHN JMNNOFADHCG, Guid FAOKHBLGHEO, BEEALJNDIKM BPLHAJDMKHP, KPCABNKAIHO NPMHEFHCFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x7338930", Offset = "0x7337330", VA = "0x187338930", Slot = "7")]
	[AsyncStateMachine(typeof(CMCOBJIOPEF))]
	protected override Task BIPADBDGGDP(HPJHGCAGHML COEIHFBAEEN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x7338B80", Offset = "0x7337580", VA = "0x187338B80")]
	[AsyncStateMachine(typeof(MMCFODFAEKO))]
	private Task IMCNJHILLBI(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7338A70", Offset = "0x7337470", VA = "0x187338A70")]
	[AsyncStateMachine(typeof(CMLPPJICLJC))]
	private Task<byte> ECMKJBGENIK(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x7338C80", Offset = "0x7337680", VA = "0x187338C80")]
	private EJJAIGEJFIJ KIMFMKOOOBB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class FBKPMFCMPJP : EDIIHMJKPCA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct LPJDCBINOLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public FBKPMFCMPJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public HPJHGCAGHML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private TaskAwaiter<IPHFHDPNPHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x7346800", Offset = "0x7345200", VA = "0x187346800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x7347170", Offset = "0x7345B70", VA = "0x187347170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private readonly int GJDAHEEJFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private readonly LOPIKBFKNII HENLKHJGNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public readonly long OMKGAKAMIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public readonly long CBNDFGNMIHJ;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public IPHFHDPNPHJ OBKGFJHHCCC
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x89F6E0", Offset = "0x89E0E0", VA = "0x18089F6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x89F700", Offset = "0x89E100", VA = "0x18089F700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x733C040", Offset = "0x733AA40", VA = "0x18733C040")]
	public FBKPMFCMPJP(Guid FAOKHBLGHEO, BEEALJNDIKM BPLHAJDMKHP, KPCABNKAIHO NPMHEFHCFJL, int GJDAHEEJFCA, LOPIKBFKNII HENLKHJGNOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x733BF20", Offset = "0x733A920", VA = "0x18733BF20", Slot = "7")]
	[AsyncStateMachine(typeof(LPJDCBINOLK))]
	protected override Task BIPADBDGGDP(HPJHGCAGHML COEIHFBAEEN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class KIMDBCHJPMN : EDIIHMJKPCA
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class GCPIFNAOLJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public KIMDBCHJPMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public LOELFNDLHDD playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GCPIFNAOLJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x733E680", Offset = "0x733D080", VA = "0x18733E680")]
		internal Task PHKDLCPJCPD(APPPBJLIGLH<string>.LANPOEPHMID postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x733E5F0", Offset = "0x733CFF0", VA = "0x18733E5F0")]
		internal object BDHFBJIMBEF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct BNIIOIJGJPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public KIMDBCHJPMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public HPJHGCAGHML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private GCPIFNAOLJN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x7338110", Offset = "0x7336B10", VA = "0x187338110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x73388D0", Offset = "0x73372D0", VA = "0x1873388D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct MEPABNHFCLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public LOELFNDLHDD playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public KIMDBCHJPMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x7347790", Offset = "0x7346190", VA = "0x187347790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x7347D20", Offset = "0x7346720", VA = "0x187347D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7345420", Offset = "0x7343E20", VA = "0x187345420")]
	public KIMDBCHJPMN(Guid FAOKHBLGHEO, BEEALJNDIKM BPLHAJDMKHP, KPCABNKAIHO NPMHEFHCFJL, string APHGLDMIIPP, MCHJNCNCMFE PGJKOCEAFDN, bool IAPFPMLDBFE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x73451A0", Offset = "0x7343BA0", VA = "0x1873451A0", Slot = "7")]
	[AsyncStateMachine(typeof(BNIIOIJGJPN))]
	protected override Task BIPADBDGGDP(HPJHGCAGHML COEIHFBAEEN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task KHLOHEMKKLB(HPJHGCAGHML COEIHFBAEEN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x73452E0", Offset = "0x7343CE0", VA = "0x1873452E0")]
	[AsyncStateMachine(typeof(MEPABNHFCLP))]
	private Task OIIDKOKIBLG(IDisposable GFJKLKCLFPB, LOELFNDLHDD NBAIBDPLCDI, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class BMJLHLAOKMA : EDIIHMJKPCA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct MANIOBKMLDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public BMJLHLAOKMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public HPJHGCAGHML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private TaskAwaiter<MEHJOEPPCEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x73471D0", Offset = "0x7345BD0", VA = "0x1873471D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x7347730", Offset = "0x7346130", VA = "0x187347730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly CLGBBEAHBHE NFFFIACDANN;

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x7338070", Offset = "0x7336A70", VA = "0x187338070")]
	public BMJLHLAOKMA(Guid FAOKHBLGHEO, BEEALJNDIKM BPLHAJDMKHP, KPCABNKAIHO NPMHEFHCFJL, CLGBBEAHBHE NFFFIACDANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x7337F90", Offset = "0x7336990", VA = "0x187337F90", Slot = "6")]
	protected override string NPKLJGOLLAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x7337E70", Offset = "0x7336870", VA = "0x187337E70", Slot = "7")]
	[AsyncStateMachine(typeof(MANIOBKMLDA))]
	protected override Task BIPADBDGGDP(HPJHGCAGHML COEIHFBAEEN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal abstract class EDIIHMJKPCA : KIAENMCLBPA
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public delegate Task GLMPMHKJLPG(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class FNMFGPAHLOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public APPPBJLIGLH<string>.LANPOEPHMID operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public EDIIHMJKPCA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public FNMFGPAHLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x733E310", Offset = "0x733CD10", VA = "0x18733E310")]
		internal Task HHABCBDKBOA(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class BLMEIPEJIKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public FNMFGPAHLOG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public BLMEIPEJIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x7337DB0", Offset = "0x73367B0", VA = "0x187337DB0")]
		internal object JKDNKOGJBMC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct JDCJGMCPCBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public EDIIHMJKPCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public Func<EDIIHMJKPCA, APPPBJLIGLH<string>.LANPOEPHMID, HPJHGCAGHML> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private FNMFGPAHLOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private HPJHGCAGHML <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private TaskAwaiter<DDFNKKNNNOO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x7342B50", Offset = "0x7341550", VA = "0x187342B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x7343C50", Offset = "0x7342650", VA = "0x187343C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct PAIDDJECOOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x734ACB0", Offset = "0x73496B0", VA = "0x18734ACB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x734B730", Offset = "0x734A130", VA = "0x18734B730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct LHNAEDHEPLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public EDIIHMJKPCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x7345A70", Offset = "0x7344470", VA = "0x187345A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x7345DD0", Offset = "0x73447D0", VA = "0x187345DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public readonly Guid BJHFNHBAIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public readonly ByteString FHHAOOBKIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly KPCABNKAIHO OHDMBKPKALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	protected readonly string JPMJLLPEELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private readonly BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private readonly bool IAPFPMLDBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly Queue<GLMPMHKJLPG> DBOEDGIJACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly NHPDOFIEOLC COALLIDPGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly MCHJNCNCMFE PGJKOCEAFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private bool HDALOGCIKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public INJHLDLALFB AONKMBGJGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public INJHLDLALFB ABHKKFHMMKP;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public BEEALJNDIKM LHEDBANJIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public HIANIBLJMCN DBCHGEHMEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x733A5E0", Offset = "0x7338FE0", VA = "0x18733A5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public HNDNOODJKON PJKBCDMJCPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x733AB60", Offset = "0x7339560", VA = "0x18733AB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public JHCJKADOLFD EOEFNJKPLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x733A8D0", Offset = "0x73392D0", VA = "0x18733A8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event MPPFFBOOLBI JHLCOOJBGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x733AAA0", Offset = "0x73394A0", VA = "0x18733AAA0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x733AAC0", Offset = "0x73394C0", VA = "0x18733AAC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x733B010", Offset = "0x7339A10", VA = "0x18733B010")]
	protected EDIIHMJKPCA(Guid FAOKHBLGHEO, BEEALJNDIKM BPLHAJDMKHP, KPCABNKAIHO NPMHEFHCFJL, string APHGLDMIIPP, MCHJNCNCMFE PGJKOCEAFDN, bool IAPFPMLDBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x733AE60", Offset = "0x7339860", VA = "0x18733AE60", Slot = "6")]
	protected virtual string NPKLJGOLLAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x733AA40", Offset = "0x7339440", VA = "0x18733AA40")]
	public void JOPEGEFCBNM(GLMPMHKJLPG POBEKJIJHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x733A8B0", Offset = "0x73392B0", VA = "0x18733A8B0")]
	protected void EDHCFMDGCHL(float FDIIPKGGJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x733A630", Offset = "0x7339030", VA = "0x18733A630")]
	[AsyncStateMachine(typeof(JDCJGMCPCBK))]
	public Task CKOMBPKHALD(CancellationToken IONNNJNKLMJ, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, [Optional] Func<EDIIHMJKPCA, APPPBJLIGLH<string>.LANPOEPHMID, HPJHGCAGHML> MJGMLEGLCAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x733A780", Offset = "0x7339180", VA = "0x18733A780")]
	[AsyncStateMachine(typeof(PAIDDJECOOE))]
	private static Task DEADEELMJDI(Func<CancellationToken, Task> JJAJEAGCAJB, Func<CancellationToken, Task> GOEBMEJFOAD, CancellationToken LBFDJGLPAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x733AEA0", Offset = "0x73398A0", VA = "0x18733AEA0")]
	private void PJFKDIFDAJD(bool PPGNMKCJKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x733AD50", Offset = "0x7339750", VA = "0x18733AD50")]
	private void NBBNIMEFOGK(HPJHGCAGHML COEIHFBAEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task BIPADBDGGDP(HPJHGCAGHML COEIHFBAEEN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x733ABB0", Offset = "0x73395B0", VA = "0x18733ABB0")]
	[AsyncStateMachine(typeof(LHNAEDHEPLF))]
	private Task LPBEJDDFHMF(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x733AAE0", Offset = "0x73394E0", VA = "0x18733AAE0")]
	public DDFNKKNNNOO LMPGHKAHNJL(DDHMMEPGMLJ HNFBAPCLKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x733A950", Offset = "0x7339350", VA = "0x18733A950")]
	[CompilerGenerated]
	private Task JLGNLDGMAFI(CancellationToken KGPMLIHPPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x733ACD0", Offset = "0x73396D0", VA = "0x18733ACD0")]
	[CompilerGenerated]
	private object MKINNDHAEKD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal sealed class CJKJLIONCNN : KIMDBCHJPMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct FAPGAKEKIHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public CJKJLIONCNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public HPJHGCAGHML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private NNNIMOHICLC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private IADPDJEAOKO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x733B750", Offset = "0x733A150", VA = "0x18733B750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x733BEC0", Offset = "0x733A8C0", VA = "0x18733BEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private readonly HHMBNBENNDA GAJGJDHJKNJ;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x7339210", Offset = "0x7337C10", VA = "0x187339210")]
	public CJKJLIONCNN(Guid FAOKHBLGHEO, BEEALJNDIKM BPLHAJDMKHP, HHMBNBENNDA GAJGJDHJKNJ, KPCABNKAIHO NPMHEFHCFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x73390C0", Offset = "0x7337AC0", VA = "0x1873390C0", Slot = "8")]
	[AsyncStateMachine(typeof(FAPGAKEKIHL))]
	protected override Task KHLOHEMKKLB(HPJHGCAGHML COEIHFBAEEN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class PIJEFGPPEPE : EDIIHMJKPCA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct OKACDGCONJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public PIJEFGPPEPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public HPJHGCAGHML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private TaskAwaiter<MEHJOEPPCEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x7349610", Offset = "0x7348010", VA = "0x187349610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x73499C0", Offset = "0x73483C0", VA = "0x1873499C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private readonly string OGKMFEFKCFA;

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x734C1B0", Offset = "0x734ABB0", VA = "0x18734C1B0")]
	public PIJEFGPPEPE(Guid FAOKHBLGHEO, BEEALJNDIKM BPLHAJDMKHP, KPCABNKAIHO NPMHEFHCFJL, string OGKMFEFKCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x734C0A0", Offset = "0x734AAA0", VA = "0x18734C0A0", Slot = "7")]
	[AsyncStateMachine(typeof(OKACDGCONJO))]
	protected override Task BIPADBDGGDP(HPJHGCAGHML COEIHFBAEEN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class EJMCGALCALA : KIMDBCHJPMN
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class NJNKOHGEEBH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public AsyncTaskMethodBuilder<DDFNKKNNNOO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public NJNKOHGEEBH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<MEHJOEPPCEK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			private TaskAwaiter<DDFNKKNNNOO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x734DE20", Offset = "0x734C820", VA = "0x18734DE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x734E2E0", Offset = "0x734CCE0", VA = "0x18734E2E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public EJMCGALCALA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public MCNIBFGHKEK serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public JBKIJJFEMIN roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public GGKCJPOLELJ uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public IGDHBHLHBPD roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NJNKOHGEEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x7348B20", Offset = "0x7347520", VA = "0x187348B20")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<DDFNKKNNNOO> FOMFIJDALEF(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct IKJKOJJFGHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public EJMCGALCALA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public HPJHGCAGHML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private NJNKOHGEEBH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private NNNIMOHICLC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private IADPDJEAOKO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private DDFNKKNNNOO <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter<DDFNKKNNNOO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x7341B90", Offset = "0x7340590", VA = "0x187341B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x7342AF0", Offset = "0x73414F0", VA = "0x187342AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private static readonly CMICIECANPG DIOOPEKBCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly int BIENMLJGBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	[CanBeNull]
	private readonly BPLKLHJMAAG OAIOGDMPBHC;

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x733B630", Offset = "0x733A030", VA = "0x18733B630")]
	public EJMCGALCALA(Guid FAOKHBLGHEO, BEEALJNDIKM BPLHAJDMKHP, int BIENMLJGBNJ, BPLKLHJMAAG OAIOGDMPBHC, KPCABNKAIHO NPMHEFHCFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x733B340", Offset = "0x7339D40", VA = "0x18733B340", Slot = "8")]
	[AsyncStateMachine(typeof(IKJKOJJFGHO))]
	protected override Task KHLOHEMKKLB(HPJHGCAGHML COEIHFBAEEN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x733B480", Offset = "0x7339E80", VA = "0x18733B480")]
	private void MPKEBAFGJDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x733B170", Offset = "0x7339B70", VA = "0x18733B170")]
	private void KCNGHAHLLFC(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, NNNIMOHICLC CFEFAAHHDGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal abstract class IGFNMHIPGFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public readonly EDIIHMJKPCA HIGMOHCHDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public readonly HPJHGCAGHML PEMODEMCGHF;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public HIANIBLJMCN DBCHGEHMEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x7341A30", Offset = "0x7340430", VA = "0x187341A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public JHCJKADOLFD EOEFNJKPLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x7341A80", Offset = "0x7340480", VA = "0x187341A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x7341B30", Offset = "0x7340530", VA = "0x187341B30")]
	protected IGFNMHIPGFP(HPJHGCAGHML COEIHFBAEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x7341B10", Offset = "0x7340510", VA = "0x187341B10")]
	protected void OJMFFMAGFPH(string KEJGDNGNGOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct LDHEOKIGPMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public Dictionary<Guid, List<DOHELJHHEAG>> FFEGEPJKICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public Dictionary<Guid, List<DOHELJHHEAG>> EIMLCHHLLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<DOHELJHHEAG>> FAPJALPECMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public List<Guid> IMLOMABNNIK;

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x7345470", Offset = "0x7343E70", VA = "0x187345470")]
	public static LDHEOKIGPMN PBGHNKGJFJB(HIANIBLJMCN GDGJPCNEJIO, INJHLDLALFB DHJKJAHDCEA, ANLFOIKADDC HCKKLLBDGKF)
	{
		return default(LDHEOKIGPMN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct IIFPCDBPNBF
{
	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40")]
	public static IIFPCDBPNBF GMDNOGMNFLF()
	{
		return default(IIFPCDBPNBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct IFANDGEHPIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public readonly LGKHNIEIJHC LFMOELFFHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public readonly GPIOLPLJMNL BOIILHDKBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly string MLOHFKEBHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly GDGMMMLOHOM FFHNFKPFGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly GDGMMMLOHOM IBGIHNMJLNF;

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x73419B0", Offset = "0x73403B0", VA = "0x1873419B0")]
	public IFANDGEHPIL(LGKHNIEIJHC LFMOELFFHGE, GPIOLPLJMNL BOIILHDKBKP, string MLOHFKEBHCJ, GDGMMMLOHOM FFHNFKPFGJK, GDGMMMLOHOM IBGIHNMJLNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct GCGJOFIIMEE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private readonly HPJHGCAGHML COEIHFBAEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private readonly Guid OKIGLNDGEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private bool PPGNMKCJKAG;

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x733E440", Offset = "0x733CE40", VA = "0x18733E440")]
	public static GCGJOFIIMEE BMJMGCBHIFP(HPJHGCAGHML COEIHFBAEEN)
	{
		return default(GCGJOFIIMEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0xBD50B0", Offset = "0xBD3AB0", VA = "0x180BD50B0")]
	public void CDENAOMLFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x733E4A0", Offset = "0x733CEA0", VA = "0x18733E4A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x733E5A0", Offset = "0x733CFA0", VA = "0x18733E5A0")]
	private GCGJOFIIMEE(HPJHGCAGHML COEIHFBAEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x733E4A0", Offset = "0x733CEA0", VA = "0x18733E4A0")]
	private void DMCNALIBOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x733E500", Offset = "0x733CF00", VA = "0x18733E500")]
	private Func<Guid, bool> JIKOJDJMLPE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class IADPDJEAOKO : IGFNMHIPGFP, KIAENMCLBPA
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public delegate Task<INJHLDLALFB> LOCELGCCLDL(ANLFOIKADDC JGCMECODHDI, LDAGNFBJONA KHPIFAMBAFN, NHPDOFIEOLC OGFHPDOEGDH, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct OHNAGCLMDOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public HHMBNBENNDA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private GCGJOFIIMEE <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private TaskAwaiter<DDFNKKNNNOO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x7348E40", Offset = "0x7347840", VA = "0x187348E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x73495B0", Offset = "0x7347FB0", VA = "0x1873495B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct HNHGIHDKABO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public AsyncTaskMethodBuilder<DDFNKKNNNOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public HHMBNBENNDA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private APPPBJLIGLH<string>.LANPOEPHMID <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private TaskAwaiter<DDFNKKNNNOO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x733F990", Offset = "0x733E390", VA = "0x18733F990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x733FDA0", Offset = "0x733E7A0", VA = "0x18733FDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct JDJNPEGCDIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public HHMBNBENNDA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private APPPBJLIGLH<string>.LANPOEPHMID <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x7343CB0", Offset = "0x73426B0", VA = "0x187343CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7344140", Offset = "0x7342B40", VA = "0x187344140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class AEGDLOEHGKP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AsyncTaskMethodBuilder<IFANDGEHPIL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public AEGDLOEHGKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private IFANDGEHPIL <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private TaskAwaiter<INJHLDLALFB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private TaskAwaiter<IFANDGEHPIL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x734C8E0", Offset = "0x734B2E0", VA = "0x18734C8E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x734D070", Offset = "0x734BA70", VA = "0x18734D070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public AsyncTaskMethodBuilder<ANLFOIKADDC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public AEGDLOEHGKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private ANLFOIKADDC <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter<INJHLDLALFB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter<ANLFOIKADDC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x734D0E0", Offset = "0x734BAE0", VA = "0x18734D0E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x734D730", Offset = "0x734C130", VA = "0x18734D730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public HHMBNBENNDA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public NHPDOFIEOLC preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public NHPDOFIEOLC downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public IFANDGEHPIL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public NHPDOFIEOLC postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public ANLFOIKADDC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public HNDCNJIJLFL.DNNCMLIGBAE <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public AEGDLOEHGKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7336450", Offset = "0x7334E50", VA = "0x187336450")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<IFANDGEHPIL> NGFKOCAHOME(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7336030", Offset = "0x7334A30", VA = "0x187336030")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<ANLFOIKADDC> AOIAPJGFCFP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7336410", Offset = "0x7334E10", VA = "0x187336410")]
		internal void EOABPDFFIAK(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7336150", Offset = "0x7334B50", VA = "0x187336150")]
		internal Task DBIHBLLJOFL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x73362B0", Offset = "0x7334CB0", VA = "0x1873362B0")]
		internal Task DGILJBDGLGH(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct KGCMDPILOOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public HHMBNBENNDA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private AEGDLOEHGKP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter<IFANDGEHPIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter<ANLFOIKADDC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x7344420", Offset = "0x7342E20", VA = "0x187344420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x7345140", Offset = "0x7343B40", VA = "0x187345140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct GOAHCHIOEBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public ANLFOIKADDC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public NHPDOFIEOLC postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private TaskAwaiter<INJHLDLALFB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private LDAGNFBJONA <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x733E930", Offset = "0x733D330", VA = "0x18733E930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x733F850", Offset = "0x733E250", VA = "0x18733F850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct PBAEINDCFBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x734B790", Offset = "0x734A190", VA = "0x18734B790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x734C040", Offset = "0x734AA40", VA = "0x18734C040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct AIKMLCIILLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public NHPDOFIEOLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private APPPBJLIGLH<string>.LANPOEPHMID <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private TaskAwaiter<INJHLDLALFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x73365F0", Offset = "0x7334FF0", VA = "0x1873365F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x7336F70", Offset = "0x7335970", VA = "0x187336F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct FEFDJHEOPAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AsyncTaskMethodBuilder<INJHLDLALFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public NHPDOFIEOLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private APPPBJLIGLH<string>.LANPOEPHMID <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private TaskAwaiter<INJHLDLALFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x733C170", Offset = "0x733AB70", VA = "0x18733C170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x733D140", Offset = "0x733BB40", VA = "0x18733D140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct FJNLHIPPPIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public AsyncTaskMethodBuilder<INJHLDLALFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public NHPDOFIEOLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public LDAGNFBJONA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private APPPBJLIGLH<string>.LANPOEPHMID <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter<INJHLDLALFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x733D1B0", Offset = "0x733BBB0", VA = "0x18733D1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x733E2A0", Offset = "0x733CCA0", VA = "0x18733E2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct PAEOGPBMFME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder<INJHLDLALFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public INJHLDLALFB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public NHPDOFIEOLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public ANLFOIKADDC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter<INJHLDLALFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x7349A20", Offset = "0x7348420", VA = "0x187349A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x7349CC0", Offset = "0x73486C0", VA = "0x187349CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class NHGGKIHMLLO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public AsyncTaskMethodBuilder<INJHLDLALFB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public NHGGKIHMLLO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			private GFHOFHONACH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private TaskAwaiter<INJHLDLALFB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0x734D7A0", Offset = "0x734C1A0", VA = "0x18734D7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x734DDB0", Offset = "0x734C7B0", VA = "0x18734DDB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public NHPDOFIEOLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public LOCELGCCLDL masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public LDAGNFBJONA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public INJHLDLALFB originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NHGGKIHMLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x7348590", Offset = "0x7346F90", VA = "0x187348590")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<INJHLDLALFB> ANLKOMKNMJL(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct LOKDJIOMOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public AsyncTaskMethodBuilder<INJHLDLALFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public NHPDOFIEOLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public LOCELGCCLDL masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public LDAGNFBJONA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<INJHLDLALFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x7346290", Offset = "0x7344C90", VA = "0x187346290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x7346790", Offset = "0x7345190", VA = "0x187346790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct CONGOJMLKCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public NHPDOFIEOLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private INJHLDLALFB <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private IEnumerator<INJHLDLALFB> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private TaskAwaiter<INJHLDLALFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x7339F80", Offset = "0x7338980", VA = "0x187339F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x733A4A0", Offset = "0x7338EA0", VA = "0x18733A4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct JHMLADGPHJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x73441A0", Offset = "0x7342BA0", VA = "0x1873441A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x73443C0", Offset = "0x7342DC0", VA = "0x1873443C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct OGEENCPFNLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7348C40", Offset = "0x7347640", VA = "0x187348C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7348DE0", Offset = "0x73477E0", VA = "0x187348DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct PAFBJOKMIMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public ANLFOIKADDC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public NHPDOFIEOLC postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter<INJHLDLALFB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private LDAGNFBJONA <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x7349D30", Offset = "0x7348730", VA = "0x187349D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x734AC50", Offset = "0x7349650", VA = "0x18734AC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct BFGEHPMINII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public AsyncTaskMethodBuilder<INJHLDLALFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public IADPDJEAOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public NHPDOFIEOLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter<INJHLDLALFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x7337210", Offset = "0x7335C10", VA = "0x187337210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7337D40", Offset = "0x7336740", VA = "0x187337D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly EAFCCNKEDEM OEOBLCLDMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly EAFCCNKEDEM ANJLMPPPDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly AGACIEIJNOB NIKMEECOFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly NIGDOAMLAIP MNIJAOEAGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly MNDADHLICLP APINJNDJEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private ProfilerCounterValue<int> DIIOJHKBANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly DEDDEELPDLO LMEOPHPNNPB;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private BEEALJNDIKM LHEDBANJIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7340E90", Offset = "0x733F890", VA = "0x187340E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event MPPFFBOOLBI JHLCOOJBGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x7341270", Offset = "0x733FC70", VA = "0x187341270", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x7341290", Offset = "0x733FC90", VA = "0x187341290", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x73416E0", Offset = "0x73400E0", VA = "0x1873416E0")]
	public IADPDJEAOKO(HPJHGCAGHML COEIHFBAEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x7340D40", Offset = "0x733F740", VA = "0x187340D40")]
	[AsyncStateMachine(typeof(OHNAGCLMDOF))]
	public Task JOBPHFEGGGO(HHMBNBENNDA NEKCFCOLDAN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x73412B0", Offset = "0x733FCB0", VA = "0x1873412B0")]
	[AsyncStateMachine(typeof(HNHGIHDKABO))]
	private Task<DDFNKKNNNOO> MBEFHPHFIFC(HHMBNBENNDA NEKCFCOLDAN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x7340EE0", Offset = "0x733F8E0", VA = "0x187340EE0")]
	[AsyncStateMachine(typeof(JDJNPEGCDIP))]
	private Task KKGPDLHNHBI(HHMBNBENNDA NEKCFCOLDAN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x7340AB0", Offset = "0x733F4B0", VA = "0x187340AB0")]
	[AsyncStateMachine(typeof(KGCMDPILOOM))]
	private Task JHOPPHMCGPN(HHMBNBENNDA NEKCFCOLDAN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken EDJCECHOLOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x73406F0", Offset = "0x733F0F0", VA = "0x1873406F0")]
	[AsyncStateMachine(typeof(GOAHCHIOEBO))]
	private Task HFCCMPPKDLN(ANLFOIKADDC LGABIEMBFIL, NHPDOFIEOLC JLAKCJGKCNA, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken EJEEEOHMGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x7341410", Offset = "0x733FE10", VA = "0x187341410")]
	[AsyncStateMachine(typeof(PBAEINDCFBG))]
	private Task OKKNJBLOLOH(APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x73401E0", Offset = "0x733EBE0", VA = "0x1873401E0")]
	[AsyncStateMachine(typeof(AIKMLCIILLD))]
	private Task DBLIPDEOMMP(ANLFOIKADDC JGCMECODHDI, NHPDOFIEOLC OGFHPDOEGDH, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x7341110", Offset = "0x733FB10", VA = "0x187341110")]
	[AsyncStateMachine(typeof(FEFDJHEOPAN))]
	private Task<INJHLDLALFB> KOLALMKFEAJ(ANLFOIKADDC JGCMECODHDI, LDAGNFBJONA ECGMBOLIJDC, NHPDOFIEOLC OGFHPDOEGDH, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x7340840", Offset = "0x733F240", VA = "0x187340840")]
	[AsyncStateMachine(typeof(FJNLHIPPPIP))]
	private Task<INJHLDLALFB> HKIEHOPFELC(ANLFOIKADDC JGCMECODHDI, LDAGNFBJONA ECGMBOLIJDC, NHPDOFIEOLC OGFHPDOEGDH, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x7340060", Offset = "0x733EA60", VA = "0x187340060")]
	[AsyncStateMachine(typeof(PAEOGPBMFME))]
	private Task<INJHLDLALFB> DBCIOHDGALL(INJHLDLALFB DHJKJAHDCEA, ANLFOIKADDC HCKKLLBDGKF, NHPDOFIEOLC OGFHPDOEGDH, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ, bool MPIEHMCNOGI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x73409C0", Offset = "0x733F3C0", VA = "0x1873409C0")]
	private bool IIEEPDLPABB(ANLFOIKADDC LGABIEMBFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x7340330", Offset = "0x733ED30", VA = "0x187340330")]
	[AsyncStateMachine(typeof(LOKDJIOMOLE))]
	protected Task<INJHLDLALFB> DEBDIGGPIEI(ANLFOIKADDC JGCMECODHDI, LDAGNFBJONA ECGMBOLIJDC, NHPDOFIEOLC OGFHPDOEGDH, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ, LOCELGCCLDL BLJNMCPCFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x7340BF0", Offset = "0x733F5F0", VA = "0x187340BF0")]
	[AsyncStateMachine(typeof(CONGOJMLKCG))]
	private Task JLJCKMMENCP(ANLFOIKADDC JGCMECODHDI, NHPDOFIEOLC OGFHPDOEGDH, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x73406A0", Offset = "0x733F0A0", VA = "0x1873406A0")]
	private void GINHIJBFHFH(INJHLDLALFB IHIOGOPLHEE, NHPDOFIEOLC OGFHPDOEGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x7340620", Offset = "0x733F020", VA = "0x187340620")]
	private void FFEENHJGHGL(INJHLDLALFB GDECBBICGAA, [Out] INJHLDLALFB MECENIDJDPN, [Out] INJHLDLALFB BINLJPFPAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x733FE10", Offset = "0x733E810", VA = "0x18733FE10")]
	private Task<IFANDGEHPIL> AKADCELGMCB(HHMBNBENNDA NEKCFCOLDAN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x73416A0", Offset = "0x73400A0", VA = "0x1873416A0")]
	private Task<ANLFOIKADDC> PHPDGNDLAEP(IFANDGEHPIL JGCMECODHDI, HNDCNJIJLFL.DNNCMLIGBAE CGFMLHAFPII, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x7341550", Offset = "0x733FF50", VA = "0x187341550")]
	[AsyncStateMachine(typeof(JHMLADGPHJI))]
	private Task PCOFFEFBKCN(ANLFOIKADDC JGCMECODHDI, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ, bool HFFCMILFNLA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x7341020", Offset = "0x733FA20", VA = "0x187341020")]
	[AsyncStateMachine(typeof(OGEENCPFNLE))]
	private Task KOEDDCFNFPE(ANLFOIKADDC JGCMECODHDI, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x733FEC0", Offset = "0x733E8C0", VA = "0x18733FEC0")]
	private Task BHBFFJBHBPP(ANLFOIKADDC JGCMECODHDI, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x733FE50", Offset = "0x733E850", VA = "0x18733FE50")]
	private Task BDOPCEOGOGP(ANLFOIKADDC JGCMECODHDI, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x7340040", Offset = "0x733EA40", VA = "0x187340040")]
	private Task BKDEAILIIEO(ANLFOIKADDC JGCMECODHDI, LDAGNFBJONA ECGMBOLIJDC, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x7341530", Offset = "0x733FF30", VA = "0x187341530")]
	private Task OPEGGKEBCCC(ANLFOIKADDC JGCMECODHDI, LDAGNFBJONA ECGMBOLIJDC, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x7341520", Offset = "0x733FF20", VA = "0x187341520")]
	private static Task OMBHCOJHMEA(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x7340EC0", Offset = "0x733F8C0", VA = "0x187340EC0")]
	private Task KDKFJNKCOIC(ANLFOIKADDC JGCMECODHDI, LDAGNFBJONA ECGMBOLIJDC, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x7340660", Offset = "0x733F060", VA = "0x187340660")]
	private Task FPOAPNOHHGA(ANLFOIKADDC JGCMECODHDI, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x733FE70", Offset = "0x733E870", VA = "0x18733FE70")]
	private void BFMDDGPNFLO(HHMBNBENNDA NEKCFCOLDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x7340680", Offset = "0x733F080", VA = "0x187340680")]
	public void GGDGCANBMAB(long CBAGNPPEFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	private static void LJEIPJOMPAA(LGKHNIEIJHC LFMOELFFHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x733FEF0", Offset = "0x733E8F0", VA = "0x18733FEF0")]
	[AsyncStateMachine(typeof(PAFBJOKMIMP))]
	private Task BHLIHGCJGAB(ANLFOIKADDC LGABIEMBFIL, NHPDOFIEOLC JLAKCJGKCNA, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken EJEEEOHMGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x73404C0", Offset = "0x733EEC0", VA = "0x1873404C0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(BFGEHPMINII))]
	private Task<INJHLDLALFB> DFDKCPKMMCO(ANLFOIKADDC JGCMECODHDI, LDAGNFBJONA ECGMBOLIJDC, NHPDOFIEOLC OGFHPDOEGDH, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct AMINALOHGOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private ANLFOIKADDC JGCMECODHDI;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private HIANIBLJMCN DBCHGEHMEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x734FD90", Offset = "0x734E790", VA = "0x18734FD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x734FDE0", Offset = "0x734E7E0", VA = "0x18734FDE0")]
	public static Task CKOMBPKHALD(BEEALJNDIKM BPLHAJDMKHP, ANLFOIKADDC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x734FEC0", Offset = "0x734E8C0", VA = "0x18734FEC0")]
	private void CKOMBPKHALD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct MEJECANAJBA
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x7362AB0", Offset = "0x73614B0", VA = "0x187362AB0")]
	public static Task CKOMBPKHALD(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct IOODOLPIHCN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct CLDIPHEEEJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public HPJHGCAGHML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private APPPBJLIGLH<string>.LANPOEPHMID <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x7352C20", Offset = "0x7351620", VA = "0x187352C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x7353140", Offset = "0x7351B40", VA = "0x187353140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x735CFA0", Offset = "0x735B9A0", VA = "0x18735CFA0")]
	[AsyncStateMachine(typeof(CLDIPHEEEJP))]
	public static Task CKOMBPKHALD(HPJHGCAGHML COEIHFBAEEN, ANLFOIKADDC JGCMECODHDI, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct ABEPLLNKNKN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct CDBHAANMENJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public HPJHGCAGHML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public LDAGNFBJONA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private INJHLDLALFB <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private BEEALJNDIKM <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private HIANIBLJMCN <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private GFHOFHONACH <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private List<(PersistenceView, GIFFLNOJBNJ)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private GIFFLNOJBNJ <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x7351E10", Offset = "0x7350810", VA = "0x187351E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x7352A80", Offset = "0x7351480", VA = "0x187352A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x734EDD0", Offset = "0x734D7D0", VA = "0x18734EDD0")]
	[AsyncStateMachine(typeof(CDBHAANMENJ))]
	public static Task CKOMBPKHALD(HPJHGCAGHML COEIHFBAEEN, ANLFOIKADDC JGCMECODHDI, LDAGNFBJONA ECGMBOLIJDC, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x734EF20", Offset = "0x734D920", VA = "0x18734EF20")]
	private static void LKKNJAIKPIO(PersistenceView NKLHHJOEDHF, GIFFLNOJBNJ LBLEGAGFFHC, ANLFOIKADDC JGCMECODHDI, INJHLDLALFB DHJKJAHDCEA, bool DBNOMKFMHII)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct LDDDPIBMHHO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct DIIDKLLGOOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public BEEALJNDIKM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x7353BB0", Offset = "0x73525B0", VA = "0x187353BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7353FE0", Offset = "0x73529E0", VA = "0x187353FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7360440", Offset = "0x735EE40", VA = "0x187360440")]
	[AsyncStateMachine(typeof(DIIDKLLGOOK))]
	public static Task CKOMBPKHALD(BEEALJNDIKM BPLHAJDMKHP, ANLFOIKADDC JGCMECODHDI, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct JHBBGLGPECG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct FCCBFGHKIHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public BEEALJNDIKM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public HPJHGCAGHML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x7356D10", Offset = "0x7355710", VA = "0x187356D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7356F20", Offset = "0x7355920", VA = "0x187356F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class LEOAOADEMCA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public APPPBJLIGLH<string>.LANPOEPHMID timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public LEOAOADEMCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x7367390", Offset = "0x7365D90", VA = "0x187367390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x7367720", Offset = "0x7366120", VA = "0x187367720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LEOAOADEMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x7360550", Offset = "0x735EF50", VA = "0x187360550")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task LDAAEPAGNNI(APPPBJLIGLH<string>.LANPOEPHMID timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct MLBKCAFAEEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public JHBBGLGPECG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter<DDFNKKNNNOO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x7362B90", Offset = "0x7361590", VA = "0x187362B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x7363550", Offset = "0x7361F50", VA = "0x187363550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class EMCFFPMMADP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public CHNAKMPIEHA version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EMCFFPMMADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x7356790", Offset = "0x7355190", VA = "0x187356790")]
		internal object CHHBNCJAIEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x73566E0", Offset = "0x73550E0", VA = "0x1873566E0")]
		internal object AGPDILHGOIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private ANLFOIKADDC JGCMECODHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private HPJHGCAGHML COEIHFBAEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private bool HFFCMILFNLA;

	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private static readonly ByteString MKOPMNLANGE;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private HIANIBLJMCN DBCHGEHMEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x735DCA0", Offset = "0x735C6A0", VA = "0x18735DCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private JHCJKADOLFD EOEFNJKPLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x735DFC0", Offset = "0x735C9C0", VA = "0x18735DFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x735DCF0", Offset = "0x735C6F0", VA = "0x18735DCF0")]
	[AsyncStateMachine(typeof(FCCBFGHKIHK))]
	public static Task CKOMBPKHALD(BEEALJNDIKM BPLHAJDMKHP, ANLFOIKADDC JGCMECODHDI, HPJHGCAGHML COEIHFBAEEN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ, bool HFFCMILFNLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x735DE40", Offset = "0x735C840", VA = "0x18735DE40")]
	[AsyncStateMachine(typeof(MLBKCAFAEEP))]
	private Task CKOMBPKHALD(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x735E060", Offset = "0x735CA60", VA = "0x18735E060")]
	private void JBHKDCLFHID([NotNull] ANPHFBDJECI HMKLJBLDGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x735DF80", Offset = "0x735C980", VA = "0x18735DF80")]
	private bool FBNFOJECOKL(CHNAKMPIEHA CJEHFDAEGCE, ANPHFBDJECI HMKLJBLDGHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct DIKNGFEPOFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct HDENIPCEPGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public AsyncTaskMethodBuilder<ANLFOIKADDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public DIKNGFEPOFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public HNDCNJIJLFL.DNNCMLIGBAE downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private APPPBJLIGLH<string>.LANPOEPHMID <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private TaskAwaiter<(BCLNLKLFCPB<HJGNFGCDHNI, LBGFPGMHGDG>, BCLNLKLFCPB<CKKLNOOKGGD<ANPHFBDJECI>, LBGFPGMHGDG>, BCLNLKLFCPB<CKKLNOOKGGD<PIKJJPNAMNM>, LBGFPGMHGDG>, BCLNLKLFCPB<CKKLNOOKGGD<ODLNIBGADPI>, LBGFPGMHGDG>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7359600", Offset = "0x7358000", VA = "0x187359600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x735A0B0", Offset = "0x7358AB0", VA = "0x18735A0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct ILOOJJDCCNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<HJGNFGCDHNI, LBGFPGMHGDG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public APPPBJLIGLH<string>.LANPOEPHMID downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public DIKNGFEPOFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public HNDCNJIJLFL.DNNCMLIGBAE downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter<BCLNLKLFCPB<HJGNFGCDHNI, LBGFPGMHGDG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x735C920", Offset = "0x735B320", VA = "0x18735C920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x735CF30", Offset = "0x735B930", VA = "0x18735CF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private JOMNDKMPEGJ<GDGMMMLOHOM, PIKJJPNAMNM> HHMACOFEMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private JOMNDKMPEGJ<GDGMMMLOHOM, ANPHFBDJECI> IBHDEHLHFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private JOMNDKMPEGJ<long, ODLNIBGADPI> JJOKMMPFFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private DCMKEGOFLLC DPGKGAHEEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private LGKHNIEIJHC LFMOELFFHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private GPIOLPLJMNL BOIILHDKBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private string MLOHFKEBHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private GDGMMMLOHOM FFHNFKPFGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private GDGMMMLOHOM IBGIHNMJLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private long CBAGNPPEFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM;

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x7354390", Offset = "0x7352D90", VA = "0x187354390")]
	public static Task<ANLFOIKADDC> PLBNPFNPDLN(BEEALJNDIKM BPLHAJDMKHP, [In] IFANDGEHPIL JGCMECODHDI, HNDCNJIJLFL.DNNCMLIGBAE CGFMLHAFPII, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x7354040", Offset = "0x7352A40", VA = "0x187354040")]
	[AsyncStateMachine(typeof(HDENIPCEPGJ))]
	private Task<ANLFOIKADDC> CKOMBPKHALD(HNDCNJIJLFL.DNNCMLIGBAE CGFMLHAFPII, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x73541D0", Offset = "0x7352BD0", VA = "0x1873541D0")]
	[AsyncStateMachine(typeof(ILOOJJDCCNJ))]
	private Task<BCLNLKLFCPB<HJGNFGCDHNI, LBGFPGMHGDG>> CPNIAONOKBE(string MLOHFKEBHCJ, long CBAGNPPEFDD, long? FNKMOIJJLLC, long? KAEOEGGGCFM, HNDCNJIJLFL.DNNCMLIGBAE CGFMLHAFPII, APPPBJLIGLH<string>.LANPOEPHMID ELBHKFMGDMI, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct HHCJJDKGCKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct ELKFPKMCHJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public AsyncTaskMethodBuilder<IFANDGEHPIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public HHCJJDKGCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private APPPBJLIGLH<string>.LANPOEPHMID <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private TaskAwaiter<IFANDGEHPIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7356270", Offset = "0x7354C70", VA = "0x187356270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7356670", Offset = "0x7355070", VA = "0x187356670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct FABLEEBHBGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AsyncTaskMethodBuilder<IFANDGEHPIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public HHCJJDKGCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter<IFANDGEHPIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x7356870", Offset = "0x7355270", VA = "0x187356870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x7356CA0", Offset = "0x73556A0", VA = "0x187356CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class LMBHLBAKEMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LMBHLBAKEMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x955340", Offset = "0x953D40", VA = "0x180955340")]
		internal bool FKOJCMGFFDF(GPIOLPLJMNL sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct KKEEDBONFLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder<IFANDGEHPIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public GDGMMMLOHOM superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public HIANIBLJMCN callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private LMBHLBAKEMO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public APBLLCPLLGK roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private LGKHNIEIJHC <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private GPIOLPLJMNL <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private GDGMMMLOHOM <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private GDGMMMLOHOM <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private TaskAwaiter<LGKHNIEIJHC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter<HDFDHEKBLHP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private TaskAwaiter<BOFGPKPACMJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x735E770", Offset = "0x735D170", VA = "0x18735E770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x735F8B0", Offset = "0x735E2B0", VA = "0x18735F8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private HIANIBLJMCN GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private AGACIEIJNOB NIKMEECOFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private APBLLCPLLGK GIJAMFOOCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private long FNKMOIJJLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private long PIGKPDHCACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private long AGBIDMLFJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private string HJDICKDHJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private GDGMMMLOHOM NAEEDHNPKPF;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x735ACC0", Offset = "0x73596C0", VA = "0x18735ACC0")]
	public static Task<IFANDGEHPIL> PLBNPFNPDLN(BEEALJNDIKM BPLHAJDMKHP, HHMBNBENNDA NEKCFCOLDAN, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x735AB40", Offset = "0x7359540", VA = "0x18735AB40")]
	[AsyncStateMachine(typeof(ELKFPKMCHJD))]
	private Task<IFANDGEHPIL> CKOMBPKHALD(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x735A840", Offset = "0x7359240", VA = "0x18735A840")]
	[AsyncStateMachine(typeof(FABLEEBHBGD))]
	private Task<IFANDGEHPIL> AKADCELGMCB(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x735A9A0", Offset = "0x73593A0", VA = "0x18735A9A0")]
	[AsyncStateMachine(typeof(KKEEDBONFLM))]
	private static Task<IFANDGEHPIL> AKADCELGMCB(HIANIBLJMCN GDGJPCNEJIO, APBLLCPLLGK GIJAMFOOCEA, long FNKMOIJJLLC, long PIGKPDHCACB, long AGBIDMLFJLK, string HJDICKDHJJJ, GDGMMMLOHOM NAEEDHNPKPF, CancellationToken IONNNJNKLMJ, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x735AC90", Offset = "0x7359690", VA = "0x18735AC90")]
	private void GKONOBCJEPH(LGKHNIEIJHC LFMOELFFHGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal struct LCFMJOPEHDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct BMIELENGJOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public LCFMJOPEHDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x7350BB0", Offset = "0x734F5B0", VA = "0x187350BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x7351140", Offset = "0x734FB40", VA = "0x187351140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private HIANIBLJMCN GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private ANLFOIKADDC JGCMECODHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private float OLPNAAJLKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private float GJDNCOJKMLP;

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x735FF50", Offset = "0x735E950", VA = "0x18735FF50")]
	public static Task KJFPMNEJCCC(BEEALJNDIKM BPLHAJDMKHP, ANLFOIKADDC JGCMECODHDI, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x735FE30", Offset = "0x735E830", VA = "0x18735FE30")]
	[AsyncStateMachine(typeof(BMIELENGJOM))]
	public Task CKOMBPKHALD(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x73601B0", Offset = "0x735EBB0", VA = "0x1873601B0")]
	private static void LPIPEDGGBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x73602E0", Offset = "0x735ECE0", VA = "0x1873602E0")]
	private void PPDGDKCEGCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x73600F0", Offset = "0x735EAF0", VA = "0x1873600F0")]
	private static float LFCJCAHNHGL(HIANIBLJMCN GDGJPCNEJIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x735FE10", Offset = "0x735E810", VA = "0x18735FE10")]
	private static float BGADCMHCFOL()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct EKJNMLMIMEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct FHMPKCCBGAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public HPJHGCAGHML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private EDIIHMJKPCA <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private BEEALJNDIKM <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private BOHBAPKBKFG.HIEBHINHEDL <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private TaskAwaiter<DDFNKKNNNOO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x7357790", Offset = "0x7356190", VA = "0x187357790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x7357FA0", Offset = "0x73569A0", VA = "0x187357FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct BAOGECPFHPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x73507F0", Offset = "0x734F1F0", VA = "0x1873507F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x7350AE0", Offset = "0x734F4E0", VA = "0x187350AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x7356070", Offset = "0x7354A70", VA = "0x187356070")]
	[AsyncStateMachine(typeof(FHMPKCCBGAH))]
	public static Task CKOMBPKHALD(HPJHGCAGHML COEIHFBAEEN, ANLFOIKADDC JGCMECODHDI, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x7356000", Offset = "0x7354A00", VA = "0x187356000")]
	private static Task<DDFNKKNNNOO> BLOAGFMDGMJ(HPJHGCAGHML COEIHFBAEEN, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x73561B0", Offset = "0x7354BB0", VA = "0x1873561B0")]
	[AsyncStateMachine(typeof(BAOGECPFHPM))]
	private static Task IJDDPGIEMHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct NEADCCCKLMD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct APIMBIBIFHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public NEADCCCKLMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x73500E0", Offset = "0x734EAE0", VA = "0x1873500E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x7350790", Offset = "0x734F190", VA = "0x187350790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class ONJCAIDNBPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ONJCAIDNBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x73661C0", Offset = "0x7364BC0", VA = "0x1873661C0")]
		internal object FLMFPGECNCH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct JCCIAIJDHLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public NEADCCCKLMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x735D7E0", Offset = "0x735C1E0", VA = "0x18735D7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x735DC40", Offset = "0x735C640", VA = "0x18735DC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	private bool FFJKGHPCMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	private CancellationToken IONNNJNKLMJ;

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x7364290", Offset = "0x7362C90", VA = "0x187364290")]
	public static Task JCJOKPEOJHI(BEEALJNDIKM BPLHAJDMKHP, bool FFJKGHPCMHL, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken LIPEIAELIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x7364070", Offset = "0x7362A70", VA = "0x187364070")]
	[AsyncStateMachine(typeof(APIMBIBIFHE))]
	private Task CKOMBPKHALD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x7364160", Offset = "0x7362B60", VA = "0x187364160")]
	[AsyncStateMachine(typeof(JCCIAIJDHLO))]
	private Task HPINOJDBMLD(bool NGJHJADFEEB, string BFMPCJDOKPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40")]
	private bool DONKEOCGLDI(bool FFJKGHPCMHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct OBFCBDFHGMD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct MOOJPKAGCPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public OBFCBDFHGMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7363A90", Offset = "0x7362490", VA = "0x187363A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7364000", Offset = "0x7362A00", VA = "0x187364000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class LFPAPKDIFLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LFPAPKDIFLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x7360670", Offset = "0x735F070", VA = "0x187360670")]
		internal object FLMFPGECNCH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct LBJPLGCMPLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public OBFCBDFHGMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x735F920", Offset = "0x735E320", VA = "0x18735F920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x735FDA0", Offset = "0x735E7A0", VA = "0x18735FDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private OOFIHHKJHCF KNPKPKGPNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private bool KFDDMOMCCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private ANLFOIKADDC JGCMECODHDI;

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x7365F00", Offset = "0x7364900", VA = "0x187365F00")]
	public static Task<Scene> KDIMKBEBJHP(BEEALJNDIKM BPLHAJDMKHP, OOFIHHKJHCF IMGHEPDIPDH, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x7365C60", Offset = "0x7364660", VA = "0x187365C60")]
	[AsyncStateMachine(typeof(MOOJPKAGCPN))]
	private Task<Scene> CKOMBPKHALD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x7365ED0", Offset = "0x73648D0", VA = "0x187365ED0")]
	private bool IEPNPGJJMCD(ANLFOIKADDC JGCMECODHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x7365F80", Offset = "0x7364980", VA = "0x187365F80")]
	private void LLGGEPLEEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x7365D80", Offset = "0x7364780", VA = "0x187365D80")]
	[AsyncStateMachine(typeof(LBJPLGCMPLH))]
	private Task<Scene> HPINOJDBMLD(string BFMPCJDOKPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct MNDADHLICLP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct ILMOOALEGGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder<INJHLDLALFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public MNDADHLICLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public INJHLDLALFB nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public ANLFOIKADDC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private APPPBJLIGLH<string>.LANPOEPHMID <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private TaskAwaiter<INJHLDLALFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x735BDD0", Offset = "0x735A7D0", VA = "0x18735BDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x735C8B0", Offset = "0x735B2B0", VA = "0x18735C8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct NNNGBHJGMHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public AsyncTaskMethodBuilder<INJHLDLALFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public MNDADHLICLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public INJHLDLALFB state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private TaskAwaiter<DDFNKKNNNOO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x7365300", Offset = "0x7363D00", VA = "0x187365300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x73655E0", Offset = "0x7363FE0", VA = "0x1873655E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private readonly HPJHGCAGHML COEIHFBAEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private readonly AGACIEIJNOB NIKMEECOFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private readonly NIGDOAMLAIP MNIJAOEAGKE;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private EDIIHMJKPCA HIGMOHCHDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x5AB31A0", Offset = "0x5AB1BA0", VA = "0x185AB31A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x7363A30", Offset = "0x7362430", VA = "0x187363A30")]
	public MNDADHLICLP(HPJHGCAGHML COEIHFBAEEN, AGACIEIJNOB NIKMEECOFFH, NIGDOAMLAIP MNIJAOEAGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x7363890", Offset = "0x7362290", VA = "0x187363890")]
	[AsyncStateMachine(typeof(ILMOOALEGGK))]
	public Task<INJHLDLALFB> MEEGACKNDGO(INJHLDLALFB ENGKPFFAALP, ANLFOIKADDC HCKKLLBDGKF, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ, bool MPIEHMCNOGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x7363730", Offset = "0x7362130", VA = "0x187363730")]
	[AsyncStateMachine(typeof(NNNGBHJGMHM))]
	private Task<INJHLDLALFB> IMNDLFFKJEO(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, INJHLDLALFB FDKAGJLJMPF, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x7363700", Offset = "0x7362100", VA = "0x187363700")]
	private bool DFHFKJNKNNO(INJHLDLALFB HPBPGLDPKPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x7363A10", Offset = "0x7362410", VA = "0x187363A10")]
	private void OJMFFMAGFPH(string GGCMALNCNCP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct IBGKPBEKJFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct HEGHGFMDONF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public EDIIHMJKPCA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public LDAGNFBJONA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private GFHOFHONACH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private List<(PersistenceView, GIFFLNOJBNJ)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private (PersistenceView, GIFFLNOJBNJ) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x735A120", Offset = "0x7358B20", VA = "0x18735A120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x735A730", Offset = "0x7359130", VA = "0x18735A730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x735B800", Offset = "0x735A200", VA = "0x18735B800")]
	[AsyncStateMachine(typeof(HEGHGFMDONF))]
	public static Task CKOMBPKHALD(EDIIHMJKPCA OPLFDLOEKLI, ANLFOIKADDC JGCMECODHDI, LDAGNFBJONA ECGMBOLIJDC, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct CKKMHPBKFDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct DGACKJIEMOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public EDIIHMJKPCA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public LDAGNFBJONA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private CHNAKMPIEHA <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private GFHOFHONACH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private List<(PersistenceView, GIFFLNOJBNJ)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private GIFFLNOJBNJ <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x7353300", Offset = "0x7351D00", VA = "0x187353300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7353B50", Offset = "0x7352550", VA = "0x187353B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x7352AE0", Offset = "0x73514E0", VA = "0x187352AE0")]
	[AsyncStateMachine(typeof(DGACKJIEMOA))]
	public static Task CKOMBPKHALD(EDIIHMJKPCA OPLFDLOEKLI, ANLFOIKADDC JGCMECODHDI, LDAGNFBJONA ECGMBOLIJDC, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct BOHBAPKBKFG
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public struct HIEBHINHEDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public List<ADINIACMIJA> AIGHHPMNJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public List<GIFFLNOJBNJ> CMHNPGFKNGM;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xD09E10", Offset = "0xD08810", VA = "0x180D09E10")]
		public HIEBHINHEDL(List<ADINIACMIJA> AIGHHPMNJBF, List<GIFFLNOJBNJ> CMHNPGFKNGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class OPLMGPEIALO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public IEnumerable<ADINIACMIJA> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public OPLMGPEIALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x7366240", Offset = "0x7364C40", VA = "0x187366240")]
		internal object JKPKLCDMFBE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private BEEALJNDIKM BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000600")]
	private ANLFOIKADDC JGCMECODHDI;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private HIANIBLJMCN DBCHGEHMEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x73511A0", Offset = "0x734FBA0", VA = "0x1873511A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x73511F0", Offset = "0x734FBF0", VA = "0x1873511F0")]
	public static HIEBHINHEDL CKOMBPKHALD(BEEALJNDIKM BPLHAJDMKHP, ANLFOIKADDC JGCMECODHDI)
	{
		return default(HIEBHINHEDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x7351250", Offset = "0x734FC50", VA = "0x187351250")]
	private HIEBHINHEDL CKOMBPKHALD()
	{
		return default(HIEBHINHEDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x73514A0", Offset = "0x734FEA0", VA = "0x1873514A0")]
	private HIEBHINHEDL GOBMGCMEIAI(ANPHFBDJECI HMKLJBLDGHJ, CHNAKMPIEHA LEMDJDELLGF)
	{
		return default(HIEBHINHEDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x7351A50", Offset = "0x7350450", VA = "0x187351A50")]
	private bool NGEMPIPHBMA(IEnumerable<ADINIACMIJA> AIGHHPMNJBF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct LGCBLCNMELJ
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class HFFGCAIMFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public BOHBAPKBKFG.HIEBHINHEDL instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public HFFGCAIMFJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x735A790", Offset = "0x7359190", VA = "0x18735A790")]
		internal object LDAAEPAGNNI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class CCPCEMPDAAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public CCPCEMPDAAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7351D80", Offset = "0x7350780", VA = "0x187351D80")]
		internal object HHABCBDKBOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x73606C0", Offset = "0x735F0C0", VA = "0x1873606C0")]
	public static void CKOMBPKHALD(EDIIHMJKPCA OPLFDLOEKLI, ANLFOIKADDC JGCMECODHDI, BOHBAPKBKFG.HIEBHINHEDL LPDDIHAAJDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal class NIGDOAMLAIP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct ALDFAEBLCOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public NIGDOAMLAIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public INJHLDLALFB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public ANLFOIKADDC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x734F2F0", Offset = "0x734DCF0", VA = "0x18734F2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x734FA60", Offset = "0x734E460", VA = "0x18734FA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class CBHLOGLHEID
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000615")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			public CBHLOGLHEID <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x7367070", Offset = "0x7365A70", VA = "0x187367070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x7367330", Offset = "0x7365D30", VA = "0x187367330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public NIGDOAMLAIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public APPPBJLIGLH<string>.LANPOEPHMID handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public CBHLOGLHEID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x7351C90", Offset = "0x7350690", VA = "0x187351C90")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task IAGBFPCPNAG(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct LIHCAMDLDPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public NIGDOAMLAIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private CBHLOGLHEID <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x7360C70", Offset = "0x735F670", VA = "0x187360C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x73611A0", Offset = "0x735FBA0", VA = "0x1873611A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct NNPMHGPKPLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public NIGDOAMLAIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private Dictionary<Guid, List<DOHELJHHEAG>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x7365650", Offset = "0x7364050", VA = "0x187365650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x7365C00", Offset = "0x7364600", VA = "0x187365C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct GNGOMFIOKPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public NIGDOAMLAIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private Dictionary<Guid, List<DOHELJHHEAG>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x7358F20", Offset = "0x7357920", VA = "0x187358F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x73595A0", Offset = "0x7357FA0", VA = "0x1873595A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class ALFEOHONNFF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000173")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			public DOHELJHHEAG handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			public ALFEOHONNFF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x7366E70", Offset = "0x7365870", VA = "0x187366E70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x7367010", Offset = "0x7365A10", VA = "0x187367010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public KCKPMPBABHL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public List<DOHELJHHEAG> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ALFEOHONNFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x734FBB0", Offset = "0x734E5B0", VA = "0x18734FBB0")]
		internal object CCAFKIDICIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x734FAC0", Offset = "0x734E4C0", VA = "0x18734FAC0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task APCHFHFDAFB(DOHELJHHEAG handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x734FCA0", Offset = "0x734E6A0", VA = "0x18734FCA0")]
		internal object FIPKKELFAKB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct PNBNDKLGCHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public KCKPMPBABHL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public List<DOHELJHHEAG> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private ALFEOHONNFF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x7366950", Offset = "0x7365350", VA = "0x187366950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7366E10", Offset = "0x7365810", VA = "0x187366E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct MADIGEHCKKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public NIGDOAMLAIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public APPPBJLIGLH<string>.LANPOEPHMID timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7361200", Offset = "0x735FC00", VA = "0x187361200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x73617C0", Offset = "0x73601C0", VA = "0x1873617C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class CAFJFPOPBEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public CAFJFPOPBEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x7351C20", Offset = "0x7350620", VA = "0x187351C20")]
		internal object ABNFPDBADNA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct DJDJMOCFMIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public NIGDOAMLAIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public ANLFOIKADDC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x7354700", Offset = "0x7353100", VA = "0x187354700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x7354BC0", Offset = "0x73535C0", VA = "0x187354BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class NFIGBJHGGAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NFIGBJHGGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x7364300", Offset = "0x7362D00", VA = "0x187364300")]
		internal object EDGDMIHPCJC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct PAGIGAGNOLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public NIGDOAMLAIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private TaskAwaiter<DDFNKKNNNOO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x73662C0", Offset = "0x7364CC0", VA = "0x1873662C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x73668F0", Offset = "0x73652F0", VA = "0x1873668F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class BDIAHKDNBAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public BDIAHKDNBAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x7350B40", Offset = "0x734F540", VA = "0x187350B40")]
		internal object KFOLFLMMMDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private readonly HPJHGCAGHML COEIHFBAEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private LDHEOKIGPMN MNIJAOEAGKE;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private EDIIHMJKPCA HIGMOHCHDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xB35480", Offset = "0xB33E80", VA = "0x180B35480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public NIGDOAMLAIP(HPJHGCAGHML COEIHFBAEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x7364610", Offset = "0x7363010", VA = "0x187364610")]
	[AsyncStateMachine(typeof(ALDFAEBLCOA))]
	public Task CKOMBPKHALD(INJHLDLALFB DHJKJAHDCEA, ANLFOIKADDC HCKKLLBDGKF, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x73649F0", Offset = "0x73633F0", VA = "0x1873649F0")]
	[AsyncStateMachine(typeof(LIHCAMDLDPO))]
	private Task HELDJDJDIAO(ANLFOIKADDC JGCMECODHDI, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x7364760", Offset = "0x7363160", VA = "0x187364760")]
	[AsyncStateMachine(typeof(NNPMHGPKPLP))]
	private Task ELKHMCCCOCH(ANLFOIKADDC JGCMECODHDI, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x73643C0", Offset = "0x7362DC0", VA = "0x1873643C0")]
	[AsyncStateMachine(typeof(GNGOMFIOKPP))]
	private Task AHPDKPCLOBG(ANLFOIKADDC JGCMECODHDI, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x73648A0", Offset = "0x73632A0", VA = "0x1873648A0")]
	[AsyncStateMachine(typeof(PNBNDKLGCHC))]
	private Task ENEDPHJKHHD(Guid AHCMODCCDHH, List<DOHELJHHEAG> HLMGKPJDBOD, KCKPMPBABHL GBFOPFOAKFJ, ANLFOIKADDC JGCMECODHDI, CancellationToken FLLNLBHFENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x73651C0", Offset = "0x7363BC0", VA = "0x1873651C0")]
	[AsyncStateMachine(typeof(MADIGEHCKKI))]
	private Task ONJBLEKFBHL(ANLFOIKADDC JGCMECODHDI, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x7364BE0", Offset = "0x73635E0", VA = "0x187364BE0")]
	[AsyncStateMachine(typeof(DJDJMOCFMIN))]
	private Task HPADPACBAID(Guid DDKKBBDPJCO, ANLFOIKADDC JGCMECODHDI, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x7364EB0", Offset = "0x73638B0", VA = "0x187364EB0")]
	[AsyncStateMachine(typeof(PAGIGAGNOLJ))]
	private Task JCAMFHEFINN(Guid DDKKBBDPJCO, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x7364500", Offset = "0x7362F00", VA = "0x187364500")]
	private void CHHGNEAMFCJ(Guid DDKKBBDPJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x7364B30", Offset = "0x7363530", VA = "0x187364B30")]
	private void HJPFFPMOGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x7364D20", Offset = "0x7363720", VA = "0x187364D20")]
	public Guid IPHGPKOAJEG(INJHLDLALFB IHIOGOPLHEE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x7364FF0", Offset = "0x73639F0", VA = "0x187364FF0")]
	[CompilerGenerated]
	private object MAEDIGCBPHO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct CPIGANHNNOG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct AAKMAENFIAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public CPIGANHNNOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private IEnumerator<DFAEJJCMMDK> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x734E690", Offset = "0x734D090", VA = "0x18734E690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x734ED70", Offset = "0x734D770", VA = "0x18734ED70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private HIANIBLJMCN GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private CancellationToken IONNNJNKLMJ;

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x7353290", Offset = "0x7351C90", VA = "0x187353290")]
	public static Task FMFKDMFODMO(HIANIBLJMCN GDGJPCNEJIO, APPPBJLIGLH<string>.LANPOEPHMID LOIGOPGNFFM, CancellationToken LIPEIAELIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x73531A0", Offset = "0x7351BA0", VA = "0x1873531A0")]
	[AsyncStateMachine(typeof(AAKMAENFIAM))]
	private Task CKOMBPKHALD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct IGDHBHLHBPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	public readonly bool HGOPOJINBBD;

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x2309290", Offset = "0x2307C90", VA = "0x182309290")]
	public IGDHBHLHBPD(bool JMHCKCLIKAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public readonly struct MEHJOEPPCEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	public readonly ANPHFBDJECI? LHNBHIEGNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	public readonly GKGEHBGNFMJ AAIGAGPGOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	public readonly string? GIIPHAELJJP;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public IReadOnlyCollection<string> FKIKDPDPBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x7362970", Offset = "0x7361370", VA = "0x187362970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IReadOnlyDictionary<long, int> MCLPJPGIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x7362990", Offset = "0x7361390", VA = "0x187362990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x73629B0", Offset = "0x73613B0", VA = "0x1873629B0")]
	public MEHJOEPPCEK(ANPHFBDJECI? LLAPGPIJJLB, GKGEHBGNFMJ HAMDLILGGJI, string? MLOHFKEBHCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class MCNIBFGHKEK : IGFNMHIPGFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct EBPNIACFKCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder<MEHJOEPPCEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public MCNIBFGHKEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public GJPEDFMPFGK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public JBKIJJFEMIN roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private GFHOFHONACH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x7354C90", Offset = "0x7353690", VA = "0x187354C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x7355300", Offset = "0x7353D00", VA = "0x187355300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class FPLMKLGFHDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public GJPEDFMPFGK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public MCNIBFGHKEK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public FPLMKLGFHDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x7358000", Offset = "0x7356A00", VA = "0x187358000")]
		internal Task EFILPJJCNGG(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x7358210", Offset = "0x7356C10", VA = "0x187358210")]
		internal Task FGKMEAJILAC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class EANFFEOMEKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public FPLMKLGFHDP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EANFFEOMEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x7354C20", Offset = "0x7353620", VA = "0x187354C20")]
		internal object JJNCGFHPLJN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class AJPHKFNNJIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public FPLMKLGFHDP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public AJPHKFNNJIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x734F2B0", Offset = "0x734DCB0", VA = "0x18734F2B0")]
		internal Task DLGMOEOGBFJ(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct IAFCGMLPGDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public GJPEDFMPFGK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public MCNIBFGHKEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private EANFFEOMEKC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private GFHOFHONACH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x735AF40", Offset = "0x7359940", VA = "0x18735AF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x735B7A0", Offset = "0x735A1A0", VA = "0x18735B7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private static readonly TimeSpan OMLBFFKEBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly BDBDECHMKIG EFDNAALCNIO;

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x7362920", Offset = "0x7361320", VA = "0x187362920")]
	public MCNIBFGHKEK(HPJHGCAGHML COEIHFBAEEN, BDBDECHMKIG EFDNAALCNIO, CMICIECANPG FPPDOFKLJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x7361970", Offset = "0x7360370", VA = "0x187361970")]
	[AsyncStateMachine(typeof(EBPNIACFKCH))]
	public Task<MEHJOEPPCEK> AMCHBAGBIFH(long PIGKPDHCACB, JBKIJJFEMIN FOJIONBHMJM, GJPEDFMPFGK HFOMLLLDCBF, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x73622E0", Offset = "0x7360CE0", VA = "0x1873622E0")]
	[AsyncStateMachine(typeof(IAFCGMLPGDL))]
	private Task KAOEHNKGMAC(GJPEDFMPFGK HFOMLLLDCBF, IEnumerable<PersistenceView> KENCFBGEJNC, StringBuilder OHAJLIIOKJA, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x7361AD0", Offset = "0x73604D0", VA = "0x187361AD0")]
	private MEHJOEPPCEK BDBJACELDMO(long PIGKPDHCACB, JBKIJJFEMIN FOJIONBHMJM, GJPEDFMPFGK HFOMLLLDCBF, IEnumerable<PersistenceView> KENCFBGEJNC, StringBuilder OHAJLIIOKJA)
	{
		return default(MEHJOEPPCEK);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x7361820", Offset = "0x7360220", VA = "0x187361820")]
	private ANPHFBDJECI AJBLGDPMLPG(long PIGKPDHCACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x7362090", Offset = "0x7360A90", VA = "0x187362090")]
	private void GIBIBDEBEDK(ANPHFBDJECI DILEOHOOPEN, StringBuilder OHAJLIIOKJA, IEnumerable<PersistenceView> KENCFBGEJNC, [In] CAEKKOPCOEB PPBAPDHDPLG, MDPIPDLAMAN KDDHGGHCICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x7362420", Offset = "0x7360E20", VA = "0x187362420")]
	private void MKNFIHCAPHH(ANPHFBDJECI DILEOHOOPEN, StringBuilder OHAJLIIOKJA, PersistenceView NKLHHJOEDHF, MDPIPDLAMAN KDDHGGHCICN, [In] CAEKKOPCOEB PPBAPDHDPLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal class GGKCJPOLELJ : IGFNMHIPGFP
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class NHBNIHMGGEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public LENINMJDNMO.OFPMGLEFMFF roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NHBNIHMGGEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x7364370", Offset = "0x7362D70", VA = "0x187364370")]
		internal object EOLAGAEKNAB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct EIMINDIPPCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public AsyncTaskMethodBuilder<(LENINMJDNMO.OFPMGLEFMFF roomDataUpload, LENINMJDNMO.OFPMGLEFMFF subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public MEHJOEPPCEK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public GGKCJPOLELJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private NHBNIHMGGEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private TaskAwaiter<LENINMJDNMO.OFPMGLEFMFF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x7355740", Offset = "0x7354140", VA = "0x187355740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x7355F90", Offset = "0x7354990", VA = "0x187355F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct JBIGJDKLBLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public AsyncTaskMethodBuilder<IPHFHDPNPHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public GGKCJPOLELJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public MEHJOEPPCEK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public BPLKLHJMAAG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private TaskAwaiter<(LENINMJDNMO.OFPMGLEFMFF roomDataUpload, LENINMJDNMO.OFPMGLEFMFF subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private TaskAwaiter<IPHFHDPNPHJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x735D0E0", Offset = "0x735BAE0", VA = "0x18735D0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x735D770", Offset = "0x735C170", VA = "0x18735D770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private struct FDDLIILOHOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public AsyncTaskMethodBuilder<HDFDHEKBLHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public GGKCJPOLELJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public MEHJOEPPCEK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private TaskAwaiter<(LENINMJDNMO.OFPMGLEFMFF roomDataUpload, LENINMJDNMO.OFPMGLEFMFF subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private TaskAwaiter<HDFDHEKBLHP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x7356F80", Offset = "0x7355980", VA = "0x187356F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x73573A0", Offset = "0x7355DA0", VA = "0x1873573A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class GDIMKBPJHOO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			public AsyncTaskMethodBuilder<DDFNKKNNNOO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			public GDIMKBPJHOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			private DDFNKKNNNOO <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			private TaskAwaiter<HDFDHEKBLHP> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			private TaskAwaiter<IPHFHDPNPHJ> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			private TaskAwaiter<DDFNKKNNNOO> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x7367780", Offset = "0x7366180", VA = "0x187367780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x7368710", Offset = "0x7367110", VA = "0x187368710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public GGKCJPOLELJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public MEHJOEPPCEK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public BPLKLHJMAAG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public IGDHBHLHBPD roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GDIMKBPJHOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x73582F0", Offset = "0x7356CF0", VA = "0x1873582F0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<DDFNKKNNNOO> HLJPBMCPAJC(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct FGPGHIFECBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public AsyncTaskMethodBuilder<DDFNKKNNNOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public GGKCJPOLELJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public MEHJOEPPCEK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public BPLKLHJMAAG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public IGDHBHLHBPD roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private TaskAwaiter<DDFNKKNNNOO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x7357410", Offset = "0x7355E10", VA = "0x187357410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x7357720", Offset = "0x7356120", VA = "0x187357720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private static readonly CMICIECANPG DIOOPEKBCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private readonly IABENDKKNAO IKBLHDDIIDD;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private BEEALJNDIKM LHEDBANJIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x7340E90", Offset = "0x733F890", VA = "0x187340E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x7358A70", Offset = "0x7357470", VA = "0x187358A70")]
	public GGKCJPOLELJ(HPJHGCAGHML COEIHFBAEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x73585C0", Offset = "0x7356FC0", VA = "0x1873585C0")]
	[AsyncStateMachine(typeof(EIMINDIPPCD))]
	private Task<(LENINMJDNMO.OFPMGLEFMFF, LENINMJDNMO.OFPMGLEFMFF)> BDHNOCHLIPJ(MEHJOEPPCEK NOGJGLJBMOE, long FNKMOIJJLLC, long KAEOEGGGCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x7358700", Offset = "0x7357100", VA = "0x187358700")]
	[AsyncStateMachine(typeof(JBIGJDKLBLB))]
	public Task<IPHFHDPNPHJ> EGKHJFIOHMC(int BIENMLJGBNJ, [CanBeNull] BPLKLHJMAAG OAIOGDMPBHC, MEHJOEPPCEK NOGJGLJBMOE, long FNKMOIJJLLC, long KAEOEGGGCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x7358870", Offset = "0x7357270", VA = "0x187358870")]
	[AsyncStateMachine(typeof(FDDLIILOHOA))]
	private Task<HDFDHEKBLHP> EGKLHBHMGLD(string HJDICKDHJJJ, int BIENMLJGBNJ, MEHJOEPPCEK NOGJGLJBMOE, long FNKMOIJJLLC, long KAEOEGGGCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x7358420", Offset = "0x7356E20", VA = "0x187358420")]
	[AsyncStateMachine(typeof(FGPGHIFECBM))]
	public Task<DDFNKKNNNOO> AIBMNNGOCFD(int BIENMLJGBNJ, BPLKLHJMAAG? OAIOGDMPBHC, MEHJOEPPCEK NOGJGLJBMOE, long FNKMOIJJLLC, long KAEOEGGGCFM, IGDHBHLHBPD JGMDEBOCKEO, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public abstract class GLHJGKANNGB<T> where T : GLHJGKANNGB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	internal readonly BEEALJNDIKM FEPCNDHPHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private int? BHPEHGDICIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	protected readonly Guid BJHFNHBAIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	protected readonly JHBLFOFBKFH IOLPKLIJNAH;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	protected T IGOLIAGJHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x3EE4060", Offset = "0x3EE2A60", VA = "0x183EE4060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x3EE4160", Offset = "0x3EE2B60", VA = "0x183EE4160")]
	internal GLHJGKANNGB(BEEALJNDIKM CJEPJELJGAC, JHBLFOFBKFH ACDFMINNBKN, [Optional] Guid? FAOKHBLGHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3E50", Offset = "0x3EE2850", VA = "0x183EE3E50")]
	private DDFNKKNNNOO DKJEFOGMBAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "4")]
	protected virtual void AEKKBBKLGJH(DDFNKKNNNOO KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x3EE40C0", Offset = "0x3EE2AC0", VA = "0x183EE40C0")]
	public T GKBEEKGJAAF(PDPPFLAPOCL MBAGFJGPJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3DA0", Offset = "0x3EE27A0", VA = "0x183EE3DA0")]
	public T CGJPCBBNLOL(int CHABBALOHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3F30", Offset = "0x3EE2930", VA = "0x183EE3F30", Slot = "5")]
	public virtual Task<BFFBEBDHILG> FJCHJGLBPDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class AJEHHEDFAGG : GLHJGKANNGB<AJEHHEDFAGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private HHMBNBENNDA AJFODGMHKJN;

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x734F1E0", Offset = "0x734DBE0", VA = "0x18734F1E0")]
	internal AJEHHEDFAGG(BEEALJNDIKM CJEPJELJGAC, JHBLFOFBKFH ACDFMINNBKN, [Optional] Guid? FAOKHBLGHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x686ACC0", Offset = "0x68696C0", VA = "0x18686ACC0")]
	public AJEHHEDFAGG GLGOOGONHBP(HHMBNBENNDA AJFODGMHKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x734F110", Offset = "0x734DB10", VA = "0x18734F110", Slot = "4")]
	protected override void AEKKBBKLGJH(DDFNKKNNNOO KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public class ILAHAMKAGHN : GLHJGKANNGB<ILAHAMKAGHN>
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	internal enum LKHAFPNJMPN
	{
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct GJPODCKGPHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public AsyncTaskMethodBuilder<BFFBEBDHILG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public ILAHAMKAGHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private TaskAwaiter<BFFBEBDHILG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x7358B00", Offset = "0x7357500", VA = "0x187358B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x7358EB0", Offset = "0x73578B0", VA = "0x187358EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private LKHAFPNJMPN DFHMCELDKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private string KBIMLPNFHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private BPLKLHJMAAG AJFODGMHKJN;

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x735BC60", Offset = "0x735A660", VA = "0x18735BC60")]
	internal ILAHAMKAGHN(BEEALJNDIKM CJEPJELJGAC, JHBLFOFBKFH ACDFMINNBKN, [Optional] Guid? FAOKHBLGHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x735BC00", Offset = "0x735A600", VA = "0x18735BC00")]
	public ILAHAMKAGHN IIBJOLPMOJC(string PADNFDKMCHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x735BAB0", Offset = "0x735A4B0", VA = "0x18735BAB0")]
	public ILAHAMKAGHN EEKBBDOHOLE(bool LADFBGCEDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x735BC30", Offset = "0x735A630", VA = "0x18735BC30")]
	public ILAHAMKAGHN LCCDMEAJEIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x735B940", Offset = "0x735A340", VA = "0x18735B940", Slot = "4")]
	protected override void AEKKBBKLGJH(DDFNKKNNNOO KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x735BB10", Offset = "0x735A510", VA = "0x18735BB10", Slot = "5")]
	[AsyncStateMachine(typeof(GJPODCKGPHD))]
	public override Task<BFFBEBDHILG> FJCHJGLBPDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x735BAD0", Offset = "0x735A4D0", VA = "0x18735BAD0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<BFFBEBDHILG> EFPKCFNODEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal static class OGDMFNBFBFH
{
	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x7366070", Offset = "0x7364A70", VA = "0x187366070")]
	public static void KCKDGJODANM(this EJJAIGEJFIJ KMODNLGPNKJ, KHOOKALDLHN JMNNOFADHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x7365FF0", Offset = "0x73649F0", VA = "0x187365FF0")]
	public static void GIJFFINMLPH(this KHOOKALDLHN EKJBHGGEALF, [Optional] string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public static class MMOOFHLKINI
{
	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x7363660", Offset = "0x7362060", VA = "0x187363660")]
	public static GDGMMMLOHOM EKHGHNLELOP(this HKDOMDCMNMG BHLHDOJEGCE)
	{
		return default(GDGMMMLOHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x73635B0", Offset = "0x7361FB0", VA = "0x1873635B0")]
	public static HKDOMDCMNMG DODEOPNJJCO(this GDGMMMLOHOM LKFBMMKKHCH)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000197")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			public CJGBFBHKACP ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public CJGBFBHKACP HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private static CJGBFBHKACP[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private Dictionary<CJGBFBHKACP, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x7368DA0", Offset = "0x73677A0", VA = "0x187368DA0")]
		public bool HODBNJMKJEN(CJGBFBHKACP BOPGOELGDIE, [Out] ResultConfig JNHFGLCOILM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x7368C60", Offset = "0x7367660", VA = "0x187368C60")]
		public ResultConfig AJBMDADMKBK(CJGBFBHKACP ONIANAELCBB, [Optional] HashSet<CJGBFBHKACP> GBCBDDDJDDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x7369340", Offset = "0x7367D40", VA = "0x187369340", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x7368E10", Offset = "0x7367810", VA = "0x187368E10", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x9A74A0", Offset = "0x9A5EA0", VA = "0x1809A74A0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class EEIJIHMMIDO : OAKJPCECMGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct HDMMMLIOCIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public EEIJIHMMIDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public APPPBJLIGLH<string>.LANPOEPHMID timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x736AC90", Offset = "0x7369690", VA = "0x18736AC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x736AE20", Offset = "0x7369820", VA = "0x18736AE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct FIDKJMGMAFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public APPPBJLIGLH<string>.LANPOEPHMID timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public OAKJPCECMGP preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private APPPBJLIGLH<string>.LANPOEPHMID <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x7369AD0", Offset = "0x73684D0", VA = "0x187369AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x7369FE0", Offset = "0x73689E0", VA = "0x187369FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private readonly DOODEFFMAJG KBDDHEKPBLO;

	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public string CDGBEGGNJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x73555A0", Offset = "0x7353FA0", VA = "0x1873555A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x73555D0", Offset = "0x7353FD0", VA = "0x1873555D0")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	internal static void NKGNNKIFAJN(JEFLJDHAGDI FMBOKBBFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EEIJIHMMIDO([OLJNBPOCBCJ(null)] DOODEFFMAJG KBDDHEKPBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x7355490", Offset = "0x7353E90", VA = "0x187355490", Slot = "5")]
	[AsyncStateMachine(typeof(HDMMMLIOCIM))]
	public Task CKOMBPKHALD(APPPBJLIGLH<string>.LANPOEPHMID FLLPMEOKLAM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x7355370", Offset = "0x7353D70", VA = "0x187355370")]
	[AsyncStateMachine(typeof(FIDKJMGMAFP))]
	private Task CKDAJDGIHLJ(OAKJPCECMGP CKBOBBJECCK, APPPBJLIGLH<string>.LANPOEPHMID FLLPMEOKLAM, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public interface DOODEFFMAJG : OAKJPCECMGP
{
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public interface OAKJPCECMGP
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string CDGBEGGNJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CKOMBPKHALD(APPPBJLIGLH<string>.LANPOEPHMID FLLPMEOKLAM, CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public static class GDNDHALCMEN
{
	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x736A880", Offset = "0x7369280", VA = "0x18736A880")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	internal static void MNJJOBMFJLK(JEFLJDHAGDI FMBOKBBFBFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public interface LOPIKBFKNII : IEquatable<LOPIKBFKNII>
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	DateTime NAHCKNNEGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFPGCKMEJCJ();

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OACHFELEHFF(long FNKMOIJJLLC, long PIGKPDHCACB, [Out] MEHJOEPPCEK NOGJGLJBMOE);
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class OOKGKKKLDGD : JAKPAJHKCIF
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class DJIMIPCCIAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public CLGBBEAHBHE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public DJIMIPCCIAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x7369A60", Offset = "0x7368460", VA = "0x187369A60")]
		internal object HICDDEOJPAK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	private readonly KBMCIMOANPA PMDGMGMEAGK;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<LOPIKBFKNII> FBCIMONKFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x736D1B0", Offset = "0x736BBB0", VA = "0x18736D1B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x736DB50", Offset = "0x736C550", VA = "0x18736DB50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	[UnityEngine.Scripting.Preserve]
	public OOKGKKKLDGD([OLJNBPOCBCJ(null)] KBMCIMOANPA PMDGMGMEAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x736D740", Offset = "0x736C140", VA = "0x18736D740", Slot = "6")]
	public bool GDNNDPGIFAM(long FNKMOIJJLLC, long PIGKPDHCACB, MEHJOEPPCEK NOGJGLJBMOE, CLGBBEAHBHE NFFFIACDANN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD7C0", Offset = "0x1FCC1C0", VA = "0x181FCD7C0")]
	private void HICFPPMGOEO(LOPIKBFKNII HENLKHJGNOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x736DC00", Offset = "0x736C600", VA = "0x18736DC00", Slot = "7")]
	public bool KHALIBNEFPC(long FNKMOIJJLLC, long PIGKPDHCACB, [Out] LOPIKBFKNII IJOJEOLCKLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x736D690", Offset = "0x736C090", VA = "0x18736D690", Slot = "8")]
	public bool ENPHBHKLMBE(long FNKMOIJJLLC, long PIGKPDHCACB, CLGBBEAHBHE NFFFIACDANN, [Out] LOPIKBFKNII IJOJEOLCKLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x736D260", Offset = "0x736BC60", VA = "0x18736D260")]
	private void DCIGNLFFIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x736DA20", Offset = "0x736C420", VA = "0x18736DA20", Slot = "9")]
	public void IFMJOGEMJHD(long FNKMOIJJLLC, long PIGKPDHCACB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal abstract class MCJPGDIFFBI : KBMCIMOANPA
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	protected enum DBGGKIIMBHN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class IMJABMMPJBI : IEnumerable<LOPIKBFKNII>, IEnumerable, IEnumerator<LOPIKBFKNII>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private LOPIKBFKNII <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public MCJPGDIFFBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private CLGBBEAHBHE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public CLGBBEAHBHE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private LOPIKBFKNII System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x993D30", Offset = "0x992730", VA = "0x180993D30")]
		[DebuggerHidden]
		public IMJABMMPJBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x736B4F0", Offset = "0x7369EF0", VA = "0x18736B4F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x736B7D0", Offset = "0x736A1D0", VA = "0x18736B7D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x736B720", Offset = "0x736A120", VA = "0x18736B720", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LOPIKBFKNII> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x736B720", Offset = "0x736A120", VA = "0x18736B720", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class PAPPCGOKKCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public CLGBBEAHBHE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public PAPPCGOKKCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x736DD70", Offset = "0x736C770", VA = "0x18736DD70")]
		internal object NFCBDDLKPLD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class CGIKCAPDMKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public MCJPGDIFFBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public CGIKCAPDMKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x73696C0", Offset = "0x73680C0", VA = "0x1873696C0")]
		internal void LCHDJIMJMPP(FNHFJMCGFEP.NJCDDMAOKPG ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private readonly object PNODGJDABHJ;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	protected string DBBCDALEDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x736C210", Offset = "0x736AC10", VA = "0x18736C210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public abstract NKADIPJPKNA MIIIAGBHBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x736C220", Offset = "0x736AC20", VA = "0x18736C220")]
	protected MCJPGDIFFBI([CanBeNull] string NPAFAMDOJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x736B8B0", Offset = "0x736A2B0", VA = "0x18736B8B0", Slot = "5")]
	public bool FHGPCPHDFCG(long FNKMOIJJLLC, long PIGKPDHCACB, CLGBBEAHBHE NFFFIACDANN, [Out] LOPIKBFKNII HENLKHJGNOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x736B820", Offset = "0x736A220", VA = "0x18736B820", Slot = "6")]
	[IteratorStateMachine(typeof(IMJABMMPJBI))]
	public IEnumerable<LOPIKBFKNII> ADOHPHDAAPB(CLGBBEAHBHE NFFFIACDANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void AOLJAMEALMA(Stream HHACHEBJBFB, long FNKMOIJJLLC, long PIGKPDHCACB, MEHJOEPPCEK NOGJGLJBMOE);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool IPDHIIJFKNJ(Stream LJCEFGAJBCE, long FNKMOIJJLLC, long PIGKPDHCACB, PNOPGJGMENA OJLHOOHJKGK, [Out] MEHJOEPPCEK NOGJGLJBMOE);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x736BAA0", Offset = "0x736A4A0", VA = "0x18736BAA0", Slot = "7")]
	public LOPIKBFKNII LACOGCBCIMP(long FNKMOIJJLLC, long PIGKPDHCACB, MEHJOEPPCEK NOGJGLJBMOE, CLGBBEAHBHE NFFFIACDANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo OLMINOOFJFP(long FNKMOIJJLLC, long PIGKPDHCACB, CLGBBEAHBHE NFFFIACDANN, DBGGKIIMBHN PKCFHCPGLHK);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo MGCBNHHPFHE(CLGBBEAHBHE NFFFIACDANN, DBGGKIIMBHN PKCFHCPGLHK);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x736C1A0", Offset = "0x736ABA0", VA = "0x18736C1A0")]
	protected void OFHPGAPJPGJ(FNHFJMCGFEP.NJCDDMAOKPG GHBDKJJGEEC, string GGCMALNCNCP, FileInfo MCDDGDAAAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x736BE10", Offset = "0x736A810", VA = "0x18736BE10")]
	internal bool NAOMPGEKIAA(FileInfo ONKAAPAKNAA, long FNKMOIJJLLC, long PIGKPDHCACB, [Out] MEHJOEPPCEK NOGJGLJBMOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	private void GHOALOJIKEP(Exception LAHIFJKDMEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class PKEPMMFEFCI : MCJPGDIFFBI
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public override NKADIPJPKNA MIIIAGBHBDD
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x15D3630", Offset = "0x15D2030", VA = "0x1815D3630", Slot = "8")]
		get
		{
			return default(NKADIPJPKNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x736E900", Offset = "0x736D300", VA = "0x18736E900")]
	public PKEPMMFEFCI([Optional] string NPAFAMDOJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x736DE10", Offset = "0x736C810", VA = "0x18736DE10")]
	private void AGEANIIEPMM(CLGBBEAHBHE NFFFIACDANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x736DE90", Offset = "0x736C890", VA = "0x18736DE90", Slot = "9")]
	internal override void AOLJAMEALMA(Stream HHACHEBJBFB, long FNKMOIJJLLC, long PIGKPDHCACB, MEHJOEPPCEK NOGJGLJBMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x736E120", Offset = "0x736CB20", VA = "0x18736E120", Slot = "10")]
	internal override bool IPDHIIJFKNJ(Stream LJCEFGAJBCE, long FNKMOIJJLLC, long PIGKPDHCACB, PNOPGJGMENA OJLHOOHJKGK, [Out] MEHJOEPPCEK NOGJGLJBMOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x736E810", Offset = "0x736D210", VA = "0x18736E810", Slot = "11")]
	protected override FileInfo OLMINOOFJFP(long FNKMOIJJLLC, long PIGKPDHCACB, CLGBBEAHBHE NFFFIACDANN, DBGGKIIMBHN PKCFHCPGLHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x736E710", Offset = "0x736D110", VA = "0x18736E710", Slot = "12")]
	protected override DirectoryInfo MGCBNHHPFHE(CLGBBEAHBHE NFFFIACDANN, DBGGKIIMBHN PKCFHCPGLHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class MLIDBIOAMAH : MCJPGDIFFBI
{
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private static readonly byte[] LFOBGDLOPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private readonly byte[] BKMPOIHAIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private readonly byte[] FLGKNENICKN;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public override NKADIPJPKNA MIIIAGBHBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x60FE990", Offset = "0x60FD390", VA = "0x1860FE990", Slot = "8")]
		get
		{
			return default(NKADIPJPKNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x736D0C0", Offset = "0x736BAC0", VA = "0x18736D0C0")]
	public MLIDBIOAMAH([Optional] string NPAFAMDOJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x736C2A0", Offset = "0x736ACA0", VA = "0x18736C2A0", Slot = "9")]
	internal override void AOLJAMEALMA(Stream HHACHEBJBFB, long FNKMOIJJLLC, long PIGKPDHCACB, MEHJOEPPCEK NOGJGLJBMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x736C610", Offset = "0x736B010", VA = "0x18736C610", Slot = "10")]
	internal override bool IPDHIIJFKNJ(Stream LJCEFGAJBCE, long FNKMOIJJLLC, long PIGKPDHCACB, PNOPGJGMENA OJLHOOHJKGK, [Out] MEHJOEPPCEK NOGJGLJBMOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x736C550", Offset = "0x736AF50", VA = "0x18736C550")]
	private void GLFOKCDBFKM(byte[] CNGBPDKMHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x736CF00", Offset = "0x736B900", VA = "0x18736CF00", Slot = "11")]
	protected override FileInfo OLMINOOFJFP(long FNKMOIJJLLC, long PIGKPDHCACB, CLGBBEAHBHE NFFFIACDANN, DBGGKIIMBHN PKCFHCPGLHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x736CDF0", Offset = "0x736B7F0", VA = "0x18736CDF0", Slot = "12")]
	protected override DirectoryInfo MGCBNHHPFHE(CLGBBEAHBHE NFFFIACDANN, DBGGKIIMBHN PKCFHCPGLHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public enum NKADIPJPKNA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal class FMDEHGAJKLN : KBMCIMOANPA
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class PPEBKOFOMLC : IEnumerable<LOPIKBFKNII>, IEnumerable, IEnumerator<LOPIKBFKNII>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private LOPIKBFKNII <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public FMDEHGAJKLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private CLGBBEAHBHE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public CLGBBEAHBHE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private NKADIPJPKNA[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private IEnumerator<LOPIKBFKNII> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private LOPIKBFKNII System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x993D30", Offset = "0x992730", VA = "0x180993D30")]
		[DebuggerHidden]
		public PPEBKOFOMLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x736ED70", Offset = "0x736D770", VA = "0x18736ED70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x736E990", Offset = "0x736D390", VA = "0x18736E990", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x736E940", Offset = "0x736D340", VA = "0x18736E940")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x736ED20", Offset = "0x736D720", VA = "0x18736ED20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x736EC70", Offset = "0x736D670", VA = "0x18736EC70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LOPIKBFKNII> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x736EC70", Offset = "0x736D670", VA = "0x18736EC70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private readonly NKADIPJPKNA[] CMDDGHPDPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private readonly Dictionary<NKADIPJPKNA, KBMCIMOANPA> MOGDCAIGKGE;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public NKADIPJPKNA MIIIAGBHBDD
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x736A0D0", Offset = "0x7368AD0", VA = "0x18736A0D0", Slot = "4")]
		get
		{
			return default(NKADIPJPKNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x736A550", Offset = "0x7368F50", VA = "0x18736A550")]
	[UnityEngine.Scripting.Preserve]
	public FMDEHGAJKLN(params KBMCIMOANPA[] HKFAJJIPKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x736A100", Offset = "0x7368B00", VA = "0x18736A100", Slot = "5")]
	public bool FHGPCPHDFCG(long FNKMOIJJLLC, long PIGKPDHCACB, CLGBBEAHBHE NFFFIACDANN, [Out] LOPIKBFKNII HENLKHJGNOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x736A330", Offset = "0x7368D30", VA = "0x18736A330")]
	private void NGLMNOBGGCB(int DCIDGJGNGMP, long FNKMOIJJLLC, long PIGKPDHCACB, CLGBBEAHBHE NFFFIACDANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x736A040", Offset = "0x7368A40", VA = "0x18736A040", Slot = "6")]
	[IteratorStateMachine(typeof(PPEBKOFOMLC))]
	public IEnumerable<LOPIKBFKNII> ADOHPHDAAPB(CLGBBEAHBHE NFFFIACDANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x736A250", Offset = "0x7368C50", VA = "0x18736A250", Slot = "7")]
	public LOPIKBFKNII LACOGCBCIMP(long FNKMOIJJLLC, long PIGKPDHCACB, MEHJOEPPCEK NOGJGLJBMOE, CLGBBEAHBHE NFFFIACDANN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class CJNLNNFELNM
{
	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x7369740", Offset = "0x7368140", VA = "0x187369740")]
	internal static byte[] CKMEDPMIEFP(byte[] CNGBPDKMHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x7369800", Offset = "0x7368200", VA = "0x187369800")]
	public static void GDOKFHNAPGM(Stream CHPPOENEDKJ, byte[] CMFNJFFCGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x7369880", Offset = "0x7368280", VA = "0x187369880")]
	public static bool HCJFLIEDBKM(Stream CHPPOENEDKJ, long DCDBIBBGGLN, PNOPGJGMENA AKNMJLPDJFH, [Out] byte[] CDLLGOLMIFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
internal sealed class HLMMGFHGAMG : LOPIKBFKNII, IEquatable<LOPIKBFKNII>, IEquatable<HLMMGFHGAMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private readonly MCJPGDIFFBI GANCBDBMBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	public readonly FileInfo NLIGDHMDKLD;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public NKADIPJPKNA MIIIAGBHBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x6D14810", Offset = "0x6D13210", VA = "0x186D14810", Slot = "9")]
		get
		{
			return default(NKADIPJPKNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DateTime NAHCKNNEGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x736AF40", Offset = "0x7369940", VA = "0x18736AF40", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x736B3E0", Offset = "0x7369DE0", VA = "0x18736B3E0")]
	public HLMMGFHGAMG(MCJPGDIFFBI BJKJNBLBKLK, FileInfo ONKAAPAKNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x736B330", Offset = "0x7369D30", VA = "0x18736B330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x736AE80", Offset = "0x7369880", VA = "0x18736AE80", Slot = "5")]
	public void AFPGCKMEJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x736B2F0", Offset = "0x7369CF0", VA = "0x18736B2F0", Slot = "6")]
	public bool OACHFELEHFF(long FNKMOIJJLLC, long PIGKPDHCACB, [Out] MEHJOEPPCEK NOGJGLJBMOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x736B090", Offset = "0x7369A90", VA = "0x18736B090", Slot = "7")]
	public bool Equals(LOPIKBFKNII PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x736AFD0", Offset = "0x73699D0", VA = "0x18736AFD0", Slot = "8")]
	public bool Equals(HLMMGFHGAMG PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x736B170", Offset = "0x7369B70", VA = "0x18736B170", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x736B260", Offset = "0x7369C60", VA = "0x18736B260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public delegate void PNOPGJGMENA(FNHFJMCGFEP.NJCDDMAOKPG EAMNJMDLIJH, string KFAOBDLOMDC);
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface KBMCIMOANPA
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	NKADIPJPKNA MIIIAGBHBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FHGPCPHDFCG(long FNKMOIJJLLC, long PIGKPDHCACB, CLGBBEAHBHE NFFFIACDANN, [Out] LOPIKBFKNII HENLKHJGNOF);

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<LOPIKBFKNII> ADOHPHDAAPB(CLGBBEAHBHE NFFFIACDANN);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LOPIKBFKNII LACOGCBCIMP(long FNKMOIJJLLC, long PIGKPDHCACB, MEHJOEPPCEK NOGJGLJBMOE, CLGBBEAHBHE NFFFIACDANN);
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
