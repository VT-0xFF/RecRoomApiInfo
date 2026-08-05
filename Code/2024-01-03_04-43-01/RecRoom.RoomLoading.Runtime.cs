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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x63F0310", Offset = "0x63EEF10", VA = "0x1863F0310")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79BDE0", Offset = "0x79A9E0", VA = "0x18079BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79BE20", Offset = "0x79AA20", VA = "0x18079BE20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MICKFPGDNFF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63ED3D0", Offset = "0x63EBFD0", VA = "0x1863ED3D0")]
	public MICKFPGDNFF(string EOOPGFAEMIH, Exception CAHHDBANDCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class LEHDCGPJKLK : KDKACIMIMJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BMCLJGCHOGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<AMHKJPMBBKF>> <>t__builder;

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
		private TaskAwaiter<CNJLPOMCIMD<AMHKJPMBBKF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x63D5ED0", Offset = "0x63D4AD0", VA = "0x1863D5ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x63D6110", Offset = "0x63D4D10", VA = "0x1863D6110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct LKGBJPMHFEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<JGGEMANKNCF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<JGGEMANKNCF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x63EBA00", Offset = "0x63EA600", VA = "0x1863EBA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x63EBC10", Offset = "0x63EA810", VA = "0x1863EBC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	[UnityEngine.Scripting.Preserve]
	public LEHDCGPJKLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x63EAE30", Offset = "0x63E9A30", VA = "0x1863EAE30", Slot = "4")]
	[AsyncStateMachine(typeof(BMCLJGCHOGK))]
	public Task<IReadOnlyList<AMHKJPMBBKF>> KIMCIENKCEB(long BPJLDBDKBIJ, long LPIJNBPBLPM, [Optional] CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x63EAF50", Offset = "0x63E9B50", VA = "0x1863EAF50", Slot = "5")]
	[AsyncStateMachine(typeof(LKGBJPMHFEN))]
	public Task<IReadOnlyList<JGGEMANKNCF>> OKEGHMJDGIH(IReadOnlyList<int> MEGDMELOPMB, [Optional] CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KCNIKONEELM : IEquatable<KCNIKONEELM>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int DDFDMNJFHDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	JGGEMANKNCF GFCGPCDPAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime FDOEHODNINP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	CEPHHCKLANJ? LJFAMLCAAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	FEHMPPFMPDC? IOHOPFBCKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	DBMIGDADPOC JBHGKMGCEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CFDJENKBLOB> EIDGGNLEBHD();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DBMIGDADPOC
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KDKACIMIMJM
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<AMHKJPMBBKF>> KIMCIENKCEB(long BPJLDBDKBIJ, long LPIJNBPBLPM, [Optional] CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<JGGEMANKNCF>> OKEGHMJDGIH(IReadOnlyList<int> MEGDMELOPMB, [Optional] CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DFJHJJJAAII
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class EJGBHDAAFGI : KCNIKONEELM, IEquatable<KCNIKONEELM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct EIIJMMMNKBD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<CFDJENKBLOB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public EJGBHDAAFGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private LHJEDOAOEFL <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<AADJFGNPPBI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<CFDJENKBLOB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63DEAB0", Offset = "0x63DD6B0", VA = "0x1863DEAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x63DEF50", Offset = "0x63DDB50", VA = "0x1863DEF50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly AMHKJPMBBKF BCDJBGFHFIH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int DDFDMNJFHDC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7786A0", Offset = "0x7772A0", VA = "0x1807786A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public JGGEMANKNCF GFCGPCDPAEH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime JEBHENDBEGB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9806B0", Offset = "0x97F2B0", VA = "0x1809806B0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CEPHHCKLANJ? LJFAMLCAAAP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1888570", Offset = "0x1887170", VA = "0x181888570", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FEHMPPFMPDC? IOHOPFBCKMK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1E06670", Offset = "0x1E05270", VA = "0x181E06670", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public DBMIGDADPOC JBHGKMGCEPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x866C40", Offset = "0x865840", VA = "0x180866C40", Slot = "10")]
			get
			{
				return default(DBMIGDADPOC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x63DEFC0", Offset = "0x63DDBC0", VA = "0x1863DEFC0", Slot = "9")]
		[AsyncStateMachine(typeof(EIIJMMMNKBD))]
		public Task<CFDJENKBLOB> EIDGGNLEBHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63DF2B0", Offset = "0x63DDEB0", VA = "0x1863DF2B0")]
		public EJGBHDAAFGI(int IIMPAOFLBID, JGGEMANKNCF OHPOGFJHJGN, AMHKJPMBBKF BCDJBGFHFIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x63DF0C0", Offset = "0x63DDCC0", VA = "0x1863DF0C0", Slot = "11")]
		public bool Equals(KCNIKONEELM LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x63DF150", Offset = "0x63DDD50", VA = "0x1863DF150", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x63DF270", Offset = "0x63DDE70", VA = "0x1863DF270")]
		private bool MIGOAFPKHIL(EJGBHDAAFGI LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63DF1F0", Offset = "0x63DDDF0", VA = "0x1863DF1F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class AOAKLGGMKBF : KCNIKONEELM, IEquatable<KCNIKONEELM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct ANAIAAGOIED : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<CFDJENKBLOB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public AOAKLGGMKBF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<CFDJENKBLOB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x63D5750", Offset = "0x63D4350", VA = "0x1863D5750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x63D5980", Offset = "0x63D4580", VA = "0x1863D5980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly IBADDLHMPKI AGKKGFAMLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly CEPHHCKLANJ IHBAHIBKHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly FEHMPPFMPDC ILFBCHBHNPN;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int DDFDMNJFHDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x63D5C80", Offset = "0x63D4880", VA = "0x1863D5C80", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public JGGEMANKNCF GFCGPCDPAEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x63D5E40", Offset = "0x63D4A40", VA = "0x1863D5E40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime JEBHENDBEGB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x63D59F0", Offset = "0x63D45F0", VA = "0x1863D59F0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public CEPHHCKLANJ? LJFAMLCAAAP
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x63D5D90", Offset = "0x63D4990", VA = "0x1863D5D90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public FEHMPPFMPDC? IOHOPFBCKMK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63D5D40", Offset = "0x63D4940", VA = "0x1863D5D40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DBMIGDADPOC JBHGKMGCEPP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x854110", Offset = "0x852D10", VA = "0x180854110", Slot = "10")]
			get
			{
				return default(DBMIGDADPOC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xE0AAC0", Offset = "0xE096C0", VA = "0x180E0AAC0")]
		public AOAKLGGMKBF(IBADDLHMPKI LLABLLJHCML, CEPHHCKLANJ FFIIGPCHECH, FEHMPPFMPDC OBLOPDCDEON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x63D5A40", Offset = "0x63D4640", VA = "0x1863D5A40", Slot = "9")]
		[AsyncStateMachine(typeof(ANAIAAGOIED))]
		public Task<CFDJENKBLOB> EIDGGNLEBHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x63D5B30", Offset = "0x63D4730", VA = "0x1863D5B30", Slot = "11")]
		public bool Equals(KCNIKONEELM LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63D5BD0", Offset = "0x63D47D0", VA = "0x1863D5BD0", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63D5DE0", Offset = "0x63D49E0", VA = "0x1863D5DE0")]
		private bool MIGOAFPKHIL(AOAKLGGMKBF LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63D5CC0", Offset = "0x63D48C0", VA = "0x1863D5CC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class EEMJPGBOHKB : KCNIKONEELM, IEquatable<KCNIKONEELM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct PCFNMLDDKGJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<CFDJENKBLOB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<CFDJENKBLOB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x63F2710", Offset = "0x63F1310", VA = "0x1863F2710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x63F2950", Offset = "0x63F1550", VA = "0x1863F2950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly JGGEMANKNCF EFMGONJICGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly CEPHHCKLANJ IHBAHIBKHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly FEHMPPFMPDC ILFBCHBHNPN;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int DDFDMNJFHDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x63DDE60", Offset = "0x63DCA60", VA = "0x1863DDE60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public JGGEMANKNCF GFCGPCDPAEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime JEBHENDBEGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public CEPHHCKLANJ? LJFAMLCAAAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x63DDF60", Offset = "0x63DCB60", VA = "0x1863DDF60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public FEHMPPFMPDC? IOHOPFBCKMK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x63DDF10", Offset = "0x63DCB10", VA = "0x1863DDF10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DBMIGDADPOC JBHGKMGCEPP
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "10")]
			get
			{
				return default(DBMIGDADPOC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xE0AAC0", Offset = "0xE096C0", VA = "0x180E0AAC0")]
		public EEMJPGBOHKB(JGGEMANKNCF OHPOGFJHJGN, CEPHHCKLANJ FFIIGPCHECH, FEHMPPFMPDC OBLOPDCDEON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x63DDB60", Offset = "0x63DC760", VA = "0x1863DDB60", Slot = "9")]
		[AsyncStateMachine(typeof(PCFNMLDDKGJ))]
		public Task<CFDJENKBLOB> EIDGGNLEBHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x63DDC30", Offset = "0x63DC830", VA = "0x1863DDC30", Slot = "11")]
		public bool Equals(KCNIKONEELM LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x63DDD40", Offset = "0x63DC940", VA = "0x1863DDD40", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x63DDE80", Offset = "0x63DCA80", VA = "0x1863DDE80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x63DDFB0", Offset = "0x63DCBB0", VA = "0x1863DDFB0")]
		private bool MIGOAFPKHIL(EEMJPGBOHKB LLMHBOEDHFP)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct GDMMNJHDBIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<KCNIKONEELM>> <>t__builder;

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
		public DFJHJJJAAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<AMHKJPMBBKF> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<AMHKJPMBBKF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, JGGEMANKNCF account, AMHKJPMBBKF roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x63E03B0", Offset = "0x63DEFB0", VA = "0x1863E03B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x63E1190", Offset = "0x63DFD90", VA = "0x1863E1190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct BNPLNMBGKFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, JGGEMANKNCF account, AMHKJPMBBKF roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<AMHKJPMBBKF> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DFJHJJJAAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<JGGEMANKNCF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x63D6180", Offset = "0x63D4D80", VA = "0x1863D6180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x63D6B70", Offset = "0x63D5770", VA = "0x1863D6B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MBKICKKDMGI EJGHELOMHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KDKACIMIMJM JIEOJNNNEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BCIGAFKDHED FJFHDHGMDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly LOAKNLLGOMD<(long, long), IReadOnlyList<AMHKJPMBBKF>> ANABALJLICA;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63D8470", Offset = "0x63D7070", VA = "0x1863D8470")]
	[UnityEngine.Scripting.Preserve]
	public DFJHJJJAAII([DLBAGNNJKKK(null)] KDKACIMIMJM EEAHFLBHDGK, [DLBAGNNJKKK(null)] BCIGAFKDHED CLDFLMIMOPC, [DLBAGNNJKKK(null)] MBKICKKDMGI JBPBBDJBGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x63D8320", Offset = "0x63D6F20", VA = "0x1863D8320")]
	[AsyncStateMachine(typeof(GDMMNJHDBIJ))]
	public Task<IList<KCNIKONEELM>> NGFLIMHOHCI(long BPJLDBDKBIJ, long KKFDHGLGLHO, bool CFBIFFBBCOC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63D8180", Offset = "0x63D6D80", VA = "0x1863D8180")]
	private bool IEDFIOJAPEB(DateTime? NHKNMEBBBBD, long BPJLDBDKBIJ, long KKFDHGLGLHO, [Out] IBADDLHMPKI EBGOHPNLCGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63D8070", Offset = "0x63D6C70", VA = "0x1863D8070")]
	[AsyncStateMachine(typeof(BNPLNMBGKFB))]
	private Task<IReadOnlyList<(int, JGGEMANKNCF, AMHKJPMBBKF)>> CHEPENEBMEH(IReadOnlyList<AMHKJPMBBKF> NCCFIHHOKHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BCIGAFKDHED
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<IBADDLHMPKI> CDFNIJNNAEG;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LEMBJAEMJED(long BPJLDBDKBIJ, long KKFDHGLGLHO, CIACFOCFAGD GFCMBFDFODN, EMCJOAAJBFJ NPEKECDFDBG);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JHFDAFLPJJM(long BPJLDBDKBIJ, long KKFDHGLGLHO, [Out] IBADDLHMPKI EBGOHPNLCGI);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DNLMFMPBDDE(long BPJLDBDKBIJ, long KKFDHGLGLHO, EMCJOAAJBFJ NPEKECDFDBG, [Out] IBADDLHMPKI EBGOHPNLCGI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPMNCEBNDOH(long BPJLDBDKBIJ, long KKFDHGLGLHO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface EAKEBPLDJAI : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IEBINNHFDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task GIBACFLBCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JDCLJDFIFJK(Task IMKPJBJJCAM, string GMJNMILHDJA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface GBDJOOFGMBJ : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CFDJENKBLOB> OCFBLOMAEPF(IBADDLHMPKI EBGOHPNLCGI);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PGKOCODGGDN(CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface LAANEOACBLL : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	NKGBBEDNKNJ CBIDBFJKGEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMFODDHGNBM();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CANNFCGDEOL();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface NEEJBNNMHIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface NHHPOOJPBND
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan DFFLLDHEIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan JCIAGMLNPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan NELLHMPAINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan HKHLMDJKLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool PIOJKEPLDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool AHEOGIHMFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DCEOHLGIJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int KJEACIFNLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool AGPAIFLMJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool KGFBJOMBOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum JFKJPKDLCOE
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum JNNLMBKMLLG
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
public struct NIIHDDCOAKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long NFHKGNJKDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long LPIJNBPBLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly JFKJPKDLCOE OMKEAAPIABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception OFHMCFLLHDB;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x63EF610", Offset = "0x63EE210", VA = "0x1863EF610")]
	public NIIHDDCOAKK(long NFHKGNJKDNH, long LPIJNBPBLPM, JFKJPKDLCOE OMKEAAPIABA, [CanBeNull] Exception OFHMCFLLHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x63EF5C0", Offset = "0x63EE1C0", VA = "0x1863EF5C0")]
	public static NIIHDDCOAKK EPKMFHMDBBK(AKINJJFCBCP NNKMNCKBBAJ, JFKJPKDLCOE OMKEAAPIABA, [Optional] Exception OFHMCFLLHDB)
	{
		return default(NIIHDDCOAKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void KJDOIPDNFFK(NIIHDDCOAKK KIALKADCNKJ);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface CFINJANHKIF : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action CIIFJNAILEM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KJDOIPDNFFK IGDIKNKPIBA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KJDOIPDNFFK DJGEHFBGMEA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KJDOIPDNFFK CNNPGFEFJCM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<JNNLMBKMLLG, bool> LCEHJICJPML;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NJICJOLLMDF();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AOEBOFGJBND(NIIHDDCOAKK KIALKADCNKJ);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OKDPDIHKFDE(NIIHDDCOAKK KIALKADCNKJ);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PJAHFKHJHPJ(NIIHDDCOAKK KIALKADCNKJ);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BEKBDJHDDDC(JNNLMBKMLLG NGJFKCMINGB, bool FHBGMNIFOGH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface PNCHHNGDOHF : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NDIJGJGNIPN();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALCMKBHHEKP();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface INBIBLHOABC : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus CPFCJDIOHDK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HKFHMDANMAJ(AKINJJFCBCP FDLFBJDCFCP, AKEENPEHJFJ OJAOCHHHNGN, CancellationToken BINKOPDIFFD);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal static class DBIPPFDOFMH
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x63D7290", Offset = "0x63D5E90", VA = "0x1863D7290")]
	public static bool KGJHJMPLJNC(this INBIBLHOABC CPEPBKLPAGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public delegate Task LJKFLDDNNAK(HNHIPMBANEH EMCADPHEHCL, CancellationToken KJCAGLABEME);
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface COHMJPPIAJC : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FOENNCADIJB(LJKFLDDNNAK JDHCALPMBNH);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface AEIFCCFGGHA : LHJEDOAOEFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken MBHGNCMFHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	OKOCNPPIKGG PKDGHBNAHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	PHGHPEAICAJ ALFMNPGBKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CLBIGKMAMFC NOKDIIIGJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NCAMOCAOBKA MOFFCFCLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	DCMEMGFPPFF OPHKOGKKGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	PMMKMMJFNCL HBOCDKBOBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	PDEGCLAEOLH IDAKEIJPAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	KPDIBHHHMEH NFNFAHIDKLK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	EAKEBPLDJAI KOLLBEIBFEI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	GBDJOOFGMBJ ANGKDDCNPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	CFINJANHKIF KFHPIJJOBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	PNCHHNGDOHF HPFMHPDOAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	INBIBLHOABC CAEPMHEHFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	COHMJPPIAJC HGIOEIEBBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	MILBDNCHNLF MLHKAEJCPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	MNNBOBMCFJA FKIHJMJAFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JMALBMIKMLO FHJOFJBFIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	EHOGOHMPOBG IKMIOEEJMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LGKDKKBBDIJ BFALNJBFEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	AFNJBPGEAGO AJNFGJFDAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	AKLCAPLPHFH CGLBPEOMMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	KADFEKOBGOD FDBJNHKLKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NBEKNIPBGGH OFEAJLOLJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	EDOHAPHCDLD IOGDFIAGMOP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	LAANEOACBLL FOEDEHOEEFD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	NHHPOOJPBND CHDBDIMHOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	AFLIPJHMMIF PHHLJHNNKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	BCIGAFKDHED CEJGCFBGMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	FPLDLFKOINE BOHNJFJDNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	MOJLHPBCMAL POLFKHIHEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void BKBKKBBPGKK(AKEENPEHJFJ HJBMHJDHCFI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface MILBDNCHNLF : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DKIEJLJPLED HFMDKEOMMOI(Guid BJCCLJBIHHN);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IFJPOCDCFNK(Guid BJCCLJBIHHN);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BKEBJJJDHAG(Guid BJCCLJBIHHN, Task LMAOILMBKJD);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IPHKLPEHLHF(Guid BJCCLJBIHHN, CFDJENKBLOB IGOJEKGMKKK);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(CFDJENKBLOB, Task)> BNCGNFKPIBD(Guid BJCCLJBIHHN);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface DKAHGMFIENM : NEEJBNNMHIH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface MNNBOBMCFJA : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAFJDDGHOLF(CMAIBKDPDAF EOOPGFAEMIH);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCCMNKFCGFL(CMAIBKDPDAF EOOPGFAEMIH);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<HBBGLBIKIJH> PPFHBMMLGLE(CancellationToken KONCBKHBBLE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface JMALBMIKMLO : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DKIEJLJPLED HGPOMOOHKFN(CMAIBKDPDAF KLMPGFHBPKG);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJJILDIJEED(Guid BJCCLJBIHHN, Task LMAOILMBKJD);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface EHOGOHMPOBG : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CFDJENKBLOB> IKMIOEEJMLA(CMAIBKDPDAF PKJLAPJGLHJ);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface LGKDKKBBDIJ : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GLELENLDELG> LLCDCCIHHOP(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, AKINJJFCBCP FDLFBJDCFCP, CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface AKLCAPLPHFH : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CFDJENKBLOB FMBEJDIANFC(ILLMBLKEFFI KGOGDJKOABA);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EHBKFKKKJOD(string ELOBOAALAAG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface AFNJBPGEAGO : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CMAIBKDPDAF> DJPEILHACDF(CMAIBKDPDAF NFAAJOAMBMN, BGAFJPNGEOB GFACAJKPEOL, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CMAIBKDPDAF> IIGPOOIIFNE(CancellationToken BJFJMBIBKLL, BGAFJPNGEOB GFACAJKPEOL);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LNOKCMEODGP IPHPAECECNI(OAMCKBCGEGJ EHOADMBDJGP, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LNOKCMEODGP OMHPMHFEFBO(OAMCKBCGEGJ EHOADMBDJGP, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface KADFEKOBGOD : NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CFDJENKBLOB AGCKAGFOFLC(ILLMBLKEFFI KGOGDJKOABA, HBBGLBIKIJH FHHBHJGIJKG);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CFDJENKBLOB IBGNIMJPHHG(ILLMBLKEFFI KCGDCNCMLEP);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface NBEKNIPBGGH
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNEFIGIGLBB(GHEDMAGOABF PGFCMDBNHLE);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LNGAPGLJCEA(GHEDMAGOABF PGFCMDBNHLE);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNGADBGFCPA(GHEDMAGOABF PGFCMDBNHLE);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBJGCACDHHM(GHEDMAGOABF PGFCMDBNHLE);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class GHEDMAGOABF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly AKINJJFCBCP OJCAKGMHJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> GHALMGIJKMG;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public FIKFBEICCGA<string> IEACMIBIOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x773620", Offset = "0x772220", VA = "0x180773620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	public GHEDMAGOABF(AKINJJFCBCP MPHHOJINAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x63E1270", Offset = "0x63DFE70", VA = "0x1863E1270")]
	public GHEDMAGOABF FABECKNKLCM(string PPNDANAOAMK, string GCPEEAODAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x63E1340", Offset = "0x63DFF40", VA = "0x1863E1340")]
	public bool IHGIBNFFIHK([Out] IEnumerable<KeyValuePair<string, string>> NJJBNIJPEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x57CE7C0", Offset = "0x57CD3C0", VA = "0x1857CE7C0")]
	public GHEDMAGOABF CLKPEAFOFPI(FIKFBEICCGA<string> AEIJEHEMJFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface AFLIPJHMMIF
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool FDMBGPFOLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string DNDIIDAIPKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLNLDEBICLF();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EEBPKOGBIBJ LIHHPOCKNKO(long IMBBOEGNAEL);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GCKAFHKMFOP<JAJPEOHOEFN, MFFBIFNFJON> HDGHOEALJKF(long IMBBOEGNAEL);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GCKAFHKMFOP<JAJPEOHOEFN, PGCGNLKABHG> JOLFPAGKFNK(long IMBBOEGNAEL);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GCKAFHKMFOP<long, OAHDIBPCFJK> ILMGFMHGKEH();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DMOFCAIIHEB(long IMBBOEGNAEL, [Out] bool HHMCDALOCEI);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<bool> MDJPCEHEKLF(byte[] DGLECCENBLP, byte[] ONIPDGEKDLM, CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface LHJEDOAOEFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool KGJHJMPLJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool JEPLAJNFLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	AKEENPEHJFJ IKNLBEJALKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action CIIFJNAILEM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KJDOIPDNFFK IGDIKNKPIBA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KJDOIPDNFFK DJGEHFBGMEA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KJDOIPDNFFK CNNPGFEFJCM;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<JNNLMBKMLLG, bool> LCEHJICJPML;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ALCMKBHHEKP();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AMOLFKBKLEG MCLBPAFHOPM();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NLPADNPAJCB FCPMOMOPJAC();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<CFDJENKBLOB> OCFBLOMAEPF(IBADDLHMPKI LLABLLJHCML);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task PGKOCODGGDN(CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface DCMEMGFPPFF
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool AHAPKDMDJLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string IFMKJNIKMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGHPALCFNAO(Scene HGKKKDMKOBG);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KMNHINFGKNK(DBEGLHOLLEJ NJJOFMDKFFC, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task GJLAFBADBEO();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface NCAMOCAOBKA
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	KABLCFJOKIG HPNOJDJMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool IEIFLNCKIME
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool NFHJNJMECEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool BNOCJCFFHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool NNJALHFNEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool IIOGJBHDELP
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool MBOHIEGHNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool HLPBCPPLNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float OBINLFMIGED
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> CAEGIDGMGKH;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OKOCNPPIKGG FDAJHFPGNNG(OKOCNPPIKGG LCEIFJPLPAL);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIKNIGPMMMB(OKOCNPPIKGG PCOJMOHPOND);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IMAHGEBCJFK();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task LIEKBIMPAHL(FIKFBEICCGA<string>.DJKJOCCHFDH DLCKNGFNLOC, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JKDFFAJOBEP(float MLKKAHKGKMH);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OHMNIDDMGBB(string BBODCMJFAEN);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<BIOAHKOLPIF> ANHNOBFCLIH();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable IBGJLEOEDHM(object BFDLBONPDOA, BIOAHKOLPIF JANCKFLIDOC);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MFFBIFNFJON BMDJMHBOAOK(IEnumerable<CACNBOICLKE> ELKLMBFJHGK);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IEJEJMGIFOP(int KCDGADOLLBP);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task ANFCPMOFOKL();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NANADPPLPIM();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool PBMFDNCAIDI();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task HABILGJJCDP(CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task GMIJECCHIEN(CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<BABHIIDIIIL> PGNNNPCGIJA(DateTime AKDIFCKOCFO, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> LBIOJCEJDIC(CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HBCPEBJHKGF(string PCHECKOCDME = "", float EJGELOGDBKE = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	ELAHHMDKCOB LCFPOGGBFNH(CIFIOAAAKKI CEACPMCGCJH, EHBKALCAMLM LHLCPOBOHJD, PGCGNLKABHG EHLHHAHBJDC, IEnumerable<PersistenceView> ADMLFHLGFPK, BIAPNJNNBGK PBGAIDNFGPA);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IDBNOHGCLMH(PGCGNLKABHG EHLHHAHBJDC);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void BLKNABNBAOE(CACNBOICLKE PGJNPMOPLKE, [In] ELAHHMDKCOB AAJKFENLHDH);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task DGKBGDPMKJI(PGCGNLKABHG FBCLOCGHONM, bool KCKEOBHPMMO, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task HKDFADLPEBG(CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LBMAMOEIJAB(long BPJLDBDKBIJ, long LPIJNBPBLPM, AADJFGNPPBI NBCLOMODJEL, AMHKJPMBBKF FHDFEFGJJOC, CIACFOCFAGD GFCMBFDFODN, CKDIJOECEAM? OAGFCMKCBHI, KECIELDKHLL? MAHLHPBPFOL);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FLBCINILKGC(long BPJLDBDKBIJ, long LPIJNBPBLPM, KECIELDKHLL? MAHLHPBPFOL);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void JOACKAOFBCM(PersistenceView AKIAGPMHJCI);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool OLINMJHKGII(PersistenceView NFGKMLPPOFG);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool GAMJKLBLKLP(CACNBOICLKE PGJNPMOPLKE, FACDBLKJAKK GEKIEOOPJHO, [Out] IHHPNNIIIED HFLPHOOIIMO);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task JKMBPBBENAO(CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void PNELJNEMCCA();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable ECIEOBFDGLD();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FIGKGDOHPBD(PGCGNLKABHG FBCLOCGHONM, FACDBLKJAKK GEKIEOOPJHO);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> LHPNGJCGLFA(PHGHPEAICAJ ODJIBPMJHOC, CancellationToken BJFJMBIBKLL, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void ALDMCBBLDLF(CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<NAKMOBJIHCO> LLNDKCNOLBJ(JBOIEHOAECJ NFAAJOAMBMN);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<AADJFGNPPBI> EGAHILBNLOD(long BPJLDBDKBIJ, bool EDKJEIIFFNL, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<AMHKJPMBBKF> FMCBLLFOGCC(long BPJLDBDKBIJ, long LPIJNBPBLPM, long KAJFLINCAKN, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<OHHDEGANHGD> JJNFJAGJINE(string DDGMFBNKOHE, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<OHHDEGANHGD> CLINEPNOBPC(string DDGMFBNKOHE, long BPJLDBDKBIJ, long LPIJNBPBLPM, string BCGCEEINNOE, NGDDDNMKBDM.ICABENAOONI EMCADPHEHCL, NGDDDNMKBDM.ICABENAOONI ONIPDGEKDLM, int MLGGMOPFMNJ);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool IIPPAKEHDDO();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool HEEGJLMMNCL();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool DKINGDFFFJP(IEnumerable<IHHPNNIIIED> DIMJHEBMHAM);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void JPDGJGJKDGM(List<GameObject> PCIHBNIDAIA);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float HDCCMPKLJAG();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> BDAHJPDIAJF(string AEGJFANOGND, LoadSceneMode BJGHNIBPFFO, bool HJGBGLLLDNP, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void BFLLOFMFLJE();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void BNAEGCJCPCG(bool CDMIKOHKIDI);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void CABEKKAGOLL(AKINJJFCBCP NFAHLMINKMM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task COCOPJHAOFG(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task AEIKMNBBDMO(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task CMNEBJHDIFB(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "62")]
	IDisposable CPAMGFNEIPM();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "63")]
	JNMAMHLJMAI NADKEAAKANJ();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task HEPMNKHMOIO(CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface JNMAMHLJMAI
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BCABLMKLEBN(CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KNCOEKIMCOF(CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct ELAHHMDKCOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> NLOOLOHNOOP;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum BABHIIDIIIL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct CIFIOAAAKKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string BPJAPFMDHBI;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KABLCFJOKIG
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	AKINJJFCBCP EKJCEABIDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	AADJFGNPPBI LHLEOHECMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	KEFAEPIPHKI FINNBOKMKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool HNECLJMHODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool OFHDKPPDJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int ADAHHGLMIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action PIJILMMBHMJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> CPNNGMNPCIE;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MJPCNBDGJBB();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.PJLFHHCDDMD> DFBPGIMKEFB(long IMBBOEGNAEL, [Optional] CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<HJPKNDBBNKL> KOMAJDDKNAD();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task MCOMCJIBMDL();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(AKINJJFCBCP, AKEENPEHJFJ) IGACDBPKMJE();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CHKCKFECDIL OHBJDHLCHAH();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GCCMHMLAOJJ(long IMBBOEGNAEL);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface EDOHAPHCDLD
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOAEEJDLFNK([Out] IEnumerable<int> GBHOELLEFOH);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKHLNFEJFEA(KOHNFGELOEJ KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OFNMJOLNADE(KOHNFGELOEJ KJCAGLABEME);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface KFJOHBAEABD
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FKNMIEBNAFI(CFDJENKBLOB EKDKEAOJBNG);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IKNDLDFIGAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COOIFDLOKAB(JBLIJLIIIAL.IKPDJGFJNJM JHCDDLIKOGI);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDPOAOODFJB(JBLIJLIIIAL.IKPDJGFJNJM JHCDDLIKOGI);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface PMMKMMJFNCL : IKNDLDFIGAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CFDJENKBLOB KKBLNHFHGIF(ILLMBLKEFFI KCGDCNCMLEP);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PDEGCLAEOLH : IKNDLDFIGAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CFDJENKBLOB FMBEJDIANFC(ILLMBLKEFFI NBMIOHDEJJG);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface EEBPKOGBIBJ
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MEPDFJNPAPE<DBEGLHOLLEJ, LGEMOLNFJEJ>> IMIJCHKDLMI(string BCGCEEINNOE, long IMBBOEGNAEL, NMGFAGNOENB.NBBBJKGOGEB OELEGAFHFII, CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GCKAFHKMFOP<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MEPDFJNPAPE<byte[], LGEMOLNFJEJ>> JBMILHLDGIC(TGetDataArg NGMDGDAKJOP, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MEPDFJNPAPE<IICMDAPPGCC<TData>, LGEMOLNFJEJ> EKFKAPBNAID(byte[] IGJLGPELHOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class NIDODLHPBHC : AEIFCCFGGHA, LHJEDOAOEFL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct MJJPJFKJPEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<CFDJENKBLOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public NIDODLHPBHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public IBADDLHMPKI autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<CFDJENKBLOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x63ED5B0", Offset = "0x63EC1B0", VA = "0x1863ED5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x63ED830", Offset = "0x63EC430", VA = "0x1863ED830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct LLIBEFNEGFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public NIDODLHPBHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x63EBC80", Offset = "0x63EA880", VA = "0x1863EBC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x63EBEB0", Offset = "0x63EAAB0", VA = "0x1863EBEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class HKEDJNPFFDC : IEnumerable<NEEJBNNMHIH>, IEnumerable, IEnumerator<NEEJBNNMHIH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private NEEJBNNMHIH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NIDODLHPBHC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private NEEJBNNMHIH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8ECE30", Offset = "0x8EBA30", VA = "0x1808ECE30")]
		[DebuggerHidden]
		public HKEDJNPFFDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x63E2FB0", Offset = "0x63E1BB0", VA = "0x1863E2FB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x63E3410", Offset = "0x63E2010", VA = "0x1863E3410", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x63E3360", Offset = "0x63E1F60", VA = "0x1863E3360", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NEEJBNNMHIH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x63E3360", Offset = "0x63E1F60", VA = "0x1863E3360", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource KFEHJMAAKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly OKOCNPPIKGG PCOJMOHPOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool MFJFBBMDDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private IJGOJOIMPMC EFOGKOKICGP;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public PHGHPEAICAJ ALFMNPGBKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x776710", Offset = "0x775310", VA = "0x180776710", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x776640", Offset = "0x775240", VA = "0x180776640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public CLBIGKMAMFC NOKDIIIGJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7766F0", Offset = "0x7752F0", VA = "0x1807766F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x776620", Offset = "0x775220", VA = "0x180776620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public NCAMOCAOBKA MOFFCFCLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7766E0", Offset = "0x7752E0", VA = "0x1807766E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7766B0", Offset = "0x7752B0", VA = "0x1807766B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public DCMEMGFPPFF OPHKOGKKGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x779BC0", Offset = "0x7787C0", VA = "0x180779BC0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x779BB0", Offset = "0x7787B0", VA = "0x180779BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public PMMKMMJFNCL HBOCDKBOBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x776540", Offset = "0x775140", VA = "0x180776540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x776550", Offset = "0x775150", VA = "0x180776550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public PDEGCLAEOLH IDAKEIJPAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x776650", Offset = "0x775250", VA = "0x180776650", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x776730", Offset = "0x775330", VA = "0x180776730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public KPDIBHHHMEH NFNFAHIDKLK
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x778760", Offset = "0x777360", VA = "0x180778760", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7787D0", Offset = "0x7773D0", VA = "0x1807787D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public EAKEBPLDJAI KOLLBEIBFEI
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x778710", Offset = "0x777310", VA = "0x180778710", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x778820", Offset = "0x777420", VA = "0x180778820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public GBDJOOFGMBJ ANGKDDCNPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x778780", Offset = "0x777380", VA = "0x180778780", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x778840", Offset = "0x777440", VA = "0x180778840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public CFINJANHKIF KFHPIJJOBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8AE890", Offset = "0x8AD490", VA = "0x1808AE890", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8AE970", Offset = "0x8AD570", VA = "0x1808AE970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public PNCHHNGDOHF HPFMHPDOAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x778690", Offset = "0x777290", VA = "0x180778690", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7786D0", Offset = "0x7772D0", VA = "0x1807786D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public INBIBLHOABC CAEPMHEHFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x837820", Offset = "0x836420", VA = "0x180837820", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x837230", Offset = "0x835E30", VA = "0x180837230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public COHMJPPIAJC HGIOEIEBBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x775B00", Offset = "0x774700", VA = "0x180775B00", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x775BA0", Offset = "0x7747A0", VA = "0x180775BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public MILBDNCHNLF MLHKAEJCPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x964470", Offset = "0x963070", VA = "0x180964470", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9645E0", Offset = "0x9631E0", VA = "0x1809645E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public DKAHGMFIENM EFBNLOBPCNC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8C3150", Offset = "0x8C1D50", VA = "0x1808C3150", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9645C0", Offset = "0x9631C0", VA = "0x1809645C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public MNNBOBMCFJA FKIHJMJAFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x964480", Offset = "0x963080", VA = "0x180964480", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x964600", Offset = "0x963200", VA = "0x180964600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public JMALBMIKMLO FHJOFJBFIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x898DF0", Offset = "0x8979F0", VA = "0x180898DF0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x92C7A0", Offset = "0x92B3A0", VA = "0x18092C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public EHOGOHMPOBG IKMIOEEJMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x92E9D0", Offset = "0x92D5D0", VA = "0x18092E9D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x92DA40", Offset = "0x92C640", VA = "0x18092DA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public LGKDKKBBDIJ BFALNJBFEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x775B10", Offset = "0x774710", VA = "0x180775B10", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x775B40", Offset = "0x774740", VA = "0x180775B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public AFNJBPGEAGO AJNFGJFDAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8639C0", Offset = "0x8625C0", VA = "0x1808639C0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8639D0", Offset = "0x8625D0", VA = "0x1808639D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public AKLCAPLPHFH CGLBPEOMMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x82C440", Offset = "0x82B040", VA = "0x18082C440", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x82C8A0", Offset = "0x82B4A0", VA = "0x18082C8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public KADFEKOBGOD FDBJNHKLKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x964460", Offset = "0x963060", VA = "0x180964460", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9645A0", Offset = "0x9631A0", VA = "0x1809645A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public NBEKNIPBGGH OFEAJLOLJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x827CC0", Offset = "0x8268C0", VA = "0x180827CC0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x827DF0", Offset = "0x8269F0", VA = "0x180827DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public EDOHAPHCDLD IOGDFIAGMOP
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x964510", Offset = "0x963110", VA = "0x180964510", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9647E0", Offset = "0x9633E0", VA = "0x1809647E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public LAANEOACBLL FOEDEHOEEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x848D50", Offset = "0x847950", VA = "0x180848D50", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x964720", Offset = "0x963320", VA = "0x180964720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public NHHPOOJPBND CHDBDIMHOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x848D60", Offset = "0x847960", VA = "0x180848D60", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9646C0", Offset = "0x9632C0", VA = "0x1809646C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public AFLIPJHMMIF PHHLJHNNKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x831DB0", Offset = "0x8309B0", VA = "0x180831DB0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x964800", Offset = "0x963400", VA = "0x180964800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public BCIGAFKDHED CEJGCFBGMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x831DA0", Offset = "0x8309A0", VA = "0x180831DA0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public FPLDLFKOINE BOHNJFJDNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x831DC0", Offset = "0x8309C0", VA = "0x180831DC0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public MOJLHPBCMAL POLFKHIHEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x831C20", Offset = "0x830820", VA = "0x180831C20", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public AKEENPEHJFJ IKNLBEJALKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x831C00", Offset = "0x830800", VA = "0x180831C00", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x964640", Offset = "0x963240", VA = "0x180964640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private bool ECEKGLKCLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x63EEAE0", Offset = "0x63ED6E0", VA = "0x1863EEAE0", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private bool ONDBJGADGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x63EEEF0", Offset = "0x63EDAF0", VA = "0x1863EEEF0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private CancellationToken FCINONEIFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x63EE800", Offset = "0x63ED400", VA = "0x1863EE800", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private OKOCNPPIKGG FPJBDDPEOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action JCCHJEACLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x63EF0C0", Offset = "0x63EDCC0", VA = "0x1863EF0C0", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x63EEC50", Offset = "0x63ED850", VA = "0x1863EEC50", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event KJDOIPDNFFK HJKEJGOJFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x63EECB0", Offset = "0x63ED8B0", VA = "0x1863EECB0", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x63EF120", Offset = "0x63EDD20", VA = "0x1863EF120", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event KJDOIPDNFFK DMNHIDJDODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x63EE880", Offset = "0x63ED480", VA = "0x1863EE880", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x63EED10", Offset = "0x63ED910", VA = "0x1863EED10", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event KJDOIPDNFFK BLGBMCJBLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x63EE710", Offset = "0x63ED310", VA = "0x1863EE710", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x63EE820", Offset = "0x63ED420", VA = "0x1863EE820", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<JNNLMBKMLLG, bool> JHJLIPFNGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x63EEA80", Offset = "0x63ED680", VA = "0x1863EEA80", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x63EF000", Offset = "0x63EDC00", VA = "0x1863EF000", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x964640", Offset = "0x963240", VA = "0x180964640", Slot = "35")]
	public void BKBKKBBPGKK(AKEENPEHJFJ HJBMHJDHCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x63EF180", Offset = "0x63EDD80", VA = "0x1863EF180")]
	[UnityEngine.Scripting.Preserve]
	internal NIDODLHPBHC([DLBAGNNJKKK(null)] OKOCNPPIKGG PCOJMOHPOND, [DLBAGNNJKKK(null)] PHGHPEAICAJ ODJIBPMJHOC, [DLBAGNNJKKK(null)] CLBIGKMAMFC NKGFHMONHGO, [DLBAGNNJKKK(null)] NCAMOCAOBKA IENMGICDHEH, [DLBAGNNJKKK(null)] DCMEMGFPPFF JPCDGPIJLCJ, [DLBAGNNJKKK(null)] PMMKMMJFNCL AAKLPMINFHP, [DLBAGNNJKKK(null)] PDEGCLAEOLH CCLDCHEMEJB, [DLBAGNNJKKK(null)] KPDIBHHHMEH LCOBNAMJIFO, [DLBAGNNJKKK(null)] EAKEBPLDJAI HONKHCHECDF, [DLBAGNNJKKK(null)] GBDJOOFGMBJ HNBNFNEMBOH, [DLBAGNNJKKK(null)] CFINJANHKIF FFIIOAEEJAP, [DLBAGNNJKKK(null)] PNCHHNGDOHF EILMNCLOHHP, [DLBAGNNJKKK(null)] INBIBLHOABC CPEPBKLPAGH, [DLBAGNNJKKK(null)] COHMJPPIAJC LIEHINIKINB, [DLBAGNNJKKK(null)] MILBDNCHNLF EGGNDDPPBEP, [DLBAGNNJKKK(null)] DKAHGMFIENM DBOGKEDHFIO, [DLBAGNNJKKK(null)] MNNBOBMCFJA OADINMDCOFL, [DLBAGNNJKKK(null)] JMALBMIKMLO DLGOAHBIFGD, [DLBAGNNJKKK(null)] EHOGOHMPOBG CEMHIDBDIGI, [DLBAGNNJKKK(null)] LGKDKKBBDIJ FALHLBKKBHK, [DLBAGNNJKKK(null)] AKLCAPLPHFH FGMDMGPCDLO, [DLBAGNNJKKK(null)] AFNJBPGEAGO CLFOBBFAFLP, [DLBAGNNJKKK(null)] KADFEKOBGOD CLNLPCMCADK, [DLBAGNNJKKK(null)] NBEKNIPBGGH OPOJJCEOKKO, [DLBAGNNJKKK(null)] EDOHAPHCDLD HNBJOIIGEMF, [DLBAGNNJKKK(null)] NHHPOOJPBND DIIHIAJGIIB, [DLBAGNNJKKK(null)] AFLIPJHMMIF ADEPCAHLDGD, [DLBAGNNJKKK(null)] BCIGAFKDHED NLKPOFHOJHL, [DLBAGNNJKKK(null)] FPLDLFKOINE HCHFOIDPFPM, [DLBAGNNJKKK(null)] MOJLHPBCMAL HBAAFBIBJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x63EED70", Offset = "0x63ED970", VA = "0x1863EED70")]
	private void JMCKLNABHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x63EE8E0", Offset = "0x63ED4E0", VA = "0x1863EE8E0", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x63EEE20", Offset = "0x63EDA20", VA = "0x1863EEE20", Slot = "48")]
	private void LHOELHBPNLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x63EE770", Offset = "0x63ED370", VA = "0x1863EE770", Slot = "49")]
	private AMOLFKBKLEG BJDKFIEAEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x63EEF70", Offset = "0x63EDB70", VA = "0x1863EEF70", Slot = "50")]
	private NLPADNPAJCB MMOPJLNOICG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x63EEB40", Offset = "0x63ED740", VA = "0x1863EEB40", Slot = "51")]
	[AsyncStateMachine(typeof(MJJPJFKJPEB))]
	private Task<CFDJENKBLOB> GOHHCGADLDG(IBADDLHMPKI EBGOHPNLCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x63EE620", Offset = "0x63ED220", VA = "0x1863EE620", Slot = "52")]
	[AsyncStateMachine(typeof(LLIBEFNEGFJ))]
	private Task AHHJPJPNFKH(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x63EEE70", Offset = "0x63EDA70", VA = "0x1863EEE70")]
	[IteratorStateMachine(typeof(HKEDJNPFFDC))]
	private IEnumerable<NEEJBNNMHIH> MAHIPIFKNBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x63EF060", Offset = "0x63EDC60", VA = "0x1863EF060")]
	[CompilerGenerated]
	private void OAEEFALPLGA(NEEJBNNMHIH FNLDGAFEDDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class JOICGANJCJO : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0xC9C130", Offset = "0xC9AD30", VA = "0x180C9C130")]
	public JOICGANJCJO(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class JPFAMENJCLJ : HMPCHPBLIIM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct HEJFEGHEALI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public JPFAMENJCLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x63E2B90", Offset = "0x63E1790", VA = "0x1863E2B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x63E2ED0", Offset = "0x63E1AD0", VA = "0x1863E2ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly NCAMOCAOBKA IENMGICDHEH;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x775A60", Offset = "0x774660", VA = "0x180775A60")]
	public JPFAMENJCLJ(AEIFCCFGGHA PELKFGHCAJD, NCAMOCAOBKA IENMGICDHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x63EA650", Offset = "0x63E9250", VA = "0x1863EA650", Slot = "4")]
	[AsyncStateMachine(typeof(HEJFEGHEALI))]
	public Task<bool> LHAEEAOKBCI(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x63EA570", Offset = "0x63E9170", VA = "0x1863EA570")]
	[CompilerGenerated]
	private object ICGBNDCPPCK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class AKMFDCJAKCA : HMPCHPBLIIM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct GNFFMKEDLKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AKMFDCJAKCA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x63E2410", Offset = "0x63E1010", VA = "0x1863E2410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x63E2B20", Offset = "0x63E1720", VA = "0x1863E2B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NCAMOCAOBKA IENMGICDHEH;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private KABLCFJOKIG HPNOJDJMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x63D54F0", Offset = "0x63D40F0", VA = "0x1863D54F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x775A60", Offset = "0x774660", VA = "0x180775A60")]
	public AKMFDCJAKCA(AEIFCCFGGHA PELKFGHCAJD, NCAMOCAOBKA IENMGICDHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x63D5540", Offset = "0x63D4140", VA = "0x1863D5540", Slot = "4")]
	[AsyncStateMachine(typeof(GNFFMKEDLKO))]
	public Task<bool> LHAEEAOKBCI(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x63D5670", Offset = "0x63D4270", VA = "0x1863D5670")]
	[CompilerGenerated]
	private object NJFCLJEMDDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class MIOBAOIFGJH : HMPCHPBLIIM
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class ACBOBCCCHHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public MIOBAOIFGJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public HJPKNDBBNKL result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AKINJJFCBCP newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public ACBOBCCCHHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x63D4FE0", Offset = "0x63D3BE0", VA = "0x1863D4FE0")]
		internal object ODFJDMBJJDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x63D4F70", Offset = "0x63D3B70", VA = "0x1863D4F70")]
		internal object BFIJFGOOFHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x63D50D0", Offset = "0x63D3CD0", VA = "0x1863D50D0")]
		internal object PHFJCJLIEGB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct LFOJLMPHJEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public MIOBAOIFGJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private ACBOBCCCHHG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<HJPKNDBBNKL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x63EB060", Offset = "0x63E9C60", VA = "0x1863EB060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x63EB990", Offset = "0x63EA590", VA = "0x1863EB990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NCAMOCAOBKA IENMGICDHEH;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private KABLCFJOKIG HPNOJDJMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x63ED440", Offset = "0x63EC040", VA = "0x1863ED440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x775A60", Offset = "0x774660", VA = "0x180775A60")]
	public MIOBAOIFGJH(AEIFCCFGGHA PELKFGHCAJD, NCAMOCAOBKA IENMGICDHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x63ED490", Offset = "0x63EC090", VA = "0x1863ED490", Slot = "4")]
	[AsyncStateMachine(typeof(LFOJLMPHJEF))]
	public Task<bool> LHAEEAOKBCI(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal interface HMPCHPBLIIM
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> LHAEEAOKBCI(CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct PAKJOOGEHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class NCIEJAJODEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AEIFCCFGGHA manager;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NCIEJAJODEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x63EE5D0", Offset = "0x63ED1D0", VA = "0x1863EE5D0")]
		internal Task HGMBFILKPGA(HNHIPMBANEH data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct DFHIABLOILB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public PAKJOOGEHGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private IBADDLHMPKI <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<BABHIIDIIIL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<CFDJENKBLOB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x63D7A70", Offset = "0x63D6670", VA = "0x1863D7A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x63D8000", Offset = "0x63D6C00", VA = "0x1863D8000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct AHBNLPCHOGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public PAKJOOGEHGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x63D5170", Offset = "0x63D3D70", VA = "0x1863D5170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x63D5490", Offset = "0x63D4090", VA = "0x1863D5490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken BJFJMBIBKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly AEIFCCFGGHA CEICFMOFGAN;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private PHGHPEAICAJ ALFMNPGBKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x63F2300", Offset = "0x63F0F00", VA = "0x1863F2300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private NCAMOCAOBKA MOFFCFCLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x63F2230", Offset = "0x63F0E30", VA = "0x1863F2230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private KABLCFJOKIG HPNOJDJMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x63F2280", Offset = "0x63F0E80", VA = "0x1863F2280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private GBDJOOFGMBJ ANGKDDCNPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x63F21E0", Offset = "0x63F0DE0", VA = "0x1863F21E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1CCD050", Offset = "0x1CCBC50", VA = "0x181CCD050")]
	public PAKJOOGEHGL(CancellationToken BJFJMBIBKLL, AEIFCCFGGHA CEICFMOFGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x63F2420", Offset = "0x63F1020", VA = "0x1863F2420")]
	public static LJKFLDDNNAK KFLAKMNAIKO(AEIFCCFGGHA CEICFMOFGAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x63F2600", Offset = "0x63F1200", VA = "0x1863F2600")]
	[AsyncStateMachine(typeof(DFHIABLOILB))]
	public Task<bool> PELAEOHIFHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x63F1FD0", Offset = "0x63F0BD0", VA = "0x1863F1FD0")]
	private bool ADFBNDGKEHC([Out] IBADDLHMPKI EBGOHPNLCGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x63F2350", Offset = "0x63F0F50", VA = "0x1863F2350")]
	[AsyncStateMachine(typeof(AHBNLPCHOGN))]
	private Task KFJAFHKILJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x63F24D0", Offset = "0x63F10D0", VA = "0x1863F24D0")]
	private Task<BABHIIDIIIL> LBCDDJFPJOF(IBADDLHMPKI GOIPHIIMKNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct DKIEJLJPLED : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly MILBDNCHNLF EGGNDDPPBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid BJCCLJBIHHN;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private Task<(CFDJENKBLOB, Task)> NIBCMNMBDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x63D8770", Offset = "0x63D7370", VA = "0x1863D8770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3A23220", Offset = "0x3A21E20", VA = "0x183A23220")]
	public DKIEJLJPLED(MILBDNCHNLF EGGNDDPPBEP, Guid BJCCLJBIHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x63D8840", Offset = "0x63D7440", VA = "0x1863D8840")]
	public TaskAwaiter<(CFDJENKBLOB, Task)> DOMDHLHKKOK()
	{
		return default(TaskAwaiter<(CFDJENKBLOB, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x63D8890", Offset = "0x63D7490", VA = "0x1863D8890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct GNCOBBLMLCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(CFDJENKBLOB, Task)> FHNAMPJHPNE;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Task<(CFDJENKBLOB, Task)> NIBCMNMBDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x63E2030", Offset = "0x63E0C30", VA = "0x1863E2030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x63E2280", Offset = "0x63E0E80", VA = "0x1863E2280")]
	public GNCOBBLMLCB(TimeSpan BENLPNBGENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x63E2100", Offset = "0x63E0D00", VA = "0x1863E2100")]
	public void HAPNKFONIJO(Task LMAOILMBKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x63E2070", Offset = "0x63E0C70", VA = "0x1863E2070")]
	public void CGFBEPMPPLE(CFDJENKBLOB EKDKEAOJBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x63E21A0", Offset = "0x63E0DA0", VA = "0x1863E21A0")]
	public void HMMPLJHBIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x63E21F0", Offset = "0x63E0DF0", VA = "0x1863E21F0")]
	internal void IONIMKAOHAG(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class DDEONACDLGD
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class IAHFGPBICAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public AMHKJPMBBKF subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public IAHFGPBICAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x63E3500", Offset = "0x63E2100", VA = "0x1863E3500")]
		internal bool DJAOKKMDKFN(KEFAEPIPHKI s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x63D79E0", Offset = "0x63D65E0", VA = "0x1863D79E0")]
	public static GLELENLDELG PAKONFKLIMF(long NFHKGNJKDNH, long LPIJNBPBLPM, string DDGMFBNKOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x63D7560", Offset = "0x63D6160", VA = "0x1863D7560")]
	public static GLELENLDELG PAKONFKLIMF(long NFHKGNJKDNH, long LPIJNBPBLPM, JAJPEOHOEFN DGLECCENBLP, long KAJFLINCAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x63D7620", Offset = "0x63D6220", VA = "0x1863D7620")]
	public static GLELENLDELG PAKONFKLIMF(NAKMOBJIHCO OCGLCNGDMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x63D77B0", Offset = "0x63D63B0", VA = "0x1863D77B0")]
	public static GLELENLDELG PAKONFKLIMF(AADJFGNPPBI POJFGLCLECD, AMHKJPMBBKF IPJLLCDBCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x63D7470", Offset = "0x63D6070", VA = "0x1863D7470")]
	public static GLELENLDELG JMDPODNACFK(this GLELENLDELG AGEBEEELPDJ, AADJFGNPPBI COJPJPGHKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x63D72E0", Offset = "0x63D5EE0", VA = "0x1863D72E0")]
	public static GLELENLDELG ELBCKDEDIJE(this GLELENLDELG AGEBEEELPDJ, AMHKJPMBBKF HHOEFFBDNIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[RecRoom.NoEngine.Common.Preserve]
internal class CFEKKNBJDEG : EAKEBPLDJAI, NEEJBNNMHIH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct PDADNLLGDAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public CFEKKNBJDEG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x63F29C0", Offset = "0x63F15C0", VA = "0x1863F29C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x63F30A0", Offset = "0x63F1CA0", VA = "0x1863F30A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly KOHNFGELOEJ JPCPJNPKABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string GHBEENOBKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task KCFBMEMONAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool IEBINNHFDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x63D6EF0", Offset = "0x63D5AF0", VA = "0x1863D6EF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public Task GIBACFLBCGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x63D6BE0", Offset = "0x63D57E0", VA = "0x1863D6BE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x773820", Offset = "0x772420", VA = "0x180773820", Slot = "7")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x63D6C70", Offset = "0x63D5870", VA = "0x1863D6C70", Slot = "6")]
	public void JDCLJDFIFJK(Task IMKPJBJJCAM, string GMJNMILHDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x63D6DD0", Offset = "0x63D59D0", VA = "0x1863D6DD0")]
	[AsyncStateMachine(typeof(PDADNLLGDAA))]
	private Task MDPLKJGILJH(Task CKCPHLAPDLJ, string GMJNMILHDJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x63D6F20", Offset = "0x63D5B20", VA = "0x1863D6F20")]
	public CFEKKNBJDEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class MDIGECEEFHM : LAANEOACBLL, NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool JHMGFEMEAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private NKGBBEDNKNJ FILFANJIMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private PHGHPEAICAJ ODJIBPMJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NHHPOOJPBND DIIHIAJGIIB;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public NKGBBEDNKNJ CBIDBFJKGEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x63ECBD0", Offset = "0x63EB7D0", VA = "0x1863ECBD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x63EC8A0", Offset = "0x63EB4A0", VA = "0x1863EC8A0", Slot = "7")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x63ECA20", Offset = "0x63EB620", VA = "0x1863ECA20", Slot = "5")]
	public void MMFODDHGNBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x63EC7A0", Offset = "0x63EB3A0", VA = "0x1863EC7A0", Slot = "6")]
	public void CANNFCGDEOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x63EC7E0", Offset = "0x63EB3E0", VA = "0x1863EC7E0")]
	private Task IKNMBNPGAJF(LOKNPOCKLHK IKFHEHLCJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x63EC7A0", Offset = "0x63EB3A0", VA = "0x1863EC7A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public MDIGECEEFHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class LEDGCFPPJDA : NHHPOOJPBND
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class EBCDJKFCOLM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly OGBLNGLGIDJ HGLGGDNNLKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly string PPNDANAOAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly T MLNCHKABKBO;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public T GMFAJOGMKIF
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x7C4240", Offset = "0x7C2E40", VA = "0x1807C4240")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x94A2A0", Offset = "0x948EA0", VA = "0x18094A2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3152D70", Offset = "0x3151970", VA = "0x183152D70")]
		public EBCDJKFCOLM(OGBLNGLGIDJ HGLGGDNNLKP, string PPNDANAOAMK, T MLNCHKABKBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3152740", Offset = "0x3151340", VA = "0x183152740")]
		private void GADECCLNEBF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly OGBLNGLGIDJ HGLGGDNNLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly EBCDJKFCOLM<TimeSpan> ILLPEMEBOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly EBCDJKFCOLM<TimeSpan> PHIFLIFMOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly EBCDJKFCOLM<TimeSpan> FFAEMDAPLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly EBCDJKFCOLM<TimeSpan> MFBNHGMPIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly EBCDJKFCOLM<bool> GMHHKKCPMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly EBCDJKFCOLM<bool> HJJNCOJHCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly EBCDJKFCOLM<bool> FKHNHHJCKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly EBCDJKFCOLM<int> MLNLEPMFAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly EBCDJKFCOLM<bool> JEIMGAMBFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly EBCDJKFCOLM<bool> HIMKFBBBGOI;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan DFFLLDHEIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x63EA8C0", Offset = "0x63E94C0", VA = "0x1863EA8C0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TimeSpan JCIAGMLNPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x63EA740", Offset = "0x63E9340", VA = "0x1863EA740", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public TimeSpan NELLHMPAINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x63EA980", Offset = "0x63E9580", VA = "0x1863EA980", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public TimeSpan HKHLMDJKLBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x63EA800", Offset = "0x63E9400", VA = "0x1863EA800", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool PIOJKEPLDII
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x63EA7C0", Offset = "0x63E93C0", VA = "0x1863EA7C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool AHEOGIHMFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x63EA880", Offset = "0x63E9480", VA = "0x1863EA880", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool DCEOHLGIJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x63EA940", Offset = "0x63E9540", VA = "0x1863EA940", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int KJEACIFNLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x63EA840", Offset = "0x63E9440", VA = "0x1863EA840", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool AGPAIFLMJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x63EA900", Offset = "0x63E9500", VA = "0x1863EA900", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool KGFBJOMBOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x63EA780", Offset = "0x63E9380", VA = "0x1863EA780", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x63EA9C0", Offset = "0x63E95C0", VA = "0x1863EA9C0")]
	[UnityEngine.Scripting.Preserve]
	public LEDGCFPPJDA([DLBAGNNJKKK(null)] OGBLNGLGIDJ HGLGGDNNLKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[UnityEngine.Scripting.Preserve]
internal class JNFNCPLGFDF : CFINJANHKIF, NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class CLPEKAPCNAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public NIIHDDCOAKK roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public CLPEKAPCNAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x63D71B0", Offset = "0x63D5DB0", VA = "0x1863D71B0")]
		internal object EMMFCAANFAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action CIIFJNAILEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x63E9A90", Offset = "0x63E8690", VA = "0x1863E9A90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x63E9DD0", Offset = "0x63E89D0", VA = "0x1863E9DD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event KJDOIPDNFFK IGDIKNKPIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x63E9BE0", Offset = "0x63E87E0", VA = "0x1863E9BE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x63E99F0", Offset = "0x63E85F0", VA = "0x1863E99F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event KJDOIPDNFFK DJGEHFBGMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x63EA130", Offset = "0x63E8D30", VA = "0x1863EA130", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x63E9D30", Offset = "0x63E8930", VA = "0x1863E9D30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event KJDOIPDNFFK CNNPGFEFJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x63E9E70", Offset = "0x63E8A70", VA = "0x1863E9E70", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x63EA200", Offset = "0x63E8E00", VA = "0x1863EA200", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<JNNLMBKMLLG, bool> LCEHJICJPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x63E9C80", Offset = "0x63E8880", VA = "0x1863E9C80", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x63E9B30", Offset = "0x63E8730", VA = "0x1863E9B30", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "19")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x63E9F10", Offset = "0x63E8B10", VA = "0x1863E9F10", Slot = "14")]
	public void NJICJOLLMDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x63E9970", Offset = "0x63E8570", VA = "0x1863E9970", Slot = "15")]
	public void AOEBOFGJBND(NIIHDDCOAKK KIALKADCNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x63EA1D0", Offset = "0x63E8DD0", VA = "0x1863EA1D0", Slot = "16")]
	public void OKDPDIHKFDE(NIIHDDCOAKK KIALKADCNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x63EA2A0", Offset = "0x63E8EA0", VA = "0x1863EA2A0", Slot = "17")]
	public void PJAHFKHJHPJ(NIIHDDCOAKK KIALKADCNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x63E99A0", Offset = "0x63E85A0", VA = "0x1863E99A0", Slot = "18")]
	public void BEKBDJHDDDC(JNNLMBKMLLG NGJFKCMINGB, bool FHBGMNIFOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x63EA2D0", Offset = "0x63E8ED0", VA = "0x1863EA2D0")]
	private void POLBKJKNIDF(KJDOIPDNFFK JANCKFLIDOC, NIIHDDCOAKK KIALKADCNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public JNFNCPLGFDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal class NBHJMEKHFEE : PNCHHNGDOHF, NEEJBNNMHIH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct EOFGAIFJBEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public NBHJMEKHFEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x63DFE00", Offset = "0x63DEA00", VA = "0x1863DFE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x63E0350", Offset = "0x63DEF50", VA = "0x1863E0350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct IHEICLNMKIN : IAsyncStateMachine
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
		public NBHJMEKHFEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x63E4CB0", Offset = "0x63E38B0", VA = "0x1863E4CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x63E5350", Offset = "0x63E3F50", VA = "0x1863E5350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class GEKAAGCDKGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public GEKAAGCDKGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x63E1200", Offset = "0x63DFE00", VA = "0x1863E1200")]
		internal object LODEFAGLDHL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct NMAOBMOOCHE : IAsyncStateMachine
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
		public NBHJMEKHFEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private GEKAAGCDKGP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x63EFB10", Offset = "0x63EE710", VA = "0x1863EFB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x63F02A0", Offset = "0x63EEEA0", VA = "0x1863F02A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class HIPMCAKKKED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public HIPMCAKKKED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x63E2F40", Offset = "0x63E1B40", VA = "0x1863E2F40")]
		internal object IGJLFDFJHLN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly ELHKCOAEACJ CABFMJIIGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NCAMOCAOBKA IENMGICDHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private HMPCHPBLIIM[] NIOPGEIGJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private CancellationTokenSource OEDMIHFDIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private int EJKMPPJKPHG;

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x63EDCB0", Offset = "0x63EC8B0", VA = "0x1863EDCB0", Slot = "6")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x63ED980", Offset = "0x63EC580", VA = "0x1863ED980", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x63EDBA0", Offset = "0x63EC7A0", VA = "0x1863EDBA0", Slot = "8")]
	public void IIEKIHINOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x63ED8A0", Offset = "0x63EC4A0", VA = "0x1863ED8A0", Slot = "5")]
	public void ALCMKBHHEKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x63EE340", Offset = "0x63ECF40", VA = "0x1863EE340", Slot = "4")]
	[AsyncStateMachine(typeof(EOFGAIFJBEC))]
	public Task NDIJGJGNIPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x63EDF50", Offset = "0x63ECB50", VA = "0x1863EDF50")]
	private void MNGAGPPOCOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x63EDD30", Offset = "0x63EC930", VA = "0x1863EDD30")]
	[AsyncStateMachine(typeof(IHEICLNMKIN))]
	private Task KAFEABHEAPB(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x63EDA70", Offset = "0x63EC670", VA = "0x1863EDA70")]
	[AsyncStateMachine(typeof(NMAOBMOOCHE))]
	private Task<bool> HFNGAAEOFHJ(int DCGGFHOCGGH, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x63ED990", Offset = "0x63EC590", VA = "0x1863ED990")]
	private void GJMKAIFGHFK(int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x63EE260", Offset = "0x63ECE60", VA = "0x1863EE260")]
	private void MOEKMLHEIOP(int DCGGFHOCGGH, bool FHBGMNIFOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x63EDE20", Offset = "0x63ECA20", VA = "0x1863EDE20")]
	private void KBOKKLOEAGF(int DCGGFHOCGGH, Exception GDDKLHPPIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x63EE410", Offset = "0x63ED010", VA = "0x1863EE410")]
	private void PPPPBOPGOAM(CancellationToken BJFJMBIBKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public NBHJMEKHFEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class JAMAAGHIPAG : INBIBLHOABC, NEEJBNNMHIH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct EHGNIIHFOBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AKINJJFCBCP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JAMAAGHIPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public AKEENPEHJFJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x63DE090", Offset = "0x63DCC90", VA = "0x1863DE090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x63DEA50", Offset = "0x63DD650", VA = "0x1863DEA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct GMDOGIDDFPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public JAMAAGHIPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AKINJJFCBCP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AKEENPEHJFJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private FIKFBEICCGA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private BGAFJPNGEOB <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private GHEDMAGOABF <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x63E13D0", Offset = "0x63DFFD0", VA = "0x1863E13D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x63E1FD0", Offset = "0x63E0BD0", VA = "0x1863E1FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class JNGIIIALHKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Matchmaking.DACLHNJHPKE result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public EOPOKBEAANJ errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public JNGIIIALHKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x63EA4C0", Offset = "0x63E90C0", VA = "0x1863EA4C0")]
		internal object HJBBKPAHPBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class CNHKIOLKNCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Task<GLELENLDELG> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public CNHKIOLKNCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		internal Task<GLELENLDELG> ELMOBLNJAEO(FIKFBEICCGA<string>.DJKJOCCHFDH _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct EAKJMIIJOJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public JAMAAGHIPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AKINJJFCBCP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public AKEENPEHJFJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public BGAFJPNGEOB joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private CNHKIOLKNCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private GNDIMEMADBJ <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private LPKFHNPIOJH <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Task<Matchmaking.PJLFHHCDDMD> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CAHNKHDLDNG <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.PJLFHHCDDMD> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<GLELENLDELG> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x63D8960", Offset = "0x63D7560", VA = "0x1863D8960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x63DDB00", Offset = "0x63DC700", VA = "0x1863DDB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct EMKAMFEOJKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public JAMAAGHIPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <disconnectTimerScope>5__3;

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
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x63DF310", Offset = "0x63DDF10", VA = "0x1863DF310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x63DFDA0", Offset = "0x63DE9A0", VA = "0x1863DFDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct NIOCHNODNML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public JAMAAGHIPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private OKOCNPPIKGG <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x63EF630", Offset = "0x63EE230", VA = "0x1863EF630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x63EFAB0", Offset = "0x63EE6B0", VA = "0x1863EFAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct PEHBGHINHNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder<Matchmaking.PJLFHHCDDMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AKINJJFCBCP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public JAMAAGHIPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter<Matchmaking.PJLFHHCDDMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x63F3100", Offset = "0x63F1D00", VA = "0x1863F3100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x63F3600", Offset = "0x63F2200", VA = "0x1863F3600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct MEKPMJNDJEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Matchmaking.PJLFHHCDDMD serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public JAMAAGHIPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public BGAFJPNGEOB joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<DGBJGBMGCJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x63ECC40", Offset = "0x63EB840", VA = "0x1863ECC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x63ED370", Offset = "0x63EBF70", VA = "0x1863ED370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class CLLPNLDCMLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AKINJJFCBCP targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public CLLPNLDCMLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x63D6FB0", Offset = "0x63D5BB0", VA = "0x1863D6FB0")]
		internal object AADCFFOGNMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x63D70B0", Offset = "0x63D5CB0", VA = "0x1863D70B0")]
		internal string IHEBIGNENFB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct OKNGDGFKCFI : IAsyncStateMachine
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
		public AKINJJFCBCP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public JAMAAGHIPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private CLLPNLDCMLD <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x63F1340", Offset = "0x63EFF40", VA = "0x1863F1340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x63F1F70", Offset = "0x63F0B70", VA = "0x1863F1F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct JFIPOGDPBCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public JAMAAGHIPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public BGAFJPNGEOB joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public GLELENLDELG initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AKINJJFCBCP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public GNDIMEMADBJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x63E9000", Offset = "0x63E7C00", VA = "0x1863E9000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x63E9910", Offset = "0x63E8510", VA = "0x1863E9910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct IGDPPDJLKLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public JAMAAGHIPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap3;

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
		[Cpp2IlInjected.Address(RVA = "0x63E35B0", Offset = "0x63E21B0", VA = "0x1863E35B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x63E4C50", Offset = "0x63E3850", VA = "0x1863E4C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct LNKKNDOEBIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public JAMAAGHIPAG <>4__this;

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
		private TaskAwaiter<CFDJENKBLOB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x63EBF10", Offset = "0x63EAB10", VA = "0x1863EBF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x63EC740", Offset = "0x63EB340", VA = "0x1863EC740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class DJIJIDNGKNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AKINJJFCBCP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public DJIJIDNGKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x63D85A0", Offset = "0x63D71A0", VA = "0x1863D85A0")]
		internal object ILHNIGGDFOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class HODCAFPHPKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public HODCAFPHPKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x63E3460", Offset = "0x63E2060", VA = "0x1863E3460")]
		internal void LJJIBKFEBFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class IDGHOPLPNKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public AKINJJFCBCP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public IDGHOPLPNKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x63E3530", Offset = "0x63E2130", VA = "0x1863E3530")]
		internal object BCMLKNEIMHE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class JAFCDNHHENA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public AKINJJFCBCP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public JAFCDNHHENA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x63E53B0", Offset = "0x63E3FB0", VA = "0x1863E53B0")]
		internal string KPJFOAMFPKD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ELHKCOAEACJ CABFMJIIGKB;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ELHKCOAEACJ OOCMPJFECFG;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly ELHKCOAEACJ JNBMADAMOLL;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly ELHKCOAEACJ HPMAHHALCGP;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly string HCIGFDEKOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string AKAMALFJHCG;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string DDCHBFJGFHP;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static readonly Guid GLCCFLGGMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private KPDIBHHHMEH LCOBNAMJIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private CLBIGKMAMFC NKGFHMONHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private PHGHPEAICAJ ODJIBPMJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private NCAMOCAOBKA IENMGICDHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private PNCHHNGDOHF EILMNCLOHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private EAKEBPLDJAI HONKHCHECDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private CFINJANHKIF FFIIOAEEJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private MOJLHPBCMAL HBAAFBIBJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private FPLDLFKOINE HCHFOIDPFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private IDisposable JNNPAOCOILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly KOHNFGELOEJ JHOEOMECFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly KOHNFGELOEJ ENDOOMDKBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private CAHNKHDLDNG OFOANPDNGEO;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TaskStatus CPFCJDIOHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9FCA70", Offset = "0x9FB670", VA = "0x1809FCA70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA4A640", Offset = "0xA49240", VA = "0x180A4A640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private KABLCFJOKIG HPNOJDJMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x63E7AA0", Offset = "0x63E66A0", VA = "0x1863E7AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x63E7C40", Offset = "0x63E6840", VA = "0x1863E7C40", Slot = "6")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x63E5BA0", Offset = "0x63E47A0", VA = "0x1863E5BA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x63E7220", Offset = "0x63E5E20", VA = "0x1863E7220", Slot = "5")]
	[AsyncStateMachine(typeof(EHGNIIHFOBI))]
	public Task HKFHMDANMAJ(AKINJJFCBCP FDLFBJDCFCP, AKEENPEHJFJ OJAOCHHHNGN, CancellationToken BINKOPDIFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x63E5DA0", Offset = "0x63E49A0", VA = "0x1863E5DA0")]
	[AsyncStateMachine(typeof(GMDOGIDDFPJ))]
	private Task FELIEMGJJIK(AKINJJFCBCP FDLFBJDCFCP, AKEENPEHJFJ OJAOCHHHNGN, CancellationToken BINKOPDIFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x63E60F0", Offset = "0x63E4CF0", VA = "0x1863E60F0")]
	private static void FGANLCCHNPA(MOJLHPBCMAL HBAAFBIBJKM, AKINJJFCBCP FDLFBJDCFCP, Exception GDDKLHPPIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x63E6990", Offset = "0x63E5590", VA = "0x1863E6990")]
	private static void HAMJOBNBGIP(GHEDMAGOABF BALDCHBFNKL, Exception GDDKLHPPIHO, [Optional] List<int> GILCHKELHPK, int EJKMPPJKPHG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x63E54B0", Offset = "0x63E40B0", VA = "0x1863E54B0")]
	[AsyncStateMachine(typeof(EAKJMIIJOJD))]
	private Task ADNAGIAFLMH(FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, AKINJJFCBCP FDLFBJDCFCP, AKEENPEHJFJ OJAOCHHHNGN, BGAFJPNGEOB CLBANEBKODO, CancellationToken BINKOPDIFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x63E7490", Offset = "0x63E6090", VA = "0x1863E7490")]
	private void HPHDDNNKHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x63E8200", Offset = "0x63E6E00", VA = "0x1863E8200")]
	[AsyncStateMachine(typeof(EMKAMFEOJKL))]
	private Task KOEFCBLIFLN(FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x63E75E0", Offset = "0x63E61E0", VA = "0x1863E75E0")]
	private void IDLEBBAMBIM(AKINJJFCBCP FDLFBJDCFCP, CancellationToken BINKOPDIFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x63E87F0", Offset = "0x63E73F0", VA = "0x1863E87F0")]
	private void MIHNFLAIBCP(AKINJJFCBCP FDLFBJDCFCP, BGAFJPNGEOB CLBANEBKODO, OperationCanceledException KLIKDOPFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x63E85C0", Offset = "0x63E71C0", VA = "0x1863E85C0")]
	private void MDMJAJIMKBF(AKINJJFCBCP FDLFBJDCFCP, BGAFJPNGEOB CLBANEBKODO, Exception GDDKLHPPIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x63E5910", Offset = "0x63E4510", VA = "0x1863E5910")]
	private void DJKJAOOLCNA(AKINJJFCBCP FDLFBJDCFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x63E8440", Offset = "0x63E7040", VA = "0x1863E8440")]
	private static NIIHDDCOAKK KPIOBDMPNBK(AKINJJFCBCP FDLFBJDCFCP)
	{
		return default(NIIHDDCOAKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x63E68C0", Offset = "0x63E54C0", VA = "0x1863E68C0")]
	[AsyncStateMachine(typeof(NIOCHNODNML))]
	private Task HAAPEBGNABO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x63E57B0", Offset = "0x63E43B0", VA = "0x1863E57B0")]
	[AsyncStateMachine(typeof(PEHBGHINHNF))]
	private Task<Matchmaking.PJLFHHCDDMD> DFBPGIMKEFB(AKINJJFCBCP FDLFBJDCFCP, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x63E5610", Offset = "0x63E4210", VA = "0x1863E5610")]
	private static DGBJGBMGCJD CGJMDOCHMNB(Matchmaking.PJLFHHCDDMD GPOAPAFMJFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x63E64B0", Offset = "0x63E50B0", VA = "0x1863E64B0")]
	[AsyncStateMachine(typeof(MEKPMJNDJEA))]
	private Task FJNFKBBCPIL(Matchmaking.PJLFHHCDDMD GPOAPAFMJFJ, BGAFJPNGEOB CLBANEBKODO, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken AFIMJMLEPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x63E6770", Offset = "0x63E5370", VA = "0x1863E6770")]
	[AsyncStateMachine(typeof(OKNGDGFKCFI))]
	private Task GJFHANEJDGL(AKINJJFCBCP FDLFBJDCFCP, CancellationTokenSource GIBJOFADFCO, Task JPAOOHKHICO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x63E6600", Offset = "0x63E5200", VA = "0x1863E6600")]
	[AsyncStateMachine(typeof(JFIPOGDPBCI))]
	private Task FNPCLOOMBKD(GLELENLDELG MINIAOGHOMD, GNDIMEMADBJ MJNGLPNBMPO, AKINJJFCBCP DGFGKKDEEJF, BGAFJPNGEOB HHOCLFKNNNK, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BIBEGJLHOIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x63E5EF0", Offset = "0x63E4AF0", VA = "0x1863E5EF0")]
	private BGAFJPNGEOB FEOIKLDBELP(BGAFJPNGEOB HHOCLFKNNNK, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x63E7360", Offset = "0x63E5F60", VA = "0x1863E7360")]
	[AsyncStateMachine(typeof(IGDPPDJLKLC))]
	private Task HNCNJMLBEOC(FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x63E8BF0", Offset = "0x63E77F0", VA = "0x1863E8BF0")]
	[AsyncStateMachine(typeof(LNKKNDOEBIB))]
	private Task PEDJEKJMJGB(HNHIPMBANEH IGJLGPELHOJ, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x63E7920", Offset = "0x63E6520", VA = "0x1863E7920")]
	private static void IHKCPGAIOAM(AKINJJFCBCP FDLFBJDCFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x63E8A20", Offset = "0x63E7620", VA = "0x1863E8A20")]
	private void OPOEKNKCIPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x63E8530", Offset = "0x63E7130", VA = "0x1863E8530")]
	private void LMONIHCPNFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x63E5720", Offset = "0x63E4320", VA = "0x1863E5720")]
	private void CNFBDICFPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x63E84A0", Offset = "0x63E70A0", VA = "0x1863E84A0")]
	private void LFHEIKGGJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x63E7AF0", Offset = "0x63E66F0", VA = "0x1863E7AF0")]
	private static void JIFGIICNPMM(AKINJJFCBCP FDLFBJDCFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x63E8330", Offset = "0x63E6F30", VA = "0x1863E8330")]
	private static CancellationTokenRegistration KPAPFCFPDEE(AKINJJFCBCP FDLFBJDCFCP, CancellationToken AFIMJMLEPMO)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x63E8100", Offset = "0x63E6D00", VA = "0x1863E8100")]
	private static void KINOCMFJOBC(AKINJJFCBCP FDLFBJDCFCP, Exception GDDKLHPPIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x63E5BF0", Offset = "0x63E47F0", VA = "0x1863E5BF0")]
	private void EEPGPNEIEJG(AKINJJFCBCP FDLFBJDCFCP, Task JPAOOHKHICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x63E7BE0", Offset = "0x63E67E0", VA = "0x1863E7BE0")]
	private static void JJBLJPHBGMP(Func<string> BJKEGONNGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x63E8F30", Offset = "0x63E7B30", VA = "0x1863E8F30")]
	public JAMAAGHIPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x63E5B40", Offset = "0x63E4740", VA = "0x1863E5B40")]
	[CompilerGenerated]
	internal static (int, int?) DKPNAKBLEBB(EOPOKBEAANJ CDPNJMLAOAG)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[RecRoom.NoEngine.Common.Preserve]
internal class OHAJJNFEGEP : COHMJPPIAJC, NEEJBNNMHIH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct IKCNIPPMOMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public OHAJJNFEGEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public HNHIPMBANEH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6406CD0", Offset = "0x64058D0", VA = "0x186406CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6407090", Offset = "0x6405C90", VA = "0x186407090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class OJOHGPOEEIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public OHAJJNFEGEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public HNHIPMBANEH roomData;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public OJOHGPOEEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6410F40", Offset = "0x640FB40", VA = "0x186410F40")]
		internal List<Task> IONDIADMHHL(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct GJMMBKLIHPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public LJKFLDDNNAK taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public HNHIPMBANEH data;

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
		[Cpp2IlInjected.Address(RVA = "0x6405240", Offset = "0x6403E40", VA = "0x186405240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6405610", Offset = "0x6404210", VA = "0x186405610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct GDKGHLBFFPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public OHAJJNFEGEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6404980", Offset = "0x6403580", VA = "0x186404980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6404C40", Offset = "0x6403840", VA = "0x186404C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly HashSet<LJKFLDDNNAK> NFGHJFJCECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private CLBIGKMAMFC NKGFHMONHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private BIOAHKOLPIF OBIDFJCPLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private NALKDPIOKEG IFBBCJNHAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private IDisposable JNNPAOCOILE;

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x63F0A80", Offset = "0x63EF680", VA = "0x1863F0A80", Slot = "5")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x63F0670", Offset = "0x63EF270", VA = "0x1863F0670", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x63F06D0", Offset = "0x63EF2D0", VA = "0x1863F06D0", Slot = "4")]
	public bool FOENNCADIJB(LJKFLDDNNAK JDHCALPMBNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x63F0D00", Offset = "0x63EF900", VA = "0x1863F0D00")]
	private void LNDFEFNKLDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x63F0800", Offset = "0x63EF400", VA = "0x1863F0800")]
	private void IDAHECJAOHE(HNHIPMBANEH EMCADPHEHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x63F0390", Offset = "0x63EEF90", VA = "0x1863F0390")]
	[AsyncStateMachine(typeof(IKCNIPPMOMB))]
	private Task ACOFHDLJGEA(HNHIPMBANEH EMCADPHEHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x63F0480", Offset = "0x63EF080", VA = "0x1863F0480")]
	private Func<CancellationToken, List<Task>> DFHLIMHDCPO(HNHIPMBANEH EMCADPHEHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x63F0E40", Offset = "0x63EFA40", VA = "0x1863F0E40")]
	private List<Task> MOAKOCFHEPI(HNHIPMBANEH EMCADPHEHCL, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x63F0550", Offset = "0x63EF150", VA = "0x1863F0550")]
	[AsyncStateMachine(typeof(GJMMBKLIHPI))]
	private Task DOPCHAKKNPF(LJKFLDDNNAK LFGOMLHIEOK, HNHIPMBANEH IGJLGPELHOJ, CancellationToken KJCAGLABEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x63F0730", Offset = "0x63EF330", VA = "0x1863F0730")]
	[AsyncStateMachine(typeof(GDKGHLBFFPJ))]
	private Task HPNHHBDDALN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x63F0A00", Offset = "0x63EF600", VA = "0x1863F0A00")]
	private void IIEKIHINOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x63F12B0", Offset = "0x63EFEB0", VA = "0x1863F12B0")]
	public OHAJJNFEGEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[UnityEngine.Scripting.Preserve]
internal sealed class NLFDLKINKGH : MILBDNCHNLF, NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class FLMMMNNBLIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public FLMMMNNBLIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6404920", Offset = "0x6403520", VA = "0x186404920")]
		internal object GIGNFJJIFMC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class ANBOCAJENNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public ANBOCAJENNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x63F4710", Offset = "0x63F3310", VA = "0x1863F4710")]
		internal object LIKHIEGLLNL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class ELECNICAKON
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public ELECNICAKON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class FDNLEFGFOME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public FDNLEFGFOME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x64029E0", Offset = "0x64015E0", VA = "0x1864029E0")]
		internal object HFELDOGNBND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class MDHPEJFBHGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public MDHPEJFBHGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x640DD70", Offset = "0x640C970", VA = "0x18640DD70")]
		internal object HFKKCPIMFAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly Dictionary<Guid, GNCOBBLMLCB> EGGNDDPPBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly TimeSpan AHBFMKFLBCE;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "9")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x640F610", Offset = "0x640E210", VA = "0x18640F610", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x640F620", Offset = "0x640E220", VA = "0x18640F620", Slot = "4")]
	public DKIEJLJPLED HFMDKEOMMOI(Guid BJCCLJBIHHN)
	{
		return default(DKIEJLJPLED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x640F850", Offset = "0x640E450", VA = "0x18640F850", Slot = "5")]
	public bool IFJPOCDCFNK(Guid BJCCLJBIHHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x640F250", Offset = "0x640DE50", VA = "0x18640F250", Slot = "6")]
	public bool BKEBJJJDHAG(Guid BJCCLJBIHHN, Task LMAOILMBKJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x640FA80", Offset = "0x640E680", VA = "0x18640FA80", Slot = "7")]
	public bool IPHKLPEHLHF(Guid BJCCLJBIHHN, CFDJENKBLOB EKDKEAOJBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x640F5A0", Offset = "0x640E1A0", VA = "0x18640F5A0", Slot = "8")]
	public Task<(CFDJENKBLOB, Task)> BNCGNFKPIBD(Guid BJCCLJBIHHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x640FC80", Offset = "0x640E880", VA = "0x18640FC80")]
	private void KIKEIAAFIIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x640FEC0", Offset = "0x640EAC0", VA = "0x18640FEC0")]
	public NLFDLKINKGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[RecRoom.NoEngine.Common.Preserve]
internal class FINAJAAJGKF : DKAHGMFIENM, NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class BCKKJEACCBO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private readonly AKINJJFCBCP NFAHLMINKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly CancellationTokenSource OEDMIHFDIKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public readonly CancellationToken FEFKHFILIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private bool JPFNFJHHLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool OCFIKJIDDDB;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x63F6C40", Offset = "0x63F5840", VA = "0x1863F6C40")]
		public BCKKJEACCBO(AKINJJFCBCP NFAHLMINKMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x63F6AF0", Offset = "0x63F56F0", VA = "0x1863F6AF0")]
		public void IIEKIHINOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x63F6AC0", Offset = "0x63F56C0", VA = "0x1863F6AC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class BMFIOEJAAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public LOKNPOCKLHK disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public BMFIOEJAAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x63F8BE0", Offset = "0x63F77E0", VA = "0x1863F8BE0")]
		internal object PMLGMLEEDBB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct DJKNBAAENHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public LOKNPOCKLHK disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public FINAJAAJGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x63FC830", Offset = "0x63FB430", VA = "0x1863FC830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x63FCC60", Offset = "0x63FB860", VA = "0x1863FCC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class OKPGFGKCIDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public OKPGFGKCIDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6411610", Offset = "0x6410210", VA = "0x186411610")]
		internal object OPNOKOKLGJP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct BLKJJCGJHMO : IAsyncStateMachine
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
		public FINAJAAJGKF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x63F7980", Offset = "0x63F6580", VA = "0x1863F7980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0C0", Offset = "0x7E9CC0", VA = "0x1807EB0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class PDBPDEMEOGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AKINJJFCBCP newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public PDBPDEMEOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6411680", Offset = "0x6410280", VA = "0x186411680")]
		internal object DNOLIOMIEMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6411720", Offset = "0x6410320", VA = "0x186411720")]
		internal object FABOAJBFOEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6411760", Offset = "0x6410360", VA = "0x186411760")]
		internal object NHMONJLGPLP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class LGPEFHDHADK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public LGPEFHDHADK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x640BB20", Offset = "0x640A720", VA = "0x18640BB20")]
		internal void CPHGLCJDDEJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct EKNHMFGHFBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public AKINJJFCBCP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public FINAJAAJGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public AKEENPEHJFJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private PDBPDEMEOGL <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x63FF510", Offset = "0x63FE110", VA = "0x1863FF510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6400510", Offset = "0x63FF110", VA = "0x186400510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly ELHKCOAEACJ CABFMJIIGKB;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly DLNNIFNKDKE.AKBDPOICNDP KOCBPKLCBPK;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly PHIOOLOPDKA LEEDHEKJCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private CLBIGKMAMFC NKGFHMONHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private PNCHHNGDOHF EILMNCLOHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private NCAMOCAOBKA IENMGICDHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private NHHPOOJPBND DIIHIAJGIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private INBIBLHOABC CPEPBKLPAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private long JINICNPPJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private BCKKJEACCBO CCHMMMGMDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private bool MINDPHPFBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private Task NDMLKNPKIFH;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private KABLCFJOKIG HPNOJDJMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6402E30", Offset = "0x6401A30", VA = "0x186402E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool ECLADGFOHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xAE5160", Offset = "0xAE3D60", VA = "0x180AE5160")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6402E20", Offset = "0x6401A20", VA = "0x186402E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6402E80", Offset = "0x6401A80", VA = "0x186402E80", Slot = "4")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6402B10", Offset = "0x6401710", VA = "0x186402B10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6403590", Offset = "0x6402190", VA = "0x186403590")]
	[AsyncStateMachine(typeof(DJKNBAAENHJ))]
	private Task NPGMICIAAHA(LOKNPOCKLHK GLOPPHIHPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6403930", Offset = "0x6402530", VA = "0x186403930")]
	private void PIJILMMBHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6403790", Offset = "0x6402390", VA = "0x186403790")]
	private void PAOLPICOAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6403400", Offset = "0x6402000", VA = "0x186403400")]
	private void LFBLPOGIKDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6402C80", Offset = "0x6401880", VA = "0x186402C80")]
	private bool EMLNBGKGOLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6402A40", Offset = "0x6401640", VA = "0x186402A40")]
	[AsyncStateMachine(typeof(BLKJJCGJHMO))]
	private void CPNNGMNPCIE(int JMFEJOLNILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6403170", Offset = "0x6401D70", VA = "0x186403170")]
	private void KGLFMLBJOMO([Out] IDisposable LJCANFIGPGF, [Out] IDisposable FAHNBKKGKMD, [Out] IDisposable FPPEIFPEAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6403680", Offset = "0x6402280", VA = "0x186403680")]
	private bool OEFLPPNOIHD(AKINJJFCBCP NFAHLMINKMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6403120", Offset = "0x6401D20", VA = "0x186403120")]
	private void KDJHNHPMBHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6402CF0", Offset = "0x64018F0", VA = "0x186402CF0")]
	[AsyncStateMachine(typeof(EKNHMFGHFBI))]
	private Task FELIEMGJJIK(AKINJJFCBCP NFAHLMINKMM, AKEENPEHJFJ OJAOCHHHNGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6403EC0", Offset = "0x6402AC0", VA = "0x186403EC0")]
	public FINAJAAJGKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[UnityEngine.Scripting.Preserve]
internal sealed class DLAOGJHPHIL : MNNBOBMCFJA, NEEJBNNMHIH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct NNDEFGHECDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder<HBBGLBIKIJH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public DLAOGJHPHIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter<HBBGLBIKIJH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x640FF80", Offset = "0x640EB80", VA = "0x18640FF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6410210", Offset = "0x640EE10", VA = "0x186410210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class EOIDFNGFDGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public CMAIBKDPDAF message;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public EOIDFNGFDGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6400BF0", Offset = "0x63FF7F0", VA = "0x186400BF0")]
		internal object CJLGOLNBLCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class LAHOGOPMIKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public CMAIBKDPDAF messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public LAHOGOPMIKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x640BAC0", Offset = "0x640A6C0", VA = "0x18640BAC0")]
		internal object DMBOLPNPOPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class MKGFLEGFBIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public CMAIBKDPDAF request;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public MKGFLEGFBIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x640DE30", Offset = "0x640CA30", VA = "0x18640DE30")]
		internal object NHIHLCLCHLM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct ANOGGCPLODL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CMAIBKDPDAF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public DLAOGJHPHIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<OAMCKBCGEGJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x63F5400", Offset = "0x63F4000", VA = "0x1863F5400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x63F5D10", Offset = "0x63F4910", VA = "0x1863F5D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class KNMJKNEHCOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public CMAIBKDPDAF operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public KNMJKNEHCOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x6409FE0", Offset = "0x6408BE0", VA = "0x186409FE0")]
		internal object DIFLFIEMCDE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct BEKKKAPONMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public CMAIBKDPDAF operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public DLAOGJHPHIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private BGAFJPNGEOB <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<CMAIBKDPDAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x63F6CF0", Offset = "0x63F58F0", VA = "0x1863F6CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x63F78A0", Offset = "0x63F64A0", VA = "0x1863F78A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct AJLKGFJLIIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<OAMCKBCGEGJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public DLAOGJHPHIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public CMAIBKDPDAF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private EFEMOEIBGDF.JEJPBNGOHON <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private BGAFJPNGEOB <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter<CMAIBKDPDAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x63F4180", Offset = "0x63F2D80", VA = "0x1863F4180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x63F46A0", Offset = "0x63F32A0", VA = "0x1863F46A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class BJAOLJLLCBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public OAMCKBCGEGJ operation;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public BJAOLJLLCBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x63F7900", Offset = "0x63F6500", VA = "0x1863F7900")]
		internal object GIIBKFBIIOP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct ILMBLNBBDBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public OAMCKBCGEGJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public DLAOGJHPHIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private FIKFBEICCGA<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6407830", Offset = "0x6406430", VA = "0x186407830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6407EB0", Offset = "0x6406AB0", VA = "0x186407EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class IDMBCIOHHLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public CMAIBKDPDAF request;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public IDMBCIOHHLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6406C70", Offset = "0x6405870", VA = "0x186406C70")]
		internal object PDLNHBGKGCD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class HKMOFGJCECG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public CMAIBKDPDAF request;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public HKMOFGJCECG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6405D60", Offset = "0x6404960", VA = "0x186405D60")]
		internal object CPLGBLPDILA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private EAKEBPLDJAI HONKHCHECDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private JMALBMIKMLO DLGOAHBIFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private AFNJBPGEAGO CLFOBBFAFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private PHGHPEAICAJ ODJIBPMJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private TaskCompletionSource<HBBGLBIKIJH> HMBCKBMODGH;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x63FD950", Offset = "0x63FC550", VA = "0x1863FD950", Slot = "7")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x63FE1E0", Offset = "0x63FCDE0", VA = "0x1863FE1E0", Slot = "6")]
	[AsyncStateMachine(typeof(NNDEFGHECDG))]
	public Task<HBBGLBIKIJH> PPFHBMMLGLE(CancellationToken KONCBKHBBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x63FD250", Offset = "0x63FBE50", VA = "0x1863FD250", Slot = "4")]
	public void FAFJDDGHOLF(CMAIBKDPDAF EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x63FDAD0", Offset = "0x63FC6D0", VA = "0x1863FDAD0", Slot = "5")]
	public void PCCMNKFCGFL(CMAIBKDPDAF GLKIBFHEOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x63FD740", Offset = "0x63FC340", VA = "0x1863FD740")]
	[AsyncStateMachine(typeof(ANOGGCPLODL))]
	private Task GPCCEKNGCHI(CMAIBKDPDAF NFAAJOAMBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x63FD840", Offset = "0x63FC440", VA = "0x1863FD840")]
	[AsyncStateMachine(typeof(BEKKKAPONMG))]
	private Task JLDCOJCNBMG(CMAIBKDPDAF FEEMBOAEEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x63FD5F0", Offset = "0x63FC1F0", VA = "0x1863FD5F0")]
	[AsyncStateMachine(typeof(AJLKGFJLIIK))]
	private Task<OAMCKBCGEGJ> FJPMOABNFPL(CMAIBKDPDAF NFAAJOAMBMN, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x63FDA40", Offset = "0x63FC640", VA = "0x1863FDA40")]
	private BGAFJPNGEOB KINPIAPJJJF(CMAIBKDPDAF PKJLAPJGLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x63FCF00", Offset = "0x63FBB00", VA = "0x1863FCF00")]
	[AsyncStateMachine(typeof(ILMBLNBBDBE))]
	private Task BHHFPNGABAK(OAMCKBCGEGJ IIPOKLFKMOK, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x63FD020", Offset = "0x63FBC20", VA = "0x1863FD020")]
	private OAMCKBCGEGJ CMOJMANJPGD(CMAIBKDPDAF NFAAJOAMBMN, BGAFJPNGEOB GFACAJKPEOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2387140", Offset = "0x2385D40", VA = "0x182387140")]
	private T KHCDKBPABND<T>(T GCPEEAODAIB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x63FDE40", Offset = "0x63FCA40", VA = "0x1863FDE40")]
	private OAMCKBCGEGJ PCMAINHIONE(CMAIBKDPDAF NFAAJOAMBMN, BGAFJPNGEOB GFACAJKPEOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public DLAOGJHPHIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[UnityEngine.Scripting.Preserve]
internal sealed class CFHMFCLBCJC : JMALBMIKMLO, NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class BLKNHIOPPLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public BLKNHIOPPLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x63F8B70", Offset = "0x63F7770", VA = "0x1863F8B70")]
		internal object HHJAOPPCCMJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class CANHFIJFHDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public CANHFIJFHDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x63F8CD0", Offset = "0x63F78D0", VA = "0x1863F8CD0")]
		internal object JHNFGLMDGIJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private PHGHPEAICAJ ODJIBPMJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private KADFEKOBGOD CLNLPCMCADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private MNNBOBMCFJA OADINMDCOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private MILBDNCHNLF EGGNDDPPBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private EDOHAPHCDLD HNBJOIIGEMF;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x63FAFC0", Offset = "0x63F9BC0", VA = "0x1863FAFC0", Slot = "6")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x63FA790", Offset = "0x63F9390", VA = "0x1863FA790", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x63FAB70", Offset = "0x63F9770", VA = "0x1863FAB70", Slot = "4")]
	public DKIEJLJPLED HGPOMOOHKFN(CMAIBKDPDAF KLMPGFHBPKG)
	{
		return default(DKIEJLJPLED);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x63F9600", Offset = "0x63F8200", VA = "0x1863F9600", Slot = "5")]
	public void AJJILDIJEED(Guid BJCCLJBIHHN, Task LMAOILMBKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x63FA840", Offset = "0x63F9440", VA = "0x1863FA840")]
	private void ECHNMPNKIAI(byte LBOCMPDCIBH, int JLOFEEBANCN, object FEMDCIIEDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x63FA1C0", Offset = "0x63F8DC0", VA = "0x1863FA1C0")]
	private void DOFNKFNHBEL(KPOJFMMLMOB DCCNFPKPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x63FB3F0", Offset = "0x63F9FF0", VA = "0x1863FB3F0")]
	private void NGHMBOKNILG(KPOJFMMLMOB DCCNFPKPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x63F9F70", Offset = "0x63F8B70", VA = "0x1863F9F70")]
	private void COOOJBOOLEN(KPOJFMMLMOB DCCNFPKPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x63FA910", Offset = "0x63F9510", VA = "0x1863FA910")]
	private CFDJENKBLOB EHMDIMOLDNO(CMAIBKDPDAF PKJLAPJGLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x63F9820", Offset = "0x63F8420", VA = "0x1863F9820")]
	private void BBDOPONIGCI(CMAIBKDPDAF FEEMBOAEEMC, CFDJENKBLOB EKDKEAOJBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x63FB130", Offset = "0x63F9D30", VA = "0x1863FB130")]
	private bool LIAAPHMNKNK(CMAIBKDPDAF FEEMBOAEEMC, CFDJENKBLOB EKDKEAOJBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x63F9A50", Offset = "0x63F8650", VA = "0x1863F9A50")]
	private bool CCHLKKOFNJE(CMAIBKDPDAF NIHBOOIPJMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x63F9CD0", Offset = "0x63F88D0", VA = "0x1863F9CD0")]
	private bool CODMOACAMHG(byte LBOCMPDCIBH, ExitGames.Client.Photon.Hashtable DCCNFPKPNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public CFHMFCLBCJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[UnityEngine.Scripting.Preserve]
internal sealed class NBJCNPFGOOD : EHOGOHMPOBG, NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class NNNGNIOHIEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public HBBGLBIKIJH operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public NBJCNPFGOOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public CMAIBKDPDAF roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NNNGNIOHIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x64103B0", Offset = "0x640EFB0", VA = "0x1864103B0")]
		internal object PFDAPFJCFNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x6410280", Offset = "0x640EE80", VA = "0x186410280")]
		internal object DDKGGCABOHN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct JMINFONDGJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<CFDJENKBLOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public NBJCNPFGOOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public CMAIBKDPDAF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private TaskAwaiter<CFDJENKBLOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6409010", Offset = "0x6407C10", VA = "0x186409010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x64096F0", Offset = "0x64082F0", VA = "0x1864096F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class DJBFBKNEAMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public HBBGLBIKIJH operationType;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public DJBFBKNEAMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x63FC7C0", Offset = "0x63FB3C0", VA = "0x1863FC7C0")]
		internal object BBBJHBMBJGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class LKFGADKOKIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public CMAIBKDPDAF request;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public LKFGADKOKIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x640BCA0", Offset = "0x640A8A0", VA = "0x18640BCA0")]
		internal object FCJIEEBJFOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x640BC30", Offset = "0x640A830", VA = "0x18640BC30")]
		internal object CPKHBAFOAEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x640BBC0", Offset = "0x640A7C0", VA = "0x18640BBC0")]
		internal object BDAKEBBDLDP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct MLIIJBEOHHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<CFDJENKBLOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public CMAIBKDPDAF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public NBJCNPFGOOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private LKFGADKOKIH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private DKIEJLJPLED <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private CFDJENKBLOB <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter<(CFDJENKBLOB validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x640DE90", Offset = "0x640CA90", VA = "0x18640DE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x640E790", Offset = "0x640D390", VA = "0x18640E790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private PHGHPEAICAJ ODJIBPMJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private KADFEKOBGOD CLNLPCMCADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private JMALBMIKMLO DLGOAHBIFGD;

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x640EEB0", Offset = "0x640DAB0", VA = "0x18640EEB0", Slot = "5")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x640ED90", Offset = "0x640D990", VA = "0x18640ED90", Slot = "4")]
	[AsyncStateMachine(typeof(JMINFONDGJD))]
	private Task<CFDJENKBLOB> HAIDMAFPOJM(CMAIBKDPDAF PKJLAPJGLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x640EF60", Offset = "0x640DB60", VA = "0x18640EF60")]
	private bool JOOIBIPJOAO(HBBGLBIKIJH NGJFKCMINGB, [Out] CFDJENKBLOB HNCONAMCFGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x640EC50", Offset = "0x640D850", VA = "0x18640EC50")]
	[AsyncStateMachine(typeof(MLIIJBEOHHF))]
	private Task<CFDJENKBLOB> ENDDIDDKAOO(CMAIBKDPDAF NFAAJOAMBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public NBJCNPFGOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class KOGEOHJIKLF : LGKDKKBBDIJ, NEEJBNNMHIH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct CBNMBPFLADA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AsyncTaskMethodBuilder<GLELENLDELG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AKINJJFCBCP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public KOGEOHJIKLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<AADJFGNPPBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x63F8D40", Offset = "0x63F7940", VA = "0x1863F8D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x63F91F0", Offset = "0x63F7DF0", VA = "0x1863F91F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class EKKNHDDGDEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public EKKNHDDGDEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x63FF460", Offset = "0x63FE060", VA = "0x1863FF460")]
		internal object DPEDNIGIBDH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct ILDNGPIBONB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<AADJFGNPPBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public KOGEOHJIKLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AKINJJFCBCP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private EKKNHDDGDEL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<AADJFGNPPBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x64071D0", Offset = "0x6405DD0", VA = "0x1864071D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x64077C0", Offset = "0x64063C0", VA = "0x1864077C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class PGEGAJNOOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public PGEGAJNOOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x13B5920", Offset = "0x13B4520", VA = "0x1813B5920")]
		internal bool IKKFNNLPOGF(KEFAEPIPHKI sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private NCAMOCAOBKA IENMGICDHEH;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static readonly (JAJPEOHOEFN superRoomData, long subRoomDataSaveId) ICGHFOFFPNF;

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x640A4E0", Offset = "0x64090E0", VA = "0x18640A4E0", Slot = "5")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x640A550", Offset = "0x6409150", VA = "0x18640A550", Slot = "4")]
	[AsyncStateMachine(typeof(CBNMBPFLADA))]
	public Task<GLELENLDELG> LLCDCCIHHOP(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, AKINJJFCBCP FDLFBJDCFCP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x640A040", Offset = "0x6408C40", VA = "0x18640A040")]
	[AsyncStateMachine(typeof(ILDNGPIBONB))]
	private Task<AADJFGNPPBI> FOHHADCJMHM(AKINJJFCBCP FDLFBJDCFCP, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x640A6B0", Offset = "0x64092B0", VA = "0x18640A6B0")]
	private GLELENLDELG NLLFFPGCLIG(AKINJJFCBCP FDLFBJDCFCP, AADJFGNPPBI OEMMLOOCOAN, long KKFDHGLGLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x640A1A0", Offset = "0x6408DA0", VA = "0x18640A1A0")]
	private (JAJPEOHOEFN, long) GCAOCJODKCJ(AKINJJFCBCP FDLFBJDCFCP, AADJFGNPPBI OEMMLOOCOAN, long KKFDHGLGLHO)
	{
		return default((JAJPEOHOEFN, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public KOGEOHJIKLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal sealed class ECMLDCLGEEA : AFNJBPGEAGO, NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class NBMALFMDJJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CMAIBKDPDAF request;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NBMALFMDJJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x640F170", Offset = "0x640DD70", VA = "0x18640F170")]
		internal object BMFFMAPLOIN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct HPGHCCIOIAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<CMAIBKDPDAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CMAIBKDPDAF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public ECMLDCLGEEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public BGAFJPNGEOB pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<CMAIBKDPDAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x6405DC0", Offset = "0x64049C0", VA = "0x186405DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6406400", Offset = "0x6405000", VA = "0x186406400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct OKKNOGJFDIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<CMAIBKDPDAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public ECMLDCLGEEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public BGAFJPNGEOB pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<ENKAMMJKNOM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6410F70", Offset = "0x640FB70", VA = "0x186410F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x64115A0", Offset = "0x64101A0", VA = "0x1864115A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class MFDCFOMJHMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public CMAIBKDPDAF request;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public MFDCFOMJHMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x640DDD0", Offset = "0x640C9D0", VA = "0x18640DDD0")]
		internal object JPFMAPEONNL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct ANKICPELMCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<CMAIBKDPDAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public CMAIBKDPDAF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public ECMLDCLGEEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public BGAFJPNGEOB pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private KBGLOHDDINE <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private DOBOGHKHHKP <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<ENKAMMJKNOM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x63F4770", Offset = "0x63F3370", VA = "0x1863F4770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x63F5390", Offset = "0x63F3F90", VA = "0x1863F5390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private PHGHPEAICAJ ODJIBPMJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private LAANEOACBLL HCODLMAJOPB;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private NKGBBEDNKNJ CBIDBFJKGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x63FE830", Offset = "0x63FD430", VA = "0x1863FE830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x63FE7A0", Offset = "0x63FD3A0", VA = "0x1863FE7A0", Slot = "8")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x63FE2F0", Offset = "0x63FCEF0", VA = "0x1863FE2F0", Slot = "4")]
	[AsyncStateMachine(typeof(HPGHCCIOIAN))]
	public Task<CMAIBKDPDAF> DJPEILHACDF(CMAIBKDPDAF NFAAJOAMBMN, BGAFJPNGEOB GFACAJKPEOL, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x63FE450", Offset = "0x63FD050", VA = "0x1863FE450", Slot = "5")]
	[AsyncStateMachine(typeof(OKKNOGJFDIN))]
	public Task<CMAIBKDPDAF> IIGPOOIIFNE(CancellationToken BJFJMBIBKLL, BGAFJPNGEOB GFACAJKPEOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x63FE590", Offset = "0x63FD190", VA = "0x1863FE590", Slot = "6")]
	public LNOKCMEODGP IPHPAECECNI(OAMCKBCGEGJ EHOADMBDJGP, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x63FE8F0", Offset = "0x63FD4F0", VA = "0x1863FE8F0", Slot = "7")]
	public LNOKCMEODGP OMHPMHFEFBO(OAMCKBCGEGJ EHOADMBDJGP, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x63FEB20", Offset = "0x63FD720", VA = "0x1863FEB20")]
	[AsyncStateMachine(typeof(ANKICPELMCL))]
	private Task<CMAIBKDPDAF> PDACJIFALNI(CMAIBKDPDAF NFAAJOAMBMN, BGAFJPNGEOB GFACAJKPEOL, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x257AC60", Offset = "0x2579860", VA = "0x18257AC60")]
	private static byte[] KCDMBIBEDDD(CMAIBKDPDAF EOOPGFAEMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public ECMLDCLGEEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[UnityEngine.Scripting.Preserve]
internal sealed class PHAIGLNFFJG : KADFEKOBGOD, NEEJBNNMHIH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private PMMKMMJFNCL AAKLPMINFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private PHGHPEAICAJ ODJIBPMJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private EAKEBPLDJAI HONKHCHECDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private AKLCAPLPHFH FGMDMGPCDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private NCAMOCAOBKA IENMGICDHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private INBIBLHOABC CPEPBKLPAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private COHMJPPIAJC LIEHINIKINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private NHHPOOJPBND DIIHIAJGIIB;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private KABLCFJOKIG HPNOJDJMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6412BB0", Offset = "0x64117B0", VA = "0x186412BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private static CFDJENKBLOB LLJMGIPBDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6410BB0", Offset = "0x640F7B0", VA = "0x186410BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6412C00", Offset = "0x6411800", VA = "0x186412C00", Slot = "6")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6412740", Offset = "0x6411340", VA = "0x186412740", Slot = "4")]
	public CFDJENKBLOB AGCKAGFOFLC(ILLMBLKEFFI KGOGDJKOABA, HBBGLBIKIJH FHHBHJGIJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x64128B0", Offset = "0x64114B0", VA = "0x1864128B0", Slot = "5")]
	public CFDJENKBLOB IBGNIMJPHHG(ILLMBLKEFFI KCGDCNCMLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6410B50", Offset = "0x640F750", VA = "0x186410B50")]
	private static CFDJENKBLOB GMOOGBOCABB(FPHFGPNODIH OKDGKAJLADI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public PHAIGLNFFJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class PMFBLKPECNG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6412D70", Offset = "0x6411970", VA = "0x186412D70")]
	public PMFBLKPECNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5A0A1A0", Offset = "0x5A08DA0", VA = "0x185A0A1A0")]
	public PMFBLKPECNG(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class PFGMDCDJJCH : GBDJOOFGMBJ, NEEJBNNMHIH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct JKMJPEMCCBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AsyncTaskMethodBuilder<CFDJENKBLOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public PFGMDCDJJCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public IBADDLHMPKI autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private FIKFBEICCGA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private BHDCJHOMFLB <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<CFDJENKBLOB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x6408410", Offset = "0x6407010", VA = "0x186408410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x6408FA0", Offset = "0x6407BA0", VA = "0x186408FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct FKPPDKFFKNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public PFGMDCDJJCH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6404170", Offset = "0x6402D70", VA = "0x186404170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x64048C0", Offset = "0x64034C0", VA = "0x1864048C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct CIFKMDNFBBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public PFGMDCDJJCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x63FB930", Offset = "0x63FA530", VA = "0x1863FB930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x63FBE40", Offset = "0x63FAA40", VA = "0x1863FBE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct AOBEKCHANOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public PFGMDCDJJCH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x63F5D70", Offset = "0x63F4970", VA = "0x1863F5D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x63F64C0", Offset = "0x63F50C0", VA = "0x1863F64C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct CFDAHEJFEBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public PFGMDCDJJCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x63F9400", Offset = "0x63F8000", VA = "0x1863F9400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x63F95A0", Offset = "0x63F81A0", VA = "0x1863F95A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct EDBKDKBCPIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public PFGMDCDJJCH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x63FEC80", Offset = "0x63FD880", VA = "0x1863FEC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x63FF3A0", Offset = "0x63FDFA0", VA = "0x1863FF3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct OBGFICHEDCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public PFGMDCDJJCH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6410420", Offset = "0x640F020", VA = "0x186410420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6410890", Offset = "0x640F490", VA = "0x186410890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct GIGHACIBMNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public PFGMDCDJJCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public EMCJOAAJBFJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private FIKFBEICCGA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x6404CA0", Offset = "0x64038A0", VA = "0x186404CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x64051E0", Offset = "0x6403DE0", VA = "0x1864051E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private PHGHPEAICAJ ODJIBPMJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private NCAMOCAOBKA IENMGICDHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private AFNJBPGEAGO CLFOBBFAFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private EAKEBPLDJAI HONKHCHECDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private COHMJPPIAJC LIEHINIKINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private CancellationTokenSource AIGMDJCDFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private Task JEFAGEMLHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private TaskCompletionSource<int> JIBDBGLAHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private int IAAFCPDPHBN;

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6411E10", Offset = "0x6410A10", VA = "0x186411E10", Slot = "6")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x85BB60", Offset = "0x85A760", VA = "0x18085BB60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6412570", Offset = "0x6411170", VA = "0x186412570")]
	private void OFNDLHGDGLA(float MKLPOCCMLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x64121B0", Offset = "0x6410DB0", VA = "0x1864121B0", Slot = "4")]
	[AsyncStateMachine(typeof(JKMJPEMCCBP))]
	public Task<CFDJENKBLOB> OCFBLOMAEPF(IBADDLHMPKI EBGOHPNLCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6412650", Offset = "0x6411250", VA = "0x186412650", Slot = "5")]
	[AsyncStateMachine(typeof(FKPPDKFFKNB))]
	public Task PGKOCODGGDN([Optional] CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x85BB60", Offset = "0x85A760", VA = "0x18085BB60")]
	public void JJPJFGJBEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x64117A0", Offset = "0x64103A0", VA = "0x1864117A0")]
	private BHDCJHOMFLB BLFMJHADCCA(IBADDLHMPKI EBGOHPNLCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6411A10", Offset = "0x6410610", VA = "0x186411A10")]
	[AsyncStateMachine(typeof(CIFKMDNFBBH))]
	private Task CCIKKPPLLAM(HNHIPMBANEH IKFHEHLCJCA, CancellationToken BINKOPDIFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6411910", Offset = "0x6410510", VA = "0x186411910")]
	[AsyncStateMachine(typeof(AOBEKCHANOM))]
	private Task BLIFIBGHDIO(CancellationToken BINKOPDIFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x6411FC0", Offset = "0x6410BC0", VA = "0x186411FC0")]
	[AsyncStateMachine(typeof(CFDAHEJFEBK))]
	private Task LLAFMOLDGPK([Optional] CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x6411B00", Offset = "0x6410700", VA = "0x186411B00")]
	[AsyncStateMachine(typeof(EDBKDKBCPIA))]
	private Task EHJAHOCANMM(CancellationToken BINKOPDIFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x64120B0", Offset = "0x6410CB0", VA = "0x1864120B0")]
	[AsyncStateMachine(typeof(OBGFICHEDCK))]
	private Task NJDKIIODECO(CancellationToken NNKIAOJAIPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x64122E0", Offset = "0x6410EE0", VA = "0x1864122E0")]
	private Task OEKMEDPDBKM(EMCJOAAJBFJ NPEKECDFDBG, CancellationToken BINKOPDIFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x6411D00", Offset = "0x6410900", VA = "0x186411D00")]
	[AsyncStateMachine(typeof(GIGHACIBMNC))]
	private Task GCODDNAAPOJ(EMCJOAAJBFJ NPEKECDFDBG, CancellationToken BINKOPDIFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6411BF0", Offset = "0x64107F0", VA = "0x186411BF0")]
	private bool FMBEJDIANFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public PFGMDCDJJCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[UnityEngine.Scripting.Preserve]
internal class PMPJLMJAIAH : AKLCAPLPHFH, NEEJBNNMHIH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct LPEIGFJHDMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public PMPJLMJAIAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private FIKFBEICCGA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x640D7B0", Offset = "0x640C3B0", VA = "0x18640D7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x640DD10", Offset = "0x640C910", VA = "0x18640DD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private PDEGCLAEOLH CCLDCHEMEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private KADFEKOBGOD CLNLPCMCADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private AFNJBPGEAGO CLFOBBFAFLP;

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6412F60", Offset = "0x6411B60", VA = "0x186412F60", Slot = "6")]
	public void JMCKLNABHHJ(AEIFCCFGGHA PELKFGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6412DB0", Offset = "0x64119B0", VA = "0x186412DB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6412E00", Offset = "0x6411A00", VA = "0x186412E00", Slot = "5")]
	[AsyncStateMachine(typeof(LPEIGFJHDMN))]
	public Task EHBKFKKKJOD(string ELOBOAALAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x6412F00", Offset = "0x6411B00", VA = "0x186412F00", Slot = "4")]
	public CFDJENKBLOB FMBEJDIANFC(ILLMBLKEFFI KGOGDJKOABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6413240", Offset = "0x6411E40", VA = "0x186413240")]
	private JPKFKCFHJGM MKHDHBLHKGF(string ELOBOAALAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public PMPJLMJAIAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class DBHGFAONEIO
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x63FBF10", Offset = "0x63FAB10", VA = "0x1863FBF10")]
	public static void EPICJBMEDLB(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x63FC1F0", Offset = "0x63FADF0", VA = "0x1863FC1F0")]
	internal static void MJBEGODOFGK(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x63FC110", Offset = "0x63FAD10", VA = "0x1863FC110")]
	internal static void FHEFGEKGPPE(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x63FC310", Offset = "0x63FAF10", VA = "0x1863FC310")]
	internal static void OACIALFLEDK(OKOCNPPIKGG PCOJMOHPOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal class KJDLAMLAJHO : CHFDDDCIAML<CMAIBKDPDAF>
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class HHKMHGFFBDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public CMAIBKDPDAF message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public HHKMHGFFBDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6405A10", Offset = "0x6404610", VA = "0x186405A10")]
		internal object GMOINECJOAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly KJDLAMLAJHO IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x6409E70", Offset = "0x6408A70", VA = "0x186409E70")]
	public ExitGames.Client.Photon.Hashtable OIIEHDKDHEB(CMAIBKDPDAF EOOPGFAEMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6409760", Offset = "0x6408360", VA = "0x186409760", Slot = "5")]
	protected override void GKEMMABMEGA(CMAIBKDPDAF EOOPGFAEMIH, IDictionary<object, object> IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6409890", Offset = "0x6408490", VA = "0x186409890", Slot = "6")]
	public override CMAIBKDPDAF JFKFFNFOIMD(IDictionary<object, object> IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6409AC0", Offset = "0x64086C0", VA = "0x186409AC0")]
	private static void JJBLJPHBGMP(string KBNGEMBLNKH, CMAIBKDPDAF EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6409FA0", Offset = "0x6408BA0", VA = "0x186409FA0")]
	public KJDLAMLAJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6409BD0", Offset = "0x64087D0", VA = "0x186409BD0")]
	[CompilerGenerated]
	internal static string NMJLOANFKAJ(GLELENLDELG AGEBEEELPDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class OBIJBNFLEDH
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public static CFDJENKBLOB LLJMGIPBDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x6410BB0", Offset = "0x640F7B0", VA = "0x186410BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6410C10", Offset = "0x640F810", VA = "0x186410C10")]
	public static bool LOGJCILIGBI(this CFDJENKBLOB EKDKEAOJBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6410B50", Offset = "0x640F750", VA = "0x186410B50")]
	public static CFDJENKBLOB GMOOGBOCABB(FPHFGPNODIH DCEDLBDLEIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6410C30", Offset = "0x640F830", VA = "0x186410C30")]
	public static CFDJENKBLOB NMEMPDDMBGF(IEnumerable<CFDJENKBLOB> FJIDBCIHFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x64108F0", Offset = "0x640F4F0", VA = "0x1864108F0")]
	public static string BEKEFFDEJKI(this CFDJENKBLOB HNCONAMCFGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class JBLIJLIIIAL : IKNDLDFIGAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public delegate CFDJENKBLOB IKPDJGFJNJM([NotNull] ILLMBLKEFFI OBIANPHDMKB);

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class IOHGGHECOCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public ILLMBLKEFFI photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public IOHGGHECOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA140", Offset = "0x5BE8D40", VA = "0x185BEA140")]
		internal CFDJENKBLOB PKAJNCIOKNN(IKPDJGFJNJM v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private bool MFJFBBMDDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	protected readonly HashSet<IKPDJGFJNJM> PEMIPOPHIEB;

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6407FD0", Offset = "0x6406BD0", VA = "0x186407FD0", Slot = "4")]
	public void COOIFDLOKAB(IKPDJGFJNJM JHCDDLIKOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6408320", Offset = "0x6406F20", VA = "0x186408320", Slot = "5")]
	public void PDPOAOODFJB(IKPDJGFJNJM JHCDDLIKOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6408030", Offset = "0x6406C30", VA = "0x186408030", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6408080", Offset = "0x6406C80", VA = "0x186408080")]
	protected CFDJENKBLOB LAPAGEAENPP(ILLMBLKEFFI KCGDCNCMLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6408380", Offset = "0x6406F80", VA = "0x186408380")]
	protected JBLIJLIIIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class MOOALMNJOJD : JBLIJLIIIAL, PMMKMMJFNCL, IKNDLDFIGAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class EEGEAFLFLAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public CFDJENKBLOB result;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public EEGEAFLFLAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x63FF400", Offset = "0x63FE000", VA = "0x1863FF400")]
		internal object OMMIDEPJPOD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x640E910", Offset = "0x640D510", VA = "0x18640E910")]
	[UnityEngine.Scripting.Preserve]
	public MOOALMNJOJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x640E800", Offset = "0x640D400", VA = "0x18640E800", Slot = "8")]
	public CFDJENKBLOB KKBLNHFHGIF(ILLMBLKEFFI KCGDCNCMLEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class OIOBNIAIAOI : JBLIJLIIIAL, PDEGCLAEOLH, IKNDLDFIGAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class DEHFNHKLCLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public CFDJENKBLOB result;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public DEHFNHKLCLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x63FC760", Offset = "0x63FB360", VA = "0x1863FC760")]
		internal object OMBHCGFPCHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x640E910", Offset = "0x640D510", VA = "0x18640E910")]
	[UnityEngine.Scripting.Preserve]
	public OIOBNIAIAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6410E30", Offset = "0x640FA30", VA = "0x186410E30", Slot = "8")]
	public CFDJENKBLOB FMBEJDIANFC(ILLMBLKEFFI NBMIOHDEJJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal static class GLDHAJKIHPO
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class CCCFDGHCFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public FIKFBEICCGA<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public CCCFDGHCFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x63F9260", Offset = "0x63F7E60", VA = "0x1863F9260")]
		internal object NFPBDIJBJDK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6405730", Offset = "0x6404330", VA = "0x186405730")]
	public static FIKFBEICCGA<string> IPKDALIACFC(ELHKCOAEACJ CABFMJIIGKB, [Optional] string KEFPHPMAIEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6405670", Offset = "0x6404270", VA = "0x186405670")]
	public static void IFEIHAOOBEB(FIKFBEICCGA<string> AEIJEHEMJFD, ELHKCOAEACJ CABFMJIIGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6405810", Offset = "0x6404410", VA = "0x186405810")]
	public static string JPJJKJKJAAK(CMAIBKDPDAF PKJLAPJGLHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal static class GNGKHBLLEJD
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6405A00", Offset = "0x6404600", VA = "0x186405A00")]
	public static void NLCCKEPPKAF(this PHGHPEAICAJ ODJIBPMJHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x64058D0", Offset = "0x64044D0", VA = "0x1864058D0")]
	public static void CBMHCBPJAGD(this PHGHPEAICAJ ODJIBPMJHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x64058E0", Offset = "0x64044E0", VA = "0x1864058E0")]
	private static void IEBPPKNHPFJ(this PHGHPEAICAJ ODJIBPMJHOC, bool IAIANEFGMPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class FDNANHIDDKN : IKLBHHDIJPA, EOLKEFJPLPJ, BGIOCIOCADB, AIILOBJJNNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private readonly EOLKEFJPLPJ KIKGGGMOCHF;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ILLMBLKEFFI DDNMCBMEAML
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x64026F0", Offset = "0x64012F0", VA = "0x1864026F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int AMMEBMOLJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x6402470", Offset = "0x6401070", VA = "0x186402470", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int IEJCFIJFPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x6402990", Offset = "0x6401590", VA = "0x186402990", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool BDGMFONPAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x78C390", Offset = "0x78AF90", VA = "0x18078C390", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int HNIDGGFFACC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x866C40", Offset = "0x865840", VA = "0x180866C40", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GFGOKJGFKNB.LBAPCKNAEGH BKJPJOHFAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event KBAOIMPCIPA KJFNDAOFJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x64024C0", Offset = "0x64010C0", VA = "0x1864024C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x64028A0", Offset = "0x64014A0", VA = "0x1864028A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> OFCEJMOFHFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<ILLMBLKEFFI> NIMMCHDBEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action KIFDHELMKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x6402760", Offset = "0x6401360", VA = "0x186402760", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x6402800", Offset = "0x6401400", VA = "0x186402800", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0xC880F0", Offset = "0xC86CF0", VA = "0x180C880F0")]
	public FDNANHIDDKN(EOLKEFJPLPJ KIKGGGMOCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6402640", Offset = "0x6401240", VA = "0x186402640", Slot = "8")]
	public bool EMFEDFPNOBH(byte LBOCMPDCIBH, ExitGames.Client.Photon.Hashtable EGNAICHPCMN, DCLDNGHLDHI KFFEMCCNCIP, SendOptions OIAPLJECJII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6402560", Offset = "0x6401160", VA = "0x186402560", Slot = "16")]
	public ILLMBLKEFFI DJEPCGOENFF(int GJONMFDAEHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "19")]
	public void FPIODHEIBKI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "20")]
	public void ELGDMGMCKPN(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "21")]
	public void HNGMKLOJJHK(object KJCAGLABEME, bool ICDAOHGNDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6402940", Offset = "0x6401540", VA = "0x186402940", Slot = "22")]
	public IDisposable LKOJIGIDBEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "23")]
	private bool CCBDFHHKJDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "24")]
	public void KIIMAEKKOHE(StringBuilder COMKMCNLPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6402740", Offset = "0x6401340", VA = "0x186402740", Slot = "25")]
	public bool IAJOCIDEMNP(bool JPBGPOKLJDG, [Out] string GNLAGDDNMDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xB5FF80", Offset = "0xB5EB80", VA = "0x180B5FF80", Slot = "28")]
	public void NEBHAHMAHJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal struct KPOJFMMLMOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private readonly IDictionary<object, object> DCCNFPKPNFP;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x8739C0", Offset = "0x8725C0", VA = "0x1808739C0")]
	public KPOJFMMLMOB(IDictionary<object, object> DCCNFPKPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x640BA10", Offset = "0x640A610", VA = "0x18640BA10")]
	public bool PEOCMGHHDAK([Out] CMAIBKDPDAF EOOPGFAEMIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x640B730", Offset = "0x640A330", VA = "0x18640B730")]
	public Guid HMKNBCOAACO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x640B7E0", Offset = "0x640A3E0", VA = "0x18640B7E0")]
	public CFDJENKBLOB OLDPHAJGDOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x640B920", Offset = "0x640A520", VA = "0x18640B920")]
	public static ExitGames.Client.Photon.Hashtable PAKONFKLIMF(CMAIBKDPDAF EOOPGFAEMIH, CFDJENKBLOB EKDKEAOJBNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class NGIEHFDBEAM
{
	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x640F1D0", Offset = "0x640DDD0", VA = "0x18640F1D0")]
	public static bool IBFCMFGPMGK(this AKINJJFCBCP MPHHOJINAPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal struct NALKDPIOKEG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct DKAANBGAOLL : IAsyncStateMachine
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
		public NALKDPIOKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x63FCCC0", Offset = "0x63FB8C0", VA = "0x1863FCCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x63FCEA0", Offset = "0x63FBAA0", VA = "0x1863FCEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly CancellationTokenSource OEDMIHFDIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private bool MFJFBBMDDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private Task IMKPJBJJCAM;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool LNBKOGHJAFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x640EA80", Offset = "0x640D680", VA = "0x18640EA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x640EAB0", Offset = "0x640D6B0", VA = "0x18640EAB0")]
	public NALKDPIOKEG(CancellationToken BJFJMBIBKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x640E920", Offset = "0x640D520", VA = "0x18640E920")]
	[AsyncStateMachine(typeof(DKAANBGAOLL))]
	public Task ALNDCEPDEOD(Func<CancellationToken, List<Task>> LAOFJMLNPOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x640EA30", Offset = "0x640D630", VA = "0x18640EA30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public readonly struct NEAPFKMFNCB<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct DGECJAKJMFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder<MEPDFJNPAPE<IICMDAPPGCC<TData>, LGEMOLNFJEJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NEAPFKMFNCB<TGetDataArg, TData> <>4__this;

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
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private TaskAwaiter<MEPDFJNPAPE<byte[], LGEMOLNFJEJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x4E39D10", Offset = "0x4E38910", VA = "0x184E39D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x4E3AE60", Offset = "0x4E39A60", VA = "0x184E3AE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly GCKAFHKMFOP<TGetDataArg, TData> JDKBNPIOBLG;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x8739C0", Offset = "0x8725C0", VA = "0x1808739C0")]
	internal NEAPFKMFNCB(GCKAFHKMFOP<TGetDataArg, TData> BKGJDHEGAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x3CFEAF0", Offset = "0x3CFD6F0", VA = "0x183CFEAF0")]
	[AsyncStateMachine(typeof(NEAPFKMFNCB<, >.DGECJAKJMFL))]
	public Task<MEPDFJNPAPE<IICMDAPPGCC<TData>, LGEMOLNFJEJ>> DNCCBFCNCJF(TGetDataArg NGMDGDAKJOP, string OCNDIAJBCKE, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class OHFPJPHPENP
{
	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2109C20", Offset = "0x2108820", VA = "0x182109C20")]
	public static NEAPFKMFNCB<TGetDataArg, TData> OOMHMBNJBCG<TGetDataArg, TData>(GCKAFHKMFOP<TGetDataArg, TData> BKGJDHEGAMG)
	{
		return default(NEAPFKMFNCB<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct EOPOKBEAANJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public readonly int OHAMAJJBOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public readonly int? AEDENJEONGA;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A23950", Offset = "0x3A22550", VA = "0x183A23950")]
	public EOPOKBEAANJ(int KCDGADOLLBP, [Optional] int? IIOEFJPJPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6400C50", Offset = "0x63FF850", VA = "0x186400C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface HPBJHODKDAN<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCBLMICFAHH();

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HPBJHODKDAN<T> ONAAOPPBCCG(string IOABPCNNHKK);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HPBJHODKDAN<T> PNDBANBINOM(APDMBKJIGBC<T> MIDDMKEHJHG);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HPBJHODKDAN<T> OEALEDPDHMA(int CDPNJMLAOAG);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HPBJHODKDAN<T> GBDCHGFCOGG(int CDPNJMLAOAG, DKFDKKHPLHF<T> IKPEHLIMAAC);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface MOJLHPBCMAL
{
	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPBJHODKDAN<T> CPMMKDCGLGH<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JBEJIOLBCPF BNIFIOBIPBF(Exception GDDKLHPPIHO);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EOPOKBEAANJ OOGPCJIOELD(Exception GDDKLHPPIHO);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public delegate string APDMBKJIGBC<in T>(T GDDKLHPPIHO) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate int DKFDKKHPLHF<in T>(T GDDKLHPPIHO) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class FBINGFGLKGB : MOJLHPBCMAL
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private delegate string JBFAPENCJGN(Exception GDDKLHPPIHO);

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate int LHKEIEOCFJJ(Exception GDDKLHPPIHO);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private class GJLLBKOLPEM<T> : HPBJHODKDAN<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class KAJLFDOIIBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public KAJLFDOIIBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
			internal string GKBFKMKDLPK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class AHAFDHBNHAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public APDMBKJIGBC<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public AHAFDHBNHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x35F42A0", Offset = "0x35F2EA0", VA = "0x1835F42A0")]
			internal string CMIKHJOAKBN(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class LAOEGDEKKDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public DKFDKKHPLHF<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public LAOEGDEKKDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x35F42A0", Offset = "0x35F2EA0", VA = "0x1835F42A0")]
			internal int FAJHOOCPEEF(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly FBINGFGLKGB HBAAFBIBJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private readonly Type KDHCJNDPIJC;

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x35C7260", Offset = "0x35C5E60", VA = "0x1835C7260")]
		internal GJLLBKOLPEM(FBINGFGLKGB HBAAFBIBJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x35C6FD0", Offset = "0x35C5BD0", VA = "0x1835C6FD0", Slot = "4")]
		public void NCBLMICFAHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x35C7040", Offset = "0x35C5C40", VA = "0x1835C7040", Slot = "5")]
		public HPBJHODKDAN<T> ONAAOPPBCCG(string IOABPCNNHKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x35C7150", Offset = "0x35C5D50", VA = "0x1835C7150", Slot = "6")]
		public HPBJHODKDAN<T> PNDBANBINOM(APDMBKJIGBC<T> MIDDMKEHJHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x35C7000", Offset = "0x35C5C00", VA = "0x1835C7000", Slot = "7")]
		public HPBJHODKDAN<T> OEALEDPDHMA(int CDPNJMLAOAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x35C6EB0", Offset = "0x35C5AB0", VA = "0x1835C6EB0", Slot = "8")]
		public HPBJHODKDAN<T> GBDCHGFCOGG(int CDPNJMLAOAG, DKFDKKHPLHF<T> IKPEHLIMAAC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class AEHFHIHKABE<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private bool KIJNHMNGBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private readonly List<Type> DGECEDEAFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private readonly Dictionary<Type, TVal> BOCPDCCFDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly Dictionary<Type, int> MEJPBCAPKED;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public IReadOnlyList<Type> GMKLBIDKJEH
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x35698B0", Offset = "0x35684B0", VA = "0x1835698B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x3569DC0", Offset = "0x35689C0", VA = "0x183569DC0")]
		public AEHFHIHKABE(Dictionary<Type, int> MEJPBCAPKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x3569AB0", Offset = "0x35686B0", VA = "0x183569AB0")]
		public void HFMDKEOMMOI(Type PPNDANAOAMK, TVal FEGNLFKFNHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3568870", VA = "0x183569C70")]
		public bool KKFBEIKGEPJ(Type KDHCJNDPIJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x3569BF0", Offset = "0x35687F0", VA = "0x183569BF0")]
		public bool IJIBFNDEOAJ(TVal GCPEEAODAIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x3569C30", Offset = "0x3568830", VA = "0x183569C30")]
		public TVal IOOJPMIEEDI(Type OMKEAAPIABA)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3569970", Offset = "0x3568570", VA = "0x183569970")]
		[CompilerGenerated]
		private int FILJOJDABLC(Type OFPFKBHNHJD, Type OEPIMJLDIKD)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class IDFMDMOABLP : IEnumerable<EOPOKBEAANJ>, IEnumerable, IEnumerator<EOPOKBEAANJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private EOPOKBEAANJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public FBINGFGLKGB <>4__this;

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
		private IEnumerator<EOPOKBEAANJ> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private EOPOKBEAANJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x3156210", Offset = "0x3154E10", VA = "0x183156210", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(EOPOKBEAANJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x6406AD0", Offset = "0x64056D0", VA = "0x186406AD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x8ECE30", Offset = "0x8EBA30", VA = "0x1808ECE30")]
		[DebuggerHidden]
		public IDFMDMOABLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x6406B20", Offset = "0x6405720", VA = "0x186406B20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x6406510", Offset = "0x6405110", VA = "0x186406510", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x64064C0", Offset = "0x64050C0", VA = "0x1864064C0")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6406470", Offset = "0x6405070", VA = "0x186406470")]
		private void HAIPFOFCHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6406A80", Offset = "0x6405680", VA = "0x186406A80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x64069C0", Offset = "0x64055C0", VA = "0x1864069C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EOPOKBEAANJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x64069C0", Offset = "0x64055C0", VA = "0x1864069C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private static readonly EOPOKBEAANJ IIAIDLBOKLA;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private static readonly Dictionary<Type, int> GFCNEHCIMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private readonly HashSet<Type> ILCDJBCCODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private readonly AEHFHIHKABE<int> PNBHGKFKMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly AEHFHIHKABE<LHKEIEOCFJJ> EDPEECAFBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly AEHFHIHKABE<JBFAPENCJGN> BAJBDOFDGHO;

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6401890", Offset = "0x6400490", VA = "0x186401890")]
	[GFMBCOBENIN(CDPNEOMLNDL.GameOnly)]
	private static void JKFPJJDDAIM(OKOCNPPIKGG JGGJFGBKEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x6402130", Offset = "0x6400D30", VA = "0x186402130")]
	[RecRoom.NoEngine.Common.Preserve]
	public FBINGFGLKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x24DAED0", Offset = "0x24D9AD0", VA = "0x1824DAED0", Slot = "4")]
	public HPBJHODKDAN<T> CPMMKDCGLGH<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6401260", Offset = "0x63FFE60", VA = "0x186401260", Slot = "5")]
	public JBEJIOLBCPF BNIFIOBIPBF(Exception GDDKLHPPIHO)
	{
		return default(JBEJIOLBCPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6401E60", Offset = "0x6400A60", VA = "0x186401E60", Slot = "6")]
	public EOPOKBEAANJ OOGPCJIOELD(Exception? GDDKLHPPIHO)
	{
		return default(EOPOKBEAANJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x64012F0", Offset = "0x63FFEF0", VA = "0x1864012F0", Slot = "7")]
	[IteratorStateMachine(typeof(IDFMDMOABLP))]
	public IEnumerable<EOPOKBEAANJ> BOOFLJJBJHL(Exception GDDKLHPPIHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x6401740", Offset = "0x6400340", VA = "0x186401740", Slot = "8")]
	public string HIMGEMADDLB(Exception? GDDKLHPPIHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6401900", Offset = "0x6400500", VA = "0x186401900")]
	private string MGCFBPCKPJE(AggregateException BJIEGFPNIKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x6400EB0", Offset = "0x63FFAB0", VA = "0x186400EB0")]
	private void BDHNINGNNBP(Type KDHCJNDPIJC, int CDPNJMLAOAG, LHKEIEOCFJJ? CBKMCBECIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x6401C10", Offset = "0x6400810", VA = "0x186401C10")]
	private void NCOHLPMMMFC(Type KDHCJNDPIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x6401390", Offset = "0x63FFF90", VA = "0x186401390")]
	private void GCAKMGADHPB(Type KDHCJNDPIJC, JBFAPENCJGN LGBIKIGOLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x6400D30", Offset = "0x63FF930", VA = "0x186400D30")]
	private static int AHAECHIIFPH(Type KDHCJNDPIJC, Dictionary<Type, int> MEJPBCAPKED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x24DAF40", Offset = "0x24D9B40", VA = "0x1824DAF40")]
	private static bool IPICBFGMMIK<TVal>(AEHFHIHKABE<TVal> HJEFNDCLEGO, Type KDHCJNDPIJC, [Out] TVal GCPEEAODAIB) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6401660", Offset = "0x6400260", VA = "0x186401660")]
	[CompilerGenerated]
	internal static int GPGEOHPAPAA(Type IBMBLNAFPPH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct JBEJIOLBCPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public readonly EOPOKBEAANJ CHFGEOJMKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public readonly string CILAFPHCOEO;

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x6407FB0", Offset = "0x6406BB0", VA = "0x186407FB0")]
	public JBEJIOLBCPF(string KOFNCIPHDMB, EOPOKBEAANJ CDPNJMLAOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x6407F10", Offset = "0x6406B10", VA = "0x186407F10")]
	public string KKADPBDOPOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class KPDIBHHHMEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly ECKJGDJNJNM NCADAAIFLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private string AAFHNNNIKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private long? FAHGEFLDCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private long? ELLJNGJFHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? DDAFNLJAJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private string HFNGFPDFLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private EDAJJABLLFB MAHOOAPGNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private long? BHDEHEKHFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private bool HNCFDCDNALK;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public string BLDKLKMLCPI
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public long BNFGENICMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x640B5D0", Offset = "0x640A1D0", VA = "0x18640B5D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public long EGKHJINOFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x640B630", Offset = "0x640A230", VA = "0x18640B630")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public long BFCAAHIMBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x640ACC0", Offset = "0x64098C0", VA = "0x18640ACC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string AKELAIBDCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x640AE10", Offset = "0x6409A10", VA = "0x18640AE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public EDAJJABLLFB ALFJHPBJAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xCD88D0", Offset = "0xCD74D0", VA = "0x180CD88D0")]
		get
		{
			return default(EDAJJABLLFB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x640AD20", Offset = "0x6409920", VA = "0x18640AD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long MGBKMADPBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x640B690", Offset = "0x640A290", VA = "0x18640B690")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x640B6F0", Offset = "0x640A2F0", VA = "0x18640B6F0")]
	[UnityEngine.Scripting.Preserve]
	public KPDIBHHHMEH([DLBAGNNJKKK(null)] ECKJGDJNJNM NCADAAIFLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x640AE50", Offset = "0x6409A50", VA = "0x18640AE50")]
	private void IBEGACMIJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x640B140", Offset = "0x6409D40", VA = "0x18640B140")]
	public void NKDGHANBMMI(long BPJLDBDKBIJ, long KKFDHGLGLHO, [Optional] long? IMBBOEGNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x640B0A0", Offset = "0x6409CA0", VA = "0x18640B0A0")]
	public void MJHOACNAPMO(long IMBBOEGNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x640A8C0", Offset = "0x64094C0", VA = "0x18640A8C0")]
	public void CJGPBACKEED(string JMAAAPLFOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x640A940", Offset = "0x6409540", VA = "0x18640A940")]
	public void DIELNAJDAPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class LNOKCMEODGP : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct AOBIKMEJJKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public AsyncTaskMethodBuilder<CMAIBKDPDAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public CMAIBKDPDAF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public LNOKCMEODGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private TaskAwaiter<NKGBBEDNKNJ.LNDKDOACHII<CMAIBKDPDAF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x63F6520", Offset = "0x63F5120", VA = "0x1863F6520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x63F6A50", Offset = "0x63F5650", VA = "0x1863F6A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct CMMKEOCHOAC<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class IKJCKNNFGCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public CMAIBKDPDAF roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public IKJCKNNFGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x64070F0", Offset = "0x6405CF0", VA = "0x1864070F0")]
		internal CMAIBKDPDAF GAAAEOOAPAA(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct ENPIGGLCNMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public AsyncTaskMethodBuilder<NKGBBEDNKNJ.LNDKDOACHII<CMAIBKDPDAF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public CMAIBKDPDAF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public LNOKCMEODGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private KBGLOHDDINE <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private TaskAwaiter<NKGBBEDNKNJ.LNDKDOACHII<CMAIBKDPDAF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x6400570", Offset = "0x63FF170", VA = "0x186400570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x6400B80", Offset = "0x63FF780", VA = "0x186400B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct DICEJBNNKJO<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public LNOKCMEODGP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4E46440", Offset = "0x4E45040", VA = "0x184E46440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x35B3740", Offset = "0x35B2340", VA = "0x1835B3740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct CFNHHOMMKPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public LNOKCMEODGP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x63FB710", Offset = "0x63FA310", VA = "0x1863FB710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x63FB8D0", Offset = "0x63FA4D0", VA = "0x1863FB8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class CDHLKDIDGMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public CDHLKDIDGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x63F92E0", Offset = "0x63F7EE0", VA = "0x1863F92E0")]
		internal object CPPPDOMNMDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x63F9340", Offset = "0x63F7F40", VA = "0x1863F9340")]
		internal bool FONPJANCOJH(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class BPDNNHLFHNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public BPDNNHLFHNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x63F8C70", Offset = "0x63F7870", VA = "0x1863F8C70")]
		internal object MGPFFGGGBOE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class DALKCLDBEKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public DALKCLDBEKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x63FBEA0", Offset = "0x63FAAA0", VA = "0x1863FBEA0")]
		internal object GFKPOKIMHHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class NBIJGIGGNDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NBIJGIGGNDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x640EBE0", Offset = "0x640D7E0", VA = "0x18640EBE0")]
		internal object ECJBKINMIBE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class FJHEGEALNPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public LNOKCMEODGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public FJHEGEALNPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x6403F30", Offset = "0x6402B30", VA = "0x186403F30")]
		internal object GMOINECJOAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private static readonly Guid BMBJCJEOGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public readonly OAMCKBCGEGJ BBPMINEPECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private readonly NKGBBEDNKNJ OCDPPDEBEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly BGIOCIOCADB ODJIBPMJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly AIILOBJJNNM OEHGNBNIEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private bool NKKDKENOKBO;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x640CDE0", Offset = "0x640B9E0", VA = "0x18640CDE0")]
	public LNOKCMEODGP(OAMCKBCGEGJ IIPOKLFKMOK, NKGBBEDNKNJ OCDPPDEBEPG, BGIOCIOCADB ODJIBPMJHOC, AIILOBJJNNM OEHGNBNIEOO, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x640BD10", Offset = "0x640A910", VA = "0x18640BD10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x640BD10", Offset = "0x640A910", VA = "0x18640BD10")]
	public void AAJLGOKEBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x640C340", Offset = "0x640AF40", VA = "0x18640C340")]
	public void GONEDCPKCMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x640C790", Offset = "0x640B390", VA = "0x18640C790")]
	public void KMFEFJOJAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x640C1E0", Offset = "0x640ADE0", VA = "0x18640C1E0")]
	[AsyncStateMachine(typeof(AOBIKMEJJKA))]
	internal Task<CMAIBKDPDAF> FEOIEEHHCOD(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CMAIBKDPDAF PKJLAPJGLHJ, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x257AC60", Offset = "0x2579860", VA = "0x18257AC60")]
	private static byte[] KKEEILEAAOH<T>(T EOOPGFAEMIH) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x257A7A0", Offset = "0x25793A0", VA = "0x18257A7A0")]
	private static T HHDBAPNLBIE<T>(MessageParser<T> JHCGDPIIHAI, byte[] EOOPGFAEMIH, T GLFGEBKCMID) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x640CC30", Offset = "0x640B830", VA = "0x18640CC30")]
	[AsyncStateMachine(typeof(ENPIGGLCNMA))]
	private Task<NKGBBEDNKNJ.LNDKDOACHII<CMAIBKDPDAF>> PKIAFHHHKIB(CMAIBKDPDAF PKJLAPJGLHJ, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x257A8F0", Offset = "0x25794F0", VA = "0x18257A8F0")]
	[AsyncStateMachine(typeof(DICEJBNNKJO<>))]
	internal Task<T> JMFCFJEIMLF<T>(CancellationToken BINKOPDIFFD, Func<CancellationToken, Task<T>> IOKIBECGNOB, int MNIGLDNHEMD = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x640C660", Offset = "0x640B260", VA = "0x18640C660")]
	[AsyncStateMachine(typeof(CFNHHOMMKPM))]
	internal Task JMFCFJEIMLF(CancellationToken BINKOPDIFFD, Func<CancellationToken, Task> IOKIBECGNOB, int MNIGLDNHEMD = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x640C110", Offset = "0x640AD10", VA = "0x18640C110")]
	public OBFAGOPEPFJ DOKJNONDLBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x640CAA0", Offset = "0x640B6A0", VA = "0x18640CAA0")]
	public IEGMBFCECNK PFLNNKFIOML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x640C510", Offset = "0x640B110", VA = "0x18640C510")]
	public JHHEMGMDPDL JMBKDDEIAGB([Optional] ELHKCOAEACJ? CABFMJIIGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x640BE30", Offset = "0x640AA30", VA = "0x18640BE30")]
	public void DELNGOPMFMA(Func<Guid, bool> LOHKFEJLMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x640CB20", Offset = "0x640B720", VA = "0x18640CB20")]
	public void PGLOMJBDMEJ(Func<Guid, bool> IEKOKNNLPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x640BF90", Offset = "0x640AB90", VA = "0x18640BF90")]
	public Guid DKMJIDAHMFF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x640C990", Offset = "0x640B590", VA = "0x18640C990")]
	public void OFMALBBHDGJ(Guid GJCCKOGJLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x640C850", Offset = "0x640B450", VA = "0x18640C850")]
	public void NOHMMCGHJCL(CMAIBKDPDAF BFNIPJELMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x640C400", Offset = "0x640B000", VA = "0x18640C400")]
	public void JJBLJPHBGMP(string PAFAGAKNNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x257AB70", Offset = "0x2579770", VA = "0x18257AB70")]
	private T KHCDKBPABND<T>(T GCPEEAODAIB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x640C190", Offset = "0x640AD90", VA = "0x18640C190")]
	public void FBILOIFGKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x257A4F0", Offset = "0x25790F0", VA = "0x18257A4F0")]
	[CompilerGenerated]
	internal static string HAIFKCBAJON<T>(byte[] FEGEJBFJFNG, int LEEFAANFGJN, CMMKEOCHOAC<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal sealed class LOJHMJFOEOO : OAMCKBCGEGJ
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class OIFIADCKNJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public OIFIADCKNJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x64271B0", Offset = "0x6425DB0", VA = "0x1864271B0")]
		internal object JBJBGKEPCGL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct NBGDLJIEBOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public LOJHMJFOEOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public LNOKCMEODGP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private CHKCKFECDIL <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private IEGMBFCECNK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x6422630", Offset = "0x6421230", VA = "0x186422630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x6422E10", Offset = "0x6421A10", VA = "0x186422E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct KLABLLIPNFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public LOJHMJFOEOO <>4__this;

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
		private TaskAwaiter<AADJFGNPPBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x6421430", Offset = "0x6420030", VA = "0x186421430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x6421AE0", Offset = "0x64206E0", VA = "0x186421AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct KGEFPBGLJOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public LOJHMJFOEOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private TaskAwaiter<AMHKJPMBBKF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x64210A0", Offset = "0x641FCA0", VA = "0x1864210A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x64213C0", Offset = "0x641FFC0", VA = "0x1864213C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class GBPKGDKCCGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public CHKCKFECDIL presence;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public GBPKGDKCCGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x641C250", Offset = "0x641AE50", VA = "0x18641C250")]
		internal object NLJPGDGNCHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly ELHKCOAEACJ CABFMJIIGKB;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly ELHKCOAEACJ FLHFKBBDFLP;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly ELHKCOAEACJ HNKIDACHNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private readonly GLELENLDELG MINIAOGHOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private readonly AKINJJFCBCP KIOEOLMCJKM;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x640D620", Offset = "0x640C220", VA = "0x18640D620")]
	public LOJHMJFOEOO(GLELENLDELG MINIAOGHOMD, AKINJJFCBCP KIOEOLMCJKM, Guid BJCCLJBIHHN, AEIFCCFGGHA PELKFGHCAJD, BGAFJPNGEOB MEODOMJAPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x640D220", Offset = "0x640BE20", VA = "0x18640D220", Slot = "7")]
	[AsyncStateMachine(typeof(NBGDLJIEBOD))]
	protected override Task HDKBEMJNPOD(LNOKCMEODGP LKHHOOLKGGB, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x640D010", Offset = "0x640BC10", VA = "0x18640D010")]
	[AsyncStateMachine(typeof(KLABLLIPNFM))]
	private Task BNAEGCJCPCG(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x640D110", Offset = "0x640BD10", VA = "0x18640D110")]
	[AsyncStateMachine(typeof(KGEFPBGLJOD))]
	private Task<byte> CFHMLNKFIJM(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x640D360", Offset = "0x640BF60", VA = "0x18640D360")]
	private CHKCKFECDIL OHBJDHLCHAH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class BHDCJHOMFLB : OAMCKBCGEGJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct EPLPJKPJLJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public BHDCJHOMFLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public LNOKCMEODGP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private TaskAwaiter<NAKMOBJIHCO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6419DF0", Offset = "0x64189F0", VA = "0x186419DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x641A770", Offset = "0x6419370", VA = "0x18641A770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private readonly int PBLLAPLFINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private readonly IBADDLHMPKI LLABLLJHCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public readonly long NPDOLACIPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public readonly long CAGMMBGKBFJ;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public NAKMOBJIHCO ANMPCHMPLLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x778780", Offset = "0x777380", VA = "0x180778780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x778840", Offset = "0x777440", VA = "0x180778840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6415660", Offset = "0x6414260", VA = "0x186415660")]
	public BHDCJHOMFLB(Guid BJCCLJBIHHN, AEIFCCFGGHA PELKFGHCAJD, BGAFJPNGEOB MEODOMJAPDG, int PBLLAPLFINO, IBADDLHMPKI LLABLLJHCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6415540", Offset = "0x6414140", VA = "0x186415540", Slot = "7")]
	[AsyncStateMachine(typeof(EPLPJKPJLJK))]
	protected override Task HDKBEMJNPOD(LNOKCMEODGP LKHHOOLKGGB, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal abstract class ADIPCLNKPFN : OAMCKBCGEGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class AKCDCJEEPAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public ADIPCLNKPFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public JNMAMHLJMAI playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public AKCDCJEEPAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x64147A0", Offset = "0x64133A0", VA = "0x1864147A0")]
		internal Task CHJDELIJEKN(FIKFBEICCGA<string>.DJKJOCCHFDH postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x64147E0", Offset = "0x64133E0", VA = "0x1864147E0")]
		internal object GBCDMEAKMOH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct FGOGOIFJIHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public ADIPCLNKPFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public LNOKCMEODGP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private AKCDCJEEPAB <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x641BA30", Offset = "0x641A630", VA = "0x18641BA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x641C1F0", Offset = "0x641ADF0", VA = "0x18641C1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct PCBBCCLEDOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public JNMAMHLJMAI playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public ADIPCLNKPFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6429B00", Offset = "0x6428700", VA = "0x186429B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x642A090", Offset = "0x6428C90", VA = "0x18642A090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6414180", Offset = "0x6412D80", VA = "0x186414180")]
	public ADIPCLNKPFN(Guid BJCCLJBIHHN, AEIFCCFGGHA PELKFGHCAJD, BGAFJPNGEOB MEODOMJAPDG, string NKHNDLLLMDM, JNNLMBKMLLG NGJFKCMINGB, bool MCPIJKJOIOD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6413F00", Offset = "0x6412B00", VA = "0x186413F00", Slot = "7")]
	[AsyncStateMachine(typeof(FGOGOIFJIHF))]
	protected override Task HDKBEMJNPOD(LNOKCMEODGP LKHHOOLKGGB, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task BOMGJPIIDIE(LNOKCMEODGP LKHHOOLKGGB, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6414040", Offset = "0x6412C40", VA = "0x186414040")]
	[AsyncStateMachine(typeof(PCBBCCLEDOK))]
	private Task JCKCAKHKNFD(IDisposable BKOJBDCPBPA, JNMAMHLJMAI FJMDJNBMGOI, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class BOIALKCAJOJ : OAMCKBCGEGJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct AIHECOBBBNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public BOIALKCAJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public LNOKCMEODGP operationContext;

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
		private TaskAwaiter<CIACFOCFAGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x64141D0", Offset = "0x6412DD0", VA = "0x1864141D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6414740", Offset = "0x6413340", VA = "0x186414740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	private readonly EMCJOAAJBFJ NPEKECDFDBG;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6416C70", Offset = "0x6415870", VA = "0x186416C70")]
	public BOIALKCAJOJ(Guid BJCCLJBIHHN, AEIFCCFGGHA PELKFGHCAJD, BGAFJPNGEOB MEODOMJAPDG, EMCJOAAJBFJ NPEKECDFDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6416B90", Offset = "0x6415790", VA = "0x186416B90", Slot = "6")]
	protected override string PCLPPCGLCFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6416A70", Offset = "0x6415670", VA = "0x186416A70", Slot = "7")]
	[AsyncStateMachine(typeof(AIHECOBBBNA))]
	protected override Task HDKBEMJNPOD(LNOKCMEODGP LKHHOOLKGGB, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class OAMCKBCGEGJ : EHFEOOAJECL
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public delegate Task BENCIIDMNJO(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class DFAFLLDDMLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public OAMCKBCGEGJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public DFAFLLDDMLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6417880", Offset = "0x6416480", VA = "0x186417880")]
		internal Task DJCGFFLAJGO(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class LKKCHOAFCFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public DFAFLLDDMLE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public LKKCHOAFCFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6421FC0", Offset = "0x6420BC0", VA = "0x186421FC0")]
		internal object OKNNPMIEBPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6421F00", Offset = "0x6420B00", VA = "0x186421F00")]
		internal object CCIIBJAMAPN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct FEEJOMFPDMH : IAsyncStateMachine
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
		public OAMCKBCGEGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public Func<OAMCKBCGEGJ, FIKFBEICCGA<string>.DJKJOCCHFDH, LNOKCMEODGP> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private DFAFLLDDMLE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private LNOKCMEODGP <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<CMAIBKDPDAF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x641A7D0", Offset = "0x64193D0", VA = "0x18641A7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x641B9D0", Offset = "0x641A5D0", VA = "0x18641B9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct OPEEHKFPJLH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6429020", Offset = "0x6427C20", VA = "0x186429020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6429AA0", Offset = "0x64286A0", VA = "0x186429AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct LHGPNAMHJLD : IAsyncStateMachine
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
		public OAMCKBCGEGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6421B40", Offset = "0x6420740", VA = "0x186421B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6421EA0", Offset = "0x6420AA0", VA = "0x186421EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly Guid KIICMPDDCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly ByteString IAKMNIOMMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly BGAFJPNGEOB BOMNLDFMPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	protected readonly string CDMJKJHPKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private readonly bool MCPIJKJOIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly Queue<BENCIIDMNJO> EPMJGJLIHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly LPKFHNPIOJH BMHJOMNGBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly JNNLMBKMLLG NGJFKCMINGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private bool HGLGFNAJLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public EDAJJABLLFB NBDCJPOKKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public EDAJJABLLFB HABIKEGCHNC;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public AEIFCCFGGHA FPNFCDAKFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x773610", Offset = "0x772210", VA = "0x180773610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public NCAMOCAOBKA MOFFCFCLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6424960", Offset = "0x6423560", VA = "0x186424960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public DCMEMGFPPFF OPHKOGKKGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6424C30", Offset = "0x6423830", VA = "0x186424C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public KABLCFJOKIG HPNOJDJMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6424DC0", Offset = "0x64239C0", VA = "0x186424DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event BDEMODOIFBD LNJALIBMOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x6425120", Offset = "0x6423D20", VA = "0x186425120", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x6424AA0", Offset = "0x64236A0", VA = "0x186424AA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x64252D0", Offset = "0x6423ED0", VA = "0x1864252D0")]
	protected OAMCKBCGEGJ(Guid BJCCLJBIHHN, AEIFCCFGGHA PELKFGHCAJD, BGAFJPNGEOB MEODOMJAPDG, string NKHNDLLLMDM, JNNLMBKMLLG NGJFKCMINGB, bool MCPIJKJOIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6425140", Offset = "0x6423D40", VA = "0x186425140", Slot = "6")]
	protected virtual string PCLPPCGLCFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6424E40", Offset = "0x6423A40", VA = "0x186424E40")]
	public void JBBMFKMJLOF(BENCIIDMNJO LFGOMLHIEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6424C80", Offset = "0x6423880", VA = "0x186424C80")]
	protected void FKJDFICDJON(float BPDGEJEAOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6425180", Offset = "0x6423D80", VA = "0x186425180")]
	[AsyncStateMachine(typeof(FEEJOMFPDMH))]
	public Task PELAEOHIFHJ(CancellationToken BJFJMBIBKLL, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, [Optional] Func<OAMCKBCGEGJ, FIKFBEICCGA<string>.DJKJOCCHFDH, LNOKCMEODGP> NJBCMJIGIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6424FF0", Offset = "0x6423BF0", VA = "0x186424FF0")]
	[AsyncStateMachine(typeof(OPEEHKFPJLH))]
	private static Task KFIGHPKLEED(Func<CancellationToken, Task> MCMMLLPJEAC, Func<CancellationToken, Task> LIPNGNCGPMM, CancellationToken BINKOPDIFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6424EA0", Offset = "0x6423AA0", VA = "0x186424EA0")]
	private void JJLLCKPJJJM(bool FHBGMNIFOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x64249B0", Offset = "0x64235B0", VA = "0x1864249B0")]
	private void BLHOADELIPM(LNOKCMEODGP LKHHOOLKGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task HDKBEMJNPOD(LNOKCMEODGP LKHHOOLKGGB, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6424CA0", Offset = "0x64238A0", VA = "0x186424CA0")]
	[AsyncStateMachine(typeof(LHGPNAMHJLD))]
	private Task IJFHGIAIHON(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x6424AC0", Offset = "0x64236C0", VA = "0x186424AC0")]
	public CMAIBKDPDAF EBLEMNCHBGD(KBGLOHDDINE GNCJDHDKBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6424B40", Offset = "0x6423740", VA = "0x186424B40")]
	[CompilerGenerated]
	private Task FCIIIAEDBHC(CancellationToken GHKAOLMKPMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
internal sealed class NDGEJEJIJCK : ADIPCLNKPFN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct BKGEEKAGIEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public NDGEJEJIJCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public LNOKCMEODGP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private NIIHDDCOAKK <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private IEGMBFCECNK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6415F30", Offset = "0x6414B30", VA = "0x186415F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x64166A0", Offset = "0x64152A0", VA = "0x1864166A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly GLELENLDELG PEKDAMJIFDH;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6423D50", Offset = "0x6422950", VA = "0x186423D50")]
	public NDGEJEJIJCK(Guid BJCCLJBIHHN, AEIFCCFGGHA PELKFGHCAJD, GLELENLDELG PEKDAMJIFDH, BGAFJPNGEOB MEODOMJAPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6423C00", Offset = "0x6422800", VA = "0x186423C00", Slot = "8")]
	[AsyncStateMachine(typeof(BKGEEKAGIEG))]
	protected override Task BOMGJPIIDIE(LNOKCMEODGP LKHHOOLKGGB, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
internal class JPKFKCFHJGM : OAMCKBCGEGJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct BGIDEKECAFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public JPKFKCFHJGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public LNOKCMEODGP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private TaskAwaiter<CIACFOCFAGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x6415130", Offset = "0x6413D30", VA = "0x186415130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x64154E0", Offset = "0x64140E0", VA = "0x1864154E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private readonly string CANGBBJGDOH;

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x6420FF0", Offset = "0x641FBF0", VA = "0x186420FF0")]
	public JPKFKCFHJGM(Guid BJCCLJBIHHN, AEIFCCFGGHA PELKFGHCAJD, BGAFJPNGEOB MEODOMJAPDG, string CANGBBJGDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6420EE0", Offset = "0x641FAE0", VA = "0x186420EE0", Slot = "7")]
	[AsyncStateMachine(typeof(BGIDEKECAFI))]
	protected override Task HDKBEMJNPOD(LNOKCMEODGP LKHHOOLKGGB, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal class ELFGEOGBICE : ADIPCLNKPFN
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class OBACKGPIHPM
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
			public AsyncTaskMethodBuilder<CMAIBKDPDAF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public OBACKGPIHPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<CIACFOCFAGD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			private TaskAwaiter<CMAIBKDPDAF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x642DA80", Offset = "0x642C680", VA = "0x18642DA80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x642DF40", Offset = "0x642CB40", VA = "0x18642DF40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public ELFGEOGBICE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public JHHEMGMDPDL serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CIFIOAAAKKI roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public OBFAGOPEPFJ uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public KECIELDKHLL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public OBACKGPIHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x6425430", Offset = "0x6424030", VA = "0x186425430")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<CMAIBKDPDAF> MBCJAHFCPPE(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct DNEJFFEACHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public ELFGEOGBICE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public LNOKCMEODGP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private OBACKGPIHPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private NIIHDDCOAKK <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private IEGMBFCECNK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private TaskAwaiter<CMAIBKDPDAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x6417EB0", Offset = "0x6416AB0", VA = "0x186417EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x6418D50", Offset = "0x6417950", VA = "0x186418D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private static readonly ELHKCOAEACJ CABFMJIIGKB;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly ELHKCOAEACJ FLHFKBBDFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private readonly int MLGGMOPFMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	[CanBeNull]
	private readonly CKDIJOECEAM OAGFCMKCBHI;

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x6419D40", Offset = "0x6418940", VA = "0x186419D40")]
	public ELFGEOGBICE(Guid BJCCLJBIHHN, AEIFCCFGGHA PELKFGHCAJD, int MLGGMOPFMNJ, CKDIJOECEAM OAGFCMKCBHI, BGAFJPNGEOB MEODOMJAPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6419880", Offset = "0x6418480", VA = "0x186419880", Slot = "8")]
	[AsyncStateMachine(typeof(DNEJFFEACHK))]
	protected override Task BOMGJPIIDIE(LNOKCMEODGP LKHHOOLKGGB, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x64199C0", Offset = "0x64185C0", VA = "0x1864199C0")]
	private void IAAABMFOJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x6419AC0", Offset = "0x64186C0", VA = "0x186419AC0")]
	private void JMKMIABHBFH(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, NIIHDDCOAKK KIALKADCNKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal abstract class DFFIPIHEPBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly OAMCKBCGEGJ BBPMINEPECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly LNOKCMEODGP BPEJAIEGMAM;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public NCAMOCAOBKA MOFFCFCLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x64179B0", Offset = "0x64165B0", VA = "0x1864179B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public KABLCFJOKIG HPNOJDJMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x6417A00", Offset = "0x6416600", VA = "0x186417A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x6417AB0", Offset = "0x64166B0", VA = "0x186417AB0")]
	protected DFFIPIHEPBF(LNOKCMEODGP LKHHOOLKGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x6417A90", Offset = "0x6416690", VA = "0x186417A90")]
	protected void JJBLJPHBGMP(string PAFAGAKNNPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal struct BGHOCAFDLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public Dictionary<Guid, List<PNOBAHPOLDK>> BABMPAPPCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public Dictionary<Guid, List<PNOBAHPOLDK>> JLHJKFFECCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public Dictionary<Guid, List<PNOBAHPOLDK>> NACKFAJHDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public List<Guid> FADOJLGGAOK;

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x6414B20", Offset = "0x6413720", VA = "0x186414B20")]
	public static BGHOCAFDLGH IOOJPMIEEDI(NCAMOCAOBKA IENMGICDHEH, EDAJJABLLFB GOGDDKOOAKF, HNHIPMBANEH CNFPFHIOJJE)
	{
		return default(BGHOCAFDLGH);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal struct JFDNJNKHLBG
{
	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0")]
	public static JFDNJNKHLBG PAKONFKLIMF()
	{
		return default(JFDNJNKHLBG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct BCCDAEBKJCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly AADJFGNPPBI NBCLOMODJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly KEFAEPIPHKI NCPFGMMGPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly string BCGCEEINNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly JAJPEOHOEFN DGLECCENBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public readonly JAJPEOHOEFN ONIPDGEKDLM;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x6414950", Offset = "0x6413550", VA = "0x186414950")]
	public BCCDAEBKJCF(AADJFGNPPBI NBCLOMODJEL, KEFAEPIPHKI NCPFGMMGPII, string BCGCEEINNOE, JAJPEOHOEFN DGLECCENBLP, JAJPEOHOEFN ONIPDGEKDLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct INBLCDDIPFF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly LNOKCMEODGP LKHHOOLKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly Guid GJCCKOGJLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private bool FHBGMNIFOGH;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x641FA00", Offset = "0x641E600", VA = "0x18641FA00")]
	public static INBLCDDIPFF DKMJIDAHMFF(LNOKCMEODGP LKHHOOLKGGB)
	{
		return default(INBLCDDIPFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x85B840", Offset = "0x85A440", VA = "0x18085B840")]
	public void BFDFOLIFCGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x641FA60", Offset = "0x641E660", VA = "0x18641FA60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x641FB60", Offset = "0x641E760", VA = "0x18641FB60")]
	private INBLCDDIPFF(LNOKCMEODGP LKHHOOLKGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x641FA60", Offset = "0x641E660", VA = "0x18641FA60")]
	private void OFMALBBHDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x641FAC0", Offset = "0x641E6C0", VA = "0x18641FAC0")]
	private Func<Guid, bool> GODPPNHFIKA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal class IEGMBFCECNK : DFFIPIHEPBF, EHFEOOAJECL
{
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	public delegate Task<EDAJJABLLFB> HLNCAJKLJIE(HNHIPMBANEH IGJLGPELHOJ, PEOLAECMAFF LFNPMEEEFGF, LPKFHNPIOJH MJNGLPNBMPO, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct EAPBPNGLMLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public GLELENLDELG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private INBLCDDIPFF <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter<CMAIBKDPDAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x6418DB0", Offset = "0x64179B0", VA = "0x186418DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x6419520", Offset = "0x6418120", VA = "0x186419520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct NNCPJHAJDIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder<CMAIBKDPDAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public GLELENLDELG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private TaskAwaiter<CMAIBKDPDAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x64243C0", Offset = "0x6422FC0", VA = "0x1864243C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x64247D0", Offset = "0x64233D0", VA = "0x1864247D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct ODILJNAMHFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public GLELENLDELG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x64264F0", Offset = "0x64250F0", VA = "0x1864264F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x6426980", Offset = "0x6425580", VA = "0x186426980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class DIOOBIBLLCO
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
			public AsyncTaskMethodBuilder<BCCDAEBKJCF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public DIOOBIBLLCO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			private BCCDAEBKJCF <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<EDAJJABLLFB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			private TaskAwaiter<BCCDAEBKJCF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x642C0F0", Offset = "0x642ACF0", VA = "0x18642C0F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x642C880", Offset = "0x642B480", VA = "0x18642C880", Slot = "5")]
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
			public AsyncTaskMethodBuilder<HNHIPMBANEH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public DIOOBIBLLCO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			private HNHIPMBANEH <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			private TaskAwaiter<EDAJJABLLFB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			private TaskAwaiter<HNHIPMBANEH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x642C8F0", Offset = "0x642B4F0", VA = "0x18642C8F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x642CF40", Offset = "0x642BB40", VA = "0x18642CF40", Slot = "5")]
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
			public DIOOBIBLLCO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private TaskAwaiter<EDAJJABLLFB> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			private PEOLAECMAFF <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x642AD50", Offset = "0x6429950", VA = "0x18642AD50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x642C090", Offset = "0x642AC90", VA = "0x18642C090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public GLELENLDELG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public LPKFHNPIOJH preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public LPKFHNPIOJH downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public BCCDAEBKJCF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public LPKFHNPIOJH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public HNHIPMBANEH phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public NMGFAGNOENB.NBBBJKGOGEB <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public DIOOBIBLLCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x6417D70", Offset = "0x6416970", VA = "0x186417D70")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<BCCDAEBKJCF> MFGGNLEGCNB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x6417B10", Offset = "0x6416710", VA = "0x186417B10")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<HNHIPMBANEH> COIEPCCJDKM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x6417C30", Offset = "0x6416830", VA = "0x186417C30")]
		internal void HBOBBIAHGCF(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x6417C70", Offset = "0x6416870", VA = "0x186417C70")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task IEJNEPFNIAB(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct NCAIBGGDJNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public GLELENLDELG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private DIOOBIBLLCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter<BCCDAEBKJCF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter<HNHIPMBANEH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x6422E70", Offset = "0x6421A70", VA = "0x186422E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x6423A80", Offset = "0x6422680", VA = "0x186423A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct BIDFBGGLBIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x6415790", Offset = "0x6414390", VA = "0x186415790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x6415ED0", Offset = "0x6414AD0", VA = "0x186415ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct OLHKKKOMENE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public LPKFHNPIOJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private TaskAwaiter<EDAJJABLLFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x6427220", Offset = "0x6425E20", VA = "0x186427220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x6427B80", Offset = "0x6426780", VA = "0x186427B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct JJKOHEFNPNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public AsyncTaskMethodBuilder<EDAJJABLLFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public LPKFHNPIOJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private TaskAwaiter<EDAJJABLLFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x641FBB0", Offset = "0x641E7B0", VA = "0x18641FBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6420D30", Offset = "0x641F930", VA = "0x186420D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct OMGMJMFHHII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AsyncTaskMethodBuilder<EDAJJABLLFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public LPKFHNPIOJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public PEOLAECMAFF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private TaskAwaiter<EDAJJABLLFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6427BE0", Offset = "0x64267E0", VA = "0x186427BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6428FB0", Offset = "0x6427BB0", VA = "0x186428FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct EFKHADCDFJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public AsyncTaskMethodBuilder<EDAJJABLLFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public EDAJJABLLFB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public LPKFHNPIOJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public HNHIPMBANEH deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private TaskAwaiter<EDAJJABLLFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x6419580", Offset = "0x6418180", VA = "0x186419580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6419810", Offset = "0x6418410", VA = "0x186419810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class NOAKBOHPCHI
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
			public AsyncTaskMethodBuilder<EDAJJABLLFB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public NOAKBOHPCHI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private TaskAwaiter<EDAJJABLLFB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x642CFB0", Offset = "0x642BBB0", VA = "0x18642CFB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x642D620", Offset = "0x642C220", VA = "0x18642D620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public LPKFHNPIOJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public HLNCAJKLJIE masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public PEOLAECMAFF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public EDAJJABLLFB originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NOAKBOHPCHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x6424840", Offset = "0x6423440", VA = "0x186424840")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<EDAJJABLLFB> NNAIENEABHP(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct MDPCBAJOMLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public AsyncTaskMethodBuilder<EDAJJABLLFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public LPKFHNPIOJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public HLNCAJKLJIE masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public PEOLAECMAFF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter<EDAJJABLLFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x6422080", Offset = "0x6420C80", VA = "0x186422080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x64225C0", Offset = "0x64211C0", VA = "0x1864225C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct OBJFEAAHPEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public LPKFHNPIOJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private EDAJJABLLFB <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private IEnumerator<EDAJJABLLFB> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter<EDAJJABLLFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x6425550", Offset = "0x6424150", VA = "0x186425550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6425A80", Offset = "0x6424680", VA = "0x186425A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct BLKBPNIOLPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x6416700", Offset = "0x6415300", VA = "0x186416700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x6416A10", Offset = "0x6415610", VA = "0x186416A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct GEGNBNBJBPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public IEGMBFCECNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x641CE80", Offset = "0x641BA80", VA = "0x18641CE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x641D0D0", Offset = "0x641BCD0", VA = "0x18641D0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly KOHNFGELOEJ EEMDAHGPLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly KOHNFGELOEJ IPFILJCPCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private readonly KPDIBHHHMEH LCOBNAMJIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly FONDLGIKGFC PCKDJFLOCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly BONMHOMKKMH FNOBKPBKFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly GNDIMEMADBJ BIMGKEBICCK;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private AEIFCCFGGHA FPNFCDAKFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x641F520", Offset = "0x641E120", VA = "0x18641F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event BDEMODOIFBD LNJALIBMOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x641ECD0", Offset = "0x641D8D0", VA = "0x18641ECD0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x641E0C0", Offset = "0x641CCC0", VA = "0x18641E0C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x641F750", Offset = "0x641E350", VA = "0x18641F750")]
	public IEGMBFCECNK(LNOKCMEODGP LKHHOOLKGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x641EE40", Offset = "0x641DA40", VA = "0x18641EE40")]
	[AsyncStateMachine(typeof(EAPBPNGLMLP))]
	public Task KODKIIIEOPD(GLELENLDELG NFAAJOAMBMN, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x641EF90", Offset = "0x641DB90", VA = "0x18641EF90")]
	[AsyncStateMachine(typeof(NNCPJHAJDIB))]
	private Task<CMAIBKDPDAF> KOMMLIJICGN(GLELENLDELG NFAAJOAMBMN, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x641F130", Offset = "0x641DD30", VA = "0x18641F130")]
	[AsyncStateMachine(typeof(ODILJNAMHFJ))]
	private Task LCGCPPHCCLE(GLELENLDELG NFAAJOAMBMN, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x641E660", Offset = "0x641D260", VA = "0x18641E660")]
	[AsyncStateMachine(typeof(NCAIBGGDJNB))]
	private Task FBDNGFMOHGN(GLELENLDELG NFAAJOAMBMN, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken JJHAGPCNMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x641E290", Offset = "0x641CE90", VA = "0x18641E290")]
	[AsyncStateMachine(typeof(BIDFBGGLBIO))]
	private Task COCOPJHAOFG(FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x641F5C0", Offset = "0x641E1C0", VA = "0x18641F5C0")]
	[AsyncStateMachine(typeof(OLHKKKOMENE))]
	private Task ONNCADDCGAO(HNHIPMBANEH IGJLGPELHOJ, LPKFHNPIOJH MJNGLPNBMPO, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x641E500", Offset = "0x641D100", VA = "0x18641E500")]
	[AsyncStateMachine(typeof(JJKOHEFNPNJ))]
	private Task<EDAJJABLLFB> FAIOIDIIIGI(HNHIPMBANEH IGJLGPELHOJ, PEOLAECMAFF JILNJHICCKP, LPKFHNPIOJH MJNGLPNBMPO, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x641EA10", Offset = "0x641D610", VA = "0x18641EA10")]
	[AsyncStateMachine(typeof(OMGMJMFHHII))]
	private Task<EDAJJABLLFB> HKKLGBDDDEP(HNHIPMBANEH IGJLGPELHOJ, PEOLAECMAFF JILNJHICCKP, LPKFHNPIOJH MJNGLPNBMPO, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x641E890", Offset = "0x641D490", VA = "0x18641E890")]
	[AsyncStateMachine(typeof(EFKHADCDFJA))]
	private Task<EDAJJABLLFB> HHOFCBGFBNH(EDAJJABLLFB GOGDDKOOAKF, HNHIPMBANEH CNFPFHIOJJE, LPKFHNPIOJH MJNGLPNBMPO, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL, bool EFLKHBJAHFN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x641F430", Offset = "0x641E030", VA = "0x18641F430")]
	private bool NPIHAIAGOBN(HNHIPMBANEH LPPNECEALBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x641E0E0", Offset = "0x641CCE0", VA = "0x18641E0E0")]
	[AsyncStateMachine(typeof(MDPCBAJOMLM))]
	protected Task<EDAJJABLLFB> CLCGOFNLGOK(HNHIPMBANEH IGJLGPELHOJ, PEOLAECMAFF JILNJHICCKP, LPKFHNPIOJH MJNGLPNBMPO, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL, HLNCAJKLJIE HJPBBKNIIHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x641DF30", Offset = "0x641CB30", VA = "0x18641DF30")]
	[AsyncStateMachine(typeof(OBJFEAAHPEA))]
	private Task BBFBICGCLOD(HNHIPMBANEH IGJLGPELHOJ, LPKFHNPIOJH MJNGLPNBMPO, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x641F550", Offset = "0x641E150", VA = "0x18641F550")]
	private void ONBJFHIFKEK(EDAJJABLLFB MMDHMHCOMBF, LPKFHNPIOJH MJNGLPNBMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x641E080", Offset = "0x641CC80", VA = "0x18641E080")]
	private void BDAIJFLCKCD(EDAJJABLLFB NJDDHAHMJND, [Out] EDAJJABLLFB HDNOOHJLHLB, [Out] EDAJJABLLFB KJAKAMPNIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x641F710", Offset = "0x641E310", VA = "0x18641F710")]
	private Task<BCCDAEBKJCF> PKGMINPBLAN(GLELENLDELG NFAAJOAMBMN, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x641F0F0", Offset = "0x641DCF0", VA = "0x18641F0F0")]
	private Task<HNHIPMBANEH> KPOPJEIEIOE(BCCDAEBKJCF IGJLGPELHOJ, NMGFAGNOENB.NBBBJKGOGEB OELEGAFHFII, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x641ECF0", Offset = "0x641D8F0", VA = "0x18641ECF0")]
	[AsyncStateMachine(typeof(BLKBPNIOLPJ))]
	private Task KJMIEPKGIME(HNHIPMBANEH IGJLGPELHOJ, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL, bool BPOLBEDKAPE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x641E7A0", Offset = "0x641D3A0", VA = "0x18641E7A0")]
	[AsyncStateMachine(typeof(GEGNBNBJBPH))]
	private Task HFGEIEKMBNJ(HNHIPMBANEH IGJLGPELHOJ, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x641E3A0", Offset = "0x641CFA0", VA = "0x18641E3A0")]
	private Task DDGKNFLEEDM(HNHIPMBANEH IGJLGPELHOJ, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x641F410", Offset = "0x641E010", VA = "0x18641F410")]
	private Task MLIHGOEOBND(HNHIPMBANEH IGJLGPELHOJ, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x641F5A0", Offset = "0x641E1A0", VA = "0x18641F5A0")]
	private Task ONIMJGOEGMP(HNHIPMBANEH IGJLGPELHOJ, PEOLAECMAFF JILNJHICCKP, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x641F2C0", Offset = "0x641DEC0", VA = "0x18641F2C0")]
	private Task MHHGBLNKPFM(HNHIPMBANEH IGJLGPELHOJ, PEOLAECMAFF JILNJHICCKP, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6414870", Offset = "0x6413470", VA = "0x186414870")]
	private static Task FPDHOAGBJMK(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x641E270", Offset = "0x641CE70", VA = "0x18641E270")]
	private Task CMBEPAKBKIL(HNHIPMBANEH IGJLGPELHOJ, PEOLAECMAFF JILNJHICCKP, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x641EB90", Offset = "0x641D790", VA = "0x18641EB90")]
	private Task IGJBICNBFKN(HNHIPMBANEH IGJLGPELHOJ, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x641F270", Offset = "0x641DE70", VA = "0x18641F270")]
	private void LHGCDNJAGHM(GLELENLDELG NFAAJOAMBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x641E4E0", Offset = "0x641D0E0", VA = "0x18641E4E0")]
	public void EIPKAHHKNDN(long IMBBOEGNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
	private static void IJIFNLJEEKO(AADJFGNPPBI NBCLOMODJEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct OFCJIODDFEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private HNHIPMBANEH IGJLGPELHOJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private NCAMOCAOBKA MOFFCFCLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6426E80", Offset = "0x6425A80", VA = "0x186426E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6426ED0", Offset = "0x6425AD0", VA = "0x186426ED0")]
	public static Task PELAEOHIFHJ(AEIFCCFGGHA PELKFGHCAJD, HNHIPMBANEH IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x6426FB0", Offset = "0x6425BB0", VA = "0x186426FB0")]
	private void PELAEOHIFHJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct BAPIEEBIMHC
{
	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x6414870", Offset = "0x6413470", VA = "0x186414870")]
	public static Task PELAEOHIFHJ(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct JJLNNLMMANC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct NECGGFDINNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public LNOKCMEODGP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x6423E00", Offset = "0x6422A00", VA = "0x186423E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x6424360", Offset = "0x6422F60", VA = "0x186424360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x6420DA0", Offset = "0x641F9A0", VA = "0x186420DA0")]
	[AsyncStateMachine(typeof(NECGGFDINNN))]
	public static Task PELAEOHIFHJ(LNOKCMEODGP LKHHOOLKGGB, HNHIPMBANEH IGJLGPELHOJ, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct PKGMAAPJGII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct HFHJCEJFFCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public LNOKCMEODGP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public PEOLAECMAFF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private EDAJJABLLFB <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private AEIFCCFGGHA <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private NCAMOCAOBKA <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private IDisposable <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private List<(PersistenceView, CACNBOICLKE)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private CACNBOICLKE <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x641D130", Offset = "0x641BD30", VA = "0x18641D130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x641DDD0", Offset = "0x641C9D0", VA = "0x18641DDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x642AC00", Offset = "0x6429800", VA = "0x18642AC00")]
	[AsyncStateMachine(typeof(HFHJCEJFFCF))]
	public static Task PELAEOHIFHJ(LNOKCMEODGP LKHHOOLKGGB, HNHIPMBANEH IGJLGPELHOJ, PEOLAECMAFF JILNJHICCKP, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x642AA00", Offset = "0x6429600", VA = "0x18642AA00")]
	private static void BLPOGDEEBGJ(PersistenceView NFGKMLPPOFG, CACNBOICLKE PGJNPMOPLKE, HNHIPMBANEH IGJLGPELHOJ, EDAJJABLLFB GOGDDKOOAKF, bool KCKEOBHPMMO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct COADJGGOMEI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct OEEIKLIFNBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public AEIFCCFGGHA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x64269E0", Offset = "0x64255E0", VA = "0x1864269E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6426E20", Offset = "0x6425A20", VA = "0x186426E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x6417770", Offset = "0x6416370", VA = "0x186417770")]
	[AsyncStateMachine(typeof(OEEIKLIFNBI))]
	public static Task PELAEOHIFHJ(AEIFCCFGGHA PELKFGHCAJD, HNHIPMBANEH IGJLGPELHOJ, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct GCICEKBLJNE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct PDHECPGLDPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AEIFCCFGGHA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public LNOKCMEODGP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x642A0F0", Offset = "0x6428CF0", VA = "0x18642A0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x642A300", Offset = "0x6428F00", VA = "0x18642A300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class NDCCCFBNOIJ
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
			public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public NDCCCFBNOIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x642D690", Offset = "0x642C290", VA = "0x18642D690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x642DA20", Offset = "0x642C620", VA = "0x18642DA20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NDCCCFBNOIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x6423AE0", Offset = "0x64226E0", VA = "0x186423AE0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task NGMKGIPMHGC(FIKFBEICCGA<string>.DJKJOCCHFDH timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct ODCOKOKJDOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public GCICEKBLJNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

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
		private TaskAwaiter<CMAIBKDPDAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6425AE0", Offset = "0x64246E0", VA = "0x186425AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6426490", Offset = "0x6425090", VA = "0x186426490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class AALPDOOMKKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public FACDBLKJAKK version;

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
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public AALPDOOMKKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6413D70", Offset = "0x6412970", VA = "0x186413D70")]
		internal object FLDNJODPJAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6413E50", Offset = "0x6412A50", VA = "0x186413E50")]
		internal object KCHCCPNKKGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private HNHIPMBANEH IGJLGPELHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private LNOKCMEODGP LKHHOOLKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private bool BPOLBEDKAPE;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private static readonly ByteString LPGHBAAHMLD;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private NCAMOCAOBKA MOFFCFCLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x641C390", Offset = "0x641AF90", VA = "0x18641C390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private KABLCFJOKIG HPNOJDJMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x641C3E0", Offset = "0x641AFE0", VA = "0x18641C3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x641CB60", Offset = "0x641B760", VA = "0x18641CB60")]
	[AsyncStateMachine(typeof(PDHECPGLDPK))]
	public static Task PELAEOHIFHJ(AEIFCCFGGHA PELKFGHCAJD, HNHIPMBANEH IGJLGPELHOJ, LNOKCMEODGP LKHHOOLKGGB, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL, bool BPOLBEDKAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x641CCB0", Offset = "0x641B8B0", VA = "0x18641CCB0")]
	[AsyncStateMachine(typeof(ODCOKOKJDOF))]
	private Task PELAEOHIFHJ(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x641C480", Offset = "0x641B080", VA = "0x18641C480")]
	private void NDNCBCPFKAN([NotNull] PGCGNLKABHG FBCLOCGHONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x641CB20", Offset = "0x641B720", VA = "0x18641CB20")]
	private bool PBHOHOJKCGH(FACDBLKJAKK DLBBNPMBKBG, PGCGNLKABHG FBCLOCGHONM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct PECOJEFMBEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct CJFHIIAOFMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public AsyncTaskMethodBuilder<HNHIPMBANEH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public PECOJEFMBEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public NMGFAGNOENB.NBBBJKGOGEB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private TaskAwaiter<(MEPDFJNPAPE<DBEGLHOLLEJ, LGEMOLNFJEJ>, MEPDFJNPAPE<IICMDAPPGCC<PGCGNLKABHG>, LGEMOLNFJEJ>, MEPDFJNPAPE<IICMDAPPGCC<MFFBIFNFJON>, LGEMOLNFJEJ>, MEPDFJNPAPE<IICMDAPPGCC<OAHDIBPCFJK>, LGEMOLNFJEJ>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x6416D10", Offset = "0x6415910", VA = "0x186416D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x6417700", Offset = "0x6416300", VA = "0x186417700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct OODPIAPIIOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public AsyncTaskMethodBuilder<MEPDFJNPAPE<DBEGLHOLLEJ, LGEMOLNFJEJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public PECOJEFMBEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public NMGFAGNOENB.NBBBJKGOGEB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private TaskAwaiter<MEPDFJNPAPE<DBEGLHOLLEJ, LGEMOLNFJEJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x64453B0", Offset = "0x6443FB0", VA = "0x1864453B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x64459A0", Offset = "0x64445A0", VA = "0x1864459A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private NEAPFKMFNCB<JAJPEOHOEFN, MFFBIFNFJON> JFPMHHJOLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private NEAPFKMFNCB<JAJPEOHOEFN, PGCGNLKABHG> AONKPHNFHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private NEAPFKMFNCB<long, OAHDIBPCFJK> IMHJDJFLIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private EEBPKOGBIBJ FMAIHCCHFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private AADJFGNPPBI NBCLOMODJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private KEFAEPIPHKI NCPFGMMGPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private string BCGCEEINNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private JAJPEOHOEFN DGLECCENBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private JAJPEOHOEFN ONIPDGEKDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private long IMBBOEGNAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD;

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x642A510", Offset = "0x6429110", VA = "0x18642A510")]
	public static Task<HNHIPMBANEH> LAODBNIIMJC(AEIFCCFGGHA PELKFGHCAJD, [In] BCCDAEBKJCF IGJLGPELHOJ, NMGFAGNOENB.NBBBJKGOGEB OELEGAFHFII, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x642A880", Offset = "0x6429480", VA = "0x18642A880")]
	[AsyncStateMachine(typeof(CJFHIIAOFMK))]
	private Task<HNHIPMBANEH> PELAEOHIFHJ(NMGFAGNOENB.NBBBJKGOGEB OELEGAFHFII, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x642A360", Offset = "0x6428F60", VA = "0x18642A360")]
	[AsyncStateMachine(typeof(OODPIAPIIOM))]
	private Task<MEPDFJNPAPE<DBEGLHOLLEJ, LGEMOLNFJEJ>> JPDJEJPDBAI(string BCGCEEINNOE, long IMBBOEGNAEL, NMGFAGNOENB.NBBBJKGOGEB OELEGAFHFII, FIKFBEICCGA<string>.DJKJOCCHFDH HIHFIKHLKLE, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct IOBODFHGBLH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct FNJKONMILNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public AsyncTaskMethodBuilder<BCCDAEBKJCF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public IOBODFHGBLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private TaskAwaiter<BCCDAEBKJCF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x64355E0", Offset = "0x64341E0", VA = "0x1864355E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x64359E0", Offset = "0x64345E0", VA = "0x1864359E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct LGAKLHJJNMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public AsyncTaskMethodBuilder<BCCDAEBKJCF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public IOBODFHGBLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<BCCDAEBKJCF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x643E1D0", Offset = "0x643CDD0", VA = "0x18643E1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x643E5D0", Offset = "0x643D1D0", VA = "0x18643E5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class MLAHKDDEAPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public MLAHKDDEAPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x13B5920", Offset = "0x13B4520", VA = "0x1813B5920")]
		internal bool IIEGEDAMMLD(KEFAEPIPHKI sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct MCAMHECGBFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder<BCCDAEBKJCF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public JAJPEOHOEFN superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public NCAMOCAOBKA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private MLAHKDDEAPC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private AADJFGNPPBI <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private KEFAEPIPHKI <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private JAJPEOHOEFN <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private JAJPEOHOEFN <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private TaskAwaiter<AADJFGNPPBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private TaskAwaiter<OHHDEGANHGD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private TaskAwaiter<AMHKJPMBBKF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x643F130", Offset = "0x643DD30", VA = "0x18643F130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x64401D0", Offset = "0x643EDD0", VA = "0x1864401D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private NCAMOCAOBKA IENMGICDHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private KPDIBHHHMEH LCOBNAMJIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private long BPJLDBDKBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private long KKFDHGLGLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private long KAJFLINCAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private string DDGMFBNKOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private JAJPEOHOEFN KILDDINAKGF;

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x6439C00", Offset = "0x6438800", VA = "0x186439C00")]
	public static Task<BCCDAEBKJCF> LAODBNIIMJC(AEIFCCFGGHA PELKFGHCAJD, GLELENLDELG NFAAJOAMBMN, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x6439E80", Offset = "0x6438A80", VA = "0x186439E80")]
	[AsyncStateMachine(typeof(FNJKONMILNM))]
	private Task<BCCDAEBKJCF> PELAEOHIFHJ(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x6439FD0", Offset = "0x6438BD0", VA = "0x186439FD0")]
	[AsyncStateMachine(typeof(LGAKLHJJNMF))]
	private Task<BCCDAEBKJCF> PKGMINPBLAN(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x643A130", Offset = "0x6438D30", VA = "0x18643A130")]
	[AsyncStateMachine(typeof(MCAMHECGBFJ))]
	private static Task<BCCDAEBKJCF> PKGMINPBLAN(NCAMOCAOBKA IENMGICDHEH, long BPJLDBDKBIJ, long KKFDHGLGLHO, long KAJFLINCAKN, string DDGMFBNKOHE, JAJPEOHOEFN KILDDINAKGF, CancellationToken BJFJMBIBKLL, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x6439BD0", Offset = "0x64387D0", VA = "0x186439BD0")]
	private void DKLONMMAPCN(AADJFGNPPBI NBCLOMODJEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct GGHNAGCAHIK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct BCMDJOFANHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public GGHNAGCAHIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x6430DB0", Offset = "0x642F9B0", VA = "0x186430DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6431340", Offset = "0x642FF40", VA = "0x186431340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private NCAMOCAOBKA IENMGICDHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private HNHIPMBANEH IGJLGPELHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private float IHLFOGJAMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private float DEDDHCOILCO;

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x64372D0", Offset = "0x6435ED0", VA = "0x1864372D0")]
	public static Task PGGFOILMPOI(AEIFCCFGGHA PELKFGHCAJD, HNHIPMBANEH IGJLGPELHOJ, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x64371B0", Offset = "0x6435DB0", VA = "0x1864371B0")]
	[AsyncStateMachine(typeof(BCMDJOFANHP))]
	public Task PELAEOHIFHJ(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6436F90", Offset = "0x6435B90", VA = "0x186436F90")]
	private static void AIHFEGGBPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6437470", Offset = "0x6436070", VA = "0x186437470")]
	private void PKNPNBFIOHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x64370D0", Offset = "0x6435CD0", VA = "0x1864370D0")]
	private static float GFPNKDHCNBG(NCAMOCAOBKA IENMGICDHEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x6437190", Offset = "0x6435D90", VA = "0x186437190")]
	private static float KAGEAGFNHPP()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct LDFCBOCPFII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct PDICIODGHJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public LNOKCMEODGP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private OAMCKBCGEGJ <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private AEIFCCFGGHA <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private NGMICNOMIHH.LLLICPJNACJ <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private TaskAwaiter<CMAIBKDPDAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x6446010", Offset = "0x6444C10", VA = "0x186446010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x6446A00", Offset = "0x6445600", VA = "0x186446A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct BKINAJPOMLA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6432290", Offset = "0x6430E90", VA = "0x186432290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x64325C0", Offset = "0x64311C0", VA = "0x1864325C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x643D770", Offset = "0x643C370", VA = "0x18643D770")]
	[AsyncStateMachine(typeof(PDICIODGHJF))]
	public static Task PELAEOHIFHJ(LNOKCMEODGP LKHHOOLKGGB, HNHIPMBANEH IGJLGPELHOJ, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x643D650", Offset = "0x643C250", VA = "0x18643D650")]
	private static Task<CMAIBKDPDAF> JPCPHOLDLJD(LNOKCMEODGP LKHHOOLKGGB, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x643D6C0", Offset = "0x643C2C0", VA = "0x18643D6C0")]
	[AsyncStateMachine(typeof(BKINAJPOMLA))]
	private static Task MNLAIPLKIBC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct GDDBJHJFEFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct ICKABMFDKMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public GDDBJHJFEFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x6439190", Offset = "0x6437D90", VA = "0x186439190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x6439840", Offset = "0x6438440", VA = "0x186439840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class MHILPEHEDPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public MHILPEHEDPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x6440240", Offset = "0x643EE40", VA = "0x186440240")]
		internal object PBLMLPJIBBH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct FCGCOAKBFEO : IAsyncStateMachine
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
		public GDDBJHJFEFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private NBBDKPKLKBH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x6434F70", Offset = "0x6433B70", VA = "0x186434F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x6435580", Offset = "0x6434180", VA = "0x186435580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private bool ELJMKAIIEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private CancellationToken BJFJMBIBKLL;

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x6436E30", Offset = "0x6435A30", VA = "0x186436E30")]
	public static Task KHLADLKOPBD(AEIFCCFGGHA PELKFGHCAJD, bool ELJMKAIIEOE, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken AFIMJMLEPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x6436EA0", Offset = "0x6435AA0", VA = "0x186436EA0")]
	[AsyncStateMachine(typeof(ICKABMFDKMJ))]
	private Task PELAEOHIFHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x6436D00", Offset = "0x6435900", VA = "0x186436D00")]
	[AsyncStateMachine(typeof(FCGCOAKBFEO))]
	private Task EOGGFMAJDNN(bool HJGBGLLLDNP, string AEGJFANOGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0")]
	private bool POEMGJGHLGL(bool ELJMKAIIEOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal struct NMEGJMKMAHL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct LCEHBOLJGJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public NMEGJMKMAHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x643D070", Offset = "0x643BC70", VA = "0x18643D070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x643D5E0", Offset = "0x643C1E0", VA = "0x18643D5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class LHCELNMBMCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public LHCELNMBMCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x643E640", Offset = "0x643D240", VA = "0x18643E640")]
		internal object PBLMLPJIBBH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct JCPOHBKIBNM : IAsyncStateMachine
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
		public NMEGJMKMAHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private NBBDKPKLKBH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x643A310", Offset = "0x6438F10", VA = "0x18643A310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x643A8F0", Offset = "0x64394F0", VA = "0x18643A8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	private JNGBMKLMEBJ LLCLLJAMGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400057F")]
	private FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000580")]
	private AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private bool MDCFHFNGIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private HNHIPMBANEH IGJLGPELHOJ;

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6444220", Offset = "0x6442E20", VA = "0x186444220")]
	public static Task<Scene> NGBKNIIFNAD(AEIFCCFGGHA PELKFGHCAJD, JNGBMKLMEBJ EDPAHOCGAML, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x64442A0", Offset = "0x6442EA0", VA = "0x1864442A0")]
	[AsyncStateMachine(typeof(LCEHBOLJGJG))]
	private Task<Scene> PELAEOHIFHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x64440A0", Offset = "0x6442CA0", VA = "0x1864440A0")]
	private bool CNEFJLHDCHI(HNHIPMBANEH IGJLGPELHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x6444030", Offset = "0x6442C30", VA = "0x186444030")]
	private void BFLLOFMFLJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x64440D0", Offset = "0x6442CD0", VA = "0x1864440D0")]
	[AsyncStateMachine(typeof(JCPOHBKIBNM))]
	private Task<Scene> EOGGFMAJDNN(string AEGJFANOGND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct BONMHOMKKMH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct BAIMCHLOPDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public AsyncTaskMethodBuilder<EDAJJABLLFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public BONMHOMKKMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public EDAJJABLLFB nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public HNHIPMBANEH deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private TaskAwaiter<EDAJJABLLFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x64300E0", Offset = "0x642ECE0", VA = "0x1864300E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x6430BC0", Offset = "0x642F7C0", VA = "0x186430BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct FPDLFNKGFGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public AsyncTaskMethodBuilder<EDAJJABLLFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public BONMHOMKKMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public EDAJJABLLFB state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter<CMAIBKDPDAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x64369B0", Offset = "0x64355B0", VA = "0x1864369B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x6436C90", Offset = "0x6435890", VA = "0x186436C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private readonly LNOKCMEODGP LKHHOOLKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private readonly KPDIBHHHMEH LCOBNAMJIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private readonly FONDLGIKGFC PCKDJFLOCFC;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private OAMCKBCGEGJ BBPMINEPECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x4C9DDE0", Offset = "0x4C9C9E0", VA = "0x184C9DDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x6432FE0", Offset = "0x6431BE0", VA = "0x186432FE0")]
	public BONMHOMKKMH(LNOKCMEODGP LKHHOOLKGGB, KPDIBHHHMEH LCOBNAMJIFO, FONDLGIKGFC PCKDJFLOCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x6432E10", Offset = "0x6431A10", VA = "0x186432E10")]
	[AsyncStateMachine(typeof(BAIMCHLOPDE))]
	public Task<EDAJJABLLFB> JGBFNOLCPAG(EDAJJABLLFB JHLJPJAJBJK, HNHIPMBANEH CNFPFHIOJJE, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL, bool EFLKHBJAHFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x6432CB0", Offset = "0x64318B0", VA = "0x186432CB0")]
	[AsyncStateMachine(typeof(FPDLFNKGFGC))]
	private Task<EDAJJABLLFB> FIOHOGBJGOM(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, EDAJJABLLFB FPIEOLNLDGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x6432FB0", Offset = "0x6431BB0", VA = "0x186432FB0")]
	private bool PMHDMOBEMKF(EDAJJABLLFB ADNPNFHPBEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x6432F90", Offset = "0x6431B90", VA = "0x186432F90")]
	private void JJBLJPHBGMP(string BJKEGONNGBL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct BBCFNFBCGNH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct MPLLFJFBFNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public OAMCKBCGEGJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public PEOLAECMAFF timedYielder;

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
		private List<(PersistenceView, CACNBOICLKE)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private (PersistenceView, CACNBOICLKE) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6441730", Offset = "0x6440330", VA = "0x186441730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x6441D70", Offset = "0x6440970", VA = "0x186441D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x6430C70", Offset = "0x642F870", VA = "0x186430C70")]
	[AsyncStateMachine(typeof(MPLLFJFBFNE))]
	public static Task PELAEOHIFHJ(OAMCKBCGEGJ IIPOKLFKMOK, HNHIPMBANEH IGJLGPELHOJ, PEOLAECMAFF JILNJHICCKP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct PCMACFOEAHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct APOGBFNNCKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public OAMCKBCGEGJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public PEOLAECMAFF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private FACDBLKJAKK <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private List<(PersistenceView, CACNBOICLKE)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private CACNBOICLKE <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x642F820", Offset = "0x642E420", VA = "0x18642F820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x6430080", Offset = "0x642EC80", VA = "0x186430080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x6445ED0", Offset = "0x6444AD0", VA = "0x186445ED0")]
	[AsyncStateMachine(typeof(APOGBFNNCKE))]
	public static Task PELAEOHIFHJ(OAMCKBCGEGJ IIPOKLFKMOK, HNHIPMBANEH IGJLGPELHOJ, PEOLAECMAFF JILNJHICCKP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct NGMICNOMIHH
{
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	public struct LLLICPJNACJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public List<IHHPNNIIIED> DNENFOCBHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public List<CACNBOICLKE> AOFOFDLBAGN;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x835CA0", Offset = "0x8348A0", VA = "0x180835CA0")]
		public LLLICPJNACJ(List<IHHPNNIIIED> DNENFOCBHKK, List<CACNBOICLKE> AOFOFDLBAGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class DIJCPNCBINK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public IEnumerable<IHHPNNIIIED> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public DIJCPNCBINK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x6434BF0", Offset = "0x64337F0", VA = "0x186434BF0")]
		internal object GMFIBNEIJBJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private AEIFCCFGGHA PELKFGHCAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private HNHIPMBANEH IGJLGPELHOJ;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private NCAMOCAOBKA MOFFCFCLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x6442BA0", Offset = "0x64417A0", VA = "0x186442BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x64435D0", Offset = "0x64421D0", VA = "0x1864435D0")]
	public static LLLICPJNACJ PELAEOHIFHJ(AEIFCCFGGHA PELKFGHCAJD, HNHIPMBANEH IGJLGPELHOJ)
	{
		return default(LLLICPJNACJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x6443370", Offset = "0x6441F70", VA = "0x186443370")]
	private LLLICPJNACJ PELAEOHIFHJ()
	{
		return default(LLLICPJNACJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x6442BF0", Offset = "0x64417F0", VA = "0x186442BF0")]
	private LLLICPJNACJ EIMMDLHFEKH(PGCGNLKABHG FBCLOCGHONM, FACDBLKJAKK GEKIEOOPJHO)
	{
		return default(LLLICPJNACJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x64431A0", Offset = "0x6441DA0", VA = "0x1864431A0")]
	private bool IPLOAKCGHNN(IEnumerable<IHHPNNIIIED> DNENFOCBHKK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct HHFONGAMAMK
{
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class HKGMNCBKMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public NGMICNOMIHH.LLLICPJNACJ instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public HKGMNCBKMGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x6438640", Offset = "0x6437240", VA = "0x186438640")]
		internal object NGMKGIPMHGC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class ABPJEHDIHFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public ABPJEHDIHFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x642E3B0", Offset = "0x642CFB0", VA = "0x18642E3B0")]
		internal object DJCGFFLAJGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x6438090", Offset = "0x6436C90", VA = "0x186438090")]
	public static void PELAEOHIFHJ(OAMCKBCGEGJ IIPOKLFKMOK, HNHIPMBANEH IGJLGPELHOJ, NGMICNOMIHH.LLLICPJNACJ PHKGEJFMNAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal class FONDLGIKGFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct NAOGCLKBDJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public FONDLGIKGFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public EDAJJABLLFB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public HNHIPMBANEH deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x6441DD0", Offset = "0x64409D0", VA = "0x186441DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x6442540", Offset = "0x6441140", VA = "0x186442540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private sealed class COICEHJKFKM
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
			public COICEHJKFKM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x6446C60", Offset = "0x6445860", VA = "0x186446C60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x6446F20", Offset = "0x6445B20", VA = "0x186446F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public FONDLGIKGFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public COICEHJKFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x6434A90", Offset = "0x6433690", VA = "0x186434A90")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task AEABFHKJJDL(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct NEBICLHJGOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public FONDLGIKGFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private COICEHJKFKM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x6442610", Offset = "0x6441210", VA = "0x186442610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x6442B40", Offset = "0x6441740", VA = "0x186442B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct AKMBJAKBNHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public FONDLGIKGFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private Dictionary<Guid, List<PNOBAHPOLDK>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x642F070", Offset = "0x642DC70", VA = "0x18642F070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x642F620", Offset = "0x642E220", VA = "0x18642F620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct MLFEPBDBKLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public FONDLGIKGFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private Dictionary<Guid, List<PNOBAHPOLDK>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x64407F0", Offset = "0x643F3F0", VA = "0x1864407F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x6440E70", Offset = "0x643FA70", VA = "0x186440E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class BCOLODOGHAJ
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
			public PNOBAHPOLDK handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			public BCOLODOGHAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x6446A60", Offset = "0x6445660", VA = "0x186446A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x6446C00", Offset = "0x6445800", VA = "0x186446C00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public JJKGAIMGIKO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public List<PNOBAHPOLDK> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public BCOLODOGHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x64313A0", Offset = "0x642FFA0", VA = "0x1864313A0")]
		internal object EJMKLGOCPGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x6431490", Offset = "0x6430090", VA = "0x186431490")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task KEFIGNCEBGN(PNOBAHPOLDK handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x6431580", Offset = "0x6430180", VA = "0x186431580")]
		internal object LDPJKAODBCF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct MKLBOJJPLKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public JJKGAIMGIKO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public List<PNOBAHPOLDK> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private BCOLODOGHAJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x64402C0", Offset = "0x643EEC0", VA = "0x1864402C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x6440790", Offset = "0x643F390", VA = "0x186440790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct LIHHGEKOJMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public FONDLGIKGFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public HNHIPMBANEH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH timer;

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
		[Cpp2IlInjected.Address(RVA = "0x643E690", Offset = "0x643D290", VA = "0x18643E690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x643EC40", Offset = "0x643D840", VA = "0x18643EC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class NCDDNMGODDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NCDDNMGODDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x64425A0", Offset = "0x64411A0", VA = "0x1864425A0")]
		internal object MFCEBLEHCJJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct NJFONMPHGGF : IAsyncStateMachine
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
		public FONDLGIKGFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public HNHIPMBANEH data;

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
		[Cpp2IlInjected.Address(RVA = "0x6443630", Offset = "0x6442230", VA = "0x186443630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x6443B40", Offset = "0x6442740", VA = "0x186443B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class ACCOEEMNLBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public ACCOEEMNLBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x642E440", Offset = "0x642D040", VA = "0x18642E440")]
		internal object FGCNOOADOMK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct JJECCFEDECD : IAsyncStateMachine
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
		public FONDLGIKGFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private TaskAwaiter<CMAIBKDPDAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x643BA50", Offset = "0x643A650", VA = "0x18643BA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x643C0D0", Offset = "0x643ACD0", VA = "0x18643C0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class DDEPOLBIKOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public DDEPOLBIKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x6434B80", Offset = "0x6433780", VA = "0x186434B80")]
		internal object BJHJAKKGJED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private readonly LNOKCMEODGP LKHHOOLKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private BGHOCAFDLGH PCKDJFLOCFC;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private OAMCKBCGEGJ BBPMINEPECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xF94A10", Offset = "0xF93610", VA = "0x180F94A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	public FONDLGIKGFC(LNOKCMEODGP LKHHOOLKGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x6436860", Offset = "0x6435460", VA = "0x186436860")]
	[AsyncStateMachine(typeof(NAOGCLKBDJA))]
	public Task PELAEOHIFHJ(EDAJJABLLFB GOGDDKOOAKF, HNHIPMBANEH CNFPFHIOJJE, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x6435C90", Offset = "0x6434890", VA = "0x186435C90")]
	[AsyncStateMachine(typeof(NEBICLHJGOO))]
	private Task CFIMAFFMAMJ(HNHIPMBANEH IGJLGPELHOJ, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x6436490", Offset = "0x6435090", VA = "0x186436490")]
	[AsyncStateMachine(typeof(AKMBJAKBNHJ))]
	private Task LNLJNMPHKAC(HNHIPMBANEH IGJLGPELHOJ, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x64360F0", Offset = "0x6434CF0", VA = "0x1864360F0")]
	[AsyncStateMachine(typeof(MLFEPBDBKLC))]
	private Task IHHEMIMCOPA(HNHIPMBANEH IGJLGPELHOJ, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x64365D0", Offset = "0x64351D0", VA = "0x1864365D0")]
	[AsyncStateMachine(typeof(MKLBOJJPLKL))]
	private Task NBGJAAJPMPN(Guid MDHOCFFPPLI, List<PNOBAHPOLDK> DACECAEDOKC, JJKGAIMGIKO MAGDMCJJNFN, HNHIPMBANEH IGJLGPELHOJ, CancellationToken KJCAGLABEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x6436720", Offset = "0x6435320", VA = "0x186436720")]
	[AsyncStateMachine(typeof(LIHHGEKOJMB))]
	private Task PBGEPNIKAIP(HNHIPMBANEH IGJLGPELHOJ, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x6436350", Offset = "0x6434F50", VA = "0x186436350")]
	[AsyncStateMachine(typeof(NJFONMPHGGF))]
	private Task KCCGPGEDGHF(Guid NCCDBEHHNFO, HNHIPMBANEH IGJLGPELHOJ, FIKFBEICCGA<string>.DJKJOCCHFDH AEIJEHEMJFD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6435FB0", Offset = "0x6434BB0", VA = "0x186435FB0")]
	[AsyncStateMachine(typeof(JJECCFEDECD))]
	private Task HHHIOPHLBHE(Guid NCCDBEHHNFO, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x6436230", Offset = "0x6434E30", VA = "0x186436230")]
	private void JOALHAKGCEJ(Guid NCCDBEHHNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x6435A50", Offset = "0x6434650", VA = "0x186435A50")]
	private void ADDHIDCFEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x6435B00", Offset = "0x6434700", VA = "0x186435B00")]
	public Guid BCMNKMDEBNK(EDAJJABLLFB MMDHMHCOMBF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x6435DD0", Offset = "0x64349D0", VA = "0x186435DD0")]
	[CompilerGenerated]
	private object EBLOLFIOFHN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public readonly struct KECIELDKHLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	public readonly bool OADMMOFMCLM;

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0xBBFA70", Offset = "0xBBE670", VA = "0x180BBFA70")]
	public KECIELDKHLL(bool KGMKDIKAGAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public readonly struct CIACFOCFAGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000626")]
	public readonly PGCGNLKABHG? HDNMPJFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000627")]
	public readonly IHOICHPOIFG IPHFJPJCINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	public readonly string? BPJAPFMDHBI;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public IReadOnlyCollection<string> BCHPFAIHBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x6433990", Offset = "0x6432590", VA = "0x186433990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public IReadOnlyDictionary<long, int> IEJANMNBGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x6433970", Offset = "0x6432570", VA = "0x186433970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x64339B0", Offset = "0x64325B0", VA = "0x1864339B0")]
	public CIACFOCFAGD(PGCGNLKABHG? EMCADPHEHCL, IHOICHPOIFG AMOKJEMNIBK, string? BCGCEEINNOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal class JHHEMGMDPDL : DFFIPIHEPBF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct OFHNHODJJDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public AsyncTaskMethodBuilder<CIACFOCFAGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public JHHEMGMDPDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public EHBKALCAMLM serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public CIFIOAAAKKI roomSaveOptions;

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
		[Cpp2IlInjected.Address(RVA = "0x6444C00", Offset = "0x6443800", VA = "0x186444C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x64452A0", Offset = "0x6443EA0", VA = "0x1864452A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class LAINHIKDFII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public EHBKALCAMLM serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public JHHEMGMDPDL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public LAINHIKDFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x643CD70", Offset = "0x643B970", VA = "0x18643CD70")]
		internal Task ODIPMPFLBCB(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x643CF90", Offset = "0x643BB90", VA = "0x18643CF90")]
		internal Task PNFJPOPEICM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class KMOHPMKOLBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public LAINHIKDFII CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public KMOHPMKOLBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x643CD00", Offset = "0x643B900", VA = "0x18643CD00")]
		internal object GLEGDAMMHOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class BAOLHEHGBBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public LAINHIKDFII CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public BAOLHEHGBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x6430C30", Offset = "0x642F830", VA = "0x186430C30")]
		internal Task OPEIMHPCAPP(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct LEGBGIKCHOP : IAsyncStateMachine
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
		public EHBKALCAMLM serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public JHHEMGMDPDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private KMOHPMKOLBA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x643D8B0", Offset = "0x643C4B0", VA = "0x18643D8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x643E170", Offset = "0x643CD70", VA = "0x18643E170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	private readonly ELHKCOAEACJ CABFMJIIGKB;

	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private static readonly TimeSpan GBINDPAFCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private readonly KPAEFPELIHD PCHFDEFJCPC;

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x643BA00", Offset = "0x643A600", VA = "0x18643BA00")]
	public JHHEMGMDPDL(LNOKCMEODGP LKHHOOLKGGB, KPAEFPELIHD PCHFDEFJCPC, ELHKCOAEACJ CABFMJIIGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x643B830", Offset = "0x643A430", VA = "0x18643B830")]
	[AsyncStateMachine(typeof(OFHNHODJJDE))]
	public Task<CIACFOCFAGD> OIIEHDKDHEB(long KKFDHGLGLHO, CIFIOAAAKKI CEACPMCGCJH, EHBKALCAMLM LHLCPOBOHJD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x643B490", Offset = "0x643A090", VA = "0x18643B490")]
	[AsyncStateMachine(typeof(LEGBGIKCHOP))]
	private Task JNNOAMJBBAM(EHBKALCAMLM LHLCPOBOHJD, IEnumerable<PersistenceView> ADMLFHLGFPK, StringBuilder KCHHDNFNCNJ, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x643AFF0", Offset = "0x6439BF0", VA = "0x18643AFF0")]
	private CIACFOCFAGD HDJKFKJMCKG(long KKFDHGLGLHO, CIFIOAAAKKI CEACPMCGCJH, EHBKALCAMLM LHLCPOBOHJD, IEnumerable<PersistenceView> ADMLFHLGFPK, StringBuilder KCHHDNFNCNJ)
	{
		return default(CIACFOCFAGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x643A960", Offset = "0x6439560", VA = "0x18643A960")]
	private PGCGNLKABHG AAIBHNECBMD(long KKFDHGLGLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x643B5E0", Offset = "0x643A1E0", VA = "0x18643B5E0")]
	private void LEBPKODGKME(PGCGNLKABHG EHLHHAHBJDC, StringBuilder KCHHDNFNCNJ, IEnumerable<PersistenceView> ADMLFHLGFPK, [In] ELAHHMDKCOB AAJKFENLHDH, BIAPNJNNBGK PBGAIDNFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x643AB20", Offset = "0x6439720", VA = "0x18643AB20")]
	private void BGBKBONDCPE(PGCGNLKABHG EHLHHAHBJDC, StringBuilder KCHHDNFNCNJ, PersistenceView NFGKMLPPOFG, BIAPNJNNBGK PBGAIDNFGPA, [In] ELAHHMDKCOB AAJKFENLHDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class OBFAGOPEPFJ : DFFIPIHEPBF
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class IOFNIGFFBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public NGDDDNMKBDM.ICABENAOONI roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public IOFNIGFFBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x643A2C0", Offset = "0x6438EC0", VA = "0x18643A2C0")]
		internal object HFBHGNDHAHG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct CFENKHNFIEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public AsyncTaskMethodBuilder<(NGDDDNMKBDM.ICABENAOONI roomDataUpload, NGDDDNMKBDM.ICABENAOONI subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public CIACFOCFAGD roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public OBFAGOPEPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private IOFNIGFFBFO <>8__1;

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
		private TaskAwaiter<NGDDDNMKBDM.ICABENAOONI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x6433040", Offset = "0x6431C40", VA = "0x186433040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x6433880", Offset = "0x6432480", VA = "0x186433880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct BMLKBDNNBJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public AsyncTaskMethodBuilder<NAKMOBJIHCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public OBFAGOPEPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public CIACFOCFAGD roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public CKDIJOECEAM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private TaskAwaiter<(NGDDDNMKBDM.ICABENAOONI roomDataUpload, NGDDDNMKBDM.ICABENAOONI subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private TaskAwaiter<NAKMOBJIHCO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x6432620", Offset = "0x6431220", VA = "0x186432620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x6432C40", Offset = "0x6431840", VA = "0x186432C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct MAHPEOHBJNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public AsyncTaskMethodBuilder<OHHDEGANHGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public OBFAGOPEPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public CIACFOCFAGD roomSerializedData;

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
		private TaskAwaiter<(NGDDDNMKBDM.ICABENAOONI roomDataUpload, NGDDDNMKBDM.ICABENAOONI subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private TaskAwaiter<OHHDEGANHGD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x643ECA0", Offset = "0x643D8A0", VA = "0x18643ECA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x643F0C0", Offset = "0x643DCC0", VA = "0x18643F0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class EIBIPBNOOEI
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
			public AsyncTaskMethodBuilder<CMAIBKDPDAF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			public EIBIPBNOOEI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400067B")]
			private CMAIBKDPDAF <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400067C")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400067D")]
			private TaskAwaiter<OHHDEGANHGD> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			private TaskAwaiter<NAKMOBJIHCO> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			private TaskAwaiter<CMAIBKDPDAF> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x6446F80", Offset = "0x6445B80", VA = "0x186446F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x6447F80", Offset = "0x6446B80", VA = "0x186447F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public OBFAGOPEPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public CIACFOCFAGD roomSerializedData;

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
		public CKDIJOECEAM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public KECIELDKHLL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public EIBIPBNOOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x6434E40", Offset = "0x6433A40", VA = "0x186434E40")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<CMAIBKDPDAF> PGOOODIEALA(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct GLJGGBMLCBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public AsyncTaskMethodBuilder<CMAIBKDPDAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public OBFAGOPEPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public CIACFOCFAGD roomSerializedData;

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
		public CKDIJOECEAM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public KECIELDKHLL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private TaskAwaiter<CMAIBKDPDAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x64378F0", Offset = "0x64364F0", VA = "0x1864378F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x6437C00", Offset = "0x6436800", VA = "0x186437C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400064E")]
	private static readonly ELHKCOAEACJ CABFMJIIGKB;

	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private static readonly ELHKCOAEACJ FLHFKBBDFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private readonly LGKDKKBBDIJ FALHLBKKBHK;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private AEIFCCFGGHA FPNFCDAKFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x641F520", Offset = "0x641E120", VA = "0x18641F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x6444B70", Offset = "0x6443770", VA = "0x186444B70")]
	public OBFAGOPEPFJ(LNOKCMEODGP LKHHOOLKGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x64447F0", Offset = "0x64433F0", VA = "0x1864447F0")]
	[AsyncStateMachine(typeof(CFENKHNFIEF))]
	private Task<(NGDDDNMKBDM.ICABENAOONI, NGDDDNMKBDM.ICABENAOONI)> JKEPEKKBCPI(CIACFOCFAGD GFCMBFDFODN, long BPJLDBDKBIJ, long LPIJNBPBLPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x6444510", Offset = "0x6443110", VA = "0x186444510")]
	[AsyncStateMachine(typeof(BMLKBDNNBJF))]
	public Task<NAKMOBJIHCO> AMADEMNLIAL(int MLGGMOPFMNJ, [CanBeNull] CKDIJOECEAM OAGFCMKCBHI, CIACFOCFAGD GFCMBFDFODN, long BPJLDBDKBIJ, long LPIJNBPBLPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x6444680", Offset = "0x6443280", VA = "0x186444680")]
	[AsyncStateMachine(typeof(MAHPEOHBJNK))]
	private Task<OHHDEGANHGD> IKLGFNDGAND(string DDGMFBNKOHE, int MLGGMOPFMNJ, CIACFOCFAGD GFCMBFDFODN, long BPJLDBDKBIJ, long LPIJNBPBLPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x6444930", Offset = "0x6443530", VA = "0x186444930")]
	[AsyncStateMachine(typeof(GLJGGBMLCBN))]
	public Task<CMAIBKDPDAF> MBANHNKLEMK(int MLGGMOPFMNJ, CKDIJOECEAM? OAGFCMKCBHI, CIACFOCFAGD GFCMBFDFODN, long BPJLDBDKBIJ, long LPIJNBPBLPM, KECIELDKHLL MAHLHPBPFOL, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public abstract class ODJKCBAPLEH<T> where T : ODJKCBAPLEH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	internal readonly AEIFCCFGGHA MHGIDPCCLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private int? PBNCAIAOMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068E")]
	protected readonly Guid KIICMPDDCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	protected readonly HBBGLBIKIJH NBBGKPBBFNO;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	protected T ECJIPJBJJID
	{
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8E10", Offset = "0x3DE7A10", VA = "0x183DE8E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8E70", Offset = "0x3DE7A70", VA = "0x183DE8E70")]
	internal ODJKCBAPLEH(AEIFCCFGGHA GDAMIGOIIPP, HBBGLBIKIJH FHHBHJGIJKG, [Optional] Guid? BJCCLJBIHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8D30", Offset = "0x3DE7930", VA = "0x183DE8D30")]
	private CMAIBKDPDAF NCENNJEMMNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "4")]
	protected virtual void GKDONKAKKDB(CMAIBKDPDAF EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8CA0", Offset = "0x3DE78A0", VA = "0x183DE8CA0")]
	public T GNFHPKIPMAK(ILLMBLKEFFI NBMIOHDEJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8C10", Offset = "0x3DE7810", VA = "0x183DE8C10")]
	public T GMNIMFMBGME(int GHMIOEDGMAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8AF0", Offset = "0x3DE76F0", VA = "0x183DE8AF0", Slot = "5")]
	public virtual Task<CFDJENKBLOB> FMOEKJJFECK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public class AMOLFKBKLEG : ODJKCBAPLEH<AMOLFKBKLEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private GLELENLDELG AGEBEEELPDJ;

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x642F750", Offset = "0x642E350", VA = "0x18642F750")]
	internal AMOLFKBKLEG(AEIFCCFGGHA GDAMIGOIIPP, HBBGLBIKIJH FHHBHJGIJKG, [Optional] Guid? BJCCLJBIHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6EB0", Offset = "0x5AC5AB0", VA = "0x185AC6EB0")]
	public AMOLFKBKLEG PGCMCGPEJDI(GLELENLDELG AGEBEEELPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x642F680", Offset = "0x642E280", VA = "0x18642F680", Slot = "4")]
	protected override void GKDONKAKKDB(CMAIBKDPDAF EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public class NLPADNPAJCB : ODJKCBAPLEH<NLPADNPAJCB>
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	internal enum EHNBAEIMGDC
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
	private struct HBOFAONBKBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public AsyncTaskMethodBuilder<CFDJENKBLOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public NLPADNPAJCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter<CFDJENKBLOB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x6437C70", Offset = "0x6436870", VA = "0x186437C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x6438020", Offset = "0x6436C20", VA = "0x186438020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	private EHNBAEIMGDC HGINHPBCIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private string FKONENIODEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private CKDIJOECEAM AGEBEEELPDJ;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x6443EC0", Offset = "0x6442AC0", VA = "0x186443EC0")]
	internal NLPADNPAJCB(AEIFCCFGGHA GDAMIGOIIPP, HBBGLBIKIJH FHHBHJGIJKG, [Optional] Guid? BJCCLJBIHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x6443E70", Offset = "0x6442A70", VA = "0x186443E70")]
	public NLPADNPAJCB MOLLKIEPMFG(string BKAHLJMONND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x6443EA0", Offset = "0x6442AA0", VA = "0x186443EA0")]
	public NLPADNPAJCB NCHHFJCINPA(bool CGGBCGKDJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x6443BE0", Offset = "0x64427E0", VA = "0x186443BE0")]
	public NLPADNPAJCB FMJKAPDECOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x6443D00", Offset = "0x6442900", VA = "0x186443D00", Slot = "4")]
	protected override void GKDONKAKKDB(CMAIBKDPDAF EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x6443C10", Offset = "0x6442810", VA = "0x186443C10", Slot = "5")]
	[AsyncStateMachine(typeof(HBOFAONBKBD))]
	public override Task<CFDJENKBLOB> FMOEKJJFECK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x6443BA0", Offset = "0x64427A0", VA = "0x186443BA0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<CFDJENKBLOB> AONAKAOMOIE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal static class EDCOBCNBHJO
{
	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x6434C70", Offset = "0x6433870", VA = "0x186434C70")]
	public static void AOMKHHLJJBF(this CHKCKFECDIL MIAGJHDNEBD, AKINJJFCBCP KIOEOLMCJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x6434DC0", Offset = "0x64339C0", VA = "0x186434DC0")]
	public static void IHKCPGAIOAM(this AKINJJFCBCP MPHHOJINAPB, [Optional] string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
public static class NMPONJJJAME
{
	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x6444470", Offset = "0x6443070", VA = "0x186444470")]
	public static JAJPEOHOEFN GCOIGLHIFAB(this BKGJOOFNBPO FDKKHFJFLLA)
	{
		return default(JAJPEOHOEFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x64443C0", Offset = "0x6442FC0", VA = "0x1864443C0")]
	public static BKGJOOFNBPO EBAKDPAPDAF(this JAJPEOHOEFN DFDOBENOHKG)
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
			public FPHFGPNODIH ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006A1")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006A2")]
			public FPHFGPNODIH HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private static FPHFGPNODIH[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private Dictionary<FPHFGPNODIH, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x64487C0", Offset = "0x64473C0", VA = "0x1864487C0")]
		public bool MJNHBDCDIMI(FPHFGPNODIH DCEDLBDLEIJ, [Out] ResultConfig DIIHIAJGIIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x6448680", Offset = "0x6447280", VA = "0x186448680")]
		public ResultConfig GDCMPCGGDJK(FPHFGPNODIH OKDGKAJLADI, [Optional] HashSet<FPHFGPNODIH> ECHMNJKNEDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x6448D90", Offset = "0x6447990", VA = "0x186448D90", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x6448830", Offset = "0x6447430", VA = "0x186448830", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A90", Offset = "0x7F5690", VA = "0x1807F6A90")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public static class PCAJMAPHGAM
{
	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x6445A10", Offset = "0x6444610", VA = "0x186445A10")]
	[GFMBCOBENIN(CDPNEOMLNDL.GameOnly)]
	private static void FALOLKAJBGJ(OKOCNPPIKGG JGGJFGBKEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public interface IBADDLHMPKI : IEquatable<IBADDLHMPKI>
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	DateTime GDGCKNKHKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJJEMMOCOCB();

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GLHPEEKGNJK(long BPJLDBDKBIJ, long KKFDHGLGLHO, [Out] CIACFOCFAGD GFCMBFDFODN);
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
internal class AHJFDGPJDLI : BCIGAFKDHED
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class KGDELJPJHCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public EMCJOAAJBFJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public KGDELJPJHCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x643C5F0", Offset = "0x643B1F0", VA = "0x18643C5F0")]
		internal object KADFMBNLOMK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private readonly BLEKKMGPAOF JPHONCHJAIG;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<IBADDLHMPKI> CDFNIJNNAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x642E4B0", Offset = "0x642D0B0", VA = "0x18642E4B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x642EB90", Offset = "0x642D790", VA = "0x18642EB90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	[UnityEngine.Scripting.Preserve]
	public AHJFDGPJDLI([DLBAGNNJKKK(null)] BLEKKMGPAOF JPHONCHJAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x642E8B0", Offset = "0x642D4B0", VA = "0x18642E8B0", Slot = "6")]
	public bool LEMBJAEMJED(long BPJLDBDKBIJ, long KKFDHGLGLHO, CIACFOCFAGD GFCMBFDFODN, EMCJOAAJBFJ NPEKECDFDBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x18DEE20", Offset = "0x18DDA20", VA = "0x1818DEE20")]
	private void OIFBDFIIHJN(IBADDLHMPKI LLABLLJHCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x642E740", Offset = "0x642D340", VA = "0x18642E740", Slot = "7")]
	public bool JHFDAFLPJJM(long BPJLDBDKBIJ, long KKFDHGLGLHO, [Out] IBADDLHMPKI EBGOHPNLCGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x642E690", Offset = "0x642D290", VA = "0x18642E690", Slot = "8")]
	public bool DNLMFMPBDDE(long BPJLDBDKBIJ, long KKFDHGLGLHO, EMCJOAAJBFJ NPEKECDFDBG, [Out] IBADDLHMPKI EBGOHPNLCGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x642EC40", Offset = "0x642D840", VA = "0x18642EC40")]
	private void OGMAAFMNLIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x642E560", Offset = "0x642D160", VA = "0x18642E560", Slot = "9")]
	public void BPMNCEBNDOH(long BPJLDBDKBIJ, long KKFDHGLGLHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal abstract class HLJOKDNHPLE : BLEKKMGPAOF
{
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	protected enum PMICCKAJNCM : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class IENBHCBHKJC : IEnumerable<IBADDLHMPKI>, IEnumerable, IEnumerator<IBADDLHMPKI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private IBADDLHMPKI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public HLJOKDNHPLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private EMCJOAAJBFJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public EMCJOAAJBFJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		private IBADDLHMPKI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x8ECE30", Offset = "0x8EBA30", VA = "0x1808ECE30")]
		[DebuggerHidden]
		public IENBHCBHKJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x64398A0", Offset = "0x64384A0", VA = "0x1864398A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6439B80", Offset = "0x6438780", VA = "0x186439B80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x6439AD0", Offset = "0x64386D0", VA = "0x186439AD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IBADDLHMPKI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x6439AD0", Offset = "0x64386D0", VA = "0x186439AD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class OHNECMMBPGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public EMCJOAAJBFJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public OHNECMMBPGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x6445310", Offset = "0x6443F10", VA = "0x186445310")]
		internal object GKJCODEOFPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class CGIJKHPMMMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public HLJOKDNHPLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public CGIJKHPMMMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x64338F0", Offset = "0x64324F0", VA = "0x1864338F0")]
		internal void FPHJOJNKLOG(LKNBGJAOGOF.HFEJNPHDGDG ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B1")]
	protected readonly string AODPDLFLCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private readonly object HMPBOLAILGP;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract FHPGPLPGNGD PGPOMLDCHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x64390F0", Offset = "0x6437CF0", VA = "0x1864390F0")]
	protected HLJOKDNHPLE([CanBeNull] string AGCGPOCHCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x6438F00", Offset = "0x6437B00", VA = "0x186438F00", Slot = "5")]
	public bool PCECNJCNAFL(long BPJLDBDKBIJ, long KKFDHGLGLHO, EMCJOAAJBFJ NPEKECDFDBG, [Out] IBADDLHMPKI LLABLLJHCML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x64386F0", Offset = "0x64372F0", VA = "0x1864386F0", Slot = "6")]
	[IteratorStateMachine(typeof(IENBHCBHKJC))]
	public IEnumerable<IBADDLHMPKI> HPHMHBFCDIF(EMCJOAAJBFJ NPEKECDFDBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void KJCHMGPCOEO(Stream NDLAFPNEOHE, long BPJLDBDKBIJ, long KKFDHGLGLHO, CIACFOCFAGD GFCMBFDFODN);

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool GEJIELOMOEL(Stream AHOGFFIEGBA, long BPJLDBDKBIJ, long KKFDHGLGLHO, NAGBBGMJJGP EKEEGLCPOOC, [Out] CIACFOCFAGD GFCMBFDFODN);

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x6438780", Offset = "0x6437380", VA = "0x186438780", Slot = "7")]
	public IBADDLHMPKI KCHAFJAHPFO(long BPJLDBDKBIJ, long KKFDHGLGLHO, CIACFOCFAGD GFCMBFDFODN, EMCJOAAJBFJ NPEKECDFDBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo EMKFLAIPGFL(long BPJLDBDKBIJ, long KKFDHGLGLHO, EMCJOAAJBFJ NPEKECDFDBG, PMICCKAJNCM ICCHMCBPANI);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo IGFDMHMMBAH(EMCJOAAJBFJ NPEKECDFDBG, PMICCKAJNCM ICCHMCBPANI);

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x6438B00", Offset = "0x6437700", VA = "0x186438B00")]
	protected void KMDKAJNGNCK(LKNBGJAOGOF.HFEJNPHDGDG PJPLELBOECH, string BJKEGONNGBL, FileInfo FBEOLAADIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x6438B70", Offset = "0x6437770", VA = "0x186438B70")]
	internal bool NKFGAOFGKJK(FileInfo IFLPGHNFDFF, long BPJLDBDKBIJ, long KKFDHGLGLHO, [Out] CIACFOCFAGD GFCMBFDFODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
	private void JJBOIFIONPP(Exception BJFILFAGADB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal class BGLMELAHPIE : HLJOKDNHPLE
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public override FHPGPLPGNGD PGPOMLDCHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xA73C40", Offset = "0xA72840", VA = "0x180A73C40", Slot = "8")]
		get
		{
			return default(FHPGPLPGNGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x64321D0", Offset = "0x6430DD0", VA = "0x1864321D0")]
	public BGLMELAHPIE([Optional] string AGCGPOCHCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x6431670", Offset = "0x6430270", VA = "0x186431670")]
	private void EDNPNDFKLCE(EMCJOAAJBFJ NPEKECDFDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x6431F40", Offset = "0x6430B40", VA = "0x186431F40", Slot = "9")]
	internal override void KJCHMGPCOEO(Stream NDLAFPNEOHE, long BPJLDBDKBIJ, long KKFDHGLGLHO, CIACFOCFAGD GFCMBFDFODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x64317E0", Offset = "0x64303E0", VA = "0x1864317E0", Slot = "10")]
	internal override bool GEJIELOMOEL(Stream AHOGFFIEGBA, long BPJLDBDKBIJ, long KKFDHGLGLHO, NAGBBGMJJGP EKEEGLCPOOC, [Out] CIACFOCFAGD GFCMBFDFODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x64316F0", Offset = "0x64302F0", VA = "0x1864316F0", Slot = "11")]
	protected override FileInfo EMKFLAIPGFL(long BPJLDBDKBIJ, long KKFDHGLGLHO, EMCJOAAJBFJ NPEKECDFDBG, PMICCKAJNCM ICCHMCBPANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x6431E30", Offset = "0x6430A30", VA = "0x186431E30", Slot = "12")]
	protected override DirectoryInfo IGFDMHMMBAH(EMCJOAAJBFJ NPEKECDFDBG, PMICCKAJNCM ICCHMCBPANI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal sealed class CNNJBOPCDBD : HLJOKDNHPLE
{
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private static readonly byte[] PPNDANAOAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private readonly byte[] OCMOLNLADFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private readonly byte[] MDHFBFDGFBD;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override FHPGPLPGNGD PGPOMLDCHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x53CF4B0", Offset = "0x53CE0B0", VA = "0x1853CF4B0", Slot = "8")]
		get
		{
			return default(FHPGPLPGNGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x6434930", Offset = "0x6433530", VA = "0x186434930")]
	public CNNJBOPCDBD([Optional] string AGCGPOCHCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x64345E0", Offset = "0x64331E0", VA = "0x1864345E0", Slot = "9")]
	internal override void KJCHMGPCOEO(Stream NDLAFPNEOHE, long BPJLDBDKBIJ, long KKFDHGLGLHO, CIACFOCFAGD GFCMBFDFODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x6433BE0", Offset = "0x64327E0", VA = "0x186433BE0", Slot = "10")]
	internal override bool GEJIELOMOEL(Stream AHOGFFIEGBA, long BPJLDBDKBIJ, long KKFDHGLGLHO, NAGBBGMJJGP EKEEGLCPOOC, [Out] CIACFOCFAGD GFCMBFDFODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x6434520", Offset = "0x6433120", VA = "0x186434520")]
	private void IPFEOJAGJNL(byte[] FEGEJBFJFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x6433AB0", Offset = "0x64326B0", VA = "0x186433AB0", Slot = "11")]
	protected override FileInfo EMKFLAIPGFL(long BPJLDBDKBIJ, long KKFDHGLGLHO, EMCJOAAJBFJ NPEKECDFDBG, PMICCKAJNCM ICCHMCBPANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x6434410", Offset = "0x6433010", VA = "0x186434410", Slot = "12")]
	protected override DirectoryInfo IGFDMHMMBAH(EMCJOAAJBFJ NPEKECDFDBG, PMICCKAJNCM ICCHMCBPANI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public enum FHPGPLPGNGD : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
internal class MPGDCJOJNNJ : BLEKKMGPAOF
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private sealed class KAHGMCPAPIF : IEnumerable<IBADDLHMPKI>, IEnumerable, IEnumerator<IBADDLHMPKI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private IBADDLHMPKI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public MPGDCJOJNNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private EMCJOAAJBFJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public EMCJOAAJBFJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private FHPGPLPGNGD[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private IEnumerator<IBADDLHMPKI> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		private IBADDLHMPKI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x8ECE30", Offset = "0x8EBA30", VA = "0x1808ECE30")]
		[DebuggerHidden]
		public KAHGMCPAPIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x643C560", Offset = "0x643B160", VA = "0x18643C560", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x643C180", Offset = "0x643AD80", VA = "0x18643C180", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x643C130", Offset = "0x643AD30", VA = "0x18643C130")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x643C510", Offset = "0x643B110", VA = "0x18643C510", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x643C460", Offset = "0x643B060", VA = "0x18643C460", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IBADDLHMPKI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x643C460", Offset = "0x643B060", VA = "0x18643C460", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private readonly FHPGPLPGNGD[] KKACNKFENMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private readonly Dictionary<FHPGPLPGNGD, BLEKKMGPAOF> CIPGCFGHKJK;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public FHPGPLPGNGD PGPOMLDCHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x6440ED0", Offset = "0x643FAD0", VA = "0x186440ED0", Slot = "4")]
		get
		{
			return default(FHPGPLPGNGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x64413E0", Offset = "0x643FFE0", VA = "0x1864413E0")]
	[UnityEngine.Scripting.Preserve]
	public MPGDCJOJNNJ(params BLEKKMGPAOF[] LLEGBJAJKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x6441290", Offset = "0x643FE90", VA = "0x186441290", Slot = "5")]
	public bool PCECNJCNAFL(long BPJLDBDKBIJ, long KKFDHGLGLHO, EMCJOAAJBFJ NPEKECDFDBG, [Out] IBADDLHMPKI LLABLLJHCML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x6441070", Offset = "0x643FC70", VA = "0x186441070")]
	private void MADFCOHDLFE(int GFOCENGDBAB, long BPJLDBDKBIJ, long KKFDHGLGLHO, EMCJOAAJBFJ NPEKECDFDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x6440F00", Offset = "0x643FB00", VA = "0x186440F00", Slot = "6")]
	[IteratorStateMachine(typeof(KAHGMCPAPIF))]
	public IEnumerable<IBADDLHMPKI> HPHMHBFCDIF(EMCJOAAJBFJ NPEKECDFDBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x6440F90", Offset = "0x643FB90", VA = "0x186440F90", Slot = "7")]
	public IBADDLHMPKI KCHAFJAHPFO(long BPJLDBDKBIJ, long KKFDHGLGLHO, CIACFOCFAGD GFCMBFDFODN, EMCJOAAJBFJ NPEKECDFDBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal static class GKCMJOONKGI
{
	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x64375D0", Offset = "0x64361D0", VA = "0x1864375D0")]
	internal static byte[] BKFCBPIAIBF(byte[] FEGEJBFJFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x6437690", Offset = "0x6436290", VA = "0x186437690")]
	public static void HPLPOOJLDAA(Stream BOOOCBOEPIH, byte[] GMCLOPHCPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x6437710", Offset = "0x6436310", VA = "0x186437710")]
	public static bool IFLGFBCLMFD(Stream BOOOCBOEPIH, long GLAGBACKGHK, NAGBBGMJJGP CEABFGEBFGH, [Out] byte[] DGAHOGHFEIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal sealed class KGFOGOJGNNC : IBADDLHMPKI, IEquatable<IBADDLHMPKI>, IEquatable<KGFOGOJGNNC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private readonly HLJOKDNHPLE HKKNPMKAJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	public readonly FileInfo LCFFOCHGJIG;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public FHPGPLPGNGD PGPOMLDCHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x643C980", Offset = "0x643B580", VA = "0x18643C980", Slot = "9")]
		get
		{
			return default(FHPGPLPGNGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public DateTime GDGCKNKHKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x643C660", Offset = "0x643B260", VA = "0x18643C660", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x643CBF0", Offset = "0x643B7F0", VA = "0x18643CBF0")]
	public KGFOGOJGNNC(HLJOKDNHPLE AGCGCOFJBNG, FileInfo IFLPGHNFDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x643CB40", Offset = "0x643B740", VA = "0x18643CB40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x643C9B0", Offset = "0x643B5B0", VA = "0x18643C9B0", Slot = "5")]
	public void FJJEMMOCOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x643CA70", Offset = "0x643B670", VA = "0x18643CA70", Slot = "6")]
	public bool GLHPEEKGNJK(long BPJLDBDKBIJ, long KKFDHGLGLHO, [Out] CIACFOCFAGD GFCMBFDFODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x643C6F0", Offset = "0x643B2F0", VA = "0x18643C6F0", Slot = "7")]
	public bool Equals(IBADDLHMPKI LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x643C8C0", Offset = "0x643B4C0", VA = "0x18643C8C0", Slot = "8")]
	public bool Equals(KGFOGOJGNNC LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x643C7D0", Offset = "0x643B3D0", VA = "0x18643C7D0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x643CAB0", Offset = "0x643B6B0", VA = "0x18643CAB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public delegate void NAGBBGMJJGP(LKNBGJAOGOF.HFEJNPHDGDG PNMADGFELNC, string EOOPGFAEMIH);
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal interface BLEKKMGPAOF
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	FHPGPLPGNGD PGPOMLDCHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PCECNJCNAFL(long BPJLDBDKBIJ, long KKFDHGLGLHO, EMCJOAAJBFJ NPEKECDFDBG, [Out] IBADDLHMPKI LLABLLJHCML);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<IBADDLHMPKI> HPHMHBFCDIF(EMCJOAAJBFJ NPEKECDFDBG);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IBADDLHMPKI KCHAFJAHPFO(long BPJLDBDKBIJ, long KKFDHGLGLHO, CIACFOCFAGD GFCMBFDFODN, EMCJOAAJBFJ NPEKECDFDBG);
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
