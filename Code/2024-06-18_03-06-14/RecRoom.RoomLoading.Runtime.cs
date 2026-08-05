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
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F688A0", Offset = "0x6F672A0", VA = "0x186F688A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : MBMEJMGLEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F65100", Offset = "0x6F63B00", VA = "0x186F65100", Slot = "4")]
		public override void PMAGAGNLFOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GPDCFNDCBJD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F780", Offset = "0x6F5E180", VA = "0x186F5F780")]
	public GPDCFNDCBJD(string BDCMABOIIFF, Exception GOOPONCNKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class CNGMLMFCIIA : MAMDFHNPOLB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct KLFPILJBKNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BCDAPHNNAIF>> <>t__builder;

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
		private TaskAwaiter<KACGBILNGHJ<BCDAPHNNAIF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F641B0", Offset = "0x6F62BB0", VA = "0x186F641B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F643F0", Offset = "0x6F62DF0", VA = "0x186F643F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MBMLKEEAHAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<DBOECMDDHEK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<DBOECMDDHEK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F65350", Offset = "0x6F63D50", VA = "0x186F65350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F65560", Offset = "0x6F63F60", VA = "0x186F65560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	[UnityEngine.Scripting.Preserve]
	public CNGMLMFCIIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F503C0", Offset = "0x6F4EDC0", VA = "0x186F503C0", Slot = "4")]
	[AsyncStateMachine(typeof(KLFPILJBKNK))]
	public Task<IReadOnlyList<BCDAPHNNAIF>> JAFEMCMNDBM(long ONILLAPMLEN, long EMDKAGDEANA, [Optional] CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F502B0", Offset = "0x6F4ECB0", VA = "0x186F502B0", Slot = "5")]
	[AsyncStateMachine(typeof(MBMLKEEAHAG))]
	public Task<IReadOnlyList<DBOECMDDHEK>> GHHNGJGOPFD(IReadOnlyList<int> EJDCOMLJIMH, [Optional] CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MIILFHNDLHP : IEquatable<MIILFHNDLHP>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int HJOAMEJDINA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	DBOECMDDHEK MALNPHOCPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime DCKCLFOBENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	HGJDEKPLFJG? GELBDAIDGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ABOCGEICNEL? ELABBDONOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	PNCPAIJGIFN MMMDFKMHGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<EOMKIGIPEDC> EMLFLNMHGEB();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum PNCPAIJGIFN
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MAMDFHNPOLB
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<BCDAPHNNAIF>> JAFEMCMNDBM(long ONILLAPMLEN, long EMDKAGDEANA, [Optional] CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<DBOECMDDHEK>> GHHNGJGOPFD(IReadOnlyList<int> EJDCOMLJIMH, [Optional] CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NKPFIAIDGNN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class IOEBBGCFBFM : MIILFHNDLHP, IEquatable<MIILFHNDLHP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct CLMPKGJEAGH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<EOMKIGIPEDC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IOEBBGCFBFM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private NNDGPOAOJKF <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<LGDDBNGBFNG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<EOMKIGIPEDC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F4FDA0", Offset = "0x6F4E7A0", VA = "0x186F4FDA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F50240", Offset = "0x6F4EC40", VA = "0x186F50240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly BCDAPHNNAIF DKCKBCMAMLM;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int HJOAMEJDINA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x855090", Offset = "0x853A90", VA = "0x180855090", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DBOECMDDHEK MALNPHOCPLH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime IIMGOHIPHFB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5B0A590", Offset = "0x5B08F90", VA = "0x185B0A590", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HGJDEKPLFJG? GELBDAIDGJD
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1BED7B0", Offset = "0x1BEC1B0", VA = "0x181BED7B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ABOCGEICNEL? ELABBDONOJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5B0A670", Offset = "0x5B09070", VA = "0x185B0A670", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public PNCPAIJGIFN MMMDFKMHGJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8B8450", Offset = "0x8B6E50", VA = "0x1808B8450", Slot = "10")]
			get
			{
				return default(PNCPAIJGIFN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F63770", Offset = "0x6F62170", VA = "0x186F63770", Slot = "9")]
		[AsyncStateMachine(typeof(CLMPKGJEAGH))]
		public Task<EOMKIGIPEDC> EMLFLNMHGEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F63A60", Offset = "0x6F62460", VA = "0x186F63A60")]
		public IOEBBGCFBFM(int HHHGIMDDNLI, DBOECMDDHEK AAKPBDNGJFP, BCDAPHNNAIF DKCKBCMAMLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F63870", Offset = "0x6F62270", VA = "0x186F63870", Slot = "11")]
		public bool Equals(MIILFHNDLHP HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F63900", Offset = "0x6F62300", VA = "0x186F63900", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F639A0", Offset = "0x6F623A0", VA = "0x186F639A0")]
		private bool GLPBBCJOFKA(IOEBBGCFBFM HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F639E0", Offset = "0x6F623E0", VA = "0x186F639E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class LIFJKIBCAEH : MIILFHNDLHP, IEquatable<MIILFHNDLHP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct GIIMOIAJDCE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<EOMKIGIPEDC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public LIFJKIBCAEH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<EOMKIGIPEDC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F5E630", Offset = "0x6F5D030", VA = "0x186F5E630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F5E860", Offset = "0x6F5D260", VA = "0x186F5E860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly OPHHGBFNKCM JAALOJJOAEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HGJDEKPLFJG OIPADECPHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly ABOCGEICNEL INNECPBLKBA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int HJOAMEJDINA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F64460", Offset = "0x6F62E60", VA = "0x186F64460", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DBOECMDDHEK MALNPHOCPLH
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F644A0", Offset = "0x6F62EA0", VA = "0x186F644A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime IIMGOHIPHFB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F647C0", Offset = "0x6F631C0", VA = "0x186F647C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HGJDEKPLFJG? GELBDAIDGJD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F648F0", Offset = "0x6F632F0", VA = "0x186F648F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ABOCGEICNEL? ELABBDONOJE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F64530", Offset = "0x6F62F30", VA = "0x186F64530", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public PNCPAIJGIFN MMMDFKMHGJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4A0", Offset = "0x8BDEA0", VA = "0x1808BF4A0", Slot = "10")]
			get
			{
				return default(PNCPAIJGIFN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x10CB580", Offset = "0x10C9F80", VA = "0x1810CB580")]
		public LIFJKIBCAEH(OPHHGBFNKCM CFEFPIPMPFL, HGJDEKPLFJG GCKMCMFECPF, ABOCGEICNEL KCMPACDKMII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F64580", Offset = "0x6F62F80", VA = "0x186F64580", Slot = "9")]
		[AsyncStateMachine(typeof(GIIMOIAJDCE))]
		public Task<EOMKIGIPEDC> EMLFLNMHGEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F64720", Offset = "0x6F63120", VA = "0x186F64720", Slot = "11")]
		public bool Equals(MIILFHNDLHP HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F64670", Offset = "0x6F63070", VA = "0x186F64670", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F64810", Offset = "0x6F63210", VA = "0x186F64810")]
		private bool GLPBBCJOFKA(LIFJKIBCAEH HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F64870", Offset = "0x6F63270", VA = "0x186F64870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PEFIEAOHKII : MIILFHNDLHP, IEquatable<MIILFHNDLHP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct EFJAIOLJHLB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<EOMKIGIPEDC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<EOMKIGIPEDC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F537B0", Offset = "0x6F521B0", VA = "0x186F537B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F539F0", Offset = "0x6F523F0", VA = "0x186F539F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly DBOECMDDHEK OMBKJKPHKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly HGJDEKPLFJG OIPADECPHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly ABOCGEICNEL INNECPBLKBA;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int HJOAMEJDINA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F69780", Offset = "0x6F68180", VA = "0x186F69780", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public DBOECMDDHEK MALNPHOCPLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime IIMGOHIPHFB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public HGJDEKPLFJG? GELBDAIDGJD
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F69C60", Offset = "0x6F68660", VA = "0x186F69C60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ABOCGEICNEL? ELABBDONOJE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F697A0", Offset = "0x6F681A0", VA = "0x186F697A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public PNCPAIJGIFN MMMDFKMHGJI
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "10")]
			get
			{
				return default(PNCPAIJGIFN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x10CB580", Offset = "0x10C9F80", VA = "0x1810CB580")]
		public PEFIEAOHKII(DBOECMDDHEK AAKPBDNGJFP, HGJDEKPLFJG GCKMCMFECPF, ABOCGEICNEL KCMPACDKMII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6F697F0", Offset = "0x6F681F0", VA = "0x186F697F0", Slot = "9")]
		[AsyncStateMachine(typeof(EFJAIOLJHLB))]
		public Task<EOMKIGIPEDC> EMLFLNMHGEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F698C0", Offset = "0x6F682C0", VA = "0x186F698C0", Slot = "11")]
		public bool Equals(MIILFHNDLHP HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F699D0", Offset = "0x6F683D0", VA = "0x186F699D0", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6F69BD0", Offset = "0x6F685D0", VA = "0x186F69BD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6F69AF0", Offset = "0x6F684F0", VA = "0x186F69AF0")]
		private bool GLPBBCJOFKA(PEFIEAOHKII HENLEJBGFIE)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct NCJPDAOHIJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<MIILFHNDLHP>> <>t__builder;

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
		public NKPFIAIDGNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<BCDAPHNNAIF> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<BCDAPHNNAIF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, DBOECMDDHEK account, BCDAPHNNAIF roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6F66830", Offset = "0x6F65230", VA = "0x186F66830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F67660", Offset = "0x6F66060", VA = "0x186F67660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct HEDEHFKEFPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, DBOECMDDHEK account, BCDAPHNNAIF roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<BCDAPHNNAIF> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NKPFIAIDGNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<DBOECMDDHEK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6F60E80", Offset = "0x6F5F880", VA = "0x186F60E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F61860", Offset = "0x6F60260", VA = "0x186F61860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ADMIFOPDLNA FIMGOAJAHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MAMDFHNPOLB LOIBHKCLHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NAMBLCHFHOF ONIPDLABFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CODGJNGJIAK<(long, long), IReadOnlyList<BCDAPHNNAIF>> HHIECFKCAFK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F68770", Offset = "0x6F67170", VA = "0x186F68770")]
	[UnityEngine.Scripting.Preserve]
	public NKPFIAIDGNN([OHLKLPAILPF(null)] MAMDFHNPOLB OEHGIFCBDBC, [OHLKLPAILPF(null)] NAMBLCHFHOF LEFCFIDGCGN, [OHLKLPAILPF(null)] ADMIFOPDLNA HPFMKJHEFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F68510", Offset = "0x6F66F10", VA = "0x186F68510")]
	[AsyncStateMachine(typeof(NCJPDAOHIJL))]
	public Task<IList<MIILFHNDLHP>> PCCGIBJNGDP(long ONILLAPMLEN, long KOIDPPGJKOA, bool DKJENOCHLMC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F68370", Offset = "0x6F66D70", VA = "0x186F68370")]
	private bool LOHNPBNFCEE(DateTime? BBPFBEEBMPC, long ONILLAPMLEN, long KOIDPPGJKOA, [Out] OPHHGBFNKCM HJPACFIDIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F68660", Offset = "0x6F67060", VA = "0x186F68660")]
	[AsyncStateMachine(typeof(HEDEHFKEFPF))]
	private Task<IReadOnlyList<(int, DBOECMDDHEK, BCDAPHNNAIF)>> PJLDHJFKCAB(IReadOnlyList<BCDAPHNNAIF> LKMOPDGMOJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NAMBLCHFHOF
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<OPHHGBFNKCM> CCLIKCACPPB;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HKKBIPNCJOM(long ONILLAPMLEN, long KOIDPPGJKOA, POAAKMMADBH FPIGOBMKHAC, MFIOOOIMKCN JHBPEHBAAIE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OLMNBDFOBPE(long ONILLAPMLEN, long KOIDPPGJKOA, [Out] OPHHGBFNKCM HJPACFIDIHD);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GDHNKKMKGDC(long ONILLAPMLEN, long KOIDPPGJKOA, MFIOOOIMKCN JHBPEHBAAIE, [Out] OPHHGBFNKCM HJPACFIDIHD);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHLCMGGFFCN(long ONILLAPMLEN, long KOIDPPGJKOA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface KFNFOHABKOA : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GKAHCBPGFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task COFMEMDBABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGICFDFDKEO(Task JCINMAJOONI, string NMBCBCAFPFO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface BEGLGPNHNFE : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EOMKIGIPEDC> EABIFPNCGAL(OPHHGBFNKCM HJPACFIDIHD);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ADOEFNDKAHM(CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface AFFIPNIMMLK : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	BJHEOJGGHKA AOKFJBPNPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMPCBDMHGFJ();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGJODHPBIKH();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface PEPBKNNAOIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface LEMGGJFEOOO
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan JEFGBKDIJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan IMGNENHDAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan NAFMCDBAKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan JJIHIDFBGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool PBANAGKDBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool CDNHBCEOBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DDPINMGJKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int MOEKOOKCOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool MDPDGNOBKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool APHFHMPEBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool KKIHEHAIMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum CMICLIIEKOM
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum MHJFPILMNPL
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
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct MABPGBIBHNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long HAMKFNPEKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long EMDKAGDEANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly CMICLIIEKOM ADDOHDGDFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception MIAILPDKHKL;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F65330", Offset = "0x6F63D30", VA = "0x186F65330")]
	public MABPGBIBHNO(long HAMKFNPEKKG, long EMDKAGDEANA, CMICLIIEKOM ADDOHDGDFOD, [CanBeNull] Exception MIAILPDKHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F652E0", Offset = "0x6F63CE0", VA = "0x186F652E0")]
	public static MABPGBIBHNO EOFJCPMGPOI(MDCEFFOBCGJ CDCPGANMGBF, CMICLIIEKOM ADDOHDGDFOD, [Optional] Exception MIAILPDKHKL)
	{
		return default(MABPGBIBHNO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void NCCEANPKCBH(MABPGBIBHNO FMGABMMAANN);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface MEMFMICPHOA : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action IDLOKPENNGD;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NCCEANPKCBH IKGBHBJKFDD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NCCEANPKCBH GKJHGMKBBMF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event NCCEANPKCBH BFGLDDCPING;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<MHJFPILMNPL, bool> CHOMICPPMKH;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GFIIGIEJDDO();

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LDPJKIBINJO(MABPGBIBHNO FMGABMMAANN);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GKIPHPNNGKP(MABPGBIBHNO FMGABMMAANN);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GDHNMHNNICK(MABPGBIBHNO FMGABMMAANN);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MFAFIJFCPAF(MHJFPILMNPL KFHICACKEFH, bool FBPJJEBDJKF);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface NCJGEHACABB : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AIHHELFPJFL();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDHENOBLFIO();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface PMOONCPIMJF : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	TaskStatus LIKFHNLIFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KDDOLCKKADE(MDCEFFOBCGJ HDKECBFDELN, NDBDNDIBEKL EDPPKGIKACG, CancellationToken NEGOEBJOBPE);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class KJPIFFLKOFD
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F64160", Offset = "0x6F62B60", VA = "0x186F64160")]
	public static bool GELHGFIPIGE(this PMOONCPIMJF BJLKGEMPJDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task OPENLMIJNEO(FNGILHDDEFI IJFOGIEFCHH, CancellationToken JCIFCENKMKP);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface EHOAKANHCDL : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBJAOCECBBB(OPENLMIJNEO BEBKGACGLJP);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface DPFMBDJKAOB : NNDGPOAOJKF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CancellationToken DGPMCDPIGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	GPECMKAJNMD JKPNPOAFODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	FGAKHKLMNEL IKCEBBANDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	AAEAMPAFKHI BIGLLCCPGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	OKJDCNBIHPD NCEODIICHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	GLPEGFIAGPD LBIPKIKGCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HGFIBKFDNAE LLDBDGMEPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NIIHFLNBIAN KBGLHNGHLEK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	BDMPGCNODMK MKNDMENJIPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	KFNFOHABKOA KCLBNDNNLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	BEGLGPNHNFE GCDNCCJPKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	MEMFMICPHOA JLIGOBCGIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NCJGEHACABB DEEMNFGDGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	PMOONCPIMJF LCOLPHGEJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	EHOAKANHCDL IHHJHLJNGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	NNKOOGLGKLN KHPIIEGIEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	OHKGMLEODIH HKJFOCHLHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	DHMPDKOAFJG ELADFOOKMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GHLGEHANDPL ILEBFHCJMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	NMPOIBENFNL PEGDJBFJFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MGJBDANHKIB NMEMNDLDKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	MMGAKMADFKD AGBEICHBFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	FGAGPKMFOJM ENDNBNNBEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	EHPEKAALDOI EOIGMBHHFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	KPLBFHGIACD EBMLJFALDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	AFFIPNIMMLK JBOKPBILMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	LEMGGJFEOOO HBGJDHEAOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	PGLHENLHOGA DELNBDDDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	NAMBLCHFHOF LMCNMHDHOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	JFMCNEFMLCF PEALEJJFHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	CHEBGDLLLJJ NNEDNNIFNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	KIIIEFGAAIL GECDDOCLOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void LFOAJEGLCGE(NDBDNDIBEKL OPEFCBPFJAO);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface NNKOOGLGKLN : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHOKOLNOMNB KODKNHDNNHA(Guid ANGIPKEDDGP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PLMGPBLKDNE(Guid ANGIPKEDDGP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MDBNINMKKHC(Guid ANGIPKEDDGP, Task CLMNIFMLNNI);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NHGFACPKAGD(Guid ANGIPKEDDGP, EOMKIGIPEDC DHJBHNGLNGE);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(EOMKIGIPEDC, Task)> ICLPJOOAMIL(Guid ANGIPKEDDGP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface CFLHEBDIOOM : PEPBKNNAOIB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface OHKGMLEODIH : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLCOLMLICPG(KDEKOFBPMEA BDCMABOIIFF);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJBAOKAPNEM(KDEKOFBPMEA BDCMABOIIFF);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<INIFIJEJACJ> GFGFINMFFFN(CancellationToken ICBCOAMELEI);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface DHMPDKOAFJG : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHOKOLNOMNB HKGJAPFMHOF(KDEKOFBPMEA IMKHDOECCFO);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCEMKFMJBFG(Guid ANGIPKEDDGP, Task CLMNIFMLNNI);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface GHLGEHANDPL : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EOMKIGIPEDC> ILEBFHCJMGG(KDEKOFBPMEA MNFCPILNGAF);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface NMPOIBENFNL : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CCPGLNKCEAO> GIDBKHJMIMJ(MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, MDCEFFOBCGJ HDKECBFDELN, CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface MMGAKMADFKD : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EOMKIGIPEDC LPHNNPBGKGD(JDKCNIBKGKE BEJOAPBJCCE);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BDLHNNPNBDC(string LLLIHNDJKKC);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface MGJBDANHKIB : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KDEKOFBPMEA> KCIELDBMDJL(KDEKOFBPMEA BJLMEIJMPBN, KJCKCCPLGMI GOFDDCECDPF, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KDEKOFBPMEA> MECIOKMLJAM(CancellationToken AOLOJHLCMLE, KJCKCCPLGMI GOFDDCECDPF);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DCDGPMPFNEE CKBOIEOAPCA(PBCHFFOPJGA NNOOHLHBLNB, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DCDGPMPFNEE PHMJBBLKADK(PBCHFFOPJGA NNOOHLHBLNB, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface FGAGPKMFOJM : PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EOMKIGIPEDC JINGFOBANPM(JDKCNIBKGKE BEJOAPBJCCE, INIFIJEJACJ BCMDHKBDLJG);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EOMKIGIPEDC AOFNBGKMODN(JDKCNIBKGKE MOIHANJJPJC);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface EHPEKAALDOI
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKNGPKIJJPF(NBNEEAGBCAD LNHHGPMBCGH);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MECGIGCDLDI(NBNEEAGBCAD LNHHGPMBCGH);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KKPHNEJPOIF(NBNEEAGBCAD LNHHGPMBCGH);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CEICLGMNHAM(NBNEEAGBCAD LNHHGPMBCGH);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class NBNEEAGBCAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly MDCEFFOBCGJ JANBMGDHJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> GBGLKFKLNJN;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public MIJAEHJIGEB<string> CIPFAFBCBJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x850E40", Offset = "0x84F840", VA = "0x180850E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	public NBNEEAGBCAD(MDCEFFOBCGJ BOKMEBAEBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F66760", Offset = "0x6F65160", VA = "0x186F66760")]
	public NBNEEAGBCAD PBNCICPPLFL(string LDDEKIBHION, string DBOBEHLEAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F666D0", Offset = "0x6F650D0", VA = "0x186F666D0")]
	public bool KHCCHCFFCAD([Out] IEnumerable<KeyValuePair<string, string>> MKPABJEGMJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x61D6B50", Offset = "0x61D5550", VA = "0x1861D6B50")]
	public NBNEEAGBCAD FOPOBKNAAPA(MIJAEHJIGEB<string> GJLENOHHOLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PGLHENLHOGA
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool HGNMBEEHACM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string BOIFMIIKDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool PBHNCGFJJLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AKDHOBLKKGE();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IBINFMOPLLH HOILBCECJOA(long MAKJFMMHJCI);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HJEPJPFHOMO<DINCFJKGGOK, FLIADCLBMOC> NNJCNJDHJNP(long MAKJFMMHJCI);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HJEPJPFHOMO<DINCFJKGGOK, HOHHBPKCDBA> BGMOADAPODN(long MAKJFMMHJCI);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HJEPJPFHOMO<long, ABGOPOHKIII> GOLIEDHGDMC();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DGMHOKODPAN(long MAKJFMMHJCI, [Out] bool CJJNPHEEHAA);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> KCAGFGENICI(byte[] BGFCCPEMGBP, byte[] GLEONALLPGG, CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface NNDGPOAOJKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool GELHGFIPIGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool NCFIHFAKGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	NDBDNDIBEKL DFOCIIEOJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action IDLOKPENNGD;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NCCEANPKCBH IKGBHBJKFDD;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event NCCEANPKCBH GKJHGMKBBMF;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NCCEANPKCBH BFGLDDCPING;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MHJFPILMNPL, bool> CHOMICPPMKH;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NDHENOBLFIO();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GHEKEGDBODK DNDKIHFKGOJ();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PGGHFFCMACE JBNPCMEBOOM();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<EOMKIGIPEDC> EABIFPNCGAL(OPHHGBFNKCM CFEFPIPMPFL);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task ADOEFNDKAHM(CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface GLPEGFIAGPD
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool AEPNPEJHGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string GAHPNPLFFKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJILLGCBBKK(Scene KPAKJCJGJGG);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FBOHILLPGII(DNPODLDDAAK NHICACKPIHH, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LNNHCHHAKGE();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task MDLMCKEGGLI();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface OKJDCNBIHPD
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	AELMJKLMOFJ DEOLIAGACBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool LNLDBBIBCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool GPKPAPEGOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool OCDEABHLPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool PDEHFDABDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int ODHHFFLJJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool GEIEGKKGMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool LHDBBGBCKDB
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	byte EOMHJKEKKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	byte CJHELIHNHFE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool DLAFGKJNLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool PEHHICKLCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool CEDIGMNJCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float PCFGFPEDIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> PLFNIHEBGJD;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GPECMKAJNMD BCMEOJPBDBH(GPECMKAJNMD HJCMBDGAKNE);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDNCHHFIAAP(GPECMKAJNMD FOPICBKBDEP);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GGLICKHFMIE();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task IHCMAMFKKAN(MIJAEHJIGEB<string>.OBFKFOAMCEP BHMMIFLCCAB, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JDOEOMKHBBJ(float FDEJJPMNJPD);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DADAHCBPNFM(string MLBCIJADJGF);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<DJNNHLJMOHO> GOHMAHKGLHH();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable ENDMCBAAFNH(object NIDJKNBFFJH, DJNNHLJMOHO MGAAFIBOMHF);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<OPNKHABJNFG> CJKEJEEPHID();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FLIADCLBMOC KPMBOGJBGGH(IEnumerable<APDBPBGHHNA> CFBOHCAIEKI);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AKGKEICMHHN(int KIPEDCEMNBN);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task NOMOHCOALLJ();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DMPMIIBPPDA();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool IKNHHPJJDPA();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task CIMHNDFKDJE(CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task HMLACKIKMFK(CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<EAGDKOGBKKK> DLOHBAINIPG(DateTime NFCBFCPFMGH, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> MGKHCCDACAN(CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AFIGIODFHBG(string BDCMABOIIFF = "", float IHJBBHNOLLJ = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "25")]
	OJELAFKBGBK BAIBKJDJDOP(AHFCPDKCLOG HPAKIFCHMJH, INCGGNCJBHD IKMJPHAJEME, HOHHBPKCDBA KKLNMGIECKN, IEnumerable<PersistenceView> GNJLLHOLMOD, KHGKNMHPLBK BMHDKBBCOMK);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GPAJAFMLCJA(HOHHBPKCDBA KKLNMGIECKN);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JBPNAOJNBDO(APDBPBGHHNA HDCEGHKDECL, [In] OJELAFKBGBK IBEMJDBLHEI);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task MBPKAHAOAPB(HOHHBPKCDBA IPPIJJOEADH, bool BIBMDHOPGNL, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task EKNFJJFIDEB(CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void JNOLCHFCHAB(long ONILLAPMLEN, long EMDKAGDEANA, LGDDBNGBFNG FCOGIFPLFKG, BCDAPHNNAIF PHONHKOHLOH, POAAKMMADBH FPIGOBMKHAC, DLCPLGMDJEG? CGDEKJPLMLA, BALIOMLHDAA? PPMCGNFPIFI);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void NFAJNIBEGAB(long ONILLAPMLEN, long EMDKAGDEANA, BALIOMLHDAA? PPMCGNFPIFI);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void OEFHFJFHFEK(PersistenceView ECBAILFAAPH);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool FPFDDPPDCFJ(PersistenceView BIAEPGIEGAH);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool HFAHMHOJOAO(APDBPBGHHNA HDCEGHKDECL, JBNFDDCMJOC ACEKHHBDICK, [Out] MIBMLBDBJNP FLKLDLDFPFF);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task KFLGJFLBFDN(CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void JOJAPPFKEMK();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable OIBADAHJHKE();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void DAIFOAPOLHC(HOHHBPKCDBA IPPIJJOEADH, JBNFDDCMJOC ACEKHHBDICK);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> AFHDJEBLIOC(FGAKHKLMNEL ILINKAEOFIO, CancellationToken AOLOJHLCMLE, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void NBODFCMFIGJ(CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<HCBBPJCCCOC> LNLHEJJDECP(BNOHNHKPIAE BJLMEIJMPBN);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<LGDDBNGBFNG> CDEDHOFFBFA(long ONILLAPMLEN, bool IIDLOGNLJHN, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<BCDAPHNNAIF> HDMLOAIOFCG(long ONILLAPMLEN, long EMDKAGDEANA, long PHHOGBMHKPJ, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<NCCIBDALGCO> PJNGFPBEDAJ(string GNFDFPFLGPO, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<NCCIBDALGCO> PFLKLPBAKHD(string GNFDFPFLGPO, long ONILLAPMLEN, long EMDKAGDEANA, string NCFBDPGOPGE, CBEKJIPBFJA.ECOGBAAIGGA IJFOGIEFCHH, CBEKJIPBFJA.ECOGBAAIGGA GLEONALLPGG, int FOBGMHODFPK);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool JKONBMHGHDA();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool PPMNCNAPNPM();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool COFAIIEMPME(IEnumerable<MIBMLBDBJNP> PBEFHHOBIPJ);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void IJFEMJFPEDI(List<GameObject> GBDMMKFPEFN);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "51")]
	float PEPBPOAMNNN();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> IFCNALJKKNJ(string GBJIEPEGCMH, LoadSceneMode BELDAKCNBKC, bool GLOIDKBGAML, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void CKODBCPCDCK();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void OBJBFLDPCDG(bool OPDIOPBPNGJ);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void PLDOEMMIEIF();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void MLENDLIDOHG();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void HPAELINEIHD(MDCEFFOBCGJ MBKCCCPKDIM);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "67")]
	Task DGHDDDIGNMN(MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task DJONIAGAGEK(MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task BAEDEIJAECC(MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task IJNBCIEEPKJ(MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "71")]
	IDisposable KFOECNFBGEA();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "72")]
	ODANEGNLBME KMEMDAEJIBC();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task FKLHCGLPMNO(CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface ODANEGNLBME
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FNHJOHLBIHK(CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AEPNNIGEOOA(CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct OJELAFKBGBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> FEGCCNJHLNO;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum EAGDKOGBKKK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct AHFCPDKCLOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string KNPBCEBCLLC;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface AELMJKLMOFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	MDCEFFOBCGJ CMLFDHLMGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	LGDDBNGBFNG BLKFMIEOHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	PPOBPODJIIJ BFBPPFMFMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool LKEHMBNEMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool OEDCHGAJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int GNNKIAJLAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action IBDHDGIAILM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> DAAKLMFGMGO;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CENKIAFLCLM();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.HLHLGAFEPGK> EGDEAIJCMFD(long MAKJFMMHJCI, [Optional] CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<CONHBEANPHH> LICFOPACOCC();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task FFHAOLIJKLP();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(MDCEFFOBCGJ, NDBDNDIBEKL) BJJFPKFNANM();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PHMNLMEJCDN DMNIDIPGOPP();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HGFCJNOAKEG(long MAKJFMMHJCI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface KPLBFHGIACD
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AMLMJCBJOAI([Out] IEnumerable<int> DDOHCBAKOBF);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNKAPMGMLOA(HFDCBECCBCM JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GFONLLHJENB(HFDCBECCBCM JCIFCENKMKP);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GHJABOJKDIA
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AGIPBFKANLB(EOMKIGIPEDC MBJHBACEHFE);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface FLDBFGJNDHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEEDIPIMILL(GIIJNDODGPL.ADOFNAPFDID EMKGIAGBKKH);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBDHDKGLKHD(GIIJNDODGPL.ADOFNAPFDID EMKGIAGBKKH);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HGFIBKFDNAE : FLDBFGJNDHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EOMKIGIPEDC GBLCCNHGHFI(JDKCNIBKGKE MOIHANJJPJC);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NIIHFLNBIAN : FLDBFGJNDHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EOMKIGIPEDC LPHNNPBGKGD(JDKCNIBKGKE FFJFLMHOJHA);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface IBINFMOPLLH
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FNBKHJCMJJM<DNPODLDDAAK, DNHFHLFKGGH>> DMGBFJLAJLK(string NCFBDPGOPGE, long MAKJFMMHJCI, long? ONILLAPMLEN, long? EMDKAGDEANA, NOJOBLOGLJC.NDKLKBMOBEN BAGEDLMCLDA, CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface HJEPJPFHOMO<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FNBKHJCMJJM<FOAIIODBMAA<TData>, DNHFHLFKGGH>> GPHBBCBNDJM(TGetDataArg PCNJMLOHDMH, CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class BFGKIKMMJDH : DPFMBDJKAOB, NNDGPOAOJKF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct OBHLGMBIKFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<EOMKIGIPEDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public BFGKIKMMJDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public OPHHGBFNKCM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<EOMKIGIPEDC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F68920", Offset = "0x6F67320", VA = "0x186F68920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F68BA0", Offset = "0x6F675A0", VA = "0x186F68BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct GMLGMENMKPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public BFGKIKMMJDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F4F0", Offset = "0x6F5DEF0", VA = "0x186F5F4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F720", Offset = "0x6F5E120", VA = "0x186F5F720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class GEPLGBJEJCN : IEnumerable<PEPBKNNAOIB>, IEnumerable, IEnumerator<PEPBKNNAOIB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private PEPBKNNAOIB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public BFGKIKMMJDH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private PEPBKNNAOIB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8A7B40", Offset = "0x8A6540", VA = "0x1808A7B40")]
		[DebuggerHidden]
		public GEPLGBJEJCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E180", Offset = "0x6F5CB80", VA = "0x186F5E180", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E5E0", Offset = "0x6F5CFE0", VA = "0x186F5E5E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E530", Offset = "0x6F5CF30", VA = "0x186F5E530", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PEPBKNNAOIB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E530", Offset = "0x6F5CF30", VA = "0x186F5E530", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource KKDGOKJNLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly GPECMKAJNMD FOPICBKBDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool MENBJDNCHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private LPNDNODEINF OCIFDIGAMEE;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public FGAKHKLMNEL IKCEBBANDMH
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x84EEB0", Offset = "0x84D8B0", VA = "0x18084EEB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x84EC10", Offset = "0x84D610", VA = "0x18084EC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public AAEAMPAFKHI BIGLLCCPGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x84FCE0", Offset = "0x84E6E0", VA = "0x18084FCE0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x84FE60", Offset = "0x84E860", VA = "0x18084FE60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public OKJDCNBIHPD NCEODIICHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x84FCD0", Offset = "0x84E6D0", VA = "0x18084FCD0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x84FD30", Offset = "0x84E730", VA = "0x18084FD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public GLPEGFIAGPD LBIPKIKGCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851270", VA = "0x180852870", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x852880", Offset = "0x851280", VA = "0x180852880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public HGFIBKFDNAE LLDBDGMEPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x84FCC0", Offset = "0x84E6C0", VA = "0x18084FCC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x84FE50", Offset = "0x84E850", VA = "0x18084FE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public NIIHFLNBIAN KBGLHNGHLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x84FE40", Offset = "0x84E840", VA = "0x18084FE40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x84FCB0", Offset = "0x84E6B0", VA = "0x18084FCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public BDMPGCNODMK MKNDMENJIPN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8550A0", Offset = "0x853AA0", VA = "0x1808550A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x855150", Offset = "0x853B50", VA = "0x180855150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public KFNFOHABKOA KCLBNDNNLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8550D0", Offset = "0x853AD0", VA = "0x1808550D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x855130", Offset = "0x853B30", VA = "0x180855130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public BEGLGPNHNFE GCDNCCJPKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x855180", Offset = "0x853B80", VA = "0x180855180", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x855040", Offset = "0x853A40", VA = "0x180855040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public MEMFMICPHOA JLIGOBCGIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9EA650", Offset = "0x9E9050", VA = "0x1809EA650", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9EA630", Offset = "0x9E9030", VA = "0x1809EA630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public NCJGEHACABB DEEMNFGDGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x855000", Offset = "0x853A00", VA = "0x180855000", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x855020", Offset = "0x853A20", VA = "0x180855020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public PMOONCPIMJF LCOLPHGEJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9DD510", Offset = "0x9DBF10", VA = "0x1809DD510", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9BC650", Offset = "0x9BB050", VA = "0x1809BC650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public EHOAKANHCDL IHHJHLJNGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x85B620", Offset = "0x85A020", VA = "0x18085B620", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x85B590", Offset = "0x859F90", VA = "0x18085B590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public NNKOOGLGKLN KHPIIEGIEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xB7E120", Offset = "0xB7CB20", VA = "0x180B7E120", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xB860D0", Offset = "0xB84AD0", VA = "0x180B860D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public CFLHEBDIOOM KFPAEHNBEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x93A6D0", Offset = "0x9390D0", VA = "0x18093A6D0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x935AB0", Offset = "0x9344B0", VA = "0x180935AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public OHKGMLEODIH HKJFOCHLHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x939E70", Offset = "0x938870", VA = "0x180939E70", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x93B410", Offset = "0x939E10", VA = "0x18093B410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public DHMPDKOAFJG ELADFOOKMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB850", Offset = "0x8BA250", VA = "0x1808BB850", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xB86110", Offset = "0xB84B10", VA = "0x180B86110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public GHLGEHANDPL ILEBFHCJMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3D0", Offset = "0x8BADD0", VA = "0x1808BC3D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA19490", Offset = "0xA17E90", VA = "0x180A19490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public NMPOIBENFNL PEGDJBFJFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x85B5D0", Offset = "0x859FD0", VA = "0x18085B5D0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x85B5E0", Offset = "0x859FE0", VA = "0x18085B5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public MGJBDANHKIB NMEMNDLDKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x897930", Offset = "0x896330", VA = "0x180897930", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9B8FA0", Offset = "0x9B79A0", VA = "0x1809B8FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public MMGAKMADFKD AGBEICHBFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA401F0", Offset = "0xA3EBF0", VA = "0x180A401F0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA401D0", Offset = "0xA3EBD0", VA = "0x180A401D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public FGAGPKMFOJM ENDNBNNBEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3F0", Offset = "0x8BADF0", VA = "0x1808BC3F0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xB860F0", Offset = "0xB84AF0", VA = "0x180B860F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public EHPEKAALDOI EOIGMBHHFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC400", Offset = "0x8BAE00", VA = "0x1808BC400", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC490", Offset = "0x9BAE90", VA = "0x1809BC490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public KPLBFHGIACD EBMLJFALDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BAD50", VA = "0x1808BC350", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xB860B0", Offset = "0xB84AB0", VA = "0x180B860B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public AFFIPNIMMLK JBOKPBILMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC360", Offset = "0x8BAD60", VA = "0x1808BC360", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xB862F0", Offset = "0xB84CF0", VA = "0x180B862F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public LEMGGJFEOOO HBGJDHEAOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8BC230", Offset = "0x8BAC30", VA = "0x1808BC230", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xB862D0", Offset = "0xB84CD0", VA = "0x180B862D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public PGLHENLHOGA DELNBDDDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8BC200", Offset = "0x8BAC00", VA = "0x1808BC200", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xB86250", Offset = "0xB84C50", VA = "0x180B86250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public NAMBLCHFHOF LMCNMHDHOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8BC160", Offset = "0x8BAB60", VA = "0x1808BC160", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public JFMCNEFMLCF PEALEJJFHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA55AF0", Offset = "0xA544F0", VA = "0x180A55AF0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public CHEBGDLLLJJ NNEDNNIFNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3E0", Offset = "0x8BADE0", VA = "0x1808BC3E0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public KIIIEFGAAIL GECDDOCLOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xAED720", Offset = "0xAEC120", VA = "0x180AED720", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public NDBDNDIBEKL DFOCIIEOJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xAED9D0", Offset = "0xAEC3D0", VA = "0x180AED9D0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xB86270", Offset = "0xB84C70", VA = "0x180B86270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private bool JJOPFABPIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DD60", Offset = "0x6F4C760", VA = "0x186F4DD60", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private bool GBNJCBMKLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6F4E0D0", Offset = "0x6F4CAD0", VA = "0x186F4E0D0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private CancellationToken CNMEMLNMGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DE10", Offset = "0x6F4C810", VA = "0x186F4DE10", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private GPECMKAJNMD IPHICKKGKEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action IEOJLPEOEKP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DEF0", Offset = "0x6F4C8F0", VA = "0x186F4DEF0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D990", Offset = "0x6F4C390", VA = "0x186F4D990", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event NCCEANPKCBH MJFLKPNMENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DE30", Offset = "0x6F4C830", VA = "0x186F4DE30", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6F4E260", Offset = "0x6F4CC60", VA = "0x186F4E260", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event NCCEANPKCBH AIDPEPBBNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D8B0", Offset = "0x6F4C2B0", VA = "0x186F4D8B0", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DCA0", Offset = "0x6F4C6A0", VA = "0x186F4DCA0", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event NCCEANPKCBH GAIAAILKPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DAA0", Offset = "0x6F4C4A0", VA = "0x186F4DAA0", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DE90", Offset = "0x6F4C890", VA = "0x186F4DE90", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<MHJFPILMNPL, bool> MAFEBBPMMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D850", Offset = "0x6F4C250", VA = "0x186F4D850", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DD00", Offset = "0x6F4C700", VA = "0x186F4DD00", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xB86270", Offset = "0xB84C70", VA = "0x180B86270", Slot = "36")]
	public void LFOAJEGLCGE(NDBDNDIBEKL OPEFCBPFJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E2C0", Offset = "0x6F4CCC0", VA = "0x186F4E2C0")]
	[UnityEngine.Scripting.Preserve]
	internal BFGKIKMMJDH([OHLKLPAILPF(null)] GPECMKAJNMD FOPICBKBDEP, [OHLKLPAILPF(null)] FGAKHKLMNEL ILINKAEOFIO, [OHLKLPAILPF(null)] AAEAMPAFKHI EJBKKDIKBLE, [OHLKLPAILPF(null)] OKJDCNBIHPD GLFIGPDLPBG, [OHLKLPAILPF(null)] GLPEGFIAGPD LENBAHKMAFP, [OHLKLPAILPF(null)] HGFIBKFDNAE CFFJPMMONGN, [OHLKLPAILPF(null)] NIIHFLNBIAN HGMPAJFOMBA, [OHLKLPAILPF(null)] BDMPGCNODMK NFHDCIEPBBH, [OHLKLPAILPF(null)] KFNFOHABKOA DCDEOEDJGFP, [OHLKLPAILPF(null)] BEGLGPNHNFE IOKEOCINAAH, [OHLKLPAILPF(null)] MEMFMICPHOA BOHBKMHODLB, [OHLKLPAILPF(null)] NCJGEHACABB BMNLBFGMFBD, [OHLKLPAILPF(null)] PMOONCPIMJF BJLKGEMPJDJ, [OHLKLPAILPF(null)] EHOAKANHCDL GCONENFMGAA, [OHLKLPAILPF(null)] NNKOOGLGKLN LDIEALKHGNA, [OHLKLPAILPF(null)] CFLHEBDIOOM AIDGDNHNLHH, [OHLKLPAILPF(null)] OHKGMLEODIH DBDKBGJLIJC, [OHLKLPAILPF(null)] DHMPDKOAFJG FELFOPBFACA, [OHLKLPAILPF(null)] GHLGEHANDPL EKEINOOPBGK, [OHLKLPAILPF(null)] NMPOIBENFNL BCHFAKBPIIG, [OHLKLPAILPF(null)] MMGAKMADFKD CHMMLABHLGN, [OHLKLPAILPF(null)] MGJBDANHKIB LIBJEBLDIFB, [OHLKLPAILPF(null)] FGAGPKMFOJM DDCGNFKBKBE, [OHLKLPAILPF(null)] EHPEKAALDOI LEANADMHLBP, [OHLKLPAILPF(null)] KPLBFHGIACD AEHNJKDNACC, [OHLKLPAILPF(null)] LEMGGJFEOOO FBFDHBHFJCB, [OHLKLPAILPF(null)] PGLHENLHOGA GFNBLDBMKBB, [OHLKLPAILPF(null)] NAMBLCHFHOF HBKDCKNCPLC, [OHLKLPAILPF(null)] JFMCNEFMLCF JGPMDJDNAIF, [OHLKLPAILPF(null)] CHEBGDLLLJJ PENBLNINCMJ, [OHLKLPAILPF(null)] KIIIEFGAAIL HNBLGIKEBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D9F0", Offset = "0x6F4C3F0", VA = "0x186F4D9F0")]
	private void CCPNKNOIBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DB00", Offset = "0x6F4C500", VA = "0x186F4DB00", Slot = "55")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DDC0", Offset = "0x6F4C7C0", VA = "0x186F4DDC0", Slot = "49")]
	private void IFGKEPNCICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DFB0", Offset = "0x6F4C9B0", VA = "0x186F4DFB0", Slot = "50")]
	private GHEKEGDBODK LHIHPINFIFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E040", Offset = "0x6F4CA40", VA = "0x186F4E040", Slot = "51")]
	private PGGHFFCMACE MLDABMDGCPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E150", Offset = "0x6F4CB50", VA = "0x186F4E150", Slot = "52")]
	[AsyncStateMachine(typeof(OBHLGMBIKFH))]
	private Task<EOMKIGIPEDC> OOMDPPHHIMO(OPHHGBFNKCM HJPACFIDIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D760", Offset = "0x6F4C160", VA = "0x186F4D760", Slot = "53")]
	[AsyncStateMachine(typeof(GMLGMENMKPI))]
	private Task AGABGFLAKMP(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D910", Offset = "0x6F4C310", VA = "0x186F4D910")]
	[IteratorStateMachine(typeof(GEPLGBJEJCN))]
	private IEnumerable<PEPBKNNAOIB> BDELKAFILNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DF50", Offset = "0x6F4C950", VA = "0x186F4DF50")]
	[CompilerGenerated]
	private void LDNEHDACLNK(PEPBKNNAOIB BHOOAGJPBFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class BFEAAOHJMLI : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xEE3A40", Offset = "0xEE2440", VA = "0x180EE3A40")]
	public BFEAAOHJMLI(string BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class BPAPHEKHCNP : GFKOJOJMLEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct IAKCNIPKPGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public BPAPHEKHCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F61980", Offset = "0x6F60380", VA = "0x186F61980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F61CC0", Offset = "0x6F606C0", VA = "0x186F61CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly OKJDCNBIHPD GLFIGPDLPBG;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool BOHLLANALDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x854210", Offset = "0x852C10", VA = "0x180854210")]
	public BPAPHEKHCNP(DPFMBDJKAOB GFAOFFCNKEI, OKJDCNBIHPD GLFIGPDLPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F4ED20", Offset = "0x6F4D720", VA = "0x186F4ED20", Slot = "4")]
	[AsyncStateMachine(typeof(IAKCNIPKPGP))]
	public Task<bool> GJFMCIGPAMF(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EE10", Offset = "0x6F4D810", VA = "0x186F4EE10")]
	[CompilerGenerated]
	private object OIPJMKPBLML()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class ECPOKLGPFEO : GFKOJOJMLEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct OLKDIKIAJOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public ECPOKLGPFEO <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6F68F90", Offset = "0x6F67990", VA = "0x186F68F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F696A0", Offset = "0x6F680A0", VA = "0x186F696A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OKJDCNBIHPD GLFIGPDLPBG;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private AELMJKLMOFJ DEOLIAGACBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F53760", Offset = "0x6F52160", VA = "0x186F53760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool BOHLLANALDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x854210", Offset = "0x852C10", VA = "0x180854210")]
	public ECPOKLGPFEO(DPFMBDJKAOB GFAOFFCNKEI, OKJDCNBIHPD GLFIGPDLPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F53550", Offset = "0x6F51F50", VA = "0x186F53550", Slot = "4")]
	[AsyncStateMachine(typeof(OLKDIKIAJOO))]
	public Task<bool> GJFMCIGPAMF(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F53680", Offset = "0x6F52080", VA = "0x186F53680")]
	[CompilerGenerated]
	private object JEKJLNEKOHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class CHOBLOKOBOG : GFKOJOJMLEC
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class COIPCDGNLKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public CHOBLOKOBOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CONHBEANPHH result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public MDCEFFOBCGJ newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public COIPCDGNLKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F50F40", Offset = "0x6F4F940", VA = "0x186F50F40")]
		internal object HDEFADILAJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F51030", Offset = "0x6F4FA30", VA = "0x186F51030")]
		internal object KNODECFBONE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F50EA0", Offset = "0x6F4F8A0", VA = "0x186F50EA0")]
		internal object CDPLDDLFNMK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct ECNCMICLLHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CHOBLOKOBOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private COIPCDGNLKB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<CONHBEANPHH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F52BC0", Offset = "0x6F515C0", VA = "0x186F52BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F534E0", Offset = "0x6F51EE0", VA = "0x186F534E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly OKJDCNBIHPD GLFIGPDLPBG;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private AELMJKLMOFJ DEOLIAGACBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F3E0", Offset = "0x6F4DDE0", VA = "0x186F4F3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool BOHLLANALDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x854210", Offset = "0x852C10", VA = "0x180854210")]
	public CHOBLOKOBOG(DPFMBDJKAOB GFAOFFCNKEI, OKJDCNBIHPD GLFIGPDLPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F2C0", Offset = "0x6F4DCC0", VA = "0x186F4F2C0", Slot = "4")]
	[AsyncStateMachine(typeof(ECNCMICLLHM))]
	public Task<bool> GJFMCIGPAMF(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface GFKOJOJMLEC
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool BOHLLANALDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> GJFMCIGPAMF(CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct FPNAIOJPEJO
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class IBOAJBDMMEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public DPFMBDJKAOB manager;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public IBOAJBDMMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F61D30", Offset = "0x6F60730", VA = "0x186F61D30")]
		internal Task AEDCJLJNBLD(FNGILHDDEFI data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct BNBKENBIDDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public FPNAIOJPEJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private OPHHGBFNKCM <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<EAGDKOGBKKK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<EOMKIGIPEDC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F4E720", Offset = "0x6F4D120", VA = "0x186F4E720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6F4ECB0", Offset = "0x6F4D6B0", VA = "0x186F4ECB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct OLHHJBGJKHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public FPNAIOJPEJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6F68C10", Offset = "0x6F67610", VA = "0x186F68C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6F68F30", Offset = "0x6F67930", VA = "0x186F68F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CancellationToken AOLOJHLCMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly DPFMBDJKAOB KNCHPAAMIFB;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private FGAKHKLMNEL IKCEBBANDMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D240", Offset = "0x6F5BC40", VA = "0x186F5D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private OKJDCNBIHPD NCEODIICHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CFE0", Offset = "0x6F5B9E0", VA = "0x186F5CFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private AELMJKLMOFJ DEOLIAGACBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D3C0", Offset = "0x6F5BDC0", VA = "0x186F5D3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private BEGLGPNHNFE GCDNCCJPKFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D440", Offset = "0x6F5BE40", VA = "0x186F5D440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FA21C0", Offset = "0x1FA0BC0", VA = "0x181FA21C0")]
	public FPNAIOJPEJO(CancellationToken AOLOJHLCMLE, DPFMBDJKAOB KNCHPAAMIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CF30", Offset = "0x6F5B930", VA = "0x186F5CF30")]
	public static OPENLMIJNEO HCKCEAMGMEG(DPFMBDJKAOB KNCHPAAMIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CD50", Offset = "0x6F5B750", VA = "0x186F5CD50")]
	[AsyncStateMachine(typeof(BNBKENBIDDF))]
	public Task<bool> AJIENLNABLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D030", Offset = "0x6F5BA30", VA = "0x186F5D030")]
	private bool IMMBAOBBDPM([Out] OPHHGBFNKCM HJPACFIDIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CE60", Offset = "0x6F5B860", VA = "0x186F5CE60")]
	[AsyncStateMachine(typeof(OLHHJBGJKHJ))]
	private Task BNCDNAKCOAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D290", Offset = "0x6F5BC90", VA = "0x186F5D290")]
	private Task<EAGDKOGBKKK> JHMAAIDGGPH(OPHHGBFNKCM CAIHAMFMODO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct NHOKOLNOMNB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly NNKOOGLGKLN LDIEALKHGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Guid ANGIPKEDDGP;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private Task<(EOMKIGIPEDC, Task)> GKKIOFPGLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F677F0", Offset = "0x6F661F0", VA = "0x186F677F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4255F80", Offset = "0x4254980", VA = "0x184255F80")]
	public NHOKOLNOMNB(NNKOOGLGKLN LDIEALKHGNA, Guid ANGIPKEDDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F676D0", Offset = "0x6F660D0", VA = "0x186F676D0")]
	public TaskAwaiter<(EOMKIGIPEDC, Task)> AJMGKPCPAEO()
	{
		return default(TaskAwaiter<(EOMKIGIPEDC, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F67720", Offset = "0x6F66120", VA = "0x186F67720", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct BBOFDDKJEBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly TaskCompletionSource<(EOMKIGIPEDC, Task)> GFDKGOKDMHD;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Task<(EOMKIGIPEDC, Task)> GKKIOFPGLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D590", Offset = "0x6F4BF90", VA = "0x186F4D590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D5D0", Offset = "0x6F4BFD0", VA = "0x186F4D5D0")]
	public BBOFDDKJEBD(TimeSpan CGNNGIOOAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D460", Offset = "0x6F4BE60", VA = "0x186F4D460")]
	public void BLLLNNOMDCJ(Task CLMNIFMLNNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D500", Offset = "0x6F4BF00", VA = "0x186F4D500")]
	public void ENNDLGNBNHB(EOMKIGIPEDC MBJHBACEHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D410", Offset = "0x6F4BE10", VA = "0x186F4D410")]
	public void BJGOLKPPFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D380", Offset = "0x6F4BD80", VA = "0x186F4D380")]
	internal void AFJGMOFLBCL(string BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class GEJEENNEACN
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class FEDODPGNHEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public BCDAPHNNAIF subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public FEDODPGNHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CD20", Offset = "0x6F5B720", VA = "0x186F5CD20")]
		internal bool DFNPJJHJHKF(PPOBPODJIIJ s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F5DAB0", Offset = "0x6F5C4B0", VA = "0x186F5DAB0")]
	public static CCPGLNKCEAO CBNOJCEAKCL(long HAMKFNPEKKG, long EMDKAGDEANA, string GNFDFPFLGPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D9F0", Offset = "0x6F5C3F0", VA = "0x186F5D9F0")]
	public static CCPGLNKCEAO CBNOJCEAKCL(long HAMKFNPEKKG, long EMDKAGDEANA, DINCFJKGGOK BGFCCPEMGBP, long PHHOGBMHKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F5DD70", Offset = "0x6F5C770", VA = "0x186F5DD70")]
	public static CCPGLNKCEAO CBNOJCEAKCL(HCBBPJCCCOC OJDLPNKOJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F5DB40", Offset = "0x6F5C540", VA = "0x186F5DB40")]
	public static CCPGLNKCEAO CBNOJCEAKCL(LGDDBNGBFNG CBNGMDEOBDB, BCDAPHNNAIF CLCPJKABCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F5DF00", Offset = "0x6F5C900", VA = "0x186F5DF00")]
	public static CCPGLNKCEAO LGJMOMEIOKE(this CCPGLNKCEAO NBBCEJPPPCO, LGDDBNGBFNG EOMMFDOCJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F5DFF0", Offset = "0x6F5C9F0", VA = "0x186F5DFF0")]
	public static CCPGLNKCEAO NJMABPAFLAA(this CCPGLNKCEAO NBBCEJPPPCO, BCDAPHNNAIF LHLNKAJLANE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class CALGNMJACLH : KFNFOHABKOA, PEPBKNNAOIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct EAFPONPDCNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CALGNMJACLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F524D0", Offset = "0x6F50ED0", VA = "0x186F524D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F52B60", Offset = "0x6F51560", VA = "0x186F52B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly HFDCBECCBCM HNLAHHLNKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private string NABBCNPIKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Task PAHOFHFDPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool GKAHCBPGFHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F4EEF0", Offset = "0x6F4D8F0", VA = "0x186F4EEF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public Task COFMEMDBABC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F1A0", Offset = "0x6F4DBA0", VA = "0x186F4F1A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x850E30", Offset = "0x84F830", VA = "0x180850E30", Slot = "7")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F040", Offset = "0x6F4DA40", VA = "0x186F4F040", Slot = "6")]
	public void IGICFDFDKEO(Task JCINMAJOONI, string NMBCBCAFPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EF20", Offset = "0x6F4D920", VA = "0x186F4EF20")]
	[AsyncStateMachine(typeof(EAFPONPDCNN))]
	private Task HEDFNPACIOG(Task DCFODCMIFMF, string NMBCBCAFPFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F230", Offset = "0x6F4DC30", VA = "0x186F4F230")]
	public CALGNMJACLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class KALEIKPFBMP : AFFIPNIMMLK, PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool DENLGPGBGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private BJHEOJGGHKA CKILKEDLOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private FGAKHKLMNEL ILINKAEOFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private LEMGGJFEOOO FBFDHBHFJCB;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public BJHEOJGGHKA AOKFJBPNPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F640F0", Offset = "0x6F62AF0", VA = "0x186F640F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F63CC0", Offset = "0x6F626C0", VA = "0x186F63CC0", Slot = "7")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F63E80", Offset = "0x6F62880", VA = "0x186F63E80", Slot = "5")]
	public void EMPCBDMHGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6F63E40", Offset = "0x6F62840", VA = "0x186F63E40", Slot = "6")]
	public void PGJODHPBIKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6F64030", Offset = "0x6F62A30", VA = "0x186F64030")]
	private Task JPIKJPPFKGE(GAKOKDPCJDJ MAJFEBAGNLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6F63E40", Offset = "0x6F62840", VA = "0x186F63E40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public KALEIKPFBMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class IHHDOCAFIEM : LEMGGJFEOOO
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class IHFNAJAJHNK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly CDGIPBDNDHL IMGPIAJMBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly string LDDEKIBHION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly T JIEGAHKKHCA;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public T NHLIMKDHAIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x8A0E90", Offset = "0x89F890", VA = "0x1808A0E90")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x9A34A0", Offset = "0x9A1EA0", VA = "0x1809A34A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3E9BCF0", Offset = "0x3E9A6F0", VA = "0x183E9BCF0")]
		public IHFNAJAJHNK(CDGIPBDNDHL IMGPIAJMBBI, string LDDEKIBHION, T JIEGAHKKHCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3E9B8E0", Offset = "0x3E9A2E0", VA = "0x183E9B8E0")]
		private void PELKOMDIIHL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly CDGIPBDNDHL IMGPIAJMBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly IHFNAJAJHNK<TimeSpan> CJDAEBOJKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly IHFNAJAJHNK<TimeSpan> OKLGIBNFDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly IHFNAJAJHNK<TimeSpan> IFPNJCACJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly IHFNAJAJHNK<TimeSpan> MGPHALOKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly IHFNAJAJHNK<bool> OLPKHFMKJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly IHFNAJAJHNK<bool> LHGFPIMKMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly IHFNAJAJHNK<bool> HBKLJDBHIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly IHFNAJAJHNK<int> GNJKOHCIOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly IHFNAJAJHNK<bool> PIBPJGIBHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly IHFNAJAJHNK<bool> GAGDMEJPFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly IHFNAJAJHNK<bool> HPNMDDLIPCG;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public TimeSpan JEFGBKDIJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6F62000", Offset = "0x6F60A00", VA = "0x186F62000", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TimeSpan IMGNENHDAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6F61D80", Offset = "0x6F60780", VA = "0x186F61D80", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TimeSpan NAFMCDBAKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6F61F80", Offset = "0x6F60980", VA = "0x186F61F80", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public TimeSpan JJIHIDFBGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6F61F00", Offset = "0x6F60900", VA = "0x186F61F00", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool PBANAGKDBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6F61E40", Offset = "0x6F60840", VA = "0x186F61E40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool CDNHBCEOBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6F61F40", Offset = "0x6F60940", VA = "0x186F61F40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool DDPINMGJKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6F61E00", Offset = "0x6F60800", VA = "0x186F61E00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int MOEKOOKCOIG
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6F61E80", Offset = "0x6F60880", VA = "0x186F61E80", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool MDPDGNOBKKA
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6F61DC0", Offset = "0x6F607C0", VA = "0x186F61DC0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool APHFHMPEBHO
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6F61FC0", Offset = "0x6F609C0", VA = "0x186F61FC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool KKIHEHAIMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6F61EC0", Offset = "0x6F608C0", VA = "0x186F61EC0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6F62040", Offset = "0x6F60A40", VA = "0x186F62040")]
	[UnityEngine.Scripting.Preserve]
	public IHHDOCAFIEM([OHLKLPAILPF(null)] CDGIPBDNDHL IMGPIAJMBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class PJLICHDPGGK : MEMFMICPHOA, PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class AJKJNLFAPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public MABPGBIBHNO roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AJKJNLFAPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D2A0", Offset = "0x6F4BCA0", VA = "0x186F4D2A0")]
		internal object IECIPJJCKNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action IDLOKPENNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A330", Offset = "0x6F68D30", VA = "0x186F6A330", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6F69CB0", Offset = "0x6F686B0", VA = "0x186F69CB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event NCCEANPKCBH IKGBHBJKFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6F69DF0", Offset = "0x6F687F0", VA = "0x186F69DF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A720", Offset = "0x6F69120", VA = "0x186F6A720", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event NCCEANPKCBH GKJHGMKBBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A060", Offset = "0x6F68A60", VA = "0x186F6A060", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A4D0", Offset = "0x6F68ED0", VA = "0x186F6A4D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event NCCEANPKCBH BFGLDDCPING
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6F69D50", Offset = "0x6F68750", VA = "0x186F69D50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A400", Offset = "0x6F68E00", VA = "0x186F6A400", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<MHJFPILMNPL, bool> CHOMICPPMKH
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A570", Offset = "0x6F68F70", VA = "0x186F6A570", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A670", Offset = "0x6F69070", VA = "0x186F6A670", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "19")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A130", Offset = "0x6F68B30", VA = "0x186F6A130", Slot = "14")]
	public void GFIIGIEJDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A4A0", Offset = "0x6F68EA0", VA = "0x186F6A4A0", Slot = "15")]
	public void LDPJKIBINJO(MABPGBIBHNO FMGABMMAANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A3D0", Offset = "0x6F68DD0", VA = "0x186F6A3D0", Slot = "16")]
	public void GKIPHPNNGKP(MABPGBIBHNO FMGABMMAANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A100", Offset = "0x6F68B00", VA = "0x186F6A100", Slot = "17")]
	public void GDHNMHNNICK(MABPGBIBHNO FMGABMMAANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A620", Offset = "0x6F69020", VA = "0x186F6A620", Slot = "18")]
	public void MFAFIJFCPAF(MHJFPILMNPL KFHICACKEFH, bool FBPJJEBDJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6F69E90", Offset = "0x6F68890", VA = "0x186F69E90")]
	private void EDIAJIJOMBB(NCCEANPKCBH MGAAFIBOMHF, MABPGBIBHNO FMGABMMAANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public PJLICHDPGGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class DLAGICOPNCE : NCJGEHACABB, PEPBKNNAOIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct IIOIKLDJJNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public DLAGICOPNCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6F63080", Offset = "0x6F61A80", VA = "0x186F63080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6F63710", Offset = "0x6F62110", VA = "0x186F63710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct IICDDPHNHAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public DLAGICOPNCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private Task<bool> <fallbackTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter<bool> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6F62500", Offset = "0x6F60F00", VA = "0x186F62500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6F63020", Offset = "0x6F61A20", VA = "0x186F63020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class PDCODBMEHIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public PDCODBMEHIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6F69710", Offset = "0x6F68110", VA = "0x186F69710")]
		internal object AHIFCKHEBOA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct LJEDIKBILBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public DLAGICOPNCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private PDCODBMEHIN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6F64940", Offset = "0x6F63340", VA = "0x186F64940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6F65090", Offset = "0x6F63A90", VA = "0x186F65090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class DOOPHJFBHMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public DOOPHJFBHMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6F52460", Offset = "0x6F50E60", VA = "0x186F52460")]
		internal object BIFGGLJLOCP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private OKJDCNBIHPD GLFIGPDLPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private GFKOJOJMLEC[] LAGJAABLAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private CancellationTokenSource JEICBAHFOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CancellationTokenSource JFDPGLMJLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Task EGFNIODBBJF;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool IGJHMIFOAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6F51FC0", Offset = "0x6F509C0", VA = "0x186F51FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6F51A00", Offset = "0x6F50400", VA = "0x186F51A00", Slot = "6")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6F51A80", Offset = "0x6F50480", VA = "0x186F51A80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6F522B0", Offset = "0x6F50CB0", VA = "0x186F522B0", Slot = "8")]
	public void OINNMPMFHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F521E0", Offset = "0x6F50BE0", VA = "0x186F521E0", Slot = "5")]
	public void NDHENOBLFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6F517F0", Offset = "0x6F501F0", VA = "0x186F517F0", Slot = "4")]
	[AsyncStateMachine(typeof(IIOIKLDJJNF))]
	public Task AIHHELFPJFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6F520D0", Offset = "0x6F50AD0", VA = "0x186F520D0")]
	[AsyncStateMachine(typeof(IICDDPHNHAC))]
	private Task KMFOILJJBAC(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6F51BC0", Offset = "0x6F505C0", VA = "0x186F51BC0")]
	private void EPFDDEEOLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6F518C0", Offset = "0x6F502C0", VA = "0x186F518C0")]
	[AsyncStateMachine(typeof(LJEDIKBILBE))]
	private Task<bool> AMPNMBCMIGI(int ILOCEPPJPDO, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6F51FF0", Offset = "0x6F509F0", VA = "0x186F51FF0")]
	private void KLKNKOGAGEG(int ILOCEPPJPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6F51EE0", Offset = "0x6F508E0", VA = "0x186F51EE0")]
	private void GOINBPILLME(int ILOCEPPJPDO, bool FBPJJEBDJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6F51A90", Offset = "0x6F50490", VA = "0x186F51A90")]
	private void EEKCBEEANJM(int ILOCEPPJPDO, Exception JKHACPOPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public DLAGICOPNCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class EJIIJJMNJOJ : PMOONCPIMJF, PEPBKNNAOIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct CNOGNIIOLNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public MDCEFFOBCGJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public EJIIJJMNJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public NDBDNDIBEKL customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6F504E0", Offset = "0x6F4EEE0", VA = "0x186F504E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6F50E40", Offset = "0x6F4F840", VA = "0x186F50E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct GIINBACFBJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public EJIIJJMNJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public MDCEFFOBCGJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public NDBDNDIBEKL customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private MIJAEHJIGEB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NDMGMBJNGAH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private KJCKCCPLGMI <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private NBNEEAGBCAD <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E8D0", Offset = "0x6F5D2D0", VA = "0x186F5E8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F490", Offset = "0x6F5DE90", VA = "0x186F5F490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class HILFHMPFICN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Matchmaking.IHLHDPEMGJA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public PGHNGJNIFIL errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public HILFHMPFICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6F618D0", Offset = "0x6F602D0", VA = "0x186F618D0")]
		internal object BOMICDIBLNE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class AKIMGMLJBFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public Task<CCPGLNKCEAO> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AKIMGMLJBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		internal Task<CCPGLNKCEAO> HLLBHBDPMNI(MIJAEHJIGEB<string>.OBFKFOAMCEP _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct FDDAFOLKGIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public EJIIJJMNJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public MDCEFFOBCGJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public NDBDNDIBEKL customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public KJCKCCPLGMI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private AKIMGMLJBFC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private JCGOAOCFLOH <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private NDMGMBJNGAH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private EDKILIBKIOP <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private Task<Matchmaking.HLHLGAFEPGK> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private IMFMMEPDGNI <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private TaskAwaiter<Matchmaking.HLHLGAFEPGK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private TaskAwaiter<CCPGLNKCEAO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6F57400", Offset = "0x6F55E00", VA = "0x186F57400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CCC0", Offset = "0x6F5B6C0", VA = "0x186F5CCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct NJHHBMLAHHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public EJIIJJMNJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6F678C0", Offset = "0x6F662C0", VA = "0x186F678C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6F68310", Offset = "0x6F66D10", VA = "0x186F68310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct NBDKNDKCODJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public EJIIJJMNJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private GPECMKAJNMD <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6F66200", Offset = "0x6F64C00", VA = "0x186F66200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6F66670", Offset = "0x6F65070", VA = "0x186F66670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct GCCEGLJPOGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder<Matchmaking.HLHLGAFEPGK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public MDCEFFOBCGJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public EJIIJJMNJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private TaskAwaiter<Matchmaking.HLHLGAFEPGK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D490", Offset = "0x6F5BE90", VA = "0x186F5D490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D980", Offset = "0x6F5C380", VA = "0x186F5D980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct DGHMCPNEBNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Matchmaking.HLHLGAFEPGK serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public EJIIJJMNJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public KJCKCCPLGMI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private TaskAwaiter<ENEOJIHBMNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6F510A0", Offset = "0x6F4FAA0", VA = "0x186F510A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6F51790", Offset = "0x6F50190", VA = "0x186F51790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class JCAIGBPAGLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public MDCEFFOBCGJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public JCAIGBPAGLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6F63BC0", Offset = "0x6F625C0", VA = "0x186F63BC0")]
		internal object KCNCLKDCILN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6F63AC0", Offset = "0x6F624C0", VA = "0x186F63AC0")]
		internal string FJGLKBDGBFC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct MFNCENKMMPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public MDCEFFOBCGJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public EJIIJJMNJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private JCAIGBPAGLL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6F655D0", Offset = "0x6F63FD0", VA = "0x186F655D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6F661A0", Offset = "0x6F64BA0", VA = "0x186F661A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct CKEEIPNHNIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public EJIIJJMNJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public KJCKCCPLGMI joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public CCPGLNKCEAO initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public MDCEFFOBCGJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public JCGOAOCFLOH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F430", Offset = "0x6F4DE30", VA = "0x186F4F430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6F4FD40", Offset = "0x6F4E740", VA = "0x186F4FD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct HCNGKGGANNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public EJIIJJMNJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private NDMGMBJNGAH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F7F0", Offset = "0x6F5E1F0", VA = "0x186F5F7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6F60E20", Offset = "0x6F5F820", VA = "0x186F60E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct PKFGHDPHJID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public EJIIJJMNJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter<EOMKIGIPEDC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A7C0", Offset = "0x6F691C0", VA = "0x186F6A7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6F6AF70", Offset = "0x6F69970", VA = "0x186F6AF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class ELKBJCDCEPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public MDCEFFOBCGJ targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public ELKBJCDCEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6F78D90", Offset = "0x6F77790", VA = "0x186F78D90")]
		internal object EILJFLJFJNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class JKMPIFMOJBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public JKMPIFMOJBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6F80D20", Offset = "0x6F7F720", VA = "0x186F80D20")]
		internal void AMACLBGEJKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class HHDGOKOBOKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public MDCEFFOBCGJ targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public HHDGOKOBOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DBD0", Offset = "0x6F7C5D0", VA = "0x186F7DBD0")]
		internal object DKDMADHOKPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class HCMEBNHMPKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public MDCEFFOBCGJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public HCMEBNHMPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DAD0", Offset = "0x6F7C4D0", VA = "0x186F7DAD0")]
		internal string BDLJEGMHMAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly LGKLDLNGEGN MMEIPNBGLOB;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly LGKLDLNGEGN HIPHIPEIFBD;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly LGKLDLNGEGN PLOPCIIEMNF;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly string OGOAMLLBHOP;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly string ECDGIFIJOII;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly string ECKGHJDCLHB;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly Guid DKNOMBBCNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private BDMPGCNODMK NFHDCIEPBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private AAEAMPAFKHI EJBKKDIKBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private FGAKHKLMNEL ILINKAEOFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private OKJDCNBIHPD GLFIGPDLPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NCJGEHACABB BMNLBFGMFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private KFNFOHABKOA DCDEOEDJGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private MEMFMICPHOA BOHBKMHODLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private CHEBGDLLLJJ PENBLNINCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private JFMCNEFMLCF JGPMDJDNAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IDisposable DDIEBKJPCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly HFDCBECCBCM HCBDIEHBMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly HFDCBECCBCM DAMBHBIDNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IMFMMEPDGNI GKBMAMDCHGO;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public TaskStatus LIKFHNLIFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2E0", Offset = "0x8BACE0", VA = "0x1808BC2E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xC78990", Offset = "0xC77390", VA = "0x180C78990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private AELMJKLMOFJ DEOLIAGACBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6F552E0", Offset = "0x6F53CE0", VA = "0x186F552E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6F53E90", Offset = "0x6F52890", VA = "0x186F53E90", Slot = "6")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6F547A0", Offset = "0x6F531A0", VA = "0x186F547A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6F55520", Offset = "0x6F53F20", VA = "0x186F55520", Slot = "5")]
	[AsyncStateMachine(typeof(CNOGNIIOLNB))]
	public Task KDDOLCKKADE(MDCEFFOBCGJ HDKECBFDELN, NDBDNDIBEKL EDPPKGIKACG, CancellationToken NEGOEBJOBPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6F53D40", Offset = "0x6F52740", VA = "0x186F53D40")]
	[AsyncStateMachine(typeof(GIINBACFBJP))]
	private Task AGDAHLOOHCH(MDCEFFOBCGJ HDKECBFDELN, NDBDNDIBEKL EDPPKGIKACG, CancellationToken NEGOEBJOBPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6F56D60", Offset = "0x6F55760", VA = "0x186F56D60")]
	private static void PKDNLJADAFC(CHEBGDLLLJJ PENBLNINCMJ, MDCEFFOBCGJ HDKECBFDELN, Exception JKHACPOPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6F55790", Offset = "0x6F54190", VA = "0x186F55790")]
	private static void KHFDNIGGJAJ(NBNEEAGBCAD MIACPKOGPPM, Exception JKHACPOPJJF, [Optional] List<int> PEOCHBNPIMF, int HMFAHDKGEMP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6F54AC0", Offset = "0x6F534C0", VA = "0x186F54AC0")]
	[AsyncStateMachine(typeof(FDDAFOLKGIL))]
	private Task FAMBLDEKOJD(MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, MDCEFFOBCGJ HDKECBFDELN, NDBDNDIBEKL EDPPKGIKACG, KJCKCCPLGMI GKNEHGNNGMA, CancellationToken NEGOEBJOBPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6F56880", Offset = "0x6F55280", VA = "0x186F56880")]
	private void PBMKHDPDLEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6F53A60", Offset = "0x6F52460", VA = "0x186F53A60")]
	[AsyncStateMachine(typeof(NJHHBMLAHHE))]
	private Task ADLOPICLIKL(MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6F56440", Offset = "0x6F54E40", VA = "0x186F56440")]
	private void NPPABKMDENH(MDCEFFOBCGJ HDKECBFDELN, CancellationToken NEGOEBJOBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6F544F0", Offset = "0x6F52EF0", VA = "0x186F544F0")]
	private void DIBJIPJNOFL(MDCEFFOBCGJ HDKECBFDELN, KJCKCCPLGMI GKNEHGNNGMA, OperationCanceledException DGGIFIBJMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6F542D0", Offset = "0x6F52CD0", VA = "0x186F542D0")]
	private void DHIKCNDAANC(MDCEFFOBCGJ HDKECBFDELN, KJCKCCPLGMI GKNEHGNNGMA, Exception JKHACPOPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6F54FE0", Offset = "0x6F539E0", VA = "0x186F54FE0")]
	private void JABAKNADAFD(MDCEFFOBCGJ HDKECBFDELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6F563E0", Offset = "0x6F54DE0", VA = "0x186F563E0")]
	private static MABPGBIBHNO NOMKOOOOHEO(MDCEFFOBCGJ HDKECBFDELN)
	{
		return default(MABPGBIBHNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6F54D30", Offset = "0x6F53730", VA = "0x186F54D30")]
	[AsyncStateMachine(typeof(NBDKNDKCODJ))]
	private Task FOIBAEGJMGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6F547F0", Offset = "0x6F531F0", VA = "0x186F547F0")]
	[AsyncStateMachine(typeof(GCCEGLJPOGK))]
	private Task<Matchmaking.HLHLGAFEPGK> EGDEAIJCMFD(MDCEFFOBCGJ HDKECBFDELN, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6F54C20", Offset = "0x6F53620", VA = "0x186F54C20")]
	private static ENEOJIHBMNO FIPHGFFFMBC(Matchmaking.HLHLGAFEPGK JOMIJFJGCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6F54E90", Offset = "0x6F53890", VA = "0x186F54E90")]
	[AsyncStateMachine(typeof(DGHMCPNEBNA))]
	private Task GEIAGBIGEAM(Matchmaking.HLHLGAFEPGK JOMIJFJGCEP, KJCKCCPLGMI GKNEHGNNGMA, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken PJABKIEFFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6F54190", Offset = "0x6F52B90", VA = "0x186F54190")]
	[AsyncStateMachine(typeof(MFNCENKMMPI))]
	private Task CFJGNGCMJFO(MDCEFFOBCGJ HDKECBFDELN, CancellationTokenSource OEDIKMJDALF, Task BHPEOBPFKOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6F54950", Offset = "0x6F53350", VA = "0x186F54950")]
	[AsyncStateMachine(typeof(CKEEIPNHNIF))]
	private Task EGDPPBGLJOH(CCPGLNKCEAO AKPFFLGJICF, JCGOAOCFLOH ABIMAOKJBED, MDCEFFOBCGJ JEGFILEFFHC, KJCKCCPLGMI PPBPADKADBJ, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken OILILKEMMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6F55330", Offset = "0x6F53D30", VA = "0x186F55330")]
	private KJCKCCPLGMI KDBNNFENELM(KJCKCCPLGMI PPBPADKADBJ, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6F55660", Offset = "0x6F54060", VA = "0x186F55660")]
	[AsyncStateMachine(typeof(HCNGKGGANNN))]
	private Task KGJCMBNFPKA(MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6F56C40", Offset = "0x6F55640", VA = "0x186F56C40")]
	[AsyncStateMachine(typeof(PKFGHDPHJID))]
	private Task PHELMABJJDN(FNGILHDDEFI EEOBDBMOHPL, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F569D0", Offset = "0x6F553D0", VA = "0x186F569D0")]
	private static void PCMLAGHGAPP(MDCEFFOBCGJ HDKECBFDELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6F561A0", Offset = "0x6F54BA0", VA = "0x186F561A0")]
	private void MPBOPAPMKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6F55250", Offset = "0x6F53C50", VA = "0x186F55250")]
	private void JHDHDFPGHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6F54E00", Offset = "0x6F53800", VA = "0x186F54E00")]
	private void GDIMNNGAMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6F54710", Offset = "0x6F53110", VA = "0x186F54710")]
	private void DOFMILMMAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6F56B50", Offset = "0x6F55550", VA = "0x186F56B50")]
	private static void PDPGNIANMGI(MDCEFFOBCGJ HDKECBFDELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6F56770", Offset = "0x6F55170", VA = "0x186F56770")]
	private static CancellationTokenRegistration OLAMHOFIFLB(MDCEFFOBCGJ HDKECBFDELN, CancellationToken PJABKIEFFAN)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6F56040", Offset = "0x6F54A40", VA = "0x186F56040")]
	private static void MABDIJGNOOD(MDCEFFOBCGJ HDKECBFDELN, Exception JKHACPOPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6F53B90", Offset = "0x6F52590", VA = "0x186F53B90")]
	private void AEGDGBLHLAE(MDCEFFOBCGJ HDKECBFDELN, Task BHPEOBPFKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6F56140", Offset = "0x6F54B40", VA = "0x186F56140")]
	private static void MDBGGDKNGAC(Func<string> LCGAFANECDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6F57330", Offset = "0x6F55D30", VA = "0x186F57330")]
	public EJIIJJMNJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6F551F0", Offset = "0x6F53BF0", VA = "0x186F551F0")]
	[CompilerGenerated]
	internal static (int, int?) JAPJGDFDKEO(PGHNGJNIFIL OKEIDPHGIFB)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class MIPNJLHBIND : EHOAKANHCDL, PEPBKNNAOIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct LCBOPBBMBDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public MIPNJLHBIND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public FNGILHDDEFI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F82490", Offset = "0x6F80E90", VA = "0x186F82490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F82900", Offset = "0x6F81300", VA = "0x186F82900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class DDEEDLAMJAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public MIPNJLHBIND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public FNGILHDDEFI roomData;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public DDEEDLAMJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F74FD0", Offset = "0x6F739D0", VA = "0x186F74FD0")]
		internal List<Task> HOIKOJNCJPE(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct CONPKDFGBCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public OPENLMIJNEO taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F72380", Offset = "0x6F70D80", VA = "0x186F72380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F72710", Offset = "0x6F71110", VA = "0x186F72710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct AADGCNDNNNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public MIPNJLHBIND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BAB0", Offset = "0x6F6A4B0", VA = "0x186F6BAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BD70", Offset = "0x6F6A770", VA = "0x186F6BD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly HashSet<OPENLMIJNEO> EPOGJALFPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private AAEAMPAFKHI EJBKKDIKBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private DJNNHLJMOHO MFMPJKLFIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private BLECJCCLLIM DEAEHKMENMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private IDisposable DDIEBKJPCPB;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6F84750", Offset = "0x6F83150", VA = "0x186F84750", Slot = "5")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F84A50", Offset = "0x6F83450", VA = "0x186F84A50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6F84CC0", Offset = "0x6F836C0", VA = "0x186F84CC0", Slot = "4")]
	public bool HBJAOCECBBB(OPENLMIJNEO BEBKGACGLJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6F854B0", Offset = "0x6F83EB0", VA = "0x186F854B0")]
	private void NCPLDHHGPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D20", Offset = "0x6F83720", VA = "0x186F84D20")]
	private void JILPKOAFDBP(FNGILHDDEFI IJFOGIEFCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6F85580", Offset = "0x6F83F80", VA = "0x186F85580")]
	[AsyncStateMachine(typeof(LCBOPBBMBDJ))]
	private Task NIIAALMOLEN(FNGILHDDEFI IJFOGIEFCHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6F84F00", Offset = "0x6F83900", VA = "0x186F84F00")]
	private Func<CancellationToken, List<Task>> JPFGDEOAEOJ(FNGILHDDEFI IJFOGIEFCHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6F84FD0", Offset = "0x6F839D0", VA = "0x186F84FD0")]
	private List<Task> NBCBLIHMNKA(FNGILHDDEFI IJFOGIEFCHH, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6F84BA0", Offset = "0x6F835A0", VA = "0x186F84BA0")]
	[AsyncStateMachine(typeof(CONPKDFGBCD))]
	private Task GKIIAMIKOHN(OPENLMIJNEO MBMICMKEMDC, FNGILHDDEFI EEOBDBMOHPL, CancellationToken JCIFCENKMKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6F84AD0", Offset = "0x6F834D0", VA = "0x186F84AD0")]
	[AsyncStateMachine(typeof(AADGCNDNNNH))]
	private Task ECDHKGPGOJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6F85670", Offset = "0x6F84070", VA = "0x186F85670")]
	private void OINNMPMFHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6F85720", Offset = "0x6F84120", VA = "0x186F85720")]
	public MIPNJLHBIND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class APKOBJLAOFN : NNKOOGLGKLN, PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class KCHNDPDHFLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public KCHNDPDHFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F80FF0", Offset = "0x6F7F9F0", VA = "0x186F80FF0")]
		internal object FHDEKHDBBDG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class IDFLOMBPMPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public IDFLOMBPMPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DCB0", Offset = "0x6F7C6B0", VA = "0x186F7DCB0")]
		internal object IBIACHOGCAF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class JDHCKKFBBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public JDHCKKFBBEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class AKDGHBJBBMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AKDGHBJBBMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C7E0", Offset = "0x6F6B1E0", VA = "0x186F6C7E0")]
		internal object IPCHBKPCHGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class PNBMNGEEMJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public PNBMNGEEMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F8AD60", Offset = "0x6F89760", VA = "0x186F8AD60")]
		internal object OOMMAGIKAFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Dictionary<Guid, BBOFDDKJEBD> LDIEALKHGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private readonly TimeSpan NGHNOFIBGMI;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "9")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D820", Offset = "0x6F6C220", VA = "0x186F6D820", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DAD0", Offset = "0x6F6C4D0", VA = "0x186F6DAD0", Slot = "4")]
	public NHOKOLNOMNB KODKNHDNNHA(Guid ANGIPKEDDGP)
	{
		return default(NHOKOLNOMNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E200", Offset = "0x6F6CC00", VA = "0x186F6E200", Slot = "5")]
	public bool PLMGPBLKDNE(Guid ANGIPKEDDGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DCF0", Offset = "0x6F6C6F0", VA = "0x186F6DCF0", Slot = "6")]
	public bool MDBNINMKKHC(Guid ANGIPKEDDGP, Task CLMNIFMLNNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E020", Offset = "0x6F6CA20", VA = "0x186F6E020", Slot = "7")]
	public bool NHGFACPKAGD(Guid ANGIPKEDDGP, EOMKIGIPEDC MBJHBACEHFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D830", Offset = "0x6F6C230", VA = "0x186F6D830", Slot = "8")]
	public Task<(EOMKIGIPEDC, Task)> ICLPJOOAMIL(Guid ANGIPKEDDGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D8A0", Offset = "0x6F6C2A0", VA = "0x186F6D8A0")]
	private void KFCBFJJPFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E410", Offset = "0x6F6CE10", VA = "0x186F6E410")]
	public APKOBJLAOFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class JJHDAPIBKEA : CFLHEBDIOOM, PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class JNOEFCLOECN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private readonly MDCEFFOBCGJ MBKCCCPKDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private readonly CancellationTokenSource NBIMBFBEBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public readonly CancellationToken JEHCHCJLNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private bool EIDIHEMGCHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private bool HEPHGBKCGHN;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F80F40", Offset = "0x6F7F940", VA = "0x186F80F40")]
		public JNOEFCLOECN(MDCEFFOBCGJ MBKCCCPKDIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F80DF0", Offset = "0x6F7F7F0", VA = "0x186F80DF0")]
		public void OINNMPMFHIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F80DC0", Offset = "0x6F7F7C0", VA = "0x186F80DC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class LIBGCIJGJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public GAKOKDPCJDJ disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public LIBGCIJGJLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F83560", Offset = "0x6F81F60", VA = "0x186F83560")]
		internal object CFEOGNOCJMB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct MIBDOBPJPCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public GAKOKDPCJDJ disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public JJHDAPIBKEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F84340", Offset = "0x6F82D40", VA = "0x186F84340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F846F0", Offset = "0x6F830F0", VA = "0x186F846F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class NKIFKJDMONK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public NKIFKJDMONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F87BE0", Offset = "0x6F865E0", VA = "0x186F87BE0")]
		internal object AHOLEMFFKKO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct PMGLPFIDCFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public JJHDAPIBKEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private NDMGMBJNGAH <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F89BD0", Offset = "0x6F885D0", VA = "0x186F89BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class JIOBLCJOBOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public MDCEFFOBCGJ newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public JIOBLCJOBOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EEC0", Offset = "0x6F7D8C0", VA = "0x186F7EEC0")]
		internal object OKJKCPEJKNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EE40", Offset = "0x6F7D840", VA = "0x186F7EE40")]
		internal object AAOCDBKFHJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EE80", Offset = "0x6F7D880", VA = "0x186F7EE80")]
		internal object BDAAHEEMICE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class MNNABECEKBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public MNNABECEKBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6F857B0", Offset = "0x6F841B0", VA = "0x186F857B0")]
		internal void MGLDIEDOPEF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct AMCNJHJALBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public MDCEFFOBCGJ newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public JJHDAPIBKEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public NDBDNDIBEKL customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private JIOBLCJOBOA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C840", Offset = "0x6F6B240", VA = "0x186F6C840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D7C0", Offset = "0x6F6C1C0", VA = "0x186F6D7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly DLHDKHODFIK.IDECIOKJCIE GFADKAIEHBF;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly OOEDGEBHONN ANCMAALIFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private AAEAMPAFKHI EJBKKDIKBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private NCJGEHACABB BMNLBFGMFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private OKJDCNBIHPD GLFIGPDLPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private LEMGGJFEOOO FBFDHBHFJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private PMOONCPIMJF BJLKGEMPJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private long LMOFHKEFDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private JNOEFCLOECN BBLKDFGODON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private bool MCELCAJFIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private Task NFFLGGNJGAJ;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private AELMJKLMOFJ DEOLIAGACBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F7FB60", Offset = "0x6F7E560", VA = "0x186F7FB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool MNCFCLCFAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x913BA0", VA = "0x1809151A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F8C0", Offset = "0x6F7E2C0", VA = "0x186F7F8C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F090", Offset = "0x6F7DA90", VA = "0x186F7F090", Slot = "4")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F400", Offset = "0x6F7DE00", VA = "0x186F7F400", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F8D0", Offset = "0x6F7E2D0", VA = "0x186F7F8D0")]
	[AsyncStateMachine(typeof(MIBDOBPJPCG))]
	private Task IAIMBLKJOOG(GAKOKDPCJDJ BBMEBNNFGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F9C0", Offset = "0x6F7E3C0", VA = "0x186F7F9C0")]
	private void IBDHDGIAILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F670", Offset = "0x6F7E070", VA = "0x186F7F670")]
	private void ELEFMALGPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FBB0", Offset = "0x6F7E5B0", VA = "0x186F7FBB0")]
	private void LBILAFKPMFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F800", Offset = "0x6F7E200", VA = "0x186F7F800")]
	private bool FGOJIPGDDOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F330", Offset = "0x6F7DD30", VA = "0x186F7F330")]
	[AsyncStateMachine(typeof(PMGLPFIDCFA))]
	private void DAAKLMFGMGO(int CEGCHAFCKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FD30", Offset = "0x6F7E730", VA = "0x186F7FD30")]
	private void ONDAKLAKLHC([Out] IDisposable ELCKNDAJHCP, [Out] IDisposable BAILDCGDPIN, [Out] IDisposable NGPDPCLFDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F570", Offset = "0x6F7DF70", VA = "0x186F7F570")]
	private bool EKPHOEHAJBL(MDCEFFOBCGJ MBKCCCPKDIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F870", Offset = "0x6F7E270", VA = "0x186F7F870")]
	private void HKKGHIILJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F7EF60", Offset = "0x6F7D960", VA = "0x186F7EF60")]
	[AsyncStateMachine(typeof(AMCNJHJALBK))]
	private Task AGDAHLOOHCH(MDCEFFOBCGJ MBKCCCPKDIM, NDBDNDIBEKL EDPPKGIKACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F80390", Offset = "0x6F7ED90", VA = "0x186F80390")]
	public JJHDAPIBKEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class COPBJMGGAKJ : OHKGMLEODIH, PEPBKNNAOIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct CNDCAIKNEGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder<INIFIJEJACJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public COPBJMGGAKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<INIFIJEJACJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F72080", Offset = "0x6F70A80", VA = "0x186F72080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F72310", Offset = "0x6F70D10", VA = "0x186F72310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class GLFCAHDBENF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public KDEKOFBPMEA message;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public GLFCAHDBENF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B4F0", Offset = "0x6F79EF0", VA = "0x186F7B4F0")]
		internal object IFLLMCLBILA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class PKNDHHAGHFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public KDEKOFBPMEA messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public PKNDHHAGHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F89B70", Offset = "0x6F88570", VA = "0x186F89B70")]
		internal object CNODJADBJKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class HMJLENPALEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public KDEKOFBPMEA request;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public HMJLENPALEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DC50", Offset = "0x6F7C650", VA = "0x186F7DC50")]
		internal object CAOFBJOIADC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct JKLDDNPKHHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public KDEKOFBPMEA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public COPBJMGGAKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<PBCHFFOPJGA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F80400", Offset = "0x6F7EE00", VA = "0x186F80400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F80CC0", Offset = "0x6F7F6C0", VA = "0x186F80CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class NLECEOABJBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public KDEKOFBPMEA operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public NLECEOABJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x6F87C50", Offset = "0x6F86650", VA = "0x186F87C50")]
		internal object LHIDDDNHDDL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct EFFGNNMFPDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public KDEKOFBPMEA operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public COPBJMGGAKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private KJCKCCPLGMI <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<KDEKOFBPMEA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6F76100", Offset = "0x6F74B00", VA = "0x186F76100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F76C60", Offset = "0x6F75660", VA = "0x186F76C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct ACOJJLONLHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder<PBCHFFOPJGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public COPBJMGGAKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public KDEKOFBPMEA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private DFGFEKEAGJI.EAIBCDEOPJK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private KJCKCCPLGMI <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private TaskAwaiter<KDEKOFBPMEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C1A0", Offset = "0x6F6ABA0", VA = "0x186F6C1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C6C0", Offset = "0x6F6B0C0", VA = "0x186F6C6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class PFICPHABEOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public PBCHFFOPJGA operation;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public PFICPHABEOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F89220", Offset = "0x6F87C20", VA = "0x186F89220")]
		internal object NBFFMFCDIDH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct BADIPKBFIHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public PBCHFFOPJGA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public COPBJMGGAKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private MIJAEHJIGEB<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E4D0", Offset = "0x6F6CED0", VA = "0x186F6E4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EB00", Offset = "0x6F6D500", VA = "0x186F6EB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class OINGAKMMKNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public KDEKOFBPMEA request;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public OINGAKMMKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x6F88450", Offset = "0x6F86E50", VA = "0x186F88450")]
		internal object LMEICBPODCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class DOGEFJEDCON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public KDEKOFBPMEA request;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public DOGEFJEDCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x6F75DF0", Offset = "0x6F747F0", VA = "0x186F75DF0")]
		internal object HBJOLMCOGEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private KFNFOHABKOA DCDEOEDJGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private DHMPDKOAFJG FELFOPBFACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private MGJBDANHKIB LIBJEBLDIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private FGAKHKLMNEL ILINKAEOFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private TaskCompletionSource<INIFIJEJACJ> DMJJNOFINEI;

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F72AD0", Offset = "0x6F714D0", VA = "0x186F72AD0", Slot = "7")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F72CD0", Offset = "0x6F716D0", VA = "0x186F72CD0", Slot = "6")]
	[AsyncStateMachine(typeof(CNDCAIKNEGA))]
	public Task<INIFIJEJACJ> GFGFINMFFFN(CancellationToken ICBCOAMELEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F73790", Offset = "0x6F72190", VA = "0x186F73790", Slot = "4")]
	public void NLCOLMLICPG(KDEKOFBPMEA BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F73430", Offset = "0x6F71E30", VA = "0x186F73430", Slot = "5")]
	public void NJBAOKAPNEM(KDEKOFBPMEA LIMMGNDBDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F72BC0", Offset = "0x6F715C0", VA = "0x186F72BC0")]
	[AsyncStateMachine(typeof(JKLDDNPKHHD))]
	private Task GBKPAKAELDL(KDEKOFBPMEA BJLMEIJMPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F73170", Offset = "0x6F71B70", VA = "0x186F73170")]
	[AsyncStateMachine(typeof(EFFGNNMFPDA))]
	private Task ILIKAPNNJLB(KDEKOFBPMEA AGAFPOBOHLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F72770", Offset = "0x6F71170", VA = "0x186F72770")]
	[AsyncStateMachine(typeof(ACOJJLONLHI))]
	private Task<PBCHFFOPJGA> AIBBMCGEIEF(KDEKOFBPMEA BJLMEIJMPBN, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F73280", Offset = "0x6F71C80", VA = "0x186F73280")]
	private KJCKCCPLGMI MMOKEBCIEKE(KDEKOFBPMEA MNFCPILNGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F73310", Offset = "0x6F71D10", VA = "0x186F73310")]
	[AsyncStateMachine(typeof(BADIPKBFIHB))]
	private Task NEPGIFEFDBP(PBCHFFOPJGA IOFDICGCDDA, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F728C0", Offset = "0x6F712C0", VA = "0x186F728C0")]
	private PBCHFFOPJGA BMNBFHLADHN(KDEKOFBPMEA BJLMEIJMPBN, KJCKCCPLGMI GOFDDCECDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2935270", Offset = "0x2933C70", VA = "0x182935270")]
	private T IMOHJHDGMFC<T>(T DBOBEHLEAAE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F72DE0", Offset = "0x6F717E0", VA = "0x186F72DE0")]
	private PBCHFFOPJGA HDGAGEMFOMO(KDEKOFBPMEA BJLMEIJMPBN, KJCKCCPLGMI GOFDDCECDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public COPBJMGGAKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class GOMKNDLJNAD : DHMPDKOAFJG, PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class ACGMNNJNEMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public ACGMNNJNEMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C130", Offset = "0x6F6AB30", VA = "0x186F6C130")]
		internal object PKNKBPLIMGC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class GOKOCHPODHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public GOKOCHPODHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B550", Offset = "0x6F79F50", VA = "0x186F7B550")]
		internal object LDHNGPKHFHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private FGAKHKLMNEL ILINKAEOFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private FGAGPKMFOJM DDCGNFKBKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private OHKGMLEODIH DBDKBGJLIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private NNKOOGLGKLN LDIEALKHGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private KPLBFHGIACD AEHNJKDNACC;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BB50", Offset = "0x6F7A550", VA = "0x186F7BB50", Slot = "6")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BCC0", Offset = "0x6F7A6C0", VA = "0x186F7BCC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C440", Offset = "0x6F7AE40", VA = "0x186F7C440", Slot = "4")]
	public NHOKOLNOMNB HKGJAPFMHOF(KDEKOFBPMEA IMKHDOECCFO)
	{
		return default(NHOKOLNOMNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BFF0", Offset = "0x6F7A9F0", VA = "0x186F7BFF0", Slot = "5")]
	public void FCEMKFMJBFG(Guid ANGIPKEDDGP, Task CLMNIFMLNNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D500", Offset = "0x6F7BF00", VA = "0x186F7D500")]
	private void PMJOKLAIOAO(byte BEDMMPCCKDC, int FHOIOAHBGEP, object NCCJIEJNAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B5C0", Offset = "0x6F79FC0", VA = "0x186F7B5C0")]
	private void BBEHLMAJJPE(GIAGMGELJDC ECOHBDCBECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D200", Offset = "0x6F7BC00", VA = "0x186F7D200")]
	private void NKNAFIKFMAH(GIAGMGELJDC ECOHBDCBECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CFC0", Offset = "0x6F7B9C0", VA = "0x186F7CFC0")]
	private void NCIOEOEDKGM(GIAGMGELJDC ECOHBDCBECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C200", Offset = "0x6F7AC00", VA = "0x186F7C200")]
	private EOMKIGIPEDC GEDJLNECIDJ(KDEKOFBPMEA MNFCPILNGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C870", Offset = "0x6F7B270", VA = "0x186F7C870")]
	private void HPAFMPLOMEM(KDEKOFBPMEA AGAFPOBOHLP, EOMKIGIPEDC MBJHBACEHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CA80", Offset = "0x6F7B480", VA = "0x186F7CA80")]
	private bool KHPONIJBKDI(KDEKOFBPMEA AGAFPOBOHLP, EOMKIGIPEDC MBJHBACEHFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BD70", Offset = "0x6F7A770", VA = "0x186F7BD70")]
	private bool EIBIKGFKOKD(KDEKOFBPMEA LMLBEGEDOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CD30", Offset = "0x6F7B730", VA = "0x186F7CD30")]
	private bool LJBNPHIKBID(byte BEDMMPCCKDC, ExitGames.Client.Photon.Hashtable ECOHBDCBECH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public GOMKNDLJNAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class HBFPGFHPNOO : GHLGEHANDPL, PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class CEMMHOPPLGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public INIFIJEJACJ operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public HBFPGFHPNOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public KDEKOFBPMEA roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public CEMMHOPPLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6F71EE0", Offset = "0x6F708E0", VA = "0x186F71EE0")]
		internal object KPCACMLFPAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6F71F50", Offset = "0x6F70950", VA = "0x186F71F50")]
		internal object OMKCMPIEIEE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct GCAOFLBALDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<EOMKIGIPEDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public HBFPGFHPNOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public KDEKOFBPMEA roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<EOMKIGIPEDC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6F797F0", Offset = "0x6F781F0", VA = "0x186F797F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6F79E80", Offset = "0x6F78880", VA = "0x186F79E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class EENDECNFHEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public INIFIJEJACJ operationType;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public EENDECNFHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6F76090", Offset = "0x6F74A90", VA = "0x186F76090")]
		internal object ICBGHNHBNIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class CPNBBLGOJDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public KDEKOFBPMEA request;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public CPNBBLGOJDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6F73B90", Offset = "0x6F72590", VA = "0x186F73B90")]
		internal object KJNENBHCKAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6F73B20", Offset = "0x6F72520", VA = "0x186F73B20")]
		internal object CJFMCAKNPJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6F73C00", Offset = "0x6F72600", VA = "0x186F73C00")]
		internal object PPNKFEJCBPG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct BIJFBEDFHFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<EOMKIGIPEDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public KDEKOFBPMEA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public HBFPGFHPNOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private CPNBBLGOJDP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private NHOKOLNOMNB <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private EOMKIGIPEDC <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private TaskAwaiter<(EOMKIGIPEDC validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FC00", Offset = "0x6F6E600", VA = "0x186F6FC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6F704B0", Offset = "0x6F6EEB0", VA = "0x186F704B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private FGAKHKLMNEL ILINKAEOFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private FGAGPKMFOJM DDCGNFKBKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private DHMPDKOAFJG FELFOPBFACA;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D710", Offset = "0x6F7C110", VA = "0x186F7D710", Slot = "5")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D9B0", Offset = "0x6F7C3B0", VA = "0x186F7D9B0", Slot = "4")]
	[AsyncStateMachine(typeof(GCAOFLBALDK))]
	private Task<EOMKIGIPEDC> ONGAIFLMNKF(KDEKOFBPMEA MNFCPILNGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D7C0", Offset = "0x6F7C1C0", VA = "0x186F7D7C0")]
	private bool GJCLEMHPIAG(INIFIJEJACJ KFHICACKEFH, [Out] EOMKIGIPEDC EBPHIJANMPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D5D0", Offset = "0x6F7BFD0", VA = "0x186F7D5D0")]
	[AsyncStateMachine(typeof(BIJFBEDFHFA))]
	private Task<EOMKIGIPEDC> BLBDNEECILE(KDEKOFBPMEA BJLMEIJMPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public HBFPGFHPNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class KNKDGJLEELI : NMPOIBENFNL, PEPBKNNAOIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct CDGIJNHCGGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<CCPGLNKCEAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public MDCEFFOBCGJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public KNKDGJLEELI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<LGDDBNGBFNG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x6F719C0", Offset = "0x6F703C0", VA = "0x186F719C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6F71E70", Offset = "0x6F70870", VA = "0x186F71E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class AIPNAJIOMGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AIPNAJIOMGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C730", Offset = "0x6F6B130", VA = "0x186F6C730")]
		internal object OLAMOLODLLK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct LDECMEJDBHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public AsyncTaskMethodBuilder<LGDDBNGBFNG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public KNKDGJLEELI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public MDCEFFOBCGJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private AIPNAJIOMGI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private TaskAwaiter<LGDDBNGBFNG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6F82960", Offset = "0x6F81360", VA = "0x186F82960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6F82F50", Offset = "0x6F81950", VA = "0x186F82F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class LEOOIEKPAGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public LEOOIEKPAGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x93F4C0", Offset = "0x93DEC0", VA = "0x18093F4C0")]
		internal bool LBMHFKBGDCD(PPOBPODJIIJ sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private OKJDCNBIHPD GLFIGPDLPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private KIIIEFGAAIL HNBLGIKEBNI;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private static readonly (DINCFJKGGOK superRoomData, long subRoomDataSaveId) FCHHPBPCHAD;

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6F81C40", Offset = "0x6F80640", VA = "0x186F81C40", Slot = "5")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x6F81CD0", Offset = "0x6F806D0", VA = "0x186F81CD0", Slot = "4")]
	[AsyncStateMachine(typeof(CDGIJNHCGGF))]
	public Task<CCPGLNKCEAO> GIDBKHJMIMJ(MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, MDCEFFOBCGJ HDKECBFDELN, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x6F82260", Offset = "0x6F80C60", VA = "0x186F82260")]
	[AsyncStateMachine(typeof(LDECMEJDBHI))]
	private Task<LGDDBNGBFNG> PKFOBDCNGCF(MDCEFFOBCGJ HDKECBFDELN, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x6F81E30", Offset = "0x6F80830", VA = "0x186F81E30")]
	private CCPGLNKCEAO GLCMDPLPEKO(MDCEFFOBCGJ HDKECBFDELN, LGDDBNGBFNG MDFHAANEALD, long KOIDPPGJKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x6F81F70", Offset = "0x6F80970", VA = "0x186F81F70")]
	private (DINCFJKGGOK, long) OJJOFEBKANP(MDCEFFOBCGJ HDKECBFDELN, LGDDBNGBFNG MDFHAANEALD, long KOIDPPGJKOA)
	{
		return default((DINCFJKGGOK, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public KNKDGJLEELI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[UnityEngine.Scripting.Preserve]
internal sealed class EJHDJPBDMHP : MGJBDANHKIB, PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class LPNHPFDLKFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public KDEKOFBPMEA request;

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public LPNHPFDLKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x6F840E0", Offset = "0x6F82AE0", VA = "0x186F840E0")]
		internal object JEGJEDBJDKL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct GDNKEIEBLJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public AsyncTaskMethodBuilder<KDEKOFBPMEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public KDEKOFBPMEA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public EJHDJPBDMHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public KJCKCCPLGMI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<KDEKOFBPMEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x6F79EF0", Offset = "0x6F788F0", VA = "0x186F79EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A500", Offset = "0x6F78F00", VA = "0x186F7A500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct DHBJEBCJNKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public AsyncTaskMethodBuilder<KDEKOFBPMEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public EJHDJPBDMHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public KJCKCCPLGMI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter<KCOGNGPBELA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x6F75780", Offset = "0x6F74180", VA = "0x186F75780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x6F75D80", Offset = "0x6F74780", VA = "0x186F75D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class NFLHHIKBJLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public KDEKOFBPMEA request;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public NFLHHIKBJLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x6F864B0", Offset = "0x6F84EB0", VA = "0x186F864B0")]
		internal object DFGMADMAEBC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct NAMENPAOAHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AsyncTaskMethodBuilder<KDEKOFBPMEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public KDEKOFBPMEA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public EJHDJPBDMHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public KJCKCCPLGMI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private GBKPFEMBBMK <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private GMMFKAIJEBI <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private TaskAwaiter<KCOGNGPBELA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6F85850", Offset = "0x6F84250", VA = "0x186F85850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x6F86440", Offset = "0x6F84E40", VA = "0x186F86440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private FGAKHKLMNEL ILINKAEOFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private AFFIPNIMMLK AMJDKNMBFCL;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private BJHEOJGGHKA AOKFJBPNPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6F78AA0", Offset = "0x6F774A0", VA = "0x186F78AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6F783F0", Offset = "0x6F76DF0", VA = "0x186F783F0", Slot = "8")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6F78690", Offset = "0x6F77090", VA = "0x186F78690", Slot = "4")]
	[AsyncStateMachine(typeof(GDNKEIEBLJK))]
	public Task<KDEKOFBPMEA> KCIELDBMDJL(KDEKOFBPMEA BJLMEIJMPBN, KJCKCCPLGMI GOFDDCECDPF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6F787F0", Offset = "0x6F771F0", VA = "0x186F787F0", Slot = "5")]
	[AsyncStateMachine(typeof(DHBJEBCJNKJ))]
	public Task<KDEKOFBPMEA> MECIOKMLJAM(CancellationToken AOLOJHLCMLE, KJCKCCPLGMI GOFDDCECDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6F78480", Offset = "0x6F76E80", VA = "0x186F78480", Slot = "6")]
	public DCDGPMPFNEE CKBOIEOAPCA(PBCHFFOPJGA NNOOHLHBLNB, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6F78B60", Offset = "0x6F77560", VA = "0x186F78B60", Slot = "7")]
	public DCDGPMPFNEE PHMJBBLKADK(PBCHFFOPJGA NNOOHLHBLNB, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6F78940", Offset = "0x6F77340", VA = "0x186F78940")]
	[AsyncStateMachine(typeof(NAMENPAOAHO))]
	private Task<KDEKOFBPMEA> MFLBONKGMLL(KDEKOFBPMEA BJLMEIJMPBN, KJCKCCPLGMI GOFDDCECDPF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x295DDE0", Offset = "0x295C7E0", VA = "0x18295DDE0")]
	private static byte[] GCODHKBMDKM(KDEKOFBPMEA BDCMABOIIFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public EJHDJPBDMHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class IHACGGJHCII : FGAGPKMFOJM, PEPBKNNAOIB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private HGFIBKFDNAE CFFJPMMONGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private FGAKHKLMNEL ILINKAEOFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private KFNFOHABKOA DCDEOEDJGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private MMGAKMADFKD CHMMLABHLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private OKJDCNBIHPD GLFIGPDLPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private PMOONCPIMJF BJLKGEMPJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private EHOAKANHCDL GCONENFMGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private LEMGGJFEOOO FBFDHBHFJCB;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private AELMJKLMOFJ DEOLIAGACBC
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E3B0", Offset = "0x6F7CDB0", VA = "0x186F7E3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private static EOMKIGIPEDC LHOANIGLBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E180", Offset = "0x6F7CB80", VA = "0x186F7E180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E010", Offset = "0x6F7CA10", VA = "0x186F7E010", Slot = "6")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E240", Offset = "0x6F7CC40", VA = "0x186F7E240", Slot = "4")]
	public EOMKIGIPEDC JINGFOBANPM(JDKCNIBKGKE BEJOAPBJCCE, INIFIJEJACJ BCMDHKBDLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DD10", Offset = "0x6F7C710", VA = "0x186F7DD10", Slot = "5")]
	public EOMKIGIPEDC AOFNBGKMODN(JDKCNIBKGKE MOIHANJJPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E1E0", Offset = "0x6F7CBE0", VA = "0x186F7E1E0")]
	private static EOMKIGIPEDC FBMEIAOGNHB(JGKBGCPBGJM GDIKEMIFDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public IHACGGJHCII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class BBBEJMIENNE : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x6F6ED60", Offset = "0x6F6D760", VA = "0x186F6ED60")]
	public BBBEJMIENNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x641D600", Offset = "0x641C000", VA = "0x18641D600")]
	public BBBEJMIENNE(string BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class NGHPAPOGEMC : BEGLGPNHNFE, PEPBKNNAOIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct KHEAIKGLBMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public AsyncTaskMethodBuilder<EOMKIGIPEDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public NGHPAPOGEMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public OPHHGBFNKCM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private MIJAEHJIGEB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private BKDMOFOGOPF <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter<EOMKIGIPEDC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6F81050", Offset = "0x6F7FA50", VA = "0x186F81050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6F81BD0", Offset = "0x6F805D0", VA = "0x186F81BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct OLMNNBLDFCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public NGHPAPOGEMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6F884B0", Offset = "0x6F86EB0", VA = "0x186F884B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6F88C00", Offset = "0x6F87600", VA = "0x186F88C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct LPAFKBGPADD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public NGHPAPOGEMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6F83B70", Offset = "0x6F82570", VA = "0x186F83B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6F84080", Offset = "0x6F82A80", VA = "0x186F84080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct GFCKCFDMAPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public NGHPAPOGEMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A570", Offset = "0x6F78F70", VA = "0x186F7A570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6F7ACC0", Offset = "0x6F796C0", VA = "0x186F7ACC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct BAKNLIPGPEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public NGHPAPOGEMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EB60", Offset = "0x6F6D560", VA = "0x186F6EB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6F6ED00", Offset = "0x6F6D700", VA = "0x186F6ED00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct DEEBPNACNIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public NGHPAPOGEMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6F75000", Offset = "0x6F73A00", VA = "0x186F75000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6F75720", Offset = "0x6F74120", VA = "0x186F75720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct FCGOMPPHKPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public NGHPAPOGEMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6F78F60", Offset = "0x6F77960", VA = "0x186F78F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6F793D0", Offset = "0x6F77DD0", VA = "0x186F793D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct JIGJCFFDNLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public NGHPAPOGEMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public MFIOOOIMKCN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private MIJAEHJIGEB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E880", Offset = "0x6F7D280", VA = "0x186F7E880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EDE0", Offset = "0x6F7D7E0", VA = "0x186F7EDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private FGAKHKLMNEL ILINKAEOFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private OKJDCNBIHPD GLFIGPDLPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private MGJBDANHKIB LIBJEBLDIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private KFNFOHABKOA DCDEOEDJGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private EHOAKANHCDL GCONENFMGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private CancellationTokenSource CAHIHBCPIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private Task LDKEMLLKLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private TaskCompletionSource<int> CFACHDOACEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private int DEOOHEPKANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private int MBJELLOLKNJ;

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x6F86890", Offset = "0x6F85290", VA = "0x186F86890", Slot = "6")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0xA6F300", Offset = "0xA6DD00", VA = "0x180A6F300", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x6F86D80", Offset = "0x6F85780", VA = "0x186F86D80")]
	private void GDANMIHMJMI(float MECPPINNJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6F86C50", Offset = "0x6F85650", VA = "0x186F86C50", Slot = "4")]
	[AsyncStateMachine(typeof(KHEAIKGLBMI))]
	public Task<EOMKIGIPEDC> EABIFPNCGAL(OPHHGBFNKCM HJPACFIDIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6F86610", Offset = "0x6F85010", VA = "0x186F86610", Slot = "5")]
	[AsyncStateMachine(typeof(OLMNNBLDFCK))]
	public Task ADOEFNDKAHM([Optional] CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0xA6F300", Offset = "0xA6DD00", VA = "0x180A6F300")]
	public void IAKAAAHOLOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6F87390", Offset = "0x6F85D90", VA = "0x186F87390")]
	private BKDMOFOGOPF OBNGJLPKMIH(OPHHGBFNKCM HJPACFIDIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6F872A0", Offset = "0x6F85CA0", VA = "0x186F872A0")]
	[AsyncStateMachine(typeof(LPAFKBGPADD))]
	private Task NHLBKONJFHI(FNGILHDDEFI MAJFEBAGNLL, CancellationToken NEGOEBJOBPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6F86510", Offset = "0x6F84F10", VA = "0x186F86510")]
	[AsyncStateMachine(typeof(GFCKCFDMAPI))]
	private Task AAIJOGIOALP(CancellationToken NEGOEBJOBPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6F86E60", Offset = "0x6F85860", VA = "0x186F86E60")]
	[AsyncStateMachine(typeof(BAKNLIPGPEO))]
	private Task IGDCABFCIFD([Optional] CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x6F86F50", Offset = "0x6F85950", VA = "0x186F86F50")]
	[AsyncStateMachine(typeof(DEEBPNACNIP))]
	private Task KMDBPOMBOAA(CancellationToken NEGOEBJOBPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x6F86A40", Offset = "0x6F85440", VA = "0x186F86A40")]
	[AsyncStateMachine(typeof(FCGOMPPHKPJ))]
	private Task CNKMBPLEFJN(CancellationToken EKJBNNGLGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6F86700", Offset = "0x6F85100", VA = "0x186F86700")]
	private Task BAHJHFDPDPE(MFIOOOIMKCN JHBPEHBAAIE, CancellationToken NEGOEBJOBPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6F86B40", Offset = "0x6F85540", VA = "0x186F86B40")]
	[AsyncStateMachine(typeof(JIGJCFFDNLK))]
	private Task DBPBFHHHNPI(MFIOOOIMKCN JHBPEHBAAIE, CancellationToken NEGOEBJOBPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6F87040", Offset = "0x6F85A40", VA = "0x186F87040")]
	private bool LPHNNPBGKGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public NGHPAPOGEMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[UnityEngine.Scripting.Preserve]
internal class LNLKCIFNNJG : MMGAKMADFKD, PEPBKNNAOIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct OONJKPKGKAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public LNLKCIFNNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private MIJAEHJIGEB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x6F88C60", Offset = "0x6F87660", VA = "0x186F88C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x6F891C0", Offset = "0x6F87BC0", VA = "0x186F891C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private NIIHFLNBIAN HGMPAJFOMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private FGAGPKMFOJM DDCGNFKBKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private MGJBDANHKIB LIBJEBLDIFB;

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6F836F0", Offset = "0x6F820F0", VA = "0x186F836F0", Slot = "6")]
	public void CCPNKNOIBEC(DPFMBDJKAOB GFAOFFCNKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6F839D0", Offset = "0x6F823D0", VA = "0x186F839D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6F835F0", Offset = "0x6F81FF0", VA = "0x186F835F0", Slot = "5")]
	[AsyncStateMachine(typeof(OONJKPKGKAF))]
	public Task BDLHNNPNBDC(string LLLIHNDJKKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6F83B10", Offset = "0x6F82510", VA = "0x186F83B10", Slot = "4")]
	public EOMKIGIPEDC LPHNNPBGKGD(JDKCNIBKGKE BEJOAPBJCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6F83A20", Offset = "0x6F82420", VA = "0x186F83A20")]
	private EHGIHIDKNJE FAPEDPEFEOL(string LLLIHNDJKKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public LNLKCIFNNJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class CBLKAMCIMMP
{
	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6F710F0", Offset = "0x6F6FAF0", VA = "0x186F710F0")]
	public static void CDFGKJEPLNB(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6F71330", Offset = "0x6F6FD30", VA = "0x186F71330")]
	internal static void CKAADONPNEA(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6F718E0", Offset = "0x6F702E0", VA = "0x186F718E0")]
	internal static void JDHMHABCIAO(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6F71490", Offset = "0x6F6FE90", VA = "0x186F71490")]
	internal static void EEMAKMCCOPH(GPECMKAJNMD FOPICBKBDEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class BNOOECCGECO : GOMNIFLJAMN<KDEKOFBPMEA>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class AANIOAKOJBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public KDEKOFBPMEA message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AANIOAKOJBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BDD0", Offset = "0x6F6A7D0", VA = "0x186F6BDD0")]
		internal object LGMKBDIIGCN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly BNOOECCGECO OHJMENPNAKB;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6F70DF0", Offset = "0x6F6F7F0", VA = "0x186F70DF0")]
	public ExitGames.Client.Photon.Hashtable KJCBMOAEMAH(KDEKOFBPMEA BDCMABOIIFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6F70A10", Offset = "0x6F6F410", VA = "0x186F70A10", Slot = "5")]
	protected override void GBCACBJPJFI(KDEKOFBPMEA BDCMABOIIFF, IDictionary<object, object> EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6F707E0", Offset = "0x6F6F1E0", VA = "0x186F707E0", Slot = "6")]
	public override KDEKOFBPMEA FIOJCIMJMME(IDictionary<object, object> EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6F70E80", Offset = "0x6F6F880", VA = "0x186F70E80")]
	private static void MDBGGDKNGAC(string HOOCHEJJIDI, KDEKOFBPMEA BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6F71030", Offset = "0x6F6FA30", VA = "0x186F71030")]
	public BNOOECCGECO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6F70B40", Offset = "0x6F6F540", VA = "0x186F70B40")]
	[CompilerGenerated]
	internal static string HMIDKJJJLHK(CCPGLNKCEAO NBBCEJPPPCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class IOBKDGPBBJA
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public static EOMKIGIPEDC LHOANIGLBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E180", Offset = "0x6F7CB80", VA = "0x186F7E180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E660", Offset = "0x6F7D060", VA = "0x186F7E660")]
	public static bool FEDFLEDDLNH(this EOMKIGIPEDC MBJHBACEHFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E1E0", Offset = "0x6F7CBE0", VA = "0x186F7E1E0")]
	public static EOMKIGIPEDC FBMEIAOGNHB(JGKBGCPBGJM MMHLCHJMJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E680", Offset = "0x6F7D080", VA = "0x186F7E680")]
	public static EOMKIGIPEDC NNFPFFNLFKN(IEnumerable<EOMKIGIPEDC> KEPHBFPMOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E400", Offset = "0x6F7CE00", VA = "0x186F7E400")]
	public static string COKEENBGGPF(this EOMKIGIPEDC EBPHIJANMPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class GIIJNDODGPL : FLDBFGJNDHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public delegate EOMKIGIPEDC ADOFNAPFDID([NotNull] JDKCNIBKGKE OGGDNINFNED);

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class OOJODFLDAJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public JDKCNIBKGKE photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public OOJODFLDAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x661A830", Offset = "0x6619230", VA = "0x18661A830")]
		internal EOMKIGIPEDC FKGKEHLNOMA(ADOFNAPFDID v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private bool MENBJDNCHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	protected readonly HashSet<ADOFNAPFDID> CCAPHCKKCIK;

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B400", Offset = "0x6F79E00", VA = "0x186F7B400", Slot = "4")]
	public void KEEDIPIMILL(ADOFNAPFDID EMKGIAGBKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B0B0", Offset = "0x6F79AB0", VA = "0x186F7B0B0", Slot = "5")]
	public void BBDHDKGLKHD(ADOFNAPFDID EMKGIAGBKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B110", Offset = "0x6F79B10", VA = "0x186F7B110", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B160", Offset = "0x6F79B60", VA = "0x186F7B160")]
	protected EOMKIGIPEDC IFHNPGIMNBE(JDKCNIBKGKE MOIHANJJPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B460", Offset = "0x6F79E60", VA = "0x186F7B460")]
	protected GIIJNDODGPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class OEHDHOEHDNK : GIIJNDODGPL, HGFIBKFDNAE, FLDBFGJNDHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class NKDKDDOOILC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public EOMKIGIPEDC result;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public NKDKDDOOILC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F87B80", Offset = "0x6F86580", VA = "0x186F87B80")]
		internal object DDLFDKALDOB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F88330", Offset = "0x6F86D30", VA = "0x186F88330")]
	[UnityEngine.Scripting.Preserve]
	public OEHDHOEHDNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F88340", Offset = "0x6F86D40", VA = "0x186F88340", Slot = "8")]
	public EOMKIGIPEDC GBLCCNHGHFI(JDKCNIBKGKE MOIHANJJPJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class ODFPKNEEEMK : GIIJNDODGPL, NIIHFLNBIAN, FLDBFGJNDHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class DBFEJMJJOBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public EOMKIGIPEDC result;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public DBFEJMJJOBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F73C70", Offset = "0x6F72670", VA = "0x186F73C70")]
		internal object LNJKBMMLHBJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F88330", Offset = "0x6F86D30", VA = "0x186F88330")]
	[UnityEngine.Scripting.Preserve]
	public ODFPKNEEEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F88220", Offset = "0x6F86C20", VA = "0x186F88220", Slot = "8")]
	public EOMKIGIPEDC LPHNNPBGKGD(JDKCNIBKGKE FFJFLMHOJHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class FMBKOFNODOL
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class BPBAAHEHBBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public MIJAEHJIGEB<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public BPBAAHEHBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F71070", Offset = "0x6F6FA70", VA = "0x186F71070")]
		internal object MKJHHHCIKBH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F79630", Offset = "0x6F78030", VA = "0x186F79630")]
	public static MIJAEHJIGEB<string> HKKNDEJPNJI(LGKLDLNGEGN DHOGKNDCDMM, [Optional] string CHMBMDOLMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F794B0", Offset = "0x6F77EB0", VA = "0x186F794B0")]
	public static void CNLJLILBIHH(MIJAEHJIGEB<string> GJLENOHHOLD, LGKLDLNGEGN DHOGKNDCDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F79570", Offset = "0x6F77F70", VA = "0x186F79570")]
	public static string EFKLPCLCMPA(KDEKOFBPMEA MNFCPILNGAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class MANNPDLLNEH
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F84140", Offset = "0x6F82B40", VA = "0x186F84140")]
	public static void EAIPFODEECM(this FGAKHKLMNEL ILINKAEOFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F84270", Offset = "0x6F82C70", VA = "0x186F84270")]
	public static void OBMPCJFFJCI(this FGAKHKLMNEL ILINKAEOFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F84150", Offset = "0x6F82B50", VA = "0x186F84150")]
	private static void EGPMPCFJBPP(this FGAKHKLMNEL ILINKAEOFIO, bool FHJNBKKLPPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class OAKDNNIOEKH : KGMIOAOMIPE, OOAABLJLPBA, JBNANBBIFBM, FNGDKKGMMKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private readonly OOAABLJLPBA OMOHMAPBEAB;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public JDKCNIBKGKE IEINKFJJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F88180", Offset = "0x6F86B80", VA = "0x186F88180", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int GLNAKAMKPOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F87D60", Offset = "0x6F86760", VA = "0x186F87D60", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public int MKDFPMEPAGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F881D0", Offset = "0x6F86BD0", VA = "0x186F881D0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool IGOCMKBBFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public int HFHFNLPBFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x8B8450", Offset = "0x8B6E50", VA = "0x1808B8450", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event IHCGIJLNMPA.KBLJBOGHOIA GFEGKECCCFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event DGOGFKMJGLB DAEGHDJCGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F87F10", Offset = "0x6F86910", VA = "0x186F87F10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F87FB0", Offset = "0x6F869B0", VA = "0x186F87FB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> CCEODECEENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<JDKCNIBKGKE> GOFGEPMBEBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action OOHDDHJBLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x6F87E50", Offset = "0x6F86850", VA = "0x186F87E50", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F87DB0", Offset = "0x6F867B0", VA = "0x186F87DB0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0xCA1540", Offset = "0xC9FF40", VA = "0x180CA1540")]
	public OAKDNNIOEKH(OOAABLJLPBA OMOHMAPBEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F87CB0", Offset = "0x6F866B0", VA = "0x186F87CB0", Slot = "8")]
	public bool BMJIPCINGIA(byte BEDMMPCCKDC, ExitGames.Client.Photon.Hashtable LLHLGHCEKMK, KKFFNPANNKN IMFDJHHCDMD, SendOptions FFJHELMNLKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F88050", Offset = "0x6F86A50", VA = "0x186F88050", Slot = "16")]
	public JDKCNIBKGKE KKCEJIBAPJP(int JBNPKIOAEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "19")]
	public void EKBFOLFCBKK(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "20")]
	public void AEPNIELODGD(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "21")]
	public void KDFAFLKKHDL(object JCIFCENKMKP, bool EJIHAKFCFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F88130", Offset = "0x6F86B30", VA = "0x186F88130", Slot = "22")]
	public IDisposable LHONJENHODK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "23")]
	private bool FHKAJHCALNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "24")]
	public void IPPHOGOJJDL(StringBuilder ODJPIMKJDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F87EF0", Offset = "0x6F868F0", VA = "0x186F87EF0", Slot = "25")]
	public bool IAGPCKBOIGA(bool LJHMDADACPJ, [Out] string BKMJJACFCBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x96BA80", Offset = "0x96A480", VA = "0x18096BA80", Slot = "28")]
	public void AJJAOAEJDHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct GIAGMGELJDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private readonly IDictionary<object, object> ECOHBDCBECH;

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
	public GIAGMGELJDC(IDictionary<object, object> ECOHBDCBECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B000", Offset = "0x6F79A00", VA = "0x186F7B000")]
	public bool LAPJEHOGHOC([Out] KDEKOFBPMEA BDCMABOIIFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AF50", Offset = "0x6F79950", VA = "0x186F7AF50")]
	public Guid CIMLEIMNCCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AD20", Offset = "0x6F79720", VA = "0x186F7AD20")]
	public EOMKIGIPEDC AOHKIEJJFNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AE60", Offset = "0x6F79860", VA = "0x186F7AE60")]
	public static ExitGames.Client.Photon.Hashtable CBNOJCEAKCL(KDEKOFBPMEA BDCMABOIIFF, EOMKIGIPEDC MBJHBACEHFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class FGINFEFOGOH
{
	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F79430", Offset = "0x6F77E30", VA = "0x186F79430")]
	public static bool LCOIDOGDIFE(this MDCEFFOBCGJ BOKMEBAEBFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct BLECJCCLLIM : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct EDJAAPKNDMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public BLECJCCLLIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x6F75E50", Offset = "0x6F74850", VA = "0x186F75E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F76030", Offset = "0x6F74A30", VA = "0x186F76030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly CancellationTokenSource NBIMBFBEBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private bool MENBJDNCHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private Task JCINMAJOONI;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool JPOGMMCJBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F70520", Offset = "0x6F6EF20", VA = "0x186F70520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F706B0", Offset = "0x6F6F0B0", VA = "0x186F706B0")]
	public BLECJCCLLIM(CancellationToken AOLOJHLCMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F70550", Offset = "0x6F6EF50", VA = "0x186F70550")]
	[AsyncStateMachine(typeof(EDJAAPKNDMO))]
	public Task CGPBIEDDAFG(Func<CancellationToken, List<Task>> LEJJCLAGFFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F70660", Offset = "0x6F6F060", VA = "0x186F70660", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct LHAOKGDJLCH<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct DHGDCKPHHKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<FOAIIODBMAA<TData>, DNHFHLFKGGH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public LHAOKGDJLCH<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private TaskAwaiter<FNBKHJCMJJM<FOAIIODBMAA<TData>, DNHFHLFKGGH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x57BD140", Offset = "0x57BBB40", VA = "0x1857BD140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x41C0730", Offset = "0x41BF130", VA = "0x1841C0730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private readonly HJEPJPFHOMO<TGetDataArg, TData> OHOKKIEJNJH;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
	internal LHAOKGDJLCH(HJEPJPFHOMO<TGetDataArg, TData> GMLBPALEECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x4286850", Offset = "0x4285250", VA = "0x184286850")]
	[AsyncStateMachine(typeof(LHAOKGDJLCH<, >.DHGDCKPHHKG))]
	public Task<FNBKHJCMJJM<FOAIIODBMAA<TData>, DNHFHLFKGGH>> BMNALBJNNPN(TGetDataArg PCNJMLOHDMH, string JACOKMGDPAN, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class KICILJCPLJH
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A613F0", Offset = "0x2A5FDF0", VA = "0x182A613F0")]
	public static LHAOKGDJLCH<TGetDataArg, TData> KHKANEAPNIK<TGetDataArg, TData>(HJEPJPFHOMO<TGetDataArg, TData> GMLBPALEECE)
	{
		return default(LHAOKGDJLCH<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct PGHNGJNIFIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public readonly int BKIGGLLPDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public readonly int? PELPDDCCFEA;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x4256550", Offset = "0x4254F50", VA = "0x184256550")]
	public PGHNGJNIFIL(int KIPEDCEMNBN, [Optional] int? FDNMCPLMEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F892A0", Offset = "0x6F87CA0", VA = "0x186F892A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface OIAHMMNBJMC<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCKOKJGKNJJ();

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OIAHMMNBJMC<T> PFIJLMNIJIN(string KMGMFBCECLK);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OIAHMMNBJMC<T> HJGDMKGCGMI(OGPACDGJMKM<T> EICPLMKHIBO);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OIAHMMNBJMC<T> HPGPKPKFAAP(int OKEIDPHGIFB);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OIAHMMNBJMC<T> BDKOFKBCPBB(int OKEIDPHGIFB, DKFHIEEHMKC<T> BDHKONMKFMM);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface CHEBGDLLLJJ
{
	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OIAHMMNBJMC<T> GBCKHCMDIPG<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MBBNHIKENJM GOHBILNCPML(Exception JKHACPOPJJF);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PGHNGJNIFIL KCDMOFGBNNF(Exception JKHACPOPJJF);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate string OGPACDGJMKM<in T>(T JKHACPOPJJF) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public delegate int DKFHIEEHMKC<in T>(T JKHACPOPJJF) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class EIAGBFLPEED : CHEBGDLLLJJ
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate string GLKPOLPCDDC(Exception JKHACPOPJJF);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private delegate int GDNCHMLOIML(Exception JKHACPOPJJF);

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class BJDLGDIFFEK<T> : OIAHMMNBJMC<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class GCBALIKGCEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public GCBALIKGCEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
			internal string FJCPAFGJCEK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class JJKHOGMPILC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public OGPACDGJMKM<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public JJKHOGMPILC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x3BEE560", Offset = "0x3BECF60", VA = "0x183BEE560")]
			internal string MFOKLPJAALM(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class FBDACOOJGGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public DKFHIEEHMKC<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public FBDACOOJGGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x3BEE560", Offset = "0x3BECF60", VA = "0x183BEE560")]
			internal int CFONAPHBNOH(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private readonly EIAGBFLPEED PENBLNINCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private readonly Type AFGGLBEBNJL;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x4E1DA50", Offset = "0x4E1C450", VA = "0x184E1DA50")]
		internal BJDLGDIFFEK(EIAGBFLPEED PENBLNINCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D670", Offset = "0x4E1C070", VA = "0x184E1D670", Slot = "4")]
		public void BCKOKJGKNJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D930", Offset = "0x4E1C330", VA = "0x184E1D930", Slot = "5")]
		public OIAHMMNBJMC<T> PFIJLMNIJIN(string KMGMFBCECLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D7D0", Offset = "0x4E1C1D0", VA = "0x184E1D7D0", Slot = "6")]
		public OIAHMMNBJMC<T> HJGDMKGCGMI(OGPACDGJMKM<T> EICPLMKHIBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D8F0", Offset = "0x4E1C2F0", VA = "0x184E1D8F0", Slot = "7")]
		public OIAHMMNBJMC<T> HPGPKPKFAAP(int OKEIDPHGIFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D6A0", Offset = "0x4E1C0A0", VA = "0x184E1D6A0", Slot = "8")]
		public OIAHMMNBJMC<T> BDKOFKBCPBB(int OKEIDPHGIFB, DKFHIEEHMKC<T> BDHKONMKFMM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class KCOHGNCBIIA<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private bool DHCNGCAHOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private readonly List<Type> LJAPDOAGFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private readonly Dictionary<Type, TVal> IJMNBIKBDJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private readonly Dictionary<Type, int> BEDOBKJNMGM;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public IReadOnlyList<Type> FLDOOBBJEML
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x41B8D00", Offset = "0x41B7700", VA = "0x1841B8D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x41B8E00", Offset = "0x41B7800", VA = "0x1841B8E00")]
		public KCOHGNCBIIA(Dictionary<Type, int> BEDOBKJNMGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x41B8B50", Offset = "0x41B7550", VA = "0x1841B8B50")]
		public void KODKNHDNNHA(Type LDDEKIBHION, TVal EHIEOLDDJEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x41B8DB0", Offset = "0x41B77B0", VA = "0x1841B8DB0")]
		public bool PAJHEFCGDII(Type AFGGLBEBNJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x41B8C00", Offset = "0x41B7600", VA = "0x1841B8C00")]
		public bool MGJGGIIDGHB(TVal DBOBEHLEAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x41B8910", Offset = "0x41B7310", VA = "0x1841B8910")]
		public TVal AMGKFNFCLFC(Type ADDOHDGDFOD)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x41B8A00", Offset = "0x41B7400", VA = "0x1841B8A00")]
		[CompilerGenerated]
		private int BBJLIGJOFEM(Type FLIKJKNFPBG, Type MFIPEGKJMNG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class PGLHOEIHBJH : IEnumerable<PGHNGJNIFIL>, IEnumerable, IEnumerator<PGHNGJNIFIL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private PGHNGJNIFIL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public EIAGBFLPEED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private IEnumerator<PGHNGJNIFIL> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private PGHNGJNIFIL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x38D9550", Offset = "0x38D7F50", VA = "0x1838D9550", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PGHNGJNIFIL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x6F899D0", Offset = "0x6F883D0", VA = "0x186F899D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x8A7B40", Offset = "0x8A6540", VA = "0x1808A7B40")]
		[DebuggerHidden]
		public PGLHOEIHBJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x6F89A20", Offset = "0x6F88420", VA = "0x186F89A20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x6F89420", Offset = "0x6F87E20", VA = "0x186F89420", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x6F893D0", Offset = "0x6F87DD0", VA = "0x186F893D0")]
		private void KBJJHHPKCPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x6F89380", Offset = "0x6F87D80", VA = "0x186F89380")]
		private void FLCLOIILAFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x6F89980", Offset = "0x6F88380", VA = "0x186F89980", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x6F898C0", Offset = "0x6F882C0", VA = "0x186F898C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PGHNGJNIFIL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x6F898C0", Offset = "0x6F882C0", VA = "0x186F898C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private static readonly PGHNGJNIFIL JMBLFCLHICE;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private static readonly Dictionary<Type, int> BLBPOCFJIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private readonly HashSet<Type> BNGDEINNOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private readonly KCOHGNCBIIA<int> DNGGACEFMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private readonly KCOHGNCBIIA<GDNCHMLOIML> AGKDOIOMAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private readonly KCOHGNCBIIA<GLKPOLPCDDC> HLLAJFMGJGJ;

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6F77090", Offset = "0x6F75A90", VA = "0x186F77090")]
	[MHFEIEAPENL(CMFCLNIIIKO.GameOnly)]
	private static void CGLKAELBCAP(GPECMKAJNMD MJAMFOPMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F780C0", Offset = "0x6F76AC0", VA = "0x186F780C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EIAGBFLPEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2960650", Offset = "0x295F050", VA = "0x182960650", Slot = "4")]
	public OIAHMMNBJMC<T> GBCKHCMDIPG<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6F771A0", Offset = "0x6F75BA0", VA = "0x186F771A0", Slot = "5")]
	public MBBNHIKENJM GOHBILNCPML(Exception JKHACPOPJJF)
	{
		return default(MBBNHIKENJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x6F77810", Offset = "0x6F76210", VA = "0x186F77810", Slot = "6")]
	public PGHNGJNIFIL KCDMOFGBNNF(Exception? JKHACPOPJJF)
	{
		return default(PGHNGJNIFIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x6F77100", Offset = "0x6F75B00", VA = "0x186F77100", Slot = "7")]
	[IteratorStateMachine(typeof(PGLHOEIHBJH))]
	public IEnumerable<PGHNGJNIFIL> GDJBBOINCND(Exception JKHACPOPJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x6F775E0", Offset = "0x6F75FE0", VA = "0x186F775E0", Slot = "8")]
	public string HJFHHLOMNHB(Exception? JKHACPOPJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x6F77CE0", Offset = "0x6F766E0", VA = "0x186F77CE0")]
	private string OLMHDGFPELP(AggregateException PEIAJCKINJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x6F77230", Offset = "0x6F75C30", VA = "0x186F77230")]
	private void HGFMINLIDIM(Type AFGGLBEBNJL, int OKEIDPHGIFB, GDNCHMLOIML? HAJAEKHNCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6F76E40", Offset = "0x6F75840", VA = "0x186F76E40")]
	private void BJNHBDNEFOO(Type AFGGLBEBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6F77A10", Offset = "0x6F76410", VA = "0x186F77A10")]
	private void MPIIKNIJDIM(Type AFGGLBEBNJL, GLKPOLPCDDC AAGMCAKDFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6F76CC0", Offset = "0x6F756C0", VA = "0x186F76CC0")]
	private static int BABBMEEINJF(Type AFGGLBEBNJL, Dictionary<Type, int> BEDOBKJNMGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x29B2B60", Offset = "0x29B1560", VA = "0x1829B2B60")]
	private static bool ELKABLKIEHH<TVal>(KCOHGNCBIIA<TVal> AHBFNFFEMPG, Type AFGGLBEBNJL, [Out] TVal DBOBEHLEAAE) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x6F77730", Offset = "0x6F76130", VA = "0x186F77730")]
	[CompilerGenerated]
	internal static int JKMBOKFICLI(Type HCIMLDKOHMG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct MBBNHIKENJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public readonly PGHNGJNIFIL HHKEHGACGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public readonly string KHBFHNNLHKP;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6F84320", Offset = "0x6F82D20", VA = "0x186F84320")]
	public MBBNHIKENJM(string GOGMJFFIBGN, PGHNGJNIFIL OKEIDPHGIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6F84280", Offset = "0x6F82C80", VA = "0x186F84280")]
	public string KEFKDDNAFPD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class BDMPGCNODMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private readonly EFAKPLKDOEA LHHMHJDKNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private string IJDIINPKIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private long? DNCPJNLLKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private long? HMGACIMPNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private long? GDMEFLEPKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private string ENPPDGJKDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private EAODDEEJJHO EFNIJOALNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private long? NBEGPHCLMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private bool FHGEFKPCEPC;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public string HBFDDBICFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long DPODAEOMOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EEE0", Offset = "0x6F6D8E0", VA = "0x186F6EEE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public long NLBBDNPCCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F330", Offset = "0x6F6DD30", VA = "0x186F6F330")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public long MJMFEGINFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F5E0", Offset = "0x6F6DFE0", VA = "0x186F6F5E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string CPMCJNPPKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EEA0", Offset = "0x6F6D8A0", VA = "0x186F6EEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public EAODDEEJJHO CLOHFGLKPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA57E20", Offset = "0xA56820", VA = "0x180A57E20")]
		get
		{
			return default(EAODDEEJJHO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FAD0", Offset = "0x6F6E4D0", VA = "0x186F6FAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public long PPJOGGBBHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EE40", Offset = "0x6F6D840", VA = "0x186F6EE40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FBC0", Offset = "0x6F6E5C0", VA = "0x186F6FBC0")]
	[UnityEngine.Scripting.Preserve]
	public BDMPGCNODMK([OHLKLPAILPF(null)] EFAKPLKDOEA LHHMHJDKNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F390", Offset = "0x6F6DD90", VA = "0x186F6F390")]
	private void KKDOADIAFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F640", Offset = "0x6F6E040", VA = "0x186F6F640")]
	public void LBPGBMOPHHN(long ONILLAPMLEN, long KOIDPPGJKOA, [Optional] long? MAKJFMMHJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EDA0", Offset = "0x6F6D7A0", VA = "0x186F6EDA0")]
	public void DFHELADNJOL(long MAKJFMMHJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F2B0", Offset = "0x6F6DCB0", VA = "0x186F6F2B0")]
	public void HDLJJMHKJBN(string KDAHIMHJBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EF40", Offset = "0x6F6D940", VA = "0x186F6EF40")]
	public void GNBGPGCCACE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class DCDGPMPFNEE : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct LFLMOJANFLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public AsyncTaskMethodBuilder<KDEKOFBPMEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public KDEKOFBPMEA roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public DCDGPMPFNEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private TaskAwaiter<BJHEOJGGHKA.NENMAPIPDEH<KDEKOFBPMEA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x6F82FC0", Offset = "0x6F819C0", VA = "0x186F82FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x6F834F0", Offset = "0x6F81EF0", VA = "0x186F834F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct FDCAKLGKOLH<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class FPEABLEIBCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public KDEKOFBPMEA roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public FPEABLEIBCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x6F79710", Offset = "0x6F78110", VA = "0x186F79710")]
		internal KDEKOFBPMEA DBLFCIPMHDK(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct NGOABGFKAAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public AsyncTaskMethodBuilder<BJHEOJGGHKA.NENMAPIPDEH<KDEKOFBPMEA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public KDEKOFBPMEA roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public DCDGPMPFNEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private GBKPFEMBBMK <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private TaskAwaiter<BJHEOJGGHKA.NENMAPIPDEH<KDEKOFBPMEA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x6F87500", Offset = "0x6F85F00", VA = "0x186F87500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x6F87B10", Offset = "0x6F86510", VA = "0x186F87B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct FMAENLJBBIA<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public DCDGPMPFNEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x3C285D0", Offset = "0x3C26FD0", VA = "0x183C285D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x35503C0", Offset = "0x354EDC0", VA = "0x1835503C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct AIDJCELNFMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public DCDGPMPFNEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B840", Offset = "0x6F8A240", VA = "0x186F8B840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x6F8BA00", Offset = "0x6F8A400", VA = "0x186F8BA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class JIMDDPGKPOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public JIMDDPGKPOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A330", Offset = "0x6F98D30", VA = "0x186F9A330")]
		internal object PPJLBLHJBBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A270", Offset = "0x6F98C70", VA = "0x186F9A270")]
		internal bool GPDLIKCLKPF(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class ABEFKKGOJIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public ABEFKKGOJIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B770", Offset = "0x6F8A170", VA = "0x186F8B770")]
		internal object EELOPCFENOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class LPPGEFKHEEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public LPPGEFKHEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9D8E0", Offset = "0x6F9C2E0", VA = "0x186F9D8E0")]
		internal object MMIFIODOHCE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class ACOOBCKKAPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public ACOOBCKKAPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B7D0", Offset = "0x6F8A1D0", VA = "0x186F8B7D0")]
		internal object LBPJDIPJBKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class EDAAADNBLMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public DCDGPMPFNEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public EDAAADNBLMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x6F91490", Offset = "0x6F8FE90", VA = "0x186F91490")]
		internal object LGMKBDIIGCN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static readonly Guid OJGBMDDLKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public readonly PBCHFFOPJGA AMGDAMGLDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private readonly BJHEOJGGHKA HGDMAIOKHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly JBNANBBIFBM ILINKAEOFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly FNGDKKGMMKN HMFFJGBKMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private bool MHOENBEMKLG;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6F74DA0", Offset = "0x6F737A0", VA = "0x186F74DA0")]
	public DCDGPMPFNEE(PBCHFFOPJGA IOFDICGCDDA, BJHEOJGGHKA HGDMAIOKHEG, JBNANBBIFBM ILINKAEOFIO, FNGDKKGMMKN HMFFJGBKMPK, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6F73E20", Offset = "0x6F72820", VA = "0x186F73E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6F73E20", Offset = "0x6F72820", VA = "0x186F73E20")]
	public void DABLPAPBNAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F40", Offset = "0x6F72940", VA = "0x186F73F40")]
	public void DEFBGOAJBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6F74000", Offset = "0x6F72A00", VA = "0x186F74000")]
	public void EAJGDOCGMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6F74590", Offset = "0x6F72F90", VA = "0x186F74590")]
	[AsyncStateMachine(typeof(LFLMOJANFLJ))]
	internal Task<KDEKOFBPMEA> LOOGEEHDLPJ(MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, KDEKOFBPMEA MNFCPILNGAF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x295DDE0", Offset = "0x295C7E0", VA = "0x18295DDE0")]
	private static byte[] GFBCNECCFNF<T>(T BDCMABOIIFF) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x295DDF0", Offset = "0x295C7F0", VA = "0x18295DDF0")]
	private static T IAEMMKBLKBL<T>(MessageParser<T> MDIGDONIMLJ, byte[] BDCMABOIIFF, T MFKOMMEOBKH) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6F742C0", Offset = "0x6F72CC0", VA = "0x186F742C0")]
	[AsyncStateMachine(typeof(NGOABGFKAAH))]
	private Task<BJHEOJGGHKA.NENMAPIPDEH<KDEKOFBPMEA>> HNANJIJBCCO(KDEKOFBPMEA MNFCPILNGAF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x295E2D0", Offset = "0x295CCD0", VA = "0x18295E2D0")]
	[AsyncStateMachine(typeof(FMAENLJBBIA<>))]
	internal Task<T> PIPMCOEJFIE<T>(CancellationToken NEGOEBJOBPE, Func<CancellationToken, Task<T>> PKKHAAJNNCI, int HNDPFDLBEBB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6F74AF0", Offset = "0x6F734F0", VA = "0x186F74AF0")]
	[AsyncStateMachine(typeof(AIDJCELNFMC))]
	internal Task PIPMCOEJFIE(CancellationToken NEGOEBJOBPE, Func<CancellationToken, Task> PKKHAAJNNCI, int HNDPFDLBEBB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6F740C0", Offset = "0x6F72AC0", VA = "0x186F740C0")]
	public MIDPGEHLBFM EHMGNLOKDON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x6F74910", Offset = "0x6F73310", VA = "0x186F74910")]
	public BIPLNLIDMKJ OHCJIIAMOJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x6F73CD0", Offset = "0x6F726D0", VA = "0x186F73CD0")]
	public JHOLNGLHEOK AICCECAPFFJ([Optional] LGKLDLNGEGN? DHOGKNDCDMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x6F74990", Offset = "0x6F73390", VA = "0x186F74990")]
	public void OHMIBIEGIEE(Func<Guid, bool> EHKCPICHIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x6F74800", Offset = "0x6F73200", VA = "0x186F74800")]
	public void MIHKCDNCGGA(Func<Guid, bool> ILGKDMKHBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6F74140", Offset = "0x6F72B40", VA = "0x186F74140")]
	public Guid FLKEBDEABIO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6F74C20", Offset = "0x6F73620", VA = "0x186F74C20")]
	public void PNLPDHFEKEL(Guid GEKHKDLFMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6F74400", Offset = "0x6F72E00", VA = "0x186F74400")]
	public void JDCPHFNEKMN(KDEKOFBPMEA AKCFODHHCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x6F746F0", Offset = "0x6F730F0", VA = "0x186F746F0")]
	public void MDBGGDKNGAC(string FICFHAOOGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x295DF40", Offset = "0x295C940", VA = "0x18295DF40")]
	private T IMOHJHDGMFC<T>(T DBOBEHLEAAE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6F74540", Offset = "0x6F72F40", VA = "0x186F74540")]
	public void JDMENCJPJEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x295E020", Offset = "0x295CA20", VA = "0x18295E020")]
	[CompilerGenerated]
	internal static string KDDDNDHAFBB<T>(byte[] KKELJOOMKNM, int CEBCLCHGCPJ, FDCAKLGKOLH<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal sealed class GGPBKELMLME : PBCHFFOPJGA
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class CDOMOKKJHAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public CDOMOKKJHAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8F950", Offset = "0x6F8E350", VA = "0x186F8F950")]
		internal object DBFCLFEJFAB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct LPIILJGHIIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public GGPBKELMLME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public DCDGPMPFNEE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private PHMNLMEJCDN <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private BIPLNLIDMKJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9CFB0", Offset = "0x6F9B9B0", VA = "0x186F9CFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6F9D880", Offset = "0x6F9C280", VA = "0x186F9D880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct APOLDIIBPEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public GGPBKELMLME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private TaskAwaiter<LGDDBNGBFNG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8BA60", Offset = "0x6F8A460", VA = "0x186F8BA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C1F0", Offset = "0x6F8ABF0", VA = "0x186F8C1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct IIBBBIBPFMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public GGPBKELMLME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private TaskAwaiter<BCDAPHNNAIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6F98230", Offset = "0x6F96C30", VA = "0x186F98230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x6F98540", Offset = "0x6F96F40", VA = "0x186F98540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class MNLPBAFOFFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public PHMNLMEJCDN presence;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public MNLPBAFOFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6F9D950", Offset = "0x6F9C350", VA = "0x186F9D950")]
		internal object JLEPGOFOIAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private static readonly LGKLDLNGEGN CIEDFMCFHNP;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private static readonly LGKLDLNGEGN CLIBOIMOBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private readonly CCPGLNKCEAO AKPFFLGJICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly MDCEFFOBCGJ CKEPHLLFMFD;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6F94DE0", Offset = "0x6F937E0", VA = "0x186F94DE0")]
	public GGPBKELMLME(CCPGLNKCEAO AKPFFLGJICF, MDCEFFOBCGJ CKEPHLLFMFD, Guid ANGIPKEDDGP, DPFMBDJKAOB GFAOFFCNKEI, KJCKCCPLGMI EFKDNOOMPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6F94BC0", Offset = "0x6F935C0", VA = "0x186F94BC0", Slot = "7")]
	[AsyncStateMachine(typeof(LPIILJGHIIK))]
	protected override Task ONIFCHLONHP(DCDGPMPFNEE ODBPLIAIBOF, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6F949B0", Offset = "0x6F933B0", VA = "0x186F949B0")]
	[AsyncStateMachine(typeof(APOLDIIBPEL))]
	private Task OBJBFLDPCDG(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6F94AB0", Offset = "0x6F934B0", VA = "0x186F94AB0")]
	[AsyncStateMachine(typeof(IIBBBIBPFMM))]
	private Task<byte> OCGOJPFCKIO(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6F947E0", Offset = "0x6F931E0", VA = "0x186F947E0")]
	private PHMNLMEJCDN DMNIDIPGOPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class BKDMOFOGOPF : PBCHFFOPJGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct CNAHGHMMDDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public BKDMOFOGOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public DCDGPMPFNEE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private TaskAwaiter<HCBBPJCCCOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6F907C0", Offset = "0x6F8F1C0", VA = "0x186F907C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6F91130", Offset = "0x6F8FB30", VA = "0x186F91130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private readonly int FGHIOCMKOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private readonly OPHHGBFNKCM CFEFPIPMPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public readonly long DCFNFBLKKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public readonly long JFEECDDHDEF;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public HCBBPJCCCOC AEPBGMNPFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x855180", Offset = "0x853B80", VA = "0x180855180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x855040", Offset = "0x853A40", VA = "0x180855040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E9F0", Offset = "0x6F8D3F0", VA = "0x186F8E9F0")]
	public BKDMOFOGOPF(Guid ANGIPKEDDGP, DPFMBDJKAOB GFAOFFCNKEI, KJCKCCPLGMI EFKDNOOMPJC, int FGHIOCMKOCE, OPHHGBFNKCM CFEFPIPMPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E8D0", Offset = "0x6F8D2D0", VA = "0x186F8E8D0", Slot = "7")]
	[AsyncStateMachine(typeof(CNAHGHMMDDH))]
	protected override Task ONIFCHLONHP(DCDGPMPFNEE ODBPLIAIBOF, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal abstract class NFMJJBBOLLH : PBCHFFOPJGA
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class NKGHHCDGPLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public NFMJJBBOLLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public ODANEGNLBME playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public NKGHHCDGPLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EE90", Offset = "0x6F9D890", VA = "0x186F9EE90")]
		internal Task CMEJHMBLLHH(MIJAEHJIGEB<string>.OBFKFOAMCEP postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EED0", Offset = "0x6F9D8D0", VA = "0x186F9EED0")]
		internal object KHJMOLMNFLN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct HFNELLFIAGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public NFMJJBBOLLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public DCDGPMPFNEE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private NKGHHCDGPLP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x6F97590", Offset = "0x6F95F90", VA = "0x186F97590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x6F97D50", Offset = "0x6F96750", VA = "0x186F97D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct OIDIGOEADJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public ODANEGNLBME playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public NFMJJBBOLLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EF60", Offset = "0x6F9D960", VA = "0x186F9EF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F4F0", Offset = "0x6F9DEF0", VA = "0x186F9F4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E830", Offset = "0x6F9D230", VA = "0x186F9E830")]
	public NFMJJBBOLLH(Guid ANGIPKEDDGP, DPFMBDJKAOB GFAOFFCNKEI, KJCKCCPLGMI EFKDNOOMPJC, string KFCBGBLLADI, MHJFPILMNPL KFHICACKEFH, bool FGDFPAPINBJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E5B0", Offset = "0x6F9CFB0", VA = "0x186F9E5B0", Slot = "7")]
	[AsyncStateMachine(typeof(HFNELLFIAGE))]
	protected override Task ONIFCHLONHP(DCDGPMPFNEE ODBPLIAIBOF, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task EBIHBPMAKHD(DCDGPMPFNEE ODBPLIAIBOF, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E6F0", Offset = "0x6F9D0F0", VA = "0x186F9E6F0")]
	[AsyncStateMachine(typeof(OIDIGOEADJI))]
	private Task POPJLNKKKFJ(IDisposable IKBFENCAFKK, ODANEGNLBME JFMNOLDGLBB, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class HOIGEKDGHOI : PBCHFFOPJGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct EIGMPPJDNFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public HOIGEKDGHOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public DCDGPMPFNEE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private TaskAwaiter<POAAKMMADBH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6F921B0", Offset = "0x6F90BB0", VA = "0x186F921B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x6F92710", Offset = "0x6F91110", VA = "0x186F92710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	private readonly MFIOOOIMKCN JHBPEHBAAIE;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6F98190", Offset = "0x6F96B90", VA = "0x186F98190")]
	public HOIGEKDGHOI(Guid ANGIPKEDDGP, DPFMBDJKAOB GFAOFFCNKEI, KJCKCCPLGMI EFKDNOOMPJC, MFIOOOIMKCN JHBPEHBAAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x6F97F90", Offset = "0x6F96990", VA = "0x186F97F90", Slot = "6")]
	protected override string HMOLCMEAHME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6F98070", Offset = "0x6F96A70", VA = "0x186F98070", Slot = "7")]
	[AsyncStateMachine(typeof(EIGMPPJDNFK))]
	protected override Task ONIFCHLONHP(DCDGPMPFNEE ODBPLIAIBOF, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal abstract class PBCHFFOPJGA : KPJJDLENIAC
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public delegate Task BFBOLHNHABM(MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class FNKGFNFBKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public PBCHFFOPJGA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public FNKGFNFBKBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F946B0", Offset = "0x6F930B0", VA = "0x186F946B0")]
		internal Task LPDNBFCBBFP(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class HMPANNDBJME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public FNKGFNFBKBI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public HMPANNDBJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F97DB0", Offset = "0x6F967B0", VA = "0x186F97DB0")]
		internal object CLHOKBJDNCM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct FDLMAJJKBNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public PBCHFFOPJGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public Func<PBCHFFOPJGA, MIJAEHJIGEB<string>.OBFKFOAMCEP, DCDGPMPFNEE> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private FNKGFNFBKBI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private DCDGPMPFNEE <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private TaskAwaiter<KDEKOFBPMEA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F92D50", Offset = "0x6F91750", VA = "0x186F92D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F93E50", Offset = "0x6F92850", VA = "0x186F93E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct LCDCGLHHMHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B920", Offset = "0x6F9A320", VA = "0x186F9B920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C3B0", Offset = "0x6F9ADB0", VA = "0x186F9C3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct CAKKBEMECEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public PBCHFFOPJGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB20", Offset = "0x6F8D520", VA = "0x186F8EB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EE80", Offset = "0x6F8D880", VA = "0x186F8EE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public readonly Guid HCPELCNJBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public readonly ByteString NLHMDKLPMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public readonly KJCKCCPLGMI GEKCPNLFLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	protected readonly string EKNPJEKFCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	private readonly DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	private readonly bool FGDFPAPINBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	private readonly Queue<BFBOLHNHABM> HDCDKOPAEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	private readonly EDKILIBKIOP HOGPCAJJCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private readonly MHJFPILMNPL KFHICACKEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private bool BHPFEFFMIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public EAODDEEJJHO GFPEINCKPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public EAODDEEJJHO OGHHDJDFGFL;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public DPFMBDJKAOB NEMIAKLILLB
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public OKJDCNBIHPD NCEODIICHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0A00", Offset = "0x6F9F400", VA = "0x186FA0A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public GLPEGFIAGPD LBIPKIKGCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0500", Offset = "0x6F9EF00", VA = "0x186FA0500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public AELMJKLMOFJ DEOLIAGACBC
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0DA0", Offset = "0x6F9F7A0", VA = "0x186FA0DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event OOJBEOCHJEB MKDIFLHMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0AF0", Offset = "0x6F9F4F0", VA = "0x186FA0AF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA09E0", Offset = "0x6F9F3E0", VA = "0x186FA09E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FA0F30", Offset = "0x6F9F930", VA = "0x186FA0F30")]
	protected PBCHFFOPJGA(Guid ANGIPKEDDGP, DPFMBDJKAOB GFAOFFCNKEI, KJCKCCPLGMI EFKDNOOMPJC, string KFCBGBLLADI, MHJFPILMNPL KFHICACKEFH, bool FGDFPAPINBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FA0AB0", Offset = "0x6F9F4B0", VA = "0x186FA0AB0", Slot = "6")]
	protected virtual string HMOLCMEAHME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FA0A50", Offset = "0x6F9F450", VA = "0x186FA0A50")]
	public void HJEPPCBFJNP(BFBOLHNHABM MBMICMKEMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x6FA0940", Offset = "0x6F9F340", VA = "0x186FA0940")]
	protected void EFFOKKHOIKF(float HINJMLAPBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x6FA0640", Offset = "0x6F9F040", VA = "0x186FA0640")]
	[AsyncStateMachine(typeof(FDLMAJJKBNC))]
	public Task AJIENLNABLE(CancellationToken AOLOJHLCMLE, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, [Optional] Func<PBCHFFOPJGA, MIJAEHJIGEB<string>.OBFKFOAMCEP, DCDGPMPFNEE> CKPJEDOLBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FA0810", Offset = "0x6F9F210", VA = "0x186FA0810")]
	[AsyncStateMachine(typeof(LCDCGLHHMHN))]
	private static Task DOEPBJLNDDG(Func<CancellationToken, Task> BJPBDCPKHHO, Func<CancellationToken, Task> NEMLJLEEAFF, CancellationToken NEGOEBJOBPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FA0B10", Offset = "0x6F9F510", VA = "0x186FA0B10")]
	private void IHDHMKGAJGM(bool FBPJJEBDJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FA0E20", Offset = "0x6F9F820", VA = "0x186FA0E20")]
	private void NGDJMDBPPJI(DCDGPMPFNEE ODBPLIAIBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task ONIFCHLONHP(DCDGPMPFNEE ODBPLIAIBOF, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FA0C80", Offset = "0x6F9F680", VA = "0x186FA0C80")]
	[AsyncStateMachine(typeof(CAKKBEMECEG))]
	private Task IIEDBDOOKGK(MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FA0790", Offset = "0x6F9F190", VA = "0x186FA0790")]
	public KDEKOFBPMEA DJOICPOGLFL(GBKPFEMBBMK PEEIKPPIBCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FA0550", Offset = "0x6F9EF50", VA = "0x186FA0550")]
	[CompilerGenerated]
	private Task ABLHCECAFPA(CancellationToken FOCADABILLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FA0960", Offset = "0x6F9F360", VA = "0x186FA0960")]
	[CompilerGenerated]
	private object ELFCLELOOEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal sealed class DAOGMIHGHGJ : NFMJJBBOLLH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct BGCNHBKNDLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public DAOGMIHGHGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public DCDGPMPFNEE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private MABPGBIBHNO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private BIPLNLIDMKJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C3A0", Offset = "0x6F8ADA0", VA = "0x186F8C3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CB10", Offset = "0x6F8B510", VA = "0x186F8CB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	private readonly CCPGLNKCEAO EEGPJANLNEF;

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F913E0", Offset = "0x6F8FDE0", VA = "0x186F913E0")]
	public DAOGMIHGHGJ(Guid ANGIPKEDDGP, DPFMBDJKAOB GFAOFFCNKEI, CCPGLNKCEAO EEGPJANLNEF, KJCKCCPLGMI EFKDNOOMPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F91290", Offset = "0x6F8FC90", VA = "0x186F91290", Slot = "8")]
	[AsyncStateMachine(typeof(BGCNHBKNDLA))]
	protected override Task EBIHBPMAKHD(DCDGPMPFNEE ODBPLIAIBOF, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class EHGIHIDKNJE : PBCHFFOPJGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct CEFNGDMKIAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public EHGIHIDKNJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public DCDGPMPFNEE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private TaskAwaiter<POAAKMMADBH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F8F9C0", Offset = "0x6F8E3C0", VA = "0x186F8F9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FD70", Offset = "0x6F8E770", VA = "0x186F8FD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private readonly string PJBGEHLIKJO;

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F92100", Offset = "0x6F90B00", VA = "0x186F92100")]
	public EHGIHIDKNJE(Guid ANGIPKEDDGP, DPFMBDJKAOB GFAOFFCNKEI, KJCKCCPLGMI EFKDNOOMPJC, string PJBGEHLIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F91FF0", Offset = "0x6F909F0", VA = "0x186F91FF0", Slot = "7")]
	[AsyncStateMachine(typeof(CEFNGDMKIAI))]
	protected override Task ONIFCHLONHP(DCDGPMPFNEE ODBPLIAIBOF, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class JDBHJAHAAPE : NFMJJBBOLLH
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class PLGFMGPBEGF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000114")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public AsyncTaskMethodBuilder<KDEKOFBPMEA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public PLGFMGPBEGF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			private TaskAwaiter<POAAKMMADBH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			private TaskAwaiter<KDEKOFBPMEA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x6FA37F0", Offset = "0x6FA21F0", VA = "0x186FA37F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x6FA3CB0", Offset = "0x6FA26B0", VA = "0x186FA3CB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public JDBHJAHAAPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public JHOLNGLHEOK serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public AHFCPDKCLOG roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public MIDPGEHLBFM uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public BALIOMLHDAA roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public PLGFMGPBEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x6FA13D0", Offset = "0x6F9FDD0", VA = "0x186FA13D0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<KDEKOFBPMEA> JDDKKMCOJKF(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct OKJKAFNIJBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public JDBHJAHAAPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public DCDGPMPFNEE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private PLGFMGPBEGF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private MABPGBIBHNO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private BIPLNLIDMKJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private KDEKOFBPMEA <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private TaskAwaiter<KDEKOFBPMEA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F550", Offset = "0x6F9DF50", VA = "0x186F9F550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FA04A0", Offset = "0x6F9EEA0", VA = "0x186FA04A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	private static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	private static readonly LGKLDLNGEGN CIEDFMCFHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	private readonly int FOBGMHODFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	[CanBeNull]
	private readonly DLCPLGMDJEG CGDEKJPLMLA;

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F98A70", Offset = "0x6F97470", VA = "0x186F98A70")]
	public JDBHJAHAAPE(Guid ANGIPKEDDGP, DPFMBDJKAOB GFAOFFCNKEI, int FOBGMHODFPK, DLCPLGMDJEG CGDEKJPLMLA, KJCKCCPLGMI EFKDNOOMPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F985B0", Offset = "0x6F96FB0", VA = "0x186F985B0", Slot = "8")]
	[AsyncStateMachine(typeof(OKJKAFNIJBF))]
	protected override Task EBIHBPMAKHD(DCDGPMPFNEE ODBPLIAIBOF, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F986F0", Offset = "0x6F970F0", VA = "0x186F986F0")]
	private void FCEBHGDDFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F987F0", Offset = "0x6F971F0", VA = "0x186F987F0")]
	private void OMHBMHIFFLA(MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, MABPGBIBHNO FMGABMMAANN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal abstract class KKOPKDOBFJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly PBCHFFOPJGA AMGDAMGLDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly DCDGPMPFNEE CIIHBKFGOBA;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public OKJDCNBIHPD NCEODIICHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A690", Offset = "0x6F99090", VA = "0x186F9A690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public AELMJKLMOFJ DEOLIAGACBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A6E0", Offset = "0x6F990E0", VA = "0x186F9A6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A790", Offset = "0x6F99190", VA = "0x186F9A790")]
	protected KKOPKDOBFJO(DCDGPMPFNEE ODBPLIAIBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A770", Offset = "0x6F99170", VA = "0x186F9A770")]
	protected void MDBGGDKNGAC(string FICFHAOOGHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct NIJMMGHIJLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public Dictionary<Guid, List<OLMPMOBPCPN>> KPEDMCGPLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public Dictionary<Guid, List<OLMPMOBPCPN>> PIEMIAINPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public Dictionary<Guid, List<OLMPMOBPCPN>> PKEAMANFKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public List<Guid> PHLBBOEADJC;

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E880", Offset = "0x6F9D280", VA = "0x186F9E880")]
	public static NIJMMGHIJLB AMGKFNFCLFC(OKJDCNBIHPD GLFIGPDLPBG, EAODDEEJJHO BKIONIDGPCE, FNGILHDDEFI FEJCFBMDEGJ)
	{
		return default(NIJMMGHIJLB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct LDGCLNEBBGC
{
	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60")]
	public static LDGCLNEBBGC CBNOJCEAKCL()
	{
		return default(LDGCLNEBBGC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct EMENIOKJNLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public readonly LGDDBNGBFNG FCOGIFPLFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public readonly PPOBPODJIIJ EONIEPBDNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public readonly string NCFBDPGOPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public readonly DINCFJKGGOK BGFCCPEMGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public readonly DINCFJKGGOK GLEONALLPGG;

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F92CD0", Offset = "0x6F916D0", VA = "0x186F92CD0")]
	public EMENIOKJNLD(LGDDBNGBFNG FCOGIFPLFKG, PPOBPODJIIJ EONIEPBDNKO, string NCFBDPGOPGE, DINCFJKGGOK BGFCCPEMGBP, DINCFJKGGOK GLEONALLPGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct LBAGOOEIHOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly DCDGPMPFNEE ODBPLIAIBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly Guid GEKHKDLFMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private bool FBPJJEBDJKF;

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A8F0", Offset = "0x6F992F0", VA = "0x186F9A8F0")]
	public static LBAGOOEIHOI FLKEBDEABIO(DCDGPMPFNEE ODBPLIAIBOF)
	{
		return default(LBAGOOEIHOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x9830B0", Offset = "0x981AB0", VA = "0x1809830B0")]
	public void ELGEINFPKDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A890", Offset = "0x6F99290", VA = "0x186F9A890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A950", Offset = "0x6F99350", VA = "0x186F9A950")]
	private LBAGOOEIHOI(DCDGPMPFNEE ODBPLIAIBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A890", Offset = "0x6F99290", VA = "0x186F9A890")]
	private void PNLPDHFEKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A7F0", Offset = "0x6F991F0", VA = "0x186F9A7F0")]
	private Func<Guid, bool> CPFGBKEDPBF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class BIPLNLIDMKJ : KKOPKDOBFJO, KPJJDLENIAC
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public delegate Task<EAODDEEJJHO> CNLDPBBKCMN(FNGILHDDEFI EEOBDBMOHPL, EKDFHPJHEMC NJLGHIEGFMG, EDKILIBKIOP ABIMAOKJBED, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct JIDBMOGBABF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public CCPGLNKCEAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private LBAGOOEIHOI <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter<KDEKOFBPMEA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x6F99AA0", Offset = "0x6F984A0", VA = "0x186F99AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A210", Offset = "0x6F98C10", VA = "0x186F9A210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct CLJKOHPGOJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public AsyncTaskMethodBuilder<KDEKOFBPMEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public CCPGLNKCEAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private TaskAwaiter<KDEKOFBPMEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x6F90340", Offset = "0x6F8ED40", VA = "0x186F90340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x6F90750", Offset = "0x6F8F150", VA = "0x186F90750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct CDHPHKDIHGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public CCPGLNKCEAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x6F8F460", Offset = "0x6F8DE60", VA = "0x186F8F460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x6F8F8F0", Offset = "0x6F8E2F0", VA = "0x186F8F8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class EKBCNMCLKFE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public AsyncTaskMethodBuilder<EMENIOKJNLD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public EKBCNMCLKFE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			private EMENIOKJNLD <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			private TaskAwaiter<EAODDEEJJHO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<EMENIOKJNLD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0x6FA22A0", Offset = "0x6FA0CA0", VA = "0x186FA22A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x6FA2A30", Offset = "0x6FA1430", VA = "0x186FA2A30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public AsyncTaskMethodBuilder<FNGILHDDEFI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public EKBCNMCLKFE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			private FNGILHDDEFI <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			private TaskAwaiter<EAODDEEJJHO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private TaskAwaiter<FNGILHDDEFI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x6FA2AA0", Offset = "0x6FA14A0", VA = "0x186FA2AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x6FA30F0", Offset = "0x6FA1AF0", VA = "0x186FA30F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public CCPGLNKCEAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public EDKILIBKIOP preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public EDKILIBKIOP downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public EMENIOKJNLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public EDKILIBKIOP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public FNGILHDDEFI phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public NOJOBLOGLJC.NDKLKBMOBEN <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public EKBCNMCLKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6F92B50", Offset = "0x6F91550", VA = "0x186F92B50")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<EMENIOKJNLD> KHBPOEOMJBB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6F92A30", Offset = "0x6F91430", VA = "0x186F92A30")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<FNGILHDDEFI> HFNGEGALNMG(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6F92C90", Offset = "0x6F91690", VA = "0x186F92C90")]
		internal void PKINGGMHGEO(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x6F92770", Offset = "0x6F91170", VA = "0x186F92770")]
		internal Task CCLPKJKBJKE(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6F928D0", Offset = "0x6F912D0", VA = "0x186F928D0")]
		internal Task CDLLNJCKJLG(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct PNIFCHHPBGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public CCPGLNKCEAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private EKBCNMCLKFE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter<EMENIOKJNLD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private TaskAwaiter<FNGILHDDEFI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x6FA14F0", Offset = "0x6F9FEF0", VA = "0x186FA14F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2240", Offset = "0x6FA0C40", VA = "0x186FA2240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct LCAMIDMEECF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public FNGILHDDEFI phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public EDKILIBKIOP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private TaskAwaiter<EAODDEEJJHO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private EKDFHPJHEMC <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A9A0", Offset = "0x6F993A0", VA = "0x186F9A9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B8C0", Offset = "0x6F9A2C0", VA = "0x186F9B8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct EDNPCPBHNOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x6F916E0", Offset = "0x6F900E0", VA = "0x186F916E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x6F91F90", Offset = "0x6F90990", VA = "0x186F91F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct NFALPLDOCGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public EDKILIBKIOP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter<EAODDEEJJHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9DBD0", Offset = "0x6F9C5D0", VA = "0x186F9DBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9E550", Offset = "0x6F9CF50", VA = "0x186F9E550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct HDBEBCGDKKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public AsyncTaskMethodBuilder<EAODDEEJJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public EDKILIBKIOP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private TaskAwaiter<EAODDEEJJHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x6F95220", Offset = "0x6F93C20", VA = "0x186F95220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x6F961F0", Offset = "0x6F94BF0", VA = "0x186F961F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct HDNANKJCCJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public AsyncTaskMethodBuilder<EAODDEEJJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public EDKILIBKIOP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public EKDFHPJHEMC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private TaskAwaiter<EAODDEEJJHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x6F96260", Offset = "0x6F94C60", VA = "0x186F96260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6F97520", Offset = "0x6F95F20", VA = "0x186F97520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct KBHCKJCJNKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public AsyncTaskMethodBuilder<EAODDEEJJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public EAODDEEJJHO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public EDKILIBKIOP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public FNGILHDDEFI deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private TaskAwaiter<EAODDEEJJHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A390", Offset = "0x6F98D90", VA = "0x186F9A390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A620", Offset = "0x6F99020", VA = "0x186F9A620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class HNHBDCFLMEI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public AsyncTaskMethodBuilder<EAODDEEJJHO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			public HNHBDCFLMEI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			private NDMGMBJNGAH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			private TaskAwaiter<EAODDEEJJHO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x6FA3160", Offset = "0x6FA1B60", VA = "0x186FA3160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0x6FA3780", Offset = "0x6FA2180", VA = "0x186FA3780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public EDKILIBKIOP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public CNLDPBBKCMN masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public EKDFHPJHEMC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public EAODDEEJJHO originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public HNHBDCFLMEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x6F97E70", Offset = "0x6F96870", VA = "0x186F97E70")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<EAODDEEJJHO> HAHGJCICGPO(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct CIJPNFLFBPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public AsyncTaskMethodBuilder<EAODDEEJJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public EDKILIBKIOP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public CNLDPBBKCMN masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public EKDFHPJHEMC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private TaskAwaiter<EAODDEEJJHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FDD0", Offset = "0x6F8E7D0", VA = "0x186F8FDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x6F902D0", Offset = "0x6F8ECD0", VA = "0x186F902D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct CBJFHCMOJIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public EDKILIBKIOP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private EAODDEEJJHO <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private IEnumerator<EAODDEEJJHO> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private TaskAwaiter<EAODDEEJJHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EEE0", Offset = "0x6F8D8E0", VA = "0x186F8EEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x6F8F400", Offset = "0x6F8DE00", VA = "0x186F8F400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct FEDNGHGIJPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x6F93EB0", Offset = "0x6F928B0", VA = "0x186F93EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x6F940D0", Offset = "0x6F92AD0", VA = "0x186F940D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct HBFKOACGJAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x6F94F70", Offset = "0x6F93970", VA = "0x186F94F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x6F951C0", Offset = "0x6F93BC0", VA = "0x186F951C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct JDCOLNOEEHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public FNGILHDDEFI phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public EDKILIBKIOP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private TaskAwaiter<EAODDEEJJHO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private EKDFHPJHEMC <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x6F98B20", Offset = "0x6F97520", VA = "0x186F98B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x6F99A40", Offset = "0x6F98440", VA = "0x186F99A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct LHPGFNCMHAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public AsyncTaskMethodBuilder<EAODDEEJJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public BIPLNLIDMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public EDKILIBKIOP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private TaskAwaiter<EAODDEEJJHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C410", Offset = "0x6F9AE10", VA = "0x186F9C410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x6F9CF40", Offset = "0x6F9B940", VA = "0x186F9CF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private readonly HFDCBECCBCM NNCNMJNPDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private readonly HFDCBECCBCM LPNDCJJCAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private readonly BDMPGCNODMK NFHDCIEPBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly EFJFPOCGNMJ FOHHAJACPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly PPKMGLEOFAA JOFLNOEJGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private readonly JCGOAOCFLOH EBEGFLGANJM;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private DPFMBDJKAOB NEMIAKLILLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D8D0", Offset = "0x6F8C2D0", VA = "0x186F8D8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event OOJBEOCHJEB MKDIFLHMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D620", Offset = "0x6F8C020", VA = "0x186F8D620", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D2D0", Offset = "0x6F8BCD0", VA = "0x186F8D2D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E630", Offset = "0x6F8D030", VA = "0x186F8E630")]
	public BIPLNLIDMKJ(DCDGPMPFNEE ODBPLIAIBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DBE0", Offset = "0x6F8C5E0", VA = "0x186F8DBE0")]
	[AsyncStateMachine(typeof(JIDBMOGBABF))]
	public Task KJDKGMBBAIG(CCPGLNKCEAO BJLMEIJMPBN, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CEC0", Offset = "0x6F8B8C0", VA = "0x186F8CEC0")]
	[AsyncStateMachine(typeof(CLJKOHPGOJF))]
	private Task<KDEKOFBPMEA> DCGBJCNGDHF(CCPGLNKCEAO BJLMEIJMPBN, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D790", Offset = "0x6F8C190", VA = "0x186F8D790")]
	[AsyncStateMachine(typeof(CDHPHKDIHGH))]
	private Task IENEMILFILO(CCPGLNKCEAO BJLMEIJMPBN, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E400", Offset = "0x6F8CE00", VA = "0x186F8E400")]
	[AsyncStateMachine(typeof(PNIFCHHPBGG))]
	private Task OOIHJJAIDIN(CCPGLNKCEAO BJLMEIJMPBN, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken BKMKMFLBHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D960", Offset = "0x6F8C360", VA = "0x186F8D960")]
	[AsyncStateMachine(typeof(LCAMIDMEECF))]
	private Task JEMKLLKCLIN(FNGILHDDEFI ACPPICPNJBM, EDKILIBKIOP BKCJEJJDGNL, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken JEACFKBLLCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D070", Offset = "0x6F8BA70", VA = "0x186F8D070")]
	[AsyncStateMachine(typeof(EDNPCPBHNOD))]
	private Task DGHDDDIGNMN(MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CB70", Offset = "0x6F8B570", VA = "0x186F8CB70")]
	[AsyncStateMachine(typeof(NFALPLDOCGL))]
	private Task AIEHDDAFKGJ(FNGILHDDEFI EEOBDBMOHPL, EDKILIBKIOP ABIMAOKJBED, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D4C0", Offset = "0x6F8BEC0", VA = "0x186F8D4C0")]
	[AsyncStateMachine(typeof(HDBEBCGDKKK))]
	private Task<EAODDEEJJHO> HHADIGOPMFG(FNGILHDDEFI EEOBDBMOHPL, EKDFHPJHEMC KHBNKCELCME, EDKILIBKIOP ABIMAOKJBED, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DEE0", Offset = "0x6F8C8E0", VA = "0x186F8DEE0")]
	[AsyncStateMachine(typeof(HDNANKJCCJO))]
	private Task<EAODDEEJJHO> MCNPPMMIKKN(FNGILHDDEFI EEOBDBMOHPL, EKDFHPJHEMC KHBNKCELCME, EDKILIBKIOP ABIMAOKJBED, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CD20", Offset = "0x6F8B720", VA = "0x186F8CD20")]
	[AsyncStateMachine(typeof(KBHCKJCJNKE))]
	private Task<EAODDEEJJHO> CHHDGFNNGLP(EAODDEEJJHO BKIONIDGPCE, FNGILHDDEFI FEJCFBMDEGJ, EDKILIBKIOP ABIMAOKJBED, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE, bool LPGANKOMDCF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E310", Offset = "0x6F8CD10", VA = "0x186F8E310")]
	private bool OOAKEABFIPB(FNGILHDDEFI ACPPICPNJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D330", Offset = "0x6F8BD30", VA = "0x186F8D330")]
	[AsyncStateMachine(typeof(CIJPNFLFBPN))]
	protected Task<EAODDEEJJHO> GILGBJGHIAF(FNGILHDDEFI EEOBDBMOHPL, EKDFHPJHEMC KHBNKCELCME, EDKILIBKIOP ABIMAOKJBED, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE, CNLDPBBKCMN CLBPKMDODKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D640", Offset = "0x6F8C040", VA = "0x186F8D640")]
	[AsyncStateMachine(typeof(CBJFHCMOJIF))]
	private Task IBOGLMMEAFM(FNGILHDDEFI EEOBDBMOHPL, EDKILIBKIOP ABIMAOKJBED, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D020", Offset = "0x6F8BA20", VA = "0x186F8D020")]
	private void DEJMLJAFJLO(EAODDEEJJHO HJOBBNKHBOD, EDKILIBKIOP ABIMAOKJBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DD60", Offset = "0x6F8C760", VA = "0x186F8DD60")]
	private void LFDHHOMKNEN(EAODDEEJJHO BPALDEGMGBF, [Out] EAODDEEJJHO ICBFJJHNIKP, [Out] EAODDEEJJHO AHEIOKMCPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D900", Offset = "0x6F8C300", VA = "0x186F8D900")]
	private Task<EMENIOKJNLD> JCMJPAIGGOJ(CCPGLNKCEAO BJLMEIJMPBN, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CCE0", Offset = "0x6F8B6E0", VA = "0x186F8CCE0")]
	private Task<FNGILHDDEFI> BKNFBBNCBNO(EMENIOKJNLD EEOBDBMOHPL, NOJOBLOGLJC.NDKLKBMOBEN BAGEDLMCLDA, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E060", Offset = "0x6F8CA60", VA = "0x186F8E060")]
	[AsyncStateMachine(typeof(FEDNGHGIJPG))]
	private Task NDCDFMEOBGC(FNGILHDDEFI EEOBDBMOHPL, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE, bool IHOAANAOMGN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E540", Offset = "0x6F8CF40", VA = "0x186F8E540")]
	[AsyncStateMachine(typeof(HBFKOACGJAJ))]
	private Task PGEMJDPLEJH(FNGILHDDEFI EEOBDBMOHPL, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DD30", Offset = "0x6F8C730", VA = "0x186F8DD30")]
	private Task KKJBKIJMICN(FNGILHDDEFI EEOBDBMOHPL, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D2F0", Offset = "0x6F8BCF0", VA = "0x186F8D2F0")]
	private Task FONPAICLHCD(FNGILHDDEFI EEOBDBMOHPL, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D940", Offset = "0x6F8C340", VA = "0x186F8D940")]
	private Task JDENCHOPIDG(FNGILHDDEFI EEOBDBMOHPL, EKDFHPJHEMC KHBNKCELCME, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CCC0", Offset = "0x6F8B6C0", VA = "0x186F8CCC0")]
	private Task BFPFLJNNKIE(FNGILHDDEFI EEOBDBMOHPL, EKDFHPJHEMC KHBNKCELCME, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DB00", Offset = "0x6F8C500", VA = "0x186F8DB00")]
	private static Task KHOFCIJCBFJ(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D310", Offset = "0x6F8BD10", VA = "0x186F8D310")]
	private Task GGHFEDAOGOP(FNGILHDDEFI EEOBDBMOHPL, EKDFHPJHEMC KHBNKCELCME, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DDA0", Offset = "0x6F8C7A0", VA = "0x186F8DDA0")]
	private Task LOHMPEEFFLG(FNGILHDDEFI EEOBDBMOHPL, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DAB0", Offset = "0x6F8C4B0", VA = "0x186F8DAB0")]
	private void KHACDFCPDAP(CCPGLNKCEAO BJLMEIJMPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CEA0", Offset = "0x6F8B8A0", VA = "0x186F8CEA0")]
	public void CKEGNGJLJKJ(long MAKJFMMHJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void APKAGFACOJI(LGDDBNGBFNG FCOGIFPLFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D180", Offset = "0x6F8BB80", VA = "0x186F8D180")]
	[AsyncStateMachine(typeof(JDCOLNOEEHC))]
	private Task DPFDFEDNLIO(FNGILHDDEFI ACPPICPNJBM, EDKILIBKIOP BKCJEJJDGNL, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken JEACFKBLLCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E1B0", Offset = "0x6F8CBB0", VA = "0x186F8E1B0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(LHPGFNCMHAB))]
	private Task<EAODDEEJJHO> NOILCPFKEOO(FNGILHDDEFI EEOBDBMOHPL, EKDFHPJHEMC KHBNKCELCME, EDKILIBKIOP ABIMAOKJBED, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct PFPKKHLPACH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	private DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private FNGILHDDEFI EEOBDBMOHPL;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private OKJDCNBIHPD NCEODIICHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1380", Offset = "0x6F9FD80", VA = "0x186FA1380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6FA12A0", Offset = "0x6F9FCA0", VA = "0x186FA12A0")]
	public static Task AJIENLNABLE(DPFMBDJKAOB GFAOFFCNKEI, FNGILHDDEFI EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x6FA1090", Offset = "0x6F9FA90", VA = "0x186FA1090")]
	private void AJIENLNABLE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct KGMKNEMNBLD
{
	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DB00", Offset = "0x6F8C500", VA = "0x186F8DB00")]
	public static Task AJIENLNABLE(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct MNOFHBAJJLO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct FGNJOPOMAIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public DCDGPMPFNEE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6F94130", Offset = "0x6F92B30", VA = "0x186F94130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6F94650", Offset = "0x6F93050", VA = "0x186F94650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DA90", Offset = "0x6F9C490", VA = "0x186F9DA90")]
	[AsyncStateMachine(typeof(FGNJOPOMAIE))]
	public static Task AJIENLNABLE(DCDGPMPFNEE ODBPLIAIBOF, FNGILHDDEFI EEOBDBMOHPL, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct GADLAIKMLOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct EFHLMCABDLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public DCDGPMPFNEE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public EKDFHPJHEMC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private EAODDEEJJHO <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private DPFMBDJKAOB <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private OKJDCNBIHPD <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private NDMGMBJNGAH <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private List<(PersistenceView, APDBPBGHHNA)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private APDBPBGHHNA <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA64A0", Offset = "0x6FA4EA0", VA = "0x186FA64A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7120", Offset = "0x6FA5B20", VA = "0x186FA7120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x6FABC00", Offset = "0x6FAA600", VA = "0x186FABC00")]
	[AsyncStateMachine(typeof(EFHLMCABDLF))]
	public static Task AJIENLNABLE(DCDGPMPFNEE ODBPLIAIBOF, FNGILHDDEFI EEOBDBMOHPL, EKDFHPJHEMC KHBNKCELCME, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x6FABD50", Offset = "0x6FAA750", VA = "0x186FABD50")]
	private static void JOKBPBOCGGE(PersistenceView BIAEPGIEGAH, APDBPBGHHNA HDCEGHKDECL, FNGILHDDEFI EEOBDBMOHPL, EAODDEEJJHO BKIONIDGPCE, bool BIBMDHOPGNL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct LDMFIGGBMCB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct BOLCCABBGPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public DPFMBDJKAOB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4EC0", Offset = "0x6FA38C0", VA = "0x186FA4EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x6FA52F0", Offset = "0x6FA3CF0", VA = "0x186FA52F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5010", Offset = "0x6FB3A10", VA = "0x186FB5010")]
	[AsyncStateMachine(typeof(BOLCCABBGPK))]
	public static Task AJIENLNABLE(DPFMBDJKAOB GFAOFFCNKEI, FNGILHDDEFI EEOBDBMOHPL, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct HNDPLALHIOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct GJHAAIJNJGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public DPFMBDJKAOB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public DCDGPMPFNEE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC680", Offset = "0x6FAB080", VA = "0x186FAC680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC890", Offset = "0x6FAB290", VA = "0x186FAC890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class MBJLNGHCIHK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			public MBJLNGHCIHK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x6FBD1A0", Offset = "0x6FBBBA0", VA = "0x186FBD1A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x6FBD530", Offset = "0x6FBBF30", VA = "0x186FBD530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public MBJLNGHCIHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6B70", Offset = "0x6FB5570", VA = "0x186FB6B70")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task LDJCKHEGHCN(MIJAEHJIGEB<string>.OBFKFOAMCEP timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct NCIFBJLBONK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public HNDPLALHIOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private TaskAwaiter<KDEKOFBPMEA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x6FB80F0", Offset = "0x6FB6AF0", VA = "0x186FB80F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8AB0", Offset = "0x6FB74B0", VA = "0x186FB8AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class PGGGEAEGMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public JBNFDDCMJOC version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public PGGGEAEGMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBC90", Offset = "0x6FBA690", VA = "0x186FBBC90")]
		internal object HMGGGLFLCNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBBE0", Offset = "0x6FBA5E0", VA = "0x186FBBBE0")]
		internal object ELLAPOBNAKN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	private FNGILHDDEFI EEOBDBMOHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private DCDGPMPFNEE ODBPLIAIBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	private bool IHOAANAOMGN;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private static readonly ByteString JPDAHGPBGAE;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private OKJDCNBIHPD NCEODIICHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF770", Offset = "0x6FAE170", VA = "0x186FAF770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private AELMJKLMOFJ DEOLIAGACBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF7C0", Offset = "0x6FAE1C0", VA = "0x186FAF7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF4A0", Offset = "0x6FADEA0", VA = "0x186FAF4A0")]
	[AsyncStateMachine(typeof(GJHAAIJNJGA))]
	public static Task AJIENLNABLE(DPFMBDJKAOB GFAOFFCNKEI, FNGILHDDEFI EEOBDBMOHPL, DCDGPMPFNEE ODBPLIAIBOF, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE, bool IHOAANAOMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF5F0", Offset = "0x6FADFF0", VA = "0x186FAF5F0")]
	[AsyncStateMachine(typeof(NCIFBJLBONK))]
	private Task AJIENLNABLE(MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEE10", Offset = "0x6FAD810", VA = "0x186FAEE10")]
	private void AALIJGCDAKA([NotNull] HOHHBPKCDBA IPPIJJOEADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF730", Offset = "0x6FAE130", VA = "0x186FAF730")]
	private bool BNDOAAFPBKO(JBNFDDCMJOC OKMBFDMPMHM, HOHHBPKCDBA IPPIJJOEADH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct JMJAJOIHIMD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct PFLDFFEFLAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public AsyncTaskMethodBuilder<FNGILHDDEFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public JMJAJOIHIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public NOJOBLOGLJC.NDKLKBMOBEN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private TaskAwaiter<(FNBKHJCMJJM<DNPODLDDAAK, DNHFHLFKGGH>, FNBKHJCMJJM<FOAIIODBMAA<HOHHBPKCDBA>, DNHFHLFKGGH>, FNBKHJCMJJM<FOAIIODBMAA<FLIADCLBMOC>, DNHFHLFKGGH>, FNBKHJCMJJM<FOAIIODBMAA<ABGOPOHKIII>, DNHFHLFKGGH>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB0C0", Offset = "0x6FB9AC0", VA = "0x186FBB0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBB70", Offset = "0x6FBA570", VA = "0x186FBBB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct LFAKAALMPPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<DNPODLDDAAK, DNHFHLFKGGH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public JMJAJOIHIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public NOJOBLOGLJC.NDKLKBMOBEN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private TaskAwaiter<FNBKHJCMJJM<DNPODLDDAAK, DNHFHLFKGGH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5120", Offset = "0x6FB3B20", VA = "0x186FB5120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5730", Offset = "0x6FB4130", VA = "0x186FB5730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private LHAOKGDJLCH<DINCFJKGGOK, FLIADCLBMOC> LEMIAOBFKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private LHAOKGDJLCH<DINCFJKGGOK, HOHHBPKCDBA> EOABNCHMFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private LHAOKGDJLCH<long, ABGOPOHKIII> KMFLEBGLLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private IBINFMOPLLH LPPHGAMBDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private LGDDBNGBFNG FCOGIFPLFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private PPOBPODJIIJ EONIEPBDNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private string NCFBDPGOPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private DINCFJKGGOK BGFCCPEMGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private DINCFJKGGOK GLEONALLPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private long MAKJFMMHJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD;

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1DB0", Offset = "0x6FB07B0", VA = "0x186FB1DB0")]
	public static Task<FNGILHDDEFI> LGAPNONEBFK(DPFMBDJKAOB GFAOFFCNKEI, [In] EMENIOKJNLD EEOBDBMOHPL, NOJOBLOGLJC.NDKLKBMOBEN BAGEDLMCLDA, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1A60", Offset = "0x6FB0460", VA = "0x186FB1A60")]
	[AsyncStateMachine(typeof(PFLDFFEFLAN))]
	private Task<FNGILHDDEFI> AJIENLNABLE(NOJOBLOGLJC.NDKLKBMOBEN BAGEDLMCLDA, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1BF0", Offset = "0x6FB05F0", VA = "0x186FB1BF0")]
	[AsyncStateMachine(typeof(LFAKAALMPPG))]
	private Task<FNBKHJCMJJM<DNPODLDDAAK, DNHFHLFKGGH>> CLMJKADDNAN(string NCFBDPGOPGE, long MAKJFMMHJCI, long? ONILLAPMLEN, long? EMDKAGDEANA, NOJOBLOGLJC.NDKLKBMOBEN BAGEDLMCLDA, MIJAEHJIGEB<string>.OBFKFOAMCEP LPDJDNKKDJB, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct FGOCALDHFKD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct FECOGJBBICN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public AsyncTaskMethodBuilder<EMENIOKJNLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public FGOCALDHFKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private TaskAwaiter<EMENIOKJNLD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9400", Offset = "0x6FA7E00", VA = "0x186FA9400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9800", Offset = "0x6FA8200", VA = "0x186FA9800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct IFJAAFHNBKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public AsyncTaskMethodBuilder<EMENIOKJNLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public FGOCALDHFKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter<EMENIOKJNLD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x6FAFA40", Offset = "0x6FAE440", VA = "0x186FAFA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x6FAFE70", Offset = "0x6FAE870", VA = "0x186FAFE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class NPLPPDDKHDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public NPLPPDDKHDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x93F4C0", Offset = "0x93DEC0", VA = "0x18093F4C0")]
		internal bool GOCAHOKANDE(PPOBPODJIIJ sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct JOLNFBALDAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public AsyncTaskMethodBuilder<EMENIOKJNLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public DINCFJKGGOK superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public OKJDCNBIHPD callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private NPLPPDDKHDB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public PGLHENLHOGA roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private LGDDBNGBFNG <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private PPOBPODJIIJ <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private DINCFJKGGOK <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private DINCFJKGGOK <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private TaskAwaiter<LGDDBNGBFNG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private TaskAwaiter<NCCIBDALGCO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private TaskAwaiter<BCDAPHNNAIF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB27F0", Offset = "0x6FB11F0", VA = "0x186FB27F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB3920", Offset = "0x6FB2320", VA = "0x186FB3920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private OKJDCNBIHPD GLFIGPDLPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private BDMPGCNODMK NFHDCIEPBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private PGLHENLHOGA GFNBLDBMKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private long ONILLAPMLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private long KOIDPPGJKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private long PHHOGBMHKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private string GNFDFPFLGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private DINCFJKGGOK AAABBPLKEFA;

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x6FAA400", Offset = "0x6FA8E00", VA = "0x186FAA400")]
	public static Task<EMENIOKJNLD> LGAPNONEBFK(DPFMBDJKAOB GFAOFFCNKEI, CCPGLNKCEAO BJLMEIJMPBN, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9F80", Offset = "0x6FA8980", VA = "0x186FA9F80")]
	[AsyncStateMachine(typeof(FECOGJBBICN))]
	private Task<EMENIOKJNLD> AJIENLNABLE(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x6FAA0D0", Offset = "0x6FA8AD0", VA = "0x186FAA0D0")]
	[AsyncStateMachine(typeof(IFJAAFHNBKC))]
	private Task<EMENIOKJNLD> JCMJPAIGGOJ(MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x6FAA230", Offset = "0x6FA8C30", VA = "0x186FAA230")]
	[AsyncStateMachine(typeof(JOLNFBALDAC))]
	private static Task<EMENIOKJNLD> JCMJPAIGGOJ(OKJDCNBIHPD GLFIGPDLPBG, PGLHENLHOGA GFNBLDBMKBB, long ONILLAPMLEN, long KOIDPPGJKOA, long PHHOGBMHKPJ, string GNFDFPFLGPO, DINCFJKGGOK AAABBPLKEFA, CancellationToken AOLOJHLCMLE, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x6FAA3D0", Offset = "0x6FA8DD0", VA = "0x186FAA3D0")]
	private void KEGGNNPLMBH(LGDDBNGBFNG FCOGIFPLFKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct OIFBFNECKNC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct BKIJJNKPBBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public OIFBFNECKNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x6FA48D0", Offset = "0x6FA32D0", VA = "0x186FA48D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4E60", Offset = "0x6FA3860", VA = "0x186FA4E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private OKJDCNBIHPD GLFIGPDLPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private FNGILHDDEFI EEOBDBMOHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private float NPCPCPPDPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private float AJFGFCEDEPK;

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA070", Offset = "0x6FB8A70", VA = "0x186FBA070")]
	public static Task GAPGMGLMODK(DPFMBDJKAOB GFAOFFCNKEI, FNGILHDDEFI EEOBDBMOHPL, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9DF0", Offset = "0x6FB87F0", VA = "0x186FB9DF0")]
	[AsyncStateMachine(typeof(BKIJJNKPBBF))]
	public Task AJIENLNABLE(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA210", Offset = "0x6FB8C10", VA = "0x186FBA210")]
	private static void JJDLGLEFIDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9F10", Offset = "0x6FB8910", VA = "0x186FB9F10")]
	private void CCACAHOJPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA370", Offset = "0x6FB8D70", VA = "0x186FBA370")]
	private static float OCNCONBIMEL(OKJDCNBIHPD GLFIGPDLPBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA350", Offset = "0x6FB8D50", VA = "0x186FBA350")]
	private static float LAEMPLCPAAD()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct PEOIPPLMMIO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct HCPHJLHHIFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public DCDGPMPFNEE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private PBCHFFOPJGA <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private DPFMBDJKAOB <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private HCDGDLIDBHA.OFLGEKNCOML <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private TaskAwaiter<KDEKOFBPMEA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE500", Offset = "0x6FACF00", VA = "0x186FAE500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x6FAED20", Offset = "0x6FAD720", VA = "0x186FAED20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct NMMBELAPPJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9AA0", Offset = "0x6FB84A0", VA = "0x186FB9AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9D90", Offset = "0x6FB8790", VA = "0x186FB9D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAEC0", Offset = "0x6FB98C0", VA = "0x186FBAEC0")]
	[AsyncStateMachine(typeof(HCPHJLHHIFD))]
	public static Task AJIENLNABLE(DCDGPMPFNEE ODBPLIAIBOF, FNGILHDDEFI EEOBDBMOHPL, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAE50", Offset = "0x6FB9850", VA = "0x186FBAE50")]
	private static Task<KDEKOFBPMEA> AIHKAHFFOHE(DCDGPMPFNEE ODBPLIAIBOF, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB000", Offset = "0x6FB9A00", VA = "0x186FBB000")]
	[AsyncStateMachine(typeof(NMMBELAPPJO))]
	private static Task HPNICFACKOJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct LMKKCMLPKLD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct FGEGGNELCEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public LMKKCMLPKLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9870", Offset = "0x6FA8270", VA = "0x186FA9870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9F20", Offset = "0x6FA8920", VA = "0x186FA9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class GJNEJGLPOFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public GJNEJGLPOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC8F0", Offset = "0x6FAB2F0", VA = "0x186FAC8F0")]
		internal object KHGIGKBHEFH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct EEJCGFGODEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public LMKKCMLPKLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private DABNPBOEILO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5E80", Offset = "0x6FA4880", VA = "0x186FA5E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6440", Offset = "0x6FA4E40", VA = "0x186FA6440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private bool DDPGKCBEGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private CancellationToken AOLOJHLCMLE;

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5DD0", Offset = "0x6FB47D0", VA = "0x186FB5DD0")]
	public static Task DBKPDFOHEHA(DPFMBDJKAOB GFAOFFCNKEI, bool DDPGKCBEGOF, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken PJABKIEFFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5CE0", Offset = "0x6FB46E0", VA = "0x186FB5CE0")]
	[AsyncStateMachine(typeof(FGEGGNELCEF))]
	private Task AJIENLNABLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5E40", Offset = "0x6FB4840", VA = "0x186FB5E40")]
	[AsyncStateMachine(typeof(EEJCGFGODEE))]
	private Task GKHMKJKBJPA(bool GLOIDKBGAML, string GBJIEPEGCMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60")]
	private bool OLAEHHBGDMI(bool DDPGKCBEGOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct AOLNKBCGNIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct CJBLFHLJHAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public AOLNKBCGNIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5350", Offset = "0x6FA3D50", VA = "0x186FA5350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x6FA58C0", Offset = "0x6FA42C0", VA = "0x186FA58C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class LGMHJHMOAJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public LGMHJHMOAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x6FB58D0", Offset = "0x6FB42D0", VA = "0x186FB58D0")]
		internal object KHGIGKBHEFH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct KJIOJMMOAPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public AOLNKBCGNIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private DABNPBOEILO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4080", Offset = "0x6FB2A80", VA = "0x186FB4080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4640", Offset = "0x6FB3040", VA = "0x186FB4640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	private KOGIADOHFGN NOMAAJHAFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005A3")]
	private MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	private DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	private bool MMLEMLDJFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005A6")]
	private FNGILHDDEFI EEOBDBMOHPL;

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x6FA4500", Offset = "0x6FA2F00", VA = "0x186FA4500")]
	public static Task<Scene> LBJJDIFNKCO(DPFMBDJKAOB GFAOFFCNKEI, KOGIADOHFGN FGNPDHPMIKG, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x6FA41F0", Offset = "0x6FA2BF0", VA = "0x186FA41F0")]
	[AsyncStateMachine(typeof(CJBLFHLJHAB))]
	private Task<Scene> AJIENLNABLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x6FA44D0", Offset = "0x6FA2ED0", VA = "0x186FA44D0")]
	private bool JAHMHDBPDNK(FNGILHDDEFI EEOBDBMOHPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x6FA4310", Offset = "0x6FA2D10", VA = "0x186FA4310")]
	private void CKODBCPCDCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x6FA4380", Offset = "0x6FA2D80", VA = "0x186FA4380")]
	[AsyncStateMachine(typeof(KJIOJMMOAPP))]
	private Task<Scene> GKHMKJKBJPA(string GBJIEPEGCMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct PPKMGLEOFAA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct EOJBAAPIKIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public AsyncTaskMethodBuilder<EAODDEEJJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public PPKMGLEOFAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public EAODDEEJJHO nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public FNGILHDDEFI deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private TaskAwaiter<EAODDEEJJHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA88B0", Offset = "0x6FA72B0", VA = "0x186FA88B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9390", Offset = "0x6FA7D90", VA = "0x186FA9390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct BEGEJOIJJOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public AsyncTaskMethodBuilder<EAODDEEJJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public PPKMGLEOFAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public EAODDEEJJHO state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private TaskAwaiter<KDEKOFBPMEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4580", Offset = "0x6FA2F80", VA = "0x186FA4580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4860", Offset = "0x6FA3260", VA = "0x186FA4860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B4")]
	private readonly DCDGPMPFNEE ODBPLIAIBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B5")]
	private readonly BDMPGCNODMK NFHDCIEPBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B6")]
	private readonly EFJFPOCGNMJ FOHHAJACPBG;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private PBCHFFOPJGA AMGDAMGLDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x56FF7D0", Offset = "0x56FE1D0", VA = "0x1856FF7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCC20", Offset = "0x6FBB620", VA = "0x186FBCC20")]
	public PPKMGLEOFAA(DCDGPMPFNEE ODBPLIAIBOF, BDMPGCNODMK NFHDCIEPBBH, EFJFPOCGNMJ FOHHAJACPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC8F0", Offset = "0x6FBB2F0", VA = "0x186FBC8F0")]
	[AsyncStateMachine(typeof(EOJBAAPIKIO))]
	public Task<EAODDEEJJHO> BNOBDNIHGFF(EAODDEEJJHO DBJKCDIIDGC, FNGILHDDEFI FEJCFBMDEGJ, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE, bool LPGANKOMDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCAA0", Offset = "0x6FBB4A0", VA = "0x186FBCAA0")]
	[AsyncStateMachine(typeof(BEGEJOIJJOP))]
	private Task<EAODDEEJJHO> FIFPDFALBDK(MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, EAODDEEJJHO FAKDNFCMPPB, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCA70", Offset = "0x6FBB470", VA = "0x186FBCA70")]
	private bool FHIINKOHPAD(EAODDEEJJHO ECGBPCPKAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCC00", Offset = "0x6FBB600", VA = "0x186FBCC00")]
	private void MDBGGDKNGAC(string LCGAFANECDP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct NBJBIOOOHDL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct LPIKFOHNOBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public PBCHFFOPJGA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public EKDFHPJHEMC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private NDMGMBJNGAH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private List<(PersistenceView, APDBPBGHHNA)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private (PersistenceView, APDBPBGHHNA) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6500", Offset = "0x6FB4F00", VA = "0x186FB6500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6B10", Offset = "0x6FB5510", VA = "0x186FB6B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7FB0", Offset = "0x6FB69B0", VA = "0x186FB7FB0")]
	[AsyncStateMachine(typeof(LPIKFOHNOBP))]
	public static Task AJIENLNABLE(PBCHFFOPJGA IOFDICGCDDA, FNGILHDDEFI EEOBDBMOHPL, EKDFHPJHEMC KHBNKCELCME, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct MMONOCLOEDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct NIHCKFCCDHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public PBCHFFOPJGA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public EKDFHPJHEMC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private JBNFDDCMJOC <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private NDMGMBJNGAH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private List<(PersistenceView, APDBPBGHHNA)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private APDBPBGHHNA <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FB91F0", Offset = "0x6FB7BF0", VA = "0x186FB91F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9A40", Offset = "0x6FB8440", VA = "0x186FB9A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7E00", Offset = "0x6FB6800", VA = "0x186FB7E00")]
	[AsyncStateMachine(typeof(NIHCKFCCDHE))]
	public static Task AJIENLNABLE(PBCHFFOPJGA IOFDICGCDDA, FNGILHDDEFI EEOBDBMOHPL, EKDFHPJHEMC KHBNKCELCME, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct HCDGDLIDBHA
{
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	public struct OFLGEKNCOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public List<MIBMLBDBJNP> BLGPIAPNIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public List<APDBPBGHHNA> JFBABDOMJDC;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA6F80", Offset = "0xAA5980", VA = "0x180AA6F80")]
		public OFLGEKNCOML(List<MIBMLBDBJNP> BLGPIAPNIDE, List<APDBPBGHHNA> JFBABDOMJDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class DHAOJEKLKGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public IEnumerable<MIBMLBDBJNP> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public DHAOJEKLKGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5B00", Offset = "0x6FA4500", VA = "0x186FA5B00")]
		internal object JAHPIHJNJMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private DPFMBDJKAOB GFAOFFCNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private FNGILHDDEFI EEOBDBMOHPL;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private OKJDCNBIHPD NCEODIICHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD9D0", Offset = "0x6FAC3D0", VA = "0x186FAD9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD7A0", Offset = "0x6FAC1A0", VA = "0x186FAD7A0")]
	public static OFLGEKNCOML AJIENLNABLE(DPFMBDJKAOB GFAOFFCNKEI, FNGILHDDEFI EEOBDBMOHPL)
	{
		return default(OFLGEKNCOML);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD540", Offset = "0x6FABF40", VA = "0x186FAD540")]
	private OFLGEKNCOML AJIENLNABLE()
	{
		return default(OFLGEKNCOML);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FADA20", Offset = "0x6FAC420", VA = "0x186FADA20")]
	private OFLGEKNCOML LDMBOOGKFMI(HOHHBPKCDBA IPPIJJOEADH, JBNFDDCMJOC ACEKHHBDICK)
	{
		return default(OFLGEKNCOML);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD800", Offset = "0x6FAC200", VA = "0x186FAD800")]
	private bool BONAPKDBLLN(IEnumerable<MIBMLBDBJNP> BLGPIAPNIDE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct POOAHKGMDOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class HAOHJAEJFJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public HCDGDLIDBHA.OFLGEKNCOML instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public HAOHJAEJFJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD490", Offset = "0x6FABE90", VA = "0x186FAD490")]
		internal object LDJCKHEGHCN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private sealed class HDPPHPCNCBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public HDPPHPCNCBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FAED80", Offset = "0x6FAD780", VA = "0x186FAED80")]
		internal object LPDNBFCBBFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC340", Offset = "0x6FBAD40", VA = "0x186FBC340")]
	public static void AJIENLNABLE(PBCHFFOPJGA IOFDICGCDDA, FNGILHDDEFI EEOBDBMOHPL, HCDGDLIDBHA.OFLGEKNCOML PDJKOPOAFMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal class EFJFPOCGNMJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct EGINDEJIAMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public EFJFPOCGNMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public EAODDEEJJHO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public FNGILHDDEFI deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x6FA80E0", Offset = "0x6FA6AE0", VA = "0x186FA80E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8850", Offset = "0x6FA7250", VA = "0x186FA8850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class AFLPPIAFCAH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000169")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005FA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005FB")]
			public AFLPPIAFCAH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x6FBCE80", Offset = "0x6FBB880", VA = "0x186FBCE80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x6FBD140", Offset = "0x6FBBB40", VA = "0x186FBD140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public EFJFPOCGNMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AFLPPIAFCAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4100", Offset = "0x6FA2B00", VA = "0x186FA4100")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task GAJELPDINJG(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct LOCMBBIJBIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public EFJFPOCGNMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private AFLPPIAFCAH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5F70", Offset = "0x6FB4970", VA = "0x186FB5F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x6FB64A0", Offset = "0x6FB4EA0", VA = "0x186FB64A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct JGDNOLBEICL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public EFJFPOCGNMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private Dictionary<Guid, List<OLMPMOBPCPN>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FB02F0", Offset = "0x6FAECF0", VA = "0x186FB02F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x6FB08A0", Offset = "0x6FAF2A0", VA = "0x186FB08A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct NGMLHPKONCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public EFJFPOCGNMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private Dictionary<Guid, List<OLMPMOBPCPN>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8B10", Offset = "0x6FB7510", VA = "0x186FB8B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9190", Offset = "0x6FB7B90", VA = "0x186FB9190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class MGOCODGIEEF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400061E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			public OLMPMOBPCPN handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000620")]
			public MGOCODGIEEF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x6FBCC80", Offset = "0x6FBB680", VA = "0x186FBCC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x6FBCE20", Offset = "0x6FBB820", VA = "0x186FBCE20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public KFMKFCFIHGA runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public List<OLMPMOBPCPN> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public MGOCODGIEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6EE0", Offset = "0x6FB58E0", VA = "0x186FB6EE0")]
		internal object NIHKCEIDCBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6DF0", Offset = "0x6FB57F0", VA = "0x186FB6DF0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task EOJDLGLLHIH(OLMPMOBPCPN handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6D00", Offset = "0x6FB5700", VA = "0x186FB6D00")]
		internal object BMBNEKHFMFM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct HCIBCOHOGNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public KFMKFCFIHGA runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public List<OLMPMOBPCPN> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private MGOCODGIEEF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x6FADFD0", Offset = "0x6FAC9D0", VA = "0x186FADFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE4A0", Offset = "0x6FACEA0", VA = "0x186FAE4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct KPBKFJNMJPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public EFJFPOCGNMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FB46B0", Offset = "0x6FB30B0", VA = "0x186FB46B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4C70", Offset = "0x6FB3670", VA = "0x186FB4C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class ACFPNLPNBJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public ACFPNLPNBJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4090", Offset = "0x6FA2A90", VA = "0x186FA4090")]
		internal object JNINKCOCHMC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct GALHAFMEEDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public EFJFPOCGNMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public FNGILHDDEFI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x6FABF50", Offset = "0x6FAA950", VA = "0x186FABF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC410", Offset = "0x6FAAE10", VA = "0x186FAC410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class GCLICFLEGHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public GCLICFLEGHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC470", Offset = "0x6FAAE70", VA = "0x186FAC470")]
		internal object FKFCDEEALAK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct GPJKOFLPGEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public EFJFPOCGNMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private TaskAwaiter<KDEKOFBPMEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC970", Offset = "0x6FAB370", VA = "0x186FAC970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6FACFB0", Offset = "0x6FAB9B0", VA = "0x186FACFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class MFGJJDJOGHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public MFGJJDJOGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6C90", Offset = "0x6FB5690", VA = "0x186FB6C90")]
		internal object BMIFENKAMOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private readonly DCDGPMPFNEE ODBPLIAIBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private NIJMMGHIJLB FOHHAJACPBG;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private PBCHFFOPJGA AMGDAMGLDMH
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x9113E0", Offset = "0x90FDE0", VA = "0x1809113E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	public EFJFPOCGNMJ(DCDGPMPFNEE ODBPLIAIBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7180", Offset = "0x6FA5B80", VA = "0x186FA7180")]
	[AsyncStateMachine(typeof(EGINDEJIAMF))]
	public Task AJIENLNABLE(EAODDEEJJHO BKIONIDGPCE, FNGILHDDEFI FEJCFBMDEGJ, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x6FA72D0", Offset = "0x6FA5CD0", VA = "0x186FA72D0")]
	[AsyncStateMachine(typeof(LOCMBBIJBIK))]
	private Task AODGIJINPHP(FNGILHDDEFI EEOBDBMOHPL, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7BF0", Offset = "0x6FA65F0", VA = "0x186FA7BF0")]
	[AsyncStateMachine(typeof(JGDNOLBEICL))]
	private Task KAOMNLPIECF(FNGILHDDEFI EEOBDBMOHPL, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7550", Offset = "0x6FA5F50", VA = "0x186FA7550")]
	[AsyncStateMachine(typeof(NGMLHPKONCN))]
	private Task CABAMDIGLOG(FNGILHDDEFI EEOBDBMOHPL, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7910", Offset = "0x6FA6310", VA = "0x186FA7910")]
	[AsyncStateMachine(typeof(HCIBCOHOGNL))]
	private Task ICCCBDMCDBN(Guid PKDLNOKNIDG, List<OLMPMOBPCPN> JMDPPHCHJLH, KFMKFCFIHGA HNIMDFEJOOM, FNGILHDDEFI EEOBDBMOHPL, CancellationToken JCIFCENKMKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7690", Offset = "0x6FA6090", VA = "0x186FA7690")]
	[AsyncStateMachine(typeof(KPBKFJNMJPA))]
	private Task DBMMBCLJIHA(FNGILHDDEFI EEOBDBMOHPL, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7410", Offset = "0x6FA5E10", VA = "0x186FA7410")]
	[AsyncStateMachine(typeof(GALHAFMEEDB))]
	private Task BKNHKFFDOJJ(Guid DPKKOCADFIL, FNGILHDDEFI EEOBDBMOHPL, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x6FA77D0", Offset = "0x6FA61D0", VA = "0x186FA77D0")]
	[AsyncStateMachine(typeof(GPJKOFLPGEF))]
	private Task GJNKEGFEBAB(Guid DPKKOCADFIL, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7F10", Offset = "0x6FA6910", VA = "0x186FA7F10")]
	private void OEKNAOGOJBF(Guid DPKKOCADFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8030", Offset = "0x6FA6A30", VA = "0x186FA8030")]
	private void PMMKJPOIIME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7A60", Offset = "0x6FA6460", VA = "0x186FA7A60")]
	public Guid JJEBMFBGLNL(EAODDEEJJHO HJOBBNKHBOD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7D30", Offset = "0x6FA6730", VA = "0x186FA7D30")]
	[CompilerGenerated]
	private object OBHOGLINGGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal struct OMFKLOLKDMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct MLBKKAEMDJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public OMFKLOLKDMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private MIJAEHJIGEB<string>.OBFKFOAMCEP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private IEnumerator<OPNKHABJNFG> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x6FB76C0", Offset = "0x6FB60C0", VA = "0x186FB76C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7DA0", Offset = "0x6FB67A0", VA = "0x186FB7DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000649")]
	private OKJDCNBIHPD GLFIGPDLPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400064A")]
	private MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064B")]
	private CancellationToken AOLOJHLCMLE;

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x6FBADE0", Offset = "0x6FB97E0", VA = "0x186FBADE0")]
	public static Task CGPBIEDDAFG(OKJDCNBIHPD GLFIGPDLPBG, MIJAEHJIGEB<string>.OBFKFOAMCEP GJLENOHHOLD, CancellationToken PJABKIEFFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FBACF0", Offset = "0x6FB96F0", VA = "0x186FBACF0")]
	[AsyncStateMachine(typeof(MLBKKAEMDJP))]
	private Task AJIENLNABLE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public readonly struct BALIOMLHDAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	public readonly bool EIAMGGPINHE;

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0xE21AD0", Offset = "0xE204D0", VA = "0x180E21AD0")]
	public BALIOMLHDAA(bool AACOKMCDJJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public readonly struct POAAKMMADBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	public readonly HOHHBPKCDBA? CNKDNOKJEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000654")]
	public readonly NFPNMDPLAGP ACPDHONGCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	public readonly string? KNPBCEBCLLC;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyCollection<string> NPEPHHNIMNI
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC220", Offset = "0x6FBAC20", VA = "0x186FBC220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public IReadOnlyDictionary<long, int> IBOLGJFHLEO
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC200", Offset = "0x6FBAC00", VA = "0x186FBC200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC240", Offset = "0x6FBAC40", VA = "0x186FBC240")]
	public POAAKMMADBH(HOHHBPKCDBA? IJFOGIEFCHH, NFPNMDPLAGP MEPANNFLKMI, string? NCFBDPGOPGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal class JHOLNGLHEOK : KKOPKDOBFJO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct JNBIHLNEEOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public AsyncTaskMethodBuilder<POAAKMMADBH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public JHOLNGLHEOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public INCGGNCJBHD serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public AHFCPDKCLOG roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private NDMGMBJNGAH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2110", Offset = "0x6FB0B10", VA = "0x186FB2110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2780", Offset = "0x6FB1180", VA = "0x186FB2780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class DOKIMHCCBNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public INCGGNCJBHD serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public JHOLNGLHEOK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public DOKIMHCCBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5C60", Offset = "0x6FA4660", VA = "0x186FA5C60")]
		internal Task EPGJKFACHFA(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5B80", Offset = "0x6FA4580", VA = "0x186FA5B80")]
		internal Task CCABKEFOFJF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class MOKBCCPLKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public DOKIMHCCBNF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public MOKBCCPLKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7F40", Offset = "0x6FB6940", VA = "0x186FB7F40")]
		internal object OHIEELBMIBN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class LJDEBCLCLAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public DOKIMHCCBNF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public LJDEBCLCLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5920", Offset = "0x6FB4320", VA = "0x186FB5920")]
		internal Task NLFAPJJNJLL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct FPHNDKIHPOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public INCGGNCJBHD serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public JHOLNGLHEOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private MOKBCCPLKBG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private NDMGMBJNGAH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB2E0", Offset = "0x6FA9CE0", VA = "0x186FAB2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x6FABB50", Offset = "0x6FAA550", VA = "0x186FABB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private static readonly TimeSpan FGEAMJCJPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000658")]
	private readonly IGEBCBGCLCP IOHJHJNFOJN;

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1A10", Offset = "0x6FB0410", VA = "0x186FB1A10")]
	public JHOLNGLHEOK(DCDGPMPFNEE ODBPLIAIBOF, IGEBCBGCLCP IOHJHJNFOJN, LGKLDLNGEGN DHOGKNDCDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FB15F0", Offset = "0x6FAFFF0", VA = "0x186FB15F0")]
	[AsyncStateMachine(typeof(JNBIHLNEEOF))]
	public Task<POAAKMMADBH> KJCBMOAEMAH(long KOIDPPGJKOA, AHFCPDKCLOG HPAKIFCHMJH, INCGGNCJBHD IKMJPHAJEME, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FB14B0", Offset = "0x6FAFEB0", VA = "0x186FB14B0")]
	[AsyncStateMachine(typeof(FPHNDKIHPOJ))]
	private Task IDDACFLIDPJ(INCGGNCJBHD IKMJPHAJEME, IEnumerable<PersistenceView> GNJLLHOLMOD, StringBuilder HJMIOKCEOAN, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0A60", Offset = "0x6FAF460", VA = "0x186FB0A60")]
	private POAAKMMADBH GNDAOGOELHG(long KOIDPPGJKOA, AHFCPDKCLOG HPAKIFCHMJH, INCGGNCJBHD IKMJPHAJEME, IEnumerable<PersistenceView> GNJLLHOLMOD, StringBuilder HJMIOKCEOAN)
	{
		return default(POAAKMMADBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0900", Offset = "0x6FAF300", VA = "0x186FB0900")]
	private HOHHBPKCDBA FEEJNPBIECM(long KOIDPPGJKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1750", Offset = "0x6FB0150", VA = "0x186FB1750")]
	private void OADOOJLEPDK(HOHHBPKCDBA KKLNMGIECKN, StringBuilder HJMIOKCEOAN, IEnumerable<PersistenceView> GNJLLHOLMOD, [In] OJELAFKBGBK IBEMJDBLHEI, KHGKNMHPLBK BMHDKBBCOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1010", Offset = "0x6FAFA10", VA = "0x186FB1010")]
	private void HAGLNBLKEOI(HOHHBPKCDBA KKLNMGIECKN, StringBuilder HJMIOKCEOAN, PersistenceView BIAEPGIEGAH, KHGKNMHPLBK BMHDKBBCOMK, [In] OJELAFKBGBK IBEMJDBLHEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal class MIDPGEHLBFM : KKOPKDOBFJO
{
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class GADFPNCAIIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public CBEKJIPBFJA.ECOGBAAIGGA roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public GADFPNCAIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x6FABBB0", Offset = "0x6FAA5B0", VA = "0x186FABBB0")]
		internal object LHMJEFGGDOE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct OLBIOFPPMMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public AsyncTaskMethodBuilder<(CBEKJIPBFJA.ECOGBAAIGGA roomDataUpload, CBEKJIPBFJA.ECOGBAAIGGA subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public POAAKMMADBH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public MIDPGEHLBFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private GADFPNCAIIB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private TaskAwaiter<CBEKJIPBFJA.ECOGBAAIGGA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA430", Offset = "0x6FB8E30", VA = "0x186FBA430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAC80", Offset = "0x6FB9680", VA = "0x186FBAC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct KDIGEEDIAEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public AsyncTaskMethodBuilder<HCBBPJCCCOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public MIDPGEHLBFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public POAAKMMADBH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public DLCPLGMDJEG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private TaskAwaiter<(CBEKJIPBFJA.ECOGBAAIGGA roomDataUpload, CBEKJIPBFJA.ECOGBAAIGGA subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private TaskAwaiter<HCBBPJCCCOC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB3990", Offset = "0x6FB2390", VA = "0x186FB3990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4010", Offset = "0x6FB2A10", VA = "0x186FB4010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct HALBBFCEGDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public AsyncTaskMethodBuilder<NCCIBDALGCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public MIDPGEHLBFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public POAAKMMADBH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private TaskAwaiter<(CBEKJIPBFJA.ECOGBAAIGGA roomDataUpload, CBEKJIPBFJA.ECOGBAAIGGA subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private TaskAwaiter<NCCIBDALGCO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD010", Offset = "0x6FABA10", VA = "0x186FAD010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD420", Offset = "0x6FABE20", VA = "0x186FAD420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class LFDNKCKDNOM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006A4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			public AsyncTaskMethodBuilder<KDEKOFBPMEA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006A6")]
			public LFDNKCKDNOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			private KDEKOFBPMEA <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006A9")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006AA")]
			private TaskAwaiter<NCCIBDALGCO> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006AB")]
			private TaskAwaiter<HCBBPJCCCOC> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006AC")]
			private TaskAwaiter<KDEKOFBPMEA> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x6FBD590", Offset = "0x6FBBF90", VA = "0x186FBD590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x6FBE510", Offset = "0x6FBCF10", VA = "0x186FBE510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public MIDPGEHLBFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public POAAKMMADBH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public DLCPLGMDJEG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public BALIOMLHDAA roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public LFDNKCKDNOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x6FB57A0", Offset = "0x6FB41A0", VA = "0x186FB57A0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<KDEKOFBPMEA> HHDHJJCEPFO(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct LMDKHHPCEOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public AsyncTaskMethodBuilder<KDEKOFBPMEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public MIDPGEHLBFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public POAAKMMADBH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public DLCPLGMDJEG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public BALIOMLHDAA roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public MIJAEHJIGEB<string>.OBFKFOAMCEP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private TaskAwaiter<KDEKOFBPMEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5960", Offset = "0x6FB4360", VA = "0x186FB5960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5C70", Offset = "0x6FB4670", VA = "0x186FB5C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400067B")]
	private static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.Token(Token = "0x400067C")]
	private static readonly LGKLDLNGEGN CIEDFMCFHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400067D")]
	private readonly NMPOIBENFNL BCHFAKBPIIG;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	private DPFMBDJKAOB NEMIAKLILLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D8D0", Offset = "0x6F8C2D0", VA = "0x186F8D8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7630", Offset = "0x6FB6030", VA = "0x186FB7630")]
	public MIDPGEHLBFM(DCDGPMPFNEE ODBPLIAIBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7140", Offset = "0x6FB5B40", VA = "0x186FB7140")]
	[AsyncStateMachine(typeof(OLBIOFPPMMF))]
	private Task<(CBEKJIPBFJA.ECOGBAAIGGA, CBEKJIPBFJA.ECOGBAAIGGA)> JJOFOOBIKBJ(POAAKMMADBH FPIGOBMKHAC, long ONILLAPMLEN, long EMDKAGDEANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6FD0", Offset = "0x6FB59D0", VA = "0x186FB6FD0")]
	[AsyncStateMachine(typeof(KDIGEEDIAEP))]
	public Task<HCBBPJCCCOC> IBCEEIACLBM(int FOBGMHODFPK, [CanBeNull] DLCPLGMDJEG CGDEKJPLMLA, POAAKMMADBH FPIGOBMKHAC, long ONILLAPMLEN, long EMDKAGDEANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7280", Offset = "0x6FB5C80", VA = "0x186FB7280")]
	[AsyncStateMachine(typeof(HALBBFCEGDD))]
	private Task<NCCIBDALGCO> NALGMPEAEMB(string GNFDFPFLGPO, int FOBGMHODFPK, POAAKMMADBH FPIGOBMKHAC, long ONILLAPMLEN, long EMDKAGDEANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x6FB73F0", Offset = "0x6FB5DF0", VA = "0x186FB73F0")]
	[AsyncStateMachine(typeof(LMDKHHPCEOG))]
	public Task<KDEKOFBPMEA> NLILIJFEIDE(int FOBGMHODFPK, DLCPLGMDJEG? CGDEKJPLMLA, POAAKMMADBH FPIGOBMKHAC, long ONILLAPMLEN, long EMDKAGDEANA, BALIOMLHDAA PPMCGNFPIFI, MIJAEHJIGEB<string>.OBFKFOAMCEP LDEAKCJAPGF, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
public abstract class DMFJLANDOEO<T> where T : DMFJLANDOEO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	internal readonly DPFMBDJKAOB ACEGIFCNMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private int? ACPMDCMNEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	protected readonly Guid HCPELCNJBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006BC")]
	protected readonly INIFIJEJACJ FJKMKDOKGNG;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	protected T EANKNNKJAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x57D0790", Offset = "0x57CF190", VA = "0x1857D0790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x57D0A60", Offset = "0x57CF460", VA = "0x1857D0A60")]
	internal DMFJLANDOEO(DPFMBDJKAOB DGGOCNGPOMO, INIFIJEJACJ BCMDHKBDLJG, [Optional] Guid? ANGIPKEDDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x57D06B0", Offset = "0x57CF0B0", VA = "0x1857D06B0")]
	private KDEKOFBPMEA DANONEBFPIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "4")]
	protected virtual void JAGODCMPDOH(KDEKOFBPMEA BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x57D0920", Offset = "0x57CF320", VA = "0x1857D0920")]
	public T MOJMNMDHELA(JDKCNIBKGKE FFJFLMHOJHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x57D09C0", Offset = "0x57CF3C0", VA = "0x1857D09C0")]
	public T OKPKAJDFFNH(int IEKIJPIGGDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x57D07F0", Offset = "0x57CF1F0", VA = "0x1857D07F0", Slot = "5")]
	public virtual Task<EOMKIGIPEDC> KJAFNBKBDBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
public class GHEKEGDBODK : DMFJLANDOEO<GHEKEGDBODK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006BD")]
	private CCPGLNKCEAO NBBCEJPPPCO;

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC5B0", Offset = "0x6FAAFB0", VA = "0x186FAC5B0")]
	internal GHEKEGDBODK(DPFMBDJKAOB DGGOCNGPOMO, INIFIJEJACJ BCMDHKBDLJG, [Optional] Guid? ANGIPKEDDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x64F2010", Offset = "0x64F0A10", VA = "0x1864F2010")]
	public GHEKEGDBODK EMMMJOGLJGG(CCPGLNKCEAO NBBCEJPPPCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC4E0", Offset = "0x6FAAEE0", VA = "0x186FAC4E0", Slot = "4")]
	protected override void JAGODCMPDOH(KDEKOFBPMEA BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public class PGGHFFCMACE : DMFJLANDOEO<PGGHFFCMACE>
{
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	internal enum HGBHMLFAKOM
	{
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct IJPJNCOIOPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public AsyncTaskMethodBuilder<EOMKIGIPEDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public PGGHFFCMACE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private TaskAwaiter<EOMKIGIPEDC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x6FAFEE0", Offset = "0x6FAE8E0", VA = "0x186FAFEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0280", Offset = "0x6FAEC80", VA = "0x186FB0280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	private HGBHMLFAKOM CNAOCJJKKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	private string BDCMOIFKBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	private DLCPLGMDJEG NBBCEJPPPCO;

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC090", Offset = "0x6FBAA90", VA = "0x186FBC090")]
	internal PGGHFFCMACE(DPFMBDJKAOB DGGOCNGPOMO, INIFIJEJACJ BCMDHKBDLJG, [Optional] Guid? ANGIPKEDDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBD70", Offset = "0x6FBA770", VA = "0x186FBBD70")]
	public PGGHFFCMACE AKDIHCIKKCP(string GFOGDKMJGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBDA0", Offset = "0x6FBA7A0", VA = "0x186FBBDA0")]
	public PGGHFFCMACE ICPFMKFGAEC(bool OCJJPPGOEEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC060", Offset = "0x6FBAA60", VA = "0x186FBC060")]
	public PGGHFFCMACE MKCGIBLIONH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBE00", Offset = "0x6FBA800", VA = "0x186FBBE00", Slot = "4")]
	protected override void JAGODCMPDOH(KDEKOFBPMEA BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBF70", Offset = "0x6FBA970", VA = "0x186FBBF70", Slot = "5")]
	[AsyncStateMachine(typeof(IJPJNCOIOPL))]
	public override Task<EOMKIGIPEDC> KJAFNBKBDBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBDC0", Offset = "0x6FBA7C0", VA = "0x186FBBDC0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<EOMKIGIPEDC> IDLLJIFNPFE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal static class DGFJBGPIDMG
{
	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x6FA5930", Offset = "0x6FA4330", VA = "0x186FA5930")]
	public static void PANNCBEPFPN(this PHMNLMEJCDN JCMKCNNAHEI, MDCEFFOBCGJ CKEPHLLFMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x6FA5A80", Offset = "0x6FA4480", VA = "0x186FA5A80")]
	public static void PCMLAGHGAPP(this MDCEFFOBCGJ BOKMEBAEBFF, [Optional] string BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public static class IBELNHFFJKP
{
	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF8F0", Offset = "0x6FAE2F0", VA = "0x186FAF8F0")]
	public static DINCFJKGGOK LPLIJILBMFC(this HJLIOFNOMKM HKNGOKFGMHB)
	{
		return default(DINCFJKGGOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF990", Offset = "0x6FAE390", VA = "0x186FAF990")]
	public static HJLIOFNOMKM NEFHOGOFLEC(this DINCFJKGGOK CIAMOJFBCKC)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000192")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006CD")]
			public JGKBGCPBGJM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006CE")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006CF")]
			public JGKBGCPBGJM HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006D0")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006D1")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006D2")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private static JGKBGCPBGJM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		private Dictionary<JGKBGCPBGJM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEBF0", Offset = "0x6FBD5F0", VA = "0x186FBEBF0")]
		public bool IIPKLJEBICM(JGKBGCPBGJM MMHLCHJMJIP, [Out] ResultConfig FBFDHBHFJCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEAB0", Offset = "0x6FBD4B0", VA = "0x186FBEAB0")]
		public ResultConfig ANABJNBELEF(JGKBGCPBGJM GDIKEMIFDHP, [Optional] HashSet<JGKBGCPBGJM> EFEGFBCOELF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF1C0", Offset = "0x6FBDBC0", VA = "0x186FBF1C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEC60", Offset = "0x6FBD660", VA = "0x186FBEC60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBC0", Offset = "0x8BA5C0", VA = "0x1808BBBC0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public static class LCOMBBJFGLK
{
	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4CD0", Offset = "0x6FB36D0", VA = "0x186FB4CD0")]
	[MHFEIEAPENL(CMFCLNIIIKO.GameOnly)]
	private static void FIFELDOAMFC(GPECMKAJNMD MJAMFOPMNJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public interface OPHHGBFNKCM : IEquatable<OPHHGBFNKCM>
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	DateTime LJDMFDOKKND
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMAGAKCHGJM();

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KGHIIOACPPE(long ONILLAPMLEN, long KOIDPPGJKOA, [Out] POAAKMMADBH FPIGOBMKHAC);
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
internal class FKOOOOLCKDN : NAMBLCHFHOF
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class FAJBDADDGGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public MFIOOOIMKCN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public FAJBDADDGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF9B0", Offset = "0x6FBE3B0", VA = "0x186FBF9B0")]
		internal object KNEEHKJOJME()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private readonly ABGJLKIBOAA LPLBOOJFPJH;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<OPHHGBFNKCM> CCLIKCACPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB230", Offset = "0x6FA9C30", VA = "0x186FAB230", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA670", Offset = "0x6FA9070", VA = "0x186FAA670", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	[UnityEngine.Scripting.Preserve]
	public FKOOOOLCKDN([OHLKLPAILPF(null)] ABGJLKIBOAA LPLBOOJFPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x6FAA7D0", Offset = "0x6FA91D0", VA = "0x186FAA7D0", Slot = "6")]
	public bool HKKBIPNCJOM(long ONILLAPMLEN, long KOIDPPGJKOA, POAAKMMADBH FPIGOBMKHAC, MFIOOOIMKCN JHBPEHBAAIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C4D0", Offset = "0x1C1AED0", VA = "0x181C1C4D0")]
	private void ALBNGOBKMCN(OPHHGBFNKCM CFEFPIPMPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB0C0", Offset = "0x6FA9AC0", VA = "0x186FAB0C0", Slot = "7")]
	public bool OLMNBDFOBPE(long ONILLAPMLEN, long KOIDPPGJKOA, [Out] OPHHGBFNKCM HJPACFIDIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x6FAA720", Offset = "0x6FA9120", VA = "0x186FAA720", Slot = "8")]
	public bool GDHNKKMKGDC(long ONILLAPMLEN, long KOIDPPGJKOA, MFIOOOIMKCN JHBPEHBAAIE, [Out] OPHHGBFNKCM HJPACFIDIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAC20", Offset = "0x6FA9620", VA = "0x186FAAC20")]
	private void MHNGPGLHLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAB10", Offset = "0x6FA9510", VA = "0x186FAAB10", Slot = "9")]
	public void JHLCMGGFFCN(long ONILLAPMLEN, long KOIDPPGJKOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal abstract class FLBKOBFDOHD : ABGJLKIBOAA
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	protected enum IMCLHPOOAEI : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class AMOIAOKFLDK : IEnumerable<OPHHGBFNKCM>, IEnumerable, IEnumerator<OPHHGBFNKCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private OPHHGBFNKCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public FLBKOBFDOHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private MFIOOOIMKCN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public MFIOOOIMKCN <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		private OPHHGBFNKCM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x8A7B40", Offset = "0x8A6540", VA = "0x1808A7B40")]
		[DebuggerHidden]
		public AMOIAOKFLDK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF560", Offset = "0x6FBDF60", VA = "0x186FBF560", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF840", Offset = "0x6FBE240", VA = "0x186FBF840", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF790", Offset = "0x6FBE190", VA = "0x186FBF790", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OPHHGBFNKCM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF790", Offset = "0x6FBE190", VA = "0x186FBF790", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class EKFIOFLGPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public MFIOOOIMKCN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public EKFIOFLGPEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF910", Offset = "0x6FBE310", VA = "0x186FBF910")]
		internal object LACFAFMHKPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private sealed class BOEBJFLLIKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public FLBKOBFDOHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public BOEBJFLLIKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF890", Offset = "0x6FBE290", VA = "0x186FBF890")]
		internal void KNPCONOGBCK(BFJKPDDFECG.PBPDMFOPLCB ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private readonly object JKJKGADAHNN;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	protected string FAGLAKHIOEG
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC01A0", Offset = "0x6FBEBA0", VA = "0x186FC01A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public abstract BEJGFBOIEHJ HCCJOEGEHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0420", Offset = "0x6FBEE20", VA = "0x186FC0420")]
	protected FLBKOBFDOHD([CanBeNull] string HDPHPHLCDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0240", Offset = "0x6FBEC40", VA = "0x186FC0240", Slot = "5")]
	public bool ONHMAFPNJJL(long ONILLAPMLEN, long KOIDPPGJKOA, MFIOOOIMKCN JHBPEHBAAIE, [Out] OPHHGBFNKCM CFEFPIPMPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x6FC01B0", Offset = "0x6FBEBB0", VA = "0x186FC01B0", Slot = "6")]
	[IteratorStateMachine(typeof(AMOIAOKFLDK))]
	public IEnumerable<OPHHGBFNKCM> NKCCGGMBDNG(MFIOOOIMKCN JHBPEHBAAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void JJPDBHLIDCN(Stream HAGNBAOACNK, long ONILLAPMLEN, long KOIDPPGJKOA, POAAKMMADBH FPIGOBMKHAC);

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool LFLDKGJMPJH(Stream LLIGAEHAKJM, long ONILLAPMLEN, long KOIDPPGJKOA, ABIGFPJHIDG OMGCLDKFGDA, [Out] POAAKMMADBH FPIGOBMKHAC);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFDB0", Offset = "0x6FBE7B0", VA = "0x186FBFDB0", Slot = "7")]
	public OPHHGBFNKCM FNBEJKLKPDN(long ONILLAPMLEN, long KOIDPPGJKOA, POAAKMMADBH FPIGOBMKHAC, MFIOOOIMKCN JHBPEHBAAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo GFCHMHDKJIC(long ONILLAPMLEN, long KOIDPPGJKOA, MFIOOOIMKCN JHBPEHBAAIE, IMCLHPOOAEI LGLGPLFEFCA);

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo IKPGGAPLKNJ(MFIOOOIMKCN JHBPEHBAAIE, IMCLHPOOAEI LGLGPLFEFCA);

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0130", Offset = "0x6FBEB30", VA = "0x186FC0130")]
	protected void HCOMNJEGKND(BFJKPDDFECG.PBPDMFOPLCB OGJIIEJDBDC, string LCGAFANECDP, FileInfo IBNFCLFGGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFA20", Offset = "0x6FBE420", VA = "0x186FBFA20")]
	internal bool DNGLEDJGKFB(FileInfo NGOABKBLFBL, long ONILLAPMLEN, long KOIDPPGJKOA, [Out] POAAKMMADBH FPIGOBMKHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private void JOJIHHKDHNH(Exception KCIKNEKGGMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal class MHFGAIBBFFG : FLBKOBFDOHD
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public override BEJGFBOIEHJ HCCJOEGEHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xCA4F20", Offset = "0xCA3920", VA = "0x180CA4F20", Slot = "8")]
		get
		{
			return default(BEJGFBOIEHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1830", Offset = "0x6FC0230", VA = "0x186FC1830")]
	public MHFGAIBBFFG([Optional] string HDPHPHLCDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0F40", Offset = "0x6FBF940", VA = "0x186FC0F40")]
	private void ILJNEEEICBN(MFIOOOIMKCN JHBPEHBAAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0FC0", Offset = "0x6FBF9C0", VA = "0x186FC0FC0", Slot = "9")]
	internal override void JJPDBHLIDCN(Stream HAGNBAOACNK, long ONILLAPMLEN, long KOIDPPGJKOA, POAAKMMADBH FPIGOBMKHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1250", Offset = "0x6FBFC50", VA = "0x186FC1250", Slot = "10")]
	internal override bool LFLDKGJMPJH(Stream LLIGAEHAKJM, long ONILLAPMLEN, long KOIDPPGJKOA, ABIGFPJHIDG OMGCLDKFGDA, [Out] POAAKMMADBH FPIGOBMKHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0D50", Offset = "0x6FBF750", VA = "0x186FC0D50", Slot = "11")]
	protected override FileInfo GFCHMHDKJIC(long ONILLAPMLEN, long KOIDPPGJKOA, MFIOOOIMKCN JHBPEHBAAIE, IMCLHPOOAEI LGLGPLFEFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0E40", Offset = "0x6FBF840", VA = "0x186FC0E40", Slot = "12")]
	protected override DirectoryInfo IKPGGAPLKNJ(MFIOOOIMKCN JHBPEHBAAIE, IMCLHPOOAEI LGLGPLFEFCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal sealed class OMOOKGCPOCE : FLBKOBFDOHD
{
	[Cpp2IlInjected.Token(Token = "0x40006EE")]
	private static readonly byte[] LDDEKIBHION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	private readonly byte[] FELMELFCBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006F0")]
	private readonly byte[] NCLPJGPLNOK;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public override BEJGFBOIEHJ HCCJOEGEHAC
	{
		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x5D819B0", Offset = "0x5D803B0", VA = "0x185D819B0", Slot = "8")]
		get
		{
			return default(BEJGFBOIEHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2690", Offset = "0x6FC1090", VA = "0x186FC2690")]
	public OMOOKGCPOCE([Optional] string HDPHPHLCDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1B70", Offset = "0x6FC0570", VA = "0x186FC1B70", Slot = "9")]
	internal override void JJPDBHLIDCN(Stream HAGNBAOACNK, long ONILLAPMLEN, long KOIDPPGJKOA, POAAKMMADBH FPIGOBMKHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1E30", Offset = "0x6FC0830", VA = "0x186FC1E30", Slot = "10")]
	internal override bool LFLDKGJMPJH(Stream LLIGAEHAKJM, long ONILLAPMLEN, long KOIDPPGJKOA, ABIGFPJHIDG OMGCLDKFGDA, [Out] POAAKMMADBH FPIGOBMKHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x6FC19A0", Offset = "0x6FC03A0", VA = "0x186FC19A0")]
	private void IELDDBDFHAA(byte[] KKELJOOMKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1870", Offset = "0x6FC0270", VA = "0x186FC1870", Slot = "11")]
	protected override FileInfo GFCHMHDKJIC(long ONILLAPMLEN, long KOIDPPGJKOA, MFIOOOIMKCN JHBPEHBAAIE, IMCLHPOOAEI LGLGPLFEFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1A60", Offset = "0x6FC0460", VA = "0x186FC1A60", Slot = "12")]
	protected override DirectoryInfo IKPGGAPLKNJ(MFIOOOIMKCN JHBPEHBAAIE, IMCLHPOOAEI LGLGPLFEFCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public enum BEJGFBOIEHJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal class PJNALINOIIM : ABGJLKIBOAA
{
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private sealed class IBOGIPANCHO : IEnumerable<OPHHGBFNKCM>, IEnumerable, IEnumerator<OPHHGBFNKCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private OPHHGBFNKCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public PJNALINOIIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		private MFIOOOIMKCN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public MFIOOOIMKCN <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private BEJGFBOIEHJ[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private IEnumerator<OPHHGBFNKCM> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		private OPHHGBFNKCM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x8A7B40", Offset = "0x8A6540", VA = "0x1808A7B40")]
		[DebuggerHidden]
		public IBOGIPANCHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0CC0", Offset = "0x6FBF6C0", VA = "0x186FC0CC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0810", Offset = "0x6FBF210", VA = "0x186FC0810", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x6FC07C0", Offset = "0x6FBF1C0", VA = "0x186FC07C0")]
		private void KBJJHHPKCPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0C70", Offset = "0x6FBF670", VA = "0x186FC0C70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0BC0", Offset = "0x6FBF5C0", VA = "0x186FC0BC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OPHHGBFNKCM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0BC0", Offset = "0x6FBF5C0", VA = "0x186FC0BC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private readonly BEJGFBOIEHJ[] FPMJGGKPGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F6")]
	private readonly Dictionary<BEJGFBOIEHJ, ABGJLKIBOAA> OCIFDHOGKEP;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public BEJGFBOIEHJ HCCJOEGEHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x6FC31F0", Offset = "0x6FC1BF0", VA = "0x186FC31F0", Slot = "4")]
		get
		{
			return default(BEJGFBOIEHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3370", Offset = "0x6FC1D70", VA = "0x186FC3370")]
	[UnityEngine.Scripting.Preserve]
	public PJNALINOIIM(params ABGJLKIBOAA[] MALPFBPGHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3220", Offset = "0x6FC1C20", VA = "0x186FC3220", Slot = "5")]
	public bool ONHMAFPNJJL(long ONILLAPMLEN, long KOIDPPGJKOA, MFIOOOIMKCN JHBPEHBAAIE, [Out] OPHHGBFNKCM CFEFPIPMPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2DF0", Offset = "0x6FC17F0", VA = "0x186FC2DF0")]
	private void EPNPJBBCDCF(int ICFOGFCGNLP, long ONILLAPMLEN, long KOIDPPGJKOA, MFIOOOIMKCN JHBPEHBAAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3160", Offset = "0x6FC1B60", VA = "0x186FC3160", Slot = "6")]
	[IteratorStateMachine(typeof(IBOGIPANCHO))]
	public IEnumerable<OPHHGBFNKCM> NKCCGGMBDNG(MFIOOOIMKCN JHBPEHBAAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3010", Offset = "0x6FC1A10", VA = "0x186FC3010", Slot = "7")]
	public OPHHGBFNKCM FNBEJKLKPDN(long ONILLAPMLEN, long KOIDPPGJKOA, POAAKMMADBH FPIGOBMKHAC, MFIOOOIMKCN JHBPEHBAAIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
internal static class HMFNDHFNHMH
{
	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0700", Offset = "0x6FBF100", VA = "0x186FC0700")]
	internal static byte[] OJMMMEGECCM(byte[] KKELJOOMKNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0680", Offset = "0x6FBF080", VA = "0x186FC0680")]
	public static void KHBGHKLEIOK(Stream JCEJDGECCCO, byte[] ENJLCNPCMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC04A0", Offset = "0x6FBEEA0", VA = "0x186FC04A0")]
	public static bool DAIAKPMMHDL(Stream JCEJDGECCCO, long MJBHCHPBJFD, ABIGFPJHIDG ILPLJCJHOLO, [Out] byte[] BJOCGMKLCJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
internal sealed class PEMLJCOONKB : OPHHGBFNKCM, IEquatable<OPHHGBFNKCM>, IEquatable<PEMLJCOONKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000704")]
	private readonly FLBKOBFDOHD GCNEHBJOKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000705")]
	public readonly FileInfo NGIKJNPKEKA;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public BEJGFBOIEHJ HCCJOEGEHAC
	{
		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x698F260", Offset = "0x698DC60", VA = "0x18698F260", Slot = "9")]
		get
		{
			return default(BEJGFBOIEHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public DateTime LJDMFDOKKND
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2BA0", Offset = "0x6FC15A0", VA = "0x186FC2BA0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2CE0", Offset = "0x6FC16E0", VA = "0x186FC2CE0")]
	public PEMLJCOONKB(FLBKOBFDOHD HKLNLCLMLOE, FileInfo NGOABKBLFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2C30", Offset = "0x6FC1630", VA = "0x186FC2C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2780", Offset = "0x6FC1180", VA = "0x186FC2780", Slot = "5")]
	public void AMAGAKCHGJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2B60", Offset = "0x6FC1560", VA = "0x186FC2B60", Slot = "6")]
	public bool KGHIIOACPPE(long ONILLAPMLEN, long KOIDPPGJKOA, [Out] POAAKMMADBH FPIGOBMKHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2900", Offset = "0x6FC1300", VA = "0x186FC2900", Slot = "7")]
	public bool Equals(OPHHGBFNKCM HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2840", Offset = "0x6FC1240", VA = "0x186FC2840", Slot = "8")]
	public bool Equals(PEMLJCOONKB HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x6FC29E0", Offset = "0x6FC13E0", VA = "0x186FC29E0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2AD0", Offset = "0x6FC14D0", VA = "0x186FC2AD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
public delegate void ABIGFPJHIDG(BFJKPDDFECG.PBPDMFOPLCB LFECLJNKDBN, string BDCMABOIIFF);
[Cpp2IlInjected.Token(Token = "0x20001A7")]
internal interface ABGJLKIBOAA
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	BEJGFBOIEHJ HCCJOEGEHAC
	{
		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ONHMAFPNJJL(long ONILLAPMLEN, long KOIDPPGJKOA, MFIOOOIMKCN JHBPEHBAAIE, [Out] OPHHGBFNKCM CFEFPIPMPFL);

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<OPHHGBFNKCM> NKCCGGMBDNG(MFIOOOIMKCN JHBPEHBAAIE);

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OPHHGBFNKCM FNBEJKLKPDN(long ONILLAPMLEN, long KOIDPPGJKOA, POAAKMMADBH FPIGOBMKHAC, MFIOOOIMKCN JHBPEHBAAIE);
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
