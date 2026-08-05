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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6217FD0", Offset = "0x6216DD0", VA = "0x186217FD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x789560", Offset = "0x788360", VA = "0x180789560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7895A0", Offset = "0x7883A0", VA = "0x1807895A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GMMLOIIEMAH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620CEF0", VA = "0x18620E0F0")]
	public GMMLOIIEMAH(string BLAOEBOMGGP, Exception FCMCOCINMCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class GMAIKJLLPGM : NAFNBGEOFEN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct OBCOBCMCEAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<KIKHMLAGMKE>> <>t__builder;

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
		private TaskAwaiter<FHHJDCAFLNJ<KIKHMLAGMKE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6218050", Offset = "0x6216E50", VA = "0x186218050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6218290", Offset = "0x6217090", VA = "0x186218290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct FPPOOADOAGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<GNGEJOMCEJG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<GNGEJOMCEJG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x620A0F0", Offset = "0x6208EF0", VA = "0x18620A0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x620A300", Offset = "0x6209100", VA = "0x18620A300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	[UnityEngine.Scripting.Preserve]
	public GMAIKJLLPGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x620DFD0", Offset = "0x620CDD0", VA = "0x18620DFD0", Slot = "4")]
	[AsyncStateMachine(typeof(OBCOBCMCEAF))]
	public Task<IReadOnlyList<KIKHMLAGMKE>> IPOIJBNKJNI(long ODPLBFKINCE, long CNKFDDFGKPE, [Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x620DEC0", Offset = "0x620CCC0", VA = "0x18620DEC0", Slot = "5")]
	[AsyncStateMachine(typeof(FPPOOADOAGB))]
	public Task<IReadOnlyList<GNGEJOMCEJG>> ADEBJHPGOPG(IReadOnlyList<int> DCJGDEKOCOI, [Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BNNMNDBFGEB : IEquatable<BNNMNDBFGEB>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int BGILPNGHOLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	GNGEJOMCEJG PPLJLGEJLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime EKPHGHFCMKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	DBFEAHAEBEN? APHBEHEMKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KONOIMDPFFE? LMJNEFMKNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	HCABJNPODEP HFBCBEBHAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DBGMMOMFJAO> DCIOIGPCDGJ();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum HCABJNPODEP
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NAFNBGEOFEN
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<KIKHMLAGMKE>> IPOIJBNKJNI(long ODPLBFKINCE, long CNKFDDFGKPE, [Optional] CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<GNGEJOMCEJG>> ADEBJHPGOPG(IReadOnlyList<int> DCJGDEKOCOI, [Optional] CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BCFDJCCEBNI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class NMHOGMCNNFN : BNNMNDBFGEB, IEquatable<BNNMNDBFGEB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct FLBPCCKAAAO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<DBGMMOMFJAO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public NMHOGMCNNFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private OPGHBJJICOK <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<HEKEHEGBBLG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<DBGMMOMFJAO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6208EB0", Offset = "0x6207CB0", VA = "0x186208EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6209350", Offset = "0x6208150", VA = "0x186209350", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly KIKHMLAGMKE HMGGBFPLBLD;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int BGILPNGHOLD
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7638A0", Offset = "0x7626A0", VA = "0x1807638A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GNGEJOMCEJG PPLJLGEJLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime LKMBGCPKMHD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8DB8B0", Offset = "0x8DA6B0", VA = "0x1808DB8B0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public DBFEAHAEBEN? APHBEHEMKEF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x17D9DE0", Offset = "0x17D8BE0", VA = "0x1817D9DE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KONOIMDPFFE? LMJNEFMKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1F99F40", Offset = "0x1F98D40", VA = "0x181F99F40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public HCABJNPODEP HFBCBEBHAIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7DD200", Offset = "0x7DC000", VA = "0x1807DD200", Slot = "10")]
			get
			{
				return default(HCABJNPODEP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6217C80", Offset = "0x6216A80", VA = "0x186217C80", Slot = "9")]
		[AsyncStateMachine(typeof(FLBPCCKAAAO))]
		public Task<DBGMMOMFJAO> DCIOIGPCDGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6217F70", Offset = "0x6216D70", VA = "0x186217F70")]
		public NMHOGMCNNFN(int GKIELOMFNJE, GNGEJOMCEJG KPFAJDAANBP, KIKHMLAGMKE HMGGBFPLBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6217E60", Offset = "0x6216C60", VA = "0x186217E60", Slot = "11")]
		public bool Equals(BNNMNDBFGEB LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6217DC0", Offset = "0x6216BC0", VA = "0x186217DC0", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6217D80", Offset = "0x6216B80", VA = "0x186217D80")]
		private bool EMFLCAGMFPA(NMHOGMCNNFN LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6217EF0", Offset = "0x6216CF0", VA = "0x186217EF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class MPKFEILPOJD : BNNMNDBFGEB, IEquatable<BNNMNDBFGEB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct LDOMJOPMGJA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<DBGMMOMFJAO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public MPKFEILPOJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<DBGMMOMFJAO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6214100", Offset = "0x6212F00", VA = "0x186214100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6214330", Offset = "0x6213130", VA = "0x186214330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly KOAFPCAGHPM HLLLEFENJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly DBFEAHAEBEN HCMHOCAHGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly KONOIMDPFFE HPCOEEONJAF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int BGILPNGHOLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6217410", Offset = "0x6216210", VA = "0x186217410", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GNGEJOMCEJG PPLJLGEJLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x62176D0", Offset = "0x62164D0", VA = "0x1862176D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime LKMBGCPKMHD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x62173C0", Offset = "0x62161C0", VA = "0x1862173C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DBFEAHAEBEN? APHBEHEMKEF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6217280", Offset = "0x6216080", VA = "0x186217280", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public KONOIMDPFFE? LMJNEFMKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6217680", Offset = "0x6216480", VA = "0x186217680", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public HCABJNPODEP HFBCBEBHAIN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7CF820", Offset = "0x7CE620", VA = "0x1807CF820", Slot = "10")]
			get
			{
				return default(HCABJNPODEP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD4DF40", Offset = "0xD4CD40", VA = "0x180D4DF40")]
		public MPKFEILPOJD(KOAFPCAGHPM GHLCENPLAFJ, DBFEAHAEBEN MOHHHHPCHBI, KONOIMDPFFE LLHEEJGHILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x62172D0", Offset = "0x62160D0", VA = "0x1862172D0", Slot = "9")]
		[AsyncStateMachine(typeof(LDOMJOPMGJA))]
		public Task<DBGMMOMFJAO> DCIOIGPCDGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6217560", Offset = "0x6216360", VA = "0x186217560", Slot = "11")]
		public bool Equals(BNNMNDBFGEB LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x62174B0", Offset = "0x62162B0", VA = "0x1862174B0", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6217450", Offset = "0x6216250", VA = "0x186217450")]
		private bool EMFLCAGMFPA(MPKFEILPOJD LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6217600", Offset = "0x6216400", VA = "0x186217600", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class AHHEPGDDHPO : BNNMNDBFGEB, IEquatable<BNNMNDBFGEB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct DKIONKBAIGB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<DBGMMOMFJAO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<DBGMMOMFJAO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x62053E0", Offset = "0x62041E0", VA = "0x1862053E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6205620", Offset = "0x6204420", VA = "0x186205620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly GNGEJOMCEJG AJCICGKHFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly DBFEAHAEBEN HCMHOCAHGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly KONOIMDPFFE HPCOEEONJAF;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int BGILPNGHOLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x61FCBD0", Offset = "0x61FB9D0", VA = "0x1861FCBD0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public GNGEJOMCEJG PPLJLGEJLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime LKMBGCPKMHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DBFEAHAEBEN? APHBEHEMKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x61FCAB0", Offset = "0x61FB8B0", VA = "0x1861FCAB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public KONOIMDPFFE? LMJNEFMKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x61FCF90", Offset = "0x61FBD90", VA = "0x1861FCF90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public HCABJNPODEP HFBCBEBHAIN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "10")]
			get
			{
				return default(HCABJNPODEP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD4DF40", Offset = "0xD4CD40", VA = "0x180D4DF40")]
		public AHHEPGDDHPO(GNGEJOMCEJG KPFAJDAANBP, DBFEAHAEBEN MOHHHHPCHBI, KONOIMDPFFE LLHEEJGHILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x61FCB00", Offset = "0x61FB900", VA = "0x1861FCB00", Slot = "9")]
		[AsyncStateMachine(typeof(DKIONKBAIGB))]
		public Task<DBGMMOMFJAO> DCIOIGPCDGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x61FCCD0", Offset = "0x61FBAD0", VA = "0x1861FCCD0", Slot = "11")]
		public bool Equals(BNNMNDBFGEB LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x61FCDE0", Offset = "0x61FBBE0", VA = "0x1861FCDE0", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x61FCF00", Offset = "0x61FBD00", VA = "0x1861FCF00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x61FCBF0", Offset = "0x61FB9F0", VA = "0x1861FCBF0")]
		private bool EMFLCAGMFPA(AHHEPGDDHPO LKMMHIOOCMN)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct HBDLPPOCECB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<BNNMNDBFGEB>> <>t__builder;

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
		public BCFDJCCEBNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<KIKHMLAGMKE> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<KIKHMLAGMKE>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, GNGEJOMCEJG account, KIKHMLAGMKE roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x620E360", Offset = "0x620D160", VA = "0x18620E360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x620F140", Offset = "0x620DF40", VA = "0x18620F140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct LEJAHKOBNPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, GNGEJOMCEJG account, KIKHMLAGMKE roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<KIKHMLAGMKE> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public BCFDJCCEBNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<GNGEJOMCEJG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6214E90", Offset = "0x6213C90", VA = "0x186214E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6215880", Offset = "0x6214680", VA = "0x186215880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KBOMCKHLPDF JFFEOAJMKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly NAFNBGEOFEN DEADELOKAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly EFINLOBHEIP DBCFJNCJADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly PHDJOGCKOJN<(long, long), IReadOnlyList<KIKHMLAGMKE>> JOBJOJBFGPB;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x61FDC10", Offset = "0x61FCA10", VA = "0x1861FDC10")]
	[UnityEngine.Scripting.Preserve]
	public BCFDJCCEBNI([FGPOJKOJBFM(null)] NAFNBGEOFEN JDACNJBNFGB, [FGPOJKOJBFM(null)] EFINLOBHEIP NMFKECHMPGD, [FGPOJKOJBFM(null)] KBOMCKHLPDF OKHPOKFEBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x61FDAC0", Offset = "0x61FC8C0", VA = "0x1861FDAC0")]
	[AsyncStateMachine(typeof(HBDLPPOCECB))]
	public Task<IList<BNNMNDBFGEB>> PAFOJAPPNML(long ODPLBFKINCE, long PHHJICEDHNG, bool DIOKFGCHLGF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61FD810", Offset = "0x61FC610", VA = "0x1861FD810")]
	private bool DHIGHMHNDDJ(DateTime? JGKHKCJAHNC, long ODPLBFKINCE, long PHHJICEDHNG, [Out] KOAFPCAGHPM FBHFFEMKPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x61FD9B0", Offset = "0x61FC7B0", VA = "0x1861FD9B0")]
	[AsyncStateMachine(typeof(LEJAHKOBNPO))]
	private Task<IReadOnlyList<(int, GNGEJOMCEJG, KIKHMLAGMKE)>> IFEGPJHKMNL(IReadOnlyList<KIKHMLAGMKE> KDDDMJIBEAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EFINLOBHEIP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KOAFPCAGHPM> BHGGAAFNFGF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LIEJCDCDHPC(long ODPLBFKINCE, long PHHJICEDHNG, CEIMFNJANHL AKFMCNAFBFA, JHEKNEICBIJ ANAIDGIIPAF);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LEDLLDLELPK(long ODPLBFKINCE, long PHHJICEDHNG, [Out] KOAFPCAGHPM FBHFFEMKPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ONCDNMJNACO(long ODPLBFKINCE, long PHHJICEDHNG, JHEKNEICBIJ ANAIDGIIPAF, [Out] KOAFPCAGHPM FBHFFEMKPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMOLDIJDKNB(long ODPLBFKINCE, long PHHJICEDHNG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface BENFFKBABLP : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OCGCJNGBAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task BABPJCBBPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIJFACBJKHE(Task DPNKBPFBJPJ, string LFOFLDIBOIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface GCMDDFAJNHD : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DBGMMOMFJAO> LMBNAKFDOMB(KOAFPCAGHPM FBHFFEMKPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KAGFICDKBDK(CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface AOIFNCCAFCG : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	NGAGHHIMGOM KNAEICMJFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKCBHNEHKDM();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NCLLNEAJCCL();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface IEHKIJJJKOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface CNCDPBAGGGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan EAOHDAANAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan PGGNAHLBDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan AOHIPMDGOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan HCEIGIBLGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool DMNHLGLFNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PLDGKJAOFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool KPGPCOFPMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int GBKKLAFIJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool PBFPJCGOCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool OPGKKMPEKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum EKOKMGEIGBP
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum HDCLEDKOAAP
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
public struct NDKKOBMILDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long LCHNGIBNMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long CNKFDDFGKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly EKOKMGEIGBP FLHOFPAHPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception NCHOCCBDJPC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x62177B0", Offset = "0x62165B0", VA = "0x1862177B0")]
	public NDKKOBMILDL(long LCHNGIBNMLJ, long CNKFDDFGKPE, EKOKMGEIGBP FLHOFPAHPKL, [CanBeNull] Exception NCHOCCBDJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6217760", Offset = "0x6216560", VA = "0x186217760")]
	public static NDKKOBMILDL HOBCKCOLEEF(KGDNOOKHPHA BKFCDOAFKGM, EKOKMGEIGBP FLHOFPAHPKL, [Optional] Exception NCHOCCBDJPC)
	{
		return default(NDKKOBMILDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void GKNHHMGBNGO(NDKKOBMILDL EMCBNIOOAKH);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface EEFOCEBODCN : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NCCOOGJEGBF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GKNHHMGBNGO DHIGFGHJFJM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GKNHHMGBNGO FAHKCDMKIDH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GKNHHMGBNGO MIMCHCBEGPG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<HDCLEDKOAAP, bool> OCIMPHIMLFC;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DAEBMILMGMF();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NFFHNLBHNNH(NDKKOBMILDL EMCBNIOOAKH);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NKOPICOAKNM(NDKKOBMILDL EMCBNIOOAKH);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LJLMCAEJEND(NDKKOBMILDL EMCBNIOOAKH);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LDIKPEFKDNF(HDCLEDKOAAP AEGJDAAKNIJ, bool LOKCGABODID);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface AJIHCNJODIL : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AFAFBKAFNPN();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCJHJJINAMI();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface DPIALHIJIPF : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus LPPFBJDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CJHAFEHMPDI(KGDNOOKHPHA NGIJJKNICEF, EFHCEIBOJHF KCDLCPKNHLF, CancellationToken FJDIBEBBHAG);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal static class LFAAEAOBBCF
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x62158F0", Offset = "0x62146F0", VA = "0x1862158F0")]
	public static bool DGBGCPJNPEP(this DPIALHIJIPF ENCKNIABMAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public delegate Task MLIGFPPLKBD(NNEDCLBDCDJ EDDLBMGEMFE, CancellationToken EKDHBKMFLGI);
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface JOKPCMCNMAM : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALDCIBPCDLM(MLIGFPPLKBD BPIAGEGHLLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface JHENEJKEAOJ : OPGHBJJICOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken NOGLMJBFAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	NNIGDKDCOBN FCKGNOCODEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	PBDPFIHDLBN GJDPBDOIJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	JDLCCAPLPFA DABMPHNEMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	GJEKPDGJJHD HGMDPNHJIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	OOLPJEPAFOA ENHEBJJFOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	OGPMEHACKPF PBPPPOHMFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	PDFONMCLKJM OMBGNHMJACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MLCFHDEFMPO FBJFMPOCCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	BENFFKBABLP AADJHDBEGME
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	GCMDDFAJNHD LKJDKDMPKKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	EEFOCEBODCN AJDFKECCOJM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	AJIHCNJODIL MLENLCONPBK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	DPIALHIJIPF EEECOFCEDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JOKPCMCNMAM IPBKKCIBJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	IIICFOAGJCD KFPCIMMPMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OLGNNCBODHL MBNAIBCCCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	OFGJJCKCANF JMACOOFKJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MELHAOKFPOJ EKBNGACHMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	NJNGIFKKLFA EBIKGDMIGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	BAKMENKFKPG BPLFBGEONKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CMMNPOOLMEK BJODIEJKDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	FIBNAAJNLBK INPLCPKECGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	LEJJNNKMGAJ OFFAEHOGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	FJPEOIADANF KDEFDHCILLD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	AOIFNCCAFCG JNFMFHGLFNL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	CNCDPBAGGGJ FDMCPHNBFHM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	OGLKJICEBDG FCCOFAEODGL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	EFINLOBHEIP AGLPDDCCDLI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	HEGHLEEBPHE KLADGDHDHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	ANOJCLPMAOC JADFPOAPFHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void CLPIDHKDCEE(EFHCEIBOJHF JAAGMOEAJCG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface IIICFOAGJCD : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DPNNCJCJBCE EJEJBLJEAIN(Guid ODNBBNPINDD);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KCJHGNBNEJA(Guid ODNBBNPINDD);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MLHEJMACAFF(Guid ODNBBNPINDD, Task OFNAIJJLDGE);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CLFJBJKNMAI(Guid ODNBBNPINDD, DBGMMOMFJAO MFCIDIAAPFL);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(DBGMMOMFJAO, Task)> CJILLGAOAGB(Guid ODNBBNPINDD);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface AKFFNDGCCGK : IEHKIJJJKOK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface OLGNNCBODHL : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANNKAMNLMMK(BPADINOBHMJ BLAOEBOMGGP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABGAGEAKFOG(BPADINOBHMJ BLAOEBOMGGP);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<HKNPACFPCEJ> DIIFGJNOPLK(CancellationToken CDMOPKIBDMC);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface OFGJJCKCANF : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DPNNCJCJBCE ANNDEDDFLPJ(BPADINOBHMJ LPDDKBDPMNJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMEKNNHOLOO(Guid ODNBBNPINDD, Task OFNAIJJLDGE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface MELHAOKFPOJ : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DBGMMOMFJAO> EKBNGACHMFN(BPADINOBHMJ BNOJAKDIIBK);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface NJNGIFKKLFA : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MMILHCEGCHA> DLFBGNDPDEG(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, KGDNOOKHPHA NGIJJKNICEF, CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface CMMNPOOLMEK : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBGMMOMFJAO LMBJKMIIFEE(OOAELAJMHEN OLFOGNLCBFB);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JFCAJNPPPLN(string MCGLDNPFLND);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface BAKMENKFKPG : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BPADINOBHMJ> JKBFAAKPJDK(BPADINOBHMJ BHMKONDNBED, OMGMONNMAKC KHNGAKEPNEA, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<BPADINOBHMJ> GHBIIHGLMJN(CancellationToken BCCDJHNACKO, OMGMONNMAKC KHNGAKEPNEA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MNOFAHLHGGO HFJJDNCOILF(CKELNELKOJL KPCBKGBKBPI, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MNOFAHLHGGO IJPMJGBHIEH(CKELNELKOJL KPCBKGBKBPI, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface FIBNAAJNLBK : IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBGMMOMFJAO NLFEPLCLLFP(OOAELAJMHEN OLFOGNLCBFB, HKNPACFPCEJ FBODNDFGDIK);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DBGMMOMFJAO NNGIIIGOAIE(OOAELAJMHEN MMNBPGKPJPG);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface LEJJNNKMGAJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COIGACHELOM(OGHOONFNAED MKBALAEFPNO);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLDPGGHHPNP(OGHOONFNAED MKBALAEFPNO);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNGHNEGHDNJ(OGHOONFNAED MKBALAEFPNO);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KIADPHLHGJE(OGHOONFNAED MKBALAEFPNO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class OGHOONFNAED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly KGDNOOKHPHA CPKJDHCMPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> IBJOJLLNBAL;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public AEMIIEBAFHL<string> HLODCOGAAEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public OGHOONFNAED(KGDNOOKHPHA CMLDOPFAAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6219410", Offset = "0x6218210", VA = "0x186219410")]
	public OGHOONFNAED PMNMBDIGKFO(string GMOPMNAPKBE, string POACLGOFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6219380", Offset = "0x6218180", VA = "0x186219380")]
	public bool DJMFBANABMG([Out] IEnumerable<KeyValuePair<string, string>> HPBKCDEGGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5643AA0", Offset = "0x56428A0", VA = "0x185643AA0")]
	public OGHOONFNAED NCOHICLGOPH(AEMIIEBAFHL<string> DNLFOGHCHDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface OGLKJICEBDG
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool DOKPAKECMIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string IIPKBIAJJBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DOIKDOHHEHO();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NOHCFMGPLCA PABKEOHKFIA(long CNOCCAPLFKN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JNECKGCIOFK<JBEOIFKKBLD, HIAIHBIEMAC> GHGAPAALBOH(long CNOCCAPLFKN);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JNECKGCIOFK<JBEOIFKKBLD, ELNFILGNBCL> HJAGKJCHOIM(long CNOCCAPLFKN);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JNECKGCIOFK<long, PHPDBENOAKI> ELGKFGNOMPN();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> CBGJHGNPPPD(byte[] DBBBPLGPHMP, byte[] GDJNMGOCFKN, CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface OPGHBJJICOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DGBGCPJNPEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool LKNGDGBGPED
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	EFHCEIBOJHF FHCGEPGNJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action NCCOOGJEGBF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event GKNHHMGBNGO DHIGFGHJFJM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event GKNHHMGBNGO FAHKCDMKIDH;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GKNHHMGBNGO MIMCHCBEGPG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<HDCLEDKOAAP, bool> OCIMPHIMLFC;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HCJHJJINAMI();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	COCNALHNELK COKHMCAANNA();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CLODLNHKJBB KEAKHEBFMJN();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<DBGMMOMFJAO> LMBNAKFDOMB(KOAFPCAGHPM GHLCENPLAFJ);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task KAGFICDKBDK(CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface OOLPJEPAFOA
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool IHCMALFEGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string KOGOMMLNMEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPDJIGKEJKN(Scene LFHMFCNAEKF);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ABOKOGLIEGJ(KHKNCAJFODO MFODPMHNDIE, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HCMBIMPGNCJ();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface GJEKPDGJJHD
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	KINEDFAPICD IJAIOKDAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool LGOPNOAIKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool IHGONDHNGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool IEJKALMPMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool HKMPKNOLCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool FIIKBFCHCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool KNGAEHKAAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float KCJGDHKLGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> KKOEFOFKPND;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NNIGDKDCOBN FFKMIIHDLLI(NNIGDKDCOBN AKMLFNCIJHN);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DONHPDELJAF(NNIGDKDCOBN LAJBGPNDGLJ);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCMIOLNAOKF();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task GAJDGLKMOFG(AEMIIEBAFHL<string>.GMENFEPMDPA GHCEPLLNFFA, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KPENMMNPAOC(float NEOFCPOBGDK);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HNMPPCPKNAL(string PEJNLGAGBJB);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<IHMFEHHCOMH> MAIGBOGCHDD();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable DFNNCLIIOCN(object DDMHMHFODEB, IHMFEHHCOMH AIKAAJDIFDJ);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HIAIHBIEMAC EPLNLKGKEAK(IEnumerable<JBHCDHCPMCM> DLDLENALPEH);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BHKHPDGHFMA(int GAGNPPDPNIO);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task OHIKGAGIGIL();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CJLGLFHFCPH();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool FNHMMHOCLAO();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task CBKKLDNBBFO(CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task OIKOBLNMJDJ(CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<LJDLMNGAONA> HAPMLPCBJHH(DateTime ANKJBJFMKAD, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<bool> LICGHMJLJJP(CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DBIGKNLONCG(string PDLPALDONCA = "", float DCKCDNEGBLL = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "22")]
	LHDGHOEKHHB JANCBHPCJGF(EBDAGPGFMGD FEKLNEOLNJA, BOCBEKEAIOO IOCBNJPMDCM, ELNFILGNBCL LALHNMMJDCP, IEnumerable<PersistenceView> AONGJLILFGH, NGGJLDGMDCB FLPECDDACOM);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NNKBBCFLGIC(ELNFILGNBCL LALHNMMJDCP);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DPFFFCHJNCD(JBHCDHCPMCM AGJJPHKFJFF, [In] LHDGHOEKHHB KLFEPFLKKDP);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task ALCKMJIAAEJ(ELNFILGNBCL AEHMMJMEEDB, bool OOPJOLIKJPP, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task PDIACMJHODH(CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void APPHKKDLLDI(long ODPLBFKINCE, long CNKFDDFGKPE, HEKEHEGBBLG MBIKCDFGAEL, KIKHMLAGMKE GHCFMNOIFDG, CEIMFNJANHL AKFMCNAFBFA, BFOHOABJCJF? GBODCICDBDD, KLDKAMMCIHI? KHMJPBEHNHE);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LKJCBJGMKIH(long ODPLBFKINCE, long CNKFDDFGKPE, KLDKAMMCIHI? KHMJPBEHNHE);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void AHLAOKBNLDP(PersistenceView PHKDKDNCDBK);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool FOEGDILHEAN(PersistenceView KBMGDEBBCNM);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool DCDDDJLBNMM(JBHCDHCPMCM AGJJPHKFJFF, BIPJOHNJPOB NCIJEBJJAKH, [Out] MFKKNAKAFKL ONHIOGHLEJI);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task PGNKKKFOJKJ(CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void HEEDLPBKIFK();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IDisposable IAEMAAEDNGJ();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void LBKHAHGOHIG(ELNFILGNBCL AEHMMJMEEDB, BIPJOHNJPOB NCIJEBJJAKH);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<bool> OHJKKNEFIKJ(PBDPFIHDLBN JDIFANIOFLI, CancellationToken BCCDJHNACKO, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void GCHNKBLDKJF(CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<PAFEDHKBAIE> NABCHOJOKGG(PHHANDPABNP BHMKONDNBED);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<HEKEHEGBBLG> IJDMKKDEHIK(long ODPLBFKINCE, bool LFCBPKLOPGN, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<KIKHMLAGMKE> LNOCCJNMKIJ(long ODPLBFKINCE, long CNKFDDFGKPE, long DLONNEIPGNE, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<LNDNFODDKGM> DNGKFONHDJP(string HLFLAICBGJM, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<LNDNFODDKGM> GPFOOMDPMHL(string HLFLAICBGJM, long ODPLBFKINCE, long CNKFDDFGKPE, string JEEIKFCHBFO, PMDDIMOKLPO.OMOIJHKFOPO EDDLBMGEMFE, PMDDIMOKLPO.OMOIJHKFOPO GDJNMGOCFKN, int OCBCHOCNCAE);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool DIJCLFLPECC();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool MIKCECFDLLI();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool EJDLNOGINFN(IEnumerable<MFKKNAKAFKL> NHBJHAJJIIJ);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void FJLBENGAACD(List<GameObject> GKEJDEHNJKE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float LEJGDDGKNPH();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<Scene> LOKBAONEPEC(string NBIMMAELPMJ, LoadSceneMode EPKDNEEDHHL, bool AAJJDIOINFF, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void JGNBFNDMLPJ();

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void FNOBAOFLOGH(bool FCMINLNDGAI);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void PAEJNIDKBJF(KGDNOOKHPHA LKFGFDLPIAN);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "58")]
	Task CMFALAKGMCJ(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task DHAGMHKKCND(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task LPDCNAGCADD(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "61")]
	IDisposable KAJEPHFGIMA();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "62")]
	INELBIHCEHA KJKIONIEMAE();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task FIHHICAOKGK(CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface INELBIHCEHA
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MPOEEFMBJOF(CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AOMPIHEAJAI(CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct LHDGHOEKHHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> LCKNDAMGCME;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum LJDLMNGAONA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct EBDAGPGFMGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string IEPKBHEBKBD;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KINEDFAPICD
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	KGDNOOKHPHA NBHNAJLLMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	HEKEHEGBBLG FFIDNHJHEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	MLODPAAEOEO JMLBBDFDJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool FCOFEOKJFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool LOCLOAGCNCO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	int ELOAAFCHOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action GKKILIGFEBF;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> ODFMCKOIEPF;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ILBHCFJJMMO();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.HHGICFNLFNC> JBFLDIDNPMA(long CNOCCAPLFKN, [Optional] CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<MHAGBOKEBOL> CKIJBFFEDBN();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task NFEHDBKJKEF();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(KGDNOOKHPHA, EFHCEIBOJHF) MHEPCPCGGMI();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PAIBCHOHLHM ODNOECMAMEP();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IGFELNOCGPP(long CNOCCAPLFKN);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface FJPEOIADANF
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LAHKMHHLFAO([Out] IEnumerable<int> HBHDBHDOCEC);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPENCKNILBH(OHJELKPNANC EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMPHNHBMBEK(OHJELKPNANC EKDHBKMFLGI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface BCNAJMOGOAH
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CPGMIBCOEDI(DBGMMOMFJAO CAKOBMLPJNF);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface NOMFMNCMEED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNPFKAHCHEO(IAOCGOGLIOK.JLABLOGJALD PMFLCGNNBPI);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCFDKIAKOHA(IAOCGOGLIOK.JLABLOGJALD PMFLCGNNBPI);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface OGPMEHACKPF : NOMFMNCMEED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBGMMOMFJAO KPBFOKPIDPG(OOAELAJMHEN MMNBPGKPJPG);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PDFONMCLKJM : NOMFMNCMEED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBGMMOMFJAO LMBJKMIIFEE(OOAELAJMHEN DPOAKIJENBG);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NOHCFMGPLCA
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FEBPNEDDNDE<KHKNCAJFODO, DBMNCLOBEEI>> LHJKFCKCJCO(string JEEIKFCHBFO, long CNOCCAPLFKN, ABHGIDAJLOA.IHCPKNLNFMO IMPJGHPEJJO, CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface JNECKGCIOFK<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FEBPNEDDNDE<byte[], DBMNCLOBEEI>> GKEBCNBPAFB(TGetDataArg GIMGFOJNMGL, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FEBPNEDDNDE<LNAHKIJCHLB<TData>, DBMNCLOBEEI> OGNIGJOHGGO(byte[] LMCJHCIOIIP);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class KELOEAHKOGC : JHENEJKEAOJ, OPGHBJJICOK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct IFEBBPPDLII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<DBGMMOMFJAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public KELOEAHKOGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public KOAFPCAGHPM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<DBGMMOMFJAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6210640", Offset = "0x620F440", VA = "0x186210640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x62108C0", Offset = "0x620F6C0", VA = "0x1862108C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct LJIPNGHMCIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public KELOEAHKOGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6215940", Offset = "0x6214740", VA = "0x186215940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6215B70", Offset = "0x6214970", VA = "0x186215B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class NEDHCBGBKIO : IEnumerable<IEHKIJJJKOK>, IEnumerable, IEnumerator<IEHKIJJJKOK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private IEHKIJJJKOK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public KELOEAHKOGC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private IEHKIJJJKOK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x86F050", Offset = "0x86DE50", VA = "0x18086F050")]
		[DebuggerHidden]
		public NEDHCBGBKIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x62177D0", Offset = "0x62165D0", VA = "0x1862177D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6217C30", Offset = "0x6216A30", VA = "0x186217C30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6217B80", Offset = "0x6216980", VA = "0x186217B80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IEHKIJJJKOK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6217B80", Offset = "0x6216980", VA = "0x186217B80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource LBPDDKNHNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly NNIGDKDCOBN LAJBGPNDGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private GKKLBCDCAPK MLMCAIEOEIK;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public PBDPFIHDLBN GJDPBDOIJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7656B0", Offset = "0x7644B0", VA = "0x1807656B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x765450", Offset = "0x764250", VA = "0x180765450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public JDLCCAPLPFA DABMPHNEMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x760F10", Offset = "0x75FD10", VA = "0x180760F10", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x760F50", Offset = "0x75FD50", VA = "0x180760F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GJEKPDGJJHD HGMDPNHJIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x760EF0", Offset = "0x75FCF0", VA = "0x180760EF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x760F00", Offset = "0x75FD00", VA = "0x180760F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public OOLPJEPAFOA ENHEBJJFOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x760F60", Offset = "0x75FD60", VA = "0x180760F60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x760F20", Offset = "0x75FD20", VA = "0x180760F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public OGPMEHACKPF PBPPPOHMFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x760F30", Offset = "0x75FD30", VA = "0x180760F30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x760F40", Offset = "0x75FD40", VA = "0x180760F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public PDFONMCLKJM OMBGNHMJACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x768A70", Offset = "0x767870", VA = "0x180768A70", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x768A80", Offset = "0x767880", VA = "0x180768A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public MLCFHDEFMPO FBJFMPOCCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766770", VA = "0x180767970", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x767910", Offset = "0x766710", VA = "0x180767910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public BENFFKBABLP AADJHDBEGME
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7678E0", Offset = "0x7666E0", VA = "0x1807678E0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7678D0", Offset = "0x7666D0", VA = "0x1807678D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public GCMDDFAJNHD LKJDKDMPKKF
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7679F0", Offset = "0x7667F0", VA = "0x1807679F0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x767860", Offset = "0x766660", VA = "0x180767860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public EEFOCEBODCN AJDFKECCOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x827700", Offset = "0x826500", VA = "0x180827700", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8277E0", Offset = "0x8265E0", VA = "0x1808277E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public AJIHCNJODIL MLENLCONPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x767990", Offset = "0x766790", VA = "0x180767990", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7679D0", Offset = "0x7667D0", VA = "0x1807679D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public DPIALHIJIPF EEECOFCEDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x89EB10", Offset = "0x89D910", VA = "0x18089EB10", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x89FCC0", Offset = "0x89EAC0", VA = "0x18089FCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public JOKPCMCNMAM IPBKKCIBJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x762AB0", Offset = "0x7618B0", VA = "0x180762AB0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x762B30", Offset = "0x761930", VA = "0x180762B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public IIICFOAGJCD KFPCIMMPMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B7ED0", VA = "0x1808B90D0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8B9370", Offset = "0x8B8170", VA = "0x1808B9370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public AKFFNDGCCGK PCOBEDEDABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x83B840", Offset = "0x83A640", VA = "0x18083B840", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9310", Offset = "0x8B8110", VA = "0x1808B9310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public OLGNNCBODHL MBNAIBCCCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8B90E0", Offset = "0x8B7EE0", VA = "0x1808B90E0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8B9390", Offset = "0x8B8190", VA = "0x1808B9390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public OFGJJCKCANF JMACOOFKJFF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8111D0", Offset = "0x80FFD0", VA = "0x1808111D0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9330", Offset = "0x8B8130", VA = "0x1808B9330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public MELHAOKFPOJ EKBNGACHMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8B90F0", Offset = "0x8B7EF0", VA = "0x1808B90F0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8B93B0", Offset = "0x8B81B0", VA = "0x1808B93B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public NJNGIFKKLFA EBIKGDMIGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x762AC0", Offset = "0x7618C0", VA = "0x180762AC0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x762AF0", Offset = "0x7618F0", VA = "0x180762AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public BAKMENKFKPG BPLFBGEONKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7DA850", Offset = "0x7D9650", VA = "0x1807DA850", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7DA860", Offset = "0x7D9660", VA = "0x1807DA860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public CMMNPOOLMEK BJODIEJKDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8B90C0", Offset = "0x8B7EC0", VA = "0x1808B90C0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8B9350", Offset = "0x8B8150", VA = "0x1808B9350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public FIBNAAJNLBK INPLCPKECGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8B90B0", Offset = "0x8B7EB0", VA = "0x1808B90B0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8B92F0", Offset = "0x8B80F0", VA = "0x1808B92F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public LEJJNNKMGAJ OFFAEHOGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8B9230", Offset = "0x8B8030", VA = "0x1808B9230", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8B95F0", Offset = "0x8B83F0", VA = "0x1808B95F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public FJPEOIADANF KDEFDHCILLD
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8B9210", Offset = "0x8B8010", VA = "0x1808B9210", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8B95B0", Offset = "0x8B83B0", VA = "0x1808B95B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public AOIFNCCAFCG JNFMFHGLFNL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8B91A0", Offset = "0x8B7FA0", VA = "0x1808B91A0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8B94D0", Offset = "0x8B82D0", VA = "0x1808B94D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public CNCDPBAGGGJ FDMCPHNBFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8B9170", Offset = "0x8B7F70", VA = "0x1808B9170", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8B9470", Offset = "0x8B8270", VA = "0x1808B9470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public OGLKJICEBDG FCCOFAEODGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8B9220", Offset = "0x8B8020", VA = "0x1808B9220", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8B95D0", Offset = "0x8B83D0", VA = "0x1808B95D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EFINLOBHEIP AGLPDDCCDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xBDED00", Offset = "0xBDDB00", VA = "0x180BDED00", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public HEGHLEEBPHE KLADGDHDHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8B91E0", Offset = "0x8B7FE0", VA = "0x1808B91E0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public ANOJCLPMAOC JADFPOAPFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8B9180", Offset = "0x8B7F80", VA = "0x1808B9180", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public EFHCEIBOJHF FHCGEPGNJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8B9130", Offset = "0x8B7F30", VA = "0x1808B9130", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8B93F0", Offset = "0x8B81F0", VA = "0x1808B93F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private bool IEEEFEFHIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6212380", Offset = "0x6211180", VA = "0x186212380", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private bool LHILPJABJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6212910", Offset = "0x6211710", VA = "0x186212910", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private CancellationToken FAILDALMGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x62126F0", Offset = "0x62114F0", VA = "0x1862126F0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private NNIGDKDCOBN LNGMAIMNEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action JPHKAHLDLHG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6212580", Offset = "0x6211380", VA = "0x186212580", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x62122C0", Offset = "0x62110C0", VA = "0x1862122C0", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event GKNHHMGBNGO MKFODJNFLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6212260", Offset = "0x6211060", VA = "0x186212260", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6212A50", Offset = "0x6211850", VA = "0x186212A50", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event GKNHHMGBNGO NOJFAEKJFNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6212320", Offset = "0x6211120", VA = "0x186212320", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6212990", Offset = "0x6211790", VA = "0x186212990", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event GKNHHMGBNGO LEIGHPMJBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x62129F0", Offset = "0x62117F0", VA = "0x1862129F0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x62125E0", Offset = "0x62113E0", VA = "0x1862125E0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<HDCLEDKOAAP, bool> LOABHGBENII
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x62120F0", Offset = "0x6210EF0", VA = "0x1862120F0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6212AB0", Offset = "0x62118B0", VA = "0x186212AB0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8B93F0", Offset = "0x8B81F0", VA = "0x1808B93F0", Slot = "35")]
	public void CLPIDHKDCEE(EFHCEIBOJHF JAAGMOEAJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6212B10", Offset = "0x6211910", VA = "0x186212B10")]
	[UnityEngine.Scripting.Preserve]
	internal KELOEAHKOGC([FGPOJKOJBFM(null)] NNIGDKDCOBN LAJBGPNDGLJ, [FGPOJKOJBFM(null)] PBDPFIHDLBN JDIFANIOFLI, [FGPOJKOJBFM(null)] JDLCCAPLPFA GKOFDMDLPPD, [FGPOJKOJBFM(null)] GJEKPDGJJHD JOJOJMCMCEP, [FGPOJKOJBFM(null)] OOLPJEPAFOA MKPLLJPJHEA, [FGPOJKOJBFM(null)] OGPMEHACKPF NMPMDDFPPKE, [FGPOJKOJBFM(null)] PDFONMCLKJM PIHGIHLIILL, [FGPOJKOJBFM(null)] MLCFHDEFMPO BLBEIHCAEIO, [FGPOJKOJBFM(null)] BENFFKBABLP CDGOACEIIIN, [FGPOJKOJBFM(null)] GCMDDFAJNHD MNBJBHCDABD, [FGPOJKOJBFM(null)] EEFOCEBODCN IHKLGGEBFNE, [FGPOJKOJBFM(null)] AJIHCNJODIL CCBLDCIMLAL, [FGPOJKOJBFM(null)] DPIALHIJIPF ENCKNIABMAN, [FGPOJKOJBFM(null)] JOKPCMCNMAM OHJLKJDCMFP, [FGPOJKOJBFM(null)] IIICFOAGJCD HPENABFIBPA, [FGPOJKOJBFM(null)] AKFFNDGCCGK FJAOHBKEDKG, [FGPOJKOJBFM(null)] OLGNNCBODHL JNJJGNPPEMP, [FGPOJKOJBFM(null)] OFGJJCKCANF FOOLBLHIIMM, [FGPOJKOJBFM(null)] MELHAOKFPOJ PEFHGFKMCMG, [FGPOJKOJBFM(null)] NJNGIFKKLFA JIBEHDPBDBH, [FGPOJKOJBFM(null)] CMMNPOOLMEK KAEHFJHHNFJ, [FGPOJKOJBFM(null)] BAKMENKFKPG CPAAECPGNGO, [FGPOJKOJBFM(null)] FIBNAAJNLBK JEJMBFKDNDO, [FGPOJKOJBFM(null)] LEJJNNKMGAJ BGNCIAPIMIL, [FGPOJKOJBFM(null)] FJPEOIADANF IMEOANDIGFI, [FGPOJKOJBFM(null)] CNCDPBAGGGJ ODAKGFFPNLL, [FGPOJKOJBFM(null)] OGLKJICEBDG KAFCAHLMAMJ, [FGPOJKOJBFM(null)] EFINLOBHEIP LHLBFJMMNPF, [FGPOJKOJBFM(null)] HEGHLEEBPHE CICLDIGOJFI, [FGPOJKOJBFM(null)] ANOJCLPMAOC EJKPBOALKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6212640", Offset = "0x6211440", VA = "0x186212640")]
	private void HCKCHEHGBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x62123E0", Offset = "0x62111E0", VA = "0x1862123E0", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6211FB0", Offset = "0x6210DB0", VA = "0x186211FB0", Slot = "48")]
	private void ADENFGILIHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6212000", Offset = "0x6210E00", VA = "0x186212000", Slot = "49")]
	private COCNALHNELK AHOCBMFODDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6212710", Offset = "0x6211510", VA = "0x186212710", Slot = "50")]
	private CLODLNHKJBB IKOFMDPGALM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6212150", Offset = "0x6210F50", VA = "0x186212150", Slot = "51")]
	[AsyncStateMachine(typeof(IFEBBPPDLII))]
	private Task<DBGMMOMFJAO> BCLOMEDFPFC(KOAFPCAGHPM FBHFFEMKPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x62127A0", Offset = "0x62115A0", VA = "0x1862127A0", Slot = "52")]
	[AsyncStateMachine(typeof(LJIPNGHMCIJ))]
	private Task JIKGKJBGLPD(CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6212890", Offset = "0x6211690", VA = "0x186212890")]
	[IteratorStateMachine(typeof(NEDHCBGBKIO))]
	private IEnumerable<IEHKIJJJKOK> KDOPMLCKBHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6212090", Offset = "0x6210E90", VA = "0x186212090")]
	[CompilerGenerated]
	private void AMOOLPMLLIP(IEHKIJJJKOK KDELPFFKINA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class JCIBBJKOBME : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0xC2BE50", Offset = "0xC2AC50", VA = "0x180C2BE50")]
	public JCIBBJKOBME(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class LAJEFJJFPOK : BKGFFBGAODH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct IMNIHNLAMOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LAJEFJJFPOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6211320", Offset = "0x6210120", VA = "0x186211320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6211660", Offset = "0x6210460", VA = "0x186211660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly GJEKPDGJJHD JOJOJMCMCEP;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7604C0", Offset = "0x75F2C0", VA = "0x1807604C0")]
	public LAJEFJJFPOK(JHENEJKEAOJ KFCMDEBDJKP, GJEKPDGJJHD JOJOJMCMCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6213F30", Offset = "0x6212D30", VA = "0x186213F30", Slot = "4")]
	[AsyncStateMachine(typeof(IMNIHNLAMOF))]
	public Task<bool> FLOADBDAFGF(CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6214020", Offset = "0x6212E20", VA = "0x186214020")]
	[CompilerGenerated]
	private object OJBACAJCKPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class IMJOAIPODCH : BKGFFBGAODH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct AHJACEFLMMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public IMJOAIPODCH <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x61FCFE0", Offset = "0x61FBDE0", VA = "0x1861FCFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x61FD6F0", Offset = "0x61FC4F0", VA = "0x1861FD6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly GJEKPDGJJHD JOJOJMCMCEP;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private KINEDFAPICD IJAIOKDAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x62112D0", Offset = "0x62100D0", VA = "0x1862112D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7604C0", Offset = "0x75F2C0", VA = "0x1807604C0")]
	public IMJOAIPODCH(JHENEJKEAOJ KFCMDEBDJKP, GJEKPDGJJHD JOJOJMCMCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x62110C0", Offset = "0x620FEC0", VA = "0x1862110C0", Slot = "4")]
	[AsyncStateMachine(typeof(AHJACEFLMMF))]
	public Task<bool> FLOADBDAFGF(CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x62111F0", Offset = "0x620FFF0", VA = "0x1862111F0")]
	[CompilerGenerated]
	private object HGHBGCBEAGM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class HJIOMAOBLIM : BKGFFBGAODH
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class HPNMBBEGLBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public HJIOMAOBLIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public MHAGBOKEBOL result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public KGDNOOKHPHA newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HPNMBBEGLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x620FE10", Offset = "0x620EC10", VA = "0x18620FE10")]
		internal object OMHLFKIJNOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x620FDA0", Offset = "0x620EBA0", VA = "0x18620FDA0")]
		internal object NAIFIBDDGBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x620FD00", Offset = "0x620EB00", VA = "0x18620FD00")]
		internal object FAFKEDFGGHP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct PBJGAIBCBCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public HJIOMAOBLIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private HPNMBBEGLBL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<MHAGBOKEBOL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6219D70", Offset = "0x6218B70", VA = "0x186219D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x621A6A0", Offset = "0x62194A0", VA = "0x18621A6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly GJEKPDGJJHD JOJOJMCMCEP;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private KINEDFAPICD IJAIOKDAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x620F340", Offset = "0x620E140", VA = "0x18620F340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7604C0", Offset = "0x75F2C0", VA = "0x1807604C0")]
	public HJIOMAOBLIM(JHENEJKEAOJ KFCMDEBDJKP, GJEKPDGJJHD JOJOJMCMCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x620F220", Offset = "0x620E020", VA = "0x18620F220", Slot = "4")]
	[AsyncStateMachine(typeof(PBJGAIBCBCC))]
	public Task<bool> FLOADBDAFGF(CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal interface BKGFFBGAODH
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> FLOADBDAFGF(CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct ODKIBNGGLEA
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class CNHDOOBIBBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public JHENEJKEAOJ manager;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public CNHDOOBIBBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x61FF5C0", Offset = "0x61FE3C0", VA = "0x1861FF5C0")]
		internal Task KFMOIKPAFBK(NNEDCLBDCDJ data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct CECBPLMJBAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public ODKIBNGGLEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private KOAFPCAGHPM <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<LJDLMNGAONA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<DBGMMOMFJAO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x61FEAE0", Offset = "0x61FD8E0", VA = "0x1861FEAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x61FF070", Offset = "0x61FDE70", VA = "0x1861FF070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct MEKKEFCIHCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public ODKIBNGGLEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6216070", Offset = "0x6214E70", VA = "0x186216070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6216390", Offset = "0x6215190", VA = "0x186216390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken BCCDJHNACKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly JHENEJKEAOJ AMCDJKCDDEF;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private PBDPFIHDLBN GJDPBDOIJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x62188C0", Offset = "0x62176C0", VA = "0x1862188C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private GJEKPDGJJHD HGMDPNHJIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6218870", Offset = "0x6217670", VA = "0x186218870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private KINEDFAPICD IJAIOKDAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6218F30", Offset = "0x6217D30", VA = "0x186218F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private GCMDDFAJNHD LKJDKDMPKKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6218C00", Offset = "0x6217A00", VA = "0x186218C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1C64E00", Offset = "0x1C63C00", VA = "0x181C64E00")]
	public ODKIBNGGLEA(CancellationToken BCCDJHNACKO, JHENEJKEAOJ AMCDJKCDDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6218B50", Offset = "0x6217950", VA = "0x186218B50")]
	public static MLIGFPPLKBD KGHDMNIKIOK(JHENEJKEAOJ AMCDJKCDDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6218910", Offset = "0x6217710", VA = "0x186218910")]
	[AsyncStateMachine(typeof(CECBPLMJBAK))]
	public Task<bool> INEHGKEHGLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6218C50", Offset = "0x6217A50", VA = "0x186218C50")]
	private bool LEMDJNLMILN([Out] KOAFPCAGHPM FBHFFEMKPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6218E60", Offset = "0x6217C60", VA = "0x186218E60")]
	[AsyncStateMachine(typeof(MEKKEFCIHCD))]
	private Task LJKENKOIIND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6218A20", Offset = "0x6217820", VA = "0x186218A20")]
	private Task<LJDLMNGAONA> JDKDNHBHDBL(KOAFPCAGHPM HDHBGJPINPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct DPNNCJCJBCE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly IIICFOAGJCD HPENABFIBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid ODNBBNPINDD;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private Task<(DBGMMOMFJAO, Task)> JJOLGFOGMPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6205C40", Offset = "0x6204A40", VA = "0x186205C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x39344C0", Offset = "0x39332C0", VA = "0x1839344C0")]
	public DPNNCJCJBCE(IIICFOAGJCD HPENABFIBPA, Guid ODNBBNPINDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6205DE0", Offset = "0x6204BE0", VA = "0x186205DE0")]
	public TaskAwaiter<(DBGMMOMFJAO, Task)> HAGMPFAAMAB()
	{
		return default(TaskAwaiter<(DBGMMOMFJAO, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6205D10", Offset = "0x6204B10", VA = "0x186205D10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct DILIGJFFGKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(DBGMMOMFJAO, Task)> JGFHHEPHELD;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Task<(DBGMMOMFJAO, Task)> JJOLGFOGMPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6205000", Offset = "0x6203E00", VA = "0x186205000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6205250", Offset = "0x6204050", VA = "0x186205250")]
	public DILIGJFFGKI(TimeSpan PNDCNOOMJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x62051B0", Offset = "0x6203FB0", VA = "0x1862051B0")]
	public void PPPGGLIICOK(Task OFNAIJJLDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6205120", Offset = "0x6203F20", VA = "0x186205120")]
	public void PPHOGNONJDE(DBGMMOMFJAO CAKOBMLPJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6205040", Offset = "0x6203E40", VA = "0x186205040")]
	public void KANBABAMGPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6205090", Offset = "0x6203E90", VA = "0x186205090")]
	internal void MJPBDHMKICM(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class IGAEGGFCLFN
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KKFAPIMIFNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public KIKHMLAGMKE subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public KKFAPIMIFNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6213F00", Offset = "0x6212D00", VA = "0x186213F00")]
		internal bool MJALHFABMEP(MLODPAAEOEO s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6210C50", Offset = "0x620FA50", VA = "0x186210C50")]
	public static MMILHCEGCHA FLMMCOJOBIA(long LCHNGIBNMLJ, long CNKFDDFGKPE, string HLFLAICBGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6210CE0", Offset = "0x620FAE0", VA = "0x186210CE0")]
	public static MMILHCEGCHA FLMMCOJOBIA(long LCHNGIBNMLJ, long CNKFDDFGKPE, JBEOIFKKBLD DBBBPLGPHMP, long DLONNEIPGNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6210AC0", Offset = "0x620F8C0", VA = "0x186210AC0")]
	public static MMILHCEGCHA FLMMCOJOBIA(PAFEDHKBAIE IEEBGCPINCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6210DA0", Offset = "0x620FBA0", VA = "0x186210DA0")]
	public static MMILHCEGCHA FLMMCOJOBIA(HEKEHEGBBLG LMJFDMHELBO, KIKHMLAGMKE GHCFKIPBEHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6210FD0", Offset = "0x620FDD0", VA = "0x186210FD0")]
	public static MMILHCEGCHA LHMGICDEGNA(this MMILHCEGCHA JOPBACODGFL, HEKEHEGBBLG MPAFADCKECN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6210930", Offset = "0x620F730", VA = "0x186210930")]
	public static MMILHCEGCHA FEDLLGNNDLA(this MMILHCEGCHA JOPBACODGFL, KIKHMLAGMKE AAEKKKAJBHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class OFLFHEOAJGG : BENFFKBABLP, IEHKIJJJKOK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct IDCNDOOMJMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public OFLFHEOAJGG <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x620FF00", Offset = "0x620ED00", VA = "0x18620FF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x62105E0", Offset = "0x620F3E0", VA = "0x1862105E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly OHJELKPNANC LADHIKOHJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string EELFBKDKLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task DHAHIMMBCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool OCGCJNGBAGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x62192C0", Offset = "0x62180C0", VA = "0x1862192C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public Task BABPJCBBPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x62190D0", Offset = "0x6217ED0", VA = "0x1862190D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x766E40", Offset = "0x765C40", VA = "0x180766E40", Slot = "7")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6219160", Offset = "0x6217F60", VA = "0x186219160", Slot = "6")]
	public void JIJFACBJKHE(Task DPNKBPFBJPJ, string LFOFLDIBOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6218FB0", Offset = "0x6217DB0", VA = "0x186218FB0")]
	[AsyncStateMachine(typeof(IDCNDOOMJMP))]
	private Task BIJLINDOAON(Task BDFINHEMLAL, string LFOFLDIBOIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x62192F0", Offset = "0x62180F0", VA = "0x1862192F0")]
	public OFLFHEOAJGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class LMLIOBKMBIF : AOIFNCCAFCG, IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool ACPNPKBKEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private NGAGHHIMGOM IAHGEJGJLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private PBDPFIHDLBN JDIFANIOFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private CNCDPBAGGGJ ODAKGFFPNLL;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public NGAGHHIMGOM KNAEICMJFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6215F40", Offset = "0x6214D40", VA = "0x186215F40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6215DC0", Offset = "0x6214BC0", VA = "0x186215DC0", Slot = "7")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6215C10", Offset = "0x6214A10", VA = "0x186215C10", Slot = "5")]
	public void FKCBHNEHKDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6215BD0", Offset = "0x62149D0", VA = "0x186215BD0", Slot = "6")]
	public void NCLLNEAJCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6215FB0", Offset = "0x6214DB0", VA = "0x186215FB0")]
	private Task NOOKJFLEFPJ(HAPBAMNGMLC KNIBDNLMNEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6215BD0", Offset = "0x62149D0", VA = "0x186215BD0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LMLIOBKMBIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class DAMCFMICODE : CNCDPBAGGGJ
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class FEDDOGOCCCA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly HHNMHMLGNNC KHGGILHKCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly string GMOPMNAPKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly T PPFOBEPKLDB;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public T CAGIMKNDHKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x7B03C0", Offset = "0x7AF1C0", VA = "0x1807B03C0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x8A83F0", Offset = "0x8A71F0", VA = "0x1808A83F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x33A0CE0", Offset = "0x339FAE0", VA = "0x1833A0CE0")]
		public FEDDOGOCCCA(HHNMHMLGNNC KHGGILHKCGP, string GMOPMNAPKBE, T PPFOBEPKLDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x33A0A80", Offset = "0x339F880", VA = "0x1833A0A80")]
		private void DPBFOEMGFHK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly HHNMHMLGNNC KHGGILHKCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly FEDDOGOCCCA<TimeSpan> KJNHPBHOBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly FEDDOGOCCCA<TimeSpan> CEIEFKGAKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly FEDDOGOCCCA<TimeSpan> AEBCIDEHPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly FEDDOGOCCCA<TimeSpan> EBLMMHBIALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly FEDDOGOCCCA<bool> OPKNCICEEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly FEDDOGOCCCA<bool> DMCDMEPIDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly FEDDOGOCCCA<bool> PGDHPBMKIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly FEDDOGOCCCA<int> MFOEPFBFLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly FEDDOGOCCCA<bool> GCDDNEHMPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly FEDDOGOCCCA<bool> BMFHFNOPFEE;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan EAOHDAANAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x61FF710", Offset = "0x61FE510", VA = "0x1861FF710", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan PGGNAHLBDOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x61FF950", Offset = "0x61FE750", VA = "0x1861FF950", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TimeSpan AOHIPMDGOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x61FF810", Offset = "0x61FE610", VA = "0x1861FF810", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public TimeSpan HCEIGIBLGED
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x61FF8D0", Offset = "0x61FE6D0", VA = "0x1861FF8D0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool DMNHLGLFNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x61FF790", Offset = "0x61FE590", VA = "0x1861FF790", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool PLDGKJAOFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x61FF750", Offset = "0x61FE550", VA = "0x1861FF750", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool KPGPCOFPMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x61FF890", Offset = "0x61FE690", VA = "0x1861FF890", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int GBKKLAFIJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x61FF850", Offset = "0x61FE650", VA = "0x1861FF850", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool PBFPJCGOCBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x61FF910", Offset = "0x61FE710", VA = "0x1861FF910", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool OPGKKMPEKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x61FF7D0", Offset = "0x61FE5D0", VA = "0x1861FF7D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x61FF990", Offset = "0x61FE790", VA = "0x1861FF990")]
	[UnityEngine.Scripting.Preserve]
	public DAMCFMICODE([FGPOJKOJBFM(null)] HHNMHMLGNNC KHGGILHKCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[UnityEngine.Scripting.Preserve]
internal class ENGFBHKFDCJ : EEFOCEBODCN, IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class JCFEMLEEMGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public NDKKOBMILDL roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JCFEMLEEMGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6211ED0", Offset = "0x6210CD0", VA = "0x186211ED0")]
		internal object EOPEBFKFHBN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action NCCOOGJEGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x62069A0", Offset = "0x62057A0", VA = "0x1862069A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6206900", Offset = "0x6205700", VA = "0x186206900", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event GKNHHMGBNGO DHIGFGHJFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6206740", Offset = "0x6205540", VA = "0x186206740", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x62064B0", Offset = "0x62052B0", VA = "0x1862064B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event GKNHHMGBNGO FAHKCDMKIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6206550", Offset = "0x6205350", VA = "0x186206550", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6206860", Offset = "0x6205660", VA = "0x186206860", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event GKNHHMGBNGO MIMCHCBEGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6206220", Offset = "0x6205020", VA = "0x186206220", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x62066A0", Offset = "0x62054A0", VA = "0x1862066A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<HDCLEDKOAAP, bool> OCIMPHIMLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6206AA0", Offset = "0x62058A0", VA = "0x186206AA0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x62065F0", Offset = "0x62053F0", VA = "0x1862065F0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "19")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6206000", Offset = "0x6204E00", VA = "0x186206000", Slot = "14")]
	public void DAEBMILMGMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6206A40", Offset = "0x6205840", VA = "0x186206A40", Slot = "15")]
	public void NFFHNLBHNNH(NDKKOBMILDL EMCBNIOOAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6206A70", Offset = "0x6205870", VA = "0x186206A70", Slot = "16")]
	public void NKOPICOAKNM(NDKKOBMILDL EMCBNIOOAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6206830", Offset = "0x6205630", VA = "0x186206830", Slot = "17")]
	public void LJLMCAEJEND(NDKKOBMILDL EMCBNIOOAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x62067E0", Offset = "0x62055E0", VA = "0x1862067E0", Slot = "18")]
	public void LDIKPEFKDNF(HDCLEDKOAAP AEGJDAAKNIJ, bool LOKCGABODID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x62062C0", Offset = "0x62050C0", VA = "0x1862062C0")]
	private void FKGDFLCAOJM(GKNHHMGBNGO AIKAAJDIFDJ, NDKKOBMILDL EMCBNIOOAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public ENGFBHKFDCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal class FOEDOGPNNLC : AJIHCNJODIL, IEHKIJJJKOK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct DLKAFLKBLEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public FOEDOGPNNLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6205690", Offset = "0x6204490", VA = "0x186205690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6205BE0", Offset = "0x62049E0", VA = "0x186205BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct MIOMFPFPEKJ : IAsyncStateMachine
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
		public FOEDOGPNNLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6216B80", Offset = "0x6215980", VA = "0x186216B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6217220", Offset = "0x6216020", VA = "0x186217220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class BFOHNJMCOED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public BFOHNJMCOED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x61FDD40", Offset = "0x61FCB40", VA = "0x1861FDD40")]
		internal object PAFCFMNFMMF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct IOHJIKPCGKK : IAsyncStateMachine
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
		public FOEDOGPNNLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private BFOHNJMCOED <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x62116D0", Offset = "0x62104D0", VA = "0x1862116D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6211E60", Offset = "0x6210C60", VA = "0x186211E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class HFAHBKBJHIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HFAHBKBJHIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x620F1B0", Offset = "0x620DFB0", VA = "0x18620F1B0")]
		internal object EPJOGHICPIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private GJEKPDGJJHD JOJOJMCMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private BKGFFBGAODH[] LDDNDGCHANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private CancellationTokenSource AJBHEMPONAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private int NCJDLIOPMCP;

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6209DA0", Offset = "0x6208BA0", VA = "0x186209DA0", Slot = "6")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6209B80", Offset = "0x6208980", VA = "0x186209B80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6209F50", Offset = "0x6208D50", VA = "0x186209F50", Slot = "8")]
	public void NFNENOCCILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6209CC0", Offset = "0x6208AC0", VA = "0x186209CC0", Slot = "5")]
	public void HCJHJJINAMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x62093C0", Offset = "0x62081C0", VA = "0x1862093C0", Slot = "4")]
	[AsyncStateMachine(typeof(DLKAFLKBLEP))]
	public Task AFAFBKAFNPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6209580", Offset = "0x6208380", VA = "0x186209580")]
	private void BFIMOMGIGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6209490", Offset = "0x6208290", VA = "0x186209490")]
	[AsyncStateMachine(typeof(MIOMFPFPEKJ))]
	private Task BAAMEDBLOCK(CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6209E20", Offset = "0x6208C20", VA = "0x186209E20")]
	[AsyncStateMachine(typeof(IOHJIKPCGKK))]
	private Task<bool> LNKJCFNCJPL(int OCMJNDDMDAL, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6209AA0", Offset = "0x62088A0", VA = "0x186209AA0")]
	private void DNILBJACPKA(int OCMJNDDMDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6209890", Offset = "0x6208690", VA = "0x186209890")]
	private void BMDMHCLAIAK(int OCMJNDDMDAL, bool LOKCGABODID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6209970", Offset = "0x6208770", VA = "0x186209970")]
	private void DECLEFKOIOA(int OCMJNDDMDAL, Exception GLNCBNFNGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6209B90", Offset = "0x6208990", VA = "0x186209B90")]
	private void HBECGMDCAPP(CancellationToken BCCDJHNACKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public FOEDOGPNNLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class GBGFONCJCHG : DPIALHIJIPF, IEHKIJJJKOK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct PIIEMCHAKJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public KGDNOOKHPHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public GBGFONCJCHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public EFHCEIBOJHF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x621A790", Offset = "0x6219590", VA = "0x18621A790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x621B150", Offset = "0x6219F50", VA = "0x18621B150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct FKGLDPFECLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public GBGFONCJCHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public KGDNOOKHPHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public EFHCEIBOJHF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private AEMIIEBAFHL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private OMGMONNMAKC <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private OGHOONFNAED <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x6208250", Offset = "0x6207050", VA = "0x186208250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6208E50", Offset = "0x6207C50", VA = "0x186208E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class AKMBCEFJFHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Matchmaking.ICEBNFHCDEP result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public IGPJKNEMLDH errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public AKMBCEFJFHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x61FD760", Offset = "0x61FC560", VA = "0x1861FD760")]
		internal object GHHLFINCIII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class GABEDBLNCBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Task<MMILHCEGCHA> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GABEDBLNCBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		internal Task<MMILHCEGCHA> AFMFFCCABPN(AEMIIEBAFHL<string>.GMENFEPMDPA _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct DGOHJLHGNLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public GBGFONCJCHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public KGDNOOKHPHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public EFHCEIBOJHF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public OMGMONNMAKC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private GABEDBLNCBE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private GKIGKOCEHFL <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private BLJPMIJPLBG <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Task<Matchmaking.HHGICFNLFNC> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private BHHNAJCCAOM <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.HHGICFNLFNC> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<MMILHCEGCHA> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x61FFE00", Offset = "0x61FEC00", VA = "0x1861FFE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6204FA0", Offset = "0x6203DA0", VA = "0x186204FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct LEIDOGBAIDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public GBGFONCJCHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <disconnectTimerScope>5__3;

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
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x62143A0", Offset = "0x62131A0", VA = "0x1862143A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6214E30", Offset = "0x6213C30", VA = "0x186214E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct CJHJNFMOADK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public GBGFONCJCHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private NNIGDKDCOBN <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x61FF0E0", Offset = "0x61FDEE0", VA = "0x1861FF0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x61FF560", Offset = "0x61FE360", VA = "0x1861FF560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct OBKBFLLKEAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder<Matchmaking.HHGICFNLFNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public KGDNOOKHPHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public GBGFONCJCHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter<Matchmaking.HHGICFNLFNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6218300", Offset = "0x6217100", VA = "0x186218300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6218800", Offset = "0x6217600", VA = "0x186218800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct MHOCILPNFFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Matchmaking.HHGICFNLFNC serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public GBGFONCJCHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public OMGMONNMAKC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<MOBHIPAGCOJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x62163F0", Offset = "0x62151F0", VA = "0x1862163F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6216B20", Offset = "0x6215920", VA = "0x186216B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class GOAMJGKKAIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public KGDNOOKHPHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GOAMJGKKAIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x620E160", Offset = "0x620CF60", VA = "0x18620E160")]
		internal object KEFHGFFJNPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x620E260", Offset = "0x620D060", VA = "0x18620E260")]
		internal string PEIAGDKFOBL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct CCOAAJBDDAI : IAsyncStateMachine
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
		public KGDNOOKHPHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public GBGFONCJCHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private GOAMJGKKAIM <>8__1;

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

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x61FDE50", Offset = "0x61FCC50", VA = "0x1861FDE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x61FEA80", Offset = "0x61FD880", VA = "0x1861FEA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct HKNMKDKNGEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public GBGFONCJCHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public OMGMONNMAKC joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public MMILHCEGCHA initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public KGDNOOKHPHA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public GKIGKOCEHFL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x620F390", Offset = "0x620E190", VA = "0x18620F390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x620FCA0", Offset = "0x620EAA0", VA = "0x18620FCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct FDPBENHCMJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public GBGFONCJCHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap3;

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

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6206B50", Offset = "0x6205950", VA = "0x186206B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x62081F0", Offset = "0x6206FF0", VA = "0x1862081F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct OJJDNDHIGDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public GBGFONCJCHG <>4__this;

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
		private TaskAwaiter<DBGMMOMFJAO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x62194E0", Offset = "0x62182E0", VA = "0x1862194E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6219D10", Offset = "0x6218B10", VA = "0x186219D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class EHLCCJPKCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public KGDNOOKHPHA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public EHLCCJPKCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6205E30", Offset = "0x6204C30", VA = "0x186205E30")]
		internal object DONKHBNAGGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class BKHELOGBCEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public BKHELOGBCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x61FDDB0", Offset = "0x61FCBB0", VA = "0x1861FDDB0")]
		internal void JGNOJKGBFEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class PCEHEDHBMED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public KGDNOOKHPHA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public PCEHEDHBMED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x621A710", Offset = "0x6219510", VA = "0x18621A710")]
		internal object DEFOAAIEKPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class COPDMLKCFKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public KGDNOOKHPHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public COPDMLKCFKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x61FF610", Offset = "0x61FE410", VA = "0x1861FF610")]
		internal string FOCMBOHPOIN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly HICMFDICNOL DMFGBOMIKGD;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly HICMFDICNOL JNKPMJJDFOF;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly HICMFDICNOL IJLCIFOOOPH;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly string MNJBIINOKBJ;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string DPJGOJHJADP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string NKGPNGEBOKC;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static readonly Guid MCDPKEPPDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private MLCFHDEFMPO BLBEIHCAEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private JDLCCAPLPFA GKOFDMDLPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private PBDPFIHDLBN JDIFANIOFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private GJEKPDGJJHD JOJOJMCMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private AJIHCNJODIL CCBLDCIMLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private BENFFKBABLP CDGOACEIIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private EEFOCEBODCN IHKLGGEBFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private ANOJCLPMAOC EJKPBOALKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private HEGHLEEBPHE CICLDIGOJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private IDisposable OHMOIIFMKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly OHJELKPNANC PFBLCKHDHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly OHJELKPNANC HBPOMCFANHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private BHHNAJCCAOM JBLIBHGDPNH;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TaskStatus LPPFBJDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x95F270", Offset = "0x95E070", VA = "0x18095F270", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9A8020", Offset = "0x9A6E20", VA = "0x1809A8020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private KINEDFAPICD IJAIOKDAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x620DB80", Offset = "0x620C980", VA = "0x18620DB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x620B590", Offset = "0x620A390", VA = "0x18620B590", Slot = "6")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x620AEA0", Offset = "0x6209CA0", VA = "0x18620AEA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x620AC70", Offset = "0x6209A70", VA = "0x18620AC70", Slot = "5")]
	[AsyncStateMachine(typeof(PIIEMCHAKJE))]
	public Task CJHAFEHMPDI(KGDNOOKHPHA NGIJJKNICEF, EFHCEIBOJHF KCDLCPKNHLF, CancellationToken FJDIBEBBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x620D7B0", Offset = "0x620C5B0", VA = "0x18620D7B0")]
	[AsyncStateMachine(typeof(FKGLDPFECLH))]
	private Task OOOOPGLPEEO(KGDNOOKHPHA NGIJJKNICEF, EFHCEIBOJHF KCDLCPKNHLF, CancellationToken FJDIBEBBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x620CAB0", Offset = "0x620B8B0", VA = "0x18620CAB0")]
	private static void LDEJHKEFNMF(ANOJCLPMAOC EJKPBOALKJF, KGDNOOKHPHA NGIJJKNICEF, Exception GLNCBNFNGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x620C110", Offset = "0x620AF10", VA = "0x18620C110")]
	private static void KKFAPGLMMKK(OGHOONFNAED PNNEFLMLJIK, Exception GLNCBNFNGKL, [Optional] List<int> KOOHDIKIAMK, int NCJDLIOPMCP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x620BFB0", Offset = "0x620ADB0", VA = "0x18620BFB0")]
	[AsyncStateMachine(typeof(DGOHJLHGNLC))]
	private Task KJJFFBCJGMB(AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, KGDNOOKHPHA NGIJJKNICEF, EFHCEIBOJHF KCDLCPKNHLF, OMGMONNMAKC MEMKABDDJLC, CancellationToken FJDIBEBBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x620D1D0", Offset = "0x620BFD0", VA = "0x18620D1D0")]
	private void MNFNHNBEAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x620A5F0", Offset = "0x62093F0", VA = "0x18620A5F0")]
	[AsyncStateMachine(typeof(LEIDOGBAIDI))]
	private Task AJOAKLEKMFJ(AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x620B010", Offset = "0x6209E10", VA = "0x18620B010")]
	private void FCDKAGNDLPJ(KGDNOOKHPHA NGIJJKNICEF, CancellationToken FJDIBEBBHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x620A950", Offset = "0x6209750", VA = "0x18620A950")]
	private void BAOLKDOBOMC(KGDNOOKHPHA NGIJJKNICEF, OMGMONNMAKC MEMKABDDJLC, OperationCanceledException HAPDCPHFLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x620A720", Offset = "0x6209520", VA = "0x18620A720")]
	private void AOJMBABHEND(KGDNOOKHPHA NGIJJKNICEF, OMGMONNMAKC MEMKABDDJLC, Exception GLNCBNFNGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x620D520", Offset = "0x620C320", VA = "0x18620D520")]
	private void OACIBMHPHFE(KGDNOOKHPHA NGIJJKNICEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x620D750", Offset = "0x620C550", VA = "0x18620D750")]
	private static NDKKOBMILDL OEBBDOJAEBC(KGDNOOKHPHA NGIJJKNICEF)
	{
		return default(NDKKOBMILDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x620BA50", Offset = "0x620A850", VA = "0x18620BA50")]
	[AsyncStateMachine(typeof(CJHJNFMOADK))]
	private Task ICIDOHCBELA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x620BB20", Offset = "0x620A920", VA = "0x18620BB20")]
	[AsyncStateMachine(typeof(OBKBFLLKEAN))]
	private Task<Matchmaking.HHGICFNLFNC> JBFLDIDNPMA(KGDNOOKHPHA NGIJJKNICEF, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x620C9A0", Offset = "0x620B7A0", VA = "0x18620C9A0")]
	private static MOBHIPAGCOJ LALMMGAHILK(Matchmaking.HHGICFNLFNC NAAJKJFOKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x620D900", Offset = "0x620C700", VA = "0x18620D900")]
	[AsyncStateMachine(typeof(MHOCILPNFFH))]
	private Task PFJKNPPLPKG(Matchmaking.HHGICFNLFNC NAAJKJFOKJL, OMGMONNMAKC MEMKABDDJLC, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken HCLJJGBIDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x620B350", Offset = "0x620A150", VA = "0x18620B350")]
	[AsyncStateMachine(typeof(CCOAAJBDDAI))]
	private Task FDOOEOBDCMM(KGDNOOKHPHA NGIJJKNICEF, CancellationTokenSource OGNHIHBAFJA, Task BFJDJIGKNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x620A370", Offset = "0x6209170", VA = "0x18620A370")]
	[AsyncStateMachine(typeof(HKNMKDKNGEA))]
	private Task ABFHANENNNI(MMILHCEGCHA CODMCAGINLG, GKIGKOCEHFL LIOPNAGLFNP, KGDNOOKHPHA DIOGLLFIIPP, OMGMONNMAKC OGEMIBGFDPG, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken DHFJHGKIMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x620D320", Offset = "0x620C120", VA = "0x18620D320")]
	private OMGMONNMAKC NPAPPIKHJMA(OMGMONNMAKC OGEMIBGFDPG, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x620DA50", Offset = "0x620C850", VA = "0x18620DA50")]
	[AsyncStateMachine(typeof(FDPBENHCMJH))]
	private Task PICCBGBEEMP(AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x620AEF0", Offset = "0x6209CF0", VA = "0x18620AEF0")]
	[AsyncStateMachine(typeof(OJJDNDHIGDD))]
	private Task EDNMCPNNFLK(NNEDCLBDCDJ LMCJHCIOIIP, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x620BE30", Offset = "0x620AC30", VA = "0x18620BE30")]
	private static void JJALFACIALA(KGDNOOKHPHA NGIJJKNICEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x620CF00", Offset = "0x620BD00", VA = "0x18620CF00")]
	private void LKFBPHLBDHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x620AE10", Offset = "0x6209C10", VA = "0x18620AE10")]
	private void DNAPIOFJCCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x620ABE0", Offset = "0x62099E0", VA = "0x18620ABE0")]
	private void CGGNOJANLOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x620CE70", Offset = "0x620BC70", VA = "0x18620CE70")]
	private void LEECMFHDAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x620B4A0", Offset = "0x620A2A0", VA = "0x18620B4A0")]
	private static void FOHJDNPAIKA(KGDNOOKHPHA NGIJJKNICEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x620A4E0", Offset = "0x62092E0", VA = "0x18620A4E0")]
	private static CancellationTokenRegistration ACBJEPMMFBM(KGDNOOKHPHA NGIJJKNICEF, CancellationToken HCLJJGBIDIL)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x620D0D0", Offset = "0x620BED0", VA = "0x18620D0D0")]
	private static void MJMNNBOPCMO(KGDNOOKHPHA NGIJJKNICEF, Exception GLNCBNFNGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x620BC80", Offset = "0x620AA80", VA = "0x18620BC80")]
	private void JHIEEGOJJCK(KGDNOOKHPHA NGIJJKNICEF, Task BFJDJIGKNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x620AB80", Offset = "0x6209980", VA = "0x18620AB80")]
	private static void BPAIBICBBJL(Func<string> DDCFNAHDILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x620DDF0", Offset = "0x620CBF0", VA = "0x18620DDF0")]
	public GBGFONCJCHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x620ADB0", Offset = "0x6209BB0", VA = "0x18620ADB0")]
	[CompilerGenerated]
	internal static (int, int?) CLBCDBPJJJD(IGPJKNEMLDH OCGNIDFIOOG)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[UnityEngine.Scripting.Preserve]
internal class KIHLNENNGMI : JOKPCMCNMAM, IEHKIJJJKOK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct GNLNJOEJKFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public KIHLNENNGMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public NNEDCLBDCDJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x622AED0", Offset = "0x6229CD0", VA = "0x18622AED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x622B290", Offset = "0x622A090", VA = "0x18622B290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class JCAMJHDGHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public KIHLNENNGMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public NNEDCLBDCDJ roomData;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JCAMJHDGHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x622FC10", Offset = "0x622EA10", VA = "0x18622FC10")]
		internal List<Task> HCNCBFFKAKF(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct FPGJKNIEKCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public MLIGFPPLKBD taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x622A3A0", Offset = "0x62291A0", VA = "0x18622A3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x622A770", Offset = "0x6229570", VA = "0x18622A770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct LKMKEOJJNJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public KIHLNENNGMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x62336F0", Offset = "0x62324F0", VA = "0x1862336F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x62339B0", Offset = "0x62327B0", VA = "0x1862339B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly HashSet<MLIGFPPLKBD> AGOBKDNAFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private JDLCCAPLPFA GKOFDMDLPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private IHMFEHHCOMH BPHHOFNOHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MJMGKHHDHOF MHPJOJMKAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private IDisposable OHMOIIFMKON;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x6213690", Offset = "0x6212490", VA = "0x186213690", Slot = "5")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x62130F0", Offset = "0x6211EF0", VA = "0x1862130F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x6212F50", Offset = "0x6211D50", VA = "0x186212F50", Slot = "4")]
	public bool ALDCIBPCDLM(MLIGFPPLKBD BPIAGEGHLLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6212FB0", Offset = "0x6211DB0", VA = "0x186212FB0")]
	private void BNAGGDEHKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6213910", Offset = "0x6212710", VA = "0x186213910")]
	private void IEMKAKJHEHB(NNEDCLBDCDJ EDDLBMGEMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6213C30", Offset = "0x6212A30", VA = "0x186213C30")]
	[AsyncStateMachine(typeof(GNLNJOEJKFL))]
	private Task MMEGOPJKAFP(NNEDCLBDCDJ EDDLBMGEMFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6213DA0", Offset = "0x6212BA0", VA = "0x186213DA0")]
	private Func<CancellationToken, List<Task>> NGNJKIEMBMH(NNEDCLBDCDJ EDDLBMGEMFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6213220", Offset = "0x6212020", VA = "0x186213220")]
	private List<Task> FIFFKNONLBI(NNEDCLBDCDJ EDDLBMGEMFE, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6213B10", Offset = "0x6212910", VA = "0x186213B10")]
	[AsyncStateMachine(typeof(FPGJKNIEKCH))]
	private Task JFKIIJDHHII(MLIGFPPLKBD PPJDGBLLNCA, NNEDCLBDCDJ LMCJHCIOIIP, CancellationToken EKDHBKMFLGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6213150", Offset = "0x6211F50", VA = "0x186213150")]
	[AsyncStateMachine(typeof(LKMKEOJJNJP))]
	private Task EJBLPNBDJPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6213D20", Offset = "0x6212B20", VA = "0x186213D20")]
	private void NFNENOCCILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6213E70", Offset = "0x6212C70", VA = "0x186213E70")]
	public KIHLNENNGMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[UnityEngine.Scripting.Preserve]
internal sealed class CENJIAKIFPI : IIICFOAGJCD, IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class NAIGBHJOJHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public NAIGBHJOJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x62370C0", Offset = "0x6235EC0", VA = "0x1862370C0")]
		internal object BJMNDBICPNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class AJPJKELHIIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public AJPJKELHIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x621CB20", Offset = "0x621B920", VA = "0x18621CB20")]
		internal object LKILGFIDGDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class GCLHHHENOHF
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GCLHHHENOHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class FDELIPBFMCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public FDELIPBFMCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6227BC0", Offset = "0x62269C0", VA = "0x186227BC0")]
		internal object KFGHJNDBBAA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class LHPMAGKHJJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public LHPMAGKHJJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6233610", Offset = "0x6232410", VA = "0x186233610")]
		internal object JONPLKOOANL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly Dictionary<Guid, DILIGJFFGKI> HPENABFIBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly TimeSpan FFDEDEDPLIC;

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "9")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x62209D0", Offset = "0x621F7D0", VA = "0x1862209D0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x62209E0", Offset = "0x621F7E0", VA = "0x1862209E0", Slot = "4")]
	public DPNNCJCJBCE EJEJBLJEAIN(Guid ODNBBNPINDD)
	{
		return default(DPNNCJCJBCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6220E50", Offset = "0x621FC50", VA = "0x186220E50", Slot = "5")]
	public bool KCJHGNBNEJA(Guid ODNBBNPINDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6221080", Offset = "0x621FE80", VA = "0x186221080", Slot = "6")]
	public bool MLHEJMACAFF(Guid ODNBBNPINDD, Task OFNAIJJLDGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x62207D0", Offset = "0x621F5D0", VA = "0x1862207D0", Slot = "7")]
	public bool CLFJBJKNMAI(Guid ODNBBNPINDD, DBGMMOMFJAO CAKOBMLPJNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6220760", Offset = "0x621F560", VA = "0x186220760", Slot = "8")]
	public Task<(DBGMMOMFJAO, Task)> CJILLGAOAGB(Guid ODNBBNPINDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6220C10", Offset = "0x621FA10", VA = "0x186220C10")]
	private void FMKJCFBOLMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x62213D0", Offset = "0x62201D0", VA = "0x1862213D0")]
	public CENJIAKIFPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[UnityEngine.Scripting.Preserve]
internal class DDNBAGPKBLN : AKFFNDGCCGK, IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class PKKLCGNGNLI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private readonly KGDNOOKHPHA LKFGFDLPIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly CancellationTokenSource AJBHEMPONAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public readonly CancellationToken GNCLJIFHECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private bool FAEBBHJBCFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool ICPHJFMOKBC;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x623AD50", Offset = "0x6239B50", VA = "0x18623AD50")]
		public PKKLCGNGNLI(KGDNOOKHPHA LKFGFDLPIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x623AC00", Offset = "0x6239A00", VA = "0x18623AC00")]
		public void NFNENOCCILA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x623ABD0", Offset = "0x62399D0", VA = "0x18623ABD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class MMKBMJMJCCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public HAPBAMNGMLC disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public MMKBMJMJCCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6235C50", Offset = "0x6234A50", VA = "0x186235C50")]
		internal object AGJEDOGPJIF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct JKMELGNFCLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public HAPBAMNGMLC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public DDNBAGPKBLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6231030", Offset = "0x622FE30", VA = "0x186231030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6231460", Offset = "0x6230260", VA = "0x186231460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class BCLBJINHIOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public BCLBJINHIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x621E190", Offset = "0x621CF90", VA = "0x18621E190")]
		internal object AGPAEIPMOJL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct PCKCBNFHGGG : IAsyncStateMachine
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
		public DDNBAGPKBLN <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6238F20", Offset = "0x6237D20", VA = "0x186238F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x865C40", Offset = "0x864A40", VA = "0x180865C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class JCDHPAMJAEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public KGDNOOKHPHA newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JCDHPAMJAEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x622FC80", Offset = "0x622EA80", VA = "0x18622FC80")]
		internal object BHBMJGABEGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x622FC40", Offset = "0x622EA40", VA = "0x18622FC40")]
		internal object ANDLILOLOEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x622FD20", Offset = "0x622EB20", VA = "0x18622FD20")]
		internal object MDEGDNEBEGM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class OGAMICEAMCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public OGAMICEAMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6237700", Offset = "0x6236500", VA = "0x186237700")]
		internal void LNJMDNAKJGC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct BDNACMHOLLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public KGDNOOKHPHA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public DDNBAGPKBLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public EFHCEIBOJHF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private JCDHPAMJAEG <>8__1;

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

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x621E200", Offset = "0x621D000", VA = "0x18621E200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x621F200", Offset = "0x621E000", VA = "0x18621F200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly LPJDLBDAKBK.DFKGBEBMDDF PBBEBCFONML;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly FPKONPAFMLP KPPPGBBJAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private JDLCCAPLPFA GKOFDMDLPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private AJIHCNJODIL CCBLDCIMLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private GJEKPDGJJHD JOJOJMCMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private CNCDPBAGGGJ ODAKGFFPNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private DPIALHIJIPF ENCKNIABMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private long POGLLKBMIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private PKKLCGNGNLI HMLOIGNBDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private bool IAGFEIKBPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private Task FEDGIONOLPJ;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private KINEDFAPICD IJAIOKDAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6224210", Offset = "0x6223010", VA = "0x186224210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool BJAFPLNJIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA45C90", Offset = "0xA44A90", VA = "0x180A45C90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6223770", Offset = "0x6222570", VA = "0x186223770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6223940", Offset = "0x6222740", VA = "0x186223940", Slot = "4")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6223400", Offset = "0x6222200", VA = "0x186223400", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6223680", Offset = "0x6222480", VA = "0x186223680")]
	[AsyncStateMachine(typeof(JKMELGNFCLA))]
	private Task EMGPEEGEDHD(HAPBAMNGMLC LLEMHCHJLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6223780", Offset = "0x6222580", VA = "0x186223780")]
	private void GKKILIGFEBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6223BE0", Offset = "0x62229E0", VA = "0x186223BE0")]
	private void JOIGMEMJPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6223220", Offset = "0x6222020", VA = "0x186223220")]
	private void BHCNOBCILIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6224260", Offset = "0x6223060", VA = "0x186224260")]
	private bool PPEMHKECPDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6224010", Offset = "0x6222E10", VA = "0x186224010")]
	[AsyncStateMachine(typeof(PCKCBNFHGGG))]
	private void ODFMCKOIEPF(int IOPJNMNEAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6223D80", Offset = "0x6222B80", VA = "0x186223D80")]
	private void NLDCNJHDBHA([Out] IDisposable FODIGHFDPOI, [Out] IDisposable HDHHNAEGOEG, [Out] IDisposable JKIAOEKIOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6223570", Offset = "0x6222370", VA = "0x186223570")]
	private bool ELIFEGONHNO(KGDNOOKHPHA LKFGFDLPIAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x62233B0", Offset = "0x62221B0", VA = "0x1862233B0")]
	private void DEMEFPGOFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x62240E0", Offset = "0x6222EE0", VA = "0x1862240E0")]
	[AsyncStateMachine(typeof(BDNACMHOLLJ))]
	private Task OOOOPGLPEEO(KGDNOOKHPHA LKFGFDLPIAN, EFHCEIBOJHF KCDLCPKNHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x62246A0", Offset = "0x62234A0", VA = "0x1862246A0")]
	public DDNBAGPKBLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[UnityEngine.Scripting.Preserve]
internal sealed class ANDHJACEHKP : OLGNNCBODHL, IEHKIJJJKOK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct LCADMMNKHPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder<HKNPACFPCEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public ANDHJACEHKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter<HKNPACFPCEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x6232870", Offset = "0x6231670", VA = "0x186232870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6232AC0", Offset = "0x62318C0", VA = "0x186232AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class AGBPNKCFBGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public BPADINOBHMJ message;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public AGBPNKCFBGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x621C460", Offset = "0x621B260", VA = "0x18621C460")]
		internal object NJMJFBJOKPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class JGLEKAHHFPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public BPADINOBHMJ messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JGLEKAHHFPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6230FD0", Offset = "0x622FDD0", VA = "0x186230FD0")]
		internal object KPLCLEMKGMK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class CCFPDLAHFKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public BPADINOBHMJ request;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public CCFPDLAHFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6220700", Offset = "0x621F500", VA = "0x186220700")]
		internal object ICJLCKNAKAP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct DLBGONNIANB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public BPADINOBHMJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public ANDHJACEHKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<CKELNELKOJL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6224770", Offset = "0x6223570", VA = "0x186224770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x6225080", Offset = "0x6223E80", VA = "0x186225080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class KLEOPBAJBDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public BPADINOBHMJ operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public KLEOPBAJBDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6232810", Offset = "0x6231610", VA = "0x186232810")]
		internal object BLDFJHDNGJF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct FGOJDHPOMPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public BPADINOBHMJ operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public ANDHJACEHKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private OMGMONNMAKC <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<BPADINOBHMJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x6228440", Offset = "0x6227240", VA = "0x186228440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x6228FF0", Offset = "0x6227DF0", VA = "0x186228FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct KGMOBGAILOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<CKELNELKOJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public ANDHJACEHKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public BPADINOBHMJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private DACGAJAECBE.NLHFIOPBIIO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private OMGMONNMAKC <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter<BPADINOBHMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x62321B0", Offset = "0x6230FB0", VA = "0x1862321B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x62326D0", Offset = "0x62314D0", VA = "0x1862326D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class EJOLFDPGENB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public CKELNELKOJL operation;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public EJOLFDPGENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x62277F0", Offset = "0x62265F0", VA = "0x1862277F0")]
		internal object LDDBGICGHKO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct FMBEDJEFFBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public CKELNELKOJL operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public ANDHJACEHKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private AEMIIEBAFHL<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x6229CC0", Offset = "0x6228AC0", VA = "0x186229CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x622A340", Offset = "0x6229140", VA = "0x18622A340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class INMMAGJGNFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public BPADINOBHMJ request;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public INMMAGJGNFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x622F430", Offset = "0x622E230", VA = "0x18622F430")]
		internal object FHGHNJGFPKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class DEEJMJMLDNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public BPADINOBHMJ request;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public DEEJMJMLDNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6224710", Offset = "0x6223510", VA = "0x186224710")]
		internal object BPLFHECFELI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private BENFFKBABLP CDGOACEIIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private OFGJJCKCANF FOOLBLHIIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private BAKMENKFKPG CPAAECPGNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private PBDPFIHDLBN JDIFANIOFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private TaskCompletionSource<HKNPACFPCEJ> JOMDMOJEPIA;

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x621D6C0", Offset = "0x621C4C0", VA = "0x18621D6C0", Slot = "7")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x621D4B0", Offset = "0x621C2B0", VA = "0x18621D4B0", Slot = "6")]
	[AsyncStateMachine(typeof(LCADMMNKHPA))]
	public Task<HKNPACFPCEJ> DIIFGJNOPLK(CancellationToken CDMOPKIBDMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x621D110", Offset = "0x621BF10", VA = "0x18621D110", Slot = "4")]
	public void ANNKAMNLMMK(BPADINOBHMJ BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x621CDA0", Offset = "0x621BBA0", VA = "0x18621CDA0", Slot = "5")]
	public void ABGAGEAKFOG(BPADINOBHMJ MGCEDNEEEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x621D5C0", Offset = "0x621C3C0", VA = "0x18621D5C0")]
	[AsyncStateMachine(typeof(DLBGONNIANB))]
	private Task GHOGEIMFIIF(BPADINOBHMJ BHMKONDNBED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x621E080", Offset = "0x621CE80", VA = "0x18621E080")]
	[AsyncStateMachine(typeof(FGOJDHPOMPH))]
	private Task OBFLMJHOECE(BPADINOBHMJ PMIBGBNPBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x621DF30", Offset = "0x621CD30", VA = "0x18621DF30")]
	[AsyncStateMachine(typeof(KGMOBGAILOP))]
	private Task<CKELNELKOJL> JPHPACNIAAL(BPADINOBHMJ BHMKONDNBED, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x621DC70", Offset = "0x621CA70", VA = "0x18621DC70")]
	private OMGMONNMAKC INNKBCNAIHH(BPADINOBHMJ BNOJAKDIIBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x621DB50", Offset = "0x621C950", VA = "0x18621DB50")]
	[AsyncStateMachine(typeof(FMBEDJEFFBD))]
	private Task ILMBIAPOGLD(CKELNELKOJL BJKAIBLEACD, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x621DD00", Offset = "0x621CB00", VA = "0x18621DD00")]
	private CKELNELKOJL JKHGCPFCLIP(BPADINOBHMJ BHMKONDNBED, OMGMONNMAKC KHNGAKEPNEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x29C2B90", Offset = "0x29C1990", VA = "0x1829C2B90")]
	private T LOMHJPPHCDB<T>(T POACLGOFKAJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x621D7B0", Offset = "0x621C5B0", VA = "0x18621D7B0")]
	private CKELNELKOJL HEDEFFKNHMH(BPADINOBHMJ BHMKONDNBED, OMGMONNMAKC KHNGAKEPNEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public ANDHJACEHKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[UnityEngine.Scripting.Preserve]
internal sealed class HEPHJNAODAO : OFGJJCKCANF, IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class BELABDFNMBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public BELABDFNMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x621F260", Offset = "0x621E060", VA = "0x18621F260")]
		internal object AOGEAIDPAHE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class FLCIKAKABHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public FLCIKAKABHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6229C50", Offset = "0x6228A50", VA = "0x186229C50")]
		internal object KOOJNLMALOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private PBDPFIHDLBN JDIFANIOFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private FIBNAAJNLBK JEJMBFKDNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private OLGNNCBODHL JNJJGNPPEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private IIICFOAGJCD HPENABFIBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private FJPEOIADANF IMEOANDIGFI;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x622CD10", Offset = "0x622BB10", VA = "0x18622CD10", Slot = "6")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x622C410", Offset = "0x622B210", VA = "0x18622C410", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x622BD90", Offset = "0x622AB90", VA = "0x18622BD90", Slot = "4")]
	public DPNNCJCJBCE ANNDEDDFLPJ(BPADINOBHMJ LPDDKBDPMNJ)
	{
		return default(DPNNCJCJBCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x622CAF0", Offset = "0x622B8F0", VA = "0x18622CAF0", Slot = "5")]
	public void GMEKNNHOLOO(Guid ODNBBNPINDD, Task OFNAIJJLDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x622CA20", Offset = "0x622B820", VA = "0x18622CA20")]
	private void FLGAAIMKEDK(byte GNKJGLJIIJH, int IIHCNNANOLD, object AKOMLMLGJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x622D680", Offset = "0x622C480", VA = "0x18622D680")]
	private void PBHMPDBOKGE(CHLCMCCBHGA BFKHLAANBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x622D0E0", Offset = "0x622BEE0", VA = "0x18622D0E0")]
	private void KDGFPFDFEDC(CHLCMCCBHGA BFKHLAANBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x622BB40", Offset = "0x622A940", VA = "0x18622BB40")]
	private void AGMAEGMJLCA(CHLCMCCBHGA BFKHLAANBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x622CE80", Offset = "0x622BC80", VA = "0x18622CE80")]
	private DBGMMOMFJAO JJAPEKOGJLP(BPADINOBHMJ BNOJAKDIIBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x622C1E0", Offset = "0x622AFE0", VA = "0x18622C1E0")]
	private void DGEOOCDOEFG(BPADINOBHMJ PMIBGBNPBDF, DBGMMOMFJAO CAKOBMLPJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x622C760", Offset = "0x622B560", VA = "0x18622C760")]
	private bool FGNJFKNIGFB(BPADINOBHMJ PMIBGBNPBDF, DBGMMOMFJAO CAKOBMLPJNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x622D400", Offset = "0x622C200", VA = "0x18622D400")]
	private bool MIPHOJJMFNF(BPADINOBHMJ LJABPFDCKBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x622C4C0", Offset = "0x622B2C0", VA = "0x18622C4C0")]
	private bool ECMDIAHFNGD(byte GNKJGLJIIJH, ExitGames.Client.Photon.Hashtable BFKHLAANBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public HEPHJNAODAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[UnityEngine.Scripting.Preserve]
internal sealed class HNHOEJILLNA : MELHAOKFPOJ, IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class FDHFBGPJEPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public HKNPACFPCEJ operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public HNHOEJILLNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public BPADINOBHMJ roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public FDHFBGPJEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6227C20", Offset = "0x6226A20", VA = "0x186227C20")]
		internal object DHMCNAJCMII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6227C90", Offset = "0x6226A90", VA = "0x186227C90")]
		internal object INAHIBLGFGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct EAJNDFLOLPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<DBGMMOMFJAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public HNHOEJILLNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public BPADINOBHMJ roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private TaskAwaiter<DBGMMOMFJAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x62250E0", Offset = "0x6223EE0", VA = "0x1862250E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x62257C0", Offset = "0x62245C0", VA = "0x1862257C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class BLEANEEGFDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public HKNPACFPCEJ operationType;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public BLEANEEGFDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x62205D0", Offset = "0x621F3D0", VA = "0x1862205D0")]
		internal object GAFCBEEDPKK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class LDEILFKJOLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public BPADINOBHMJ request;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public LDEILFKJOLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6232D20", Offset = "0x6231B20", VA = "0x186232D20")]
		internal object MHKFPMGHIJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6232CB0", Offset = "0x6231AB0", VA = "0x186232CB0")]
		internal object KBJCJGICNHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6232C40", Offset = "0x6231A40", VA = "0x186232C40")]
		internal object CGJBEBLCEGI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct BIHJNFKNPDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<DBGMMOMFJAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public BPADINOBHMJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public HNHOEJILLNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private LDEILFKJOLH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private DPNNCJCJBCE <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private DBGMMOMFJAO <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter<(DBGMMOMFJAO validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x621FC60", Offset = "0x621EA60", VA = "0x18621FC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6220560", Offset = "0x621F360", VA = "0x186220560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private PBDPFIHDLBN JDIFANIOFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private FIBNAAJNLBK JEJMBFKDNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private OFGJJCKCANF FOOLBLHIIMM;

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x622E1E0", Offset = "0x622CFE0", VA = "0x18622E1E0", Slot = "5")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x622E290", Offset = "0x622D090", VA = "0x18622E290", Slot = "4")]
	[AsyncStateMachine(typeof(EAJNDFLOLPL))]
	private Task<DBGMMOMFJAO> JKBLIBNNLAC(BPADINOBHMJ BNOJAKDIIBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x622DE90", Offset = "0x622CC90", VA = "0x18622DE90")]
	private bool AMJMLIAKNND(HKNPACFPCEJ AEGJDAAKNIJ, [Out] DBGMMOMFJAO CGIMAKAECOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x622E0A0", Offset = "0x622CEA0", VA = "0x18622E0A0")]
	[AsyncStateMachine(typeof(BIHJNFKNPDF))]
	private Task<DBGMMOMFJAO> GHPKIAAPAPA(BPADINOBHMJ BHMKONDNBED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public HNHOEJILLNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class LHJAKGFKFEA : NJNGIFKKLFA, IEHKIJJJKOK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct JGABMJBDNEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AsyncTaskMethodBuilder<MMILHCEGCHA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public KGDNOOKHPHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public LHJAKGFKFEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<HEKEHEGBBLG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6230300", Offset = "0x622F100", VA = "0x186230300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x62307B0", Offset = "0x622F5B0", VA = "0x1862307B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class OHPAIMIFIHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public OHPAIMIFIHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x62377A0", Offset = "0x62365A0", VA = "0x1862377A0")]
		internal object BLGHBOHDMJG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct AGGFKBCCMGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<HEKEHEGBBLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public LHJAKGFKFEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public KGDNOOKHPHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private OHPAIMIFIHB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<HEKEHEGBBLG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x621C4C0", Offset = "0x621B2C0", VA = "0x18621C4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x621CAB0", Offset = "0x621B8B0", VA = "0x18621CAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class GLCCCLHCPGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GLCCCLHCPGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x1321320", Offset = "0x1320120", VA = "0x181321320")]
		internal bool DPALEJAOCBK(MLODPAAEOEO sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private GJEKPDGJJHD JOJOJMCMCEP;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static readonly (JBEOIFKKBLD superRoomData, long subRoomDataSaveId) ELDFHEOLEPM;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6232EF0", Offset = "0x6231CF0", VA = "0x186232EF0", Slot = "5")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6232D90", Offset = "0x6231B90", VA = "0x186232D90", Slot = "4")]
	[AsyncStateMachine(typeof(JGABMJBDNEI))]
	public Task<MMILHCEGCHA> DLFBGNDPDEG(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, KGDNOOKHPHA NGIJJKNICEF, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6232F60", Offset = "0x6231D60", VA = "0x186232F60")]
	[AsyncStateMachine(typeof(AGGFKBCCMGB))]
	private Task<HEKEHEGBBLG> JLDFGLBJLKK(KGDNOOKHPHA NGIJJKNICEF, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x62330C0", Offset = "0x6231EC0", VA = "0x1862330C0")]
	private MMILHCEGCHA OMDFCAOEFEO(KGDNOOKHPHA NGIJJKNICEF, HEKEHEGBBLG BNHJGEKGFBE, long PHHJICEDHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6233200", Offset = "0x6232000", VA = "0x186233200")]
	private (JBEOIFKKBLD, long) PFGPEPHBGCM(KGDNOOKHPHA NGIJJKNICEF, HEKEHEGBBLG BNHJGEKGFBE, long PHHJICEDHNG)
	{
		return default((JBEOIFKKBLD, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LHJAKGFKFEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal sealed class BFHBNADJNEP : BAKMENKFKPG, IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class KHGFGFJLMHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public BPADINOBHMJ request;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public KHGFGFJLMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x62327B0", Offset = "0x62315B0", VA = "0x1862327B0")]
		internal object KGOBPMOIOGI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct GOGAALMBNCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<BPADINOBHMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public BPADINOBHMJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public BFHBNADJNEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public OMGMONNMAKC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<BPADINOBHMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x622B2F0", Offset = "0x622A0F0", VA = "0x18622B2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x622B930", Offset = "0x622A730", VA = "0x18622B930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct CHHOFINNOAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<BPADINOBHMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public BFHBNADJNEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public OMGMONNMAKC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<DNOELPHBCDG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6221A00", Offset = "0x6220800", VA = "0x186221A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6222030", Offset = "0x6220E30", VA = "0x186222030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class KELJGIAFKOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public BPADINOBHMJ request;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public KELJGIAFKOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x62314C0", Offset = "0x62302C0", VA = "0x1862314C0")]
		internal object GIIKGHPHIIJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct KEOHFANFJFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<BPADINOBHMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public BPADINOBHMJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public BFHBNADJNEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public OMGMONNMAKC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private CADKKNKEDOJ <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private PMBMIDKNMJO <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<DNOELPHBCDG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6231520", Offset = "0x6230320", VA = "0x186231520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6232140", Offset = "0x6230F40", VA = "0x186232140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private PBDPFIHDLBN JDIFANIOFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private AOIFNCCAFCG BGHGDJCBMMP;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private NGAGHHIMGOM KNAEICMJFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x621FBA0", Offset = "0x621E9A0", VA = "0x18621FBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x621F570", Offset = "0x621E370", VA = "0x18621F570", Slot = "8")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x621FA40", Offset = "0x621E840", VA = "0x18621FA40", Slot = "4")]
	[AsyncStateMachine(typeof(GOGAALMBNCI))]
	public Task<BPADINOBHMJ> JKBFAAKPJDK(BPADINOBHMJ BHMKONDNBED, OMGMONNMAKC KHNGAKEPNEA, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x621F430", Offset = "0x621E230", VA = "0x18621F430", Slot = "5")]
	[AsyncStateMachine(typeof(CHHOFINNOAN))]
	public Task<BPADINOBHMJ> GHBIIHGLMJN(CancellationToken BCCDJHNACKO, OMGMONNMAKC KHNGAKEPNEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x621F600", Offset = "0x621E400", VA = "0x18621F600", Slot = "6")]
	public MNOFAHLHGGO HFJJDNCOILF(CKELNELKOJL KPCBKGBKBPI, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x621F810", Offset = "0x621E610", VA = "0x18621F810", Slot = "7")]
	public MNOFAHLHGGO IJPMJGBHIEH(CKELNELKOJL KPCBKGBKBPI, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x621F2D0", Offset = "0x621E0D0", VA = "0x18621F2D0")]
	[AsyncStateMachine(typeof(KEOHFANFJFE))]
	private Task<BPADINOBHMJ> EEAFHDPFBJN(BPADINOBHMJ BHMKONDNBED, OMGMONNMAKC KHNGAKEPNEA, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x24860C0", Offset = "0x2484EC0", VA = "0x1824860C0")]
	private static byte[] FKGJOFJJENJ(BPADINOBHMJ BLAOEBOMGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BFHBNADJNEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[UnityEngine.Scripting.Preserve]
internal sealed class MKGFBEAOKDA : FIBNAAJNLBK, IEHKIJJJKOK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private OGPMEHACKPF NMPMDDFPPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private PBDPFIHDLBN JDIFANIOFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private BENFFKBABLP CDGOACEIIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private CMMNPOOLMEK KAEHFJHHNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private GJEKPDGJJHD JOJOJMCMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private DPIALHIJIPF ENCKNIABMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private JOKPCMCNMAM OHJLKJDCMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private CNCDPBAGGGJ ODAKGFFPNLL;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private KINEDFAPICD IJAIOKDAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6234D90", Offset = "0x6233B90", VA = "0x186234D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private static DBGMMOMFJAO ICANHBNEFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x62348F0", Offset = "0x62336F0", VA = "0x1862348F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6234780", Offset = "0x6233580", VA = "0x186234780", Slot = "6")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6234950", Offset = "0x6233750", VA = "0x186234950", Slot = "4")]
	public DBGMMOMFJAO NLFEPLCLLFP(OOAELAJMHEN OLFOGNLCBFB, HKNPACFPCEJ FBODNDFGDIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6234AC0", Offset = "0x62338C0", VA = "0x186234AC0", Slot = "5")]
	public DBGMMOMFJAO NNGIIIGOAIE(OOAELAJMHEN MMNBPGKPJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6234720", Offset = "0x6233520", VA = "0x186234720")]
	private static DBGMMOMFJAO AOEOMAMMBGG(FIHOCAFBEOC BNAPAMOAFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MKGFBEAOKDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class NICHAJAFNIC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6237120", Offset = "0x6235F20", VA = "0x186237120")]
	public NICHAJAFNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5880EA0", Offset = "0x587FCA0", VA = "0x185880EA0")]
	public NICHAJAFNIC(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class ONLDCELODNE : GCMDDFAJNHD, IEHKIJJJKOK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct FGPDPBHKOKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AsyncTaskMethodBuilder<DBGMMOMFJAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public ONLDCELODNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public KOAFPCAGHPM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private AEMIIEBAFHL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private GNOOBBGOINJ <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<DBGMMOMFJAO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x6229050", Offset = "0x6227E50", VA = "0x186229050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x6229BE0", Offset = "0x62289E0", VA = "0x186229BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct JGACCNDDLCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public ONLDCELODNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6230820", Offset = "0x622F620", VA = "0x186230820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6230F70", Offset = "0x622FD70", VA = "0x186230F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct CFHNDDPFHLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public ONLDCELODNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6221490", Offset = "0x6220290", VA = "0x186221490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x62219A0", Offset = "0x62207A0", VA = "0x1862219A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct CHILEJOPNNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public ONLDCELODNE <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x62220A0", Offset = "0x6220EA0", VA = "0x1862220A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x62227F0", Offset = "0x62215F0", VA = "0x1862227F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct MHABGKEJHEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public ONLDCELODNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x6234260", Offset = "0x6233060", VA = "0x186234260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6234400", Offset = "0x6233200", VA = "0x186234400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct IONFCKJDDCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public ONLDCELODNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x622F490", Offset = "0x622E290", VA = "0x18622F490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x622FBB0", Offset = "0x622E9B0", VA = "0x18622FBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct ONDDCOCDHIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public ONLDCELODNE <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6237AB0", Offset = "0x62368B0", VA = "0x186237AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6237F20", Offset = "0x6236D20", VA = "0x186237F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct JFKECKAIMAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public ONLDCELODNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public JHEKNEICBIJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private AEMIIEBAFHL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x622FD60", Offset = "0x622EB60", VA = "0x18622FD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x62302A0", Offset = "0x622F0A0", VA = "0x1862302A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private PBDPFIHDLBN JDIFANIOFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private GJEKPDGJJHD JOJOJMCMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private BAKMENKFKPG CPAAECPGNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private BENFFKBABLP CDGOACEIIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private JOKPCMCNMAM OHJLKJDCMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private CancellationTokenSource HEMIDEDACLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private Task IBFBDLONPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private TaskCompletionSource<int> HKKJECGPELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private int MNNFMLAMPLH;

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6238170", Offset = "0x6236F70", VA = "0x186238170", Slot = "6")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD80", Offset = "0x7CCB80", VA = "0x1807CDD80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6238E40", Offset = "0x6237C40", VA = "0x186238E40")]
	private void PLPBPGAABFN(float PEJBEAOLBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6238B00", Offset = "0x6237900", VA = "0x186238B00", Slot = "4")]
	[AsyncStateMachine(typeof(FGPDPBHKOKP))]
	public Task<DBGMMOMFJAO> LMBNAKFDOMB(KOAFPCAGHPM FBHFFEMKPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6238900", Offset = "0x6237700", VA = "0x186238900", Slot = "5")]
	[AsyncStateMachine(typeof(JGACCNDDLCO))]
	public Task KAGFICDKBDK([Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD80", Offset = "0x7CCB80", VA = "0x1807CDD80")]
	public void JHPNEAHLEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6238410", Offset = "0x6237210", VA = "0x186238410")]
	private GNOOBBGOINJ JDIDKHCEAIJ(KOAFPCAGHPM FBHFFEMKPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6238580", Offset = "0x6237380", VA = "0x186238580")]
	[AsyncStateMachine(typeof(CFHNDDPFHLI))]
	private Task JGGMPCPBFAI(NNEDCLBDCDJ KNIBDNLMNEE, CancellationToken FJDIBEBBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6238C30", Offset = "0x6237A30", VA = "0x186238C30")]
	[AsyncStateMachine(typeof(CHILEJOPNNI))]
	private Task NDLHEPJJGGG(CancellationToken FJDIBEBBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6238080", Offset = "0x6236E80", VA = "0x186238080")]
	[AsyncStateMachine(typeof(MHABGKEJHEJ))]
	private Task CEKCHHNDPIM([Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6238320", Offset = "0x6237120", VA = "0x186238320")]
	[AsyncStateMachine(typeof(IONFCKJDDCM))]
	private Task HFLKGBHIHCO(CancellationToken FJDIBEBBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x6237F80", Offset = "0x6236D80", VA = "0x186237F80")]
	[AsyncStateMachine(typeof(ONDDCOCDHIO))]
	private Task BFDOPFFEEAM(CancellationToken POJGDKJKCLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x6238670", Offset = "0x6237470", VA = "0x186238670")]
	private Task KAANFLDGBGN(JHEKNEICBIJ ANAIDGIIPAF, CancellationToken FJDIBEBBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x6238D30", Offset = "0x6237B30", VA = "0x186238D30")]
	[AsyncStateMachine(typeof(JFKECKAIMAF))]
	private Task PBLHELIICCF(JHEKNEICBIJ ANAIDGIIPAF, CancellationToken FJDIBEBBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x62389F0", Offset = "0x62377F0", VA = "0x1862389F0")]
	private bool LMBJKMIIFEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public ONLDCELODNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[UnityEngine.Scripting.Preserve]
internal class PIFDLMBPMGA : CMMNPOOLMEK, IEHKIJJJKOK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct DBEFPLOLCPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public PIFDLMBPMGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private AEMIIEBAFHL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6222C60", Offset = "0x6221A60", VA = "0x186222C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x62231C0", Offset = "0x6221FC0", VA = "0x1862231C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private PDFONMCLKJM PIHGIHLIILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private FIBNAAJNLBK JEJMBFKDNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private BAKMENKFKPG CPAAECPGNGO;

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x623A730", Offset = "0x6239530", VA = "0x18623A730", Slot = "6")]
	public void HCKCHEHGBKI(JHENEJKEAOJ KFCMDEBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x623A6E0", Offset = "0x62394E0", VA = "0x18623A6E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x623AA10", Offset = "0x6239810", VA = "0x18623AA10", Slot = "5")]
	[AsyncStateMachine(typeof(DBEFPLOLCPB))]
	public Task JFCAJNPPPLN(string MCGLDNPFLND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x623AB10", Offset = "0x6239910", VA = "0x18623AB10", Slot = "4")]
	public DBGMMOMFJAO LMBJKMIIFEE(OOAELAJMHEN OLFOGNLCBFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x623A5F0", Offset = "0x62393F0", VA = "0x18623A5F0")]
	private NLHBPDLHBDH DEBCAMDPJDD(string MCGLDNPFLND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public PIFDLMBPMGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class LPBGMIHNJJF
{
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6234060", Offset = "0x6232E60", VA = "0x186234060")]
	public static void KBNAJIPBHBA(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6233A10", Offset = "0x6232810", VA = "0x186233A10")]
	internal static void DGLBELJGPMH(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x6233F80", Offset = "0x6232D80", VA = "0x186233F80")]
	internal static void JAEIEAJILPB(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x6233B30", Offset = "0x6232930", VA = "0x186233B30")]
	internal static void IFAPDFHLLFM(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal class EEDDINDOLPM : LBNLBGIEJDM<BPADINOBHMJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class FBCCLLLHJPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public BPADINOBHMJ message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public FBCCLLLHJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6227870", Offset = "0x6226670", VA = "0x186227870")]
		internal object JMOJEMOBIPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly EEDDINDOLPM IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x6227450", Offset = "0x6226250", VA = "0x186227450")]
	public ExitGames.Client.Photon.Hashtable LJOKGFFEJKK(BPADINOBHMJ BLAOEBOMGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x6227320", Offset = "0x6226120", VA = "0x186227320", Slot = "5")]
	protected override void JIIHFPIHAID(BPADINOBHMJ BLAOEBOMGGP, IDictionary<object, object> LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x62274E0", Offset = "0x62262E0", VA = "0x1862274E0", Slot = "6")]
	public override BPADINOBHMJ NLOFGFEMKNI(IDictionary<object, object> LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6226F70", Offset = "0x6225D70", VA = "0x186226F70")]
	private static void BPAIBICBBJL(string ADEEDBOHLHF, BPADINOBHMJ BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x62277B0", Offset = "0x62265B0", VA = "0x1862277B0")]
	public EEDDINDOLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6227080", Offset = "0x6225E80", VA = "0x186227080")]
	[CompilerGenerated]
	internal static string CIAEAPMHHGL(MMILHCEGCHA JOPBACODGFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class PGLKNFKLHHA
{
	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public static DBGMMOMFJAO ICANHBNEFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x62348F0", Offset = "0x62336F0", VA = "0x1862348F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x623A170", Offset = "0x6238F70", VA = "0x18623A170")]
	public static bool BOFBHILCMDC(this DBGMMOMFJAO CAKOBMLPJNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6234720", Offset = "0x6233520", VA = "0x186234720")]
	public static DBGMMOMFJAO AOEOMAMMBGG(FIHOCAFBEOC AJALDJIMLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x623A190", Offset = "0x6238F90", VA = "0x18623A190")]
	public static DBGMMOMFJAO CCDHHKBKGKL(IEnumerable<DBGMMOMFJAO> HONFPNNODKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x623A390", Offset = "0x6239190", VA = "0x18623A390")]
	public static string GFDCHOFNFED(this DBGMMOMFJAO CGIMAKAECOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class IAOCGOGLIOK : NOMFMNCMEED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public delegate DBGMMOMFJAO JLABLOGJALD([NotNull] OOAELAJMHEN AEHNHBKAAFO);

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class NBDHGAHBAOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public OOAELAJMHEN photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public NBDHGAHBAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5A76790", Offset = "0x5A75590", VA = "0x185A76790")]
		internal DBGMMOMFJAO GIGIMMGNPOI(JLABLOGJALD v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	protected readonly HashSet<JLABLOGJALD> HFIFLDCIOND;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x622E700", Offset = "0x622D500", VA = "0x18622E700", Slot = "4")]
	public void KNPFKAHCHEO(JLABLOGJALD PMFLCGNNBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x622E3B0", Offset = "0x622D1B0", VA = "0x18622E3B0", Slot = "5")]
	public void DCFDKIAKOHA(JLABLOGJALD PMFLCGNNBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x622E410", Offset = "0x622D210", VA = "0x18622E410", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x622E460", Offset = "0x622D260", VA = "0x18622E460")]
	protected DBGMMOMFJAO FDJINEFDMFK(OOAELAJMHEN MMNBPGKPJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x622E760", Offset = "0x622D560", VA = "0x18622E760")]
	protected IAOCGOGLIOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class GLENPPDMBHB : IAOCGOGLIOK, OGPMEHACKPF, NOMFMNCMEED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class PGFECCMCLGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public DBGMMOMFJAO result;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public PGFECCMCLGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x623A110", Offset = "0x6238F10", VA = "0x18623A110")]
		internal object ABELPCMJNEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x622AEC0", Offset = "0x6229CC0", VA = "0x18622AEC0")]
	[UnityEngine.Scripting.Preserve]
	public GLENPPDMBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x622ADB0", Offset = "0x6229BB0", VA = "0x18622ADB0", Slot = "8")]
	public DBGMMOMFJAO KPBFOKPIDPG(OOAELAJMHEN MMNBPGKPJPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class LCNNPAMCBAN : IAOCGOGLIOK, PDFONMCLKJM, NOMFMNCMEED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class PKECKNCLIPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public DBGMMOMFJAO result;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public PKECKNCLIPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x623AB70", Offset = "0x6239970", VA = "0x18623AB70")]
		internal object COEPKFENCAK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x622AEC0", Offset = "0x6229CC0", VA = "0x18622AEC0")]
	[UnityEngine.Scripting.Preserve]
	public LCNNPAMCBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6232B30", Offset = "0x6231930", VA = "0x186232B30", Slot = "8")]
	public DBGMMOMFJAO LMBJKMIIFEE(OOAELAJMHEN DPOAKIJENBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal static class OKLNIELJBLM
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class LIMCFJDLECC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public AEMIIEBAFHL<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public LIMCFJDLECC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x6233670", Offset = "0x6232470", VA = "0x186233670")]
		internal object GNMJILCIJKK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x62379D0", Offset = "0x62367D0", VA = "0x1862379D0")]
	public static AEMIIEBAFHL<string> EEMBMNOBDKC(HICMFDICNOL DFCBIKLJFPD, [Optional] string EMAGCFBLBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6237910", Offset = "0x6236710", VA = "0x186237910")]
	public static void BOMKIIDEIEG(AEMIIEBAFHL<string> DNLFOGHCHDI, HICMFDICNOL DFCBIKLJFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6237850", Offset = "0x6236650", VA = "0x186237850")]
	public static string ACHFGEAONLM(BPADINOBHMJ BNOJAKDIIBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal static class HAOBALOKOGJ
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x622BA00", Offset = "0x622A800", VA = "0x18622BA00")]
	public static void DAEDGMLJGCO(this PBDPFIHDLBN JDIFANIOFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x622BB30", Offset = "0x622A930", VA = "0x18622BB30")]
	public static void KFDODMPJNDO(this PBDPFIHDLBN JDIFANIOFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x622BA10", Offset = "0x622A810", VA = "0x18622BA10")]
	private static void KBKOFOGGPJB(this PBDPFIHDLBN JDIFANIOFLI, bool JPGOCDDEOGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class GILKPFNJKJI : GKFANIMDFDK, HKAHMHKFKNN, MPMELMHFGFE, FGPNHFAOIOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private readonly HKAHMHKFKNN PJPMIHBEEPH;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public OOAELAJMHEN LLMPEMBMOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x622A9A0", Offset = "0x62297A0", VA = "0x18622A9A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public int IBCLJHKGEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x622AA10", Offset = "0x6229810", VA = "0x18622AA10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int CDGDKGKOPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x622A8B0", Offset = "0x62296B0", VA = "0x18622A8B0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool KHNJGAJHHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int MFEBOHIBMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7DD200", Offset = "0x7DC000", VA = "0x1807DD200", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event CAGBENJDHMI.KKPPMEDHELI MNMILJLKOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event PAKICLDJOFH APJKBKIMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x622A900", Offset = "0x6229700", VA = "0x18622A900", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x622ACA0", Offset = "0x6229AA0", VA = "0x18622ACA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> PELOGHPDCFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<OOAELAJMHEN> AIJOBBJGGON
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action GJBJICDLLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x622AC00", Offset = "0x6229A00", VA = "0x18622AC00", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x622AB60", Offset = "0x6229960", VA = "0x18622AB60", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0xC07630", Offset = "0xC06430", VA = "0x180C07630")]
	public GILKPFNJKJI(HKAHMHKFKNN PJPMIHBEEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x622AAB0", Offset = "0x62298B0", VA = "0x18622AAB0", Slot = "8")]
	public bool LBBCBLNHCFG(byte GNKJGLJIIJH, ExitGames.Client.Photon.Hashtable DNAMLLBGHHA, AGPMIFJKDDP CIALPGDDHBE, SendOptions IHPJKGMNCHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x622A7D0", Offset = "0x62295D0", VA = "0x18622A7D0", Slot = "16")]
	public OOAELAJMHEN AINNFHKEFCF(int PABDGEBBIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "19")]
	public void ADIGDFNGBPL(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "20")]
	public void BJNALIGBDLB(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "21")]
	public void IFADCJALLFH(object EKDHBKMFLGI, bool NPJECEMHBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x622AA60", Offset = "0x6229860", VA = "0x18622AA60", Slot = "22")]
	public IDisposable KBLOGGINJCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "23")]
	private bool NEFKLJMELCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "24")]
	public void COCDIHJCDBJ(StringBuilder CEPLELDLAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x622A9F0", Offset = "0x62297F0", VA = "0x18622A9F0", Slot = "25")]
	public bool IMLHIAJFGJC(bool APMOEIPLPJJ, [Out] string HIFPPFEDDLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0xADE750", Offset = "0xADD550", VA = "0x180ADE750", Slot = "28")]
	public void OAFEFNAFHPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal struct CHLCMCCBHGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private readonly IDictionary<object, object> BFKHLAANBNN;

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7EB650", Offset = "0x7EA450", VA = "0x1807EB650")]
	public CHLCMCCBHGA(IDictionary<object, object> BFKHLAANBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6222B30", Offset = "0x6221930", VA = "0x186222B30")]
	public bool NCICKNHMLLM([Out] BPADINOBHMJ BLAOEBOMGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6222A80", Offset = "0x6221880", VA = "0x186222A80")]
	public Guid LFFHHOGPPGK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6222940", Offset = "0x6221740", VA = "0x186222940")]
	public DBGMMOMFJAO IEKLKADBGAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6222850", Offset = "0x6221650", VA = "0x186222850")]
	public static ExitGames.Client.Photon.Hashtable FLMMCOJOBIA(BPADINOBHMJ BLAOEBOMGGP, DBGMMOMFJAO CAKOBMLPJNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class CNCHDGBDPPM
{
	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6222BE0", Offset = "0x62219E0", VA = "0x186222BE0")]
	public static bool ECCFOOFCPCF(this KGDNOOKHPHA CMLDOPFAAJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal struct MJMGKHHDHOF : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct HKOAEGADLDJ : IAsyncStateMachine
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
		public MJMGKHHDHOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x622DC50", Offset = "0x622CA50", VA = "0x18622DC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x622DE30", Offset = "0x622CC30", VA = "0x18622DE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly CancellationTokenSource AJBHEMPONAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private Task DPNKBPFBJPJ;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool ELICBKNLKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x6234460", Offset = "0x6233260", VA = "0x186234460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x62345F0", Offset = "0x62333F0", VA = "0x1862345F0")]
	public MJMGKHHDHOF(CancellationToken BCCDJHNACKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x62344E0", Offset = "0x62332E0", VA = "0x1862344E0")]
	[AsyncStateMachine(typeof(HKOAEGADLDJ))]
	public Task HKAKKCDGLFK(Func<CancellationToken, List<Task>> AFHLHFCMKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6234490", Offset = "0x6233290", VA = "0x186234490", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public readonly struct GDKMKFHDMDI<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct FOIFGBBELFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<LNAHKIJCHLB<TData>, DBMNCLOBEEI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public GDKMKFHDMDI<TGetDataArg, TData> <>4__this;

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
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private TaskAwaiter<FEBPNEDDNDE<byte[], DBMNCLOBEEI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x33D4420", Offset = "0x33D3220", VA = "0x1833D4420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x33D5E20", Offset = "0x33D4C20", VA = "0x1833D5E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly JNECKGCIOFK<TGetDataArg, TData> JFMOPJMOHHN;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x7EB650", Offset = "0x7EA450", VA = "0x1807EB650")]
	internal GDKMKFHDMDI(JNECKGCIOFK<TGetDataArg, TData> BLNNMOCCDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x3481D40", Offset = "0x3480B40", VA = "0x183481D40")]
	[AsyncStateMachine(typeof(GDKMKFHDMDI<, >.FOIFGBBELFE))]
	public Task<FEBPNEDDNDE<LNAHKIJCHLB<TData>, DBMNCLOBEEI>> DPMKJGHLPGJ(TGetDataArg GIMGFOJNMGL, string CIBAPBJFAFP, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class NPACCABGBKC
{
	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2182820", Offset = "0x2181620", VA = "0x182182820")]
	public static GDKMKFHDMDI<TGetDataArg, TData> IGHHFGMBDIH<TGetDataArg, TData>(JNECKGCIOFK<TGetDataArg, TData> BLNNMOCCDKN)
	{
		return default(GDKMKFHDMDI<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct IGPJKNEMLDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public readonly int ANMBICCFLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public readonly int? GIJKCAIMLII;

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x3934830", Offset = "0x3933630", VA = "0x183934830")]
	public IGPJKNEMLDH(int GAGNPPDPNIO, [Optional] int? ILKPIEIOFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x622EA30", Offset = "0x622D830", VA = "0x18622EA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface MMOOFAFDLMC<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDPBDLAKDPH();

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MMOOFAFDLMC<T> GJPCBEDILKF(string IELIBEMPOFK);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MMOOFAFDLMC<T> DHBKJIHHOAN(JHAMGCICJBO<T> MPJCPAGBHPL);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MMOOFAFDLMC<T> GIENLNGBONO(int OCGNIDFIOOG);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MMOOFAFDLMC<T> GCOGKDLELBK(int OCGNIDFIOOG, COKDEEDBEEP<T> CGHIPFAOOIM);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface ANOJCLPMAOC
{
	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MMOOFAFDLMC<T> BMHGOMFGBEP<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BPMHEHEIFKE MALJCNPPLGL(Exception GLNCBNFNGKL);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IGPJKNEMLDH DBOBGCGJCCM(Exception GLNCBNFNGKL);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public delegate string JHAMGCICJBO<in T>(T GLNCBNFNGKL) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate int COKDEEDBEEP<in T>(T GLNCBNFNGKL) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class EANHPKIICBA : ANOJCLPMAOC
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private delegate string EJCOEIIMLMF(Exception GLNCBNFNGKL);

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate int PDAMIBECPBL(Exception GLNCBNFNGKL);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private class HMIBFPFPANN<T> : MMOOFAFDLMC<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class MCFOOMAKEND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public MCFOOMAKEND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
			internal string FJAHKBLOLND(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class GNDIJDJHJDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public JHAMGCICJBO<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public GNDIJDJHJDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x3456590", Offset = "0x3455390", VA = "0x183456590")]
			internal string PIPFKBKDNLA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class AFECHOPNFIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public COKDEEDBEEP<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public AFECHOPNFIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x3456590", Offset = "0x3455390", VA = "0x183456590")]
			internal int DFMMNIFPLBP(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly EANHPKIICBA EJKPBOALKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private readonly Type MFOHOOLAOFG;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x35EA340", Offset = "0x35E9140", VA = "0x1835EA340")]
		internal HMIBFPFPANN(EANHPKIICBA EJKPBOALKJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x35EA1C0", Offset = "0x35E8FC0", VA = "0x1835EA1C0", Slot = "4")]
		public void GDPBDLAKDPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x35EA230", Offset = "0x35E9030", VA = "0x1835EA230", Slot = "5")]
		public MMOOFAFDLMC<T> GJPCBEDILKF(string IELIBEMPOFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x35E9F90", Offset = "0x35E8D90", VA = "0x1835E9F90", Slot = "6")]
		public MMOOFAFDLMC<T> DHBKJIHHOAN(JHAMGCICJBO<T> MPJCPAGBHPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x35EA1F0", Offset = "0x35E8FF0", VA = "0x1835EA1F0", Slot = "7")]
		public MMOOFAFDLMC<T> GIENLNGBONO(int OCGNIDFIOOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x35EA0A0", Offset = "0x35E8EA0", VA = "0x1835EA0A0", Slot = "8")]
		public MMOOFAFDLMC<T> GCOGKDLELBK(int OCGNIDFIOOG, COKDEEDBEEP<T> CGHIPFAOOIM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class DFBDJABBFJD<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private bool BAODLCEJNPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private readonly List<Type> BPHLDCMLKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private readonly Dictionary<Type, TVal> OMJHPGDACEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly Dictionary<Type, int> LKEFBABDHAC;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public IReadOnlyList<Type> GOKJMAJLONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x4C51780", Offset = "0x4C50580", VA = "0x184C51780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x4C519D0", Offset = "0x4C507D0", VA = "0x184C519D0")]
		public DFBDJABBFJD(Dictionary<Type, int> LKEFBABDHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4C515E0", Offset = "0x4C503E0", VA = "0x184C515E0")]
		public void EJEJBLJEAIN(Type GMOPMNAPKBE, TVal OBPGGDPOOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x4C51880", Offset = "0x4C50680", VA = "0x184C51880")]
		public bool NNPIIHEMHEE(Type MFOHOOLAOFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x4C51840", Offset = "0x4C50640", VA = "0x184C51840")]
		public bool MBIGBEMMJHF(TVal POACLGOFKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x4C51680", Offset = "0x4C50480", VA = "0x184C51680")]
		public TVal HAMDPAFEPLN(Type FLHOFPAHPKL)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x4C514A0", Offset = "0x4C502A0", VA = "0x184C514A0")]
		[CompilerGenerated]
		private int CJKKADGAEEA(Type ADBDDCBAEPC, Type CBIKPFPEBIE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class IIGGLBMJCAM : IEnumerable<IGPJKNEMLDH>, IEnumerable, IEnumerator<IGPJKNEMLDH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private IGPJKNEMLDH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public EANHPKIICBA <>4__this;

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
		private IEnumerator<IGPJKNEMLDH> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		private IGPJKNEMLDH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x30A94C0", Offset = "0x30A82C0", VA = "0x1830A94C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(IGPJKNEMLDH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x622F170", Offset = "0x622DF70", VA = "0x18622F170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x86F050", Offset = "0x86DE50", VA = "0x18086F050")]
		[DebuggerHidden]
		public IIGGLBMJCAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x622F1C0", Offset = "0x622DFC0", VA = "0x18622F1C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x622EBB0", Offset = "0x622D9B0", VA = "0x18622EBB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x622EB60", Offset = "0x622D960", VA = "0x18622EB60")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x622EB10", Offset = "0x622D910", VA = "0x18622EB10")]
		private void KMKNJEPJJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x622F120", Offset = "0x622DF20", VA = "0x18622F120", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x622F060", Offset = "0x622DE60", VA = "0x18622F060", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IGPJKNEMLDH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x622F060", Offset = "0x622DE60", VA = "0x18622F060", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private static readonly IGPJKNEMLDH BLCHKNBLGNM;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private static readonly Dictionary<Type, int> AFKPFPOPKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private readonly HashSet<Type> GCGAMCMFJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private readonly DFBDJABBFJD<int> HNIONABNOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly DFBDJABBFJD<PDAMIBECPBL> PILGCCKIPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly DFBDJABBFJD<EJCOEIIMLMF> ABMLGCKHBDK;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x62260D0", Offset = "0x6224ED0", VA = "0x1862260D0")]
	[DJDJPHIPNFL(IEJLPKKICHC.GameOnly)]
	private static void LKBEDIJGOEL(NNIGDKDCOBN AMGLAFJJOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x6226C30", Offset = "0x6225A30", VA = "0x186226C30")]
	[RecRoom.NoEngine.Common.Preserve]
	public EANHPKIICBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x21EE400", Offset = "0x21ED200", VA = "0x1821EE400", Slot = "4")]
	public MMOOFAFDLMC<T> BMHGOMFGBEP<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x6226140", Offset = "0x6224F40", VA = "0x186226140", Slot = "5")]
	public BPMHEHEIFKE MALJCNPPLGL(Exception GLNCBNFNGKL)
	{
		return default(BPMHEHEIFKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6225830", Offset = "0x6224630", VA = "0x186225830", Slot = "6")]
	public IGPJKNEMLDH DBOBGCGJCCM(Exception? GLNCBNFNGKL)
	{
		return default(IGPJKNEMLDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6225B10", Offset = "0x6224910", VA = "0x186225B10", Slot = "7")]
	[IteratorStateMachine(typeof(IIGGLBMJCAM))]
	public IEnumerable<IGPJKNEMLDH> KGMPOECFLLI(Exception GLNCBNFNGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6226580", Offset = "0x6225380", VA = "0x186226580", Slot = "8")]
	public string NDGEKJKKEIL(Exception? GLNCBNFNGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x6226850", Offset = "0x6225650", VA = "0x186226850")]
	private string PFAMENHCHDK(AggregateException FLHCCJBDKFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x62261D0", Offset = "0x6224FD0", VA = "0x1862261D0")]
	private void MOKCJCOAGIG(Type MFOHOOLAOFG, int OCGNIDFIOOG, PDAMIBECPBL? LNFKAAFDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6225BB0", Offset = "0x62249B0", VA = "0x186225BB0")]
	private void KJDAMHPMMJF(Type MFOHOOLAOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x6225E00", Offset = "0x6224C00", VA = "0x186225E00")]
	private void LCKLAPGLFFI(Type MFOHOOLAOFG, EJCOEIIMLMF IKLALEDDLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x62266D0", Offset = "0x62254D0", VA = "0x1862266D0")]
	private static int OADAKFEIICK(Type MFOHOOLAOFG, Dictionary<Type, int> LKEFBABDHAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2242B50", Offset = "0x2241950", VA = "0x182242B50")]
	private static bool PDEGEFNPANA<TVal>(DFBDJABBFJD<TVal> MFELMHKMEDH, Type MFOHOOLAOFG, [Out] TVal POACLGOFKAJ) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6225A30", Offset = "0x6224830", VA = "0x186225A30")]
	[CompilerGenerated]
	internal static int DGGLEMGOLDO(Type HGCNBPDCDID)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct BPMHEHEIFKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public readonly IGPJKNEMLDH NIBBOLAKHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public readonly string MDICLMIFIFF;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x62206E0", Offset = "0x621F4E0", VA = "0x1862206E0")]
	public BPMHEHEIFKE(string BLGLOJPLKPA, IGPJKNEMLDH OCGNIDFIOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x6220640", Offset = "0x621F440", VA = "0x186220640")]
	public string IGLAHHNKCHG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class MLCFHDEFMPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly LADPFBGJADL ILBLBEOHBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private string EBMDOFDBPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private long? MINOABCPHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private long? KCLAJKMONAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? JMCENCFIEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private string HLHDONFONIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private CNEEJNIMOIF FJFAGFGBELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private long? DPOIBLDLOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private bool PBNCHLJGCJO;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public string EHGPAGHDLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public long HAMCMGKKFJE
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x6235030", Offset = "0x6233E30", VA = "0x186235030")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public long ACBHFPDGNJP
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x6234ED0", Offset = "0x6233CD0", VA = "0x186234ED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public long KJMCLGMHMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x6234F30", Offset = "0x6233D30", VA = "0x186234F30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public string JCAELOCDGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6235110", Offset = "0x6233F10", VA = "0x186235110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public CNEEJNIMOIF MIFAKBPABIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xEC5440", Offset = "0xEC4240", VA = "0x180EC5440")]
		get
		{
			return default(CNEEJNIMOIF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x6234DE0", Offset = "0x6233BE0", VA = "0x186234DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public long POBGCMFGFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x6235150", Offset = "0x6233F50", VA = "0x186235150")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x6235C10", Offset = "0x6234A10", VA = "0x186235C10")]
	[UnityEngine.Scripting.Preserve]
	public MLCFHDEFMPO([FGPOJKOJBFM(null)] LADPFBGJADL ILBLBEOHBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x6235640", Offset = "0x6234440", VA = "0x186235640")]
	private void PBGDADBKLBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x62351B0", Offset = "0x6233FB0", VA = "0x1862351B0")]
	public void ODAKCKLKMEL(long ODPLBFKINCE, long PHHJICEDHNG, [Optional] long? CNOCCAPLFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6234F90", Offset = "0x6233D90", VA = "0x186234F90")]
	public void KKDPJAFDMLI(long CNOCCAPLFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6235090", Offset = "0x6233E90", VA = "0x186235090")]
	public void MEGGKGMGLFH(string KCLMDJOODFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x6235890", Offset = "0x6234690", VA = "0x186235890")]
	public void PBJBJJIBGNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class MNOFAHLHGGO : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct NIPGOBCAMIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public AsyncTaskMethodBuilder<BPADINOBHMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public BPADINOBHMJ roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public MNOFAHLHGGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private TaskAwaiter<NGAGHHIMGOM.PCNMLBHIJPA<BPADINOBHMJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x6237160", Offset = "0x6235F60", VA = "0x186237160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x6237690", Offset = "0x6236490", VA = "0x186237690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct HKCCCJADDOI<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class MOPAJPHAJGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public BPADINOBHMJ roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public MOPAJPHAJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x6236FE0", Offset = "0x6235DE0", VA = "0x186236FE0")]
		internal BPADINOBHMJ AJCDFJOIJNM(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct FDMGKCEGIEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public AsyncTaskMethodBuilder<NGAGHHIMGOM.PCNMLBHIJPA<BPADINOBHMJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public BPADINOBHMJ roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public MNOFAHLHGGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private CADKKNKEDOJ <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private TaskAwaiter<NGAGHHIMGOM.PCNMLBHIJPA<BPADINOBHMJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x6227DC0", Offset = "0x6226BC0", VA = "0x186227DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x62283D0", Offset = "0x62271D0", VA = "0x1862283D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct JNADJDAFDGC<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public MNOFAHLHGGO <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x3860BC0", Offset = "0x385F9C0", VA = "0x183860BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x338C8B0", Offset = "0x338B6B0", VA = "0x18338C8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct AMJKDJLFNAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public MNOFAHLHGGO <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x621CB80", Offset = "0x621B980", VA = "0x18621CB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x621CD40", Offset = "0x621BB40", VA = "0x18621CD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class IILKKIBCNOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public IILKKIBCNOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x622F310", Offset = "0x622E110", VA = "0x18622F310")]
		internal object KOANPKMFBMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x622F370", Offset = "0x622E170", VA = "0x18622F370")]
		internal bool POECJJFPEKJ(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class HAICPIDMFAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HAICPIDMFAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x622B9A0", Offset = "0x622A7A0", VA = "0x18622B9A0")]
		internal object OIHIDPAELJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class KHFIBELIHBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public KHFIBELIHBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x6232740", Offset = "0x6231540", VA = "0x186232740")]
		internal object KCDMKAJLCHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class GLEMNMPECCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GLEMNMPECCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x622AD40", Offset = "0x6229B40", VA = "0x18622AD40")]
		internal object KJAJOFJALBC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class IBDCGAKIGOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public MNOFAHLHGGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public IBDCGAKIGOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x622E7F0", Offset = "0x622D5F0", VA = "0x18622E7F0")]
		internal object JMOJEMOBIPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private static readonly Guid LIBLGNPKMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public readonly CKELNELKOJL OEHACKOMCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private readonly NGAGHHIMGOM FHLIJDGIGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly MPMELMHFGFE JDIFANIOFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly FGPNHFAOIOP DKIBFEGANDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private bool FHEAKNBBMHJ;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6236DB0", Offset = "0x6235BB0", VA = "0x186236DB0")]
	public MNOFAHLHGGO(CKELNELKOJL BJKAIBLEACD, NGAGHHIMGOM FHLIJDGIGDG, MPMELMHFGFE JDIFANIOFLI, FGPNHFAOIOP DKIBFEGANDL, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6235FD0", Offset = "0x6234DD0", VA = "0x186235FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6235FD0", Offset = "0x6234DD0", VA = "0x186235FD0")]
	public void FBLIEGMKLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6236AB0", Offset = "0x62358B0", VA = "0x186236AB0")]
	public void OAEPKLLKNKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x6236200", Offset = "0x6235000", VA = "0x186236200")]
	public void GPMOLCOOKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x6235DF0", Offset = "0x6234BF0", VA = "0x186235DF0")]
	[AsyncStateMachine(typeof(NIPGOBCAMIC))]
	internal Task<BPADINOBHMJ> CJODNOILHJG(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, BPADINOBHMJ BNOJAKDIIBK, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x24860C0", Offset = "0x2484EC0", VA = "0x1824860C0")]
	private static byte[] BIAGGGCOKGI<T>(T BLAOEBOMGGP) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2486380", Offset = "0x2485180", VA = "0x182486380")]
	private static T JEMEIKNGPHA<T>(MessageParser<T> HLMHKKBEPDP, byte[] BLAOEBOMGGP, T KGNHAOBOCKA) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x62367F0", Offset = "0x62355F0", VA = "0x1862367F0")]
	[AsyncStateMachine(typeof(FDMGKCEGIEP))]
	private Task<NGAGHHIMGOM.PCNMLBHIJPA<BPADINOBHMJ>> MJMLAFFGDFI(BPADINOBHMJ BNOJAKDIIBK, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x24865C0", Offset = "0x24853C0", VA = "0x1824865C0")]
	[AsyncStateMachine(typeof(JNADJDAFDGC<>))]
	internal Task<T> NKMPLAANENA<T>(CancellationToken FJDIBEBBHAG, Func<CancellationToken, Task<T>> CLBKOFOGBLE, int LKGOCNPNODJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6236980", Offset = "0x6235780", VA = "0x186236980")]
	[AsyncStateMachine(typeof(AMJKDJLFNAI))]
	internal Task NKMPLAANENA(CancellationToken FJDIBEBBHAG, Func<CancellationToken, Task> CLBKOFOGBLE, int LKGOCNPNODJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6236B70", Offset = "0x6235970", VA = "0x186236B70")]
	public IGNPADGHKFJ OPHLKBOKGFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6235F50", Offset = "0x6234D50", VA = "0x186235F50")]
	public BGNBDGJIINJ CKEJKMHGKCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6236BF0", Offset = "0x62359F0", VA = "0x186236BF0")]
	public PIKEEBBOBMO PFFCFOEPAIH([Optional] HICMFDICNOL? DFCBIKLJFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6236690", Offset = "0x6235490", VA = "0x186236690")]
	public void MAKECHIFMLG(Func<Guid, bool> NAJNPJHLCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x62360F0", Offset = "0x6234EF0", VA = "0x1862360F0")]
	public void EPKHOAFONNJ(Func<Guid, bool> GJGIEJFCEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x62363D0", Offset = "0x62351D0", VA = "0x1862363D0")]
	public Guid IOIGAINIIJO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x62362C0", Offset = "0x62350C0", VA = "0x1862362C0")]
	public void INNLPCLBOHP(Guid NJGOJIKJIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6236550", Offset = "0x6235350", VA = "0x186236550")]
	public void JNLAHCBGEMB(BPADINOBHMJ DFLKGBJEPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6235CE0", Offset = "0x6234AE0", VA = "0x186235CE0")]
	public void BPAIBICBBJL(string JGFDMKPOMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x24864D0", Offset = "0x24852D0", VA = "0x1824864D0")]
	private T LOMHJPPHCDB<T>(T POACLGOFKAJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6236930", Offset = "0x6235730", VA = "0x186236930")]
	public void MNOMGMGCGMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x24860D0", Offset = "0x2484ED0", VA = "0x1824860D0")]
	[CompilerGenerated]
	internal static string FPGCDPOLGFD<T>(byte[] LKHDKNBOMJD, int MMGMGPHHDNH, HKCCCJADDOI<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal sealed class ACLLKDPPBKB : CKELNELKOJL
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class KFNCKDENPIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public KFNCKDENPIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x62493C0", Offset = "0x62481C0", VA = "0x1862493C0")]
		internal object JFNJDBFGGNA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct FGOJHKDBCAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public ACLLKDPPBKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public MNOFAHLHGGO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private PAIBCHOHLHM <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private BGNBDGJIINJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x62439B0", Offset = "0x62427B0", VA = "0x1862439B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x6244130", Offset = "0x6242F30", VA = "0x186244130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct ECKDMDLBHMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public ACLLKDPPBKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private bool <omIsEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<HEKEHEGBBLG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x6242290", Offset = "0x6241090", VA = "0x186242290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x6242810", Offset = "0x6241610", VA = "0x186242810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct LHBEMIKHGND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public ACLLKDPPBKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private TaskAwaiter<KIKHMLAGMKE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x624DFA0", Offset = "0x624CDA0", VA = "0x18624DFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x624E2C0", Offset = "0x624D0C0", VA = "0x18624E2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class KPFHOKOLFLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public PAIBCHOHLHM presence;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public KPFHOKOLFLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x624A0A0", Offset = "0x6248EA0", VA = "0x18624A0A0")]
		internal object LIHMFHCOBCO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly HICMFDICNOL EDDPKBMDFEH;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly HICMFDICNOL NDJFCNPIEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private readonly MMILHCEGCHA CODMCAGINLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private readonly KGDNOOKHPHA MMPNDNJPMCG;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x621C2D0", Offset = "0x621B0D0", VA = "0x18621C2D0")]
	public ACLLKDPPBKB(MMILHCEGCHA CODMCAGINLG, KGDNOOKHPHA MMPNDNJPMCG, Guid ODNBBNPINDD, JHENEJKEAOJ KFCMDEBDJKP, OMGMONNMAKC DEAOGJKCCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x621BDC0", Offset = "0x621ABC0", VA = "0x18621BDC0", Slot = "7")]
	[AsyncStateMachine(typeof(FGOJHKDBCAM))]
	protected override Task JNHHMBJEEEC(MNOFAHLHGGO ICJCFPNHMJP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x621BCC0", Offset = "0x621AAC0", VA = "0x18621BCC0")]
	[AsyncStateMachine(typeof(ECKDMDLBHMD))]
	private Task FNOBAOFLOGH(CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x621BF00", Offset = "0x621AD00", VA = "0x18621BF00")]
	[AsyncStateMachine(typeof(LHBEMIKHGND))]
	private Task<byte> KHOJOECEECN(CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x621C010", Offset = "0x621AE10", VA = "0x18621C010")]
	private PAIBCHOHLHM ODNOECMAMEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class GNOOBBGOINJ : CKELNELKOJL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct LGKBJAEKHPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public GNOOBBGOINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public MNOFAHLHGGO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private TaskAwaiter<PAFEDHKBAIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x624CE20", Offset = "0x624BC20", VA = "0x18624CE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x624D7A0", Offset = "0x624C5A0", VA = "0x18624D7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private readonly int ICMCAOFODMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private readonly KOAFPCAGHPM GHLCENPLAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public readonly long OPMGJOGOEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public readonly long KLBPLBEAKBN;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PAFEDHKBAIE OBFALCBKNAM
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7679F0", Offset = "0x7667F0", VA = "0x1807679F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x767860", Offset = "0x766660", VA = "0x180767860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6244B30", Offset = "0x6243930", VA = "0x186244B30")]
	public GNOOBBGOINJ(Guid ODNBBNPINDD, JHENEJKEAOJ KFCMDEBDJKP, OMGMONNMAKC DEAOGJKCCNM, int ICMCAOFODMN, KOAFPCAGHPM GHLCENPLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6244A10", Offset = "0x6243810", VA = "0x186244A10", Slot = "7")]
	[AsyncStateMachine(typeof(LGKBJAEKHPC))]
	protected override Task JNHHMBJEEEC(MNOFAHLHGGO ICJCFPNHMJP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal abstract class GFBMEHPFPEC : CKELNELKOJL
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class NJFEELPBKLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public GFBMEHPFPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public INELBIHCEHA playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public NJFEELPBKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x6250460", Offset = "0x624F260", VA = "0x186250460")]
		internal Task DKKNCKCHFFD(AEMIIEBAFHL<string>.GMENFEPMDPA postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x62504A0", Offset = "0x624F2A0", VA = "0x1862504A0")]
		internal object NPAIHEENPMI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct EOLDKDPDAOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public GFBMEHPFPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public MNOFAHLHGGO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private NJFEELPBKLA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x6242DE0", Offset = "0x6241BE0", VA = "0x186242DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x62435A0", Offset = "0x62423A0", VA = "0x1862435A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct LKLBDIDAEHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public INELBIHCEHA playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public GFBMEHPFPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x624E330", Offset = "0x624D130", VA = "0x18624E330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x624E8C0", Offset = "0x624D6C0", VA = "0x18624E8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x62449C0", Offset = "0x62437C0", VA = "0x1862449C0")]
	public GFBMEHPFPEC(Guid ODNBBNPINDD, JHENEJKEAOJ KFCMDEBDJKP, OMGMONNMAKC DEAOGJKCCNM, string BAJHDCJKHKL, HDCLEDKOAAP AEGJDAAKNIJ, bool OHPDGKMEBOD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6244740", Offset = "0x6243540", VA = "0x186244740", Slot = "7")]
	[AsyncStateMachine(typeof(EOLDKDPDAOK))]
	protected override Task JNHHMBJEEEC(MNOFAHLHGGO ICJCFPNHMJP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task AEBCBKCIGDO(MNOFAHLHGGO ICJCFPNHMJP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6244880", Offset = "0x6243680", VA = "0x186244880")]
	[AsyncStateMachine(typeof(LKLBDIDAEHE))]
	private Task KJCHCELJPLG(IDisposable ACNOHKAOHBJ, INELBIHCEHA EKMKOJMCLPF, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class LEGKLPKJFEN : CKELNELKOJL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct OBPMGAPKAKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public LEGKLPKJFEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public MNOFAHLHGGO operationContext;

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
		private TaskAwaiter<CEIMFNJANHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x62506F0", Offset = "0x624F4F0", VA = "0x1862506F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6250C60", Offset = "0x624FA60", VA = "0x186250C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	private readonly JHEKNEICBIJ ANAIDGIIPAF;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x624BB90", Offset = "0x624A990", VA = "0x18624BB90")]
	public LEGKLPKJFEN(Guid ODNBBNPINDD, JHENEJKEAOJ KFCMDEBDJKP, OMGMONNMAKC DEAOGJKCCNM, JHEKNEICBIJ ANAIDGIIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x624BAB0", Offset = "0x624A8B0", VA = "0x18624BAB0", Slot = "6")]
	protected override string NHCDBLGGBPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x624B990", Offset = "0x624A790", VA = "0x18624B990", Slot = "7")]
	[AsyncStateMachine(typeof(OBPMGAPKAKG))]
	protected override Task JNHHMBJEEEC(MNOFAHLHGGO ICJCFPNHMJP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class CKELNELKOJL : DABBEHEKBOG
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public delegate Task AHDALMMFLIO(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class PKNEJAKKJHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public CKELNELKOJL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public PKNEJAKKJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6251F30", Offset = "0x6250D30", VA = "0x186251F30")]
		internal Task NOENIAHBEBC(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class JILOCJECBBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public PKNEJAKKJHN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JILOCJECBBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x62488F0", Offset = "0x62476F0", VA = "0x1862488F0")]
		internal object KDJIFKEPDAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6248830", Offset = "0x6247630", VA = "0x186248830")]
		internal object FFKHDLAGNCL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct CICILOOCKFA : IAsyncStateMachine
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
		public CKELNELKOJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public Func<CKELNELKOJL, AEMIIEBAFHL<string>.GMENFEPMDPA, MNOFAHLHGGO> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private PKNEJAKKJHN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private MNOFAHLHGGO <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<BPADINOBHMJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x62404D0", Offset = "0x623F2D0", VA = "0x1862404D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x62415D0", Offset = "0x62403D0", VA = "0x1862415D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct HELENGOLBPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public CKELNELKOJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6244C60", Offset = "0x6243A60", VA = "0x186244C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6244FC0", Offset = "0x6243DC0", VA = "0x186244FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly Guid LLNDMFMBIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly ByteString GNBIFCKMCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly OMGMONNMAKC HNDGCJKFKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	protected readonly string EHPPGCNGODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private readonly bool OHPDGKMEBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly Queue<AHDALMMFLIO> EMKPIEHAJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly BLJPMIJPLBG KMIPNILJBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly HDCLEDKOAAP AEGJDAAKNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private bool EICIFIMOBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public CNEEJNIMOIF KPPBILIDOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public CNEEJNIMOIF IMLAMLMCKEB;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public JHENEJKEAOJ NCNLGKFEJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x7654A0", Offset = "0x7642A0", VA = "0x1807654A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public GJEKPDGJJHD HGMDPNHJIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x62417A0", Offset = "0x62405A0", VA = "0x1862417A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public OOLPJEPAFOA ENHEBJJFOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6241A10", Offset = "0x6240810", VA = "0x186241A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public KINEDFAPICD IJAIOKDAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6241DF0", Offset = "0x6240BF0", VA = "0x186241DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event HBHFGMAABIK IODBMHDGGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x62418D0", Offset = "0x62406D0", VA = "0x1862418D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6241B50", Offset = "0x6240950", VA = "0x186241B50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6241E70", Offset = "0x6240C70", VA = "0x186241E70")]
	protected CKELNELKOJL(Guid ODNBBNPINDD, JHENEJKEAOJ KFCMDEBDJKP, OMGMONNMAKC DEAOGJKCCNM, string BAJHDCJKHKL, HDCLEDKOAAP AEGJDAAKNIJ, bool OHPDGKMEBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6241DB0", Offset = "0x6240BB0", VA = "0x186241DB0", Slot = "6")]
	protected virtual string NHCDBLGGBPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x62417F0", Offset = "0x62405F0", VA = "0x1862417F0")]
	public void CDELLIFDJKE(AHDALMMFLIO PPJDGBLLNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6241630", Offset = "0x6240430", VA = "0x186241630")]
	protected void ACFAANOMHCO(float ADKJANDCMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6241B70", Offset = "0x6240970", VA = "0x186241B70")]
	[AsyncStateMachine(typeof(CICILOOCKFA))]
	public Task INEHGKEHGLC(CancellationToken BCCDJHNACKO, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, [Optional] Func<CKELNELKOJL, AEMIIEBAFHL<string>.GMENFEPMDPA, MNOFAHLHGGO> IOKHKLIAKLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6241650", Offset = "0x6240450", VA = "0x186241650")]
	private void BEMILJALDPA(bool LOKCGABODID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6241CC0", Offset = "0x6240AC0", VA = "0x186241CC0")]
	private void LKCPOLBPODH(MNOFAHLHGGO ICJCFPNHMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task JNHHMBJEEEC(MNOFAHLHGGO ICJCFPNHMJP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x62418F0", Offset = "0x62406F0", VA = "0x1862418F0")]
	[AsyncStateMachine(typeof(HELENGOLBPJ))]
	private Task EJNLEHDCANG(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6241850", Offset = "0x6240650", VA = "0x186241850")]
	public BPADINOBHMJ DGFHAFAHJNI(CADKKNKEDOJ APAKFPFKGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x6241A60", Offset = "0x6240860", VA = "0x186241A60")]
	[CompilerGenerated]
	private Task FKJLCBFJFHI(CancellationToken EGGPNONKPNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal sealed class JDLDJCGAEFA : GFBMEHPFPEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct KOHKNBJCCEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public JDLDJCGAEFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public MNOFAHLHGGO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private NDKKOBMILDL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private BGNBDGJIINJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x62498D0", Offset = "0x62486D0", VA = "0x1862498D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x624A040", Offset = "0x6248E40", VA = "0x18624A040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	private readonly MMILHCEGCHA JDNFDBLMLMO;

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x6248480", Offset = "0x6247280", VA = "0x186248480")]
	public JDLDJCGAEFA(Guid ODNBBNPINDD, JHENEJKEAOJ KFCMDEBDJKP, MMILHCEGCHA JDNFDBLMLMO, OMGMONNMAKC DEAOGJKCCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6248330", Offset = "0x6247130", VA = "0x186248330", Slot = "8")]
	[AsyncStateMachine(typeof(KOHKNBJCCEB))]
	protected override Task AEBCBKCIGDO(MNOFAHLHGGO ICJCFPNHMJP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal class NLHBPDLHBDH : CKELNELKOJL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct OLJEMHCIMNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public NLHBPDLHBDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public MNOFAHLHGGO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private TaskAwaiter<CEIMFNJANHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6250CC0", Offset = "0x624FAC0", VA = "0x186250CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6251070", Offset = "0x624FE70", VA = "0x186251070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly string GCNAAGAJGFN;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x6250640", Offset = "0x624F440", VA = "0x186250640")]
	public NLHBPDLHBDH(Guid ODNBBNPINDD, JHENEJKEAOJ KFCMDEBDJKP, OMGMONNMAKC DEAOGJKCCNM, string GCNAAGAJGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6250530", Offset = "0x624F330", VA = "0x186250530", Slot = "7")]
	[AsyncStateMachine(typeof(OLJEMHCIMNO))]
	protected override Task JNHHMBJEEEC(MNOFAHLHGGO ICJCFPNHMJP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class AEKOKOGAMPO : GFBMEHPFPEC
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class MCEFOMLBDLM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public AsyncTaskMethodBuilder<BPADINOBHMJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			public MCEFOMLBDLM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			private TaskAwaiter<CEIMFNJANHL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			private TaskAwaiter<BPADINOBHMJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x6254D90", Offset = "0x6253B90", VA = "0x186254D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x6255250", Offset = "0x6254050", VA = "0x186255250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public AEKOKOGAMPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public PIKEEBBOBMO serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public EBDAGPGFMGD roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public IGNPADGHKFJ uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public KLDKAMMCIHI roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public MCEFOMLBDLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x624E920", Offset = "0x624D720", VA = "0x18624E920")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<BPADINOBHMJ> KNBAKCDIGHL(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct IJODJFIDPEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public AEKOKOGAMPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public MNOFAHLHGGO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private MCEFOMLBDLM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private NDKKOBMILDL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private BGNBDGJIINJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private TaskAwaiter<BPADINOBHMJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x6247430", Offset = "0x6246230", VA = "0x186247430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x62482D0", Offset = "0x62470D0", VA = "0x1862482D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private static readonly HICMFDICNOL EDDPKBMDFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	private readonly int OCBCHOCNCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	[CanBeNull]
	private readonly BFOHOABJCJF GBODCICDBDD;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x623C8F0", Offset = "0x623B6F0", VA = "0x18623C8F0")]
	public AEKOKOGAMPO(Guid ODNBBNPINDD, JHENEJKEAOJ KFCMDEBDJKP, int OCBCHOCNCAE, BFOHOABJCJF GBODCICDBDD, OMGMONNMAKC DEAOGJKCCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x623C430", Offset = "0x623B230", VA = "0x18623C430", Slot = "8")]
	[AsyncStateMachine(typeof(IJODJFIDPEP))]
	protected override Task AEBCBKCIGDO(MNOFAHLHGGO ICJCFPNHMJP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x623C740", Offset = "0x623B540", VA = "0x18623C740")]
	private void MPKOCNOHJJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x623C570", Offset = "0x623B370", VA = "0x18623C570")]
	private void DBEEGNBHEKK(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, NDKKOBMILDL EMCBNIOOAKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal abstract class CGBFJPILGOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public readonly CKELNELKOJL OEHACKOMCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public readonly MNOFAHLHGGO HDCIDJEMIGJ;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public GJEKPDGJJHD HGMDPNHJIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x6240060", Offset = "0x623EE60", VA = "0x186240060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public KINEDFAPICD IJAIOKDAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x62400B0", Offset = "0x623EEB0", VA = "0x1862400B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x6240140", Offset = "0x623EF40", VA = "0x186240140")]
	protected CGBFJPILGOO(MNOFAHLHGGO ICJCFPNHMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6240040", Offset = "0x623EE40", VA = "0x186240040")]
	protected void BPAIBICBBJL(string JGFDMKPOMBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct NIHCKIOHHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public Dictionary<Guid, List<LJFPLDLNAJC>> FFJDHOLLIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public Dictionary<Guid, List<LJFPLDLNAJC>> GLIEKMJOBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public Dictionary<Guid, List<LJFPLDLNAJC>> OKOBKFLHDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public List<Guid> BPFJEDFJABB;

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x624FE50", Offset = "0x624EC50", VA = "0x18624FE50")]
	public static NIHCKIOHHFA HAMDPAFEPLN(GJEKPDGJJHD JOJOJMCMCEP, CNEEJNIMOIF ANEAGIEPPDJ, NNEDCLBDCDJ EPLEDHCPFCN)
	{
		return default(NIHCKIOHHFA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct OKDPCFHMKHF
{
	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300")]
	public static OKDPCFHMKHF FLMMCOJOBIA()
	{
		return default(OKDPCFHMKHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal struct EHBAKJCGEMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly HEKEHEGBBLG MBIKCDFGAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public readonly MLODPAAEOEO OEBKFPOAGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly string JEEIKFCHBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly JBEOIFKKBLD DBBBPLGPHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public readonly JBEOIFKKBLD GDJNMGOCFKN;

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6242870", Offset = "0x6241670", VA = "0x186242870")]
	public EHBAKJCGEMK(HEKEHEGBBLG MBIKCDFGAEL, MLODPAAEOEO OEBKFPOAGOH, string JEEIKFCHBFO, JBEOIFKKBLD DBBBPLGPHMP, JBEOIFKKBLD GDJNMGOCFKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct DKBPBNHPIDA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly MNOFAHLHGGO ICJCFPNHMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly Guid NJGOJIKJIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private bool LOKCGABODID;

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x62421E0", Offset = "0x6240FE0", VA = "0x1862421E0")]
	public static DKBPBNHPIDA IOIGAINIIJO(MNOFAHLHGGO ICJCFPNHMJP)
	{
		return default(DKBPBNHPIDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D58A0", Offset = "0x7D46A0", VA = "0x1807D58A0")]
	public void FLKAJHAHOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6242180", Offset = "0x6240F80", VA = "0x186242180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x6242240", Offset = "0x6241040", VA = "0x186242240")]
	private DKBPBNHPIDA(MNOFAHLHGGO ICJCFPNHMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x6242180", Offset = "0x6240F80", VA = "0x186242180")]
	private void INNLPCLBOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x62420E0", Offset = "0x6240EE0", VA = "0x1862420E0")]
	private Func<Guid, bool> DJKIAEPCLLK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class BGNBDGJIINJ : CGBFJPILGOO, DABBEHEKBOG
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	public delegate Task<CNEEJNIMOIF> FBEHGIEJNEJ(NNEDCLBDCDJ LMCJHCIOIIP, NAGGDKFKHLB IIOLEPNHFOG, BLJPMIJPLBG LIOPNAGLFNP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct IHPFBKNGEPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public MMILHCEGCHA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private DKBPBNHPIDA <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private TaskAwaiter<BPADINOBHMJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x6246CD0", Offset = "0x6245AD0", VA = "0x186246CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x62473D0", Offset = "0x62461D0", VA = "0x1862473D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct AGKJDFHDNMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public AsyncTaskMethodBuilder<BPADINOBHMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public MMILHCEGCHA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private TaskAwaiter<BPADINOBHMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x623C9A0", Offset = "0x623B7A0", VA = "0x18623C9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x623CDB0", Offset = "0x623BBB0", VA = "0x18623CDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct EKAEMAEOLEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public MMILHCEGCHA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x62428F0", Offset = "0x62416F0", VA = "0x1862428F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x6242D80", Offset = "0x6241B80", VA = "0x186242D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class HJMPDANBEAL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000120")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			public AsyncTaskMethodBuilder<EHBAKJCGEMK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			public HJMPDANBEAL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			private EHBAKJCGEMK <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			private TaskAwaiter<CNEEJNIMOIF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			private TaskAwaiter<EHBAKJCGEMK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x6253400", Offset = "0x6252200", VA = "0x186253400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x6253B90", Offset = "0x6252990", VA = "0x186253B90", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public AsyncTaskMethodBuilder<NNEDCLBDCDJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public HJMPDANBEAL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			private NNEDCLBDCDJ <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			private TaskAwaiter<CNEEJNIMOIF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			private TaskAwaiter<NNEDCLBDCDJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x6253C00", Offset = "0x6252A00", VA = "0x186253C00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x6254250", Offset = "0x6253050", VA = "0x186254250", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			public HJMPDANBEAL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			private TaskAwaiter<CNEEJNIMOIF> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			private NAGGDKFKHLB <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x6252060", Offset = "0x6250E60", VA = "0x186252060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x62533A0", Offset = "0x62521A0", VA = "0x1862533A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public MMILHCEGCHA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public BLJPMIJPLBG preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public BLJPMIJPLBG downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public EHBAKJCGEMK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public BLJPMIJPLBG postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public NNEDCLBDCDJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public ABHGIDAJLOA.IHCPKNLNFMO <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HJMPDANBEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x62453A0", Offset = "0x62441A0", VA = "0x1862453A0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<EHBAKJCGEMK> PILPPONHKKD(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x6245280", Offset = "0x6244080", VA = "0x186245280")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<NNEDCLBDCDJ> PGAGEEMFIAB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x6245140", Offset = "0x6243F40", VA = "0x186245140")]
		internal void ACOHFABOLHI(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x6245180", Offset = "0x6243F80", VA = "0x186245180")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task CDKELONMAHJ(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct BCKKEPLLHJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public MMILHCEGCHA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private HJMPDANBEAL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private TaskAwaiter<EHBAKJCGEMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private TaskAwaiter<NNEDCLBDCDJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x623D730", Offset = "0x623C530", VA = "0x18623D730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x623E430", Offset = "0x623D230", VA = "0x18623E430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct LGNBJNKJOAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x624D800", Offset = "0x624C600", VA = "0x18624D800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x624DF40", Offset = "0x624CD40", VA = "0x18624DF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct MPOILMBFMIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public BLJPMIJPLBG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TaskAwaiter<CNEEJNIMOIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x624F490", Offset = "0x624E290", VA = "0x18624F490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x624FDF0", Offset = "0x624EBF0", VA = "0x18624FDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct LGDMLCBLECI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public AsyncTaskMethodBuilder<CNEEJNIMOIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public BLJPMIJPLBG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private TaskAwaiter<CNEEJNIMOIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x624BC30", Offset = "0x624AA30", VA = "0x18624BC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x624CDB0", Offset = "0x624BBB0", VA = "0x18624CDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct LDKGGCLBLOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public AsyncTaskMethodBuilder<CNEEJNIMOIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public BLJPMIJPLBG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public NAGGDKFKHLB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private TaskAwaiter<CNEEJNIMOIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x624A1E0", Offset = "0x6248FE0", VA = "0x18624A1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x624B5B0", Offset = "0x624A3B0", VA = "0x18624B5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct JHLHHCHMKPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AsyncTaskMethodBuilder<CNEEJNIMOIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public CNEEJNIMOIF operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public BLJPMIJPLBG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public NNEDCLBDCDJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private TaskAwaiter<CNEEJNIMOIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x6248530", Offset = "0x6247330", VA = "0x186248530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x62487C0", Offset = "0x62475C0", VA = "0x1862487C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class HEMGMJDGIDF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			public AsyncTaskMethodBuilder<CNEEJNIMOIF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public HEMGMJDGIDF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			private TaskAwaiter<CNEEJNIMOIF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0x62542C0", Offset = "0x62530C0", VA = "0x1862542C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0x6254930", Offset = "0x6253730", VA = "0x186254930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public BLJPMIJPLBG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public FBEHGIEJNEJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public NAGGDKFKHLB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public CNEEJNIMOIF originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HEMGMJDGIDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6245020", Offset = "0x6243E20", VA = "0x186245020")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<CNEEJNIMOIF> GPGONIHGEKO(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct GAIKEDEGHLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public AsyncTaskMethodBuilder<CNEEJNIMOIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public BLJPMIJPLBG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public FBEHGIEJNEJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public NAGGDKFKHLB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private TaskAwaiter<CNEEJNIMOIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6244190", Offset = "0x6242F90", VA = "0x186244190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x62446D0", Offset = "0x62434D0", VA = "0x1862446D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct PJLFEJBBIGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public BLJPMIJPLBG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private CNEEJNIMOIF <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private IEnumerator<CNEEJNIMOIF> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private TaskAwaiter<CNEEJNIMOIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x62519A0", Offset = "0x62507A0", VA = "0x1862519A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6251ED0", Offset = "0x6250CD0", VA = "0x186251ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct LEFAOALOJOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x624B620", Offset = "0x624A420", VA = "0x18624B620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x624B930", Offset = "0x624A730", VA = "0x18624B930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct FECGBCMMBMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public BGNBDGJIINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x6243700", Offset = "0x6242500", VA = "0x186243700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x6243950", Offset = "0x6242750", VA = "0x186243950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly OHJELKPNANC BOJAJCAAPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private readonly OHJELKPNANC EKKABPOINBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private readonly MLCFHDEFMPO BLBEIHCAEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private readonly BAHOBGPGCIJ HFGLMKGJOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private readonly KHAEJGIBJFD DIIKMOFCEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly GKIGKOCEHFL OCKDNOPDEJN;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private JHENEJKEAOJ NCNLGKFEJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x623F160", Offset = "0x623DF60", VA = "0x18623F160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event HBHFGMAABIK IODBMHDGGGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x623EC20", Offset = "0x623DA20", VA = "0x18623EC20", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x623F5E0", Offset = "0x623E3E0", VA = "0x18623F5E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x623FD90", Offset = "0x623EB90", VA = "0x18623FD90")]
	public BGNBDGJIINJ(MNOFAHLHGGO ICJCFPNHMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x623E6D0", Offset = "0x623D4D0", VA = "0x18623E6D0")]
	[AsyncStateMachine(typeof(IHPFBKNGEPJ))]
	public Task ADOGJCDLKII(MMILHCEGCHA BHMKONDNBED, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x623FBC0", Offset = "0x623E9C0", VA = "0x18623FBC0")]
	[AsyncStateMachine(typeof(AGKJDFHDNMO))]
	private Task<BPADINOBHMJ> MMLJFDOAHBN(MMILHCEGCHA BHMKONDNBED, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x623EC40", Offset = "0x623DA40", VA = "0x18623EC40")]
	[AsyncStateMachine(typeof(EKAEMAEOLEJ))]
	private Task ECPCFELEHFI(MMILHCEGCHA BHMKONDNBED, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x623FA80", Offset = "0x623E880", VA = "0x18623FA80")]
	[AsyncStateMachine(typeof(BCKKEPLLHJG))]
	private Task MIKFMDKNLBL(MMILHCEGCHA BHMKONDNBED, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken JDMPIJIAIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x623E9A0", Offset = "0x623D7A0", VA = "0x18623E9A0")]
	[AsyncStateMachine(typeof(LGNBJNKJOAB))]
	private Task CMFALAKGMCJ(AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x623EAB0", Offset = "0x623D8B0", VA = "0x18623EAB0")]
	[AsyncStateMachine(typeof(MPOILMBFMIF))]
	private Task CPPGDGGHEGK(NNEDCLBDCDJ LMCJHCIOIIP, BLJPMIJPLBG LIOPNAGLFNP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x623F190", Offset = "0x623DF90", VA = "0x18623F190")]
	[AsyncStateMachine(typeof(LGDMLCBLECI))]
	private Task<CNEEJNIMOIF> HBNNKGJPCAL(NNEDCLBDCDJ LMCJHCIOIIP, NAGGDKFKHLB MFGBLFEINMJ, BLJPMIJPLBG LIOPNAGLFNP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x623F310", Offset = "0x623E110", VA = "0x18623F310")]
	[AsyncStateMachine(typeof(LDKGGCLBLOJ))]
	private Task<CNEEJNIMOIF> HFLKFCEIKDI(NNEDCLBDCDJ LMCJHCIOIIP, NAGGDKFKHLB MFGBLFEINMJ, BLJPMIJPLBG LIOPNAGLFNP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x623F830", Offset = "0x623E630", VA = "0x18623F830")]
	[AsyncStateMachine(typeof(JHLHHCHMKPN))]
	private Task<CNEEJNIMOIF> KDILIDMDKLC(CNEEJNIMOIF ANEAGIEPPDJ, NNEDCLBDCDJ EPLEDHCPFCN, BLJPMIJPLBG LIOPNAGLFNP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO, bool OMKKEEENKBB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x623E490", Offset = "0x623D290", VA = "0x18623E490")]
	private bool ACKIELOKEBI(NNEDCLBDCDJ MBAAIHAFDBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x623ED80", Offset = "0x623DB80", VA = "0x18623ED80")]
	[AsyncStateMachine(typeof(GAIKEDEGHLL))]
	protected Task<CNEEJNIMOIF> EEEHLCIDAOG(NNEDCLBDCDJ LMCJHCIOIIP, NAGGDKFKHLB MFGBLFEINMJ, BLJPMIJPLBG LIOPNAGLFNP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO, FBEHGIEJNEJ MLNPPMEGBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x623E580", Offset = "0x623D380", VA = "0x18623E580")]
	[AsyncStateMachine(typeof(PJLFEJBBIGH))]
	private Task ADDBFOGPMAN(NNEDCLBDCDJ LMCJHCIOIIP, BLJPMIJPLBG LIOPNAGLFNP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x623FA30", Offset = "0x623E830", VA = "0x18623FA30")]
	private void LOLLFMEKIFE(CNEEJNIMOIF LBDMAKFKENM, BLJPMIJPLBG LIOPNAGLFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x623F9F0", Offset = "0x623E7F0", VA = "0x18623F9F0")]
	private void LKLDBNPKIAN(CNEEJNIMOIF BFILDDLCPPA, [Out] CNEEJNIMOIF DLNJMJOPNED, [Out] CNEEJNIMOIF CLKBCAPHGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x623E960", Offset = "0x623D760", VA = "0x18623E960")]
	private Task<EHBAKJCGEMK> BNDOIPBDLCB(MMILHCEGCHA BHMKONDNBED, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x623F9B0", Offset = "0x623E7B0", VA = "0x18623F9B0")]
	private Task<NNEDCLBDCDJ> KKGLFGMDKDH(EHBAKJCGEMK LMCJHCIOIIP, ABHGIDAJLOA.IHCPKNLNFMO IMPJGHPEJJO, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x623EF10", Offset = "0x623DD10", VA = "0x18623EF10")]
	[AsyncStateMachine(typeof(LEFAOALOJOM))]
	private Task EFPOJBFPCLK(NNEDCLBDCDJ LMCJHCIOIIP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO, bool KIBLOFEIKLP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x623F740", Offset = "0x623E540", VA = "0x18623F740")]
	[AsyncStateMachine(typeof(FECGBCMMBMF))]
	private Task JMOFALKEDHC(NNEDCLBDCDJ LMCJHCIOIIP, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x623E820", Offset = "0x623D620", VA = "0x18623E820")]
	private Task BEECCNPIENK(NNEDCLBDCDJ LMCJHCIOIIP, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x623F2F0", Offset = "0x623E0F0", VA = "0x18623F2F0")]
	private Task HFKKKKPEDKI(NNEDCLBDCDJ LMCJHCIOIIP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x623FD70", Offset = "0x623EB70", VA = "0x18623FD70")]
	private Task PFBCNBALAKC(NNEDCLBDCDJ LMCJHCIOIIP, NAGGDKFKHLB MFGBLFEINMJ, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x623F490", Offset = "0x623E290", VA = "0x18623F490")]
	private Task IJIFPKKHJNC(NNEDCLBDCDJ LMCJHCIOIIP, NAGGDKFKHLB MFGBLFEINMJ, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x623F080", Offset = "0x623DE80", VA = "0x18623F080")]
	private static Task EMCBMEEAEIH(CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x623EC00", Offset = "0x623DA00", VA = "0x18623EC00")]
	private Task DANMNBPAGOA(NNEDCLBDCDJ LMCJHCIOIIP, NAGGDKFKHLB MFGBLFEINMJ, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x623F600", Offset = "0x623E400", VA = "0x18623F600")]
	private Task IMJOKAENAKM(NNEDCLBDCDJ LMCJHCIOIIP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x623FD20", Offset = "0x623EB20", VA = "0x18623FD20")]
	private void NAJDMAMDJEM(MMILHCEGCHA BHMKONDNBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x623F060", Offset = "0x623DE60", VA = "0x18623F060")]
	public void ELPCJCLAJOE(long CNOCCAPLFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void EMCPLIDCPII(HEKEHEGBBLG MBIKCDFGAEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal struct CGKHKHDLGDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private NNEDCLBDCDJ LMCJHCIOIIP;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private GJEKPDGJJHD HGMDPNHJIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x62401A0", Offset = "0x623EFA0", VA = "0x1862401A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x62401F0", Offset = "0x623EFF0", VA = "0x1862401F0")]
	public static Task INEHGKEHGLC(JHENEJKEAOJ KFCMDEBDJKP, NNEDCLBDCDJ LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x62402D0", Offset = "0x623F0D0", VA = "0x1862402D0")]
	private void INEHGKEHGLC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct LENLJKMKEDB
{
	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x623F080", Offset = "0x623DE80", VA = "0x18623F080")]
	public static Task INEHGKEHGLC(CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct MPAJPNNCJCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct MHEDGMLBGJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public MNOFAHLHGGO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x624EA40", Offset = "0x624D840", VA = "0x18624EA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x624EFA0", Offset = "0x624DDA0", VA = "0x18624EFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x624F350", Offset = "0x624E150", VA = "0x18624F350")]
	[AsyncStateMachine(typeof(MHEDGMLBGJN))]
	public static Task INEHGKEHGLC(MNOFAHLHGGO ICJCFPNHMJP, NNEDCLBDCDJ LMCJHCIOIIP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct MJHLFHBLJBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct HOEOKKOKIHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public MNOFAHLHGGO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public NAGGDKFKHLB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private CNEEJNIMOIF <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private JHENEJKEAOJ <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private GJEKPDGJJHD <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private IDisposable <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private List<(PersistenceView, JBHCDHCPMCM)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private JBHCDHCPMCM <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x62454E0", Offset = "0x62442E0", VA = "0x1862454E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x6246180", Offset = "0x6244F80", VA = "0x186246180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x624F200", Offset = "0x624E000", VA = "0x18624F200")]
	[AsyncStateMachine(typeof(HOEOKKOKIHE))]
	public static Task INEHGKEHGLC(MNOFAHLHGGO ICJCFPNHMJP, NNEDCLBDCDJ LMCJHCIOIIP, NAGGDKFKHLB MFGBLFEINMJ, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x624F000", Offset = "0x624DE00", VA = "0x18624F000")]
	private static void IKCDBBKBMNF(PersistenceView KBMGDEBBCNM, JBHCDHCPMCM AGJJPHKFJFF, NNEDCLBDCDJ LMCJHCIOIIP, CNEEJNIMOIF ANEAGIEPPDJ, bool OOPJOLIKJPP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal struct CKHIJPFDBLC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct KNGMHLIKMCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public JHENEJKEAOJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x6249430", Offset = "0x6248230", VA = "0x186249430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6249870", Offset = "0x6248670", VA = "0x186249870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x6241FD0", Offset = "0x6240DD0", VA = "0x186241FD0")]
	[AsyncStateMachine(typeof(KNGMHLIKMCC))]
	public static Task INEHGKEHGLC(JHENEJKEAOJ KFCMDEBDJKP, NNEDCLBDCDJ LMCJHCIOIIP, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct ICGIMEINEJL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct OOMMAPDKJIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public JHENEJKEAOJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public MNOFAHLHGGO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x62510D0", Offset = "0x624FED0", VA = "0x1862510D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x62512E0", Offset = "0x62500E0", VA = "0x1862512E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class AJKAEEOJHMC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013C")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E6")]
			public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E7")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			public AJKAEEOJHMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004EA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0x62549A0", Offset = "0x62537A0", VA = "0x1862549A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x6254D30", Offset = "0x6253B30", VA = "0x186254D30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public AJKAEEOJHMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x623CF70", Offset = "0x623BD70", VA = "0x18623CF70")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task CKPLOJLPFMP(AEMIIEBAFHL<string>.GMENFEPMDPA timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct JNBGFLCLHGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public ICGIMEINEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private TaskAwaiter<BPADINOBHMJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x62489B0", Offset = "0x62477B0", VA = "0x1862489B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x6249360", Offset = "0x6248160", VA = "0x186249360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class ACHOHNNCEEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public BIPJOHNJPOB version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public ACHOHNNCEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x623B840", Offset = "0x623A640", VA = "0x18623B840")]
		internal object EDOGDILBNEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x623B920", Offset = "0x623A720", VA = "0x18623B920")]
		internal object JPHEEIDHDJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	private NNEDCLBDCDJ LMCJHCIOIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	private MNOFAHLHGGO ICJCFPNHMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	private bool KIBLOFEIKLP;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	private static readonly ByteString LHCCONIBIGD;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private GJEKPDGJJHD HGMDPNHJIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x62461E0", Offset = "0x6244FE0", VA = "0x1862461E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private KINEDFAPICD IJAIOKDAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6246BA0", Offset = "0x62459A0", VA = "0x186246BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x62468D0", Offset = "0x62456D0", VA = "0x1862468D0")]
	[AsyncStateMachine(typeof(OOMMAPDKJIJ))]
	public static Task INEHGKEHGLC(JHENEJKEAOJ KFCMDEBDJKP, NNEDCLBDCDJ LMCJHCIOIIP, MNOFAHLHGGO ICJCFPNHMJP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO, bool KIBLOFEIKLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x6246A20", Offset = "0x6245820", VA = "0x186246A20")]
	[AsyncStateMachine(typeof(JNBGFLCLHGD))]
	private Task INEHGKEHGLC(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x6246230", Offset = "0x6245030", VA = "0x186246230")]
	private void EIPBJHHKLEG([NotNull] ELNFILGNBCL AEHMMJMEEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x6246B60", Offset = "0x6245960", VA = "0x186246B60")]
	private bool KLEEGJAAJPH(BIPJOHNJPOB FBJEHMGCPKI, ELNFILGNBCL AEHMMJMEEDB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct ALNLOMKJJCI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct AEIFFPKPJFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public AsyncTaskMethodBuilder<NNEDCLBDCDJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public ALNLOMKJJCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public ABHGIDAJLOA.IHCPKNLNFMO downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private TaskAwaiter<(FEBPNEDDNDE<KHKNCAJFODO, DBMNCLOBEEI>, FEBPNEDDNDE<LNAHKIJCHLB<ELNFILGNBCL>, DBMNCLOBEEI>, FEBPNEDDNDE<LNAHKIJCHLB<HIAIHBIEMAC>, DBMNCLOBEEI>, FEBPNEDDNDE<LNAHKIJCHLB<PHPDBENOAKI>, DBMNCLOBEEI>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x623B9D0", Offset = "0x623A7D0", VA = "0x18623B9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x623C3C0", Offset = "0x623B1C0", VA = "0x18623C3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct PAKPFEDDNAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<KHKNCAJFODO, DBMNCLOBEEI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public ALNLOMKJJCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public ABHGIDAJLOA.IHCPKNLNFMO downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private TaskAwaiter<FEBPNEDDNDE<KHKNCAJFODO, DBMNCLOBEEI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x6251340", Offset = "0x6250140", VA = "0x186251340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x6251930", Offset = "0x6250730", VA = "0x186251930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private GDKMKFHDMDI<JBEOIFKKBLD, HIAIHBIEMAC> OAPHOALEJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private GDKMKFHDMDI<JBEOIFKKBLD, ELNFILGNBCL> HDEACFEPDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private GDKMKFHDMDI<long, PHPDBENOAKI> JLINFPDGBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private NOHCFMGPLCA NPLDFFCAGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private HEKEHEGBBLG MBIKCDFGAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private MLODPAAEOEO OEBKFPOAGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private string JEEIKFCHBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private JBEOIFKKBLD DBBBPLGPHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	private JBEOIFKKBLD GDJNMGOCFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private long CNOCCAPLFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	private AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI;

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x623D3C0", Offset = "0x623C1C0", VA = "0x18623D3C0")]
	public static Task<NNEDCLBDCDJ> JCEKJFIHDGP(JHENEJKEAOJ KFCMDEBDJKP, [In] EHBAKJCGEMK LMCJHCIOIIP, ABHGIDAJLOA.IHCPKNLNFMO IMPJGHPEJJO, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x623D240", Offset = "0x623C040", VA = "0x18623D240")]
	[AsyncStateMachine(typeof(AEIFFPKPJFG))]
	private Task<NNEDCLBDCDJ> INEHGKEHGLC(ABHGIDAJLOA.IHCPKNLNFMO IMPJGHPEJJO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x623D090", Offset = "0x623BE90", VA = "0x18623D090")]
	[AsyncStateMachine(typeof(PAKPFEDDNAO))]
	private Task<FEBPNEDDNDE<KHKNCAJFODO, DBMNCLOBEEI>> DEECINAPHPP(string JEEIKFCHBFO, long CNOCCAPLFKN, ABHGIDAJLOA.IHCPKNLNFMO IMPJGHPEJJO, AEMIIEBAFHL<string>.GMENFEPMDPA HKCMLGDICDH, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct BGNHBCBCDMD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct AGJBEKNHEDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public AsyncTaskMethodBuilder<EHBAKJCGEMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public BGNHBCBCDMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private TaskAwaiter<EHBAKJCGEMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x6255E60", Offset = "0x6254C60", VA = "0x186255E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6256260", Offset = "0x6255060", VA = "0x186256260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct FBNLNPPMNJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public AsyncTaskMethodBuilder<EHBAKJCGEMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public BGNHBCBCDMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter<EHBAKJCGEMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x625D1B0", Offset = "0x625BFB0", VA = "0x18625D1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x625D5B0", Offset = "0x625C3B0", VA = "0x18625D5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class KIGFPGFOJIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public KIGFPGFOJIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x1321320", Offset = "0x1320120", VA = "0x181321320")]
		internal bool LFIPOCLLIFL(MLODPAAEOEO sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct OALPGHMPPAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public AsyncTaskMethodBuilder<EHBAKJCGEMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public JBEOIFKKBLD superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public GJEKPDGJJHD callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private KIGFPGFOJIO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private HEKEHEGBBLG <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private MLODPAAEOEO <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private JBEOIFKKBLD <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private JBEOIFKKBLD <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private TaskAwaiter<HEKEHEGBBLG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private TaskAwaiter<LNDNFODDKGM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private TaskAwaiter<KIKHMLAGMKE> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x6267DD0", Offset = "0x6266BD0", VA = "0x186267DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x6268E70", Offset = "0x6267C70", VA = "0x186268E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private GJEKPDGJJHD JOJOJMCMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private MLCFHDEFMPO BLBEIHCAEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private long ODPLBFKINCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private long PHHJICEDHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private long DLONNEIPGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private string HLFLAICBGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private JBEOIFKKBLD PAOGLAEEHFL;

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x6258BB0", Offset = "0x62579B0", VA = "0x186258BB0")]
	public static Task<EHBAKJCGEMK> JCEKJFIHDGP(JHENEJKEAOJ KFCMDEBDJKP, MMILHCEGCHA BHMKONDNBED, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x6258A60", Offset = "0x6257860", VA = "0x186258A60")]
	[AsyncStateMachine(typeof(AGJBEKNHEDF))]
	private Task<EHBAKJCGEMK> INEHGKEHGLC(CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x6258770", Offset = "0x6257570", VA = "0x186258770")]
	[AsyncStateMachine(typeof(FBNLNPPMNJH))]
	private Task<EHBAKJCGEMK> BNDOIPBDLCB(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x62588D0", Offset = "0x62576D0", VA = "0x1862588D0")]
	[AsyncStateMachine(typeof(OALPGHMPPAI))]
	private static Task<EHBAKJCGEMK> BNDOIPBDLCB(GJEKPDGJJHD JOJOJMCMCEP, long ODPLBFKINCE, long PHHJICEDHNG, long DLONNEIPGNE, string HLFLAICBGJM, JBEOIFKKBLD PAOGLAEEHFL, CancellationToken BCCDJHNACKO, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x6258E30", Offset = "0x6257C30", VA = "0x186258E30")]
	private void PLDJNBPDODH(HEKEHEGBBLG MBIKCDFGAEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct ODPEKKJANMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct FMJNDFDPBHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public ODPEKKJANMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x625D950", Offset = "0x625C750", VA = "0x18625D950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x625DEE0", Offset = "0x625CCE0", VA = "0x18625DEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private GJEKPDGJJHD JOJOJMCMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private NNEDCLBDCDJ LMCJHCIOIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private float IAHAFJAJJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private float MPLHIEEDBNB;

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x6268F00", Offset = "0x6267D00", VA = "0x186268F00")]
	public static Task GJMFLLJPLEL(JHENEJKEAOJ KFCMDEBDJKP, NNEDCLBDCDJ LMCJHCIOIIP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x62690A0", Offset = "0x6267EA0", VA = "0x1862690A0")]
	[AsyncStateMachine(typeof(FMJNDFDPBHL))]
	public Task INEHGKEHGLC(CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x62691C0", Offset = "0x6267FC0", VA = "0x1862691C0")]
	private static void KAGCCBJILCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x62693C0", Offset = "0x62681C0", VA = "0x1862693C0")]
	private void PAFNMHOGFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x6269300", Offset = "0x6268100", VA = "0x186269300")]
	private static float OJHHGHEDHPJ(GJEKPDGJJHD JOJOJMCMCEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6268EE0", Offset = "0x6267CE0", VA = "0x186268EE0")]
	private static float DODDGINGJHD()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct PKBBLBKGDBH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct HNPABDJBCEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public MNOFAHLHGGO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private CKELNELKOJL <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private JHENEJKEAOJ <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private CPEFNHJGJBP.JCKNOFIMDHK <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private TaskAwaiter<BPADINOBHMJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x625F620", Offset = "0x625E420", VA = "0x18625F620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x6260010", Offset = "0x625EE10", VA = "0x186260010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct MMGAHLPMKFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x6266920", Offset = "0x6265720", VA = "0x186266920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x6266C50", Offset = "0x6265A50", VA = "0x186266C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x626C900", Offset = "0x626B700", VA = "0x18626C900")]
	[AsyncStateMachine(typeof(HNPABDJBCEO))]
	public static Task INEHGKEHGLC(MNOFAHLHGGO ICJCFPNHMJP, NNEDCLBDCDJ LMCJHCIOIIP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x626C7E0", Offset = "0x626B5E0", VA = "0x18626C7E0")]
	private static Task<BPADINOBHMJ> BDKPIBOCPOK(MNOFAHLHGGO ICJCFPNHMJP, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x626C850", Offset = "0x626B650", VA = "0x18626C850")]
	[AsyncStateMachine(typeof(MMGAHLPMKFD))]
	private static Task DJAODDMFKKM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal struct PIODIEEPBCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct AFOCAEABIJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public PIODIEEPBCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x6255750", Offset = "0x6254550", VA = "0x186255750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6255E00", Offset = "0x6254C00", VA = "0x186255E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class PPAHADJKMLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public PPAHADJKMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x626D690", Offset = "0x626C490", VA = "0x18626D690")]
		internal object ELMDLAEOFAI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct FOKEFNJCKDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public PIODIEEPBCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private AIJKDNDEDKG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x625DF40", Offset = "0x625CD40", VA = "0x18625DF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x625E550", Offset = "0x625D350", VA = "0x18625E550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	private bool LPDHFCFHMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	private AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	private JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private CancellationToken BCCDJHNACKO;

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x626C550", Offset = "0x626B350", VA = "0x18626C550")]
	public static Task DEMOAEJONMB(JHENEJKEAOJ KFCMDEBDJKP, bool LPDHFCFHMNF, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken HCLJJGBIDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x626C6F0", Offset = "0x626B4F0", VA = "0x18626C6F0")]
	[AsyncStateMachine(typeof(AFOCAEABIJG))]
	private Task INEHGKEHGLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x626C5C0", Offset = "0x626B3C0", VA = "0x18626C5C0")]
	[AsyncStateMachine(typeof(FOKEFNJCKDC))]
	private Task HHFBDALDAPF(bool AAJJDIOINFF, string NBIMMAELPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300")]
	private bool DGMDDALPFBL(bool LPDHFCFHMNF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct BNPALDCDICP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct KJOBHLPGKGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public BNPALDCDICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x6264DE0", Offset = "0x6263BE0", VA = "0x186264DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x6265350", Offset = "0x6264150", VA = "0x186265350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class POHDBNMLOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public POHDBNMLOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x626D640", Offset = "0x626C440", VA = "0x18626D640")]
		internal object ELMDLAEOFAI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct OPJBOBMACDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public BNPALDCDICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private AIJKDNDEDKG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x626A370", Offset = "0x6269170", VA = "0x18626A370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x626A950", Offset = "0x6269750", VA = "0x18626A950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private NPGOIDNKJIO DMAKELFALAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private bool DECLKKCOHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000577")]
	private NNEDCLBDCDJ LMCJHCIOIIP;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6258E60", Offset = "0x6257C60", VA = "0x186258E60")]
	public static Task<Scene> FNFKDOJGHEI(JHENEJKEAOJ KFCMDEBDJKP, NPGOIDNKJIO PNPDAPCGMPF, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6259030", Offset = "0x6257E30", VA = "0x186259030")]
	[AsyncStateMachine(typeof(KJOBHLPGKGJ))]
	private Task<Scene> INEHGKEHGLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x62591C0", Offset = "0x6257FC0", VA = "0x1862591C0")]
	private bool ONHNGNFEDBL(NNEDCLBDCDJ LMCJHCIOIIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x6259150", Offset = "0x6257F50", VA = "0x186259150")]
	private void JGNBFNDMLPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x6258EE0", Offset = "0x6257CE0", VA = "0x186258EE0")]
	[AsyncStateMachine(typeof(OPJBOBMACDO))]
	private Task<Scene> HHFBDALDAPF(string NBIMMAELPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct KHAEJGIBJFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct OOCBGKFHHJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder<CNEEJNIMOIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public KHAEJGIBJFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public CNEEJNIMOIF nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public NNEDCLBDCDJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private TaskAwaiter<CNEEJNIMOIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x6269820", Offset = "0x6268620", VA = "0x186269820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x626A300", Offset = "0x6269100", VA = "0x18626A300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct CHGBHDLLFOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public AsyncTaskMethodBuilder<CNEEJNIMOIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public KHAEJGIBJFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public CNEEJNIMOIF state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private TaskAwaiter<BPADINOBHMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x625A460", Offset = "0x6259260", VA = "0x18625A460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x625A740", Offset = "0x6259540", VA = "0x18625A740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private readonly MNOFAHLHGGO ICJCFPNHMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private readonly MLCFHDEFMPO BLBEIHCAEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private readonly BAHOBGPGCIJ HFGLMKGJOBA;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private CKELNELKOJL OEHACKOMCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0BC0", Offset = "0x4BAF9C0", VA = "0x184BB0BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6264D80", Offset = "0x6263B80", VA = "0x186264D80")]
	public KHAEJGIBJFD(MNOFAHLHGGO ICJCFPNHMJP, MLCFHDEFMPO BLBEIHCAEIO, BAHOBGPGCIJ HFGLMKGJOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x6264C00", Offset = "0x6263A00", VA = "0x186264C00")]
	[AsyncStateMachine(typeof(OOCBGKFHHJH))]
	public Task<CNEEJNIMOIF> OILHBMBCIFF(CNEEJNIMOIF JIMGFHMIKHL, NNEDCLBDCDJ EPLEDHCPFCN, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO, bool OMKKEEENKBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x6264A70", Offset = "0x6263870", VA = "0x186264A70")]
	[AsyncStateMachine(typeof(CHGBHDLLFOM))]
	private Task<CNEEJNIMOIF> DNODIDNGMAP(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CNEEJNIMOIF KIGOLAOAAMI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x6264BD0", Offset = "0x62639D0", VA = "0x186264BD0")]
	private bool GFEKAMDHAML(CNEEJNIMOIF HCAMOBIIBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x6264A50", Offset = "0x6263850", VA = "0x186264A50")]
	private void BPAIBICBBJL(string DDCFNAHDILI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct PNALPDCMEII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct PNCMLPNJLLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public CKELNELKOJL operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public NAGGDKFKHLB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private List<(PersistenceView, JBHCDHCPMCM)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private (PersistenceView, JBHCDHCPMCM) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x626CFA0", Offset = "0x626BDA0", VA = "0x18626CFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x626D5E0", Offset = "0x626C3E0", VA = "0x18626D5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x626CE60", Offset = "0x626BC60", VA = "0x18626CE60")]
	[AsyncStateMachine(typeof(PNCMLPNJLLO))]
	public static Task INEHGKEHGLC(CKELNELKOJL BJKAIBLEACD, NNEDCLBDCDJ LMCJHCIOIIP, NAGGDKFKHLB MFGBLFEINMJ, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct CFHFDMKLJIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct NLEMLKENNBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public CKELNELKOJL operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public NAGGDKFKHLB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private BIPJOHNJPOB <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private List<(PersistenceView, JBHCDHCPMCM)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private JBHCDHCPMCM <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x6266CB0", Offset = "0x6265AB0", VA = "0x186266CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x6267510", Offset = "0x6266310", VA = "0x186267510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x625A320", Offset = "0x6259120", VA = "0x18625A320")]
	[AsyncStateMachine(typeof(NLEMLKENNBB))]
	public static Task INEHGKEHGLC(CKELNELKOJL BJKAIBLEACD, NNEDCLBDCDJ LMCJHCIOIIP, NAGGDKFKHLB MFGBLFEINMJ, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct CPEFNHJGJBP
{
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	public struct JCKNOFIMDHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public List<MFKKNAKAFKL> IFBKNDCHBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public List<JBHCDHCPMCM> LFDJANGPAOG;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x7E8680", Offset = "0x7E7480", VA = "0x1807E8680")]
		public JCKNOFIMDHK(List<MFKKNAKAFKL> IFBKNDCHBIM, List<JBHCDHCPMCM> LFDJANGPAOG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class IMGGMBPKIEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public IEnumerable<MFKKNAKAFKL> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public IMGGMBPKIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x6260CF0", Offset = "0x625FAF0", VA = "0x186260CF0")]
		internal object NJDIGOIPPAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B4")]
	private JHENEJKEAOJ KFCMDEBDJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B5")]
	private NNEDCLBDCDJ LMCJHCIOIIP;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private GJEKPDGJJHD HGMDPNHJIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x625AE50", Offset = "0x6259C50", VA = "0x18625AE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x625B070", Offset = "0x6259E70", VA = "0x18625B070")]
	public static JCKNOFIMDHK INEHGKEHGLC(JHENEJKEAOJ KFCMDEBDJKP, NNEDCLBDCDJ LMCJHCIOIIP)
	{
		return default(JCKNOFIMDHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x625B0D0", Offset = "0x6259ED0", VA = "0x18625B0D0")]
	private JCKNOFIMDHK INEHGKEHGLC()
	{
		return default(JCKNOFIMDHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x625B330", Offset = "0x625A130", VA = "0x18625B330")]
	private JCKNOFIMDHK KHALKGCOKAA(ELNFILGNBCL AEHMMJMEEDB, BIPJOHNJPOB NCIJEBJJAKH)
	{
		return default(JCKNOFIMDHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x625AEA0", Offset = "0x6259CA0", VA = "0x18625AEA0")]
	private bool CPOLAGABOBK(IEnumerable<MFKKNAKAFKL> IFBKNDCHBIM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct KFDPKKHEENL
{
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class LLAAGKJLGDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public CPEFNHJGJBP.JCKNOFIMDHK instantiations;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public LLAAGKJLGDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x62661A0", Offset = "0x6264FA0", VA = "0x1862661A0")]
		internal object CKPLOJLPFMP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class ABFNCPKPAIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public ABFNCPKPAIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x62556C0", Offset = "0x62544C0", VA = "0x1862556C0")]
		internal object NOENIAHBEBC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x6263FE0", Offset = "0x6262DE0", VA = "0x186263FE0")]
	public static void INEHGKEHGLC(CKELNELKOJL BJKAIBLEACD, NNEDCLBDCDJ LMCJHCIOIIP, CPEFNHJGJBP.JCKNOFIMDHK PCADOKDNNHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal class BAHOBGPGCIJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct JFMKNLKBEEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public BAHOBGPGCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public CNEEJNIMOIF operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public NNEDCLBDCDJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x6261930", Offset = "0x6260730", VA = "0x186261930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x62620A0", Offset = "0x6260EA0", VA = "0x1862620A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class GPLABKOGJBJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000165")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public GPLABKOGJBJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005CE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x626D910", Offset = "0x626C710", VA = "0x18626D910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x626DBD0", Offset = "0x626C9D0", VA = "0x18626DBD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public BAHOBGPGCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GPLABKOGJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x625EDD0", Offset = "0x625DBD0", VA = "0x18625EDD0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task MCECLHNOLBA(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct HOOCHLFKONF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public BAHOBGPGCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private GPLABKOGJBJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x6260070", Offset = "0x625EE70", VA = "0x186260070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x62605A0", Offset = "0x625F3A0", VA = "0x1862605A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct HMLPECAGHMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public BAHOBGPGCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private Dictionary<Guid, List<LJFPLDLNAJC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x625F010", Offset = "0x625DE10", VA = "0x18625F010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x625F5C0", Offset = "0x625E3C0", VA = "0x18625F5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct BGDILALJIJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public BAHOBGPGCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private Dictionary<Guid, List<LJFPLDLNAJC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x6258090", Offset = "0x6256E90", VA = "0x186258090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x6258710", Offset = "0x6257510", VA = "0x186258710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class JJNJNEJODFD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016A")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005EE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005EF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F0")]
			public LJFPLDLNAJC handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			public JJNJNEJODFD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x626D710", Offset = "0x626C510", VA = "0x18626D710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x626D8B0", Offset = "0x626C6B0", VA = "0x18626D8B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public OMGAFDNLHBK runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public List<LJFPLDLNAJC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JJNJNEJODFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x62621F0", Offset = "0x6260FF0", VA = "0x1862621F0")]
		internal object HPPGPMACLBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x6262100", Offset = "0x6260F00", VA = "0x186262100")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task EIPOHDCCNHL(LJFPLDLNAJC handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x62622E0", Offset = "0x62610E0", VA = "0x1862622E0")]
		internal object PFLOBFMCMAA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct PIGNKPMONOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public OMGAFDNLHBK runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public List<LJFPLDLNAJC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private JJNJNEJODFD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x626AF30", Offset = "0x6269D30", VA = "0x18626AF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x626B400", Offset = "0x626A200", VA = "0x18626B400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct MAFBLIPDAPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public BAHOBGPGCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x62662C0", Offset = "0x62650C0", VA = "0x1862662C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x6266870", Offset = "0x6265670", VA = "0x186266870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class MACCKHJALKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public MACCKHJALKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x6266250", Offset = "0x6265050", VA = "0x186266250")]
		internal object PKOMLIDKJJB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct PFPKJOIPJKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public BAHOBGPGCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public NNEDCLBDCDJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x626A9C0", Offset = "0x62697C0", VA = "0x18626A9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x626AED0", Offset = "0x6269CD0", VA = "0x18626AED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class DCGNHMGBJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public DCGNHMGBJMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x625B8E0", Offset = "0x625A6E0", VA = "0x18625B8E0")]
		internal object BHHPEHMGPIF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct AOHFLOIEKLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public BAHOBGPGCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private TaskAwaiter<BPADINOBHMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x6256340", Offset = "0x6255140", VA = "0x186256340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x62569C0", Offset = "0x62557C0", VA = "0x1862569C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class ANLEKFOLFKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public ANLEKFOLFKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x62562D0", Offset = "0x62550D0", VA = "0x1862562D0")]
		internal object GBJJAMCIHDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private readonly MNOFAHLHGGO ICJCFPNHMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	private NIHCKIOHHFA HFGLMKGJOBA;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private CKELNELKOJL OEHACKOMCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x1A2FBF0", Offset = "0x1A2E9F0", VA = "0x181A2FBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public BAHOBGPGCIJ(MNOFAHLHGGO ICJCFPNHMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x6256FC0", Offset = "0x6255DC0", VA = "0x186256FC0")]
	[AsyncStateMachine(typeof(JFMKNLKBEEF))]
	public Task INEHGKEHGLC(CNEEJNIMOIF ANEAGIEPPDJ, NNEDCLBDCDJ EPLEDHCPFCN, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x6256E80", Offset = "0x6255C80", VA = "0x186256E80")]
	[AsyncStateMachine(typeof(HOOCHLFKONF))]
	private Task IIODIDJGONJ(NNEDCLBDCDJ LMCJHCIOIIP, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x6257110", Offset = "0x6255F10", VA = "0x186257110")]
	[AsyncStateMachine(typeof(HMLPECAGHMM))]
	private Task KFGKBMIENDL(NNEDCLBDCDJ LMCJHCIOIIP, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x6256D40", Offset = "0x6255B40", VA = "0x186256D40")]
	[AsyncStateMachine(typeof(BGDILALJIJF))]
	private Task HHDLHIOILJM(NNEDCLBDCDJ LMCJHCIOIIP, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x6257300", Offset = "0x6256100", VA = "0x186257300")]
	[AsyncStateMachine(typeof(PIGNKPMONOI))]
	private Task MIDJIEAFLOG(Guid FDEFMENCACN, List<LJFPLDLNAJC> CCHHHGDGGOK, OMGAFDNLHBK BJGBENPMHIH, NNEDCLBDCDJ LMCJHCIOIIP, CancellationToken EKDHBKMFLGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x6257450", Offset = "0x6256250", VA = "0x186257450")]
	[AsyncStateMachine(typeof(MAFBLIPDAPC))]
	private Task NADLPCAIKLI(NNEDCLBDCDJ LMCJHCIOIIP, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x6256A20", Offset = "0x6255820", VA = "0x186256A20")]
	[AsyncStateMachine(typeof(PFPKJOIPJKN))]
	private Task DMFPMHHLIKM(Guid ODGDCCBLCEC, NNEDCLBDCDJ LMCJHCIOIIP, AEMIIEBAFHL<string>.GMENFEPMDPA DNLFOGHCHDI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x62576B0", Offset = "0x62564B0", VA = "0x1862576B0")]
	[AsyncStateMachine(typeof(AOHFLOIEKLK))]
	private Task OGIFPGBNGHD(Guid ODGDCCBLCEC, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x6257590", Offset = "0x6256390", VA = "0x186257590")]
	private void NEBEFJKFJMH(Guid ODGDCCBLCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x6257250", Offset = "0x6256050", VA = "0x186257250")]
	private void LOMIPCACJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x62577F0", Offset = "0x62565F0", VA = "0x1862577F0")]
	public Guid OGNHAKJEBOM(CNEEJNIMOIF LBDMAKFKENM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x6256B60", Offset = "0x6255960", VA = "0x186256B60")]
	[CompilerGenerated]
	private object GLMMBOOIPBA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
public readonly struct KLDKAMMCIHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	public readonly bool GBJBKNFEKEN;

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0xB50F00", Offset = "0xB4FD00", VA = "0x180B50F00")]
	public KLDKAMMCIHI(bool AIKIAOLKLIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public readonly struct CEIMFNJANHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	public readonly ELNFILGNBCL? MDJBCFMJKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	public readonly KGDCJBBNKCO PBMJCACKOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	public readonly string? IEPKBHEBKBD;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public IReadOnlyCollection<string> AJDLMKKIJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x625A1E0", Offset = "0x6258FE0", VA = "0x18625A1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public IReadOnlyDictionary<long, int> NPGCDPAFJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x625A200", Offset = "0x6259000", VA = "0x18625A200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x625A220", Offset = "0x6259020", VA = "0x18625A220")]
	public CEIMFNJANHL(ELNFILGNBCL? EDDLBMGEMFE, KGDCJBBNKCO GIDKJMKJLPE, string? JEEIKFCHBFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
internal class PIKEEBBOBMO : CGBFJPILGOO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct BDJIIFCLHCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public AsyncTaskMethodBuilder<CEIMFNJANHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public PIKEEBBOBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public BOCBEKEAIOO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public EBDAGPGFMGD roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x6257980", Offset = "0x6256780", VA = "0x186257980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x6258020", Offset = "0x6256E20", VA = "0x186258020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class OKGIGPEHJPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public BOCBEKEAIOO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public PIKEEBBOBMO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public OKGIGPEHJPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x6269520", Offset = "0x6268320", VA = "0x186269520")]
		internal Task FGFFCBAHJOE(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x6269740", Offset = "0x6268540", VA = "0x186269740")]
		internal Task PFDANGHFGFG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class CICDILPBBJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public OKGIGPEHJPP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public CICDILPBBJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x625A7B0", Offset = "0x62595B0", VA = "0x18625A7B0")]
		internal object BMOPEALBJCD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class DDJACDCIFEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public OKGIGPEHJPP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public DDJACDCIFEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x625B950", Offset = "0x625A750", VA = "0x18625B950")]
		internal Task BOJHOBBALAO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct KPBANIGBKLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public BOCBEKEAIOO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public PIKEEBBOBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private CICDILPBBJJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6265880", Offset = "0x6264680", VA = "0x186265880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x6266140", Offset = "0x6264F40", VA = "0x186266140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400061E")]
	private readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x400061F")]
	private static readonly TimeSpan KHLJEFOABAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000620")]
	private readonly CAGHMBCDIEJ NCBFGNIBMND;

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x626C500", Offset = "0x626B300", VA = "0x18626C500")]
	public PIKEEBBOBMO(MNOFAHLHGGO ICJCFPNHMJP, CAGHMBCDIEJ NCBFGNIBMND, HICMFDICNOL DFCBIKLJFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x626BE90", Offset = "0x626AC90", VA = "0x18626BE90")]
	[AsyncStateMachine(typeof(BDJIIFCLHCK))]
	public Task<CEIMFNJANHL> LJOKGFFEJKK(long PHHJICEDHNG, EBDAGPGFMGD FEKLNEOLNJA, BOCBEKEAIOO IOCBNJPMDCM, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x626BD40", Offset = "0x626AB40", VA = "0x18626BD40")]
	[AsyncStateMachine(typeof(KPBANIGBKLN))]
	private Task FAOJCOLLEPI(BOCBEKEAIOO IOCBNJPMDCM, IEnumerable<PersistenceView> AONGJLILFGH, StringBuilder EADMIAKJNBO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x626BFF0", Offset = "0x626ADF0", VA = "0x18626BFF0")]
	private CEIMFNJANHL OFOKCGOGMGC(long PHHJICEDHNG, EBDAGPGFMGD FEKLNEOLNJA, BOCBEKEAIOO IOCBNJPMDCM, IEnumerable<PersistenceView> AONGJLILFGH, StringBuilder EADMIAKJNBO)
	{
		return default(CEIMFNJANHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x626BB80", Offset = "0x626A980", VA = "0x18626BB80")]
	private ELNFILGNBCL CCPLFKGMCGN(long PHHJICEDHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x626B460", Offset = "0x626A260", VA = "0x18626B460")]
	private void ABBAEBGCCPI(ELNFILGNBCL LALHNMMJDCP, StringBuilder EADMIAKJNBO, IEnumerable<PersistenceView> AONGJLILFGH, [In] LHDGHOEKHHB KLFEPFLKKDP, NGGJLDGMDCB FLPECDDACOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x626B6B0", Offset = "0x626A4B0", VA = "0x18626B6B0")]
	private void BIBLJMIFCDP(ELNFILGNBCL LALHNMMJDCP, StringBuilder EADMIAKJNBO, PersistenceView KBMGDEBBCNM, NGGJLDGMDCB FLPECDDACOM, [In] LHDGHOEKHHB KLFEPFLKKDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal class IGNPADGHKFJ : CGBFJPILGOO
{
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class MMALDPPAPNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public PMDDIMOKLPO.OMOIJHKFOPO roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public MMALDPPAPNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x62668D0", Offset = "0x62656D0", VA = "0x1862668D0")]
		internal object HNALCEAFHNO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct JLCDPFGKKHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public AsyncTaskMethodBuilder<(PMDDIMOKLPO.OMOIJHKFOPO roomDataUpload, PMDDIMOKLPO.OMOIJHKFOPO subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public CEIMFNJANHL roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public IGNPADGHKFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private MMALDPPAPNK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private TaskAwaiter<PMDDIMOKLPO.OMOIJHKFOPO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x62623D0", Offset = "0x62611D0", VA = "0x1862623D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x6262C10", Offset = "0x6261A10", VA = "0x186262C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct FBCMHJPFFOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public AsyncTaskMethodBuilder<PAFEDHKBAIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public IGNPADGHKFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public CEIMFNJANHL roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public BFOHOABJCJF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private TaskAwaiter<(PMDDIMOKLPO.OMOIJHKFOPO roomDataUpload, PMDDIMOKLPO.OMOIJHKFOPO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private TaskAwaiter<PAFEDHKBAIE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x625CAA0", Offset = "0x625B8A0", VA = "0x18625CAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x625D0C0", Offset = "0x625BEC0", VA = "0x18625D0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct GLBKNIAOMFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public AsyncTaskMethodBuilder<LNDNFODDKGM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public IGNPADGHKFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CEIMFNJANHL roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private TaskAwaiter<(PMDDIMOKLPO.OMOIJHKFOPO roomDataUpload, PMDDIMOKLPO.OMOIJHKFOPO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private TaskAwaiter<LNDNFODDKGM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x625E620", Offset = "0x625D420", VA = "0x18625E620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x625EA40", Offset = "0x625D840", VA = "0x18625EA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class ECOIKFNNPOB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000182")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400066C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400066D")]
			public AsyncTaskMethodBuilder<BPADINOBHMJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400066E")]
			public ECOIKFNNPOB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400066F")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000670")]
			private BPADINOBHMJ <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000671")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000672")]
			private TaskAwaiter<LNDNFODDKGM> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000673")]
			private TaskAwaiter<PAFEDHKBAIE> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000674")]
			private TaskAwaiter<BPADINOBHMJ> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x626DC30", Offset = "0x626CA30", VA = "0x18626DC30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x626EC30", Offset = "0x626DA30", VA = "0x18626EC30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public IGNPADGHKFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public CEIMFNJANHL roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public BFOHOABJCJF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public KLDKAMMCIHI roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public ECOIKFNNPOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x625B990", Offset = "0x625A790", VA = "0x18625B990")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<BPADINOBHMJ> HDKEMBPEMJH(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct BONFKIFHLII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder<BPADINOBHMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public IGNPADGHKFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public CEIMFNJANHL roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public BFOHOABJCJF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public KLDKAMMCIHI roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private TaskAwaiter<BPADINOBHMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x62591F0", Offset = "0x6257FF0", VA = "0x1862591F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x6259500", Offset = "0x6258300", VA = "0x186259500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x4000644")]
	private static readonly HICMFDICNOL EDDPKBMDFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	private readonly NJNGIFKKLFA JIBEHDPBDBH;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private JHENEJKEAOJ NCNLGKFEJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x623F160", Offset = "0x623DF60", VA = "0x18623F160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x6260C60", Offset = "0x625FA60", VA = "0x186260C60")]
	public IGNPADGHKFJ(MNOFAHLHGGO ICJCFPNHMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x6260910", Offset = "0x625F710", VA = "0x186260910")]
	[AsyncStateMachine(typeof(JLCDPFGKKHB))]
	private Task<(PMDDIMOKLPO.OMOIJHKFOPO, PMDDIMOKLPO.OMOIJHKFOPO)> HANPKKFMLBO(CEIMFNJANHL AKFMCNAFBFA, long ODPLBFKINCE, long CNKFDDFGKPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x6260A50", Offset = "0x625F850", VA = "0x186260A50")]
	[AsyncStateMachine(typeof(FBCMHJPFFOM))]
	public Task<PAFEDHKBAIE> KJELEDJIHNK(int OCBCHOCNCAE, [CanBeNull] BFOHOABJCJF GBODCICDBDD, CEIMFNJANHL AKFMCNAFBFA, long ODPLBFKINCE, long CNKFDDFGKPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x6260600", Offset = "0x625F400", VA = "0x186260600")]
	[AsyncStateMachine(typeof(GLBKNIAOMFO))]
	private Task<LNDNFODDKGM> FBGDDCKJLAO(string HLFLAICBGJM, int OCBCHOCNCAE, CEIMFNJANHL AKFMCNAFBFA, long ODPLBFKINCE, long CNKFDDFGKPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x6260770", Offset = "0x625F570", VA = "0x186260770")]
	[AsyncStateMachine(typeof(BONFKIFHLII))]
	public Task<BPADINOBHMJ> GMIDOIHBFDK(int OCBCHOCNCAE, BFOHOABJCJF? GBODCICDBDD, CEIMFNJANHL AKFMCNAFBFA, long ODPLBFKINCE, long CNKFDDFGKPE, KLDKAMMCIHI KHMJPBEHNHE, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public abstract class JDEHAINLGDD<T> where T : JDEHAINLGDD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	internal readonly JHENEJKEAOJ KPMFFFHMKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private int? KEMAOKIMCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	protected readonly Guid LLNDMFMBIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	protected readonly HKNPACFPCEJ CDPLFNKBOCI;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	protected T ALAOIFFNEPA
	{
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x3834860", Offset = "0x3833660", VA = "0x183834860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x3834A70", Offset = "0x3833870", VA = "0x183834A70")]
	internal JDEHAINLGDD(JHENEJKEAOJ KLDMNKAPIJL, HKNPACFPCEJ FBODNDFGDIK, [Optional] Guid? ODNBBNPINDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x38346F0", Offset = "0x38334F0", VA = "0x1838346F0")]
	private BPADINOBHMJ ACIDJADKFKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "4")]
	protected virtual void FEPFFIEAKFA(BPADINOBHMJ BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x38347D0", Offset = "0x38335D0", VA = "0x1838347D0")]
	public T CLMDHINEGJN(OOAELAJMHEN DPOAKIJENBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x38348C0", Offset = "0x38336C0", VA = "0x1838348C0")]
	public T KEMFLOIFBJI(int CNPBOLIMPBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x3834950", Offset = "0x3833750", VA = "0x183834950", Slot = "5")]
	public virtual Task<DBGMMOMFJAO> LGGNHHEJBHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class COCNALHNELK : JDEHAINLGDD<COCNALHNELK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private MMILHCEGCHA JOPBACODGFL;

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x625AD80", Offset = "0x6259B80", VA = "0x18625AD80")]
	internal COCNALHNELK(JHENEJKEAOJ KLDMNKAPIJL, HKNPACFPCEJ FBODNDFGDIK, [Optional] Guid? ODNBBNPINDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x593DBB0", Offset = "0x593C9B0", VA = "0x18593DBB0")]
	public COCNALHNELK DAPFOPIODNJ(MMILHCEGCHA JOPBACODGFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x625ACB0", Offset = "0x6259AB0", VA = "0x18625ACB0", Slot = "4")]
	protected override void FEPFFIEAKFA(BPADINOBHMJ BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public class CLODLNHKJBB : JDEHAINLGDD<CLODLNHKJBB>
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	internal enum FOHONGHGEEE
	{
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private struct PMBHJDIAPHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public AsyncTaskMethodBuilder<DBGMMOMFJAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public CLODLNHKJBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private TaskAwaiter<DBGMMOMFJAO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x626CA40", Offset = "0x626B840", VA = "0x18626CA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x626CDF0", Offset = "0x626BBF0", VA = "0x18626CDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private FOHONGHGEEE DIKPGIMBHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private string NJILAOHLDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private BFOHOABJCJF JOPBACODGFL;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x625AB40", Offset = "0x6259940", VA = "0x18625AB40")]
	internal CLODLNHKJBB(JHENEJKEAOJ KLDMNKAPIJL, HKNPACFPCEJ FBODNDFGDIK, [Optional] Guid? ODNBBNPINDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x625AA20", Offset = "0x6259820", VA = "0x18625AA20")]
	public CLODLNHKJBB LCKAMAPLKOC(string DCLCBHADCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x625A860", Offset = "0x6259660", VA = "0x18625A860")]
	public CLODLNHKJBB CBIODOEJMJP(bool ECPPNCGBNEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x625A9F0", Offset = "0x62597F0", VA = "0x18625A9F0")]
	public CLODLNHKJBB IHOKOFIGKNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x625A880", Offset = "0x6259680", VA = "0x18625A880", Slot = "4")]
	protected override void FEPFFIEAKFA(BPADINOBHMJ BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x625AA50", Offset = "0x6259850", VA = "0x18625AA50", Slot = "5")]
	[AsyncStateMachine(typeof(PMBHJDIAPHO))]
	public override Task<DBGMMOMFJAO> LGGNHHEJBHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x625A820", Offset = "0x6259620", VA = "0x18625A820")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<DBGMMOMFJAO> BLCEMPLPKDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal static class BONIKLKIJFC
{
	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x62595F0", Offset = "0x62583F0", VA = "0x1862595F0")]
	public static void KKBADDMOGFO(this PAIBCHOHLHM EAPOOONPJJK, KGDNOOKHPHA MMPNDNJPMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x6259570", Offset = "0x6258370", VA = "0x186259570")]
	public static void JJALFACIALA(this KGDNOOKHPHA CMLDOPFAAJF, [Optional] string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
public static class HCJPJPEBBMA
{
	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x625EF70", Offset = "0x625DD70", VA = "0x18625EF70")]
	public static JBEOIFKKBLD MKFINPFEFPJ(this EDGIMNNBDNH MIBDLONNHLG)
	{
		return default(JBEOIFKKBLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x625EEC0", Offset = "0x625DCC0", VA = "0x18625EEC0")]
	public static EDGIMNNBDNH JOBEHILKMOP(this JBEOIFKKBLD LJGIJJALHAF)
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
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			public FIHOCAFBEOC ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000696")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000697")]
			public FIHOCAFBEOC HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000698")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000699")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400069A")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private static FIHOCAFBEOC[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private Dictionary<FIHOCAFBEOC, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x626F330", Offset = "0x626E130", VA = "0x18626F330")]
		public bool CGOELIDCHDK(FIHOCAFBEOC AJALDJIMLAP, [Out] ResultConfig ODAKGFFPNLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x626F3A0", Offset = "0x626E1A0", VA = "0x18626F3A0")]
		public ResultConfig DEJMJDHIHNE(FIHOCAFBEOC BNAPAMOAFNA, [Optional] HashSet<FIHOCAFBEOC> DALNMOPIEII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x626FA40", Offset = "0x626E840", VA = "0x18626FA40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x626F4E0", Offset = "0x626E2E0", VA = "0x18626F4E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x84A0A0", Offset = "0x848EA0", VA = "0x18084A0A0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class KLGNJJIKCFB
{
	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x62653C0", Offset = "0x62641C0", VA = "0x1862653C0")]
	[DJDJPHIPNFL(IEJLPKKICHC.GameOnly)]
	private static void AMIIDJBEOMM(NNIGDKDCOBN AMGLAFJJOEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public interface KOAFPCAGHPM : IEquatable<KOAFPCAGHPM>
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	DateTime JLOLHPGIGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDEFDFILPKJ();

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AKKDKHIICHJ(long ODPLBFKINCE, long PHHJICEDHNG, [Out] CEIMFNJANHL AKFMCNAFBFA);
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
internal class JDDKHFPNKBA : EFINLOBHEIP
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class GBPNABIDEDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public JHEKNEICBIJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GBPNABIDEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x625E5B0", Offset = "0x625D3B0", VA = "0x18625E5B0")]
		internal object MPGNGFEICKB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private readonly ELCDNIGPPNM IEAAHHIPGDF;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<KOAFPCAGHPM> BHGGAAFNFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x62616A0", Offset = "0x62604A0", VA = "0x1862616A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x62611A0", Offset = "0x625FFA0", VA = "0x1862611A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	[UnityEngine.Scripting.Preserve]
	public JDDKHFPNKBA([FGPOJKOJBFM(null)] ELCDNIGPPNM IEAAHHIPGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x62613C0", Offset = "0x62601C0", VA = "0x1862613C0", Slot = "6")]
	public bool LIEJCDCDHPC(long ODPLBFKINCE, long PHHJICEDHNG, CEIMFNJANHL AKFMCNAFBFA, JHEKNEICBIJ ANAIDGIIPAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x17FDD90", Offset = "0x17FCB90", VA = "0x1817FDD90")]
	private void KBDNMFOOIKC(KOAFPCAGHPM GHLCENPLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x6261250", Offset = "0x6260050", VA = "0x186261250", Slot = "7")]
	public bool LEDLLDLELPK(long ODPLBFKINCE, long PHHJICEDHNG, [Out] KOAFPCAGHPM FBHFFEMKPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x6261880", Offset = "0x6260680", VA = "0x186261880", Slot = "8")]
	public bool ONCDNMJNACO(long ODPLBFKINCE, long PHHJICEDHNG, JHEKNEICBIJ ANAIDGIIPAF, [Out] KOAFPCAGHPM FBHFFEMKPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x6260D70", Offset = "0x625FB70", VA = "0x186260D70")]
	private void HJNINHPJHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x6261750", Offset = "0x6260550", VA = "0x186261750", Slot = "9")]
	public void OMOLDIJDKNB(long ODPLBFKINCE, long PHHJICEDHNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal abstract class CDOHKMNKLFB : ELCDNIGPPNM
{
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	protected enum PEKLNECHEOL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class FDGJPKPKJNN : IEnumerable<KOAFPCAGHPM>, IEnumerable, IEnumerator<KOAFPCAGHPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private KOAFPCAGHPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public CDOHKMNKLFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private JHEKNEICBIJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public JHEKNEICBIJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private KOAFPCAGHPM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x86F050", Offset = "0x86DE50", VA = "0x18086F050")]
		[DebuggerHidden]
		public FDGJPKPKJNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x625D620", Offset = "0x625C420", VA = "0x18625D620", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x625D900", Offset = "0x625C700", VA = "0x18625D900", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x625D850", Offset = "0x625C650", VA = "0x18625D850", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KOAFPCAGHPM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x625D850", Offset = "0x625C650", VA = "0x18625D850", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class JMIPGEKOGDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public JHEKNEICBIJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JMIPGEKOGDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6263320", Offset = "0x6262120", VA = "0x186263320")]
		internal object JGDHNLAMCMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class FBGMMCEPBCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public CDOHKMNKLFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public FBGMMCEPBCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x625D130", Offset = "0x625BF30", VA = "0x18625D130")]
		internal void EJGGGLGMMLD(GHCEJBEMPJI.KJMMBKPIAGJ ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	protected readonly string PCHMFDMPBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private readonly object JIJLAMHNIOE;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract HEMPGMADGFC GGAPLJBHKBN
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x625A140", Offset = "0x6258F40", VA = "0x18625A140")]
	protected CDOHKMNKLFB([CanBeNull] string KJCGFGDJOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x6259B30", Offset = "0x6258930", VA = "0x186259B30", Slot = "5")]
	public bool HJCBNFBPOKE(long ODPLBFKINCE, long PHHJICEDHNG, JHEKNEICBIJ ANAIDGIIPAF, [Out] KOAFPCAGHPM GHLCENPLAFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x625A0B0", Offset = "0x6258EB0", VA = "0x18625A0B0", Slot = "6")]
	[IteratorStateMachine(typeof(FDGJPKPKJNN))]
	public IEnumerable<KOAFPCAGHPM> JIMKOFHLBJK(JHEKNEICBIJ ANAIDGIIPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void MGPFBCAOEBG(Stream IGMJMFMMOEA, long ODPLBFKINCE, long PHHJICEDHNG, CEIMFNJANHL AKFMCNAFBFA);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool BOCFAEKCNOE(Stream OMHBJBMBMLB, long ODPLBFKINCE, long PHHJICEDHNG, MKODPGPJAFN BOIPANAIPAH, [Out] CEIMFNJANHL AKFMCNAFBFA);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x6259740", Offset = "0x6258540", VA = "0x186259740", Slot = "7")]
	public KOAFPCAGHPM EDCMEMIGLNK(long ODPLBFKINCE, long PHHJICEDHNG, CEIMFNJANHL AKFMCNAFBFA, JHEKNEICBIJ ANAIDGIIPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo FECDOAIOFOI(long ODPLBFKINCE, long PHHJICEDHNG, JHEKNEICBIJ ANAIDGIIPAF, PEKLNECHEOL OOCICAPBMJJ);

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo DLDBCFFAHPN(JHEKNEICBIJ ANAIDGIIPAF, PEKLNECHEOL OOCICAPBMJJ);

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x6259AC0", Offset = "0x62588C0", VA = "0x186259AC0")]
	protected void FGBCMGJPLBC(GHCEJBEMPJI.KJMMBKPIAGJ DJGGOPGKFCI, string DDCFNAHDILI, FileInfo INNALFCDOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x6259D20", Offset = "0x6258B20", VA = "0x186259D20")]
	internal bool IPADFFIKKEB(FileInfo FOKLHPFKEDI, long ODPLBFKINCE, long PHHJICEDHNG, [Out] CEIMFNJANHL AKFMCNAFBFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private void CPJDBIHDJLL(Exception GAGKDENINAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
internal class KFDMOIPOGMD : CDOHKMNKLFB
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public override HEMPGMADGFC GGAPLJBHKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xA55820", Offset = "0xA54620", VA = "0x180A55820", Slot = "8")]
		get
		{
			return default(HEMPGMADGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x6263F20", Offset = "0x6262D20", VA = "0x186263F20")]
	public KFDMOIPOGMD([Optional] string KJCGFGDJOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x6263A10", Offset = "0x6262810", VA = "0x186263A10")]
	private void CCGJFPJPBGB(JHEKNEICBIJ ANAIDGIIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x6263C90", Offset = "0x6262A90", VA = "0x186263C90", Slot = "9")]
	internal override void MGPFBCAOEBG(Stream IGMJMFMMOEA, long ODPLBFKINCE, long PHHJICEDHNG, CEIMFNJANHL AKFMCNAFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x62633C0", Offset = "0x62621C0", VA = "0x1862633C0", Slot = "10")]
	internal override bool BOCFAEKCNOE(Stream OMHBJBMBMLB, long ODPLBFKINCE, long PHHJICEDHNG, MKODPGPJAFN BOIPANAIPAH, [Out] CEIMFNJANHL AKFMCNAFBFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x6263BA0", Offset = "0x62629A0", VA = "0x186263BA0", Slot = "11")]
	protected override FileInfo FECDOAIOFOI(long ODPLBFKINCE, long PHHJICEDHNG, JHEKNEICBIJ ANAIDGIIPAF, PEKLNECHEOL OOCICAPBMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x6263A90", Offset = "0x6262890", VA = "0x186263A90", Slot = "12")]
	protected override DirectoryInfo DLDBCFFAHPN(JHEKNEICBIJ ANAIDGIIPAF, PEKLNECHEOL OOCICAPBMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal sealed class EFGLFNCNHCF : CDOHKMNKLFB
{
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	private static readonly byte[] GMOPMNAPKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	private readonly byte[] CILLFAFCKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private readonly byte[] NPFMBNHCCNJ;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public override HEMPGMADGFC GGAPLJBHKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x524F170", Offset = "0x524DF70", VA = "0x18524F170", Slot = "8")]
		get
		{
			return default(HEMPGMADGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x625C940", Offset = "0x625B740", VA = "0x18625C940")]
	public EFGLFNCNHCF([Optional] string KJCGFGDJOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x625C5F0", Offset = "0x625B3F0", VA = "0x18625C5F0", Slot = "9")]
	internal override void MGPFBCAOEBG(Stream IGMJMFMMOEA, long ODPLBFKINCE, long PHHJICEDHNG, CEIMFNJANHL AKFMCNAFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x625BB80", Offset = "0x625A980", VA = "0x18625BB80", Slot = "10")]
	internal override bool BOCFAEKCNOE(Stream OMHBJBMBMLB, long ODPLBFKINCE, long PHHJICEDHNG, MKODPGPJAFN BOIPANAIPAH, [Out] CEIMFNJANHL AKFMCNAFBFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x625BAC0", Offset = "0x625A8C0", VA = "0x18625BAC0")]
	private void AHLCEOJBBMH(byte[] LKHDKNBOMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x625C4C0", Offset = "0x625B2C0", VA = "0x18625C4C0", Slot = "11")]
	protected override FileInfo FECDOAIOFOI(long ODPLBFKINCE, long PHHJICEDHNG, JHEKNEICBIJ ANAIDGIIPAF, PEKLNECHEOL OOCICAPBMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x625C3B0", Offset = "0x625B1B0", VA = "0x18625C3B0", Slot = "12")]
	protected override DirectoryInfo DLDBCFFAHPN(JHEKNEICBIJ ANAIDGIIPAF, PEKLNECHEOL OOCICAPBMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
public enum HEMPGMADGFC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006BC")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006BD")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal class OAECEICMOJG : ELCDNIGPPNM
{
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private sealed class KFOIJNBKKJF : IEnumerable<KOAFPCAGHPM>, IEnumerable, IEnumerator<KOAFPCAGHPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private KOAFPCAGHPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public OAECEICMOJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private JHEKNEICBIJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public JHEKNEICBIJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private HEMPGMADGFC[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		private IEnumerator<KOAFPCAGHPM> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		private KOAFPCAGHPM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x86F050", Offset = "0x86DE50", VA = "0x18086F050")]
		[DebuggerHidden]
		public KFOIJNBKKJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x62649C0", Offset = "0x62637C0", VA = "0x1862649C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x62645E0", Offset = "0x62633E0", VA = "0x1862645E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x6264590", Offset = "0x6263390", VA = "0x186264590")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x6264970", Offset = "0x6263770", VA = "0x186264970", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x62648C0", Offset = "0x62636C0", VA = "0x1862648C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KOAFPCAGHPM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x62648C0", Offset = "0x62636C0", VA = "0x1862648C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	private readonly HEMPGMADGFC[] FAJPNPECFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	private readonly Dictionary<HEMPGMADGFC, ELCDNIGPPNM> JALKAEILOFC;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public HEMPGMADGFC GGAPLJBHKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x6267570", Offset = "0x6266370", VA = "0x186267570", Slot = "4")]
		get
		{
			return default(HEMPGMADGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x6267A80", Offset = "0x6266880", VA = "0x186267A80")]
	[UnityEngine.Scripting.Preserve]
	public OAECEICMOJG(params ELCDNIGPPNM[] DDDKMJBIHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x6267680", Offset = "0x6266480", VA = "0x186267680", Slot = "5")]
	public bool HJCBNFBPOKE(long ODPLBFKINCE, long PHHJICEDHNG, JHEKNEICBIJ ANAIDGIIPAF, [Out] KOAFPCAGHPM GHLCENPLAFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x62677D0", Offset = "0x62665D0", VA = "0x1862677D0")]
	private void IKKCFHEHKMN(int OHKLNNHLJCB, long ODPLBFKINCE, long PHHJICEDHNG, JHEKNEICBIJ ANAIDGIIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x62679F0", Offset = "0x62667F0", VA = "0x1862679F0", Slot = "6")]
	[IteratorStateMachine(typeof(KFOIJNBKKJF))]
	public IEnumerable<KOAFPCAGHPM> JIMKOFHLBJK(JHEKNEICBIJ ANAIDGIIPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x62675A0", Offset = "0x62663A0", VA = "0x1862675A0", Slot = "7")]
	public KOAFPCAGHPM EDCMEMIGLNK(long ODPLBFKINCE, long PHHJICEDHNG, CEIMFNJANHL AKFMCNAFBFA, JHEKNEICBIJ ANAIDGIIPAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal static class GMJFLCCFFJE
{
	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x625EB30", Offset = "0x625D930", VA = "0x18625EB30")]
	internal static byte[] FJHGJBEHMEJ(byte[] LKHDKNBOMJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x625EAB0", Offset = "0x625D8B0", VA = "0x18625EAB0")]
	public static void DOJOILMDHEH(Stream PLOOMBBCGBH, byte[] NFKCFDBCECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x625EBF0", Offset = "0x625D9F0", VA = "0x18625EBF0")]
	public static bool NIDDMIIECGM(Stream PLOOMBBCGBH, long IJCMEHJKOJF, MKODPGPJAFN MLFFCIJGKCL, [Out] byte[] KOLNJFCMBNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal sealed class JMDEMMKMADI : KOAFPCAGHPM, IEquatable<KOAFPCAGHPM>, IEquatable<JMDEMMKMADI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private readonly CDOHKMNKLFB PFMPLPDLMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	public readonly FileInfo KGJEOBLALAC;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public HEMPGMADGFC GGAPLJBHKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x6262CC0", Offset = "0x6261AC0", VA = "0x186262CC0", Slot = "9")]
		get
		{
			return default(HEMPGMADGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public DateTime JLOLHPGIGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x6263040", Offset = "0x6261E40", VA = "0x186263040", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x6263210", Offset = "0x6262010", VA = "0x186263210")]
	public JMDEMMKMADI(CDOHKMNKLFB NEFIIFDPDMF, FileInfo FOKLHPFKEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x6263160", Offset = "0x6261F60", VA = "0x186263160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x6262F80", Offset = "0x6261D80", VA = "0x186262F80", Slot = "5")]
	public void GDEFDFILPKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x6262C80", Offset = "0x6261A80", VA = "0x186262C80", Slot = "6")]
	public bool AKKDKHIICHJ(long ODPLBFKINCE, long PHHJICEDHNG, [Out] CEIMFNJANHL AKFMCNAFBFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x6262EA0", Offset = "0x6261CA0", VA = "0x186262EA0", Slot = "7")]
	public bool Equals(KOAFPCAGHPM LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x6262DE0", Offset = "0x6261BE0", VA = "0x186262DE0", Slot = "8")]
	public bool Equals(JMDEMMKMADI LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x6262CF0", Offset = "0x6261AF0", VA = "0x186262CF0", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x62630D0", Offset = "0x6261ED0", VA = "0x1862630D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public delegate void MKODPGPJAFN(GHCEJBEMPJI.KJMMBKPIAGJ OFEKNFDBFOF, string BLAOEBOMGGP);
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal interface ELCDNIGPPNM
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	HEMPGMADGFC GGAPLJBHKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HJCBNFBPOKE(long ODPLBFKINCE, long PHHJICEDHNG, JHEKNEICBIJ ANAIDGIIPAF, [Out] KOAFPCAGHPM GHLCENPLAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<KOAFPCAGHPM> JIMKOFHLBJK(JHEKNEICBIJ ANAIDGIIPAF);

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KOAFPCAGHPM EDCMEMIGLNK(long ODPLBFKINCE, long PHHJICEDHNG, CEIMFNJANHL AKFMCNAFBFA, JHEKNEICBIJ ANAIDGIIPAF);
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
