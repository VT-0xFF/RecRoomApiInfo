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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
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
		[Cpp2IlInjected.Address(RVA = "0x63CCA50", Offset = "0x63CBA50", VA = "0x1863CCA50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79B560", Offset = "0x79A560", VA = "0x18079B560")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B5A0", Offset = "0x79A5A0", VA = "0x18079B5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IGINEPGDHFM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63C5A80", Offset = "0x63C4A80", VA = "0x1863C5A80")]
	public IGINEPGDHFM(string NCBOINMNCHO, Exception OGJFLGPCPOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class LOOHKMACMJP : MEGLJAJDKFB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct IKNOIFJJOEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<GNBPKJBLPKB>> <>t__builder;

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
		private TaskAwaiter<ICNLIHCOKIB<GNBPKJBLPKB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x63C6830", Offset = "0x63C5830", VA = "0x1863C6830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x63C6A70", Offset = "0x63C5A70", VA = "0x1863C6A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JDNNOICPLMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<LOOKOJPHOON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<LOOKOJPHOON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x63C6AE0", Offset = "0x63C5AE0", VA = "0x1863C6AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x63C6CF0", Offset = "0x63C5CF0", VA = "0x1863C6CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	[UnityEngine.Scripting.Preserve]
	public LOOHKMACMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x63CBEE0", Offset = "0x63CAEE0", VA = "0x1863CBEE0", Slot = "4")]
	[AsyncStateMachine(typeof(IKNOIFJJOEG))]
	public Task<IReadOnlyList<GNBPKJBLPKB>> IFLBDAGNKIP(long KAOIBEOBDCN, long BBEDBHIBLKF, [Optional] CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x63CC000", Offset = "0x63CB000", VA = "0x1863CC000", Slot = "5")]
	[AsyncStateMachine(typeof(JDNNOICPLMI))]
	public Task<IReadOnlyList<LOOKOJPHOON>> IGBEEOEOEDH(IReadOnlyList<int> BBDAIFMOOMO, [Optional] CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KAIPKFBBCLN : IEquatable<KAIPKFBBCLN>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int GJIFHOFCAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LOOKOJPHOON LJKAFPDGOEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime NDFCIICIBFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LDHMGKLHGBC? HBDMLBNFAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HIHBGEJBHNH? DAJCGCICEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	MBDICPCMPDP IDEHIABBIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GPKOEFJDDBP> LDOLNHDHOIM();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum MBDICPCMPDP
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MEGLJAJDKFB
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<GNBPKJBLPKB>> IFLBDAGNKIP(long KAOIBEOBDCN, long BBEDBHIBLKF, [Optional] CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<LOOKOJPHOON>> IGBEEOEOEDH(IReadOnlyList<int> BBDAIFMOOMO, [Optional] CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IFJKLFAMPFP
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class AHMCAOFAKMF : KAIPKFBBCLN, IEquatable<KAIPKFBBCLN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct ENFCAIGGBFI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<GPKOEFJDDBP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public AHMCAOFAKMF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private JKPGLBCGCAD <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<MCEIHIBECAG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<GPKOEFJDDBP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63C0260", Offset = "0x63BF260", VA = "0x1863C0260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x63C0700", Offset = "0x63BF700", VA = "0x1863C0700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly GNBPKJBLPKB NLADMEPNPGA;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int GJIFHOFCAEI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x775DA0", Offset = "0x774DA0", VA = "0x180775DA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LOOKOJPHOON LJKAFPDGOEC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime IHMDJCHDJKB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x950950", Offset = "0x94F950", VA = "0x180950950", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LDHMGKLHGBC? HBDMLBNFAHE
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1847AB0", Offset = "0x1846AB0", VA = "0x181847AB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HIHBGEJBHNH? DAJCGCICEGH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1DFC890", Offset = "0x1DFB890", VA = "0x181DFC890", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MBDICPCMPDP IDEHIABBIAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x834600", Offset = "0x833600", VA = "0x180834600", Slot = "10")]
			get
			{
				return default(MBDICPCMPDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x63B1680", Offset = "0x63B0680", VA = "0x1863B1680", Slot = "9")]
		[AsyncStateMachine(typeof(ENFCAIGGBFI))]
		public Task<GPKOEFJDDBP> LDOLNHDHOIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63B1780", Offset = "0x63B0780", VA = "0x1863B1780")]
		public AHMCAOFAKMF(int CDMEPAAPHKO, LOOKOJPHOON MMOEGBHHFOC, GNBPKJBLPKB NLADMEPNPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x63B14D0", Offset = "0x63B04D0", VA = "0x1863B14D0", Slot = "11")]
		public bool Equals(KAIPKFBBCLN EJEDDDCGMMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x63B1560", Offset = "0x63B0560", VA = "0x1863B1560", Slot = "0")]
		public override bool Equals(object GPCHHCACPPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x63B1490", Offset = "0x63B0490", VA = "0x1863B1490")]
		private bool CDCBOMFEPPB(AHMCAOFAKMF EJEDDDCGMMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63B1600", Offset = "0x63B0600", VA = "0x1863B1600", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class FMPEJDOOPDI : KAIPKFBBCLN, IEquatable<KAIPKFBBCLN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct NCPDKCMKLIE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<GPKOEFJDDBP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public FMPEJDOOPDI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<GPKOEFJDDBP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x63CC5B0", Offset = "0x63CB5B0", VA = "0x1863CC5B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x63CC7E0", Offset = "0x63CB7E0", VA = "0x1863CC7E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly ALFEBNEDACP NMIDANGJGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly LDHMGKLHGBC NHDNPPFIDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly HIHBGEJBHNH HFANAKLCHCP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int GJIFHOFCAEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x63C1EA0", Offset = "0x63C0EA0", VA = "0x1863C1EA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LOOKOJPHOON LJKAFPDGOEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x63C1D40", Offset = "0x63C0D40", VA = "0x1863C1D40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime IHMDJCHDJKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x63C1B40", Offset = "0x63C0B40", VA = "0x1863C1B40", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public LDHMGKLHGBC? HBDMLBNFAHE
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x63C1FD0", Offset = "0x63C0FD0", VA = "0x1863C1FD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public HIHBGEJBHNH? DAJCGCICEGH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63C1E50", Offset = "0x63C0E50", VA = "0x1863C1E50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public MBDICPCMPDP IDEHIABBIAO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x820660", Offset = "0x81F660", VA = "0x180820660", Slot = "10")]
			get
			{
				return default(MBDICPCMPDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xDD1EE0", Offset = "0xDD0EE0", VA = "0x180DD1EE0")]
		public FMPEJDOOPDI(ALFEBNEDACP DHHBKLBMPLE, LDHMGKLHGBC CHEFKEPIHHA, HIHBGEJBHNH NBKFBHGOGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x63C1EE0", Offset = "0x63C0EE0", VA = "0x1863C1EE0", Slot = "9")]
		[AsyncStateMachine(typeof(NCPDKCMKLIE))]
		public Task<GPKOEFJDDBP> LDOLNHDHOIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x63C1BF0", Offset = "0x63C0BF0", VA = "0x1863C1BF0", Slot = "11")]
		public bool Equals(KAIPKFBBCLN EJEDDDCGMMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63C1C90", Offset = "0x63C0C90", VA = "0x1863C1C90", Slot = "0")]
		public override bool Equals(object GPCHHCACPPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63C1B90", Offset = "0x63C0B90", VA = "0x1863C1B90")]
		private bool CDCBOMFEPPB(FMPEJDOOPDI EJEDDDCGMMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63C1DD0", Offset = "0x63C0DD0", VA = "0x1863C1DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class LFMGGOHOJHN : KAIPKFBBCLN, IEquatable<KAIPKFBBCLN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct PMOCIOOPPKB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<GPKOEFJDDBP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<GPKOEFJDDBP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x63CECB0", Offset = "0x63CDCB0", VA = "0x1863CECB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x63CEEF0", Offset = "0x63CDEF0", VA = "0x1863CEEF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly LOOKOJPHOON BBHHBOEPLNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly LDHMGKLHGBC NHDNPPFIDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly HIHBGEJBHNH HFANAKLCHCP;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int GJIFHOFCAEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x63CBB10", Offset = "0x63CAB10", VA = "0x1863CBB10", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public LOOKOJPHOON LJKAFPDGOEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime IHMDJCHDJKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public LDHMGKLHGBC? HBDMLBNFAHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x63CBC00", Offset = "0x63CAC00", VA = "0x1863CBC00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HIHBGEJBHNH? DAJCGCICEGH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x63CBAC0", Offset = "0x63CAAC0", VA = "0x1863CBAC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MBDICPCMPDP IDEHIABBIAO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "10")]
			get
			{
				return default(MBDICPCMPDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xDD1EE0", Offset = "0xDD0EE0", VA = "0x180DD1EE0")]
		public LFMGGOHOJHN(LOOKOJPHOON MMOEGBHHFOC, LDHMGKLHGBC CHEFKEPIHHA, HIHBGEJBHNH NBKFBHGOGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x63CBB30", Offset = "0x63CAB30", VA = "0x1863CBB30", Slot = "9")]
		[AsyncStateMachine(typeof(PMOCIOOPPKB))]
		public Task<GPKOEFJDDBP> LDOLNHDHOIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x63CB920", Offset = "0x63CA920", VA = "0x1863CB920", Slot = "11")]
		public bool Equals(KAIPKFBBCLN EJEDDDCGMMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x63CB800", Offset = "0x63CA800", VA = "0x1863CB800", Slot = "0")]
		public override bool Equals(object GPCHHCACPPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x63CBA30", Offset = "0x63CAA30", VA = "0x1863CBA30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x63CB720", Offset = "0x63CA720", VA = "0x1863CB720")]
		private bool CDCBOMFEPPB(LFMGGOHOJHN EJEDDDCGMMB)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct KBGNCMNOOEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<KAIPKFBBCLN>> <>t__builder;

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
		public IFJKLFAMPFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<GNBPKJBLPKB> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<GNBPKJBLPKB>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, LOOKOJPHOON account, GNBPKJBLPKB roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x63C9500", Offset = "0x63C8500", VA = "0x1863C9500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x63CA2E0", Offset = "0x63C92E0", VA = "0x1863CA2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct BOHFLPKIBLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, LOOKOJPHOON account, GNBPKJBLPKB roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<GNBPKJBLPKB> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IFJKLFAMPFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<LOOKOJPHOON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x63B1EA0", Offset = "0x63B0EA0", VA = "0x1863B1EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x63B2890", Offset = "0x63B1890", VA = "0x1863B2890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FCJOKOFKJNI DAJMGMGJPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MEGLJAJDKFB PMNCDIKLLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly LGDBIMMEJPN OIHMJICMNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly HBINADBGHMF<(long, long), IReadOnlyList<GNBPKJBLPKB>> CBKKFPKCILH;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63C5950", Offset = "0x63C4950", VA = "0x1863C5950")]
	[UnityEngine.Scripting.Preserve]
	public IFJKLFAMPFP([KHIPNIHHNOH(null)] MEGLJAJDKFB MHOPNOCIJJL, [KHIPNIHHNOH(null)] LGDBIMMEJPN BDLGFHIKKGH, [KHIPNIHHNOH(null)] FCJOKOFKJNI DAJCGHBMNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x63C56F0", Offset = "0x63C46F0", VA = "0x1863C56F0")]
	[AsyncStateMachine(typeof(KBGNCMNOOEP))]
	public Task<IList<KAIPKFBBCLN>> NKHGAOAAIMD(long KAOIBEOBDCN, long HIFDDDODBFK, bool HHJHDGGJLGF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63C5550", Offset = "0x63C4550", VA = "0x1863C5550")]
	private bool NJEEIBDGCPF(DateTime? PJOEDPPABAE, long KAOIBEOBDCN, long HIFDDDODBFK, [Out] ALFEBNEDACP AAKFCMHHOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63C5840", Offset = "0x63C4840", VA = "0x1863C5840")]
	[AsyncStateMachine(typeof(BOHFLPKIBLL))]
	private Task<IReadOnlyList<(int, LOOKOJPHOON, GNBPKJBLPKB)>> PCGFFCALJPD(IReadOnlyList<GNBPKJBLPKB> FMNDKEHJMFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LGDBIMMEJPN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<ALFEBNEDACP> PHKNGIHGBGN;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GPAEFLLPOOF(long KAOIBEOBDCN, long HIFDDDODBFK, NKNGHGMAJIA LPBIKGAEGIH, BFJJLHPIHPM GJGEIEHPEOB);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FKNLHCPILJH(long KAOIBEOBDCN, long HIFDDDODBFK, [Out] ALFEBNEDACP AAKFCMHHOAD);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HHNGPMEBHDN(long KAOIBEOBDCN, long HIFDDDODBFK, BFJJLHPIHPM GJGEIEHPEOB, [Out] ALFEBNEDACP AAKFCMHHOAD);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EBIPNGCEIFL(long KAOIBEOBDCN, long HIFDDDODBFK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface MLGFINJLBLF : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MGHIBKJGDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task MBKIJCMMAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPMDFHFGCNG(Task NFANMEMOADP, string NJFIEFLKLDO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface JCIOFJMFHOM : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GPKOEFJDDBP> CMHBJGKIJKP(ALFEBNEDACP AAKFCMHHOAD);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FNFLKCCOEGD(CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface NMLOCBJIIPG : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CPHKDNMEPBN EFPHAALECDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CFPKKAOJOOJ();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CONMOLEOJHK();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface KCGIJCOKMAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface EMLICJCHFPN
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan HMLHAAFILNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan NFIOLELCAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan BHCPNLODLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan CLHKAGABHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool EPJLFDDBDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BGGMDMMHOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool EGPLHHMKBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int GEFNEOJPKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool EGPIBHPJPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool OEAKCCFNNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum FJHDGKHLMIB
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum NHBLINDOEMG
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
public struct PLIIDCKOCBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long OCCBCOMDEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long BBEDBHIBLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly FJHDGKHLMIB CFGJPNBLNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception IDCHKAEINIM;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x63CEC90", Offset = "0x63CDC90", VA = "0x1863CEC90")]
	public PLIIDCKOCBJ(long OCCBCOMDEIL, long BBEDBHIBLKF, FJHDGKHLMIB CFGJPNBLNDJ, [CanBeNull] Exception IDCHKAEINIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x63CEC40", Offset = "0x63CDC40", VA = "0x1863CEC40")]
	public static PLIIDCKOCBJ INBOMCKFCII(LPJIABDOGLI NJHKDCOIFMA, FJHDGKHLMIB CFGJPNBLNDJ, [Optional] Exception IDCHKAEINIM)
	{
		return default(PLIIDCKOCBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void PDCJPLBFMJI(PLIIDCKOCBJ BAHPNHBJDGL);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface HLLDBDIMMKG : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PJOCHGKDAFP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event PDCJPLBFMJI OJMBJMGOKLB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PDCJPLBFMJI NPCJLMIIICC;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event PDCJPLBFMJI DLPEAGBBNMJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<NHBLINDOEMG, bool> DABJLPBCIJC;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JOAOMJPOMIG();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HDPIDKGEGPB(PLIIDCKOCBJ BAHPNHBJDGL);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DAHDPGLJOKI(PLIIDCKOCBJ BAHPNHBJDGL);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IIGFFILPPAI(PLIIDCKOCBJ BAHPNHBJDGL);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IBGLKOEBPPO(NHBLINDOEMG FDIEGFHJBPI, bool ENFECCOPMNB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface DCCFFLDKHDH : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BBJMHDBNAPJ();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFBBCPHBFCO();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface LKKGAOCNCAA : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus KDOPLIBHGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KDNJLHJAELK(LPJIABDOGLI CMDBJODNHGC, NPOHIKBADKF DNKKJBOBOEN, CancellationToken PMLBMCIFPPF);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal static class CPNCGHDJHHN
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x63B8A20", Offset = "0x63B7A20", VA = "0x1863B8A20")]
	public static bool ELODKIFINAH(this LKKGAOCNCAA GCDBDOMPCOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public delegate Task DCOPGKCCEFD(LLGCMGAEGBM EINEAGMJDPE, CancellationToken PDIBILKHEBM);
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface EEDEELKDLCP : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KAFCGEEMOMC(DCOPGKCCEFD GIBNKPBAJGH);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface LDIAGFCFIDA : JKPGLBCGCAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken HMJJLCAJEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	EIABFOFJCDK MBPNABCEDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HDJBGMMJLFC FAMMNPAMCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	KCHBDCGPPPH FJMMKFGENEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	AJNHNKMBAPI DAKHMKMAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EODIMPPJHNN CPFJBHHNMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	HKNBGEDIAMP FFLACAEJINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	GBLGBHJLJDM MGAGEAKBMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	GDLDHDHGFLC OKIBDKJGBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	MLGFINJLBLF BINMDEJEHCK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	JCIOFJMFHOM ADNKHCPBNCE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	HLLDBDIMMKG KIIKJDFFEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	DCCFFLDKHDH PNFGIGNHHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	LKKGAOCNCAA ODGCOOHDJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	EEDEELKDLCP AJCGBACPKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	DMFAGANNFEB PHKHDOGLCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GEOABLCBIOL NAKOKFJFDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BBEIGKCDDOC CMMBJDKDOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	APHHJNEFHCN MAAJCLFBANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MCLEIFFAJFC IHPPCHCAOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OJIPPNEEKKD PLJKMELJBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	BOPJHPFOIKJ OBKGCFKGHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	NIIEPMNFECO JEBGJLAFGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	CIKDFOLBOHL AEEEKBNAGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	MAABAJGEJOG CGGBMNCFJCB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	NMLOCBJIIPG OKLDAANMCIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	EMLICJCHFPN POAABEHPLDF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	CENDBNHJIMP IPMEFCMOPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	LGDBIMMEJPN NDPJDGPCCHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	DICJKFHJMPC DNFLBICBLOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	PLGCFFBLAPM IICPPBOIPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void FBPCLDFNALK(NPOHIKBADKF IKJDADDCOOK);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface DMFAGANNFEB : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MGNBIDPCCPO GPDFOMDKBKK(Guid KBNMFHADFEA);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MOJJDBCCFOB(Guid KBNMFHADFEA);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PHCBENKNOLH(Guid KBNMFHADFEA, Task OJNIMCPHGBO);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MOICLCGBLAM(Guid KBNMFHADFEA, GPKOEFJDDBP MNBBNKGBJLD);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(GPKOEFJDDBP, Task)> CNMMPEFPDHA(Guid KBNMFHADFEA);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface HIHDCCEBCFI : KCGIJCOKMAL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface GEOABLCBIOL : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDJHLLBGPJC(OCGKKEPIGGA NCBOINMNCHO);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECNJIAFCNPM(OCGKKEPIGGA NCBOINMNCHO);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<LLJKCEKOIII> ELPCHKMBHPM(CancellationToken MIGJLIAPEPB);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface BBEIGKCDDOC : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MGNBIDPCCPO NKNJHJGCCPL(OCGKKEPIGGA GEPEPGIEIKL);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMINPDHEMDL(Guid KBNMFHADFEA, Task OJNIMCPHGBO);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface APHHJNEFHCN : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GPKOEFJDDBP> MAAJCLFBANF(OCGKKEPIGGA AFHEHHPFPLE);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface MCLEIFFAJFC : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CIFKNLJLNLO> DHKGJNCJJEN(PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, LPJIABDOGLI CMDBJODNHGC, CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface BOPJHPFOIKJ : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPKOEFJDDBP JMJDNJHKBGL(HANCNHADEOE MEOGCOCOCGG);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PFLCNGCCJDN(string JDDFHOGGEKO);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface OJIPPNEEKKD : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OCGKKEPIGGA> GLCELHFFPBD(OCGKKEPIGGA ICLPGCHCHFB, DIIGLJEEJID GIOADJKMGIC, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OCGKKEPIGGA> JLJGDPFLDEA(CancellationToken JEBPNJAPHEL, DIIGLJEEJID GIOADJKMGIC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IGDBPFKILJO BPGNHPKINCP(KNNODDOINJP CEPDGNPODKA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IGDBPFKILJO AOGGOBFNMPG(KNNODDOINJP CEPDGNPODKA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface NIIEPMNFECO : KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPKOEFJDDBP EHHIGILIHLG(HANCNHADEOE MEOGCOCOCGG, LLJKCEKOIII MGNBHKMDAHM);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GPKOEFJDDBP HPPGPJEGDEI(HANCNHADEOE HFOEIHALCPB);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface CIKDFOLBOHL
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKNKBBBAGIH(GOBGCHCBFKE OIOGMEAOAGL);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHOEIEFEFIB(GOBGCHCBFKE OIOGMEAOAGL);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGOBBMBCDGA(GOBGCHCBFKE OIOGMEAOAGL);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JECGLICMELC(GOBGCHCBFKE OIOGMEAOAGL);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class GOBGCHCBFKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly LPJIABDOGLI GCHBHHIEDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> DBLLDHMMIGA;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public PFLLCKOMFGL<string> BJNHMLNDGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x76F1E0", Offset = "0x76E1E0", VA = "0x18076F1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	public GOBGCHCBFKE(LPJIABDOGLI FDPAIPNDEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x63C3270", Offset = "0x63C2270", VA = "0x1863C3270")]
	public GOBGCHCBFKE MEHILEJJJDL(string BGNGIHJEFLM, string APPJEOKOGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x63C31E0", Offset = "0x63C21E0", VA = "0x1863C31E0")]
	public bool KHBNJOPCIIM([Out] IEnumerable<KeyValuePair<string, string>> HFMNOPDPNNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x57B2EF0", Offset = "0x57B1EF0", VA = "0x1857B2EF0")]
	public GOBGCHCBFKE CNOAJEOLGJK(PFLLCKOMFGL<string> HCMHKMALPLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface CENDBNHJIMP
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool BIKNDFCFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string HFJEJANADKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FLDJPBOCLLJ();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AHGNBMCPLNJ FPAOKJOJLPO(long BEMMFIIOINO);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PCBJJBIDLOM<AEBNJGMIDFC, CEHDOMGLFNK> CEBGFMDBOMK(long BEMMFIIOINO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PCBJJBIDLOM<AEBNJGMIDFC, LNIMNABFGFK> PCFILAAEINL(long BEMMFIIOINO);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PCBJJBIDLOM<long, JBPPNCKAHCO> LACOAPEAFOM();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ECCNNDPNCPC([Out] bool LGPHMHAJMKL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<bool> JJEOGNOHEGN(byte[] FBEOJJGECFJ, byte[] DFPGBDADMFH, CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JKPGLBCGCAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool ELODKIFINAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool MLEFFAPGGJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	NPOHIKBADKF LHPPJDAADBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action PJOCHGKDAFP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event PDCJPLBFMJI OJMBJMGOKLB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event PDCJPLBFMJI NPCJLMIIICC;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event PDCJPLBFMJI DLPEAGBBNMJ;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<NHBLINDOEMG, bool> DABJLPBCIJC;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NFBBCPHBFCO();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PJJOKIJBMJE AENKKNEINNF();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ANLPMPOIDDI OCCELDFHMCO();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<GPKOEFJDDBP> CMHBJGKIJKP(ALFEBNEDACP DHHBKLBMPLE);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task FNFLKCCOEGD(CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EODIMPPJHNN
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool COBDEALBIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string NHKNFFNJHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEMFOHMNLNA(Scene IKLNLCJKJBD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FPMIFDBBEKG(LDHMDLHGPJM JKHKGKOLPBM, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HBPIAFMNBKC();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface AJNHNKMBAPI
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	JPJCLLNFHEO EFLFLLHFENI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool APIFGAOGMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool CAJNIAJGLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool EGKILCCJEDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool ENMPHKEFDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool BJLJHNIAGEH
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool FNNECIMCNPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool KOOAKBBNMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float MHAFDCMBIOE
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> INNMIBBDJAA;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EIABFOFJCDK IDCOJFBALMM(EIABFOFJCDK BKLFELEFPAL);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BFLJABFEHPG(EIABFOFJCDK KMOLABGHAKI);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOFCEMBAEDN();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task NMAPFEHENID(PFLLCKOMFGL<string>.FEFFPGFLENA EDKJKHDNCBO, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PECILFNLDBN(float AEJFIFLCFKG);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MLOIGBMFBCP(string KHMNDPOMOEK);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<MDFHJOFLIGL> PDOHIJFOFAA();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable BAMPDPHLDIA(object ACJODAOHIHK, MDFHJOFLIGL NFJGGDJONND);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CEHDOMGLFNK FBLOOIPLHHK(IEnumerable<GNLAKLLEMDG> JKOMAFACIAO);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GECLJHDAOMI(int JBMNHFKOFIC);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task EBKIFJNHCMC();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NLDLFPOACBF();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool JNBHHLIMHHD();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task HOAIGFKKOOJ(CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task JDFIOKCGOND(CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<HIHNJPBHFDM> FPINEOHOKPF(DateTime OKPAEKGLCEA, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> HMJPHIOIBOP(CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HFMHMNFHBIA(string PDKNPGJCFFC = "", float GNOBHKOCPOE = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	ONJCJHIAIPL IPFLDHNJGPL(KEDEFKCBACM JALECPCCGGE, GIFIJHKEGCI NEHHMEJGJEP, LNIMNABFGFK NLDBDOPEINB, IEnumerable<PersistenceView> AFPFNPCPEKO, PDOHHCFENIE PPHLDLFCCII);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HCIPGDNDAOO(LNIMNABFGFK NLDBDOPEINB);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void BACJBHJFAEC(GNLAKLLEMDG FGNJDLEPFIE, [In] ONJCJHIAIPL CMCBDBKNKFJ);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task JJMHAIKGPGL(LNIMNABFGFK BDFKGNFLBBP, bool GCHBIFIPMCE, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task DADKCOPCGFC(CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void DFEPNBEOOPC(long KAOIBEOBDCN, long BBEDBHIBLKF, MCEIHIBECAG JOHECMNIEAD, GNBPKJBLPKB MKDCPCAPCGN, NKNGHGMAJIA LPBIKGAEGIH, CJCILOJDOKG? FHHGEIENCHI, DKIOIIGJIDP? KCGODJOOBFP);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PKJDKFLOCJL(long KAOIBEOBDCN, long BBEDBHIBLKF, DKIOIIGJIDP? KCGODJOOBFP);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void JDMMAMIGBAI(PersistenceView IMFHGNCIBFK);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool GEKNMNLNLFA(PersistenceView GCCDJCPNBME);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool BCLNPCMAPNI(GNLAKLLEMDG FGNJDLEPFIE, HGLNEIGIEKC PGJLFNBDKMM, [Out] EJMELBHFMJA OCFHBJACNBP);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task OLEHLMACHIE(CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void KFOBNGBMHEA();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable PPFLALAJMEK();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void BKODPFMPGEM(LNIMNABFGFK BDFKGNFLBBP, HGLNEIGIEKC PGJLFNBDKMM);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> GMCOFAEEDCJ(HDJBGMMJLFC GDOLGBNNMGG, CancellationToken JEBPNJAPHEL, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void IMHPEMCLOMO(CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<FACJKOPPMPM> JAJGMGIMAFM(IIKIHLCPMIO ICLPGCHCHFB);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<MCEIHIBECAG> MBHDLEEGGBB(long KAOIBEOBDCN, bool KFMEFLGEGFB, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<GNBPKJBLPKB> IKALLDFPJMI(long KAOIBEOBDCN, long BBEDBHIBLKF, long PDGMCGEBKOO, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<BPIJMECGCAC> GFDAIIAEHPH(string DFPKFFBPELK, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<BPIJMECGCAC> FBMFEGCADAI(string DFPKFFBPELK, long KAOIBEOBDCN, long BBEDBHIBLKF, string HHGIIFONOJM, PLGFLNIIODP.APLABLPHDMJ EINEAGMJDPE, PLGFLNIIODP.APLABLPHDMJ DFPGBDADMFH, int KMPEFDCGPJE);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool LAIAKINEBAH();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool GHFHFHFHALF();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool OCEDLNOOJPP(IEnumerable<EJMELBHFMJA> GLAGDDEFBLN);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void BPDAHOMPMHH(List<GameObject> CALDDLGGJEE);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float MKNOCFEKHAA();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> FMHGLOOJJLN(string PHMJOCAELEH, LoadSceneMode PDKEHDBGBOO, bool LALBJKCONEN, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void PLKCCFGLEGJ();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void FGHBMEBPKIJ(bool NHIMOAGIDEG);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void MPGKKLCMMFC(LPJIABDOGLI BEKJGEFHGNF);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task NCDHHFJCLFB(PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task GNHEEHPOJJD(PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task LGDJKPHPEDJ(PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "62")]
	IDisposable MEBGHDDIGBJ();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "63")]
	ONJLCGMCNIC OJAGNDHNPBH();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task JLDJPDOHFFL(CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ONJLCGMCNIC
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FMLFGGJFOFH(CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HPPHODOAOOA(CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct ONJCJHIAIPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> MGJOFHEHLEO;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum HIHNJPBHFDM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct KEDEFKCBACM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string JHCIBMLHIJK;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface JPJCLLNFHEO
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	LPJIABDOGLI ABNIKJDIBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	MCEIHIBECAG MMLJLCILFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	PNEBNDCHIFA CECNANBDCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool JMGMIHKOEID
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool IMCPOFGGCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int NLDKLDHNDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action OBNLLHKBMMD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> OEAPINPFMEA;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IECMKMEPIMH();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.AHKGLMIIALK> NPDBOFIHAOO(long BEMMFIIOINO, [Optional] CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<PKMJIJAANNP> BHHLGILGAFO();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task MCGKHDNDCPL();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(LPJIABDOGLI, NPOHIKBADKF) BNLKJEBBMDL();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FGJACDIIGLL CFEDMLLFDMP();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LFIFKFGHAHO(long BEMMFIIOINO);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MAABAJGEJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBOJNHDBNAM([Out] IEnumerable<int> JLCOEAPMMOI);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CINJOHAIAHL(APINBDFMKOH PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJBBJNPNFJP(APINBDFMKOH PDIBILKHEBM);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface ONOAELAKCOM
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CNLPKOIMJPJ(GPKOEFJDDBP CKLFFMBDKHA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface JOCMCIIGJPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBCABGBGKLA(KOPLIOIDIOP.NEKGEKFGLBG JAOLAKGBDEE);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEECNKJMPEH(KOPLIOIDIOP.NEKGEKFGLBG JAOLAKGBDEE);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface HKNBGEDIAMP : JOCMCIIGJPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPKOEFJDDBP PALHKNHHCAA(HANCNHADEOE HFOEIHALCPB);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GBLGBHJLJDM : JOCMCIIGJPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPKOEFJDDBP JMJDNJHKBGL(HANCNHADEOE AENINCMMGKC);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface AHGNBMCPLNJ
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CJDJPCEAKND<LDHMDLHGPJM, PKPFPNLKHDF>> PKHMGDBMDEG(string HHGIIFONOJM, long BEMMFIIOINO, IALLEOEJMID.BMNHCINNHOB KGGDGOKEOIC, CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface PCBJJBIDLOM<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CJDJPCEAKND<byte[], PKPFPNLKHDF>> BNBKDMFBAPB(TGetDataArg DKCNDPMKPNO, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CJDJPCEAKND<CJDGGCFLJMM<TData>, PKPFPNLKHDF> MOFAEFBMHMJ(byte[] FCLEEDACIMH);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class GENNMFNPEEK : LDIAGFCFIDA, JKPGLBCGCAD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct BKMMLHFGMBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<GPKOEFJDDBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public GENNMFNPEEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public ALFEBNEDACP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<GPKOEFJDDBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x63B17E0", Offset = "0x63B07E0", VA = "0x1863B17E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x63B1A60", Offset = "0x63B0A60", VA = "0x1863B1A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct LNGPMBIGPOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GENNMFNPEEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x63CBC50", Offset = "0x63CAC50", VA = "0x1863CBC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x63CBE80", Offset = "0x63CAE80", VA = "0x1863CBE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class PPEJNFLNAJB : IEnumerable<KCGIJCOKMAL>, IEnumerable, IEnumerator<KCGIJCOKMAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private KCGIJCOKMAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GENNMFNPEEK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private KCGIJCOKMAL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A40", Offset = "0x8BFA40", VA = "0x1808C0A40")]
		[DebuggerHidden]
		public PPEJNFLNAJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x63CEF60", Offset = "0x63CDF60", VA = "0x1863CEF60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x63CF3C0", Offset = "0x63CE3C0", VA = "0x1863CF3C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x63CF310", Offset = "0x63CE310", VA = "0x1863CF310", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KCGIJCOKMAL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x63CF310", Offset = "0x63CE310", VA = "0x1863CF310", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource OBEANNKMHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly EIABFOFJCDK KMOLABGHAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool BKIGCJKEOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private FIHBOINBLBH FHCBJNBKCBJ;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public HDJBGMMJLFC FAMMNPAMCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x774F20", Offset = "0x773F20", VA = "0x180774F20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x774F10", Offset = "0x773F10", VA = "0x180774F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public KCHBDCGPPPH FJMMKFGENEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7738C0", Offset = "0x7728C0", VA = "0x1807738C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7738F0", Offset = "0x7728F0", VA = "0x1807738F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public AJNHNKMBAPI DAKHMKMAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7738E0", Offset = "0x7728E0", VA = "0x1807738E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x773910", Offset = "0x772910", VA = "0x180773910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public EODIMPPJHNN CPFJBHHNMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x773900", Offset = "0x772900", VA = "0x180773900", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7738D0", Offset = "0x7728D0", VA = "0x1807738D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public HKNBGEDIAMP FFLACAEJINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x7728A0", VA = "0x1807738A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x7728B0", VA = "0x1807738B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public GBLGBHJLJDM MGAGEAKBMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7793B0", Offset = "0x7783B0", VA = "0x1807793B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7793C0", Offset = "0x7783C0", VA = "0x1807793C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public GDLDHDHGFLC OKIBDKJGBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x775D90", Offset = "0x774D90", VA = "0x180775D90", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x775EC0", Offset = "0x774EC0", VA = "0x180775EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public MLGFINJLBLF BINMDEJEHCK
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x775D60", Offset = "0x774D60", VA = "0x180775D60", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x775E30", Offset = "0x774E30", VA = "0x180775E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public JCIOFJMFHOM ADNKHCPBNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x775DE0", Offset = "0x774DE0", VA = "0x180775DE0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x775DB0", Offset = "0x774DB0", VA = "0x180775DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public HLLDBDIMMKG KIIKJDFFEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x87A850", Offset = "0x879850", VA = "0x18087A850", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x87A930", Offset = "0x879930", VA = "0x18087A930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public DCCFFLDKHDH PNFGIGNHHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x775E40", Offset = "0x774E40", VA = "0x180775E40", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x775EA0", Offset = "0x774EA0", VA = "0x180775EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public LKKGAOCNCAA ODGCOOHDJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x806B90", Offset = "0x805B90", VA = "0x180806B90", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x806B70", Offset = "0x805B70", VA = "0x180806B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public EEDEELKDLCP AJCGBACPKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x77D940", Offset = "0x77C940", VA = "0x18077D940", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x77D9E0", Offset = "0x77C9E0", VA = "0x18077D9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public DMFAGANNFEB PHKHDOGLCDG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x90A300", Offset = "0x909300", VA = "0x18090A300", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x90A4C0", Offset = "0x9094C0", VA = "0x18090A4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public HIHDCCEBCFI BJDBNJDLILK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x88E830", Offset = "0x88D830", VA = "0x18088E830", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x90A480", Offset = "0x909480", VA = "0x18090A480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public GEOABLCBIOL NAKOKFJFDDF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x90A310", Offset = "0x909310", VA = "0x18090A310", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x90A4E0", Offset = "0x9094E0", VA = "0x18090A4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public BBEIGKCDDOC CMMBJDKDOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x864EA0", Offset = "0x863EA0", VA = "0x180864EA0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x90A4A0", Offset = "0x9094A0", VA = "0x18090A4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public APHHJNEFHCN MAAJCLFBANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x90A320", Offset = "0x909320", VA = "0x18090A320", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x90A500", Offset = "0x909500", VA = "0x18090A500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public MCLEIFFAJFC IHPPCHCAOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x77D970", Offset = "0x77C970", VA = "0x18077D970", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x77D950", Offset = "0x77C950", VA = "0x18077D950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public OJIPPNEEKKD PLJKMELJBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x831150", Offset = "0x830150", VA = "0x180831150", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x831160", Offset = "0x830160", VA = "0x180831160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public BOPJHPFOIKJ OBKGCFKGHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x81A220", Offset = "0x819220", VA = "0x18081A220", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x81A1E0", Offset = "0x8191E0", VA = "0x18081A1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public NIIEPMNFECO JEBGJLAFGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x90A2F0", Offset = "0x9092F0", VA = "0x18090A2F0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x90A460", Offset = "0x909460", VA = "0x18090A460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public CIKDFOLBOHL AEEEKBNAGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3650", Offset = "0x7F2650", VA = "0x1807F3650", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3780", Offset = "0x7F2780", VA = "0x1807F3780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public MAABAJGEJOG CGGBMNCFJCB
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x90A3C0", Offset = "0x9093C0", VA = "0x18090A3C0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x90A6E0", Offset = "0x9096E0", VA = "0x18090A6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public NMLOCBJIIPG OKLDAANMCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x815000", Offset = "0x814000", VA = "0x180815000", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x90A620", Offset = "0x909620", VA = "0x18090A620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public EMLICJCHFPN POAABEHPLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x815010", Offset = "0x814010", VA = "0x180815010", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x90A5C0", Offset = "0x9095C0", VA = "0x18090A5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public CENDBNHJIMP IPMEFCMOPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3E0", Offset = "0x7FC3E0", VA = "0x1807FD3E0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x90A700", Offset = "0x909700", VA = "0x18090A700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public LGDBIMMEJPN NDPJDGPCCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3D0", Offset = "0x7FC3D0", VA = "0x1807FD3D0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public DICJKFHJMPC DNFLBICBLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3F0", Offset = "0x7FC3F0", VA = "0x1807FD3F0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public PLGCFFBLAPM IICPPBOIPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7FD250", Offset = "0x7FC250", VA = "0x1807FD250", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public NPOHIKBADKF LHPPJDAADBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7FD230", Offset = "0x7FC230", VA = "0x1807FD230", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x90A540", Offset = "0x909540", VA = "0x18090A540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private bool NLLLHHHIMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x63C2590", Offset = "0x63C1590", VA = "0x1863C2590", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private bool NDBFJKECIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x63C2070", Offset = "0x63C1070", VA = "0x1863C2070", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private CancellationToken CBJNHDJHMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x63C2970", Offset = "0x63C1970", VA = "0x1863C2970", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private EIABFOFJCDK DAINIOMHKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action GFJMENIMKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x63C2B70", Offset = "0x63C1B70", VA = "0x1863C2B70", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x63C2450", Offset = "0x63C1450", VA = "0x1863C2450", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event PDCJPLBFMJI BFCKIKMDBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x63C2150", Offset = "0x63C1150", VA = "0x1863C2150", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x63C27C0", Offset = "0x63C17C0", VA = "0x1863C27C0", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event PDCJPLBFMJI KAPDCNPBBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x63C2A80", Offset = "0x63C1A80", VA = "0x1863C2A80", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x63C2A20", Offset = "0x63C1A20", VA = "0x1863C2A20", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event PDCJPLBFMJI APAHJLLHBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x63C2820", Offset = "0x63C1820", VA = "0x1863C2820", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x63C2650", Offset = "0x63C1650", VA = "0x1863C2650", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<NHBLINDOEMG, bool> OOPMGFOBIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x63C25F0", Offset = "0x63C15F0", VA = "0x1863C25F0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x63C2530", Offset = "0x63C1530", VA = "0x1863C2530", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x90A540", Offset = "0x909540", VA = "0x18090A540", Slot = "35")]
	public void FBPCLDFNALK(NPOHIKBADKF IKJDADDCOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x63C2BD0", Offset = "0x63C1BD0", VA = "0x1863C2BD0")]
	[UnityEngine.Scripting.Preserve]
	internal GENNMFNPEEK([KHIPNIHHNOH(null)] EIABFOFJCDK KMOLABGHAKI, [KHIPNIHHNOH(null)] HDJBGMMJLFC GDOLGBNNMGG, [KHIPNIHHNOH(null)] KCHBDCGPPPH KGHINEPPBBP, [KHIPNIHHNOH(null)] AJNHNKMBAPI ICCKKADELMP, [KHIPNIHHNOH(null)] EODIMPPJHNN POHAKDGIKMP, [KHIPNIHHNOH(null)] HKNBGEDIAMP FHPMIMGAPAL, [KHIPNIHHNOH(null)] GBLGBHJLJDM BBPCJKAMNDJ, [KHIPNIHHNOH(null)] GDLDHDHGFLC DDFGMGKALFA, [KHIPNIHHNOH(null)] MLGFINJLBLF HLLADAHJIKI, [KHIPNIHHNOH(null)] JCIOFJMFHOM JJPJPJOANDD, [KHIPNIHHNOH(null)] HLLDBDIMMKG DEPDCGPCBEO, [KHIPNIHHNOH(null)] DCCFFLDKHDH KMDEMPIBNOP, [KHIPNIHHNOH(null)] LKKGAOCNCAA GCDBDOMPCOJ, [KHIPNIHHNOH(null)] EEDEELKDLCP CHLKAJKGCFB, [KHIPNIHHNOH(null)] DMFAGANNFEB MEEGNMOGOCG, [KHIPNIHHNOH(null)] HIHDCCEBCFI HCPAGLNJHFH, [KHIPNIHHNOH(null)] GEOABLCBIOL ELKPIPANCNI, [KHIPNIHHNOH(null)] BBEIGKCDDOC GMANHAHEDIM, [KHIPNIHHNOH(null)] APHHJNEFHCN OANHIDGHBIG, [KHIPNIHHNOH(null)] MCLEIFFAJFC EELDOPCJBMJ, [KHIPNIHHNOH(null)] BOPJHPFOIKJ OMBPNHFAEKD, [KHIPNIHHNOH(null)] OJIPPNEEKKD MBJJPJOGOMB, [KHIPNIHHNOH(null)] NIIEPMNFECO FINBHBAEEKE, [KHIPNIHHNOH(null)] CIKDFOLBOHL AAEIOODGKEF, [KHIPNIHHNOH(null)] MAABAJGEJOG DEMCBPBAOIJ, [KHIPNIHHNOH(null)] EMLICJCHFPN IBEAHHFJKHM, [KHIPNIHHNOH(null)] CENDBNHJIMP FBEIEFOEFPN, [KHIPNIHHNOH(null)] LGDBIMMEJPN KIKBJMDCNKM, [KHIPNIHHNOH(null)] DICJKFHJMPC CHDNMPPKMOG, [KHIPNIHHNOH(null)] PLGCFFBLAPM MAPNJIKJEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x63C2350", Offset = "0x63C1350", VA = "0x1863C2350")]
	private void EMCBFDNIFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x63C21B0", Offset = "0x63C11B0", VA = "0x1863C21B0", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x63C2400", Offset = "0x63C1400", VA = "0x1863C2400", Slot = "48")]
	private void FBDLKNOJDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x63C2AE0", Offset = "0x63C1AE0", VA = "0x1863C2AE0", Slot = "49")]
	private PJJOKIJBMJE NPMIKPFJDJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x63C2990", Offset = "0x63C1990", VA = "0x1863C2990", Slot = "50")]
	private ANLPMPOIDDI MMBGAGFPBLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x63C26B0", Offset = "0x63C16B0", VA = "0x1863C26B0", Slot = "51")]
	[AsyncStateMachine(typeof(BKMMLHFGMBM))]
	private Task<GPKOEFJDDBP> KHBFMEELBHE(ALFEBNEDACP AAKFCMHHOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x63C2880", Offset = "0x63C1880", VA = "0x1863C2880", Slot = "52")]
	[AsyncStateMachine(typeof(LNGPMBIGPOE))]
	private Task LNLKMDKLLNG(CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x63C24B0", Offset = "0x63C14B0", VA = "0x1863C24B0")]
	[IteratorStateMachine(typeof(PPEJNFLNAJB))]
	private IEnumerable<KCGIJCOKMAL> FIOHGFGGCHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x63C20F0", Offset = "0x63C10F0", VA = "0x1863C20F0")]
	[CompilerGenerated]
	private void ALBANOPJKPP(KCGIJCOKMAL NDABCGGAOCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class EEHHBPHPBEJ : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0xC73510", Offset = "0xC72510", VA = "0x180C73510")]
	public EEHHBPHPBEJ(string NCBOINMNCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class KMPACBIGIKA : JAGELHBFLJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct HFNJJCKGEGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KMPACBIGIKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x63C34B0", Offset = "0x63C24B0", VA = "0x1863C34B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x63C37F0", Offset = "0x63C27F0", VA = "0x1863C37F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly AJNHNKMBAPI ICCKKADELMP;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x77EB20", Offset = "0x77DB20", VA = "0x18077EB20")]
	public KMPACBIGIKA(LDIAGFCFIDA MFKBBJFDJHI, AJNHNKMBAPI ICCKKADELMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x63CADC0", Offset = "0x63C9DC0", VA = "0x1863CADC0", Slot = "4")]
	[AsyncStateMachine(typeof(HFNJJCKGEGB))]
	public Task<bool> OCELIPOPHMN(CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x63CAEB0", Offset = "0x63C9EB0", VA = "0x1863CAEB0")]
	[CompilerGenerated]
	private object PMPDCKNKKIN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class IBHBDOMIFJH : JAGELHBFLJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct AHGKJHFAICN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public IBHBDOMIFJH <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x63B0D10", Offset = "0x63AFD10", VA = "0x1863B0D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x63B1420", Offset = "0x63B0420", VA = "0x1863B1420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly AJNHNKMBAPI ICCKKADELMP;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private JPJCLLNFHEO EFLFLLHFENI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x63C52F0", Offset = "0x63C42F0", VA = "0x1863C52F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x77EB20", Offset = "0x77DB20", VA = "0x18077EB20")]
	public IBHBDOMIFJH(LDIAGFCFIDA MFKBBJFDJHI, AJNHNKMBAPI ICCKKADELMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x63C5420", Offset = "0x63C4420", VA = "0x1863C5420", Slot = "4")]
	[AsyncStateMachine(typeof(AHGKJHFAICN))]
	public Task<bool> OCELIPOPHMN(CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x63C5340", Offset = "0x63C4340", VA = "0x1863C5340")]
	[CompilerGenerated]
	private object KEKPHONLNEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class HFNAGOBLBPH : JAGELHBFLJN
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class NGHMGMPNLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public HFNAGOBLBPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public PKMJIJAANNP result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public LPJIABDOGLI newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public NGHMGMPNLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x63CC850", Offset = "0x63CB850", VA = "0x1863CC850")]
		internal object FIGDINOLDBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x63CC9E0", Offset = "0x63CB9E0", VA = "0x1863CC9E0")]
		internal object GGNCOAHPKAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x63CC940", Offset = "0x63CB940", VA = "0x1863CC940")]
		internal object GCEBDGCAFDI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct DDPPEIMGCFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public HFNAGOBLBPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private NGHMGMPNLLO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<PKMJIJAANNP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x63B9510", Offset = "0x63B8510", VA = "0x1863B9510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x63B9E40", Offset = "0x63B8E40", VA = "0x1863B9E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly AJNHNKMBAPI ICCKKADELMP;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private JPJCLLNFHEO EFLFLLHFENI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x63C3340", Offset = "0x63C2340", VA = "0x1863C3340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x77EB20", Offset = "0x77DB20", VA = "0x18077EB20")]
	public HFNAGOBLBPH(LDIAGFCFIDA MFKBBJFDJHI, AJNHNKMBAPI ICCKKADELMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x63C3390", Offset = "0x63C2390", VA = "0x1863C3390", Slot = "4")]
	[AsyncStateMachine(typeof(DDPPEIMGCFC))]
	public Task<bool> OCELIPOPHMN(CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal interface JAGELHBFLJN
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> OCELIPOPHMN(CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct FMIANKPMMJI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class GBJPOJHIEIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LDIAGFCFIDA manager;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public GBJPOJHIEIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x63C2020", Offset = "0x63C1020", VA = "0x1863C2020")]
		internal Task HDPCJANHHGO(LLGCMGAEGBM data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct OJJLENJIDNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public FMIANKPMMJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private ALFEBNEDACP <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<HIHNJPBHFDM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<GPKOEFJDDBP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x63CE1A0", Offset = "0x63CD1A0", VA = "0x1863CE1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x63CE730", Offset = "0x63CD730", VA = "0x1863CE730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct OGEHBDJDEDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public FMIANKPMMJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x63CD2D0", Offset = "0x63CC2D0", VA = "0x1863CD2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x63CD5F0", Offset = "0x63CC5F0", VA = "0x1863CD5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken JEBPNJAPHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly LDIAGFCFIDA PPJFGCMLNID;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private HDJBGMMJLFC FAMMNPAMCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x63C15B0", Offset = "0x63C05B0", VA = "0x1863C15B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private AJNHNKMBAPI DAKHMKMAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x63C1AF0", Offset = "0x63C0AF0", VA = "0x1863C1AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private JPJCLLNFHEO EFLFLLHFENI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x63C1530", Offset = "0x63C0530", VA = "0x1863C1530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private JCIOFJMFHOM ADNKHCPBNCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x63C1600", Offset = "0x63C0600", VA = "0x1863C1600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8E80", Offset = "0x1CB7E80", VA = "0x181CB8E80")]
	public FMIANKPMMJI(CancellationToken JEBPNJAPHEL, LDIAGFCFIDA PPJFGCMLNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x63C1930", Offset = "0x63C0930", VA = "0x1863C1930")]
	public static DCOPGKCCEFD KIKLMJPANJJ(LDIAGFCFIDA PPJFGCMLNID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x63C19E0", Offset = "0x63C09E0", VA = "0x1863C19E0")]
	[AsyncStateMachine(typeof(OJJLENJIDNB))]
	public Task<bool> LODICMNCPHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x63C1650", Offset = "0x63C0650", VA = "0x1863C1650")]
	private bool FKMFMEAGHKN([Out] ALFEBNEDACP AAKFCMHHOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x63C1860", Offset = "0x63C0860", VA = "0x1863C1860")]
	[AsyncStateMachine(typeof(OGEHBDJDEDP))]
	private Task GLMCCCCFDLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x63C1400", Offset = "0x63C0400", VA = "0x1863C1400")]
	private Task<HIHNJPBHFDM> CNNJOGLPHFF(ALFEBNEDACP DJOJEGJIAJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct MGNBIDPCCPO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly DMFAGANNFEB MEEGNMOGOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid KBNMFHADFEA;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private Task<(GPKOEFJDDBP, Task)> PHFGMOHOPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x63CC310", Offset = "0x63CB310", VA = "0x1863CC310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3A50510", Offset = "0x3A4F510", VA = "0x183A50510")]
	public MGNBIDPCCPO(DMFAGANNFEB MEEGNMOGOCG, Guid KBNMFHADFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x63CC4B0", Offset = "0x63CB4B0", VA = "0x1863CC4B0")]
	public TaskAwaiter<(GPKOEFJDDBP, Task)> LKIDDMAHHKC()
	{
		return default(TaskAwaiter<(GPKOEFJDDBP, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x63CC3E0", Offset = "0x63CB3E0", VA = "0x1863CC3E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct HIBBEFOIKHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(GPKOEFJDDBP, Task)> DANPNEDOJAD;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Task<(GPKOEFJDDBP, Task)> PHFGMOHOPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x63C38F0", Offset = "0x63C28F0", VA = "0x1863C38F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x63C3AB0", Offset = "0x63C2AB0", VA = "0x1863C3AB0")]
	public HIBBEFOIKHE(TimeSpan HMHJOGKKCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x63C3A10", Offset = "0x63C2A10", VA = "0x1863C3A10")]
	public void PLFDOFHEIEJ(Task OJNIMCPHGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x63C3930", Offset = "0x63C2930", VA = "0x1863C3930")]
	public void KEKMOHAPALD(GPKOEFJDDBP CKLFFMBDKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x63C39C0", Offset = "0x63C29C0", VA = "0x1863C39C0")]
	public void MOCCNHIBKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x63C3860", Offset = "0x63C2860", VA = "0x1863C3860")]
	internal void BMHHJLAAGGH(string NCBOINMNCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class DHNGEDIMLCO
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CHEPJIIFLBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public GNBPKJBLPKB subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public CHEPJIIFLBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x63B8400", Offset = "0x63B7400", VA = "0x1863B8400")]
		internal bool KFOKGPBKLBB(PNEBNDCHIFA s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x63BA330", Offset = "0x63B9330", VA = "0x1863BA330")]
	public static CIFKNLJLNLO BJANKEDJCNP(long OCCBCOMDEIL, long BBEDBHIBLKF, string DFPKFFBPELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x63BA270", Offset = "0x63B9270", VA = "0x1863BA270")]
	public static CIFKNLJLNLO BJANKEDJCNP(long OCCBCOMDEIL, long BBEDBHIBLKF, AEBNJGMIDFC FBEOJJGECFJ, long PDGMCGEBKOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x63BA0E0", Offset = "0x63B90E0", VA = "0x1863BA0E0")]
	public static CIFKNLJLNLO BJANKEDJCNP(FACJKOPPMPM DPIGDHJNLHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x63B9EB0", Offset = "0x63B8EB0", VA = "0x1863B9EB0")]
	public static CIFKNLJLNLO BJANKEDJCNP(MCEIHIBECAG GIDHGDFNHBL, GNBPKJBLPKB AONKFANDODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x63BA3C0", Offset = "0x63B93C0", VA = "0x1863BA3C0")]
	public static CIFKNLJLNLO JFNJJEOKGFJ(this CIFKNLJLNLO HPEDGLBMGED, MCEIHIBECAG COGGHJCNLOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x63BA4B0", Offset = "0x63B94B0", VA = "0x1863BA4B0")]
	public static CIFKNLJLNLO NKJLOGMBGBH(this CIFKNLJLNLO HPEDGLBMGED, GNBPKJBLPKB LGPFNKCDIBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[RecRoom.NoEngine.Common.Preserve]
internal class BMKCGFPJMKE : MLGFINJLBLF, KCGIJCOKMAL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct EKPBKPDFOOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public BMKCGFPJMKE <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x63BEDF0", Offset = "0x63BDDF0", VA = "0x1863BEDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x63BF4D0", Offset = "0x63BE4D0", VA = "0x1863BF4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly APINBDFMKOH CFAALPDAKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string DJEKCMIPHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task FKIKLGPABMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool MGHIBKJGDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x63B1CC0", Offset = "0x63B0CC0", VA = "0x1863B1CC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public Task MBKIJCMMAOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x63B1C30", Offset = "0x63B0C30", VA = "0x1863B1C30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x76F190", Offset = "0x76E190", VA = "0x18076F190", Slot = "7")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x63B1AD0", Offset = "0x63B0AD0", VA = "0x1863B1AD0", Slot = "6")]
	public void CPMDFHFGCNG(Task NFANMEMOADP, string NJFIEFLKLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x63B1CF0", Offset = "0x63B0CF0", VA = "0x1863B1CF0")]
	[AsyncStateMachine(typeof(EKPBKPDFOOJ))]
	private Task PLIKKBPIJAP(Task KAFKMEMECKB, string NJFIEFLKLDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x63B1E10", Offset = "0x63B0E10", VA = "0x1863B1E10")]
	public BMKCGFPJMKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class PKFLMMGMNPG : NMLOCBJIIPG, KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool IOMCAPGFLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private CPHKDNMEPBN KOJOMBHDIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private HDJBGMMJLFC GDOLGBNNMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private EMLICJCHFPN IBEAHHFJKHM;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public CPHKDNMEPBN EFPHAALECDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x63CE990", Offset = "0x63CD990", VA = "0x1863CE990", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x63CEA00", Offset = "0x63CDA00", VA = "0x1863CEA00", Slot = "7")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x63CE7A0", Offset = "0x63CD7A0", VA = "0x1863CE7A0", Slot = "5")]
	public void CFPKKAOJOOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x63CE950", Offset = "0x63CD950", VA = "0x1863CE950", Slot = "6")]
	public void CONMOLEOJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x63CEB80", Offset = "0x63CDB80", VA = "0x1863CEB80")]
	private Task NEGDHNPJNJE(LCMKDIGGNML GDKIMOIKOFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x63CE950", Offset = "0x63CD950", VA = "0x1863CE950", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public PKFLMMGMNPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class IHPEDBMLGFG : EMLICJCHFPN
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class LBBKBNFIFAJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly MDJCEOLJBNI HFMMICCLHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly string BGNGIHJEFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly T ELMPJJEOKEH;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public T INAJMIAKCCF
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x7C4710", Offset = "0x7C3710", VA = "0x1807C4710")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x8F2680", Offset = "0x8F1680", VA = "0x1808F2680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B7F0", Offset = "0x3A5A7F0", VA = "0x183A5B7F0")]
		public LBBKBNFIFAJ(MDJCEOLJBNI HFMMICCLHEK, string BGNGIHJEFLM, T ELMPJJEOKEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B420", Offset = "0x3A5A420", VA = "0x183A5B420")]
		private void JOHEMDBJPMF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly MDJCEOLJBNI HFMMICCLHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly LBBKBNFIFAJ<TimeSpan> OJHELBKILEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly LBBKBNFIFAJ<TimeSpan> IGIIADFOOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly LBBKBNFIFAJ<TimeSpan> CFCKHAOCBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly LBBKBNFIFAJ<TimeSpan> IHIMPHEHFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly LBBKBNFIFAJ<bool> LCBMKIFNOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly LBBKBNFIFAJ<bool> NGAHCHEBOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly LBBKBNFIFAJ<bool> EINMGOHBAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly LBBKBNFIFAJ<int> NCKNIMNPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly LBBKBNFIFAJ<bool> KEEMOOPEJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly LBBKBNFIFAJ<bool> MAFCDKEEDDD;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan HMLHAAFILNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x63C5C30", Offset = "0x63C4C30", VA = "0x1863C5C30", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TimeSpan NFIOLELCAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x63C5AF0", Offset = "0x63C4AF0", VA = "0x1863C5AF0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public TimeSpan BHCPNLODLGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x63C5C70", Offset = "0x63C4C70", VA = "0x1863C5C70", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public TimeSpan CLHKAGABHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x63C5B70", Offset = "0x63C4B70", VA = "0x1863C5B70", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool EPJLFDDBDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x63C5BB0", Offset = "0x63C4BB0", VA = "0x1863C5BB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool BGGMDMMHOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x63C5CF0", Offset = "0x63C4CF0", VA = "0x1863C5CF0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool EGPLHHMKBEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x63C5D30", Offset = "0x63C4D30", VA = "0x1863C5D30", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int GEFNEOJPKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x63C5CB0", Offset = "0x63C4CB0", VA = "0x1863C5CB0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool EGPIBHPJPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x63C5B30", Offset = "0x63C4B30", VA = "0x1863C5B30", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool OEAKCCFNNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x63C5BF0", Offset = "0x63C4BF0", VA = "0x1863C5BF0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x63C5D70", Offset = "0x63C4D70", VA = "0x1863C5D70")]
	[UnityEngine.Scripting.Preserve]
	public IHPEDBMLGFG([KHIPNIHHNOH(null)] MDJCEOLJBNI HFMMICCLHEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[UnityEngine.Scripting.Preserve]
internal class OGNLCKGKBMC : HLLDBDIMMKG, KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class IJOCMLCMINE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public PLIIDCKOCBJ roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public IJOCMLCMINE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x63C6750", Offset = "0x63C5750", VA = "0x1863C6750")]
		internal object CFGCCCHEDAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action PJOCHGKDAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x63CDAE0", Offset = "0x63CCAE0", VA = "0x1863CDAE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x63CE100", Offset = "0x63CD100", VA = "0x1863CE100", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event PDCJPLBFMJI OJMBJMGOKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x63CD870", Offset = "0x63CC870", VA = "0x1863CD870", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x63CD7A0", Offset = "0x63CC7A0", VA = "0x1863CD7A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event PDCJPLBFMJI NPCJLMIIICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x63CE060", Offset = "0x63CD060", VA = "0x1863CE060", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x63CD9F0", Offset = "0x63CC9F0", VA = "0x1863CD9F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event PDCJPLBFMJI DLPEAGBBNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x63CD700", Offset = "0x63CC700", VA = "0x1863CD700", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x63CDFC0", Offset = "0x63CCFC0", VA = "0x1863CDFC0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NHBLINDOEMG, bool> DABJLPBCIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x63CD910", Offset = "0x63CC910", VA = "0x1863CD910", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x63CD650", Offset = "0x63CC650", VA = "0x1863CD650", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "19")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x63CDBB0", Offset = "0x63CCBB0", VA = "0x1863CDBB0", Slot = "14")]
	public void JOAOMJPOMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x63CD9C0", Offset = "0x63CC9C0", VA = "0x1863CD9C0", Slot = "15")]
	public void HDPIDKGEGPB(PLIIDCKOCBJ BAHPNHBJDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x63CD840", Offset = "0x63CC840", VA = "0x1863CD840", Slot = "16")]
	public void DAHDPGLJOKI(PLIIDCKOCBJ BAHPNHBJDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x63CDB80", Offset = "0x63CCB80", VA = "0x1863CDB80", Slot = "17")]
	public void IIGFFILPPAI(PLIIDCKOCBJ BAHPNHBJDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x63CDA90", Offset = "0x63CCA90", VA = "0x1863CDA90", Slot = "18")]
	public void IBGLKOEBPPO(NHBLINDOEMG FDIEGFHJBPI, bool ENFECCOPMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x63CDDD0", Offset = "0x63CCDD0", VA = "0x1863CDDD0")]
	private void KJKIFIOBHDO(PDCJPLBFMJI NFJGGDJONND, PLIIDCKOCBJ BAHPNHBJDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public OGNLCKGKBMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal class ELNDIJABOGB : DCCFFLDKHDH, KCGIJCOKMAL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct JDPMPGNDEAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public ELNDIJABOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x63C6D60", Offset = "0x63C5D60", VA = "0x1863C6D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x63C72B0", Offset = "0x63C62B0", VA = "0x1863C72B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct IADMGLIFJJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public ELNDIJABOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x63C4BF0", Offset = "0x63C3BF0", VA = "0x1863C4BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x63C5290", Offset = "0x63C4290", VA = "0x1863C5290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class CBAODACNBON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public CBAODACNBON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x63B2900", Offset = "0x63B1900", VA = "0x1863B2900")]
		internal object MCAEKNPFJEB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct OEBNABCILGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public ELNDIJABOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private CBAODACNBON <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x63CCAD0", Offset = "0x63CBAD0", VA = "0x1863CCAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x63CD260", Offset = "0x63CC260", VA = "0x1863CD260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class CKGPCKJJJGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public CKGPCKJJJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x63B84D0", Offset = "0x63B74D0", VA = "0x1863B84D0")]
		internal object MBPNBEADAGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly IMFBLHALHMN DJHKLFMABMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private AJNHNKMBAPI ICCKKADELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private JAGELHBFLJN[] DHIDNCKADIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private CancellationTokenSource OCCBKDMNJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private int CAKKLJNJJND;

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x63BF7D0", Offset = "0x63BE7D0", VA = "0x1863BF7D0", Slot = "6")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x63BF7C0", Offset = "0x63BE7C0", VA = "0x1863BF7C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x63BF980", Offset = "0x63BE980", VA = "0x1863BF980", Slot = "8")]
	public void ICBCAGAGNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x63BFDE0", Offset = "0x63BEDE0", VA = "0x1863BFDE0", Slot = "5")]
	public void NFBBCPHBFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x63BF610", Offset = "0x63BE610", VA = "0x1863BF610", Slot = "4")]
	[AsyncStateMachine(typeof(JDPMPGNDEAC))]
	public Task BBJMHDBNAPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x63BFEC0", Offset = "0x63BEEC0", VA = "0x1863BFEC0")]
	private void ODDBJJPPLCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x63BFA90", Offset = "0x63BEA90", VA = "0x1863BFA90")]
	[AsyncStateMachine(typeof(IADMGLIFJJN))]
	private Task IKCMOKCDLJD(CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x63BFB80", Offset = "0x63BEB80", VA = "0x1863BFB80")]
	[AsyncStateMachine(typeof(OEBNABCILGA))]
	private Task<bool> MMNNBEGFAAP(int NFJIPMHILEL, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x63BF6E0", Offset = "0x63BE6E0", VA = "0x1863BF6E0")]
	private void DLHGFLLJGNJ(int NFJIPMHILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x63BF530", Offset = "0x63BE530", VA = "0x1863BF530")]
	private void AMPIKIBKIPA(int NFJIPMHILEL, bool ENFECCOPMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x63BFCB0", Offset = "0x63BECB0", VA = "0x1863BFCB0")]
	private void NCBKKDLCHDD(int NFJIPMHILEL, Exception GDBKEDNPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x63BF850", Offset = "0x63BE850", VA = "0x1863BF850")]
	private void HGGADIBELNB(CancellationToken JEBPNJAPHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public ELNDIJABOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class DIGDBAKOPOA : LKKGAOCNCAA, KCGIJCOKMAL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct DALOOHILODI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public LPJIABDOGLI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public DIGDBAKOPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public NPOHIKBADKF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x63B8AF0", Offset = "0x63B7AF0", VA = "0x1863B8AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x63B94B0", Offset = "0x63B84B0", VA = "0x1863B94B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct DNANBIIAHLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public DIGDBAKOPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public LPJIABDOGLI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public NPOHIKBADKF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private PFLLCKOMFGL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private DIIGLJEEJID <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private GOBGCHCBFKE <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x63BE190", Offset = "0x63BD190", VA = "0x1863BE190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x63BED90", Offset = "0x63BDD90", VA = "0x1863BED90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class MNIECJDFGGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Matchmaking.BLIHHMIJHKK result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public DNCIBFDLMHO errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public MNIECJDFGGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x63CC500", Offset = "0x63CB500", VA = "0x1863CC500")]
		internal object OIMIPDBHPEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class FNOAOPFNOCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Task<CIFKNLJLNLO> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FNOAOPFNOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		internal Task<CIFKNLJLNLO> JDKDPEMOGKC(PFLLCKOMFGL<string>.FEFFPGFLENA _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct CGEHJNJOMPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public DIGDBAKOPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public LPJIABDOGLI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public NPOHIKBADKF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public DIIGLJEEJID joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private FNOAOPFNOCN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private HKPEMPOGMNP <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private LOMEGEHHEJF <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Task<Matchmaking.AHKGLMIIALK> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private FPAACNFKCED <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter<Matchmaking.AHKGLMIIALK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<CIFKNLJLNLO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x63B2970", Offset = "0x63B1970", VA = "0x1863B2970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x63B7B10", Offset = "0x63B6B10", VA = "0x1863B7B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct JJLHNOANJBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public DIGDBAKOPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x63C8A10", Offset = "0x63C7A10", VA = "0x1863C8A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x63C94A0", Offset = "0x63C84A0", VA = "0x1863C94A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct CPLIPDBMMKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public DIGDBAKOPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private EIABFOFJCDK <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x63B8540", Offset = "0x63B7540", VA = "0x1863B8540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x63B89C0", Offset = "0x63B79C0", VA = "0x1863B89C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct IIMMBDFOPKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder<Matchmaking.AHKGLMIIALK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public LPJIABDOGLI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public DIGDBAKOPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter<Matchmaking.AHKGLMIIALK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x63C61E0", Offset = "0x63C51E0", VA = "0x1863C61E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x63C66E0", Offset = "0x63C56E0", VA = "0x1863C66E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct LBKBDMOGJAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Matchmaking.AHKGLMIIALK serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public DIGDBAKOPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public DIIGLJEEJID joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<HIILJJLBAJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x63CAF90", Offset = "0x63C9F90", VA = "0x1863CAF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x63CB6C0", Offset = "0x63CA6C0", VA = "0x1863CB6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class MDJLEMALGML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public LPJIABDOGLI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public MDJLEMALGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x63CC110", Offset = "0x63CB110", VA = "0x1863CC110")]
		internal object EPPMDINNEML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x63CC210", Offset = "0x63CB210", VA = "0x1863CC210")]
		internal string LHIBIOACBBK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct EOCEACJMJGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public LPJIABDOGLI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public DIGDBAKOPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private MDJLEMALGML <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x63C0770", Offset = "0x63BF770", VA = "0x1863C0770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x63C13A0", Offset = "0x63C03A0", VA = "0x1863C13A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct KFKMBIBIMIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public DIGDBAKOPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public DIIGLJEEJID joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CIFKNLJLNLO initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public LPJIABDOGLI targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public HKPEMPOGMNP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x63CA350", Offset = "0x63C9350", VA = "0x1863CA350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x63CAC60", Offset = "0x63C9C60", VA = "0x1863CAC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct JHEDMDBHHIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public DIGDBAKOPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x63C7310", Offset = "0x63C6310", VA = "0x1863C7310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x63C89B0", Offset = "0x63C79B0", VA = "0x1863C89B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct CGMBMGBINDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public DIGDBAKOPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<GPKOEFJDDBP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x63B7B70", Offset = "0x63B6B70", VA = "0x1863B7B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x63B83A0", Offset = "0x63B73A0", VA = "0x1863B83A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class GJMCEOPKEIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public LPJIABDOGLI targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public GJMCEOPKEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x63C3010", Offset = "0x63C2010", VA = "0x1863C3010")]
		internal object PJBLNGLBOOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class CJNBKFADLJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public CJNBKFADLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x63B8430", Offset = "0x63B7430", VA = "0x1863B8430")]
		internal void BEAGKJDHCJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class DAHJECBNNOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public LPJIABDOGLI targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public DAHJECBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x63B8A70", Offset = "0x63B7A70", VA = "0x1863B8A70")]
		internal object GMGKOLOPIHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class KLFJGLIKPHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public LPJIABDOGLI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public KLFJGLIKPHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x63CACC0", Offset = "0x63C9CC0", VA = "0x1863CACC0")]
		internal string GPEJNNCBPEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly IMFBLHALHMN DJHKLFMABMI;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly IMFBLHALHMN CFIGAODLBEG;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly IMFBLHALHMN PFAAOHILLAA;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly IMFBLHALHMN DANAIPINIHM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly string IIBHGNDLDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string NCLJDPNAFCA;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string NFKIIFAMDCP;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static readonly Guid DKDHFLMOIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private GDLDHDHGFLC DDFGMGKALFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private KCHBDCGPPPH KGHINEPPBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private HDJBGMMJLFC GDOLGBNNMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private AJNHNKMBAPI ICCKKADELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private DCCFFLDKHDH KMDEMPIBNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private MLGFINJLBLF HLLADAHJIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private HLLDBDIMMKG DEPDCGPCBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private PLGCFFBLAPM MAPNJIKJEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private DICJKFHJMPC CHDNMPPKMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private IDisposable HKCCBIBPFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly APINBDFMKOH GANKHGMDBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly APINBDFMKOH ODINGDCNLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private FPAACNFKCED NBBGMAOMANI;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TaskStatus KDOPLIBHGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9C95F0", Offset = "0x9C85F0", VA = "0x1809C95F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9FD700", Offset = "0x9FC700", VA = "0x1809FD700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private JPJCLLNFHEO EFLFLLHFENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x63BAC30", Offset = "0x63B9C30", VA = "0x1863BAC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x63BB7D0", Offset = "0x63BA7D0", VA = "0x1863BB7D0", Slot = "6")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x63BB650", Offset = "0x63BA650", VA = "0x1863BB650", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x63BC880", Offset = "0x63BB880", VA = "0x1863BC880", Slot = "5")]
	[AsyncStateMachine(typeof(DALOOHILODI))]
	public Task KDNJLHJAELK(LPJIABDOGLI CMDBJODNHGC, NPOHIKBADKF DNKKJBOBOEN, CancellationToken PMLBMCIFPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x63BA640", Offset = "0x63B9640", VA = "0x1863BA640")]
	[AsyncStateMachine(typeof(DNANBIIAHLE))]
	private Task ACOAMDBOEAB(LPJIABDOGLI CMDBJODNHGC, NPOHIKBADKF DNKKJBOBOEN, CancellationToken PMLBMCIFPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x63BAE70", Offset = "0x63B9E70", VA = "0x1863BAE70")]
	private static void DHBPIHLAMAA(PLGCFFBLAPM MAPNJIKJEBN, LPJIABDOGLI CMDBJODNHGC, Exception GDBKEDNPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x63BD2C0", Offset = "0x63BC2C0", VA = "0x1863BD2C0")]
	private static void OPGICHONDLB(GOBGCHCBFKE PKINEHHKMNB, Exception GDBKEDNPKDC, [Optional] List<int> CLGADBNCIBD, int CAKKLJNJJND = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x63BB4F0", Offset = "0x63BA4F0", VA = "0x1863BB4F0")]
	[AsyncStateMachine(typeof(CGEHJNJOMPD))]
	private Task DLDKEICONEB(PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, LPJIABDOGLI CMDBJODNHGC, NPOHIKBADKF DNKKJBOBOEN, DIIGLJEEJID ABADIKDEKDN, CancellationToken PMLBMCIFPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x63BC0A0", Offset = "0x63BB0A0", VA = "0x1863BC0A0")]
	private void HOMJHHCNGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x63BB6A0", Offset = "0x63BA6A0", VA = "0x1863BB6A0")]
	[AsyncStateMachine(typeof(JJLHNOANJBI))]
	private Task EGDBIGLOOJH(PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x63BC1F0", Offset = "0x63BB1F0", VA = "0x1863BC1F0")]
	private void HOPAMADKNHM(LPJIABDOGLI CMDBJODNHGC, CancellationToken PMLBMCIFPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x63BB230", Offset = "0x63BA230", VA = "0x1863BB230")]
	private void DJGFGKNDHAF(LPJIABDOGLI CMDBJODNHGC, DIIGLJEEJID ABADIKDEKDN, OperationCanceledException MNJMDNDCONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x63BDBB0", Offset = "0x63BCBB0", VA = "0x1863BDBB0")]
	private void PDIIKODGPKJ(LPJIABDOGLI CMDBJODNHGC, DIIGLJEEJID ABADIKDEKDN, Exception GDBKEDNPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x63BCD90", Offset = "0x63BBD90", VA = "0x1863BCD90")]
	private void NGHAOFNMCPH(LPJIABDOGLI CMDBJODNHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x63BDE40", Offset = "0x63BCE40", VA = "0x1863BDE40")]
	private static PLIIDCKOCBJ PNJJLLHIBJE(LPJIABDOGLI CMDBJODNHGC)
	{
		return default(PLIIDCKOCBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x63BADA0", Offset = "0x63B9DA0", VA = "0x1863BADA0")]
	[AsyncStateMachine(typeof(CPLIPDBMMKG))]
	private Task DAMEEGNFEJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x63BCFC0", Offset = "0x63BBFC0", VA = "0x1863BCFC0")]
	[AsyncStateMachine(typeof(IIMMBDFOPKF))]
	private Task<Matchmaking.AHKGLMIIALK> NPDBOFIHAOO(LPJIABDOGLI CMDBJODNHGC, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x63BBF90", Offset = "0x63BAF90", VA = "0x1863BBF90")]
	private static HIILJJLBAJM HIEILFPOIGK(Matchmaking.AHKGLMIIALK OKNKHIODHEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x63BC530", Offset = "0x63BB530", VA = "0x1863BC530")]
	[AsyncStateMachine(typeof(LBKBDMOGJAG))]
	private Task IGAJJOIHHOO(Matchmaking.AHKGLMIIALK OKNKHIODHEH, DIIGLJEEJID ABADIKDEKDN, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken PCMKIHEDCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x63BA790", Offset = "0x63B9790", VA = "0x1863BA790")]
	[AsyncStateMachine(typeof(EOCEACJMJGK))]
	private Task BCEFEBMPJCF(LPJIABDOGLI CMDBJODNHGC, CancellationTokenSource PLFJPENFEDD, Task GGFGJFMIKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x63BBD90", Offset = "0x63BAD90", VA = "0x1863BBD90")]
	[AsyncStateMachine(typeof(KFKMBIBIMIN))]
	private Task GJFELGKDHOO(CIFKNLJLNLO MECOHCPKCAH, HKPEMPOGMNP MEFHPJNCLKE, LPJIABDOGLI PHLAPLIDBBA, DIIGLJEEJID FMPEGJBGFPP, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken EGBANGFNFPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x63BC680", Offset = "0x63BB680", VA = "0x1863BC680")]
	private DIIGLJEEJID JJJNOGGDIOE(DIIGLJEEJID FMPEGJBGFPP, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x63BCC60", Offset = "0x63BBC60", VA = "0x1863BCC60")]
	[AsyncStateMachine(typeof(JHEDMDBHHIG))]
	private Task MNCKAMNACBH(PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x63BAC80", Offset = "0x63B9C80", VA = "0x1863BAC80")]
	[AsyncStateMachine(typeof(CGMBMGBINDM))]
	private Task DABLBDOJDBE(LLGCMGAEGBM FCLEEDACIMH, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x63BA8E0", Offset = "0x63B98E0", VA = "0x1863BA8E0")]
	private static void BGKPAPPKEIL(LPJIABDOGLI CMDBJODNHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x63BAA60", Offset = "0x63B9A60", VA = "0x1863BAA60")]
	private void CHFEDMIGNOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x63BD230", Offset = "0x63BC230", VA = "0x1863BD230")]
	private void OKPDMLANGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x63BBF00", Offset = "0x63BAF00", VA = "0x1863BBF00")]
	private void HELBLIFLHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x63BB460", Offset = "0x63BA460", VA = "0x1863BB460")]
	private void DKMPIGHLDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x63BC9C0", Offset = "0x63BB9C0", VA = "0x1863BC9C0")]
	private static void KDNJLNEAHMJ(LPJIABDOGLI CMDBJODNHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x63BD120", Offset = "0x63BC120", VA = "0x1863BD120")]
	private static CancellationTokenRegistration OACAEKIHLDO(LPJIABDOGLI CMDBJODNHGC, CancellationToken PCMKIHEDCIB)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x63BBC90", Offset = "0x63BAC90", VA = "0x1863BBC90")]
	private static void GJBAPIFIPJC(LPJIABDOGLI CMDBJODNHGC, Exception GDBKEDNPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x63BCAB0", Offset = "0x63BBAB0", VA = "0x1863BCAB0")]
	private void LFELMHAELOH(LPJIABDOGLI CMDBJODNHGC, Task GGFGJFMIKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x63BDB50", Offset = "0x63BCB50", VA = "0x1863BDB50")]
	private static void PAOJJBFOCDP(Func<string> IECBPCEAHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x63BE0C0", Offset = "0x63BD0C0", VA = "0x1863BE0C0")]
	public DIGDBAKOPOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x63BDDE0", Offset = "0x63BCDE0", VA = "0x1863BDDE0")]
	[CompilerGenerated]
	internal static (int, int?) PKIGHFKEFGC(DNCIBFDLMHO KKBHHFJDIJK)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[RecRoom.NoEngine.Common.Preserve]
internal class HMPIHACDDMM : EEDEELKDLCP, KCGIJCOKMAL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct ANCFFMPHKGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public HMPIHACDDMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public LLGCMGAEGBM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x63CFFD0", Offset = "0x63CEFD0", VA = "0x1863CFFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x63D0390", Offset = "0x63CF390", VA = "0x1863D0390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class LBOAMBCHHHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public HMPIHACDDMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public LLGCMGAEGBM roomData;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public LBOAMBCHHHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x63E5B40", Offset = "0x63E4B40", VA = "0x1863E5B40")]
		internal List<Task> BOABEJCHKOI(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct LAHKBPEAGNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public DCOPGKCCEFD taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x63E5710", Offset = "0x63E4710", VA = "0x1863E5710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x63E5AE0", Offset = "0x63E4AE0", VA = "0x1863E5AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct FBJCKCCBPNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public HMPIHACDDMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x63D8700", Offset = "0x63D7700", VA = "0x1863D8700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x63D89C0", Offset = "0x63D79C0", VA = "0x1863D89C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly HashSet<DCOPGKCCEFD> FCCOMACICIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private KCHBDCGPPPH KGHINEPPBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MDFHJOFLIGL JABIBPNEEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private DJFOPLMMGLN BCMAHJGOKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private IDisposable HKCCBIBPFLP;

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x63C3F60", Offset = "0x63C2F60", VA = "0x1863C3F60", Slot = "5")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x63C3F00", Offset = "0x63C2F00", VA = "0x1863C3F00", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x63C47C0", Offset = "0x63C37C0", VA = "0x1863C47C0", Slot = "4")]
	public bool KAFCGEEMOMC(DCOPGKCCEFD GIBNKPBAJGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x63C4820", Offset = "0x63C3820", VA = "0x1863C4820")]
	private void KCNFNPKJFJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x63C4960", Offset = "0x63C3960", VA = "0x1863C4960")]
	private void PAAKLFNNFFL(LLGCMGAEGBM EINEAGMJDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x63C41E0", Offset = "0x63C31E0", VA = "0x1863C41E0")]
	[AsyncStateMachine(typeof(ANCFFMPHKGG))]
	private Task HKKILCPMFLL(LLGCMGAEGBM EINEAGMJDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x63C3C40", Offset = "0x63C2C40", VA = "0x1863C3C40")]
	private Func<CancellationToken, List<Task>> BIDJIGPMDKE(LLGCMGAEGBM EINEAGMJDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x63C4350", Offset = "0x63C3350", VA = "0x1863C4350")]
	private List<Task> JMOKJFIEDFO(LLGCMGAEGBM EINEAGMJDPE, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x63C3DE0", Offset = "0x63C2DE0", VA = "0x1863C3DE0")]
	[AsyncStateMachine(typeof(LAHKBPEAGNP))]
	private Task DAODECNMLJD(DCOPGKCCEFD BCFKKGGBHOK, LLGCMGAEGBM FCLEEDACIMH, CancellationToken PDIBILKHEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x63C3D10", Offset = "0x63C2D10", VA = "0x1863C3D10")]
	[AsyncStateMachine(typeof(FBJCKCCBPNI))]
	private Task BIPALPGOOFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x63C42D0", Offset = "0x63C32D0", VA = "0x1863C42D0")]
	private void ICBCAGAGNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x63C4B60", Offset = "0x63C3B60", VA = "0x1863C4B60")]
	public HMPIHACDDMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[UnityEngine.Scripting.Preserve]
internal sealed class OOJONHHCEND : DMFAGANNFEB, KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class MMPFMKDCGFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public MMPFMKDCGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x63EAC90", Offset = "0x63E9C90", VA = "0x1863EAC90")]
		internal object JIGKKNFKCFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class FICEIOFGMJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FICEIOFGMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x63D8CE0", Offset = "0x63D7CE0", VA = "0x1863D8CE0")]
		internal object HOACFDLBAEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class KDGBOJLPHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public KDGBOJLPHJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class BFHDHOHLOOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public BFHDHOHLOOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x63D0C50", Offset = "0x63CFC50", VA = "0x1863D0C50")]
		internal object ONJABHOPIDC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class FCBDPPNLONB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FCBDPPNLONB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x63D8A20", Offset = "0x63D7A20", VA = "0x1863D8A20")]
		internal object LICGADBFKNL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly Dictionary<Guid, HIBBEFOIKHE> MEEGNMOGOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly TimeSpan GOANIMFFMPM;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "9")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x63EC690", Offset = "0x63EB690", VA = "0x1863EC690", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x63EC6A0", Offset = "0x63EB6A0", VA = "0x1863EC6A0", Slot = "4")]
	public MGNBIDPCCPO GPDFOMDKBKK(Guid KBNMFHADFEA)
	{
		return default(MGNBIDPCCPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x63ECAD0", Offset = "0x63EBAD0", VA = "0x1863ECAD0", Slot = "5")]
	public bool MOJJDBCCFOB(Guid KBNMFHADFEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x63ECF40", Offset = "0x63EBF40", VA = "0x1863ECF40", Slot = "6")]
	public bool PHCBENKNOLH(Guid KBNMFHADFEA, Task OJNIMCPHGBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x63EC8D0", Offset = "0x63EB8D0", VA = "0x1863EC8D0", Slot = "7")]
	public bool MOICLCGBLAM(Guid KBNMFHADFEA, GPKOEFJDDBP CKLFFMBDKHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x63EC620", Offset = "0x63EB620", VA = "0x1863EC620", Slot = "8")]
	public Task<(GPKOEFJDDBP, Task)> CNMMPEFPDHA(Guid KBNMFHADFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x63ECD00", Offset = "0x63EBD00", VA = "0x1863ECD00")]
	private void OICNOGHAAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x63ED290", Offset = "0x63EC290", VA = "0x1863ED290")]
	public OOJONHHCEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[RecRoom.NoEngine.Common.Preserve]
internal class HLANHOPKNLG : HIHDCCEBCFI, KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class IJBMMJIIIOC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private readonly LPJIABDOGLI BEKJGEFHGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly CancellationTokenSource OCCBKDMNJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public readonly CancellationToken LEONAHFDKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private bool IHPLECBBILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool EDDFAKMICOP;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x63E0C90", Offset = "0x63DFC90", VA = "0x1863E0C90")]
		public IJBMMJIIIOC(LPJIABDOGLI BEKJGEFHGNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x63E0B40", Offset = "0x63DFB40", VA = "0x1863E0B40")]
		public void ICBCAGAGNJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x63E0B10", Offset = "0x63DFB10", VA = "0x1863E0B10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class BFLCBHLNPHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public LCMKDIGGNML disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public BFLCBHLNPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x63D0CB0", Offset = "0x63CFCB0", VA = "0x1863D0CB0")]
		internal object FDNIEINIJII()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct PDPDNBPEEMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public LCMKDIGGNML disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public HLANHOPKNLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x63EE270", Offset = "0x63ED270", VA = "0x1863EE270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x63EE6A0", Offset = "0x63ED6A0", VA = "0x1863EE6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class PEIBNPADGPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public PEIBNPADGPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x63EE700", Offset = "0x63ED700", VA = "0x1863EE700")]
		internal object DIEGNMNKCLE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct EDPPCJIMHAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public HLANHOPKNLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x63D6A60", Offset = "0x63D5A60", VA = "0x1863D6A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8C2E60", Offset = "0x8C1E60", VA = "0x1808C2E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class FFBPPBHHPBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public LPJIABDOGLI newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FFBPPBHHPBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x63D8BC0", Offset = "0x63D7BC0", VA = "0x1863D8BC0")]
		internal object INMPENCNCDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x63D8CA0", Offset = "0x63D7CA0", VA = "0x1863D8CA0")]
		internal object OAOOEDOPFPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x63D8C60", Offset = "0x63D7C60", VA = "0x1863D8C60")]
		internal object MLBMJEOEOBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class GCBMNKNMNKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public GCBMNKNMNKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x63DA280", Offset = "0x63D9280", VA = "0x1863DA280")]
		internal void MLOLGLHCGCC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct HAFNBOLDFBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public LPJIABDOGLI newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public HLANHOPKNLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public NPOHIKBADKF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private FFBPPBHHPBI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x63DB7B0", Offset = "0x63DA7B0", VA = "0x1863DB7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x63DC7B0", Offset = "0x63DB7B0", VA = "0x1863DC7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly IMFBLHALHMN DJHKLFMABMI;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly JLHDNJPOBNI.EIABAEEBJGH MPABFLKKEIH;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly CMIINAELBNH FMMMGHAIEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private KCHBDCGPPPH KGHINEPPBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private DCCFFLDKHDH KMDEMPIBNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private AJNHNKMBAPI ICCKKADELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private EMLICJCHFPN IBEAHHFJKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private LKKGAOCNCAA GCDBDOMPCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private long CHFEKHBOGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private IJBMMJIIIOC AIFOCNFPCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private bool MGCHECMKKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private Task EPKBCOCAIMM;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private JPJCLLNFHEO EFLFLLHFENI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x63DE1C0", Offset = "0x63DD1C0", VA = "0x1863DE1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool MFFHGBKNAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xABB420", Offset = "0xABA420", VA = "0x180ABB420")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x63DE690", Offset = "0x63DD690", VA = "0x1863DE690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x63DE380", Offset = "0x63DD380", VA = "0x1863DE380", Slot = "4")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x63DE210", Offset = "0x63DD210", VA = "0x1863DE210", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x63DEBD0", Offset = "0x63DDBD0", VA = "0x1863DEBD0")]
	[AsyncStateMachine(typeof(PDPDNBPEEMB))]
	private Task PCGKAEOFKNN(LCMKDIGGNML HHCPLMJKCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x63DE940", Offset = "0x63DD940", VA = "0x1863DE940")]
	private void OBNLLHKBMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x63DDC60", Offset = "0x63DCC60", VA = "0x1863DDC60")]
	private void ABPNAJOHDBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x63DE6A0", Offset = "0x63DD6A0", VA = "0x1863DE6A0")]
	private void KLNMHKHNDFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x63DE620", Offset = "0x63DD620", VA = "0x1863DE620")]
	private bool IOEOCKHKNHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x63DEB00", Offset = "0x63DDB00", VA = "0x1863DEB00")]
	[AsyncStateMachine(typeof(EDPPCJIMHAH))]
	private void OEAPINPFMEA(int LECICHFMCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x63DDF30", Offset = "0x63DCF30", VA = "0x1863DDF30")]
	private void ANBFMGFDIEN([Out] IDisposable JLMGFPBEAMN, [Out] IDisposable IICAEABCKMP, [Out] IDisposable IMCKMFHGMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x63DE830", Offset = "0x63DD830", VA = "0x1863DE830")]
	private bool NLBILHJIPJC(LPJIABDOGLI BEKJGEFHGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x63DECC0", Offset = "0x63DDCC0", VA = "0x1863DECC0")]
	private void PPAMFPNOEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x63DDE00", Offset = "0x63DCE00", VA = "0x1863DDE00")]
	[AsyncStateMachine(typeof(HAFNBOLDFBB))]
	private Task ACOAMDBOEAB(LPJIABDOGLI BEKJGEFHGNF, NPOHIKBADKF DNKKJBOBOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x63DF0E0", Offset = "0x63DE0E0", VA = "0x1863DF0E0")]
	public HLANHOPKNLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[UnityEngine.Scripting.Preserve]
internal sealed class MMPAGPPHOMB : GEOABLCBIOL, KCGIJCOKMAL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct DEPALPBCOGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder<LLJKCEKOIII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public MMPAGPPHOMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter<LLJKCEKOIII> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x63D4AA0", Offset = "0x63D3AA0", VA = "0x1863D4AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x63D4D30", Offset = "0x63D3D30", VA = "0x1863D4D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class FJCGNBJLBHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public OCGKKEPIGGA message;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FJCGNBJLBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x63D8F60", Offset = "0x63D7F60", VA = "0x1863D8F60")]
		internal object JHFCBNJOFCD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class MAICCLIKPGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public OCGKKEPIGGA messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public MAICCLIKPGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x63E90F0", Offset = "0x63E80F0", VA = "0x1863E90F0")]
		internal object PCCFAJLLOAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class DIJJOMHKPNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public OCGKKEPIGGA request;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public DIJJOMHKPNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x63D5D40", Offset = "0x63D4D40", VA = "0x1863D5D40")]
		internal object PCDJACEICDI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct KMENJDJNKDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public OCGKKEPIGGA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public MMPAGPPHOMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<KNNODDOINJP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x63E39A0", Offset = "0x63E29A0", VA = "0x1863E39A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x63E42B0", Offset = "0x63E32B0", VA = "0x1863E42B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class BPMGPACPAFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public OCGKKEPIGGA operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public BPMGPACPAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x63D1510", Offset = "0x63D0510", VA = "0x1863D1510")]
		internal object CKNOEHFIEKO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct JDOBCPDLDIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public OCGKKEPIGGA operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public MMPAGPPHOMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private DIIGLJEEJID <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<OCGKKEPIGGA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x63E1A20", Offset = "0x63E0A20", VA = "0x1863E1A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x63E25D0", Offset = "0x63E15D0", VA = "0x1863E25D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct NONKHPHONDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<KNNODDOINJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public MMPAGPPHOMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public OCGKKEPIGGA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private JKLLALFHMJH.KAICNKJCJNP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private DIIGLJEEJID <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter<OCGKKEPIGGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x63EB330", Offset = "0x63EA330", VA = "0x1863EB330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x63EB850", Offset = "0x63EA850", VA = "0x1863EB850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class EOHFJHIEJIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public KNNODDOINJP operation;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public EOHFJHIEJIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x63D8420", Offset = "0x63D7420", VA = "0x1863D8420")]
		internal object OLLGLMLIILK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct COJJGNPDAAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public KNNODDOINJP operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public MMPAGPPHOMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private PFLLCKOMFGL<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x63D43C0", Offset = "0x63D33C0", VA = "0x1863D43C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x63D4A40", Offset = "0x63D3A40", VA = "0x1863D4A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class DLBAPHBDDHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public OCGKKEPIGGA request;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public DLBAPHBDDHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x63D6060", Offset = "0x63D5060", VA = "0x1863D6060")]
		internal object OBEIOJMFOBM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class KCJHCCBPJBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public OCGKKEPIGGA request;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public KCJHCCBPJBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x63E2DD0", Offset = "0x63E1DD0", VA = "0x1863E2DD0")]
		internal object HNGHGAICIPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private MLGFINJLBLF HLLADAHJIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private BBEIGKCDDOC GMANHAHEDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private OJIPPNEEKKD MBJJPJOGOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private HDJBGMMJLFC GDOLGBNNMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private TaskCompletionSource<LLJKCEKOIII> LJBDMAJNFLA;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x63EA6C0", Offset = "0x63E96C0", VA = "0x1863EA6C0", Slot = "7")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x63EA5B0", Offset = "0x63E95B0", VA = "0x1863EA5B0", Slot = "6")]
	[AsyncStateMachine(typeof(DEPALPBCOGF))]
	public Task<LLJKCEKOIII> ELPCHKMBHPM(CancellationToken MIGJLIAPEPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x63EA100", Offset = "0x63E9100", VA = "0x1863EA100", Slot = "4")]
	public void EDJHLLBGPJC(OCGKKEPIGGA NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x63E9D90", Offset = "0x63E8D90", VA = "0x1863E9D90", Slot = "5")]
	public void ECNJIAFCNPM(OCGKKEPIGGA PFPMJMDBACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x63EA8D0", Offset = "0x63E98D0", VA = "0x1863EA8D0")]
	[AsyncStateMachine(typeof(KMENJDJNKDM))]
	private Task IEFADEBCAFJ(OCGKKEPIGGA ICLPGCHCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x63EA4A0", Offset = "0x63E94A0", VA = "0x1863EA4A0")]
	[AsyncStateMachine(typeof(JDOBCPDLDIL))]
	private Task EEONCDEGEPD(OCGKKEPIGGA NJMFNMBEEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x63E98A0", Offset = "0x63E88A0", VA = "0x1863E98A0")]
	[AsyncStateMachine(typeof(NONKHPHONDB))]
	private Task<KNNODDOINJP> BNMOABCMFAN(OCGKKEPIGGA ICLPGCHCHFB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x63EA9D0", Offset = "0x63E99D0", VA = "0x1863EA9D0")]
	private DIIGLJEEJID MHIIECJGJGF(OCGKKEPIGGA AFHEHHPFPLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x63EA7B0", Offset = "0x63E97B0", VA = "0x1863EA7B0")]
	[AsyncStateMachine(typeof(COJJGNPDAAB))]
	private Task ENCJCINJCML(KNNODDOINJP ILJNJNIMKOM, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x63EAA60", Offset = "0x63E9A60", VA = "0x1863EAA60")]
	private KNNODDOINJP PFEDLFJFDGB(OCGKKEPIGGA ICLPGCHCHFB, DIIGLJEEJID GIOADJKMGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2587500", Offset = "0x2586500", VA = "0x182587500")]
	private T AEEGBGAAMCJ<T>(T APPJEOKOGAK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x63E99F0", Offset = "0x63E89F0", VA = "0x1863E99F0")]
	private KNNODDOINJP CHFNKDKDGCA(OCGKKEPIGGA ICLPGCHCHFB, DIIGLJEEJID GIOADJKMGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public MMPAGPPHOMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[UnityEngine.Scripting.Preserve]
internal sealed class CKNCJIKBBFK : BBEIGKCDDOC, KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class BIEICKEGIPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public BIEICKEGIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x63D0D40", Offset = "0x63CFD40", VA = "0x1863D0D40")]
		internal object EMFMJFGFJMA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class MLPFNJPEKOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public MLPFNJPEKOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x63E9830", Offset = "0x63E8830", VA = "0x1863E9830")]
		internal object AJMCAKABIED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private HDJBGMMJLFC GDOLGBNNMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private NIIEPMNFECO FINBHBAEEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private GEOABLCBIOL ELKPIPANCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private DMFAGANNFEB MEEGNMOGOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private MAABAJGEJOG DEMCBPBAOIJ;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x63D2CD0", Offset = "0x63D1CD0", VA = "0x1863D2CD0", Slot = "6")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x63D2B50", Offset = "0x63D1B50", VA = "0x1863D2B50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x63D35A0", Offset = "0x63D25A0", VA = "0x1863D35A0", Slot = "4")]
	public MGNBIDPCCPO NKNJHJGCCPL(OCGKKEPIGGA GEPEPGIEIKL)
	{
		return default(MGNBIDPCCPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x63D2E40", Offset = "0x63D1E40", VA = "0x1863D2E40", Slot = "5")]
	public void GMINPDHEMDL(Guid KBNMFHADFEA, Task OJNIMCPHGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x63D2C00", Offset = "0x63D1C00", VA = "0x1863D2C00")]
	private void EGGIKKHPHHH(byte JIPPKPFPDIK, int LCFOPBENPPI, object CNMIBHMILIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x63D2080", Offset = "0x63D1080", VA = "0x1863D2080")]
	private void CAGLPPFCLPA(KONDJEEKEOA MFCMLHEKFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x63D1B10", Offset = "0x63D0B10", VA = "0x1863D1B10")]
	private void AKEGHAKBMCL(KONDJEEKEOA MFCMLHEKFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x63D1E30", Offset = "0x63D0E30", VA = "0x1863D1E30")]
	private void BKMGMDNLEML(KONDJEEKEOA MFCMLHEKFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x63D2650", Offset = "0x63D1650", VA = "0x1863D2650")]
	private GPKOEFJDDBP CNFCLMDBGBD(OCGKKEPIGGA AFHEHHPFPLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x63D39F0", Offset = "0x63D29F0", VA = "0x1863D39F0")]
	private void OGOFFIHOJGB(OCGKKEPIGGA NJMFNMBEEAD, GPKOEFJDDBP CKLFFMBDKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x63D3060", Offset = "0x63D2060", VA = "0x1863D3060")]
	private bool HPLECAOGFDH(OCGKKEPIGGA NJMFNMBEEAD, GPKOEFJDDBP CKLFFMBDKHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x63D3320", Offset = "0x63D2320", VA = "0x1863D3320")]
	private bool KDLOIPMBKFL(OCGKKEPIGGA DDKNDEDCGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x63D28B0", Offset = "0x63D18B0", VA = "0x1863D28B0")]
	private bool DEKEJMOINKK(byte JIPPKPFPDIK, ExitGames.Client.Photon.Hashtable MFCMLHEKFHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public CKNCJIKBBFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[UnityEngine.Scripting.Preserve]
internal sealed class IFBHGAECJHI : APHHJNEFHCN, KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class IHCMCMCOCJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public LLJKCEKOIII operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public IFBHGAECJHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public OCGKKEPIGGA roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public IHCMCMCOCJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x63E0AA0", Offset = "0x63DFAA0", VA = "0x1863E0AA0")]
		internal object ODFKJGOFBFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x63E0970", Offset = "0x63DF970", VA = "0x1863E0970")]
		internal object LFFAMAPCCEB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct EEFBGDBENED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<GPKOEFJDDBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public IFBHGAECJHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public OCGKKEPIGGA roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private TaskAwaiter<GPKOEFJDDBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x63D7C50", Offset = "0x63D6C50", VA = "0x1863D7C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x63D8330", Offset = "0x63D7330", VA = "0x1863D8330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class JNCBHIKBPIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public LLJKCEKOIII operationType;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public JNCBHIKBPIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x63E2690", Offset = "0x63E1690", VA = "0x1863E2690")]
		internal object KBLOMIOJIBO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class KCCBMOONBFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public OCGKKEPIGGA request;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public KCCBMOONBFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x63E2C80", Offset = "0x63E1C80", VA = "0x1863E2C80")]
		internal object BPIIMALKBGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x63E2CF0", Offset = "0x63E1CF0", VA = "0x1863E2CF0")]
		internal object FNKEGKMKCDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x63E2D60", Offset = "0x63E1D60", VA = "0x1863E2D60")]
		internal object IDENLPLFMFE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct KKMCOGLGPEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<GPKOEFJDDBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public OCGKKEPIGGA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public IFBHGAECJHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private KCCBMOONBFB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private MGNBIDPCCPO <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private GPKOEFJDDBP <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter<(GPKOEFJDDBP validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x63E3030", Offset = "0x63E2030", VA = "0x1863E3030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x63E3930", Offset = "0x63E2930", VA = "0x1863E3930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private HDJBGMMJLFC GDOLGBNNMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private NIIEPMNFECO FINBHBAEEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private BBEIGKCDDOC GMANHAHEDIM;

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x63DF150", Offset = "0x63DE150", VA = "0x1863DF150", Slot = "5")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x63DF200", Offset = "0x63DE200", VA = "0x1863DF200", Slot = "4")]
	[AsyncStateMachine(typeof(EEFBGDBENED))]
	private Task<GPKOEFJDDBP> HIEPBKKGNIN(OCGKKEPIGGA AFHEHHPFPLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x63DF460", Offset = "0x63DE460", VA = "0x1863DF460")]
	private bool LHNIOLMLBBN(LLJKCEKOIII FDIEGFHJBPI, [Out] GPKOEFJDDBP BBMBCGDLBEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x63DF320", Offset = "0x63DE320", VA = "0x1863DF320")]
	[AsyncStateMachine(typeof(KKMCOGLGPEA))]
	private Task<GPKOEFJDDBP> JIPGEMFLNBD(OCGKKEPIGGA ICLPGCHCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public IFBHGAECJHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class HEFIGDEBJAM : MCLEIFFAJFC, KCGIJCOKMAL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct NMCMNJMGNFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AsyncTaskMethodBuilder<CIFKNLJLNLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public LPJIABDOGLI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public HEFIGDEBJAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<MCEIHIBECAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x63EACF0", Offset = "0x63E9CF0", VA = "0x1863EACF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x63EB1A0", Offset = "0x63EA1A0", VA = "0x1863EB1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class AKJNCHCNFEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public AKJNCHCNFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x63CFF20", Offset = "0x63CEF20", VA = "0x1863CFF20")]
		internal object INPGMFAJAPO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct HFJAEJAPACI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<MCEIHIBECAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public HEFIGDEBJAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public LPJIABDOGLI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private AKJNCHCNFEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<MCEIHIBECAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x63DD600", Offset = "0x63DC600", VA = "0x1863DD600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x63DDBF0", Offset = "0x63DCBF0", VA = "0x1863DDBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class AJOELDIPFKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public AJOELDIPFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x1394FF0", Offset = "0x1393FF0", VA = "0x181394FF0")]
		internal bool GOPLAMFJFLD(PNEBNDCHIFA sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private AJNHNKMBAPI ICCKKADELMP;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static readonly (AEBNJGMIDFC superRoomData, long subRoomDataSaveId) ALGNFPEKJIH;

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x63DCEE0", Offset = "0x63DBEE0", VA = "0x1863DCEE0", Slot = "5")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x63DCD80", Offset = "0x63DBD80", VA = "0x1863DCD80", Slot = "4")]
	[AsyncStateMachine(typeof(NMCMNJMGNFH))]
	public Task<CIFKNLJLNLO> DHKGJNCJJEN(PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, LPJIABDOGLI CMDBJODNHGC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x63DD090", Offset = "0x63DC090", VA = "0x1863DD090")]
	[AsyncStateMachine(typeof(HFJAEJAPACI))]
	private Task<MCEIHIBECAG> LLMEONFGNBK(LPJIABDOGLI CMDBJODNHGC, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x63DCF50", Offset = "0x63DBF50", VA = "0x1863DCF50")]
	private CIFKNLJLNLO KLMBOKDENGB(LPJIABDOGLI CMDBJODNHGC, MCEIHIBECAG HJBIKPLBJHF, long HIFDDDODBFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x63DD1F0", Offset = "0x63DC1F0", VA = "0x1863DD1F0")]
	private (AEBNJGMIDFC, long) OEMNBOMAAHF(LPJIABDOGLI CMDBJODNHGC, MCEIHIBECAG HJBIKPLBJHF, long HIFDDDODBFK)
	{
		return default((AEBNJGMIDFC, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public HEFIGDEBJAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal sealed class FOCFCNKBHHH : OJIPPNEEKKD, KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class IKLBLGADNDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public OCGKKEPIGGA request;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public IKLBLGADNDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x63E0D40", Offset = "0x63DFD40", VA = "0x1863E0D40")]
		internal object HKGADOLODHO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct LFOGPIHNPEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<OCGKKEPIGGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public OCGKKEPIGGA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public FOCFCNKBHHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public DIIGLJEEJID pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<OCGKKEPIGGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x63E6800", Offset = "0x63E5800", VA = "0x1863E6800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x63E6E40", Offset = "0x63E5E40", VA = "0x1863E6E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct OONNPOHOLLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<OCGKKEPIGGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public FOCFCNKBHHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public DIIGLJEEJID pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<JPFNKOJPGOE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x63ED350", Offset = "0x63EC350", VA = "0x1863ED350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x63ED980", Offset = "0x63EC980", VA = "0x1863ED980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class JGNMKBLNLKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public OCGKKEPIGGA request;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public JGNMKBLNLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x63E2630", Offset = "0x63E1630", VA = "0x1863E2630")]
		internal object JBNFDCJDFEE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct LDDAPOLEKKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<OCGKKEPIGGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public OCGKKEPIGGA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public FOCFCNKBHHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public DIIGLJEEJID pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private LLAHLAEGPAB <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private HLJKDKDEKJF <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<JPFNKOJPGOE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x63E5B70", Offset = "0x63E4B70", VA = "0x1863E5B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x63E6790", Offset = "0x63E5790", VA = "0x1863E6790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private HDJBGMMJLFC GDOLGBNNMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private NMLOCBJIIPG IKCMGDNCDOL;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private CPHKDNMEPBN EFPHAALECDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x63D9640", Offset = "0x63D8640", VA = "0x1863D9640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x63D9700", Offset = "0x63D8700", VA = "0x1863D9700", Slot = "8")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x63D9790", Offset = "0x63D8790", VA = "0x1863D9790", Slot = "4")]
	[AsyncStateMachine(typeof(LFOGPIHNPEB))]
	public Task<OCGKKEPIGGA> GLCELHFFPBD(OCGKKEPIGGA ICLPGCHCHFB, DIIGLJEEJID GIOADJKMGIC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x63D98F0", Offset = "0x63D88F0", VA = "0x1863D98F0", Slot = "5")]
	[AsyncStateMachine(typeof(OONNPOHOLLC))]
	public Task<OCGKKEPIGGA> JLJGDPFLDEA(CancellationToken JEBPNJAPHEL, DIIGLJEEJID GIOADJKMGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x63D9430", Offset = "0x63D8430", VA = "0x1863D9430", Slot = "6")]
	public IGDBPFKILJO BPGNHPKINCP(KNNODDOINJP CEPDGNPODKA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x63D9200", Offset = "0x63D8200", VA = "0x1863D9200", Slot = "7")]
	public IGDBPFKILJO AOGGOBFNMPG(KNNODDOINJP CEPDGNPODKA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x63D9A30", Offset = "0x63D8A30", VA = "0x1863D9A30")]
	[AsyncStateMachine(typeof(LDDAPOLEKKM))]
	private Task<OCGKKEPIGGA> NHLJPJGEKLL(OCGKKEPIGGA ICLPGCHCHFB, DIIGLJEEJID GIOADJKMGIC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x250C2E0", Offset = "0x250B2E0", VA = "0x18250C2E0")]
	private static byte[] AHNLDNPGKNJ(OCGKKEPIGGA NCBOINMNCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public FOCFCNKBHHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[UnityEngine.Scripting.Preserve]
internal sealed class GAPJGAGPOPE : NIIEPMNFECO, KCGIJCOKMAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private HKNBGEDIAMP FHPMIMGAPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private HDJBGMMJLFC GDOLGBNNMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private MLGFINJLBLF HLLADAHJIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private BOPJHPFOIKJ OMBPNHFAEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private AJNHNKMBAPI ICCKKADELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private LKKGAOCNCAA GCDBDOMPCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private EEDEELKDLCP CHLKAJKGCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private EMLICJCHFPN IBEAHHFJKHM;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private JPJCLLNFHEO EFLFLLHFENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x63D9B90", Offset = "0x63D8B90", VA = "0x1863D9B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private static GPKOEFJDDBP DPJJHGFECKG
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x63D9BE0", Offset = "0x63D8BE0", VA = "0x1863D9BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x63D9DB0", Offset = "0x63D8DB0", VA = "0x1863D9DB0", Slot = "6")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x63D9C40", Offset = "0x63D8C40", VA = "0x1863D9C40", Slot = "4")]
	public GPKOEFJDDBP EHHIGILIHLG(HANCNHADEOE MEOGCOCOCGG, LLJKCEKOIII MGNBHKMDAHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x63D9F20", Offset = "0x63D8F20", VA = "0x1863D9F20", Slot = "5")]
	public GPKOEFJDDBP HPPGPJEGDEI(HANCNHADEOE HFOEIHALCPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x63DA220", Offset = "0x63D9220", VA = "0x1863DA220")]
	private static GPKOEFJDDBP MIFDGDLOFGL(FBGPILHJKBA GEIKHBJFIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public GAPJGAGPOPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class OAHNFGADLHH : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x63EB8C0", Offset = "0x63EA8C0", VA = "0x1863EB8C0")]
	public OAHNFGADLHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x59EE750", Offset = "0x59ED750", VA = "0x1859EE750")]
	public OAHNFGADLHH(string NCBOINMNCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class DFFKFIOMCDO : JCIOFJMFHOM, KCGIJCOKMAL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct JBNJNGGLKGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AsyncTaskMethodBuilder<GPKOEFJDDBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public DFFKFIOMCDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public ALFEBNEDACP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private PFLLCKOMFGL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private JOFKNAJALKD <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<GPKOEFJDDBP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x63E0E20", Offset = "0x63DFE20", VA = "0x1863E0E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x63E19B0", Offset = "0x63E09B0", VA = "0x1863E19B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct KNGCEOMHHCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public DFFKFIOMCDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x63E4790", Offset = "0x63E3790", VA = "0x1863E4790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x63E4EE0", Offset = "0x63E3EE0", VA = "0x1863E4EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct HBNFLPODOCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public DFFKFIOMCDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x63DC810", Offset = "0x63DB810", VA = "0x1863DC810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x63DCD20", Offset = "0x63DBD20", VA = "0x1863DCD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct LJDOPFMMDOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public DFFKFIOMCDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x63E6EB0", Offset = "0x63E5EB0", VA = "0x1863E6EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x63E7600", Offset = "0x63E6600", VA = "0x1863E7600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct KEBLDNPMCND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public DFFKFIOMCDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x63E2E30", Offset = "0x63E1E30", VA = "0x1863E2E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x63E2FD0", Offset = "0x63E1FD0", VA = "0x1863E2FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct OGJPICHACBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public DFFKFIOMCDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x63EB900", Offset = "0x63EA900", VA = "0x1863EB900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x63EC020", Offset = "0x63EB020", VA = "0x1863EC020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct GKKGPJNOPME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public DFFKFIOMCDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x63DB2E0", Offset = "0x63DA2E0", VA = "0x1863DB2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x63DB750", Offset = "0x63DA750", VA = "0x1863DB750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct OMNKBCJPFIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public DFFKFIOMCDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public BFJJLHPIHPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private PFLLCKOMFGL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x63EC080", Offset = "0x63EB080", VA = "0x1863EC080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x63EC5C0", Offset = "0x63EB5C0", VA = "0x1863EC5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private HDJBGMMJLFC GDOLGBNNMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private AJNHNKMBAPI ICCKKADELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private OJIPPNEEKKD MBJJPJOGOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private MLGFINJLBLF HLLADAHJIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private EEDEELKDLCP CHLKAJKGCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private CancellationTokenSource JKEIKCKLBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private Task JKLJDEGGEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private TaskCompletionSource<int> BACBADJHDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private int PBJKBECBFAL;

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x63D53C0", Offset = "0x63D43C0", VA = "0x1863D53C0", Slot = "6")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x81FB50", Offset = "0x81EB50", VA = "0x18081FB50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x63D5770", Offset = "0x63D4770", VA = "0x1863D5770")]
	private void IMLELOOKOEE(float FJHIHMAIKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x63D51A0", Offset = "0x63D41A0", VA = "0x1863D51A0", Slot = "4")]
	[AsyncStateMachine(typeof(JBNJNGGLKGL))]
	public Task<GPKOEFJDDBP> CMHBJGKIJKP(ALFEBNEDACP AAKFCMHHOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x63D5570", Offset = "0x63D4570", VA = "0x1863D5570", Slot = "5")]
	[AsyncStateMachine(typeof(KNGCEOMHHCB))]
	public Task FNFLKCCOEGD([Optional] CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x81FB50", Offset = "0x81EB50", VA = "0x18081FB50")]
	public void FPMPCLLJLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x63D5030", Offset = "0x63D4030", VA = "0x1863D5030")]
	private JOFKNAJALKD CDKAFBINKKM(ALFEBNEDACP AAKFCMHHOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x63D52D0", Offset = "0x63D42D0", VA = "0x1863D52D0")]
	[AsyncStateMachine(typeof(HBNFLPODOCM))]
	private Task DBHGNKPHDOI(LLGCMGAEGBM GDKIMOIKOFD, CancellationToken PMLBMCIFPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x63D5B50", Offset = "0x63D4B50", VA = "0x1863D5B50")]
	[AsyncStateMachine(typeof(LJDOPFMMDOB))]
	private Task MMEDNKIOEAG(CancellationToken PMLBMCIFPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x63D5A60", Offset = "0x63D4A60", VA = "0x1863D5A60")]
	[AsyncStateMachine(typeof(KEBLDNPMCND))]
	private Task MHNEIGGCNHE([Optional] CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x63D5C50", Offset = "0x63D4C50", VA = "0x1863D5C50")]
	[AsyncStateMachine(typeof(OGJPICHACBL))]
	private Task NJBBFFDHBDK(CancellationToken PMLBMCIFPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x63D5960", Offset = "0x63D4960", VA = "0x1863D5960")]
	[AsyncStateMachine(typeof(GKKGPJNOPME))]
	private Task KDKKNHPAMOD(CancellationToken DCLDLECGHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x63D4DA0", Offset = "0x63D3DA0", VA = "0x1863D4DA0")]
	private Task AJMOCKECCNJ(BFJJLHPIHPM GJGEIEHPEOB, CancellationToken PMLBMCIFPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x63D5660", Offset = "0x63D4660", VA = "0x1863D5660")]
	[AsyncStateMachine(typeof(OMNKBCJPFIM))]
	private Task GLADAMKCFLP(BFJJLHPIHPM GJGEIEHPEOB, CancellationToken PMLBMCIFPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x63D5850", Offset = "0x63D4850", VA = "0x1863D5850")]
	private bool JMJDNJHKBGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public DFFKFIOMCDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[UnityEngine.Scripting.Preserve]
internal class JPBOJKPMPNK : BOPJHPFOIKJ, KCGIJCOKMAL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct MHJCCBLJKJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public JPBOJKPMPNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private PFLLCKOMFGL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x63E9150", Offset = "0x63E8150", VA = "0x1863E9150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x63E96B0", Offset = "0x63E86B0", VA = "0x1863E96B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private GBLGBHJLJDM BBPCJKAMNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private NIIEPMNFECO FINBHBAEEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private OJIPPNEEKKD MBJJPJOGOMB;

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x63E2840", Offset = "0x63E1840", VA = "0x1863E2840", Slot = "6")]
	public void EMCBFDNIFOC(LDIAGFCFIDA MFKBBJFDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x63E27F0", Offset = "0x63E17F0", VA = "0x1863E27F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x63E2B80", Offset = "0x63E1B80", VA = "0x1863E2B80", Slot = "5")]
	[AsyncStateMachine(typeof(MHJCCBLJKJH))]
	public Task PFLCNGCCJDN(string JDDFHOGGEKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x63E2B20", Offset = "0x63E1B20", VA = "0x1863E2B20", Slot = "4")]
	public GPKOEFJDDBP JMJDNJHKBGL(HANCNHADEOE MEOGCOCOCGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x63E2700", Offset = "0x63E1700", VA = "0x1863E2700")]
	private MKLAIGMBEFE AOMPJKIAADK(string JDDFHOGGEKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public JPBOJKPMPNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class PIKJPMEBDAI
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x63EEA80", Offset = "0x63EDA80", VA = "0x1863EEA80")]
	public static void NNFINKNNPPP(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x63EE960", Offset = "0x63ED960", VA = "0x1863EE960")]
	internal static void EDFKLILCOLI(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x63EE880", Offset = "0x63ED880", VA = "0x1863EE880")]
	internal static void ADGENOGLFKM(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x63EEC80", Offset = "0x63EDC80", VA = "0x1863EEC80")]
	internal static void NPGLDJNBLPI(EIABFOFJCDK KMOLABGHAKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal class PBOIGNNAKPH : PCALLOKGNLJ<OCGKKEPIGGA>
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class LLHPPEICEKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public OCGKKEPIGGA message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public LLHPPEICEKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x63E7660", Offset = "0x63E6660", VA = "0x1863E7660")]
		internal object EKNFBEJEECA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly PBOIGNNAKPH NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x63EDEC0", Offset = "0x63ECEC0", VA = "0x1863EDEC0")]
	public ExitGames.Client.Photon.Hashtable KJONJHMMAMK(OCGKKEPIGGA NCBOINMNCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x63EDF50", Offset = "0x63ECF50", VA = "0x1863EDF50", Slot = "5")]
	protected override void MDLNCLJGANP(OCGKKEPIGGA NCBOINMNCHO, IDictionary<object, object> FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x63ED9F0", Offset = "0x63EC9F0", VA = "0x1863ED9F0", Slot = "6")]
	public override OCGKKEPIGGA AJBPOCIDFHA(IDictionary<object, object> FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x63EE080", Offset = "0x63ED080", VA = "0x1863EE080")]
	private static void PAOJJBFOCDP(string ADDHHFBOABG, OCGKKEPIGGA NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x63EE230", Offset = "0x63ED230", VA = "0x1863EE230")]
	public PBOIGNNAKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x63EDC20", Offset = "0x63ECC20", VA = "0x1863EDC20")]
	[CompilerGenerated]
	internal static string FGPAHKIOIJB(CIFKNLJLNLO HPEDGLBMGED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class KNAIIFGPDDB
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public static GPKOEFJDDBP DPJJHGFECKG
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x63D9BE0", Offset = "0x63D8BE0", VA = "0x1863D9BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x63E4570", Offset = "0x63E3570", VA = "0x1863E4570")]
	public static bool DCHGGEKFBEH(this GPKOEFJDDBP CKLFFMBDKHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x63DA220", Offset = "0x63D9220", VA = "0x1863DA220")]
	public static GPKOEFJDDBP MIFDGDLOFGL(FBGPILHJKBA PGOCKLBICBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x63E4590", Offset = "0x63E3590", VA = "0x1863E4590")]
	public static GPKOEFJDDBP HOMNCNJDBEA(IEnumerable<GPKOEFJDDBP> DGPLJOHGIBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x63E4310", Offset = "0x63E3310", VA = "0x1863E4310")]
	public static string BJMAGHPAJIO(this GPKOEFJDDBP BBMBCGDLBEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class KOPLIOIDIOP : JOCMCIIGJPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public delegate GPKOEFJDDBP NEKGEKFGLBG([NotNull] HANCNHADEOE AKOPGAJONMI);

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class PDBMOINGEFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public HANCNHADEOE photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public PDBMOINGEFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5BD9B60", Offset = "0x5BD8B60", VA = "0x185BD9B60")]
		internal GPKOEFJDDBP MPGADHGFJBP(NEKGEKFGLBG v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private bool BKIGCJKEOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	protected readonly HashSet<NEKGEKFGLBG> KFLNMCDJENO;

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x63E5620", Offset = "0x63E4620", VA = "0x1863E5620", Slot = "4")]
	public void HBCABGBGKLA(NEKGEKFGLBG JAOLAKGBDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x63E52D0", Offset = "0x63E42D0", VA = "0x1863E52D0", Slot = "5")]
	public void DEECNKJMPEH(NEKGEKFGLBG JAOLAKGBDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x63E5330", Offset = "0x63E4330", VA = "0x1863E5330", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x63E5380", Offset = "0x63E4380", VA = "0x1863E5380")]
	protected GPKOEFJDDBP GLIMDBBIDDO(HANCNHADEOE HFOEIHALCPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x63E5680", Offset = "0x63E4680", VA = "0x1863E5680")]
	protected KOPLIOIDIOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class BNBAAACCIMM : KOPLIOIDIOP, HKNBGEDIAMP, JOCMCIIGJPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class BKIMKFNGEPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public GPKOEFJDDBP result;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public BKIMKFNGEPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x63D0DB0", Offset = "0x63CFDB0", VA = "0x1863D0DB0")]
		internal object ELOJEEFJJBH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x63D0F90", Offset = "0x63CFF90", VA = "0x1863D0F90")]
	[UnityEngine.Scripting.Preserve]
	public BNBAAACCIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x63D0E80", Offset = "0x63CFE80", VA = "0x1863D0E80", Slot = "8")]
	public GPKOEFJDDBP PALHKNHHCAA(HANCNHADEOE HFOEIHALCPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class PGLENDBLFAG : KOPLIOIDIOP, GBLGBHJLJDM, JOCMCIIGJPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class NMLHLAGJONJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public GPKOEFJDDBP result;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public NMLHLAGJONJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x63EB2D0", Offset = "0x63EA2D0", VA = "0x1863EB2D0")]
		internal object PLIHKEHKOID()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x63D0F90", Offset = "0x63CFF90", VA = "0x1863D0F90")]
	[UnityEngine.Scripting.Preserve]
	public PGLENDBLFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x63EE770", Offset = "0x63ED770", VA = "0x1863EE770", Slot = "8")]
	public GPKOEFJDDBP JMJDNJHKBGL(HANCNHADEOE AENINCMMGKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal static class FAGJFKHBDLI
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class EEOOHCIEOHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public PFLLCKOMFGL<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public EEOOHCIEOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x63D83A0", Offset = "0x63D73A0", VA = "0x1863D83A0")]
		internal object LMGCKCFLFME()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x63D8620", Offset = "0x63D7620", VA = "0x1863D8620")]
	public static PFLLCKOMFGL<string> JEONNGMANCO(IMFBLHALHMN DJHKLFMABMI, [Optional] string HGFEKPAIJJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x63D84A0", Offset = "0x63D74A0", VA = "0x1863D84A0")]
	public static void BHDCHEBDDGJ(PFLLCKOMFGL<string> HCMHKMALPLB, IMFBLHALHMN DJHKLFMABMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x63D8560", Offset = "0x63D7560", VA = "0x1863D8560")]
	public static string EPEPJEINFBA(OCGKKEPIGGA AFHEHHPFPLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal static class FCMALONIKJJ
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x63D8BA0", Offset = "0x63D7BA0", VA = "0x1863D8BA0")]
	public static void LCCAIDLALKA(this HDJBGMMJLFC GDOLGBNNMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x63D8BB0", Offset = "0x63D7BB0", VA = "0x1863D8BB0")]
	public static void LJCCEGDPFLE(this HDJBGMMJLFC GDOLGBNNMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x63D8A80", Offset = "0x63D7A80", VA = "0x1863D8A80")]
	private static void BNFIKDDEIEP(this HDJBGMMJLFC GDOLGBNNMGG, bool HOLFCNJOHGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class BOIDGKADBAM : NBPCAFMKLOH, CPAGEPJPJIM, AHPJNCONHHP, GBEOMIDHIBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private readonly CPAGEPJPJIM JGDHOCBCGGI;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public HANCNHADEOE GALCGBAAEAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x63D14C0", Offset = "0x63D04C0", VA = "0x1863D14C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int LBMFDHDBELP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x63D1360", Offset = "0x63D0360", VA = "0x1863D1360", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int CBNBFABIDLG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x63D1310", Offset = "0x63D0310", VA = "0x1863D1310", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool GJEJAOKPENL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x78B130", Offset = "0x78A130", VA = "0x18078B130", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int HDOAECNFICP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x834600", Offset = "0x833600", VA = "0x180834600", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event CDNICEFMPNI.EKOLLBKOOJM GDLGIAPADEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event KLHNPJFMDOG MPOMHEPCOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x63D0FA0", Offset = "0x63CFFA0", VA = "0x1863D0FA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x63D1400", Offset = "0x63D0400", VA = "0x1863D1400", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> EDDLMNFMABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<HANCNHADEOE> CCGHAGLKCDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action JEGOEGOOAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x63D1190", Offset = "0x63D0190", VA = "0x1863D1190", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x63D1040", Offset = "0x63D0040", VA = "0x1863D1040", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0xC4D520", Offset = "0xC4C520", VA = "0x180C4D520")]
	public BOIDGKADBAM(CPAGEPJPJIM JGDHOCBCGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x63D10E0", Offset = "0x63D00E0", VA = "0x1863D10E0", Slot = "8")]
	public bool GJLFBJDGFOL(byte JIPPKPFPDIK, ExitGames.Client.Photon.Hashtable NBPNCBMEKGD, IJFLFDFKCGL OKFDMLIKDID, SendOptions DGFPPPCJEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x63D1230", Offset = "0x63D0230", VA = "0x1863D1230", Slot = "16")]
	public HANCNHADEOE HCEDMBJIKHA(int CLPPFKPDPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "19")]
	public void GCFKCFBMLJL(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "20")]
	public void CCPHPGPNFNM(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "21")]
	public void NMAACNJHHML(object PDIBILKHEBM, bool HAHCBMKKOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x63D13B0", Offset = "0x63D03B0", VA = "0x1863D13B0", Slot = "22")]
	public IDisposable LCLDMDMHAHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "23")]
	private bool INKIJPIEOND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "24")]
	public void NIHNDJEMJJM(StringBuilder NGAHMDPMIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x63D14A0", Offset = "0x63D04A0", VA = "0x1863D14A0", Slot = "25")]
	public bool NEIAMMILEMD(bool MGFJOMAAPOK, [Out] string KHEFJOIGNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xB2F370", Offset = "0xB2E370", VA = "0x180B2F370", Slot = "28")]
	public void CKPGMADMIMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal struct KONDJEEKEOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private readonly IDictionary<object, object> MFCMLHEKFHP;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x8436A0", Offset = "0x8426A0", VA = "0x1808436A0")]
	public KONDJEEKEOA(IDictionary<object, object> MFCMLHEKFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x63E5170", Offset = "0x63E4170", VA = "0x1863E5170")]
	public bool JDEHKBBBGEB([Out] OCGKKEPIGGA NCBOINMNCHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x63E5220", Offset = "0x63E4220", VA = "0x1863E5220")]
	public Guid OIDMIPBNOIL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x63E4F40", Offset = "0x63E3F40", VA = "0x1863E4F40")]
	public GPKOEFJDDBP AHAPMHNDEJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x63E5080", Offset = "0x63E4080", VA = "0x1863E5080")]
	public static ExitGames.Client.Photon.Hashtable BJANKEDJCNP(OCGKKEPIGGA NCBOINMNCHO, GPKOEFJDDBP CKLFFMBDKHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class INPDFDOBHOD
{
	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x63E0DA0", Offset = "0x63DFDA0", VA = "0x1863E0DA0")]
	public static bool ACLMMOHJHKM(this LPJIABDOGLI FDPAIPNDEPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal struct DJFOPLMMGLN : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct FNHAHCNOKLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public DJFOPLMMGLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x63D8FC0", Offset = "0x63D7FC0", VA = "0x1863D8FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x63D91A0", Offset = "0x63D81A0", VA = "0x1863D91A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly CancellationTokenSource OCCBKDMNJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private bool BKIGCJKEOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private Task NFANMEMOADP;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool EMFJBOKKGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x63D5F00", Offset = "0x63D4F00", VA = "0x1863D5F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x63D5F30", Offset = "0x63D4F30", VA = "0x1863D5F30")]
	public DJFOPLMMGLN(CancellationToken JEBPNJAPHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x63D5DF0", Offset = "0x63D4DF0", VA = "0x1863D5DF0")]
	[AsyncStateMachine(typeof(FNHAHCNOKLB))]
	public Task JCNBFHILKGI(Func<CancellationToken, List<Task>> NCPMIFFFNFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x63D5DA0", Offset = "0x63D4DA0", VA = "0x1863D5DA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public readonly struct LPPGJIPGMFM<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct KNPAEINACJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder<CJDJPCEAKND<CJDGGCFLJMM<TData>, PKPFPNLKHDF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public LPPGJIPGMFM<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private TaskAwaiter<CJDJPCEAKND<byte[], PKPFPNLKHDF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x39D9830", Offset = "0x39D8830", VA = "0x1839D9830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x39DA980", Offset = "0x39D9980", VA = "0x1839DA980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly PCBJJBIDLOM<TGetDataArg, TData> ADEFBBLCDGG;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x8436A0", Offset = "0x8426A0", VA = "0x1808436A0")]
	internal LPPGJIPGMFM(PCBJJBIDLOM<TGetDataArg, TData> AKMCMCJGOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F840", Offset = "0x3A9E840", VA = "0x183A9F840")]
	[AsyncStateMachine(typeof(LPPGJIPGMFM<, >.KNPAEINACJH))]
	public Task<CJDJPCEAKND<CJDGGCFLJMM<TData>, PKPFPNLKHDF>> PIFEHJMMPIK(TGetDataArg DKCNDPMKPNO, string GIHAHMDBENC, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class DIAKHILNKNC
{
	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x22AD140", Offset = "0x22AC140", VA = "0x1822AD140")]
	public static LPPGJIPGMFM<TGetDataArg, TData> ANBAJJBGINK<TGetDataArg, TData>(PCBJJBIDLOM<TGetDataArg, TData> AKMCMCJGOCI)
	{
		return default(LPPGJIPGMFM<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct DNCIBFDLMHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public readonly int MFDDLNFEFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public readonly int? IPAOHPKHDMF;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A50740", Offset = "0x3A4F740", VA = "0x183A50740")]
	public DNCIBFDLMHO(int JBMNHFKOFIC, [Optional] int? GNBFIAGDNGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x63D60C0", Offset = "0x63D50C0", VA = "0x1863D60C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface EFOINFLBONB<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMMFADPADMP();

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EFOINFLBONB<T> FIOHEDMFJJI(string JLEHGNOPMFG);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EFOINFLBONB<T> EDCIJLGBGMN(DHHHHPCAFFO<T> GNKEJHNDJJL);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EFOINFLBONB<T> OLEKKHBFCOM(int KKBHHFJDIJK);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EFOINFLBONB<T> LCGOKGJENAB(int KKBHHFJDIJK, KLNOFHBAJMC<T> HCMNENEEJIN);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface PLGCFFBLAPM
{
	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EFOINFLBONB<T> MBCHMPJIJAM<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NMDLNKGNBIJ NBNPPFFDABK(Exception GDBKEDNPKDC);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DNCIBFDLMHO OCKMKIGBFBI(Exception GDBKEDNPKDC);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public delegate string DHHHHPCAFFO<in T>(T GDBKEDNPKDC) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate int KLNOFHBAJMC<in T>(T GDBKEDNPKDC) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class LOGDDBPHGCK : PLGCFFBLAPM
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private delegate string EFKODNIAKKO(Exception GDBKEDNPKDC);

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate int FPPMAFFPNOO(Exception GDBKEDNPKDC);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private class JDFHNEAACME<T> : EFOINFLBONB<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class HOJMLBNHCLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public HOJMLBNHCLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
			internal string LCGCEEFPCPB(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class ILEENJPJDKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public DHHHHPCAFFO<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public ILEENJPJDKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x346A160", Offset = "0x3469160", VA = "0x18346A160")]
			internal string HGOHCBFDNCH(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class FMADDLJCBPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public KLNOFHBAJMC<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public FMADDLJCBPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x346A160", Offset = "0x3469160", VA = "0x18346A160")]
			internal int EOAIICJOGKL(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly LOGDDBPHGCK MAPNJIKJEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private readonly Type NFKOEJJHHGB;

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x38D0B30", Offset = "0x38CFB30", VA = "0x1838D0B30")]
		internal JDFHNEAACME(LOGDDBPHGCK MAPNJIKJEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x38D0B00", Offset = "0x38CFB00", VA = "0x1838D0B00", Slot = "4")]
		public void OMMFADPADMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x38D0890", Offset = "0x38CF890", VA = "0x1838D0890", Slot = "5")]
		public EFOINFLBONB<T> FIOHEDMFJJI(string JLEHGNOPMFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x38D0780", Offset = "0x38CF780", VA = "0x1838D0780", Slot = "6")]
		public EFOINFLBONB<T> EDCIJLGBGMN(DHHHHPCAFFO<T> GNKEJHNDJJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x38D0AC0", Offset = "0x38CFAC0", VA = "0x1838D0AC0", Slot = "7")]
		public EFOINFLBONB<T> OLEKKHBFCOM(int KKBHHFJDIJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x38D09A0", Offset = "0x38CF9A0", VA = "0x1838D09A0", Slot = "8")]
		public EFOINFLBONB<T> LCGOKGJENAB(int KKBHHFJDIJK, KLNOFHBAJMC<T> HCMNENEEJIN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class DCJOONAPHPN<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private bool PLHIMENPNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private readonly List<Type> GKLNAHGJDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private readonly Dictionary<Type, TVal> FCAPAHPHKJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly Dictionary<Type, int> AHEKLFDNPNH;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public IReadOnlyList<Type> KGCHGCMGCPC
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x4D91710", Offset = "0x4D90710", VA = "0x184D91710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x4D91950", Offset = "0x4D90950", VA = "0x184D91950")]
		public DCJOONAPHPN(Dictionary<Type, int> AHEKLFDNPNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x4D91510", Offset = "0x4D90510", VA = "0x184D91510")]
		public void GPDFOMDKBKK(Type BGNGIHJEFLM, TVal DKCKOABFNGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x4D91910", Offset = "0x4D90910", VA = "0x184D91910")]
		public bool OJHNMEFAHCC(Type NFKOEJJHHGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x4D91490", Offset = "0x4D90490", VA = "0x184D91490")]
		public bool FKIGMPOKHPA(TVal APPJEOKOGAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x4D914D0", Offset = "0x4D904D0", VA = "0x184D914D0")]
		public TVal GJNMDDLIIAA(Type CFGJPNBLNDJ)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x4D917D0", Offset = "0x4D907D0", VA = "0x184D917D0")]
		[CompilerGenerated]
		private int NHJIJCAECHL(Type PJJFGEMIDOB, Type KOIDAFIOOJB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class BAHHFKKCKAD : IEnumerable<DNCIBFDLMHO>, IEnumerable, IEnumerator<DNCIBFDLMHO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private DNCIBFDLMHO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public LOGDDBPHGCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private IEnumerator<DNCIBFDLMHO> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private DNCIBFDLMHO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x3171D00", Offset = "0x3170D00", VA = "0x183171D00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(DNCIBFDLMHO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x63D0A50", Offset = "0x63CFA50", VA = "0x1863D0A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A40", Offset = "0x8BFA40", VA = "0x1808C0A40")]
		[DebuggerHidden]
		public BAHHFKKCKAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x63D0AA0", Offset = "0x63CFAA0", VA = "0x1863D0AA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x63D0490", Offset = "0x63CF490", VA = "0x1863D0490", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x63D0440", Offset = "0x63CF440", VA = "0x1863D0440")]
		private void GDOLLNLODDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x63D03F0", Offset = "0x63CF3F0", VA = "0x1863D03F0")]
		private void CPPLOHGLGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x63D0A00", Offset = "0x63CFA00", VA = "0x1863D0A00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x63D0940", Offset = "0x63CF940", VA = "0x1863D0940", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DNCIBFDLMHO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x63D0940", Offset = "0x63CF940", VA = "0x1863D0940", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private static readonly DNCIBFDLMHO HIKOBONNBLG;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private static readonly Dictionary<Type, int> KJOFDEAIIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private readonly HashSet<Type> DFGMHDPAGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private readonly DCJOONAPHPN<int> MGFAFGNJMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly DCJOONAPHPN<FPPMAFFPNOO> MEKKGNGIPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly DCJOONAPHPN<EFKODNIAKKO> JOHMNLOOICK;

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x63E81D0", Offset = "0x63E71D0", VA = "0x1863E81D0")]
	[PKDJMILODMH(OMIAJJHDDGO.GameOnly)]
	private static void KIGOHJFFCIM(EIABFOFJCDK ENBCIOEOBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x63E8DB0", Offset = "0x63E7DB0", VA = "0x1863E8DB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LOGDDBPHGCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x24E6F40", Offset = "0x24E5F40", VA = "0x1824E6F40", Slot = "4")]
	public EFOINFLBONB<T> MBCHMPJIJAM<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x63E8240", Offset = "0x63E7240", VA = "0x1863E8240", Slot = "5")]
	public NMDLNKGNBIJ NBNPPFFDABK(Exception GDBKEDNPKDC)
	{
		return default(NMDLNKGNBIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x63E82D0", Offset = "0x63E72D0", VA = "0x1863E82D0", Slot = "6")]
	public DNCIBFDLMHO OCKMKIGBFBI(Exception? GDBKEDNPKDC)
	{
		return default(DNCIBFDLMHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x63E7B30", Offset = "0x63E6B30", VA = "0x1863E7B30", Slot = "7")]
	[IteratorStateMachine(typeof(BAHHFKKCKAD))]
	public IEnumerable<DNCIBFDLMHO> FBNHKJFAODO(Exception GDBKEDNPKDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x63E87E0", Offset = "0x63E77E0", VA = "0x1863E87E0", Slot = "8")]
	public string OJHFOOMOBPK(Exception? GDBKEDNPKDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x63E84D0", Offset = "0x63E74D0", VA = "0x1863E84D0")]
	private string ODNHBKOHGMD(AggregateException DKJEADIIAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x63E8930", Offset = "0x63E7930", VA = "0x1863E8930")]
	private void PAACADEBENG(Type NFKOEJJHHGB, int KKBHHFJDIJK, FPPMAFFPNOO? AOHGMEPAMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x63E7F80", Offset = "0x63E6F80", VA = "0x1863E7F80")]
	private void KGDNEHCEEHA(Type NFKOEJJHHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x63E7CB0", Offset = "0x63E6CB0", VA = "0x1863E7CB0")]
	private void JBPPFJOBMHB(Type NFKOEJJHHGB, EFKODNIAKKO EPCDJPAGJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x63E79B0", Offset = "0x63E69B0", VA = "0x1863E79B0")]
	private static int BPHPKBEDGFD(Type NFKOEJJHHGB, Dictionary<Type, int> AHEKLFDNPNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2568510", Offset = "0x2567510", VA = "0x182568510")]
	private static bool HHPDNEKFKMB<TVal>(DCJOONAPHPN<TVal> ALBJDCCCHNI, Type NFKOEJJHHGB, [Out] TVal APPJEOKOGAK) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x63E7BD0", Offset = "0x63E6BD0", VA = "0x1863E7BD0")]
	[CompilerGenerated]
	internal static int FOCBCHJGJGH(Type PJEPKBIEJBP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct NMDLNKGNBIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public readonly DNCIBFDLMHO CJIJHIELJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public readonly string CFBAAJICDNN;

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x63EB2B0", Offset = "0x63EA2B0", VA = "0x1863EB2B0")]
	public NMDLNKGNBIJ(string KNPBPHCAOCG, DNCIBFDLMHO KKBHHFJDIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x63EB210", Offset = "0x63EA210", VA = "0x1863EB210")]
	public string FMCDPOEKDGM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class GDLDHDHGFLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly KIMAMHDMBAE AINOPJJNOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private string OGNIMEOJHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private long? HEPJBICIGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private long? ADCPNGHOMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? NHCMGJCFJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private string MAAFJFCDFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private HLMNMBBHFAH HADGDFBPAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private long? FMHDFAHJPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private bool EJMMODCCPON;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public string NNBKLBEGFID
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public long GLACFLEMPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x63DA320", Offset = "0x63D9320", VA = "0x1863DA320")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public long LNKAGAPIPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x63DAC50", Offset = "0x63D9C50", VA = "0x1863DAC50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public long JGCKPMLEKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x63DA470", Offset = "0x63D9470", VA = "0x1863DA470")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string LCOABPHBIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x63DAC10", Offset = "0x63D9C10", VA = "0x1863DAC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public HLMNMBBHFAH ALDLGCHOBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xF92280", Offset = "0xF91280", VA = "0x180F92280")]
		get
		{
			return default(HLMNMBBHFAH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x63DA380", Offset = "0x63D9380", VA = "0x1863DA380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long NKBFJKMFOBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x63DA4D0", Offset = "0x63D94D0", VA = "0x1863DA4D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x63DB150", Offset = "0x63DA150", VA = "0x1863DB150")]
	[UnityEngine.Scripting.Preserve]
	public GDLDHDHGFLC([KHIPNIHHNOH(null)] KIMAMHDMBAE AINOPJJNOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x63DA9C0", Offset = "0x63D99C0", VA = "0x1863DA9C0")]
	private void HJGALMGOEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x63DA530", Offset = "0x63D9530", VA = "0x1863DA530")]
	public void HHAEOKIMOCF(long KAOIBEOBDCN, long HIFDDDODBFK, [Optional] long? BEMMFIIOINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x63DAD30", Offset = "0x63D9D30", VA = "0x1863DAD30")]
	public void OOPFLGOBIDI(long BEMMFIIOINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x63DACB0", Offset = "0x63D9CB0", VA = "0x1863DACB0")]
	public void NOHIOLPEFMC(string CIALOEIKMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x63DADD0", Offset = "0x63D9DD0", VA = "0x1863DADD0")]
	public void PCHPLBPBHAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class IGDBPFKILJO : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct CCAHCKIBIGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public AsyncTaskMethodBuilder<OCGKKEPIGGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public OCGKKEPIGGA roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public IGDBPFKILJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private TaskAwaiter<CPHKDNMEPBN.KHNPFDDOGFG<OCGKKEPIGGA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x63D1570", Offset = "0x63D0570", VA = "0x1863D1570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x63D1AA0", Offset = "0x63D0AA0", VA = "0x1863D1AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct HNFFEGDPGGI<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class GEOKLLPIOHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public OCGKKEPIGGA roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public GEOKLLPIOHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x63DB190", Offset = "0x63DA190", VA = "0x1863DB190")]
		internal OCGKKEPIGGA GMJMLAFGDIB(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct DOLJBKNKBGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public AsyncTaskMethodBuilder<CPHKDNMEPBN.KHNPFDDOGFG<OCGKKEPIGGA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public OCGKKEPIGGA roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public IGDBPFKILJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private LLAHLAEGPAB <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private TaskAwaiter<CPHKDNMEPBN.KHNPFDDOGFG<OCGKKEPIGGA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x63D61A0", Offset = "0x63D51A0", VA = "0x1863D61A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x63D67B0", Offset = "0x63D57B0", VA = "0x1863D67B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct PCABMGJCIMK<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public IGDBPFKILJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1040", Offset = "0x3EA0040", VA = "0x183EA1040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x351D580", Offset = "0x351C580", VA = "0x18351D580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct FJAELGNHDIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public IGDBPFKILJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x63D8D40", Offset = "0x63D7D40", VA = "0x1863D8D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x63D8F00", Offset = "0x63D7F00", VA = "0x1863D8F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class MIFABFHCMNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public MIFABFHCMNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x63E97D0", Offset = "0x63E87D0", VA = "0x1863E97D0")]
		internal object OHIABEIGEAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x63E9710", Offset = "0x63E8710", VA = "0x1863E9710")]
		internal bool NABBLCAJEFF(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class BDCNJIJCGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public BDCNJIJCGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x63D0BF0", Offset = "0x63CFBF0", VA = "0x1863D0BF0")]
		internal object FENNMNPNOKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class BKNFKKODGAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public BKNFKKODGAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x63D0E10", Offset = "0x63CFE10", VA = "0x1863D0E10")]
		internal object DGKLIDHODIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class GIKBKNBDFAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public GIKBKNBDFAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x63DB270", Offset = "0x63DA270", VA = "0x1863DB270")]
		internal object CMAMNAGOLFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class DOPAGGFAEMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public IGDBPFKILJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public DOPAGGFAEMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x63D6820", Offset = "0x63D5820", VA = "0x1863D6820")]
		internal object EKNFBEJEECA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private static readonly Guid NOCALOJGBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public readonly KNNODDOINJP BIBKPBNONAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private readonly CPHKDNMEPBN JNHGCBJBGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly AHPJNCONHHP GDOLGBNNMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly GBEOMIDHIBK JKEMLKMOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private bool JMNCDAJKCGM;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x63E0740", Offset = "0x63DF740", VA = "0x1863E0740")]
	public IGDBPFKILJO(KNNODDOINJP ILJNJNIMKOM, CPHKDNMEPBN JNHGCBJBGOI, AHPJNCONHHP GDOLGBNNMGG, GBEOMIDHIBK JKEMLKMOCEB, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x63DF8E0", Offset = "0x63DE8E0", VA = "0x1863DF8E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x63DF8E0", Offset = "0x63DE8E0", VA = "0x1863DF8E0")]
	public void FNNFLDDBIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x63DFB90", Offset = "0x63DEB90", VA = "0x1863DFB90")]
	public void GMFFOBHJPOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x63E01F0", Offset = "0x63DF1F0", VA = "0x1863E01F0")]
	public void NLLAPMHMECF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x63DF780", Offset = "0x63DE780", VA = "0x1863DF780")]
	[AsyncStateMachine(typeof(CCAHCKIBIGC))]
	internal Task<OCGKKEPIGGA> CNHNFJBCNLG(PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, OCGKKEPIGGA AFHEHHPFPLE, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x250C2E0", Offset = "0x250B2E0", VA = "0x18250C2E0")]
	private static byte[] FGDIALOMCCE<T>(T NCBOINMNCHO) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x250C5A0", Offset = "0x250B5A0", VA = "0x18250C5A0")]
	private static T NFHMMPLEIKG<T>(MessageParser<T> BJLEDHJMEKE, byte[] NCBOINMNCHO, T NDHJFMDGDMJ) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x63DFA50", Offset = "0x63DEA50", VA = "0x1863DFA50")]
	[AsyncStateMachine(typeof(DOLJBKNKBGL))]
	private Task<CPHKDNMEPBN.KHNPFDDOGFG<OCGKKEPIGGA>> GFHCPALBJJB(OCGKKEPIGGA AFHEHHPFPLE, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x250C6F0", Offset = "0x250B6F0", VA = "0x18250C6F0")]
	[AsyncStateMachine(typeof(PCABMGJCIMK<>))]
	internal Task<T> OEDICGEGFAF<T>(CancellationToken PMLBMCIFPPF, Func<CancellationToken, Task<T>> NAKOOHPEIFJ, int EKPMPPBOAEG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x63E02B0", Offset = "0x63DF2B0", VA = "0x1863E02B0")]
	[AsyncStateMachine(typeof(FJAELGNHDIG))]
	internal Task OEDICGEGFAF(CancellationToken PMLBMCIFPPF, Func<CancellationToken, Task> NAKOOHPEIFJ, int EKPMPPBOAEG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x63DFD90", Offset = "0x63DED90", VA = "0x1863DFD90")]
	public LIDMKBOKAGM JFNAMPIPIDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x63E04F0", Offset = "0x63DF4F0", VA = "0x1863E04F0")]
	public DAFKLKGCOKJ PDEACEEMALE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x63DFF90", Offset = "0x63DEF90", VA = "0x1863DFF90")]
	public NLPLMFCFCMK NCGGBMHMPGO([Optional] IMFBLHALHMN? DJHKLFMABMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x63E0570", Offset = "0x63DF570", VA = "0x1863E0570")]
	public void PFNCIPFDAFO(Func<Guid, bool> MADDKJNCNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x63E00E0", Offset = "0x63DF0E0", VA = "0x1863E00E0")]
	public void NJDOJLGODFH(Func<Guid, bool> PBCEOJIBDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x63DFE10", Offset = "0x63DEE10", VA = "0x1863DFE10")]
	public Guid KJFLJJEFCBK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x63DF670", Offset = "0x63DE670", VA = "0x1863DF670")]
	public void BCOHPKHDBNM(Guid JEBNHFOGEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x63DFC50", Offset = "0x63DEC50", VA = "0x1863DFC50")]
	public void IMACBKJKAAL(OCGKKEPIGGA FKIMDDNECEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x63E03E0", Offset = "0x63DF3E0", VA = "0x1863E03E0")]
	public void PAOJJBFOCDP(string FBJNGINILFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x250C1F0", Offset = "0x250B1F0", VA = "0x18250C1F0")]
	private T AEEGBGAAMCJ<T>(T APPJEOKOGAK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x63DFA00", Offset = "0x63DEA00", VA = "0x1863DFA00")]
	public void FAECLCEOJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x250C2F0", Offset = "0x250B2F0", VA = "0x18250C2F0")]
	[CompilerGenerated]
	internal static string GCLNLILPOJA<T>(byte[] BKCOILCKNDC, int AAIHABNEPDM, HNFFEGDPGGI<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal sealed class CMHAHDCAEBC : KNNODDOINJP
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class EEPNMBHCCLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public EEPNMBHCCLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x63F5BC0", Offset = "0x63F4BC0", VA = "0x1863F5BC0")]
		internal object OOPOJJJHBLC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct PFPDOPKGILI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public CMHAHDCAEBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public IGDBPFKILJO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private FGJACDIIGLL <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private DAFKLKGCOKJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x6405900", Offset = "0x6404900", VA = "0x186405900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x64060E0", Offset = "0x64050E0", VA = "0x1864060E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct LPEAJPHOEAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public CMHAHDCAEBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<MCEIHIBECAG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x63FF9E0", Offset = "0x63FE9E0", VA = "0x1863FF9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x6400080", Offset = "0x63FF080", VA = "0x186400080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct BIHPJKEOAHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public CMHAHDCAEBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private TaskAwaiter<GNBPKJBLPKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x63F1910", Offset = "0x63F0910", VA = "0x1863F1910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x63F1C30", Offset = "0x63F0C30", VA = "0x1863F1C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class NGFODMDPOCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public FGJACDIIGLL presence;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public NGFODMDPOCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x6401AF0", Offset = "0x6400AF0", VA = "0x186401AF0")]
		internal object JPCLBBBKKJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly IMFBLHALHMN DJHKLFMABMI;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly IMFBLHALHMN HEIPKGBHEPA;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly IMFBLHALHMN JPOHBJGMBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private readonly CIFKNLJLNLO MECOHCPKCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private readonly LPJIABDOGLI NEKFAPDECED;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x63D4230", Offset = "0x63D3230", VA = "0x1863D4230")]
	public CMHAHDCAEBC(CIFKNLJLNLO MECOHCPKCAH, LPJIABDOGLI NEKFAPDECED, Guid KBNMFHADFEA, LDIAGFCFIDA MFKBBJFDJHI, DIIGLJEEJID DEPHNHOEMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x63D3F00", Offset = "0x63D2F00", VA = "0x1863D3F00", Slot = "7")]
	[AsyncStateMachine(typeof(PFPDOPKGILI))]
	protected override Task FJLHLPJMAOK(IGDBPFKILJO BALLFIJIOCA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x63D3E00", Offset = "0x63D2E00", VA = "0x1863D3E00")]
	[AsyncStateMachine(typeof(LPEAJPHOEAC))]
	private Task FGHBMEBPKIJ(CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x63D4040", Offset = "0x63D3040", VA = "0x1863D4040")]
	[AsyncStateMachine(typeof(BIHPJKEOAHP))]
	private Task<byte> MNBJEKFPDPP(CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x63D3C20", Offset = "0x63D2C20", VA = "0x1863D3C20")]
	private FGJACDIIGLL CFEDMLLFDMP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class JOFKNAJALKD : KNNODDOINJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct IPBMMCMANNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public JOFKNAJALKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public IGDBPFKILJO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private TaskAwaiter<FACJKOPPMPM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x63FB6F0", Offset = "0x63FA6F0", VA = "0x1863FB6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x63FC070", Offset = "0x63FB070", VA = "0x1863FC070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private readonly int FLMGPAFKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private readonly ALFEBNEDACP DHHBKLBMPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public readonly long AFIMLDIFEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public readonly long NBMMGEANEPA;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public FACJKOPPMPM JGPAJAGGJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x775DE0", Offset = "0x774DE0", VA = "0x180775DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x775DB0", Offset = "0x774DB0", VA = "0x180775DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x63FD150", Offset = "0x63FC150", VA = "0x1863FD150")]
	public JOFKNAJALKD(Guid KBNMFHADFEA, LDIAGFCFIDA MFKBBJFDJHI, DIIGLJEEJID DEPHNHOEMCM, int FLMGPAFKEOI, ALFEBNEDACP DHHBKLBMPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x63FD030", Offset = "0x63FC030", VA = "0x1863FD030", Slot = "7")]
	[AsyncStateMachine(typeof(IPBMMCMANNK))]
	protected override Task FJLHLPJMAOK(IGDBPFKILJO BALLFIJIOCA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal abstract class HKDLKNOBLOM : KNNODDOINJP
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class ACIIKMKMALO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public HKDLKNOBLOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public ONJLCGMCNIC playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public ACIIKMKMALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x63EFB10", Offset = "0x63EEB10", VA = "0x1863EFB10")]
		internal Task EFFECMNGBIL(PFLLCKOMFGL<string>.FEFFPGFLENA postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x63EFB50", Offset = "0x63EEB50", VA = "0x1863EFB50")]
		internal object IKCDKPMLHDI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct JGJJCKKOCLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public HKDLKNOBLOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public IGDBPFKILJO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private ACIIKMKMALO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x63FC250", Offset = "0x63FB250", VA = "0x1863FC250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x63FCA10", Offset = "0x63FBA10", VA = "0x1863FCA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct MGMAEIPPDKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public ONJLCGMCNIC playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public HKDLKNOBLOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x64004B0", Offset = "0x63FF4B0", VA = "0x1864004B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6400A40", Offset = "0x63FFA40", VA = "0x186400A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x63F9410", Offset = "0x63F8410", VA = "0x1863F9410")]
	public HKDLKNOBLOM(Guid KBNMFHADFEA, LDIAGFCFIDA MFKBBJFDJHI, DIIGLJEEJID DEPHNHOEMCM, string INHAEOHABDJ, NHBLINDOEMG FDIEGFHJBPI, bool PJCJAPOMIHD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x63F92D0", Offset = "0x63F82D0", VA = "0x1863F92D0", Slot = "7")]
	[AsyncStateMachine(typeof(JGJJCKKOCLP))]
	protected override Task FJLHLPJMAOK(IGDBPFKILJO BALLFIJIOCA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task NFNAALMODLI(IGDBPFKILJO BALLFIJIOCA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x63F9190", Offset = "0x63F8190", VA = "0x1863F9190")]
	[AsyncStateMachine(typeof(MGMAEIPPDKC))]
	private Task BANJGFAEBOC(IDisposable ECOFEFFMIBP, ONJLCGMCNIC CKMIIIJEDIG, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class PNKHLGONBLJ : KNNODDOINJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct JPCKKJFPKKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public PNKHLGONBLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public IGDBPFKILJO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private TaskAwaiter<NKNGHGMAJIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x63FD3E0", Offset = "0x63FC3E0", VA = "0x1863FD3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x63FD950", Offset = "0x63FC950", VA = "0x1863FD950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	private readonly BFJJLHPIHPM GJGEIEHPEOB;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6406A40", Offset = "0x6405A40", VA = "0x186406A40")]
	public PNKHLGONBLJ(Guid KBNMFHADFEA, LDIAGFCFIDA MFKBBJFDJHI, DIIGLJEEJID DEPHNHOEMCM, BFJJLHPIHPM GJGEIEHPEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6406960", Offset = "0x6405960", VA = "0x186406960", Slot = "6")]
	protected override string OINAJJMHLJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6406840", Offset = "0x6405840", VA = "0x186406840", Slot = "7")]
	[AsyncStateMachine(typeof(JPCKKJFPKKL))]
	protected override Task FJLHLPJMAOK(IGDBPFKILJO BALLFIJIOCA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class KNNODDOINJP : ACKIPOPELHK
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public delegate Task PJCNEBDALCK(PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class DFABELCHKEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public KNNODDOINJP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public DFABELCHKEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x63F4DF0", Offset = "0x63F3DF0", VA = "0x1863F4DF0")]
		internal Task LNNIHIJAJOF(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class JBMBGEOAHMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public DFABELCHKEP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public JBMBGEOAHMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x63FC0D0", Offset = "0x63FB0D0", VA = "0x1863FC0D0")]
		internal object BIECBACBDOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x63FC190", Offset = "0x63FB190", VA = "0x1863FC190")]
		internal object NNBPKCCLIAC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct AJGHGKFPMBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public KNNODDOINJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public Func<KNNODDOINJP, PFLLCKOMFGL<string>.FEFFPGFLENA, IGDBPFKILJO> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private DFABELCHKEP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private IGDBPFKILJO <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<OCGKKEPIGGA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x63F0030", Offset = "0x63EF030", VA = "0x1863F0030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x63F1230", Offset = "0x63F0230", VA = "0x1863F1230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct IKHCLEIKGIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x63F9C00", Offset = "0x63F8C00", VA = "0x1863F9C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x63FA680", Offset = "0x63F9680", VA = "0x1863FA680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct KPPGKNLDIJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public KNNODDOINJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x63FF100", Offset = "0x63FE100", VA = "0x1863FF100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x63FF460", Offset = "0x63FE460", VA = "0x1863FF460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly Guid HPDKIOPIJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly ByteString PCIDPHNFKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly DIIGLJEEJID APMEHKNMPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	protected readonly string FNCJNBBHEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private readonly bool PJCJAPOMIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly Queue<PJCNEBDALCK> PFEKKPANCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly LOMEGEHHEJF DGLIDNOJBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly NHBLINDOEMG FDIEGFHJBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private bool CECHPKMLMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public HLMNMBBHFAH KCCJBGEKAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public HLMNMBBHFAH POBKOGMJFFA;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public LDIAGFCFIDA MGHFLABNEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x774F60", Offset = "0x773F60", VA = "0x180774F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public AJNHNKMBAPI DAKHMKMAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x63FEBE0", Offset = "0x63FDBE0", VA = "0x1863FEBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public EODIMPPJHNN CPFJBHHNMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x63FEB30", Offset = "0x63FDB30", VA = "0x1863FEB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public JPJCLLNFHEO EFLFLLHFENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x63FE550", Offset = "0x63FD550", VA = "0x1863FE550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event HPLCJCJIPEP JICANIJCLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x63FE6C0", Offset = "0x63FD6C0", VA = "0x1863FE6C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x63FEB80", Offset = "0x63FDB80", VA = "0x1863FEB80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x63FED80", Offset = "0x63FDD80", VA = "0x1863FED80")]
	protected KNNODDOINJP(Guid KBNMFHADFEA, LDIAGFCFIDA MFKBBJFDJHI, DIIGLJEEJID DEPHNHOEMCM, string INHAEOHABDJ, NHBLINDOEMG FDIEGFHJBPI, bool PJCJAPOMIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x63FEBA0", Offset = "0x63FDBA0", VA = "0x1863FEBA0", Slot = "6")]
	protected virtual string OINAJJMHLJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x63FE900", Offset = "0x63FD900", VA = "0x1863FE900")]
	public void KBDMPMIDHAD(PJCNEBDALCK BCFKKGGBHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x63FE410", Offset = "0x63FD410", VA = "0x1863FE410")]
	protected void BEOKFKBOAFL(float KLACNNEOMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x63FE9E0", Offset = "0x63FD9E0", VA = "0x1863FE9E0")]
	[AsyncStateMachine(typeof(AJGHGKFPMBI))]
	public Task LODICMNCPHB(CancellationToken JEBPNJAPHEL, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, [Optional] Func<KNNODDOINJP, PFLLCKOMFGL<string>.FEFFPGFLENA, IGDBPFKILJO> CHODNHDNGEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x63FE6E0", Offset = "0x63FD6E0", VA = "0x1863FE6E0")]
	[AsyncStateMachine(typeof(IKHCLEIKGIK))]
	private static Task GBFAGNOGBJB(Func<CancellationToken, Task> IDDMHGKDFKL, Func<CancellationToken, Task> LIIKOMMGKAJ, CancellationToken PMLBMCIFPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x63FEC30", Offset = "0x63FDC30", VA = "0x1863FEC30")]
	private void OPENMLIGNOE(bool ENFECCOPMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x63FE810", Offset = "0x63FD810", VA = "0x1863FE810")]
	private void GBONGDDEGAJ(IGDBPFKILJO BALLFIJIOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task FJLHLPJMAOK(IGDBPFKILJO BALLFIJIOCA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x63FE430", Offset = "0x63FD430", VA = "0x1863FE430")]
	[AsyncStateMachine(typeof(KPPGKNLDIJF))]
	private Task CNFFCDDNKHP(PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x63FE960", Offset = "0x63FD960", VA = "0x1863FE960")]
	public OCGKKEPIGGA KLMIHPLKPPH(LLAHLAEGPAB FKDLHLJBOIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x63FE5D0", Offset = "0x63FD5D0", VA = "0x1863FE5D0")]
	[CompilerGenerated]
	private Task FACKLGFDKMI(CancellationToken CDBKGKHLPJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
internal sealed class EBMBFNKHDNL : HKDLKNOBLOM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct DBDIGCCAMMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public EBMBFNKHDNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public IGDBPFKILJO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private PLIIDCKOCBJ <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private DAFKLKGCOKJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x63F4620", Offset = "0x63F3620", VA = "0x1863F4620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x63F4D90", Offset = "0x63F3D90", VA = "0x1863F4D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly CIFKNLJLNLO AHKFBEILDEE;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x63F5B10", Offset = "0x63F4B10", VA = "0x1863F5B10")]
	public EBMBFNKHDNL(Guid KBNMFHADFEA, LDIAGFCFIDA MFKBBJFDJHI, CIFKNLJLNLO AHKFBEILDEE, DIIGLJEEJID DEPHNHOEMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x63F59C0", Offset = "0x63F49C0", VA = "0x1863F59C0", Slot = "8")]
	[AsyncStateMachine(typeof(DBDIGCCAMMB))]
	protected override Task NFNAALMODLI(IGDBPFKILJO BALLFIJIOCA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
internal class MKLAIGMBEFE : KNNODDOINJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct LOJOKAGHOEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public MKLAIGMBEFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public IGDBPFKILJO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private TaskAwaiter<NKNGHGMAJIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x63FF5D0", Offset = "0x63FE5D0", VA = "0x1863FF5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x63FF980", Offset = "0x63FE980", VA = "0x1863FF980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private readonly string FJCOFLAALBM;

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x64015C0", Offset = "0x64005C0", VA = "0x1864015C0")]
	public MKLAIGMBEFE(Guid KBNMFHADFEA, LDIAGFCFIDA MFKBBJFDJHI, DIIGLJEEJID DEPHNHOEMCM, string FJCOFLAALBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x64014B0", Offset = "0x64004B0", VA = "0x1864014B0", Slot = "7")]
	[AsyncStateMachine(typeof(LOJOKAGHOEM))]
	protected override Task FJLHLPJMAOK(IGDBPFKILJO BALLFIJIOCA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal class FEFHDKJKBEF : HKDLKNOBLOM
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class KPFHIKACCIN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public AsyncTaskMethodBuilder<OCGKKEPIGGA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public KPFHIKACCIN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<NKNGHGMAJIA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			private TaskAwaiter<OCGKKEPIGGA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x6409810", Offset = "0x6408810", VA = "0x186409810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x6409CD0", Offset = "0x6408CD0", VA = "0x186409CD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public FEFHDKJKBEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public NLPLMFCFCMK serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public KEDEFKCBACM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public LIDMKBOKAGM uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public DKIOIIGJIDP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public KPFHIKACCIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x63FEFE0", Offset = "0x63FDFE0", VA = "0x1863FEFE0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<OCGKKEPIGGA> IGKOILOFKJO(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct NNECEHHPONH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public FEFHDKJKBEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public IGDBPFKILJO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private KPFHIKACCIN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private PLIIDCKOCBJ <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private DAFKLKGCOKJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private TaskAwaiter<OCGKKEPIGGA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x64025C0", Offset = "0x64015C0", VA = "0x1864025C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x6403460", Offset = "0x6402460", VA = "0x186403460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private static readonly IMFBLHALHMN DJHKLFMABMI;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly IMFBLHALHMN HEIPKGBHEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private readonly int KMPEFDCGPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	[CanBeNull]
	private readonly CJCILOJDOKG FHHGEIENCHI;

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x63F60F0", Offset = "0x63F50F0", VA = "0x1863F60F0")]
	public FEFHDKJKBEF(Guid KBNMFHADFEA, LDIAGFCFIDA MFKBBJFDJHI, int KMPEFDCGPJE, CJCILOJDOKG FHHGEIENCHI, DIIGLJEEJID DEPHNHOEMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x63F5D30", Offset = "0x63F4D30", VA = "0x1863F5D30", Slot = "8")]
	[AsyncStateMachine(typeof(NNECEHHPONH))]
	protected override Task NFNAALMODLI(IGDBPFKILJO BALLFIJIOCA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x63F5C30", Offset = "0x63F4C30", VA = "0x1863F5C30")]
	private void DHLCFCOAKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x63F5E70", Offset = "0x63F4E70", VA = "0x1863F5E70")]
	private void PJDKPNJCMFE(PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, PLIIDCKOCBJ BAHPNHBJDGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal abstract class JPCHIBFEFIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly KNNODDOINJP BIBKPBNONAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly IGDBPFKILJO KECCLBPMHMC;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public AJNHNKMBAPI DAKHMKMAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x63FD310", Offset = "0x63FC310", VA = "0x1863FD310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public JPJCLLNFHEO EFLFLLHFENI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x63FD280", Offset = "0x63FC280", VA = "0x1863FD280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x63FD380", Offset = "0x63FC380", VA = "0x1863FD380")]
	protected JPCHIBFEFIF(IGDBPFKILJO BALLFIJIOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x63FD360", Offset = "0x63FC360", VA = "0x1863FD360")]
	protected void PAOJJBFOCDP(string FBJNGINILFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal struct GGHEFABFJCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public Dictionary<Guid, List<LEDADMDAMKM>> KCDCOEBCBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public Dictionary<Guid, List<LEDADMDAMKM>> NGMDENPAILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public Dictionary<Guid, List<LEDADMDAMKM>> FIDPLDBPJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public List<Guid> OLDNLBGLEEI;

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x63F7830", Offset = "0x63F6830", VA = "0x1863F7830")]
	public static GGHEFABFJCG GJNMDDLIIAA(AJNHNKMBAPI ICCKKADELMP, HLMNMBBHFAH HPNEIHAOLGE, LLGCMGAEGBM EILDHIPOEJH)
	{
		return default(GGHEFABFJCG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal struct EMBNPMIADDJ
{
	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0")]
	public static EMBNPMIADDJ BJANKEDJCNP()
	{
		return default(EMBNPMIADDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct GKBLMJJHFGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly MCEIHIBECAG JOHECMNIEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly PNEBNDCHIFA EPBJFAJJFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly string HHGIIFONOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly AEBNJGMIDFC FBEOJJGECFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public readonly AEBNJGMIDFC DFPGBDADMFH;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x63F7E40", Offset = "0x63F6E40", VA = "0x1863F7E40")]
	public GKBLMJJHFGC(MCEIHIBECAG JOHECMNIEAD, PNEBNDCHIFA EPBJFAJJFKM, string HHGIIFONOJM, AEBNJGMIDFC FBEOJJGECFJ, AEBNJGMIDFC DFPGBDADMFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct EBKFAPDFEDN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly IGDBPFKILJO BALLFIJIOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly Guid JEBNHFOGEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private bool ENFECCOPMNB;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x63F5870", Offset = "0x63F4870", VA = "0x1863F5870")]
	public static EBKFAPDFEDN KJFLJJEFCBK(IGDBPFKILJO BALLFIJIOCA)
	{
		return default(EBKFAPDFEDN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x8263C0", Offset = "0x8253C0", VA = "0x1808263C0")]
	public void HMMLAEHEJPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x63F5810", Offset = "0x63F4810", VA = "0x1863F5810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x63F5970", Offset = "0x63F4970", VA = "0x1863F5970")]
	private EBKFAPDFEDN(IGDBPFKILJO BALLFIJIOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x63F5810", Offset = "0x63F4810", VA = "0x1863F5810")]
	private void BCOHPKHDBNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x63F58D0", Offset = "0x63F48D0", VA = "0x1863F58D0")]
	private Func<Guid, bool> MENPIIHMNLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal class DAFKLKGCOKJ : JPCHIBFEFIF, ACKIPOPELHK
{
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	public delegate Task<HLMNMBBHFAH> KPEEGGEOEMN(LLGCMGAEGBM FCLEEDACIMH, GOJAADCHEHO KKFPOMFKKHD, LOMEGEHHEJF MEFHPJNCLKE, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct DGNGCKPFFNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public CIFKNLJLNLO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private EBKFAPDFEDN <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter<OCGKKEPIGGA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x63F4F20", Offset = "0x63F3F20", VA = "0x1863F4F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x63F5690", Offset = "0x63F4690", VA = "0x1863F5690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct NALGOCAMLJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder<OCGKKEPIGGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public CIFKNLJLNLO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private TaskAwaiter<OCGKKEPIGGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x6401670", Offset = "0x6400670", VA = "0x186401670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x6401A80", Offset = "0x6400A80", VA = "0x186401A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct CABNHMEJMOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public CIFKNLJLNLO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x63F1CA0", Offset = "0x63F0CA0", VA = "0x1863F1CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x63F2130", Offset = "0x63F1130", VA = "0x1863F2130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class INDFCOOJCFI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public AsyncTaskMethodBuilder<GKBLMJJHFGC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public INDFCOOJCFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			private GKBLMJJHFGC <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<HLMNMBBHFAH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			private TaskAwaiter<GKBLMJJHFGC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x6407E80", Offset = "0x6406E80", VA = "0x186407E80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x6408610", Offset = "0x6407610", VA = "0x186408610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public AsyncTaskMethodBuilder<LLGCMGAEGBM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public INDFCOOJCFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			private LLGCMGAEGBM <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			private TaskAwaiter<HLMNMBBHFAH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			private TaskAwaiter<LLGCMGAEGBM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x6408680", Offset = "0x6407680", VA = "0x186408680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x6408CD0", Offset = "0x6407CD0", VA = "0x186408CD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public INDFCOOJCFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private TaskAwaiter<HLMNMBBHFAH> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			private GOJAADCHEHO <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x6406AE0", Offset = "0x6405AE0", VA = "0x186406AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x6407E20", Offset = "0x6406E20", VA = "0x186407E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public CIFKNLJLNLO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public LOMEGEHHEJF preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public LOMEGEHHEJF downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public GKBLMJJHFGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public LOMEGEHHEJF postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public LLGCMGAEGBM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public IALLEOEJMID.BMNHCINNHOB <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public INDFCOOJCFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x63FA6E0", Offset = "0x63F96E0", VA = "0x1863FA6E0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<GKBLMJJHFGC> BKOEGOPHHEP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x63FA960", Offset = "0x63F9960", VA = "0x1863FA960")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<LLGCMGAEGBM> KMIKGCJFNKL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x63FA920", Offset = "0x63F9920", VA = "0x1863FA920")]
		internal void IFHICICIANG(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x63FA820", Offset = "0x63F9820", VA = "0x1863FA820")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task DLHCODFNKDG(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct INLNPCPPHHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public CIFKNLJLNLO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private INDFCOOJCFI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter<GKBLMJJHFGC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter<LLGCMGAEGBM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x63FAA80", Offset = "0x63F9A80", VA = "0x1863FAA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x63FB690", Offset = "0x63FA690", VA = "0x1863FB690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct IFBPHNBMFED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x63F9460", Offset = "0x63F8460", VA = "0x1863F9460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x63F9BA0", Offset = "0x63F8BA0", VA = "0x1863F9BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct CMOFKIGHLAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public LOMEGEHHEJF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private TaskAwaiter<HLMNMBBHFAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x63F2190", Offset = "0x63F1190", VA = "0x1863F2190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x63F2AF0", Offset = "0x63F1AF0", VA = "0x1863F2AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct FMEPKDIBIBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public AsyncTaskMethodBuilder<HLMNMBBHFAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public LOMEGEHHEJF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private TaskAwaiter<HLMNMBBHFAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x63F6640", Offset = "0x63F5640", VA = "0x1863F6640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x63F77C0", Offset = "0x63F67C0", VA = "0x1863F77C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct PFIOHHJJEPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AsyncTaskMethodBuilder<HLMNMBBHFAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public LOMEGEHHEJF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public GOJAADCHEHO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private TaskAwaiter<HLMNMBBHFAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x64044C0", Offset = "0x64034C0", VA = "0x1864044C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6405890", Offset = "0x6404890", VA = "0x186405890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct OKCMBDIHNGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public AsyncTaskMethodBuilder<HLMNMBBHFAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public HLMNMBBHFAH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public LOMEGEHHEJF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public LLGCMGAEGBM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private TaskAwaiter<HLMNMBBHFAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x64041C0", Offset = "0x64031C0", VA = "0x1864041C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6404450", Offset = "0x6403450", VA = "0x186404450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class MBIKGKLOCKN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012C")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public AsyncTaskMethodBuilder<HLMNMBBHFAH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public MBIKGKLOCKN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private TaskAwaiter<HLMNMBBHFAH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x6408D40", Offset = "0x6407D40", VA = "0x186408D40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x64093B0", Offset = "0x64083B0", VA = "0x1864093B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public LOMEGEHHEJF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public KPEEGGEOEMN masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public GOJAADCHEHO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public HLMNMBBHFAH originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public MBIKGKLOCKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x6400390", Offset = "0x63FF390", VA = "0x186400390")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<HLMNMBBHFAH> CJLMGIBLBMM(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct PLFOOHNMADN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public AsyncTaskMethodBuilder<HLMNMBBHFAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public LOMEGEHHEJF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public KPEEGGEOEMN masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public GOJAADCHEHO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter<HLMNMBBHFAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x6406290", Offset = "0x6405290", VA = "0x186406290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x64067D0", Offset = "0x64057D0", VA = "0x1864067D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct NMMKFBICOPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public LOMEGEHHEJF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private HLMNMBBHFAH <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private IEnumerator<HLMNMBBHFAH> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter<HLMNMBBHFAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x6402030", Offset = "0x6401030", VA = "0x186402030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6402560", Offset = "0x6401560", VA = "0x186402560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct AFNIOLEPDOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x63EFCC0", Offset = "0x63EECC0", VA = "0x1863EFCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x63EFFD0", Offset = "0x63EEFD0", VA = "0x1863EFFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct MAEPGPOIJHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public DAFKLKGCOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x64000E0", Offset = "0x63FF0E0", VA = "0x1864000E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x6400330", Offset = "0x63FF330", VA = "0x186400330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly APINBDFMKOH OABBNEIEMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly APINBDFMKOH LIDGLMMOMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private readonly GDLDHDHGFLC DDFGMGKALFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly BEJLOLIKNEB AKJCABMNFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly ALHJLHAJGLA NLBMAMHEAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly HKPEMPOGMNP NBICBOLFEEK;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private LDIAGFCFIDA MGHFLABNEND
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x63F3060", Offset = "0x63F2060", VA = "0x1863F3060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event HPLCJCJIPEP JICANIJCLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x63F3640", Offset = "0x63F2640", VA = "0x1863F3640", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x63F3CB0", Offset = "0x63F2CB0", VA = "0x1863F3CB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x63F4370", Offset = "0x63F3370", VA = "0x1863F4370")]
	public DAFKLKGCOKJ(IGDBPFKILJO BALLFIJIOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x63F3FB0", Offset = "0x63F2FB0", VA = "0x1863F3FB0")]
	[AsyncStateMachine(typeof(DGNGCKPFFNA))]
	public Task OGIMJGKOIPA(CIFKNLJLNLO ICLPGCHCHFB, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x63F3D10", Offset = "0x63F2D10", VA = "0x1863F3D10")]
	[AsyncStateMachine(typeof(NALGOCAMLJG))]
	private Task<OCGKKEPIGGA> NKNPABHAAOA(CIFKNLJLNLO ICLPGCHCHFB, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x63F3810", Offset = "0x63F2810", VA = "0x1863F3810")]
	[AsyncStateMachine(typeof(CABNHMEJMOA))]
	private Task HPMGCOIGDJI(CIFKNLJLNLO ICLPGCHCHFB, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x63F2B50", Offset = "0x63F1B50", VA = "0x1863F2B50")]
	[AsyncStateMachine(typeof(INLNPCPPHHA))]
	private Task AFNPIMKLGLE(CIFKNLJLNLO ICLPGCHCHFB, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken DLMOACAJCDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x63F3BA0", Offset = "0x63F2BA0", VA = "0x1863F3BA0")]
	[AsyncStateMachine(typeof(IFBPHNBMFED))]
	private Task NCDHHFJCLFB(PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x63F3090", Offset = "0x63F2090", VA = "0x1863F3090")]
	[AsyncStateMachine(typeof(CMOFKIGHLAD))]
	private Task CBKKKODMHAH(LLGCMGAEGBM FCLEEDACIMH, LOMEGEHHEJF MEFHPJNCLKE, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x63F39B0", Offset = "0x63F29B0", VA = "0x1863F39B0")]
	[AsyncStateMachine(typeof(FMEPKDIBIBE))]
	private Task<HLMNMBBHFAH> LCKOLAMPPIK(LLGCMGAEGBM FCLEEDACIMH, GOJAADCHEHO HDLLKMICEGE, LOMEGEHHEJF MEFHPJNCLKE, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x63F41F0", Offset = "0x63F31F0", VA = "0x1863F41F0")]
	[AsyncStateMachine(typeof(PFIOHHJJEPL))]
	private Task<HLMNMBBHFAH> POPMDANPNMH(LLGCMGAEGBM FCLEEDACIMH, GOJAADCHEHO HDLLKMICEGE, LOMEGEHHEJF MEFHPJNCLKE, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x63F3370", Offset = "0x63F2370", VA = "0x1863F3370")]
	[AsyncStateMachine(typeof(OKCMBDIHNGF))]
	private Task<HLMNMBBHFAH> EFLKENIJGDM(HLMNMBBHFAH HPNEIHAOLGE, LLGCMGAEGBM EILDHIPOEJH, LOMEGEHHEJF MEFHPJNCLKE, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL, bool GJMONOHCNNM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x63F2F70", Offset = "0x63F1F70", VA = "0x1863F2F70")]
	private bool BHCGEMPLBIE(LLGCMGAEGBM HJPJFDOIGMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x63F31E0", Offset = "0x63F21E0", VA = "0x1863F31E0")]
	[AsyncStateMachine(typeof(PLFOOHNMADN))]
	protected Task<HLMNMBBHFAH> EBCAJCKELDL(LLGCMGAEGBM FCLEEDACIMH, GOJAADCHEHO HDLLKMICEGE, LOMEGEHHEJF MEFHPJNCLKE, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL, KPEEGGEOEMN FIDNBCIHPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x63F2C90", Offset = "0x63F1C90", VA = "0x1863F2C90")]
	[AsyncStateMachine(typeof(NMMKFBICOPJ))]
	private Task AKBEOAGKIKA(LLGCMGAEGBM FCLEEDACIMH, LOMEGEHHEJF MEFHPJNCLKE, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x63F3B10", Offset = "0x63F2B10", VA = "0x1863F3B10")]
	private void LJHAIGOIIBA(HLMNMBBHFAH ENHFFFFAGNC, LOMEGEHHEJF MEFHPJNCLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x63F3B60", Offset = "0x63F2B60", VA = "0x1863F3B60")]
	private void LLFJBFBPCLP(HLMNMBBHFAH HOIEGKDFOAH, [Out] HLMNMBBHFAH LGLFBOMGJNJ, [Out] HLMNMBBHFAH HOLINNJBLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x63F3CD0", Offset = "0x63F2CD0", VA = "0x1863F3CD0")]
	private Task<GKBLMJJHFGC> NFCCMBNFGHE(CIFKNLJLNLO ICLPGCHCHFB, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x63F2F30", Offset = "0x63F1F30", VA = "0x1863F2F30")]
	private Task<LLGCMGAEGBM> BEPGPKEODDA(GKBLMJJHFGC FCLEEDACIMH, IALLEOEJMID.BMNHCINNHOB KGGDGOKEOIC, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x63F2DE0", Offset = "0x63F1DE0", VA = "0x1863F2DE0")]
	[AsyncStateMachine(typeof(AFNIOLEPDOB))]
	private Task BEFNPLPPFJD(LLGCMGAEGBM FCLEEDACIMH, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL, bool FOKIGFHIOEO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x63F4100", Offset = "0x63F3100", VA = "0x1863F4100")]
	[AsyncStateMachine(typeof(MAEPGPOIJHN))]
	private Task OLENKOPGFBF(LLGCMGAEGBM FCLEEDACIMH, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x63F3660", Offset = "0x63F2660", VA = "0x1863F3660")]
	private Task GBBCHIKFLGA(LLGCMGAEGBM FCLEEDACIMH, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x63F3950", Offset = "0x63F2950", VA = "0x1863F3950")]
	private Task IEOJJMBBAEL(LLGCMGAEGBM FCLEEDACIMH, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x63F3970", Offset = "0x63F2970", VA = "0x1863F3970")]
	private Task ILFNGIPJIDP(LLGCMGAEGBM FCLEEDACIMH, GOJAADCHEHO HDLLKMICEGE, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x63F34F0", Offset = "0x63F24F0", VA = "0x1863F34F0")]
	private Task EIEKKANHJDG(LLGCMGAEGBM FCLEEDACIMH, GOJAADCHEHO HDLLKMICEGE, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x63EFBE0", Offset = "0x63EEBE0", VA = "0x1863EFBE0")]
	private static Task FDIMEKANMLK(CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x63F37F0", Offset = "0x63F27F0", VA = "0x1863F37F0")]
	private Task HMLNLLMGGDH(LLGCMGAEGBM FCLEEDACIMH, GOJAADCHEHO HDLLKMICEGE, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x63F3E70", Offset = "0x63F2E70", VA = "0x1863F3E70")]
	private Task NOPJAOJDKPI(LLGCMGAEGBM FCLEEDACIMH, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x63F37A0", Offset = "0x63F27A0", VA = "0x1863F37A0")]
	private void HDEPHAJOFNH(CIFKNLJLNLO ICLPGCHCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x63F3990", Offset = "0x63F2990", VA = "0x1863F3990")]
	public void KILIOFEIGDH(long BEMMFIIOINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
	private static void FPGIEIHAGEJ(MCEIHIBECAG JOHECMNIEAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct BAEKBNLMALL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private LLGCMGAEGBM FCLEEDACIMH;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private AJNHNKMBAPI DAKHMKMAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x63F18C0", Offset = "0x63F08C0", VA = "0x1863F18C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x63F17E0", Offset = "0x63F07E0", VA = "0x1863F17E0")]
	public static Task LODICMNCPHB(LDIAGFCFIDA MFKBBJFDJHI, LLGCMGAEGBM FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x63F15E0", Offset = "0x63F05E0", VA = "0x1863F15E0")]
	private void LODICMNCPHB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct ADGONCEKJAM
{
	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x63EFBE0", Offset = "0x63EEBE0", VA = "0x1863EFBE0")]
	public static Task LODICMNCPHB(CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct HDLLANAKOLG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct JIKPLKOEHFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public IGDBPFKILJO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x63FCA70", Offset = "0x63FBA70", VA = "0x1863FCA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x63FCFD0", Offset = "0x63FBFD0", VA = "0x1863FCFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x63F9050", Offset = "0x63F8050", VA = "0x1863F9050")]
	[AsyncStateMachine(typeof(JIKPLKOEHFP))]
	public static Task LODICMNCPHB(IGDBPFKILJO BALLFIJIOCA, LLGCMGAEGBM FCLEEDACIMH, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct AMGOGFJJOKD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct OHGEKCLCBPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public IGDBPFKILJO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public GOJAADCHEHO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private HLMNMBBHFAH <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private LDIAGFCFIDA <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private AJNHNKMBAPI <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private IDisposable <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private List<(PersistenceView, GNLAKLLEMDG)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private GNLAKLLEMDG <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x64034C0", Offset = "0x64024C0", VA = "0x1864034C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x6404160", Offset = "0x6403160", VA = "0x186404160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x63F1490", Offset = "0x63F0490", VA = "0x1863F1490")]
	[AsyncStateMachine(typeof(OHGEKCLCBPB))]
	public static Task LODICMNCPHB(IGDBPFKILJO BALLFIJIOCA, LLGCMGAEGBM FCLEEDACIMH, GOJAADCHEHO HDLLKMICEGE, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x63F1290", Offset = "0x63F0290", VA = "0x1863F1290")]
	private static void LBCMMHNLAME(PersistenceView GCCDJCPNBME, GNLAKLLEMDG FGNJDLEPFIE, LLGCMGAEGBM FCLEEDACIMH, HLMNMBBHFAH HPNEIHAOLGE, bool GCHBIFIPMCE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct LDKBNIEDODK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct FKNJLJIGLDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public LDIAGFCFIDA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x63F61A0", Offset = "0x63F51A0", VA = "0x1863F61A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x63F65E0", Offset = "0x63F55E0", VA = "0x1863F65E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x63FF4C0", Offset = "0x63FE4C0", VA = "0x1863FF4C0")]
	[AsyncStateMachine(typeof(FKNJLJIGLDE))]
	public static Task LODICMNCPHB(LDIAGFCFIDA MFKBBJFDJHI, LLGCMGAEGBM FCLEEDACIMH, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct HCDBFFNLGJE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct NJCDBOMKOLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public LDIAGFCFIDA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public IGDBPFKILJO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x6401DC0", Offset = "0x6400DC0", VA = "0x186401DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x6401FD0", Offset = "0x6400FD0", VA = "0x186401FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class DHPBLFLJAFD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013D")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public DHPBLFLJAFD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x6409420", Offset = "0x6408420", VA = "0x186409420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x64097B0", Offset = "0x64087B0", VA = "0x1864097B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public DHPBLFLJAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x63F56F0", Offset = "0x63F46F0", VA = "0x1863F56F0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task NODLLIEAOEE(PFLLCKOMFGL<string>.FEFFPGFLENA timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct MHIOMPCANGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public HCDBFFNLGJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private TaskAwaiter<OCGKKEPIGGA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6400AA0", Offset = "0x63FFAA0", VA = "0x186400AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6401450", Offset = "0x6400450", VA = "0x186401450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class NJAPDMDJAIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public HGLNEIGIEKC version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public NJAPDMDJAIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6401CE0", Offset = "0x6400CE0", VA = "0x186401CE0")]
		internal object MBCMDGFNCMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6401C30", Offset = "0x6400C30", VA = "0x186401C30")]
		internal object DKBNNOEEDBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private LLGCMGAEGBM FCLEEDACIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private IGDBPFKILJO BALLFIJIOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private bool FOKIGFHIOEO;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private static readonly ByteString HKKHLBJAAJE;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private AJNHNKMBAPI DAKHMKMAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x63F8230", Offset = "0x63F7230", VA = "0x1863F8230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private JPJCLLNFHEO EFLFLLHFENI
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x63F7EC0", Offset = "0x63F6EC0", VA = "0x1863F7EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x63F80E0", Offset = "0x63F70E0", VA = "0x1863F80E0")]
	[AsyncStateMachine(typeof(NJCDBOMKOLP))]
	public static Task LODICMNCPHB(LDIAGFCFIDA MFKBBJFDJHI, LLGCMGAEGBM FCLEEDACIMH, IGDBPFKILJO BALLFIJIOCA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL, bool FOKIGFHIOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x63F7FA0", Offset = "0x63F6FA0", VA = "0x1863F7FA0")]
	[AsyncStateMachine(typeof(MHIOMPCANGA))]
	private Task LODICMNCPHB(PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x63F8280", Offset = "0x63F7280", VA = "0x1863F8280")]
	private void PGGPANINHCI([NotNull] LNIMNABFGFK BDFKGNFLBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x63F7F60", Offset = "0x63F6F60", VA = "0x1863F7F60")]
	private bool HCHCLKGFGJD(HGLNEIGIEKC CEJKGGNMCNG, LNIMNABFGFK BDFKGNFLBBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct HCJDJMDOHHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct KFOKKMBBMKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public AsyncTaskMethodBuilder<LLGCMGAEGBM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public HCJDJMDOHHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public IALLEOEJMID.BMNHCINNHOB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private TaskAwaiter<(CJDJPCEAKND<LDHMDLHGPJM, PKPFPNLKHDF>, CJDJPCEAKND<CJDGGCFLJMM<LNIMNABFGFK>, PKPFPNLKHDF>, CJDJPCEAKND<CJDGGCFLJMM<CEHDOMGLFNK>, PKPFPNLKHDF>, CJDJPCEAKND<CJDGGCFLJMM<JBPPNCKAHCO>, PKPFPNLKHDF>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x63FD9B0", Offset = "0x63FC9B0", VA = "0x1863FD9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x63FE3A0", Offset = "0x63FD3A0", VA = "0x1863FE3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct BJKLCLDNCGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public AsyncTaskMethodBuilder<CJDJPCEAKND<LDHMDLHGPJM, PKPFPNLKHDF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public HCJDJMDOHHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public IALLEOEJMID.BMNHCINNHOB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private TaskAwaiter<CJDJPCEAKND<LDHMDLHGPJM, PKPFPNLKHDF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x640E210", Offset = "0x640D210", VA = "0x18640E210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x640E800", Offset = "0x640D800", VA = "0x18640E800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private LPPGJIPGMFM<AEBNJGMIDFC, CEHDOMGLFNK> EKAPELMPEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private LPPGJIPGMFM<AEBNJGMIDFC, LNIMNABFGFK> LBCBNPBHFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private LPPGJIPGMFM<long, JBPPNCKAHCO> CDEGNMPKODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private AHGNBMCPLNJ NMPKDJKCMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private MCEIHIBECAG JOHECMNIEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private PNEBNDCHIFA EPBJFAJJFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private string HHGIIFONOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private AEBNJGMIDFC FBEOJJGECFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private AEBNJGMIDFC DFPGBDADMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private long BEMMFIIOINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB;

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x63F89B0", Offset = "0x63F79B0", VA = "0x1863F89B0")]
	public static Task<LLGCMGAEGBM> BNGCKMHIBCE(LDIAGFCFIDA MFKBBJFDJHI, [In] GKBLMJJHFGC FCLEEDACIMH, IALLEOEJMID.BMNHCINNHOB KGGDGOKEOIC, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x63F8ED0", Offset = "0x63F7ED0", VA = "0x1863F8ED0")]
	[AsyncStateMachine(typeof(KFOKKMBBMKC))]
	private Task<LLGCMGAEGBM> LODICMNCPHB(IALLEOEJMID.BMNHCINNHOB KGGDGOKEOIC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x63F8D20", Offset = "0x63F7D20", VA = "0x1863F8D20")]
	[AsyncStateMachine(typeof(BJKLCLDNCGJ))]
	private Task<CJDJPCEAKND<LDHMDLHGPJM, PKPFPNLKHDF>> HBIFKFNOPLJ(string HHGIIFONOJM, long BEMMFIIOINO, IALLEOEJMID.BMNHCINNHOB KGGDGOKEOIC, PFLLCKOMFGL<string>.FEFFPGFLENA NHFLLHCECEE, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct AKLGGNEMMFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct AMHDJNAJBAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public AsyncTaskMethodBuilder<GKBLMJJHFGC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AKLGGNEMMFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private TaskAwaiter<GKBLMJJHFGC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x640BB70", Offset = "0x640AB70", VA = "0x18640BB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x640BF70", Offset = "0x640AF70", VA = "0x18640BF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct FDEHLFFBLDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public AsyncTaskMethodBuilder<GKBLMJJHFGC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public AKLGGNEMMFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<GKBLMJJHFGC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x6411520", Offset = "0x6410520", VA = "0x186411520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x6411920", Offset = "0x6410920", VA = "0x186411920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class ONHPNFPHFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public ONHPNFPHFJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x1394FF0", Offset = "0x1393FF0", VA = "0x181394FF0")]
		internal bool DBNPMAHJLEM(PNEBNDCHIFA sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct MLIEFMDNPPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder<GKBLMJJHFGC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public AEBNJGMIDFC superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AJNHNKMBAPI callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private ONHPNFPHFJH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private MCEIHIBECAG <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private PNEBNDCHIFA <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private AEBNJGMIDFC <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private AEBNJGMIDFC <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private TaskAwaiter<MCEIHIBECAG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private TaskAwaiter<BPIJMECGCAC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private TaskAwaiter<GNBPKJBLPKB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x641AF50", Offset = "0x6419F50", VA = "0x18641AF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x641BFF0", Offset = "0x641AFF0", VA = "0x18641BFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private AJNHNKMBAPI ICCKKADELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private GDLDHDHGFLC DDFGMGKALFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private long KAOIBEOBDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private long HIFDDDODBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private long PDGMCGEBKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private string DFPKFFBPELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private AEBNJGMIDFC ABOGDFICANG;

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x640B0F0", Offset = "0x640A0F0", VA = "0x18640B0F0")]
	public static Task<GKBLMJJHFGC> BNGCKMHIBCE(LDIAGFCFIDA MFKBBJFDJHI, CIFKNLJLNLO ICLPGCHCHFB, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x640B3A0", Offset = "0x640A3A0", VA = "0x18640B3A0")]
	[AsyncStateMachine(typeof(AMHDJNAJBAN))]
	private Task<GKBLMJJHFGC> LODICMNCPHB(CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x640B680", Offset = "0x640A680", VA = "0x18640B680")]
	[AsyncStateMachine(typeof(FDEHLFFBLDA))]
	private Task<GKBLMJJHFGC> NFCCMBNFGHE(PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x640B4F0", Offset = "0x640A4F0", VA = "0x18640B4F0")]
	[AsyncStateMachine(typeof(MLIEFMDNPPJ))]
	private static Task<GKBLMJJHFGC> NFCCMBNFGHE(AJNHNKMBAPI ICCKKADELMP, long KAOIBEOBDCN, long HIFDDDODBFK, long PDGMCGEBKOO, string DFPKFFBPELK, AEBNJGMIDFC ABOGDFICANG, CancellationToken JEBPNJAPHEL, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x640B370", Offset = "0x640A370", VA = "0x18640B370")]
	private void HGLGCFMINFO(MCEIHIBECAG JOHECMNIEAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct DOJJJLLHKCG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct CDLLNCKBBNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public DOJJJLLHKCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x640E8F0", Offset = "0x640D8F0", VA = "0x18640E8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x640EE80", Offset = "0x640DE80", VA = "0x18640EE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private AJNHNKMBAPI ICCKKADELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private LLGCMGAEGBM FCLEEDACIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private float FJCCIHGINLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private float CJLGPHDHGAN;

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x64106A0", Offset = "0x640F6A0", VA = "0x1864106A0")]
	public static Task PPDKABPJJGM(LDIAGFCFIDA MFKBBJFDJHI, LLGCMGAEGBM FCLEEDACIMH, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x64104C0", Offset = "0x640F4C0", VA = "0x1864104C0")]
	[AsyncStateMachine(typeof(CDLLNCKBBNG))]
	public Task LODICMNCPHB(CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6410220", Offset = "0x640F220", VA = "0x186410220")]
	private static void JKFAFJFPIFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6410360", Offset = "0x640F360", VA = "0x186410360")]
	private void JMCOCNAELHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x64105E0", Offset = "0x640F5E0", VA = "0x1864105E0")]
	private static float NNKEAMLHFCJ(AJNHNKMBAPI ICCKKADELMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x6410200", Offset = "0x640F200", VA = "0x186410200")]
	private static float FGDEEMFMBDD()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct PBMOJBLBHAI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct HIIPIEGOEMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public IGDBPFKILJO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private KNNODDOINJP <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private LDIAGFCFIDA <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private DGEPKMMEOPK.MFPLKBIHEKC <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private TaskAwaiter<OCGKKEPIGGA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x64156B0", Offset = "0x64146B0", VA = "0x1864156B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x64160A0", Offset = "0x64150A0", VA = "0x1864160A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct MGGBOFJJKFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x641AB40", Offset = "0x6419B40", VA = "0x18641AB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x641AE70", Offset = "0x6419E70", VA = "0x18641AE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x64215F0", Offset = "0x64205F0", VA = "0x1864215F0")]
	[AsyncStateMachine(typeof(HIIPIEGOEMM))]
	public static Task LODICMNCPHB(IGDBPFKILJO BALLFIJIOCA, LLGCMGAEGBM FCLEEDACIMH, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x64214D0", Offset = "0x64204D0", VA = "0x1864214D0")]
	private static Task<OCGKKEPIGGA> FABPGCOBHEP(IGDBPFKILJO BALLFIJIOCA, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x6421540", Offset = "0x6420540", VA = "0x186421540")]
	[AsyncStateMachine(typeof(MGGBOFJJKFE))]
	private static Task LNLMLLNBGFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct DABGNGFJGEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct KGKDHAABGMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public DABGNGFJGEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x6418390", Offset = "0x6417390", VA = "0x186418390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x6418A40", Offset = "0x6417A40", VA = "0x186418A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class MKEIIPOKNNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public MKEIIPOKNNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x641AED0", Offset = "0x6419ED0", VA = "0x18641AED0")]
		internal object IKDHOGKDGOJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct IHHCHOEEDGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public DABGNGFJGEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private AGLLPDPKGAO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x6416A30", Offset = "0x6415A30", VA = "0x186416A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x6417040", Offset = "0x6416040", VA = "0x186417040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private bool HGNKDGKDOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private CancellationToken JEBPNJAPHEL;

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x640F580", Offset = "0x640E580", VA = "0x18640F580")]
	public static Task LNNJHDADHME(LDIAGFCFIDA MFKBBJFDJHI, bool HGNKDGKDOCO, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken PCMKIHEDCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x640F5F0", Offset = "0x640E5F0", VA = "0x18640F5F0")]
	[AsyncStateMachine(typeof(KGKDHAABGMA))]
	private Task LODICMNCPHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x640F450", Offset = "0x640E450", VA = "0x18640F450")]
	[AsyncStateMachine(typeof(IHHCHOEEDGG))]
	private Task GGDAELGCDCN(bool LALBJKCONEN, string PHMJOCAELEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0")]
	private bool CNDJKCPEBPD(bool HGNKDGKDOCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal struct FGNJOPIAOIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct OAPMHGFHNHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public FGNJOPIAOIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x6420570", Offset = "0x641F570", VA = "0x186420570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x6420AE0", Offset = "0x641FAE0", VA = "0x186420AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class LNNIIBIHPGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public LNNIIBIHPGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x641A6B0", Offset = "0x64196B0", VA = "0x18641A6B0")]
		internal object IKDHOGKDGOJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct PBDFDAGFMDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public FGNJOPIAOIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private AGLLPDPKGAO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x6420E80", Offset = "0x641FE80", VA = "0x186420E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6421460", Offset = "0x6420460", VA = "0x186421460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	private IJLDJNNJNOK BLHMKEHOHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400057F")]
	private PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000580")]
	private LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private bool EPGHLJHFHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private LLGCMGAEGBM FCLEEDACIMH;

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6412500", Offset = "0x6411500", VA = "0x186412500")]
	public static Task<Scene> POICDCHAHJN(LDIAGFCFIDA MFKBBJFDJHI, IJLDJNNJNOK NJEFGAMDCKB, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x6412340", Offset = "0x6411340", VA = "0x186412340")]
	[AsyncStateMachine(typeof(OAPMHGFHNHM))]
	private Task<Scene> LODICMNCPHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x6412460", Offset = "0x6411460", VA = "0x186412460")]
	private bool OIDNBJDGOAG(LLGCMGAEGBM FCLEEDACIMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x6412490", Offset = "0x6411490", VA = "0x186412490")]
	private void PLKCCFGLEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x64121F0", Offset = "0x64111F0", VA = "0x1864121F0")]
	[AsyncStateMachine(typeof(PBDFDAGFMDN))]
	private Task<Scene> GGDAELGCDCN(string PHMJOCAELEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct ALHJLHAJGLA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct JMEMCGEBMID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public AsyncTaskMethodBuilder<HLMNMBBHFAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public ALHJLHAJGLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public HLMNMBBHFAH nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public LLGCMGAEGBM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private TaskAwaiter<HLMNMBBHFAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x64177A0", Offset = "0x64167A0", VA = "0x1864177A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x6418280", Offset = "0x6417280", VA = "0x186418280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct PDGHECAGJKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public AsyncTaskMethodBuilder<HLMNMBBHFAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public ALHJLHAJGLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public HLMNMBBHFAH state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter<OCGKKEPIGGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x6421730", Offset = "0x6420730", VA = "0x186421730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x6421A10", Offset = "0x6420A10", VA = "0x186421A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private readonly IGDBPFKILJO BALLFIJIOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private readonly GDLDHDHGFLC DDFGMGKALFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private readonly BEJLOLIKNEB AKJCABMNFBI;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private KNNODDOINJP BIBKPBNONAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x4D445E0", Offset = "0x4D435E0", VA = "0x184D445E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x640BB10", Offset = "0x640AB10", VA = "0x18640BB10")]
	public ALHJLHAJGLA(IGDBPFKILJO BALLFIJIOCA, GDLDHDHGFLC DDFGMGKALFA, BEJLOLIKNEB AKJCABMNFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x640B7E0", Offset = "0x640A7E0", VA = "0x18640B7E0")]
	[AsyncStateMachine(typeof(JMEMCGEBMID))]
	public Task<HLMNMBBHFAH> ALNFKPPLJPG(HLMNMBBHFAH LIBJNEMKOFO, LLGCMGAEGBM EILDHIPOEJH, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL, bool GJMONOHCNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x640B990", Offset = "0x640A990", VA = "0x18640B990")]
	[AsyncStateMachine(typeof(PDGHECAGJKJ))]
	private Task<HLMNMBBHFAH> HAOHOJMGELB(PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, HLMNMBBHFAH LDGNDDODOCD, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x640B960", Offset = "0x640A960", VA = "0x18640B960")]
	private bool GKEGCJBOEHH(HLMNMBBHFAH POAANNELOAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x640BAF0", Offset = "0x640AAF0", VA = "0x18640BAF0")]
	private void PAOJJBFOCDP(string IECBPCEAHOG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct AEPPCOKKEKA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct PKENCPHFEKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public KNNODDOINJP operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public GOJAADCHEHO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private List<(PersistenceView, GNLAKLLEMDG)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private (PersistenceView, GNLAKLLEMDG) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6421C90", Offset = "0x6420C90", VA = "0x186421C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x64222D0", Offset = "0x64212D0", VA = "0x1864222D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x640AFB0", Offset = "0x6409FB0", VA = "0x18640AFB0")]
	[AsyncStateMachine(typeof(PKENCPHFEKN))]
	public static Task LODICMNCPHB(KNNODDOINJP ILJNJNIMKOM, LLGCMGAEGBM FCLEEDACIMH, GOJAADCHEHO HDLLKMICEGE, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct INBEOIIGDAI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct HOBAKHCCMDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public KNNODDOINJP operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public GOJAADCHEHO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private HGLNEIGIEKC <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private List<(PersistenceView, GNLAKLLEMDG)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private GNLAKLLEMDG <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x6416100", Offset = "0x6415100", VA = "0x186416100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x6416960", Offset = "0x6415960", VA = "0x186416960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x64170A0", Offset = "0x64160A0", VA = "0x1864170A0")]
	[AsyncStateMachine(typeof(HOBAKHCCMDA))]
	public static Task LODICMNCPHB(KNNODDOINJP ILJNJNIMKOM, LLGCMGAEGBM FCLEEDACIMH, GOJAADCHEHO HDLLKMICEGE, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct DGEPKMMEOPK
{
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	public struct MFPLKBIHEKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public List<EJMELBHFMJA> GJPGKFBBONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public List<GNLAKLLEMDG> CLNGKOAKINN;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x7F7E80", Offset = "0x7F6E80", VA = "0x1807F7E80")]
		public MFPLKBIHEKC(List<EJMELBHFMJA> GJPGKFBBONG, List<GNLAKLLEMDG> CLNGKOAKINN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class CDGDDLFFAMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public IEnumerable<EJMELBHFMJA> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public CDGDDLFFAMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x640E870", Offset = "0x640D870", VA = "0x18640E870")]
		internal object OKKCHANNHPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private LDIAGFCFIDA MFKBBJFDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private LLGCMGAEGBM FCLEEDACIMH;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private AJNHNKMBAPI DAKHMKMAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x64101B0", Offset = "0x640F1B0", VA = "0x1864101B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x6410150", Offset = "0x640F150", VA = "0x186410150")]
	public static MFPLKBIHEKC LODICMNCPHB(LDIAGFCFIDA MFKBBJFDJHI, LLGCMGAEGBM FCLEEDACIMH)
	{
		return default(MFPLKBIHEKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x640FEF0", Offset = "0x640EEF0", VA = "0x18640FEF0")]
	private MFPLKBIHEKC LODICMNCPHB()
	{
		return default(MFPLKBIHEKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x640F770", Offset = "0x640E770", VA = "0x18640F770")]
	private MFPLKBIHEKC FENHMBDPPMJ(LNIMNABFGFK BDFKGNFLBBP, HGLNEIGIEKC PGJLFNBDKMM)
	{
		return default(MFPLKBIHEKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x640FD20", Offset = "0x640ED20", VA = "0x18640FD20")]
	private bool HABPNCNJGCP(IEnumerable<EJMELBHFMJA> GJPGKFBBONG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct LIILMMBMJCA
{
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class KHILCFOLGAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public DGEPKMMEOPK.MFPLKBIHEKC instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public KHILCFOLGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x6418AA0", Offset = "0x6417AA0", VA = "0x186418AA0")]
		internal object NODLLIEAOEE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class DEJKHFKBCHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public DEJKHFKBCHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x640F6E0", Offset = "0x640E6E0", VA = "0x18640F6E0")]
		internal object LNNIHIJAJOF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x641A100", Offset = "0x6419100", VA = "0x18641A100")]
	public static void LODICMNCPHB(KNNODDOINJP ILJNJNIMKOM, LLGCMGAEGBM FCLEEDACIMH, DGEPKMMEOPK.MFPLKBIHEKC JACEIIKMKOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal class BEJLOLIKNEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct ACICELBPJOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public BEJLOLIKNEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public HLMNMBBHFAH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public LLGCMGAEGBM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x640A7E0", Offset = "0x64097E0", VA = "0x18640A7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x640AF50", Offset = "0x6409F50", VA = "0x18640AF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private sealed class JAFDICANILF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000166")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			public JAFDICANILF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x64229F0", Offset = "0x64219F0", VA = "0x1864229F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x6422CB0", Offset = "0x6421CB0", VA = "0x186422CB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public BEJLOLIKNEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public JAFDICANILF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x64171E0", Offset = "0x64161E0", VA = "0x1864171E0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task HFJLEAMKMPM(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct BCEHNIKAKKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public BEJLOLIKNEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private JAFDICANILF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x640C470", Offset = "0x640B470", VA = "0x18640C470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x640C9A0", Offset = "0x640B9A0", VA = "0x18640C9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct NACNNMIHJBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public BEJLOLIKNEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private Dictionary<Guid, List<LEDADMDAMKM>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x641DA00", Offset = "0x641CA00", VA = "0x18641DA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x641DFB0", Offset = "0x641CFB0", VA = "0x18641DFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct LBIBCAKDLOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public BEJLOLIKNEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private Dictionary<Guid, List<LEDADMDAMKM>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x64191E0", Offset = "0x64181E0", VA = "0x1864191E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x6419860", Offset = "0x6418860", VA = "0x186419860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class NFKOBKABHIJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005FA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005FB")]
			public LEDADMDAMKM handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			public NFKOBKABHIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x64227F0", Offset = "0x64217F0", VA = "0x1864227F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x6422990", Offset = "0x6421990", VA = "0x186422990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public EFICDJENMBF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public List<LEDADMDAMKM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public NFKOBKABHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x641E230", Offset = "0x641D230", VA = "0x18641E230")]
		internal object DOFFPCDHKJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x641E140", Offset = "0x641D140", VA = "0x18641E140")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task COKLIKDPDAJ(LEDADMDAMKM handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x641E320", Offset = "0x641D320", VA = "0x18641E320")]
		internal object DPIIFKBABAL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct MOMIFJPGGPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public EFICDJENMBF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public List<LEDADMDAMKM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private NFKOBKABHIJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x641D4D0", Offset = "0x641C4D0", VA = "0x18641D4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x641D9A0", Offset = "0x641C9A0", VA = "0x18641D9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct NLCKLPLHEBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public BEJLOLIKNEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x641E550", Offset = "0x641D550", VA = "0x18641E550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x641EB00", Offset = "0x641DB00", VA = "0x18641EB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class HPCCDCAFLBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public HPCCDCAFLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x64169C0", Offset = "0x64159C0", VA = "0x1864169C0")]
		internal object KEBMCKCDFJH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct CIMJKFLAHAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public BEJLOLIKNEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public LLGCMGAEGBM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x640EEE0", Offset = "0x640DEE0", VA = "0x18640EEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x640F3F0", Offset = "0x640E3F0", VA = "0x18640F3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class EPLDPDFJGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public EPLDPDFJGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x64114B0", Offset = "0x64104B0", VA = "0x1864114B0")]
		internal object LIFCKMKNJHJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct GHGCDFMBKHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public BEJLOLIKNEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private TaskAwaiter<OCGKKEPIGGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x6414A90", Offset = "0x6413A90", VA = "0x186414A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x6415110", Offset = "0x6414110", VA = "0x186415110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class MCCNADPOAOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public MCCNADPOAOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x641AAD0", Offset = "0x6419AD0", VA = "0x18641AAD0")]
		internal object FPOPBNDLHFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private readonly IGDBPFKILJO BALLFIJIOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private GGHEFABFJCG AKJCABMNFBI;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private KNNODDOINJP BIBKPBNONAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xF4C840", Offset = "0xF4B840", VA = "0x180F4C840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	public BEJLOLIKNEB(IGDBPFKILJO BALLFIJIOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x640DD00", Offset = "0x640CD00", VA = "0x18640DD00")]
	[AsyncStateMachine(typeof(ACICELBPJOM))]
	public Task LODICMNCPHB(HLMNMBBHFAH HPNEIHAOLGE, LLGCMGAEGBM EILDHIPOEJH, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x640D8E0", Offset = "0x640C8E0", VA = "0x18640D8E0")]
	[AsyncStateMachine(typeof(BCEHNIKAKKK))]
	private Task KJOCMHKHLOI(LLGCMGAEGBM FCLEEDACIMH, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x640DF90", Offset = "0x640CF90", VA = "0x18640DF90")]
	[AsyncStateMachine(typeof(NACNNMIHJBG))]
	private Task OAPPJDENCGM(LLGCMGAEGBM FCLEEDACIMH, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x640DE50", Offset = "0x640CE50", VA = "0x18640DE50")]
	[AsyncStateMachine(typeof(LBIBCAKDLOD))]
	private Task MPLMKKPKCDC(LLGCMGAEGBM FCLEEDACIMH, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x640DBB0", Offset = "0x640CBB0", VA = "0x18640DBB0")]
	[AsyncStateMachine(typeof(MOMIFJPGGPM))]
	private Task LMJJLIPDHNH(Guid KHJBHDDJLFG, List<LEDADMDAMKM> BJKCEMNNJBB, EFICDJENMBF PEFHNNALGPG, LLGCMGAEGBM FCLEEDACIMH, CancellationToken PDIBILKHEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x640D3D0", Offset = "0x640C3D0", VA = "0x18640D3D0")]
	[AsyncStateMachine(typeof(NLCKLPLHEBC))]
	private Task DDPLEKMOAMJ(LLGCMGAEGBM FCLEEDACIMH, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x640D5C0", Offset = "0x640C5C0", VA = "0x18640D5C0")]
	[AsyncStateMachine(typeof(CIMJKFLAHAK))]
	private Task GPEGHDMAJAJ(Guid PMOPAJODJOF, LLGCMGAEGBM FCLEEDACIMH, PFLLCKOMFGL<string>.FEFFPGFLENA HCMHKMALPLB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x640E0D0", Offset = "0x640D0D0", VA = "0x18640E0D0")]
	[AsyncStateMachine(typeof(GHGCDFMBKHO))]
	private Task OCCILKJBJPK(Guid PMOPAJODJOF, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x640D2B0", Offset = "0x640C2B0", VA = "0x18640D2B0")]
	private void AIKKGKMDJJD(Guid PMOPAJODJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x640D510", Offset = "0x640C510", VA = "0x18640D510")]
	private void FCKKMLLGMCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x640DA20", Offset = "0x640CA20", VA = "0x18640DA20")]
	public Guid LCCDMJIDEFC(HLMNMBBHFAH ENHFFFFAGNC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x640D700", Offset = "0x640C700", VA = "0x18640D700")]
	[CompilerGenerated]
	private object INMGJFNCMHN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public readonly struct DKIOIIGJIDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	public readonly bool NBDFNPIOOIK;

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0xBAF9F0", Offset = "0xBAE9F0", VA = "0x180BAF9F0")]
	public DKIOIIGJIDP(bool ABPDKAKPPBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public readonly struct NKNGHGMAJIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000626")]
	public readonly LNIMNABFGFK? AJCDEAPPHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000627")]
	public readonly MNPDEFHCJKK LPLLNJGGIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	public readonly string? JHCIBMLHIJK;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public IReadOnlyCollection<string> FFDCHHHFMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x641E410", Offset = "0x641D410", VA = "0x18641E410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public IReadOnlyDictionary<long, int> BJIDGCIOIJA
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x641E430", Offset = "0x641D430", VA = "0x18641E430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x641E450", Offset = "0x641D450", VA = "0x18641E450")]
	public NKNGHGMAJIA(LNIMNABFGFK? EINEAGMJDPE, MNPDEFHCJKK FDMEHEPPFJK, string? HHGIIFONOJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal class NLPLMFCFCMK : JPCHIBFEFIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct FJCHMPMKMLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public AsyncTaskMethodBuilder<NKNGHGMAJIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public NLPLMFCFCMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public GIFIJHKEGCI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public KEDEFKCBACM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x6412580", Offset = "0x6411580", VA = "0x186412580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x6412C20", Offset = "0x6411C20", VA = "0x186412C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class FMDMBDKNBNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public GIFIJHKEGCI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public NLPLMFCFCMK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FMDMBDKNBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x6412C90", Offset = "0x6411C90", VA = "0x186412C90")]
		internal Task KLJKAABDJAK(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x6412EB0", Offset = "0x6411EB0", VA = "0x186412EB0")]
		internal Task LLDNAGCOCPJ(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class JFIAMLKDKBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public FMDMBDKNBNL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public JFIAMLKDKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x6417310", Offset = "0x6416310", VA = "0x186417310")]
		internal object MICEJHECKNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class JEJPPGJFOHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public FMDMBDKNBNL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public JEJPPGJFOHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x64172D0", Offset = "0x64162D0", VA = "0x1864172D0")]
		internal Task FFLMBOPJPCC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct NPFKBAOBNKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public GIFIJHKEGCI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public NLPLMFCFCMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private JFIAMLKDKBE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x641FC50", Offset = "0x641EC50", VA = "0x18641FC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x6420510", Offset = "0x641F510", VA = "0x186420510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	private readonly IMFBLHALHMN DJHKLFMABMI;

	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private static readonly TimeSpan ABBIAEGKNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private readonly FCBOKDDFNMF PAFLLINHOOK;

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x641FC00", Offset = "0x641EC00", VA = "0x18641FC00")]
	public NLPLMFCFCMK(IGDBPFKILJO BALLFIJIOCA, FCBOKDDFNMF PAFLLINHOOK, IMFBLHALHMN DJHKLFMABMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x641F560", Offset = "0x641E560", VA = "0x18641F560")]
	[AsyncStateMachine(typeof(FJCHMPMKMLO))]
	public Task<NKNGHGMAJIA> KJONJHMMAMK(long HIFDDDODBFK, KEDEFKCBACM JALECPCCGGE, GIFIJHKEGCI NEHHMEJGJEP, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x641EB60", Offset = "0x641DB60", VA = "0x18641EB60")]
	[AsyncStateMachine(typeof(NPFKBAOBNKB))]
	private Task AFKJPEPIFEH(GIFIJHKEGCI NEHHMEJGJEP, IEnumerable<PersistenceView> AFPFNPCPEKO, StringBuilder FABMJMCEFAP, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x641EE70", Offset = "0x641DE70", VA = "0x18641EE70")]
	private NKNGHGMAJIA GHONDLCJIEM(long HIFDDDODBFK, KEDEFKCBACM JALECPCCGGE, GIFIJHKEGCI NEHHMEJGJEP, IEnumerable<PersistenceView> AFPFNPCPEKO, StringBuilder FABMJMCEFAP)
	{
		return default(NKNGHGMAJIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x641ECB0", Offset = "0x641DCB0", VA = "0x18641ECB0")]
	private LNIMNABFGFK GBMNALIMGMN(long HIFDDDODBFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x641F310", Offset = "0x641E310", VA = "0x18641F310")]
	private void KACOELKACBL(LNIMNABFGFK NLDBDOPEINB, StringBuilder FABMJMCEFAP, IEnumerable<PersistenceView> AFPFNPCPEKO, [In] ONJCJHIAIPL CMCBDBKNKFJ, PDOHHCFENIE PPHLDLFCCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x641F6C0", Offset = "0x641E6C0", VA = "0x18641F6C0")]
	private void KMILMHMFDPH(LNIMNABFGFK NLDBDOPEINB, StringBuilder FABMJMCEFAP, PersistenceView GCCDJCPNBME, PDOHHCFENIE PPHLDLFCCII, [In] ONJCJHIAIPL CMCBDBKNKFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class LIDMKBOKAGM : JPCHIBFEFIF
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class LNOKJEIGGEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public PLGFLNIIODP.APLABLPHDMJ roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public LNOKJEIGGEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x641A700", Offset = "0x6419700", VA = "0x18641A700")]
		internal object NOGHGJACBFI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct BDCHGHKGPKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public AsyncTaskMethodBuilder<(PLGFLNIIODP.APLABLPHDMJ roomDataUpload, PLGFLNIIODP.APLABLPHDMJ subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public NKNGHGMAJIA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public LIDMKBOKAGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private LNOKJEIGGEC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private TaskAwaiter<PLGFLNIIODP.APLABLPHDMJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x640CA00", Offset = "0x640BA00", VA = "0x18640CA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x640D240", Offset = "0x640C240", VA = "0x18640D240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct KNHHLPALOBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public AsyncTaskMethodBuilder<FACJKOPPMPM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public LIDMKBOKAGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public NKNGHGMAJIA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public CJCILOJDOKG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private TaskAwaiter<(PLGFLNIIODP.APLABLPHDMJ roomDataUpload, PLGFLNIIODP.APLABLPHDMJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private TaskAwaiter<FACJKOPPMPM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x6418B50", Offset = "0x6417B50", VA = "0x186418B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x6419170", Offset = "0x6418170", VA = "0x186419170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct MODMALDHELD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public AsyncTaskMethodBuilder<BPIJMECGCAC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public LIDMKBOKAGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public NKNGHGMAJIA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private TaskAwaiter<(PLGFLNIIODP.APLABLPHDMJ roomDataUpload, PLGFLNIIODP.APLABLPHDMJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private TaskAwaiter<BPIJMECGCAC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x641D040", Offset = "0x641C040", VA = "0x18641D040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x641D460", Offset = "0x641C460", VA = "0x18641D460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class NCBIEDDKLFD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000183")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000677")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000678")]
			public AsyncTaskMethodBuilder<OCGKKEPIGGA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			public NCBIEDDKLFD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400067B")]
			private OCGKKEPIGGA <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400067C")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400067D")]
			private TaskAwaiter<BPIJMECGCAC> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			private TaskAwaiter<FACJKOPPMPM> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			private TaskAwaiter<OCGKKEPIGGA> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x6422D10", Offset = "0x6421D10", VA = "0x186422D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x6423D10", Offset = "0x6422D10", VA = "0x186423D10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public LIDMKBOKAGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public NKNGHGMAJIA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public CJCILOJDOKG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public DKIOIIGJIDP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public NCBIEDDKLFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x641E010", Offset = "0x641D010", VA = "0x18641E010")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<OCGKKEPIGGA> DHNOKLNCDDI(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct MAOKNICDBMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public AsyncTaskMethodBuilder<OCGKKEPIGGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public LIDMKBOKAGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public NKNGHGMAJIA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public CJCILOJDOKG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public DKIOIIGJIDP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private TaskAwaiter<OCGKKEPIGGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x641A750", Offset = "0x6419750", VA = "0x18641A750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x641AA60", Offset = "0x6419A60", VA = "0x18641AA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400064E")]
	private static readonly IMFBLHALHMN DJHKLFMABMI;

	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private static readonly IMFBLHALHMN HEIPKGBHEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private readonly MCLEIFFAJFC EELDOPCJBMJ;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private LDIAGFCFIDA MGHFLABNEND
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x63F3060", Offset = "0x63F2060", VA = "0x1863F3060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x641A070", Offset = "0x6419070", VA = "0x18641A070")]
	public LIDMKBOKAGM(IGDBPFKILJO BALLFIJIOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x6419A10", Offset = "0x6418A10", VA = "0x186419A10")]
	[AsyncStateMachine(typeof(BDCHGHKGPKP))]
	private Task<(PLGFLNIIODP.APLABLPHDMJ, PLGFLNIIODP.APLABLPHDMJ)> FJMLPHOMGJG(NKNGHGMAJIA LPBIKGAEGIH, long KAOIBEOBDCN, long BBEDBHIBLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x6419E60", Offset = "0x6418E60", VA = "0x186419E60")]
	[AsyncStateMachine(typeof(KNHHLPALOBN))]
	public Task<FACJKOPPMPM> POGJKJLPCPP(int KMPEFDCGPJE, [CanBeNull] CJCILOJDOKG FHHGEIENCHI, NKNGHGMAJIA LPBIKGAEGIH, long KAOIBEOBDCN, long BBEDBHIBLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x6419CF0", Offset = "0x6418CF0", VA = "0x186419CF0")]
	[AsyncStateMachine(typeof(MODMALDHELD))]
	private Task<BPIJMECGCAC> NHCEODNAJDG(string DFPKFFBPELK, int KMPEFDCGPJE, NKNGHGMAJIA LPBIKGAEGIH, long KAOIBEOBDCN, long BBEDBHIBLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x6419B50", Offset = "0x6418B50", VA = "0x186419B50")]
	[AsyncStateMachine(typeof(MAOKNICDBMM))]
	public Task<OCGKKEPIGGA> KIEJCINAKHF(int KMPEFDCGPJE, CJCILOJDOKG? FHHGEIENCHI, NKNGHGMAJIA LPBIKGAEGIH, long KAOIBEOBDCN, long BBEDBHIBLKF, DKIOIIGJIDP KCGODJOOBFP, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public abstract class DLFGABBPBPH<T> where T : DLFGABBPBPH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	internal readonly LDIAGFCFIDA LEEBPLPNJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private int? DDIMFJHBEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068E")]
	protected readonly Guid HPDKIOPIJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	protected readonly LLJKCEKOIII FNAHCHGIIOH;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	protected T GLKHPEMJIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x4DC5C20", Offset = "0x4DC4C20", VA = "0x184DC5C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x4DC5D60", Offset = "0x4DC4D60", VA = "0x184DC5D60")]
	internal DLFGABBPBPH(LDIAGFCFIDA FHCODCOEFAN, LLJKCEKOIII MGNBHKMDAHM, [Optional] Guid? KBNMFHADFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x4DC5C80", Offset = "0x4DC4C80", VA = "0x184DC5C80")]
	private OCGKKEPIGGA OKKFOJMMMIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "4")]
	protected virtual void MKDJGJAECCI(OCGKKEPIGGA NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x4DC5A70", Offset = "0x4DC4A70", VA = "0x184DC5A70")]
	public T CPGDGHBOJNP(HANCNHADEOE AENINCMMGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x4DC59E0", Offset = "0x4DC49E0", VA = "0x184DC59E0")]
	public T BCFPBIJJOIN(int PPPCGIIOBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x4DC5B00", Offset = "0x4DC4B00", VA = "0x184DC5B00", Slot = "5")]
	public virtual Task<GPKOEFJDDBP> NKHCDDHDDAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public class PJJOKIJBMJE : DLFGABBPBPH<PJJOKIJBMJE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private CIFKNLJLNLO HPEDGLBMGED;

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x6421BC0", Offset = "0x6420BC0", VA = "0x186421BC0")]
	internal PJJOKIJBMJE(LDIAGFCFIDA FHCODCOEFAN, LLJKCEKOIII MGNBHKMDAHM, [Optional] Guid? KBNMFHADFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB460", Offset = "0x5AAA460", VA = "0x185AAB460")]
	public PJJOKIJBMJE EMPNMOBBIJC(CIFKNLJLNLO HPEDGLBMGED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x6421AF0", Offset = "0x6420AF0", VA = "0x186421AF0", Slot = "4")]
	protected override void MKDJGJAECCI(OCGKKEPIGGA NCBOINMNCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public class ANLPMPOIDDI : DLFGABBPBPH<ANLPMPOIDDI>
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	internal enum DOJOPICJGIM
	{
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct JGHGCJKEMJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public AsyncTaskMethodBuilder<GPKOEFJDDBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public ANLPMPOIDDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter<GPKOEFJDDBP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x6417380", Offset = "0x6416380", VA = "0x186417380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x6417730", Offset = "0x6416730", VA = "0x186417730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	private DOJOPICJGIM KMHEMBDINDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private string MOHCJACHFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private CJCILOJDOKG HPEDGLBMGED;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x640C300", Offset = "0x640B300", VA = "0x18640C300")]
	internal ANLPMPOIDDI(LDIAGFCFIDA FHCODCOEFAN, LLJKCEKOIII MGNBHKMDAHM, [Optional] Guid? KBNMFHADFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x640C010", Offset = "0x640B010", VA = "0x18640C010")]
	public ANLPMPOIDDI GJNONPLALMJ(string BEOAJBBECNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x640C080", Offset = "0x640B080", VA = "0x18640C080")]
	public ANLPMPOIDDI KBCPKJFGPCE(bool AFCNDFHJLFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x640BFE0", Offset = "0x640AFE0", VA = "0x18640BFE0")]
	public ANLPMPOIDDI EIBCGANBABP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x640C0A0", Offset = "0x640B0A0", VA = "0x18640C0A0", Slot = "4")]
	protected override void MKDJGJAECCI(OCGKKEPIGGA NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x640C210", Offset = "0x640B210", VA = "0x18640C210", Slot = "5")]
	[AsyncStateMachine(typeof(JGHGCJKEMJL))]
	public override Task<GPKOEFJDDBP> NKHCDDHDDAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x640C040", Offset = "0x640B040", VA = "0x18640C040")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<GPKOEFJDDBP> IGJENKNJFCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal static class EJFLCFHJNHN
{
	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x64108C0", Offset = "0x640F8C0", VA = "0x1864108C0")]
	public static void HFHDMAGEDGO(this FGJACDIIGLL GNLBBEDHDJB, LPJIABDOGLI NEKFAPDECED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x6410840", Offset = "0x640F840", VA = "0x186410840")]
	public static void BGKPAPPKEIL(this LPJIABDOGLI FDPAIPNDEPO, [Optional] string NCBOINMNCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
public static class LGOCLJEPOFI
{
	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x64198C0", Offset = "0x64188C0", VA = "0x1864198C0")]
	public static AEBNJGMIDFC FFADBCNHFKE(this ACNIGDBIPDB EFJLMGECIJJ)
	{
		return default(AEBNJGMIDFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x6419960", Offset = "0x6418960", VA = "0x186419960")]
	public static ACNIGDBIPDB JEGDIAABHED(this AEBNJGMIDFC HLFFPBNHJHD)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006A0")]
			public FBGPILHJKBA ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006A1")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006A2")]
			public FBGPILHJKBA HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006A3")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006A4")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private static FBGPILHJKBA[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private Dictionary<FBGPILHJKBA, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x6424550", Offset = "0x6423550", VA = "0x186424550")]
		public bool NEOCKPOLBEH(FBGPILHJKBA PGOCKLBICBB, [Out] ResultConfig IBEAHHFJKHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x6424410", Offset = "0x6423410", VA = "0x186424410")]
		public ResultConfig FHOIHMMDFPF(FBGPILHJKBA GEIKHBJFIME, [Optional] HashSet<FBGPILHJKBA> CPOEGKDFJBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x6424B20", Offset = "0x6423B20", VA = "0x186424B20", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x64245C0", Offset = "0x64235C0", VA = "0x1864245C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x802230", Offset = "0x801230", VA = "0x180802230")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public static class POEAPDGJHHD
{
	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x6422330", Offset = "0x6421330", VA = "0x186422330")]
	[PKDJMILODMH(OMIAJJHDDGO.GameOnly)]
	private static void JNGPOGLGKKE(EIABFOFJCDK ENBCIOEOBDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public interface ALFEBNEDACP : IEquatable<ALFEBNEDACP>
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	DateTime MMACPDKMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAJKAGGLCOB();

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FJNAIIOPJOJ(long KAOIBEOBDCN, long HIFDDDODBFK, [Out] NKNGHGMAJIA LPBIKGAEGIH);
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
internal class GDDCMIHLIBP : LGDBIMMEJPN
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class PEKBLECICJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public BFJJLHPIHPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public PEKBLECICJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x6421A80", Offset = "0x6420A80", VA = "0x186421A80")]
		internal object AHOBFGNJANE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private readonly MJLDDJHNJBN FPJGCELAFFF;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<ALFEBNEDACP> PHKNGIHGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x6413BB0", Offset = "0x6412BB0", VA = "0x186413BB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x6413F00", Offset = "0x6412F00", VA = "0x186413F00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	[UnityEngine.Scripting.Preserve]
	public GDDCMIHLIBP([KHIPNIHHNOH(null)] MJLDDJHNJBN FPJGCELAFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x6413FB0", Offset = "0x6412FB0", VA = "0x186413FB0", Slot = "6")]
	public bool GPAEFLLPOOF(long KAOIBEOBDCN, long HIFDDDODBFK, NKNGHGMAJIA LPBIKGAEGIH, BFJJLHPIHPM GJGEIEHPEOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x188F0A0", Offset = "0x188E0A0", VA = "0x18188F0A0")]
	private void BBHONPBPGKB(ALFEBNEDACP DHHBKLBMPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x6413D90", Offset = "0x6412D90", VA = "0x186413D90", Slot = "7")]
	public bool FKNLHCPILJH(long KAOIBEOBDCN, long HIFDDDODBFK, [Out] ALFEBNEDACP AAKFCMHHOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x6414290", Offset = "0x6413290", VA = "0x186414290", Slot = "8")]
	public bool HHNGPMEBHDN(long KAOIBEOBDCN, long HIFDDDODBFK, BFJJLHPIHPM GJGEIEHPEOB, [Out] ALFEBNEDACP AAKFCMHHOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x6414340", Offset = "0x6413340", VA = "0x186414340")]
	private void ODHGMOLOBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x6413C60", Offset = "0x6412C60", VA = "0x186413C60", Slot = "9")]
	public void EBIPNGCEIFL(long KAOIBEOBDCN, long HIFDDDODBFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal abstract class EOAFFOGDIFO : MJLDDJHNJBN
{
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	protected enum CINPOFEHGJN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class OJJFPINEGBN : IEnumerable<ALFEBNEDACP>, IEnumerable, IEnumerator<ALFEBNEDACP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private ALFEBNEDACP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public EOAFFOGDIFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private BFJJLHPIHPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public BFJJLHPIHPM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		private ALFEBNEDACP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A40", Offset = "0x8BFA40", VA = "0x1808C0A40")]
		[DebuggerHidden]
		public OJJFPINEGBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x6420B50", Offset = "0x641FB50", VA = "0x186420B50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6420E30", Offset = "0x641FE30", VA = "0x186420E30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x6420D80", Offset = "0x641FD80", VA = "0x186420D80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ALFEBNEDACP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x6420D80", Offset = "0x641FD80", VA = "0x186420D80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class JMMHDKFKBKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public BFJJLHPIHPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public JMMHDKFKBKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x64182F0", Offset = "0x64172F0", VA = "0x1864182F0")]
		internal object LNNLNCEFNNL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class GOLOJJMMLMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public EOAFFOGDIFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public GOLOJJMMLMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x6415630", Offset = "0x6414630", VA = "0x186415630")]
		internal void OPOJNANKCHA(NLLAIDCMIAP.EEEFLMHDCGP ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B1")]
	protected readonly string EMLFOLPECAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private readonly object DDBINIPFEDJ;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract FBJPAIDDGJA LMLJFMDEIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x6411410", Offset = "0x6410410", VA = "0x186411410")]
	protected EOAFFOGDIFO([CanBeNull] string GIOHPANEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x6410AA0", Offset = "0x640FAA0", VA = "0x186410AA0", Slot = "5")]
	public bool DMHBEMBJMKL(long KAOIBEOBDCN, long HIFDDDODBFK, BFJJLHPIHPM GJGEIEHPEOB, [Out] ALFEBNEDACP DHHBKLBMPLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x6410A10", Offset = "0x640FA10", VA = "0x186410A10", Slot = "6")]
	[IteratorStateMachine(typeof(OJJFPINEGBN))]
	public IEnumerable<ALFEBNEDACP> BNPOELHDHEI(BFJJLHPIHPM GJGEIEHPEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void FHJIANAIAEK(Stream KPKAKJGNIOB, long KAOIBEOBDCN, long HIFDDDODBFK, NKNGHGMAJIA LPBIKGAEGIH);

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool KALFDOBKEJD(Stream NOKHBMIAOPG, long KAOIBEOBDCN, long HIFDDDODBFK, GAEMLFHCPDM DFOGLPNJGDM, [Out] NKNGHGMAJIA LPBIKGAEGIH);

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x6411090", Offset = "0x6410090", VA = "0x186411090", Slot = "7")]
	public ALFEBNEDACP MIJONOGCICH(long KAOIBEOBDCN, long HIFDDDODBFK, NKNGHGMAJIA LPBIKGAEGIH, BFJJLHPIHPM GJGEIEHPEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo IHGDJCCJELE(long KAOIBEOBDCN, long HIFDDDODBFK, BFJJLHPIHPM GJGEIEHPEOB, CINPOFEHGJN BACCEOLFFIE);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo LGLGMEEDMLE(BFJJLHPIHPM GJGEIEHPEOB, CINPOFEHGJN BACCEOLFFIE);

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x6410C90", Offset = "0x640FC90", VA = "0x186410C90")]
	protected void EFBOKPFGMKB(NLLAIDCMIAP.EEEFLMHDCGP AFPNBBEKCLK, string IECBPCEAHOG, FileInfo EFIFKGKPJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x6410D00", Offset = "0x640FD00", VA = "0x186410D00")]
	internal bool KPLCJGJOHPN(FileInfo CANNGNNHIJB, long KAOIBEOBDCN, long HIFDDDODBFK, [Out] NKNGHGMAJIA LPBIKGAEGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
	private void KHHIFJOKCNE(Exception KOOFLIKCDNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal class FPLFBMLKHOE : EOAFFOGDIFO
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public override FBJPAIDDGJA LMLJFMDEIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xA6E000", Offset = "0xA6D000", VA = "0x180A6E000", Slot = "8")]
		get
		{
			return default(FBJPAIDDGJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x6413AF0", Offset = "0x6412AF0", VA = "0x186413AF0")]
	public FPLFBMLKHOE([Optional] string GIOHPANEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x6413310", Offset = "0x6412310", VA = "0x186413310")]
	private void JAFMNEDGAOM(BFJJLHPIHPM GJGEIEHPEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x6412F90", Offset = "0x6411F90", VA = "0x186412F90", Slot = "9")]
	internal override void FHJIANAIAEK(Stream KPKAKJGNIOB, long KAOIBEOBDCN, long HIFDDDODBFK, NKNGHGMAJIA LPBIKGAEGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x6413390", Offset = "0x6412390", VA = "0x186413390", Slot = "10")]
	internal override bool KALFDOBKEJD(Stream NOKHBMIAOPG, long KAOIBEOBDCN, long HIFDDDODBFK, GAEMLFHCPDM DFOGLPNJGDM, [Out] NKNGHGMAJIA LPBIKGAEGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x6413220", Offset = "0x6412220", VA = "0x186413220", Slot = "11")]
	protected override FileInfo IHGDJCCJELE(long KAOIBEOBDCN, long HIFDDDODBFK, BFJJLHPIHPM GJGEIEHPEOB, CINPOFEHGJN BACCEOLFFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x64139E0", Offset = "0x64129E0", VA = "0x1864139E0", Slot = "12")]
	protected override DirectoryInfo LGLGMEEDMLE(BFJJLHPIHPM GJGEIEHPEOB, CINPOFEHGJN BACCEOLFFIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal sealed class MOAFHEEKHMO : EOAFFOGDIFO
{
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private static readonly byte[] BGNGIHJEFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private readonly byte[] DLCHHHAMEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private readonly byte[] AFGNDEECGCM;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override FBJPAIDDGJA LMLJFMDEIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x53B69A0", Offset = "0x53B59A0", VA = "0x1853B69A0", Slot = "8")]
		get
		{
			return default(FBJPAIDDGJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x641CEE0", Offset = "0x641BEE0", VA = "0x18641CEE0")]
	public MOAFHEEKHMO([Optional] string GIOHPANEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x641C120", Offset = "0x641B120", VA = "0x18641C120", Slot = "9")]
	internal override void FHJIANAIAEK(Stream KPKAKJGNIOB, long KAOIBEOBDCN, long HIFDDDODBFK, NKNGHGMAJIA LPBIKGAEGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x641C510", Offset = "0x641B510", VA = "0x18641C510", Slot = "10")]
	internal override bool KALFDOBKEJD(Stream NOKHBMIAOPG, long KAOIBEOBDCN, long HIFDDDODBFK, GAEMLFHCPDM DFOGLPNJGDM, [Out] NKNGHGMAJIA LPBIKGAEGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x641C060", Offset = "0x641B060", VA = "0x18641C060")]
	private void DFFDECLLHDN(byte[] BKCOILCKNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x641C3E0", Offset = "0x641B3E0", VA = "0x18641C3E0", Slot = "11")]
	protected override FileInfo IHGDJCCJELE(long KAOIBEOBDCN, long HIFDDDODBFK, BFJJLHPIHPM GJGEIEHPEOB, CINPOFEHGJN BACCEOLFFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x641CD40", Offset = "0x641BD40", VA = "0x18641CD40", Slot = "12")]
	protected override DirectoryInfo LGLGMEEDMLE(BFJJLHPIHPM GJGEIEHPEOB, CINPOFEHGJN BACCEOLFFIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public enum FBJPAIDDGJA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
internal class FGIMKJCAKFG : MJLDDJHNJBN
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private sealed class GICNPGEIDEI : IEnumerable<ALFEBNEDACP>, IEnumerable, IEnumerator<ALFEBNEDACP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private ALFEBNEDACP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public FGIMKJCAKFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private BFJJLHPIHPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public BFJJLHPIHPM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private FBJPAIDDGJA[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private IEnumerator<ALFEBNEDACP> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		private ALFEBNEDACP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000667")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A40", Offset = "0x8BFA40", VA = "0x1808C0A40")]
		[DebuggerHidden]
		public GICNPGEIDEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x64155A0", Offset = "0x64145A0", VA = "0x1864155A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x64151C0", Offset = "0x64141C0", VA = "0x1864151C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x6415170", Offset = "0x6414170", VA = "0x186415170")]
		private void GDOLLNLODDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x6415550", Offset = "0x6414550", VA = "0x186415550", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x64154A0", Offset = "0x64144A0", VA = "0x1864154A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ALFEBNEDACP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x64154A0", Offset = "0x64144A0", VA = "0x1864154A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private readonly FBJPAIDDGJA[] LGPOBFPOHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private readonly Dictionary<FBJPAIDDGJA, MJLDDJHNJBN> IEDIDPKMHKO;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public FBJPAIDDGJA LMLJFMDEIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x6411A20", Offset = "0x6410A20", VA = "0x186411A20", Slot = "4")]
		get
		{
			return default(FBJPAIDDGJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x6411EA0", Offset = "0x6410EA0", VA = "0x186411EA0")]
	[UnityEngine.Scripting.Preserve]
	public FGIMKJCAKFG(params MJLDDJHNJBN[] PMBOHMAHEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x6411A50", Offset = "0x6410A50", VA = "0x186411A50", Slot = "5")]
	public bool DMHBEMBJMKL(long KAOIBEOBDCN, long HIFDDDODBFK, BFJJLHPIHPM GJGEIEHPEOB, [Out] ALFEBNEDACP DHHBKLBMPLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x6411BA0", Offset = "0x6410BA0", VA = "0x186411BA0")]
	private void HPPBHOGNLKF(int NFEKKBEODCP, long KAOIBEOBDCN, long HIFDDDODBFK, BFJJLHPIHPM GJGEIEHPEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x6411990", Offset = "0x6410990", VA = "0x186411990", Slot = "6")]
	[IteratorStateMachine(typeof(GICNPGEIDEI))]
	public IEnumerable<ALFEBNEDACP> BNPOELHDHEI(BFJJLHPIHPM GJGEIEHPEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x6411DC0", Offset = "0x6410DC0", VA = "0x186411DC0", Slot = "7")]
	public ALFEBNEDACP MIJONOGCICH(long KAOIBEOBDCN, long HIFDDDODBFK, NKNGHGMAJIA LPBIKGAEGIH, BFJJLHPIHPM GJGEIEHPEOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal static class GGHJMENABMD
{
	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x6414770", Offset = "0x6413770", VA = "0x186414770")]
	internal static byte[] ECNKLAGFECI(byte[] BKCOILCKNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x6414A10", Offset = "0x6413A10", VA = "0x186414A10")]
	public static void ONOLLHMMJHN(Stream EODNJPIMPGN, byte[] OENGCOEJEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x6414830", Offset = "0x6413830", VA = "0x186414830")]
	public static bool FOPMJLLFEGF(Stream EODNJPIMPGN, long FONMFOOPADF, GAEMLFHCPDM IHMGFCMDHJB, [Out] byte[] CJNLGCEPOGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal sealed class ABBNJHFCBJI : ALFEBNEDACP, IEquatable<ALFEBNEDACP>, IEquatable<ABBNJHFCBJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private readonly EOAFFOGDIFO OBIDGEMLJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	public readonly FileInfo HOHGPGFBFFG;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public FBJPAIDDGJA LMLJFMDEIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x640A200", Offset = "0x6409200", VA = "0x18640A200", Slot = "9")]
		get
		{
			return default(FBJPAIDDGJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public DateTime MMACPDKMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x640A590", Offset = "0x6409590", VA = "0x18640A590", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x640A6D0", Offset = "0x64096D0", VA = "0x18640A6D0")]
	public ABBNJHFCBJI(EOAFFOGDIFO MFNNNPJKLNB, FileInfo CANNGNNHIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x640A620", Offset = "0x6409620", VA = "0x18640A620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x640A140", Offset = "0x6409140", VA = "0x18640A140", Slot = "5")]
	public void BAJKAGGLCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x640A4C0", Offset = "0x64094C0", VA = "0x18640A4C0", Slot = "6")]
	public bool FJNAIIOPJOJ(long KAOIBEOBDCN, long HIFDDDODBFK, [Out] NKNGHGMAJIA LPBIKGAEGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x640A230", Offset = "0x6409230", VA = "0x18640A230", Slot = "7")]
	public bool Equals(ALFEBNEDACP EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x640A310", Offset = "0x6409310", VA = "0x18640A310", Slot = "8")]
	public bool Equals(ABBNJHFCBJI EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x640A3D0", Offset = "0x64093D0", VA = "0x18640A3D0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x640A500", Offset = "0x6409500", VA = "0x18640A500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public delegate void GAEMLFHCPDM(NLLAIDCMIAP.EEEFLMHDCGP GEHJHJCJALG, string NCBOINMNCHO);
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal interface MJLDDJHNJBN
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	FBJPAIDDGJA LMLJFMDEIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DMHBEMBJMKL(long KAOIBEOBDCN, long HIFDDDODBFK, BFJJLHPIHPM GJGEIEHPEOB, [Out] ALFEBNEDACP DHHBKLBMPLE);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ALFEBNEDACP> BNPOELHDHEI(BFJJLHPIHPM GJGEIEHPEOB);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ALFEBNEDACP MIJONOGCICH(long KAOIBEOBDCN, long HIFDDDODBFK, NKNGHGMAJIA LPBIKGAEGIH, BFJJLHPIHPM GJGEIEHPEOB);
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
