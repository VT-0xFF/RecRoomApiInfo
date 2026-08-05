using System;
using System.Buffers;
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
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DC00", Offset = "0x7D8D000", VA = "0x187D8DC00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
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
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D87880", Offset = "0x7D86C80", VA = "0x187D87880", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7D92050", Offset = "0x7D91450", VA = "0x187D92050", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JKCBPPHFEDJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C590", Offset = "0x7D7B990", VA = "0x187D7C590")]
	public JKCBPPHFEDJ(string LPIFIOEEOGF, Exception JALIEJNBJJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class JANABLHIPPN : NCLDLJLINLK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MBAHPBLNIGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<INMAGKMJCGB>> <>t__builder;

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
		private TaskAwaiter<HNKKHFKGEFM<CBLOAIMJMAA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D87BB0", Offset = "0x7D86FB0", VA = "0x187D87BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7D87DF0", Offset = "0x7D871F0", VA = "0x187D87DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct FDFGOOBEMOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<OKKEKHCOOAL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<OKKEKHCOOAL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D77360", Offset = "0x7D76760", VA = "0x187D77360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D77570", Offset = "0x7D76970", VA = "0x187D77570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	[UnityEngine.Scripting.Preserve]
	public JANABLHIPPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B9A0", Offset = "0x7D7ADA0", VA = "0x187D7B9A0", Slot = "4")]
	[AsyncStateMachine(typeof(MBAHPBLNIGK))]
	public Task<IReadOnlyList<INMAGKMJCGB>> DPAHNNCHHEM(long LFNEDMLHPHM, long BEGDDCHOHOL, [Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D7BAC0", Offset = "0x7D7AEC0", VA = "0x187D7BAC0", Slot = "5")]
	[AsyncStateMachine(typeof(FDFGOOBEMOI))]
	public Task<IReadOnlyList<OKKEKHCOOAL>> IBMIBMNMGLL(IReadOnlyList<int> DIKNKJCMNHA, [Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CDOMKFPJCFG : IEquatable<CDOMKFPJCFG>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int IFAMMKGBHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	OKKEKHCOOAL DMGPFPNDNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime FEFCEJIAJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	OHFFJIFMDLM? GMHILABHAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DAFMOCGPDPE? OPBCIIFDLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	HBLGNAHDKPE IPEDPIJEKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MLDDIEDIFAF> EAKJMKIOFLG();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum HBLGNAHDKPE
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NCLDLJLINLK
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<INMAGKMJCGB>> DPAHNNCHHEM(long LFNEDMLHPHM, long BEGDDCHOHOL, [Optional] CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<OKKEKHCOOAL>> IBMIBMNMGLL(IReadOnlyList<int> DIKNKJCMNHA, [Optional] CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NAGBCJBKKMD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class LEKDKNFOOGF : CDOMKFPJCFG, IEquatable<CDOMKFPJCFG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct BIMAPPDAAAI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<MLDDIEDIFAF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public LEKDKNFOOGF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private JHABIGLANJE <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<FGPODGGHBLK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<MLDDIEDIFAF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7D72650", Offset = "0x7D71A50", VA = "0x187D72650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7D72B10", Offset = "0x7D71F10", VA = "0x187D72B10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly INMAGKMJCGB PPAFDGGNLJP;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int IFAMMKGBHEO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9712B0", Offset = "0x9706B0", VA = "0x1809712B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OKKEKHCOOAL DMGPFPNDNEK
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime ALIDPAKIBOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7D83650", Offset = "0x7D82A50", VA = "0x187D83650", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OHFFJIFMDLM? GMHILABHAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x67079E0", Offset = "0x6706DE0", VA = "0x1867079E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public DAFMOCGPDPE? OPBCIIFDLJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x27E6D10", Offset = "0x27E6110", VA = "0x1827E6D10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public HBLGNAHDKPE IPEDPIJEKBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xACC550", Offset = "0xACB950", VA = "0x180ACC550", Slot = "10")]
			get
			{
				return default(HBLGNAHDKPE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7D83670", Offset = "0x7D82A70", VA = "0x187D83670", Slot = "9")]
		[AsyncStateMachine(typeof(BIMAPPDAAAI))]
		public Task<MLDDIEDIFAF> EAKJMKIOFLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7D83960", Offset = "0x7D82D60", VA = "0x187D83960")]
		public LEKDKNFOOGF(int PEKJMHNCNGF, OKKEKHCOOAL MMCAJCHCAHP, INMAGKMJCGB PPAFDGGNLJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7D83770", Offset = "0x7D82B70", VA = "0x187D83770", Slot = "11")]
		public bool Equals(CDOMKFPJCFG MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7D83800", Offset = "0x7D82C00", VA = "0x187D83800", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7D83920", Offset = "0x7D82D20", VA = "0x187D83920")]
		private bool KHCDKGLPHFO(LEKDKNFOOGF MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D838A0", Offset = "0x7D82CA0", VA = "0x187D838A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class DDLHDPKPGPM : CDOMKFPJCFG, IEquatable<CDOMKFPJCFG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct LIBGNHOJDLJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<MLDDIEDIFAF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public DDLHDPKPGPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<MLDDIEDIFAF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7D83CB0", Offset = "0x7D830B0", VA = "0x187D83CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7D83F00", Offset = "0x7D83300", VA = "0x187D83F00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly HLGDIBFKEKE JPGOAFGOFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly OHFFJIFMDLM LJELFAMFAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly DAFMOCGPDPE FOEPGCPDCLO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int IFAMMKGBHEO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7D753E0", Offset = "0x7D747E0", VA = "0x187D753E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public OKKEKHCOOAL DMGPFPNDNEK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7D74F40", Offset = "0x7D74340", VA = "0x187D74F40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime ALIDPAKIBOD
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7D75020", Offset = "0x7D74420", VA = "0x187D75020", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OHFFJIFMDLM? GMHILABHAFH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7D74FD0", Offset = "0x7D743D0", VA = "0x187D74FD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DAFMOCGPDPE? OPBCIIFDLJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7D752B0", Offset = "0x7D746B0", VA = "0x187D752B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public HBLGNAHDKPE IPEDPIJEKBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xACB320", Offset = "0xACA720", VA = "0x180ACB320", Slot = "10")]
			get
			{
				return default(HBLGNAHDKPE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1C8DA00", Offset = "0x1C8CE00", VA = "0x181C8DA00")]
		public DDLHDPKPGPM(HLGDIBFKEKE CKIFDKJKIAC, OHFFJIFMDLM EENIOGGMBHA, DAFMOCGPDPE FLFIEFACBGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7D75070", Offset = "0x7D74470", VA = "0x187D75070", Slot = "9")]
		[AsyncStateMachine(typeof(LIBGNHOJDLJ))]
		public Task<MLDDIEDIFAF> EAKJMKIOFLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7D75160", Offset = "0x7D74560", VA = "0x187D75160", Slot = "11")]
		public bool Equals(CDOMKFPJCFG MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7D75200", Offset = "0x7D74600", VA = "0x187D75200", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7D75380", Offset = "0x7D74780", VA = "0x187D75380")]
		private bool KHCDKGLPHFO(DDLHDPKPGPM MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7D75300", Offset = "0x7D74700", VA = "0x187D75300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class EANEFGMCLFA : CDOMKFPJCFG, IEquatable<CDOMKFPJCFG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct HMBGKHKAIJK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<MLDDIEDIFAF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<MLDDIEDIFAF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7D79520", Offset = "0x7D78920", VA = "0x187D79520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7D79780", Offset = "0x7D78B80", VA = "0x187D79780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly OKKEKHCOOAL AIKBHINMFKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly OHFFJIFMDLM LJELFAMFAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly DAFMOCGPDPE FOEPGCPDCLO;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int IFAMMKGBHEO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7D757F0", Offset = "0x7D74BF0", VA = "0x187D757F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public OKKEKHCOOAL DMGPFPNDNEK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime ALIDPAKIBOD
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public OHFFJIFMDLM? GMHILABHAFH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7D75420", Offset = "0x7D74820", VA = "0x187D75420", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DAFMOCGPDPE? OPBCIIFDLJK
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7D75630", Offset = "0x7D74A30", VA = "0x187D75630", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public HBLGNAHDKPE IPEDPIJEKBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "10")]
			get
			{
				return default(HBLGNAHDKPE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1C8DA00", Offset = "0x1C8CE00", VA = "0x181C8DA00")]
		public EANEFGMCLFA(OKKEKHCOOAL MMCAJCHCAHP, OHFFJIFMDLM EENIOGGMBHA, DAFMOCGPDPE FLFIEFACBGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7D75470", Offset = "0x7D74870", VA = "0x187D75470", Slot = "9")]
		[AsyncStateMachine(typeof(HMBGKHKAIJK))]
		public Task<MLDDIEDIFAF> EAKJMKIOFLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7D75540", Offset = "0x7D74940", VA = "0x187D75540", Slot = "11")]
		public bool Equals(CDOMKFPJCFG MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7D755B0", Offset = "0x7D749B0", VA = "0x187D755B0", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7D75680", Offset = "0x7D74A80", VA = "0x187D75680", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7D75710", Offset = "0x7D74B10", VA = "0x187D75710")]
		private bool KHCDKGLPHFO(EANEFGMCLFA MNALNBMKJLK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct ONHECECJFOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<CDOMKFPJCFG>> <>t__builder;

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
		public NAGBCJBKKMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<INMAGKMJCGB> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<INMAGKMJCGB>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, OKKEKHCOOAL account, INMAGKMJCGB roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7D8EB70", Offset = "0x7D8DF70", VA = "0x187D8EB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F9A0", Offset = "0x7D8EDA0", VA = "0x187D8F9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct MCDFDBOGGBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, OKKEKHCOOAL account, INMAGKMJCGB roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<INMAGKMJCGB> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NAGBCJBKKMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<OKKEKHCOOAL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7D87E60", Offset = "0x7D87260", VA = "0x187D87E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7D88830", Offset = "0x7D87C30", VA = "0x187D88830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NJDPGIJGNMJ PEEADLAPFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly NCLDLJLINLK OCFFGMCMKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JKOCOFLNOBD HAHBIJALOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly EFINIOEALEL<(long, long), IReadOnlyList<INMAGKMJCGB>> JGNMADBGAIL;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D8B640", Offset = "0x7D8AA40", VA = "0x187D8B640")]
	[UnityEngine.Scripting.Preserve]
	public NAGBCJBKKMD([PNFCCJKFMBH(null)] NCLDLJLINLK CPHGNJCBADO, [PNFCCJKFMBH(null)] JKOCOFLNOBD DOFMBNEAAMM, [PNFCCJKFMBH(null)] NJDPGIJGNMJ KEHLJENHJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D8B3E0", Offset = "0x7D8A7E0", VA = "0x187D8B3E0")]
	[AsyncStateMachine(typeof(ONHECECJFOL))]
	public Task<IList<CDOMKFPJCFG>> KMGPIFHEFAH(long LFNEDMLHPHM, long FHAJBLMHDGD, bool FAJCBPCGCCM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D8B240", Offset = "0x7D8A640", VA = "0x187D8B240")]
	private bool DOHCINCGMGG(DateTime? MBMJPDGJNNI, long LFNEDMLHPHM, long FHAJBLMHDGD, [Out] HLGDIBFKEKE AADNONONIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D8B530", Offset = "0x7D8A930", VA = "0x187D8B530")]
	[AsyncStateMachine(typeof(MCDFDBOGGBL))]
	private Task<IReadOnlyList<(int, OKKEKHCOOAL, INMAGKMJCGB)>> KMINDMJANMH(IReadOnlyList<INMAGKMJCGB> NCIJCGOCPFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JKOCOFLNOBD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HLGDIBFKEKE> DFDAMIINFJO;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OGLELCKLNPJ(long LFNEDMLHPHM, long FHAJBLMHDGD, JHKLIMEFACP LAFAIALAGHO, DNGFPOMMDGK FHBKFDOMCJO);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ANCGCFEJJCM(long LFNEDMLHPHM, long FHAJBLMHDGD, [Out] HLGDIBFKEKE AADNONONIOJ);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IHLLFBFKGHJ(long LFNEDMLHPHM, long FHAJBLMHDGD, DNGFPOMMDGK FHBKFDOMCJO, [Out] HLGDIBFKEKE AADNONONIOJ);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BMENPCFKLCN(long LFNEDMLHPHM, long FHAJBLMHDGD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface MJPICOFJBDP : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MJFDANKGNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task CMPPGNHHNFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCDBGOJJNFP(Task GELALODAJCE, string FBDJLGDJLME);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface OLNLMBALJMH : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MLDDIEDIFAF> JOHBALMOGEH(HLGDIBFKEKE AADNONONIOJ);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OGNDCMNMNCA(CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface JENEEEIDFIJ : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	IGKLHNCIHKG BNBJKCHDDID
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENIPAOLFHNA();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADOIKGCGDIF();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface ILPCOFODDNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface HGBLLPJJCBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan OJCPCNLGAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan JAAOCEJHGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan GJIJKHHEPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan EDCMGKEFAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool JPMLHBKNEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool KAFFLCAOKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool NFPLNIPLKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int GDBCDEBHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool GLBKJCAIENN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool GNLBLIKPDDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum HAKJFCAIJCA
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum PKPHAIIFFIO
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
public struct AFOKKDBKELL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long NBFFAAFDIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long BEGDDCHOHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly HAKJFCAIJCA ANONBNLNHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception KDDOOLKAPAE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7D71FB0", Offset = "0x7D713B0", VA = "0x187D71FB0")]
	public AFOKKDBKELL(long NBFFAAFDIFN, long BEGDDCHOHOL, HAKJFCAIJCA ANONBNLNHHL, [CanBeNull] Exception KDDOOLKAPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D71F60", Offset = "0x7D71360", VA = "0x187D71F60")]
	public static AFOKKDBKELL BONEJHCIKAG(DNHLENAINEA OEEBHKEGCOF, HAKJFCAIJCA ANONBNLNHHL, [Optional] Exception KDDOOLKAPAE)
	{
		return default(AFOKKDBKELL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void FJGNFAJHCOO(AFOKKDBKELL JMAPFIDMONE);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface AGHNLFGEBKJ : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MLKIOMBIOHB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FJGNFAJHCOO LCOFDDPMJCF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FJGNFAJHCOO FNCDDFEBDJA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FJGNFAJHCOO GHFINDHNALF;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BMCAJEBBKIL();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DFJIPGDJBFK(AFOKKDBKELL JMAPFIDMONE);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OOAKANIBHLP(AFOKKDBKELL JMAPFIDMONE);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CJECIJJJCOK(AFOKKDBKELL JMAPFIDMONE);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KBGFIEHELGB(PKPHAIIFFIO PCPPMGPAHKO, bool LAKNLJKLEMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface EBPALNPDLNI : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum Reason
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		TestCase,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		ServerDisconnect_ClientTimeout,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		ServerDisconnect_ServerTimeout,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		ServerDisconnect_ByServer,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		ServerDisconnect_ByClient,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		ServerDisconnect_Other,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		PresenceUpdate_SentToInvalidInstance,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		UnhandledExceptionDuringInitialRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		UnhandledExceptionDuringNonInitialLoad,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FallbackFailure_UnhandledException,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		FallbackFailure_NoInternetConnection,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		FallbackFailure_Timeout,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		FallbackFailure_Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		FallbackFailure_EndedInInvalidInstance,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		FallbackFailure_EndedInIncorrectInstance,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		FallbackFailure_EndedInIncorrectScene,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		FallbackFailure_AlreadyInTargetInstance,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		FallbackFailure_MatchmakingError
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool APDINCPAOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DODBBHNKCAK(Reason BBAJBLJIPLG = Reason.Unknown);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDMACGAFALA();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface MDGIPPAFIND : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	TaskStatus KLMMKDPNGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HAEAOMPECPB(DNHLENAINEA LEBOBKLCHDG, KMNIIEFGPKB MMFPLOFHMAF, CancellationToken IMBEMDEIDGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class EKLBBOLIBAK
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7D76300", Offset = "0x7D75700", VA = "0x187D76300")]
	public static bool MHJEKLEONHM(this MDGIPPAFIND IFOOBBNHHGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task ILOKGPLFKED(CancellationToken OCDOGNMJENC, int CBJKLCMKNMO, DFFCINOLDEH BFPFCMDBGML);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface JAMCMMKGBKP : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IHKGFEHMIBL(ILOKGPLFKED NHBOECKMNMC);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface KBABJPFHBFP : JHABIGLANJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CancellationToken OGMEOHIJOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	LEPFMCICNAK CNNOMCHMBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	HHMOMAGJIPE OKEMJCALLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	IFIEBAFBCGE KKJFDKDBPIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	LAGOIFMOJDA JIOKCOHMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	CIFIMMMOPKA FILPJIKNEAE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	KDJOLJCAGCD AIKIDBCJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	BEEMHPLPFOO IPFCGNLLMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	OGIKFOGELKN PGKEKMCLHCC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	MJPICOFJBDP CNPGGJBPCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	OLNLMBALJMH ODMFIIBNDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	AGHNLFGEBKJ BKAIBIIKLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	EBPALNPDLNI MLONJKDPKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MDGIPPAFIND GFHCOENPFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	JAMCMMKGBKP PGAOGBPCJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CAPOKDEDNLL MLFCNFLLEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	DBJBBMPJJDE NFIDIDBFODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	JFNFGLFDAJH EOBPEDHJBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	KJAHCINMHID LOPBBLEMCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GMNIJCAFBOL EJDBBEOGFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CHDBFKKIGJL LBCPJHGLDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	GGCFIFHGAEB CBHCDGGADCA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	GCHCIBOABFC BNBKIOGAIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	PKFMOFMAIHK NBGGABPCLLK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	AMAGBMICKBJ PLEHGBGGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	JENEEEIDFIJ OPIBLAHHBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	HGBLLPJJCBJ KFJKKEKKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	HCHBLHNLCND NEOIIJFPNDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	JKOCOFLNOBD HAHGBGJPLMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	MOEMPDODMEG ICNENBHNGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	KGMCELACHEF KLBMMOPFDIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	ECLAECFMLGO FJFELEKBKEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	DEBJFNCKLHK CHLBBOMAEKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	new bool HPNLIODLBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void IMCNCJJBIBA(KMNIIEFGPKB CBFEMPBKHFB);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface CAPOKDEDNLL : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GBPMNAIFOAH KAAHFJDOOLK(Guid PPLJPJJDEGE);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PBIACPFCCPC(Guid PPLJPJJDEGE);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BHKPJJAJBKB(Guid PPLJPJJDEGE, Task EKBLHMHCAJM);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JKAMFIGJODH(Guid PPLJPJJDEGE, MLDDIEDIFAF EKCIJHBBBEJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(MLDDIEDIFAF, Task)> LPPKDBBOHIM(Guid PPLJPJJDEGE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface HFDDGLJDMII : ILPCOFODDNC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface DBJBBMPJJDE : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKCAKFALIIP(MGPKNNLHNMP LPIFIOEEOGF);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNDIHKIHECA(MGPKNNLHNMP LPIFIOEEOGF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<AAALDGKDLBO> OBPOEHGNFDP(CancellationToken OKIPOOADPEO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface JFNFGLFDAJH : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GBPMNAIFOAH PBKFHADNOCN(MGPKNNLHNMP JOOGKIIDCPN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECMCFECPBKI(Guid PPLJPJJDEGE, Task EKBLHMHCAJM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface KJAHCINMHID : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MLDDIEDIFAF> LOPBBLEMCPL(MGPKNNLHNMP DMNJLKMHCNI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GMNIJCAFBOL : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LDGKNLKOAHN> PNBPLGOJBDB(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, DNHLENAINEA LEBOBKLCHDG, CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface GGCFIFHGAEB : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLDDIEDIFAF LAOBKBLLOLN(NOFCMGEHFOO FDNLBHLEFDI);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FOENOIFLNFM(string CBAOKODFJCF);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface CHDBFKKIGJL : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MGPKNNLHNMP> KALKGLDCNDH(MGPKNNLHNMP NKKKCKHLGCJ, MMCELPKDDOJ ELPNJEJBOMD, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MGPKNNLHNMP> IGCAPIFFFEK(CancellationToken MLAPMBKLAOF, MMCELPKDDOJ ELPNJEJBOMD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OJEJNDLACBE HDDCCHPLKDL(GIELBPOLHAF NMJONAJJMMC, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OJEJNDLACBE FPKHNFDKGNI(GIELBPOLHAF NMJONAJJMMC, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface GCHCIBOABFC : ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLDDIEDIFAF EPEPKPLHNEM(NOFCMGEHFOO FDNLBHLEFDI, AAALDGKDLBO OENLPLOJPBN);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MLDDIEDIFAF NJOKGAOIBNK(NOFCMGEHFOO GECCDAMDACK);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface DAPGJHPIJKE
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	const int MDPIMIOMHBG = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IReadOnlyDictionary<Guid, OKKAJENOOLC> IJCMHFFDCPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	Action DOALJJDIJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<Guid> KCJKOPHDKPC();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task PPFCDHNABHN([Optional] CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task MNMBCKJLCOD([Optional] CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface PKFMOFMAIHK
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICHMIHDLKOL(PLPALFJAGFP FKLCBMLCDMC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NECBJPGMFKK(PLPALFJAGFP FKLCBMLCDMC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMJMLBCEEBO(PLPALFJAGFP FKLCBMLCDMC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ADJGADHNOEP(PLPALFJAGFP FKLCBMLCDMC);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class PLPALFJAGFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly DNHLENAINEA PJEJCFCKOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Dictionary<string, string> LNAACLNGOCH;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public PGLLJHOKMII<string> MPIAABAADOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x968070", Offset = "0x967470", VA = "0x180968070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public PLPALFJAGFP(DNHLENAINEA FLPHGLKPGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D908E0", Offset = "0x7D8FCE0", VA = "0x187D908E0")]
	public PLPALFJAGFP LKDEMDAFMNA(string MCNLCGLNHHO, string PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D909B0", Offset = "0x7D8FDB0", VA = "0x187D909B0")]
	public bool MLLFMMODPBE([Out] IEnumerable<KeyValuePair<string, string>> HAHIPHMDBAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6E3EC40", Offset = "0x6E3E040", VA = "0x186E3EC40")]
	public PLPALFJAGFP JPPPCOHDMLD(PGLLJHOKMII<string> LMBGFJBPMAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HCHBLHNLCND
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool KGBEHNLOGCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	string EODJOGHDHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool BEEIFJCFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ILIIPGHIMCF();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GNAMIPCKPFJ JPCGIOEOPMC(long FNPIGGMFPPH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HHKKLDJCOIN<LOFGJIDOAFO, LDEPJGKAOIB> GMMCDHOBKLH(long FNPIGGMFPPH);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HHKKLDJCOIN<LOFGJIDOAFO, OIBKBLGJIPN> CKCOBKFMDNL(long FNPIGGMFPPH);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HHKKLDJCOIN<long, PLFDEBDPAHA> NDFDJGOMICO();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<EHCMNNBMDKN>> GMHJCKBENPE(long FNPIGGMFPPH, IReadOnlyCollection<EHCMNNBMDKN> BJOFMMDBECA, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MAPCFCDLIBM(long FNPIGGMFPPH, [Out] bool OLOEGNDHLHH);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> ICICJKMDNCI(byte[] IEFIJIFMMAE, byte[] ODGDPEFBEOA, IReadOnlyCollection<Guid> IBOHDLALFHF, CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface JHABIGLANJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool MHJEKLEONHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool EPBPMINOBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool HPNLIODLBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	KMNIIEFGPKB IEBIHHHCOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action MLKIOMBIOHB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event FJGNFAJHCOO LCOFDDPMJCF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FJGNFAJHCOO FNCDDFEBDJA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FJGNFAJHCOO GHFINDHNALF;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CDMACGAFALA();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EHPADHEMLAI ELFMGMJAFJL();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EPAMDPBJAJK KHOMDBFLDFG();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task HCPEGIGLDME(int FNEMCGFJDJN, NBJKHDBIOKG BILBPLEGPGE, Func<JHKLIMEFACP, JHKLIMEFACP> FEEGBJLIOHE);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<MLDDIEDIFAF> JOHBALMOGEH(HLGDIBFKEKE CKIFDKJKIAC);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task OGNDCMNMNCA(CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface CIFIMMMOPKA
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool PHBEFPNKLAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool DKLNBNFOJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Guid? GFHBIAEHJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEBMDEMNFGL(Scene COKELAJFOFI);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task EBJCLEKLPMF(IJLAIOLGPKJ MMNHKALDAMI, IReadOnlyList<IJLAIOLGPKJ> HLALKEALPEN, IReadOnlyList<IJLAIOLGPKJ> GBJAEGHENDL, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GMDDMKKOIIL(NJBDDHLJPOI ODFBAALONEF);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task PJHJMLGAOOC(IReadOnlyList<Guid> JJMFBNMOMBD, CancellationToken EFABJDHAJGM);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GBPEBBDEAAB GLLJPJONDDF();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task FPEFAMKJPLG();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task GKFLOEBJGID();
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface LAGOIFMOJDA
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	MONKCCHOMPK GPMOAHABAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool IGPICMHCHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool CLLBMMOJDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool KNBADIEKLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool EECOCEPPNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int LDAIDNAKKOH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool IPACANPILBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool PMCDDIENAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	int MOJBGAOHNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	int LNKJLCCPAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool FJFCFNKGEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool FMOGIFANDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool BEDAAOKFKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float DOLNJMADHCL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> JMCIJKBBMDK;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LEPFMCICNAK AFGPDLPFFJB(LEPFMCICNAK IAJOALFPCDG);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBLDMNJIFGM(LEPFMCICNAK EOMAFKDOFHE);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PMPGDMBLCJI();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task GMEKHKCEKOE(PGLLJHOKMII<string>.GLACLJPMODI JDLKLKPGDCN, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LHHALLDEJJE(float INBDCPKDEKP);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DEEGLCIPNKG(string HKOIFLLCMEG);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<JBDMCPFFKFC> IJEHAGFDCND();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable EAOBDGEEMDI(object MEBLJIBNLCL, JBDMCPFFKFC BNMOKGHOHIA);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<NLAHOONCNNF> GHPEMBNBEFM();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LDEPJGKAOIB EMLJEDMPDMP(IEnumerable<FMDAPGFGAFB> BLJMJAOHHCI);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PPNGDMGCOEK(int LNEEKMIFMOP);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task ADFDLCDAHBM();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CPHJIKEDELE();

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool DLCIGAIFJOL();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task BLNJBBGOOJM(CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task IPDPOBHPMHE(CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<KJDAGLMLNJL> FBKKLDJHHAK(DateTime PHPFICLODOG, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> ONLPBJMHCLO(CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LDOMKCLANBD(string LPIFIOEEOGF = "", float NGAJLIGHCDN = 3f);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "25")]
	EFDLDPFLHGE ONMKKAEOOCE(FJKNANMCCDC PGJAMANIDEP, JLCHIDAEKKK FAGMDOIFLMG, OIBKBLGJIPN CAGFGEKDIPD, IEnumerable<PersistenceView> IDNBBICEFBM, LLFMKFGELDH FMADHOLDHAI);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BKCOJDMJFLD(OIBKBLGJIPN CAGFGEKDIPD);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void GFODMPPOACC(FMDAPGFGAFB MCHMPDGPNBP, [In] EFDLDPFLHGE BNKHAAAAAFO);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task PNPNIHDBOHG(OIBKBLGJIPN PMELHKPACLM, bool CMMBLHEIHNH, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task FOHDNLNCPPC(CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KEMNDLGELLH(long LFNEDMLHPHM, long BEGDDCHOHOL, FGPODGGHBLK POAGMGLMAJP, INMAGKMJCGB FFGNCPOOAAI, JHKLIMEFACP LAFAIALAGHO, NBJKHDBIOKG? BILBPLEGPGE, CBBFDOMDOBO? FHOHDFEKCCI);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void LKKKNGLPMBM(long LFNEDMLHPHM, long BEGDDCHOHOL, CBBFDOMDOBO? FHOHDFEKCCI);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CNDMPGEKCDE(PersistenceView PHDIGJBBHOH);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void FHGCHJNJOOK(string DMOCNPKIBHH, DNHLENAINEA FLPHGLKPGDK, OADMHEEGPLA OOHEODGLLPK, [Optional] string? MLMKOGBFBJM, [Optional] string? GOFCDFICBCE, [Optional] string? PMNBMNFNEJH);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool JIDHBNHIHNB(PersistenceView GOGEGHBLCKJ);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool IELFAECPPAC(FMDAPGFGAFB MCHMPDGPNBP, AHDANNFMFFK MOKHPNPCEGA, [Out] NFPJIIKLFJK FLKOJPLEHFC);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task GDLCFEOKPLO(CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void GAONIDMOICD();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable BHFBIAAODMG();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void PDADFNEECLC(OIBKBLGJIPN PMELHKPACLM, AHDANNFMFFK MOKHPNPCEGA);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> LNAKBDKIMCC(HHMOMAGJIPE BCLILIMLEBK, CancellationToken MLAPMBKLAOF, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void HKADPNKMEBA(CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<CGKMMAMFMFL> LKFCJKMMACN(KBMGMOECLBF NKKKCKHLGCJ);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<FGPODGGHBLK> DBKMKDGENGP(long LFNEDMLHPHM, bool CKNBOPCMGLP, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<CBLOAIMJMAA> FGABCHOIFCA(long LFNEDMLHPHM, long BEGDDCHOHOL, long BDNECDKPHLA, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<CBLOAIMJMAA> ADLCECLGKDJ(long LFNEDMLHPHM, long BEGDDCHOHOL, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "46")]
	HHKKLDJCOIN<LIAJNBDKFAJ, IEnumerable<MAIGHNLLPKA>> DGPGMPKNAMG();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "47")]
	Task<GLMHKJIINJI> ABOFKPJMCOB(string IICKCAKFCMN, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<GLMHKJIINJI> GKLJMOACJME(string IICKCAKFCMN, long LFNEDMLHPHM, long BEGDDCHOHOL, Guid? JMFGCPHCPKI, KDJOFOHAGOJ.LAOAICDOOEK EDHFGAMFCNC, KDJOFOHAGOJ.LAOAICDOOEK ODGDPEFBEOA, int FNEMCGFJDJN);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool PHNKMPFCMBG();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool ECDHJNPMLPL();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool PKFHABMPNNP(IEnumerable<NFPJIIKLFJK> PBPPJOPELOA);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void MBPAOMBHAKN(List<GameObject> MKFNPJAGPDD);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float GCGDFEDFBJE();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "55")]
	Task<bool> GIBICCHGOCG(CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<Scene> NHILJLCBNDJ(string ENFELFHDLFE, LoadSceneMode KLHHCPCEJNO, bool NENHJLNAGOD, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void PMMBOHIAPOH();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void OIHLKLNLAGA(bool KFMEJIELJKA);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void EKBMHMDMHCM();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void JHIBNPOMNGC();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void OEIADMHCJFK(bool IFJLJGKNNLK);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void HKJCPFGMDFK(DNHLENAINEA NHOPDPDCHLM);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task EGGBBMMOLPP(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task MALFBCNIAHP(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task IKADAKJKKIM(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task OOOOPKCKCIC(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "76")]
	IDisposable BGDECPODGFL();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "77")]
	OPKEFFKHMEH NPEBBADBEBK();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "78")]
	Task NJNKGOFILLD(CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface OPKEFFKHMEH
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FANJJLMCMDL(CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FIKHJPCPFNE(CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct EFDLDPFLHGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HashSet<int> PLPCJCBEEJE;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum KJDAGLMLNJL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct FJKNANMCCDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Guid? HJMGBHGEOAP;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MONKCCHOMPK
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	DNHLENAINEA JNCONCODHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	FGPODGGHBLK MDPBAJGDGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	PNGEIJCJKOB IBJPLJBIBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool HFMFBFKOPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool KJGJNIOFOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	int IIOICBAOHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action GBCCPLLOOOK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> HECGODPBDMK;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IHJKKFFFKOD();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.PLKGDPOLBAB> HEDLJEFEFEM(long FNPIGGMFPPH, [Optional] CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<LFGONPFCLHO> EKABPPECPOO(DNHLENAINEA FLPHGLKPGDK, [Optional] KMNIIEFGPKB MMFPLOFHMAF);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<LFGONPFCLHO> MHPIPBJJAOJ();

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task APFEJMDIOBB();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(DNHLENAINEA, KMNIIEFGPKB) GKIKJNDBOOF();

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FJEGBONDBNO FPDHELMAGAA();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ALMOHKPBFAL(long FNPIGGMFPPH);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GOIHHBPOFEP(DNHLENAINEA FLPHGLKPGDK, Matchmaking.NKFPJNABPOG HOCIBOCHCFJ, (int Major, int? Minor)? AOFMJKALGDK);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface AMAGBMICKBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADPGGKOAIAD([Out] IEnumerable<int> ELBIGMGBKEH);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMBJPIIIPBO(JBBPIGEHCDP OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HGJOLMEFFOL(JBBPIGEHCDP OCDOGNMJENC);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface DLBOHAMBABF
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OAEALDFABDL(MLDDIEDIFAF GOHJIBCDDFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface MBDABCDMGEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFEHNFOILNA(MDJJDEHKOCL.BILDMICMDAF OIMLDJKLCKB);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDNFNKEKKKH(MDJJDEHKOCL.BILDMICMDAF OIMLDJKLCKB);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface KDJOLJCAGCD : MBDABCDMGEI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLDDIEDIFAF LPIBJJLAHJP(NOFCMGEHFOO GECCDAMDACK);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BEEMHPLPFOO : MBDABCDMGEI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLDDIEDIFAF LAOBKBLLOLN(NOFCMGEHFOO BAEPHPHLIBE);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface GNAMIPCKPFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PHLGGJNOBDN<DOLPFMIDMMB, OGPHAGHJAIC>> LGCCGHJCCGD(Guid? JMFGCPHCPKI, IReadOnlyCollection<EHCMNNBMDKN> BJHMIJGOJHP, IReadOnlyCollection<EHCMNNBMDKN> AANNMKMHHBI, IKOCPANPHCK LPJHEHGIEKB, long? LFNEDMLHPHM, long? BEGDDCHOHOL, PFCIJBPOHAL.GHMOGAJJENN MBMLLOLGJDN, CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class DOLPFMIDMMB
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public IJLAIOLGPKJ FPFFODMPCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public IReadOnlyList<IJLAIOLGPKJ> ANJHIJIJKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IReadOnlyList<IJLAIOLGPKJ> LGPLMBCFLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0xB40EC0", Offset = "0xB402C0", VA = "0x180B40EC0")]
	public DOLPFMIDMMB(IJLAIOLGPKJ EIPKFJLIAPA, IReadOnlyList<IJLAIOLGPKJ> IDMOHIPBOLD, IReadOnlyList<IJLAIOLGPKJ> NCAHGHJGCEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HHKKLDJCOIN<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PHLGGJNOBDN<NOINHDPCAGF<TData>, OGPHAGHJAIC>> MKLEHANDPPP(TGetDataArg EEHMKJMNANF, CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class MEJOFFMOFIA : KBABJPFHBFP, JHABIGLANJE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct LFCCPAEPKJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder<MLDDIEDIFAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public MEJOFFMOFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public HLGDIBFKEKE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter<MLDDIEDIFAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7D839C0", Offset = "0x7D82DC0", VA = "0x187D839C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7D83C40", Offset = "0x7D83040", VA = "0x187D83C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct PJMLGLNJALA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public MEJOFFMOFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7D90650", Offset = "0x7D8FA50", VA = "0x187D90650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7D90880", Offset = "0x7D8FC80", VA = "0x187D90880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class IGHNGNIMIBO : IEnumerable<ILPCOFODDNC>, IEnumerable, IEnumerator<ILPCOFODDNC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private ILPCOFODDNC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public MEJOFFMOFIA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private ILPCOFODDNC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD746B0", VA = "0x180D752B0")]
		[DebuggerHidden]
		public IGHNGNIMIBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7D797F0", Offset = "0x7D78BF0", VA = "0x187D797F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7D79C50", Offset = "0x7D79050", VA = "0x187D79C50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7D79BA0", Offset = "0x7D78FA0", VA = "0x187D79BA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ILPCOFODDNC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D79BA0", Offset = "0x7D78FA0", VA = "0x187D79BA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CancellationTokenSource NHPGGKKFJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LEPFMCICNAK EOMAFKDOFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool MPODDHPAEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private KODFJGIJDHK ILLGJINJBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool IKABMPPAMMM;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public HHMOMAGJIPE OKEMJCALLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9636B0", VA = "0x1809642B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9642D0", Offset = "0x9636D0", VA = "0x1809642D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IFIEBAFBCGE KKJFDKDBPIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9642C0", Offset = "0x9636C0", VA = "0x1809642C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9642E0", Offset = "0x9636E0", VA = "0x1809642E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public LAGOIFMOJDA JIOKCOHMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9642F0", Offset = "0x9636F0", VA = "0x1809642F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x964300", Offset = "0x963700", VA = "0x180964300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CIFIMMMOPKA FILPJIKNEAE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9650B0", Offset = "0x9644B0", VA = "0x1809650B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9650C0", Offset = "0x9644C0", VA = "0x1809650C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public KDJOLJCAGCD AIKIDBCJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9650D0", Offset = "0x9644D0", VA = "0x1809650D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9650E0", Offset = "0x9644E0", VA = "0x1809650E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BEEMHPLPFOO IPFCGNLLMFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x971410", Offset = "0x970810", VA = "0x180971410", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x971400", Offset = "0x970800", VA = "0x180971400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public OGIKFOGELKN PGKEKMCLHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9712F0", Offset = "0x9706F0", VA = "0x1809712F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9712E0", Offset = "0x9706E0", VA = "0x1809712E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public MJPICOFJBDP CNPGGJBPCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9712A0", Offset = "0x9706A0", VA = "0x1809712A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x971450", Offset = "0x970850", VA = "0x180971450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public OLNLMBALJMH ODMFIIBNDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xACC560", Offset = "0xACB960", VA = "0x180ACC560", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x1179AC0", Offset = "0x1178EC0", VA = "0x181179AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public AGHNLFGEBKJ BKAIBIIKLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9712D0", Offset = "0x9706D0", VA = "0x1809712D0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9713A0", Offset = "0x9707A0", VA = "0x1809713A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public EBPALNPDLNI MLONJKDPKEB
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xBDAFB0", Offset = "0xBDA3B0", VA = "0x180BDAFB0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xD458D0", Offset = "0xD44CD0", VA = "0x180D458D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public MDGIPPAFIND GFHCOENPFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9744C0", Offset = "0x9738C0", VA = "0x1809744C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x974460", Offset = "0x973860", VA = "0x180974460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public JAMCMMKGBKP PGAOGBPCJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xB16520", Offset = "0xB15920", VA = "0x180B16520", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xD2A950", Offset = "0xD29D50", VA = "0x180D2A950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public CAPOKDEDNLL MLFCNFLLEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xC31D40", Offset = "0xC31140", VA = "0x180C31D40", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xC31D50", Offset = "0xC31150", VA = "0x180C31D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public HFDDGLJDMII BCCIPAPPMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xBDADE0", Offset = "0xBDA1E0", VA = "0x180BDADE0", Slot = "59")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xFF2D30", Offset = "0xFF2130", VA = "0x180FF2D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public DBJBBMPJJDE NFIDIDBFODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xBC63B0", Offset = "0xBC57B0", VA = "0x180BC63B0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xC62300", Offset = "0xC61700", VA = "0x180C62300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public JFNFGLFDAJH EOBPEDHJBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA99A20", Offset = "0xA98E20", VA = "0x180A99A20", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA995D0", Offset = "0xA989D0", VA = "0x180A995D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public KJAHCINMHID LOPBBLEMCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9744F0", Offset = "0x9738F0", VA = "0x1809744F0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x974480", Offset = "0x973880", VA = "0x180974480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public GMNIJCAFBOL EJDBBEOGFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA9E580", Offset = "0xA9D980", VA = "0x180A9E580", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA9DF20", Offset = "0xA9D320", VA = "0x180A9DF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public CHDBFKKIGJL LBCPJHGLDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xAB7690", Offset = "0xAB6A90", VA = "0x180AB7690", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5FB0", Offset = "0xAB53B0", VA = "0x180AB5FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public GGCFIFHGAEB CBHCDGGADCA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9D5470", Offset = "0x9D4870", VA = "0x1809D5470", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xAB69F0", Offset = "0xAB5DF0", VA = "0x180AB69F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public GCHCIBOABFC BNBKIOGAIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA97C40", Offset = "0xA97040", VA = "0x180A97C40", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA9DE40", Offset = "0xA9D240", VA = "0x180A9DE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public PKFMOFMAIHK NBGGABPCLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA97C50", Offset = "0xA97050", VA = "0x180A97C50", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA94340", Offset = "0xA93740", VA = "0x180A94340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public AMAGBMICKBJ PLEHGBGGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9F2230", Offset = "0x9F1630", VA = "0x1809F2230", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9F5120", Offset = "0x9F4520", VA = "0x1809F5120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public JENEEEIDFIJ OPIBLAHHBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA87DA0", Offset = "0xA871A0", VA = "0x180A87DA0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x107CD00", Offset = "0x107C100", VA = "0x18107CD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public HGBLLPJJCBJ KFJKKEKKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9F3BE0", Offset = "0x9F2FE0", VA = "0x1809F3BE0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA95020", Offset = "0xA94420", VA = "0x180A95020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public HCHBLHNLCND NEOIIJFPNDP
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2870", Offset = "0x9F1C70", VA = "0x1809F2870", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xABDF30", Offset = "0xABD330", VA = "0x180ABDF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public JKOCOFLNOBD HAHGBGJPLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9D9470", Offset = "0x9D8870", VA = "0x1809D9470", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public MOEMPDODMEG ICNENBHNGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9DD0", Offset = "0x9F91D0", VA = "0x1809F9DD0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public KGMCELACHEF KLBMMOPFDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC90", Offset = "0x9DB090", VA = "0x1809DBC90", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public ECLAECFMLGO FJFELEKBKEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C10", Offset = "0x9D9010", VA = "0x1809D9C10", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DEBJFNCKLHK CHLBBOMAEKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9E2DD0", Offset = "0x9E21D0", VA = "0x1809E2DD0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public KMNIIEFGPKB IEBIHHHCOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x9E36E0", Offset = "0x9E2AE0", VA = "0x1809E36E0", Slot = "57")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1272DE0", Offset = "0x12721E0", VA = "0x181272DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private bool KPEKGGKLGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D88EE0", Offset = "0x7D882E0", VA = "0x187D88EE0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private bool LOGEEMNDLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D894C0", Offset = "0x7D888C0", VA = "0x187D894C0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private bool IDFHGPHCIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x11E3D00", Offset = "0x11E3100", VA = "0x1811E3D00", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private CancellationToken KIOEBOBLPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7D89540", Offset = "0x7D88940", VA = "0x187D89540", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private LEPFMCICNAK BHNBOCENDMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool CDKBPHJHONI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x11E3D00", Offset = "0x11E3100", VA = "0x1811E3D00", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x11DFD30", Offset = "0x11DF130", VA = "0x1811DFD30", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event Action GLGMGODJDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7D88AA0", Offset = "0x7D87EA0", VA = "0x187D88AA0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7D88CF0", Offset = "0x7D880F0", VA = "0x187D88CF0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event FJGNFAJHCOO IKGPGNGOOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D89060", Offset = "0x7D88460", VA = "0x187D89060", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7D88FA0", Offset = "0x7D883A0", VA = "0x187D88FA0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event FJGNFAJHCOO ELFHDCEBCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D88C10", Offset = "0x7D88010", VA = "0x187D88C10", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7D88A40", Offset = "0x7D87E40", VA = "0x187D88A40", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event FJGNFAJHCOO AHCBKJNOHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D89000", Offset = "0x7D88400", VA = "0x187D89000", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D88F40", Offset = "0x7D88340", VA = "0x187D88F40", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x1272DE0", Offset = "0x12721E0", VA = "0x181272DE0", Slot = "39")]
	public void IMCNCJJBIBA(KMNIIEFGPKB CBFEMPBKHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D89750", Offset = "0x7D88B50", VA = "0x187D89750")]
	[UnityEngine.Scripting.Preserve]
	internal MEJOFFMOFIA([PNFCCJKFMBH(null)] LEPFMCICNAK EOMAFKDOFHE, [PNFCCJKFMBH(null)] HHMOMAGJIPE BCLILIMLEBK, [PNFCCJKFMBH(null)] IFIEBAFBCGE JKEPHCDLNOC, [PNFCCJKFMBH(null)] LAGOIFMOJDA DCHKFKLALGC, [PNFCCJKFMBH(null)] CIFIMMMOPKA CMHBHAIJACJ, [PNFCCJKFMBH(null)] KDJOLJCAGCD BGLHAPHGOIB, [PNFCCJKFMBH(null)] BEEMHPLPFOO AFMCEDMHHLI, [PNFCCJKFMBH(null)] OGIKFOGELKN INEKFIKKIDI, [PNFCCJKFMBH(null)] MJPICOFJBDP EOFAPPEKOPJ, [PNFCCJKFMBH(null)] OLNLMBALJMH CPHNDMODPIN, [PNFCCJKFMBH(null)] AGHNLFGEBKJ JLKPPHLJAPJ, [PNFCCJKFMBH(null)] EBPALNPDLNI MILPPPKHFBO, [PNFCCJKFMBH(null)] MDGIPPAFIND IFOOBBNHHGC, [PNFCCJKFMBH(null)] JAMCMMKGBKP GEJNAODDPNL, [PNFCCJKFMBH(null)] CAPOKDEDNLL DNGFBNEHOOC, [PNFCCJKFMBH(null)] HFDDGLJDMII FCPELOPAKJA, [PNFCCJKFMBH(null)] DBJBBMPJJDE NLNKDDIICDC, [PNFCCJKFMBH(null)] JFNFGLFDAJH PGCEFHJHKBM, [PNFCCJKFMBH(null)] KJAHCINMHID BBOENFEGOHA, [PNFCCJKFMBH(null)] GMNIJCAFBOL MEEGACDFLGK, [PNFCCJKFMBH(null)] GGCFIFHGAEB FKNAECPGFBE, [PNFCCJKFMBH(null)] CHDBFKKIGJL KDKFFDOJCPA, [PNFCCJKFMBH(null)] GCHCIBOABFC EMMFNJHAEED, [PNFCCJKFMBH(null)] PKFMOFMAIHK GLNNLFFKEJK, [PNFCCJKFMBH(null)] AMAGBMICKBJ BBHPKCGEOMD, [PNFCCJKFMBH(null)] HGBLLPJJCBJ FLKLAANBPFM, [PNFCCJKFMBH(null)] HCHBLHNLCND MDJNJHHNPOF, [PNFCCJKFMBH(null)] JKOCOFLNOBD ICOGLOIMBFB, [PNFCCJKFMBH(null)] MOEMPDODMEG GGIBPNKFKHI, [PNFCCJKFMBH(null)] KGMCELACHEF ADDAMDDDHKN, [PNFCCJKFMBH(null)] ECLAECFMLGO GICPMFNJKEJ, [PNFCCJKFMBH(null)] DEBJFNCKLHK DJONJMNHDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D895F0", Offset = "0x7D889F0", VA = "0x187D895F0")]
	private void OBBALIPJEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D88D50", Offset = "0x7D88150", VA = "0x187D88D50", Slot = "58")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x7D896A0", Offset = "0x7D88AA0", VA = "0x187D896A0", Slot = "51")]
	private void OONGCMANCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D889B0", Offset = "0x7D87DB0", VA = "0x187D889B0", Slot = "52")]
	private EHPADHEMLAI ALLICMPLCIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D89560", Offset = "0x7D88960", VA = "0x187D89560", Slot = "53")]
	private EPAMDPBJAJK JIPEOGBMBEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D890C0", Offset = "0x7D884C0", VA = "0x187D890C0", Slot = "54")]
	public Task HCPEGIGLDME(int FNEMCGFJDJN, NBJKHDBIOKG BILBPLEGPGE, Func<JHKLIMEFACP, JHKLIMEFACP> FEEGBJLIOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D888A0", Offset = "0x7D87CA0", VA = "0x187D888A0")]
	private KKEMAFDODJO ADLEHEPKHOC(int FNEMCGFJDJN, NBJKHDBIOKG BILBPLEGPGE, Func<JHKLIMEFACP, JHKLIMEFACP> FEEGBJLIOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D88B00", Offset = "0x7D87F00", VA = "0x187D88B00", Slot = "55")]
	[AsyncStateMachine(typeof(LFCCPAEPKJK))]
	private Task<MLDDIEDIFAF> BDENOKFLFAB(HLGDIBFKEKE AADNONONIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D893D0", Offset = "0x7D887D0", VA = "0x187D893D0", Slot = "56")]
	[AsyncStateMachine(typeof(PJMLGLNJALA))]
	private Task IEMKDPCIOCB(CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D88C70", Offset = "0x7D88070", VA = "0x187D88C70")]
	[IteratorStateMachine(typeof(IGHNGNIMIBO))]
	private IEnumerable<ILPCOFODDNC> CMPIHEFJMLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D896F0", Offset = "0x7D88AF0", VA = "0x187D896F0")]
	[CompilerGenerated]
	private void PEKOAOANMLE(ILPCOFODDNC LENGNFMPCHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class MGBDEKKFLMM : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x15EF800", Offset = "0x15EEC00", VA = "0x1815EF800")]
	public MGBDEKKFLMM(string LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class CJGOHFOJPMH : EJEOICABIFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct MKBBEKBLFJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder<EJEOICABIFJ.CLALLBOLOKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public HashSet<EBPALNPDLNI.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CJGOHFOJPMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D89BD0", Offset = "0x7D88FD0", VA = "0x187D89BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D89ED0", Offset = "0x7D892D0", VA = "0x187D89ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly LAGOIFMOJDA DCHKFKLALGC;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private string ACGFMKCLMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D74D40", Offset = "0x7D74140", VA = "0x187D74D40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x96FAD0", Offset = "0x96EED0", VA = "0x18096FAD0")]
	public CJGOHFOJPMH(KBABJPFHBFP OKINEPMMKIG, LAGOIFMOJDA DCHKFKLALGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7D74D70", Offset = "0x7D74170", VA = "0x187D74D70", Slot = "5")]
	[AsyncStateMachine(typeof(MKBBEKBLFJD))]
	public Task<EJEOICABIFJ.CLALLBOLOKG> JCADJGIOJAE(HashSet<EBPALNPDLNI.Reason> BGHNKLMDNNB, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal class FDGHBGBEIHK : JNGNEIPHADP, EJEOICABIFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct PEHBMACOECC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder<EJEOICABIFJ.CLALLBOLOKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public FDGHBGBEIHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public HashSet<EBPALNPDLNI.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private DNHLENAINEA <localRoomInstance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private long <preFallbackInstance>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private bool <currentIsOffline>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<EJEOICABIFJ.CLALLBOLOKG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7D8FB40", Offset = "0x7D8EF40", VA = "0x187D8FB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7D904A0", Offset = "0x7D8F8A0", VA = "0x187D904A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private string ACGFMKCLMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D775E0", Offset = "0x7D769E0", VA = "0x187D775E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x96FAD0", Offset = "0x96EED0", VA = "0x18096FAD0")]
	public FDGHBGBEIHK(KBABJPFHBFP OKINEPMMKIG, LAGOIFMOJDA DCHKFKLALGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D77610", Offset = "0x7D76A10", VA = "0x187D77610", Slot = "5")]
	[AsyncStateMachine(typeof(PEHBMACOECC))]
	public Task<EJEOICABIFJ.CLALLBOLOKG> JCADJGIOJAE(HashSet<EBPALNPDLNI.Reason> BGHNKLMDNNB, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal class HKLLOJBFCIA : JNGNEIPHADP, EJEOICABIFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct BMFEGOMIKBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder<EJEOICABIFJ.CLALLBOLOKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public HKLLOJBFCIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public HashSet<EBPALNPDLNI.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter<LFGONPFCLHO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter<EJEOICABIFJ.CLALLBOLOKG> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D72B80", Offset = "0x7D71F80", VA = "0x187D72B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D73570", Offset = "0x7D72970", VA = "0x187D73570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private string ACGFMKCLMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D79320", Offset = "0x7D78720", VA = "0x187D79320", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x96FAD0", Offset = "0x96EED0", VA = "0x18096FAD0")]
	public HKLLOJBFCIA(KBABJPFHBFP OKINEPMMKIG, LAGOIFMOJDA DCHKFKLALGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D79350", Offset = "0x7D78750", VA = "0x187D79350", Slot = "5")]
	[AsyncStateMachine(typeof(BMFEGOMIKBF))]
	public Task<EJEOICABIFJ.CLALLBOLOKG> JCADJGIOJAE(HashSet<EBPALNPDLNI.Reason> BGHNKLMDNNB, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal class KFJKJBIKJLK : JNGNEIPHADP, EJEOICABIFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class PFEBOODFDLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public LFGONPFCLHO matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public PFEBOODFDLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7D905D0", Offset = "0x7D8F9D0", VA = "0x187D905D0")]
		internal object MHIKMKPKAHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7D90510", Offset = "0x7D8F910", VA = "0x187D90510")]
		internal object HOJHPNGNAFI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct FDAOALJDIDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder<EJEOICABIFJ.CLALLBOLOKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public KFJKJBIKJLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public HashSet<EBPALNPDLNI.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private PFEBOODFDLC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private TaskAwaiter<LFGONPFCLHO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<EJEOICABIFJ.CLALLBOLOKG> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7D766D0", Offset = "0x7D75AD0", VA = "0x187D766D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7D772F0", Offset = "0x7D766F0", VA = "0x187D772F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string ACGFMKCLMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C780", Offset = "0x7D7BB80", VA = "0x187D7C780", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x96FAD0", Offset = "0x96EED0", VA = "0x18096FAD0")]
	public KFJKJBIKJLK(KBABJPFHBFP OKINEPMMKIG, LAGOIFMOJDA DCHKFKLALGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C7B0", Offset = "0x7D7BBB0", VA = "0x187D7C7B0", Slot = "5")]
	[AsyncStateMachine(typeof(FDAOALJDIDF))]
	public Task<EJEOICABIFJ.CLALLBOLOKG> JCADJGIOJAE(HashSet<EBPALNPDLNI.Reason> BGHNKLMDNNB, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal abstract class JNGNEIPHADP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct NBINBIAELCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public HLBHMADGLFA log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public HashSet<EBPALNPDLNI.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public JNGNEIPHADP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private List<EBPALNPDLNI.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7D8B770", Offset = "0x7D8AB70", VA = "0x187D8B770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7D8BC90", Offset = "0x7D8B090", VA = "0x187D8BC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	protected readonly KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	protected readonly LAGOIFMOJDA DCHKFKLALGC;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	protected MONKCCHOMPK GPMOAHABAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C730", Offset = "0x7D7BB30", VA = "0x187D7C730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x96FAD0", Offset = "0x96EED0", VA = "0x18096FAD0")]
	public JNGNEIPHADP(KBABJPFHBFP OKINEPMMKIG, LAGOIFMOJDA DCHKFKLALGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C600", Offset = "0x7D7BA00", VA = "0x187D7C600")]
	[AsyncStateMachine(typeof(NBINBIAELCC))]
	protected Task IJPINGLFOCH(HLBHMADGLFA GCIBFPDCNDK, HashSet<EBPALNPDLNI.Reason> BGHNKLMDNNB, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class EHFCEKBHDID
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct HFFOFPEJBDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public AsyncTaskMethodBuilder<EJEOICABIFJ.CLALLBOLOKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public LAGOIFMOJDA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D78F30", Offset = "0x7D78330", VA = "0x187D78F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7D792B0", Offset = "0x7D786B0", VA = "0x187D792B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class OPGDBJNHLCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public KBABJPFHBFP roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OPGDBJNHLCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7D8FA40", Offset = "0x7D8EE40", VA = "0x187D8FA40")]
		internal object FMKJCALKPJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static readonly float LPFDJIMBGBL;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	internal static readonly HashSet<EBPALNPDLNI.Reason> OBEJFKOMIFB;

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7D75F50", Offset = "0x7D75350", VA = "0x187D75F50")]
	[AsyncStateMachine(typeof(HFFOFPEJBDA))]
	internal static Task<EJEOICABIFJ.CLALLBOLOKG> EKBJIDNLKHH(LAGOIFMOJDA DCHKFKLALGC, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D76060", Offset = "0x7D75460", VA = "0x187D76060")]
	internal static void NFJMEHFLBHB(KBABJPFHBFP OKINEPMMKIG, HLBHMADGLFA GCIBFPDCNDK, string DMOCNPKIBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal interface EJEOICABIFJ
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct CLALLBOLOKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public bool LAKNLJKLEMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public EBPALNPDLNI.Reason BBAJBLJIPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Enum? PMNBMNFNEJH;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7D74F00", Offset = "0x7D74300", VA = "0x187D74F00")]
		public static CLALLBOLOKG MMNBHEMMLJC()
		{
			return default(CLALLBOLOKG);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7D74F10", Offset = "0x7D74310", VA = "0x187D74F10")]
		public static CLALLBOLOKG PDCKLPDBHGK(EBPALNPDLNI.Reason BBAJBLJIPLG, [Optional] Enum? PMNBMNFNEJH)
		{
			return default(CLALLBOLOKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	string BMLEKFMKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CLALLBOLOKG> JCADJGIOJAE(HashSet<EBPALNPDLNI.Reason> BGHNKLMDNNB, CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal struct EFPDFDPPMIC
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class OMADIHANBJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public KBABJPFHBFP manager;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OMADIHANBJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7D8EB20", Offset = "0x7D8DF20", VA = "0x187D8EB20")]
		internal Task NCBHPJCEKNK(CancellationToken cancellationToken, int roomTotalVersion, DFFCINOLDEH localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct MOEIELIGDBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public EFPDFDPPMIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private HLGDIBFKEKE <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter<KJDAGLMLNJL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter<MLDDIEDIFAF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7D8AC40", Offset = "0x7D8A040", VA = "0x187D8AC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7D8B1D0", Offset = "0x7D8A5D0", VA = "0x187D8B1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct EMDAHOHCDCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public EFPDFDPPMIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7D76350", Offset = "0x7D75750", VA = "0x187D76350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7D76670", Offset = "0x7D75A70", VA = "0x187D76670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly CancellationToken MLAPMBKLAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly KBABJPFHBFP FDIJEKJEAKE;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private HHMOMAGJIPE OKEMJCALLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7D75810", Offset = "0x7D74C10", VA = "0x187D75810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private LAGOIFMOJDA JIOKCOHMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7D75BC0", Offset = "0x7D74FC0", VA = "0x187D75BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private MONKCCHOMPK GPMOAHABAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7D75B40", Offset = "0x7D74F40", VA = "0x187D75B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private OLNLMBALJMH ODMFIIBNDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7D75AF0", Offset = "0x7D74EF0", VA = "0x187D75AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x25C3080", Offset = "0x25C2480", VA = "0x1825C3080")]
	public EFPDFDPPMIC(CancellationToken MLAPMBKLAOF, KBABJPFHBFP FDIJEKJEAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7D75A40", Offset = "0x7D74E40", VA = "0x187D75A40")]
	public static ILOKGPLFKED HLHOGBDALCB(KBABJPFHBFP FDIJEKJEAKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7D75930", Offset = "0x7D74D30", VA = "0x187D75930")]
	[AsyncStateMachine(typeof(MOEIELIGDBK))]
	public Task<bool> GNAFMGAEBCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7D75C10", Offset = "0x7D75010", VA = "0x187D75C10")]
	private bool MJJKOCDOHOF([Out] HLGDIBFKEKE AADNONONIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7D75860", Offset = "0x7D74C60", VA = "0x187D75860")]
	[AsyncStateMachine(typeof(EMDAHOHCDCM))]
	private Task BPJFMKBKJML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7D75E20", Offset = "0x7D75220", VA = "0x187D75E20")]
	private Task<KJDAGLMLNJL> PAAPDDBDMDB(HLGDIBFKEKE CLIKDBCPPFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct GBPMNAIFOAH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly CAPOKDEDNLL DNGFBNEHOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly Guid PPLJPJJDEGE;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private Task<(MLDDIEDIFAF, Task)> MFCJJENJALG
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7D78070", Offset = "0x7D77470", VA = "0x187D78070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4BC3500", Offset = "0x4BC2900", VA = "0x184BC3500")]
	public GBPMNAIFOAH(CAPOKDEDNLL DNGFBNEHOOC, Guid PPLJPJJDEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7D77F50", Offset = "0x7D77350", VA = "0x187D77F50")]
	public TaskAwaiter<(MLDDIEDIFAF, Task)> ADJMMNLCDBA()
	{
		return default(TaskAwaiter<(MLDDIEDIFAF, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7D77FA0", Offset = "0x7D773A0", VA = "0x187D77FA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct POEMFDHFMBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly TaskCompletionSource<(MLDDIEDIFAF, Task)> LJGNFIODGDI;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Task<(MLDDIEDIFAF, Task)> MFCJJENJALG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7D90B60", Offset = "0x7D8FF60", VA = "0x187D90B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7D90C90", Offset = "0x7D90090", VA = "0x187D90C90")]
	public POEMFDHFMBM(TimeSpan OFCJJHCKIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7D90BF0", Offset = "0x7D8FFF0", VA = "0x187D90BF0")]
	public void PJOJIIKKMHA(Task EKBLHMHCAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7D90A40", Offset = "0x7D8FE40", VA = "0x187D90A40")]
	public void AGFEJNGFEPC(MLDDIEDIFAF GOHJIBCDDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7D90BA0", Offset = "0x7D8FFA0", VA = "0x187D90BA0")]
	public void IHMIBMKLHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7D90AD0", Offset = "0x7D8FED0", VA = "0x187D90AD0")]
	internal void DIKPGJBDGGF(string LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class CEIGDECGGLE
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class ONNPNBAKFFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public INMAGKMJCGB subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public ONNPNBAKFFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7D8FA10", Offset = "0x7D8EE10", VA = "0x187D8FA10")]
		internal bool NLECEHPIAND(PNGEIJCJKOB s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7D74AA0", Offset = "0x7D73EA0", VA = "0x187D74AA0")]
	public static LDGKNLKOAHN GEEFBNOOFMP(long NBFFAAFDIFN, long BEGDDCHOHOL, string IICKCAKFCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7D74520", Offset = "0x7D73920", VA = "0x187D74520")]
	public static LDGKNLKOAHN GEEFBNOOFMP(long NBFFAAFDIFN, long BEGDDCHOHOL, LOFGJIDOAFO IEFIJIFMMAE, Guid? LCECALACCPP, long BDNECDKPHLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7D74680", Offset = "0x7D73A80", VA = "0x187D74680")]
	public static LDGKNLKOAHN GEEFBNOOFMP(CGKMMAMFMFL PJNDAFBOJHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7D74820", Offset = "0x7D73C20", VA = "0x187D74820")]
	public static LDGKNLKOAHN GEEFBNOOFMP(FGPODGGHBLK JLAGHAHNIPF, INMAGKMJCGB PJNBHJIFHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7D74B30", Offset = "0x7D73F30", VA = "0x187D74B30")]
	public static LDGKNLKOAHN GLMLOFKJFDE(this LDGKNLKOAHN IILBHIALBMC, FGPODGGHBLK ENBCDPLIFME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7D74390", Offset = "0x7D73790", VA = "0x187D74390")]
	public static LDGKNLKOAHN DEANBDPFFCL(this LDGKNLKOAHN IILBHIALBMC, INMAGKMJCGB ELNOGJPLCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7D74CD0", Offset = "0x7D740D0", VA = "0x187D74CD0")]
	private static Guid? MOAJAEEHMME(FGPODGGHBLK PLJLHALIBBN, long FHAJBLMHDGD, long KEJMGKLBKBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[RecRoom.NoEngine.Common.Preserve]
internal class NGLPAHMMDEM : MJPICOFJBDP, ILPCOFODDNC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct FIMEEKOOFEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NGLPAHMMDEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7D777E0", Offset = "0x7D76BE0", VA = "0x187D777E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7D77E70", Offset = "0x7D77270", VA = "0x187D77E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly JBBPIGEHCDP GEDJODFAFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private string IAKDGAINCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Task GLHMHCBPMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool MJFDANKGNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C680", Offset = "0x7D8BA80", VA = "0x187D8C680", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Task CMPPGNHHNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C6B0", Offset = "0x7D8BAB0", VA = "0x187D8C6B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x969430", Offset = "0x968830", VA = "0x180969430", Slot = "7")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C740", Offset = "0x7D8BB40", VA = "0x187D8C740", Slot = "6")]
	public void KCDBGOJJNFP(Task GELALODAJCE, string FBDJLGDJLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C8A0", Offset = "0x7D8BCA0", VA = "0x187D8C8A0")]
	[AsyncStateMachine(typeof(FIMEEKOOFEO))]
	private Task OHLOKIKGFEC(Task AIDPLJJNAOB, string FBDJLGDJLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C9C0", Offset = "0x7D8BDC0", VA = "0x187D8C9C0")]
	public NGLPAHMMDEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal class NPJBKDPLLPF : JENEEEIDFIJ, ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private bool GHKACJIHCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private IGKLHNCIHKG LMMGNFEEACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private HHMOMAGJIPE BCLILIMLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private HGBLLPJJCBJ FLKLAANBPFM;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public IGKLHNCIHKG BNBJKCHDDID
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DA10", Offset = "0x7D8CE10", VA = "0x187D8DA10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7D8DA80", Offset = "0x7D8CE80", VA = "0x187D8DA80", Slot = "7")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D7A0", Offset = "0x7D8CBA0", VA = "0x187D8D7A0", Slot = "5")]
	public void ENIPAOLFHNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D760", Offset = "0x7D8CB60", VA = "0x187D8D760", Slot = "6")]
	public void ADOIKGCGDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D950", Offset = "0x7D8CD50", VA = "0x187D8D950")]
	private Task GKAIMPOAIIM(CBKEDKEAGIE NCCMNNBGHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D760", Offset = "0x7D8CB60", VA = "0x187D8D760", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public NPJBKDPLLPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal class HBHOPKNBFDB : HGBLLPJJCBJ
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class MIMFHHJOFKE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly PAJFLGMBLIE OFOFLKGFIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly string MCNLCGLNHHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly T CIKOELCEFFM;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public T KAMPPLLIEDO
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xB8D840", Offset = "0xB8CC40", VA = "0x180B8D840")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xB8D080", Offset = "0xB8C480", VA = "0x180B8D080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x4E02F50", Offset = "0x4E02350", VA = "0x184E02F50")]
		public MIMFHHJOFKE(PAJFLGMBLIE OFOFLKGFIFD, string MCNLCGLNHHO, T CIKOELCEFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x4E02A20", Offset = "0x4E01E20", VA = "0x184E02A20")]
		private void AFKIHFKDLDJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly PAJFLGMBLIE OFOFLKGFIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly MIMFHHJOFKE<TimeSpan> FLFBJFNMJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly MIMFHHJOFKE<TimeSpan> BKJEDFKCPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly MIMFHHJOFKE<TimeSpan> KOHFMOALGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly MIMFHHJOFKE<TimeSpan> GLPMMBEPHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly MIMFHHJOFKE<bool> OAICLGJEEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly MIMFHHJOFKE<bool> IBENOCBOMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly MIMFHHJOFKE<bool> CNMCIMANKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly MIMFHHJOFKE<int> BDEGLJDIGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly MIMFHHJOFKE<bool> PMLPABJIFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly MIMFHHJOFKE<bool> CPFCMJDPIHL;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public TimeSpan OJCPCNLGAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7D78A00", Offset = "0x7D77E00", VA = "0x187D78A00", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public TimeSpan JAAOCEJHGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7D78A40", Offset = "0x7D77E40", VA = "0x187D78A40", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public TimeSpan GJIJKHHEPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7D78A80", Offset = "0x7D77E80", VA = "0x187D78A80", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan EDCMGKEFAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7D78900", Offset = "0x7D77D00", VA = "0x187D78900", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool JPMLHBKNEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7D788C0", Offset = "0x7D77CC0", VA = "0x187D788C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool KAFFLCAOKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7D78980", Offset = "0x7D77D80", VA = "0x187D78980", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool NFPLNIPLKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7D78840", Offset = "0x7D77C40", VA = "0x187D78840", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public int GDBCDEBHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7D78880", Offset = "0x7D77C80", VA = "0x187D78880", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool GLBKJCAIENN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7D789C0", Offset = "0x7D77DC0", VA = "0x187D789C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool GNLBLIKPDDH
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7D78940", Offset = "0x7D77D40", VA = "0x187D78940", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7D78AC0", Offset = "0x7D77EC0", VA = "0x187D78AC0")]
	[UnityEngine.Scripting.Preserve]
	public HBHOPKNBFDB([PNFCCJKFMBH(null)] PAJFLGMBLIE OFOFLKGFIFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[UnityEngine.Scripting.Preserve]
internal class NDOOOKMKANF : AGHNLFGEBKJ, ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class BNCBFJNPOOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public AFOKKDBKELL roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public BNCBFJNPOOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7D735E0", Offset = "0x7D729E0", VA = "0x187D735E0")]
		internal object JANBIDKGBOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	[CompilerGenerated]
	private Action<PKPHAIIFFIO, bool> IMBJFMFNLNO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action MLKIOMBIOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C0D0", Offset = "0x7D8B4D0", VA = "0x187D8C0D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C210", Offset = "0x7D8B610", VA = "0x187D8C210", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event FJGNFAJHCOO LCOFDDPMJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7D8BFE0", Offset = "0x7D8B3E0", VA = "0x187D8BFE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C170", Offset = "0x7D8B570", VA = "0x187D8C170", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event FJGNFAJHCOO FNCDDFEBDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C2B0", Offset = "0x7D8B6B0", VA = "0x187D8C2B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C420", Offset = "0x7D8B820", VA = "0x187D8C420", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event FJGNFAJHCOO GHFINDHNALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C350", Offset = "0x7D8B750", VA = "0x187D8C350", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7D8BCF0", Offset = "0x7D8B0F0", VA = "0x187D8BCF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "17")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BD90", Offset = "0x7D8B190", VA = "0x187D8BD90", Slot = "12")]
	public void BMCAJEBBKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BFB0", Offset = "0x7D8B3B0", VA = "0x187D8BFB0", Slot = "13")]
	public void DFJIPGDJBFK(AFOKKDBKELL JMAPFIDMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C3F0", Offset = "0x7D8B7F0", VA = "0x187D8C3F0", Slot = "14")]
	public void OOAKANIBHLP(AFOKKDBKELL JMAPFIDMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BF80", Offset = "0x7D8B380", VA = "0x187D8BF80", Slot = "15")]
	public void CJECIJJJCOK(AFOKKDBKELL JMAPFIDMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C080", Offset = "0x7D8B480", VA = "0x187D8C080", Slot = "16")]
	public void KBGFIEHELGB(PKPHAIIFFIO PCPPMGPAHKO, bool LAKNLJKLEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C4C0", Offset = "0x7D8B8C0", VA = "0x187D8C4C0")]
	private void PLLPMLOMEJL(FJGNFAJHCOO BNMOKGHOHIA, AFOKKDBKELL JMAPFIDMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public NDOOOKMKANF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[UnityEngine.Scripting.Preserve]
internal class OBGKJJGGFIH : EBPALNPDLNI, ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private class IHAEAPPLLPD : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct KNLHIBIKOOJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public IHAEAPPLLPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public EBPALNPDLNI.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private CPNFFAJCLON <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			private EJEOICABIFJ[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private TaskAwaiter<EJEOICABIFJ.CLALLBOLOKG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x7D82EC0", Offset = "0x7D822C0", VA = "0x187D82EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x7D835F0", Offset = "0x7D829F0", VA = "0x187D835F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct MKNGHKMHFFG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public AsyncTaskMethodBuilder<EJEOICABIFJ.CLALLBOLOKG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public EJEOICABIFJ fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public IHAEAPPLLPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public EBPALNPDLNI.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			private CPNFFAJCLON <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private GFPACELCEIC <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private TaskAwaiter<EJEOICABIFJ.CLALLBOLOKG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x7D89F40", Offset = "0x7D89340", VA = "0x187D89F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x7D8ABD0", Offset = "0x7D89FD0", VA = "0x187D8ABD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class FNEGANIHDOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public EJEOICABIFJ fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public FNEGANIHDOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x7D77ED0", Offset = "0x7D772D0", VA = "0x187D77ED0")]
			internal object AGMFBHPDHPG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Task GELALODAJCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationTokenSource DJFFBOPMNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public GFPACELCEIC PPJONAMJIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public LAGOIFMOJDA DCHKFKLALGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public OADMHEEGPLA OOHEODGLLPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public DNHLENAINEA FLPHGLKPGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public EJEOICABIFJ[] BHCMOFHGHIB;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public bool JJCLLNLCAMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x7D78140", Offset = "0x7D77540", VA = "0x187D78140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public bool DICHDOHMNJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x7D782E0", Offset = "0x7D776E0", VA = "0x187D782E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B790", Offset = "0x7D7AB90", VA = "0x187D7B790")]
		public IHAEAPPLLPD(LAGOIFMOJDA DCHKFKLALGC, OADMHEEGPLA OOHEODGLLPK, DNHLENAINEA FLPHGLKPGDK, EJEOICABIFJ[] BHCMOFHGHIB, CancellationToken MLAPMBKLAOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A140", Offset = "0x7D79540", VA = "0x187D7A140", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B290", Offset = "0x7D7A690", VA = "0x187D7B290")]
		public void PANDNGLECFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7D7AD70", Offset = "0x7D7A170", VA = "0x187D7AD70")]
		public void OCEKCDPJNLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A430", Offset = "0x7D79830", VA = "0x187D7A430")]
		public void GOPGNOJJCDI(EBPALNPDLNI.Reason PIDEBNCLALN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A990", Offset = "0x7D79D90", VA = "0x187D7A990")]
		[AsyncStateMachine(typeof(KNLHIBIKOOJ))]
		public Task JNAGKGLLNBG(EBPALNPDLNI.Reason BBAJBLJIPLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A000", Offset = "0x7D79400", VA = "0x187D7A000")]
		[AsyncStateMachine(typeof(MKNGHKMHFFG))]
		private Task<EJEOICABIFJ.CLALLBOLOKG> DOIEDHALJOA(EBPALNPDLNI.Reason BBAJBLJIPLG, EJEOICABIFJ OCHIKIEJGIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B300", Offset = "0x7D7A700", VA = "0x187D7B300")]
		private void PDNKCHDFAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7D79E40", Offset = "0x7D79240", VA = "0x187D79E40")]
		public bool COACJKGLHND(EBPALNPDLNI.Reason CAFIFAKMFNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A6E0", Offset = "0x7D79AE0", VA = "0x187D7A6E0")]
		private void IEJPJOCCIPM(GFPACELCEIC MLIDEILJAJE, EBPALNPDLNI.Reason BBAJBLJIPLG = EBPALNPDLNI.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7D7ABA0", Offset = "0x7D79FA0", VA = "0x187D7ABA0")]
		private void LGPOHIJOEGE(GFPACELCEIC MLIDEILJAJE, EJEOICABIFJ.CLALLBOLOKG HOCIBOCHCFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7D79CA0", Offset = "0x7D790A0", VA = "0x187D79CA0")]
		private void APLNLKEIIFA(GFPACELCEIC MLIDEILJAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7D7AED0", Offset = "0x7D7A2D0", VA = "0x187D7AED0")]
		private void OIMPMOFEAOJ(GFPACELCEIC MLIDEILJAJE, EJEOICABIFJ.CLALLBOLOKG HOCIBOCHCFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A2D0", Offset = "0x7D796D0", VA = "0x187D7A2D0")]
		private void ENFEDNKFFMP(GFPACELCEIC MLIDEILJAJE, Exception BOKONMFPKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7D7AA90", Offset = "0x7D79E90", VA = "0x187D7AA90")]
		private void KCKJOMHPHCH(EJEOICABIFJ OCHIKIEJGIF, EBPALNPDLNI.Reason BBAJBLJIPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7D79EF0", Offset = "0x7D792F0", VA = "0x187D79EF0")]
		private void DKPHNHEDHNF(EJEOICABIFJ OCHIKIEJGIF, EBPALNPDLNI.Reason BBAJBLJIPLG, string PMNBMNFNEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B420", Offset = "0x7D7A820", VA = "0x187D7B420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class GFPACELCEIC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public Task<EJEOICABIFJ.CLALLBOLOKG> GELALODAJCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public CancellationTokenSource DJFFBOPMNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public EJEOICABIFJ OCHIKIEJGIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public EBPALNPDLNI.Reason PIDEBNCLALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public HashSet<EBPALNPDLNI.Reason> BGHNKLMDNNB;

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public bool JJCLLNLCAMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x7D78140", Offset = "0x7D77540", VA = "0x187D78140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public bool DICHDOHMNJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x7D782E0", Offset = "0x7D776E0", VA = "0x187D782E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7D78180", Offset = "0x7D77580", VA = "0x187D78180")]
		public void FGPIGKDDHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7D78160", Offset = "0x7D77560", VA = "0x187D78160", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7D78300", Offset = "0x7D77700", VA = "0x187D78300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7D78660", Offset = "0x7D77A60", VA = "0x187D78660")]
		public GFPACELCEIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class GIGIALNIBPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public EBPALNPDLNI.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GIGIALNIBPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7D78760", Offset = "0x7D77B60", VA = "0x187D78760")]
		internal object GDMDJKCJBNB(GFPACELCEIC x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7D787D0", Offset = "0x7D77BD0", VA = "0x187D787D0")]
		internal object PJBAAHNIJPA(IHAEAPPLLPD x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7D786F0", Offset = "0x7D77AF0", VA = "0x187D786F0")]
		internal object CJJCLEIOJGB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct KLNBNFPGHJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public EBPALNPDLNI.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public OBGKJJGGFIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private GIGIALNIBPF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C980", Offset = "0x7D7BD80", VA = "0x187D7C980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7D7D3E0", Offset = "0x7D7C7E0", VA = "0x187D7D3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct CBOIDEAFEHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public OBGKJJGGFIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public EBPALNPDLNI.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private IHAEAPPLLPD <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7D736C0", Offset = "0x7D72AC0", VA = "0x187D736C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7D74330", Offset = "0x7D73730", VA = "0x187D74330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct AKFDKOMLFPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public OBGKJJGGFIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7D71FD0", Offset = "0x7D713D0", VA = "0x187D71FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7D72540", Offset = "0x7D71940", VA = "0x187D72540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	internal static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	internal static readonly HLBHMADGLFA GLEDKBJBBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private LAGOIFMOJDA DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private IHAEAPPLLPD BGMDOBCFNKD;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private MONKCCHOMPK GPMOAHABAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7D8E670", Offset = "0x7D8DA70", VA = "0x187D8E670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool APDINCPAOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x21573B0", Offset = "0x21567B0", VA = "0x1821573B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private bool OHDNKMAIMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7D8E8E0", Offset = "0x7D8DCE0", VA = "0x187D8E8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7D8E860", Offset = "0x7D8DC60", VA = "0x187D8E860", Slot = "7")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7D8E030", Offset = "0x7D8D430", VA = "0x187D8E030", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7D8E040", Offset = "0x7D8D440", VA = "0x187D8E040", Slot = "9")]
	public void FGPIGKDDHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7D8DC80", Offset = "0x7D8D080", VA = "0x187D8DC80")]
	private bool AOEJLIFPHFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7D8E790", Offset = "0x7D8DB90", VA = "0x187D8E790", Slot = "6")]
	private void MAEKKFNDLOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7D8E580", Offset = "0x7D8D980", VA = "0x187D8E580", Slot = "5")]
	[AsyncStateMachine(typeof(KLNBNFPGHJD))]
	private Task HCEGIAEHIED(EBPALNPDLNI.Reason BBAJBLJIPLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7D8DD60", Offset = "0x7D8D160", VA = "0x187D8DD60")]
	private bool BJCMIOMGDEJ(EBPALNPDLNI.Reason BBAJBLJIPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7D8E1C0", Offset = "0x7D8D5C0", VA = "0x187D8E1C0")]
	private EJEOICABIFJ[] GMFNDKIJNKE(DNHLENAINEA AOFGAENNFBJ, OADMHEEGPLA ENPJGLNOAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7D8E950", Offset = "0x7D8DD50", VA = "0x187D8E950")]
	[AsyncStateMachine(typeof(CBOIDEAFEHH))]
	private Task PBNICCACJHO(EBPALNPDLNI.Reason BBAJBLJIPLG, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7D8E6C0", Offset = "0x7D8DAC0", VA = "0x187D8E6C0")]
	[AsyncStateMachine(typeof(AKFDKOMLFPL))]
	private Task JPMDMAJLMJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public OBGKJJGGFIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[RecRoom.NoEngine.Common.Preserve]
internal class LJHMMELPGKG : MDGIPPAFIND, ILPCOFODDNC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct JEBNMEHNLLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public LJHMMELPGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public KMNIIEFGPKB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BBD0", Offset = "0x7D7AFD0", VA = "0x187D7BBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C530", Offset = "0x7D7B930", VA = "0x187D7C530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct NLEJAOAFHPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public LJHMMELPGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public KMNIIEFGPKB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private PGLLJHOKMII<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private CPNFFAJCLON <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private MMCELPKDDOJ <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private PLPALFJAGFP <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D8CA50", Offset = "0x7D8BE50", VA = "0x187D8CA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D700", Offset = "0x7D8CB00", VA = "0x187D8D700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class ANPNOPGAECD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public Matchmaking.NKFPJNABPOG result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public BEGGOOEAECN errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public ANPNOPGAECD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D725A0", Offset = "0x7D719A0", VA = "0x187D725A0")]
		internal object EIFOEKDDIDL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class DMBEKCMMPJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Task<LDGKNLKOAHN> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public DMBEKCMMPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		internal Task<LDGKNLKOAHN> AEBGIIICPKC(PGLLJHOKMII<string>.GLACLJPMODI _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct KLOGFPAPFDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public LJHMMELPGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public KMNIIEFGPKB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public MMCELPKDDOJ joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private DMBEKCMMPJM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private IIPINPOLBCP <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private CPNFFAJCLON <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private PGLLJHOKMII<string>.GLACLJPMODI <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private CJKDPIKNJOA <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private Task<Matchmaking.PLKGDPOLBAB> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private LJPNEKMEFMK <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private TaskAwaiter<Matchmaking.PLKGDPOLBAB> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter<LDGKNLKOAHN> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D7D440", Offset = "0x7D7C840", VA = "0x187D7D440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7D82E60", Offset = "0x7D82260", VA = "0x187D82E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct JODDEBMMNIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public LJHMMELPGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private PGLLJHOKMII<string>.GLACLJPMODI <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7B80", Offset = "0x7DA6F80", VA = "0x187DA7B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7DA85F0", Offset = "0x7DA79F0", VA = "0x187DA85F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct LJHPBIIBIOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public LJHMMELPGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private LEPFMCICNAK <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7DAA9B0", Offset = "0x7DA9DB0", VA = "0x187DAA9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7DAAE40", Offset = "0x7DAA240", VA = "0x187DAAE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct BJBMIKCHHIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public AsyncTaskMethodBuilder<Matchmaking.PLKGDPOLBAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public LJHMMELPGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<Matchmaking.PLKGDPOLBAB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7D97760", Offset = "0x7D96B60", VA = "0x187D97760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D97C40", Offset = "0x7D97040", VA = "0x187D97C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct IDKBEPCFMNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public Matchmaking.PLKGDPOLBAB serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public LJHMMELPGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public MMCELPKDDOJ joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private TaskAwaiter<NHEIDIOHEIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7DA56F0", Offset = "0x7DA4AF0", VA = "0x187DA56F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5D30", Offset = "0x7DA5130", VA = "0x187DA5D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class AHHCOLOKPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AHHCOLOKPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7D934D0", Offset = "0x7D928D0", VA = "0x187D934D0")]
		internal object AHMNKGBIBBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7D935D0", Offset = "0x7D929D0", VA = "0x187D935D0")]
		internal string FCNOHNPCOBJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct BBDIJBPOEPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public LJHMMELPGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private AHHCOLOKPNM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7D95140", Offset = "0x7D94540", VA = "0x187D95140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7D95CD0", Offset = "0x7D950D0", VA = "0x187D95CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct KHGLILBOAHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public LJHMMELPGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public MMCELPKDDOJ joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public LDGKNLKOAHN initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public DNHLENAINEA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public IIPINPOLBCP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private PGLLJHOKMII<string>.GLACLJPMODI <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8EB0", Offset = "0x7DA82B0", VA = "0x187DA8EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7DA96A0", Offset = "0x7DA8AA0", VA = "0x187DA96A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct MNEPGNHODIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public LJHMMELPGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private PGLLJHOKMII<string>.GLACLJPMODI <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private CPNFFAJCLON <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private CPNFFAJCLON <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC910", Offset = "0x7DABD10", VA = "0x187DAC910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE0F0", Offset = "0x7DAD4F0", VA = "0x187DAE0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct BOMJEANJGMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public DFFCINOLDEH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public LJHMMELPGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private TaskAwaiter<MLDDIEDIFAF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7D97CB0", Offset = "0x7D970B0", VA = "0x187D97CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7D984B0", Offset = "0x7D978B0", VA = "0x187D984B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class JLPDNKHLDDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JLPDNKHLDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DA71E0", Offset = "0x7DA65E0", VA = "0x187DA71E0")]
		internal object ABDKCEILMGA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class DOGFJJKDGEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public DOGFJJKDGEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D0A0", Offset = "0x7D9C4A0", VA = "0x187D9D0A0")]
		internal void FPCBGJGOOFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class JJHPBANFHEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JJHPBANFHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7160", Offset = "0x7DA6560", VA = "0x187DA7160")]
		internal object BMMPGCEABAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class GBCGCGMCGHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GBCGCGMCGHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7DA18F0", Offset = "0x7DA0CF0", VA = "0x187DA18F0")]
		internal string HFDKGNCMBIM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly HLBHMADGLFA LFEMCAECBLD;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly HLBHMADGLFA LGMKCJCBFGB;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly HLBHMADGLFA NPGICJPFCIA;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly string NLJBKDLHEDO;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly string OLOPJKPKFAI;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly string DDGIEKHCDBJ;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public static readonly Guid HNFCBHPDHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private OGIKFOGELKN INEKFIKKIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private IFIEBAFBCGE JKEPHCDLNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private HHMOMAGJIPE BCLILIMLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private LAGOIFMOJDA DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private EBPALNPDLNI MILPPPKHFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private MJPICOFJBDP EOFAPPEKOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private AGHNLFGEBKJ JLKPPHLJAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private KGMCELACHEF ADDAMDDDHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private MOEMPDODMEG GGIBPNKFKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private IDisposable NMFMGBAFGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private DEBJFNCKLHK DJONJMNHDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly JBBPIGEHCDP LBLLFLKFPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private LJPNEKMEFMK JPFHOEDOPEL;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TaskStatus KLMMKDPNGFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x98D4D0", Offset = "0x98C8D0", VA = "0x18098D4D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x116FD00", Offset = "0x116F100", VA = "0x18116FD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private MONKCCHOMPK GPMOAHABAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D865B0", Offset = "0x7D859B0", VA = "0x187D865B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7D86F20", Offset = "0x7D86320", VA = "0x187D86F20", Slot = "6")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D84B60", Offset = "0x7D83F60", VA = "0x187D84B60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D85E70", Offset = "0x7D85270", VA = "0x187D85E70", Slot = "5")]
	[AsyncStateMachine(typeof(JEBNMEHNLLG))]
	public Task HAEAOMPECPB(DNHLENAINEA LEBOBKLCHDG, KMNIIEFGPKB MMFPLOFHMAF, CancellationToken IMBEMDEIDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D86600", Offset = "0x7D85A00", VA = "0x187D86600")]
	[AsyncStateMachine(typeof(NLEJAOAFHPM))]
	private Task LMNJEHLBCKP(DNHLENAINEA LEBOBKLCHDG, KMNIIEFGPKB MMFPLOFHMAF, CancellationToken IMBEMDEIDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7D869D0", Offset = "0x7D85DD0", VA = "0x187D869D0")]
	private void MNLNCJLCEND(KGMCELACHEF ADDAMDDDHKN, DNHLENAINEA LEBOBKLCHDG, Exception BOKONMFPKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D84F20", Offset = "0x7D84320", VA = "0x187D84F20")]
	private static void FDDFFCAFOJG(PLPALFJAGFP FCCGAKAMBHJ, Exception BOKONMFPKMC, [Optional] List<int> FEDJJLOBBKC, int DGIDCCMGILP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D85AA0", Offset = "0x7D84EA0", VA = "0x187D85AA0")]
	[AsyncStateMachine(typeof(KLOGFPAPFDH))]
	private Task FNDMFPEBGMI(PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, DNHLENAINEA LEBOBKLCHDG, KMNIIEFGPKB MMFPLOFHMAF, MMCELPKDDOJ CNGHJNMANGK, CancellationToken IMBEMDEIDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D86850", Offset = "0x7D85C50", VA = "0x187D86850")]
	private void MKBOMPPJAAP([CallerMemberName] string DMDKOMNCCNP = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D85D40", Offset = "0x7D85140", VA = "0x187D85D40")]
	[AsyncStateMachine(typeof(JODDEBMMNIA))]
	private Task GBJBKFHODIN(PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D84660", Offset = "0x7D83A60", VA = "0x187D84660")]
	private void BOEMJGIJBFP(DNHLENAINEA LEBOBKLCHDG, CancellationToken IMBEMDEIDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D84400", Offset = "0x7D83800", VA = "0x187D84400")]
	private void BIPBGAJJAEL(DNHLENAINEA LEBOBKLCHDG, TaskStatus PBNNAALDLIJ, string LPIFIOEEOGF, MMCELPKDDOJ CNGHJNMANGK, Exception HKMMACEDFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7D84D90", Offset = "0x7D84190", VA = "0x187D84D90")]
	private void EGBGOLBGGLH(DNHLENAINEA LEBOBKLCHDG, MMCELPKDDOJ CNGHJNMANGK, OperationCanceledException OCNAMBGOMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D86E40", Offset = "0x7D86240", VA = "0x187D86E40")]
	private void MPDJKMADDGH(DNHLENAINEA LEBOBKLCHDG, MMCELPKDDOJ CNGHJNMANGK, Exception BOKONMFPKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D84160", Offset = "0x7D83560", VA = "0x187D84160")]
	private void BAHLCDBGKMJ(DNHLENAINEA LEBOBKLCHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D86EC0", Offset = "0x7D862C0", VA = "0x187D86EC0")]
	private static AFOKKDBKELL NBMPLMEOJBD(DNHLENAINEA LEBOBKLCHDG)
	{
		return default(AFOKKDBKELL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D859D0", Offset = "0x7D84DD0", VA = "0x187D859D0")]
	[AsyncStateMachine(typeof(LJHPBIIBIOH))]
	private Task FKDKOBLOBME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D85FB0", Offset = "0x7D853B0", VA = "0x187D85FB0")]
	[AsyncStateMachine(typeof(BJBMIKCHHIA))]
	private Task<Matchmaking.PLKGDPOLBAB> HEDLJEFEFEM(DNHLENAINEA LEBOBKLCHDG, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D84990", Offset = "0x7D83D90", VA = "0x187D84990")]
	private static NHEIDIOHEIE CCIEHDJAMPN(Matchmaking.PLKGDPOLBAB DJNBMANNCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D84C40", Offset = "0x7D84040", VA = "0x187D84C40")]
	[AsyncStateMachine(typeof(IDKBEPCFMNA))]
	private Task EBKGICONHDF(Matchmaking.PLKGDPOLBAB DJNBMANNCHL, MMCELPKDDOJ CNGHJNMANGK, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken LCHOPNFEEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C00", Offset = "0x7D85000", VA = "0x187D85C00")]
	[AsyncStateMachine(typeof(BBDIJBPOEPJ))]
	private Task FOGKEBMIPBF(DNHLENAINEA LEBOBKLCHDG, CancellationTokenSource BOADJODGJAJ, Task BNFLAIPIPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D87480", Offset = "0x7D86880", VA = "0x187D87480")]
	[AsyncStateMachine(typeof(KHGLILBOAHA))]
	private Task PPANDFFJIKP(LDGKNLKOAHN MFJCNLDOCMA, IIPINPOLBCP BBHPHMEEOGB, DNHLENAINEA MDKMBLLEBPC, MMCELPKDDOJ HEBCPCMACMI, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken KHDOFHIMBPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D83F70", Offset = "0x7D83370", VA = "0x187D83F70")]
	private MMCELPKDDOJ AFBAHEHIAJM(MMCELPKDDOJ HEBCPCMACMI, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D86240", Offset = "0x7D85640", VA = "0x187D86240")]
	[AsyncStateMachine(typeof(MNEPGNHODIH))]
	private Task IHFCIKPEGCM(PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D86110", Offset = "0x7D85510", VA = "0x187D86110")]
	[AsyncStateMachine(typeof(BOMJEANJGMP))]
	private Task HGMDCKBCMFE(CancellationToken MLAPMBKLAOF, int CBJKLCMKNMO, DFFCINOLDEH BFPFCMDBGML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D85850", Offset = "0x7D84C50", VA = "0x187D85850")]
	private static void FJJHGMMKMPJ(DNHLENAINEA LEBOBKLCHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D86380", Offset = "0x7D85780", VA = "0x187D86380")]
	private void IJFKLLOBPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D84370", Offset = "0x7D83770", VA = "0x187D84370")]
	private void BAOEIAGHNKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D87240", Offset = "0x7D86640", VA = "0x187D87240")]
	private void OGBPGPNHKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D84BB0", Offset = "0x7D83FB0", VA = "0x187D84BB0")]
	private void EBILAHLPHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7D85760", Offset = "0x7D84B60", VA = "0x187D85760")]
	private static void FGIBIDBCKPF(DNHLENAINEA LEBOBKLCHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D84E10", Offset = "0x7D84210", VA = "0x187D84E10")]
	private static CancellationTokenRegistration EKBDNAPLMLE(DNHLENAINEA LEBOBKLCHDG, CancellationToken LCHOPNFEEBJ)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D86750", Offset = "0x7D85B50", VA = "0x187D86750")]
	private static void MADGFPILHLE(DNHLENAINEA LEBOBKLCHDG, Exception BOKONMFPKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D872D0", Offset = "0x7D866D0", VA = "0x187D872D0")]
	private void OPOAMNPEEGO(DNHLENAINEA LEBOBKLCHDG, Task BNFLAIPIPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7D84AA0", Offset = "0x7D83EA0", VA = "0x187D84AA0")]
	private static void COHAOGFFGHO(Func<string> DOICNOOOHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7D877F0", Offset = "0x7D86BF0", VA = "0x187D877F0")]
	public LJHMMELPGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D84B00", Offset = "0x7D83F00", VA = "0x187D84B00")]
	[CompilerGenerated]
	internal static (int, int?) DKHKEIOFIGJ(BEGGOOEAECN AOFMJKALGDK)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[RecRoom.NoEngine.Common.Preserve]
internal class FBONEANOJEO : JAMCMMKGBKP, ILPCOFODDNC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct MCLACIACOHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public FBONEANOJEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public DFFCINOLDEH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x7DAAF70", Offset = "0x7DAA370", VA = "0x187DAAF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB450", Offset = "0x7DAA850", VA = "0x187DAB450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class IPKAGBIJGFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public FBONEANOJEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public DFFCINOLDEH localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public IPKAGBIJGFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x7DA67F0", Offset = "0x7DA5BF0", VA = "0x187DA67F0")]
		internal List<Task> PAFPKGHLBAJ(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct INECHMCDDLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public ILOKGPLFKED taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public DFFCINOLDEH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5DF0", Offset = "0x7DA51F0", VA = "0x187DA5DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6190", Offset = "0x7DA5590", VA = "0x187DA6190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct CKLFMJENLPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public FBONEANOJEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7D99C40", Offset = "0x7D99040", VA = "0x187D99C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7D99F20", Offset = "0x7D99320", VA = "0x187D99F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly HashSet<ILOKGPLFKED> PAFJNCBAMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private IFIEBAFBCGE JKEPHCDLNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private JBDMCPFFKFC KAGKCLLOLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private BFLGPEHGOLO KEGEBMLGEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private IDisposable NMFMGBAFGHL;

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1580", Offset = "0x7DA0980", VA = "0x187DA1580", Slot = "5")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1060", Offset = "0x7DA0460", VA = "0x187DA1060", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1230", Offset = "0x7DA0630", VA = "0x187DA1230", Slot = "4")]
	public bool IHKGFEHMIBL(ILOKGPLFKED NHBOECKMNMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7DA08D0", Offset = "0x7D9FCD0", VA = "0x187DA08D0")]
	private void ADJMIIPHIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1290", Offset = "0x7DA0690", VA = "0x187DA1290")]
	private void JKJHEMELDON(DOFGKDAOBGJ EDHFGAMFCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7DA10C0", Offset = "0x7DA04C0", VA = "0x187DA10C0")]
	[AsyncStateMachine(typeof(MCLACIACOHP))]
	private Task ENBGPHCKOHD(int CBJKLCMKNMO, DFFCINOLDEH BFPFCMDBGML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7DA14B0", Offset = "0x7DA08B0", VA = "0x187DA14B0")]
	private Func<CancellationToken, List<Task>> KPKANPFGAHE(int CBJKLCMKNMO, DFFCINOLDEH BFPFCMDBGML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7DA0B90", Offset = "0x7D9FF90", VA = "0x187DA0B90")]
	private List<Task> DOLGDJALKGJ(int CBJKLCMKNMO, DFFCINOLDEH BFPFCMDBGML, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7DA0A70", Offset = "0x7D9FE70", VA = "0x187DA0A70")]
	[AsyncStateMachine(typeof(INECHMCDDLC))]
	private Task DMHCGCFCBLJ(ILOKGPLFKED KJCHANDKGBO, CancellationToken OCDOGNMJENC, int CBJKLCMKNMO, DFFCINOLDEH BFPFCMDBGML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7DA09A0", Offset = "0x7D9FDA0", VA = "0x187DA09A0")]
	[AsyncStateMachine(typeof(CKLFMJENLPJ))]
	private Task DHLGMOKDLFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7DA11B0", Offset = "0x7DA05B0", VA = "0x187DA11B0")]
	private void FGPIGKDDHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1860", Offset = "0x7DA0C60", VA = "0x187DA1860")]
	public FBONEANOJEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[UnityEngine.Scripting.Preserve]
internal sealed class EPJPMHAOHCP : CAPOKDEDNLL, ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class NJIGIKOLGCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public NJIGIKOLGCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE790", Offset = "0x7DADB90", VA = "0x187DAE790")]
		internal object FGHJLBGBDBD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class KCCPFNIFKMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public KCCPFNIFKMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8E50", Offset = "0x7DA8250", VA = "0x187DA8E50")]
		internal object DFFOPFIKLCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class MMOIDEPOKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MMOIDEPOKCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class DEDGHEBNJAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public DEDGHEBNJAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C3B0", Offset = "0x7D9B7B0", VA = "0x187D9C3B0")]
		internal object FGCLFFAMMNH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class IEHNLEAGGCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public IEHNLEAGGCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5D90", Offset = "0x7DA5190", VA = "0x187DA5D90")]
		internal object DCLOPADDNHH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private readonly Dictionary<Guid, POEMFDHFMBM> DNGFBNEHOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private readonly TimeSpan MEDMELPNBCK;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "9")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7D9FF50", Offset = "0x7D9F350", VA = "0x187D9FF50", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7DA0140", Offset = "0x7D9F540", VA = "0x187DA0140", Slot = "4")]
	public GBPMNAIFOAH KAAHFJDOOLK(Guid PPLJPJJDEGE)
	{
		return default(GBPMNAIFOAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7DA0600", Offset = "0x7D9FA00", VA = "0x187DA0600", Slot = "5")]
	public bool PBIACPFCCPC(Guid PPLJPJJDEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7D9FC20", Offset = "0x7D9F020", VA = "0x187D9FC20", Slot = "6")]
	public bool BHKPJJAJBKB(Guid PPLJPJJDEGE, Task EKBLHMHCAJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7D9FF60", Offset = "0x7D9F360", VA = "0x187D9FF60", Slot = "7")]
	public bool JKAMFIGJODH(Guid PPLJPJJDEGE, MLDDIEDIFAF GOHJIBCDDFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7DA0590", Offset = "0x7D9F990", VA = "0x187DA0590", Slot = "8")]
	public Task<(MLDDIEDIFAF, Task)> LPPKDBBOHIM(Guid PPLJPJJDEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7DA0360", Offset = "0x7D9F760", VA = "0x187DA0360")]
	private void LEDNOHOAPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7DA0810", Offset = "0x7D9FC10", VA = "0x187DA0810")]
	public EPJPMHAOHCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[RecRoom.NoEngine.Common.Preserve]
internal class BGEFGIPCLJL : HFDDGLJDMII, ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class JOONNBAJCNC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private readonly DNHLENAINEA NHOPDPDCHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private readonly CancellationTokenSource GBICCIOOCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public readonly CancellationToken FIOEPLBHCNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private bool BLGLNCKGOKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private bool JBOKBJOADDP;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA87D0", Offset = "0x7DA7BD0", VA = "0x187DA87D0")]
		public JOONNBAJCNC(DNHLENAINEA NHOPDPDCHLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8680", Offset = "0x7DA7A80", VA = "0x187DA8680")]
		public void FGPIGKDDHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8650", Offset = "0x7DA7A50", VA = "0x187DA8650", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class OGEAHFDHAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public CBKEDKEAGIE disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OGEAHFDHAKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x7DB05F0", Offset = "0x7DAF9F0", VA = "0x187DB05F0")]
		internal object ANMLIEPNIJF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private struct OBNEEIHAMCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public CBKEDKEAGIE disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public BGEFGIPCLJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0140", Offset = "0x7DAF540", VA = "0x187DB0140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0590", Offset = "0x7DAF990", VA = "0x187DB0590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class OOLDNJIJHAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public BGEFGIPCLJL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OOLDNJIJHAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0680", Offset = "0x7DAFA80", VA = "0x187DB0680")]
		internal object DCBLPILBKAM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class DMGMPGDBMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public DNHLENAINEA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public OOLDNJIJHAF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public DMGMPGDBMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C770", Offset = "0x7D9BB70", VA = "0x187D9C770")]
		internal object DKGFNKDHHBK((DNHLENAINEA lastLocalPlayerRoomInstance, DNHLENAINEA newRoomInstance, EBPALNPDLNI fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct CJEGACPMAFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public BGEFGIPCLJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private CPNFFAJCLON <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x7D98510", Offset = "0x7D97910", VA = "0x187D98510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class LBFBIKAANJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public DNHLENAINEA newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LBFBIKAANJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x7DA9EE0", Offset = "0x7DA92E0", VA = "0x187DA9EE0")]
		internal object FENFPKBBCMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7DAA000", Offset = "0x7DA9400", VA = "0x187DAA000")]
		internal void OMDKKEEKCID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7DA9FC0", Offset = "0x7DA93C0", VA = "0x187DA9FC0")]
		internal object NGELNIJFDIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x7DA9F80", Offset = "0x7DA9380", VA = "0x187DA9F80")]
		internal object GKDOJJIGNEI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct OBENGPKLMBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public DNHLENAINEA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public BGEFGIPCLJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public KMNIIEFGPKB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private LBFBIKAANJJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF130", Offset = "0x7DAE530", VA = "0x187DAF130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x7DB00E0", Offset = "0x7DAF4E0", VA = "0x187DB00E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly HBFPDADEGME.INFALKINHAI NAJCKGKCBFD;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly BNOKINAHBNJ OBMDLIHDJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private IFIEBAFBCGE JKEPHCDLNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private EBPALNPDLNI MILPPPKHFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private LAGOIFMOJDA DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private HGBLLPJJCBJ FLKLAANBPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private MDGIPPAFIND IFOOBBNHHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private DNHLENAINEA ANLBDOKIFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private JOONNBAJCNC GPMKMPIDEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private bool FICHJBJPOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private Task POBFAPOGGIF;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private MONKCCHOMPK GPMOAHABAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7D967E0", Offset = "0x7D95BE0", VA = "0x187D967E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool CLAAJDPPIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69C00", VA = "0x180B6A800")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7D967D0", Offset = "0x7D95BD0", VA = "0x187D967D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7D96B50", Offset = "0x7D95F50", VA = "0x187D96B50", Slot = "4")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7D96030", Offset = "0x7D95430", VA = "0x187D96030", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x7D966E0", Offset = "0x7D95AE0", VA = "0x187D966E0")]
	[AsyncStateMachine(typeof(OBNEEIHAMCA))]
	private Task IIDEBDDNFAD(CBKEDKEAGIE JJHBCGMOFJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7D96430", Offset = "0x7D95830", VA = "0x187D96430")]
	private void GBCCPLLOOOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7D961A0", Offset = "0x7D955A0", VA = "0x187D961A0")]
	private void EHGHJKJEPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7D969D0", Offset = "0x7D95DD0", VA = "0x187D969D0")]
	private void MJFAHMBNBCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7D96830", Offset = "0x7D95C30", VA = "0x187D96830")]
	private bool LEHENILPNIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7D96610", Offset = "0x7D95A10", VA = "0x187D96610")]
	[AsyncStateMachine(typeof(CJEGACPMAFH))]
	private void HECGODPBDMK(int FDLLGPFCFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7D95DA0", Offset = "0x7D951A0", VA = "0x187D95DA0")]
	private void DDAKPFFEBLL([Out] IDisposable JNDLFJGBNCJ, [Out] IDisposable EDNINMJGOJL, [Out] IDisposable BBKAEPAAJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7D96330", Offset = "0x7D95730", VA = "0x187D96330")]
	private bool FJFAKMHJMPG(DNHLENAINEA NHOPDPDCHLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7D965C0", Offset = "0x7D959C0", VA = "0x187D965C0")]
	private void HDDLGPKCLFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7D968A0", Offset = "0x7D95CA0", VA = "0x187D968A0")]
	[AsyncStateMachine(typeof(OBENGPKLMBF))]
	private Task LMNJEHLBCKP(DNHLENAINEA NHOPDPDCHLM, KMNIIEFGPKB MMFPLOFHMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7D97180", Offset = "0x7D96580", VA = "0x187D97180")]
	public BGEFGIPCLJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[UnityEngine.Scripting.Preserve]
internal sealed class DEBOGNGEEJK : DBJBBMPJJDE, ILPCOFODDNC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct DGFDOMHMJBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public AsyncTaskMethodBuilder<AAALDGKDLBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public DEBOGNGEEJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private TaskAwaiter<AAALDGKDLBO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C470", Offset = "0x7D9B870", VA = "0x187D9C470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C700", Offset = "0x7D9BB00", VA = "0x187D9C700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class DEMIMILAJOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public MGPKNNLHNMP message;

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public DEMIMILAJOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C410", Offset = "0x7D9B810", VA = "0x187D9C410")]
		internal object GJJEGNEALIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class KNJNCFEEBCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public MGPKNNLHNMP messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public KNJNCFEEBCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7DA9740", Offset = "0x7DA8B40", VA = "0x187DA9740")]
		internal object OHDAPDODKKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class EIEKEHHALEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public MGPKNNLHNMP request;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public EIEKEHHALEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D140", Offset = "0x7D9C540", VA = "0x187D9D140")]
		internal object AGBKEMGPMIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct JHJJHACGFMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public MGPKNNLHNMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public DEBOGNGEEJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private TaskAwaiter<GIELBPOLHAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6830", Offset = "0x7DA5C30", VA = "0x187DA6830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7100", Offset = "0x7DA6500", VA = "0x187DA7100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class ANGOADNOHEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public MGPKNNLHNMP operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public ANGOADNOHEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7D94940", Offset = "0x7D93D40", VA = "0x187D94940")]
		internal object IJIBANOOMPC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct ALDJKIJBADK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public MGPKNNLHNMP operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public DEBOGNGEEJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private MMCELPKDDOJ <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private TaskAwaiter<MGPKNNLHNMP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7D936D0", Offset = "0x7D92AD0", VA = "0x187D936D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7D94240", Offset = "0x7D93640", VA = "0x187D94240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct INOAJLGMBNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public AsyncTaskMethodBuilder<GIELBPOLHAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public DEBOGNGEEJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public MGPKNNLHNMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private BJIHCLIBNDJ.HEBHEJDHELL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private MMCELPKDDOJ <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private TaskAwaiter<MGPKNNLHNMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6250", Offset = "0x7DA5650", VA = "0x187DA6250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6780", Offset = "0x7DA5B80", VA = "0x187DA6780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class ACHOBCMDOFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public GIELBPOLHAF operation;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public ACHOBCMDOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7D927E0", Offset = "0x7D91BE0", VA = "0x187D927E0")]
		internal object IILBKBKGKOH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct ALMBMFJJKPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public GIELBPOLHAF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public DEBOGNGEEJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private PGLLJHOKMII<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7D942A0", Offset = "0x7D936A0", VA = "0x187D942A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x7D948E0", Offset = "0x7D93CE0", VA = "0x187D948E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class HLHLJCFIPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public MGPKNNLHNMP request;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HLHLJCFIPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4920", Offset = "0x7DA3D20", VA = "0x187DA4920")]
		internal object NDPJJNIAIOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class MAODFLKELFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public MGPKNNLHNMP request;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MAODFLKELFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x7DAAEA0", Offset = "0x7DAA2A0", VA = "0x187DAAEA0")]
		internal object LGHNOPGCCEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private MJPICOFJBDP EOFAPPEKOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private JFNFGLFDAJH PGCEFHJHKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private CHDBFKKIGJL KDKFFDOJCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private HHMOMAGJIPE BCLILIMLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private TaskCompletionSource<AAALDGKDLBO> LELHCEOOMBM;

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7D9BE50", Offset = "0x7D9B250", VA = "0x187D9BE50", Slot = "7")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7D9BF40", Offset = "0x7D9B340", VA = "0x187D9BF40", Slot = "6")]
	[AsyncStateMachine(typeof(DGFDOMHMJBC))]
	public Task<AAALDGKDLBO> OBPOEHGNFDP(CancellationToken OKIPOOADPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B000", Offset = "0x7D9A400", VA = "0x187D9B000", Slot = "4")]
	public void BKCAKFALIIP(MGPKNNLHNMP LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7D9C050", Offset = "0x7D9B450", VA = "0x187D9C050", Slot = "5")]
	public void PNDIHKIHECA(MGPKNNLHNMP MJONEIBJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B4B0", Offset = "0x7D9A8B0", VA = "0x187D9B4B0")]
	[AsyncStateMachine(typeof(JHJJHACGFMI))]
	private Task FLEBCMGODPO(MGPKNNLHNMP NKKKCKHLGCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7D9BD40", Offset = "0x7D9B140", VA = "0x187D9BD40")]
	[AsyncStateMachine(typeof(ALDJKIJBADK))]
	private Task MIONPIAJCJA(MGPKNNLHNMP LODBHOOINJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B5C0", Offset = "0x7D9A9C0", VA = "0x187D9B5C0")]
	[AsyncStateMachine(typeof(INOAJLGMBNO))]
	private Task<GIELBPOLHAF> HAJABMHAIMJ(MGPKNNLHNMP NKKKCKHLGCJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B710", Offset = "0x7D9AB10", VA = "0x187D9B710")]
	private MMCELPKDDOJ HLMFAAONFEG(MGPKNNLHNMP DMNJLKMHCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B390", Offset = "0x7D9A790", VA = "0x187D9B390")]
	[AsyncStateMachine(typeof(ALMBMFJJKPH))]
	private Task EDHBOAMMNOF(GIELBPOLHAF IFKMLHMDOLM, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7D9BB30", Offset = "0x7D9AF30", VA = "0x187D9BB30")]
	private GIELBPOLHAF KNAAGJGCONB(MGPKNNLHNMP NKKKCKHLGCJ, MMCELPKDDOJ ELPNJEJBOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x32CBCE0", Offset = "0x32CB0E0", VA = "0x1832CBCE0")]
	private T JOCLDBJIJBC<T>(T PEBNJNGMMHE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B7A0", Offset = "0x7D9ABA0", VA = "0x187D9B7A0")]
	private GIELBPOLHAF JJPKLPGGGBN(MGPKNNLHNMP NKKKCKHLGCJ, MMCELPKDDOJ ELPNJEJBOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public DEBOGNGEEJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[UnityEngine.Scripting.Preserve]
internal sealed class ENCLHFDOAKH : JFNFGLFDAJH, ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class BDCIHALMPGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public BDCIHALMPGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7D95D30", Offset = "0x7D95130", VA = "0x187D95D30")]
		internal object GFGHLMDADGP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class MEMKDOLDLHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MEMKDOLDLHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB4B0", Offset = "0x7DAA8B0", VA = "0x187DAB4B0")]
		internal object MPOKPHPJFIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private HHMOMAGJIPE BCLILIMLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private GCHCIBOABFC EMMFNJHAEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private DBJBBMPJJDE NLNKDDIICDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private CAPOKDEDNLL DNGFBNEHOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private AMAGBMICKBJ BBHPKCGEOMD;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7D9F410", Offset = "0x7D9E810", VA = "0x187D9F410", Slot = "6")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DF90", Offset = "0x7D9D390", VA = "0x187D9DF90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7D9F800", Offset = "0x7D9EC00", VA = "0x187D9F800", Slot = "4")]
	public GBPMNAIFOAH PBKFHADNOCN(MGPKNNLHNMP JOOGKIIDCPN)
	{
		return default(GBPMNAIFOAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E040", Offset = "0x7D9D440", VA = "0x187D9E040", Slot = "5")]
	public void ECMCFECPBKI(Guid PPLJPJJDEGE, Task EKBLHMHCAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E710", Offset = "0x7D9DB10", VA = "0x187D9E710")]
	private void JOKOAJDFCGE(byte FPINDDDPMFJ, int DODLNPKMBHK, object FDLMNFADLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E9F0", Offset = "0x7D9DDF0", VA = "0x187D9E9F0")]
	private void LFHBOEHIMFH(DAIEIGCJIEC CDDCIHICHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E250", Offset = "0x7D9D650", VA = "0x187D9E250")]
	private void FIIKOAPEJGM(DAIEIGCJIEC CDDCIHICHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E4D0", Offset = "0x7D9D8D0", VA = "0x187D9E4D0")]
	private void GOEDBCJKJMA(DAIEIGCJIEC CDDCIHICHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7D9EF70", Offset = "0x7D9E370", VA = "0x187D9EF70")]
	private MLDDIEDIFAF LFMHLICJABM(MGPKNNLHNMP DMNJLKMHCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7D9F210", Offset = "0x7D9E610", VA = "0x187D9F210")]
	private void MGGDBGNCCFC(MGPKNNLHNMP LODBHOOINJD, MLDDIEDIFAF GOHJIBCDDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DDB0", Offset = "0x7D9D1B0", VA = "0x187D9DDB0")]
	private bool DNOKEDAMHKO(MGPKNNLHNMP LODBHOOINJD, MLDDIEDIFAF GOHJIBCDDFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E7E0", Offset = "0x7D9DBE0", VA = "0x187D9E7E0")]
	private bool LDJMMDLJLND(MGPKNNLHNMP MELPFCNKPNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7D9F580", Offset = "0x7D9E980", VA = "0x187D9F580")]
	private bool OOLHKCBBHNA(byte FPINDDDPMFJ, ExitGames.Client.Photon.Hashtable CDDCIHICHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public ENCLHFDOAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class EKEIBFOHFPG : KJAHCINMHID, ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class JMLDHPECBOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AAALDGKDLBO operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public EKEIBFOHFPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public MGPKNNLHNMP roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JMLDHPECBOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7970", Offset = "0x7DA6D70", VA = "0x187DA7970")]
		internal object MJGLCFCCIPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7DA79E0", Offset = "0x7DA6DE0", VA = "0x187DA79E0")]
		internal object NFEEGGPGBCA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct MIKGMGINEIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AsyncTaskMethodBuilder<MLDDIEDIFAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public EKEIBFOHFPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public MGPKNNLHNMP roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private TaskAwaiter<MLDDIEDIFAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB670", Offset = "0x7DAAA70", VA = "0x187DAB670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7DABD10", Offset = "0x7DAB110", VA = "0x187DABD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class MCIFCHOFDOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AAALDGKDLBO operationType;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MCIFCHOFDOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7DAAF00", Offset = "0x7DAA300", VA = "0x187DAAF00")]
		internal object MHKCNLBHICE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class MFNLOBMPMFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public MGPKNNLHNMP request;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MFNLOBMPMFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB600", Offset = "0x7DAAA00", VA = "0x187DAB600")]
		internal object MFMMADOJDNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB520", Offset = "0x7DAA920", VA = "0x187DAB520")]
		internal object BPALPJLJIHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB590", Offset = "0x7DAA990", VA = "0x187DAB590")]
		internal object FLIAJKJAKKM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct NNJHNHBOGHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public AsyncTaskMethodBuilder<MLDDIEDIFAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public MGPKNNLHNMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public EKEIBFOHFPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private MFNLOBMPMFB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private GBPMNAIFOAH <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private MLDDIEDIFAF <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TaskAwaiter<(MLDDIEDIFAF validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE7F0", Offset = "0x7DADBF0", VA = "0x187DAE7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF0C0", Offset = "0x7DAE4C0", VA = "0x187DAF0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private HHMOMAGJIPE BCLILIMLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private GCHCIBOABFC EMMFNJHAEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private JFNFGLFDAJH PGCEFHJHKBM;

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D5F0", Offset = "0x7D9C9F0", VA = "0x187D9D5F0", Slot = "5")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D1A0", Offset = "0x7D9C5A0", VA = "0x187D9D1A0", Slot = "4")]
	[AsyncStateMachine(typeof(MIKGMGINEIH))]
	private Task<MLDDIEDIFAF> BKNICDBHPEP(MGPKNNLHNMP DMNJLKMHCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D2C0", Offset = "0x7D9C6C0", VA = "0x187D9D2C0")]
	private bool EFOKDFHOBIF(AAALDGKDLBO PCPPMGPAHKO, [Out] MLDDIEDIFAF HOCIBOCHCFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D4B0", Offset = "0x7D9C8B0", VA = "0x187D9D4B0")]
	[AsyncStateMachine(typeof(NNJHNHBOGHF))]
	private Task<MLDDIEDIFAF> IDPGOFAGJCA(MGPKNNLHNMP NKKKCKHLGCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public EKEIBFOHFPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class DNEFPEFHKDL : GMNIJCAFBOL, ILPCOFODDNC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct MOEFNJHONJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public AsyncTaskMethodBuilder<LDGKNLKOAHN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public DNEFPEFHKDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private TaskAwaiter<FGPODGGHBLK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter<LDGKNLKOAHN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE150", Offset = "0x7DAD550", VA = "0x187DAE150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE720", Offset = "0x7DADB20", VA = "0x187DAE720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class HGLNEAJFDCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HGLNEAJFDCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4870", Offset = "0x7DA3C70", VA = "0x187DA4870")]
		internal object NHEPLJCPHKJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct MLCCHBCOAIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public AsyncTaskMethodBuilder<FGPODGGHBLK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public DNEFPEFHKDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private HGLNEAJFDCB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter<FGPODGGHBLK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7DABD80", Offset = "0x7DAB180", VA = "0x187DABD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC370", Offset = "0x7DAB770", VA = "0x187DAC370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct MMOPLGJPABE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public AsyncTaskMethodBuilder<LDGKNLKOAHN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public DNEFPEFHKDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public FGPODGGHBLK roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private TaskAwaiter<(LOFGJIDOAFO superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC3E0", Offset = "0x7DAB7E0", VA = "0x187DAC3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC8A0", Offset = "0x7DABCA0", VA = "0x187DAC8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class PNAKMGKBNIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public PNAKMGKBNIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xD50E80", Offset = "0xD50280", VA = "0x180D50E80")]
		internal bool DDBGIMLFEBD(PNGEIJCJKOB sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct EMKHPLDMNPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public AsyncTaskMethodBuilder<(LOFGJIDOAFO superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public FGPODGGHBLK roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public DNEFPEFHKDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public DNHLENAINEA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private TaskAwaiter<(LOFGJIDOAFO superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D6A0", Offset = "0x7D9CAA0", VA = "0x187D9D6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DD40", Offset = "0x7D9D140", VA = "0x187D9DD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class LHEDIMIPOJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LHEDIMIPOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x7DAA700", Offset = "0x7DA9B00", VA = "0x187DAA700")]
		internal object EIFLHKIEBON()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct APLMFALOBPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AsyncTaskMethodBuilder<(LOFGJIDOAFO superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public PNGEIJCJKOB subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public DNEFPEFHKDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public DNHLENAINEA dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private LHEDIMIPOJD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter<CBLOAIMJMAA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7D949A0", Offset = "0x7D93DA0", VA = "0x187D949A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7D950D0", Offset = "0x7D944D0", VA = "0x187D950D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private static readonly (LOFGJIDOAFO superRoomData, long subRoomDataSaveId) GGBPHBMFAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private LAGOIFMOJDA DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private ECLAECFMLGO GICPMFNJKEJ;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7D9CDE0", Offset = "0x7D9C1E0", VA = "0x187D9CDE0", Slot = "5")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7D9CE70", Offset = "0x7D9C270", VA = "0x187D9CE70", Slot = "4")]
	[AsyncStateMachine(typeof(MOEFNJHONJM))]
	public Task<LDGKNLKOAHN> PNBPLGOJBDB(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, DNHLENAINEA LEBOBKLCHDG, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D9C9A0", Offset = "0x7D9BDA0", VA = "0x187D9C9A0")]
	[AsyncStateMachine(typeof(MLCCHBCOAIF))]
	private Task<FGPODGGHBLK> FKJDBDGFNDK(DNHLENAINEA LEBOBKLCHDG, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7D9CC70", Offset = "0x7D9C070", VA = "0x187D9CC70")]
	[AsyncStateMachine(typeof(MMOPLGJPABE))]
	private Task<LDGKNLKOAHN> MHGJFMINBNP(DNHLENAINEA LEBOBKLCHDG, FGPODGGHBLK BMCIAEPHBNG, long FHAJBLMHDGD, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D9C830", Offset = "0x7D9BC30", VA = "0x187D9C830")]
	[AsyncStateMachine(typeof(EMKHPLDMNPJ))]
	private Task<(LOFGJIDOAFO, long)> DEFHOHDJDOB(DNHLENAINEA LEBOBKLCHDG, FGPODGGHBLK BMCIAEPHBNG, long FHAJBLMHDGD, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D9CB00", Offset = "0x7D9BF00", VA = "0x187D9CB00")]
	[AsyncStateMachine(typeof(APLMFALOBPK))]
	private Task<(LOFGJIDOAFO, long)> GIMNGBDOGDL(DNHLENAINEA HILGOJAKJEA, PNGEIJCJKOB FKCMGHGNCOF, long FHAJBLMHDGD, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public DNEFPEFHKDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[UnityEngine.Scripting.Preserve]
internal sealed class KNLBHJHOPDF : CHDBFKKIGJL, ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class CMGNGAKNGJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public MGPKNNLHNMP request;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public CMGNGAKNGJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7D99F80", Offset = "0x7D99380", VA = "0x187D99F80")]
		internal object ODPPLIMOABD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct LEBLOBHBDDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public AsyncTaskMethodBuilder<MGPKNNLHNMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public MGPKNNLHNMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public KNLBHJHOPDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public MMCELPKDDOJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private TaskAwaiter<MGPKNNLHNMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DAA080", Offset = "0x7DA9480", VA = "0x187DAA080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7DAA690", Offset = "0x7DA9A90", VA = "0x187DAA690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct HDDJGKAAMKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public AsyncTaskMethodBuilder<MGPKNNLHNMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public KNLBHJHOPDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public MMCELPKDDOJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private TaskAwaiter<OONCOJCHBKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4210", Offset = "0x7DA3610", VA = "0x187DA4210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4800", Offset = "0x7DA3C00", VA = "0x187DA4800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class INHPGGIOOKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public MGPKNNLHNMP request;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public INHPGGIOOKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7DA61F0", Offset = "0x7DA55F0", VA = "0x187DA61F0")]
		internal object JILJEGFFPFI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct GCGDKDMIOGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public AsyncTaskMethodBuilder<MGPKNNLHNMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public MGPKNNLHNMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public KNLBHJHOPDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public MMCELPKDDOJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private CLAEHKNMMJA <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private NNCCCELBFED <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter<OONCOJCHBKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2A00", Offset = "0x7DA1E00", VA = "0x187DA2A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7DA35F0", Offset = "0x7DA29F0", VA = "0x187DA35F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private HHMOMAGJIPE BCLILIMLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private JENEEEIDFIJ LHEAIIPNGFE;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private IGKLHNCIHKG BNBJKCHDDID
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7DA9C30", Offset = "0x7DA9030", VA = "0x187DA9C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7DA9CF0", Offset = "0x7DA90F0", VA = "0x187DA9CF0", Slot = "8")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x7DA9AD0", Offset = "0x7DA8ED0", VA = "0x187DA9AD0", Slot = "4")]
	[AsyncStateMachine(typeof(LEBLOBHBDDF))]
	public Task<MGPKNNLHNMP> KALKGLDCNDH(MGPKNNLHNMP NKKKCKHLGCJ, MMCELPKDDOJ ELPNJEJBOMD, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7DA9980", Offset = "0x7DA8D80", VA = "0x187DA9980", Slot = "5")]
	[AsyncStateMachine(typeof(HDDJGKAAMKJ))]
	public Task<MGPKNNLHNMP> IGCAPIFFFEK(CancellationToken MLAPMBKLAOF, MMCELPKDDOJ ELPNJEJBOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7DA98D0", Offset = "0x7DA8CD0", VA = "0x187DA98D0", Slot = "6")]
	public OJEJNDLACBE HDDCCHPLKDL(GIELBPOLHAF NMJONAJJMMC, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7DA97A0", Offset = "0x7DA8BA0", VA = "0x187DA97A0", Slot = "7")]
	public OJEJNDLACBE FPKHNFDKGNI(GIELBPOLHAF NMJONAJJMMC, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7DA9D80", Offset = "0x7DA9180", VA = "0x187DA9D80")]
	[AsyncStateMachine(typeof(GCGDKDMIOGN))]
	private Task<MGPKNNLHNMP> OPKNEIOEPOM(MGPKNNLHNMP NKKKCKHLGCJ, MMCELPKDDOJ ELPNJEJBOMD, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x3657730", Offset = "0x3656B30", VA = "0x183657730")]
	private static byte[] LDAPALIMFCP(MGPKNNLHNMP LPIFIOEEOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public KNLBHJHOPDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[UnityEngine.Scripting.Preserve]
internal sealed class KACIOOLIKOA : GCHCIBOABFC, ILPCOFODDNC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private KDJOLJCAGCD BGLHAPHGOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private HHMOMAGJIPE BCLILIMLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private MJPICOFJBDP EOFAPPEKOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private GGCFIFHGAEB FKNAECPGFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private LAGOIFMOJDA DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private MDGIPPAFIND IFOOBBNHHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private JAMCMMKGBKP GEJNAODDPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private HGBLLPJJCBJ FLKLAANBPFM;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private MONKCCHOMPK GPMOAHABAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8A10", Offset = "0x7DA7E10", VA = "0x187DA8A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private static MLDDIEDIFAF MMNBHEMMLJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8880", Offset = "0x7DA7C80", VA = "0x187DA8880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7DA8CE0", Offset = "0x7DA80E0", VA = "0x187DA8CE0", Slot = "6")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7DA88A0", Offset = "0x7DA7CA0", VA = "0x187DA88A0", Slot = "4")]
	public MLDDIEDIFAF EPEPKPLHNEM(NOFCMGEHFOO FDNLBHLEFDI, AAALDGKDLBO OENLPLOJPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7DA8A60", Offset = "0x7DA7E60", VA = "0x187DA8A60", Slot = "5")]
	public MLDDIEDIFAF NJOKGAOIBNK(NOFCMGEHFOO GECCDAMDACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x7DA8890", Offset = "0x7DA7C90", VA = "0x187DA8890")]
	private static MLDDIEDIFAF BANJHLNBFAN(BDCDKKLDAGN BBAJBLJIPLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public KACIOOLIKOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class KLIMOALFGMO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x7DA9700", Offset = "0x7DA8B00", VA = "0x187DA9700")]
	public KLIMOALFGMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x7073FF0", Offset = "0x70733F0", VA = "0x187073FF0")]
	public KLIMOALFGMO(string LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[UnityEngine.Scripting.Preserve]
internal sealed class GBNKPLOHKNI : OLNLMBALJMH, ILPCOFODDNC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct HBBPCEFKEAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public AsyncTaskMethodBuilder<MLDDIEDIFAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public GBNKPLOHKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public HLGDIBFKEKE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private PGLLJHOKMII<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private PGLLJHOKMII<string>.GLACLJPMODI <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private DKHFOPGDMEO <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private TaskAwaiter<MLDDIEDIFAF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7DA3660", Offset = "0x7DA2A60", VA = "0x187DA3660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7DA41A0", Offset = "0x7DA35A0", VA = "0x187DA41A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct ACJNOEGGBCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public GBNKPLOHKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7D92860", Offset = "0x7D91C60", VA = "0x187D92860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7D92FA0", Offset = "0x7D923A0", VA = "0x187D92FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct BGMLHJDGKKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public GBNKPLOHKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7D971F0", Offset = "0x7D965F0", VA = "0x187D971F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7D97700", Offset = "0x7D96B00", VA = "0x187D97700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct IDJELNBJNAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public GBNKPLOHKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4F40", Offset = "0x7DA4340", VA = "0x187DA4F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5690", Offset = "0x7DA4A90", VA = "0x187DA5690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct LIOJDGDIDIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public GBNKPLOHKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7DAA7B0", Offset = "0x7DA9BB0", VA = "0x187DAA7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7DAA950", Offset = "0x7DA9D50", VA = "0x187DAA950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct DADOJGCJHEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public GBNKPLOHKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7D99FE0", Offset = "0x7D993E0", VA = "0x187D99FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A6F0", Offset = "0x7D99AF0", VA = "0x187D9A6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct AFGPBCBKBAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public GBNKPLOHKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7D93000", Offset = "0x7D92400", VA = "0x187D93000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7D93470", Offset = "0x7D92870", VA = "0x187D93470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct HNOCKKADFBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public GBNKPLOHKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public DNGFPOMMDGK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private PGLLJHOKMII<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4980", Offset = "0x7DA3D80", VA = "0x187DA4980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4EE0", Offset = "0x7DA42E0", VA = "0x187DA4EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private HHMOMAGJIPE BCLILIMLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private LAGOIFMOJDA DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private CHDBFKKIGJL KDKFFDOJCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private MJPICOFJBDP EOFAPPEKOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private JAMCMMKGBKP GEJNAODDPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private CancellationTokenSource AMOHCJLCJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private Task LOGFFMCMIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private TaskCompletionSource<int> ENKHNOAPGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private int FNLKEAJEBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private int FKOEDMEHOFO;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x7DA2650", Offset = "0x7DA1A50", VA = "0x187DA2650", Slot = "6")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x1139F80", Offset = "0x1139380", VA = "0x181139F80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1D50", Offset = "0x7DA1150", VA = "0x187DA1D50")]
	private void DLKCCBNMPFG(float MFBJNKGMEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1E30", Offset = "0x7DA1230", VA = "0x187DA1E30", Slot = "4")]
	[AsyncStateMachine(typeof(HBBPCEFKEAL))]
	public Task<MLDDIEDIFAF> JOHBALMOGEH(HLGDIBFKEKE AADNONONIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x7DA2800", Offset = "0x7DA1C00", VA = "0x187DA2800", Slot = "5")]
	[AsyncStateMachine(typeof(ACJNOEGGBCL))]
	public Task OGNDCMNMNCA([Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x1139F80", Offset = "0x1139380", VA = "0x181139F80")]
	public void MFDMKHLEILG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x7DA19F0", Offset = "0x7DA0DF0", VA = "0x187DA19F0")]
	private DKHFOPGDMEO AIOMIJGJEFM(HLGDIBFKEKE AADNONONIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7DA2560", Offset = "0x7DA1960", VA = "0x187DA2560")]
	[AsyncStateMachine(typeof(BGMLHJDGKKK))]
	private Task NGPNBJAOMEH(CancellationToken IMBEMDEIDGJ, int CBJKLCMKNMO, DFFCINOLDEH BFPFCMDBGML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1B60", Offset = "0x7DA0F60", VA = "0x187DA1B60")]
	[AsyncStateMachine(typeof(IDJELNBJNAE))]
	private Task DEGLIDNPDOC(CancellationToken IMBEMDEIDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1C60", Offset = "0x7DA1060", VA = "0x187DA1C60")]
	[AsyncStateMachine(typeof(LIOJDGDIDIE))]
	private Task DEJBABBODLA([Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1F60", Offset = "0x7DA1360", VA = "0x187DA1F60")]
	[AsyncStateMachine(typeof(DADOJGCJHEM))]
	private Task KDNMNPBJOEE(CancellationToken IMBEMDEIDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7DA22D0", Offset = "0x7DA16D0", VA = "0x187DA22D0")]
	[AsyncStateMachine(typeof(AFGPBCBKBAA))]
	private Task MLEDJPOBPLD(CancellationToken EMNJFKNFCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7DA23D0", Offset = "0x7DA17D0", VA = "0x187DA23D0")]
	private Task NFFAJEHNDFC(DNGFPOMMDGK FHBKFDOMCJO, CancellationToken IMBEMDEIDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x7DA28F0", Offset = "0x7DA1CF0", VA = "0x187DA28F0")]
	[AsyncStateMachine(typeof(HNOCKKADFBE))]
	private Task PCIHEMKJNPB(DNGFPOMMDGK FHBKFDOMCJO, CancellationToken IMBEMDEIDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x7DA2050", Offset = "0x7DA1450", VA = "0x187DA2050")]
	private bool LAOBKBLLOLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public GBNKPLOHKNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[UnityEngine.Scripting.Preserve]
internal class PGNBEAAJJHD : GGCFIFHGAEB, ILPCOFODDNC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct JMIFFHILJNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public PGNBEAAJJHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private PGLLJHOKMII<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x7DA73B0", Offset = "0x7DA67B0", VA = "0x187DA73B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7910", Offset = "0x7DA6D10", VA = "0x187DA7910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private BEEMHPLPFOO AFMCEDMHHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private GCHCIBOABFC EMMFNJHAEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private CHDBFKKIGJL KDKFFDOJCPA;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0990", Offset = "0x7DAFD90", VA = "0x187DB0990", Slot = "6")]
	public void OBBALIPJEND(KBABJPFHBFP OKINEPMMKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x7DB07E0", Offset = "0x7DAFBE0", VA = "0x187DB07E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0830", Offset = "0x7DAFC30", VA = "0x187DB0830", Slot = "5")]
	[AsyncStateMachine(typeof(JMIFFHILJNF))]
	public Task FOENOIFLNFM(string CBAOKODFJCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0930", Offset = "0x7DAFD30", VA = "0x187DB0930", Slot = "4")]
	public MLDDIEDIFAF LAOBKBLLOLN(NOFCMGEHFOO FDNLBHLEFDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x7DB06F0", Offset = "0x7DAFAF0", VA = "0x187DB06F0")]
	private EIEOPAGKMJE AONACILIING(string CBAOKODFJCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public PGNBEAAJJHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public static class DEBIPJIDBEB
{
	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x7D9ADC0", Offset = "0x7D9A1C0", VA = "0x187D9ADC0")]
	public static void KKEHKJJKJDH(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A750", Offset = "0x7D99B50", VA = "0x187D9A750")]
	internal static void CLAGKDNLLNG(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A8B0", Offset = "0x7D99CB0", VA = "0x187D9A8B0")]
	internal static void DFENICMLCAB(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A990", Offset = "0x7D99D90", VA = "0x187D9A990")]
	internal static void DIEBPNGFMBJ(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x32CBBB0", Offset = "0x32CAFB0", VA = "0x1832CBBB0")]
	private static void EFDHLJCKIOK<Interface, Impl, Interface>(LEPFMCICNAK EOMAFKDOFHE) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class ODGPHECCHEE : HMIFCDPHAOM<MGPKNNLHNMP>
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private sealed class IIKINKNDJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public MGPKNNLHNMP message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public IIKINKNDJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE1E0", Offset = "0x7DBD5E0", VA = "0x187DBE1E0")]
		internal object MPIGPHAOMFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly ODGPHECCHEE AJPLFLPAHGP;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7DC55D0", Offset = "0x7DC49D0", VA = "0x187DC55D0")]
	public ExitGames.Client.Photon.Hashtable EFGCEHNIDJN(MGPKNNLHNMP LPIFIOEEOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5B30", Offset = "0x7DC4F30", VA = "0x187DC5B30", Slot = "5")]
	protected override void PNAFHPEPDIN(MGPKNNLHNMP LPIFIOEEOGF, IDictionary<object, object> MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5900", Offset = "0x7DC4D00", VA = "0x187DC5900", Slot = "6")]
	public override MGPKNNLHNMP NHMCOOCBIHH(IDictionary<object, object> MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC54C0", Offset = "0x7DC48C0", VA = "0x187DC54C0")]
	private static void COHAOGFFGHO(string KEOONJFHAPA, MGPKNNLHNMP LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5CF0", Offset = "0x7DC50F0", VA = "0x187DC5CF0")]
	public ODGPHECCHEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5660", Offset = "0x7DC4A60", VA = "0x187DC5660")]
	[CompilerGenerated]
	internal static string HKFBBGCGNBN(LDGKNLKOAHN IILBHIALBMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class BFDKFCHOOHA
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public static MLDDIEDIFAF MMNBHEMMLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7DB17F0", Offset = "0x7DB0BF0", VA = "0x187DB17F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1B00", Offset = "0x7DB0F00", VA = "0x187DB1B00")]
	public static bool IKCINGELDBA(this MLDDIEDIFAF GOHJIBCDDFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1850", Offset = "0x7DB0C50", VA = "0x187DB1850")]
	public static MLDDIEDIFAF BANJHLNBFAN(BDCDKKLDAGN FMMBBDMNBLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1B20", Offset = "0x7DB0F20", VA = "0x187DB1B20")]
	public static MLDDIEDIFAF NAMBBFKCGOG(IEnumerable<MLDDIEDIFAF> AFMLDJPKOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x7DB18B0", Offset = "0x7DB0CB0", VA = "0x187DB18B0")]
	public static string FIODFJPKMKA(this MLDDIEDIFAF HOCIBOCHCFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public abstract class MDJJDEHKOCL : MBDABCDMGEI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public delegate MLDDIEDIFAF BILDMICMDAF([NotNull] NOFCMGEHFOO PFDFFAPLFJE);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class LLALDKNPAJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public NOFCMGEHFOO photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LLALDKNPAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x13CDD90", Offset = "0x13CD190", VA = "0x1813CDD90")]
		internal MLDDIEDIFAF CPGCBAPBLLG(BILDMICMDAF v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private bool MPODDHPAEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	protected readonly HashSet<BILDMICMDAF> FHGGJFMOALH;

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4720", Offset = "0x7DC3B20", VA = "0x187DC4720", Slot = "4")]
	public void JFEHNFOILNA(BILDMICMDAF OIMLDJKLCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4780", Offset = "0x7DC3B80", VA = "0x187DC4780", Slot = "5")]
	public void PDNFNKEKKKH(BILDMICMDAF OIMLDJKLCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC46D0", Offset = "0x7DC3AD0", VA = "0x187DC46D0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4440", Offset = "0x7DC3840", VA = "0x187DC4440")]
	protected MLDDIEDIFAF CFCIBPDICGO(NOFCMGEHFOO GECCDAMDACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC47E0", Offset = "0x7DC3BE0", VA = "0x187DC47E0")]
	protected MDJJDEHKOCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public class CMBAFACOLEF : MDJJDEHKOCL, KDJOLJCAGCD, MBDABCDMGEI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class GAHPCIMALCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public MLDDIEDIFAF result;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GAHPCIMALCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x7DB9FF0", Offset = "0x7DB93F0", VA = "0x187DB9FF0")]
		internal object IFNPJFLIOHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1700", Offset = "0x7DB0B00", VA = "0x187DB1700")]
	[UnityEngine.Scripting.Preserve]
	public CMBAFACOLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3580", Offset = "0x7DB2980", VA = "0x187DB3580", Slot = "8")]
	public MLDDIEDIFAF LPIBJJLAHJP(NOFCMGEHFOO GECCDAMDACK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public class AHDCALMENNN : MDJJDEHKOCL, BEEMHPLPFOO, MBDABCDMGEI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class NKPHELNINEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public MLDDIEDIFAF result;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public NKPHELNINEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5000", Offset = "0x7DC4400", VA = "0x187DC5000")]
		internal object GKDHMHEDMGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1700", Offset = "0x7DB0B00", VA = "0x187DB1700")]
	[UnityEngine.Scripting.Preserve]
	public AHDCALMENNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x7DB15F0", Offset = "0x7DB09F0", VA = "0x187DB15F0", Slot = "8")]
	public MLDDIEDIFAF LAOBKBLLOLN(NOFCMGEHFOO BAEPHPHLIBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal static class OHGLCLEFOCK
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class GMIIMBMCEAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public PGLLJHOKMII<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GMIIMBMCEAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7DBBD80", Offset = "0x7DBB180", VA = "0x187DBBD80")]
		internal object GDHBELOAKII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7250", Offset = "0x7DC6650", VA = "0x187DC7250")]
	public static PGLLJHOKMII<string> EGDGAACFOMI(HLBHMADGLFA GCIBFPDCNDK, [Optional] string MLFDNNLLEIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7190", Offset = "0x7DC6590", VA = "0x187DC7190")]
	public static void CCADNMEHHAH(PGLLJHOKMII<string> LMBGFJBPMAJ, HLBHMADGLFA GCIBFPDCNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7330", Offset = "0x7DC6730", VA = "0x187DC7330")]
	public static string JOMNKIEDIHO(MGPKNNLHNMP DMNJLKMHCNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal static class KGODBDBHOAE
{
	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x7DC15C0", Offset = "0x7DC09C0", VA = "0x187DC15C0")]
	public static void GODCPEIPBFD(this HHMOMAGJIPE BCLILIMLEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7DC16F0", Offset = "0x7DC0AF0", VA = "0x187DC16F0")]
	public static void PJFGELLPFEH(this HHMOMAGJIPE BCLILIMLEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7DC15D0", Offset = "0x7DC09D0", VA = "0x187DC15D0")]
	private static void IPMNFIIAEBK(this HHMOMAGJIPE BCLILIMLEBK, bool IODDIOIHMHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class IMCBALIHMAP : EAFJFGJJKEN, MBMJLKCABGK, JFPFNIIKLHH, BJIJFEABGPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private readonly MBMJLKCABGK GAOPMJPNLDJ;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public NOFCMGEHFOO MMFHALPOBPH
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF550", Offset = "0x7DBE950", VA = "0x187DBF550", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public int CJJBPDBCBPA
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF870", Offset = "0x7DBEC70", VA = "0x187DBF870", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int KJHCOHFGINN
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF6D0", Offset = "0x7DBEAD0", VA = "0x187DBF6D0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool EJIKBACHGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int NMFLDDHDAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xACC550", Offset = "0xACB950", VA = "0x180ACC550", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event MLGDFMMLEEK.NBAMDIBPKGG FLADBGFPBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event OGMCAIHMFDP OMHDLPLIHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF8C0", Offset = "0x7DBECC0", VA = "0x187DBF8C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF7D0", Offset = "0x7DBEBD0", VA = "0x187DBF7D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> GBCJBPEGKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NOFCMGEHFOO> HBOHENDGLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action DIIAPBINIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF960", Offset = "0x7DBED60", VA = "0x187DBF960", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF4B0", Offset = "0x7DBE8B0", VA = "0x187DBF4B0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0xC00E10", Offset = "0xC00210", VA = "0x180C00E10")]
	public IMCBALIHMAP(MBMJLKCABGK GAOPMJPNLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF720", Offset = "0x7DBEB20", VA = "0x187DBF720", Slot = "8")]
	public bool MLLDMBBNDDJ(byte FPINDDDPMFJ, object NPIOCJAOMHB, EIJLNMDGOPA MLCJBGOJGOH, SendOptions GMONLKDMFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF5F0", Offset = "0x7DBE9F0", VA = "0x187DBF5F0", Slot = "16")]
	public NOFCMGEHFOO GBLKFOCIKND(int CFMOAKJJMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "19")]
	public void OIIKJNIPCNI(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "20")]
	public void FPJOMMBCHOG(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "21")]
	public void HECMPBBIEPD(object OCDOGNMJENC, bool NDIDHEFBMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF5A0", Offset = "0x7DBE9A0", VA = "0x187DBF5A0", Slot = "22")]
	public IDisposable EBOIDAHIEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "23")]
	private bool CCFPIKMKEMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "24")]
	public void AONEDAJENDB(StringBuilder DLLCCCGNFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0xE35270", Offset = "0xE34670", VA = "0x180E35270", Slot = "25")]
	public bool MIJMOEJOMGB(bool CLBKPMJPKNL, [Out] string JPAKKPAOGDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xDAEA80", Offset = "0xDADE80", VA = "0x180DAEA80", Slot = "28")]
	public void EBGPKJLDCII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal struct DAIEIGCJIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	private readonly IDictionary<object, object> CDDCIHICHEA;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
	public DAIEIGCJIEC(IDictionary<object, object> CDDCIHICHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3A60", Offset = "0x7DB2E60", VA = "0x187DB3A60")]
	public bool OCNLNMFJMAJ([Out] MGPKNNLHNMP LPIFIOEEOGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7DB39B0", Offset = "0x7DB2DB0", VA = "0x187DB39B0")]
	public Guid IGLILJLJDJA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3790", Offset = "0x7DB2B90", VA = "0x187DB3790")]
	public MLDDIEDIFAF BFGFKPDAJEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7DB38C0", Offset = "0x7DB2CC0", VA = "0x187DB38C0")]
	public static ExitGames.Client.Photon.Hashtable GEEFBNOOFMP(MGPKNNLHNMP LPIFIOEEOGF, MLDDIEDIFAF GOHJIBCDDFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal static class NILHBMBMKGO
{
	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4A10", Offset = "0x7DC3E10", VA = "0x187DC4A10")]
	public static bool NENMJOBHJFP(this DNHLENAINEA FLPHGLKPGDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal struct BFLGPEHGOLO : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct JLDCKDNDEFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public BFLGPEHGOLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0E10", Offset = "0x7DC0210", VA = "0x187DC0E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0FF0", Offset = "0x7DC03F0", VA = "0x187DC0FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private readonly CancellationTokenSource GBICCIOOCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private bool MPODDHPAEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	private Task GELALODAJCE;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool DAHIKGIHLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1E70", Offset = "0x7DB1270", VA = "0x187DB1E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1EA0", Offset = "0x7DB12A0", VA = "0x187DB1EA0")]
	public BFLGPEHGOLO(CancellationToken MLAPMBKLAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1D60", Offset = "0x7DB1160", VA = "0x187DB1D60")]
	[AsyncStateMachine(typeof(JLDCKDNDEFC))]
	public Task FBHKFNNFIAP(Func<CancellationToken, List<Task>> HJGNOPHCKDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1D10", Offset = "0x7DB1110", VA = "0x187DB1D10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public readonly struct IKILMCFABBM<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct PBBLLLOPENG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<NOINHDPCAGF<TData>, OGPHAGHJAIC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public IKILMCFABBM<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TaskAwaiter<PHLGGJNOBDN<NOINHDPCAGF<TData>, OGPHAGHJAIC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x507D9E0", Offset = "0x507CDE0", VA = "0x18507D9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x4134300", Offset = "0x4133700", VA = "0x184134300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private readonly HHKKLDJCOIN<TGetDataArg, TData> JPIGDBMGNPA;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
	internal IKILMCFABBM(HHKKLDJCOIN<TGetDataArg, TData> BDKFMFBFJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x4821A10", Offset = "0x4820E10", VA = "0x184821A10")]
	[AsyncStateMachine(typeof(IKILMCFABBM<, >.PBBLLLOPENG))]
	public Task<PHLGGJNOBDN<NOINHDPCAGF<TData>, OGPHAGHJAIC>> LBPEDOIAKGA(TGetDataArg EEHMKJMNANF, string FHIGHECHNAG, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public static class JEDINFBMPJP
{
	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x3202BD0", Offset = "0x3201FD0", VA = "0x183202BD0")]
	public static IKILMCFABBM<TGetDataArg, TData> KMDIICJFNJF<TGetDataArg, TData>(HHKKLDJCOIN<TGetDataArg, TData> BDKFMFBFJII)
	{
		return default(IKILMCFABBM<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public struct BEGGOOEAECN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public readonly int HKFLKNBGMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public readonly int? KGAMPOHADAI;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x4BC35B0", Offset = "0x4BC29B0", VA = "0x184BC35B0")]
	public BEGGOOEAECN(int LNEEKMIFMOP, [Optional] int? ICCFDKPBJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1710", Offset = "0x7DB0B10", VA = "0x187DB1710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public interface OKMOFPJDJDP<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCMFNBMACNH();

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OKMOFPJDJDP<T> FOPCMABPOJJ(string IFKPMNDGIBE);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OKMOFPJDJDP<T> HOAPAIPAJBO(LPCNGEGKFCJ<T> ONFEKDPPKIG);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OKMOFPJDJDP<T> JGGFCHJKBPL(int AOFMJKALGDK);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OKMOFPJDJDP<T> KAHAAKLLGGG(int AOFMJKALGDK, FLGKLGAIOLM<T> NIFNJNFJPMO);
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface KGMCELACHEF
{
	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OKMOFPJDJDP<T> IJIHDCKKGKI<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FMBHIBJMKLH EHCCJMOCAFE(Exception BOKONMFPKMC);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BEGGOOEAECN ELJBJOGCCOC(Exception BOKONMFPKMC);
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public delegate string LPCNGEGKFCJ<in T>(T BOKONMFPKMC) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public delegate int FLGKLGAIOLM<in T>(T BOKONMFPKMC) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class FKIAOEDOCLN : KGMCELACHEF
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private delegate string DICNFAIKCJL(Exception BOKONMFPKMC);

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private delegate int DLHGJLNNPIK(Exception BOKONMFPKMC);

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	private class KHODIHNACKC<T> : OKMOFPJDJDP<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		[CompilerGenerated]
		private sealed class AGGNAOBGEJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public AGGNAOBGEJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			internal string DHJDFODCBDB(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		[CompilerGenerated]
		private sealed class HMHCCHGAFPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public LPCNGEGKFCJ<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public HMHCCHGAFPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x4755C00", Offset = "0x4755000", VA = "0x184755C00")]
			internal string FHEMFPCCNBB(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		[CompilerGenerated]
		private sealed class COBDOHLMGKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public FLGKLGAIOLM<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public COBDOHLMGKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x4755C00", Offset = "0x4755000", VA = "0x184755C00")]
			internal int ACCGHABNBPE(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private readonly FKIAOEDOCLN ADDAMDDDHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private readonly Type EGJKHOEGECL;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x4B24C90", Offset = "0x4B24090", VA = "0x184B24C90")]
		internal KHODIHNACKC(FKIAOEDOCLN ADDAMDDDHKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x4B249D0", Offset = "0x4B23DD0", VA = "0x184B249D0", Slot = "4")]
		public void GCMFNBMACNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x4B248B0", Offset = "0x4B23CB0", VA = "0x184B248B0", Slot = "5")]
		public OKMOFPJDJDP<T> FOPCMABPOJJ(string IFKPMNDGIBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x4B24A00", Offset = "0x4B23E00", VA = "0x184B24A00", Slot = "6")]
		public OKMOFPJDJDP<T> HOAPAIPAJBO(LPCNGEGKFCJ<T> ONFEKDPPKIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x4B24B20", Offset = "0x4B23F20", VA = "0x184B24B20", Slot = "7")]
		public OKMOFPJDJDP<T> JGGFCHJKBPL(int AOFMJKALGDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x4B24B60", Offset = "0x4B23F60", VA = "0x184B24B60", Slot = "8")]
		public OKMOFPJDJDP<T> KAHAAKLLGGG(int AOFMJKALGDK, FLGKLGAIOLM<T> NIFNJNFJPMO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class MNBIPANCLMO<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private bool BABCMPPDKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly List<Type> OPLDFADKKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly Dictionary<Type, TVal> JGPJLGAGLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private readonly Dictionary<Type, int> FOCNACLNCLB;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public IReadOnlyList<Type> FNCPFPEENMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x4E16420", Offset = "0x4E15820", VA = "0x184E16420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x4E167A0", Offset = "0x4E15BA0", VA = "0x184E167A0")]
		public MNBIPANCLMO(Dictionary<Type, int> FOCNACLNCLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x4E164D0", Offset = "0x4E158D0", VA = "0x184E164D0")]
		public void KAAHFJDOOLK(Type MCNLCGLNHHO, TVal GHFLHNCPIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x4E16320", Offset = "0x4E15720", VA = "0x184E16320")]
		public bool DEDPIFLILBJ(Type EGJKHOEGECL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x4E16630", Offset = "0x4E15A30", VA = "0x184E16630")]
		public bool OIIACPLNCIG(TVal PEBNJNGMMHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x4125890", Offset = "0x4124C90", VA = "0x184125890")]
		public TVal FCPELJIOJPN(Type ANONBNLNHHL)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x4E16280", Offset = "0x4E15680", VA = "0x184E16280")]
		[CompilerGenerated]
		private int COCHEDDMLHO(Type FPCDCAJDOCL, Type LCILCPPPJEB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class GOPCIEEPCOH : IEnumerable<BEGGOOEAECN>, IEnumerable, IEnumerator<BEGGOOEAECN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private BEGGOOEAECN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public FKIAOEDOCLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private IEnumerator<BEGGOOEAECN> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		private BEGGOOEAECN System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x41ADA10", Offset = "0x41ACE10", VA = "0x1841ADA10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(BEGGOOEAECN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x7DBC900", Offset = "0x7DBBD00", VA = "0x187DBC900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD746B0", VA = "0x180D752B0")]
		[DebuggerHidden]
		public GOPCIEEPCOH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC950", Offset = "0x7DBBD50", VA = "0x187DBC950", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC340", Offset = "0x7DBB740", VA = "0x187DBC340", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC2F0", Offset = "0x7DBB6F0", VA = "0x187DBC2F0")]
		private void MHCHPBFCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC2A0", Offset = "0x7DBB6A0", VA = "0x187DBC2A0")]
		private void GADEEDGNJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC8B0", Offset = "0x7DBBCB0", VA = "0x187DBC8B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC7F0", Offset = "0x7DBBBF0", VA = "0x187DBC7F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BEGGOOEAECN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC7F0", Offset = "0x7DBBBF0", VA = "0x187DBC7F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	private static readonly BEGGOOEAECN PLBAEDPCIML;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private static readonly Dictionary<Type, int> DJCONIJDJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private readonly HashSet<Type> GGDOONEHPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private readonly MNBIPANCLMO<int> GIILGFNCOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private readonly MNBIPANCLMO<DLHGJLNNPIK> POLBJIELIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	private readonly MNBIPANCLMO<DICNFAIKCJL> GIBIDJNJOIE;

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8EE0", Offset = "0x7DB82E0", VA = "0x187DB8EE0")]
	[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
	internal static void PPNAAKNMPKA(LEPFMCICNAK BFCIDAHLIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9090", Offset = "0x7DB8490", VA = "0x187DB9090")]
	[RecRoom.NoEngine.Common.Preserve]
	public FKIAOEDOCLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x34828A0", Offset = "0x3481CA0", VA = "0x1834828A0", Slot = "4")]
	public OKMOFPJDJDP<T> IJIHDCKKGKI<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8500", Offset = "0x7DB7900", VA = "0x187DB8500", Slot = "5")]
	public FMBHIBJMKLH EHCCJMOCAFE(Exception BOKONMFPKMC)
	{
		return default(FMBHIBJMKLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8590", Offset = "0x7DB7990", VA = "0x187DB8590", Slot = "6")]
	public BEGGOOEAECN ELJBJOGCCOC(Exception? BOKONMFPKMC)
	{
		return default(BEGGOOEAECN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8460", Offset = "0x7DB7860", VA = "0x187DB8460", Slot = "7")]
	[IteratorStateMachine(typeof(GOPCIEEPCOH))]
	public IEnumerable<BEGGOOEAECN> DLDFGACPLEP(Exception BOKONMFPKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8790", Offset = "0x7DB7B90", VA = "0x187DB8790", Slot = "8")]
	public string FOLDLPBGCPJ(Exception? BOKONMFPKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7E90", Offset = "0x7DB7290", VA = "0x187DB7E90")]
	private string CAODHABIHCC(AggregateException IHICEGLKHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8B30", Offset = "0x7DB7F30", VA = "0x187DB8B30")]
	private void ICOAOLFCCKD(Type EGJKHOEGECL, int AOFMJKALGDK, DLHGJLNNPIK? NDHJPMAKGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7DB88E0", Offset = "0x7DB7CE0", VA = "0x187DB88E0")]
	private void HPBPNJHFNGI(Type EGJKHOEGECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8190", Offset = "0x7DB7590", VA = "0x187DB8190")]
	private void CCELBKELLGD(Type EGJKHOEGECL, DICNFAIKCJL KBHCBBCJCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7C30", Offset = "0x7DB7030", VA = "0x187DB7C30")]
	private static int ABBBELHJGCF(Type EGJKHOEGECL, Dictionary<Type, int> FOCNACLNCLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x34833B0", Offset = "0x34827B0", VA = "0x1834833B0")]
	private static bool LKDEBJBPIPL<TVal>(MNBIPANCLMO<TVal> JPGIMCGBJEJ, Type EGJKHOEGECL, [Out] TVal PEBNJNGMMHE) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7DB0", Offset = "0x7DB71B0", VA = "0x187DB7DB0")]
	[CompilerGenerated]
	internal static int AFKFIMPPHDO(Type FKNEOEDLFIG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public struct FMBHIBJMKLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public readonly BEGGOOEAECN BCCKFDGHCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public readonly string NMJJNLNLJIJ;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9E80", Offset = "0x7DB9280", VA = "0x187DB9E80")]
	public FMBHIBJMKLH(string GJIAHMAEBIF, BEGGOOEAECN AOFMJKALGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9DE0", Offset = "0x7DB91E0", VA = "0x187DB9DE0")]
	public string HLJHKEEELLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public class OGIKFOGELKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	private readonly MPOANHNJNCL FDINCJCKHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private string LOPNDCEFAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	private long? ANOGGPGEJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private long? JILONPCHGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private long? LEFKKOHAJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private string OOKIMNBNHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private LELMIIPMAGF LPEEHINLJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private long? HAJNCFGJGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private bool DDNEODMACLF;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public string JBFPKPKIPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public long PJDAKMGGEND
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6410", Offset = "0x7DC5810", VA = "0x187DC6410")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public long CKKKNJLGPFF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6330", Offset = "0x7DC5730", VA = "0x187DC6330")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public long BMMJGCHEPCD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6FF0", Offset = "0x7DC63F0", VA = "0x187DC6FF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public string PEGGOGMIIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x7DC67E0", Offset = "0x7DC5BE0", VA = "0x187DC67E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public LELMIIPMAGF CFJIOPPCICB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xC5B340", Offset = "0xC5A740", VA = "0x180C5B340")]
		get
		{
			return default(LELMIIPMAGF);
		}
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6CB0", Offset = "0x7DC60B0", VA = "0x187DC6CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public long KALANIOONCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x7DC70F0", Offset = "0x7DC64F0", VA = "0x187DC70F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7150", Offset = "0x7DC6550", VA = "0x187DC7150")]
	[UnityEngine.Scripting.Preserve]
	public OGIKFOGELKN([PNFCCJKFMBH(null)] MPOANHNJNCL FDINCJCKHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6DA0", Offset = "0x7DC61A0", VA = "0x187DC6DA0")]
	private void HCGGOJLOGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6820", Offset = "0x7DC5C20", VA = "0x187DC6820")]
	public void ENBJCECDOIE(long LFNEDMLHPHM, long FHAJBLMHDGD, [Optional] long? FNPIGGMFPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7050", Offset = "0x7DC6450", VA = "0x187DC7050")]
	public void IMMBNJLBAFP(long FNPIGGMFPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6390", Offset = "0x7DC5790", VA = "0x187DC6390")]
	public void ADNDPHEECBC(string FKMAEDHOLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6470", Offset = "0x7DC5870", VA = "0x187DC6470")]
	public void CLBJMGLLHBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class OJEJNDLACBE : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct EGOEOHLFIMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public AsyncTaskMethodBuilder<MGPKNNLHNMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public MGPKNNLHNMP roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public OJEJNDLACBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private TaskAwaiter<IGKLHNCIHKG.HIEDJJPPHPH<MGPKNNLHNMP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5BC0", Offset = "0x7DB4FC0", VA = "0x187DB5BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6100", Offset = "0x7DB5500", VA = "0x187DB6100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct FNCIFLPEDDN<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class HCBNOFIEHIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public MGPKNNLHNMP roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HCBNOFIEHIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x7DBCAA0", Offset = "0x7DBBEA0", VA = "0x187DBCAA0")]
		internal MGPKNNLHNMP AFPKAJHIMAO(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct EBJAKDKOBNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public AsyncTaskMethodBuilder<IGKLHNCIHKG.HIEDJJPPHPH<MGPKNNLHNMP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public MGPKNNLHNMP roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public OJEJNDLACBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private CLAEHKNMMJA <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private TaskAwaiter<IGKLHNCIHKG.HIEDJJPPHPH<MGPKNNLHNMP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5540", Offset = "0x7DB4940", VA = "0x187DB5540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5B50", Offset = "0x7DB4F50", VA = "0x187DB5B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct BCAKICABOMO<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public OJEJNDLACBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x58B44F0", Offset = "0x58B38F0", VA = "0x1858B44F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x3D60950", Offset = "0x3D5FD50", VA = "0x183D60950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct OACIJEIOHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public OJEJNDLACBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5060", Offset = "0x7DC4460", VA = "0x187DC5060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5220", Offset = "0x7DC4620", VA = "0x187DC5220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class PJNCMEFHANG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public PJNCMEFHANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB470", Offset = "0x7DCA870", VA = "0x187DCB470")]
		internal object CIEMDEJFPIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB4D0", Offset = "0x7DCA8D0", VA = "0x187DCB4D0")]
		internal bool FLNEAGCPCDD(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private sealed class MNLCKMMIPIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MNLCKMMIPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4870", Offset = "0x7DC3C70", VA = "0x187DC4870")]
		internal object PLENGEIMMFL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class ENIAEMLMCKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public ENIAEMLMCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6D40", Offset = "0x7DB6140", VA = "0x187DB6D40")]
		internal object JFIODMDCGPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class NIBJJEPCFAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public NIBJJEPCFAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x7DC49A0", Offset = "0x7DC3DA0", VA = "0x187DC49A0")]
		internal object FKKGCPGABOE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class OBJCDDJEBKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public OJEJNDLACBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OBJCDDJEBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5280", Offset = "0x7DC4680", VA = "0x187DC5280")]
		internal object MPIGPHAOMFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private static readonly Guid PCKIFAFEAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public readonly GIELBPOLHAF CFLLFIOEOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private readonly IGKLHNCIHKG IEMCJOHCEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	private readonly JFPFNIIKLHH BCLILIMLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	private readonly BJIJFEABGPL CNCHJEMOHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	private bool JAALIMGGLJL;

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x7DCA460", Offset = "0x7DC9860", VA = "0x187DCA460")]
	public OJEJNDLACBE(GIELBPOLHAF IFKMLHMDOLM, IGKLHNCIHKG IEMCJOHCEOE, JFPFNIIKLHH BCLILIMLEBK, BJIJFEABGPL CNCHJEMOHGL, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x7DC97D0", Offset = "0x7DC8BD0", VA = "0x187DC97D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9470", Offset = "0x7DC8870", VA = "0x187DC9470")]
	public void BNEKCAFJHJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x7DCA160", Offset = "0x7DC9560", VA = "0x187DCA160")]
	public void MCLNPNCLHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9280", Offset = "0x7DC8680", VA = "0x187DC9280")]
	public void BDHEGJLAAIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9CE0", Offset = "0x7DC90E0", VA = "0x187DC9CE0")]
	[AsyncStateMachine(typeof(EGOEOHLFIMH))]
	internal Task<MGPKNNLHNMP> JJMMHOMBMHD(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, MGPKNNLHNMP DMNJLKMHCNI, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x3657730", Offset = "0x3656B30", VA = "0x183657730")]
	private static byte[] BDCJDOKFCJC<T>(T LPIFIOEEOGF) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x3657D60", Offset = "0x3657160", VA = "0x183657D60")]
	private static T PAKBGGEMHPK<T>(MessageParser<T> MIEBLEMBJHM, byte[] LPIFIOEEOGF, T DJGKHMLKNDE) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9FA0", Offset = "0x7DC93A0", VA = "0x187DC9FA0")]
	[AsyncStateMachine(typeof(EBJAKDKOBNJ))]
	private Task<IGKLHNCIHKG.HIEDJJPPHPH<MGPKNNLHNMP>> LIDJGDJANCE(MGPKNNLHNMP DMNJLKMHCNI, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x3657740", Offset = "0x3656B40", VA = "0x183657740")]
	[AsyncStateMachine(typeof(BCAKICABOMO<>))]
	internal Task<T> COAFCAGEPDA<T>(CancellationToken IMBEMDEIDGJ, Func<CancellationToken, Task<T>> IDANBALKKEA, int DPKLBNFGBPB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9590", Offset = "0x7DC8990", VA = "0x187DC9590")]
	[AsyncStateMachine(typeof(OACIJEIOHNG))]
	internal Task COAFCAGEPDA(CancellationToken IMBEMDEIDGJ, Func<CancellationToken, Task> IDANBALKKEA, int DPKLBNFGBPB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x7DCA220", Offset = "0x7DC9620", VA = "0x187DCA220")]
	public PBEFJMKFDFM MHJFEJMECPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x7DCA0E0", Offset = "0x7DC94E0", VA = "0x187DCA0E0")]
	public OHHDBCHDCIF MCEKJJKIPHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x7DC98F0", Offset = "0x7DC8CF0", VA = "0x187DC98F0")]
	public FBAHBFKEPNC GAONJFOHJNE([Optional] HLBHMADGLFA? GCIBFPDCNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9E40", Offset = "0x7DC9240", VA = "0x187DC9E40")]
	public void KIAFACDFHHL(Func<Guid, bool> DOGDCMJMKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x7DCA2A0", Offset = "0x7DC96A0", VA = "0x187DCA2A0")]
	public void NGGKDEJNHOF(Func<Guid, bool> NANPAANEAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9B60", Offset = "0x7DC8F60", VA = "0x187DC9B60")]
	public Guid IJCECJKCGFL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x7DC97E0", Offset = "0x7DC8BE0", VA = "0x187DC97E0")]
	public void FBLIAOELNLJ(Guid JEIFOACBHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9340", Offset = "0x7DC8740", VA = "0x187DC9340")]
	public void BEDEJGJDJFG(MGPKNNLHNMP MAEGCIICDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x7DC96C0", Offset = "0x7DC8AC0", VA = "0x187DC96C0")]
	public void COHAOGFFGHO(string CCHFBHIEDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x3657C80", Offset = "0x3657080", VA = "0x183657C80")]
	private T JOCLDBJIJBC<T>(T PEBNJNGMMHE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x7DCA3B0", Offset = "0x7DC97B0", VA = "0x187DCA3B0")]
	public void NOAIOFBLPPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x36579E0", Offset = "0x3656DE0", VA = "0x1836579E0")]
	[CompilerGenerated]
	internal static string IDOAEHPMCAO<T>(byte[] KPLABGDDBEL, int BIHHFABMMFA, FNCIFLPEDDN<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal sealed class LIFACANOBNG : GIELBPOLHAF
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class PLJOADNPLKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public PLJOADNPLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB590", Offset = "0x7DCA990", VA = "0x187DCB590")]
		internal object NEJCHNJLNGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct FLEDIKFMCIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public LIFACANOBNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public OJEJNDLACBE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private FJEGBONDBNO <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private OHHDBCHDCIF <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x7DB9430", Offset = "0x7DB8830", VA = "0x187DB9430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DB9D80", Offset = "0x7DB9180", VA = "0x187DB9D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct GCCJNFDJJOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public LIFACANOBNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private TaskAwaiter<FGPODGGHBLK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x7DBA050", Offset = "0x7DB9450", VA = "0x187DBA050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x7DBA790", Offset = "0x7DB9B90", VA = "0x187DBA790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct GLCMOKDGKFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public LIFACANOBNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter<CBLOAIMJMAA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x7DBBA00", Offset = "0x7DBAE00", VA = "0x187DBBA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x7DBBD10", Offset = "0x7DBB110", VA = "0x187DBBD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class INEPDPNDDDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public FJEGBONDBNO presence;

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public INEPDPNDDDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFA00", Offset = "0x7DBEE00", VA = "0x187DBFA00")]
		internal object EAFNJPIKOJM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	private static readonly HLBHMADGLFA HKMOKHMAIEM;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	private static readonly HLBHMADGLFA CELPKICECPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	private readonly LDGKNLKOAHN MFJCNLDOCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private readonly DNHLENAINEA FIAFGAIMMPK;

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x7DC2F00", Offset = "0x7DC2300", VA = "0x187DC2F00")]
	public LIFACANOBNG(LDGKNLKOAHN MFJCNLDOCMA, DNHLENAINEA FIAFGAIMMPK, Guid PPLJPJJDEGE, KBABJPFHBFP OKINEPMMKIG, MMCELPKDDOJ IFGMJFBLFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x7DC2BF0", Offset = "0x7DC1FF0", VA = "0x187DC2BF0", Slot = "7")]
	[AsyncStateMachine(typeof(FLEDIKFMCIJ))]
	protected override Task NJDPFOOJLIK(OJEJNDLACBE OOHICOOKFFI, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x7DC2D30", Offset = "0x7DC2130", VA = "0x187DC2D30")]
	[AsyncStateMachine(typeof(GCCJNFDJJOH))]
	private Task OIHLKLNLAGA(CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x7DC2AE0", Offset = "0x7DC1EE0", VA = "0x187DC2AE0")]
	[AsyncStateMachine(typeof(GLCMOKDGKFI))]
	private Task<int> KLBPDBGHFBL(CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x7DC2910", Offset = "0x7DC1D10", VA = "0x187DC2910")]
	private FJEGBONDBNO FPDHELMAGAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class DKHFOPGDMEO : GIELBPOLHAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct EIBLHHIICJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public DKHFOPGDMEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public OJEJNDLACBE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private TaskAwaiter<CGKMMAMFMFL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6170", Offset = "0x7DB5570", VA = "0x187DB6170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6B20", Offset = "0x7DB5F20", VA = "0x187DB6B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly int KPCPAHCNFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly HLGDIBFKEKE CKIFDKJKIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public readonly long CIKKOOKDCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public readonly long KODEFGIOBLL;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public CGKMMAMFMFL GLFCCFDCOGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x9712A0", Offset = "0x9706A0", VA = "0x1809712A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x971450", Offset = "0x970850", VA = "0x180971450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3C30", Offset = "0x7DB3030", VA = "0x187DB3C30")]
	public DKHFOPGDMEO(Guid PPLJPJJDEGE, KBABJPFHBFP OKINEPMMKIG, MMCELPKDDOJ IFGMJFBLFGD, int KPCPAHCNFAF, HLGDIBFKEKE CKIFDKJKIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3B10", Offset = "0x7DB2F10", VA = "0x187DB3B10", Slot = "7")]
	[AsyncStateMachine(typeof(EIBLHHIICJG))]
	protected override Task NJDPFOOJLIK(OJEJNDLACBE OOHICOOKFFI, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal abstract class GGOMMAOLKBI : GIELBPOLHAF
{
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class NEHENNDLFKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public GGOMMAOLKBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public OPKEFFKHMEH playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public NEHENNDLFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x7DC48D0", Offset = "0x7DC3CD0", VA = "0x187DC48D0")]
		internal Task ABJENMCAIJM(PGLLJHOKMII<string>.GLACLJPMODI postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4910", Offset = "0x7DC3D10", VA = "0x187DC4910")]
		internal object GOPHOPEJEAD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct DNCBKJELIIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public GGOMMAOLKBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public OJEJNDLACBE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private NEHENNDLFKN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x7DB4D10", Offset = "0x7DB4110", VA = "0x187DB4D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x7DB54E0", Offset = "0x7DB48E0", VA = "0x187DB54E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct PDHOEPBKHAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public OPKEFFKHMEH playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public GGOMMAOLKBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x7DCAD30", Offset = "0x7DCA130", VA = "0x187DCAD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB2E0", Offset = "0x7DCA6E0", VA = "0x187DCB2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAA70", Offset = "0x7DB9E70", VA = "0x187DBAA70")]
	public GGOMMAOLKBI(Guid PPLJPJJDEGE, KBABJPFHBFP OKINEPMMKIG, MMCELPKDDOJ IFGMJFBLFGD, string ADAACKHKDKO, PKPHAIIFFIO PCPPMGPAHKO, bool PILPMEBOJNA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x7DBA930", Offset = "0x7DB9D30", VA = "0x187DBA930", Slot = "7")]
	[AsyncStateMachine(typeof(DNCBKJELIIJ))]
	protected override Task NJDPFOOJLIK(OJEJNDLACBE OOHICOOKFFI, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task JJCCOAHDCKO(OJEJNDLACBE OOHICOOKFFI, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x7DBA7F0", Offset = "0x7DB9BF0", VA = "0x187DBA7F0")]
	[AsyncStateMachine(typeof(PDHOEPBKHAI))]
	private Task NEICHMCFMLH(IDisposable MHLHBLGEKLJ, OPKEFFKHMEH APGNGMMKKAM, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal class GJLJHDJKKAN : GIELBPOLHAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct IKINMMKKKAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public GJLJHDJKKAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public OJEJNDLACBE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private TaskAwaiter<JHKLIMEFACP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE530", Offset = "0x7DBD930", VA = "0x187DBE530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEB20", Offset = "0x7DBDF20", VA = "0x187DBEB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private readonly DNGFPOMMDGK FHBKFDOMCJO;

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB960", Offset = "0x7DBAD60", VA = "0x187DBB960")]
	public GJLJHDJKKAN(Guid PPLJPJJDEGE, KBABJPFHBFP OKINEPMMKIG, MMCELPKDDOJ IFGMJFBLFGD, DNGFPOMMDGK FHBKFDOMCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB880", Offset = "0x7DBAC80", VA = "0x187DBB880", Slot = "6")]
	protected override string PAFHIOPKEAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB760", Offset = "0x7DBAB60", VA = "0x187DBB760", Slot = "7")]
	[AsyncStateMachine(typeof(IKINMMKKKAK))]
	protected override Task NJDPFOOJLIK(OJEJNDLACBE OOHICOOKFFI, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal abstract class GIELBPOLHAF : FPEDHPDMHAE
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public delegate Task FOEKPDFFGAF(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class PFPPEPIBNFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public PGLLJHOKMII<string>.GLACLJPMODI operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public GIELBPOLHAF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public PFPPEPIBNFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB340", Offset = "0x7DCA740", VA = "0x187DCB340")]
		internal Task IKFGKHACJPJ(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class ENPHOONEKBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public PFPPEPIBNFN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public ENPHOONEKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6DB0", Offset = "0x7DB61B0", VA = "0x187DB6DB0")]
		internal object DIMIPOGAJON()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct MBMAAEIDBNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public GIELBPOLHAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public Func<GIELBPOLHAF, PGLLJHOKMII<string>.GLACLJPMODI, OJEJNDLACBE> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private PFPPEPIBNFN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private OJEJNDLACBE <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private TaskAwaiter<MGPKNNLHNMP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3290", Offset = "0x7DC2690", VA = "0x187DC3290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x7DC43E0", Offset = "0x7DC37E0", VA = "0x187DC43E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct JKPCGCDEINL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0310", Offset = "0x7DBF710", VA = "0x187DC0310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0DB0", Offset = "0x7DC01B0", VA = "0x187DC0DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct CLEEJHCHFPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public GIELBPOLHAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x7DB31C0", Offset = "0x7DB25C0", VA = "0x187DB31C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3520", Offset = "0x7DB2920", VA = "0x187DB3520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public readonly Guid IMMGPMKFLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public readonly ByteString JMGJAMCAPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public readonly MMCELPKDDOJ GHBCMIHELEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	protected readonly string OMHCNKLIOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly bool PILPMEBOJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private readonly Queue<FOEKPDFFGAF> MKEFCGEEBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly CJKDPIKNJOA CAAICIEDLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private readonly PKPHAIIFFIO PCPPMGPAHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private bool BJHNCLAJPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public LELMIIPMAGF BGKDNHDONIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public LELMIIPMAGF PFGACCHLGMH;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public KBABJPFHBFP MAJHNGEJJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public LAGOIFMOJDA JIOKCOHMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x7DBB310", Offset = "0x7DBA710", VA = "0x187DBB310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public CIFIMMMOPKA FILPJIKNEAE
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x7DBB360", Offset = "0x7DBA760", VA = "0x187DBB360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public MONKCCHOMPK GPMOAHABAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x7DBB160", Offset = "0x7DBA560", VA = "0x187DBB160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event OJABBGPCOCO MOMJALIGJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7DBB3B0", Offset = "0x7DBA7B0", VA = "0x187DBB3B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x7DBAAC0", Offset = "0x7DB9EC0", VA = "0x187DBAAC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB600", Offset = "0x7DBAA00", VA = "0x187DBB600")]
	protected GIELBPOLHAF(Guid PPLJPJJDEGE, KBABJPFHBFP OKINEPMMKIG, MMCELPKDDOJ IFGMJFBLFGD, string ADAACKHKDKO, PKPHAIIFFIO PCPPMGPAHKO, bool PILPMEBOJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB5C0", Offset = "0x7DBA9C0", VA = "0x187DBB5C0", Slot = "6")]
	protected virtual string PAFHIOPKEAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAC20", Offset = "0x7DBA020", VA = "0x187DBAC20")]
	public void DOHKMDKNNNP(FOEKPDFFGAF KJCHANDKGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAC00", Offset = "0x7DBA000", VA = "0x187DBAC00")]
	protected void DILOALNNDDL(float FEPAKEBFLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAEA0", Offset = "0x7DBA2A0", VA = "0x187DBAEA0")]
	[AsyncStateMachine(typeof(MBMAAEIDBNA))]
	public Task GNAFMGAEBCA(CancellationToken MLAPMBKLAOF, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, [Optional] Func<GIELBPOLHAF, PGLLJHOKMII<string>.GLACLJPMODI, OJEJNDLACBE> LBLGJCBALJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB1E0", Offset = "0x7DBA5E0", VA = "0x187DBB1E0")]
	[AsyncStateMachine(typeof(JKPCGCDEINL))]
	private static Task KBDJMBOMBKE(Func<CancellationToken, Task> FMFCDEMJGCO, Func<CancellationToken, Task> MMMLOBLDONN, CancellationToken IMBEMDEIDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB3D0", Offset = "0x7DBA7D0", VA = "0x187DBB3D0")]
	private void MJAIBCDBENI(bool LAKNLJKLEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAC80", Offset = "0x7DBA080", VA = "0x187DBAC80")]
	private void FFDKFHCKHMI(OJEJNDLACBE OOHICOOKFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task NJDPFOOJLIK(OJEJNDLACBE OOHICOOKFFI, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAAE0", Offset = "0x7DB9EE0", VA = "0x187DBAAE0")]
	[AsyncStateMachine(typeof(CLEEJHCHFPJ))]
	private Task COFLBIPGGEF(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB0E0", Offset = "0x7DBA4E0", VA = "0x187DBB0E0")]
	public MGPKNNLHNMP HKBLBFIICGA(CLAEHKNMMJA LEACMIKKKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAFF0", Offset = "0x7DBA3F0", VA = "0x187DBAFF0")]
	[CompilerGenerated]
	private Task HCOELPOEOBD(CancellationToken MPAMMAGABHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB540", Offset = "0x7DBA940", VA = "0x187DBB540")]
	[CompilerGenerated]
	private object NFGNHMMPBOE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal sealed class MAIJKFPNHLH : GGOMMAOLKBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct JHFNMJPHGJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public MAIJKFPNHLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public OJEJNDLACBE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private AFOKKDBKELL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private OHHDBCHDCIF <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFB40", Offset = "0x7DBEF40", VA = "0x187DBFB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x7DC02B0", Offset = "0x7DBF6B0", VA = "0x187DC02B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private readonly LDGKNLKOAHN IMLJNPLEPMC;

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC31E0", Offset = "0x7DC25E0", VA = "0x187DC31E0")]
	public MAIJKFPNHLH(Guid PPLJPJJDEGE, KBABJPFHBFP OKINEPMMKIG, LDGKNLKOAHN IMLJNPLEPMC, MMCELPKDDOJ IFGMJFBLFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC3090", Offset = "0x7DC2490", VA = "0x187DC3090", Slot = "8")]
	[AsyncStateMachine(typeof(JHFNMJPHGJG))]
	protected override Task JJCCOAHDCKO(OJEJNDLACBE OOHICOOKFFI, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal class EIEOPAGKMJE : GIELBPOLHAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct IDNBAECBOMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public EIEOPAGKMJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public OJEJNDLACBE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter<JHKLIMEFACP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDCF0", Offset = "0x7DBD0F0", VA = "0x187DBDCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE180", Offset = "0x7DBD580", VA = "0x187DBE180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private readonly string KLJMJDGKAPC;

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6C90", Offset = "0x7DB6090", VA = "0x187DB6C90")]
	public EIEOPAGKMJE(Guid PPLJPJJDEGE, KBABJPFHBFP OKINEPMMKIG, MMCELPKDDOJ IFGMJFBLFGD, string KLJMJDGKAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6B80", Offset = "0x7DB5F80", VA = "0x187DB6B80", Slot = "7")]
	[AsyncStateMachine(typeof(IDNBAECBOMK))]
	protected override Task NJDPFOOJLIK(OJEJNDLACBE OOHICOOKFFI, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
internal class NJIEFENHGFI : GGOMMAOLKBI
{
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class KHAHIOGOAJK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012C")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public AsyncTaskMethodBuilder<MGPKNNLHNMP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public KHAHIOGOAJK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private TaskAwaiter<JHKLIMEFACP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			private TaskAwaiter<MGPKNNLHNMP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0x7DCC7A0", Offset = "0x7DCBBA0", VA = "0x187DCC7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0x7DCCC90", Offset = "0x7DCC090", VA = "0x187DCCC90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public NJIEFENHGFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public FBAHBFKEPNC serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public FJKNANMCCDC roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public PBEFJMKFDFM uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public CBBFDOMDOBO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public KHAHIOGOAJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1700", Offset = "0x7DC0B00", VA = "0x187DC1700")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<MGPKNNLHNMP> NENHCPHKCPF(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct DNABJEGNCFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public NJIEFENHGFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public OJEJNDLACBE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private KHAHIOGOAJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private AFOKKDBKELL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private OHHDBCHDCIF <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private MGPKNNLHNMP <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private TaskAwaiter<MGPKNNLHNMP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3D60", Offset = "0x7DB3160", VA = "0x187DB3D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x7DB4CB0", Offset = "0x7DB40B0", VA = "0x187DB4CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private static readonly HLBHMADGLFA HKMOKHMAIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private readonly int FNEMCGFJDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	[CanBeNull]
	private readonly NBJKHDBIOKG BILBPLEGPGE;

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4F50", Offset = "0x7DC4350", VA = "0x187DC4F50")]
	public NJIEFENHGFI(Guid PPLJPJJDEGE, KBABJPFHBFP OKINEPMMKIG, int FNEMCGFJDJN, NBJKHDBIOKG BILBPLEGPGE, MMCELPKDDOJ IFGMJFBLFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4A90", Offset = "0x7DC3E90", VA = "0x187DC4A90", Slot = "8")]
	[AsyncStateMachine(typeof(DNABJEGNCFC))]
	protected override Task JJCCOAHDCKO(OJEJNDLACBE OOHICOOKFFI, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4DA0", Offset = "0x7DC41A0", VA = "0x187DC4DA0")]
	private void MAICNAEECGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4BD0", Offset = "0x7DC3FD0", VA = "0x187DC4BD0")]
	private void LFKDECBBBFD(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, AFOKKDBKELL JMAPFIDMONE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class KKEMAFDODJO : GIELBPOLHAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct CEKHLDFAANJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public KKEMAFDODJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private AFOKKDBKELL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private JCAOOGBCPCO<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private TaskAwaiter<CGKMMAMFMFL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1FD0", Offset = "0x7DB13D0", VA = "0x187DB1FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3160", Offset = "0x7DB2560", VA = "0x187DB3160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	private readonly int FNEMCGFJDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private readonly NBJKHDBIOKG BILBPLEGPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private Func<JHKLIMEFACP, JHKLIMEFACP> FEEGBJLIOHE;

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1960", Offset = "0x7DC0D60", VA = "0x187DC1960")]
	public KKEMAFDODJO(Guid PPLJPJJDEGE, KBABJPFHBFP OKINEPMMKIG, int FNEMCGFJDJN, NBJKHDBIOKG BILBPLEGPGE, Func<JHKLIMEFACP, JHKLIMEFACP> FEEGBJLIOHE, MMCELPKDDOJ IFGMJFBLFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1820", Offset = "0x7DC0C20", VA = "0x187DC1820", Slot = "7")]
	[AsyncStateMachine(typeof(CEKHLDFAANJ))]
	protected override Task NJDPFOOJLIK(OJEJNDLACBE OOHICOOKFFI, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal abstract class PNAINFJABOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public readonly GIELBPOLHAF CFLLFIOEOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public readonly OJEJNDLACBE FEDPIICIOCA;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public LAGOIFMOJDA JIOKCOHMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB7A0", Offset = "0x7DCABA0", VA = "0x187DCB7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public MONKCCHOMPK GPMOAHABAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB710", Offset = "0x7DCAB10", VA = "0x187DCB710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x7DCB7F0", Offset = "0x7DCABF0", VA = "0x187DCB7F0")]
	protected PNAINFJABOK(OJEJNDLACBE OOHICOOKFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x7DCB600", Offset = "0x7DCAA00", VA = "0x187DCB600")]
	protected void COHAOGFFGHO(string CCHFBHIEDLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct OELMCGGELDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public Dictionary<Guid, List<CJFDGNGNJMA>> ABBEHKLIGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public Dictionary<Guid, List<CJFDGNGNJMA>> FLLGIADDEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public Dictionary<Guid, List<CJFDGNGNJMA>> JAICLLAHOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public List<Guid> OAOONBFLDND;

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5D30", Offset = "0x7DC5130", VA = "0x187DC5D30")]
	public static OELMCGGELDP FCPELJIOJPN(LAGOIFMOJDA DCHKFKLALGC, LELMIIPMAGF FDFDFNPGAHJ, DOFGKDAOBGJ BIOKMAOMLBN)
	{
		return default(OELMCGGELDP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct NJGHPEMBKCJ
{
	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60")]
	public static NJGHPEMBKCJ GEEFBNOOFMP()
	{
		return default(NJGHPEMBKCJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct KPGEMMPIFAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public readonly FGPODGGHBLK POAGMGLMAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public readonly PNGEIJCJKOB EJMLDJCHLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public readonly Guid? JMFGCPHCPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public readonly IReadOnlyCollection<EHCMNNBMDKN> BJHMIJGOJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public readonly IReadOnlyCollection<EHCMNNBMDKN> AANNMKMHHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public readonly LOFGJIDOAFO IEFIJIFMMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public readonly LOFGJIDOAFO ODGDPEFBEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public readonly LIAJNBDKFAJ GCHMMOJKJCB;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool GIMJBIBGNPB
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x7DC27D0", Offset = "0x7DC1BD0", VA = "0x187DC27D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC2860", Offset = "0x7DC1C60", VA = "0x187DC2860")]
	public KPGEMMPIFAK(FGPODGGHBLK POAGMGLMAJP, PNGEIJCJKOB EJMLDJCHLNC, Guid? JMFGCPHCPKI, IReadOnlyList<EHCMNNBMDKN> BJHMIJGOJHP, IReadOnlyCollection<EHCMNNBMDKN> AANNMKMHHBI, LOFGJIDOAFO IEFIJIFMMAE, LOFGJIDOAFO ODGDPEFBEOA, LIAJNBDKFAJ GCHMMOJKJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct GOMILOPBJHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private readonly OJEJNDLACBE OOHICOOKFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private readonly Guid JEIFOACBHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private bool LAKNLJKLEMJ;

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC040", Offset = "0x7DBB440", VA = "0x187DBC040")]
	public static GOMILOPBJHO IJCECJKCGFL(OJEJNDLACBE OOHICOOKFFI)
	{
		return default(GOMILOPBJHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x10482A0", Offset = "0x10476A0", VA = "0x1810482A0")]
	public void PEOKLIMHFJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBE00", Offset = "0x7DBB200", VA = "0x187DBBE00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC110", Offset = "0x7DBB510", VA = "0x187DBC110")]
	private GOMILOPBJHO(OJEJNDLACBE OOHICOOKFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBE10", Offset = "0x7DBB210", VA = "0x187DBBE10")]
	private void FBLIAOELNLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC070", Offset = "0x7DBB470", VA = "0x187DBC070")]
	private Func<Guid, bool> JMAHCBIHGNN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal class OHHDBCHDCIF : PNAINFJABOK, FPEDHPDMHAE
{
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	public delegate Task<LELMIIPMAGF> CMFGNJLLHMD(DOFGKDAOBGJ MJFOKKFMONL, OBHLNLCOGME CGDNPNCILLB, CJKDPIKNJOA BBHPHMEEOGB, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct ILJGKKBCEID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public LDGKNLKOAHN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private GOMILOPBJHO <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter<MGPKNNLHNMP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEB80", Offset = "0x7DBDF80", VA = "0x187DBEB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF450", Offset = "0x7DBE850", VA = "0x187DBF450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct FJNDLFCBGND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public AsyncTaskMethodBuilder<MGPKNNLHNMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public LDGKNLKOAHN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private PGLLJHOKMII<string>.GLACLJPMODI <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private TaskAwaiter<MGPKNNLHNMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7790", Offset = "0x7DB6B90", VA = "0x187DB7790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7BC0", Offset = "0x7DB6FC0", VA = "0x187DB7BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct PCFDKLLMMHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public LDGKNLKOAHN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private PGLLJHOKMII<string>.GLACLJPMODI <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x7DCA690", Offset = "0x7DC9A90", VA = "0x187DCA690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x7DCACD0", Offset = "0x7DCA0D0", VA = "0x187DCACD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class JMAJPDCGBDG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013C")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			public AsyncTaskMethodBuilder<KPGEMMPIFAK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E6")]
			public JMAJPDCGBDG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E7")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			private KPGEMMPIFAK <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			private TaskAwaiter<LELMIIPMAGF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004EA")]
			private TaskAwaiter<KPGEMMPIFAK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x7DCB850", Offset = "0x7DCAC50", VA = "0x187DCB850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x7DCC040", Offset = "0x7DCB440", VA = "0x187DCC040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013D")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			public AsyncTaskMethodBuilder<DOFGKDAOBGJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			public JMAJPDCGBDG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			private DOFGKDAOBGJ <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			private TaskAwaiter<LELMIIPMAGF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			private TaskAwaiter<DOFGKDAOBGJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x7DCC0B0", Offset = "0x7DCB4B0", VA = "0x187DCC0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x7DCC730", Offset = "0x7DCBB30", VA = "0x187DCC730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public LDGKNLKOAHN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CJKDPIKNJOA preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public CJKDPIKNJOA downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public KPGEMMPIFAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public CJKDPIKNJOA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public DOFGKDAOBGJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public PFCIJBPOHAL.GHMOGAJJENN <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JMAJPDCGBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1430", Offset = "0x7DC0830", VA = "0x187DC1430")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<KPGEMMPIFAK> MPIMDNNNAGE(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1310", Offset = "0x7DC0710", VA = "0x187DC1310")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<DOFGKDAOBGJ> HNKNPKPCFHP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1580", Offset = "0x7DC0980", VA = "0x187DC1580")]
		internal void PCCHFHCPAHB(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1050", Offset = "0x7DC0450", VA = "0x187DC1050")]
		internal Task FEGJBEJJCHH(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x7DC11B0", Offset = "0x7DC05B0", VA = "0x187DC11B0")]
		internal Task FKELOCGNNDD(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct KOCCNCGDDDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public LDGKNLKOAHN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private JMAJPDCGBDG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private TaskAwaiter<KPGEMMPIFAK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private TaskAwaiter<DOFGKDAOBGJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1A20", Offset = "0x7DC0E20", VA = "0x187DC1A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2770", Offset = "0x7DC1B70", VA = "0x187DC2770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct HNLAALHNHAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public DOFGKDAOBGJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public CJKDPIKNJOA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private TaskAwaiter<LELMIIPMAGF> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private OBHLNLCOGME <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7DBCB80", Offset = "0x7DBBF80", VA = "0x187DBCB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDC90", Offset = "0x7DBD090", VA = "0x187DBDC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct FHJEPCGGPCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6E70", Offset = "0x7DB6270", VA = "0x187DB6E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7730", Offset = "0x7DB6B30", VA = "0x187DB7730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct AMGGDCCOBMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public CJKDPIKNJOA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private PGLLJHOKMII<string>.GLACLJPMODI <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter<LELMIIPMAGF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7DCD310", Offset = "0x7DCC710", VA = "0x187DCD310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7DCDB50", Offset = "0x7DCCF50", VA = "0x187DCDB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct MFNIFAHLIBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder<LELMIIPMAGF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public CJKDPIKNJOA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private PGLLJHOKMII<string>.GLACLJPMODI <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private TaskAwaiter<LELMIIPMAGF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE5B0", Offset = "0x7DDD9B0", VA = "0x187DDE5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF570", Offset = "0x7DDE970", VA = "0x187DDF570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct CJCMOGEGPIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public AsyncTaskMethodBuilder<LELMIIPMAGF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public CJKDPIKNJOA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public OBHLNLCOGME timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private PGLLJHOKMII<string>.GLACLJPMODI <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private TaskAwaiter<LELMIIPMAGF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1F90", Offset = "0x7DD1390", VA = "0x187DD1F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD30A0", Offset = "0x7DD24A0", VA = "0x187DD30A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct LBKBPPHBMEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public AsyncTaskMethodBuilder<LELMIIPMAGF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public LELMIIPMAGF operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public CJKDPIKNJOA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public DOFGKDAOBGJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private TaskAwaiter<LELMIIPMAGF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC4C0", Offset = "0x7DDB8C0", VA = "0x187DDC4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC710", Offset = "0x7DDBB10", VA = "0x187DDC710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class BMAOEBFLIID
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000147")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			public AsyncTaskMethodBuilder<LELMIIPMAGF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			public BMAOEBFLIID <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			private CPNFFAJCLON <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			private TaskAwaiter<LELMIIPMAGF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x7DE4D60", Offset = "0x7DE4160", VA = "0x187DE4D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x7DE5380", Offset = "0x7DE4780", VA = "0x187DE5380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public CJKDPIKNJOA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public CMFGNJLLHMD masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public OBHLNLCOGME timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public LELMIIPMAGF originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public BMAOEBFLIID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x7DD01A0", Offset = "0x7DCF5A0", VA = "0x187DD01A0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<LELMIIPMAGF> OLCEEAIEJMJ(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct BIOFKGBMPIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public AsyncTaskMethodBuilder<LELMIIPMAGF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public CJKDPIKNJOA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public CMFGNJLLHMD masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public OBHLNLCOGME timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private TaskAwaiter<LELMIIPMAGF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x7DCFC10", Offset = "0x7DCF010", VA = "0x187DCFC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7DD0130", Offset = "0x7DCF530", VA = "0x187DD0130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct NLLFFMJLBNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public CJKDPIKNJOA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private LELMIIPMAGF <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private IEnumerator<LELMIIPMAGF> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private TaskAwaiter<LELMIIPMAGF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0C90", Offset = "0x7DE0090", VA = "0x187DE0C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x7DE11F0", Offset = "0x7DE05F0", VA = "0x187DE11F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct IBOCEPAGHNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9800", Offset = "0x7DD8C00", VA = "0x187DD9800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9AF0", Offset = "0x7DD8EF0", VA = "0x187DD9AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct HJMLPFAOIEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9580", Offset = "0x7DD8980", VA = "0x187DD9580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x7DD97A0", Offset = "0x7DD8BA0", VA = "0x187DD97A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class NMLKDBDDFKP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014D")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			public AsyncTaskMethodBuilder<LELMIIPMAGF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			public NMLKDBDDFKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			public DOFGKDAOBGJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			public CJKDPIKNJOA progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			private TaskAwaiter<LELMIIPMAGF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			private TaskAwaiter<ALNOBMEGHGO> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x7DE53F0", Offset = "0x7DE47F0", VA = "0x187DE53F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x7DE5EC0", Offset = "0x7DE52C0", VA = "0x187DE5EC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public FBCNBLKDKGB mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public NMLKDBDDFKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1250", Offset = "0x7DE0650", VA = "0x187DE1250")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<LELMIIPMAGF> HDGDDBMAGAA(DOFGKDAOBGJ data, OBHLNLCOGME _, CJKDPIKNJOA progressTracker, PGLLJHOKMII<string>.GLACLJPMODI stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct PCCPDNPMKMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public DOFGKDAOBGJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public CJKDPIKNJOA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private NMLKDBDDFKP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private OBHLNLCOGME <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private TaskAwaiter<LELMIIPMAGF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2490", Offset = "0x7DE1890", VA = "0x187DE2490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3350", Offset = "0x7DE2750", VA = "0x187DE3350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct CILLNDPOCLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1B30", Offset = "0x7DD0F30", VA = "0x187DD1B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1F30", Offset = "0x7DD1330", VA = "0x187DD1F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct FMGGNCNPBLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public AsyncTaskMethodBuilder<LELMIIPMAGF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public OHHDBCHDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public CJKDPIKNJOA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private PGLLJHOKMII<string>.GLACLJPMODI <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<LELMIIPMAGF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5620", Offset = "0x7DD4A20", VA = "0x187DD5620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5C40", Offset = "0x7DD5040", VA = "0x187DD5C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private readonly JBBPIGEHCDP DDDEHMKKPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private readonly JBBPIGEHCDP GAAIIHCNIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private readonly OGIKFOGELKN INEKFIKKIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private readonly GFFJLJGCGCA BPOLIEKHJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private readonly IMMGFLGNCGF MHJHDCOBHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private ProfilerCounterValue<int> PMMMCALLABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private readonly IIPINPOLBCP KGCNIPPAIAO;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private KBABJPFHBFP MAJHNGEJJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x7DC7640", Offset = "0x7DC6A40", VA = "0x187DC7640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event OJABBGPCOCO MOMJALIGJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x7DC89A0", Offset = "0x7DC7DA0", VA = "0x187DC89A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x7DC7600", Offset = "0x7DC6A00", VA = "0x187DC7600", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8FB0", Offset = "0x7DC83B0", VA = "0x187DC8FB0")]
	public OHHDBCHDCIF(OJEJNDLACBE OOHICOOKFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x7DC86D0", Offset = "0x7DC7AD0", VA = "0x187DC86D0")]
	[AsyncStateMachine(typeof(ILJGKKBCEID))]
	public Task LMNELMINPPI(LDGKNLKOAHN NKKKCKHLGCJ, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x7DC82A0", Offset = "0x7DC76A0", VA = "0x187DC82A0")]
	[AsyncStateMachine(typeof(FJNDLFCBGND))]
	private Task<MGPKNNLHNMP> LCALOGLNFIB(LDGKNLKOAHN NKKKCKHLGCJ, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8400", Offset = "0x7DC7800", VA = "0x187DC8400")]
	[AsyncStateMachine(typeof(PCFDKLLMMHI))]
	private Task LJANPFAFCIA(LDGKNLKOAHN NKKKCKHLGCJ, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8E70", Offset = "0x7DC8270", VA = "0x187DC8E70")]
	[AsyncStateMachine(typeof(KOCCNCGDDDD))]
	private Task PHIEMBDKBNA(LDGKNLKOAHN NKKKCKHLGCJ, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken DHIBPINJCDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7BA0", Offset = "0x7DC6FA0", VA = "0x187DC7BA0")]
	[AsyncStateMachine(typeof(HNLAALHNHAN))]
	private Task HAIIJHGJKEC(DOFGKDAOBGJ MEJKLJBMJCB, CJKDPIKNJOA HPIBJCMHLIM, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken HOKCMMLLHKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7670", Offset = "0x7DC6A70", VA = "0x187DC7670")]
	[AsyncStateMachine(typeof(FHJEPCGGPCH))]
	private Task EGGBBMMOLPP(PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8AF0", Offset = "0x7DC7EF0", VA = "0x187DC8AF0")]
	[AsyncStateMachine(typeof(AMGGDCCOBMA))]
	private Task MPEIMJGAOAJ(DOFGKDAOBGJ MJFOKKFMONL, CJKDPIKNJOA BBHPHMEEOGB, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC73F0", Offset = "0x7DC67F0", VA = "0x187DC73F0")]
	[AsyncStateMachine(typeof(MFNIFAHLIBO))]
	private Task<LELMIIPMAGF> ALHOABGEJBJ(DOFGKDAOBGJ MJFOKKFMONL, OBHLNLCOGME JLFGMKPBEPP, CJKDPIKNJOA BBHPHMEEOGB, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7780", Offset = "0x7DC6B80", VA = "0x187DC7780")]
	[AsyncStateMachine(typeof(CJCMOGEGPIP))]
	private Task<LELMIIPMAGF> FBDLHOEJIIN(DOFGKDAOBGJ MJFOKKFMONL, OBHLNLCOGME JLFGMKPBEPP, CJKDPIKNJOA BBHPHMEEOGB, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8820", Offset = "0x7DC7C20", VA = "0x187DC8820")]
	[AsyncStateMachine(typeof(LBKBPPHBMEH))]
	private Task<LELMIIPMAGF> LPMOMCPLCHM(LELMIIPMAGF FDFDFNPGAHJ, DOFGKDAOBGJ BIOKMAOMLBN, CJKDPIKNJOA BBHPHMEEOGB, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF, bool IBMPHMMEMBB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x7DC89C0", Offset = "0x7DC7DC0", VA = "0x187DC89C0")]
	private bool MNEMEGPKFBO(DOFGKDAOBGJ MEJKLJBMJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8C50", Offset = "0x7DC8050", VA = "0x187DC8C50")]
	[AsyncStateMachine(typeof(BIOFKGBMPIA))]
	protected Task<LELMIIPMAGF> NDFAEDDCEJP(DOFGKDAOBGJ MJFOKKFMONL, OBHLNLCOGME JLFGMKPBEPP, CJKDPIKNJOA BBHPHMEEOGB, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF, CMFGNJLLHMD IJPFCDIJNJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8540", Offset = "0x7DC7940", VA = "0x187DC8540")]
	[AsyncStateMachine(typeof(NLLFFMJLBNG))]
	private Task LJCHDDECLGJ(DOFGKDAOBGJ MJFOKKFMONL, CJKDPIKNJOA BBHPHMEEOGB, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8E20", Offset = "0x7DC8220", VA = "0x187DC8E20")]
	private void OINEAPFAGFD(LELMIIPMAGF BEDFLIFKGKJ, CJKDPIKNJOA BBHPHMEEOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8AB0", Offset = "0x7DC7EB0", VA = "0x187DC8AB0")]
	private void MPDJIHLEOGG(LELMIIPMAGF MLBKHOEDPJM, [Out] LELMIIPMAGF HKKGGMJOMDD, [Out] LELMIIPMAGF EIAMADPCIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8690", Offset = "0x7DC7A90", VA = "0x187DC8690")]
	private Task<KPGEMMPIFAK> LLPBPNHHFEC(LDGKNLKOAHN NKKKCKHLGCJ, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7F20", Offset = "0x7DC7320", VA = "0x187DC7F20")]
	private Task<DOFGKDAOBGJ> HOFKHNOAIMA(KPGEMMPIFAK MJFOKKFMONL, PFCIJBPOHAL.GHMOGAJJENN MBMLLOLGJDN, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8150", Offset = "0x7DC7550", VA = "0x187DC8150")]
	[AsyncStateMachine(typeof(IBOCEPAGHNM))]
	private Task LBDMNIFOCOD(DOFGKDAOBGJ MJFOKKFMONL, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF, bool EOMIAOBGBFE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7CF0", Offset = "0x7DC70F0", VA = "0x187DC7CF0")]
	[AsyncStateMachine(typeof(HJMLPFAOIEF))]
	private Task HGCHDNJAJBH(DOFGKDAOBGJ MJFOKKFMONL, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7F80", Offset = "0x7DC7380", VA = "0x187DC7F80")]
	private Task JEBFKGLFMLP(DOFGKDAOBGJ MJFOKKFMONL, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8E00", Offset = "0x7DC8200", VA = "0x187DC8E00")]
	private Task OECPGDNKGEH(DOFGKDAOBGJ MJFOKKFMONL, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7620", Offset = "0x7DC6A20", VA = "0x187DC7620")]
	private Task BLNEBAJANIF(DOFGKDAOBGJ MJFOKKFMONL, OBHLNLCOGME JLFGMKPBEPP, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8DE0", Offset = "0x7DC81E0", VA = "0x187DC8DE0")]
	private Task OAJJOPIMFOM(DOFGKDAOBGJ MJFOKKFMONL, OBHLNLCOGME JLFGMKPBEPP, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8C40", Offset = "0x7DC8040", VA = "0x187DC8C40")]
	private static Task MPOBJKOBBCC(CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7900", Offset = "0x7DC6D00", VA = "0x187DC7900")]
	private Task GCLGAAKBAFJ(DOFGKDAOBGJ MJFOKKFMONL, OBHLNLCOGME JLFGMKPBEPP, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7F60", Offset = "0x7DC7360", VA = "0x187DC7F60")]
	private Task IBMHKPCAKMD(DOFGKDAOBGJ MJFOKKFMONL, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8100", Offset = "0x7DC7500", VA = "0x187DC8100")]
	private void KOMODIFNKBL(LDGKNLKOAHN NKKKCKHLGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7550", Offset = "0x7DC6950", VA = "0x187DC7550")]
	public void BEJALEOLDEJ(long FNPIGGMFPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	private static void KJHDAACGJDJ(FGPODGGHBLK POAGMGLMAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7FB0", Offset = "0x7DC73B0", VA = "0x187DC7FB0")]
	[AsyncStateMachine(typeof(PCCPDNPMKMP))]
	private Task KNPJMDADODF(DOFGKDAOBGJ MEJKLJBMJCB, CJKDPIKNJOA HPIBJCMHLIM, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken HOKCMMLLHKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7DE0", Offset = "0x7DC71E0", VA = "0x187DC7DE0")]
	[AsyncStateMachine(typeof(CILLNDPOCLM))]
	private Task HMGMLNEFGEE(DOFGKDAOBGJ MJFOKKFMONL, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7A80", Offset = "0x7DC6E80", VA = "0x187DC7A80")]
	private static PNOBPLGGKAA GEFDEEIKHCI(DOFGKDAOBGJ BIOKMAOMLBN)
	{
		return default(PNOBPLGGKAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7920", Offset = "0x7DC6D20", VA = "0x187DC7920")]
	[AsyncStateMachine(typeof(FMGGNCNPBLE))]
	private Task<LELMIIPMAGF> GDOFLNDKMIN(DOFGKDAOBGJ MJFOKKFMONL, OBHLNLCOGME JLFGMKPBEPP, CJKDPIKNJOA BBHPHMEEOGB, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	private void GJEEAPHHCAO(LELMIIPMAGF BCIEDHDFABL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct NONGKFDDEGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private DOFGKDAOBGJ MJFOKKFMONL;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	private LAGOIFMOJDA JIOKCOHMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x7DE16A0", Offset = "0x7DE0AA0", VA = "0x187DE16A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x7DE13B0", Offset = "0x7DE07B0", VA = "0x187DE13B0")]
	public static Task GNAFMGAEBCA(KBABJPFHBFP OKINEPMMKIG, DOFGKDAOBGJ MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1490", Offset = "0x7DE0890", VA = "0x187DE1490")]
	private void GNAFMGAEBCA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal struct HELBJIGCHPO
{
	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9230", Offset = "0x7DD8630", VA = "0x187DD9230")]
	public static Task GNAFMGAEBCA(CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct IFKDLJBPFGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct DJBDNIAKINB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public OJEJNDLACBE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private PGLLJHOKMII<string>.GLACLJPMODI <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x7DD42A0", Offset = "0x7DD36A0", VA = "0x187DD42A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x7DD47D0", Offset = "0x7DD3BD0", VA = "0x187DD47D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA180", Offset = "0x7DD9580", VA = "0x187DDA180")]
	[AsyncStateMachine(typeof(DJBDNIAKINB))]
	public static Task GNAFMGAEBCA(OJEJNDLACBE OOHICOOKFFI, DOFGKDAOBGJ MJFOKKFMONL, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct PHOBJKFAJEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct KNNIFIILEJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public OJEJNDLACBE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public OBHLNLCOGME timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private KBABJPFHBFP <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private LAGOIFMOJDA <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private LELMIIPMAGF <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private CPNFFAJCLON <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private List<(PersistenceView, FMDAPGFGAFB)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private FMDAPGFGAFB <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB790", Offset = "0x7DDAB90", VA = "0x187DDB790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC460", Offset = "0x7DDB860", VA = "0x187DDC460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x7DE33B0", Offset = "0x7DE27B0", VA = "0x187DE33B0")]
	[AsyncStateMachine(typeof(KNNIFIILEJJ))]
	public static Task GNAFMGAEBCA(OJEJNDLACBE OOHICOOKFFI, DOFGKDAOBGJ MJFOKKFMONL, OBHLNLCOGME JLFGMKPBEPP, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3500", Offset = "0x7DE2900", VA = "0x187DE3500")]
	private static void MIPGFBAALLI(PersistenceView GOGEGHBLCKJ, FMDAPGFGAFB MCHMPDGPNBP, DOFGKDAOBGJ MJFOKKFMONL, LELMIIPMAGF FDFDFNPGAHJ, bool CMMBLHEIHNH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct MAPMGEKJOJI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct LPCGCDCFOAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public KBABJPFHBFP roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private CPNFFAJCLON <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD640", Offset = "0x7DDCA40", VA = "0x187DDD640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x7DDDC60", Offset = "0x7DDD060", VA = "0x187DDDC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE490", Offset = "0x7DDD890", VA = "0x187DDE490")]
	[AsyncStateMachine(typeof(LPCGCDCFOAA))]
	public static Task GNAFMGAEBCA(KBABJPFHBFP OKINEPMMKIG, DOFGKDAOBGJ MJFOKKFMONL, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct GCLNLCNKMLB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct HIFDMANMLLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public KBABJPFHBFP roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public OJEJNDLACBE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9310", Offset = "0x7DD8710", VA = "0x187DD9310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9520", Offset = "0x7DD8920", VA = "0x187DD9520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class CLANGIOLOBK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200015D")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			public PGLLJHOKMII<string>.GLACLJPMODI timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			public CLANGIOLOBK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x7DE6250", Offset = "0x7DE5650", VA = "0x187DE6250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x7DE65E0", Offset = "0x7DE59E0", VA = "0x187DE65E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public CLANGIOLOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3110", Offset = "0x7DD2510", VA = "0x187DD3110")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task HOCMKHDIADG(PGLLJHOKMII<string>.GLACLJPMODI timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct PLKJMJAHMFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public GCLNLCNKMLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private CPNFFAJCLON <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private TaskAwaiter<MGPKNNLHNMP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x7DE36F0", Offset = "0x7DE2AF0", VA = "0x187DE36F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x7DE42F0", Offset = "0x7DE36F0", VA = "0x187DE42F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class OIMGGACAMDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public AHDANNFMFFK version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OIMGGACAMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x7DE22B0", Offset = "0x7DE16B0", VA = "0x187DE22B0")]
		internal object PFOHLKDIANF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2200", Offset = "0x7DE1600", VA = "0x187DE2200")]
		internal object HMFFFCONGBL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B6")]
	private KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B7")]
	private DOFGKDAOBGJ MJFOKKFMONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	private OJEJNDLACBE OOHICOOKFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private bool EOMIAOBGBFE;

	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private static readonly ByteString ILNJIDCAAIC;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	private LAGOIFMOJDA JIOKCOHMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DD68F0", Offset = "0x7DD5CF0", VA = "0x187DD68F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private MONKCCHOMPK GPMOAHABAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6850", Offset = "0x7DD5C50", VA = "0x187DD6850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5E00", Offset = "0x7DD5200", VA = "0x187DD5E00")]
	[AsyncStateMachine(typeof(HIFDMANMLLK))]
	public static Task GNAFMGAEBCA(KBABJPFHBFP OKINEPMMKIG, DOFGKDAOBGJ MJFOKKFMONL, OJEJNDLACBE OOHICOOKFFI, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF, bool EOMIAOBGBFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5F50", Offset = "0x7DD5350", VA = "0x187DD5F50")]
	[AsyncStateMachine(typeof(PLKJMJAHMFJ))]
	private Task GNAFMGAEBCA(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6080", Offset = "0x7DD5480", VA = "0x187DD6080")]
	private void JGIPOHBCFCH([NotNull] OIBKBLGJIPN PMELHKPACLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5DC0", Offset = "0x7DD51C0", VA = "0x187DD5DC0")]
	private bool AJIIPNECMGG(AHDANNFMFFK IFKCKGNMHDI, OIBKBLGJIPN PMELHKPACLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct CIJPNDMDNPI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct CFDBIEBBOFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public AsyncTaskMethodBuilder<DOFGKDAOBGJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public CIJPNDMDNPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public PFCIJBPOHAL.GHMOGAJJENN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private PGLLJHOKMII<string>.GLACLJPMODI <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private TaskAwaiter<IReadOnlyCollection<EHCMNNBMDKN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private TaskAwaiter<(PHLGGJNOBDN<DOLPFMIDMMB, OGPHAGHJAIC>, PHLGGJNOBDN<NOINHDPCAGF<OIBKBLGJIPN>, OGPHAGHJAIC>, PHLGGJNOBDN<NOINHDPCAGF<LDEPJGKAOIB>, OGPHAGHJAIC>, PHLGGJNOBDN<NOINHDPCAGF<IEnumerable<MAIGHNLLPKA>>, OGPHAGHJAIC>, PHLGGJNOBDN<NOINHDPCAGF<PLFDEBDPAHA>, OGPHAGHJAIC>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7DD02C0", Offset = "0x7DCF6C0", VA = "0x187DD02C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7DD10A0", Offset = "0x7DD04A0", VA = "0x187DD10A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct CNMCCJEPFKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<DOLPFMIDMMB, OGPHAGHJAIC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public PGLLJHOKMII<string>.GLACLJPMODI downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public CIJPNDMDNPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public IReadOnlyCollection<EHCMNNBMDKN> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public IReadOnlyCollection<EHCMNNBMDKN> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public PFCIJBPOHAL.GHMOGAJJENN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private TaskAwaiter<PHLGGJNOBDN<DOLPFMIDMMB, OGPHAGHJAIC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3BD0", Offset = "0x7DD2FD0", VA = "0x187DD3BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4230", Offset = "0x7DD3630", VA = "0x187DD4230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private IKILMCFABBM<LOFGJIDOAFO, LDEPJGKAOIB> BOPHKAIKHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private IKILMCFABBM<LOFGJIDOAFO, OIBKBLGJIPN> CKPPBEJDEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private IKILMCFABBM<LIAJNBDKFAJ, IEnumerable<MAIGHNLLPKA>> CPKJKNAILOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private IKILMCFABBM<long, PLFDEBDPAHA> HNOPCPKHEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private GNAMIPCKPFJ ECIBOCCBCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private FGPODGGHBLK POAGMGLMAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private PNGEIJCJKOB EJMLDJCHLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private Guid? JMFGCPHCPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private IReadOnlyCollection<EHCMNNBMDKN> BJHMIJGOJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private Task<IReadOnlyCollection<EHCMNNBMDKN>> IIIAILKFIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private LOFGJIDOAFO IEFIJIFMMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private LOFGJIDOAFO ODGDPEFBEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private LOFGJIDOAFO? KPPLCMKCBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private LIAJNBDKFAJ GCHMMOJKJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	private PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ;

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1630", Offset = "0x7DD0A30", VA = "0x187DD1630")]
	public static Task<DOFGKDAOBGJ> LBJOONIIDJF(KBABJPFHBFP OKINEPMMKIG, [In] KPGEMMPIFAK MJFOKKFMONL, PFCIJBPOHAL.GHMOGAJJENN MBMLLOLGJDN, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1480", Offset = "0x7DD0880", VA = "0x187DD1480")]
	[AsyncStateMachine(typeof(CFDBIEBBOFC))]
	private Task<DOFGKDAOBGJ> GNAFMGAEBCA(PFCIJBPOHAL.GHMOGAJJENN MBMLLOLGJDN, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1250", Offset = "0x7DD0650", VA = "0x187DD1250")]
	[AsyncStateMachine(typeof(CNMCCJEPFKG))]
	private Task<PHLGGJNOBDN<DOLPFMIDMMB, OGPHAGHJAIC>> CKOMNGGDCAI(Guid? JMFGCPHCPKI, IReadOnlyCollection<EHCMNNBMDKN> BJHMIJGOJHP, IReadOnlyCollection<EHCMNNBMDKN> AANNMKMHHBI, long? LFNEDMLHPHM, long? BEGDDCHOHOL, PFCIJBPOHAL.GHMOGAJJENN MBMLLOLGJDN, PGLLJHOKMII<string>.GLACLJPMODI ONKOJBMFLCG, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct LJOMPKEEDOG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct NHNBJOGMECF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public AsyncTaskMethodBuilder<KPGEMMPIFAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public LJOMPKEEDOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private PGLLJHOKMII<string>.GLACLJPMODI <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter<KPGEMMPIFAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x7DE07D0", Offset = "0x7DDFBD0", VA = "0x187DE07D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0C20", Offset = "0x7DE0020", VA = "0x187DE0C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct FJDIAHMBMAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public AsyncTaskMethodBuilder<KPGEMMPIFAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public LJOMPKEEDOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private TaskAwaiter<KPGEMMPIFAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4E10", Offset = "0x7DD4210", VA = "0x187DD4E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5260", Offset = "0x7DD4660", VA = "0x187DD5260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class LFCBJFAKCPK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000625")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000626")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000627")]
			public LFCBJFAKCPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000628")]
			private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000629")]
			private TaskAwaiter<GLMHKJIINJI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			private TaskAwaiter<CBLOAIMJMAA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x7DE4350", Offset = "0x7DE3750", VA = "0x187DE4350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x7DE4D00", Offset = "0x7DE4100", VA = "0x187DE4D00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public HCHBLHNLCND roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public LAGOIFMOJDA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public LOFGJIDOAFO superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public LOFGJIDOAFO subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public IReadOnlyList<EHCMNNBMDKN> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public IReadOnlyList<EHCMNNBMDKN> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LFCBJFAKCPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xD50E80", Offset = "0xD50280", VA = "0x180D50E80")]
		internal bool HGDNCCNHNAM(PNGEIJCJKOB sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC780", Offset = "0x7DDBB80", VA = "0x187DDC780")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task CKOLMABCCCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC850", Offset = "0x7DDBC50", VA = "0x187DDC850")]
		internal Task<LIAJNBDKFAJ> NKPLGAENMHA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct BCOGGMEPPJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder<KPGEMMPIFAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public HCHBLHNLCND roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public LAGOIFMOJDA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public LOFGJIDOAFO superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private LFCBJFAKCPK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private FGPODGGHBLK <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private PNGEIJCJKOB <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private Task<LIAJNBDKFAJ> <getRoomLoadDTOTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private TaskAwaiter<FGPODGGHBLK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private TaskAwaiter<LIAJNBDKFAJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE810", Offset = "0x7DCDC10", VA = "0x187DCE810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF930", Offset = "0x7DCED30", VA = "0x187DCF930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000601")]
	private LAGOIFMOJDA DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000602")]
	private OGIKFOGELKN INEKFIKKIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private HCHBLHNLCND MDJNJHHNPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private long LFNEDMLHPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	private long FHAJBLMHDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private long BDNECDKPHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private string IICKCAKFCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private LOFGJIDOAFO LHJPBGKALII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private Guid HFGCBAMBCDD;

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD0D0", Offset = "0x7DDC4D0", VA = "0x187DDD0D0")]
	public static Task<KPGEMMPIFAK> LBJOONIIDJF(KBABJPFHBFP OKINEPMMKIG, LDGKNLKOAHN NKKKCKHLGCJ, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCF80", Offset = "0x7DDC380", VA = "0x187DDCF80")]
	[AsyncStateMachine(typeof(NHNBJOGMECF))]
	private Task<KPGEMMPIFAK> GNAFMGAEBCA(CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD4D0", Offset = "0x7DDC8D0", VA = "0x187DDD4D0")]
	[AsyncStateMachine(typeof(FJDIAHMBMAC))]
	private Task<KPGEMMPIFAK> LLPBPNHHFEC(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD320", Offset = "0x7DDC720", VA = "0x187DDD320")]
	[AsyncStateMachine(typeof(BCOGGMEPPJC))]
	private static Task<KPGEMMPIFAK> LLPBPNHHFEC(LAGOIFMOJDA DCHKFKLALGC, HCHBLHNLCND MDJNJHHNPOF, long LFNEDMLHPHM, long FHAJBLMHDGD, long BDNECDKPHLA, string IICKCAKFCMN, LOFGJIDOAFO LHJPBGKALII, Guid HFGCBAMBCDD, CancellationToken MLAPMBKLAOF, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCF50", Offset = "0x7DDC350", VA = "0x187DDCF50")]
	private void AAAKLNDGCMM(FGPODGGHBLK POAGMGLMAJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
internal struct IFCBFGPNDBN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct NBBOEIFCHLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public IFCBFGPNDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x7DDFD00", Offset = "0x7DDF100", VA = "0x187DDFD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0290", Offset = "0x7DDF690", VA = "0x187DE0290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private LAGOIFMOJDA DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000640")]
	private DOFGKDAOBGJ MJFOKKFMONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	private float CDMDDBCIDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private float CBIGJKJHKPO;

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9B50", Offset = "0x7DD8F50", VA = "0x187DD9B50")]
	public static Task BHNOEOAOBKD(KBABJPFHBFP OKINEPMMKIG, DOFGKDAOBGJ MJFOKKFMONL, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9E70", Offset = "0x7DD9270", VA = "0x187DD9E70")]
	[AsyncStateMachine(typeof(NBBOEIFCHLB))]
	public Task GNAFMGAEBCA(CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA050", Offset = "0x7DD9450", VA = "0x187DDA050")]
	private static void LGGCDEDJGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9CF0", Offset = "0x7DD90F0", VA = "0x187DD9CF0")]
	private void DGEEJABPLAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9F90", Offset = "0x7DD9390", VA = "0x187DD9F90")]
	private static float JLOPIHHICIH(LAGOIFMOJDA DCHKFKLALGC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9E50", Offset = "0x7DD9250", VA = "0x187DD9E50")]
	private static float EIBCIBEMAJD()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200016C")]
internal struct BDKFCOHAJOC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct OEBILGEIHCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public OJEJNDLACBE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private GIELBPOLHAF <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private KBABJPFHBFP <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private HDLLNDFCMOG.AIJMJLKGKPM <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private TaskAwaiter<MGPKNNLHNMP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1980", Offset = "0x7DE0D80", VA = "0x187DE1980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x7DE21A0", Offset = "0x7DE15A0", VA = "0x187DE21A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct CLBPBJGCMFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3230", Offset = "0x7DD2630", VA = "0x187DD3230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3560", Offset = "0x7DD2960", VA = "0x187DD3560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFA60", Offset = "0x7DCEE60", VA = "0x187DCFA60")]
	[AsyncStateMachine(typeof(OEBILGEIHCI))]
	public static Task GNAFMGAEBCA(OJEJNDLACBE OOHICOOKFFI, DOFGKDAOBGJ MJFOKKFMONL, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFBA0", Offset = "0x7DCEFA0", VA = "0x187DCFBA0")]
	private static Task<MGPKNNLHNMP> HMIPCDBIBLF(OJEJNDLACBE OOHICOOKFFI, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x7DCF9A0", Offset = "0x7DCEDA0", VA = "0x187DCF9A0")]
	[AsyncStateMachine(typeof(CLBPBJGCMFK))]
	private static Task CBNNAPCAPMP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
internal struct NPCADKAFPDL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct IJALHCPLGAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public NPCADKAFPDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA2C0", Offset = "0x7DD96C0", VA = "0x187DDA2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA970", Offset = "0x7DD9D70", VA = "0x187DDA970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class CMBAJOIAKDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public CMBAJOIAKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD35C0", Offset = "0x7DD29C0", VA = "0x187DD35C0")]
		internal object IFFEPLMHBHB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct NDKBHJLHNJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public NPCADKAFPDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x7DE02F0", Offset = "0x7DDF6F0", VA = "0x187DE02F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0770", Offset = "0x7DDFB70", VA = "0x187DE0770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	private bool DLLGFBOILLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000661")]
	private CancellationToken MLAPMBKLAOF;

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1820", Offset = "0x7DE0C20", VA = "0x187DE1820")]
	public static Task FLBODLKHCFB(KBABJPFHBFP OKINEPMMKIG, bool DLLGFBOILLE, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken LCHOPNFEEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1890", Offset = "0x7DE0C90", VA = "0x187DE1890")]
	[AsyncStateMachine(typeof(IJALHCPLGAJ))]
	private Task GNAFMGAEBCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x7DE16F0", Offset = "0x7DE0AF0", VA = "0x187DE16F0")]
	[AsyncStateMachine(typeof(NDKBHJLHNJI))]
	private Task DEMEEBAGAHG(bool NENHJLNAGOD, string ENFELFHDLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60")]
	private bool PECALCNDALE(bool DLLGFBOILLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal struct GMKECPOCJJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct ECCLFOFPNMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public GMKECPOCJJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4830", Offset = "0x7DD3C30", VA = "0x187DD4830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4DA0", Offset = "0x7DD41A0", VA = "0x187DD4DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class OKHKFOFLBKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OKHKFOFLBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2390", Offset = "0x7DE1790", VA = "0x187DE2390")]
		internal object IFFEPLMHBHB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct APEACJHMJJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public GMKECPOCJJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE320", Offset = "0x7DCD720", VA = "0x187DCE320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE7A0", Offset = "0x7DCDBA0", VA = "0x187DCE7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private CLDLANJDABJ MODPFJJEMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private bool PKJHDCEANMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private DOFGKDAOBGJ MJFOKKFMONL;

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8420", Offset = "0x7DD7820", VA = "0x187DD8420")]
	public static Task<Scene> BGBGKEEGHND(KBABJPFHBFP OKINEPMMKIG, CLDLANJDABJ NLBFNPOBEEN, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD85F0", Offset = "0x7DD79F0", VA = "0x187DD85F0")]
	[AsyncStateMachine(typeof(ECCLFOFPNMD))]
	private Task<Scene> GNAFMGAEBCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD7B10", VA = "0x187DD8710")]
	private bool NNCGKCGNCHI(DOFGKDAOBGJ MJFOKKFMONL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8740", Offset = "0x7DD7B40", VA = "0x187DD8740")]
	private void PMMBOHIAPOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x7DD84A0", Offset = "0x7DD78A0", VA = "0x187DD84A0")]
	[AsyncStateMachine(typeof(APEACJHMJJD))]
	private Task<Scene> DEMEEBAGAHG(string ENFELFHDLFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal struct IMMGFLGNCGF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct GMIKENEAEMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public AsyncTaskMethodBuilder<LELMIIPMAGF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public IMMGFLGNCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public LELMIIPMAGF nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public DOFGKDAOBGJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private PGLLJHOKMII<string>.GLACLJPMODI <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private TaskAwaiter<LELMIIPMAGF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD78E0", Offset = "0x7DD6CE0", VA = "0x187DD78E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x7DD83B0", Offset = "0x7DD77B0", VA = "0x187DD83B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct FJGIEHAPBBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public AsyncTaskMethodBuilder<LELMIIPMAGF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public IMMGFLGNCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public LELMIIPMAGF state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		private TaskAwaiter<MGPKNNLHNMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x7DD52D0", Offset = "0x7DD46D0", VA = "0x187DD52D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x7DD55B0", Offset = "0x7DD49B0", VA = "0x187DD55B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private readonly OJEJNDLACBE OOHICOOKFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private readonly OGIKFOGELKN INEKFIKKIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private readonly GFFJLJGCGCA BPOLIEKHJBG;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private GIELBPOLHAF CFLLFIOEOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x6324D80", Offset = "0x6324180", VA = "0x186324D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAD00", Offset = "0x7DDA100", VA = "0x187DDAD00")]
	public IMMGFLGNCGF(OJEJNDLACBE OOHICOOKFFI, OGIKFOGELKN INEKFIKKIDI, GFFJLJGCGCA BPOLIEKHJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA9F0", Offset = "0x7DD9DF0", VA = "0x187DDA9F0")]
	[AsyncStateMachine(typeof(GMIKENEAEMH))]
	public Task<LELMIIPMAGF> GFGJJFOBPFM(LELMIIPMAGF BABGIKLBIFE, DOFGKDAOBGJ BIOKMAOMLBN, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF, bool IBMPHMMEMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDABA0", Offset = "0x7DD9FA0", VA = "0x187DDABA0")]
	[AsyncStateMachine(typeof(FJGIEHAPBBB))]
	private Task<LELMIIPMAGF> KIOGAMFLKEB(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, LELMIIPMAGF MLIDEILJAJE, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAB70", Offset = "0x7DD9F70", VA = "0x187DDAB70")]
	private bool HICJNGOENLB(LELMIIPMAGF IHGDFIAPILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA9D0", Offset = "0x7DD9DD0", VA = "0x187DDA9D0")]
	private void COHAOGFFGHO(string DOICNOOOHHG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal struct ADKBHKHFCJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct MLPIHPNBPMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public GIELBPOLHAF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public OBHLNLCOGME timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private CPNFFAJCLON <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private List<(PersistenceView, FMDAPGFGAFB)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private (PersistenceView, FMDAPGFGAFB) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF5E0", Offset = "0x7DDE9E0", VA = "0x187DDF5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x7DDFCA0", Offset = "0x7DDF0A0", VA = "0x187DDFCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x7DCD1D0", Offset = "0x7DCC5D0", VA = "0x187DCD1D0")]
	[AsyncStateMachine(typeof(MLPIHPNBPMJ))]
	public static Task GNAFMGAEBCA(GIELBPOLHAF IFKMLHMDOLM, DOFGKDAOBGJ MJFOKKFMONL, OBHLNLCOGME JLFGMKPBEPP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct CHDENCMIFPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct KNJDEKAELGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public GIELBPOLHAF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public OBHLNLCOGME timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private AHDANNFMFFK <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private CPNFFAJCLON <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private List<(PersistenceView, FMDAPGFGAFB)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private FMDAPGFGAFB <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAE50", Offset = "0x7DDA250", VA = "0x187DDAE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB730", Offset = "0x7DDAB30", VA = "0x187DDB730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1110", Offset = "0x7DD0510", VA = "0x187DD1110")]
	[AsyncStateMachine(typeof(KNJDEKAELGJ))]
	public static Task GNAFMGAEBCA(GIELBPOLHAF IFKMLHMDOLM, DOFGKDAOBGJ MJFOKKFMONL, OBHLNLCOGME JLFGMKPBEPP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal struct HDLLNDFCMOG
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	public struct AIJMJLKGKPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public List<NFPJIIKLFJK> NENGPKIILMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public List<FMDAPGFGAFB> GIFLBALNFHE;

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x9CC970", Offset = "0x9CBD70", VA = "0x1809CC970")]
		public AIJMJLKGKPM(List<NFPJIIKLFJK> NENGPKIILMK, List<FMDAPGFGAFB> GIFLBALNFHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private sealed class FOOHFCBBFDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public IEnumerable<NFPJIIKLFJK> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public FOOHFCBBFDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5CB0", Offset = "0x7DD50B0", VA = "0x187DD5CB0")]
		internal object KHEPIIPOAAM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006B1")]
	private KBABJPFHBFP OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private DOFGKDAOBGJ MJFOKKFMONL;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private LAGOIFMOJDA JIOKCOHMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD91E0", Offset = "0x7DD85E0", VA = "0x187DD91E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9180", Offset = "0x7DD8580", VA = "0x187DD9180")]
	public static AIJMJLKGKPM GNAFMGAEBCA(KBABJPFHBFP OKINEPMMKIG, DOFGKDAOBGJ MJFOKKFMONL)
	{
		return default(AIJMJLKGKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8F30", Offset = "0x7DD8330", VA = "0x187DD8F30")]
	private AIJMJLKGKPM GNAFMGAEBCA()
	{
		return default(AIJMJLKGKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD87B0", Offset = "0x7DD7BB0", VA = "0x187DD87B0")]
	private AIJMJLKGKPM BBBIPFNNPND(OIBKBLGJIPN PMELHKPACLM, AHDANNFMFFK MOKHPNPCEGA)
	{
		return default(AIJMJLKGKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8D60", Offset = "0x7DD8160", VA = "0x187DD8D60")]
	private bool EGPDMBEJCIE(IEnumerable<NFPJIIKLFJK> NENGPKIILMK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct LIOPCDLBFCK
{
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class PCBBNNMCLPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public HDLLNDFCMOG.AIJMJLKGKPM instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public PCBBNNMCLPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x7DE23E0", Offset = "0x7DE17E0", VA = "0x187DE23E0")]
		internal object HOCMKHDIADG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class FPPIPCBAIAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public FPPIPCBAIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5D30", Offset = "0x7DD5130", VA = "0x187DD5D30")]
		internal object IKFGKHACJPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC9A0", Offset = "0x7DDBDA0", VA = "0x187DDC9A0")]
	public static void GNAFMGAEBCA(GIELBPOLHAF IFKMLHMDOLM, DOFGKDAOBGJ MJFOKKFMONL, HDLLNDFCMOG.AIJMJLKGKPM BBGOBGEHIHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class GFFJLJGCGCA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct LPGBFIKLJPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public GFFJLJGCGCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public LELMIIPMAGF operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public DOFGKDAOBGJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x7DDDCC0", Offset = "0x7DDD0C0", VA = "0x187DDDCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE430", Offset = "0x7DDD830", VA = "0x187DDE430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class KIBOAPJACKM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000187")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			public KIBOAPJACKM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x7DE5F30", Offset = "0x7DE5330", VA = "0x187DE5F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x7DE61F0", Offset = "0x7DE55F0", VA = "0x187DE61F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public GFFJLJGCGCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public PGLLJHOKMII<string>.GLACLJPMODI handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public KIBOAPJACKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAD60", Offset = "0x7DDA160", VA = "0x187DDAD60")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task LECLALMHLHG(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private struct CNCJIBPPJKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public GFFJLJGCGCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private KIBOAPJACKM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3640", Offset = "0x7DD2A40", VA = "0x187DD3640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3B70", Offset = "0x7DD2F70", VA = "0x187DD3B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct ANDKGLOEKNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public GFFJLJGCGCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private Dictionary<Guid, List<CJFDGNGNJMA>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x7DCDBB0", Offset = "0x7DCCFB0", VA = "0x187DCDBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE2C0", Offset = "0x7DCD6C0", VA = "0x187DCE2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct CDGFIOFMHCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public GFFJLJGCGCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private Dictionary<Guid, List<CJFDGNGNJMA>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE9070", Offset = "0x7DE8470", VA = "0x187DE9070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE9700", Offset = "0x7DE8B00", VA = "0x187DE9700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class GAPFPONAKGP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public CJFDGNGNJMA handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public GAPFPONAKGP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			private CPNFFAJCLON <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x7DF4BE0", Offset = "0x7DF3FE0", VA = "0x187DF4BE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x7DF5040", Offset = "0x7DF4440", VA = "0x187DF5040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public IGJBFACJKEE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public List<CJFDGNGNJMA> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GAPFPONAKGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x7DEE5E0", Offset = "0x7DED9E0", VA = "0x187DEE5E0")]
		internal object HCJFDENHKGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x7DEE4E0", Offset = "0x7DED8E0", VA = "0x187DEE4E0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task FBHILIOOIKL(CJFDGNGNJMA handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x7DEE3F0", Offset = "0x7DED7F0", VA = "0x187DEE3F0")]
		internal object DHAGDMBKKOC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct OIPBGCNKGCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public IGJBFACJKEE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public List<CJFDGNGNJMA> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private GAPFPONAKGP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x7DF3200", Offset = "0x7DF2600", VA = "0x187DF3200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF36D0", Offset = "0x7DF2AD0", VA = "0x187DF36D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct NKOKCGJNENM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public GFFJLJGCGCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public PGLLJHOKMII<string>.GLACLJPMODI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x7DF2EB0", Offset = "0x7DF22B0", VA = "0x187DF2EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF31A0", Offset = "0x7DF25A0", VA = "0x187DF31A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class MLBIGDAPCOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MLBIGDAPCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x7DF29A0", Offset = "0x7DF1DA0", VA = "0x187DF29A0")]
		internal object IDFFJOEPHND()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private struct MGGGCDFHHHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public GFFJLJGCGCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public DOFGKDAOBGJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x7DF15F0", Offset = "0x7DF09F0", VA = "0x187DF15F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1AA0", Offset = "0x7DF0EA0", VA = "0x187DF1AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class KFGBLBKBIAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public KFGBLBKBIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x7DEFBE0", Offset = "0x7DEEFE0", VA = "0x187DEFBE0")]
		internal object BNAEHJBIILG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct MBGMFELJNCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public GFFJLJGCGCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		private CPNFFAJCLON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		private TaskAwaiter<MGPKNNLHNMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0F60", Offset = "0x7DF0360", VA = "0x187DF0F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1590", Offset = "0x7DF0990", VA = "0x187DF1590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class IGMJKPBMGHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public IGMJKPBMGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEF30", Offset = "0x7DEE330", VA = "0x187DEEF30")]
		internal object EAJGDFAEPMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private readonly OJEJNDLACBE OOHICOOKFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private OELMCGGELDP BPOLIEKHJBG;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private GIELBPOLHAF CFLLFIOEOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xF6CBB0", Offset = "0xF6BFB0", VA = "0x180F6CBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public GFFJLJGCGCA(OJEJNDLACBE OOHICOOKFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6FF0", Offset = "0x7DD63F0", VA = "0x187DD6FF0")]
	[AsyncStateMachine(typeof(LPGBFIKLJPI))]
	public Task GNAFMGAEBCA(LELMIIPMAGF FDFDFNPGAHJ, DOFGKDAOBGJ BIOKMAOMLBN, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7640", Offset = "0x7DD6A40", VA = "0x187DD7640")]
	[AsyncStateMachine(typeof(CNCJIBPPJKD))]
	private Task MPEEHCCKDIA(DOFGKDAOBGJ MJFOKKFMONL, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD73C0", Offset = "0x7DD67C0", VA = "0x187DD73C0")]
	[AsyncStateMachine(typeof(ANDKGLOEKNN))]
	private Task IAHGBDCJPDN(DOFGKDAOBGJ MJFOKKFMONL, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7500", Offset = "0x7DD6900", VA = "0x187DD7500")]
	[AsyncStateMachine(typeof(CDGFIOFMHCM))]
	private Task LKGCMLKOIII(DOFGKDAOBGJ MJFOKKFMONL, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD69D0", Offset = "0x7DD5DD0", VA = "0x187DD69D0")]
	[AsyncStateMachine(typeof(OIPBGCNKGCN))]
	private Task ACCJNPAPIHK(Guid ILNAPFMEIOP, List<CJFDGNGNJMA> LCDDLKOELBI, IGJBFACJKEE NNGIEMOONAD, DOFGKDAOBGJ MJFOKKFMONL, CancellationToken OCDOGNMJENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6CF0", Offset = "0x7DD60F0", VA = "0x187DD6CF0")]
	[AsyncStateMachine(typeof(NKOKCGJNENM))]
	private Task DHIPLOHGLEP(DOFGKDAOBGJ MJFOKKFMONL, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7140", Offset = "0x7DD6540", VA = "0x187DD7140")]
	[AsyncStateMachine(typeof(MGGGCDFHHHM))]
	private Task GPDGDBFEPPC(Guid JIBODDBBGDL, DOFGKDAOBGJ MJFOKKFMONL, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7280", Offset = "0x7DD6680", VA = "0x187DD7280")]
	[AsyncStateMachine(typeof(MBGMFELJNCF))]
	private Task HCIONHDODMM(Guid JIBODDBBGDL, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6E30", Offset = "0x7DD6230", VA = "0x187DD6E30")]
	private void EDEHOCEIIMF(Guid JIBODDBBGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6F40", Offset = "0x7DD6340", VA = "0x187DD6F40")]
	private void FGPBGBBEGMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7780", Offset = "0x7DD6B80", VA = "0x187DD7780")]
	public Guid NEBDMBJMGFE(LELMIIPMAGF BEDFLIFKGKJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6B20", Offset = "0x7DD5F20", VA = "0x187DD6B20")]
	[CompilerGenerated]
	private object BMNIEGDPHOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal struct CEPNMHGDNLA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private struct IOKLHIDKOCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public CEPNMHGDNLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		private IEnumerator<NLAHOONCNNF> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEFA0", Offset = "0x7DEE3A0", VA = "0x187DEEFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x7DEF630", Offset = "0x7DEEA30", VA = "0x187DEF630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private LAGOIFMOJDA DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private CancellationToken MLAPMBKLAOF;

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9760", Offset = "0x7DE8B60", VA = "0x187DE9760")]
	public static Task FBHKFNNFIAP(LAGOIFMOJDA DCHKFKLALGC, PGLLJHOKMII<string>.GLACLJPMODI LMBGFJBPMAJ, CancellationToken LCHOPNFEEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x7DE97D0", Offset = "0x7DE8BD0", VA = "0x187DE97D0")]
	[AsyncStateMachine(typeof(IOKLHIDKOCN))]
	private Task GNAFMGAEBCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
public readonly struct CBBFDOMDOBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000722")]
	public readonly bool FCKNPONJLKC;

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x27C2F60", Offset = "0x27C2360", VA = "0x1827C2F60")]
	public CBBFDOMDOBO(bool NAONJMMIGKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public readonly struct JHKLIMEFACP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000723")]
	public readonly OIBKBLGJIPN? NMCMFCNIHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	public readonly JMJEIPGADIE DLMELIDKFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	public readonly Guid? HJMGBHGEOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	public readonly IReadOnlyList<Guid> IJCMHFFDCPM;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public IReadOnlyCollection<string> CFOPPKCOOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x7DEFA50", Offset = "0x7DEEE50", VA = "0x187DEFA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public IReadOnlyDictionary<long, int> CFMAMHBBKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x7DEFA30", Offset = "0x7DEEE30", VA = "0x187DEFA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x7DEFA70", Offset = "0x7DEEE70", VA = "0x187DEFA70")]
	public JHKLIMEFACP(OIBKBLGJIPN? EDHFGAMFCNC, JMJEIPGADIE PMDIOKOFILO, Guid? JMFGCPHCPKI, [Optional] IReadOnlyList<Guid>? OLBPKDBMKDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal class FBAHBFKEPNC : PNAINFJABOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct ENBHCCANOBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public AsyncTaskMethodBuilder<JHKLIMEFACP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public FBAHBFKEPNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public JLCHIDAEKKK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public FJKNANMCCDC roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private CPNFFAJCLON <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x7DEAC90", Offset = "0x7DEA090", VA = "0x187DEAC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB330", Offset = "0x7DEA730", VA = "0x187DEB330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class GIFMPNBODGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GIFMPNBODGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEBD0", Offset = "0x7DEDFD0", VA = "0x187DEEBD0")]
		internal object FMMNHMHPPNA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private struct FEELOKFLKNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public FBAHBFKEPNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public JLCHIDAEKKK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		private GIFMPNBODGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private CPNFFAJCLON <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		private LAEKEAJIIJD<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x7DED070", Offset = "0x7DEC470", VA = "0x187DED070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x7DEDB30", Offset = "0x7DECF30", VA = "0x187DEDB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x4000728")]
	private static readonly TimeSpan KELHLIDFHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000729")]
	private readonly JGCHGPOINCA CGHGOBIJNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private readonly AJGFFMILDDN KHOCOMCMENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private readonly DAPGJHPIJKE PCGBDEEAFKF;

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x7DED000", Offset = "0x7DEC400", VA = "0x187DED000")]
	public FBAHBFKEPNC(OJEJNDLACBE OOHICOOKFFI, JGCHGPOINCA CGHGOBIJNAE, AJGFFMILDDN KJMIOCEMEDE, DAPGJHPIJKE PCGBDEEAFKF, HLBHMADGLFA GCIBFPDCNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBE50", Offset = "0x7DEB250", VA = "0x187DEBE50")]
	[AsyncStateMachine(typeof(ENBHCCANOBP))]
	public Task<JHKLIMEFACP> EFGCEHNIDJN(long FHAJBLMHDGD, FJKNANMCCDC PGJAMANIDEP, JLCHIDAEKKK FAGMDOIFLMG, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC9C0", Offset = "0x7DEBDC0", VA = "0x187DEC9C0")]
	[AsyncStateMachine(typeof(FEELOKFLKNI))]
	private Task MLJDBOFFIBK(JLCHIDAEKKK FAGMDOIFLMG, PersistenceView[] IDNBBICEFBM, StringBuilder LFNEMFLACNC, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC1F0", Offset = "0x7DEB5F0", VA = "0x187DEC1F0")]
	private JHKLIMEFACP FMBMIOMIBIE(long FHAJBLMHDGD, FJKNANMCCDC PGJAMANIDEP, JLCHIDAEKKK FAGMDOIFLMG, IEnumerable<PersistenceView> IDNBBICEFBM, StringBuilder LFNEMFLACNC)
	{
		return default(JHKLIMEFACP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC800", Offset = "0x7DEBC00", VA = "0x187DEC800")]
	private OIBKBLGJIPN JPMNALLHNPE(long FHAJBLMHDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBFA0", Offset = "0x7DEB3A0", VA = "0x187DEBFA0")]
	private void EHJKFBPHNKF(OIBKBLGJIPN CAGFGEKDIPD, StringBuilder LFNEMFLACNC, IEnumerable<PersistenceView> IDNBBICEFBM, [In] EFDLDPFLHGE BNKHAAAAAFO, LLFMKFGELDH FMADHOLDHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x7DECB00", Offset = "0x7DEBF00", VA = "0x187DECB00")]
	private void MLNJGBBIJMB(OIBKBLGJIPN CAGFGEKDIPD, StringBuilder LFNEMFLACNC, PersistenceView GOGEGHBLCKJ, LLFMKFGELDH FMADHOLDHAI, [In] EFDLDPFLHGE BNKHAAAAAFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal class PBEFJMKFDFM : PNAINFJABOK
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class AOIDOCNONOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public KDJOFOHAGOJ.LAOAICDOOEK roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AOIDOCNONOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6DA0", Offset = "0x7DE61A0", VA = "0x187DE6DA0")]
		internal object EOEJKJJJCBH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private struct MJJNLIFOCMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public AsyncTaskMethodBuilder<(KDJOFOHAGOJ.LAOAICDOOEK roomDataUpload, KDJOFOHAGOJ.LAOAICDOOEK subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public JHKLIMEFACP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public LAGOIFMOJDA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private AOIDOCNONOP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private TaskAwaiter<KDJOFOHAGOJ.LAOAICDOOEK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1F10", Offset = "0x7DF1310", VA = "0x187DF1F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x7DF2760", Offset = "0x7DF1B60", VA = "0x187DF2760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private struct PGKDCIGJEDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public AsyncTaskMethodBuilder<CGKMMAMFMFL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public PBEFJMKFDFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public NBJKHDBIOKG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public JHKLIMEFACP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		private TaskAwaiter<CGKMMAMFMFL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF3FC0", Offset = "0x7DF33C0", VA = "0x187DF3FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x7DF4380", Offset = "0x7DF3780", VA = "0x187DF4380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[CompilerGenerated]
	private struct PPIDKHAJNGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public AsyncTaskMethodBuilder<CGKMMAMFMFL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public LAGOIFMOJDA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public JHKLIMEFACP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		public NBJKHDBIOKG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		private TaskAwaiter<(KDJOFOHAGOJ.LAOAICDOOEK roomDataUpload, KDJOFOHAGOJ.LAOAICDOOEK subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		private TaskAwaiter<CGKMMAMFMFL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x7DF43F0", Offset = "0x7DF37F0", VA = "0x187DF43F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x7DF4B70", Offset = "0x7DF3F70", VA = "0x187DF4B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private struct DLEFDMCACNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public AsyncTaskMethodBuilder<GLMHKJIINJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public PBEFJMKFDFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public JHKLIMEFACP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		private TaskAwaiter<(KDJOFOHAGOJ.LAOAICDOOEK roomDataUpload, KDJOFOHAGOJ.LAOAICDOOEK subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		private TaskAwaiter<GLMHKJIINJI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x7DE99F0", Offset = "0x7DE8DF0", VA = "0x187DE99F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x7DE9EB0", Offset = "0x7DE92B0", VA = "0x187DE9EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private sealed class CMNJNADNCFJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A5")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000777")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000778")]
			public AsyncTaskMethodBuilder<MGPKNNLHNMP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000779")]
			public CMNJNADNCFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400077A")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400077B")]
			private MGPKNNLHNMP <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400077C")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400077D")]
			private TaskAwaiter<GLMHKJIINJI> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400077E")]
			private TaskAwaiter<CGKMMAMFMFL> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400077F")]
			private TaskAwaiter<MGPKNNLHNMP> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0x7DF50A0", Offset = "0x7DF44A0", VA = "0x187DF50A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x7DF60A0", Offset = "0x7DF54A0", VA = "0x187DF60A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public PBEFJMKFDFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public JHKLIMEFACP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public NBJKHDBIOKG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public CBBFDOMDOBO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public CMNJNADNCFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x7DE98C0", Offset = "0x7DE8CC0", VA = "0x187DE98C0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<MGPKNNLHNMP> AGDOPHJHCMH(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct JAEOOPEHPCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public AsyncTaskMethodBuilder<MGPKNNLHNMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public PBEFJMKFDFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public JHKLIMEFACP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public NBJKHDBIOKG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public CBBFDOMDOBO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		private TaskAwaiter<MGPKNNLHNMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x7DEF690", Offset = "0x7DEEA90", VA = "0x187DEF690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x7DEF9C0", Offset = "0x7DEEDC0", VA = "0x187DEF9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000745")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x4000746")]
	private static readonly HLBHMADGLFA HKMOKHMAIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000747")]
	private readonly GMNIJCAFBOL MEEGACDFLGK;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private KBABJPFHBFP MAJHNGEJJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x7DC7640", Offset = "0x7DC6A40", VA = "0x187DC7640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x7DF3F30", Offset = "0x7DF3330", VA = "0x187DF3F30")]
	public PBEFJMKFDFM(OJEJNDLACBE OOHICOOKFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x7DF3A60", Offset = "0x7DF2E60", VA = "0x187DF3A60")]
	[AsyncStateMachine(typeof(MJJNLIFOCMG))]
	private static Task<(KDJOFOHAGOJ.LAOAICDOOEK, KDJOFOHAGOJ.LAOAICDOOEK)> MJJMPJEPBJP(LAGOIFMOJDA DCHKFKLALGC, JHKLIMEFACP LAFAIALAGHO, long LFNEDMLHPHM, long BEGDDCHOHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x7DF3BB0", Offset = "0x7DF2FB0", VA = "0x187DF3BB0")]
	[AsyncStateMachine(typeof(PGKDCIGJEDN))]
	public Task<CGKMMAMFMFL> PHFEGIBBBEC(int FNEMCGFJDJN, [CanBeNull] NBJKHDBIOKG BILBPLEGPGE, JHKLIMEFACP LAFAIALAGHO, long LFNEDMLHPHM, long BEGDDCHOHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x7DF3D20", Offset = "0x7DF3120", VA = "0x187DF3D20")]
	[AsyncStateMachine(typeof(PPIDKHAJNGM))]
	public static Task<CGKMMAMFMFL> PHFEGIBBBEC(LAGOIFMOJDA DCHKFKLALGC, int FNEMCGFJDJN, [CanBeNull] NBJKHDBIOKG BILBPLEGPGE, JHKLIMEFACP LAFAIALAGHO, long LFNEDMLHPHM, long BEGDDCHOHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x7DF38E0", Offset = "0x7DF2CE0", VA = "0x187DF38E0")]
	[AsyncStateMachine(typeof(DLEFDMCACNI))]
	private Task<GLMHKJIINJI> LGOHGJHHMPM(string IICKCAKFCMN, int FNEMCGFJDJN, JHKLIMEFACP LAFAIALAGHO, long LFNEDMLHPHM, long BEGDDCHOHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x7DF3730", Offset = "0x7DF2B30", VA = "0x187DF3730")]
	[AsyncStateMachine(typeof(JAEOOPEHPCB))]
	public Task<MGPKNNLHNMP> DLEBOBAGPOD(int FNEMCGFJDJN, NBJKHDBIOKG? BILBPLEGPGE, JHKLIMEFACP LAFAIALAGHO, long LFNEDMLHPHM, long BEGDDCHOHOL, CBBFDOMDOBO FHOHDFEKCCI, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
public abstract class BJKPNHFCEBH<T> where T : BJKPNHFCEBH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400078C")]
	internal readonly KBABJPFHBFP MLKHGMKPKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400078D")]
	private int? FIKKHGHDEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400078E")]
	protected readonly Guid IMMGPMKFLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400078F")]
	protected readonly AAALDGKDLBO CLJPKPEOHGO;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	protected T HFGDDHLGKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9460", Offset = "0x5CA8860", VA = "0x185CA9460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9640", Offset = "0x5CA8A40", VA = "0x185CA9640")]
	internal BJKPNHFCEBH(KBABJPFHBFP GLBLACKFHII, AAALDGKDLBO OENLPLOJPBN, [Optional] Guid? PPLJPJJDEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9560", Offset = "0x5CA8960", VA = "0x185CA9560")]
	private MGPKNNLHNMP OPMNJOCIDAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
	protected virtual void PGMNNBAEFOK(MGPKNNLHNMP LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9290", Offset = "0x5CA8690", VA = "0x185CA9290")]
	public T DFNGFEGEOFD(NOFCMGEHFOO BAEPHPHLIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x5CA94C0", Offset = "0x5CA88C0", VA = "0x185CA94C0")]
	public T IJEGKPHONGP(int HOENNBOIEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9330", Offset = "0x5CA8730", VA = "0x185CA9330", Slot = "5")]
	public virtual Task<MLDDIEDIFAF> DPHJALECCIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public class EHPADHEMLAI : BJKPNHFCEBH<EHPADHEMLAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000790")]
	private LDGKNLKOAHN IILBHIALBMC;

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x7DEABC0", Offset = "0x7DE9FC0", VA = "0x187DEABC0")]
	internal EHPADHEMLAI(KBABJPFHBFP GLBLACKFHII, AAALDGKDLBO OENLPLOJPBN, [Optional] Guid? PPLJPJJDEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x712E4E0", Offset = "0x712D8E0", VA = "0x18712E4E0")]
	public EHPADHEMLAI FLCHOAHDMGD(LDGKNLKOAHN IILBHIALBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x7DEAAF0", Offset = "0x7DE9EF0", VA = "0x187DEAAF0", Slot = "4")]
	protected override void PGMNNBAEFOK(MGPKNNLHNMP LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public class EPAMDPBJAJK : BJKPNHFCEBH<EPAMDPBJAJK>
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	internal enum ELNKDOMOJBO
	{
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct MPMEMGBGJMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public AsyncTaskMethodBuilder<MLDDIEDIFAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public EPAMDPBJAJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private TaskAwaiter<MLDDIEDIFAF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x7DF2A90", Offset = "0x7DF1E90", VA = "0x187DF2A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x7DF2E40", Offset = "0x7DF2240", VA = "0x187DF2E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000791")]
	private ELNKDOMOJBO NLACKFFKEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000792")]
	private string DBJNHGKECFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000793")]
	private NBJKHDBIOKG IILBHIALBMC;

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBCE0", Offset = "0x7DEB0E0", VA = "0x187DEBCE0")]
	internal EPAMDPBJAJK(KBABJPFHBFP GLBLACKFHII, AAALDGKDLBO OENLPLOJPBN, [Optional] Guid? PPLJPJJDEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBAE0", Offset = "0x7DEAEE0", VA = "0x187DEBAE0")]
	public EPAMDPBJAJK NOBMBHCPIGM(string APDEKOCIEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBB50", Offset = "0x7DEAF50", VA = "0x187DEBB50")]
	public EPAMDPBJAJK PGFBOENCEBE(bool GNDBBPICKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBAC0", Offset = "0x7DEAEC0", VA = "0x187DEBAC0")]
	public EPAMDPBJAJK JLOMGENPKCG(bool PIJGDJLFBBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB9A0", Offset = "0x7DEADA0", VA = "0x187DEB9A0")]
	public EPAMDPBJAJK ANGEECCPOHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBB70", Offset = "0x7DEAF70", VA = "0x187DEBB70", Slot = "4")]
	protected override void PGMNNBAEFOK(MGPKNNLHNMP LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB9D0", Offset = "0x7DEADD0", VA = "0x187DEB9D0", Slot = "5")]
	[AsyncStateMachine(typeof(MPMEMGBGJMK))]
	public override Task<MLDDIEDIFAF> DPHJALECCIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBB10", Offset = "0x7DEAF10", VA = "0x187DEBB10")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<MLDDIEDIFAF> OELKIDPKHFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
internal static class MKGCIDACIHD
{
	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x7DF27D0", Offset = "0x7DF1BD0", VA = "0x187DF27D0")]
	public static void FEIGHFJIAKN(this FJEGBONDBNO LJPFHKGCNOH, DNHLENAINEA FIAFGAIMMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2920", Offset = "0x7DF1D20", VA = "0x187DF2920")]
	public static void FJJHGMMKMPJ(this DNHLENAINEA FLPHGLKPGDK, [Optional] string LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public static class LNCPIBBPNEC
{
	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0EC0", Offset = "0x7DF02C0", VA = "0x187DF0EC0")]
	public static LOFGJIDOAFO GEDCNAAFKBN(this KCIODNNIDJK KPNOLBFLFMD)
	{
		return default(LOFGJIDOAFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0E10", Offset = "0x7DF0210", VA = "0x187DF0E10")]
	public static KCIODNNIDJK EFDAICFOEME(this LOFGJIDOAFO BIMGAMCOKEC)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			public BDCDKKLDAGN ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			public BDCDKKLDAGN HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007A3")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007A4")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007A5")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400079D")]
		private static BDCDKKLDAGN[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		private Dictionary<BDCDKKLDAGN, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x7DF67A0", Offset = "0x7DF5BA0", VA = "0x187DF67A0")]
		public bool JDEHABMNBJD(BDCDKKLDAGN FMMBBDMNBLF, [Out] ResultConfig FLKLAANBPFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6660", Offset = "0x7DF5A60", VA = "0x187DF6660")]
		public ResultConfig ABJKAEDDOBL(BDCDKKLDAGN BBAJBLJIPLG, [Optional] HashSet<BDCDKKLDAGN> PDJIKDICHNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6DC0", Offset = "0x7DF61C0", VA = "0x187DF6DC0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6810", Offset = "0x7DF5C10", VA = "0x187DF6810", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0xAA00D0", Offset = "0xA9F4D0", VA = "0x180AA00D0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class LLPECOGKBMP : DEBJFNCKLHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	[CompilerGenerated]
	private struct GKHLOEGDDFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		public LLPECOGKBMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		public PGLLJHOKMII<string>.GLACLJPMODI timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEC40", Offset = "0x7DEE040", VA = "0x187DEEC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEED0", Offset = "0x7DEE2D0", VA = "0x187DEEED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	[CompilerGenerated]
	private struct GGFGMPBEMKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		public PGLLJHOKMII<string>.GLACLJPMODI timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		public DEBJFNCKLHK preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		private PGLLJHOKMII<string>.GLACLJPMODI <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x7DEE6D0", Offset = "0x7DEDAD0", VA = "0x187DEE6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEB70", Offset = "0x7DEDF70", VA = "0x187DEEB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007AB")]
	private readonly JAPHMMEGEMI CGIHDIBCOFJ;

	[Cpp2IlInjected.Token(Token = "0x40007AC")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public string CPODMKDDCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x7DF02B0", Offset = "0x7DEF6B0", VA = "0x187DF02B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0120", Offset = "0x7DEF520", VA = "0x187DF0120")]
	[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
	internal static void HCFGACKFDEN(LEPFMCICNAK BFCIDAHLIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	[RecRoom.NoEngine.Common.Preserve]
	public LLPECOGKBMP([PNFCCJKFMBH(null)] JAPHMMEGEMI CGIHDIBCOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0010", Offset = "0x7DEF410", VA = "0x187DF0010", Slot = "5")]
	[AsyncStateMachine(typeof(GKHLOEGDDFJ))]
	public Task GNAFMGAEBCA(PGLLJHOKMII<string>.GLACLJPMODI PNJLGKMNCME, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0190", Offset = "0x7DEF590", VA = "0x187DF0190")]
	[AsyncStateMachine(typeof(GGFGMPBEMKJ))]
	private Task IAKJMCNLDFO(DEBJFNCKLHK DJONJMNHDFN, PGLLJHOKMII<string>.GLACLJPMODI PNJLGKMNCME, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
public interface JAPHMMEGEMI : DEBJFNCKLHK
{
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
public interface DEBJFNCKLHK
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	string CPODMKDDCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GNAFMGAEBCA(PGLLJHOKMII<string>.GLACLJPMODI PNJLGKMNCME, CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public static class MJFCFKGKBDK
{
	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1B00", Offset = "0x7DF0F00", VA = "0x187DF1B00")]
	[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
	internal static void GFLBPMFPPHA(LEPFMCICNAK BFCIDAHLIIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
public interface HLGDIBFKEKE : IEquatable<HLGDIBFKEKE>
{
	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	DateTime EBALLIBAPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FMHNKPMMLGE();

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JJJEALFAGMD(long LFNEDMLHPHM, long FHAJBLMHDGD, [Out] JHKLIMEFACP LAFAIALAGHO);
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
internal class DMONLFEMCGJ : JKOCOFLNOBD
{
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[CompilerGenerated]
	private sealed class JHMLFKLNIFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public DNGFPOMMDGK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JHMLFKLNIFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x7DEFB70", Offset = "0x7DEEF70", VA = "0x187DEFB70")]
		internal object DBAMHBJKDOM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007BA")]
	private readonly JOPGFEFBIND KNPHENGDNNF;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<HLGDIBFKEKE> DFDAMIINFJO
	{
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA260", Offset = "0x7DE9660", VA = "0x187DEA260", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA1B0", Offset = "0x7DE95B0", VA = "0x187DEA1B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	[UnityEngine.Scripting.Preserve]
	public DMONLFEMCGJ([PNFCCJKFMBH(null)] JOPGFEFBIND KNPHENGDNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA7F0", Offset = "0x7DE9BF0", VA = "0x187DEA7F0", Slot = "6")]
	public bool OGLELCKLNPJ(long LFNEDMLHPHM, long FHAJBLMHDGD, JHKLIMEFACP LAFAIALAGHO, DNGFPOMMDGK FHBKFDOMCJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0xCB1F40", Offset = "0xCB1340", VA = "0x180CB1F40")]
	private void JMEPBHGGJBH(HLGDIBFKEKE CKIFDKJKIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9F20", Offset = "0x7DE9320", VA = "0x187DE9F20", Slot = "7")]
	public bool ANCGCFEJJCM(long LFNEDMLHPHM, long FHAJBLMHDGD, [Out] HLGDIBFKEKE AADNONONIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA310", Offset = "0x7DE9710", VA = "0x187DEA310", Slot = "8")]
	public bool IHLLFBFKGHJ(long LFNEDMLHPHM, long FHAJBLMHDGD, DNGFPOMMDGK FHBKFDOMCJO, [Out] HLGDIBFKEKE AADNONONIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA3C0", Offset = "0x7DE97C0", VA = "0x187DEA3C0")]
	private void LCFDFGNFKLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA090", Offset = "0x7DE9490", VA = "0x187DEA090", Slot = "9")]
	public void BMENPCFKLCN(long LFNEDMLHPHM, long FHAJBLMHDGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
internal abstract class LMKCOBCMKGH : JOPGFEFBIND
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	protected enum LBFBNNICEIN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	[CompilerGenerated]
	private sealed class BFPANNFLLAA : IEnumerable<HLGDIBFKEKE>, IEnumerable, IEnumerator<HLGDIBFKEKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		private HLGDIBFKEKE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public LMKCOBCMKGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		private DNGFPOMMDGK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		public DNGFPOMMDGK <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		private HLGDIBFKEKE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD746B0", VA = "0x180D752B0")]
		[DebuggerHidden]
		public BFPANNFLLAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6DF0", Offset = "0x7DE61F0", VA = "0x187DE6DF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x7DE70D0", Offset = "0x7DE64D0", VA = "0x187DE70D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7020", Offset = "0x7DE6420", VA = "0x187DE7020", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HLGDIBFKEKE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7020", Offset = "0x7DE6420", VA = "0x187DE7020", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	[CompilerGenerated]
	private sealed class LFLALPIGPPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public DNGFPOMMDGK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LFLALPIGPPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x7DEFF70", Offset = "0x7DEF370", VA = "0x187DEFF70")]
		internal object JBFNOKDDBAK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[CompilerGenerated]
	private sealed class MMPMIJPHLPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		public LMKCOBCMKGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MMPMIJPHLPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x7DF2A10", Offset = "0x7DF1E10", VA = "0x187DF2A10")]
		internal void GGLMJJIFDHM(APMNDGLLOKH.PIODCMDINPO ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007C0")]
	private readonly object ABGOBLALDDD;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected string JKGFNIDDEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0350", Offset = "0x7DEF750", VA = "0x187DF0350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public abstract LLJFNHNKCPP JACLPFPJGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0D90", Offset = "0x7DF0190", VA = "0x187DF0D90")]
	protected LMKCOBCMKGH([CanBeNull] string BGFLBNKPCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0360", Offset = "0x7DEF760", VA = "0x187DF0360", Slot = "5")]
	public bool CFABBADBJFL(long LFNEDMLHPHM, long FHAJBLMHDGD, DNGFPOMMDGK FHBKFDOMCJO, [Out] HLGDIBFKEKE CKIFDKJKIAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0550", Offset = "0x7DEF950", VA = "0x187DF0550", Slot = "6")]
	[IteratorStateMachine(typeof(BFPANNFLLAA))]
	public IEnumerable<HLGDIBFKEKE> GBAKLMLJOCH(DNGFPOMMDGK FHBKFDOMCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void HMAEMDONOIG(Stream NBMIPPCHDGC, long LFNEDMLHPHM, long FHAJBLMHDGD, JHKLIMEFACP LAFAIALAGHO);

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool HNGIPOOLGAK(Stream CEJNGKJGHNL, long LFNEDMLHPHM, long FHAJBLMHDGD, MJLDLJHNKDL ADOKJNGHCHJ, [Out] JHKLIMEFACP LAFAIALAGHO);

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x7DF09A0", Offset = "0x7DEFDA0", VA = "0x187DF09A0", Slot = "7")]
	public HLGDIBFKEKE NKOAEBMDFCE(long LFNEDMLHPHM, long FHAJBLMHDGD, JHKLIMEFACP LAFAIALAGHO, DNGFPOMMDGK FHBKFDOMCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo OFODGOLIFJB(long LFNEDMLHPHM, long FHAJBLMHDGD, DNGFPOMMDGK FHBKFDOMCJO, LBFBNNICEIN MMCNFDCFIBN);

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo ABJHEEEDACN(DNGFPOMMDGK FHBKFDOMCJO, LBFBNNICEIN MMCNFDCFIBN);

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0D20", Offset = "0x7DF0120", VA = "0x187DF0D20")]
	protected void NNLIDFGGGBF(APMNDGLLOKH.PIODCMDINPO FIIHAPHEDHL, string DOICNOOOHHG, FileInfo JBBIDIMOIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x7DF05E0", Offset = "0x7DEF9E0", VA = "0x187DF05E0")]
	internal bool IOBLGIBKEFA(FileInfo BLOACFFHAEB, long LFNEDMLHPHM, long FHAJBLMHDGD, [Out] JHKLIMEFACP LAFAIALAGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	private void FDKLHOHCODM(Exception HKMMACEDFFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
internal class CDAAPMNPIDF : LMKCOBCMKGH
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public override LLJFNHNKCPP JACLPFPJGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x1BC9AA0", Offset = "0x1BC8EA0", VA = "0x181BC9AA0", Slot = "8")]
		get
		{
			return default(LLJFNHNKCPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9030", Offset = "0x7DE8430", VA = "0x187DE9030")]
	public CDAAPMNPIDF([Optional] string BGFLBNKPCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8EC0", Offset = "0x7DE82C0", VA = "0x187DE8EC0")]
	private void INLCHPAFNLM(DNGFPOMMDGK FHBKFDOMCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8520", Offset = "0x7DE7920", VA = "0x187DE8520", Slot = "9")]
	internal override void HMAEMDONOIG(Stream NBMIPPCHDGC, long LFNEDMLHPHM, long FHAJBLMHDGD, JHKLIMEFACP LAFAIALAGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x7DE87D0", Offset = "0x7DE7BD0", VA = "0x187DE87D0", Slot = "10")]
	internal override bool HNGIPOOLGAK(Stream CEJNGKJGHNL, long LFNEDMLHPHM, long FHAJBLMHDGD, MJLDLJHNKDL ADOKJNGHCHJ, [Out] JHKLIMEFACP LAFAIALAGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8F40", Offset = "0x7DE8340", VA = "0x187DE8F40", Slot = "11")]
	protected override FileInfo OFODGOLIFJB(long LFNEDMLHPHM, long FHAJBLMHDGD, DNGFPOMMDGK FHBKFDOMCJO, LBFBNNICEIN MMCNFDCFIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8420", Offset = "0x7DE7820", VA = "0x187DE8420", Slot = "12")]
	protected override DirectoryInfo ABJHEEEDACN(DNGFPOMMDGK FHBKFDOMCJO, LBFBNNICEIN MMCNFDCFIBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
internal sealed class BMACFIKJEED : LMKCOBCMKGH
{
	[Cpp2IlInjected.Token(Token = "0x40007D0")]
	private static readonly byte[] MCNLCGLNHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007D1")]
	private readonly byte[] OHGDGPOBIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007D2")]
	private readonly byte[] GJIGHGOINAK;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public override LLJFNHNKCPP JACLPFPJGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x6988E50", Offset = "0x6988250", VA = "0x186988E50", Slot = "8")]
		get
		{
			return default(LLJFNHNKCPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8330", Offset = "0x7DE7730", VA = "0x187DE8330")]
	public BMACFIKJEED([Optional] string BGFLBNKPCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7230", Offset = "0x7DE6630", VA = "0x187DE7230", Slot = "9")]
	internal override void HMAEMDONOIG(Stream NBMIPPCHDGC, long LFNEDMLHPHM, long FHAJBLMHDGD, JHKLIMEFACP LAFAIALAGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7640", Offset = "0x7DE6A40", VA = "0x187DE7640", Slot = "10")]
	internal override bool HNGIPOOLGAK(Stream CEJNGKJGHNL, long LFNEDMLHPHM, long FHAJBLMHDGD, MJLDLJHNKDL ADOKJNGHCHJ, [Out] JHKLIMEFACP LAFAIALAGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x7DE80B0", Offset = "0x7DE74B0", VA = "0x187DE80B0")]
	private void MPOFACBIHPM(byte[] KPLABGDDBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8170", Offset = "0x7DE7570", VA = "0x187DE8170", Slot = "11")]
	protected override FileInfo OFODGOLIFJB(long LFNEDMLHPHM, long FHAJBLMHDGD, DNGFPOMMDGK FHBKFDOMCJO, LBFBNNICEIN MMCNFDCFIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7120", Offset = "0x7DE6520", VA = "0x187DE7120", Slot = "12")]
	protected override DirectoryInfo ABJHEEEDACN(DNGFPOMMDGK FHBKFDOMCJO, LBFBNNICEIN MMCNFDCFIBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
public enum LLJFNHNKCPP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007D6")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007D7")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007D8")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal class FPCMCBAANBL : JOPGFEFBIND
{
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[CompilerGenerated]
	private sealed class AFBKMGLCIBD : IEnumerable<HLGDIBFKEKE>, IEnumerable, IEnumerator<HLGDIBFKEKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		private HLGDIBFKEKE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		public FPCMCBAANBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		private DNGFPOMMDGK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		public DNGFPOMMDGK <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		private LLJFNHNKCPP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		private IEnumerator<HLGDIBFKEKE> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		private HLGDIBFKEKE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD746B0", VA = "0x180D752B0")]
		[DebuggerHidden]
		public AFBKMGLCIBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6D10", Offset = "0x7DE6110", VA = "0x187DE6D10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6930", Offset = "0x7DE5D30", VA = "0x187DE6930", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x7DE68E0", Offset = "0x7DE5CE0", VA = "0x187DE68E0")]
		private void MHCHPBFCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6CC0", Offset = "0x7DE60C0", VA = "0x187DE6CC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6C10", Offset = "0x7DE6010", VA = "0x187DE6C10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HLGDIBFKEKE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6C10", Offset = "0x7DE6010", VA = "0x187DE6C10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007D9")]
	private readonly LLJFNHNKCPP[] NFPEBLOCNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007DA")]
	private readonly Dictionary<LLJFNHNKCPP, JOPGFEFBIND> NKOMADEBFNB;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public LLJFNHNKCPP JACLPFPJGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x7DEDCE0", Offset = "0x7DED0E0", VA = "0x187DEDCE0", Slot = "4")]
		get
		{
			return default(LLJFNHNKCPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE0C0", Offset = "0x7DED4C0", VA = "0x187DEE0C0")]
	[UnityEngine.Scripting.Preserve]
	public FPCMCBAANBL(params JOPGFEFBIND[] MPHFHMEHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDB90", Offset = "0x7DECF90", VA = "0x187DEDB90", Slot = "5")]
	public bool CFABBADBJFL(long LFNEDMLHPHM, long FHAJBLMHDGD, DNGFPOMMDGK FHBKFDOMCJO, [Out] HLGDIBFKEKE CKIFDKJKIAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDDA0", Offset = "0x7DED1A0", VA = "0x187DEDDA0")]
	private void HPNJAKFALEI(int NCEJJLEKFNB, long LFNEDMLHPHM, long FHAJBLMHDGD, DNGFPOMMDGK FHBKFDOMCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDD10", Offset = "0x7DED110", VA = "0x187DEDD10", Slot = "6")]
	[IteratorStateMachine(typeof(AFBKMGLCIBD))]
	public IEnumerable<HLGDIBFKEKE> GBAKLMLJOCH(DNGFPOMMDGK FHBKFDOMCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDFD0", Offset = "0x7DED3D0", VA = "0x187DEDFD0", Slot = "7")]
	public HLGDIBFKEKE NKOAEBMDFCE(long LFNEDMLHPHM, long FHAJBLMHDGD, JHKLIMEFACP LAFAIALAGHO, DNGFPOMMDGK FHBKFDOMCJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
internal static class KJPGEHGFEAM
{
	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x7DEFE30", Offset = "0x7DEF230", VA = "0x187DEFE30")]
	internal static byte[] LFAJPKHABGP(byte[] KPLABGDDBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x7DEFEF0", Offset = "0x7DEF2F0", VA = "0x187DEFEF0")]
	public static void NMIKHLPIKOP(Stream NCMIFGJNOIO, byte[] PJNDPKCEAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x7DEFC50", Offset = "0x7DEF050", VA = "0x187DEFC50")]
	public static bool CEGPIDKCHHB(Stream NCMIFGJNOIO, long CMHAIDIAENE, MJLDLJHNKDL ADLBHHHEAAE, [Out] byte[] BOKBAFNKAEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
internal sealed class EOMDAEIPADK : HLGDIBFKEKE, IEquatable<HLGDIBFKEKE>, IEquatable<EOMDAEIPADK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E8")]
	private readonly LMKCOBCMKGH LCCCAJBLADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007E9")]
	public readonly FileInfo MOEBIDFBEDN;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public LLJFNHNKCPP JACLPFPJGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x76F2600", Offset = "0x76F1A00", VA = "0x1876F2600", Slot = "9")]
		get
		{
			return default(LLJFNHNKCPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public DateTime EBALLIBAPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB750", Offset = "0x7DEAB50", VA = "0x187DEB750", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB890", Offset = "0x7DEAC90", VA = "0x187DEB890")]
	public EOMDAEIPADK(LMKCOBCMKGH BONDIOKJPAK, FileInfo BLOACFFHAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB7E0", Offset = "0x7DEABE0", VA = "0x187DEB7E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB5C0", Offset = "0x7DEA9C0", VA = "0x187DEB5C0", Slot = "5")]
	public void FMHNKPMMLGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB710", Offset = "0x7DEAB10", VA = "0x187DEB710", Slot = "6")]
	public bool JJJEALFAGMD(long LFNEDMLHPHM, long FHAJBLMHDGD, [Out] JHKLIMEFACP LAFAIALAGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB3A0", Offset = "0x7DEA7A0", VA = "0x187DEB3A0", Slot = "7")]
	public bool Equals(HLGDIBFKEKE MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB410", Offset = "0x7DEA810", VA = "0x187DEB410", Slot = "8")]
	public bool Equals(EOMDAEIPADK MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB4D0", Offset = "0x7DEA8D0", VA = "0x187DEB4D0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB680", Offset = "0x7DEAA80", VA = "0x187DEB680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
public delegate void MJLDLJHNKDL(APMNDGLLOKH.PIODCMDINPO CENOHIGLDAC, string LPIFIOEEOGF);
[Cpp2IlInjected.Token(Token = "0x20001CA")]
internal interface JOPGFEFBIND
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	LLJFNHNKCPP JACLPFPJGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CFABBADBJFL(long LFNEDMLHPHM, long FHAJBLMHDGD, DNGFPOMMDGK FHBKFDOMCJO, [Out] HLGDIBFKEKE CKIFDKJKIAC);

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<HLGDIBFKEKE> GBAKLMLJOCH(DNGFPOMMDGK FHBKFDOMCJO);

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HLGDIBFKEKE NKOAEBMDFCE(long LFNEDMLHPHM, long FHAJBLMHDGD, JHKLIMEFACP LAFAIALAGHO, DNGFPOMMDGK FHBKFDOMCJO);
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
