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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
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
		[Cpp2IlInjected.Address(RVA = "0x6258930", Offset = "0x6257D30", VA = "0x186258930")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
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
		[Cpp2IlInjected.Address(RVA = "0x78E340", Offset = "0x78D740", VA = "0x18078E340")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NPLLJMOOGMA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62588C0", Offset = "0x6257CC0", VA = "0x1862588C0")]
	public NPLLJMOOGMA(string LMJAPBNMKLG, Exception NOOMHHHENMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class CBNINGBEGIM : MMHGDKIMDJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct LIDLMGJBPHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<HDMEAOOCBIO>> <>t__builder;

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
		private TaskAwaiter<NOLBEJDJBOL<HDMEAOOCBIO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6254400", Offset = "0x6253800", VA = "0x186254400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6254640", Offset = "0x6253A40", VA = "0x186254640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IGAEILPJEKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MJBKGPKHEIH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<MJBKGPKHEIH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x624E920", Offset = "0x624DD20", VA = "0x18624E920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x624EB30", Offset = "0x624DF30", VA = "0x18624EB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	[UnityEngine.Scripting.Preserve]
	public CBNINGBEGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6244590", Offset = "0x6243990", VA = "0x186244590", Slot = "4")]
	[AsyncStateMachine(typeof(LIDLMGJBPHN))]
	public Task<IReadOnlyList<HDMEAOOCBIO>> MENBCFLBOPC(long BLPLCJENHDJ, long PINPACMDEDH, [Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6244480", Offset = "0x6243880", VA = "0x186244480", Slot = "5")]
	[AsyncStateMachine(typeof(IGAEILPJEKN))]
	public Task<IReadOnlyList<MJBKGPKHEIH>> COJPHOFINAL(IReadOnlyList<int> IFPDCKLEIMP, [Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JMOJECAJKFB : IEquatable<JMOJECAJKFB>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int KKNECKLNFEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	MJBKGPKHEIH BIFFPMBPELA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime KGGIINJLPKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	EPKMJFMGJBP? PPFNPAGGGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	JBHFEHGPAMJ? GICPJFHLEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	AIMBBHKKHIN JHDLPACNIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<KLJJBFIAHEC> KCPLKADGMGG();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum AIMBBHKKHIN
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MMHGDKIMDJP
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<HDMEAOOCBIO>> MENBCFLBOPC(long BLPLCJENHDJ, long PINPACMDEDH, [Optional] CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<MJBKGPKHEIH>> COJPHOFINAL(IReadOnlyList<int> IFPDCKLEIMP, [Optional] CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PGDMGOCJFKN
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class EIMMPKAGGKM : JMOJECAJKFB, IEquatable<JMOJECAJKFB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct JHCFLGILEHE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<KLJJBFIAHEC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public EIMMPKAGGKM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private FOKOCMKDEGN <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<FDKPOLPBLFH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<KLJJBFIAHEC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6250B20", Offset = "0x624FF20", VA = "0x186250B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6250FC0", Offset = "0x62503C0", VA = "0x186250FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HDMEAOOCBIO KJJGNPKOIIN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int KKNECKLNFEN
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x765400", Offset = "0x764800", VA = "0x180765400", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MJBKGPKHEIH BIFFPMBPELA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime LJEJFIBIAGC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8BAD20", Offset = "0x8BA120", VA = "0x1808BAD20", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EPKMJFMGJBP? PPFNPAGGGPF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x17A3820", Offset = "0x17A2C20", VA = "0x1817A3820", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public JBHFEHGPAMJ? GICPJFHLEAK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1F397C0", Offset = "0x1F38BC0", VA = "0x181F397C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AIMBBHKKHIN JHDLPACNIPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8015E0", Offset = "0x8009E0", VA = "0x1808015E0", Slot = "10")]
			get
			{
				return default(AIMBBHKKHIN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x624AEB0", Offset = "0x624A2B0", VA = "0x18624AEB0", Slot = "9")]
		[AsyncStateMachine(typeof(JHCFLGILEHE))]
		public Task<KLJJBFIAHEC> KCPLKADGMGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x624AFF0", Offset = "0x624A3F0", VA = "0x18624AFF0")]
		public EIMMPKAGGKM(int PLFPGCFLGGL, MJBKGPKHEIH ELIJNJDGMKB, HDMEAOOCBIO KJJGNPKOIIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x624AD00", Offset = "0x624A100", VA = "0x18624AD00", Slot = "11")]
		public bool Equals(JMOJECAJKFB KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x624AD90", Offset = "0x624A190", VA = "0x18624AD90", Slot = "0")]
		public override bool Equals(object IBBNLILJNEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x624AFB0", Offset = "0x624A3B0", VA = "0x18624AFB0")]
		private bool LKNLIJKGMAC(EIMMPKAGGKM KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x624AE30", Offset = "0x624A230", VA = "0x18624AE30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class COGEDKDKCNF : JMOJECAJKFB, IEquatable<JMOJECAJKFB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct KKIMCGMHFBB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<KLJJBFIAHEC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public COGEDKDKCNF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<KLJJBFIAHEC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6251EE0", Offset = "0x62512E0", VA = "0x186251EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6252110", Offset = "0x6251510", VA = "0x186252110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly BJHHJKOCPBD GMEDBMOBMDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly EPKMJFMGJBP BPHEMBGNCAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly JBHFEHGPAMJ NEAEDBIOFMI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int KKNECKLNFEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6244EB0", Offset = "0x62442B0", VA = "0x186244EB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MJBKGPKHEIH BIFFPMBPELA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6245090", Offset = "0x6244490", VA = "0x186245090", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime LJEJFIBIAGC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6244E60", Offset = "0x6244260", VA = "0x186244E60", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EPKMJFMGJBP? PPFNPAGGGPF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x62452F0", Offset = "0x62446F0", VA = "0x1862452F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public JBHFEHGPAMJ? GICPJFHLEAK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6244EF0", Offset = "0x62442F0", VA = "0x186244EF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AIMBBHKKHIN JHDLPACNIPO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA0AE30", Offset = "0xA0A230", VA = "0x180A0AE30", Slot = "10")]
			get
			{
				return default(AIMBBHKKHIN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD30990", Offset = "0xD2FD90", VA = "0x180D30990")]
		public COGEDKDKCNF(BJHHJKOCPBD IFNJMAAKBKN, EPKMJFMGJBP LMONNOKEFGM, JBHFEHGPAMJ KEFBJGGLKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x62451A0", Offset = "0x62445A0", VA = "0x1862451A0", Slot = "9")]
		[AsyncStateMachine(typeof(KKIMCGMHFBB))]
		public Task<KLJJBFIAHEC> KCPLKADGMGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6244FF0", Offset = "0x62443F0", VA = "0x186244FF0", Slot = "11")]
		public bool Equals(JMOJECAJKFB KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6244F40", Offset = "0x6244340", VA = "0x186244F40", Slot = "0")]
		public override bool Equals(object IBBNLILJNEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6245290", Offset = "0x6244690", VA = "0x186245290")]
		private bool LKNLIJKGMAC(COGEDKDKCNF KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6245120", Offset = "0x6244520", VA = "0x186245120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class EEGLMHNPAPD : JMOJECAJKFB, IEquatable<JMOJECAJKFB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct LKEOEDNDCOK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<KLJJBFIAHEC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<KLJJBFIAHEC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6254CB0", Offset = "0x62540B0", VA = "0x186254CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6254EF0", Offset = "0x62542F0", VA = "0x186254EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly MJBKGPKHEIH NIFKONMAGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly EPKMJFMGJBP BPHEMBGNCAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly JBHFEHGPAMJ NEAEDBIOFMI;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int KKNECKLNFEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x624A840", Offset = "0x6249C40", VA = "0x18624A840", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public MJBKGPKHEIH BIFFPMBPELA
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime LJEJFIBIAGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public EPKMJFMGJBP? PPFNPAGGGPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x624ACB0", Offset = "0x624A0B0", VA = "0x18624ACB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public JBHFEHGPAMJ? GICPJFHLEAK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x624A8C0", Offset = "0x6249CC0", VA = "0x18624A8C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public AIMBBHKKHIN JHDLPACNIPO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "10")]
			get
			{
				return default(AIMBBHKKHIN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD30990", Offset = "0xD2FD90", VA = "0x180D30990")]
		public EEGLMHNPAPD(MJBKGPKHEIH ELIJNJDGMKB, EPKMJFMGJBP LMONNOKEFGM, JBHFEHGPAMJ KEFBJGGLKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x624AAB0", Offset = "0x6249EB0", VA = "0x18624AAB0", Slot = "9")]
		[AsyncStateMachine(typeof(LKEOEDNDCOK))]
		public Task<KLJJBFIAHEC> KCPLKADGMGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x624A990", Offset = "0x6249D90", VA = "0x18624A990", Slot = "11")]
		public bool Equals(JMOJECAJKFB KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x624A910", Offset = "0x6249D10", VA = "0x18624A910", Slot = "0")]
		public override bool Equals(object IBBNLILJNEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x624AA00", Offset = "0x6249E00", VA = "0x18624AA00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x624AB80", Offset = "0x6249F80", VA = "0x18624AB80")]
		private bool LKNLIJKGMAC(EEGLMHNPAPD KEEHOGPOIFD)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct BMGEJEIDKMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<JMOJECAJKFB>> <>t__builder;

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
		public PGDMGOCJFKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<HDMEAOOCBIO> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<HDMEAOOCBIO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, MJBKGPKHEIH account, HDMEAOOCBIO roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6242E90", Offset = "0x6242290", VA = "0x186242E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6243C70", Offset = "0x6243070", VA = "0x186243C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct EAIBNKNALJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, MJBKGPKHEIH account, HDMEAOOCBIO roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<HDMEAOOCBIO> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public PGDMGOCJFKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<MJBKGPKHEIH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6245E60", Offset = "0x6245260", VA = "0x186245E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x62468A0", Offset = "0x6245CA0", VA = "0x1862468A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MGLLBPIMJHF FOLDMOBICJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MMHGDKIMDJP BKNFEGCHBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NMPPFLAPGBK FCLCGLPEBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly GBCLKJPHEGN<(long, long), IReadOnlyList<HDMEAOOCBIO>> HBIHLOKHPLO;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62590F0", Offset = "0x62584F0", VA = "0x1862590F0")]
	[UnityEngine.Scripting.Preserve]
	public PGDMGOCJFKN([LMAFJMDCBJO(null)] MMHGDKIMDJP DNJJHDLFPHK, [LMAFJMDCBJO(null)] NMPPFLAPGBK HNCCALIPDMI, [LMAFJMDCBJO(null)] MGLLBPIMJHF DGLGPOCLLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6258CF0", Offset = "0x62580F0", VA = "0x186258CF0")]
	[AsyncStateMachine(typeof(BMGEJEIDKMF))]
	public Task<IList<JMOJECAJKFB>> ANHNJGEJKOJ(long BLPLCJENHDJ, long CAHHMNIGLJL, bool EMHNGMIHOPO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6258F50", Offset = "0x6258350", VA = "0x186258F50")]
	private bool HKCAFMEPJEL(DateTime? MOAKMAELHDG, long BLPLCJENHDJ, long CAHHMNIGLJL, [Out] BJHHJKOCPBD CIOPFHLILOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6258E40", Offset = "0x6258240", VA = "0x186258E40")]
	[AsyncStateMachine(typeof(EAIBNKNALJN))]
	private Task<IReadOnlyList<(int, MJBKGPKHEIH, HDMEAOOCBIO)>> GOFIAMJGLGB(IReadOnlyList<HDMEAOOCBIO> KKCNMADHGFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NMPPFLAPGBK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<BJHHJKOCPBD> EMFOCNGKLMA;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LDKKECNLJKC(long BLPLCJENHDJ, long CAHHMNIGLJL, BLOPIEONCGA BNLKEIJBFNK, ANDGBBKHDNM CNBEKNILNAO);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PALDBENLOMO(long BLPLCJENHDJ, long CAHHMNIGLJL, [Out] BJHHJKOCPBD CIOPFHLILOL);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MHNNIDONKCP(long BLPLCJENHDJ, long CAHHMNIGLJL, ANDGBBKHDNM CNBEKNILNAO, [Out] BJHHJKOCPBD CIOPFHLILOL);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMICJDKNJMA(long BLPLCJENHDJ, long CAHHMNIGLJL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface JLKCNOPLBDB : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HIFDOFLJIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task AEJGOCHPOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AJMAALPDPIL(Task DJNEDNIILKC, string CPBLGOKGJLK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface AGJJPDEKINC : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KLJJBFIAHEC> ICCJJPKLJOA(BJHHJKOCPBD CIOPFHLILOL);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PLIJNPLNGGF(CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface CGFOCHHGACM : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CGKFPLEFIDK JMEKLGFFDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAJIKLAKKLE();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKEAHNJMCFM();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface EIAHCHMNJNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface IHDPFKHBMBC
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan JGPEEMHOKKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan NNNJNKEAMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan HKFMBHMFKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan FCBFMJOHCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NLECKIOCAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FEDFDONMOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DOGDDPGIDHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int PFDFLNNFMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool MMMLCJINFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum IEFJKODNEBO
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum BAIOELEICOL
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
public struct DDKHGNOFKCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long LDECBGPODEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long PINPACMDEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly IEFJKODNEBO DJMKKNDNCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception HNBPEGIIAEA;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6245390", Offset = "0x6244790", VA = "0x186245390")]
	public DDKHGNOFKCA(long LDECBGPODEE, long PINPACMDEDH, IEFJKODNEBO DJMKKNDNCBM, [CanBeNull] Exception HNBPEGIIAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6245340", Offset = "0x6244740", VA = "0x186245340")]
	public static DDKHGNOFKCA MHFBJFFHDKD(BDKFBCEFMIP KDIOGGCJKMI, IEFJKODNEBO DJMKKNDNCBM, [Optional] Exception HNBPEGIIAEA)
	{
		return default(DDKHGNOFKCA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void DANNLOHPOAC(DDKHGNOFKCA LDCLGCFOCKH);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface JDAGMEDBEOP : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GHHBHLAPKCN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event DANNLOHPOAC OJDHKGPBOFO;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event DANNLOHPOAC FLHGDEIHLHI;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event DANNLOHPOAC CMPFEMDFJOJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<BAIOELEICOL, bool> BHPEPOMEAFK;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DJPDCCOFOBG();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PCGANMDNEEK(DDKHGNOFKCA LDCLGCFOCKH);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NMFEIJEGONP(DDKHGNOFKCA LDCLGCFOCKH);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BEBGIIGNFKF(DDKHGNOFKCA LDCLGCFOCKH);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JNKNFIPHCBB(BAIOELEICOL EGJBIIEJEOI, bool OLAMLOCNCJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface PJADLBKLPBG : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task APLEGOHOINI();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGIOFLCFCIH();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface GOHDAHNCEBE : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	TaskStatus KIBGINHAEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ONOGKBKLFNL(BDKFBCEFMIP DNLDHEDCLAM, AONGELAAJMM IPDAHDOFOCL, CancellationToken CKCHEDNFLJC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal static class GGEHJKFKJEE
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x624BC10", Offset = "0x624B010", VA = "0x18624BC10")]
	public static bool LGOHCMOOJPL(this GOHDAHNCEBE JKLMJJBOHML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public delegate Task KALGNJFILHN(OKOIPJPAMDA NDJHINJFLAD, CancellationToken IBLOMPOENGH);
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface LMCCFNCOEKH : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OHGEONNPNHA(KALGNJFILHN KJNPEAJJAPN);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface FGMCJCFGAPG : FOKOCMKDEGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	CancellationToken OHJFMBJJMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	BFGBHKPNKEI BGKKJADIOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	IBLKHHFCHMM EOAIEANLOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	FDNFIBJMANG GEMBCHNKGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CHMLDJDCJFC JIBKILINHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	GLIHBPDBOBH ELJDEDBLPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NEAGOFNAEJH CEKNJNAEPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	LMGMKFINJJP LKMGENKEAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	OKADPHKNNFI DMNOFKNDHEG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JLKCNOPLBDB HGHCKBODEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	AGJJPDEKINC NLBJBDNGFHL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	JDAGMEDBEOP GIOJBPCBJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	PJADLBKLPBG CDAIGLHLFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	GOHDAHNCEBE JOFFGKJNMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	LMCCFNCOEKH KGDFAMCLBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JCCDJMCNDFD IIKJEDJOKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	KFPPMIJFDDH IJAGDANDPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OBLLOKNJDCG BBMLIFJNOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	AKGKACKHBAH FDJLMFDDHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	BEBAGOEJLNM KEKEPNBMBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IJECOICGHPC LEELFFOCMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OGFJBPHFJEB NBEICOAPBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	KBICEBOFMAL NIADAHCEBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	HICAKEDDGPG DLIJBNOAKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	ILDFOCCEHCO NGHHDMDGIJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	CGFOCHHGACM MEFEJNCCJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	IHDPFKHBMBC NEOJJNKICLF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	HKEFIKEPBGG EDPCCHCMLGA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NMPPFLAPGBK EICCMHGIKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AEEOCELCEBG CLOBAPGFCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EFMGDAKFBAE HLCOBPPOPNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void NBNJNALDELN(AONGELAAJMM CCMNHCKIGON);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface JCCDJMCNDFD : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PIGAAPDDGPE GIHKKMKIIOJ(Guid CEMPKOIGLIO);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HFJFDMFKDND(Guid CEMPKOIGLIO);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AIIJHGEPFCI(Guid CEMPKOIGLIO, Task NLMOJCNFHEA);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool POFLLEMAKDN(Guid CEMPKOIGLIO, KLJJBFIAHEC BHIBDKILKNB);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(KLJJBFIAHEC, Task)> KOHHAMJECBB(Guid CEMPKOIGLIO);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface HEBIEGDBEAD : EIAHCHMNJNI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface KFPPMIJFDDH : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKOKNAKCJJN(OCJBGBEKDGN LMJAPBNMKLG);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOEEPFMBAON(OCJBGBEKDGN LMJAPBNMKLG);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<BNGAGHFEKJK> IHKDDKFAOEJ(CancellationToken PMHPJKLOCAO);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface OBLLOKNJDCG : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PIGAAPDDGPE IEFOPAGOBCP(OCJBGBEKDGN BBKFPLEPCAN);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEDFEKLKCAN(Guid CEMPKOIGLIO, Task NLMOJCNFHEA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface AKGKACKHBAH : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KLJJBFIAHEC> FDJLMFDDHMJ(OCJBGBEKDGN ABMIABCDNMK);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface BEBAGOEJLNM : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABMIDKAKKGN> BHHHPNDNNBA(KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, BDKFBCEFMIP DNLDHEDCLAM, CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface OGFJBPHFJEB : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLJJBFIAHEC GEAJPMDLFLD(KEMOGAOMDFA LFELICAKALB);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FNCCHDEPNGK(string EOEPLCPMJAO);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface IJECOICGHPC : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OCJBGBEKDGN> FLPPLMIJHHL(OCJBGBEKDGN EJJHDDFDLOL, EMNADKEEBNM ADHOLEIKFEH, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OCJBGBEKDGN> PBJCOPNEFOD(CancellationToken OMFABMCIOAC, EMNADKEEBNM ADHOLEIKFEH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HNIKGGHLOAK BLMNOBGJOOF(KHKLNHABCFF HGMMLGNGDDH, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HNIKGGHLOAK BGKPEKLIEAC(KHKLNHABCFF HGMMLGNGDDH, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface KBICEBOFMAL : EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLJJBFIAHEC HDAEAGEAACH(KEMOGAOMDFA LFELICAKALB, BNGAGHFEKJK FCOLEJMPJKO);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KLJJBFIAHEC AKNPMLJEAOI(KEMOGAOMDFA DJEGLCKHILF);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface HICAKEDDGPG
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LAKBJJKNDPA(KEGBDCDGPPF JIFOJGCDHPP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFMCFBHDAJF(KEGBDCDGPPF JIFOJGCDHPP);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHHLGDOPPEL(KEGBDCDGPPF JIFOJGCDHPP);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OLJKFEPPIHO(KEGBDCDGPPF JIFOJGCDHPP);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class KEGBDCDGPPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly BDKFBCEFMIP NIEGCGBJMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> MCBOCJJPEPE;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public KGKDBPAMFIO<string> GKLBOANCLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x764500", VA = "0x180765100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	public KEGBDCDGPPF(BDKFBCEFMIP AMBGDFJLCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6251D80", Offset = "0x6251180", VA = "0x186251D80")]
	public KEGBDCDGPPF DGAFFBAEPHG(string IHHOPACLNAK, string LPCGJALKADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6251E50", Offset = "0x6251250", VA = "0x186251E50")]
	public bool ODOGNOFFBNN([Out] IEnumerable<KeyValuePair<string, string>> JLJAINGGBEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x56AF400", Offset = "0x56AE800", VA = "0x1856AF400")]
	public KEGBDCDGPPF BEDKINGGAKO(KGKDBPAMFIO<string> LHJMFKIBCKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface HKEFIKEPBGG
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool KJKNEMBCJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	string IHPAAIIKIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FEGHJJBPDHE();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GHELNDHPLBF CKGMGLLNNKA(long EBLCIIMJECI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ICANMBKACPH<IGNOFONIPFC, CMFAAJONIFD> JMKGPKGOGEK(long EBLCIIMJECI);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ICANMBKACPH<IGNOFONIPFC, KAIKLPKIAEH> JJIIMFOOMGK(long EBLCIIMJECI);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ICANMBKACPH<long, NDFHPLNPLMM> NHHPEMOMEAI();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> HJMIJHHIAPG(byte[] ILOGCLKGEMA, byte[] DHAFNCNBMBA, CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface FOKOCMKDEGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool LGOHCMOOJPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool HKHJFGEPHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	AONGELAAJMM EJEPMOHPIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action GHHBHLAPKCN;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event DANNLOHPOAC OJDHKGPBOFO;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event DANNLOHPOAC FLHGDEIHLHI;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event DANNLOHPOAC CMPFEMDFJOJ;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<BAIOELEICOL, bool> BHPEPOMEAFK;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IGIOFLCFCIH();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FKIJPOFAOED AKBACPHFHHN();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	BFAAFEKANMA KBELLIHELAE();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<KLJJBFIAHEC> ICCJJPKLJOA(BJHHJKOCPBD IFNJMAAKBKN);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task PLIJNPLNGGF(CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface GLIHBPDBOBH
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool ILHGKLALHKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string ABEPGJNCPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFHKIPAINNC(Scene PKHNMFFNHAD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PBAHENKDMLO(KCHJPABMKIM BOKOKOCAEEE, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PFFGKGMCGGC();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CHMLDJDCJFC
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	EAKNENHMOPB DHPIDOBBJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool AHFPPJCBIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool DKDKBCACJAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool KJLILNBMJBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool IFDEAMEIGCI
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool GGCDBHIKEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool LGAJFECOMFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float NEHMDILPODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> ILEAMPDMNKH;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BFGBHKPNKEI KKICBOPIAKM(BFGBHKPNKEI FMGMKMDJHPG);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PNEPOMGJOAK(BFGBHKPNKEI MIPCMNILFEO);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KIDJNBCIOAD();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task NLOOMIIIKOE(KGKDBPAMFIO<string>.HDBHKIOKMPF GAAEOIEEFAE, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PCMDPHOMBFF(float MFOKJACCBFB);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BPJDLHHPNHE(string BJCOOPFBLAC);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<IHFCDNDDOME> PIFDIHGNIFM();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable HNAPFCDLEBP(object CNKGFJIJGPA, IHFCDNDDOME MDNGPGHLBBO);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CMFAAJONIFD HDOLKADPMGJ(IEnumerable<DAJJDHFICPI> LEEIOGKJPKL);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KEKANJBCMCB(int ELKEEAHOLKC);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task KKAFHAMBLMG();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PCCPFGCBEBC();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool ELNOPHNBLHB();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task FJLEMIGHGDL(CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task DMGOEGHKOIH(CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<HIIBGFBFAID> EDPMPFEJINB(DateTime BNODADIAOJI, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<bool> FECBANGJMBH(CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BBLNDAHCILP(string LKDIKKEICGO = "", float DGGLMJANNMD = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	JDCLMKKKNDO AFKDOPDHNNL(KJGPAHOKGPF MJLMKKAJKEC, NHCLIMEGHJE KGMDBFCGIOH, KAIKLPKIAEH EAAJIENBCOL, IEnumerable<PersistenceView> LGLNEABPCOD, AFOPDHFCNEP ONKGGJNCDKC);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EABNAHLPIMM(KAIKLPKIAEH EAAJIENBCOL);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OLLPCDHAAMF(DAJJDHFICPI JINLJHLPIMH, [In] JDCLMKKKNDO FCPFLJOBOCA);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task GBJPOEMFOED(KAIKLPKIAEH BCCEKGGHAFC, bool NAGADMNOCPC, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task JLAJEOGAJDL(CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KHFGLBNIJHG(long BLPLCJENHDJ, long PINPACMDEDH, FDKPOLPBLFH JNPLJPLJGKA, HDMEAOOCBIO HNKELMCDPBK, BLOPIEONCGA BNLKEIJBFNK, NNDEIDFMMBL? PEMMFKFLKEL, IDBGIKDPAIG? ODHKJNFLHPH);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ILBCDKKBGMN(long BLPLCJENHDJ, long PINPACMDEDH, IDBGIKDPAIG? ODHKJNFLHPH);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JNIBBLDMCHH(PersistenceView GDBLGMBMLOH);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool LPBAJBIDGLK(PersistenceView MBDMIIMHHNK);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool ILJBBIDMLGO(DAJJDHFICPI JINLJHLPIMH, DAACELPKEHI PNGFHHEKPJA, [Out] DIDBMPMOKJC JJIDPIBGGNM);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task GKLFLBJEDIN(CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void BGGMAJMBAJN();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IDisposable OIMKKNHFLMG();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void INBEFNHJBPA(KAIKLPKIAEH BCCEKGGHAFC, DAACELPKEHI PNGFHHEKPJA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<bool> OADMHLOIAAC(IBLKHHFCHMM FOEGMELFMCF, CancellationToken OMFABMCIOAC, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void JMEGDNDBBHJ(CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<EOMDJPDNCEE> JOCGPADJHDE(OLHLNCLAKDF EJJHDDFDLOL);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<FDKPOLPBLFH> CAMFFLACDPC(long BLPLCJENHDJ, bool ADGNECLKIBB, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<HDMEAOOCBIO> AAKDNDGFLHC(long BLPLCJENHDJ, long PINPACMDEDH, long DHIEKGKANNH, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<OGMJBCAALDL> LIBAAGLPPLI(string FNOFHHIOKHC, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<OGMJBCAALDL> HHBFIBIBBMG(string FNOFHHIOKHC, long BLPLCJENHDJ, long PINPACMDEDH, string ACDLOAEPCEG, JDLHPELPAPJ.HAFFLOGODNJ NDJHINJFLAD, JDLHPELPAPJ.HAFFLOGODNJ DHAFNCNBMBA, int NFJKFKHHGIB);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool BNLMMOMLCLE();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool GEOKOGGBHHF();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool FLIDPONLJDA(IEnumerable<DIDBMPMOKJC> MLJKDHBPAEC);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void JOAABCBOAJM(List<GameObject> HHOLNEGKEPE);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float ANBDHJNBCCF();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<Scene> JEONKIKCOLH(string GJEIIMEENIK, LoadSceneMode ANBCIDAMIIM, bool OEHLEEEPFHF, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void DFAFHEDHMLC();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void DEICEPJKFDL(bool GGJLDJABGMP);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void OMEIKHJIHLG(BDKFBCEFMIP IPPDJPKCJOH);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "58")]
	Task GLOPGDBLAGP(KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task ABLGIEDJDGH(KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task EGGPNIOAPBF(KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "61")]
	IDisposable NNMDEHLDHLE();

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "62")]
	FFNBMNKKACB PANLPNPAFMO();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task CAJBIOLHHDF(CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FFNBMNKKACB
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JPIPBPCEDEH(CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PHDDJAAIEMB(CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct JDCLMKKKNDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> BPMPEMGBGMD;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum HIIBGFBFAID : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct KJGPAHOKGPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string DLNJECCIOMN;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface EAKNENHMOPB
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	BDKFBCEFMIP OCCMLAJCKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	FDKPOLPBLFH ALBJAADNBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	DFEHFHGPFLB CENHFAGHMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool HEKDJCIAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool HNAGJLHJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int MILJIHLPCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action KJNCNLDIDBI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> LMDELCJKGCG;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HAAGIJGMPLK();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.BMLABNOFELP> PHPCNLMALGB(long EBLCIIMJECI, [Optional] CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.AKJKLIOHEKN> PGCEMMOKOJG();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task BABBBHONPCO();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(BDKFBCEFMIP, AONGELAAJMM) EPJEIOGMMBL();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BDPINNBKCPB DLHPHLAJGDL();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GJBBAJENCAN(long EBLCIIMJECI);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface ILDFOCCEHCO
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEINCBPPILP([Out] IEnumerable<int> LHKJILJEJJA);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBGLHFIDHGM(NHAKFPLMIPB IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLPPLCCGPOJ(NHAKFPLMIPB IBLOMPOENGH);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface OGDMDKHDDJB
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FBBGFDNANDI(KLJJBFIAHEC HMBGGNACLEA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KKMLMHIMDCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPPEOMDHEAC(IJDGBEDBJBE.IMHODCGEFJM KAAHNMFFFEP);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGMIFKBEJAN(IJDGBEDBJBE.IMHODCGEFJM KAAHNMFFFEP);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface NEAGOFNAEJH : KKMLMHIMDCA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLJJBFIAHEC OCHNKCOMIFK(KEMOGAOMDFA DJEGLCKHILF);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface LMGMKFINJJP : KKMLMHIMDCA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLJJBFIAHEC GEAJPMDLFLD(KEMOGAOMDFA ENPJGNCLGBK);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GHELNDHPLBF
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MEEAMGFNJIM<KCHJPABMKIM, PGBNOEKHDBP>> JIBNKMJIKND(string ACDLOAEPCEG, long EBLCIIMJECI, AOIDJKEPFOF.PEMLCFAHAFJ CMOHMLHFLNA, CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface ICANMBKACPH<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MEEAMGFNJIM<byte[], PGBNOEKHDBP>> ODBPGPKFACB(TGetDataArg LIFDGOACBCI, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MEEAMGFNJIM<CAHCBJHECPF<TData>, PGBNOEKHDBP> OAONMFBFODF(byte[] OOIBMCBCEPD);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class BAPFCOEHDAC : FGMCJCFGAPG, FOKOCMKDEGN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct IADJOHMPDFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<KLJJBFIAHEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public BAPFCOEHDAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public BJHHJKOCPBD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<KLJJBFIAHEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x624E460", Offset = "0x624D860", VA = "0x18624E460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x624E6E0", Offset = "0x624DAE0", VA = "0x18624E6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct EDNGDNFOCLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public BAPFCOEHDAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6246A80", Offset = "0x6245E80", VA = "0x186246A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6246CB0", Offset = "0x62460B0", VA = "0x186246CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class LIAKJBEKKFE : IEnumerable<EIAHCHMNJNI>, IEnumerable, IEnumerator<EIAHCHMNJNI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private EIAHCHMNJNI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public BAPFCOEHDAC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private EIAHCHMNJNI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public LIAKJBEKKFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6253F50", Offset = "0x6253350", VA = "0x186253F50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x62543B0", Offset = "0x62537B0", VA = "0x1862543B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6254300", Offset = "0x6253700", VA = "0x186254300", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EIAHCHMNJNI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6254300", Offset = "0x6253700", VA = "0x186254300", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource EGFJGPLKLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly BFGBHKPNKEI MIPCMNILFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private DHEEHIGHIPJ FNAAJHHMDBK;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public IBLKHHFCHMM EOAIEANLOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7653E0", Offset = "0x7647E0", VA = "0x1807653E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x765460", Offset = "0x764860", VA = "0x180765460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public FDNFIBJMANG GEMBCHNKGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x766620", Offset = "0x765A20", VA = "0x180766620", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x766630", Offset = "0x765A30", VA = "0x180766630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public CHMLDJDCJFC JIBKILINHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x766610", Offset = "0x765A10", VA = "0x180766610", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7665E0", Offset = "0x7659E0", VA = "0x1807665E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GLIHBPDBOBH ELJDEDBLPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7665F0", Offset = "0x7659F0", VA = "0x1807665F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x766600", Offset = "0x765A00", VA = "0x180766600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public NEAGOFNAEJH CEKNJNAEPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7665C0", Offset = "0x7659C0", VA = "0x1807665C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7665D0", Offset = "0x7659D0", VA = "0x1807665D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public LMGMKFINJJP LKMGENKEAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7699F0", Offset = "0x768DF0", VA = "0x1807699F0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x769A00", Offset = "0x768E00", VA = "0x180769A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public OKADPHKNNFI DMNOFKNDHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7653B0", Offset = "0x7647B0", VA = "0x1807653B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7654B0", Offset = "0x7648B0", VA = "0x1807654B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public JLKCNOPLBDB HGHCKBODEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x765410", Offset = "0x764810", VA = "0x180765410", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7653D0", Offset = "0x7647D0", VA = "0x1807653D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public AGJJPDEKINC NLBJBDNGFHL
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7654E0", Offset = "0x7648E0", VA = "0x1807654E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x765380", Offset = "0x764780", VA = "0x180765380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public JDAGMEDBEOP GIOJBPCBJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x80AA90", Offset = "0x809E90", VA = "0x18080AA90", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x80AB70", Offset = "0x809F70", VA = "0x18080AB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public PJADLBKLPBG CDAIGLHLFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7653F0", Offset = "0x7647F0", VA = "0x1807653F0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x765420", Offset = "0x764820", VA = "0x180765420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public GOHDAHNCEBE JOFFGKJNMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8877D0", Offset = "0x886BD0", VA = "0x1808877D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x886C40", Offset = "0x886040", VA = "0x180886C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public LMCCFNCOEKH KGDFAMCLBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x769120", Offset = "0x768520", VA = "0x180769120", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x769130", Offset = "0x768530", VA = "0x180769130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public JCCDJMCNDFD IIKJEDJOKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x824280", Offset = "0x823680", VA = "0x180824280", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x89BD00", Offset = "0x89B100", VA = "0x18089BD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public HEBIEGDBEAD CHKENHCEHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x89BB30", Offset = "0x89AF30", VA = "0x18089BB30", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x89BDC0", Offset = "0x89B1C0", VA = "0x18089BDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public KFPPMIJFDDH IJAGDANDPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x89BB00", Offset = "0x89AF00", VA = "0x18089BB00", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x89BD60", Offset = "0x89B160", VA = "0x18089BD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public OBLLOKNJDCG BBMLIFJNOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F50", Offset = "0x7F6350", VA = "0x1807F6F50", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x89BDE0", Offset = "0x89B1E0", VA = "0x18089BDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public AKGKACKHBAH FDJLMFDDHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x89BB10", Offset = "0x89AF10", VA = "0x18089BB10", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x89BD80", Offset = "0x89B180", VA = "0x18089BD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public BEBAGOEJLNM KEKEPNBMBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7690D0", Offset = "0x7684D0", VA = "0x1807690D0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x769100", Offset = "0x768500", VA = "0x180769100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IJECOICGHPC LEELFFOCMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7F7BF0", Offset = "0x7F6FF0", VA = "0x1807F7BF0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7F7C00", Offset = "0x7F7000", VA = "0x1807F7C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public OGFJBPHFJEB NBEICOAPBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x89BB40", Offset = "0x89AF40", VA = "0x18089BB40", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x89BE00", Offset = "0x89B200", VA = "0x18089BE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public KBICEBOFMAL NIADAHCEBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x89BB20", Offset = "0x89AF20", VA = "0x18089BB20", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x89BDA0", Offset = "0x89B1A0", VA = "0x18089BDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public HICAKEDDGPG DLIJBNOAKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x89BAF0", Offset = "0x89AEF0", VA = "0x18089BAF0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public ILDFOCCEHCO NGHHDMDGIJM
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x89BC40", Offset = "0x89B040", VA = "0x18089BC40", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x89C020", Offset = "0x89B420", VA = "0x18089C020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public CGFOCHHGACM MEFEJNCCJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x89BC20", Offset = "0x89B020", VA = "0x18089BC20", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x89BFE0", Offset = "0x89B3E0", VA = "0x18089BFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public IHDPFKHBMBC NEOJJNKICLF
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x89BBD0", Offset = "0x89AFD0", VA = "0x18089BBD0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x89BF20", Offset = "0x89B320", VA = "0x18089BF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public HKEFIKEPBGG EDPCCHCMLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x89BB90", Offset = "0x89AF90", VA = "0x18089BB90", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x89BEA0", Offset = "0x89B2A0", VA = "0x18089BEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public NMPPFLAPGBK EICCMHGIKDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x89BC30", Offset = "0x89B030", VA = "0x18089BC30", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public AEEOCELCEBG CLOBAPGFCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x89BAC0", Offset = "0x89AEC0", VA = "0x18089BAC0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public EFMGDAKFBAE HLCOBPPOPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x89BBF0", Offset = "0x89AFF0", VA = "0x18089BBF0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public AONGELAAJMM EJEPMOHPIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x89BBA0", Offset = "0x89AFA0", VA = "0x18089BBA0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x89BEC0", Offset = "0x89B2C0", VA = "0x18089BEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private bool LBFIJCAEDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x623B560", Offset = "0x623A960", VA = "0x18623B560", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private bool EIGNGGMECKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x623B9F0", Offset = "0x623ADF0", VA = "0x18623B9F0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private CancellationToken HCHMIGBHPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x623B970", Offset = "0x623AD70", VA = "0x18623B970", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private BFGBHKPNKEI ELMPKBJEPGD
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action NPGICHKKILB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x623B2B0", Offset = "0x623A6B0", VA = "0x18623B2B0", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x623B420", Offset = "0x623A820", VA = "0x18623B420", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event DANNLOHPOAC EEFGEABMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x623B820", Offset = "0x623AC20", VA = "0x18623B820", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x623B480", Offset = "0x623A880", VA = "0x18623B480", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event DANNLOHPOAC MAKDLEGFKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x623B7C0", Offset = "0x623ABC0", VA = "0x18623B7C0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x623B1C0", Offset = "0x623A5C0", VA = "0x18623B1C0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event DANNLOHPOAC ELEOIJDPLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x623B3C0", Offset = "0x623A7C0", VA = "0x18623B3C0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x623B760", Offset = "0x623AB60", VA = "0x18623B760", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<BAIOELEICOL, bool> BNMFGNFFJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x623BC10", Offset = "0x623B010", VA = "0x18623BC10", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x623B990", Offset = "0x623AD90", VA = "0x18623B990", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x89BEC0", Offset = "0x89B2C0", VA = "0x18089BEC0", Slot = "35")]
	public void NBNJNALDELN(AONGELAAJMM CCMNHCKIGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x623BD20", Offset = "0x623B120", VA = "0x18623BD20")]
	[UnityEngine.Scripting.Preserve]
	internal BAPFCOEHDAC([LMAFJMDCBJO(null)] BFGBHKPNKEI MIPCMNILFEO, [LMAFJMDCBJO(null)] IBLKHHFCHMM FOEGMELFMCF, [LMAFJMDCBJO(null)] FDNFIBJMANG MLDJENEOCDG, [LMAFJMDCBJO(null)] CHMLDJDCJFC FDEKFCDLHEC, [LMAFJMDCBJO(null)] GLIHBPDBOBH DJPMEFNNNCI, [LMAFJMDCBJO(null)] NEAGOFNAEJH GCPBDNGFMOB, [LMAFJMDCBJO(null)] LMGMKFINJJP DMBPGIHBDDO, [LMAFJMDCBJO(null)] OKADPHKNNFI OCAFCJCEGID, [LMAFJMDCBJO(null)] JLKCNOPLBDB MHDOMGOJADN, [LMAFJMDCBJO(null)] AGJJPDEKINC CNLKONKHOKH, [LMAFJMDCBJO(null)] JDAGMEDBEOP OMNHOGNBOAO, [LMAFJMDCBJO(null)] PJADLBKLPBG JNEONJAEABG, [LMAFJMDCBJO(null)] GOHDAHNCEBE JKLMJJBOHML, [LMAFJMDCBJO(null)] LMCCFNCOEKH LJLIPNKPPLJ, [LMAFJMDCBJO(null)] JCCDJMCNDFD DDPFBAJJKEO, [LMAFJMDCBJO(null)] HEBIEGDBEAD KPLEPOCCAPA, [LMAFJMDCBJO(null)] KFPPMIJFDDH BJLLOGJJHPI, [LMAFJMDCBJO(null)] OBLLOKNJDCG PCAOMEPKOGA, [LMAFJMDCBJO(null)] AKGKACKHBAH DCFEEMCJPDI, [LMAFJMDCBJO(null)] BEBAGOEJLNM PEPPDFGOAIH, [LMAFJMDCBJO(null)] OGFJBPHFJEB KBNKGFDBHAM, [LMAFJMDCBJO(null)] IJECOICGHPC EOKALGEBCIH, [LMAFJMDCBJO(null)] KBICEBOFMAL IIPFCEFGFDM, [LMAFJMDCBJO(null)] HICAKEDDGPG CKHPKJHFJBD, [LMAFJMDCBJO(null)] ILDFOCCEHCO MOCNNBHFPLB, [LMAFJMDCBJO(null)] IHDPFKHBMBC DAHGDHMNEHE, [LMAFJMDCBJO(null)] HKEFIKEPBGG ANMKNLMDNLI, [LMAFJMDCBJO(null)] NMPPFLAPGBK HLGHAEPPPPD, [LMAFJMDCBJO(null)] AEEOCELCEBG FCOLHCLIFCI, [LMAFJMDCBJO(null)] EFMGDAKFBAE OKFAEDKNMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x623BC70", Offset = "0x623B070", VA = "0x18623BC70")]
	private void OMELHDOHHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x623B5C0", Offset = "0x623A9C0", VA = "0x18623B5C0", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x623B310", Offset = "0x623A710", VA = "0x18623B310", Slot = "48")]
	private void BACKEAEGDMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x623BB80", Offset = "0x623AF80", VA = "0x18623BB80", Slot = "49")]
	private FKIJPOFAOED MPNPAPMHJDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x623B220", Offset = "0x623A620", VA = "0x18623B220", Slot = "50")]
	private BFAAFEKANMA AFIGNJJHFNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x623BA70", Offset = "0x623AE70", VA = "0x18623BA70", Slot = "51")]
	[AsyncStateMachine(typeof(IADJOHMPDFC))]
	private Task<KLJJBFIAHEC> MOCOKANIOLO(BJHHJKOCPBD CIOPFHLILOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x623B880", Offset = "0x623AC80", VA = "0x18623B880", Slot = "52")]
	[AsyncStateMachine(typeof(EDNGDNFOCLN))]
	private Task HHGOCJOCEGI(CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x623B4E0", Offset = "0x623A8E0", VA = "0x18623B4E0")]
	[IteratorStateMachine(typeof(LIAKJBEKKFE))]
	private IEnumerable<EIAHCHMNJNI> DCDBJGFDLPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x623B360", Offset = "0x623A760", VA = "0x18623B360")]
	[CompilerGenerated]
	private void BJGMCCJKNJB(EIAHCHMNJNI FNPIKAPNGBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class GOBFBDJCGFM : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0xBF8C70", Offset = "0xBF8070", VA = "0x180BF8C70")]
	public GOBFBDJCGFM(string LMJAPBNMKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class MNHJMKGLDMI : EIBLFGDNHKD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct DKNAMBACJOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public MNHJMKGLDMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6245AB0", Offset = "0x6244EB0", VA = "0x186245AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6245DF0", Offset = "0x62451F0", VA = "0x186245DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly CHMLDJDCJFC FDEKFCDLHEC;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x769080", Offset = "0x768480", VA = "0x180769080")]
	public MNHJMKGLDMI(FGMCJCFGAPG LGOFKBPFPIN, CHMLDJDCJFC FDEKFCDLHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x62576F0", Offset = "0x6256AF0", VA = "0x1862576F0", Slot = "4")]
	[AsyncStateMachine(typeof(DKNAMBACJOP))]
	public Task<bool> NHONBHKCNJC(CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6257610", Offset = "0x6256A10", VA = "0x186257610")]
	[CompilerGenerated]
	private object JPPPBIAOIOJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class PDPMFJABIBD : EIBLFGDNHKD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct CEDABPBBJLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public PDPMFJABIBD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x62446B0", Offset = "0x6243AB0", VA = "0x1862446B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6244DC0", Offset = "0x62441C0", VA = "0x186244DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly CHMLDJDCJFC FDEKFCDLHEC;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private EAKNENHMOPB DHPIDOBBJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6258A90", Offset = "0x6257E90", VA = "0x186258A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x769080", Offset = "0x768480", VA = "0x180769080")]
	public PDPMFJABIBD(FGMCJCFGAPG LGOFKBPFPIN, CHMLDJDCJFC FDEKFCDLHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6258BC0", Offset = "0x6257FC0", VA = "0x186258BC0", Slot = "4")]
	[AsyncStateMachine(typeof(CEDABPBBJLP))]
	public Task<bool> NHONBHKCNJC(CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6258AE0", Offset = "0x6257EE0", VA = "0x186258AE0")]
	[CompilerGenerated]
	private object MONBDCJHJLM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class EBDCJNBEPMM : EIBLFGDNHKD
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class BNCJOOIBDOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public EBDCJNBEPMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Matchmaking.AKJKLIOHEKN result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public BDKFBCEFMIP newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public BNCJOOIBDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6243D80", Offset = "0x6243180", VA = "0x186243D80")]
		internal object FGNOCFDFIOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6243E70", Offset = "0x6243270", VA = "0x186243E70")]
		internal object MEOGALODHPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6243CE0", Offset = "0x62430E0", VA = "0x186243CE0")]
		internal object AOHHMAOAGFF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct NBEKOJFKPIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public EBDCJNBEPMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private BNCJOOIBDOB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<Matchmaking.AKJKLIOHEKN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6257F20", Offset = "0x6257320", VA = "0x186257F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6258850", Offset = "0x6257C50", VA = "0x186258850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly CHMLDJDCJFC FDEKFCDLHEC;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private EAKNENHMOPB DHPIDOBBJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6246910", Offset = "0x6245D10", VA = "0x186246910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x769080", Offset = "0x768480", VA = "0x180769080")]
	public EBDCJNBEPMM(FGMCJCFGAPG LGOFKBPFPIN, CHMLDJDCJFC FDEKFCDLHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6246960", Offset = "0x6245D60", VA = "0x186246960", Slot = "4")]
	[AsyncStateMachine(typeof(NBEKOJFKPIM))]
	public Task<bool> NHONBHKCNJC(CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal interface EIBLFGDNHKD
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> NHONBHKCNJC(CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct KMGNIGGOODJ
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class BNFIFBEPCLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public FGMCJCFGAPG manager;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public BNFIFBEPCLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6243EE0", Offset = "0x62432E0", VA = "0x186243EE0")]
		internal Task EJFDHLECBLN(OKOIPJPAMDA data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct LIFAGENCOJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public KMGNIGGOODJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private BJHHJKOCPBD <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<HIIBGFBFAID> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<KLJJBFIAHEC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x62546B0", Offset = "0x6253AB0", VA = "0x1862546B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6254C40", Offset = "0x6254040", VA = "0x186254C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct JDGJLOFMLAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public KMGNIGGOODJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x624FD50", Offset = "0x624F150", VA = "0x18624FD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6250070", Offset = "0x624F470", VA = "0x186250070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken OMFABMCIOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly FGMCJCFGAPG CCJFCCENPLD;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private IBLKHHFCHMM EOAIEANLOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x62523E0", Offset = "0x62517E0", VA = "0x1862523E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private CHMLDJDCJFC JIBKILINHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6252180", Offset = "0x6251580", VA = "0x186252180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private EAKNENHMOPB DHPIDOBBJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6252500", Offset = "0x6251900", VA = "0x186252500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private AGJJPDEKINC NLBJBDNGFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6252740", Offset = "0x6251B40", VA = "0x186252740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1C26870", Offset = "0x1C25C70", VA = "0x181C26870")]
	public KMGNIGGOODJ(CancellationToken OMFABMCIOAC, FGMCJCFGAPG CCJFCCENPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6252580", Offset = "0x6251980", VA = "0x186252580")]
	public static KALGNJFILHN KACNIFKJHKJ(FGMCJCFGAPG CCJFCCENPLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6252630", Offset = "0x6251A30", VA = "0x186252630")]
	[AsyncStateMachine(typeof(LIFAGENCOJO))]
	public Task<bool> LAGINJJKIEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x62521D0", Offset = "0x62515D0", VA = "0x1862521D0")]
	private bool CPNDNOKDHJO([Out] BJHHJKOCPBD CIOPFHLILOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6252430", Offset = "0x6251830", VA = "0x186252430")]
	[AsyncStateMachine(typeof(JDGJLOFMLAD))]
	private Task EECKJGBFJFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6252790", Offset = "0x6251B90", VA = "0x186252790")]
	private Task<HIIBGFBFAID> PEOIENDPGCL(BJHHJKOCPBD HLLNEFIGGHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct PIGAAPDDGPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly JCCDJMCNDFD DDPFBAJJKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid CEMPKOIGLIO;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private Task<(KLJJBFIAHEC, Task)> AKFCAPPDBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x62592F0", Offset = "0x62586F0", VA = "0x1862592F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x38AFAA0", Offset = "0x38AEEA0", VA = "0x1838AFAA0")]
	public PIGAAPDDGPE(JCCDJMCNDFD DDPFBAJJKEO, Guid CEMPKOIGLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x62593C0", Offset = "0x62587C0", VA = "0x1862593C0")]
	public TaskAwaiter<(KLJJBFIAHEC, Task)> IGKNDCIJPBN()
	{
		return default(TaskAwaiter<(KLJJBFIAHEC, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6259220", Offset = "0x6258620", VA = "0x186259220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct KMLAKBGFHOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(KLJJBFIAHEC, Task)> INOAOIMPNLB;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Task<(KLJJBFIAHEC, Task)> AKFCAPPDBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6252960", Offset = "0x6251D60", VA = "0x186252960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6252B10", Offset = "0x6251F10", VA = "0x186252B10")]
	public KMLAKBGFHOL(TimeSpan HKLLMMFEENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x62528C0", Offset = "0x6251CC0", VA = "0x1862528C0")]
	public void BMJMEIGDAIG(Task NLMOJCNFHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6252A30", Offset = "0x6251E30", VA = "0x186252A30")]
	public void KBOFPBLDIHP(KLJJBFIAHEC HMBGGNACLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6252AC0", Offset = "0x6251EC0", VA = "0x186252AC0")]
	public void KFAFNGJGANI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x62529A0", Offset = "0x6251DA0", VA = "0x1862529A0")]
	internal void JGCAKAHGLEJ(string LMJAPBNMKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class HNJIKOBCEDF
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CEMNBACAOIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public HDMEAOOCBIO subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CEMNBACAOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6244E30", Offset = "0x6244230", VA = "0x186244E30")]
		internal bool ODBFHODFDEG(DFEHFHGPFLB s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x624DFA0", Offset = "0x624D3A0", VA = "0x18624DFA0")]
	public static ABMIDKAKKGN PJBIIEEDKDI(long LDECBGPODEE, long PINPACMDEDH, string FNOFHHIOKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x624DEE0", Offset = "0x624D2E0", VA = "0x18624DEE0")]
	public static ABMIDKAKKGN PJBIIEEDKDI(long LDECBGPODEE, long PINPACMDEDH, IGNOFONIPFC ILOGCLKGEMA, long DHIEKGKANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x624DD50", Offset = "0x624D150", VA = "0x18624DD50")]
	public static ABMIDKAKKGN PJBIIEEDKDI(EOMDJPDNCEE HMLEKAPDMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x624E030", Offset = "0x624D430", VA = "0x18624E030")]
	public static ABMIDKAKKGN PJBIIEEDKDI(FDKPOLPBLFH HMAHNDAKJAL, HDMEAOOCBIO JIMEOAAAGDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x624DC60", Offset = "0x624D060", VA = "0x18624DC60")]
	public static ABMIDKAKKGN OAFIJGPDODC(this ABMIDKAKKGN CJFCIOOMJGN, FDKPOLPBLFH BAOHNKIPIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x624DAD0", Offset = "0x624CED0", VA = "0x18624DAD0")]
	public static ABMIDKAKKGN BFPHFKKMAKH(this ABMIDKAKKGN CJFCIOOMJGN, HDMEAOOCBIO EEPEKOJKKPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class AKICGMJAPKF : JLKCNOPLBDB, EIAHCHMNJNI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct MPOGFKKHHPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AKICGMJAPKF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x62577E0", Offset = "0x6256BE0", VA = "0x1862577E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6257EC0", Offset = "0x62572C0", VA = "0x186257EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly NHAKFPLMIPB IDKMJOMMFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string AAAHOLHDDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task AIJLMKEJFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool HIFDOFLJIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x623AF40", Offset = "0x623A340", VA = "0x18623AF40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Task AEJGOCHPOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x623AEB0", Offset = "0x623A2B0", VA = "0x18623AEB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x76DDB0", Offset = "0x76D1B0", VA = "0x18076DDB0", Slot = "7")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x623AD50", Offset = "0x623A150", VA = "0x18623AD50", Slot = "6")]
	public void AJMAALPDPIL(Task DJNEDNIILKC, string CPBLGOKGJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x623AF70", Offset = "0x623A370", VA = "0x18623AF70")]
	[AsyncStateMachine(typeof(MPOGFKKHHPG))]
	private Task PAEEFOPDHEH(Task LDLGOKJFCEA, string CPBLGOKGJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x623B090", Offset = "0x623A490", VA = "0x18623B090")]
	public AKICGMJAPKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class JHAPAGPKOKN : CGFOCHHGACM, EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool IIHJBMBPPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private CGKFPLEFIDK CNOCGPMNPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IBLKHHFCHMM FOEGMELFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IHDPFKHBMBC DAHGDHMNEHE;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public CGKFPLEFIDK JMEKLGFFDHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6250930", Offset = "0x624FD30", VA = "0x186250930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x62509A0", Offset = "0x624FDA0", VA = "0x1862509A0", Slot = "7")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6250740", Offset = "0x624FB40", VA = "0x186250740", Slot = "5")]
	public void DAJIKLAKKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x62508F0", Offset = "0x624FCF0", VA = "0x1862508F0", Slot = "6")]
	public void LKEAHNJMCFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6250680", Offset = "0x624FA80", VA = "0x186250680")]
	private Task BJHGAAGFMPE(FNPDPJOBFPE JMBKGKDJDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x62508F0", Offset = "0x624FCF0", VA = "0x1862508F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public JHAPAGPKOKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class GNBOOBGDBHB : IHDPFKHBMBC
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class LNPPNKGILAD<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly KINEKJFPBEJ CCAHBOAJIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly string IHHOPACLNAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly T HBPJMDHPOKO;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public T OFPAGNFLHNE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x7B47D0", Offset = "0x7B3BD0", VA = "0x1807B47D0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x889760", Offset = "0x888B60", VA = "0x180889760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x39274F0", Offset = "0x39268F0", VA = "0x1839274F0")]
		public LNPPNKGILAD(KINEKJFPBEJ CCAHBOAJIHB, string IHHOPACLNAK, T HBPJMDHPOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3926F70", Offset = "0x3926370", VA = "0x183926F70")]
		private void HBBKMAGOLLF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly KINEKJFPBEJ CCAHBOAJIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly LNPPNKGILAD<TimeSpan> JGMOKBDLNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly LNPPNKGILAD<TimeSpan> AHPHFGFILFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly LNPPNKGILAD<TimeSpan> MHAKJMIDPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly LNPPNKGILAD<TimeSpan> HFNCHDIILNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly LNPPNKGILAD<bool> FIHBGMOMELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly LNPPNKGILAD<bool> EPJADPAPGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly LNPPNKGILAD<bool> JGPCNMBBOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly LNPPNKGILAD<int> DMCANCBIIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly LNPPNKGILAD<bool> IHBAFNDAEMA;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan JGPEEMHOKKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x624C7D0", Offset = "0x624BBD0", VA = "0x18624C7D0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan NNNJNKEAMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x624C750", Offset = "0x624BB50", VA = "0x18624C750", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan HKFMBHMFKOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x624C810", Offset = "0x624BC10", VA = "0x18624C810", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TimeSpan FCBFMJOHCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x624C890", Offset = "0x624BC90", VA = "0x18624C890", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool NLECKIOCAHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x624C8D0", Offset = "0x624BCD0", VA = "0x18624C8D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool FEDFDONMOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x624C790", Offset = "0x624BB90", VA = "0x18624C790", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool DOGDDPGIDHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x624C910", Offset = "0x624BD10", VA = "0x18624C910", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int PFDFLNNFMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x624C950", Offset = "0x624BD50", VA = "0x18624C950", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool MMMLCJINFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x624C850", Offset = "0x624BC50", VA = "0x18624C850", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x624C990", Offset = "0x624BD90", VA = "0x18624C990")]
	[UnityEngine.Scripting.Preserve]
	public GNBOOBGDBHB([LMAFJMDCBJO(null)] KINEKJFPBEJ CCAHBOAJIHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[UnityEngine.Scripting.Preserve]
internal class GAKGMADENLB : JDAGMEDBEOP, EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class OHEBGGFJKNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public DDKHGNOFKCA roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public OHEBGGFJKNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x62589B0", Offset = "0x6257DB0", VA = "0x1862589B0")]
		internal object OPLPPFAMBKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action GHHBHLAPKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x624BA70", Offset = "0x624AE70", VA = "0x18624BA70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x624B640", Offset = "0x624AA40", VA = "0x18624B640", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event DANNLOHPOAC OJDHKGPBOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x624B830", Offset = "0x624AC30", VA = "0x18624B830", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x624B790", Offset = "0x624AB90", VA = "0x18624B790", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event DANNLOHPOAC FLHGDEIHLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x624BB10", Offset = "0x624AF10", VA = "0x18624BB10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x624B0F0", Offset = "0x624A4F0", VA = "0x18624B0F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event DANNLOHPOAC CMPFEMDFJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x624B8D0", Offset = "0x624ACD0", VA = "0x18624B8D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x624B5A0", Offset = "0x624A9A0", VA = "0x18624B5A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<BAIOELEICOL, bool> BHPEPOMEAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x624B6E0", Offset = "0x624AAE0", VA = "0x18624B6E0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x624B9C0", Offset = "0x624ADC0", VA = "0x18624B9C0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "19")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x624B380", Offset = "0x624A780", VA = "0x18624B380", Slot = "14")]
	public void DJPDCCOFOBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x624BBE0", Offset = "0x624AFE0", VA = "0x18624BBE0", Slot = "15")]
	public void PCGANMDNEEK(DDKHGNOFKCA LDCLGCFOCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x624BBB0", Offset = "0x624AFB0", VA = "0x18624BBB0", Slot = "16")]
	public void NMFEIJEGONP(DDKHGNOFKCA LDCLGCFOCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x624B0C0", Offset = "0x624A4C0", VA = "0x18624B0C0", Slot = "17")]
	public void BEBGIIGNFKF(DDKHGNOFKCA LDCLGCFOCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x624B970", Offset = "0x624AD70", VA = "0x18624B970", Slot = "18")]
	public void JNKNFIPHCBB(BAIOELEICOL EGJBIIEJEOI, bool OLAMLOCNCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x624B190", Offset = "0x624A590", VA = "0x18624B190")]
	private void DFPIJIPLDKJ(DANNLOHPOAC MDNGPGHLBBO, DDKHGNOFKCA LDCLGCFOCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public GAKGMADENLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal class HBIGHFGNMJB : PJADLBKLPBG, EIAHCHMNJNI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct JEKPINCENCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public HBIGHFGNMJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x62500D0", Offset = "0x624F4D0", VA = "0x1862500D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6250620", Offset = "0x624FA20", VA = "0x186250620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct DIDJEPBEOGB : IAsyncStateMachine
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
		public HBIGHFGNMJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x62453B0", Offset = "0x62447B0", VA = "0x1862453B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6245A50", Offset = "0x6244E50", VA = "0x186245A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class KAJFMHEDPHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public KAJFMHEDPHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6251D10", Offset = "0x6251110", VA = "0x186251D10")]
		internal object JDEBMCFLMGB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct BEILEFKABCM : IAsyncStateMachine
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
		public HBIGHFGNMJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private KAJFMHEDPHK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6240F90", Offset = "0x6240390", VA = "0x186240F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6241720", Offset = "0x6240B20", VA = "0x186241720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class FNPLFCNAEOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public FNPLFCNAEOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x624B050", Offset = "0x624A450", VA = "0x18624B050")]
		internal object HFHMEADGPKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private CHMLDJDCJFC FDEKFCDLHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private EIBLFGDNHKD[] JEJHBKJJOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private CancellationTokenSource HFJACFBDGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private int NHJPGLIINMC;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x624D890", Offset = "0x624CC90", VA = "0x18624D890", Slot = "6")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x624D2B0", Offset = "0x624C6B0", VA = "0x18624D2B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x624D650", Offset = "0x624CA50", VA = "0x18624D650", Slot = "8")]
	public void JGPNGJLKHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x624D570", Offset = "0x624C970", VA = "0x18624D570", Slot = "5")]
	public void IGIOFLCFCIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x624D1E0", Offset = "0x624C5E0", VA = "0x18624D1E0", Slot = "4")]
	[AsyncStateMachine(typeof(JEKPINCENCK))]
	public Task APLEGOHOINI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x624CED0", Offset = "0x624C2D0", VA = "0x18624CED0")]
	private void AMGCPODLDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x624D480", Offset = "0x624C880", VA = "0x18624D480")]
	[AsyncStateMachine(typeof(DIDJEPBEOGB))]
	private Task FPNNFLMHDJC(CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x624D760", Offset = "0x624CB60", VA = "0x18624D760")]
	[AsyncStateMachine(typeof(BEILEFKABCM))]
	private Task<bool> JJDDNHODGOE(int JPEMHHILGGG, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x624D2C0", Offset = "0x624C6C0", VA = "0x18624D2C0")]
	private void EBKNCKGGONM(int JPEMHHILGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x624D3A0", Offset = "0x624C7A0", VA = "0x18624D3A0")]
	private void FPJLCHPGMMG(int JPEMHHILGGG, bool OLAMLOCNCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x624CDA0", Offset = "0x624C1A0", VA = "0x18624CDA0")]
	private void AJAPEFOPAPM(int JPEMHHILGGG, Exception FLMBJDOBLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x624D910", Offset = "0x624CD10", VA = "0x18624D910")]
	private void PAKJAIJBGNH(CancellationToken OMFABMCIOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public HBIGHFGNMJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class EEAAMICIALK : GOHDAHNCEBE, EIAHCHMNJNI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct LFGKFKMJBEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public BDKFBCEFMIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public EEAAMICIALK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AONGELAAJMM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6252CA0", Offset = "0x62520A0", VA = "0x186252CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6253660", Offset = "0x6252A60", VA = "0x186253660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct JIDPCHMLEJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public EEAAMICIALK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public BDKFBCEFMIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AONGELAAJMM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private KGKDBPAMFIO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private EMNADKEEBNM <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private KEGBDCDGPPF <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6251030", Offset = "0x6250430", VA = "0x186251030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x6251C30", Offset = "0x6251030", VA = "0x186251C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class PIMBFIHONOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public Matchmaking.JMIOLCJNKEK result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public HNCCCLFKMDO errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public PIMBFIHONOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6259410", Offset = "0x6258810", VA = "0x186259410")]
		internal object PEGAEJCBOBJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class NJCHOBPIDPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Task<ABMIDKAKKGN> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public NJCHOBPIDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		internal Task<ABMIDKAKKGN> KLEAFGLBMEH(KGKDBPAMFIO<string>.HDBHKIOKMPF _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct BCIACDCIBOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public EEAAMICIALK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public BDKFBCEFMIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AONGELAAJMM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public EMNADKEEBNM joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private NJCHOBPIDPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private KDNDFIEIIAJ <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private BJKFFLKACKO <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private Task<Matchmaking.BMLABNOFELP> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ILDJKEIANJP <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private TaskAwaiter<Matchmaking.BMLABNOFELP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationToken <photonJoinedToken>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private Task <roomLoadTask>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter<ABMIDKAKKGN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x623C160", Offset = "0x623B560", VA = "0x18623C160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6240F30", Offset = "0x6240330", VA = "0x186240F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct GHEMMAJMCLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public EEAAMICIALK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <disconnectTimerScope>5__3;

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
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x624BC60", Offset = "0x624B060", VA = "0x18624BC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x624C6F0", Offset = "0x624BAF0", VA = "0x18624C6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct IGFBBLGHFDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public EEAAMICIALK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private BFGBHKPNKEI <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x624EBA0", Offset = "0x624DFA0", VA = "0x18624EBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x624F020", Offset = "0x624E420", VA = "0x18624F020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct BPCDNEBKGKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder<Matchmaking.BMLABNOFELP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public BDKFBCEFMIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public EEAAMICIALK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private TaskAwaiter<Matchmaking.BMLABNOFELP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6243F30", Offset = "0x6243330", VA = "0x186243F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6244410", Offset = "0x6243810", VA = "0x186244410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct IIOACOOBGCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public Matchmaking.BMLABNOFELP serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public EEAAMICIALK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public EMNADKEEBNM joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<KBBLOHGGBJA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x624F080", Offset = "0x624E480", VA = "0x18624F080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x624F7B0", Offset = "0x624EBB0", VA = "0x18624F7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class HPELBMKKOBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public BDKFBCEFMIP targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HPELBMKKOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x624E260", Offset = "0x624D660", VA = "0x18624E260")]
		internal object APBBLKLHDAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x624E360", Offset = "0x624D760", VA = "0x18624E360")]
		internal string GFDLENIIMJL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct LKIMGHLNJPN : IAsyncStateMachine
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
		public BDKFBCEFMIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public EEAAMICIALK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private HPELBMKKOBG <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x6254F60", Offset = "0x6254360", VA = "0x186254F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6255B90", Offset = "0x6254F90", VA = "0x186255B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct MGKIGKBACOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public EEAAMICIALK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public EMNADKEEBNM joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public ABMIDKAKKGN initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public BDKFBCEFMIP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public KDNDFIEIIAJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6256CA0", Offset = "0x62560A0", VA = "0x186256CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x62575B0", Offset = "0x62569B0", VA = "0x1862575B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct BGBIJGFACPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public EEAAMICIALK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap3;

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
		[Cpp2IlInjected.Address(RVA = "0x6241790", Offset = "0x6240B90", VA = "0x186241790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6242E30", Offset = "0x6242230", VA = "0x186242E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct LHOEEGACKGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public EEAAMICIALK <>4__this;

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
		private TaskAwaiter<KLJJBFIAHEC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x62536C0", Offset = "0x6252AC0", VA = "0x1862536C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6253EF0", Offset = "0x62532F0", VA = "0x186253EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class ICJLLBKCMDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public BDKFBCEFMIP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ICJLLBKCMDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x624E750", Offset = "0x624DB50", VA = "0x18624E750")]
		internal object EPIKFINMEJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class ANFBKKDOBLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ANFBKKDOBLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x623B120", Offset = "0x623A520", VA = "0x18623B120")]
		internal void HDIAANMHFPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class JOEDIKBCODI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public BDKFBCEFMIP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public JOEDIKBCODI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6251C90", Offset = "0x6251090", VA = "0x186251C90")]
		internal object PENOMPMEEAF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class MCCGAENGCEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public BDKFBCEFMIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public MCCGAENGCEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6255BF0", Offset = "0x6254FF0", VA = "0x186255BF0")]
		internal string AFJDFMIIDNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly FJOGIBEAJHF ECECKLCJOHC;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly FJOGIBEAJHF JODJAKGIHCD;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly FJOGIBEAJHF OCCIAONIIBC;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly string KAJKLOHJEOF;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly string ANDNNNBJKLK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string GJIDKLEAHLP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static readonly Guid FEJBIKFHLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private OKADPHKNNFI OCAFCJCEGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private FDNFIBJMANG MLDJENEOCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private IBLKHHFCHMM FOEGMELFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private CHMLDJDCJFC FDEKFCDLHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private PJADLBKLPBG JNEONJAEABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private JLKCNOPLBDB MHDOMGOJADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private JDAGMEDBEOP OMNHOGNBOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private EFMGDAKFBAE OKFAEDKNMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private AEEOCELCEBG FCOLHCLIFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private IDisposable BLAMIGLEHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly NHAKFPLMIPB IAFKHNCFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly NHAKFPLMIPB GODNCEPAEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private ILDJKEIANJP CEHIMCBLIKL;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public TaskStatus KIBGINHAEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x93E110", Offset = "0x93D510", VA = "0x18093E110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x986830", Offset = "0x985C30", VA = "0x180986830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private EAKNENHMOPB DHPIDOBBJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6248330", Offset = "0x6247730", VA = "0x186248330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6249970", Offset = "0x6248D70", VA = "0x186249970", Slot = "6")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x62479E0", Offset = "0x6246DE0", VA = "0x1862479E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6249E30", Offset = "0x6249230", VA = "0x186249E30", Slot = "5")]
	[AsyncStateMachine(typeof(LFGKFKMJBEC))]
	public Task ONOGKBKLFNL(BDKFBCEFMIP DNLDHEDCLAM, AONGELAAJMM IPDAHDOFOCL, CancellationToken CKCHEDNFLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6247A30", Offset = "0x6246E30", VA = "0x186247A30")]
	[AsyncStateMachine(typeof(JIDPCHMLEJL))]
	private Task EMONMPCDHBN(BDKFBCEFMIP DNLDHEDCLAM, AONGELAAJMM IPDAHDOFOCL, CancellationToken CKCHEDNFLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6249320", Offset = "0x6248720", VA = "0x186249320")]
	private static void OANFCFNJMDM(EFMGDAKFBAE OKFAEDKNMAL, BDKFBCEFMIP DNLDHEDCLAM, Exception FLMBJDOBLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6248380", Offset = "0x6247780", VA = "0x186248380")]
	private static void JKKOCHKNFIO(KEGBDCDGPPF MLNDFLMDIBP, Exception FLMBJDOBLFE, [Optional] List<int> IIJBMGHIOJH, int NHJPGLIINMC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x624A080", Offset = "0x6249480", VA = "0x18624A080")]
	[AsyncStateMachine(typeof(BCIACDCIBOF))]
	private Task PGHHKLIFFPI(KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, BDKFBCEFMIP DNLDHEDCLAM, AONGELAAJMM IPDAHDOFOCL, EMNADKEEBNM CBNMHEHKHPP, CancellationToken CKCHEDNFLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6247260", Offset = "0x6246660", VA = "0x186247260")]
	private void BCOPBBGAMGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6247E40", Offset = "0x6247240", VA = "0x186247E40")]
	[AsyncStateMachine(typeof(GHEMMAJMCLB))]
	private Task HDDLAJMAEEN(KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6247410", Offset = "0x6246810", VA = "0x186247410")]
	private void BGONIKFCKFM(BDKFBCEFMIP DNLDHEDCLAM, CancellationToken CKCHEDNFLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x624A320", Offset = "0x6249720", VA = "0x18624A320")]
	private void PHPKJBLFGGN(BDKFBCEFMIP DNLDHEDCLAM, EMNADKEEBNM CBNMHEHKHPP, OperationCanceledException APHCBBPLCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6247B80", Offset = "0x6246F80", VA = "0x186247B80")]
	private void FJJCFHFJEBO(BDKFBCEFMIP DNLDHEDCLAM, EMNADKEEBNM CBNMHEHKHPP, Exception FLMBJDOBLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x62480A0", Offset = "0x62474A0", VA = "0x1862480A0")]
	private void HLLOHMMHFOH(BDKFBCEFMIP DNLDHEDCLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6246D10", Offset = "0x6246110", VA = "0x186246D10")]
	private static DDKHGNOFKCA AAPFANPNJCP(BDKFBCEFMIP DNLDHEDCLAM)
	{
		return default(DDKHGNOFKCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6246D70", Offset = "0x6246170", VA = "0x186246D70")]
	[AsyncStateMachine(typeof(IGFBBLGHFDF))]
	private Task AEBEELEDCEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x624A1E0", Offset = "0x62495E0", VA = "0x18624A1E0")]
	[AsyncStateMachine(typeof(BPCDNEBKGKN))]
	private Task<Matchmaking.BMLABNOFELP> PHPCNLMALGB(BDKFBCEFMIP DNLDHEDCLAM, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6249860", Offset = "0x6248C60", VA = "0x186249860")]
	private static KBBLOHGGBJA OLHHBIHBMIJ(Matchmaking.BMLABNOFELP JBJMECDJEFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6249140", Offset = "0x6248540", VA = "0x186249140")]
	[AsyncStateMachine(typeof(IIOACOOBGCL))]
	private Task MILMLPOMBIA(Matchmaking.BMLABNOFELP JBJMECDJEFA, EMNADKEEBNM CBNMHEHKHPP, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken GALIAPOJGAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6247110", Offset = "0x6246510", VA = "0x186247110")]
	[AsyncStateMachine(typeof(LKIMGHLNJPN))]
	private Task BBHPGHNIOBM(BDKFBCEFMIP DNLDHEDCLAM, CancellationTokenSource DHKALMINANJ, Task IFMFCPKGIBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6248C10", Offset = "0x6248010", VA = "0x186248C10")]
	[AsyncStateMachine(typeof(MGKIGKBACOD))]
	private Task LIAGMHBEMIG(ABMIDKAKKGN IPFJOAEJGOE, KDNDFIEIIAJ DGFJADMMGJP, BDKFBCEFMIP AOIHCHCEGBF, EMNADKEEBNM PALDMJGFJGI, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken HMEJAHLLCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x62477E0", Offset = "0x6246BE0", VA = "0x1862477E0")]
	private EMNADKEEBNM CLLAHBOCKOA(EMNADKEEBNM PALDMJGFJGI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6247F70", Offset = "0x6247370", VA = "0x186247F70")]
	[AsyncStateMachine(typeof(BGBIJGFACPG))]
	private Task HECJKBGLJKP(KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6246FF0", Offset = "0x62463F0", VA = "0x186246FF0")]
	[AsyncStateMachine(typeof(LHOEEGACKGA))]
	private Task AMLFJGEPPMH(OKOIPJPAMDA OOIBMCBCEPD, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x62496E0", Offset = "0x6248AE0", VA = "0x1862496E0")]
	private static void OJBIDCCEMKB(BDKFBCEFMIP DNLDHEDCLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6248E80", Offset = "0x6248280", VA = "0x186248E80")]
	private void MDEPJFBAPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6247750", Offset = "0x6246B50", VA = "0x186247750")]
	private void BNNLAEPPJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6247DB0", Offset = "0x62471B0", VA = "0x186247DB0")]
	private void FMALFFKLHMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6249290", Offset = "0x6248690", VA = "0x186249290")]
	private void MNFDDKCKHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6249050", Offset = "0x6248450", VA = "0x186249050")]
	private static void MIJKMPCBEMD(BDKFBCEFMIP DNLDHEDCLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6249F70", Offset = "0x6249370", VA = "0x186249F70")]
	private static CancellationTokenRegistration OODMBOKJDNK(BDKFBCEFMIP DNLDHEDCLAM, CancellationToken GALIAPOJGAG)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6248D80", Offset = "0x6248180", VA = "0x186248D80")]
	private static void LLJCALOAPFN(BDKFBCEFMIP DNLDHEDCLAM, Exception FLMBJDOBLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6246E40", Offset = "0x6246240", VA = "0x186246E40")]
	private void AMJGMILCGPJ(BDKFBCEFMIP DNLDHEDCLAM, Task IFMFCPKGIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x62482D0", Offset = "0x62476D0", VA = "0x1862482D0")]
	private static void IJCNCIMJJJN(Func<string> AJGMBAOCDMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x624A770", Offset = "0x6249B70", VA = "0x18624A770")]
	public EEAAMICIALK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x62473B0", Offset = "0x62467B0", VA = "0x1862473B0")]
	[CompilerGenerated]
	internal static (int, int?) BFPGKNNGGEK(HNCCCLFKMDO BCIJBMOMCKL)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[UnityEngine.Scripting.Preserve]
internal class MGJODJLLJAL : LMCCFNCOEKH, EIAHCHMNJNI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct JCMAKIIKPMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public MGJODJLLJAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public OKOIPJPAMDA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x624F810", Offset = "0x624EC10", VA = "0x18624F810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x624FCF0", Offset = "0x624F0F0", VA = "0x18624FCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class OKEAOBCJDLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public MGJODJLLJAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public OKOIPJPAMDA roomData;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public OKEAOBCJDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6278AA0", Offset = "0x6277EA0", VA = "0x186278AA0")]
		internal List<Task> AONKKABANKE(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct MFAGHNOEDJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public KALGNJFILHN taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public OKOIPJPAMDA data;

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
		[Cpp2IlInjected.Address(RVA = "0x6276060", Offset = "0x6275460", VA = "0x186276060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6276430", Offset = "0x6275830", VA = "0x186276430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct FMALKECCGML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public MGJODJLLJAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6265FF0", Offset = "0x62653F0", VA = "0x186265FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x62662B0", Offset = "0x62656B0", VA = "0x1862662B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly HashSet<KALGNJFILHN> KHJICBHJPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private FDNFIBJMANG MLDJENEOCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private IHFCDNDDOME LCGGAIHAJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private LPCLAHIKKBG ELGPCJGCINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private IDisposable BLAMIGLEHNH;

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x62568C0", Offset = "0x6255CC0", VA = "0x1862568C0", Slot = "5")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x6255E10", Offset = "0x6255210", VA = "0x186255E10", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x6256860", Offset = "0x6255C60", VA = "0x186256860", Slot = "4")]
	public bool OHGEONNPNHA(KALGNJFILHN KJNPEAJJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x62562B0", Offset = "0x62556B0", VA = "0x1862562B0")]
	private void MHIIDAGFPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x6255E70", Offset = "0x6255270", VA = "0x186255E70")]
	private void ELNILONCMED(OKOIPJPAMDA NDJHINJFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x62560F0", Offset = "0x62554F0", VA = "0x1862560F0")]
	[AsyncStateMachine(typeof(JCMAKIIKPMI))]
	private Task JIOHHCFCHBI(OKOIPJPAMDA NDJHINJFLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6256B40", Offset = "0x6255F40", VA = "0x186256B40")]
	private Func<CancellationToken, List<Task>> PCDOKBICFLF(OKOIPJPAMDA NDJHINJFLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x62563F0", Offset = "0x62557F0", VA = "0x1862563F0")]
	private List<Task> NGBNJEJJDOE(OKOIPJPAMDA NDJHINJFLAD, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6255CF0", Offset = "0x62550F0", VA = "0x186255CF0")]
	[AsyncStateMachine(typeof(MFAGHNOEDJM))]
	private Task AEAIEODEHIF(KALGNJFILHN KHPFPLBFKPI, OKOIPJPAMDA OOIBMCBCEPD, CancellationToken IBLOMPOENGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x62561E0", Offset = "0x62555E0", VA = "0x1862561E0")]
	[AsyncStateMachine(typeof(FMALKECCGML))]
	private Task LBJAEDPHGCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6256070", Offset = "0x6255470", VA = "0x186256070")]
	private void JGPNGJLKHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6256C10", Offset = "0x6256010", VA = "0x186256C10")]
	public MGJODJLLJAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[UnityEngine.Scripting.Preserve]
internal sealed class HOJPPNGOPAP : JCCDJMCNDFD, EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class IKAGPBMNNAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public IKAGPBMNNAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x626F390", Offset = "0x626E790", VA = "0x18626F390")]
		internal object LCNFGDBDGCI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class ECBNEHLKOPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ECBNEHLKOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x62621F0", Offset = "0x62615F0", VA = "0x1862621F0")]
		internal object OCLPHENGHNP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class CFGKNMBPBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CFGKNMBPBBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class JHPNHLFOOAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public JHPNHLFOOAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6270F10", Offset = "0x6270310", VA = "0x186270F10")]
		internal object JGKIGBJIJAG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class OGEFKCIPNKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public OGEFKCIPNKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6277BD0", Offset = "0x6276FD0", VA = "0x186277BD0")]
		internal object LHCEFLLLFGP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private readonly Dictionary<Guid, KMLAKBGFHOL> DDPFBAJJKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly TimeSpan NGKANIOFMHE;

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "9")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x626DBD0", Offset = "0x626CFD0", VA = "0x18626DBD0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x626DBE0", Offset = "0x626CFE0", VA = "0x18626DBE0", Slot = "4")]
	public PIGAAPDDGPE GIHKKMKIIOJ(Guid CEMPKOIGLIO)
	{
		return default(PIGAAPDDGPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x626DE10", Offset = "0x626D210", VA = "0x18626DE10", Slot = "5")]
	public bool HFJFDMFKDND(Guid CEMPKOIGLIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x626D640", Offset = "0x626CA40", VA = "0x18626D640", Slot = "6")]
	public bool AIIJHGEPFCI(Guid CEMPKOIGLIO, Task NLMOJCNFHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x626E0B0", Offset = "0x626D4B0", VA = "0x18626E0B0", Slot = "7")]
	public bool POFLLEMAKDN(Guid CEMPKOIGLIO, KLJJBFIAHEC HMBGGNACLEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x626E040", Offset = "0x626D440", VA = "0x18626E040", Slot = "8")]
	public Task<(KLJJBFIAHEC, Task)> KOHHAMJECBB(Guid CEMPKOIGLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x626D990", Offset = "0x626CD90", VA = "0x18626D990")]
	private void BDIGJGDFFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x626E2B0", Offset = "0x626D6B0", VA = "0x18626E2B0")]
	public HOJPPNGOPAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[UnityEngine.Scripting.Preserve]
internal class APDBHGEABAA : HEBIEGDBEAD, EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class PIAJGIGEKMJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private readonly BDKFBCEFMIP IPPDJPKCJOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private readonly CancellationTokenSource HFJACFBDGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public readonly CancellationToken GEKALEOKFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private bool BJIGDCGMMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private bool CHCAJAAKAHP;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6278C50", Offset = "0x6278050", VA = "0x186278C50")]
		public PIAJGIGEKMJ(BDKFBCEFMIP IPPDJPKCJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6278B00", Offset = "0x6277F00", VA = "0x186278B00")]
		public void JGPNGJLKHJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6278AD0", Offset = "0x6277ED0", VA = "0x186278AD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class BBONLIILCFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public FNPDPJOBFPE disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public BBONLIILCFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x625DF70", Offset = "0x625D370", VA = "0x18625DF70")]
		internal object NAJGOJIHGEJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct GNGDDDADGPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public FNPDPJOBFPE disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public APDBHGEABAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6268550", Offset = "0x6267950", VA = "0x186268550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6268980", Offset = "0x6267D80", VA = "0x186268980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class GLFOABBGGNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public GLFOABBGGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x62684E0", Offset = "0x62678E0", VA = "0x1862684E0")]
		internal object GBKMHGNFEDC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct APDECFPLBBG : IAsyncStateMachine
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
		public APDBHGEABAA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x625CD80", Offset = "0x625C180", VA = "0x18625CD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x82FC80", Offset = "0x82F080", VA = "0x18082FC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class EDHJPIEILJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public BDKFBCEFMIP newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public EDHJPIEILJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x62622D0", Offset = "0x62616D0", VA = "0x1862622D0")]
		internal object LNCIFBHABOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6262290", Offset = "0x6261690", VA = "0x186262290")]
		internal object LLOBFCKIFON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6262250", Offset = "0x6261650", VA = "0x186262250")]
		internal object KMPONIPCMLF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class NIBMKDHGPPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public NIBMKDHGPPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6276D50", Offset = "0x6276150", VA = "0x186276D50")]
		internal void ECONHLKFPFP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct EOBIMNIBDAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public BDKFBCEFMIP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public APDBHGEABAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public AONGELAAJMM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private EDHJPIEILJO <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x6262B40", Offset = "0x6261F40", VA = "0x186262B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6263B50", Offset = "0x6262F50", VA = "0x186263B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly APLACKDCONJ.JJKIPOEEFDN LNMNDPADFKI;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly EFCCEFGBMAN FMFDPEBJPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private FDNFIBJMANG MLDJENEOCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private PJADLBKLPBG JNEONJAEABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private CHMLDJDCJFC FDEKFCDLHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private IHDPFKHBMBC DAHGDHMNEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private GOHDAHNCEBE JKLMJJBOHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private long FKMEGLPLAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private PIAJGIGEKMJ CNHOBJMJOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private bool PBIJBKBILLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private Task BJMEAJLKMCF;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private EAKNENHMOPB DHPIDOBBJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x625BFA0", Offset = "0x625B3A0", VA = "0x18625BFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool MHPECLABMBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA1F5E0", Offset = "0xA1E9E0", VA = "0x180A1F5E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x625C220", Offset = "0x625B620", VA = "0x18625C220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x625C6A0", Offset = "0x625BAA0", VA = "0x18625C6A0", Slot = "4")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x625BBC0", Offset = "0x625AFC0", VA = "0x18625BBC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x625BE60", Offset = "0x625B260", VA = "0x18625BE60")]
	[AsyncStateMachine(typeof(GNGDDDADGPE))]
	private Task HGFKDKLMJJM(FNPDPJOBFPE CNBCIAKNFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x625C060", Offset = "0x625B460", VA = "0x18625C060")]
	private void KJNCNLDIDBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x625B890", Offset = "0x625AC90", VA = "0x18625B890")]
	private void ABIBEMKLDKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x625BA30", Offset = "0x625AE30", VA = "0x18625BA30")]
	private void DDIAMPJNFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x625BFF0", Offset = "0x625B3F0", VA = "0x18625BFF0")]
	private bool JJHGOFFDNHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x625C230", Offset = "0x625B630", VA = "0x18625C230")]
	[AsyncStateMachine(typeof(APDECFPLBBG))]
	private void LMDELCJKGCG(int JNIFDEFBBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x625C300", Offset = "0x625B700", VA = "0x18625C300")]
	private void LMFGJBGGDJC([Out] IDisposable BECCACCLPAK, [Out] IDisposable CKHGCAMJPMD, [Out] IDisposable KPALLBFKION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x625C590", Offset = "0x625B990", VA = "0x18625C590")]
	private bool MKALCDPHGJE(BDKFBCEFMIP IPPDJPKCJOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x625BF50", Offset = "0x625B350", VA = "0x18625BF50")]
	private void HLGNDBGCDPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x625BD30", Offset = "0x625B130", VA = "0x18625BD30")]
	[AsyncStateMachine(typeof(EOBIMNIBDAA))]
	private Task EMONMPCDHBN(BDKFBCEFMIP IPPDJPKCJOH, AONGELAAJMM IPDAHDOFOCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x625CD10", Offset = "0x625C110", VA = "0x18625CD10")]
	public APDBHGEABAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[UnityEngine.Scripting.Preserve]
internal sealed class KLCJDIPHMAI : KFPPMIJFDDH, EIAHCHMNJNI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct LOEMJHDIOJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public AsyncTaskMethodBuilder<BNGAGHFEKJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public KLCJDIPHMAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<BNGAGHFEKJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x62755C0", Offset = "0x62749C0", VA = "0x1862755C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6275810", Offset = "0x6274C10", VA = "0x186275810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class HIOEKCBEOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public OCJBGBEKDGN message;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HIOEKCBEOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x626B980", Offset = "0x626AD80", VA = "0x18626B980")]
		internal object ABJLCBGFJJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class KHJIBPGLDDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public OCJBGBEKDGN messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public KHJIBPGLDDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6272770", Offset = "0x6271B70", VA = "0x186272770")]
		internal object NAMMOEFIOHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class GKAGLPCCIAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public OCJBGBEKDGN request;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public GKAGLPCCIAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x62677F0", Offset = "0x6266BF0", VA = "0x1862677F0")]
		internal object KEDLEOINEKP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct ABFFMJMHLBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public OCJBGBEKDGN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public KLCJDIPHMAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<KHKLNHABCFF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6259FC0", Offset = "0x62593C0", VA = "0x186259FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x625A8D0", Offset = "0x6259CD0", VA = "0x18625A8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class ALEIPIHGHLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public OCJBGBEKDGN operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ALEIPIHGHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x625B6F0", Offset = "0x625AAF0", VA = "0x18625B6F0")]
		internal object KIBIBOPAOBP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct BHJEFAJLEME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public OCJBGBEKDGN operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public KLCJDIPHMAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private EMNADKEEBNM <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<OCJBGBEKDGN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x625E060", Offset = "0x625D460", VA = "0x18625E060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x625EC10", Offset = "0x625E010", VA = "0x18625EC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct GGIOCBFAMGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AsyncTaskMethodBuilder<KHKLNHABCFF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public KLCJDIPHMAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public OCJBGBEKDGN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private KHCHIAGHAFN.HJIHFDDNALO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private EMNADKEEBNM <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<OCJBGBEKDGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x6266AE0", Offset = "0x6265EE0", VA = "0x186266AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x6267000", Offset = "0x6266400", VA = "0x186267000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class JIENIEIJCKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public KHKLNHABCFF operation;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public JIENIEIJCKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6270F70", Offset = "0x6270370", VA = "0x186270F70")]
		internal object EMLGJICCPLM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct CHEJNJMNKGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public KHKLNHABCFF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public KLCJDIPHMAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private KGKDBPAMFIO<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x625FE20", Offset = "0x625F220", VA = "0x18625FE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x62604A0", Offset = "0x625F8A0", VA = "0x1862604A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class IOAHNLOBNEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public OCJBGBEKDGN request;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public IOAHNLOBNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6270850", Offset = "0x626FC50", VA = "0x186270850")]
		internal object JCKMPJIPMIL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class NCIBHKHENKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public OCJBGBEKDGN request;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public NCIBHKHENKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6276550", Offset = "0x6275950", VA = "0x186276550")]
		internal object DBEGJPCOFCK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private JLKCNOPLBDB MHDOMGOJADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private OBLLOKNJDCG PCAOMEPKOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private IJECOICGHPC EOKALGEBCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private IBLKHHFCHMM FOEGMELFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private TaskCompletionSource<BNGAGHFEKJK> EHOBMONFNFM;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6273AD0", Offset = "0x6272ED0", VA = "0x186273AD0", Slot = "7")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6272EE0", Offset = "0x62722E0", VA = "0x186272EE0", Slot = "6")]
	[AsyncStateMachine(typeof(LOEMJHDIOJH))]
	public Task<BNGAGHFEKJK> IHKDDKFAOEJ(CancellationToken PMHPJKLOCAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x62729F0", Offset = "0x6271DF0", VA = "0x1862729F0", Slot = "4")]
	public void BKOKNAKCJJN(OCJBGBEKDGN LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6273080", Offset = "0x6272480", VA = "0x186273080", Slot = "5")]
	public void JOEEPFMBAON(OCJBGBEKDGN IHDHJBIHKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x62727D0", Offset = "0x6271BD0", VA = "0x1862727D0")]
	[AsyncStateMachine(typeof(ABFFMJMHLBN))]
	private Task ANIPNGJPFCJ(OCJBGBEKDGN EJJHDDFDLOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x62739C0", Offset = "0x6272DC0", VA = "0x1862739C0")]
	[AsyncStateMachine(typeof(BHJEFAJLEME))]
	private Task OBKMJAJOHGO(OCJBGBEKDGN KLOJNJKHOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x6272D90", Offset = "0x6272190", VA = "0x186272D90")]
	[AsyncStateMachine(typeof(GGIOCBFAMGD))]
	private Task<KHKLNHABCFF> EEKGEMGBGKD(OCJBGBEKDGN EJJHDDFDLOL, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6272FF0", Offset = "0x62723F0", VA = "0x186272FF0")]
	private EMNADKEEBNM IINEDAKHLLH(OCJBGBEKDGN ABMIABCDNMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x62728D0", Offset = "0x6271CD0", VA = "0x1862728D0")]
	[AsyncStateMachine(typeof(CHEJNJMNKGM))]
	private Task APBJPLFIEAM(KHKLNHABCFF PLBKMELAPOA, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6273790", Offset = "0x6272B90", VA = "0x186273790")]
	private KHKLNHABCFF OACEAEPMNAI(OCJBGBEKDGN EJJHDDFDLOL, EMNADKEEBNM ADHOLEIKFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2431B80", Offset = "0x2430F80", VA = "0x182431B80")]
	private T EJPFBNKEHDC<T>(T LPCGJALKADL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x62733F0", Offset = "0x62727F0", VA = "0x1862733F0")]
	private KHKLNHABCFF NDDLAINIMCL(OCJBGBEKDGN EJJHDDFDLOL, EMNADKEEBNM ADHOLEIKFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public KLCJDIPHMAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[UnityEngine.Scripting.Preserve]
internal sealed class HGOLDGFMKGJ : OBLLOKNJDCG, EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class EMHFNDKDDEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public EMHFNDKDDEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6262370", Offset = "0x6261770", VA = "0x186262370")]
		internal object KLIMIPNJKCJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class CCAMCNMDNIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CCAMCNMDNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x625F660", Offset = "0x625EA60", VA = "0x18625F660")]
		internal object GDFFKPLLLJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private IBLKHHFCHMM FOEGMELFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private KBICEBOFMAL IIPFCEFGFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private KFPPMIJFDDH BJLLOGJJHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private JCCDJMCNDFD DDPFBAJJKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private ILDFOCCEHCO MOCNNBHFPLB;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x626B260", Offset = "0x626A660", VA = "0x18626B260", Slot = "6")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6269CE0", Offset = "0x62690E0", VA = "0x186269CE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x626A360", Offset = "0x6269760", VA = "0x18626A360", Slot = "4")]
	public PIGAAPDDGPE IEFOPAGOBCP(OCJBGBEKDGN BBKFPLEPCAN)
	{
		return default(PIGAAPDDGPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x62699F0", Offset = "0x6268DF0", VA = "0x1862699F0", Slot = "5")]
	public void BEDFEKLKCAN(Guid CEMPKOIGLIO, Task NLMOJCNFHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6269C10", Offset = "0x6269010", VA = "0x186269C10")]
	private void DLGHEDJKAAJ(byte APKGBOFIMJN, int IBKDIOPCGFF, object CDJEAMAGCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6269D90", Offset = "0x6269190", VA = "0x186269D90")]
	private void IDPKMPGNGOD(ILBHHNAIALA NBKAJLKMOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x626AF40", Offset = "0x626A340", VA = "0x18626AF40")]
	private void OHEGNEEEOAE(ILBHHNAIALA NBKAJLKMOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x626B3D0", Offset = "0x626A7D0", VA = "0x18626B3D0")]
	private void OMOGMDOJHLC(ILBHHNAIALA NBKAJLKMOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6269790", Offset = "0x6268B90", VA = "0x186269790")]
	private KLJJBFIAHEC AIPBOPPOHDE(OCJBGBEKDGN ABMIABCDNMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x626AA50", Offset = "0x6269E50", VA = "0x18626AA50")]
	private void NJGMGKBDOPE(OCJBGBEKDGN KLOJNJKHOKE, KLJJBFIAHEC HMBGGNACLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x626AC80", Offset = "0x626A080", VA = "0x18626AC80")]
	private bool NNMEAKPIAFF(OCJBGBEKDGN KLOJNJKHOKE, KLJJBFIAHEC HMBGGNACLEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x626B620", Offset = "0x626AA20", VA = "0x18626B620")]
	private bool PKKGHGIKKBD(OCJBGBEKDGN GILKILLNEEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x626A7B0", Offset = "0x6269BB0", VA = "0x18626A7B0")]
	private bool KLPKCLPJMCD(byte APKGBOFIMJN, ExitGames.Client.Photon.Hashtable NBKAJLKMOGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public HGOLDGFMKGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[UnityEngine.Scripting.Preserve]
internal sealed class MAIKPCFNAEN : AKGKACKHBAH, EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class GFKIKHBHEOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public BNGAGHFEKJK operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public MAIKPCFNAEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public OCJBGBEKDGN roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public GFKIKHBHEOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6266A70", Offset = "0x6265E70", VA = "0x186266A70")]
		internal object HKMPOFKCMJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x6266940", Offset = "0x6265D40", VA = "0x186266940")]
		internal object HBAIHAIBBKL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct CEJJMFPACCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AsyncTaskMethodBuilder<KLJJBFIAHEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public MAIKPCFNAEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public OCJBGBEKDGN roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private TaskAwaiter<KLJJBFIAHEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x625F6D0", Offset = "0x625EAD0", VA = "0x18625F6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x625FDB0", Offset = "0x625F1B0", VA = "0x18625FDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class ILKFAGFOPPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public BNGAGHFEKJK operationType;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ILKFAGFOPPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x62707E0", Offset = "0x626FBE0", VA = "0x1862707E0")]
		internal object OBOFEFBNGDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class IHIHAMKECEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public OCJBGBEKDGN request;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public IHIHAMKECEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x626EDC0", Offset = "0x626E1C0", VA = "0x18626EDC0")]
		internal object OOJJPKOLPJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x626ED50", Offset = "0x626E150", VA = "0x18626ED50")]
		internal object LHKOHFCCDBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x626ECE0", Offset = "0x626E0E0", VA = "0x18626ECE0")]
		internal object IJKOICKCBKF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct IFLOBFOMKJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public AsyncTaskMethodBuilder<KLJJBFIAHEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public OCJBGBEKDGN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public MAIKPCFNAEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private IHIHAMKECEI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private PIGAAPDDGPE <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private KLJJBFIAHEC <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private TaskAwaiter<(KLJJBFIAHEC validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x626E370", Offset = "0x626D770", VA = "0x18626E370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x626EC70", Offset = "0x626E070", VA = "0x18626EC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private IBLKHHFCHMM FOEGMELFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private KBICEBOFMAL IIPFCEFGFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private OBLLOKNJDCG PCAOMEPKOGA;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6275FB0", Offset = "0x62753B0", VA = "0x186275FB0", Slot = "5")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6275B40", Offset = "0x6274F40", VA = "0x186275B40", Slot = "4")]
	[AsyncStateMachine(typeof(CEJJMFPACCC))]
	private Task<KLJJBFIAHEC> AFIGOOGOAJA(OCJBGBEKDGN ABMIABCDNMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6275DA0", Offset = "0x62751A0", VA = "0x186275DA0")]
	private bool NPGBNBAAIIB(BNGAGHFEKJK EGJBIIEJEOI, [Out] KLJJBFIAHEC BBHPNPGLHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6275C60", Offset = "0x6275060", VA = "0x186275C60")]
	[AsyncStateMachine(typeof(IFLOBFOMKJP))]
	private Task<KLJJBFIAHEC> KOBDKBONKNA(OCJBGBEKDGN EJJHDDFDLOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public MAIKPCFNAEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class KBFNILLHKDO : BEBAGOEJLNM, EIAHCHMNJNI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct CIJFPIBBDGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<ABMIDKAKKGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public BDKFBCEFMIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public KBFNILLHKDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter<FDKPOLPBLFH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6260500", Offset = "0x625F900", VA = "0x186260500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x62609B0", Offset = "0x625FDB0", VA = "0x1862609B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class FPIDGOHDKPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public FPIDGOHDKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6266310", Offset = "0x6265710", VA = "0x186266310")]
		internal object JKOCNCMFJFE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct JHJJLBBHMEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public AsyncTaskMethodBuilder<FDKPOLPBLFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public KBFNILLHKDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public BDKFBCEFMIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private FPIDGOHDKPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter<FDKPOLPBLFH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x62708B0", Offset = "0x626FCB0", VA = "0x1862708B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6270EA0", Offset = "0x62702A0", VA = "0x186270EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class LKMKMOIMFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public LKMKMOIMFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x12CF570", Offset = "0x12CE970", VA = "0x1812CF570")]
		internal bool OMMHJBIBDHJ(DFEHFHGPFLB sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private CHMLDJDCJFC FDEKFCDLHEC;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static readonly (IGNOFONIPFC superRoomData, long subRoomDataSaveId) JAEMLHOGONI;

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x62722F0", Offset = "0x62716F0", VA = "0x1862722F0", Slot = "5")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6271EF0", Offset = "0x62712F0", VA = "0x186271EF0", Slot = "4")]
	[AsyncStateMachine(typeof(CIJFPIBBDGC))]
	public Task<ABMIDKAKKGN> BHHHPNDNNBA(KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, BDKFBCEFMIP DNLDHEDCLAM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6272190", Offset = "0x6271590", VA = "0x186272190")]
	[AsyncStateMachine(typeof(JHJJLBBHMEO))]
	private Task<FDKPOLPBLFH> OFCPHNCIMEO(BDKFBCEFMIP DNLDHEDCLAM, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6272050", Offset = "0x6271450", VA = "0x186272050")]
	private ABMIDKAKKGN NJEPFKCPIII(BDKFBCEFMIP DNLDHEDCLAM, FDKPOLPBLFH COJBLDLANGK, long CAHHMNIGLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6272360", Offset = "0x6271760", VA = "0x186272360")]
	private (IGNOFONIPFC, long) PLAJNFKNEKI(BDKFBCEFMIP DNLDHEDCLAM, FDKPOLPBLFH COJBLDLANGK, long CAHHMNIGLJL)
	{
		return default((IGNOFONIPFC, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public KBFNILLHKDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal sealed class JIKLFOEFBIH : IJECOICGHPC, EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class DFLJHJNKPGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public OCJBGBEKDGN request;

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public DFLJHJNKPGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6260D80", Offset = "0x6260180", VA = "0x186260D80")]
		internal object ANDJLCDLANP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct LEJBOJFPPGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public AsyncTaskMethodBuilder<OCJBGBEKDGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public OCJBGBEKDGN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public JIKLFOEFBIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public EMNADKEEBNM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<OCJBGBEKDGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6273E20", Offset = "0x6273220", VA = "0x186273E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6274460", Offset = "0x6273860", VA = "0x186274460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct DHPOHFMHJHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<OCJBGBEKDGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public JIKLFOEFBIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public EMNADKEEBNM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<MHKBIEKGFFL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x62613A0", Offset = "0x62607A0", VA = "0x1862613A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x62619D0", Offset = "0x6260DD0", VA = "0x1862619D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class ILHHJLCFHGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public OCJBGBEKDGN request;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ILHHJLCFHGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6270780", Offset = "0x626FB80", VA = "0x186270780")]
		internal object PBHIPNOMLFP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct GKJHMDMLCOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<OCJBGBEKDGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public OCJBGBEKDGN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public JIKLFOEFBIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public EMNADKEEBNM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private CBKIKLFMBOI <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private BLKBBCCMMAA <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<MHKBIEKGFFL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6267850", Offset = "0x6266C50", VA = "0x186267850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6268470", Offset = "0x6267870", VA = "0x186268470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private IBLKHHFCHMM FOEGMELFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private CGFOCHHGACM ODCOILMPPOI;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private CGKFPLEFIDK JMEKLGFFDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x62716F0", Offset = "0x6270AF0", VA = "0x1862716F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x62717B0", Offset = "0x6270BB0", VA = "0x1862717B0", Slot = "8")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6271590", Offset = "0x6270990", VA = "0x186271590", Slot = "4")]
	[AsyncStateMachine(typeof(LEJBOJFPPGH))]
	public Task<OCJBGBEKDGN> FLPPLMIJHHL(OCJBGBEKDGN EJJHDDFDLOL, EMNADKEEBNM ADHOLEIKFEH, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6271840", Offset = "0x6270C40", VA = "0x186271840", Slot = "5")]
	[AsyncStateMachine(typeof(DHPOHFMHJHI))]
	public Task<OCJBGBEKDGN> PBJCOPNEFOD(CancellationToken OMFABMCIOAC, EMNADKEEBNM ADHOLEIKFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6271220", Offset = "0x6270620", VA = "0x186271220", Slot = "6")]
	public HNIKGGHLOAK BLMNOBGJOOF(KHKLNHABCFF HGMMLGNGDDH, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x6270FF0", Offset = "0x62703F0", VA = "0x186270FF0", Slot = "7")]
	public HNIKGGHLOAK BGKPEKLIEAC(KHKLNHABCFF HGMMLGNGDDH, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6271430", Offset = "0x6270830", VA = "0x186271430")]
	[AsyncStateMachine(typeof(GKJHMDMLCOD))]
	private Task<OCJBGBEKDGN> DCFLHOCNMGM(OCJBGBEKDGN EJJHDDFDLOL, EMNADKEEBNM ADHOLEIKFEH, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x23DD2C0", Offset = "0x23DC6C0", VA = "0x1823DD2C0")]
	private static byte[] OMJKJDOLNOG(OCJBGBEKDGN LMJAPBNMKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public JIKLFOEFBIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[UnityEngine.Scripting.Preserve]
internal sealed class OFHPFBFKEPO : KBICEBOFMAL, EIAHCHMNJNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private NEAGOFNAEJH GCPBDNGFMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private IBLKHHFCHMM FOEGMELFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private JLKCNOPLBDB MHDOMGOJADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private OGFJBPHFJEB KBNKGFDBHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private CHMLDJDCJFC FDEKFCDLHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private GOHDAHNCEBE JKLMJJBOHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private LMCCFNCOEKH LJLIPNKPPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private IHDPFKHBMBC DAHGDHMNEHE;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private EAKNENHMOPB DHPIDOBBJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6277A10", Offset = "0x6276E10", VA = "0x186277A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private static KLJJBFIAHEC EMNGAOCOKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x62645F0", Offset = "0x62639F0", VA = "0x1862645F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6277A60", Offset = "0x6276E60", VA = "0x186277A60", Slot = "6")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x62778A0", Offset = "0x6276CA0", VA = "0x1862778A0", Slot = "4")]
	public KLJJBFIAHEC HDAEAGEAACH(KEMOGAOMDFA LFELICAKALB, BNGAGHFEKJK FCOLEJMPJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x62775D0", Offset = "0x62769D0", VA = "0x1862775D0", Slot = "5")]
	public KLJJBFIAHEC AKNPMLJEAOI(KEMOGAOMDFA DJEGLCKHILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6264590", Offset = "0x6263990", VA = "0x186264590")]
	private static KLJJBFIAHEC GCOKGODAFLG(ILLGLLDLALE GDMNFOHPCNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public OFHPFBFKEPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class CLDPKCGIIPI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6260A20", Offset = "0x625FE20", VA = "0x186260A20")]
	public CLDPKCGIIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x58EB500", Offset = "0x58EA900", VA = "0x1858EB500")]
	public CLDPKCGIIPI(string LMJAPBNMKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class ILFLEFDMNNC : AGJJPDEKINC, EIAHCHMNJNI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct HDAIIINEFBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<KLJJBFIAHEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public ILFLEFDMNNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public BJHHJKOCPBD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private KGKDBPAMFIO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private PLDHEJHFNND <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private TaskAwaiter<KLJJBFIAHEC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x6268A40", Offset = "0x6267E40", VA = "0x186268A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x6269600", Offset = "0x6268A00", VA = "0x186269600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct BLFPLMCHGPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public ILFLEFDMNNC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x625EEB0", Offset = "0x625E2B0", VA = "0x18625EEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x625F600", Offset = "0x625EA00", VA = "0x18625F600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct AFPLGDEFPON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public ILFLEFDMNNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x625B180", Offset = "0x625A580", VA = "0x18625B180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x625B690", Offset = "0x625AA90", VA = "0x18625B690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct DLNCGEJLGCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public ILFLEFDMNNC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6261A40", Offset = "0x6260E40", VA = "0x186261A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6262190", Offset = "0x6261590", VA = "0x186262190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct NPOMOGLIPMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public ILFLEFDMNNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x62772C0", Offset = "0x62766C0", VA = "0x1862772C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6277460", Offset = "0x6276860", VA = "0x186277460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct GJAFJKMJMCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public ILFLEFDMNNC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6267070", Offset = "0x6266470", VA = "0x186267070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6267790", Offset = "0x6266B90", VA = "0x186267790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct NNIKLHBILJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public ILFLEFDMNNC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6276DF0", Offset = "0x62761F0", VA = "0x186276DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6277260", Offset = "0x6276660", VA = "0x186277260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct FHKGMKPNLML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public ILFLEFDMNNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public ANDGBBKHDNM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private KGKDBPAMFIO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6263DD0", Offset = "0x62631D0", VA = "0x186263DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6264310", Offset = "0x6263710", VA = "0x186264310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private IBLKHHFCHMM FOEGMELFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private CHMLDJDCJFC FDEKFCDLHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private IJECOICGHPC EOKALGEBCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private JLKCNOPLBDB MHDOMGOJADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private LMCCFNCOEKH LJLIPNKPPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private CancellationTokenSource KKJGJECNGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private Task IGAMGOPNGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private TaskCompletionSource<int> BJOJEFHIEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private int JNFFNHFNNOL;

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x62704E0", Offset = "0x626F8E0", VA = "0x1862704E0", Slot = "6")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x1AFDA50", Offset = "0x1AFCE50", VA = "0x181AFDA50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x626FA40", Offset = "0x626EE40", VA = "0x18626FA40")]
	private void ELKHGLMHHNJ(float CNOEGFMLJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x626FD20", Offset = "0x626F120", VA = "0x18626FD20", Slot = "4")]
	[AsyncStateMachine(typeof(HDAIIINEFBK))]
	public Task<KLJJBFIAHEC> ICCJJPKLJOA(BJHHJKOCPBD CIOPFHLILOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6270690", Offset = "0x626FA90", VA = "0x186270690", Slot = "5")]
	[AsyncStateMachine(typeof(BLFPLMCHGPH))]
	public Task PLIJNPLNGGF([Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x1AFDA50", Offset = "0x1AFCE50", VA = "0x181AFDA50")]
	public void ANEJMDOCFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x626F780", Offset = "0x626EB80", VA = "0x18626F780")]
	private PLDHEJHFNND ANNJJJGCDMP(BJHHJKOCPBD CIOPFHLILOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x626FC30", Offset = "0x626F030", VA = "0x18626FC30")]
	[AsyncStateMachine(typeof(AFPLGDEFPON))]
	private Task HIMEAMENDDC(OKOIPJPAMDA JMBKGKDJDLG, CancellationToken CKCHEDNFLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x626FE50", Offset = "0x626F250", VA = "0x18626FE50")]
	[AsyncStateMachine(typeof(DLNCGEJLGCJ))]
	private Task LLCDNGHNJHF(CancellationToken CKCHEDNFLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x626F950", Offset = "0x626ED50", VA = "0x18626F950")]
	[AsyncStateMachine(typeof(NPOMOGLIPMA))]
	private Task EJNAAOHGEOH([Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x62703F0", Offset = "0x626F7F0", VA = "0x1862703F0")]
	[AsyncStateMachine(typeof(GJAFJKMJMCJ))]
	private Task NPCDDICNJPM(CancellationToken CKCHEDNFLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x62702F0", Offset = "0x626F6F0", VA = "0x1862702F0")]
	[AsyncStateMachine(typeof(NNIKLHBILJA))]
	private Task NKKLOBCFIOL(CancellationToken PMPAIFIMNAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x626FF50", Offset = "0x626F350", VA = "0x18626FF50")]
	private Task MNLAIHJMPDH(ANDGBBKHDNM CNBEKNILNAO, CancellationToken CKCHEDNFLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x62701E0", Offset = "0x626F5E0", VA = "0x1862701E0")]
	[AsyncStateMachine(typeof(FHKGMKPNLML))]
	private Task NJEKGNLHPBJ(ANDGBBKHDNM CNBEKNILNAO, CancellationToken CKCHEDNFLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x626FB20", Offset = "0x626EF20", VA = "0x18626FB20")]
	private bool GEAJPMDLFLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public ILFLEFDMNNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[UnityEngine.Scripting.Preserve]
internal class FPJKLGIPFON : OGFJBPHFJEB, EIAHCHMNJNI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct DHKAAJLJHFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public FPJKLGIPFON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private KGKDBPAMFIO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6260DE0", Offset = "0x62601E0", VA = "0x186260DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6261340", Offset = "0x6260740", VA = "0x186261340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private LMGMKFINJJP DMBPGIHBDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private KBICEBOFMAL IIPFCEFGFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private IJECOICGHPC EOKALGEBCIH;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6266660", Offset = "0x6265A60", VA = "0x186266660", Slot = "6")]
	public void OMELHDOHHCI(FGMCJCFGAPG LGOFKBPFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x62663C0", Offset = "0x62657C0", VA = "0x1862663C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6266410", Offset = "0x6265810", VA = "0x186266410", Slot = "5")]
	[AsyncStateMachine(typeof(DHKAAJLJHFB))]
	public Task FNCCHDEPNGK(string EOEPLCPMJAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x6266510", Offset = "0x6265910", VA = "0x186266510", Slot = "4")]
	public KLJJBFIAHEC GEAJPMDLFLD(KEMOGAOMDFA LFELICAKALB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6266570", Offset = "0x6265970", VA = "0x186266570")]
	private JOBIKGLIGMH MNAONBFNIAP(string EOEPLCPMJAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public FPJKLGIPFON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class ADHNIJHKLNM
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x625AF80", Offset = "0x625A380", VA = "0x18625AF80")]
	public static void PLGHEMBKHOP(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x625A930", Offset = "0x6259D30", VA = "0x18625A930")]
	internal static void CCLNLCGEDOO(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x625AA50", Offset = "0x6259E50", VA = "0x18625AA50")]
	internal static void CPLAPOOGJAB(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x625AB30", Offset = "0x6259F30", VA = "0x18625AB30")]
	internal static void ODLNIAEJCLM(BFGBHKPNKEI MIPCMNILFEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal class HNMBNLNAECN : HKJDBLLBPCK<OCJBGBEKDGN>
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class LGKMIOCANNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public OCJBGBEKDGN message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public LGKMIOCANNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6274A70", Offset = "0x6273E70", VA = "0x186274A70")]
		internal object KKACBPNCHCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly HNMBNLNAECN OMCMBELJBID;

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x626D230", Offset = "0x626C630", VA = "0x18626D230")]
	public ExitGames.Client.Photon.Hashtable MFIMBGNEKOH(OCJBGBEKDGN LMJAPBNMKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x626CDC0", Offset = "0x626C1C0", VA = "0x18626CDC0", Slot = "5")]
	protected override void EKGIGGKJHOL(OCJBGBEKDGN LMJAPBNMKLG, IDictionary<object, object> OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x626CEF0", Offset = "0x626C2F0", VA = "0x18626CEF0", Slot = "6")]
	public override OCJBGBEKDGN HNNKJEMPCFP(IDictionary<object, object> OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x626D120", Offset = "0x626C520", VA = "0x18626D120")]
	private static void IJCNCIMJJJN(string BMGKNOIDKFN, OCJBGBEKDGN LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x626D600", Offset = "0x626CA00", VA = "0x18626D600")]
	public HNMBNLNAECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x626D2C0", Offset = "0x626C6C0", VA = "0x18626D2C0")]
	[CompilerGenerated]
	internal static string POENIOBMNAO(ABMIDKAKKGN CJFCIOOMJGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class FKEAIIDFOPG
{
	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public static KLJJBFIAHEC EMNGAOCOKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x62645F0", Offset = "0x62639F0", VA = "0x1862645F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6264570", Offset = "0x6263970", VA = "0x186264570")]
	public static bool DNJBCOFOLEJ(this KLJJBFIAHEC HMBGGNACLEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6264590", Offset = "0x6263990", VA = "0x186264590")]
	public static KLJJBFIAHEC GCOKGODAFLG(ILLGLLDLALE EBPNLHHPBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6264370", Offset = "0x6263770", VA = "0x186264370")]
	public static KLJJBFIAHEC APMGKAAAIJK(IEnumerable<KLJJBFIAHEC> EDHJAAMHHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6264650", Offset = "0x6263A50", VA = "0x186264650")]
	public static string NEKDJFLIJMK(this KLJJBFIAHEC BBHPNPGLHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class IJDGBEDBJBE : KKMLMHIMDCA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public delegate KLJJBFIAHEC IMHODCGEFJM([NotNull] KEMOGAOMDFA IDPEOPPHCPM);

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class PGAMHFLDHKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public KEMOGAOMDFA photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public PGAMHFLDHKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5AE4F30", Offset = "0x5AE4330", VA = "0x185AE4F30")]
		internal KLJJBFIAHEC ALNALHLIAIO(IMHODCGEFJM v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	protected readonly HashSet<IMHODCGEFJM> MADPFHJPKDC;

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x626F2A0", Offset = "0x626E6A0", VA = "0x18626F2A0", Slot = "4")]
	public void PPPEOMDHEAC(IMHODCGEFJM KAAHNMFFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x626EF50", Offset = "0x626E350", VA = "0x18626EF50", Slot = "5")]
	public void BGMIFKBEJAN(IMHODCGEFJM KAAHNMFFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x626EFB0", Offset = "0x626E3B0", VA = "0x18626EFB0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x626F000", Offset = "0x626E400", VA = "0x18626F000")]
	protected KLJJBFIAHEC IOOOLHBDICA(KEMOGAOMDFA DJEGLCKHILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x626F300", Offset = "0x626E700", VA = "0x18626F300")]
	protected IJDGBEDBJBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class IIMIMIELKKF : IJDGBEDBJBE, NEAGOFNAEJH, KKMLMHIMDCA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class GOCPNNPNMJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public KLJJBFIAHEC result;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public GOCPNNPNMJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x62689E0", Offset = "0x6267DE0", VA = "0x1862689E0")]
		internal object PAFMJLFPFNJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x626EF40", Offset = "0x626E340", VA = "0x18626EF40")]
	[UnityEngine.Scripting.Preserve]
	public IIMIMIELKKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x626EE30", Offset = "0x626E230", VA = "0x18626EE30", Slot = "8")]
	public KLJJBFIAHEC OCHNKCOMIFK(KEMOGAOMDFA DJEGLCKHILF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class OCCAHINMOFM : IJDGBEDBJBE, LMGMKFINJJP, KKMLMHIMDCA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class BEDNDNJPLBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public KLJJBFIAHEC result;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public BEDNDNJPLBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x625E000", Offset = "0x625D400", VA = "0x18625E000")]
		internal object EDMECFIAODF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x626EF40", Offset = "0x626E340", VA = "0x18626EF40")]
	[UnityEngine.Scripting.Preserve]
	public OCCAHINMOFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x62774C0", Offset = "0x62768C0", VA = "0x1862774C0", Slot = "8")]
	public KLJJBFIAHEC GEAJPMDLFLD(KEMOGAOMDFA ENPJGNCLGBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal static class LAGOOEPPMGH
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class AABFNODFHLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public KGKDBPAMFIO<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public AABFNODFHLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x6259F40", Offset = "0x6259340", VA = "0x186259F40")]
		internal object NHCNHNAKGML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6273C80", Offset = "0x6273080", VA = "0x186273C80")]
	public static KGKDBPAMFIO<string> EFNBBHDGMHI(FJOGIBEAJHF AABDFOONPNL, [Optional] string LEPIIJFBBEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6273BC0", Offset = "0x6272FC0", VA = "0x186273BC0")]
	public static void CNOCBHEDNAH(KGKDBPAMFIO<string> LHJMFKIBCKM, FJOGIBEAJHF AABDFOONPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6273D60", Offset = "0x6273160", VA = "0x186273D60")]
	public static string JFJEANPCFEE(OCJBGBEKDGN ABMIABCDNMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal static class ALNCDGBNADC
{
	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x625B760", Offset = "0x625AB60", VA = "0x18625B760")]
	public static void CHMNCKMPHFN(this IBLKHHFCHMM FOEGMELFMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x625B750", Offset = "0x625AB50", VA = "0x18625B750")]
	public static void CFJEBIEHHPK(this IBLKHHFCHMM FOEGMELFMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x625B770", Offset = "0x625AB70", VA = "0x18625B770")]
	private static void EDEMNLGHEMK(this IBLKHHFCHMM FOEGMELFMCF, bool CJBJGNNEOHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class JOOLAKBCDNM : FBPJLMGMEAD, CGKOGDMBEJM, GGDBFAOHHOP, MBEDGJOOHMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private readonly CGKOGDMBEJM EECHPGGHJIO;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public KEMOGAOMDFA DIDGKACBIBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6271C90", Offset = "0x6271090", VA = "0x186271C90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int AGPLJLIIDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6271E00", Offset = "0x6271200", VA = "0x186271E00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int NKDCCNHHOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x6271A20", Offset = "0x6270E20", VA = "0x186271A20", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool CKDAOOBHLAN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int HFDGLBGEHAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x8015E0", Offset = "0x8009E0", VA = "0x1808015E0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event LPMHIDAMPFI.KFNJOKHBBGE DHGHAFNIHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event EPMDEFCNHKG ABCNCCCLMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x6271A70", Offset = "0x6270E70", VA = "0x186271A70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x6271E50", Offset = "0x6271250", VA = "0x186271E50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> EJBDMMHHAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<KEMOGAOMDFA> DBHFMMEHIIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action BBGDLPDLOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x6271B10", Offset = "0x6270F10", VA = "0x186271B10", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x6271980", Offset = "0x6270D80", VA = "0x186271980", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xBA6FD0", Offset = "0xBA63D0", VA = "0x180BA6FD0")]
	public JOOLAKBCDNM(CGKOGDMBEJM EECHPGGHJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6271CE0", Offset = "0x62710E0", VA = "0x186271CE0", Slot = "8")]
	public bool GALDAMPMKJH(byte APKGBOFIMJN, ExitGames.Client.Photon.Hashtable DBAPHAHGJKL, GFKOIBOEFAL DBBEAIAHGNI, SendOptions NDCKGFLAPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6271BB0", Offset = "0x6270FB0", VA = "0x186271BB0", Slot = "16")]
	public KEMOGAOMDFA DENMDPALLCK(int KHAOBMIAMHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "19")]
	public void GCNMBIFCAMA(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "20")]
	public void JBOGJGNOGOM(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "21")]
	public void DCCMOGHCDCI(object IBLOMPOENGH, bool KALIJOLFMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6271D90", Offset = "0x6271190", VA = "0x186271D90", Slot = "22")]
	public IDisposable IOIOOOKFLBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "23")]
	private bool OMNOLEJHCFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "24")]
	public void CFENIACEOPJ(StringBuilder OLILNHNPHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6271DE0", Offset = "0x62711E0", VA = "0x186271DE0", Slot = "25")]
	public bool MHCNLNBGKEK(bool CCJEHMIGOPL, [Out] string NJAPBBBJJNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0xA95CD0", Offset = "0xA950D0", VA = "0x180A95CD0", Slot = "28")]
	public void JFNGPBFNIMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal struct ILBHHNAIALA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private readonly IDictionary<object, object> NBKAJLKMOGF;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D3110", Offset = "0x7D2510", VA = "0x1807D3110")]
	public ILBHHNAIALA(IDictionary<object, object> NBKAJLKMOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x626F5E0", Offset = "0x626E9E0", VA = "0x18626F5E0")]
	public bool LAGGLDBPMKI([Out] OCJBGBEKDGN LMJAPBNMKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x626F530", Offset = "0x626E930", VA = "0x18626F530")]
	public Guid KNHMEHKIFEF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x626F3F0", Offset = "0x626E7F0", VA = "0x18626F3F0")]
	public KLJJBFIAHEC GGGJALELFKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x626F690", Offset = "0x626EA90", VA = "0x18626F690")]
	public static ExitGames.Client.Photon.Hashtable PJBIIEEDKDI(OCJBGBEKDGN LMJAPBNMKLG, KLJJBFIAHEC HMBGGNACLEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class ENJPKOHKJGJ
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6262A60", Offset = "0x6261E60", VA = "0x186262A60")]
	public static bool DPJLGPIHPAO(this BDKFBCEFMIP AMBGDFJLCDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal struct LPCLAHIKKBG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct BILPKPJHONI : IAsyncStateMachine
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
		public LPCLAHIKKBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x625EC70", Offset = "0x625E070", VA = "0x18625EC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x625EE50", Offset = "0x625E250", VA = "0x18625EE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private readonly CancellationTokenSource HFJACFBDGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private Task DJNEDNIILKC;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool ADBIFDDOPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x6275880", Offset = "0x6274C80", VA = "0x186275880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6275A10", Offset = "0x6274E10", VA = "0x186275A10")]
	public LPCLAHIKKBG(CancellationToken OMFABMCIOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6275900", Offset = "0x6274D00", VA = "0x186275900")]
	[AsyncStateMachine(typeof(BILPKPJHONI))]
	public Task OKPFBLJJCEM(Func<CancellationToken, List<Task>> FFCBHCFEDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x62758B0", Offset = "0x6274CB0", VA = "0x1862758B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public readonly struct JPIEJFPOKCJ<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct PFFJHBLLNOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<CAHCBJHECPF<TData>, PGBNOEKHDBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public JPIEJFPOKCJ<TGetDataArg, TData> <>4__this;

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
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private TaskAwaiter<MEEAMGFNJIM<byte[], PGBNOEKHDBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C4C0", Offset = "0x3E3B8C0", VA = "0x183E3C4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x3E3DEC0", Offset = "0x3E3D2C0", VA = "0x183E3DEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private readonly ICANMBKACPH<TGetDataArg, TData> BOAEKCBHIIP;

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7D3110", Offset = "0x7D2510", VA = "0x1807D3110")]
	internal JPIEJFPOKCJ(ICANMBKACPH<TGetDataArg, TData> KELDMPHCCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x37B4A30", Offset = "0x37B3E30", VA = "0x1837B4A30")]
	[AsyncStateMachine(typeof(JPIEJFPOKCJ<, >.PFFJHBLLNOA))]
	public Task<MEEAMGFNJIM<CAHCBJHECPF<TData>, PGBNOEKHDBP>> EDIIPHCHMGG(TGetDataArg LIFDGOACBCI, string DHKHFMPLEFI, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class FHMHBDGLEDG
{
	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x214CF60", Offset = "0x214C360", VA = "0x18214CF60")]
	public static JPIEJFPOKCJ<TGetDataArg, TData> CLFIPFKIGEN<TGetDataArg, TData>(ICANMBKACPH<TGetDataArg, TData> KELDMPHCCLC)
	{
		return default(JPIEJFPOKCJ<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct HNCCCLFKMDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public readonly int JPHDIMILEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public readonly int? CLGLKDJPGJH;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x38AB990", Offset = "0x38AAD90", VA = "0x1838AB990")]
	public HNCCCLFKMDO(int ELKEEAHOLKC, [Optional] int? PMOALIKGIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x626B9E0", Offset = "0x626ADE0", VA = "0x18626B9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface CJMKDCDNAIM<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPBGIOAGICI();

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CJMKDCDNAIM<T> ALPCJMNJHBC(string BCBCBAEOENM);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CJMKDCDNAIM<T> CGBPCMCIMBN(ONABGJJJPCF<T> IIHLDDOPJHM);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CJMKDCDNAIM<T> ACCGNHFAOBJ(int BCIJBMOMCKL);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CJMKDCDNAIM<T> LIEKJBDAABK(int BCIJBMOMCKL, OKCHCCDOGCN<T> IGKPNLBFOPL);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface EFMGDAKFBAE
{
	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CJMKDCDNAIM<T> MECBDHIHIDL<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NBHAGIHNLPF GEJMEGGLGLA(Exception FLMBJDOBLFE);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HNCCCLFKMDO JCIDALGHDLK(Exception FLMBJDOBLFE);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public delegate string ONABGJJJPCF<in T>(T FLMBJDOBLFE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate int OKCHCCDOGCN<in T>(T FLMBJDOBLFE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class FKICCNHFKED : EFMGDAKFBAE
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private delegate string EGNLMNPLEJB(Exception FLMBJDOBLFE);

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate int DLLLAKLCDDO(Exception FLMBJDOBLFE);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private class MJELGKBFKFI<T> : CJMKDCDNAIM<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class GEEEEIAOCMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public GEEEEIAOCMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
			internal string JCONDFGLKOM(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class FEBCLDIHMMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public ONABGJJJPCF<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public FEBCLDIHMMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x339BC10", Offset = "0x339B010", VA = "0x18339BC10")]
			internal string HKPOEIGGHKN(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class LFKCINEPHJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public OKCHCCDOGCN<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public LFKCINEPHJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x339BC10", Offset = "0x339B010", VA = "0x18339BC10")]
			internal int GIFCJNJFMKP(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private readonly FKICCNHFKED OKFAEDKNMAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private readonly Type DPAKNFAEAKH;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x3B6ABA0", Offset = "0x3B69FA0", VA = "0x183B6ABA0")]
		internal MJELGKBFKFI(FKICCNHFKED OKFAEDKNMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x3B6AA50", Offset = "0x3B69E50", VA = "0x183B6AA50", Slot = "4")]
		public void CPBGIOAGICI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x3B6A830", Offset = "0x3B69C30", VA = "0x183B6A830", Slot = "5")]
		public CJMKDCDNAIM<T> ALPCJMNJHBC(string BCBCBAEOENM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3B6A940", Offset = "0x3B69D40", VA = "0x183B6A940", Slot = "6")]
		public CJMKDCDNAIM<T> CGBPCMCIMBN(ONABGJJJPCF<T> IIHLDDOPJHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x3B6A7F0", Offset = "0x3B69BF0", VA = "0x183B6A7F0", Slot = "7")]
		public CJMKDCDNAIM<T> ACCGNHFAOBJ(int BCIJBMOMCKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x3B6AA80", Offset = "0x3B69E80", VA = "0x183B6AA80", Slot = "8")]
		public CJMKDCDNAIM<T> LIEKJBDAABK(int BCIJBMOMCKL, OKCHCCDOGCN<T> IGKPNLBFOPL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class DBIHNMCOPOF<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private bool INDICEIECNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private readonly List<Type> DHCDCGEIJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private readonly Dictionary<Type, TVal> MEKOCDKMDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private readonly Dictionary<Type, int> HBEECKMMAJB;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public IReadOnlyList<Type> ADNHLCJONKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x4CDADB0", Offset = "0x4CDA1B0", VA = "0x184CDADB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x4CDB240", Offset = "0x4CDA640", VA = "0x184CDB240")]
		public DBIHNMCOPOF(Dictionary<Type, int> HBEECKMMAJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x4CDAD10", Offset = "0x4CDA110", VA = "0x184CDAD10")]
		public void GIHKKMKIIOJ(Type IHHOPACLNAK, TVal FLJKEGLJDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4CDB0B0", Offset = "0x4CDA4B0", VA = "0x184CDB0B0")]
		public bool LPMPLPKKKIM(Type DPAKNFAEAKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x4CDB0F0", Offset = "0x4CDA4F0", VA = "0x184CDB0F0")]
		public bool OMCFKKOGGCG(TVal LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x4CDAF30", Offset = "0x4CDA330", VA = "0x184CDAF30")]
		public TVal KJBHHOOLCCM(Type DJMKKNDNCBM)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x4CDAF70", Offset = "0x4CDA370", VA = "0x184CDAF70")]
		[CompilerGenerated]
		private int LNBHMEGCINL(Type PGFPHAJHBDK, Type LPJIMLJNONJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class LODKCLLGKKD : IEnumerable<HNCCCLFKMDO>, IEnumerable, IEnumerator<HNCCCLFKMDO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private HNCCCLFKMDO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public FKICCNHFKED <>4__this;

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
		private IEnumerator<HNCCCLFKMDO> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private HNCCCLFKMDO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x30A23D0", Offset = "0x30A17D0", VA = "0x1830A23D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HNCCCLFKMDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x6275420", Offset = "0x6274820", VA = "0x186275420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public LODKCLLGKKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x6275470", Offset = "0x6274870", VA = "0x186275470", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6274DC0", Offset = "0x62741C0", VA = "0x186274DC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x6275270", Offset = "0x6274670", VA = "0x186275270")]
		private void OGHCJJGAJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x62752C0", Offset = "0x62746C0", VA = "0x1862752C0")]
		private void POMJOEIOKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x62753D0", Offset = "0x62747D0", VA = "0x1862753D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6275310", Offset = "0x6274710", VA = "0x186275310", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HNCCCLFKMDO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6275310", Offset = "0x6274710", VA = "0x186275310", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private static readonly HNCCCLFKMDO AEKPMLDMHGE;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private static readonly Dictionary<Type, int> IFFPMGHODHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private readonly HashSet<Type> BOALANEKLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	private readonly DBIHNMCOPOF<int> MMNHMODEFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private readonly DBIHNMCOPOF<DLLLAKLCDDO> BNEBLIAFIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private readonly DBIHNMCOPOF<EGNLMNPLEJB> MDPBBKGBKMD;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x62654F0", Offset = "0x62648F0", VA = "0x1862654F0")]
	[DCEDJGMCFCN(IIPPAMCLFBJ.GameOnly)]
	private static void KAGIJELEALE(BFGBHKPNKEI AFJFOILCBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x6265CB0", Offset = "0x62650B0", VA = "0x186265CB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FKICCNHFKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x225A120", Offset = "0x2259520", VA = "0x18225A120", Slot = "4")]
	public CJMKDCDNAIM<T> MECBDHIHIDL<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x6264B00", Offset = "0x6263F00", VA = "0x186264B00", Slot = "5")]
	public NBHAGIHNLPF GEJMEGGLGLA(Exception FLMBJDOBLFE)
	{
		return default(NBHAGIHNLPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6264FE0", Offset = "0x62643E0", VA = "0x186264FE0", Slot = "6")]
	public HNCCCLFKMDO JCIDALGHDLK(Exception? FLMBJDOBLFE)
	{
		return default(HNCCCLFKMDO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x6264F40", Offset = "0x6264340", VA = "0x186264F40", Slot = "7")]
	[IteratorStateMachine(typeof(LODKCLLGKKD))]
	public IEnumerable<HNCCCLFKMDO> HOOOLJLMINJ(Exception FLMBJDOBLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6265A90", Offset = "0x6264E90", VA = "0x186265A90", Slot = "8")]
	public string ONGLDIHIJKJ(Exception? FLMBJDOBLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x62651E0", Offset = "0x62645E0", VA = "0x1862651E0")]
	private string JMJPFNIPNLB(AggregateException CFBPGEGEBEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6264B90", Offset = "0x6263F90", VA = "0x186264B90")]
	private void GMIMFFLDDAG(Type DPAKNFAEAKH, int BCIJBMOMCKL, DLLLAKLCDDO? NGNHGBCMEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x62648B0", Offset = "0x6263CB0", VA = "0x1862648B0")]
	private void BGIGGLJFPEL(Type DPAKNFAEAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x6265560", Offset = "0x6264960", VA = "0x186265560")]
	private void KFCOHPGDDAE(Type DPAKNFAEAKH, EGNLMNPLEJB AHCMBMOMEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6265910", Offset = "0x6264D10", VA = "0x186265910")]
	private static int MPALCPMPIBN(Type DPAKNFAEAKH, Dictionary<Type, int> HBEECKMMAJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x23B9180", Offset = "0x23B8580", VA = "0x1823B9180")]
	private static bool AFDBBGHIGNL<TVal>(DBIHNMCOPOF<TVal> FDELOOBEEJI, Type DPAKNFAEAKH, [Out] TVal LPCGJALKADL) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x6265830", Offset = "0x6264C30", VA = "0x186265830")]
	[CompilerGenerated]
	internal static int LENNADHKKAD(Type MKHPACNKPMH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct NBHAGIHNLPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public readonly HNCCCLFKMDO OLOKKOAIPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public readonly string PAMIIGAGOAO;

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x6276530", Offset = "0x6275930", VA = "0x186276530")]
	public NBHAGIHNLPF(string INJJMJHALCN, HNCCCLFKMDO BCIJBMOMCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x6276490", Offset = "0x6275890", VA = "0x186276490")]
	public string INAADIMHOJE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class OKADPHKNNFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private readonly EGHCFFGENEP ONKLABCEHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private string KLBCBGHMKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private long? OLMNINHEGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private long? AOHDCAJKHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private long? FJHDFJJDOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private string CLBJBIAOMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private FPMKBCLBDOA NHLDMHGCOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private long? AHBIGMIFMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private bool HEMHLGEKOHB;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public string BDICLNCJCHM
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public long FJGBHJECHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6277C90", Offset = "0x6277090", VA = "0x186277C90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public long GJJIDFFMHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x62786B0", Offset = "0x6277AB0", VA = "0x1862786B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public long HMNFMOBAMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x6277C30", Offset = "0x6277030", VA = "0x186277C30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public string IJAGIDLJCKC
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x6278500", Offset = "0x6277900", VA = "0x186278500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public FPMKBCLBDOA MEEJLKLIEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xED3330", Offset = "0xED2730", VA = "0x180ED3330")]
		get
		{
			return default(FPMKBCLBDOA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x62785C0", Offset = "0x62779C0", VA = "0x1862785C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public long CKDDDNCFIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x62787B0", Offset = "0x6277BB0", VA = "0x1862787B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6278A60", Offset = "0x6277E60", VA = "0x186278A60")]
	[UnityEngine.Scripting.Preserve]
	public OKADPHKNNFI([LMAFJMDCBJO(null)] EGHCFFGENEP ONKLABCEHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x6278810", Offset = "0x6277C10", VA = "0x186278810")]
	private void OMFNHGHLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x6278070", Offset = "0x6277470", VA = "0x186278070")]
	public void GJBALFAHGPP(long BLPLCJENHDJ, long CAHHMNIGLJL, [Optional] long? EBLCIIMJECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x6278710", Offset = "0x6277B10", VA = "0x186278710")]
	public void MIBFBMKLKAG(long EBLCIIMJECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6278540", Offset = "0x6277940", VA = "0x186278540")]
	public void JMMODMBLGHA(string BGJEOJLNCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6277CF0", Offset = "0x62770F0", VA = "0x186277CF0")]
	public void FJJKHLFJICK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class HNIKGGHLOAK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct LFACPEOIOIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public AsyncTaskMethodBuilder<OCJBGBEKDGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public OCJBGBEKDGN roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public HNIKGGHLOAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<CGKFPLEFIDK.IOGAMCELJBM<OCJBGBEKDGN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x62744D0", Offset = "0x62738D0", VA = "0x1862744D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x6274A00", Offset = "0x6273E00", VA = "0x186274A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct FELFPDLOCFF<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class DDJJHLIMLPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public OCJBGBEKDGN roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public DDJJHLIMLPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x6260CA0", Offset = "0x62600A0", VA = "0x186260CA0")]
		internal OCJBGBEKDGN NEMAJHFKNGO(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct EMPAIGIDNCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public AsyncTaskMethodBuilder<CGKFPLEFIDK.IOGAMCELJBM<OCJBGBEKDGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public OCJBGBEKDGN roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public HNIKGGHLOAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private CBKIKLFMBOI <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private TaskAwaiter<CGKFPLEFIDK.IOGAMCELJBM<OCJBGBEKDGN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x62623E0", Offset = "0x62617E0", VA = "0x1862623E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x62629F0", Offset = "0x6261DF0", VA = "0x1862629F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct MOLNCPFNPGG<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public HNIKGGHLOAK <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3B8E3E0", Offset = "0x3B8D7E0", VA = "0x183B8E3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x33B33D0", Offset = "0x33B27D0", VA = "0x1833B33D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct EPLOFNJMCEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public HNIKGGHLOAK <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6263BB0", Offset = "0x6262FB0", VA = "0x186263BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x6263D70", Offset = "0x6263170", VA = "0x186263D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class HFDJHPBGIEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HFDJHPBGIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x6269670", Offset = "0x6268A70", VA = "0x186269670")]
		internal object KCBGOCNIHIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x62696D0", Offset = "0x6268AD0", VA = "0x1862696D0")]
		internal bool KNCKOMFKNMJ(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class EOBELOOJDHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public EOBELOOJDHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6262AE0", Offset = "0x6261EE0", VA = "0x186262AE0")]
		internal object OEPACEBBIMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class HHNKDBFEIJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HHNKDBFEIJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x626B8A0", Offset = "0x626ACA0", VA = "0x18626B8A0")]
		internal object GMKDPJFJJJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class HIHODLGCCMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HIHODLGCCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x626B910", Offset = "0x626AD10", VA = "0x18626B910")]
		internal object GMJJFKEEMCI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class DCDMCBNNJGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public HNIKGGHLOAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public DCDMCBNNJGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x6260A60", Offset = "0x625FE60", VA = "0x186260A60")]
		internal object KKACBPNCHCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private static readonly Guid EPFICBHEDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public readonly KHKLNHABCFF PNLPMJNOAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private readonly CGKFPLEFIDK PNJBACPJHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private readonly GGDBFAOHHOP FOEGMELFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private readonly MBEDGJOOHMD ABJOJKKDPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private bool DGCLJKGKNDH;

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x626CB90", Offset = "0x626BF90", VA = "0x18626CB90")]
	public HNIKGGHLOAK(KHKLNHABCFF PLBKMELAPOA, CGKFPLEFIDK PNJBACPJHCK, GGDBFAOHHOP FOEGMELFMCF, MBEDGJOOHMD ABJOJKKDPOG, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x626BBD0", Offset = "0x626AFD0", VA = "0x18626BBD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x626BBD0", Offset = "0x626AFD0", VA = "0x18626BBD0")]
	public void BHLHDHIGIKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x626CA60", Offset = "0x626BE60", VA = "0x18626CA60")]
	public void PNIBJLACKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x626BCF0", Offset = "0x626B0F0", VA = "0x18626BCF0")]
	public void CFOILHEACLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x626C040", Offset = "0x626B440", VA = "0x18626C040")]
	[AsyncStateMachine(typeof(LFACPEOIOIP))]
	internal Task<OCJBGBEKDGN> HIEPAAGIGLD(KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, OCJBGBEKDGN ABMIABCDNMK, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x23DD2C0", Offset = "0x23DC6C0", VA = "0x1823DD2C0")]
	private static byte[] BBFAOFAFAHJ<T>(T LMJAPBNMKLG) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x23DD8F0", Offset = "0x23DCCF0", VA = "0x1823DD8F0")]
	private static T LENLEELECAA<T>(MessageParser<T> ENMDKCPIBFI, byte[] LMJAPBNMKLG, T BBGNHGDCHBO) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x626C760", Offset = "0x626BB60", VA = "0x18626C760")]
	[AsyncStateMachine(typeof(EMPAIGIDNCD))]
	private Task<CGKFPLEFIDK.IOGAMCELJBM<OCJBGBEKDGN>> LNKIPMALGIK(OCJBGBEKDGN ABMIABCDNMK, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x23DD670", Offset = "0x23DCA70", VA = "0x1823DD670")]
	[AsyncStateMachine(typeof(MOLNCPFNPGG<>))]
	internal Task<T> HPOEOACDOIJ<T>(CancellationToken CKCHEDNFLJC, Func<CancellationToken, Task<T>> KJJEEPJEIKP, int IGLIDACCHHA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x626C1A0", Offset = "0x626B5A0", VA = "0x18626C1A0")]
	[AsyncStateMachine(typeof(EPLOFNJMCEO))]
	internal Task HPOEOACDOIJ(CancellationToken CKCHEDNFLJC, Func<CancellationToken, Task> KJJEEPJEIKP, int IGLIDACCHHA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x626C3E0", Offset = "0x626B7E0", VA = "0x18626C3E0")]
	public EMAHJKMLAHO IPMAFFEMDDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x626C8A0", Offset = "0x626BCA0", VA = "0x18626C8A0")]
	public IHGPABBHGPO NDFILLLCICK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x626C4B0", Offset = "0x626B8B0", VA = "0x18626C4B0")]
	public EEPBGGBDJMA KJBADHJKIHG([Optional] FJOGIBEAJHF? AABDFOONPNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x626C600", Offset = "0x626BA00", VA = "0x18626C600")]
	public void LMCGOGCLFHE(Func<Guid, bool> POGFAHHLCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x626BAC0", Offset = "0x626AEC0", VA = "0x18626BAC0")]
	public void ANBMBFEGDLF(Func<Guid, bool> HHDAKDCIPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x626BDB0", Offset = "0x626B1B0", VA = "0x18626BDB0")]
	public Guid FBDOBMDOPDL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x626BF30", Offset = "0x626B330", VA = "0x18626BF30")]
	public void HALAKMAMJNJ(Guid FLIEECCFIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x626C920", Offset = "0x626BD20", VA = "0x18626C920")]
	public void PENHMKJDBPE(OCJBGBEKDGN EHCGHCOBMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x626C2D0", Offset = "0x626B6D0", VA = "0x18626C2D0")]
	public void IJCNCIMJJJN(string PLNLIHKALBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x23DD580", Offset = "0x23DC980", VA = "0x1823DD580")]
	private T EJPFBNKEHDC<T>(T LPCGJALKADL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x626C460", Offset = "0x626B860", VA = "0x18626C460")]
	public void JOHBEPGANNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x23DD2D0", Offset = "0x23DC6D0", VA = "0x1823DD2D0")]
	[CompilerGenerated]
	internal static string EGEDJLFCAKB<T>(byte[] FBMKKLOJFGJ, int GCHDMCAFBKA, FELFPDLOCFF<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal sealed class NFJMPEPOLMA : KHKLNHABCFF
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class DFDABJGHLND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public DFDABJGHLND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x627E350", Offset = "0x627D750", VA = "0x18627E350")]
		internal object KAFCKKHAIGB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct ECFGFBHEACG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public NFJMPEPOLMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public HNIKGGHLOAK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private BDPINNBKCPB <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private IHGPABBHGPO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x627E930", Offset = "0x627DD30", VA = "0x18627E930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x627F0B0", Offset = "0x627E4B0", VA = "0x18627F0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct GPDJJJJGKON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public NFJMPEPOLMA <>4__this;

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
		private TaskAwaiter<FDKPOLPBLFH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x6281DA0", Offset = "0x62811A0", VA = "0x186281DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x6282320", Offset = "0x6281720", VA = "0x186282320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct PBKNNNCFHON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public NFJMPEPOLMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<HDMEAOOCBIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x628F9D0", Offset = "0x628EDD0", VA = "0x18628F9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x628FCF0", Offset = "0x628F0F0", VA = "0x18628FCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class FDBINMDCIIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public BDPINNBKCPB presence;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public FDBINMDCIIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x627FC10", Offset = "0x627F010", VA = "0x18627FC10")]
		internal object HEEOKKNNHLE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private static readonly FJOGIBEAJHF JHIIOOHKCMN;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static readonly FJOGIBEAJHF NAOCLJCNELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly ABMIDKAKKGN IPFJOAEJGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private readonly BDKFBCEFMIP AMAJGOGOANE;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6276BC0", Offset = "0x6275FC0", VA = "0x186276BC0")]
	public NFJMPEPOLMA(ABMIDKAKKGN IPFJOAEJGOE, BDKFBCEFMIP AMAJGOGOANE, Guid CEMPKOIGLIO, FGMCJCFGAPG LGOFKBPFPIN, EMNADKEEBNM LBMFAHEJNFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x62769A0", Offset = "0x6275DA0", VA = "0x1862769A0", Slot = "7")]
	[AsyncStateMachine(typeof(ECFGFBHEACG))]
	protected override Task ECNKBENLLCH(HNIKGGHLOAK CMCLMFBENFL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x62766C0", Offset = "0x6275AC0", VA = "0x1862766C0")]
	[AsyncStateMachine(typeof(GPDJJJJGKON))]
	private Task DEICEPJKFDL(CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x62765B0", Offset = "0x62759B0", VA = "0x1862765B0")]
	[AsyncStateMachine(typeof(PBKNNNCFHON))]
	private Task<byte> CHPGMOHMHIG(CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x62767C0", Offset = "0x6275BC0", VA = "0x1862767C0")]
	private BDPINNBKCPB DLHPHLAJGDL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class PLDHEJHFNND : KHKLNHABCFF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct HHIMGDENIEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public PLDHEJHFNND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public HNIKGGHLOAK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private TaskAwaiter<EOMDJPDNCEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x6282E50", Offset = "0x6282250", VA = "0x186282E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x6283820", Offset = "0x6282C20", VA = "0x186283820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private readonly int KKAJPHLJIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private readonly BJHHJKOCPBD IFNJMAAKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public readonly long HHAPKNDFDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public readonly long POLAEMKGGKA;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public EOMDJPDNCEE KNFBFBOKDIK
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x7654E0", Offset = "0x7648E0", VA = "0x1807654E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x765380", Offset = "0x764780", VA = "0x180765380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x628FE80", Offset = "0x628F280", VA = "0x18628FE80")]
	public PLDHEJHFNND(Guid CEMPKOIGLIO, FGMCJCFGAPG LGOFKBPFPIN, EMNADKEEBNM LBMFAHEJNFB, int KKAJPHLJIBJ, BJHHJKOCPBD IFNJMAAKBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x628FD60", Offset = "0x628F160", VA = "0x18628FD60", Slot = "7")]
	[AsyncStateMachine(typeof(HHIMGDENIEE))]
	protected override Task ECNKBENLLCH(HNIKGGHLOAK CMCLMFBENFL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal abstract class AGCGJBJCNLL : KHKLNHABCFF
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class DFPNNBOANPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public AGCGJBJCNLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public FFNBMNKKACB playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public DFPNNBOANPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x627E450", Offset = "0x627D850", VA = "0x18627E450")]
		internal Task GMAJHHOLBPE(KGKDBPAMFIO<string>.HDBHKIOKMPF postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x627E3C0", Offset = "0x627D7C0", VA = "0x18627E3C0")]
		internal object DOCGFHPCCPG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct HHBPJPNIPHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public AGCGJBJCNLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public HNIKGGHLOAK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private DFPNNBOANPM <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x6282630", Offset = "0x6281A30", VA = "0x186282630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x6282DF0", Offset = "0x62821F0", VA = "0x186282DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct CNJGOICNBJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public FFNBMNKKACB playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public AGCGJBJCNLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x627CEE0", Offset = "0x627C2E0", VA = "0x18627CEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x627D470", Offset = "0x627C870", VA = "0x18627D470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x627B4C0", Offset = "0x627A8C0", VA = "0x18627B4C0")]
	public AGCGJBJCNLL(Guid CEMPKOIGLIO, FGMCJCFGAPG LGOFKBPFPIN, EMNADKEEBNM LBMFAHEJNFB, string FNLHPIPIBCF, BAIOELEICOL EGJBIIEJEOI, bool NCOGFILKCJK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x627B240", Offset = "0x627A640", VA = "0x18627B240", Slot = "7")]
	[AsyncStateMachine(typeof(HHBPJPNIPHG))]
	protected override Task ECNKBENLLCH(HNIKGGHLOAK CMCLMFBENFL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task NFFLHDMJNMJ(HNIKGGHLOAK CMCLMFBENFL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x627B380", Offset = "0x627A780", VA = "0x18627B380")]
	[AsyncStateMachine(typeof(CNJGOICNBJG))]
	private Task NJGECPDMBJN(IDisposable OBHHFNBBIMF, FFNBMNKKACB FIPDGBLKGAI, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class DDADLMMPMMO : KHKLNHABCFF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct DFAEBGCHMCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public DDADLMMPMMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public HNIKGGHLOAK operationContext;

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
		private TaskAwaiter<BLOPIEONCGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x627DD80", Offset = "0x627D180", VA = "0x18627DD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x627E2F0", Offset = "0x627D6F0", VA = "0x18627E2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly ANDGBBKHDNM CNBEKNILNAO;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x627D6D0", Offset = "0x627CAD0", VA = "0x18627D6D0")]
	public DDADLMMPMMO(Guid CEMPKOIGLIO, FGMCJCFGAPG LGOFKBPFPIN, EMNADKEEBNM LBMFAHEJNFB, ANDGBBKHDNM CNBEKNILNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x627D4D0", Offset = "0x627C8D0", VA = "0x18627D4D0", Slot = "6")]
	protected override string CMFEGJNNOPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x627D5B0", Offset = "0x627C9B0", VA = "0x18627D5B0", Slot = "7")]
	[AsyncStateMachine(typeof(DFAEBGCHMCC))]
	protected override Task ECNKBENLLCH(HNIKGGHLOAK CMCLMFBENFL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class KHKLNHABCFF : KBEHKOHFOFA
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public delegate Task KFOIECPCIFG(KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class DILPGDDDNKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public KHKLNHABCFF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public DILPGDDDNKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x627E490", Offset = "0x627D890", VA = "0x18627E490")]
		internal Task KNIOAMHIOPL(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class KLAODHCPJNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public DILPGDDDNKO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public KLAODHCPJNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6289DB0", Offset = "0x62891B0", VA = "0x186289DB0")]
		internal object JGIOABMALGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x6289CF0", Offset = "0x62890F0", VA = "0x186289CF0")]
		internal object AHFCDGGCIPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct JEJMGDFFOHA : IAsyncStateMachine
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
		public KHKLNHABCFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public Func<KHKLNHABCFF, KGKDBPAMFIO<string>.HDBHKIOKMPF, HNIKGGHLOAK> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private DILPGDDDNKO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private HNIKGGHLOAK <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private TaskAwaiter<OCJBGBEKDGN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x62872D0", Offset = "0x62866D0", VA = "0x1862872D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x62883D0", Offset = "0x62877D0", VA = "0x1862883D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct AFKLFMDNPFM : IAsyncStateMachine
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
		public KHKLNHABCFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x627AE80", Offset = "0x627A280", VA = "0x18627AE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x627B1E0", Offset = "0x627A5E0", VA = "0x18627B1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public readonly Guid EHNJNMFMEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public readonly ByteString LEHHBMMJAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public readonly EMNADKEEBNM HFGNBNLABFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	protected readonly string HPGLNACMNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	private readonly FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	private readonly bool NCOGFILKCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	private readonly Queue<KFOIECPCIFG> IBACKPFHCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly BJKFFLKACKO DDOIIPECKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly BAIOELEICOL EGJBIIEJEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private bool JGPCKNIINOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public FPMKBCLBDOA BAJCPIMOLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public FPMKBCLBDOA JBHAOAOHNJF;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public FGMCJCFGAPG HGHPMDMDHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CHMLDJDCJFC JIBKILINHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6288860", Offset = "0x6287C60", VA = "0x186288860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public GLIHBPDBOBH ELJDEDBLPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x6289050", Offset = "0x6288450", VA = "0x186289050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public EAKNENHMOPB DHPIDOBBJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6288CF0", Offset = "0x62880F0", VA = "0x186288CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event FJAGAGNLDBF GCADDHJIFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x62889A0", Offset = "0x6287DA0", VA = "0x1862889A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6288A60", Offset = "0x6287E60", VA = "0x186288A60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x62890A0", Offset = "0x62884A0", VA = "0x1862890A0")]
	protected KHKLNHABCFF(Guid CEMPKOIGLIO, FGMCJCFGAPG LGOFKBPFPIN, EMNADKEEBNM LBMFAHEJNFB, string FNLHPIPIBCF, BAIOELEICOL EGJBIIEJEOI, bool NCOGFILKCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6288A20", Offset = "0x6287E20", VA = "0x186288A20", Slot = "6")]
	protected virtual string CMFEGJNNOPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x62889C0", Offset = "0x6287DC0", VA = "0x1862889C0")]
	public void CGDGPIBILOF(KFOIECPCIFG KHPFPLBFKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6288DF0", Offset = "0x62881F0", VA = "0x186288DF0")]
	protected void KGNCPKALAIN(float HGOEIFPLBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6288E10", Offset = "0x6288210", VA = "0x186288E10")]
	[AsyncStateMachine(typeof(JEJMGDFFOHA))]
	public Task LAGINJJKIEC(CancellationToken OMFABMCIOAC, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, [Optional] Func<KHKLNHABCFF, KGKDBPAMFIO<string>.HDBHKIOKMPF, HNIKGGHLOAK> IAKGPBHMAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6288BA0", Offset = "0x6287FA0", VA = "0x186288BA0")]
	private void IABHICOKMJD(bool OLAMLOCNCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6288F60", Offset = "0x6288360", VA = "0x186288F60")]
	private void LLBEIAGNPKC(HNIKGGHLOAK CMCLMFBENFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task ECNKBENLLCH(HNIKGGHLOAK CMCLMFBENFL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6288A80", Offset = "0x6287E80", VA = "0x186288A80")]
	[AsyncStateMachine(typeof(AFKLFMDNPFM))]
	private Task ELLNAHDCIJC(KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6288D70", Offset = "0x6288170", VA = "0x186288D70")]
	public OCJBGBEKDGN KBLIAINPNLL(CBKIKLFMBOI LAGCNJDMOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x62888B0", Offset = "0x6287CB0", VA = "0x1862888B0")]
	[CompilerGenerated]
	private Task BLBBLGPCLBN(CancellationToken BFGAGBINHNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal sealed class IPOHECOMMAF : AGCGJBJCNLL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct MELBANOLNAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public IPOHECOMMAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public HNIKGGHLOAK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private DDKHGNOFKCA <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private IHGPABBHGPO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x628B040", Offset = "0x628A440", VA = "0x18628B040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x628B7B0", Offset = "0x628ABB0", VA = "0x18628B7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly ABMIDKAKKGN CIMOCEEIHGO;

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x6287220", Offset = "0x6286620", VA = "0x186287220")]
	public IPOHECOMMAF(Guid CEMPKOIGLIO, FGMCJCFGAPG LGOFKBPFPIN, ABMIDKAKKGN CIMOCEEIHGO, EMNADKEEBNM LBMFAHEJNFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x62870D0", Offset = "0x62864D0", VA = "0x1862870D0", Slot = "8")]
	[AsyncStateMachine(typeof(MELBANOLNAM))]
	protected override Task NFFLHDMJNMJ(HNIKGGHLOAK CMCLMFBENFL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal class JOBIKGLIGMH : KHKLNHABCFF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct FLKMPPKNLAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public JOBIKGLIGMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public HNIKGGHLOAK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private TaskAwaiter<BLOPIEONCGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6281570", Offset = "0x6280970", VA = "0x186281570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6281920", Offset = "0x6280D20", VA = "0x186281920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private readonly string PHAGAMHJKAP;

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x6288540", Offset = "0x6287940", VA = "0x186288540")]
	public JOBIKGLIGMH(Guid CEMPKOIGLIO, FGMCJCFGAPG LGOFKBPFPIN, EMNADKEEBNM LBMFAHEJNFB, string PHAGAMHJKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x6288430", Offset = "0x6287830", VA = "0x186288430", Slot = "7")]
	[AsyncStateMachine(typeof(FLKMPPKNLAO))]
	protected override Task ECNKBENLLCH(HNIKGGHLOAK CMCLMFBENFL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class CHHAKMKBHNC : AGCGJBJCNLL
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class NOAEOLKMJAH
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
			public AsyncTaskMethodBuilder<OCJBGBEKDGN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public NOAEOLKMJAH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private TaskAwaiter<BLOPIEONCGA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private TaskAwaiter<OCJBGBEKDGN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x6292CE0", Offset = "0x62920E0", VA = "0x186292CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x62931A0", Offset = "0x62925A0", VA = "0x1862931A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public CHHAKMKBHNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public EEPBGGBDJMA serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public KJGPAHOKGPF roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public EMAHJKMLAHO uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public IDBGIKDPAIG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public NOAEOLKMJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x628D2E0", Offset = "0x628C6E0", VA = "0x18628D2E0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<OCJBGBEKDGN> GILGJPICGBJ(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct IJIDPAHONDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public CHHAKMKBHNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public HNIKGGHLOAK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private NOAEOLKMJAH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private DDKHGNOFKCA <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private IHGPABBHGPO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter<OCJBGBEKDGN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x62860B0", Offset = "0x62854B0", VA = "0x1862860B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6286F50", Offset = "0x6286350", VA = "0x186286F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private static readonly FJOGIBEAJHF JHIIOOHKCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private readonly int NFJKFKHHGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	[CanBeNull]
	private readonly NNDEIDFMMBL PEMMFKFLKEL;

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x627CE30", Offset = "0x627C230", VA = "0x18627CE30")]
	public CHHAKMKBHNC(Guid CEMPKOIGLIO, FGMCJCFGAPG LGOFKBPFPIN, int NFJKFKHHGIB, NNDEIDFMMBL PEMMFKFLKEL, EMNADKEEBNM LBMFAHEJNFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x627CC40", Offset = "0x627C040", VA = "0x18627CC40", Slot = "8")]
	[AsyncStateMachine(typeof(IJIDPAHONDK))]
	protected override Task NFFLHDMJNMJ(HNIKGGHLOAK CMCLMFBENFL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x627C970", Offset = "0x627BD70", VA = "0x18627C970")]
	private void JFKKCKDGMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x627CA70", Offset = "0x627BE70", VA = "0x18627CA70")]
	private void LPPFCGGNGGB(KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, DDKHGNOFKCA LDCLGCFOCKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal abstract class OMKIAIBIPPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public readonly KHKLNHABCFF PNLPMJNOAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public readonly HNIKGGHLOAK JCHBGHGMJDG;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public CHMLDJDCJFC JIBKILINHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x628F870", Offset = "0x628EC70", VA = "0x18628F870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public EAKNENHMOPB DHPIDOBBJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x628F8E0", Offset = "0x628ECE0", VA = "0x18628F8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x628F970", Offset = "0x628ED70", VA = "0x18628F970")]
	protected OMKIAIBIPPM(HNIKGGHLOAK CMCLMFBENFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x628F8C0", Offset = "0x628ECC0", VA = "0x18628F8C0")]
	protected void IJCNCIMJJJN(string PLNLIHKALBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct DEBEGMIAJGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public Dictionary<Guid, List<DAMKILFCPKF>> OALOABPDKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public Dictionary<Guid, List<DAMKILFCPKF>> MHGJOMMOFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public Dictionary<Guid, List<DAMKILFCPKF>> LNGBGHMMBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public List<Guid> MMDIHAGAINC;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x627D770", Offset = "0x627CB70", VA = "0x18627D770")]
	public static DEBEGMIAJGN KJBHHOOLCCM(CHMLDJDCJFC FDEKFCDLHEC, FPMKBCLBDOA LADLFKDMJEN, OKOIPJPAMDA CBNHJABECIP)
	{
		return default(DEBEGMIAJGN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct MBFEFMDOIIC
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280")]
	public static MBFEFMDOIIC PJBIIEEDKDI()
	{
		return default(MBFEFMDOIIC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal struct BGPAGBGDKBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public readonly FDKPOLPBLFH JNPLJPLJGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public readonly DFEHFHGPFLB FBOLIGJLGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public readonly string ACDLOAEPCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public readonly IGNOFONIPFC ILOGCLKGEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly IGNOFONIPFC DHAFNCNBMBA;

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x627C330", Offset = "0x627B730", VA = "0x18627C330")]
	public BGPAGBGDKBL(FDKPOLPBLFH JNPLJPLJGKA, DFEHFHGPFLB FBOLIGJLGEJ, string ACDLOAEPCEG, IGNOFONIPFC ILOGCLKGEMA, IGNOFONIPFC DHAFNCNBMBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct GBOCFNEIPMP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private readonly HNIKGGHLOAK CMCLMFBENFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private readonly Guid FLIEECCFIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private bool OLAMLOCNCJJ;

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x62819E0", Offset = "0x6280DE0", VA = "0x1862819E0")]
	public static GBOCFNEIPMP FBDOBMDOPDL(HNIKGGHLOAK CMCLMFBENFL)
	{
		return default(GBOCFNEIPMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1A43B40", Offset = "0x1A42F40", VA = "0x181A43B40")]
	public void FPBIEPHONPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6281980", Offset = "0x6280D80", VA = "0x186281980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6281AE0", Offset = "0x6280EE0", VA = "0x186281AE0")]
	private GBOCFNEIPMP(HNIKGGHLOAK CMCLMFBENFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6281980", Offset = "0x6280D80", VA = "0x186281980")]
	private void HALAKMAMJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x6281A40", Offset = "0x6280E40", VA = "0x186281A40")]
	private Func<Guid, bool> FFBNGHOPAFE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class IHGPABBHGPO : OMKIAIBIPPM, KBEHKOHFOFA
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	public delegate Task<FPMKBCLBDOA> LBALLPKPJIK(OKOIPJPAMDA OOIBMCBCEPD, CHGACGDBFPI PAFIBLLIGAJ, BJKFFLKACKO DGFJADMMGJP, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct FDDNICJLMHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public ABMIDKAKKGN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private GBOCFNEIPMP <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter<OCJBGBEKDGN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x627FD50", Offset = "0x627F150", VA = "0x18627FD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x6280450", Offset = "0x627F850", VA = "0x186280450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct LOIBPLIIMOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public AsyncTaskMethodBuilder<OCJBGBEKDGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public ABMIDKAKKGN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private TaskAwaiter<OCJBGBEKDGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x628ABC0", Offset = "0x6289FC0", VA = "0x18628ABC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x628AFD0", Offset = "0x628A3D0", VA = "0x18628AFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct BAMCNDKLNEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public ABMIDKAKKGN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x627BCB0", Offset = "0x627B0B0", VA = "0x18627BCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x627C140", Offset = "0x627B540", VA = "0x18627C140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class IAIEBLKHEDD
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
			public AsyncTaskMethodBuilder<BGPAGBGDKBL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IAIEBLKHEDD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private BGPAGBGDKBL <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			private TaskAwaiter<FPMKBCLBDOA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			private TaskAwaiter<BGPAGBGDKBL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x6291350", Offset = "0x6290750", VA = "0x186291350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x6291AE0", Offset = "0x6290EE0", VA = "0x186291AE0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<OKOIPJPAMDA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public IAIEBLKHEDD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			private OKOIPJPAMDA <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<FPMKBCLBDOA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			private TaskAwaiter<OKOIPJPAMDA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x6291B50", Offset = "0x6290F50", VA = "0x186291B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x62921A0", Offset = "0x62915A0", VA = "0x1862921A0", Slot = "5")]
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
			public IAIEBLKHEDD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			private TaskAwaiter<FPMKBCLBDOA> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private CHGACGDBFPI <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x628FFB0", Offset = "0x628F3B0", VA = "0x18628FFB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x62912F0", Offset = "0x62906F0", VA = "0x1862912F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public ABMIDKAKKGN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public BJKFFLKACKO preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public BJKFFLKACKO downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public BGPAGBGDKBL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public BJKFFLKACKO postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public OKOIPJPAMDA phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public AOIDJKEPFOF.PEMLCFAHAFJ <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public IAIEBLKHEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x6283BC0", Offset = "0x6282FC0", VA = "0x186283BC0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<BGPAGBGDKBL> OIHNEEEBCFH(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x6283AA0", Offset = "0x6282EA0", VA = "0x186283AA0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<OKOIPJPAMDA> KMIKEDHOPCJ(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x6283A60", Offset = "0x6282E60", VA = "0x186283A60")]
		internal void FJEGJEEGIAL(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x6283960", Offset = "0x6282D60", VA = "0x186283960")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task CLCGIOGFDIM(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct NPIDIHECNPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public ABMIDKAKKGN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private IAIEBLKHEDD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private TaskAwaiter<BGPAGBGDKBL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private TaskAwaiter<OKOIPJPAMDA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x628D400", Offset = "0x628C800", VA = "0x18628D400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x628E100", Offset = "0x628D500", VA = "0x18628E100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct AGCIFODCAGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x627B510", Offset = "0x627A910", VA = "0x18627B510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x627BC50", Offset = "0x627B050", VA = "0x18627BC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct EMCJBGLEMFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public BJKFFLKACKO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter<FPMKBCLBDOA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x627F250", Offset = "0x627E650", VA = "0x18627F250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x627FBB0", Offset = "0x627EFB0", VA = "0x18627FBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct NHCBHCCKNMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public AsyncTaskMethodBuilder<FPMKBCLBDOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public BJKFFLKACKO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private TaskAwaiter<FPMKBCLBDOA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x628C0F0", Offset = "0x628B4F0", VA = "0x18628C0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x628D270", Offset = "0x628C670", VA = "0x18628D270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct ABDKMACGKMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder<FPMKBCLBDOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public BJKFFLKACKO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public CHGACGDBFPI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private TaskAwaiter<FPMKBCLBDOA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x6279A40", Offset = "0x6278E40", VA = "0x186279A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x627AE10", Offset = "0x627A210", VA = "0x18627AE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct ABCCAIENKIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public AsyncTaskMethodBuilder<FPMKBCLBDOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public FPMKBCLBDOA operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public BJKFFLKACKO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public OKOIPJPAMDA deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter<FPMKBCLBDOA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x6279740", Offset = "0x6278B40", VA = "0x186279740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x62799D0", Offset = "0x6278DD0", VA = "0x1862799D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class JOHIHEHEJNI
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
			public AsyncTaskMethodBuilder<FPMKBCLBDOA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public JOHIHEHEJNI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private TaskAwaiter<FPMKBCLBDOA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x6292210", Offset = "0x6291610", VA = "0x186292210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0x6292880", Offset = "0x6291C80", VA = "0x186292880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public BJKFFLKACKO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public LBALLPKPJIK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CHGACGDBFPI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public FPMKBCLBDOA originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public JOHIHEHEJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x62885F0", Offset = "0x62879F0", VA = "0x1862885F0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<FPMKBCLBDOA> KNGGPHKGLDJ(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct KODNLDNCKGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public AsyncTaskMethodBuilder<FPMKBCLBDOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public BJKFFLKACKO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public LBALLPKPJIK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public CHGACGDBFPI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private TaskAwaiter<FPMKBCLBDOA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6289E70", Offset = "0x6289270", VA = "0x186289E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x628A3B0", Offset = "0x62897B0", VA = "0x18628A3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct MNKGBGINBCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public BJKFFLKACKO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private FPMKBCLBDOA <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private IEnumerator<FPMKBCLBDOA> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private TaskAwaiter<FPMKBCLBDOA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x628B810", Offset = "0x628AC10", VA = "0x18628B810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x628BD40", Offset = "0x628B140", VA = "0x18628BD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct EBEBANNMAHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x627E5C0", Offset = "0x627D9C0", VA = "0x18627E5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x627E8D0", Offset = "0x627DCD0", VA = "0x18627E8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct HGNMPJMIJOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public IHGPABBHGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x6282380", Offset = "0x6281780", VA = "0x186282380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x62825D0", Offset = "0x62819D0", VA = "0x1862825D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private readonly NHAKFPLMIPB IJIPMGGMADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly NHAKFPLMIPB EPNMNKBLLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly OKADPHKNNFI OCAFCJCEGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly GNGIEKHFEHI ALHIMFANBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly GNIKBMOEOGP GIODCBCJGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private readonly KDNDFIEIIAJ GLKGMFGJHFN;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private FGMCJCFGAPG HGHPMDMDHLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x6285220", Offset = "0x6284620", VA = "0x186285220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event FJAGAGNLDBF GCADDHJIFKH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x62843C0", Offset = "0x62837C0", VA = "0x1862843C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x6284540", Offset = "0x6283940", VA = "0x186284540", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x6285520", Offset = "0x6284920", VA = "0x186285520")]
	public IHGPABBHGPO(HNIKGGHLOAK CMCLMFBENFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x6284560", Offset = "0x6283960", VA = "0x186284560")]
	[AsyncStateMachine(typeof(FDDNICJLMHO))]
	public Task EKKELHONJEB(ABMIDKAKKGN EJJHDDFDLOL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6284020", Offset = "0x6283420", VA = "0x186284020")]
	[AsyncStateMachine(typeof(LOIBPLIIMOJ))]
	private Task<OCJBGBEKDGN> BMFJLELLEIF(ABMIDKAKKGN EJJHDDFDLOL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x6283D50", Offset = "0x6283150", VA = "0x186283D50")]
	[AsyncStateMachine(typeof(BAMCNDKLNEF))]
	private Task AIMPBCAHIGI(ABMIDKAKKGN EJJHDDFDLOL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x62853E0", Offset = "0x62847E0", VA = "0x1862853E0")]
	[AsyncStateMachine(typeof(NPIDIHECNPJ))]
	private Task PODHPJACMGF(ABMIDKAKKGN EJJHDDFDLOL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken GEHMHEOFNEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x6284890", Offset = "0x6283C90", VA = "0x186284890")]
	[AsyncStateMachine(typeof(AGCIFODCAGA))]
	private Task GLOPGDBLAGP(KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x6285290", Offset = "0x6284690", VA = "0x186285290")]
	[AsyncStateMachine(typeof(EMCJBGLEMFE))]
	private Task OFNGAHBNDFL(OKOIPJPAMDA OOIBMCBCEPD, BJKFFLKACKO DGFJADMMGJP, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x6284B80", Offset = "0x6283F80", VA = "0x186284B80")]
	[AsyncStateMachine(typeof(NHCBHCCKNMN))]
	private Task<FPMKBCLBDOA> INOLOOCAEDN(OKOIPJPAMDA OOIBMCBCEPD, CHGACGDBFPI IJLMKIGKLDL, BJKFFLKACKO DGFJADMMGJP, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x62850A0", Offset = "0x62844A0", VA = "0x1862850A0")]
	[AsyncStateMachine(typeof(ABDKMACGKMG))]
	private Task<FPMKBCLBDOA> LHKLDFDCAEF(OKOIPJPAMDA OOIBMCBCEPD, CHGACGDBFPI IJLMKIGKLDL, BJKFFLKACKO DGFJADMMGJP, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x62846D0", Offset = "0x6283AD0", VA = "0x1862846D0")]
	[AsyncStateMachine(typeof(ABCCAIENKIJ))]
	private Task<FPMKBCLBDOA> GJLMLCKNNHJ(FPMKBCLBDOA LADLFKDMJEN, OKOIPJPAMDA CBNHJABECIP, BJKFFLKACKO DGFJADMMGJP, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC, bool OADEGLEGEOK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x6284FB0", Offset = "0x62843B0", VA = "0x186284FB0")]
	private bool KLCIBEAKNGK(OKOIPJPAMDA LGCMDMKHJEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x6283E90", Offset = "0x6283290", VA = "0x186283E90")]
	[AsyncStateMachine(typeof(KODNLDNCKGC))]
	protected Task<FPMKBCLBDOA> BGCLGAJKCDN(OKOIPJPAMDA OOIBMCBCEPD, CHGACGDBFPI IJLMKIGKLDL, BJKFFLKACKO DGFJADMMGJP, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC, LBALLPKPJIK LJMOOJBBCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x6284270", Offset = "0x6283670", VA = "0x186284270")]
	[AsyncStateMachine(typeof(MNKGBGINBCI))]
	private Task CEOCNABKKML(OKOIPJPAMDA OOIBMCBCEPD, BJKFFLKACKO DGFJADMMGJP, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x6283D00", Offset = "0x6283100", VA = "0x186283D00")]
	private void ABIIHPFPFIC(FPMKBCLBDOA BBBFLDKINMI, BJKFFLKACKO DGFJADMMGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x62849A0", Offset = "0x6283DA0", VA = "0x1862849A0")]
	private void GLPBFJMOEPH(FPMKBCLBDOA BBKGOAMKDMK, [Out] FPMKBCLBDOA JHINLCJINKE, [Out] FPMKBCLBDOA GFCBFEELNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6284F70", Offset = "0x6284370", VA = "0x186284F70")]
	private Task<BGPAGBGDKBL> JIACJGOMDHF(ABMIDKAKKGN EJJHDDFDLOL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x6284850", Offset = "0x6283C50", VA = "0x186284850")]
	private Task<OKOIPJPAMDA> GKODLDIOHOM(BGPAGBGDKBL OOIBMCBCEPD, AOIDJKEPFOF.PEMLCFAHAFJ CMOHMLHFLNA, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6284A30", Offset = "0x6283E30", VA = "0x186284A30")]
	[AsyncStateMachine(typeof(EBEBANNMAHE))]
	private Task IKHNPEMALNC(OKOIPJPAMDA OOIBMCBCEPD, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC, bool GJNAKKLGJGP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x6284180", Offset = "0x6283580", VA = "0x186284180")]
	[AsyncStateMachine(typeof(HGNMPJMIJOJ))]
	private Task CDHJEHDHOMH(OKOIPJPAMDA OOIBMCBCEPD, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x6284400", Offset = "0x6283800", VA = "0x186284400")]
	private Task COPMJFFDOPO(OKOIPJPAMDA OOIBMCBCEPD, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6285250", Offset = "0x6284650", VA = "0x186285250")]
	private Task MDBDDBHPIBP(OKOIPJPAMDA OOIBMCBCEPD, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x62843E0", Offset = "0x62837E0", VA = "0x1862843E0")]
	private Task CKAGFGCLCDE(OKOIPJPAMDA OOIBMCBCEPD, CHGACGDBFPI IJLMKIGKLDL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6284E20", Offset = "0x6284220", VA = "0x186284E20")]
	private Task JFBFJLPLPBM(OKOIPJPAMDA OOIBMCBCEPD, CHGACGDBFPI IJLMKIGKLDL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6283880", Offset = "0x6282C80", VA = "0x186283880")]
	private static Task PHNCFKKJLIO(CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x62846B0", Offset = "0x6283AB0", VA = "0x1862846B0")]
	private Task ELCIGECAOHD(OKOIPJPAMDA OOIBMCBCEPD, CHGACGDBFPI IJLMKIGKLDL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6284CE0", Offset = "0x62840E0", VA = "0x186284CE0")]
	private Task JDJKMEAIMIB(OKOIPJPAMDA OOIBMCBCEPD, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x62849E0", Offset = "0x6283DE0", VA = "0x1862849E0")]
	private void HMEEKHACKJF(ABMIDKAKKGN EJJHDDFDLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6285270", Offset = "0x6284670", VA = "0x186285270")]
	public void NKCJDJOGNCH(long EBLCIIMJECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void LKJBEIIEFJL(FDKPOLPBLFH JNPLJPLJGKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal struct IHOALBIHHOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private OKOIPJPAMDA OOIBMCBCEPD;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CHMLDJDCJFC JIBKILINHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x62857D0", Offset = "0x6284BD0", VA = "0x1862857D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x6285820", Offset = "0x6284C20", VA = "0x186285820")]
	public static Task LAGINJJKIEC(FGMCJCFGAPG LGOFKBPFPIN, OKOIPJPAMDA OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x6285900", Offset = "0x6284D00", VA = "0x186285900")]
	private void LAGINJJKIEC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct HKGMPAMHGLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x6283880", Offset = "0x6282C80", VA = "0x186283880")]
	public static Task LAGINJJKIEC(CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct EJGGEENOFGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct CGFNHDPLGND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public HNIKGGHLOAK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x627C3B0", Offset = "0x627B7B0", VA = "0x18627C3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x627C910", Offset = "0x627BD10", VA = "0x18627C910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x627F110", Offset = "0x627E510", VA = "0x18627F110")]
	[AsyncStateMachine(typeof(CGFNHDPLGND))]
	public static Task LAGINJJKIEC(HNIKGGHLOAK CMCLMFBENFL, OKOIPJPAMDA OOIBMCBCEPD, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct NCIJHGEIKFI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct OIDMCDJBENE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public HNIKGGHLOAK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public CHGACGDBFPI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private FPMKBCLBDOA <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private FGMCJCFGAPG <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private CHMLDJDCJFC <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private IDisposable <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private List<(PersistenceView, DAJJDHFICPI)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private DAJJDHFICPI <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x628EB70", Offset = "0x628DF70", VA = "0x18628EB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x628F810", Offset = "0x628EC10", VA = "0x18628F810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x628BDA0", Offset = "0x628B1A0", VA = "0x18628BDA0")]
	[AsyncStateMachine(typeof(OIDMCDJBENE))]
	public static Task LAGINJJKIEC(HNIKGGHLOAK CMCLMFBENFL, OKOIPJPAMDA OOIBMCBCEPD, CHGACGDBFPI IJLMKIGKLDL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x628BEF0", Offset = "0x628B2F0", VA = "0x18628BEF0")]
	private static void NJDGDCGJIIK(PersistenceView MBDMIIMHHNK, DAJJDHFICPI JINLJHLPIMH, OKOIPJPAMDA OOIBMCBCEPD, FPMKBCLBDOA LADLFKDMJEN, bool NAGADMNOCPC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal struct IJCDMADCCGK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct IIEGPLGJCFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public FGMCJCFGAPG roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x6285B00", Offset = "0x6284F00", VA = "0x186285B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6285F40", Offset = "0x6285340", VA = "0x186285F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x6285FA0", Offset = "0x62853A0", VA = "0x186285FA0")]
	[AsyncStateMachine(typeof(IIEGPLGJCFO))]
	public static Task LAGINJJKIEC(FGMCJCFGAPG LGOFKBPFPIN, OKOIPJPAMDA OOIBMCBCEPD, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct KIBPJNIDAII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct GCGMMFBKFMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public FGMCJCFGAPG roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public HNIKGGHLOAK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x6281B30", Offset = "0x6280F30", VA = "0x186281B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x6281D40", Offset = "0x6281140", VA = "0x186281D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class IMKAANDHECD
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
			public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			public IMKAANDHECD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004E6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x62928F0", Offset = "0x6291CF0", VA = "0x1862928F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0x6292C80", Offset = "0x6292080", VA = "0x186292C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public IMKAANDHECD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x6286FB0", Offset = "0x62863B0", VA = "0x186286FB0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task PCPANOFDNOE(KGKDBPAMFIO<string>.HDBHKIOKMPF timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct OANLJGLPCKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public KIBPJNIDAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

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
		private TaskAwaiter<OCJBGBEKDGN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x628E160", Offset = "0x628D560", VA = "0x18628E160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x628EB10", Offset = "0x628DF10", VA = "0x18628EB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class BDLBJBNIPMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public DAACELPKEHI version;

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
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public BDLBJBNIPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x627C250", Offset = "0x627B650", VA = "0x18627C250")]
		internal object LOBJNNLENDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x627C1A0", Offset = "0x627B5A0", VA = "0x18627C1A0")]
		internal object BBBLKOEPBIM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private OKOIPJPAMDA OOIBMCBCEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private HNIKGGHLOAK CMCLMFBENFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private bool GJNAKKLGJGP;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private static readonly ByteString PAAIIAJKIIP;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private CHMLDJDCJFC JIBKILINHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6289200", Offset = "0x6288600", VA = "0x186289200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private EAKNENHMOPB DHPIDOBBJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x6289290", Offset = "0x6288690", VA = "0x186289290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x6289470", Offset = "0x6288870", VA = "0x186289470")]
	[AsyncStateMachine(typeof(GCGMMFBKFMO))]
	public static Task LAGINJJKIEC(FGMCJCFGAPG LGOFKBPFPIN, OKOIPJPAMDA OOIBMCBCEPD, HNIKGGHLOAK CMCLMFBENFL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC, bool GJNAKKLGJGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6289330", Offset = "0x6288730", VA = "0x186289330")]
	[AsyncStateMachine(typeof(OANLJGLPCKH))]
	private Task LAGINJJKIEC(KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x62895C0", Offset = "0x62889C0", VA = "0x1862895C0")]
	private void LCIDHMAGOBL([NotNull] KAIKLPKIAEH BCCEKGGHAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x6289250", Offset = "0x6288650", VA = "0x186289250")]
	private bool CNFMANBMIMB(DAACELPKEHI KAHINILDCOI, KAIKLPKIAEH BCCEKGGHAFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct LABMMGMFPEP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct FJKIMFMKNLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public AsyncTaskMethodBuilder<OKOIPJPAMDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public LABMMGMFPEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public AOIDJKEPFOF.PEMLCFAHAFJ downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private TaskAwaiter<(MEEAMGFNJIM<KCHJPABMKIM, PGBNOEKHDBP>, MEEAMGFNJIM<CAHCBJHECPF<KAIKLPKIAEH>, PGBNOEKHDBP>, MEEAMGFNJIM<CAHCBJHECPF<CMFAAJONIFD>, PGBNOEKHDBP>, MEEAMGFNJIM<CAHCBJHECPF<NDFHPLNPLMM>, PGBNOEKHDBP>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x62804B0", Offset = "0x627F8B0", VA = "0x1862804B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6280EA0", Offset = "0x62802A0", VA = "0x186280EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct FKLOCDBBFJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<KCHJPABMKIM, PGBNOEKHDBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public LABMMGMFPEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public AOIDJKEPFOF.PEMLCFAHAFJ downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private TaskAwaiter<MEEAMGFNJIM<KCHJPABMKIM, PGBNOEKHDBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6280F10", Offset = "0x6280310", VA = "0x186280F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6281500", Offset = "0x6280900", VA = "0x186281500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private JPIEJFPOKCJ<IGNOFONIPFC, CMFAAJONIFD> ELKOIGLOKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private JPIEJFPOKCJ<IGNOFONIPFC, KAIKLPKIAEH> HNMIJBMDHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private JPIEJFPOKCJ<long, NDFHPLNPLMM> DDILIFABNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private GHELNDHPLBF JJKKBAIAKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private FDKPOLPBLFH JNPLJPLJGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private DFEHFHGPFLB FBOLIGJLGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private string ACDLOAEPCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private IGNOFONIPFC ILOGCLKGEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private IGNOFONIPFC DHAFNCNBMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private long EBLCIIMJECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x628A5D0", Offset = "0x62899D0", VA = "0x18628A5D0")]
	public static Task<OKOIPJPAMDA> DMIMJDPHMIB(FGMCJCFGAPG LGOFKBPFPIN, [In] BGPAGBGDKBL OOIBMCBCEPD, AOIDJKEPFOF.PEMLCFAHAFJ CMOHMLHFLNA, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x628A940", Offset = "0x6289D40", VA = "0x18628A940")]
	[AsyncStateMachine(typeof(FJKIMFMKNLD))]
	private Task<OKOIPJPAMDA> LAGINJJKIEC(AOIDJKEPFOF.PEMLCFAHAFJ CMOHMLHFLNA, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x628A420", Offset = "0x6289820", VA = "0x18628A420")]
	[AsyncStateMachine(typeof(FKLOCDBBFJA))]
	private Task<MEEAMGFNJIM<KCHJPABMKIM, PGBNOEKHDBP>> CHKJCHCLLMO(string ACDLOAEPCEG, long EBLCIIMJECI, AOIDJKEPFOF.PEMLCFAHAFJ CMOHMLHFLNA, KGKDBPAMFIO<string>.HDBHKIOKMPF LGKLLEFGEGD, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct FNBFHOOFKOG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct FLPFNODGKOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder<BGPAGBGDKBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public FNBFHOOFKOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter<BGPAGBGDKBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x629D530", Offset = "0x629C930", VA = "0x18629D530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x629D930", Offset = "0x629CD30", VA = "0x18629D930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct KFMHLNKEKIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public AsyncTaskMethodBuilder<BGPAGBGDKBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public FNBFHOOFKOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter<BGPAGBGDKBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x62A5A70", Offset = "0x62A4E70", VA = "0x1862A5A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x62A5E70", Offset = "0x62A5270", VA = "0x1862A5E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class CKBNKOHNJGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CKBNKOHNJGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x12CF570", Offset = "0x12CE970", VA = "0x1812CF570")]
		internal bool NCCACJCNBIF(DFEHFHGPFLB sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct IILHBLPCLFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AsyncTaskMethodBuilder<BGPAGBGDKBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public IGNOFONIPFC superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public CHMLDJDCJFC callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private CKBNKOHNJGF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private FDKPOLPBLFH <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private DFEHFHGPFLB <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private IGNOFONIPFC <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private IGNOFONIPFC <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private TaskAwaiter<FDKPOLPBLFH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private TaskAwaiter<OGMJBCAALDL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private TaskAwaiter<HDMEAOOCBIO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x62A26E0", Offset = "0x62A1AE0", VA = "0x1862A26E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x62A3780", Offset = "0x62A2B80", VA = "0x1862A3780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private CHMLDJDCJFC FDEKFCDLHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private OKADPHKNNFI OCAFCJCEGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private long BLPLCJENHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private long CAHHMNIGLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private long DHIEKGKANNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private string FNOFHHIOKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private IGNOFONIPFC CKPCKPIMAAF;

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x629DCA0", Offset = "0x629D0A0", VA = "0x18629DCA0")]
	public static Task<BGPAGBGDKBL> DMIMJDPHMIB(FGMCJCFGAPG LGOFKBPFPIN, ABMIDKAKKGN EJJHDDFDLOL, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x629E210", Offset = "0x629D610", VA = "0x18629E210")]
	[AsyncStateMachine(typeof(FLPFNODGKOG))]
	private Task<BGPAGBGDKBL> LAGINJJKIEC(CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x629E0B0", Offset = "0x629D4B0", VA = "0x18629E0B0")]
	[AsyncStateMachine(typeof(KFMHLNKEKIP))]
	private Task<BGPAGBGDKBL> JIACJGOMDHF(KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x629DF20", Offset = "0x629D320", VA = "0x18629DF20")]
	[AsyncStateMachine(typeof(IILHBLPCLFP))]
	private static Task<BGPAGBGDKBL> JIACJGOMDHF(CHMLDJDCJFC FDEKFCDLHEC, long BLPLCJENHDJ, long CAHHMNIGLJL, long DHIEKGKANNH, string FNOFHHIOKHC, IGNOFONIPFC CKPCKPIMAAF, CancellationToken OMFABMCIOAC, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x629DC70", Offset = "0x629D070", VA = "0x18629DC70")]
	private void DLPMLOJKKDE(FDKPOLPBLFH JNPLJPLJGKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct CKEHADCAPOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct OMKBGLGEALG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public CKEHADCAPOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x62AA2E0", Offset = "0x62A96E0", VA = "0x1862AA2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x62AA870", Offset = "0x62A9C70", VA = "0x1862AA870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private CHMLDJDCJFC FDEKFCDLHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private OKOIPJPAMDA OOIBMCBCEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private float IAMLPILJBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private float DCMEMMJBNDB;

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x6297B90", Offset = "0x6296F90", VA = "0x186297B90")]
	public static Task IGAMBIMOMAL(FGMCJCFGAPG LGOFKBPFPIN, OKOIPJPAMDA OOIBMCBCEPD, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x6297D30", Offset = "0x6297130", VA = "0x186297D30")]
	[AsyncStateMachine(typeof(OMKBGLGEALG))]
	public Task LAGINJJKIEC(CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x6297E50", Offset = "0x6297250", VA = "0x186297E50")]
	private static void OJMIBNLGLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x6297950", Offset = "0x6296D50", VA = "0x186297950")]
	private void AKKFMIKNLNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x6297AD0", Offset = "0x6296ED0", VA = "0x186297AD0")]
	private static float HFCEGMGIAJI(CHMLDJDCJFC FDEKFCDLHEC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6297AB0", Offset = "0x6296EB0", VA = "0x186297AB0")]
	private static float FFDFDOIGBKH()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct PJOLNMDCHJI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct JKODMEBEIFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public HNIKGGHLOAK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private KHKLNHABCFF <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private FGMCJCFGAPG <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private LPPMANPEGIL.JGJOKBIANFC <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private TaskAwaiter<OCJBGBEKDGN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x62A4310", Offset = "0x62A3710", VA = "0x1862A4310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x62A4D00", Offset = "0x62A4100", VA = "0x1862A4D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct LCIBCDCKLIC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62A6470", Offset = "0x62A5870", VA = "0x1862A6470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x62A67A0", Offset = "0x62A5BA0", VA = "0x1862A67A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x62AB4B0", Offset = "0x62AA8B0", VA = "0x1862AB4B0")]
	[AsyncStateMachine(typeof(JKODMEBEIFL))]
	public static Task LAGINJJKIEC(HNIKGGHLOAK CMCLMFBENFL, OKOIPJPAMDA OOIBMCBCEPD, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x62AB5F0", Offset = "0x62AA9F0", VA = "0x1862AB5F0")]
	private static Task<OCJBGBEKDGN> MNEJNIPLBML(HNIKGGHLOAK CMCLMFBENFL, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x62AB400", Offset = "0x62AA800", VA = "0x1862AB400")]
	[AsyncStateMachine(typeof(LCIBCDCKLIC))]
	private static Task CKJFJFFDPEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal struct MLNCEALJJCA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct FAOLBKJDDBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public MLNCEALJJCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x629C270", Offset = "0x629B670", VA = "0x18629C270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x629C920", Offset = "0x629BD20", VA = "0x18629C920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class DODLPIAHKFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public DODLPIAHKFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x62995C0", Offset = "0x62989C0", VA = "0x1862995C0")]
		internal object BLLDGCHFHJH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct KBAJOGLPHIA : IAsyncStateMachine
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
		public MLNCEALJJCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private EGOJNOCCOCF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x62A5400", Offset = "0x62A4800", VA = "0x1862A5400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x62A5A10", Offset = "0x62A4E10", VA = "0x1862A5A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private bool IOLCJHGGPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	private KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	private FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	private CancellationToken OMFABMCIOAC;

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x62A9440", Offset = "0x62A8840", VA = "0x1862A9440")]
	public static Task GNCEEKIFBFC(FGMCJCFGAPG LGOFKBPFPIN, bool IOLCJHGGPKA, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken GALIAPOJGAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x62A94B0", Offset = "0x62A88B0", VA = "0x1862A94B0")]
	[AsyncStateMachine(typeof(FAOLBKJDDBE))]
	private Task LAGINJJKIEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x62A9310", Offset = "0x62A8710", VA = "0x1862A9310")]
	[AsyncStateMachine(typeof(KBAJOGLPHIA))]
	private Task DPMFMBNLPKI(bool OEHLEEEPFHF, string GJEIIMEENIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280")]
	private bool KIFILEJLCEA(bool IOLCJHGGPKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct JBGNJGKBPKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct EEABJMPECNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public JBGNJGKBPKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x6299E20", Offset = "0x6299220", VA = "0x186299E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x629A390", Offset = "0x6299790", VA = "0x18629A390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class MODCNGBKHMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public MODCNGBKHMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x62A9C80", Offset = "0x62A9080", VA = "0x1862A9C80")]
		internal object BLLDGCHFHJH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct KAPPMEJAFFG : IAsyncStateMachine
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
		public JBGNJGKBPKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private EGOJNOCCOCF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x62A4DB0", Offset = "0x62A41B0", VA = "0x1862A4DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x62A5390", Offset = "0x62A4790", VA = "0x1862A5390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private LLCEIPACFKB EPFALHAKPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private bool KMNANENIOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private OKOIPJPAMDA OOIBMCBCEPD;

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x62A4290", Offset = "0x62A3690", VA = "0x1862A4290")]
	public static Task<Scene> PMHMGJCMFBO(FGMCJCFGAPG LGOFKBPFPIN, LLCEIPACFKB NDEAIIBDOAB, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x62A4170", Offset = "0x62A3570", VA = "0x1862A4170")]
	[AsyncStateMachine(typeof(EEABJMPECNH))]
	private Task<Scene> LAGINJJKIEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x62A4140", Offset = "0x62A3540", VA = "0x1862A4140")]
	private bool JBJMNCKONBG(OKOIPJPAMDA OOIBMCBCEPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x62A3F80", Offset = "0x62A3380", VA = "0x1862A3F80")]
	private void DFAFHEDHMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x62A3FF0", Offset = "0x62A33F0", VA = "0x1862A3FF0")]
	[AsyncStateMachine(typeof(KAPPMEJAFFG))]
	private Task<Scene> DPMFMBNLPKI(string GJEIIMEENIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct GNIKBMOEOGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct GNDEDNALAFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public AsyncTaskMethodBuilder<FPMKBCLBDOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public GNIKBMOEOGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public FPMKBCLBDOA nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public OKOIPJPAMDA deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<FPMKBCLBDOA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x629E360", Offset = "0x629D760", VA = "0x18629E360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x629EE40", Offset = "0x629E240", VA = "0x18629EE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct DBCKEICOACF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder<FPMKBCLBDOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public GNIKBMOEOGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public FPMKBCLBDOA state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter<OCJBGBEKDGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x6298D30", Offset = "0x6298130", VA = "0x186298D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x6299010", Offset = "0x6298410", VA = "0x186299010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private readonly HNIKGGHLOAK CMCLMFBENFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private readonly OKADPHKNNFI OCAFCJCEGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private readonly GNGIEKHFEHI ALHIMFANBMJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private KHKLNHABCFF PNLPMJNOAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x4C79990", Offset = "0x4C78D90", VA = "0x184C79990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x62A0140", Offset = "0x629F540", VA = "0x1862A0140")]
	public GNIKBMOEOGP(HNIKGGHLOAK CMCLMFBENFL, OKADPHKNNFI OCAFCJCEGID, GNGIEKHFEHI ALHIMFANBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x629FFC0", Offset = "0x629F3C0", VA = "0x18629FFC0")]
	[AsyncStateMachine(typeof(GNDEDNALAFP))]
	public Task<FPMKBCLBDOA> OHNOPNLCALN(FPMKBCLBDOA GDKPIEAGMGJ, OKOIPJPAMDA CBNHJABECIP, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC, bool OADEGLEGEOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x629FE40", Offset = "0x629F240", VA = "0x18629FE40")]
	[AsyncStateMachine(typeof(DBCKEICOACF))]
	private Task<FPMKBCLBDOA> DKGKEKMGEPB(KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, FPMKBCLBDOA CGABFKIJBOC, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x629FE10", Offset = "0x629F210", VA = "0x18629FE10")]
	private bool CLNCBFOBBBO(FPMKBCLBDOA OCOFJDEDMOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x629FFA0", Offset = "0x629F3A0", VA = "0x18629FFA0")]
	private void IJCNCIMJJJN(string AJGMBAOCDMI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct BLPBBANFGDB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct PHFEOJMMFPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public KHKLNHABCFF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public CHGACGDBFPI timedYielder;

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
		private List<(PersistenceView, DAJJDHFICPI)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private (PersistenceView, DAJJDHFICPI) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x62AAD60", Offset = "0x62AA160", VA = "0x1862AAD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x62AB3A0", Offset = "0x62AA7A0", VA = "0x1862AB3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x62965B0", Offset = "0x62959B0", VA = "0x1862965B0")]
	[AsyncStateMachine(typeof(PHFEOJMMFPM))]
	public static Task LAGINJJKIEC(KHKLNHABCFF PLBKMELAPOA, OKOIPJPAMDA OOIBMCBCEPD, CHGACGDBFPI IJLMKIGKLDL, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct EBBPGCEBAMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct BGDAEHCKOIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public KHKLNHABCFF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public CHGACGDBFPI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private DAACELPKEHI <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private List<(PersistenceView, DAJJDHFICPI)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private DAJJDHFICPI <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x6294BD0", Offset = "0x6293FD0", VA = "0x186294BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x6295430", Offset = "0x6294830", VA = "0x186295430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x6299CE0", Offset = "0x62990E0", VA = "0x186299CE0")]
	[AsyncStateMachine(typeof(BGDAEHCKOIG))]
	public static Task LAGINJJKIEC(KHKLNHABCFF PLBKMELAPOA, OKOIPJPAMDA OOIBMCBCEPD, CHGACGDBFPI IJLMKIGKLDL, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct LPPMANPEGIL
{
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	public struct JGJOKBIANFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public List<DIDBMPMOKJC> PAOPCNINMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public List<DAJJDHFICPI> NMPLMBLJGFF;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x7CF750", Offset = "0x7CEB50", VA = "0x1807CF750")]
		public JGJOKBIANFC(List<DIDBMPMOKJC> PAOPCNINMFE, List<DAJJDHFICPI> NMPLMBLJGFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class DKEIJCJEFCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public IEnumerable<DIDBMPMOKJC> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public DKEIJCJEFCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x6299540", Offset = "0x6298940", VA = "0x186299540")]
		internal object DAONEHMGOHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	private FGMCJCFGAPG LGOFKBPFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private OKOIPJPAMDA OOIBMCBCEPD;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private CHMLDJDCJFC JIBKILINHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x62A7510", Offset = "0x62A6910", VA = "0x1862A7510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x62A7F40", Offset = "0x62A7340", VA = "0x1862A7F40")]
	public static JGJOKBIANFC LAGINJJKIEC(FGMCJCFGAPG LGOFKBPFPIN, OKOIPJPAMDA OOIBMCBCEPD)
	{
		return default(JGJOKBIANFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x62A7CE0", Offset = "0x62A70E0", VA = "0x1862A7CE0")]
	private JGJOKBIANFC LAGINJJKIEC()
	{
		return default(JGJOKBIANFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x62A7730", Offset = "0x62A6B30", VA = "0x1862A7730")]
	private JGJOKBIANFC IEPLMKFOPBK(KAIKLPKIAEH BCCEKGGHAFC, DAACELPKEHI PNGFHHEKPJA)
	{
		return default(JGJOKBIANFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x62A7560", Offset = "0x62A6960", VA = "0x1862A7560")]
	private bool GKHGCAJBCGG(IEnumerable<DIDBMPMOKJC> PAOPCNINMFE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct ELPCLLMBHJA
{
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class IKIJKFPICBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public LPPMANPEGIL.JGJOKBIANFC instantiations;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public IKIJKFPICBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x62A37F0", Offset = "0x62A2BF0", VA = "0x1862A37F0")]
		internal object PCPANOFDNOE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class HGNAEHKIJCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HGNAEHKIJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x62A1380", Offset = "0x62A0780", VA = "0x1862A1380")]
		internal object KNIOAMHIOPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x629B560", Offset = "0x629A960", VA = "0x18629B560")]
	public static void LAGINJJKIEC(KHKLNHABCFF PLBKMELAPOA, OKOIPJPAMDA OOIBMCBCEPD, LPPMANPEGIL.JGJOKBIANFC GLOKOAEHOBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal class GNGIEKHFEHI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct MCPMEJEENBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public GNGIEKHFEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public FPMKBCLBDOA operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public OKOIPJPAMDA deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x62A8680", Offset = "0x62A7A80", VA = "0x1862A8680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x62A8DF0", Offset = "0x62A81F0", VA = "0x1862A8DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class IIAILDICBME
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
			public IIAILDICBME <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x62AB860", Offset = "0x62AAC60", VA = "0x1862AB860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x62ABB20", Offset = "0x62AAF20", VA = "0x1862ABB20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public GNGIEKHFEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public IIAILDICBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x62A1D40", Offset = "0x62A1140", VA = "0x1862A1D40")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task JHPCAEBHCMM(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct KHKLCAOHBAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public GNGIEKHFEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private IIAILDICBME <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x62A5EE0", Offset = "0x62A52E0", VA = "0x1862A5EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x62A6410", Offset = "0x62A5810", VA = "0x1862A6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct HONOIINMFEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public GNGIEKHFEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private Dictionary<Guid, List<DAMKILFCPKF>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x62A1730", Offset = "0x62A0B30", VA = "0x1862A1730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x62A1CE0", Offset = "0x62A10E0", VA = "0x1862A1CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct MMELAKOMGEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public GNGIEKHFEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private Dictionary<Guid, List<DAMKILFCPKF>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x62A95A0", Offset = "0x62A89A0", VA = "0x1862A95A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x62A9C20", Offset = "0x62A9020", VA = "0x1862A9C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class FMBIHDINDAO
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
			public DAMKILFCPKF handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005ED")]
			public FMBIHDINDAO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005EE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x62AB660", Offset = "0x62AAA60", VA = "0x1862AB660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x62AB800", Offset = "0x62AAC00", VA = "0x1862AB800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public PPCBJELGMIE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public List<DAMKILFCPKF> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public FMBIHDINDAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x629DA90", Offset = "0x629CE90", VA = "0x18629DA90")]
		internal object LCKFKKNLGGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x629DB80", Offset = "0x629CF80", VA = "0x18629DB80")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task PAFEHKAMGNP(DAMKILFCPKF handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x629D9A0", Offset = "0x629CDA0", VA = "0x18629D9A0")]
		internal object KDJKKJFCCJM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct CACCCFEBALH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public PPCBJELGMIE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public List<DAMKILFCPKF> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private FMBIHDINDAO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x6296A20", Offset = "0x6295E20", VA = "0x186296A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x6296EF0", Offset = "0x62962F0", VA = "0x186296EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct NIJDDEAOKHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public GNGIEKHFEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public OKOIPJPAMDA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF timer;

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
		[Cpp2IlInjected.Address(RVA = "0x62A9CD0", Offset = "0x62A90D0", VA = "0x1862A9CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x62AA280", Offset = "0x62A9680", VA = "0x1862AA280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class ACGMIGPOMGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ACGMIGPOMGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x6293610", Offset = "0x6292A10", VA = "0x186293610")]
		internal object POBONOBBBBO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct IMAICELMALM : IAsyncStateMachine
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
		public GNGIEKHFEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public OKOIPJPAMDA data;

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
		[Cpp2IlInjected.Address(RVA = "0x62A38A0", Offset = "0x62A2CA0", VA = "0x1862A38A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x62A3DB0", Offset = "0x62A31B0", VA = "0x1862A3DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class CAONIEONPDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CAONIEONPDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x6296F50", Offset = "0x6296350", VA = "0x186296F50")]
		internal object ANFBMFCEGFK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct MAKJFOPJMOL : IAsyncStateMachine
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
		public GNGIEKHFEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private TaskAwaiter<OCJBGBEKDGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x62A7FA0", Offset = "0x62A73A0", VA = "0x1862A7FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x62A8620", Offset = "0x62A7A20", VA = "0x1862A8620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class CEIBJAMFENB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CEIBJAMFENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x6296FC0", Offset = "0x62963C0", VA = "0x186296FC0")]
		internal object PNGLDAAEOFA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	private readonly HNIKGGHLOAK CMCLMFBENFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private DEBEGMIAJGN ALHIMFANBMJ;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private KHKLNHABCFF PNLPMJNOAJG
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x19E0420", Offset = "0x19DF820", VA = "0x1819E0420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	public GNGIEKHFEHI(HNIKGGHLOAK CMCLMFBENFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x629F540", Offset = "0x629E940", VA = "0x18629F540")]
	[AsyncStateMachine(typeof(MCPMEJEENBM))]
	public Task LAGINJJKIEC(FPMKBCLBDOA LADLFKDMJEN, OKOIPJPAMDA CBNHJABECIP, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x629F690", Offset = "0x629EA90", VA = "0x18629F690")]
	[AsyncStateMachine(typeof(KHKLCAOHBAA))]
	private Task MFHEENHKFFD(OKOIPJPAMDA OOIBMCBCEPD, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x629F180", Offset = "0x629E580", VA = "0x18629F180")]
	[AsyncStateMachine(typeof(HONOIINMFEL))]
	private Task DOJAFMCEFHF(OKOIPJPAMDA OOIBMCBCEPD, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x629EEB0", Offset = "0x629E2B0", VA = "0x18629EEB0")]
	[AsyncStateMachine(typeof(MMELAKOMGEL))]
	private Task CBJGBPHGGPH(OKOIPJPAMDA OOIBMCBCEPD, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x629F7D0", Offset = "0x629EBD0", VA = "0x18629F7D0")]
	[AsyncStateMachine(typeof(CACCCFEBALH))]
	private Task NEPOAHDMILC(Guid IEJPLJFGKKB, List<DAMKILFCPKF> ABENPBHLFGA, PPCBJELGMIE AMPFAPBAEMK, OKOIPJPAMDA OOIBMCBCEPD, CancellationToken IBLOMPOENGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x629F400", Offset = "0x629E800", VA = "0x18629F400")]
	[AsyncStateMachine(typeof(NIJDDEAOKHO))]
	private Task GIFIFHPKLNM(OKOIPJPAMDA OOIBMCBCEPD, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x629FAF0", Offset = "0x629EEF0", VA = "0x18629FAF0")]
	[AsyncStateMachine(typeof(IMAICELMALM))]
	private Task PENLAGNJDOP(Guid ICNJDMPDDFE, OKOIPJPAMDA OOIBMCBCEPD, KGKDBPAMFIO<string>.HDBHKIOKMPF LHJMFKIBCKM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x629F2C0", Offset = "0x629E6C0", VA = "0x18629F2C0")]
	[AsyncStateMachine(typeof(MAKJFOPJMOL))]
	private Task FGNHLMALGOJ(Guid ICNJDMPDDFE, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x629F9D0", Offset = "0x629EDD0", VA = "0x18629F9D0")]
	private void ONBPEDIPEIF(Guid ICNJDMPDDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x629F920", Offset = "0x629ED20", VA = "0x18629F920")]
	private void OIBNCLHNINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x629EFF0", Offset = "0x629E3F0", VA = "0x18629EFF0")]
	public Guid CBMEDMGJJKM(FPMKBCLBDOA BBBFLDKINMI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x629FC30", Offset = "0x629F030", VA = "0x18629FC30")]
	[CompilerGenerated]
	private object PLEBCBAFPEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
public readonly struct IDBGIKDPAIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	public readonly bool NHCNKIGEOCF;

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0xB15050", Offset = "0xB14450", VA = "0x180B15050")]
	public IDBGIKDPAIG(bool HDPONHAIFFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public readonly struct BLOPIEONCGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	public readonly KAIKLPKIAEH? PKJBAFJBIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	public readonly KDOGLIIIJHM EGNNHAFMBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	public readonly string? DLNJECCIOMN;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IReadOnlyCollection<string> HDCDGEGKEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x6296490", Offset = "0x6295890", VA = "0x186296490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public IReadOnlyDictionary<long, int> BAHEDKKNFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x6296470", Offset = "0x6295870", VA = "0x186296470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x62964B0", Offset = "0x62958B0", VA = "0x1862964B0")]
	public BLOPIEONCGA(KAIKLPKIAEH? NDJHINJFLAD, KDOGLIIIJHM KFELNOPEACA, string? ACDLOAEPCEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
internal class EEPBGGBDJMA : OMKIAIBIPPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct HAMDDPCNONO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public AsyncTaskMethodBuilder<BLOPIEONCGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public EEPBGGBDJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public NHCLIMEGHJE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public KJGPAHOKGPF roomSaveOptions;

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
		[Cpp2IlInjected.Address(RVA = "0x62A0370", Offset = "0x629F770", VA = "0x1862A0370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x62A0A10", Offset = "0x629FE10", VA = "0x1862A0A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class CMLNGAHOABE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public NHCLIMEGHJE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public EEPBGGBDJMA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CMLNGAHOABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x6297F90", Offset = "0x6297390", VA = "0x186297F90")]
		internal Task CJJJFELEBAO(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x62981B0", Offset = "0x62975B0", VA = "0x1862981B0")]
		internal Task PGBGGEALLMO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class FAILLAHKIOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public CMLNGAHOABE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public FAILLAHKIOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x629C200", Offset = "0x629B600", VA = "0x18629C200")]
		internal object NGFEIPBNLLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class IOFGFLPMENB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public CMLNGAHOABE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public IOFGFLPMENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x62A3F40", Offset = "0x62A3340", VA = "0x1862A3F40")]
		internal Task CNPJEOKPMKN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct CFIMLNNABNH : IAsyncStateMachine
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
		public NHCLIMEGHJE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public EEPBGGBDJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private FAILLAHKIOE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x6297030", Offset = "0x6296430", VA = "0x186297030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x62978F0", Offset = "0x6296CF0", VA = "0x1862978F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private static readonly TimeSpan LNBFCNIPNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private readonly BNMDBIEHLLE BBPBLKHNHEB;

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x629B4A0", Offset = "0x629A8A0", VA = "0x18629B4A0")]
	public EEPBGGBDJMA(HNIKGGHLOAK CMCLMFBENFL, BNMDBIEHLLE BBPBLKHNHEB, FJOGIBEAJHF AABDFOONPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x629A960", Offset = "0x6299D60", VA = "0x18629A960")]
	[AsyncStateMachine(typeof(HAMDDPCNONO))]
	public Task<BLOPIEONCGA> MFIMBGNEKOH(long CAHHMNIGLJL, KJGPAHOKGPF MJLMKKAJKEC, NHCLIMEGHJE KGMDBFCGIOH, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x629A810", Offset = "0x6299C10", VA = "0x18629A810")]
	[AsyncStateMachine(typeof(CFIMLNNABNH))]
	private Task LILFLJDBCDF(NHCLIMEGHJE KGMDBFCGIOH, IEnumerable<PersistenceView> LGLNEABPCOD, StringBuilder JPNHEPKFPOA, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x629AF90", Offset = "0x629A390", VA = "0x18629AF90")]
	private BLOPIEONCGA PDDFFCIDBPF(long CAHHMNIGLJL, KJGPAHOKGPF MJLMKKAJKEC, NHCLIMEGHJE KGMDBFCGIOH, IEnumerable<PersistenceView> LGLNEABPCOD, StringBuilder JPNHEPKFPOA)
	{
		return default(BLOPIEONCGA);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x629A400", Offset = "0x6299800", VA = "0x18629A400")]
	private KAIKLPKIAEH AMDEHPCPBGK(long CAHHMNIGLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x629A5C0", Offset = "0x62999C0", VA = "0x18629A5C0")]
	private void HKDEHJMMJNI(KAIKLPKIAEH EAAJIENBCOL, StringBuilder JPNHEPKFPOA, IEnumerable<PersistenceView> LGLNEABPCOD, [In] JDCLMKKKNDO FCPFLJOBOCA, AFOPDHFCNEP ONKGGJNCDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x629AAC0", Offset = "0x6299EC0", VA = "0x18629AAC0")]
	private void MHIIEEBBBCH(KAIKLPKIAEH EAAJIENBCOL, StringBuilder JPNHEPKFPOA, PersistenceView MBDMIIMHHNK, AFOPDHFCNEP ONKGGJNCDKC, [In] JDCLMKKKNDO FCPFLJOBOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal class EMAHJKMLAHO : OMKIAIBIPPM
{
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class KALPECOHMDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public JDLHPELPAPJ.HAFFLOGODNJ roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public KALPECOHMDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x62A4D60", Offset = "0x62A4160", VA = "0x1862A4D60")]
		internal object EAPEFLBGOLM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct IIBDPAHBIEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public AsyncTaskMethodBuilder<(JDLHPELPAPJ.HAFFLOGODNJ roomDataUpload, JDLHPELPAPJ.HAFFLOGODNJ subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public BLOPIEONCGA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public EMAHJKMLAHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private KALPECOHMDF <>8__1;

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
		private TaskAwaiter<JDLHPELPAPJ.HAFFLOGODNJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x62A1E30", Offset = "0x62A1230", VA = "0x1862A1E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x62A2670", Offset = "0x62A1A70", VA = "0x1862A2670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct FGFFFOBAJNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public AsyncTaskMethodBuilder<EOMDJPDNCEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public EMAHJKMLAHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public BLOPIEONCGA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public NNDEIDFMMBL roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private TaskAwaiter<(JDLHPELPAPJ.HAFFLOGODNJ roomDataUpload, JDLHPELPAPJ.HAFFLOGODNJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private TaskAwaiter<EOMDJPDNCEE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x629C980", Offset = "0x629BD80", VA = "0x18629C980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x629CFA0", Offset = "0x629C3A0", VA = "0x18629CFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct PCHBAEGMCAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public AsyncTaskMethodBuilder<OGMJBCAALDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public EMAHJKMLAHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public BLOPIEONCGA roomSerializedData;

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
		private TaskAwaiter<(JDLHPELPAPJ.HAFFLOGODNJ roomDataUpload, JDLHPELPAPJ.HAFFLOGODNJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private TaskAwaiter<OGMJBCAALDL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x62AA8D0", Offset = "0x62A9CD0", VA = "0x1862AA8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x62AACF0", Offset = "0x62AA0F0", VA = "0x1862AACF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class INNJLDAPGFG
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
			public AsyncTaskMethodBuilder<OCJBGBEKDGN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			public INNJLDAPGFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400066B")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400066C")]
			private OCJBGBEKDGN <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400066D")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400066E")]
			private TaskAwaiter<OGMJBCAALDL> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400066F")]
			private TaskAwaiter<EOMDJPDNCEE> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000670")]
			private TaskAwaiter<OCJBGBEKDGN> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x62ABB80", Offset = "0x62AAF80", VA = "0x1862ABB80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x62ACB80", Offset = "0x62ABF80", VA = "0x1862ACB80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public EMAHJKMLAHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public BLOPIEONCGA roomSerializedData;

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
		public NNDEIDFMMBL roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public IDBGIKDPAIG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public INNJLDAPGFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x62A3E10", Offset = "0x62A3210", VA = "0x1862A3E10")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<OCJBGBEKDGN> MAJILDKCCIK(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct FHLDPAMAEDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public AsyncTaskMethodBuilder<OCJBGBEKDGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public EMAHJKMLAHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public BLOPIEONCGA roomSerializedData;

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
		public NNDEIDFMMBL roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public IDBGIKDPAIG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private TaskAwaiter<OCJBGBEKDGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x629D010", Offset = "0x629C410", VA = "0x18629D010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x629D320", Offset = "0x629C720", VA = "0x18629D320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x4000640")]
	private static readonly FJOGIBEAJHF JHIIOOHKCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private readonly BEBAGOEJLNM PEPPDFGOAIH;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private FGMCJCFGAPG HGHPMDMDHLB
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6285220", Offset = "0x6284620", VA = "0x186285220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x629C170", Offset = "0x629B570", VA = "0x18629C170")]
	public EMAHJKMLAHO(HNIKGGHLOAK CMCLMFBENFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x629BC80", Offset = "0x629B080", VA = "0x18629BC80")]
	[AsyncStateMachine(typeof(IIBDPAHBIEG))]
	private Task<(JDLHPELPAPJ.HAFFLOGODNJ, JDLHPELPAPJ.HAFFLOGODNJ)> BPCNKOGMFDC(BLOPIEONCGA BNLKEIJBFNK, long BLPLCJENHDJ, long PINPACMDEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x629BB10", Offset = "0x629AF10", VA = "0x18629BB10")]
	[AsyncStateMachine(typeof(FGFFFOBAJNJ))]
	public Task<EOMDJPDNCEE> ANIFELOCJFE(int NFJKFKHHGIB, [CanBeNull] NNDEIDFMMBL PEMMFKFLKEL, BLOPIEONCGA BNLKEIJBFNK, long BLPLCJENHDJ, long PINPACMDEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x629BDC0", Offset = "0x629B1C0", VA = "0x18629BDC0")]
	[AsyncStateMachine(typeof(PCHBAEGMCAK))]
	private Task<OGMJBCAALDL> ODOHNHBBOPM(string FNOFHHIOKHC, int NFJKFKHHGIB, BLOPIEONCGA BNLKEIJBFNK, long BLPLCJENHDJ, long PINPACMDEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x629BF30", Offset = "0x629B330", VA = "0x18629BF30")]
	[AsyncStateMachine(typeof(FHLDPAMAEDM))]
	public Task<OCJBGBEKDGN> OIGFMECNNFH(int NFJKFKHHGIB, NNDEIDFMMBL? PEMMFKFLKEL, BLOPIEONCGA BNLKEIJBFNK, long BLPLCJENHDJ, long PINPACMDEDH, IDBGIKDPAIG ODHKJNFLHPH, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public abstract class MOPLABCEHIA<T> where T : MOPLABCEHIA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067D")]
	internal readonly FGMCJCFGAPG PPMOEMCCOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private int? IMOPEGMONJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	protected readonly Guid EHNJNMFMEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	protected readonly BNGAGHFEKJK ECHOEIBACHF;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	protected T HFCDBLOODHD
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3B8EDD0", Offset = "0x3B8E1D0", VA = "0x183B8EDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x3B8EF10", Offset = "0x3B8E310", VA = "0x183B8EF10")]
	internal MOPLABCEHIA(FGMCJCFGAPG GGEOHCCNMAF, BNGAGHFEKJK FCOLEJMPJKO, [Optional] Guid? CEMPKOIGLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x3B8EE30", Offset = "0x3B8E230", VA = "0x183B8EE30")]
	private OCJBGBEKDGN MCFEHNHEEAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "4")]
	protected virtual void AANLFGAHHLP(OCJBGBEKDGN LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x3B8EC20", Offset = "0x3B8E020", VA = "0x183B8EC20")]
	public T CHLFGPGFMCF(KEMOGAOMDFA ENPJGNCLGBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x3B8EB90", Offset = "0x3B8DF90", VA = "0x183B8EB90")]
	public T AHCCKPBPAFL(int CIFFIAEKEEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x3B8ECB0", Offset = "0x3B8E0B0", VA = "0x183B8ECB0", Slot = "5")]
	public virtual Task<KLJJBFIAHEC> DAMIPHCJHLB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class FKIJPOFAOED : MOPLABCEHIA<FKIJPOFAOED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private ABMIDKAKKGN CJFCIOOMJGN;

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x629D460", Offset = "0x629C860", VA = "0x18629D460")]
	internal FKIJPOFAOED(FGMCJCFGAPG GGEOHCCNMAF, BNGAGHFEKJK FCOLEJMPJKO, [Optional] Guid? CEMPKOIGLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x59A8210", Offset = "0x59A7610", VA = "0x1859A8210")]
	public FKIJPOFAOED FFNMIABPDBN(ABMIDKAKKGN CJFCIOOMJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x629D390", Offset = "0x629C790", VA = "0x18629D390", Slot = "4")]
	protected override void AANLFGAHHLP(OCJBGBEKDGN LMJAPBNMKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public class BFAAFEKANMA : MOPLABCEHIA<BFAAFEKANMA>
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	internal enum FIIGDJHHNGO
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
	private struct BDOLCCNBHCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public AsyncTaskMethodBuilder<KLJJBFIAHEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public BFAAFEKANMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private TaskAwaiter<KLJJBFIAHEC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x6294320", Offset = "0x6293720", VA = "0x186294320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x62946D0", Offset = "0x6293AD0", VA = "0x1862946D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private FIIGDJHHNGO MFNPOEKHKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private string CNEAGNBNMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private NNDEIDFMMBL CJFCIOOMJGN;

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x6294A60", Offset = "0x6293E60", VA = "0x186294A60")]
	internal BFAAFEKANMA(FGMCJCFGAPG GGEOHCCNMAF, BNGAGHFEKJK FCOLEJMPJKO, [Optional] Guid? CEMPKOIGLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x6294A10", Offset = "0x6293E10", VA = "0x186294A10")]
	public BFAAFEKANMA OBACDJIDBLE(string PJFLKEHKFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x6294A40", Offset = "0x6293E40", VA = "0x186294A40")]
	public BFAAFEKANMA PJGODDDCPOI(bool BHPHKPDKJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x62948B0", Offset = "0x6293CB0", VA = "0x1862948B0")]
	public BFAAFEKANMA BIKEFNKKKEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x6294740", Offset = "0x6293B40", VA = "0x186294740", Slot = "4")]
	protected override void AANLFGAHHLP(OCJBGBEKDGN LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x62948E0", Offset = "0x6293CE0", VA = "0x1862948E0", Slot = "5")]
	[AsyncStateMachine(typeof(BDOLCCNBHCD))]
	public override Task<KLJJBFIAHEC> DAMIPHCJHLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x62949D0", Offset = "0x6293DD0", VA = "0x1862949D0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<KLJJBFIAHEC> GFNIKCFOJAP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal static class HAFHNDOCBBM
{
	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x62A01A0", Offset = "0x629F5A0", VA = "0x1862A01A0")]
	public static void OCNEPMPFEAJ(this BDPINNBKCPB EOOOFHFMIJO, BDKFBCEFMIP AMAJGOGOANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x62A02F0", Offset = "0x629F6F0", VA = "0x1862A02F0")]
	public static void OJBIDCCEMKB(this BDKFBCEFMIP AMBGDFJLCDH, [Optional] string LMJAPBNMKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
public static class LJLGGLBCKNN
{
	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x62A7470", Offset = "0x62A6870", VA = "0x1862A7470")]
	public static IGNOFONIPFC NKIGIIOCHOI(this JBGCEAPPCLE ALKOHALIMIA)
	{
		return default(IGNOFONIPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x62A73C0", Offset = "0x62A67C0", VA = "0x1862A73C0")]
	public static JBGCEAPPCLE HODNLJAANJE(this IGNOFONIPFC JIAEPNDGPDF)
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
			public ILLGLLDLALE ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000692")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000693")]
			public ILLGLLDLALE HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private static ILLGLLDLALE[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private Dictionary<ILLGLLDLALE, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x62AD280", Offset = "0x62AC680", VA = "0x1862AD280")]
		public bool CIDPIMANECF(ILLGLLDLALE EBPNLHHPBLK, [Out] ResultConfig DAHGDHMNEHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x62AD2F0", Offset = "0x62AC6F0", VA = "0x1862AD2F0")]
		public ResultConfig FMHEGELBCBG(ILLGLLDLALE GDMNFOHPCNM, [Optional] HashSet<ILLGLLDLALE> FDNAGNHEPBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x62AD990", Offset = "0x62ACD90", VA = "0x1862AD990", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x62AD430", Offset = "0x62AC830", VA = "0x1862AD430", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x835CD0", Offset = "0x8350D0", VA = "0x180835CD0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class DGPLABLMMEK
{
	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x6299080", Offset = "0x6298480", VA = "0x186299080")]
	[DCEDJGMCFCN(IIPPAMCLFBJ.GameOnly)]
	private static void PODIJJHNPLH(BFGBHKPNKEI AFJFOILCBOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public interface BJHHJKOCPBD : IEquatable<BJHHJKOCPBD>
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	DateTime PDEHNPBNKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HINDGONNMFG();

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JMHOEICDEGM(long BLPLCJENHDJ, long CAHHMNIGLJL, [Out] BLOPIEONCGA BNLKEIJBFNK);
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
internal class LHBGJBMANJL : NMPPFLAPGBK
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class ELGLCKCENOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public ANDGBBKHDNM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ELGLCKCENOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x629B4F0", Offset = "0x629A8F0", VA = "0x18629B4F0")]
		internal object PGMBOJGGFPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private readonly ICDMJJPCENE APIKPKBMOBJ;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<BJHHJKOCPBD> EMFOCNGKLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x62A68B0", Offset = "0x62A5CB0", VA = "0x1862A68B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x62A6800", Offset = "0x62A5C00", VA = "0x1862A6800", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	[UnityEngine.Scripting.Preserve]
	public LHBGJBMANJL([LMAFJMDCBJO(null)] ICDMJJPCENE APIKPKBMOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x62A6A90", Offset = "0x62A5E90", VA = "0x1862A6A90", Slot = "6")]
	public bool LDKKECNLJKC(long BLPLCJENHDJ, long CAHHMNIGLJL, BLOPIEONCGA BNLKEIJBFNK, ANDGBBKHDNM CNBEKNILNAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x17C7CB0", Offset = "0x17C70B0", VA = "0x1817C7CB0")]
	private void ONLHGKEHJJI(BJHHJKOCPBD IFNJMAAKBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x62A6E20", Offset = "0x62A6220", VA = "0x1862A6E20", Slot = "7")]
	public bool PALDBENLOMO(long BLPLCJENHDJ, long CAHHMNIGLJL, [Out] BJHHJKOCPBD CIOPFHLILOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x62A6D70", Offset = "0x62A6170", VA = "0x1862A6D70", Slot = "8")]
	public bool MHNNIDONKCP(long BLPLCJENHDJ, long CAHHMNIGLJL, ANDGBBKHDNM CNBEKNILNAO, [Out] BJHHJKOCPBD CIOPFHLILOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x62A6F90", Offset = "0x62A6390", VA = "0x1862A6F90")]
	private void PINPEIIFHAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x62A6960", Offset = "0x62A5D60", VA = "0x1862A6960", Slot = "9")]
	public void KMICJDKNJMA(long BLPLCJENHDJ, long CAHHMNIGLJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal abstract class CNBDMHENMEJ : ICDMJJPCENE
{
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	protected enum GNBCANDDJFC : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class BNAIDJAOBEL : IEnumerable<BJHHJKOCPBD>, IEnumerable, IEnumerator<BJHHJKOCPBD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private BJHHJKOCPBD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public CNBDMHENMEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private ANDGBBKHDNM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public ANDGBBKHDNM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private BJHHJKOCPBD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public BNAIDJAOBEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x62966F0", Offset = "0x6295AF0", VA = "0x1862966F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x62969D0", Offset = "0x6295DD0", VA = "0x1862969D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x6296920", Offset = "0x6295D20", VA = "0x186296920", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BJHHJKOCPBD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x6296920", Offset = "0x6295D20", VA = "0x186296920", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class HCJJAHLNBPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public ANDGBBKHDNM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HCJJAHLNBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x62A0A80", Offset = "0x629FE80", VA = "0x1862A0A80")]
		internal object HCPLCEFMPOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class AKGIFCHFOGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public CNBDMHENMEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public AKGIFCHFOGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x62942A0", Offset = "0x62936A0", VA = "0x1862942A0")]
		internal void INBNNGBLMIB(NGKJHPBODBF.MLHEBAFEEEE ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	protected readonly string IPACANEBGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private readonly object ONDFGCAJLCJ;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract OEEDAEONJFB MHMAAMAMELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x6298C90", Offset = "0x6298090", VA = "0x186298C90")]
	protected CNBDMHENMEJ([CanBeNull] string JDBAAIDAOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x62986A0", Offset = "0x6297AA0", VA = "0x1862986A0", Slot = "5")]
	public bool IDHIGLJGHKK(long BLPLCJENHDJ, long CAHHMNIGLJL, ANDGBBKHDNM CNBEKNILNAO, [Out] BJHHJKOCPBD IFNJMAAKBKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x6298610", Offset = "0x6297A10", VA = "0x186298610", Slot = "6")]
	[IteratorStateMachine(typeof(BNAIDJAOBEL))]
	public IEnumerable<BJHHJKOCPBD> CAGICGNBNKI(ANDGBBKHDNM CNBEKNILNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void OHKKADOLCBB(Stream PAAHDMJBLPF, long BLPLCJENHDJ, long CAHHMNIGLJL, BLOPIEONCGA BNLKEIJBFNK);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool EDPPHKBNBGN(Stream BHFNNMNIGEF, long BLPLCJENHDJ, long CAHHMNIGLJL, DINMBCMBILO HGKDHODJCCF, [Out] BLOPIEONCGA BNLKEIJBFNK);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x6298290", Offset = "0x6297690", VA = "0x186298290", Slot = "7")]
	public BJHHJKOCPBD BKDOFDKGMNJ(long BLPLCJENHDJ, long CAHHMNIGLJL, BLOPIEONCGA BNLKEIJBFNK, ANDGBBKHDNM CNBEKNILNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo LPKIDIHCAHK(long BLPLCJENHDJ, long CAHHMNIGLJL, ANDGBBKHDNM CNBEKNILNAO, GNBCANDDJFC KDNIDGNGIFJ);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo HPAAGCHGOHM(ANDGBBKHDNM CNBEKNILNAO, GNBCANDDJFC KDNIDGNGIFJ);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x6298C20", Offset = "0x6298020", VA = "0x186298C20")]
	protected void PEEDLCGELEO(NGKJHPBODBF.MLHEBAFEEEE GIJGDNKJFPH, string AJGMBAOCDMI, FileInfo HNPFJFOCKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x6298890", Offset = "0x6297C90", VA = "0x186298890")]
	internal bool PAFAMGOBKMK(FileInfo GKMHEOCICEF, long BLPLCJENHDJ, long CAHHMNIGLJL, [Out] BLOPIEONCGA BNLKEIJBFNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private void KOIAOKNCPOK(Exception ACDFONNILGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
internal class AGHHLNNBCNA : CNBDMHENMEJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public override OEEDAEONJFB MHMAAMAMELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xA535A0", Offset = "0xA529A0", VA = "0x180A535A0", Slot = "8")]
		get
		{
			return default(OEEDAEONJFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x62941E0", Offset = "0x62935E0", VA = "0x1862941E0")]
	public AGHHLNNBCNA([Optional] string JDBAAIDAOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x6293ED0", Offset = "0x62932D0", VA = "0x186293ED0")]
	private void MPMKBHGHKIG(ANDGBBKHDNM CNBEKNILNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x6293F50", Offset = "0x6293350", VA = "0x186293F50", Slot = "9")]
	internal override void OHKKADOLCBB(Stream PAAHDMJBLPF, long BLPLCJENHDJ, long CAHHMNIGLJL, BLOPIEONCGA BNLKEIJBFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x6293680", Offset = "0x6292A80", VA = "0x186293680", Slot = "10")]
	internal override bool EDPPHKBNBGN(Stream BHFNNMNIGEF, long BLPLCJENHDJ, long CAHHMNIGLJL, DINMBCMBILO HGKDHODJCCF, [Out] BLOPIEONCGA BNLKEIJBFNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x6293DE0", Offset = "0x62931E0", VA = "0x186293DE0", Slot = "11")]
	protected override FileInfo LPKIDIHCAHK(long BLPLCJENHDJ, long CAHHMNIGLJL, ANDGBBKHDNM CNBEKNILNAO, GNBCANDDJFC KDNIDGNGIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x6293CD0", Offset = "0x62930D0", VA = "0x186293CD0", Slot = "12")]
	protected override DirectoryInfo HPAAGCHGOHM(ANDGBBKHDNM CNBEKNILNAO, GNBCANDDJFC KDNIDGNGIFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal sealed class BKEFMILHFKM : CNBDMHENMEJ
{
	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	private static readonly byte[] IHHOPACLNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	private readonly byte[] NCBIBJECNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	private readonly byte[] DAJBMLCGPGO;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public override OEEDAEONJFB MHMAAMAMELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x52D4F30", Offset = "0x52D4330", VA = "0x1852D4F30", Slot = "8")]
		get
		{
			return default(OEEDAEONJFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x6296310", Offset = "0x6295710", VA = "0x186296310")]
	public BKEFMILHFKM([Optional] string JDBAAIDAOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x6295FC0", Offset = "0x62953C0", VA = "0x186295FC0", Slot = "9")]
	internal override void OHKKADOLCBB(Stream PAAHDMJBLPF, long BLPLCJENHDJ, long CAHHMNIGLJL, BLOPIEONCGA BNLKEIJBFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x6295490", Offset = "0x6294890", VA = "0x186295490", Slot = "10")]
	internal override bool EDPPHKBNBGN(Stream BHFNNMNIGEF, long BLPLCJENHDJ, long CAHHMNIGLJL, DINMBCMBILO HGKDHODJCCF, [Out] BLOPIEONCGA BNLKEIJBFNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x6295DD0", Offset = "0x62951D0", VA = "0x186295DD0")]
	private void IJJDJLACKIG(byte[] FBMKKLOJFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x6295E90", Offset = "0x6295290", VA = "0x186295E90", Slot = "11")]
	protected override FileInfo LPKIDIHCAHK(long BLPLCJENHDJ, long CAHHMNIGLJL, ANDGBBKHDNM CNBEKNILNAO, GNBCANDDJFC KDNIDGNGIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x6295CC0", Offset = "0x62950C0", VA = "0x186295CC0", Slot = "12")]
	protected override DirectoryInfo HPAAGCHGOHM(ANDGBBKHDNM CNBEKNILNAO, GNBCANDDJFC KDNIDGNGIFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
public enum OEEDAEONJFB : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal class HDLNMFMAMND : ICDMJJPCENE
{
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private sealed class MDJACBHJEJG : IEnumerable<BJHHJKOCPBD>, IEnumerable, IEnumerator<BJHHJKOCPBD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private BJHHJKOCPBD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public HDLNMFMAMND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private ANDGBBKHDNM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public ANDGBBKHDNM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private OEEDAEONJFB[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private IEnumerator<BJHHJKOCPBD> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		private BJHHJKOCPBD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public MDJACBHJEJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x62A9280", Offset = "0x62A8680", VA = "0x1862A9280", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x62A8E50", Offset = "0x62A8250", VA = "0x1862A8E50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x62A9130", Offset = "0x62A8530", VA = "0x1862A9130")]
		private void OGHCJJGAJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x62A9230", Offset = "0x62A8630", VA = "0x1862A9230", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x62A9180", Offset = "0x62A8580", VA = "0x1862A9180", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BJHHJKOCPBD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x62A9180", Offset = "0x62A8580", VA = "0x1862A9180", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private readonly OEEDAEONJFB[] CLNBPIDPNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private readonly Dictionary<OEEDAEONJFB, ICDMJJPCENE> CDMNLKGAKHK;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public OEEDAEONJFB MHMAAMAMELI
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x62A1000", Offset = "0x62A0400", VA = "0x1862A1000", Slot = "4")]
		get
		{
			return default(OEEDAEONJFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x62A1030", Offset = "0x62A0430", VA = "0x1862A1030")]
	[UnityEngine.Scripting.Preserve]
	public HDLNMFMAMND(params ICDMJJPCENE[] DCDHPIDNDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x62A0C90", Offset = "0x62A0090", VA = "0x1862A0C90", Slot = "5")]
	public bool IDHIGLJGHKK(long BLPLCJENHDJ, long CAHHMNIGLJL, ANDGBBKHDNM CNBEKNILNAO, [Out] BJHHJKOCPBD IFNJMAAKBKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x62A0DE0", Offset = "0x62A01E0", VA = "0x1862A0DE0")]
	private void JNCDGKPJNBB(int GLFKEDAJLDL, long BLPLCJENHDJ, long CAHHMNIGLJL, ANDGBBKHDNM CNBEKNILNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x62A0C00", Offset = "0x62A0000", VA = "0x1862A0C00", Slot = "6")]
	[IteratorStateMachine(typeof(MDJACBHJEJG))]
	public IEnumerable<BJHHJKOCPBD> CAGICGNBNKI(ANDGBBKHDNM CNBEKNILNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x62A0B20", Offset = "0x629FF20", VA = "0x1862A0B20", Slot = "7")]
	public BJHHJKOCPBD BKDOFDKGMNJ(long BLPLCJENHDJ, long CAHHMNIGLJL, BLOPIEONCGA BNLKEIJBFNK, ANDGBBKHDNM CNBEKNILNAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal static class HHMHFJLPHEA
{
	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x62A1410", Offset = "0x62A0810", VA = "0x1862A1410")]
	internal static byte[] GCAFGOLOHJD(byte[] FBMKKLOJFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x62A14D0", Offset = "0x62A08D0", VA = "0x1862A14D0")]
	public static void GMALHIONACA(Stream BKMMHPCMIEO, byte[] ELEOGKNACIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x62A1550", Offset = "0x62A0950", VA = "0x1862A1550")]
	public static bool JIDIHEMBMBG(Stream BKMMHPCMIEO, long FEPHEPBMPHG, DINMBCMBILO LKHLKLEMONJ, [Out] byte[] CGLEKMLEPDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal sealed class EAILHMFCHCI : BJHHJKOCPBD, IEquatable<BJHHJKOCPBD>, IEquatable<EAILHMFCHCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private readonly CNBDMHENMEJ DNHIPHICKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	public readonly FileInfo GHBOIPIAGFG;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public OEEDAEONJFB MHMAAMAMELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x6299AF0", Offset = "0x6298EF0", VA = "0x186299AF0", Slot = "9")]
		get
		{
			return default(OEEDAEONJFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DateTime PDEHNPBNKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x6299640", Offset = "0x6298A40", VA = "0x186299640", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x6299BD0", Offset = "0x6298FD0", VA = "0x186299BD0")]
	public EAILHMFCHCI(CNBDMHENMEJ OBCLJLNACOK, FileInfo GKMHEOCICEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x6299B20", Offset = "0x6298F20", VA = "0x186299B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x62999F0", Offset = "0x6298DF0", VA = "0x1862999F0", Slot = "5")]
	public void HINDGONNMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x6299AB0", Offset = "0x6298EB0", VA = "0x186299AB0", Slot = "6")]
	public bool JMHOEICDEGM(long BLPLCJENHDJ, long CAHHMNIGLJL, [Out] BLOPIEONCGA BNLKEIJBFNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x62996D0", Offset = "0x6298AD0", VA = "0x1862996D0", Slot = "7")]
	public bool Equals(BJHHJKOCPBD KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x62997B0", Offset = "0x6298BB0", VA = "0x1862997B0", Slot = "8")]
	public bool Equals(EAILHMFCHCI KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x6299870", Offset = "0x6298C70", VA = "0x186299870", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x6299960", Offset = "0x6298D60", VA = "0x186299960", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public delegate void DINMBCMBILO(NGKJHPBODBF.MLHEBAFEEEE PKOGKBEPHEI, string LMJAPBNMKLG);
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal interface ICDMJJPCENE
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	OEEDAEONJFB MHMAAMAMELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IDHIGLJGHKK(long BLPLCJENHDJ, long CAHHMNIGLJL, ANDGBBKHDNM CNBEKNILNAO, [Out] BJHHJKOCPBD IFNJMAAKBKN);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<BJHHJKOCPBD> CAGICGNBNKI(ANDGBBKHDNM CNBEKNILNAO);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BJHHJKOCPBD BKDOFDKGMNJ(long BLPLCJENHDJ, long CAHHMNIGLJL, BLOPIEONCGA BNLKEIJBFNK, ANDGBBKHDNM CNBEKNILNAO);
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
